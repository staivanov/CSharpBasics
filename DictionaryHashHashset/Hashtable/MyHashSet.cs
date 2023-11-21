using System.Collections;

namespace Hashtable
{
    public class ThreeSet<T> : ICollection<T>
    {

        private SortedDictionary<T, bool> innerDictionary;

        public ThreeSet(IEnumerable<T> element) : this()
        {
            foreach (T item in element)
            {
                this.Add(item);
            }
        }

        public ThreeSet() => innerDictionary = new SortedDictionary<T, bool>();


        public int Count { get => innerDictionary.Count; }
        public bool IsReadOnly { get => false; }
        public void Clear() => innerDictionary.Clear();


        public bool Add(T element)
        {
            if (!innerDictionary.ContainsKey(element))
            {
                innerDictionary[element] = true;
                return true;
            }

            return false;

        }


        public void IntersectWith(ThreeSet<T> other)
        {
            List<T> elementsToRemove = new(Math.Min(this.Count, other.Count));

            foreach (T key in innerDictionary.Keys)
            {
                if (!other.Contains(key))
                {
                    elementsToRemove.Add(key);
                }
            }

            foreach (T elementToRemove in elementsToRemove)
            {
                elementsToRemove.Remove(elementToRemove);
            }
        }


        public void UnionWith(ThreeSet<T> other)
        {
            foreach (T key in other)
            {
                innerDictionary[key] = true;
            }
        }


        public bool Contains(T item) => innerDictionary.ContainsKey(item);


        public void CopyTo(T[] array, int arrayIndex)
        {
            innerDictionary.Keys.CopyTo(array, arrayIndex);
        }


        public IEnumerator<T> GetEnumerator()
        {
            return innerDictionary.Keys.GetEnumerator();
        }


        public bool Remove(T item) => innerDictionary.Remove(item);


        IEnumerator IEnumerable.GetEnumerator()
        {
            return innerDictionary.Keys.GetEnumerator();
        }

        void ICollection<T>.Add(T item) => this.Add(item);

    }
}
