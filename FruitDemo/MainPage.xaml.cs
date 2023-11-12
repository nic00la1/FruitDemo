using FruitDemo.Models;

namespace FruitDemo
{
    public partial class MainPage : ContentPage
    {
        public List<FruitInformation> PapayaInfo { get; set; }

        public MainPage()
        {
            InitializeComponent();
            PapayaInfo = new List<FruitInformation>();

    }
}