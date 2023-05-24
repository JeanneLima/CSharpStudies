using System;
using System.Globalization;

namespace Basic;
class Program
{
  static void Main(string[] args)
  {
    // Exercício de Fixação 01
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

    Console.WriteLine("Resultado do Exercício de Fixação 01:\n");

    Console.WriteLine($"Produtos:\n{product1Text}\n{product2Text}\n\nRegistro: {buyerAge} anos de idade, código {buyerCode} e gênero {buyerGender}\n\nMedida com oito casas decimais: {measure:F8}\nArredondado (três casas decimais): {measure:F3}\nSeparador decimal invariant culture: {measure.ToString("F3", CultureInfo.InvariantCulture)}");

    Console.WriteLine("\n-------------\n");

    // Exercício de Fixação 02 - Entrada de dados em C#
    string answer1;
    int answer2;
    double answer3;
    string[] answer4;
    string lastName;
    int age;
    double height;

    Console.WriteLine("Resultado do Exercício de Fixação 01:\n");

    Console.WriteLine("Entre com seu nome completo:");
    answer1 = Console.ReadLine();

    Console.WriteLine("Quantos quartos tem na sua casa?");
    answer2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Entre com o preço de um produto:");
    answer3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha)");
    answer4 = Console.ReadLine().Split();

    lastName = answer4[0];

    age = int.Parse(answer4[1]);

    height = double.Parse(answer4[2], CultureInfo.InvariantCulture);

    Console.WriteLine("\nSuas respostas foram (números reais com 2 casas decimais):");
    Console.WriteLine(answer1);
    Console.WriteLine(answer2);
    Console.WriteLine(answer3.ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine(lastName);
    Console.WriteLine(age);
    Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

    Console.WriteLine("\n-------------\n");
  }
}
