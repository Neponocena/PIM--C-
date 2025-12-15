using System;
namespace PIM
{
    public static class Remover
    {
        public static void Turmas()
        {
             List<string> turmas = File.ReadAllLines("turmas.txt").ToList();

            Console.Clear();
            Console.WriteLine("Turmas");
            Console.WriteLine("------");

            for (int i = 0; i < turmas.Count; i++)
                Console.WriteLine($"{i + 1} - {turmas[i]}");

            Console.Write("Escolha o número da turma  :");
            int index = int.Parse(Console.ReadLine()) - 1;

            turmas.RemoveAt(index);

            File.WriteAllLines("turmas.txt", turmas);

            Console.WriteLine("turma excluída com sucesso!");
            Console.ReadKey();
            Menu.Mostrar();
        }
    }
}
