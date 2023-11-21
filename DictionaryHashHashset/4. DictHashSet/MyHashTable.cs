namespace DictHashSet
{
    internal class MyHashTable
    {
        private readonly int defaultSize = 10;
        private int[] tableOne;
        private int[] tableTwo;
        private int[] tableThree;

        private double threshold;

        public MyHashTable()
        {
            tableOne = new int[defaultSize];
            tableTwo = new int[defaultSize];
            tableThree = new int[defaultSize];
        }


        private int GetHashCodeTableOne(int key) => key % tableOne.Length;
        private int GetHashCodeTableTwo(int key) => (GetHashCodeTableOne(key) * 83 + 7) % tableTwo.Length;
        private int GetHashCodeTableThree(int key) => (GetHashCodeTableOne(key) * GetHashCodeTableOne(key) + 19) * tableThree.Length;

        private bool LookUp(int key)
        {
            bool isElementStored = false;

            if (tableOne[GetHashCodeTableOne(key)] != 0) return isElementStored = true;
            else if (tableTwo[GetHashCodeTableTwo(key)] != 0) return isElementStored = true;
            else if (tableThree[GetHashCodeTableThree(key)] != 0) return isElementStored = true;

            return isElementStored = false;
        }
    }
}
