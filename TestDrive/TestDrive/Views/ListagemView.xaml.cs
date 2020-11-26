using System.Collections.Generic;
using System.ComponentModel;
using TestDrive.Models;
using Xamarin.Forms;

namespace TestDrive.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ListagemView : ContentPage
    {
        public List<Veiculo> Veiculos { get; set; }
        public ListagemView()
        {
            InitializeComponent();

            this.Veiculos = new List<Veiculo>
            {
                new Veiculo
                {
                    Modelo = "Azera V6",
                    Preco = 60000.00M
                },
                new Veiculo
                {
                    Modelo = "Fiesta 2.0",
                    Preco = 40000.00M
                },
                new Veiculo
                {
                    Modelo = "HB20 S",
                    Preco = 50000.00M
                }
            };

            this.BindingContext = this;
        }

        private void listViewVeiculos_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            //DisplayAlert("TestDrive", string.Format("Você tocou no modelo {0} que custa {1}!", veiculo.Modelo, veiculo.PrecoFormatado), "Ok");
            Navigation.PushAsync(new DetalheView((Veiculo)e.Item));
        }
    }
}
