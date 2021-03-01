using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Registration
{
    public class СheckingPassword
    {
        private static string lower = "абвгдежзийклмнопрстуфхцчшщьюя";
        private static string spec = "!@#$%^&*";

        public bool CheckPassword(string pass)
        {
            if (pass.Length < 6)
            {
                return false;
            }
            List<int> list = new List<int>();
            foreach (var c in pass.ToCharArray())
            {
                string s = c.ToString();

                if (lower.Contains(s.ToLower()))
                {
                    return false;
                }

                if (int.TryParse(s, out _))
                {
                    if (!list.Contains(1))
                    {
                        list.Add(1);
                    }
                }
                if (s == s.ToUpper())
                {
                    if (!list.Contains(2))
                    {
                        list.Add(2);
                    }
                }
                if (spec.Contains(s))
                {
                    if (!list.Contains(3))
                    {
                        list.Add(3);
                    }
                }
            }
            if (list.Count == 3)
            {
                return true;
            }
            return false;
        }
        
    }
}

