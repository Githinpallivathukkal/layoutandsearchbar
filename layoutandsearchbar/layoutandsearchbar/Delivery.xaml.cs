using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace layoutandsearchbar
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Delivery : ContentPage
    {
        ObservableCollection<AnimalModel> animals;
        public Delivery()
        {
            InitializeComponent();
            animals = new ObservableCollection<AnimalModel>
            {
                new AnimalModel
                {
                    Name = "Meal",
                    Image = "meal.jpg",
                    Category = AnimalModel.Group.Land
                },
                new AnimalModel
                {
                    Name = "Berger",
                    Image = "Berger1.jpg",
                    Category = AnimalModel.Group.Land
                },
                new AnimalModel
                {
                    Name = "pizza",
                    Image = "pizza.jpg",
                    Category = AnimalModel.Group.Land
                },
                new AnimalModel
                {
                    Name = "pizza",
                    Image = "pizza1.jpg",
                    Category = AnimalModel.Group.Land
                },
                new AnimalModel
                {
                    Name = "Meal",
                    Image = "meal.jpg",
                    Category = AnimalModel.Group.Land
                },
                new AnimalModel
                {
                    Name = "Berger",
                    Image = "Berger1.jpg",
                    Category = AnimalModel.Group.Land
                },
                new AnimalModel
                {
                    Name = "pizza",
                    Image = "pizza.jpg",
                    Category = AnimalModel.Group.Land
                },
                new AnimalModel
                {
                    Name = "pizza",
                    Image = "pizza1.jpg",
                    Category = AnimalModel.Group.Land
                },
                new AnimalModel
                {
                    Name = "Meal",
                    Image = "meal.jpg",
                    Category = AnimalModel.Group.Land
                },
                new AnimalModel
                {
                    Name = "Berger",
                    Image = "Berger1.jpg",
                    Category = AnimalModel.Group.Land
                },
                new AnimalModel
                {
                    Name = "pizza",
                    Image = "pizza.jpg",
                    Category = AnimalModel.Group.Land
                }
            };
            MyCollectionView.ItemsSource = animals;
            MyCollectionView1.ItemsSource = animals;
            MyCollectionView2.ItemsSource = animals;
        }
        private void searchbar_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filteredlist = animals.Where(a => a.Name.StartsWith(e.NewTextValue));
            MyCollectionView2.ItemsSource = filteredlist;
        }
    }
}