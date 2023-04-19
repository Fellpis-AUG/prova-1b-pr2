using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prova_1b_pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ex;
            Console.WriteLine("qual exercicio voce que que seja executado:");
            ex = int.Parse(Console.ReadLine());

            switch (ex)
            {
                case 1:
                    Console.WriteLine("digite um numero inteiro");
                    int N1 = int.Parse(Console.ReadLine());

                    if (N1 > 0)
                    {
                        Console.WriteLine("o numero é" + N1);
                    }
                    else if (N1 > 0)
                    {
                        N1 = N1 * -1;
                        Console.WriteLine("o numero é" + N1);
                    }
                    Console.ReadKey();
                    break;

                case 2:
                    Console.WriteLine("informe um numero:");
                    double N2 = double.Parse(Console.ReadLine());

                    if (N2 % 3 == 0 && N2 % 5 == 0 || N2 % 4 == 0 && N2 % 7 == 0)
                    {
                        Console.WriteLine("ele é divisivel por 3 e 5 ou por 4 e 7");
                    }

                    else if (N2 % 3 == 0)
                    {
                        Console.WriteLine("ele é divisivel por 3");
                    }

                    else if (N2 % 4 == 0)
                    {
                        Console.WriteLine("ele é divisivel por 4");
                    }

                    else if (N2 % 5 == 0)
                    {
                        Console.WriteLine("ele é divisivel por 5");
                    }

                    else if (N2 % 7 == 0)
                    {
                        Console.WriteLine("ele é divisivel por 7");
                    }

                    else
                    {
                        Console.WriteLine("ele não é divisil por 3,4,5 e o 7 ");
                    }
                    Console.ReadKey();
                    break;

                case 3:

                    int maior = int.MaxValue;

                    Console.WriteLine("digite um numero inteiro");
                    int num1 = int.Parse(Console.ReadLine());

                    if (num1 > maior)
                    {
                        maior = num1;
                    }

                    Console.WriteLine("digite um numero inteiro");
                    int num2 = int.Parse(Console.ReadLine());

                    if (num2 > maior)
                    {
                        maior = num2;
                    }

                    Console.WriteLine("digite um numero inteiro");
                    int num3 = int.Parse(Console.ReadLine());

                    if (num3 > maior)
                    {
                        maior = num3;
                    }
                    Console.WriteLine("o maior valor é" + maior);
                    Console.ReadKey();
                    break;

                case 4:
                    int Ds;
                    Console.WriteLine("informe um dia da semana de 1 a 7:");
                    Ds = int.Parse(Console.ReadLine());

                    switch (Ds)
                    {
                        case 1:

                            Console.WriteLine("nos domingos customo ficar em casa jogando ou sair para pasear");

                            break;
                        case 2:

                            Console.WriteLine(" na segunda geralmente temos aula de Filosofia, portugues e de Matematica");

                            break;
                        case 3:

                            Console.WriteLine(" na terça temos alula aula de quimica, Historia e de IMI");

                            break;
                        case 4:

                            Console.WriteLine(" na quareta temos aula de Biologia, Portugues e de Progamação");

                            break;
                        case 5:

                            Console.WriteLine("na quinta temos aula de Fisica, redes e de Sociologia");

                            break;
                        case 6:

                            Console.WriteLine("na sexta temos Geografia, BDS e Mattematica");

                            break;
                        case 7:

                            Console.WriteLine("no sabado fico em casa");

                            break;
                        case 8:

                            Console.WriteLine("vocé colocou um numero invalido");

                            break;

                    }

                    Console.ReadKey();
                    break;

                case 5:

                    int maior5 = int.MinValue;
                    int menor5 = int.MaxValue;
                    int N5 = 1;

                    for (; N5 <= 0;)
                    {


                        Console.Write("Digite o  número: ");
                        N5 = int.Parse(Console.ReadLine());

                        if (N5 > maior5)
                        {
                            maior5 = N5;
                        }

                        if (N5 < menor5)
                        {
                            menor5 = N5;
                        }
                    }

                    Console.WriteLine("O maior número digitado foi: " + maior5);
                    Console.WriteLine("O menor número digitado foi: " + menor5);
                    Console.ReadKey();
                    Console.ReadKey();
                    break;

                case 6:

                    int N6, cont6, i;

                    Console.WriteLine("digite o numero");
                    N6 = int.Parse(Console.ReadLine());

                    for (i = 1; i < N6 / 2; i++)
                    {
                        cont6 = i;
                        if (N6  == cont6)
                        {
                            
                            if (N6 % i == 0)
                            {
                                Console.WriteLine("o numero é perfeito");
                            }
                            else
                            {
                                Console.WriteLine("o numero não é perfeito");
                            }
                        }

                     }
                    Console.ReadKey();
                    break;
                case 7:

                    int N7 = 1, soma = 0, cont = 0, media = 0;


                    for (; N7 <= 0;)
                    {
                        cont++;
                        Console.WriteLine("digite um numero");
                        N7 = int.Parse(Console.ReadLine());
                        if (N7 % 2 == 0)
                        {
                            soma = soma + N7;

                        }


                    }
                    if (soma > 0)
                    {
                        media = soma / cont;
                        Console.WriteLine("a media é" + media);

                    }
                    else
                    {
                        Console.WriteLine("os numeros não são validos");
                    }

                    Console.ReadKey();
                    break;

            }




        }
    }
}
