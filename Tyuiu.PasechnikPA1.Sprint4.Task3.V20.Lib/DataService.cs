﻿using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PasechnikPA1.Sprint4.Task3.V20.Lib
{
    public class DataService : ISprint4Task3V20
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int columns = array.Length / rows;
            int minimal = 100000;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j == 0)
                    {
                        minimal = Math.Min(minimal, array[i, j]);
                    }
                }
            }
            return minimal;
        }
    }
}
