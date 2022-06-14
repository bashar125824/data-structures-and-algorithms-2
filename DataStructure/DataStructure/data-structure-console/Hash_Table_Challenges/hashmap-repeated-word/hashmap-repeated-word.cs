using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hash_Table;

namespace Repeated_Word
{
    public class hashmap_repeated_word
    {
        public string repeatedWord (string text)
        {
            
            int length = text.Length;
            if (length == 0)
            {
                return " There is no text ! ";
            }
            Hash_Table.HashTable hash_table = new Hash_Table.HashTable(1024);

            char[] letters = { ' ', ',', '.', ':', '\t' };
            string[] str = text.ToLower().Split(letters);

            for (int i = 0; i < str.Length; i++)
            {
                if (hash_table.Get(str[i]) == null)
                {
                    hash_table.Set(str[i], "1");
                }
                else
                    return str[i];
            }
            return "There is no repeated word ..";
        }
    }
}
