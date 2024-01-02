namespace arrayAssign
{
    internal class Program
    {
        static void Main()
        {


            int batches = Convert.ToInt32(Console.ReadLine());
            int[][] arr = new int[batches][];
            for (int i = 0; i<batches; i++)
            {
                Console.WriteLine("enter number of students in batch {0}", i+1);

                int students = Convert.ToInt32(Console.ReadLine());
                arr[i] = new int[students];

                for (int j = 0; j<students; j++)
                {
                    Console.Write("Enter mark for student {0} in batch {1}: ", j + 1, i + 1);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }

              
            }
            Console.WriteLine("Student Marks:");

            for (int i = 0; i < batches; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("Mark for student {0} in batch {1} is {2}", j + 1, i + 1, arr[i][j]);
                }
            }

            Console.ReadLine();
        }
    }
}