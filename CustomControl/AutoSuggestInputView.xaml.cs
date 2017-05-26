using Xamarin.Forms;

namespace CustomControl
{
    public partial class AutoSuggestInputView : ContentView
    {
        public AutoSuggestInputView()
        {
            InitializeComponent();
            BindingContext = new AutoSuggestInputViewModel();
        }
    }
}
