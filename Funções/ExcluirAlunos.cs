using System;
using System.ComponentModel.Design;
namespace PIM
{
    public static class Excluir
{
    public static void AlunoS()
        {
            List<string> alunos = File.ReadAllLines("alunos.txt").ToList();

            Console.Clear();
            Console.WriteLine("ALUNOS");
            Console.WriteLine("------");

            for (int i = 0; i < alunos.Count; i++)
                Console.WriteLine($"{i + 1} - {alunos[i]}");

            Console.Write("\nEscolha o número do aluno para excluir: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            alunos.RemoveAt(index);

            File.WriteAllLines("alunos.txt", alunos);

            Console.WriteLine("Aluno excluído com sucesso!");
            Console.ReadKey();
            Menu.Mostrar();
            
        }    
}

}