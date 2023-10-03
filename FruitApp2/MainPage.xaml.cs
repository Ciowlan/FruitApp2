namespace FruitApp2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {   
            List<Fruit> list = new List<Fruit>() 
            { 
            new Fruit() {Name="Apple",ImageUrl="apple.png",Description="This is an apple"},
            new Fruit() {Name="Orange",ImageUrl="orange.png",Description="This is an orange"},
            new Fruit() {Name="Banana",ImageUrl="banana.png",Description="This is an banana"},
            new Fruit() {Name="Kiwi",ImageUrl="kiwi.png",Description="This is an kiwi"},
            new Fruit() {Name="Strawberry",ImageUrl="strawberry.png",Description="This is an strawberry"},
            new Fruit() {Name="Pineapple",ImageUrl="pineapple.png",Description="This is an pineapple"},
            new Fruit() {Name="Watermelon",ImageUrl="watermelon.png",Description="This is an watermelon"},
            new Fruit() {Name="Grapes",ImageUrl="grape.png",Description="This is an grapes"},
            new Fruit() {Name="Guava",ImageUrl="grape.png",Description="This is an grapes"},
            new Fruit() {Name="Pear",ImageUrl="pear.png",Description="This is an pear"},
            new Fruit() {Name="Peach",ImageUrl="peach.png",Description="This is an grapeachpes"},
            new Fruit() {Name="Coconut",ImageUrl="coconut.png",Description="This is an coconut"},
            new Fruit() {Name="Apricot",ImageUrl="apricot.png",Description="This is an apricot"},
            new Fruit() {Name="Mango",ImageUrl="mango.png",Description="This is an grapes"},
            new Fruit() {Name="Pomegranate",ImageUrl="pomegranate.png",Description="This is an pomegranate"},
            new Fruit() {Name="Melon",ImageUrl="melon.png",Description="This is an melon"},
            };
            InitializeComponent();
            FruitApp2.ItemsSource = list;
        }

        

        private void FruitApp2_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            var selectedItem = e.SelectedItem as Fruit;
            Navigation.PushAsync(new FruitDetailed(selectedItem.Name, selectedItem.ImageUrl, selectedItem.Description));

        }
    }
}