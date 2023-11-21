namespace LearnDSAlgorithms
{
    class HashLinearProbe
    {
        private int hashtableSize;
        private int[] hashtable;

        public HashLinearProbe()
        {
            hashtableSize = 10;
            hashtable = new int[hashtableSize];
        }

        public int Hashcode(int key) => key % hashtableSize;

        public int Lprobe(int element)
        {
            int i = Hashcode(element),
                j = 0;

            while (hashtable[(i + j) % hashtableSize] != 0)
            {
                j++;
            }

            return (i + j) % hashtableSize;
        }

        public void Insert(int element)
        {
            int i = Hashcode(element);

            if (hashtable[i] == 0)
            {
                hashtable[i] = element;
            }
            else
            {
                i = Lprobe(element);
                hashtable[i] = element;
            }
        }

        public bool Search(int key)
        {
            int i = Hashcode(key),
                j = 0;

            while (hashtable[(i + j) % hashtableSize] != key)
            {
                if (hashtable[(i + j) % hashtableSize] == 0)
                {
                    return false;
                }

                j++;
            }
            return true;
        }

        public void Display()
        {
            for (int i = 0; i < hashtableSize; i++)
            {
                Console.Write(hashtable[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
