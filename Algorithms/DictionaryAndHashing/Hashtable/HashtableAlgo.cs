using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.DictionaryAndHashing.Hashtable
{
    internal class HashtableAlgo
    {
        public static Dictionary<int, int> FindFrequency(int[] arr)
        {
            Dictionary<int, int> frequency = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (frequency.ContainsKey(arr[i]))
                {
                    frequency[arr[i]]++;
                }
                else
                {
                    frequency.Add(arr[i], 1);
                }
            }

            return frequency;
        }
    }
}
