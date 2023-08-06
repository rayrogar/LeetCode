using System.Runtime.Versioning;

namespace LeetCode
{
    class No_841
    {
        public bool CanVisitAllRooms(IList<IList<int>> rooms) {
             //Console.WriteLine(string.Join(",", rooms.Select(x => string.Join(",",x.ToArray()))));
          
         HashSet<int> keys = new HashSet<int>();
            keys.Add(0);
            int i = 0;
            while (keys.Count < rooms.Count && i < keys.Count)
            {
                Console.WriteLine(string.Join(",",keys));
                for (int j = 0; j < rooms[keys.ToArray()[i]].Count; j++)
                    keys.Add(rooms[keys.ToArray()[i]][j]);

                i++;
            }
            Console.WriteLine($"Keys: {string.Join(",",keys)}"
            +$" keys.Count: {keys.Count} == rooms.Count: {rooms.Count} ");

            return keys.Count==rooms.Count;

        }
    }
}