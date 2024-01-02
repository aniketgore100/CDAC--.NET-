namespace arrays
{
    internal class Program
    {
        static void Main()
        {
            //int[] arr = new int[5];
            //for (int i=0; i<arr.Length; i++)
            //{
            //    // Console.Write("enter the value for for arr["+i.ToString() + "]:");
            //    //Console.Write($"enter the value for arr[{i}]");
            //    Console.Write("enter the value for arr[{0}]: ", i);
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //foreach(int i in arr)
            //{
            //    Console.WriteLine(i);
            //}

            //int[,] arr = new int[3, 5];
            //for (int i = 0; i<arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j<arr.GetLength(1); j++)
            //    {
            //        arr[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i<arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j<arr.GetLength(1); j++)
            //    {
            //        Console.WriteLine(arr[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            //int[] arr = new int[5];
            //for (int i = 0; i<arr.Length; i++)
            //{
            //    //arr[i] = Convert.ToInt32(Console.ReadLine());
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine();
            //Console.WriteLine("index is :" + Array.IndexOf(arr, 30));
            //Console.WriteLine("last occurence is :" + Array.LastIndexOf(arr, 50));
            //Console.WriteLine("index is :" + Array.BinarySearch(arr, 50));
            //Array.Reverse(arr);

            //Console.WriteLine();

            //for (int i = 0; i<arr.Length; i++)
            //{
            //    Console.WriteLine("array after reverse   : " + arr[i]);
            //}
            //Array.Sort(arr);


            //Console.WriteLine();
            //for (int i = 0; i<arr.Length; i++)
            //{
            //    Console.WriteLine("array after sort : " + arr[i]);
            //}





           

            int[][] arr = new int[4][];
            for (int i = 0; i < arr.Length; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());

                arr[i] = new int[x];
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("enter value for subscript [{0}][{1}] : ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("value for subscript {0},{1} is {2}  ", i, j, arr[i][j]);

                }
            }
            Console.ReadLine();
        }
    }
    
}