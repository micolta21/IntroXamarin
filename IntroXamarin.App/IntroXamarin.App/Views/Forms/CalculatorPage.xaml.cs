using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IntroXamarin.App.Views.Forms
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CalculatorPage : ContentPage
    {
        private String operador = null;
        private Double? Valor1 = null;
        private Double? Valor2 = null;
        private Double? Resultado = null;
        

        public CalculatorPage()
        {
            InitializeComponent();
        }

        private void btn_Cliked(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if ("1234567890".Contains(boton.Text) && (Valor1 == null || operador == null))
            {
                PantallaResultado.Text = Valor1.ToString() + boton.Text;
                Valor1 = Convert.ToDouble(PantallaResultado.Text);
            }
            else if ("1234567890".Contains(boton.Text) && (Valor2 == null) || operador != null)
            {
                PantallaResultado.Text = Valor2.ToString() + boton.Text;
                Valor2 = Convert.ToDouble(PantallaResultado.Text);
            }
            else if ("+-x+/-√%÷".Contains(boton.Text) && Valor1 != null)
                operador = boton.Text;
            else
                calcular(Valor1, Valor2, operador);

        }
        private void calcular (double? v1, double? v2, String op)
        {
            switch (op)
            {
                case "+":
                    Resultado = v1 + v2;
                    PantallaResultado.Text = Resultado.ToString();
                    Valor1 = Resultado;
                    Valor2 = null;
                    break;

                case "-":
                    Resultado = v1 - v2;
                    PantallaResultado.Text = Resultado.ToString();
                    Valor1 = Resultado;
                    Valor2 = null;
                    break;

                case "÷":
                    Resultado = v1 / v2;
                    PantallaResultado.Text = Resultado.ToString();
                    Valor1 = Resultado;
                    Valor2 = null;
                    break;

                case "%":
                    Resultado = v1 * v2/100;
                    PantallaResultado.Text = Resultado.ToString();
                    Valor1 = Resultado;
                    Valor2 = null;
                    break;

                case "X":
                    Resultado = v1 * v2;
                    PantallaResultado.Text = Resultado.ToString();
                    Valor1 = Resultado;
                    Valor2 = null;
                    break;

                case "√":
                    Resultado = v1 / v2;
                    PantallaResultado.Text = Resultado.ToString();
                    Valor1 = Resultado;
                    Valor2 = null;
                    break;
            }
        }

        private void btn_limpiar(object sender, EventArgs e)
        {
            Valor1 = null;
            Valor2 = null;
            Resultado = null;
            operador = null;
            PantallaResultado.Text = "0";
        }

        private void Igual_Clicked(object sender, EventArgs e)
        {
            Button boton = sender as Button;
            if (boton != null)
            {
                PantallaResultado.Text = Resultado.ToString();
            }
        }
    }
}