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
            Search.Display();
            Console.ReadKey();
        }
    }
}
