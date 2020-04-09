using System;

namespace ChainResponsibility
{
    public class ConcretHandler2 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 10 && request < 20)
                Console.WriteLine("{0} hanlded request {1}", GetType().Name, request);
            else if (sucessor != null)
                sucessor.HandlerRequest(request);
        }
    }
}
