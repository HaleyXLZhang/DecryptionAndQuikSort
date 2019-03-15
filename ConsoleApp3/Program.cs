using System;
using System.Text;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            string originalStr = "What is your name? My name is Haley.";

            string passwordStr = string.Empty;

            Console.WriteLine("原文:" + originalStr);

            StringBuilder buff = new StringBuilder();

            StringBuilder buffPassword = new StringBuilder();

            foreach (char c in originalStr)
            {
                buffPassword.Append(PasswordChar(c));
            }

            passwordStr = buffPassword.ToString();

            Console.WriteLine("密文:" + passwordStr);

            foreach (char c in passwordStr)
            {

                buff.Append(TranslateChar(c));
            }
            Console.WriteLine("译文:" + buff.ToString());

            Console.ReadLine();
        }
        public static char TranslateChar(char passwordChar)
        {
            char result = Char.MinValue;

            if (CompareCharCase(passwordChar) == 1)
            {
                int charPosition = 26 - (System.Convert.ToInt32(passwordChar) - System.Convert.ToInt32('A'));

                result = (char)(charPosition + System.Convert.ToInt32('A') - 1);
            }
            else
            if (CompareCharCase(passwordChar) == 0)
            {
                int charPosition = 26 - (System.Convert.ToInt32(passwordChar) - System.Convert.ToInt32('a'));

                result = (char)(charPosition + System.Convert.ToInt32('a') - 1);
            }
            else
            {
                result = passwordChar;
            }
            return result;
        }
        public static int CompareCharCase(char inputChar)
        {
            if (inputChar >= 'A' && inputChar <= 'Z')
            {
                return 1;
            }
            if (inputChar >= 'a' && inputChar <= 'z')
            {
                return 0;
            }
            return -1;
        }


        public static char PasswordChar(char orginalChar)
        {

            char result = Char.MinValue;

            if (CompareCharCase(orginalChar) == 1)
            {
                int i = 26 - (System.Convert.ToInt32(orginalChar) - System.Convert.ToInt32('A') + 1) + 1;

                result = (char)(i + System.Convert.ToInt32('A') - 1);
            }
            else
            if (CompareCharCase(orginalChar) == 0)
            {
                int i = 26 - (System.Convert.ToInt32(orginalChar) - System.Convert.ToInt32('a') + 1) + 1;

                result = (char)(i + System.Convert.ToInt32('a') - 1);
            }
            else
            {
                result = orginalChar;
            }
            return result;
        }

    }
}
