using System;
using System.Collections.Generic;

namespace RFCMexico
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Teste 
            Mexico();

        }

        public  static void Mexico()
        {
            // --------------E J E M P L O S--------------

            List<RFCMexico> rFCMexicos = new List<RFCMexico>();

            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Juan", SegundoNome = "Barrios", TerceiroNome = "Fernández", DtNascimento = new DateTime(1970, 12, 13) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Eva", SegundoNome = "Iriarte", TerceiroNome = "Mendez", DtNascimento = new DateTime(1969, 11, 17) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Francisco", SegundoNome = "Ortíz", TerceiroNome = "Pérez", DtNascimento = new DateTime(1929, 02, 05) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Manuel", SegundoNome = "Martínez", TerceiroNome = "Hernández", DtNascimento = new DateTime(1957, 01, 02) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Gabriel", SegundoNome = "Courturier", TerceiroNome = "Moreno", DtNascimento = new DateTime(1960, 07, 03) });
            // Regla 3
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Manuel", SegundoNome = "Chávez", TerceiroNome = "González", DtNascimento = new DateTime(1924, 06, 18) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Felipe", SegundoNome = "Camargo", TerceiroNome = "Llamas", DtNascimento = new DateTime(1945, 02, 28) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Charles", SegundoNome = "Kennedy", TerceiroNome = "Truman", DtNascimento = new DateTime(1951, 10, 12) });
            //Regla 4
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Alvaro", SegundoNome = "de la O", TerceiroNome = "Lozano", DtNascimento = new DateTime(1940, 12, 01) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Ernesto", SegundoNome = "Ek", TerceiroNome = "Rivera", DtNascimento = new DateTime(1907, 11, 20) });
            //Regla 5
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Dolores", SegundoNome = "San Martín", TerceiroNome = "Dávalos", DtNascimento = new DateTime(1918, 08, 12) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Mario", SegundoNome = "Sánchez de la Barquera", TerceiroNome = "Gómez", DtNascimento = new DateTime(1919, 02, 24) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Mario", SegundoNome = "Sánchez", TerceiroNome = "de la Barquera Gómez", DtNascimento = new DateTime(1919, 02, 24) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Antonio", SegundoNome = "Jiménez", TerceiroNome = "Ponce de León", DtNascimento = new DateTime(1917, 08, 08) });
            //Regla 6
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Luz María", SegundoNome = "Fernández", TerceiroNome = "Juárez", DtNascimento = new DateTime(1920, 02, 05) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "J. Antonio", SegundoNome = "Camargo", TerceiroNome = "Hernández", DtNascimento = new DateTime(1921, 12, 18) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "María Luisa", SegundoNome = "Ramírez", TerceiroNome = "Sánchez", DtNascimento = new DateTime(1925, 11, 12) });
            //Regla 7
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Juan", SegundoNome = "Martínez", TerceiroNome = "", DtNascimento = new DateTime(1942, 01, 16) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Gerarda", SegundoNome = "Zafra", TerceiroNome = "", DtNascimento = new DateTime(1925, 11, 15) });
            ////Regla 8
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Carmen", SegundoNome = "de la Peña", TerceiroNome = "Ramírez", DtNascimento = new DateTime(1963, 12, 01) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Mario", SegundoNome = "Sánchez", TerceiroNome = "de los Cobos", DtNascimento = new DateTime(1970, 11, 10) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Roberto", SegundoNome = "González", TerceiroNome = "y Durán", DtNascimento = new DateTime(1960, 01, 01) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Juan", SegundoNome = "del Valle", TerceiroNome = "Martínez", DtNascimento = new DateTime(1969, 10, 01) });
            ////Regla 9
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Alberto", SegundoNome = "Carmona", TerceiroNome = "Carranza", DtNascimento = new DateTime(1963, 12, 01) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Yazmín", SegundoNome = "Bustos", TerceiroNome = "Estrada", DtNascimento = new DateTime(1970, 11, 10) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Alejandra", SegundoNome = "Músquiz", TerceiroNome = "Lara", DtNascimento = new DateTime(1960, 01, 01) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Orlando", SegundoNome = "Puentes", TerceiroNome = "Torrado", DtNascimento = new DateTime(1969, 10, 01) });
            ////Regla 10
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Roberto", SegundoNome = "O’farril", TerceiroNome = "Carballo", DtNascimento = new DateTime(1963, 12, 01) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Rubén", SegundoNome = "D’angelo", TerceiroNome = "Fargo", DtNascimento = new DateTime(1970, 11, 10) });
            rFCMexicos.Add(new RFCMexico() { PrimeiroNome = "Luz Ma.", SegundoNome = "Fernández", TerceiroNome = "Juárez", DtNascimento = new DateTime(1960, 01, 01) });

            RFCMexico rFC = new RFCMexico();


         

            foreach (var item in rFCMexicos)
            {
                Console.WriteLine(rFC.GerarRFC(item));
            }


            Console.ReadKey();

        }
    }
}
