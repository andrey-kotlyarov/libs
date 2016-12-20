namespace DemoCatel.ViewModels
{
    using Catel.MVVM;
    using System.Threading.Tasks;
    using System.Windows;



    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
        }

        public override string Title { get { return "DemoCatel v1.0"; } }

        public string MyLabel { get { return "My content here"; } }

        /*
        public string MyTxt
        {
            get { return (string)GetValue(MyTxtProperty); }
            set { SetValue(MyTxtProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyTxt.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty MyTxtProperty =
            DependencyProperty.Register("MyTxt", typeof(string), typeof(MainWindowViewModel), new PropertyMetadata(""));

        */








        // TODO: Register models with the vmpropmodel codesnippet
        // TODO: Register view model properties with the vmprop or vmpropviewmodeltomodel codesnippets
        // TODO: Register commands with the vmcommand or vmcommandwithcanexecute codesnippets

        protected override async Task InitializeAsync()
        {
            await base.InitializeAsync();

            // TODO: subscribe to events here
        }

        protected override async Task CloseAsync()
        {
            // TODO: unsubscribe from events here

            await base.CloseAsync();
        }
    }
}
