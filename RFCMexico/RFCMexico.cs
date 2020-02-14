using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;


namespace RFCMexico
{
    public class RFCMexico
    {
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public string TerceiroNome { get; set; }
        public DateTime DtNascimento { get; set; }
        public int NascDia { get; set; }
        public int NascMes { get; set; }
        public int NascAno { get; set; }




        public string GerarRFC(RFCMexico rfcMexico)
        {
            RFCMexico mexico = new RFCMexico
            {
                PrimeiroNome = RemoveNomesComuns(RemovePrefixos(LimpaString(rfcMexico.PrimeiroNome))),
                SegundoNome = RemovePrefixos(LimpaString(rfcMexico.SegundoNome)),
                TerceiroNome = RemovePrefixos(LimpaString(rfcMexico.TerceiroNome)),
                NascDia = rfcMexico.DtNascimento.Day,
                NascMes = rfcMexico.DtNascimento.Month,
                NascAno = rfcMexico.DtNascimento.Year
            };

            return GerarParteComum(mexico);
        }

        private string LimpaString(string palavra)
        {

            return "";
        }

        private string RemoveAcentos(string palavra)
        {

            return "";
        }

        private string RemovePrefixos(string nome)
        {

            string[] prefixos = new string[] {"PARA ", "AND ", "CON ", "DEL ", "LAS ",
                                              "LOS ", "MAC ", "POR ", "SUS ",
                                              "THE ", "VAN ", "VON ", "AL ",
                                              "DE ", "EL ","EN ", "LA ", "MC ",
                                              "MI ", "OF ", "A ", "E ", "Y ",
                                              "DE LOS", "LOS "};



            return "";
        }

        private string RemoveNomesComuns(string nome)
        {
            string[] naoNomes = new string[] { "MARIA DEL ", "MARIA DE LOS ",
                                               "MARIA ", "JOSE DE ", "JOSE ",
                                               "MA. ",  "MA ", "M. ", "J. ", "J "};

            return "";
        }

        private string GerarParteComum(RFCMexico mexico)
        {

            return "";
        }

        private string ObterLetrasRFC(string primeiroNome, string segundoNome, string terceiroNome)
        {
            string letras;

            if (terceiroNome.Length == 0)
            {
                letras = segundoNome.Substring(0, 2) + primeiroNome.Substring(0, 2);
            }
            else if (segundoNome.Length < 3)
            {
                letras = segundoNome.Substring(0, 1) + terceiroNome.Substring(0, 1) + primeiroNome.Substring(0, 2);
            }
            else
            {
                bool eVogal = new Regex(@"^[AEIOU]").IsMatch(segundoNome.Substring(0, 1));
                letras = segundoNome[0] + (eVogal == true ? segundoNome.Substring(0, 1) : "") + terceiroNome[0] + primeiroNome[0];
            }
            return letras;
        }

        private string RemovePalavrasNaoAceitas()
        {
            string[] palavrasNaoAceitas = new string[] { };


            return "";
        }
    }
}
