using System;
namespace Iamsorry
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> st = new Stack<char>();
            if (st.IsEmpty())
            {
                Console.WriteLine("xD");
            }
            else
            {
                Console.WriteLine("some");
            }
            st.Push('a');
            st.Push('b');
            st.Push('c');
            st.Push('d');
            st.Push('e');
            st.Pop();
            st.Pop();
            st.Peek();
            st.Push('f');
            st.Push('g');
            st.Push('h');
            st.Push('i');
            st.Push('j');
            st.Push('k');
            st.Push('l');
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine(st.PrintStack()[i]);
            }
            Console.WriteLine(st.Peek());
            st.Pop();
            st.Pop();
            st.Peek();
            st.Pop();
            st.Pop();
            st.Peek();
            st.Push('r');
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(st.PrintStack()[i]);
            }
            if (st.IsEmpty())
            {
                Console.WriteLine("xD");
            }
            else
            {
                Console.WriteLine("some");
            }

        }
    }
    public class Stack<T>
    {
        T[] pole;
        int posithion = -1;
        int ElementCount;
        public Stack(int maxElementCount = 100)
        {
            ElementCount = maxElementCount;
            pole = new T[maxElementCount];
        }
        public void Push(T t)
        {
            pole[++posithion] = t;
        }
        public void Pop()
        {
            posithion--;
        }
        public T Peek()
        {
            return pole[posithion];
        }
        public bool IsEmpty()
        {
            bool TrFal;
            if (posithion == -1)
            {
                TrFal = true;
            }
            else
            {
                TrFal = false;
            }
            return TrFal;
        }
        public T[] PrintStack()
        {
            T[] save = new T[ElementCount];
            for (int i = 0; i <= posithion; i++)
            {
                save[i] = pole[i];
            }
            return save;
        }
    }
}
