using System;
using System.Collections.Generic;
using System.Text;

namespace Open_Lab_04._03
{
    class RemoveFirstLast
    {
        public string RemoveFirstLastChar(string text)
        {
            if (text.Length < 3)
            {
                return text;
            }
            else
            {
                return text.Remove(text.Length - 1).Remove(0, 1);
            }
        }           
    }
}
