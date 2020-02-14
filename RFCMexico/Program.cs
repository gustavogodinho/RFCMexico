using System;

namespace RFCMexico
{
    class Program
    {
        public static void Main(string[] args)
        {

            RFCMexico mexico = new RFCMexico 
            { 
                PrimeiroNome = "Juan", 
                SegundoNome = "Barrios", 
                TerceiroNome = "Fernández", 
                DtNascimento = DateTime.Now
            };

            var r = mexico.GerarRFC(mexico);

            Console.WriteLine(r);


        }
    }
}
