namespace LeetCode
{
    public class tema_arrays{

        public  tema_arrays(){

            // Console.WriteLine("Given a binary array nums, return the maximum number of consecutive 1's in the array.");
            // Console.WriteLine();
            // Console.WriteLine("Example 1:");
            // Console.WriteLine("Input: nums = [1,1,0,1,1,1]");
            // Console.WriteLine("Output: 3");
            // Console.WriteLine("Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.");
            // Console.WriteLine("Real: " + FindMaxConsecutiveOnes(new int[] { 1, 1, 0, 1, 1, 1 }));
            // Console.WriteLine();

            // ///==============================================================///============================================//

            // Console.WriteLine("Example 2:");
            // Console.WriteLine("Input: nums = [1,0,1,1,0,1]");
            // Console.WriteLine("Output: 2");
            // Console.WriteLine("Real: " + FindMaxConsecutiveOnes(new int[] { 1, 0, 1, 1, 0, 1 }));

            // Console.WriteLine("Given an integer array nums sorted in non-decreasing order, return an array of the squares of each number sorted in non-decreasing order.");
            // Console.WriteLine();
            // Console.WriteLine("Example 1:");
            // Console.WriteLine("Input: nums = [-4,-1,0,3,10]");
            // Console.WriteLine("Output: [0,1,9,16,100]");
            // Console.WriteLine("Explanation: After squaring, the array becomes [16,1,0,9,100].");
            // Console.WriteLine("After sorting, it becomes[0, 1, 9, 16, 100].");
            // Console.WriteLine("Real: " + string.Join(",",SortedSquares(new int[] { -4, -1, 0, 3, 10 })));
            // ///==============================================================///============================================//

            // Console.WriteLine("Example 2:");
            // Console.WriteLine("Input: nums = [-7,-3,2,3,11]");
            // Console.WriteLine("Output: [4,9,9,49,121]");
            // Console.WriteLine("Real: " + string.Join(",", SortedSquares(new int[] { -7, -3, 2, 3, 11 })));
            // ///==============================================================///============================================//

            // Console.WriteLine("Example 2:");
            // Console.WriteLine("Input: nums = [-5, -3, -2, -1]");
            // Console.WriteLine("Output: [1,4,9,25]");
            // Console.WriteLine("Real: " + string.Join(",", SortedSquares(new int[] { -5, -3, -2, -1 })));

            // Console.WriteLine("Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may \n be changed. Then return the number of elements in nums which are not equal to val. \n Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things: \n Change the array nums such that the first k elements of nums contain the elements which are not equal to val. \n The remaining elements of nums are not important as well as the size of nums. \n Return k.");
            // Console.WriteLine();
            // Console.WriteLine("Example 1:");
            // Console.WriteLine("Input: nums = [3,2,2,3], val = 3 \n Output: 2, nums = [2,2,_,_] \n Explanation: Your function should return k = 2, with the first two elements of nums being 2. \n It does not matter what you leave beyond the returned k (hence they are underscores).");
            // int[] a = new int[] { 3, 2, 2, 3 };
            // Console.WriteLine("Real: K = {0}, array: {1}", RemoveElement(a, 3), string.Join(',', a));

            // //====================================================///============================================================================================//

            // Console.WriteLine("Example 2:");
            // Console.WriteLine("Input: nums = [0,1,2,2,3,0,4,2], val = 2 \n Output: 5, nums = [0,1,4,0,3,_,_,_] \n Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4. \n Note that the five elements can be returned in any order. \n It does not matter what you leave beyond the returned k (hence they are underscores).");
            // a = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
            // Console.WriteLine("Real: K = {0}, array: {1}", RemoveElement(a, 2), string.Join(',', a));

            //====================================================///============================================================================================//
            // a = new int[] { 1 };
            // Console.WriteLine("Real: K = {0}, array: {1}", RemoveElement(a, 1), string.Join(',', a));

            // Console.WriteLine("\n Example 1: \n Input: heights = [1,1,4,2,1,3]\n Output: 3\n Explanation:\n heights:  [1,1,4,2,1,3]\n expected: [1,1,1,2,3,4]\n Indices 2, 4, and 5 do not match.\n");
            // Console.WriteLine(HeightChecker(new int[] { 1, 1, 4, 2, 1, 3 }));
            // Console.ReadKey();

            // //====================================================///============================================================================================//

            // Console.WriteLine("\n Example 2: \n Input: heights = [5,1,2,3,4] \n Output: 5 \n Explanation: \n heights:  [5,1,2,3,4] \n expected: [1,2,3,4,5] \n All indices do not match.\n");
            // Console.WriteLine(HeightChecker(new int[] { 5, 1, 2, 3, 4 }));
            // Console.ReadKey();

            // //====================================================///============================================================================================//

            // Console.WriteLine("\n Example 3: \n Input: heights = [1,2,3,4,5] \n Output: 0 \n Explanation: \n heights:  [1,2,3,4,5] \n expected: [1,2,3,4,5] \n All indices match.\n");
            // Console.WriteLine(HeightChecker(new int[] { 1, 2, 3, 4, 5 }));
            // Console.ReadKey();

            // //====================================================///============================================================================================//

            // Console.WriteLine("\n Example 3: \n Input: heights = [2,1,2,1,1,2,2,1]  \n expected: [1,1,1,1,2,2,2,2] \n Output: 4 \n ");
            // Console.WriteLine(HeightChecker(new int[] { 2, 1, 2, 1, 1, 2, 2, 1 }));
            // Console.ReadKey();

            // //====================================================///============================================================================================//

            Console.WriteLine("\n Example 3: \n Input: heights = [7,4,5,6,4,2,1,4,6,5,4,8,3,1,8,2,7,6,3,2]  \n expected: [1,1,2,2,2,3,3,4,4,4,4,7,5,5,6,6,6,7,8,8] \n Output: 17 \n ");
            Console.WriteLine(HeightChecker(new int[] { 7, 4, 5, 6, 4, 2, 1, 4, 6, 5, 4, 8, 3, 1, 8, 2, 7, 6, 3, 2 }));
            Console.ReadKey();
            
        }

