using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace Buscador3
{
    public partial class Form1 : Form
    {
        static int bgn, end;
        static string line1, line2;
        static string[] commonWords = {"a", "about", "above", "according", "across", "actually", "adj", "after", "afterwards", "again",
                                       "all", "almost", "alone", "along", "already", "also", "although", "always", "among", "amongst",
                                       "an", "and", "another", "any", "anybody", "anyhow", "anyone", "anything", "anywhere", "are",
                                       "area", "areas", "aren't", "around", "as", "ask", "asked", "asking", "asks", "at",
                                       "away", "b", "back", "backed", "backing", "backs", "be", "became", "because", "become",
                                       "becomes", "becoming", "been", "before", "beforehand", "began", "begin", "beginning", "behind", "being",
                                       "beings", "below", "beside", "besides", "best", "better", "between", "beyond", "big", "billion", "both",
                                       "but", "by", "c", "came", "can", "cannot", "can't", "caption", "case", "cases", "certain",
                                       "certainly", "clear", "clearly", "co", "come", "could", "couldn't", "d", "day", "did", "didn´t",
                                       "differ", "different", "differently", "do", "does", "doesn't", "done", "don't", "down", "downed",
                                       "downing", "downs", "during", "e", "each", "early", "eg", "eight", "eighty", "either", "else",
                                       "elsewhere", "end", "ended", "ending", "ends", "enough", "etc", "even", "evenly",
                                       "everybody", "everyone", "everything", "everywhere", "except", "f", "face",
                                       "far", "felt", "few", "fifty", "find", "finds", "first", "fiver", "for", "former",
                                       "found", "four", "from", "further", "furthered", "furthering", "furthers", "g",
                                       "generally", "get", "gets", "give", "given", "gives", "go", "going", "good",
                                       "greater", "greatest", "group", "grouped", "grouping", "groups", "h", "had",
                                       "haven't", "having", "he", "he'd", "he'll", "hence", "her", "here", "hereafter",
                                       "here's", "hereupon", "hers", "herself", "he's", "high", "higher", "highest",
                                       "how", "however", "hundred", "I", "i'd", "ie", "if", "i'll", "i'm", "important",
                                       "instead", "interest", "interested", "interesting", "interests", "into", "is",
                                       "it's", "itself", "i've", "j", "just", "kl", "know", "large", "largely", "last",
                                       "latter", "latterly", "least", "less", "let", "lets", "let's", "like", "likely",
                                       "longest", "look", "ltd", "m", "made", "make", "makes", "making", "man", "many",
                                       "meantime", "meanwhile", "member", "members", "men", "might", "million", "miss",
                                       "most", "mostly", "mr", "mrs", "much", "must", "my", "myself", "n", "namely",
                                       "needed", "needing", "needs", "neither", "never", "nevertheless", "noone", "nor",
                                       "nowhere", "number", "numbers", "o", "of", "off", "often", "old", "older", "oldest",
                                       "one's", "only", "onto", "open", "opened", "opens", "or", "order", "ordered",
                                       "others", "otherwise", "our", "ours", "ourselves", "out", "over", "overall",
                                       "parting", "parts", "people", "per", "perhaps", "place", "places", "point", "points",
                                       "possible", "present", "presented", "presenting", "presents", "problem", "problems",
                                       "quite", "r", "rather", "really", "recent", "recently", "right", "room", "rooms",
                                       "say", "says", "second", "seconds", "see", "seem", "seemed", "seeming", "seems",
                                       "she", "she'd", "she'll", "she's", "should", "shouldn't",
                                       "six", "sixty", "small", "smaller", "smallest", "so", "some",
                                       "sometime", "sometimes", "somewhere", "state", "states", "still",
                                       "taking", "ten", "than", "that", "that'll", "that's", "that've",
                                       "thence", "there", "thereafter", "thereby", "there'd", "therefore",
                                       "thereupon", "there've", "these", "they", "they'd", "they'll",
                                       "thinks", "thirty", "this", "those", "though","thought",
                                       "thru", "thus", "time", "to", "today", "together", "too",
                                       "turning", "turns", "twenty", "two", "u", "under", "unless",
                                       "used", "uses", "using", "v", "very", "via", "w", "want",
                                       "we", "we'd", "well", "we'll", "wells", "were", "we're",
                                       "what've", "when", "whence", "whenever", "where", "whereafter",
                                       "who's", "whose", "why", "will", "with", "within", "without",
                                       "wouldn't", "xy", "year", "years", "yes", "yet", "you", "you'd",
                                       "you're", "yours", "yourself", "yourselves", "you've", "z", ""};

        public Form1()
        {
            InitializeComponent();
        }

        private void clearResult01_Click(object sender, EventArgs e)
        {
            preview1.Clear();
        }

        private void clearResult02_Click(object sender, EventArgs e)
        {
            preview2.Clear();
        }

        private void palabrasRepetidas_Click(object sender, EventArgs e)
        {
            DbConnect dbc = new DbConnect();
            Stopwatch time = new Stopwatch();
            try
            {
                time.Start();
                MySqlDataReader reader = dbc.SelectPalabrasRepetidas();
                int i = 1;
                while (reader.Read())
                {
                    preview2.AppendText(i + ".-" + reader.GetString(0) +
                                        " --- " + reader.GetString(1) +
                                        " --- " + reader.GetString(2) +
                                        "\r\n");
                    i++;
                }
                time.Stop();
                preview2.AppendText($"Tiempo: {time.Elapsed.TotalMilliseconds} milisegundos. \r\n");
                preview2.AppendText($"Tiempo: {time.Elapsed.TotalSeconds} segundos. \r\n");

            }
            catch (MySqlException ex)
            {
                preview2.AppendText("Exception: " + ex.Message + "\r\n");
            }
        }

        private void buscarPalabra_Click(object sender, EventArgs e)
        {
            DbConnect dbc = new DbConnect();
            Stopwatch time = new Stopwatch();
            try
            {
                time.Start();
                MySqlDataReader reader = dbc.SelectPalabra(buscar.Text);
                int i = 1;
                while (reader.Read())
                {
                    preview3.AppendText(i + ".- " + reader.GetString(0) +
                                        " --- " + reader.GetString(1) +
                                        " --- " + reader.GetString(2) +
                                        "\r\n");
                    i++;
                }
                time.Stop();
                preview3.AppendText($"Tiempo: {time.Elapsed.TotalMilliseconds} milisegundos. \r\n");
                preview3.AppendText($"Tiempo: {time.Elapsed.TotalSeconds} segundos. \r\n");
            }
            catch (MySqlException ex)
            {
                preview3.AppendText("Exception: " + ex.Message + "\r\n");
            }
        }

        private void cargarCarpeta_Click(object sender, EventArgs e)
        {
            DbConnect dbc = new DbConnect();
            Stopwatch time = new Stopwatch();
            string rmv, file, folder;
            string[] words;
            int i, j;
            Boolean compare;

            WindowLoadFile.ShowDialog();
            time.Start();
            i = 2;
            j = 1;
            file = WindowLoadFile.FileName;
            folder = System.IO.Path.GetDirectoryName(file);
            DirectoryInfo di = new DirectoryInfo(folder);
            preview1.AppendText("Inicio de limpieza");
            foreach (var fi in di.GetFiles())
            {
                try
                {
                    //StreamWriter sw = new StreamWriter(folder + @"\res\r_" + i + ".txt");
                    preview1.AppendText(folder + @"\" + fi.Name + "---" + folder + @"\res\r_" + i + ".txt \r\n");
                    StreamReader sr = new StreamReader(folder + @"\" + fi.Name);
                    line1 = sr.ReadLine();
                    //Preview.AppendText(" " + i + ", ");
                    while (line1 != null)
                    {
                        bgn = line1.IndexOf("<");
                        end = line1.IndexOf(">");
                        tagSearch(bgn, end);
                        while (bgn != -1 || end != -1)
                        {
                            rmv = line1.Substring(bgn, end - bgn + 1);
                            line2 = line1.Replace(rmv, "");
                            //preview1.AppendText($"Resultado: {line2} \r\n");
                            //preview1.AppendText(" " + i + ",");
                            line1 = line2;
                            bgn = line1.IndexOf("<");
                            end = line1.IndexOf(">");
                            tagSearch(bgn, end);
                        }
                        if (line1 != "")
                        {
                            words = line1.Split(' ');
                            foreach (var w in words)
                            {
                                /*compare = compareWords(w);
                                if (w != "" && compare == false)
                                {*/
                                //insert into palabras values (1,"hola","007");
                                line2 = "insert into palabras values (" + j + ",\"" + w + "\",\"" + fi.Name + "\");";
                                dbc.InsertDb(line2);
                                //sw.WriteLine(w);
                                j++;
                                /*if (j == 345)
                                {
                                    Preview.AppendText("alto");
                                }*/

                                //}
                            }
                            //sw.WriteLine(line1);
                        }
                        line1 = sr.ReadLine();
                    }
                    line1 = null;
                    line2 = null;
                    bgn = 0;
                    end = 0;
                    //sw.Close();
                    //sw.FlushAsync();
                    //sr.Close();
                    i++;
                }
                catch (Exception ex)
                {
                    preview1.AppendText("Exception: " + ex.Message + "\r\n");
                    preview1.AppendText("Result: " + ex.HResult + "\r\n");
                    //break;
                }
            }
            preview1.AppendText("Fin de limpieza\r\n");
            time.Stop();
            preview1.AppendText($"Tiempo: {time.Elapsed.TotalMilliseconds} milisegundos.\r\n");
            preview1.AppendText($"Tiempo: {time.Elapsed.TotalSeconds} segundos.\r\n");
        }

        private void clearResult03_Click(object sender, EventArgs e)
        {
            preview3.Clear();
        }

        public static void tagSearch(int a, int b)
        {
            if (bgn != -1 && end == -1)
            {
                bgn = 0;
                end = line1.Length - 1;
            }
            if (bgn == -1 && end != -1)
            {
                bgn = 0;
            }
            if (bgn > end)
            {
                bgn = 0;
            }
        }

        public static Boolean compareWords(string w)
        {
            Boolean cmp = false;
            string word = w.ToLower();
            int i;
            i = 0;
            do
            {
                if (commonWords[i].Equals(word)) cmp = true;
                else i++;
            } while (cmp == false && i != commonWords.Length - 1);
            return cmp;
        }


    }
}