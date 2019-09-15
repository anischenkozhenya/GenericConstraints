using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class CarCollection<T> where T : Car
    {
        T[] ts;
        public CarCollection()
        {
            ts = new T[0];
        }
        public void Add(T newcar)
        {
            T[] tk = new T[ts.Length + 1];
            for (int i = 0; i < ts.Length; i++)
            {
                tk[i] = ts[i];
            }
            tk[tk.Length - 1] = newcar;
            ts = tk;
        }
        public int Count
        {
            get
            {
                return ts.Length;
            }
        }
        public void Clear()
        {
            ts = new T[0];
        }
        public string this[int index]
        {
            get
            {
                string str = null;
                str = ts[index].ToString();
                return str;
            }
        }
        public override string ToString()
        {
            string str = "";
            for (int i = 0; i < ts.Length; i++)
            {
                str += "\n" + ts[i].ToString();
            }
            return str;
        }
    }
}