        public int FindMaxConsecutiveOnes(int[] nums)
        {
            int c = 0, c1 = 0;

            for (int i = 0; i < nums.Length; i++)
            {

                if (nums[i] == 1)
                    c1++;
                else
                {
                    if (c < c1) c = c1;
                    c1 = 0;
                }
            }

            if (c > c1)
                return c;
            return c1;

        }
        public int FindNumbers(int[] nums)
        {
            int c = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i].ToString().Length % 2 == 0)
                    c++;
            }
            return c;

        }
        public int[] SortedSquares(int[] nums)
        {
            int pmax = nums.Length - 1, p = nums.Length - 1, pmin = 0;
            int[] sqr_sort_nums = new int[nums.Length];
            
           while (pmax!=pmin)
           {
                int f = (int)Math.Pow(nums[pmax], 2);
                int i = (int)Math.Pow(nums[pmin], 2);
                if(f >= i){
                    sqr_sort_nums[p] = f;
                    pmax--;
                }
                else{
                    sqr_sort_nums[p] = i;
                    pmin++;
                }
                p--;
            }
            sqr_sort_nums[p] = (int)Math.Pow(nums[pmax], 2);

            return sqr_sort_nums;
        }
        public int[] SortedSquares1(int[] nums)
        {
            int pmax = nums.Length - 1, p = nums.Length - 1, pmin = 0;
            int[] sqr_sort_nums = new int[nums.Length];

            while (pmax != pmin)
            {
                if (Math.Pow(nums[pmax], 2) >= Math.Pow(nums[pmin], 2))
                {
                    sqr_sort_nums[p] = (int)Math.Pow(nums[pmax], 2);
                    pmax--;
                }
                else
                {
                    sqr_sort_nums[p] = (int)Math.Pow(nums[pmin], 2);
                    pmin++;
                }
                p--;
            }
            sqr_sort_nums[p] = (int)Math.Pow(nums[pmax], 2);

            return sqr_sort_nums;
        }
        public void DuplicateZeros(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                if(arr[i]==0){
                    for (int j = arr.Length-1; j > i + 1; j--)
                    {
                        arr[j] = arr[j - 1];
                    }
                    arr[i + 1] = 0;
                    i++;
                }
            }

        }
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int p1 = m - 1, p2 = n - 1;

            for (int i = m + n-1; i >=0 ; i--)
            {
                if(p1 >= 0 && p2 >= 0){
                    if(nums1[p1]>nums2[p2]){
                        nums1[i] = nums1[p1];
                        p1--;
                    }
                    else
                    {
                        nums1[i] = nums2[p2];
                        p2--;
                    }
                }
                else if(p2 >= 0){
                    nums1[i] = nums2[p2];
                    p2--;
                }
                else break;
            }

        }
        public int RemoveElement(int[] nums, int val)
        {
            if(val > 50)
                return nums.Length;
            int i = 0, c = 0, f = nums.Length - 1;

            while (i <= f)
            {
                if(i==f){
                    if(nums[i]==val)
                        c++;
                    break;
                }else if(nums[i]==val){
                        if(nums[f] == val){
                            c++;
                            f--;
                        }
                        else{
                                int t = nums[i];
                                nums[i] = nums[f];
                                nums[f] = t;
                                c++;
                                f--;
                                i++;
                        }
                }else if(nums[f]==val){
                        c++;
                        f--;
                }else{
                    i++;
                }
            }
            return nums.Length - c;
        }
        public int RemoveDuplicates(int[] nums)
        {
            int p = 0, p1 = 1;
                    while (p1 < nums.Length)
                    {
                        if(nums[p]==nums[p1]){
                            p1++;
                        }else{
                            if(p != p1-1){
                                nums[p + 1] = nums[p1];
                                p++;
                                p1++;
                            }else{
                                p++;
                                p1++;
                             }
                        }
                    }

            return p + 1;
        }
        public bool CheckIfExist(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if(arr[i]==arr[j]*2 || arr[i] * 2 == arr[j])
                        return true;
                }
            }
            return false;
        }
        /// <summary>
