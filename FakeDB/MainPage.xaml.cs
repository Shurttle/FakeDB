﻿namespace FakeDB
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnViewItemsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(ItemListPage));
        }
    }

}
