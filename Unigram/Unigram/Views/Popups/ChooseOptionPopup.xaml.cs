﻿using System.Collections.Generic;
using System.Linq;
using Unigram.Controls;
using Unigram.Navigation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Unigram.Views.Popups
{
    public sealed partial class ChooseOptionPopup : ContentPopup
    {
        public ChooseOptionPopup(IEnumerable<ChooseOptionItem> options)
        {
            InitializeComponent();

            var first = options.FirstOrDefault().Value;
            var last = options.LastOrDefault().Value;

            foreach (var option in options)
            {
                var radio = new RadioButton();
                radio.Checked += Radio_Checked;
                radio.Content = option.Text;
                radio.Tag = option;
                radio.IsChecked = option.IsChecked;
                radio.Style = App.Current.Resources["SettingsRadioButtonStyle"] as Style;

                LayoutRoot.Items.Add(radio);
            }
        }

        private void Radio_Checked(object sender, RoutedEventArgs e)
        {
            var radio = sender as RadioButton;
            var item = radio.Tag as ChooseOptionItem;

            LayoutRoot.Footer = item.Footer ?? string.Empty;
        }

        public object SelectedIndex { get; private set; }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            SelectedIndex = ((ChooseOptionItem)LayoutRoot.Items.OfType<RadioButton>().FirstOrDefault(x => x.IsChecked == true)?.Tag)?.Value;
        }

        private void ContentDialog_SecondaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
        }
    }

    public class ChooseOptionItem
    {
        public ChooseOptionItem(object value, string text, bool check)
        {
            Value = value;
            Text = text;
            IsChecked = check;
        }

        public object Value { get; set; }
        public string Text { get; set; }
        public bool IsChecked { get; set; }

        public string Footer { get; set; }
    }

    public class SettingsOptionItem : BindableBase
    {
        public SettingsOptionItem(string text)
        {
            Text = text;
        }

        public string Text { get; set; }

        private bool _isChecked;
        public bool IsChecked
        {
            get => _isChecked;
            set => Set(ref _isChecked, value);
        }
    }

    public class SettingsOptionItem<T> : SettingsOptionItem
    {
        public SettingsOptionItem(T value, string text)
            : base(text)
        {
            Value = value;
        }

        public T Value { get; set; }
    }
}
