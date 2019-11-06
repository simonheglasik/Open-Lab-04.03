using System;

namespace Open_Lab_04._03
{
    public class StringTools
    {
        public string RemoveFirstLast(string original)
        {
            {
                if (original == "") return original;
                string a = original.Remove(original.Length-1);
                if (a == "") return original;
                string b = a.Remove(0, 1);
                return b;
            }
        }
    }
}
