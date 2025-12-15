using System;
using System.ComponentModel.Design;
namespace PIM
{
    public static class Alunos
    {
    public static List<string> alunos = Arquivo.CarregarLista("alunos.txt");

        public static void Cadastrar()
        {
            
            Console.Clear();

            Console.WriteLine("Nome do Aluno:");
            Console.WriteLine("------------------");
            String aluno = Console.ReadLine();
            alunos.Add(aluno);
            Arquivo.SalvarLista("alunos.txt", alunos);

            Console.WriteLine("");
            Console.WriteLine($"{aluno} Cadastrado com sucesso!");
            Console.WriteLine("");
            Console.WriteLine("APERTE ENTER PARA CONTINUAR");
            Console.ReadKey();
            Menu.Mostrar();  
        }

        public static void Listagem()
        {
            Console.Clear();
            Console.WriteLine("Listagem de Alunos");
            Console.WriteLine("-------------------");

           if(alunos.Count == 0)
            {
                Console.WriteLine("Nenhum aluno cadastrada");
            }
            else
            {
                foreach(var aluno in alunos)
                {
                    Console.WriteLine(aluno);
                }
                Console.ReadKey();
            }  
            Menu.Mostrar();
        }
        
    }
}

