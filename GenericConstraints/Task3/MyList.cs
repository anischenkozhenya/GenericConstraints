namespace Task3
{  
    public class MyList<T> : IMyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[0];
        }

        public void Add(T a) 
        {
            T[] temp = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            temp[array.Length] = a;
            array = temp;
        }

        public T this[int index]
        {
            get
            {
                return array[index];
            }
        }      

        public void Clear() 
        {
            array = new T[0];
        }

        public bool Contains(T item) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((int)(object)array[i] == (int)(object)item)
                {
                    return true;
                }
            }
            return false;
        }
        public int Count
        {
            get { return array.Length; }
        }
        public override string ToString() 
        {
            string str = null;
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i] + " ";
            }
            return "Длина массива: " + array.Length + "\nЭлементы массива: " + str;
        }
    }
}
