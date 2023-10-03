using System.Collections.Generic;

namespace FruitApp2;

public partial class FruitDetailed : ContentPage
{
	public FruitDetailed(string name, string imageUrl, string description)
	{
        InitializeComponent();
        fruitImg.Source = imageUrl;
        fruitName.Text = name;
        fruitDescription.Text = description;
    }

}