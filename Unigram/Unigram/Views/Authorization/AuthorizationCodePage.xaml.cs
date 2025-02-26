﻿using System;
using Telegram.Td.Api;
using Unigram.Common;
using Unigram.ViewModels.Authorization;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Unigram.Views.Authorization
{
    public sealed partial class AuthorizationCodePage : Page
    {
        public AuthorizationCodeViewModel ViewModel => DataContext as AuthorizationCodeViewModel;

        public AuthorizationCodePage()
        {
            InitializeComponent();
            Window.Current.SetTitleBar(TitleBar);
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            ViewModel.PropertyChanged += OnPropertyChanged;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            ViewModel.PropertyChanged -= OnPropertyChanged;
        }

        private void OnPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case "SENT_CODE_INVALID":
                    VisualUtilities.ShakeView(PrimaryInput);
                    break;
            }
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            PrimaryInput.Focus(FocusState.Keyboard);
        }

        #region Binding

        private Uri ConvertAnimation(AuthenticationCodeInfo codeInfo)
        {
            return codeInfo?.Type switch
            {
                AuthenticationCodeTypeFragment => new Uri("ms-appx:///Assets/Animations/AuthorizationStateWaitFragment.tgs"),
                _ => new Uri("ms-appx:///Assets/Animations/AuthorizationStateWaitCode.tgs")
            };
        }

        private string ConvertType(AuthenticationCodeInfo codeInfo)
        {
            return codeInfo?.Type switch
            {
                AuthenticationCodeTypeTelegramMessage => Strings.Resources.SentAppCode,
                AuthenticationCodeTypeFragment => string.Format(Strings.Resources.SentFragmentCode, PhoneNumber.Format(codeInfo.PhoneNumber)),
                AuthenticationCodeTypeSms => string.Format(Strings.Resources.SentSmsCode, PhoneNumber.Format(codeInfo.PhoneNumber)),
                _ => string.Empty
            };
        }

        private string ConvertNext(AuthenticationCodeInfo codeInfo, string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                return codeInfo?.Type switch
                {
                    AuthenticationCodeTypeFragment => Strings.Resources.OpenFragment,
                    _ => Strings.Resources.OK
                };
            }

            return Strings.Resources.OK;
        }

        #endregion

    }
}
