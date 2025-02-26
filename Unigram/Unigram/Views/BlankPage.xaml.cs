﻿using System.Linq;
using Telegram.Td.Api;
using Unigram.Services;
using Unigram.Views.Authorization;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Unigram.Views
{
    public sealed partial class BlankPage : Page
    {
        public BlankPage()
        {
            InitializeComponent();
            DataContext = new object();

            NavigationCacheMode = NavigationCacheMode.Required;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (e.NavigationMode == NavigationMode.Back && Frame.ForwardStack.Any(x => x.SourcePageType == typeof(AuthorizationPage)))
            {
                TLContainer.Current.Resolve<IClientService>().Send(new Destroy());
            }
        }
    }
}
