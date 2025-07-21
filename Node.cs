using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAcount
{
    public class Node<T>
    {
        private T item;
        private Node<T> next;

        public Node(T item, Node<T> next)
        {
            this.item = item;
            this.next = next;
        }

        public Node(T item)
        {
            this.item = item;
        }

        public T GetItem()
        {
            return this.item;
        }
        public Node<T> GetNext()
        {
            return this.next;
        }

        public void SetItem(T item)
        {
            this.item = item;
        }
        public void SetNext(Node<T> next)
        {
            this.next = next;
        }

        public bool HasNext()
        {
            return this.next != null;
        }
        public override string ToString()
        {

            return $"{this.item}->{this.next}";

        }
    }
}
