using System;
using System.Globalization;

namespace Basic;
class Program
{
  static void Main(string[] args)
  {
    // Exercício 01
    string soldProduct1 = "Computador";
    string soldProduct2 = "Mesa de escritório";

    double priceProduct1 = 2100.0;
    double priceProduct2 = 650.50;
    double measure = 53.234567;

    byte buyerAge = 30;
    int buyerCode = 5290;
    char buyerGender = 'M';

    string productDescriptionText = "{0}, cujo preço é $ {1:F2}";
    string product1Text = String.Format(productDescriptionText, soldProduct1, priceProduct1);
    string product2Text = String.Format(productDescriptionText, soldProduct2, priceProduct2);

    Console.WriteLine($"Produtos:\n{product1Text}\n{product2Text}\n\nRegistro: {buyerAge} anos de idade, código {buyerCode} e gênero {buyerGender}\n\nMedida com oito casas decimais: {measure:F8}\nArredondado (três casas decimais): {measure:F3}\nSeparador decimal invariant culture: {measure.ToString("F3", CultureInfo.InvariantCulture)}");
  }
}
