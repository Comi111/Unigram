﻿using System;
using System.Threading.Tasks;
using Unigram.Controls;
using Unigram.Services;
using Windows.Devices.Enumeration;
using Windows.Media.Capture;
using Windows.Media.Devices;
using Windows.System;
using Windows.System.Profile;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Unigram.Common
{
    public class MediaDeviceWatcher
    {
        private readonly DeviceClass _class;
        private readonly DeviceWatcher _watcher;

        private readonly Action<string> _setDevice;

        private string _currentDevice;
        private bool _stopped = true;

        public MediaDeviceWatcher(DeviceClass deviceClass, Action<string> setDevice)
        {
            _class = deviceClass;
            _setDevice = setDevice;

            try
            {
                _watcher = DeviceInformation.CreateWatcher(deviceClass);
                _watcher.Added += OnAdded;
                _watcher.Removed += OnRemoved;
            }
            catch { }
        }

        public void Start()
        {
            if (_watcher == null)
            {
                return;
            }

            if (_watcher.Status == DeviceWatcherStatus.Created)
            {
                _watcher.Start();
            }

            _stopped = false;
        }

        public void Stop()
        {
            _stopped = true;
        }

        private void OnAdded(DeviceWatcher sender, DeviceInformation args)
        {
            if (_stopped || _watcher.Status != DeviceWatcherStatus.EnumerationCompleted)
            {
                return;
            }

            var defaultRole = GetDefault();
            var storedRole = GetStored();

            if (args.Id == storedRole || args.Id == defaultRole && string.IsNullOrEmpty(storedRole))
            {
                _setDevice(_currentDevice = args.Id);
            }
        }

        private async void OnRemoved(DeviceWatcher sender, DeviceInformationUpdate args)
        {
            if (_stopped || _watcher.Status != DeviceWatcherStatus.EnumerationCompleted)
            {
                return;
            }

            if (args.Id == _currentDevice)
            {
                _setDevice(_currentDevice = await GetDeviceAsync(GetDefault()));
            }
        }

        public void Set(string deviceId)
        {
            SetStored(deviceId);

            if (string.IsNullOrEmpty(deviceId))
            {
                deviceId = GetDefault();
            }

            if (_currentDevice != deviceId)
            {
                _currentDevice = deviceId;
                _setDevice(deviceId);
            }
        }

        public string Get()
        {
            return _currentDevice ?? GetStored();
        }

        public async Task<string> GetAndUpdateAsync()
        {
            return _currentDevice = await GetDeviceAsync(GetStored());
        }

        private async Task<string> GetDeviceAsync(string deviceId)
        {
            if (string.IsNullOrEmpty(deviceId))
            {
                return GetDefault();
            }

            try
            {
                var selected = await DeviceInformation.CreateFromIdAsync(deviceId);
                return selected.Id;
            }
            catch
            {
                return GetDefault();
            }
        }

        private string GetDefault()
        {
            switch (_class)
            {
                case DeviceClass.AudioCapture:
                    return MediaDevice.GetDefaultAudioCaptureId(AudioDeviceRole.Communications);
                case DeviceClass.AudioRender:
                    return MediaDevice.GetDefaultAudioRenderId(AudioDeviceRole.Communications);
                case DeviceClass.VideoCapture:
                default:
                    return Constants.DefaultDeviceId;
            }
        }

        private string GetStored()
        {
            switch (_class)
            {
                case DeviceClass.AudioCapture:
                    return SettingsService.Current.VoIP.InputDevice;
                case DeviceClass.AudioRender:
                    return SettingsService.Current.VoIP.OutputDevice;
                case DeviceClass.VideoCapture:
                default:
                    return SettingsService.Current.VoIP.VideoDevice;
            }
        }

        private void SetStored(string deviceId)
        {
            switch (_class)
            {
                case DeviceClass.AudioCapture:
                    SettingsService.Current.VoIP.InputDevice = deviceId;
                    break;
                case DeviceClass.AudioRender:
                    SettingsService.Current.VoIP.OutputDevice = deviceId;
                    break;
                case DeviceClass.VideoCapture:
                default:
                    SettingsService.Current.VoIP.VideoDevice = deviceId;
                    break;
            }
        }

        #region Device Access

        public static async Task<bool> CheckAccessAsync(bool video, ElementTheme requestedTheme = ElementTheme.Default)
        {
            var audioPermission = await CheckDeviceAccessAsync(true, video, requestedTheme);
            if (audioPermission == false)
            {
                return false;
            }

            if (video)
            {
                var videoPermission = await CheckDeviceAccessAsync(false, true, requestedTheme);
                if (videoPermission == false)
                {
                    return false;
                }
            }

            return true;
        }

        private static async Task<bool> CheckDeviceAccessAsync(bool audio, bool video, ElementTheme requestedTheme = ElementTheme.Default)
        {
            // For some reason, as far as I understood, CurrentStatus is always Unspecified on Xbox
            if (string.Equals(AnalyticsInfo.VersionInfo.DeviceFamily, "Windows.Xbox"))
            {
                return true;
            }

            var access = DeviceAccessInformation.CreateFromDeviceClass(audio ? DeviceClass.AudioCapture : DeviceClass.VideoCapture);
            if (access.CurrentStatus == DeviceAccessStatus.Unspecified)
            {
                MediaCapture capture = null;
                bool success = false;
                try
                {
                    capture = new MediaCapture();
                    var settings = new MediaCaptureInitializationSettings();
                    settings.StreamingCaptureMode = video
                        ? StreamingCaptureMode.AudioAndVideo
                        : StreamingCaptureMode.Audio;
                    await capture.InitializeAsync(settings);
                    success = true;
                }
                catch { }
                finally
                {
                    if (capture != null)
                    {
                        capture.Dispose();
                    }
                }

                return success;
            }
            else if (access.CurrentStatus != DeviceAccessStatus.Allowed)
            {
                var message = audio
                    ? video
                    ? Strings.Resources.PermissionNoAudio
                    : Strings.Resources.PermissionNoAudioVideo
                    : Strings.Resources.PermissionNoCamera;

                var popup = new MessagePopup
                {
                    Title = Strings.Resources.AppName,
                    Message = message,
                    PrimaryButtonText = Strings.Resources.Settings,
                    SecondaryButtonText = Strings.Resources.OK,
                    RequestedTheme = requestedTheme
                };

                var confirm = await popup.ShowQueuedAsync();
                if (confirm == ContentDialogResult.Primary)
                {
                    await Launcher.LaunchUriAsync(new Uri("ms-settings:appsfeatures-app"));
                }

                return false;
            }

            return true;
        }

        #endregion
    }
}
