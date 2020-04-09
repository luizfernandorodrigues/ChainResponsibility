using System;

namespace ChainResponsibility
{
    public class ConcretHandler1 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 0 && request < 10)
                Console.WriteLine("{0} Handled Request {1}", GetType().Name, request);
            else if (sucessor != null)
                sucessor.HandlerRequest(request);

        }
    }
}
