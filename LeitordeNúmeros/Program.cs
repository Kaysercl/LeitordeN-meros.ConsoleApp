using System;

namespace LeitordeNúmeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto =   "     __  __      __  __  __  __  __  __ " + Environment.NewLine +
                             "  |  __| __||__||__ |__   | |__||__||  |" + Environment.NewLine +
                             "  | |__  __|   | __||__|  | |__| __||__|"; 
                                              
            System.IO.StringReader leitordeCodigos = new System.IO.StringReader(texto);

            string Linha1 = leitordeCodigos.ReadLine();
            char[] char1 = Linha1.ToCharArray(); 
            string Linha2 = leitordeCodigos.ReadLine();
            char[] char2 = Linha2.ToCharArray();
            string Linha3 = leitordeCodigos.ReadLine();
            char[] char3 = Linha3.ToCharArray();

            string primeiraLinha = "";
            string segundaLinha = "";
            string terceiraLinha = "";
            string numero = "";
            int contador = 0;

            for (int i = 0; i <= 39; i++)
            {
                primeiraLinha = primeiraLinha + char1[i];
                segundaLinha = segundaLinha + char2[i];
                terceiraLinha = terceiraLinha + char3[i];


                if (primeiraLinha == "    " && segundaLinha == "  | " && terceiraLinha == "  | ")
                {
                    Console.Write(numero += "1");
                }
                else if (primeiraLinha == " __ " && segundaLinha == " __|" && terceiraLinha == "|__ ")
                {
                    Console.Write(numero += "2");
                }
                else if (primeiraLinha == " __ " && segundaLinha == " __|" && terceiraLinha == " __|")
                {
                    Console.Write (numero += "3");
                }
                else if (primeiraLinha == "    " && segundaLinha == "|__|" && terceiraLinha == "   |")
                {
                    Console.Write(numero += "4");
                }
                else if (primeiraLinha == " __ " && segundaLinha == "|__ " && terceiraLinha == " __|")
                {
                    Console.Write(numero += "5");
                }
                else if (primeiraLinha == " __ " && segundaLinha == "|__ " && terceiraLinha == "|__|")
                {
                    Console.Write(numero += "6");
                }
                else if (primeiraLinha == " __ " && segundaLinha == "  | " && terceiraLinha == "  | ")
                {
                    Console.Write(numero += "7");
                }
                else if (primeiraLinha == " __ " && segundaLinha == "|__|" && terceiraLinha == "|__|")
                {
                    Console.Write(numero += "8");
                }
                else if (primeiraLinha == " __ " && segundaLinha == "|__|" && terceiraLinha == " __|")
                {
                    Console.Write(numero += "9");
                }
                else if (primeiraLinha == " __ " && segundaLinha == "|  |" && terceiraLinha == "|__|")
                {
                    Console.Write(numero += "0");
                }

                contador = contador + 1;
                if (contador == 4)
                {
                     primeiraLinha = "";
                     segundaLinha = "";
                     terceiraLinha = "";
                     contador = 0;
                     numero = "";
                }
                
            }
                       
        } 
    }
}
