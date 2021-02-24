using System;
using System.Collections.Generic;
using System.Text;

namespace SignIn
{
    class CheckPassword
    {
        public bool Password(string password, int min)
        {
            int length = password.Length;
            return  length>= min;
        }
        public bool Alphabet(string password)
        {
            bool flag = true;
            for (int i = 0; i < password.Length; i++)
            {
                if (!(password[i] >= 'a' && password[i] <= 'z' || password[i] >= 'A' && password[i] <= 'Z' || password[i] >= '0' && password[i] <= '9' || password[i] >= '!' && password[i] <= '/' || password[i] >= ':' && password[i] <= '@' || password[i] >= '[' && password[i] <= '`' || password[i] >= '{' && password[i] <= '~'))
                {
                    flag = false;
                    break;
                }
            }

            return flag;
        }


        public bool CheckAlp(string password)
        {
            int alp = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'A' && password[i] <= 'Z')
                {
                    alp += 1;
                }
            }
            return alp >= 1;
        }
        public bool CheckNum(string password)
        {
            int num = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= '0' && password[i] <= '9')
                {
                    num += 1;
                }
            }
            return num >= 1;
        }
        public bool CheckSpec(string password)
        {
            char[] chars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '/', '.', ',', '>', '<' };
            int sp = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password.IndexOfAny(chars) != 0)
                {
                    sp += 1;
                }
            }
            return sp >= 1;
        }
        public bool CheckSymb(string password)
        {
            bool a = CheckAlp(password);
            bool b = CheckNum(password);
            bool c = CheckSpec(password);
            if (a == true && b == true && c == true)
            {
                return true;
            }
            return false;

        }

    }
}
