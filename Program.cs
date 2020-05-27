using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTurma
{
    class Program
    {
        static void Main(string[] args)
        {
            int turma;

            Console.Write("Insira a quantidade de turmas existentes: ");
            turma = Convert.ToInt32(Console.ReadLine());

            double totalalunos = SaberTotalAlunos(turma);

            Console.WriteLine("A média de alunos de cada turma é de: " + totalalunos + " alunos");

            Console.ReadLine();

        }
        public static double SaberTotalAlunos(int turma)
        {

            int[] listaqtdealunos = new int[turma];
            int qtdalunos;

            for (int i = 0; i < turma; i++)
            {
                Console.WriteLine("Quantas alunos tem na turma " + (i + 1) + ":");
                qtdalunos = Convert.ToInt32(Console.ReadLine());

                if (qtdalunos <= 40)
                {
                    listaqtdealunos[i] = qtdalunos;
                }
                else
                {
                    Console.WriteLine("A quantidade de alunos informados não condiz com o total " +
                        "estabalecido de no máximo 40 alunos por turma");

                    Console.WriteLine();

                    Console.Clear();

                    while (qtdalunos > 40)
                    {
                        Console.WriteLine("Digite novamente a quantidade de alunos da turma " + (i + 1) + ":");
                        qtdalunos = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                    }
                    listaqtdealunos[i] = qtdalunos;
                    
                }
                
            }
            double totalalunos = listaqtdealunos.Average();
            return totalalunos;

        }
    }
}
