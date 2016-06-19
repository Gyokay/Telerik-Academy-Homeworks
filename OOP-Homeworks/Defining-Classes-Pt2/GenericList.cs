namespace Defining_Classes_Pt2
{
    class GenericList<T>
    {
        private T[] arr;
        private int capacity;
        public int count;

        public GenericList(int capacity)
        {
            this.capacity = capacity;
            this.arr = new T[capacity];
            this.count = 0;
        }

        public T this[int index]
        {
            get
            {
                return this.arr[index];
            }
            set
            {
                this.arr[index] = value;
            }
        }

        public void Add(T element)
        {
            
        }

    }
}
