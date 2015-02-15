using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1213
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 2, 2, 2, 2, 1, 2, 3, 3, 3, 3, 3, 2, 2, 2, 1 };
            int maxSequence = 1;
            int currentSequence = 1;
            int indexOfcurrent = 0;
            int indexOfMax = 0;
            // for-loop to iterate through array
            for (int i = 1; i < array.Length; i++)
            {
                // get the current element for the iteration
                int current = array[i - 1];
                // get the next element for the iteration
                int next = array[i];
                // if we don't have a sequence already and the current and next elements are equal, the begining of a new sequence of equal elements
                if (current == next && currentSequence == 1)
                {
                    // we increment the sequence counter
                    currentSequence++;
                    // get the index of the first element of the new sequence(the index of current)
                    indexOfcurrent = i - 1;
                }
                // if we HAVE a sequence already and the current and next elements are equal we just increment the sequence counter
                else if (current == next)
                {
                    currentSequence++;
                }
                // if the sequence is broken check if it is biger or equal to the maximum sequence that we have seen so far
                else
                {
                    // if the current sequence that was just broken is bigger than the max seq we've seen then set a new maxsequence equal to
                    // the current one and set the index of the max seq to the current one
                    if (maxSequence <= currentSequence)
                    {
                        maxSequence = currentSequence;
                        currentSequence = 1;
                        indexOfMax = indexOfcurrent;
                        indexOfcurrent = 0;
                    }
                }
            }
            string result = "";
            for (int i = indexOfMax; i < indexOfMax + maxSequence; i++)
            {
                // ""
                // "" + 3 + ", "
                // "3, " + 3 + ", "
                // "3, 3, " + 3 + ", "
                result += array[i] + ", ";
            }
            result = result.Remove(result.Length - 2);
            Console.WriteLine(result);
        }
    }
}