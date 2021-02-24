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

            if (flag == true)
            {
                return true;
            }
            return false;
        }
        public bool CheckSymb(string password)
        {
            int alp = 0;
            int num = 0;
            int specSymp = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'A' && password[i] <= 'Z')
                {
                    alp += 1;
                }
                if (password[i] >= '0' && password[i] <= '9')
                {
                    num += 1;
                }
                if (password[i] >= '!' && password[i] <= '/' || password[i] >= ':' && password[i] <= '@' || password[i] >= '[' && password[i] <= '`' || password[i] >= '{' && password[i] <= '~')
                {
                    specSymp += 1;
                }

            }

            if (specSymp >= 1 && num >= 1 && alp >= 1)
            {
                return true;
            }
            return false;
        }

    }
}
