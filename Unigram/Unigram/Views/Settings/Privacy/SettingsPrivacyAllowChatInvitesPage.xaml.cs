﻿using Unigram.ViewModels.Settings;
using Unigram.ViewModels.Settings.Privacy;
using Windows.UI.Xaml;

namespace Unigram.Views.Settings.Privacy
{
    public sealed partial class SettingsPrivacyAllowChatInvitesPage : HostedPage
    {
        public SettingsPrivacyAllowChatInvitesViewModel ViewModel => DataContext as SettingsPrivacyAllowChatInvitesViewModel;

        public SettingsPrivacyAllowChatInvitesPage()
        {
            InitializeComponent();
            Title = Strings.Resources.GroupsAndChannels;
        }

        #region Binding

        private Visibility ConvertNever(PrivacyValue value)
        {
            return value is PrivacyValue.AllowAll or PrivacyValue.AllowContacts ? Visibility.Visible : Visibility.Collapsed;
        }

        private Visibility ConvertAlways(PrivacyValue value)
        {
            return value is PrivacyValue.AllowContacts or PrivacyValue.DisallowAll ? Visibility.Visible : Visibility.Collapsed;
        }

        #endregion

    }
}
