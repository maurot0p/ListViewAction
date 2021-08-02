using ListViewAction.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewAction
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MainListView.ItemsSource = new List<ListViewTemplate>

            {
            new ListViewTemplate
                {
                Name = "Ejercicio del Profe",
                    Description = "Mostrar los números impares entre el 0 y el 100.",
                    OrderNumber = 1
               },
               new ListViewTemplate
               {
                   Name = "Ejercicio del Profe",
                   Description = "Mostrar los números pares entre el 0 y el 100.",
                   OrderNumber = 2
                },
                new ListViewTemplate
                {
                    Name = "Ejercicio del Profe",
                    Description = "Mostrar los múltiplos de 3 y de 2 entre dos números dados.",
                    OrderNumber = 3
               },
               new ListViewTemplate
               {
                   Name = "Ejercicio del Profe",
                   Description = "Dado tres lados de un triangulo, decir si se puede formar un triangulo, en caso de, decir que tipo de triangulo es. ",
                   OrderNumber = 4
               },
                new ListViewTemplate
               {
                   Name = "Ejercicio del Profe",
                   Description = "Cree una función que dado un string con la hora en formato de 24 horas me la convierta a la hora con formato de 12 horas ",
                   OrderNumber = 5
               },
                 new ListViewTemplate
               {
                   Name = "Ejercicio de Codeforces",
                   Description = "339A",
                   OrderNumber = 6
               },
                  new ListViewTemplate
               {
                   Name = "Ejercicio de MATCOMGRADER",
                   Description = "Perímetro mínimo",
                   OrderNumber = 7
               },
                   new ListViewTemplate
               {
                   Name = "Ejercicio de Codeforces",
                   Description = "158A",
                   OrderNumber = 8
               },
                    new ListViewTemplate
               {
                   Name = "Ejercicio del Profe",
                   Description = "Encontrar el maximo y minimo de un arreglo dado",
                   OrderNumber = 9
               },
                   new ListViewTemplate
               {
                   Name = "Ejercicio de Codeforces",
                   Description = "271A",
                   OrderNumber = 10
               },
                    new ListViewTemplate
               {
                   Name = "Ejercicio de Codeforces",
                   Description = "136A",
                   OrderNumber = 11
               },
                     new ListViewTemplate
               {
                   Name = "Ejercicio del Profe",
                   Description = "Calcular Area de un Triangulo",
                   OrderNumber = 12
               },
                      new ListViewTemplate
               {
                   Name = "Ejercicio de Codeforces",
                   Description = "479A",
                   OrderNumber = 13
               },
                       new ListViewTemplate
               {
                   Name = "Ejercicio de Codeforces",
                   Description = "486A",
                   OrderNumber = 14
               },
                        new ListViewTemplate
               {
                   Name = "Ejercicio de Codeforces",
                   Description = "25A",
                   OrderNumber = 15
               },


           };
        }
        async private void MainListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var Selected = e.Item as ListViewTemplate;

            switch (Selected.OrderNumber)
            {
                case 1:
                    await Navigation.PushAsync(new Page1());
                    break;
                case 2:
                    await Navigation.PushAsync(new Page2());
                    break;
                case 3:
                    await Navigation.PushAsync(new Page3());
                    break;
                case 4:
                    await Navigation.PushAsync(new Page4());
                    break;
                case 5:
                    await Navigation.PushAsync(new Page5());
                    break;
                case 6:
                    await Navigation.PushAsync(new Page6());
                    break;
                case 7:
                    await Navigation.PushAsync(new Page7());
                    break;
                case 8:
                    await Navigation.PushAsync(new Page8());
                    break;
                case 9:
                    await Navigation.PushAsync(new Page9());
                    break;
                case 10:
                    await Navigation.PushAsync(new Page10());
                    break;
                case 11:
                    await Navigation.PushAsync(new Page11());
                    break;
                case 12:
                    await Navigation.PushAsync(new Page12());
                    break;
                case 13:
                    await Navigation.PushAsync(new Page13());
                    break;
                case 14:
                    await Navigation.PushAsync(new Page14());
                    break;
                case 15:
                    await Navigation.PushAsync(new Page15());
                    break;
            }

               ((ListView)sender).SelectedItem = null;


        }
    }
}