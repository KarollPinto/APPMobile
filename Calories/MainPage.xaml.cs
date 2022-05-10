using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Calories
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Peso.Text) && !string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Años.Text) && !string.IsNullOrEmpty(Genero.Text))
            {
                double calorias;
                string resultado = "";
                if (Genero.Text == "1")
                {
                    //var calorias =(13.75*peso)+(5*altura)-(6.76*años)+66;
                    calorias = (13.75 * Convert.ToDouble(Peso.Text)) + (5 * Convert.ToDouble(Altura.Text)) - (6.78 * Convert.ToDouble(Años.Text)) + 66.5;
                    Calorias.Text = calorias.ToString();
                    resultado = Convert.ToString(calorias);


                }
                else if (Genero.Text == "2")
                {
                    //var calorias = (9.56 * peso) + (1.85 * altura) - (4.68 * años) + 655;
                    calorias = (9.56 * Convert.ToDouble(Peso.Text)) + (1.85 * Convert.ToDouble(Altura.Text)) - (4.68 * Convert.ToDouble(Años.Text)) + 655;
                    Calorias.Text = calorias.ToString();
                    resultado = Convert.ToString(calorias);

                }
                DisplayAlert("Sus calorias diarias son ", resultado, "OK");
            }
            else
            {
                DisplayAlert("Error", "Por favor llenar toda la información", "OK");
            }
        }
    }
}
