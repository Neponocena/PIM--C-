using System;
using System.ComponentModel.Design;

    public static class Editar
{
    public static void Alunos()
    {

     List<string> alunos = File.ReadAllLines("alunos.txt").ToList();

        Console.Clear();
        Console.WriteLine("ALUNOS");
        Console.WriteLine("------");

    for (int i = 0; i < alunos.Count; i++)
        Console.WriteLine($"{i + 1} - {alunos[i]}");

        Console.Write("\nEscolha o número do aluno: ");
        int index = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Novo nome: ");
         alunos[index] = Console.ReadLine();

         File.WriteAllLines("alunos.txt", alunos);

        Console.WriteLine("Aluno editado com sucesso!");
        Console.ReadKey();

    }   
}