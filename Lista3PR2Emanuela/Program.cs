﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista3PR2Emanuela
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.WriteLine("==========MENU==========");
            Console.WriteLine("1- EXERCÍCIO 1");
            Console.WriteLine("2- EXERCÍCIO 2");
            Console.WriteLine("3- EXERCÍCIO 3");
            Console.WriteLine("4- EXERCÍCIO 4");
            Console.WriteLine("5- EXERCÍCIO 5");
            Console.WriteLine("6- EXERCÍCIO 5");
            Console.WriteLine("=======================");

            numero = int.Parse(Console.ReadLine());



            switch (numero)
            {
             case 1:  int dia;

                    Console.WriteLine("Escolha um número para saber o dia da semana: ");
                 
                    Console.WriteLine("=====MENU=====");
                    Console.WriteLine("1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.WriteLine("4");
                    Console.WriteLine("5");
                    Console.WriteLine("6");
                    Console.WriteLine("7");
                    Console.WriteLine("===============");

                    dia = int.Parse(Console.ReadLine());
                   
                    switch (dia)
                    {
                        case 1: Console.WriteLine("DOMINGO");
                            break;
                        case 2:
                            Console.WriteLine("SEGUNDA");
                            break;
                        case 3:
                            Console.WriteLine("TERÇA");
                            break;
                        case 4:
                            Console.WriteLine("QUARTA");
                            break;
                        case 5:
                            Console.WriteLine("QUINTA");
                            break;
                        case 6:
                            Console.WriteLine("SEXTA");
                            break;
                        case 7:
                            Console.WriteLine("SABADO");
                            break;
            
                       
                        default: Console.WriteLine("Opção Inválida!");
                            break;
                    }
                   
                        break;

             case 2: float cp, pg,VAFI;

                       Console.WriteLine("Digite o valor da sua compra: ");
                        cp = float.Parse(Console.ReadLine());

                       Console.WriteLine("Escolha uma forma de pagamento");

                       Console.WriteLine("=====MENU=====");
                       Console.WriteLine("1 - Dinheiro");
                       Console.WriteLine("2 - Pix");
                       Console.WriteLine("3 - Débito");
                       Console.WriteLine("4 - Crédito");
                       Console.WriteLine("===============");

                       pg = float.Parse(Console.ReadLine());

                    switch (pg)
                    {
                        case 1: VAFI = cp - (15 / 100);
                            Console.WriteLine("O valor final a ser pago é:  " + VAFI);
                            break;

                        case 2:VAFI = cp - (10 / 100);
                             Console.WriteLine("O valor final a ser pago é:  " + VAFI);
                            break;

                        case 3:VAFI = cp + (5 / 100);
                             Console.WriteLine("O valor final a ser pago é:  " + VAFI);
                             break;

                        case 4:VAFI = cp + (10 / 100);
                            Console.WriteLine("O valor final a ser pago é:  " + VAFI);
                            break;

                       
                        default: Console.WriteLine("Opção Inválida!");
                            break;

                    }

                    break ;


             case 3:int mes;

                    Console.WriteLine("Escolha um número para saber o mês e quantos dias ele tem");

                    Console.WriteLine("=====MENU=====");
                    Console.WriteLine("1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.WriteLine("4");
                    Console.WriteLine("5");
                    Console.WriteLine("6");
                    Console.WriteLine("7");
                    Console.WriteLine("8");
                    Console.WriteLine("9");
                    Console.WriteLine("10");
                    Console.WriteLine("11");
                    Console.WriteLine("12");
                    Console.WriteLine("===============");

                    mes = int.Parse(Console.ReadLine());

                    switch (mes)
                    {
                        case 1:Console.WriteLine("O mês é janeiro e tem 31 dias");
                            break;

                        case 2:Console.WriteLine("O mês é fevereiro e tem 28 dias,mas se for ano bissexto ele tera 29 dias");
                            break;


                    }

                    break;

             case 4:
           
                    break;

             case 5:
            
                    break;

             case 6:
           
                    break;

           

                  default: Console.WriteLine("Opção Inválida!");
                      break;
            }

            Console.ReadKey();

            //------------------------------------------------------------------------------------------------------------------------------------------------

         
            


        }
    }
}
