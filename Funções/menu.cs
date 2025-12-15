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
            Console.WriteLine("1 - Cadastrar Aluno");
            Console.WriteLine("2 - Listar Alunos");
            Console.WriteLine("3 - Cadastrar turmas");
            Console.WriteLine("4 - Listar turma");
            Console.WriteLine("5 - Editar Aluno");
            Console.WriteLine("6 - Exluir Alunos");
            Console.WriteLine("7 - Editar Turmas");
            Console.WriteLine("8 - Remover Turmas");
            Console.WriteLine("-----------------");
            Console.WriteLine("");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Alunos.Cadastrar(); break;
                case 2: Alunos.Listagem(); break;
                case 3: Turmas.Cadastrar(); break;
                case 4: Turmas.Listagem(); break;
                case 5: Editar.Alunos();break;
                case 6: Excluir.AlunoS(); break;
                case 7: Editarr.Turmas();break;
                case 8: Remover.Turmas();break;
                default: Mostrar(); break;
            }

        }
    }
}
