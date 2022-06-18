using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hash_Table;

namespace Left_Join
{
    public class hashmap_left_join
    {
        public List<string> leftJoin(Hash_Table.HashTable firstHashTable, Hash_Table.HashTable secondHashTable)
        {
            if (firstHashTable.size == 0)
            {
                throw new Exception("HashTable is Empty !");
            }
            if (secondHashTable.size == 0)
            {
                throw new Exception("HashTable is Empty !");
            }

            List<string> leftJoinList = new List<string>();

            List<string> firstHashTableKeys = firstHashTable.Keys();

            foreach (var element in firstHashTableKeys)
            {
                if (secondHashTable.Contains(element))
                {
                    leftJoinList.Add( element + ":" + firstHashTable.Get(element).Value + "," + secondHashTable.Get(element).Value);
                }
                else
                {
                    leftJoinList.Add( element + ":" + firstHashTable.Get(element).Value + "," + null );
                }
            }
            return leftJoinList;
        }
    }
}
