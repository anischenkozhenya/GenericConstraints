namespace Task4
{
    class MyArrayList
    {
        private object[] array;
        public MyArrayList()
        {
            array = new object[0];
        }
        public object this[int index]
        {
            get
            {
                return array[index];
            }
        }
               
        public int Count 
        {
            get 
            {
                return array.Length;
            }
        }
        public void Add(object a)
        {
            object[] temp = new object[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                temp[i] = array[i];
            }
            temp[array.Length] = a;
            array = temp;
        } 
        public void Clear() 
        {
            array = new object[0];
        }
        public bool Contains(object item) 
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == item) 
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            string str = null;
            for (int i = 0; i < array.Length; i++)
            {
                str += array[i] + " ";
            }
            return "Элементы массива: " + str;
        }
    }
}
