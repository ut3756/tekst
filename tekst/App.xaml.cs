namespace tekst
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = new Window();
            window.MinimumHeight = 900;
            window.MaximumHeight = 900;
            window.MinimumWidth = 650;
            window.MaximumWidth = 650;

            window.Page = new AppShell();
            return window;
        }
    }
}
