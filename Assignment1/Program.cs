
namespace cpsc360
{
    public class Program
    {
        
        public static bool[] process(char[,] letters, string[,] words)
        {
            bool[] answer = new bool[words.GetLength(0)];
            for (int i = 0; i < words.GetLength(0); i++)
            {
                string w1 = words[i, 0];
                string w2 = words[i, 1];
                string con = "";
                if(w1 == w2)
                {
                    answer[i] = true;
                    break;
                }
                if (w1.Length == w2.Length)
                {

                    for (int l = 0; l < w1.Length; l++)
                    {
                        System.Collections.Generic.List<char> lst = new System.Collections.Generic.List<char>();
                        char let1 = w1[l];
                        char let2 = w2[l];
                        lst.Add(let1);
                        con += rechelp(let1, let2, letters, lst);
                    }
                    if (con == w2)
                    {
                        answer[i] = true;
                    }
                    else if (con == w1)
                    {
                        answer[i] = true;
                    }
                    else
                    {
                        answer[i] = false;
                    }
                }
                else
                {
                    answer[i] = false;
                }
            }
            
            
            return answer;
        }

        public static string rechelp(char one, char two, char[,] lets, System.Collections.Generic.List<char> check)
        {
            string value = "";
            if (one == two)
            {
                value += one;
                return value;
            }
            for (int j = 0; j < lets.GetLength(0); j++)
            {
                char l1 = lets[j, 0];
                char l2 = lets[j, 1];
                if (l1 == one && l2 == two)
                {
                    value += l2;
                    break;
                }
                if (l1 == one && l2 != two && check.Contains(l2) == false)
                {
                    check.Add(l2);
                    value += rechelp(l2, two, lets, check);
                    if (value.Length == 1)
                    {
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            return value;
        }
            
                public static void Main(string[] args)
        {
        }
    }
}
