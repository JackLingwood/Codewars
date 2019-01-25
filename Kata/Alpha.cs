using System;
using System.Text;

namespace Kata
{
    public static class Alpha
    {

        public static string AlphabetPosition(string text)
        {
            StringBuilder sb = new StringBuilder();
            foreach(char ch in text)
            {
                int subtractor = char.IsUpper(ch) ? 64 : 96;
                if (char.IsLetter(ch))
                    sb.Append( ((int)ch-subtractor)+" ");
            }

            return sb.ToString().Trim();
        }
    }
}
