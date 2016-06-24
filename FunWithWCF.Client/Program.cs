using System;

namespace FunWithWCF.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creating proxy for the Service
            Service1Client client = new Service1Client();
            Console.WriteLine(client.GetData(1));

            var composite = client.GetDataUsingDataContract(new CompositeType
            {
                BoolValue = true,
                StringValue = "test"
            });
            Console.WriteLine(composite.BoolValue);
            Console.WriteLine(composite.StringValue);
            Console.Read();
        }
    }
}
