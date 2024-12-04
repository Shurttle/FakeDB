using Android.Media;

namespace FakeDB
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemListPage), typeof(ItemListPage));
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
        }
    }
}
