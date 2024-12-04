using FakeDB.Model;

namespace FakeDB;

public partial class NewPage1 : ContentPage
{
    public List<Item> Items { get; set; }
    public NewPage1()
	{
		InitializeComponent();
        Items = FakeDatabase.Items;
        BindingContext = this;
    }
    public Command<int> NavigateCommand => new Command<int>(async (id) =>
    {
        await Shell.Current.GoToAsync($"{nameof(ItemDetailPage)}?itemId={id}");
    });
}