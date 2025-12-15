using System;
namespace PIM
{
    public static class Editarr
    {
        static public void Turmas()
        {
             List<string> turmas = File.ReadAllLines("turmas.txt").ToList();

        Console.Clear();
        Console.WriteLine("TURMAS");
        Console.WriteLine("------");

    for (int i = 0; i < turmas.Count; i++)
        Console.WriteLine($"{i + 1} - {turmas[i]}");

        Console.Write("\nEscolha o número da turma: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Novo nome: ");
         turmas[index] = Console.ReadLine();

         File.WriteAllLines("turmas.txt", turmas);

        Console.WriteLine("Turma editada com sucesso!");
        Console.ReadKey();
        }
    }
   
}