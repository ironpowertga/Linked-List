using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList<T>
    {

        LinkData<T> data;
        public int Count
        {
            get;
            private set;
        }
        public LinkedList()
        {

        }

        public void Push(T value)
        {
            Count++;
            if (data != null)
            {
                getLastElement(data).NextElement = new LinkData<T>(value);
            }
            else
            {
                data = new LinkData<T>(value);
            }
        }
        public T Pop()
        {
            if(data == null)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            else if(data.NextElement == null)
            {
                Count--;
                LinkData<T> last = data;
                data = null;

                return last.Value;
            }
            else
            {
                Count--;
                LinkData<T> beforeLast = getElement(data, Count - 1, 1);


                LinkData<T> last = beforeLast.NextElement;

                beforeLast.NextElement = null;

                return last.Value;
            }
        }

        private LinkData<T> getElement(LinkData<T> data, int index, int cpt)
        {
            if(cpt == index)
            {
                return data;
            }
            else if(data.NextElement == null && cpt < index)
            {
                throw new StackOverflowException();
            }
            else
            {
                cpt++;
                return getElement(data.NextElement, index, cpt);
            }
        }



        public T this[int key]
        {
            get
            {
                if(key >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                else if(data.NextElement == null)
                {
                    return data.Value;
                }
                else
                {
                    return getElement(data, key+1, 1).Value;
                }
            }
            set
            {
                if (key >= Count)
                {
                    throw new IndexOutOfRangeException();
                }
                else if (data.NextElement == null)
                {
                    data.Value = value;
                }
                else
                {
                    getElement(data, key + 1, 1).Value = value;
                }
            }
        }


        private LinkData<T> getLastElement(LinkData<T> data)
        {
            if (data.NextElement == null)
            {
                return data;
            }
            else
            {
                return getLastElement(data.NextElement);
            }
        }

        /*
        public int Length
        {
            get
            {
                if(data == null)
                {
                    return 0;
                }
                return cptElement(data) + 1;
            }
        }

        private int cptElement(LinkData<T> data)
        {
            if(data.NextElement == null)
            {
                return 0;
            }
            else
            {
                return 1 + cptElement(data.NextElement);
            }
        }
        */
    }
}
