namespace LeetCode
{
    public class No_2336
    {
        public No_2336(){
            string s = "";
            SmallestInfiniteSet obj = new SmallestInfiniteSet();
            // Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));

/*
            #region Test case 1
            s += "[]";
            Console.WriteLine(s);

            obj.AddBack(2);
            //Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += "[]";
            Console.WriteLine(s);

            s += string.Format("[{0}]", obj.PopSmallest());
            // Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += string.Format("[{0}]", obj.PopSmallest());
            // Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += string.Format("[{0}]", obj.PopSmallest());
            //Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            Console.WriteLine(s);

            obj.AddBack(2);
            //Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += "[]";
            Console.WriteLine(s);

            obj.AddBack(3);
            //Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += "[]";
            Console.WriteLine(s);

            s += string.Format("[{0}]", obj.PopSmallest());
            //Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += string.Format("[{0}]", obj.PopSmallest());
            //Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            Console.WriteLine(s);

            Console.ReadKey();

            #endregion
            */

            #region Test case 2
            s += "[]";
            //Console.WriteLine(s);

            obj.AddBack(2);
            //Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += "[]";
            //Console.WriteLine(s);

            s += string.Format("[{0}]", obj.PopSmallest());
            //Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += string.Format("[{0}]", obj.PopSmallest());
            // Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += string.Format("[{0}]", obj.PopSmallest());
           // Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
           // Console.WriteLine(s);

            obj.AddBack(3);
           // Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += "[]";
           // Console.WriteLine(s);

            obj.AddBack(2);
           // Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += "[]";
           // Console.WriteLine(s);
            
            obj.AddBack(1);
           // Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += "[]";
            //Console.WriteLine(s);

            s += string.Format("[{0}]", obj.PopSmallest());
            //Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += string.Format("[{0}]", obj.PopSmallest());
           // Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            s += string.Format("[{0}]", obj.PopSmallest());
           // Console.WriteLine("SET: {0}, SMOLEST: {1}", obj.set, string.Join(',', obj.smalest));
            Console.WriteLine(s);

            Console.ReadKey();

            #endregion
        }

    }

    public partial class SmallestInfiniteSet
    {
       public int set = 1;
       public List<int> smalest;
        public SmallestInfiniteSet()
        {
            set = 1;
            smalest = new List<int>();
        }

        public int PopSmallest()
        {
            // Console.WriteLine("start call: PopSmallest(), set: {0}, smalest: {1} ", set, string.Join(',', smalest));
            // Console.ReadKey();
            if (smalest.Count() == 0)
                return set++;

            int s = smalest[0];
            smalest.RemoveAt(0);

            return s;
        }

        public void AddBack(int num)
        {
            // Console.WriteLine("start call: AddBack(int {0}), set: {1}, smalest: {2} ",num, set, string.Join(',', smalest));
            // Console.ReadKey();
            if (num < set)
            {
                if (smalest.Count == 0)
                    smalest.Add(num);
                else
                {
                    List<int> sm = new List<int>();
                    
                    while (smalest.Count!=0)
                   {
                         if (num == smalest[0])
                             break;
                         if (num < smalest[0])
                         {
                            sm.Add(num);
                            break;
                         }
                         else{
                            sm.Add(smalest[0]);
                            smalest.RemoveAt(0);
                        }
                    }
                    if(smalest.Count==0)
                        sm.Add(num);
                    sm.AddRange(smalest);
                    smalest = sm;
                }
            }
            // Console.WriteLine("end call: AddBack(int {0}), set: {1}, smalest: {2} ",num, set, string.Join(',', smalest));
            // Console.ReadKey();
        }
    }
}