using System;
using System.Collections.Generic;
using System.Text;

namespace RFCMexico
{
    public class RFCMexico
    {

        public string GerarRFC(string primeiroNome, string segundoNome, string terceiroNome, int nascDia, int nascMes, int nascAno)
        {
            return "";
        }

        private string ClearString(string palavra)
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

        private string GerarParteComum(string primeiroNome, string segundoNome, string terceiroNome, int nascDia, int nascMes, int nascAno)
        {

            return "";
        }

        private string ObterLetrasRFC(string primeiroNome, string segundoNome, string terceiroNome)
        {

        }
    }
}
