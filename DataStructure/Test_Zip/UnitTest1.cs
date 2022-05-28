using System;
using Xunit;
using zip;

namespace Test_Zip
{
    public class linked_list_zip
    {
        [Fact]
        public void Test1()
        {

            zip.linked_list_zip.LinkedList L = new zip.linked_list_zip.LinkedList();
            zip.linked_list_zip.LinkedList L1 = new zip.linked_list_zip.LinkedList();
            zip.linked_list_zip.LinkedList L2 = new zip.linked_list_zip.LinkedList();
            zip.linked_list_zip.LinkedList L_Test = new zip.linked_list_zip.LinkedList();


            L.append(1);
            L.append(5);
            L.append(3);
            L.append(9);
            L.append(2);
            L.append(4);
            L1.append(1);
            L1.append(3);
            L2.append(2);
            L2.append(5);
            L2.append(9);
            L2.append(4);

            L_Test.zipLists(L1, L2);

            Assert.NotEqual(L, L_Test);



        }
    }
}
