using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{

    class BSTree<T> where T : IComparable<T>
    {
        public T NodeData { get; set; }
        public BSTree<T> left { get; set; }
        public BSTree<T> right{ get; set; }

        public BSTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.right= null;
            this.left = null;

        }
        int leftCount = 0, rightCount = 0;
        public void Insert(T item)
        {
            T nodeValue = this.NodeData;
            if ((nodeValue.CompareTo(item)) > 0)
            {
                if (this.left == null)
                    this.left = new BSTree<T>(item);
                else
                    this.left.Insert(item);
            }
            else
            {
                if (this.right== null)
                    this.right= new BSTree<T>(item);
                else
                    this.right.Insert(item);
            }
        }
        public void Display()
        {
            if (this.left != null)
            {
                this.leftCount++;
                this.left.Display();

            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.right!= null)
            {
                this.rightCount++;
                this.right.Display();
            }
        }
        public void Size()
        {
            Console.WriteLine("Size" + " " + (1 + this.leftCount + this.rightCount));
        }
    }
}
