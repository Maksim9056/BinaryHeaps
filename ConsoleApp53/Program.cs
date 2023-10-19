namespace ConsoleApp53
{
    internal class Program
    {
        static void Main(string[] args)
        {


            BinaryHeap binaryHeap = new BinaryHeap();
            int[] d = new int[] { 4, 8, 10, 20, 5, 6, 13, 12, 25, 15, 14, 0, 26, 9, 3, 1, 19, 2, 24, 28, 17, 23, 27, 7, 11, 29, 21, 30, 22, 18, 16 };

            foreach (int i in d)
            {
                binaryHeap.Insert(i);
            }

             Console.WriteLine("Root");
             binaryHeap.Print();
              binaryHeap.Delete(4);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
            binaryHeap.Print();

            Console.ReadLine();

        }
    }
}