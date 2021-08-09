using System;

namespace Ivory.TesteEstagio.CampoMinado
{
    class Program
    {
        static void Main(string[] args)
        {
            var campoMinado = new CampoMinado();
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);

            // Realize sua codificação a partir deste ponto, boa sorte!

            // Como todos sabem, uma string é um vetor de caracteres, portanto o objetivo do algoritmo é realizar a leitura da string Tabuleiro
            // utilizando a lógica de identificação das minas terrestres conforme a sessão objetivo do jogo. Após analisar e identificar que é
            // seguro abrir uma posição, seu algoritmo deve chamar o método Abrir da classe CampoMinado. Ao abrir todas as posições que não
            // possuem minas terrestres o atributo JogoStatus irá receber o valor 1 de vitória.





            // Objetivo 1 : Conseguir uma lógica que percorra o campoMinado.Tabuleiro e retorne o valor 
            // Objetivo 2 : Avaliar as posições ao redor da casa para ver se é segura abrir
            // Objetivo 3 : Caso seja segura executar campoMinado.abrir para abrir a casa certa. 


            //OBJ 1: Talvez uma maneira de solucionar seja dividir o array de 9x9 para 3 array 3x3 sendo assim possível verificar
            //o elemento central e seu arredor


            
            // Método 1
             foreach (int x > 0 in campoMinado.Tabuleiro)
                 {


                 }
                  };
         
            // Método 2

            for (int i = 0; i < 9; i++)

            {

                for (int j = 0; j < 9; j++)

                {

                   // Console.WriteLine(array[i, j].ToString());

                }

            }
            
             
            
            // Método 3
            class ArrayClass2D
         {
        static void Print2DArray(int[,] arr)
        {
            // Display the array elements.
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.WriteLine("Element({0},{1})={2}", i, j, arr[i, j]);
                }
            }
        }
        static void Main()
        {
            // Pass the array as an argument.
            Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });

            // Keep the console window open in debug mode.
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
    /* Output:
        Element(0,0)=1
        Element(0,1)=2
        Element(1,0)=3
        Element(1,1)=4
        Element(2,0)=5
        Element(2,1)=6
        Element(3,0)=7
        Element(3,1)=8
    */
            

            //Abrir casa
            campoMinado.Abrir(9, 9);
            
            Console.WriteLine("Início do jogo\n=========");
            Console.WriteLine(campoMinado.Tabuleiro);
           ;



        }

    }
}

