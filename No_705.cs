namespace LeetCode
{
    public class MyHashSet
    {
        List<int> _set;
        public MyHashSet()
        {
            _set = new List<int>();
        }

        public void Add(int key)
        {
            if (!_set.Contains(key))
                _set.Add(key);
        }

        public void Remove(int key)
        {
            _set.Remove(key);
        }

        public bool Contains(int key)
        {
            return _set.Contains(key);
        }
    }
}