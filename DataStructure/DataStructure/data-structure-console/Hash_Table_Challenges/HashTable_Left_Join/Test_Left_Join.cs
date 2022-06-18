using System;
using Xunit;
using Left_Join;
using Hash_Table;
using System.Collections.Generic;

namespace Test_Left_Join
{
    public class hashmap_left_join
    {
        [Fact]
        public void Test1()
        {
            Hash_Table.HashTable firstHashTable = new Hash_Table.HashTable(0);
            Hash_Table.HashTable secondHashTable = new Hash_Table.HashTable(0);
            Left_Join.hashmap_left_join testLeftJoin = new Left_Join.hashmap_left_join();
            Exception E = Assert.Throws<Exception>(() => testLeftJoin.leftJoin(firstHashTable, secondHashTable));
            Assert.Equal("HashTable is Empty !", E.Message);

        }

        [Fact]
        public void Test2()
        {
            Hash_Table.HashTable firstHashTable = new Hash_Table.HashTable(5);
            firstHashTable.Set("fond", "enamored");
            firstHashTable.Set("wrath", "anger");
            firstHashTable.Set("diligent", "employed");
            firstHashTable.Set("outift", "garb");
            firstHashTable.Set("guide", "usher");

            Hash_Table.HashTable secondHashTable = new Hash_Table.HashTable(5);
            secondHashTable.Set("fond", "averse");
            secondHashTable.Set("wrath", "delight");
            secondHashTable.Set("diligent", "idle");
            secondHashTable.Set("guide", "follow");
            secondHashTable.Set("flow", "jam");

            Left_Join.hashmap_left_join testLeftJoin = new Left_Join.hashmap_left_join();
            List<string> testList = new List<string>() {
           "[fond:enamored,averse]", "[wrath:anger,delight]",
           "[diligent:employed,null]", "[outift:garb,]", "[guide:usher,follow]"
            };
            Assert.NotEqual(testList, testLeftJoin.leftJoin(firstHashTable, secondHashTable));

        }

        [Fact]
        public void Test3()
        {
            Hash_Table.HashTable firstHashTable = new Hash_Table.HashTable(5);
            firstHashTable.Set("fond", "enamored");
            firstHashTable.Set("wrath", "anger");
            firstHashTable.Set("diligent", "employed");
            firstHashTable.Set("outift", "garb");
            firstHashTable.Set("guide", "usher");

            Hash_Table.HashTable secondHashTable = new Hash_Table.HashTable(5);
            secondHashTable.Set("fond", "averse");
            secondHashTable.Set("wrath", "delight");
            secondHashTable.Set("diligent", "idle");
            secondHashTable.Set("guide", "follow");
            secondHashTable.Set("flow", "jam");

            Left_Join.hashmap_left_join testLeftJoin = new Left_Join.hashmap_left_join();
            List<string> testList = new List<string>() {
           " fond:enamored,averse ", " wrath:anger,delight ",
           " diligent:employed,idle ", " outift:garb, ", " guide:usher,follow "
            };
            Assert.Equal(testList, testLeftJoin.leftJoin(firstHashTable, secondHashTable));

        }

    }
}
