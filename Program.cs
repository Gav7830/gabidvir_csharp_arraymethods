using System;
namespace ArrayMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            //Append(new int[] { 1, 2 }, 3);
            //Print(Append(new int[] {1,4,1,5,9,2 }, 1));
            //Print(GetIndexes(new int[] { 1, 5, 1, 5, 9, 2 }, 5));
            //Print(GetItemsAbove(new int[] { 1, 4, 1, 5, 9, 2 }, 4));
            //Print(GetItemsExcept(new int[] { 1, 4, 1, 5, 9, 2 }, 1));
            //Print(GetAllContains(new int[] { 11,4,15,5,1,29,2 }, 1));
          // Print(GetSorted(new int[] { 3, 6, 1, 2 }));
            //Console.WriteLine(AreItemsSame(new int[] { }).ToString());
          



        }

        static int[] Append(int[] arr, int i)
        {
            if (arr == null) return new int[] { i };
            int[] results = new int[arr.Length + 1];

            for (int j = 0; j < arr.Length; j++)
            {
                results[j] = arr[j];
            }
            results[arr.Length] = i;
            return results;
        }

        static int[] GetIndexes(int[] arr, int i)
        {
            if (arr == null) return null;

            int[] tempArr = new int[arr.Length];
            int counter = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] == i)
                {
                    tempArr[counter] = j;
                    counter++;
                }
            }

            if (counter == 0)
            {
                return null;
            }

            int[] results = new int[counter];
            for (int j = 0; j < counter; j++)
            {
                results[j] = tempArr[j];
            }
            return results;

        }


        static int[] GetItemsAbove(int[] arr, int i)
        {
            if (arr == null) return null;

            int[] tempArr = new int[arr.Length];
            int counter = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] > i)
                {
                    tempArr[counter] = arr[j];
                    counter++;
                }
            }

            if (counter == 0)
            {
                return null;
            }

            int[] results = new int[counter];
            for (int j = 0; j < counter; j++)
            {
                results[j] = tempArr[j];
            }
            return results;

        }

        static int[] GetItemsExcept(int[] arr, int i)
        {
            if (arr == null) return null;

            int[] tempArr = new int[arr.Length];
            int counter = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j] != i)
                {
                    tempArr[counter] = arr[j];
                    counter++;
                }
            }

            if (counter == 0)
            {
                return null;
            }

            int[] results = new int[counter];
            for (int j = 0; j < counter; j++)
            {
                results[j] = tempArr[j];
            }
            return results;

        }

        static int[] GetAllContains(int[] arr, int i)
        {

            if (arr == null) return null;
            string str_i = i.ToString();
            int[] tempArr = new int[arr.Length];
            int counter = 0;
            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[j].ToString().Contains(str_i))
                {
                    tempArr[counter] = arr[j];
                    counter++;
                }
            }

            if (counter == 0) return null;



            int[] results = new int[counter];
            for (int j = 0; j < counter; j++)
            {
                results[j] = tempArr[j];
            }
            return results;

        }



        static int[] GetSorted(int[] arr)
        {

            if (arr == null) return null;
            int[] result = new int[arr.Length];
            for (int j = 0; j < arr.Length; j++)
            {
                result[j] = arr[j];
            }
            int temp = 0;
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length; j++)
                {
                    if (result[i] > result[j])
                    {
                        temp = result[i];
                        result[i] = result[j];
                        result[j] = temp;
                    }
                }
            }

            return result;

        }



        static bool AreItemsSame(int[] arr)
        {
          
            if (arr == null) return true;


            for (int j = 0; j < arr.Length; j++)
            {
                if (arr[0] != arr[j]) return false;
            }

            return true;



        }




        static void Print(int[] arr)
        {
            if (arr == null)
            {
                Console.Write("Null");

            }
            else
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }

        }

    }
}

