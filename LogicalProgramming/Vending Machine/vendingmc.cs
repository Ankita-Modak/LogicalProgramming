using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgramming.Vending_Machine
{
    internal class vendingmc
    {
        static int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };

        public static void GetNotes()
        {
             
            
            Console.Write("Enter the change to be returned: ");
            int change = int.Parse(Console.ReadLine());

            //calculate no. of notes
            int[] notesCount = new int[notes.Length];
            CalculateNotes(change, notesCount, 0);

            int totalNotes = 0;
            for (int i = 0; i < notes.Length; i++)
            {
                if (notesCount[i] > 0)
                {
                    Console.WriteLine(notesCount[i] + " notes of Rs " + notes[i]);
                    totalNotes += notesCount[i];
                }
            }
            Console.WriteLine("Total number of notes: " + totalNotes);
        }

        //calculate minimum number of notes
        static void CalculateNotes(int change, int[] notesCount, int index)
        {
            if (change == 0) return;

            int note = notes[index];
            int count = change / note;

            if (count > 0)
            {
                notesCount[index] = count;
                change -= note * count;
            }

            CalculateNotes(change, notesCount, index + 1);
        }
    }
}

