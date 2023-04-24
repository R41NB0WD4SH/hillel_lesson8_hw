

namespace Hillel_Lesson8_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            int even = 0;
            int odd = 0;

            Random rnd = new Random();
            
            object lockObject = new object();

            Thread[] threads = new Thread[10];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = CreateNewThread(ref even, ref odd, rnd, lockObject);
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
                threads[i].Join();
            }
       


            Console.WriteLine("EVEN COUNT: {0}", even);
            Console.WriteLine("ODD COUNT: {0}", odd);

            Console.ReadKey();



        }

        public static Thread CreateNewThread(ref int even, ref int odd, Random rnd, object lockObject)
        {

            int evenTmp = even;
            int oddTmp = odd;
            
            Thread t1 = new Thread(_ =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int number = rnd.Next(1, 101);

                    lock (lockObject)
                    {
                        if (number % 2 == 0)
                        {
                            evenTmp++;
                        }
                        else
                        {
                            oddTmp++;
                        }
                    }
                }
            });

            even += evenTmp;
            odd += oddTmp;

            return t1;
        }



    }
}