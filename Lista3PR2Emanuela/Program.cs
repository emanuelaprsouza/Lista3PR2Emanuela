using System;
using System.CodeDom;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

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
            Console.WriteLine("6- EXERCÍCIO 6");
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
                        case 1: VAFI = cp - (15/100);
                              
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

                        case 3:Console.WriteLine("O mês é março e tem 31 dias");
                            break ;

                        case 4:Console.WriteLine("O mês é abril e tem 30 dias");
                            break;

                        case 5:Console.WriteLine("O mês é maio e tem 31 dias");
                            break;  

                        case 6:Console.WriteLine("O mês é junho e tem 30 dias");
                            break;

                         case 7:Console.WriteLine("O mês é julho e tem 31 dias");
                            break;

                         case 8:Console.WriteLine("O mês é agosto e tem 31 dias");
                            break;

                         case 9:Console.WriteLine("O mês é setembro e tem 30 dias");
                            break;

                         case 10:Console.WriteLine("O mês é outubro e tem 31 dias");
                            break;

                         case 11:Console.WriteLine("O mês é novembro e tem 30 dias");
                            break;

                         case 12:Console.WriteLine("O mês é dezembro e tem 31 dias");
                            break;

                         default: Console.WriteLine("Opção Inválida!");
                            break;

                    }

                    break;

             case 4:int n1,n2,result;
                    char cara;

                    Console.WriteLine("Digite o primeiro número: ");
                    Console.WriteLine("Digite o segundo número: ");

                    n1 = int.Parse(Console.ReadLine());
                    n2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("=====MENU=====");
                    Console.WriteLine("+");
                    Console.WriteLine("-");
                    Console.WriteLine("*");
                    Console.WriteLine("/");
                    Console.WriteLine("===============");

                   cara = char.Parse(Console.ReadLine());

                    switch (cara)
                    {
                        case '+':
                                Console.WriteLine("O resultado é: " + n1 + n2);
                                break;

                        case '-':
                                Console.WriteLine("O resultado é: " + n1 - n2);
                                break;

                        case '*':
                                Console.WriteLine("O resultado é: " + n1 * n2);
                                break;

                        case '/':
                                Console.WriteLine("O resultado é: "+ n1 / n2);
                            break;

                             default: Console.WriteLine("Opção Inválida!");
                            break;
                    }
           
                    break;

             case 5:float salario, percentual, salarionovo, cod;

                    Console.WriteLine("qual é o seu salario? ");
                    salario = float.Parse(Console.ReadLine());
                  

                    Console.WriteLine("Escolha de acordo com seu codigo:");


                    Console.WriteLine("==========MENU==========");
                    Console.WriteLine("101");
                    Console.WriteLine("102");
                    Console.WriteLine("103");
                    Console.WriteLine("204");
                    Console.WriteLine("206");
                    Console.WriteLine("301");
                    Console.WriteLine("302");
                    Console.WriteLine("=======================");

                    cod = float.Parse(Console.ReadLine());

                    switch (cod)
                    {
                        case 101:

                            percentual = (7.5f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá Professor(a), seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        case 102:
                            
                            percentual = (9.7f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá Secretario(a), seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        case 103:
                           
                            percentual = (11.7f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá PUblicitario(a), seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        case 204:
                           
                            percentual = (8.9f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá Jornalista, seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        case 206:
                           
                            percentual = (13.24f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá Mecanico(a), seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        case 301:
                           
                            percentual = (10.4f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá Estagiario(a), seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        case 302:
                           
                            percentual = (14.6f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá Tecnico(a) em TI, seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;

                        
                        default:
                            percentual = (43.5f * salario) / 100;

                            salarionovo = salario + percentual;


                            Console.WriteLine("Olá, Voce não está cadastrado mas seu novo salario é: {0}, e o seu salario antigo é:{1} e a diferença é: {2} ", salarionovo, salario, percentual);
                            break;
                    }
                    break;
            

             case 6: double  sal , sl , imp ;

                    Console . WriteLine ( " informe o seu salário: " );
                    sal  =  double.Parse( Console.ReadLine ());

                    if ( sal  <  1903 . 98 )
                    {
                        Console. WriteLine ( " seu salário está isento de imposto " );
                    }
                    else  if ( sal  >=  1903 . 99  &&  sal  <=  2826 . 65 )
                    {
                        sl  =  sal  -  sal  *  0 . 075 ;
                        imp  =  sal  %  sl ;
                        Console . WriteLine ( " o seu salário líquido é de: R$ "  +  sl  +  " eo imposto foi de: R$ "  +  imp );
                    }
                    else  if ( sal  >=  2826 . 66  &&  sal  <=  3751 . 05 )
                    {
                        sl  =  sal  -  sal  *  0 . 15 ;
                        imp  =  sal  %  sl ;
                        Console . WriteLine ( " o seu salário líquido é de: R$ "  +  sl  +  " eo imposto foi de: R$ "  +  imp );
                    }
                    else  if ( sal  >=  3751 . 06  &&  sal  <=  4664 . 68 )
                    {
                        sl  =  sal  -  sal  *  0 . 225 ;
                        imp  =  sal  %  sl ;
                        Console . WriteLine ( " o seu salário líquido é de: R$ "  +  sl  +  " eo imposto foi de: R$ "  +  imp );
                    }
                    else
                    {
                        sl  =  sal  -  sal  *  0 . 275 ;
                        imp  =  sal  %  sl ;
                        Console . WriteLine ( " o seu salário líquido é de: R$ "  +  sl  +  " eo imposto foi de: R$ "  +  imp );

                         default:
                    Console . WriteLine ( " opção inválida! " );
           
                    break;
                    }


                    break ;
           

                  default: Console.WriteLine("Opção Inválida!");
                      break;
            }

            Console.ReadKey();

            //------------------------------------------------------------------------------------------------------------------------------------------------

         
            


        }
    }
}
