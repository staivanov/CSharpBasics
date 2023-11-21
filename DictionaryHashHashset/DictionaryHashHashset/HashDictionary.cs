using System.Collections;

namespace MyDictionary
{
    public class HashDictionary<K, V> : IEnumerable<KeyValuePair<K, V>>
    {
        private const int DEFAULT_CAPACITY = 2;
        private const float DEFAUL_LOAD_FACTOR = 0.75f;
        private List<KeyValuePair<K, V>>[] table;
        private float loadFactor;
        private int threshold;
        private int size;
        private int initialCapacity;

        public HashDictionary() : this(DEFAULT_CAPACITY, DEFAUL_LOAD_FACTOR) { }

        private HashDictionary(int capacity, float loadFactor)
        {
            initialCapacity = capacity;
            table = new List<KeyValuePair<K, V>>[capacity];
            loadFactor = loadFactor;

            unchecked
            {
                threshold =
                    (int)(capacity * loadFactor);
            }
        }

        public void Clear()
        {
            if (table != null)
            {
                table = new List<KeyValuePair<K, V>>[initialCapacity];
            }
            size = 0;
        }

        private List<KeyValuePair<K, V>> FindChain(K key, bool createIfMissing)
        {
            int index = key.GetHashCode();
            index %= table.Length;

            bool isElementNull = table[index] == null;

            if (isElementNull && createIfMissing)
            {
                table[index] = new List<KeyValuePair<K, V>>();
            }

            return table[index];
        }

        public V Get(K key)
        {
            List<KeyValuePair<K, V>> chain = FindChain(key, false);

            if (chain != null)
            {
                for (int i = 0; i < chain.Count; i++)
                {
                    KeyValuePair<K, V> entry = chain[i];

                    if (entry.Key.Equals(key))
                    {
                        return entry.Value;
                    }
                }
            }

            return default(V);
        }

        public V this[K key]
        {
            get
            {
                return Get(key);
            }
            set
            {
                Set(key, value);
            }
        }

        public int Count() => size;

        public V Set(K key, V value)
        {
            List<KeyValuePair<K, V>> chain = FindChain(key, true);

            for (int i = 0; i < chain.Count; i++)
            {
                KeyValuePair<K, V> entry = chain[i];

                if (entry.Value.Equals(key))
                {
                    KeyValuePair<K, V> newEntry = new(key, value);
                    chain[i] = newEntry;
                    return entry.Value;
                }
            }

            chain.Add(new KeyValuePair<K, V>(key, value));

            if (size++ >= threshold)
            {
                this.Expand();
            }

            return default(V);

        }

        private void Expand()
        {
            int newCapacity = 2 * table.Length;
            List<KeyValuePair<K, V>>[] oldTable = table;
            table = new List<KeyValuePair<K, V>>[newCapacity];
            threshold = (int)(newCapacity * loadFactor);

            foreach (List<KeyValuePair<K, V>> oldChain in oldTable)
            {
                if (oldChain != null)
                {
                    foreach (KeyValuePair<K, V> keyValuePair in oldChain)
                    {
                        List<KeyValuePair<K, V>> chain = FindChain(keyValuePair.Key, true);
                        chain.Add(keyValuePair);
                    }
                }
            }
        }


        public bool Remove(K key)
        {
            List<KeyValuePair<K, V>> chain = FindChain(key, false);

            if (chain != null)
            {
                for (int i = 0; i < chain.Count; i++)
                {
                    KeyValuePair<K, V> entry = chain[i];

                    if (entry.Key.Equals(key))
                    {
                        chain.RemoveAt(i);
                        return true;
                    }
                }
            }
            return false;
        }

        IEnumerator<KeyValuePair<K, V>> IEnumerable<KeyValuePair<K, V>>.GetEnumerator()
        {
            foreach (List<KeyValuePair<K, V>> chain in table)
            {
                if (chain != null)
                {
                    foreach (KeyValuePair<K, V> entry in chain)
                    {
                        yield return entry;
                    }
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<KeyValuePair<K, V>>)this).
                  GetEnumerator();
        }
    }
}
