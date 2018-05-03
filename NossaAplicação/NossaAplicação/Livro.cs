using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NossaAplicação
{
    class Livro
    {
        string[] LivroNome = new string[100];
        string[] genero = new string[100];
        double[] precolivro = new double[100];
        int atual = 0;

        public void CadastrarLivro()
        {
            Console.Clear();
            Console.Write("Nome do livro: ");
            LivroNome[atual] = Console.ReadLine();
            Console.Write("Genero do livro: ");
            
            Console.Write("Preço do barco: ");

        }
    }
}
