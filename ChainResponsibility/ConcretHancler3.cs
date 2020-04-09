using System;

namespace ChainResponsibility
{
    public class ConcretHancler3 : Handler
    {
        public override void HandlerRequest(int request)
        {
            if (request >= 20 && request < 30)
                Console.WriteLine("{0} hanlded request {1}", GetType().Name, request);
            else if (sucessor != null)
                sucessor.HandlerRequest(request);
        }
    }
}
