using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PasechnikPA1.Sprint4.Task7.V13.Lib
{
    public class DataService : ISprint4Task7V13
    {
        public int Calculate(int n, int m, string value)
        {
            int res = 0;
            int[,] mtrx = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mtrx[i, j] = int.Parse(value.Substring(i * m + j, 1));
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (mtrx[i, j] % 2 == 0)
                    {
                        res += 1;
                    }
                }
            }
            return res;

        }
    }
}
