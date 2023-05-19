using System.Collections;

namespace LeetCode
{
    public class No_733
    {
        public int[][] FloodFill(int[][] image, int sr, int sc, int color)
        {
            Stack<int> _sr = new Stack<int>();
            Stack<int> _sc = new Stack<int>();
            _sr.Push(sr); _sc.Push(sc);

            while (_sr.Count != 0)
            {
                int cur_sr = _sr.Pop(), cur_sc = _sc.Pop();

                if (cur_sr + 1 < image.Length && image[cur_sr + 1][cur_sc] == image[cur_sr][cur_sc] && image[cur_sr][cur_sc] != color)
                {
                    _sr.Push(cur_sr + 1);
                    _sc.Push(cur_sc);
                }
                if (cur_sr - 1 >= 0 && image[cur_sr - 1][cur_sc] == image[cur_sr][cur_sc] && image[cur_sr][cur_sc] != color)
                {
                    _sr.Push(cur_sr - 1);
                    _sc.Push(cur_sc);
                }
                if (cur_sc + 1 < image[0].Length && image[cur_sr][cur_sc + 1] == image[cur_sr][cur_sc] && image[cur_sr][cur_sc] != color)
                {
                    _sr.Push(cur_sr);
                    _sc.Push(cur_sc + 1);
                }
                if (cur_sc - 1 >= 0 && image[cur_sr][cur_sc - 1] == image[cur_sr][cur_sc] && image[cur_sr][cur_sc] != color)
                {
                    _sr.Push(cur_sr);
                    _sc.Push(cur_sc - 1);
                }
                image[cur_sr][cur_sc] = color;
            }

            return image;
        }

        public static void imprimirMatrix(int[][] matriz)
        {
            for (int i = 0; i < matriz.Length; i++)
            {
                for (int j = 0; j < matriz[i].Length; j++)
                {
                    Console.Write(matriz[i][j]);
                }
                Console.WriteLine();
                Console.ReadKey();
            }
        }
    }
}