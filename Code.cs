using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeAndHashTable
{
    public class Code<T> where T : IComparable<T>
    {
        public T Data { get; set; }
        public Code<T> LeftTree { get; set; }
        public Code<T> RightTree { get; set; }

        public Code(T Data)
        {
            this.Data = Data;
            this.LeftTree = null;
            this.RightTree = null;
        }

        int leftcount = 0;
        int rightcount = 0;

        public void Add(T item)
        {
            T currentValue = this.Data;
            if (currentValue.CompareTo(item) > 0)
            {
                if (LeftTree == null)
                {
                    this.LeftTree = new Code<T>(item);
                }
                else { this.LeftTree.Add(item); }
            }

            else
            {
                if (this.RightTree == null)
                    this.RightTree = new Code<T>(item);
                else
                    this.RightTree.Add(item);
            }
        }


        public void Display()
        {
            if (this.LeftTree != null)
            {
                this.leftcount++;
                this.LeftTree.Display();
            }
            Console.WriteLine(this.Data.ToString());
            if (this.RightTree != null)
            {
                this.rightcount++;
                this.RightTree.Display();
            }
        }

        //SIZE in ascending order
        public void Size()
        {
            Console.WriteLine("Size" + " " + (7 * (this.leftcount + this.rightcount) - 1));
        }
    }
}
