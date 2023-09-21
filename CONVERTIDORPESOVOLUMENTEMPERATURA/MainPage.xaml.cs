using System;
using Xamarin.Forms;

namespace CONVERTIDORPESOVOLUMENTEMPERATURA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Evento para convertir peso de kg a lb
        private void ConvertirPeso_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(pesoEntry.Text, out double pesoKg))
            {
                double pesoLb = pesoKg * 2.20462; // 1 kg = 2.20462 lb
                resultadoPesoLabel.Text = "Resultado: " + pesoLb.ToString("F2") + " lb";
            }
            else
            {
                resultadoPesoLabel.Text = "Ingrese un valor válido.";
            }
        }

        // Evento para convertir volumen de litros a galones
        private void ConvertirVolumen_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(volumenEntry.Text, out double volumenLitros))
            {
                double volumenGalones = volumenLitros * 0.264172; // 1 litro = 0.264172 galones
                resultadoVolumenLabel.Text = "Resultado: " + volumenGalones.ToString("F2") + " gal";
            }
            else
            {
                resultadoVolumenLabel.Text = "Ingrese un valor válido.";
            }
        }

        // Evento para convertir temperatura de °C a °F
        private void ConvertirTemperatura_Clicked(object sender, EventArgs e)
        {
            if (double.TryParse(temperaturaEntry.Text, out double temperaturaC))
            {
                double temperaturaF = (temperaturaC * 9 / 5) + 32;
                resultadoTemperaturaLabel.Text = "Resultado: " + temperaturaF.ToString("F2") + " °F";
            }
            else
            {
                resultadoTemperaturaLabel.Text = "Ingrese un valor válido.";
            }
        }
    }
}
