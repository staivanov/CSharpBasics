namespace MyDictionary
{
    public class MyList<T>
    {
        private T[] _elements;
        public T[] Elements { get => _elements; set => _elements = value; }

        public MyList(params T[] elements) => Elements = elements;


        public T this[int index]
        {
            get => Elements[index];
            set => Elements[index] = value;
        }

    }
}