/// Probar variante con una sola consulta del length
/// </summary>
        public bool ValidMountainArray(int[] arr) {
            
            if(arr.Length < 3)
                return false;
            for (int i = 1; i < arr.Length-1; i++)
            {
                int l = i - 1, r = i + 1;
                bool ll = false, rr = false;

                while (l>=0)
                {
                    if(arr[l]==arr[l+1])
                        return false;
                    if(arr[l] > arr[l+1])
                        break;
                    l--;
                    if (l < 0)
                        ll = true;

                }

                while (r <= arr.Length-1)
                {
                    if(arr[r]==arr[r-1])
                        return false;
                    if(arr[r] > arr[r-1])
                        break;
                    r++;
                    if (r > arr.Length - 1)
                        rr = true;
                }

                if(ll && rr)
                    return true;
            }
            return false;
        }
        public bool ValidMountainArray1(int[] arr)
        {
            int length = arr.Length;
            if (length < 3)
                return false;
            for (int i = 1; i < length - 1; i++)
            {
                int l = i - 1, r = i + 1;
                bool ll = false, rr = false;

                while (l >= 0)
                {
                    if (arr[l] == arr[l + 1])
                        return false;
                    if (arr[l] > arr[l + 1])
                        break;
                    l--;
                    if (l < 0)
                        ll = true;

                }

                while (r <= length - 1)
                {
                    if (arr[r] == arr[r - 1])
                        return false;
                    if (arr[r] > arr[r - 1])
                        break;
                    r++;
                    if (r > length - 1)
                        rr = true;
                }

                if (ll && rr)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// O(n^2)
        /// </summary>
        public int[] ReplaceElements(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                arr[i] = arr[i + 1];
                for (int j = i + 1; j < arr.Length - 1; j++)
                {
                    if (arr[i] < arr[j + 1])
                        arr[i] = arr[j + 1];
                }
            }
            arr[arr.Length - 1] = -1;
            return arr;
        }
        /// <summary>
        /// O(n)*O(Log(n))
        /// </summary>
        public int[] ReplaceElements1(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int pmax = i + 1, max = arr[i + 1], p = i + 2;
                while (p < arr.Length)
                {
                    if(max < arr[p]){
                        pmax = p;
                        max = arr[p];
                    }
                    p++;
                }

                for (int j = i; j < pmax; j++)
                {
                    arr[j] = max;
                }
                i = pmax - 1;
            }

            arr[arr.Length - 1] = -1;
            return arr;
        }
        public void MoveZeroes(int[] nums)
        {
            int p = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    if (p == -1)
                        p = i;
                }
                else if (p != -1)
                {
                    nums[p] = nums[i];
                    nums[i] = 0;
                    p++;
                }
            }
        }
        public int[] SortArrayByParity(int[] nums)
        {
            int p = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i]%2!=0){
                     if(p == -1)
                        p = i;
                }
                else if(p != -1){
                    int t = nums[i];
                    nums[i] = nums[p];
                    nums[p] = t;
                    p++;
                }
            }
            return nums;
        }
        public int HeightChecker(int[] heights)
        {
            int[] copy = new int[heights.Length];
            Array.Copy(heights, copy,heights.Length);
            Array.Sort(heights);
            int c = 0;

            for (int i = 0; i < heights.Length; i++)
            {
                if(heights[i]!=copy[i])
                    c++;
            }
            return c;
        }

        public int HeightChecker1(int[] heights)
        {
            int c = 0, p = heights.Length - 1;
            List<int> post = new List<int>();

            while (p > 0)
            {
                for (int i = 0; i < heights.Length; i++)
                {
                    Console.WriteLine(string.Join(',', heights) + " P: {0}, I: {1}, C: {2} post: {3}", p, i, c, string.Join(',', post));
                    Console.ReadKey();
                    if (i + p >= heights.Length)
                        break;
                    if (heights[i] > heights[i + p])
                    {
                        post.Remove(i);
                        post.Add(i);
                        int t = heights[i];
                        heights[i] = heights[i + p];
                        heights[i + p] = t;
                        c++;
                    }

                }
                p--;
            }

            return c + post.Count;
        }

        public int ThirdMax(int[] nums)
        {
            int f = -1, s = -1, t = -1;
            if(nums.Length == 1)
                return nums[0];
            else if(nums.Length==2)
                return (nums[0] > nums[1] ? nums[0] : nums[1]);
            else{
                for (int i = 0; i < nums.Length; i++)
                    {
                       if(f == -1)
                        f = i;
                        else{
                            if(nums[i] > nums[f])
                                {
                                        t = s;
                                        s = f;
                                        f = i;
                                }else if (nums[i] != nums[f]){
                                    if (s == -1)
                                        s = i;
                                    else
                                        {
                                            if (nums[i] > nums[s])
                                            {
                                                t = s;
                                                s = i;
                                            }
                                            else if (nums[i] != nums[s]){
                                               if(t==-1)
                                                    t = i;
                                                    else if (nums[i] > nums [t])
                                                            t = i;
                                                }
                                        }
                                    }
                        }
                    }
                }

            if (t != -1)
                return nums[t];
            else return nums[f];
        }
    }

    
    
}