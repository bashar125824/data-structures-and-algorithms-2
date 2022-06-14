using System;
using Xunit;
using Hash_Table;
using System.Collections.Generic;

namespace HashTable
{
    public class UnitTest1
    {
        Hash_Table.HashTable hashtable = new Hash_Table.HashTable(512);

        [Fact]
        public void Test1_Setting_a_key_valye_to_Hashtable ()
        {
            hashtable.Set( "7" , "seven");

            Assert.Equal("seven", hashtable.Get("7").Value);
        }

        [Fact]
        public void Test2_Retrieving_based_on_a_key_returns_the_value_stored()
        {
            hashtable.Set("7", "seven");
            Assert.Equal("seven", hashtable.Get("7").Value);
        }
       
        [Fact]
        public void Test3_returns_null_for_a_key_that_does_not_exist_in_the_hashtable()
        {
            hashtable.Set("10", "ten");
            Assert.Null(hashtable.Get("10"));
        }
        
        [Fact]
        public void Test4_returns_a_list_of_all_unique_keys_that_exist_in_the_hashtable()
        {
            hashtable.Set("15", "fifteen");
            hashtable.Set("33", "thirty three");
            hashtable.Set("1",  "one");

            List<string> unique_keys = new List<string>() { "15", "33", "1" };
            Assert.Equal(unique_keys, hashtable.Keys());
        }
        
        [Fact]
        public void Test5_handle_a_collision_within_the_hashtable()
        {

            hashtable.Set("1", "one");
            hashtable.Set("5", "five");

            int first_value = hashtable.Hash("1");
            int second_value = hashtable.Hash("5");

            Assert.Equal(first_value , second_value);
        }
        

        [Fact]
        public void Test6_hash_a_key_to_an_in_range_value()
        {
            int val = hashtable.Hash("100");
            Assert.InRange(val, 0, hashtable.size);
        }
        
    }
}
