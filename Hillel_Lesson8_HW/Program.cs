

namespace Hillel_Lesson8_HW
{
    class Program
    {
        static void Main(string[] args)
        {

            int even = 0;
            int odd = 0;

            Random rnd = new Random();
            
            var lockObject = new object();

            Thread t1 = new Thread(_ =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int number = rnd.Next(1, 101);

                    lock (lockObject)
                    {
                        if (number % 2 == 0)
                        {
                            even++;
                        }
                        else
                        {
                            odd++;
                        }
                    }
                }
            });
            
            Thread t2 = new Thread(_ =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int number = rnd.Next(1, 101);

                    lock (lockObject)
                    {
                        if (number % 2 == 0)
                        {
                            even++;
                        }
                        else
                        {
                            odd++;
                        }
                    }
                }
            });
            
            Thread t3 = new Thread(_ =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int number = rnd.Next(1, 101);

                    lock (lockObject)
                    {
                        if (number % 2 == 0)
                        {
                            even++;
                        }
                        else
                        {
                            odd++;
                        }
                    }
                }
            });
            
            Thread t4 = new Thread(_ =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int number = rnd.Next(1, 101);

                    lock (lockObject)
                    {
                        if (number % 2 == 0)
                        {
                            even++;
                        }
                        else
                        {
                            odd++;
                        }
                    }
                }
            });
            
            Thread t5 = new Thread(_ =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int number = rnd.Next(1, 101);

                    lock (lockObject)
                    {
                        if (number % 2 == 0)
                        {
                            even++;
                        }
                        else
                        {
                            odd++;
                        }
                    }
                }
            });
            
            Thread t6 = new Thread(_ =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int number = rnd.Next(1, 101);

                    lock (lockObject)
                    {
                        if (number % 2 == 0)
                        {
                            even++;
                        }
                        else
                        {
                            odd++;
                        }
                    }
                }
            });
            
            Thread t7 = new Thread(_ =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int number = rnd.Next(1, 101);

                    lock (lockObject)
                    {
                        if (number % 2 == 0)
                        {
                            even++;
                        }
                        else
                        {
                            odd++;
                        }
                    }
                }
            });
            
            Thread t8 = new Thread(_ =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int number = rnd.Next(1, 101);

                    lock (lockObject)
                    {
                        if (number % 2 == 0)
                        {
                            even++;
                        }
                        else
                        {
                            odd++;
                        }
                    }
                }
            });
            
            Thread t9 = new Thread(_ =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int number = rnd.Next(1, 101);

                    lock (lockObject)
                    {
                        if (number % 2 == 0)
                        {
                            even++;
                        }
                        else
                        {
                            odd++;
                        }
                    }
                }
            });
            
            Thread t10 = new Thread(_ =>
            {
                for (int i = 0; i < 100; i++)
                {
                    int number = rnd.Next(1, 101);

                    lock (lockObject)
                    {
                        if (number % 2 == 0)
                        {
                            even++;
                        }
                        else
                        {
                            odd++;
                        }
                    }
                }
            });
            
            
            t1.Start();
            t2.Start();
            t3.Start();
            t4.Start();
            t5.Start();
            t6.Start();
            t7.Start();
            t8.Start();
            t9.Start();
            t10.Start();
            
            t1.Join();
            t2.Join();
            t3.Join();
            t4.Join();
            t5.Join();
            t6.Join();
            t7.Join();
            t8.Join();
            t9.Join();
            t10.Join();


            Console.WriteLine("EVEN COUNT: {0}", even);
            Console.WriteLine("ODD COUNT: {0}", odd);

            Console.ReadKey();



        }
    }
}