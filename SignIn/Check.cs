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
            char[] chars = { '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '_', '/', '.', ',', '>', '<' };
            int sp = password.IndexOfAny(chars) + 1;
            char[] chars1 = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            int num = password.IndexOfAny(chars1) + 1;
            for (int i = 0; i < password.Length; i++)
            {
                if (!(password[i] >= 'a' && password[i] <= 'z' || password[i] >= 'A' && password[i] <= 'Z' && num > 0 && sp > 0))
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
            int sp = password.IndexOfAny(chars) + 1;
            return sp >= 1;
        }
        public bool CheckSymb(string password)
        {
            if (CheckAlp(password) && CheckNum(password) && CheckSpec(password))
            {
                return true;
            }
            return false;

        }

    }
}
