using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generator
{
    class Program
    {
        static void Main(string[] args)
        {

            int digito1;
            char repetir;
            char a;
            char b;
            char c;
            int digitos;

            do
            {

                Console.Clear(); //Limpando a tela 

                Console.Write("\t**********************************************************");
                Console.Write("\n\t*** Programa que gera a próxima sequência de uma placa ***");
                Console.Write("\n\t**********************************************************");

                Console.Write("\n\nDigite o primeiro dígito: ");
                digito1 = int.Parse(Console.ReadLine());

                Console.Write("\nDigite a primeira letra: ");
                a = char.Parse(Console.ReadLine());

                Console.Write("\nDigite a segunda letra: ");
                b = char.Parse(Console.ReadLine());

                Console.Write("\nDigite a terceira letra: ");
                c = char.Parse(Console.ReadLine());

                Console.Write("\nDigite os outros 3 dígitos: ");
                digitos = int.Parse(Console.ReadLine());


                //Realizando os cálculos             


                if (digitos < 10)
                {
                    //Exibindo valores da placa atual:
                    Console.Write("\n\t\t----------------------------");
                    Console.Write("\n\t\t A placa Atual é: " + digito1 + " " + a + "" + b + "" + c + " 00" + digitos);
                    Console.Write("\n\t\t----------------------------");

                    digitos = digitos + 1;
                    Console.Write("\n\nA placa próxima sequência dessa placa é: " + digito1 + " " + a + "" + b + "" + c + " 00" + digitos);
                }


                else if (digitos < 999)
                {
                    //Exibindo valores da placa atual:
                    Console.Write("\n\t\t----------------------------");
                    Console.Write("\n\t\t A placa Atual é: " + digito1 + " " + a + "" + b + "" + c + " " + digitos);
                    Console.Write("\n\t\t----------------------------");

                    digitos = digitos + 1;
                    Console.Write("\n\nA placa próxima sequência dessa placa é: " + digito1 + " " + a + "" + b + "" + c + " " + digitos);
                }


                else if (digitos == 999)
                {
                    //Exibindo valores da placa atual:
                    Console.Write("\n\t\t----------------------------");
                    Console.Write("\n\t\t A placa Atual é: " + digito1 + " " + a + "" + b + "" + c + " " + digitos);
                    Console.Write("\n\t\t----------------------------");

                    if (c != 'z')
                    {

                        digitos = 0;
                        c = (char)(c + 1);
                        Console.Write("\n\nA placa próxima sequência dessa placa é: " + digito1 + " " + a + "" + b + "" + c + " 00" + digitos);
                    }

                    else
                        if (c == 'z' && b == 'z' && a != 'z')
                        {
                            digitos = 0;
                            c = 'a';
                            b = 'a';
                            a = (char)(a + 1);
                            Console.Write("\n\nA placa próxima sequência dessa placa é: " + digito1 + " " + a + "" + b + "" + c + " 00" + digitos);
                        }

                        else
                            if (c == 'z' && b != 'z' && a != 'z')
                            {

                                digitos = 0;
                                c = 'a';
                                b = (char)(b + 1);

                                Console.Write("\n\nA placa próxima sequência dessa placa é: " + digito1 + " " + a + "" + b + "" + c + " 00" + digitos);

                            }

                            else if (a == 'z' && b == 'z' && c == 'z')
                            {
                                if (digito1 != 9)
                                {
                                    digitos = 0;
                                    c = 'a';
                                    b = 'a';
                                    a = 'a';

                                    digito1 = digito1 + 1;
                                    Console.Write("\n\nA placa próxima sequência dessa placa é: " + digito1 + " " + a + "" + b + "" + c + " 00" + digitos);
                                }
                                else
                                {
                                    Console.Write("\n\n\t\tERRO! NÃO HÁ MAIS PLACAS !!!");
                                }
                            }
                }

                Console.Write("\n\nDeseja uma nova operação ? [S]im - [N]ão: ");
                repetir = char.Parse(Console.ReadLine());

            } while (repetir == 's' || repetir == 'S');
        }
    }
}
