using FakeDB.Model;

namespace FakeDB;
[QueryProperty(nameof(ItemId), "itemId")]
public partial class ItemDetailPage : ContentPage
{
    public int ItemId { get; set; }
    public Item Item { get; set; }

    public ItemDetailPage()
	{
		InitializeComponent();
	}
    protected override void OnAppearing()
    {
        base.OnAppearing();
        Item = FakeDatabase.Items.FirstOrDefault(i => i.Id == ItemId);
        BindingContext = this;
    }

    private async void OnGoBackClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}