using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercises
{
    public static class ArrayHelper
    {
        public static int Min(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException(
                    "Array must have at least 1 element",
                    nameof(array));
            }

            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }

            return min;
        }
        public static int Max(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException(
                    "Array must have at least 1 element",
                    nameof(array));
            }
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;



        }
        public static int Sum(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException(
                    "Array must have at least 1 element",
                    nameof(array));
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static int[] VectorInvers(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException(
                    "Array must have at least 1 element",
                    nameof(array));
            }
            int[] inversat = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                inversat[i] = array[array.Length - 1 - i];
            }
            return inversat;
        }
        public static int CalculFrecventa(int[] array, int frecventa)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (array.Length == 0)
            {
                throw new ArgumentException(
                    "Array must have at least 1 element",
                    nameof(array));
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == frecventa)
                {
                    count++;
                }
                ;
            }
            return count;
        }
    }
}
