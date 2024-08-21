namespace Module01Activity02
{
    public partial class MainPage : ContentPage
    {
        public string Firstname { get; set; }
        public Color ColorRed { get; set; }
        public MainPage()
        {
            InitializeComponent();

            Firstname = "Hello, MAUI!";
            ColorRed = Colors.Red;

            this.BindingContext = this;

        }

        private void OnChangedLabelName(object sender, EventArgs e)
        {
            this.Resources["StaticUsername"] = "Peter Butter";
        }

        private void OnChangedLabelNameDynamic(object sender, EventArgs e)
        {
            this.Resources["DynamicUsername"] = "Mr. Juan dela Cruz";
        }

        private void OnChangeBackgroundColor(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.LightGray;
        }

        private void OnChangeBackgroundColorGreen(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.Green;
        }

        private void OnChangeBackgroundColorLBlue(object sender, EventArgs e)
        {
            this.Resources["LocalBackgroundColor"] = Colors.LightBlue;
        }

        private void OnChangeBoxViewColor(object sender, EventArgs e)
        {
            this.Resources["DynamicBoxColor"] = Colors.Red;
        }

    }

}
