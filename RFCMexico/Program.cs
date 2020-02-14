using System;

namespace RFCMexico
{
    class Program
    {
        public static void Main(string[] args)
        {

            RFCMexico mexico = new RFCMexico 
            { 
                PrimeiroNome = "Tetes", 
                SegundoNome = "Test", 
                TerceiroNome = " aa", 
                DtNascimento = DateTime.Now 
            };

            mexico.GerarRFC(mexico);

        }
    }
}
