using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree<int> binarySearch = new BinaryTree<int>(56);
            binarySearch.Insert(12);
            binarySearch.Insert(11);
            binarySearch.Insert(10);
            binarySearch.Insert(9);
            binarySearch.Insert(8);
            binarySearch.Insert(7);
            binarySearch.Insert(6);
            binarySearch.Insert(5);
            binarySearch.Insert(4);
            binarySearch.Insert(3);
            binarySearch.Insert(2);
            binarySearch.Insert(1);
            binarySearch.GetSize();
            binarySearch.Display();
            bool result = binarySearch.IfExist(17, binarySearch);
            Console.WriteLine(result);
        }
    }
}
