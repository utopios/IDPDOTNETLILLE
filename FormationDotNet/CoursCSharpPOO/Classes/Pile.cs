using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursCSharpPOO.Classes
{
    class Pile<T>
    {
        private T[] elements;
        private int compteur;
        public event Action PilePleine;
        public Pile(int t)
        {
            elements = new T[t];
            compteur = 0;
        }

        public bool Empiler(T element)
        {
            if(compteur < elements.Length)
            {
                elements[compteur++] = element;
                return true;
            }
            else
            {
                //if (PilePleine != null)
                //    PilePleine();
                //<=>
                PilePleine?.Invoke();
                return false;
            }
        }

        public bool Depiler()
        {
            if (compteur > 0)
            {
                elements[--compteur] = default(T);
                return true;
            }
            return false;
        }

        public T GetElement(int index)
        {
            if(index >= 0 && index < compteur)
            {
                return elements[index];
            }
            return default(T);
        }

        public T SearchElement(Func<T, bool> searchMethod)
        {
            T result = default(T);
            foreach(T element in elements)
            {
                if(searchMethod(element))
                {
                    result = element;
                    break;
                }
            }
            return result;
        }
    }
}
