﻿using System.Collections.Generic;
using System.Linq;
using Telegram.Td.Api;
using Unigram.Common;
using Unigram.Controls;
using Unigram.Controls.Cells;
using Unigram.Services;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Unigram.Views.Popups
{
    public sealed partial class VideoChatAliasesPopup : ContentPopup
    {
        private readonly IClientService _clientService;

        public VideoChatAliasesPopup(IClientService clientService, Chat chat, bool canSchedule, IList<MessageSender> senders)
        {
            InitializeComponent();

            _clientService = clientService;
            var already = senders.FirstOrDefault(x => x.AreTheSame(chat.VideoChat.DefaultParticipantId));
            var channel = chat.Type is ChatTypeSupergroup super && super.IsChannel;

            Title = chat.VideoChat.GroupCallId != 0
                ? Strings.Resources.VoipGroupDisplayAs
                : channel
                ? Strings.Resources.StartVoipChannelTitle
                : Strings.Resources.VoipGroupStartAs;

            MessageLabel.Text = channel
                ? Strings.Resources.VoipGroupStartAsInfo
                : Strings.Resources.VoipGroupStartAsInfoGroup;

            List.ItemsSource = senders;
            List.SelectedItem = already ?? senders.FirstOrDefault();

            Schedule.Content = channel
                ? Strings.Resources.VoipChannelScheduleVoiceChat
                : Strings.Resources.VoipGroupScheduleVoiceChat;

            Schedule.Visibility = canSchedule
                ? Visibility.Visible
                : Visibility.Collapsed;

            if (clientService.TryGetSupergroup(chat, out Supergroup supergroup))
            {
                StartWith.Visibility = canSchedule && supergroup.Status is ChatMemberStatusCreator
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            }
            else if (clientService.TryGetBasicGroup(chat, out BasicGroup basicGroup))
            {
                StartWith.Visibility = canSchedule && basicGroup.Status is ChatMemberStatusCreator
                    ? Visibility.Visible
                    : Visibility.Collapsed;
            }
            else
            {
                StartWith.Visibility = Visibility.Collapsed;
            }

            PrimaryButtonText = Strings.Resources.Start;
            SecondaryButtonText = Strings.Resources.Close;
        }

        public bool IsScheduleSelected { get; private set; }

        public bool IsStartWithSelected { get; private set; }

        public MessageSender SelectedSender => List.SelectedItem as MessageSender;

        #region Recycle

        private void OnChoosingItemContainer(ListViewBase sender, ChoosingItemContainerEventArgs args)
        {
            if (args.ItemContainer == null)
            {
                args.ItemContainer = new MultipleListViewItem(false);
                args.ItemContainer.Style = List.ItemContainerStyle;
                args.ItemContainer.ContentTemplate = List.ItemTemplate;
            }

            args.IsContainerPrepared = true;
        }

        private void OnContainerContentChanging(ListViewBase sender, ContainerContentChangingEventArgs args)
        {
            if (args.InRecycleQueue)
            {
                return;
            }
            else if (args.ItemContainer.ContentTemplateRoot is ChatShareCell content)
            {
                content.UpdateState(false, false);
                content.UpdateMessageSender(_clientService, args, OnContainerContentChanging);
            }
        }

        #endregion

        private void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (List.SelectedItem is MessageSender)
            {
                //if (_clientService.TryGetUser(messageSender, out User user))
                //{
                //    PrimaryButtonText = string.Format(Strings.Resources.VoipGroupContinueAs, user.GetFullName());
                //}
                //else if (_clientService.TryGetChat(messageSender, out Chat chat))
                //{
                //    PrimaryButtonText = string.Format(Strings.Resources.VoipGroupContinueAs, _clientService.GetTitle(chat));
                //}

                IsPrimaryButtonEnabled = true;
            }
            else
            {
                IsPrimaryButtonEnabled = false;
            }
        }

        private void Schedule_Click(object sender, RoutedEventArgs e)
        {
            IsScheduleSelected = true;
            Hide(ContentDialogResult.Primary);
        }

        private void StartWith_Click(object sender, RoutedEventArgs e)
        {
            IsStartWithSelected = true;
            Hide(ContentDialogResult.Primary);
        }
    }
}
