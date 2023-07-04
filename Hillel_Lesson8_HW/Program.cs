
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
                threads[i] = new Thread(_ =>
                {
                    int numberTmp = rnd.Next(1, 101);

                    lock(lockObject)
                    if (numberTmp % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                });
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine("EVEN COUNT: {0}", even);
            Console.WriteLine("ODD COUNT: {0}", odd);

            Console.ReadKey();
        }

    }
}
