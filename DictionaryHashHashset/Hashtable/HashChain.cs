namespace LearnDSAlgorithms
{
    class HashChain
    {
        private int hashtableSize;
        private LinkedList[] hashtable;

        public HashChain()
        {
            hashtableSize = 10;
            hashtable = new LinkedList[hashtableSize];
            int index = 0;

            while (index < hashtableSize)
            {
                hashtable[index] = new LinkedList();
                index++;
            }
        }

        public int Hashcode(int key) => key % hashtableSize;

        public void Insert(int element)
        {
            int index = Hashcode(element);
            hashtable[index].InsertSorted(element);
        }

        public bool Search(int key)
        {
            int index = Hashcode(key);
            return hashtable[index].Search(key) != -1;
        }

        public void Display()
        {
            for (int i = 0; i < hashtableSize; i++)
            {
                Console.Write("[" + i + "]");
                hashtable[i].Display();
            }
            Console.WriteLine();
        }
    }
}
