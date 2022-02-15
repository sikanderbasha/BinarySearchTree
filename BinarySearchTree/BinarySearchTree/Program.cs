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
            BSTree<int> Search = new BSTree<int>(56);
            Search.Insert(30);
            Search.Insert(70);
            Search.Insert(22);
            Search.Insert(40);
            Search.Insert(60);
            Search.Insert(95);
            Search.Insert(11);
            Search.Insert(65);
            Search.Insert(3);
            Search.Insert(16);
            Search.Insert(63);
            Search.Insert(67);
            Search.Display();
            Search.Check(63, Search);
            Console.ReadKey();
        }
    }
}
