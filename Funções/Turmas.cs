using System;
namespace PIM
{
    public static class Turmas
    {
    public static List<string> turmas = Arquivo.CarregarLista("turmas.txt");
    public static void Cadastrar()
        {
           Console.Clear();

           Console.WriteLine("Nome da turma");
           Console.WriteLine("---------------");
           string turma = Console.ReadLine();
           turmas.Add(turma);
            Arquivo.SalvarLista("turmas.txt", turmas);


           Console.WriteLine(turma + "cadastrada com sucesso");
           Menu.Mostrar();
        }

            public static void Listagem()
    {
            Console.Clear();
            Console.WriteLine("Turmas Cadastradas");
            Console.WriteLine("--------------------");


            if (turmas.Count == 0)
             Console.WriteLine("Nenhuma turma cadastrada.");
             else
                foreach (var t in turmas)
            Console.WriteLine(t);

            Console.ReadKey();
            Menu.Mostrar();
    }
    }
}