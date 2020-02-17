using System;
using System.Globalization;


namespace RFCMexico
{
    public class RFCMexico
    {
        public string PrimeiroNome { get; set; }
        public string SegundoNome { get; set; }
        public string TerceiroNome { get; set; }
        public DateTime DtNascimento { get; set; }
        private string NascDia { get; set; }
        private string NascMes { get; set; }
        private string NascAno { get; set; }


        public string GerarRFC(RFCMexico rfcMexico)
        {
            RFCMexico mexico = new RFCMexico
            {
                PrimeiroNome = RemoveNomesComuns(RemovePrefixos(LimpaString(rfcMexico.PrimeiroNome.ToUpper()))),
                SegundoNome = RemovePrefixos(LimpaString(rfcMexico.SegundoNome.ToUpper())),
                TerceiroNome = RemovePrefixos(LimpaString(rfcMexico.TerceiroNome.ToUpper())),
                NascDia = rfcMexico.DtNascimento.ToString("dd", CultureInfo.InvariantCulture),
                NascMes = rfcMexico.DtNascimento.ToString("MM", CultureInfo.InvariantCulture),
                NascAno = rfcMexico.DtNascimento.ToString("yy", CultureInfo.InvariantCulture)
            };

            return GerarParteComum(mexico);
        }

        private string LimpaString(string palavra)
        {
            string comAcentos = "ÄÅÁÂÀÃäáâàãÉÊËÈéêëèÍÎÏÌíîïìÖÓÔÒÕöóôòõÜÚÛüúûùÇç";
            string semAcentos = "AAAAAAaaaaaEEEEeeeeIIIIiiiiOOOOOoooooUUUuuuuCc";

            for (int i = 0; i < comAcentos.Length; i++)
            {
                palavra = palavra.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
            }

            return palavra;
        }

        private string RemovePrefixos(string nome)
        {
            string[] prefixos = new string[] {"PARA ", "AND ", "CON ", "DEL ", "LAS ",
                                              "LOS ", "MAC ", "POR ", "SUS ",
                                              "THE ", "VAN ", "VON ", "AL ",
                                              "DE ", "EL ","EN ", "LA ", "MC ",
                                              "MI ", "OF ", " A ", " E ", "Y ",
                                              "DE LOS ", "LOS "};

            foreach (var item in prefixos)
            {
                if (nome.Contains(item))
                {
                    nome = nome.Replace(item, string.Empty);
                }
            }
            return nome;
        }

        private string RemoveNomesComuns(string nome)
        {
            string[] naoNomes = new string[] { "MARIA DEL ", "MARIA DE LOS ",
                                               "MARIA ", " JOSE DE ", "JOSE ",
                                               "MA. ",  "MA ", "M. ", "J. ", "J "};

            foreach (var item in naoNomes)
            {
                if (nome.Contains(item))
                {
                    nome = nome.Replace(item, string.Empty);
                }
            }
            return nome;
        }

        private string GerarParteComum(RFCMexico mexico)
        {
            var x = ObterLetrasRFC(mexico.PrimeiroNome, mexico.SegundoNome, mexico.TerceiroNome);
            x = RemovePalavrasNaoAceitas(x);
            x += mexico.NascAno.ToString();
            x += mexico.NascMes;
            x += mexico.NascDia;

            return x;
        }

        private string ObterLetrasRFC(string primeiroNome, string segundoNome, string terceiroNome)
        {
            string letras;

            string[] vogais = new string[] { "A", "E", "I", "O", "U" };
            string vogal = string.Empty;

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
                bool eVogal = false;

                for (int i = 1; i <= segundoNome.Length - 1; i++)
                {
                    for (int x = 0; x < vogais.Length; x++)
                    {
                        if (segundoNome.Substring(i, 1) == vogais[x])
                        {
                            vogal = segundoNome.Substring(i, 1);
                            eVogal = true;
                        }
                    }
                    if (eVogal)
                    {
                        break;
                    }
                }
                letras = segundoNome[0] + vogal + terceiroNome[0] + primeiroNome[0];
            }
            return letras;
        }

        private string RemovePalavrasNaoAceitas(string palavra)
        {
            string[] palavrasNaoAceitas = new string[] { "BUEI",
                                                        "BUEY","CACA","CACO","CAGA","CAGO","CAKA",
                                                        "COGE","COJA","COJE","COJI","COJO","CULO",
                                                        "FETO","GUEY","JOTO","KACA","KACO","KAGA",
                                                        "KAGO","KOGE","KOJO","KAKA","KULO","MAME",
                                                        "MAMO","MEAR","MEON","MION","MOCO","MULA",
                                                        "PEDA","PEDO","PENE","PUTA","PUTO","QULO",
                                                        "RATA","RUIN"};
            foreach (var item in palavrasNaoAceitas)
            {
                palavra = palavra == item ? palavra.Substring(0, 3) + "X" : palavra;
            }
            return palavra;
        }
    }
}
