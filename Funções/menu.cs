using System;
namespace PIM
{
    public static class Menu
    {
       
       public static void Mostrar()
        {
             Console.Clear();

            Console.WriteLine("SISTEMA ACADÊMICO");
            Console.WriteLine("-----------------");
            Console.WriteLine("1-Cadastrar Aluno");
            Console.WriteLine("2-Listar Alunos");
            Console.WriteLine("3-Cadastrar turmas");
            Console.WriteLine("4-Listar turma");
            Console.WriteLine("-----------------");
            Console.WriteLine("");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Alunos.Cadastrar(); break;
                case 2: Alunos.Listagem(); break;
                case 3: Turmas.Cadastrar(); break;
                case 4: Turmas.Listagem(); break;
                default: Mostrar(); break;
            }

        }
    }
}
