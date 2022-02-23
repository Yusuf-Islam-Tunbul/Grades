using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20220209_Quiz2
{
    class Program
    {
        Random random = new Random();
        int[,] notes = new int[20,2];
        int pass_note = 70;

        static void Main(string[] args)
        {
            Program prog = new Program();
            prog.AssignNotes();
            prog.CalculateNotes();
        }

        void AssignNotes()
        {
            for (int i = 0; i < notes.GetLength(0); i++)
            {
                for(int j=0; j < notes.GetLength(1); j++)
                {
                    notes[i, j] = random.Next(0, 101);
                }
            }
        }

        void CalculateNotes()
        {
            for (int i = 0; i< notes.GetLength(0); i++)
            {
                string text = "";
                int sum = 0;

                for(int j = 0; j < notes.GetLength(1); j++)
                {
                    text += notes[i, j] + " ";
                    sum += notes[i, j];
                }

                text += (sum / notes.GetLength(1)) > pass_note ? "Geçti" : "Kaldı";

                Console.WriteLine(text);
            }

            Console.ReadKey();
        }
    }
}
