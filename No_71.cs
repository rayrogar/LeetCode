/*
Given a string path, which is an absolute path (starting with a slash '/') to a file or directory in a Unix-style file system, convert it to the simplified canonical path.

In a Unix-style file system, a period '.' refers to the current directory, a double period '..' refers to the directory up a level, and any multiple consecutive slashes (i.e. '//') are treated as a single slash '/'. For this problem, any other format of periods such as '...' are treated as file/directory names.

The canonical path should have the following format:

The path starts with a single slash '/'.
Any two directories are separated by a single slash '/'.
The path does not end with a trailing '/'.
The path only contains the directories on the path from the root directory to the target file or directory (i.e., no period '.' or double period '..')
Return the simplified canonical path.

 

Example 1:

Input: path = "/home/"
Output: "/home"
Explanation: Note that there is no trailing slash after the last directory name.
Example 2:

Input: path = "/../"
Output: "/"
Explanation: Going one level up from the root directory is a no-op, as the root level is the highest level you can go.
Example 3:

Input: path = "/home//foo/"
Output: "/home/foo"
Explanation: In the canonical path, multiple consecutive slashes are replaced by a single one.
 

Constraints:

1 <= path.length <= 3000
path consists of English letters, digits, period '.', slash '/' or '_'.
path is a valid absolute Unix path.

Examples:

"/a/./" --> means stay at the current directory 'a'
"/a/b/.." --> means jump to the parent directory
from 'b' to 'a'
"////" --> consecutive multiple '/' are a valid
path, they are equivalent to single "/".

Input : /home/
Output : /home

Input : /a/./b/../../c/
Output : /c

Input : /a/..
Output : /

Input : /a/../
Ouput : /

Input : /../../../../../a
Ouput : /a

Input : /a/./b/./c/./d/
Ouput : /a/b/c/d

Input : /a/../.././../../.
Ouput : /

Input : /a//b//c//////d
Ouput : /a/b/c/d

Input : /abc/...
Output : /abc/...

*/
namespace LeetCode
{
    public class No_71{

        public No_71(){
            // Console.WriteLine("/home/");
            // Console.WriteLine("Expected: /home");
            // Console.WriteLine(SimplifyPath("/home/"));
            // Console.ReadKey();

            // ///==============================///========================///
            // Console.WriteLine("/a/./b/../../c/");
            // Console.WriteLine("Expected: /c");
            // Console.WriteLine(SimplifyPath("/a/./b/../../c/"));
            // Console.ReadKey();

            // ///==============================///========================///
            // Console.WriteLine("/a/..");
            // Console.WriteLine("Expected: /");
            // Console.WriteLine(SimplifyPath("/a/.."));
            // Console.ReadKey();

            // ///==============================///========================///
            // Console.WriteLine("/a/../");
            // Console.WriteLine("Expected: /");
            // Console.WriteLine(SimplifyPath("/a/../"));
            // Console.ReadKey();

            // ///==============================///========================///
            // Console.WriteLine("/../../../../../a");
            // Console.WriteLine("Expected: /a");
            // Console.WriteLine(SimplifyPath("/../../../../../a"));
            // Console.ReadKey();

            // ///==============================///========================///
            // Console.WriteLine("/a/./b/./c/./d/");
            // Console.WriteLine("Expected: /a/b/c/d");
            // Console.WriteLine(SimplifyPath("/a/./b/./c/./d/"));
            // Console.ReadKey();

            // ///==============================///========================///
            // Console.WriteLine("/a/../.././../../.");
            // Console.WriteLine("Expected: /");
            // Console.WriteLine(SimplifyPath("/a/../.././../../."));
            // Console.ReadKey();

            // ///==============================///========================///
            // Console.WriteLine("/a/../.././../../.");
            // Console.WriteLine("Expected: /a/b/c/d");
            // Console.WriteLine(SimplifyPath("/a//b//c//////d"));
            // Console.ReadKey();

            // ///==============================///========================///
            // Console.WriteLine("/a/../.././../../.");
            // Console.WriteLine("Expected: /abc/...");
            // Console.WriteLine(SimplifyPath("/abc/..."));
            // Console.ReadKey();

            // ///==============================///========================///

            // Console.WriteLine("/..hidden");
            // Console.WriteLine("Expected: /..hidden");
            // Console.WriteLine(SimplifyPath("/..hidden"));
            // Console.ReadKey();

            // ///==============================///========================///

            // Console.WriteLine("/hidden..");
            // Console.WriteLine("Expected: /hidden..");
            // Console.WriteLine(SimplifyPath("/hidden.."));
            // Console.ReadKey();

            ///==============================///========================///

            Console.WriteLine("/../..ga/b/.f..d/..../e.baaeeh./.a");
            Console.WriteLine("Expected: /..ga/b/.f..d/..../e.baaeeh./.a");
            Console.WriteLine(SimplifyPath("/../..ga/b/.f..d/..../e.baaeeh./.a"));
            Console.ReadKey();

            ///==============================///========================///

            Console.WriteLine("/..../e.baaeeh./.a");
            Console.WriteLine("Expected: /..../e.baaeeh./.a");
            Console.WriteLine(SimplifyPath("/..../e.baaeeh./.a"));
            Console.ReadKey();

            ///==============================///========================///

            Console.WriteLine("/e.baaeeh./.a");
            Console.WriteLine("Expected: /e.baaeeh./.a");
            Console.WriteLine(SimplifyPath("/e.baaeeh./.a"));
            Console.ReadKey();

        }
        public string SimplifyPath(string path)
        {
            List<string> dir = new List<string>();
            string s = "";

            for (int i = 0; i < path.Length; i++)
            {
                //Console.WriteLine("i: {0}, s: {1} dir: {2}", i, s, string.Join('/', dir));
                //Console.ReadKey();
                if (path[i] == '.'){
                   // Console.WriteLine("path[i] == '.'");
                   // Console.ReadKey();
                    while (i < path.Length && path[i]!='/')
                    {
                       // Console.WriteLine("i: "+ i + " s: " + s);
                       // Console.ReadKey();
                        s += path[i].ToString();
                        i++;
                    }
                    if (s == "..")
                    {
                        if (dir.Count != 0)
                            dir.RemoveAt(dir.Count - 1);
                        s = "";
                    }else if(s=="."){
                        s = "";
                    }else{
                        dir.Add(s);
                        s = "";
                    }
                    i--;
                }else if(path[i]!='/'){
                    //Console.WriteLine("path[i]!='/'");
                   // Console.ReadKey();
                    while (i < path.Length && path[i] != '/')
                    {
                       // Console.WriteLine("i: " + i + " s: " + s);
                       // Console.ReadKey();
                        s += path[i].ToString();
                        i++;
                    }
                    dir.Add(s);
                    s = "";
                    i--;
                }
            }

            if(dir.Count==0)
                return "/";
            foreach (string slut in dir)
            {
                s += "/" + slut;
            }
            return s;
        }
    }
}