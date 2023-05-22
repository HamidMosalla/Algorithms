using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Sort.Merge_Sort
{
    internal class MergeSortAlgo
    {

        public static void MergeSort(int[] arr, int l, int r)
        {
            if (l >= r) return;

            int m = l + (r - l) / 2;

            MergeSort(arr, l, m);
            MergeSort(arr, m + 1, r);

            Merge(arr, l, m, r);
        }

        public static void Merge(int[] arr, int l, int m, int r)
        {
            int[] temp = new int[r - l + 1];
            int left = l;
            int right = m + 1;
            int k = 0;

            while (left <= m && right <= r)
            {
                if (arr[left] <= arr[right])
                {
                    temp[k++] = arr[left++];
                }
                else
                {
                    temp[k++] = arr[right++];
                }
            }

            while (left <= m)
            {
                temp[k++] = arr[left++];
            }

            while (right <= r)
            {
                temp[k++] = arr[right++];
            }

            for (int i = 0; i < temp.Length; i++)
            {
                arr[l + i] = temp[i];
            }
        }

    }
}
