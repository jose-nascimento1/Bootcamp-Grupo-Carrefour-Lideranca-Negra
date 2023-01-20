//Desafio
//Faça um programa que calcule e imprima o salário a ser transferido para um funcionário.
//Para realizar o calculo receba o valor bruto do salário e o adicional dos benefícios.
//O salário a ser transferido é calculado da seguinte maneira: 
//(valor bruto do salário - percentual de imposto mediante ao salário) + adicional dos benefícios
//Para calcular o percentual de imposto segue as aliquotas:
//    De R$ 0.00 a R$ 1100.00 = 5.00%
//    De R$ 1100.01 a R$ 2500.00 = 10.00%
//    Maior que R$ 2500.00 = 15.00%

using System;

public class Desafio
{
	public static void Main()
	{
	  //Lê os valores de Entrada:
	  float salarioBruto = float.Parse(Console.ReadLine());
	  float valorBeneficios = float.Parse(Console.ReadLine());
	  
	  float valorImposto = 0;
	  if (salarioBruto >= 0 && salarioBruto <= 1100)
	  {
	    //Atribiu a aliquota de 5% mediante o salário:
	    valorImposto = 0.05F * salarioBruto;
	  } else if (salarioBruto > 1100 && salarioBruto <= 2500) {
	    valorImposto = 0.10F * salarioBruto;
	  } else {
	    valorImposto = 0.15F * salarioBruto;
	  }
	  //TODO Criar as demais condições para as aliquotas de 10.00% e 15.00%.
	  
	  //Calcula e imprime a Saída (com 2 casas decimais):
	  float saida = salarioBruto - valorImposto + valorBeneficios;
	  Console.WriteLine(saida.ToString("0.00"));
	}
}