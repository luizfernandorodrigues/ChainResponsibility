using System;

namespace ChainResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handler = new ConcretHandler1();
            Handler handler1 = new ConcretHandler2();
            Handler handler3 = new ConcretHancler3();

            handler.SetSucessor(handler1);
            handler1.SetSucessor(handler3);

            int[] requests = { 2, 5, 24, 22, 18, 3, 27, 20 };

            foreach (int item in requests)
                handler.HandlerRequest(item);

            Console.ReadKey();
            
        }
    }
}
