using System;

namespace Planetary_Grid
{
    internal class Program
    {
        struct Grid
        {
            public int[] X;
            public int[] Y;
            public bool[,] Road;
        }

        static void Main(string[] args)
        {
            int testCases = int.Parse(Console.ReadLine());
            for (int i = 0; i < testCases; i++)
            {
                int[] values = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

                //Create our grid and instantiate it
                Grid grid = new Grid();
                grid.X = new int[values[4] - (values[2] - 1)];
                grid.Y = new int[values[5] - (values[3] - 1)];
                grid.Road = new bool[grid.X.Length, grid.Y.Length];
                grid.X[0] = values[2];
                grid.Y[0] = values[3];

                for (int k = 0; k < values[4] - values[2]; k++)
                {
                    grid.X[k + 1] = grid.X[k] + 1;
                }

                for (int k = 0; k < values[5] - values[3]; k++)
                {
                    grid.Y[k + 1] = grid.Y[k] + 1;
                }

                grid = CalculateHValues(grid, values[0], values[1]);

                double totalDistance = 0;
                int[] currentPosition = { grid.X[0], grid.Y[0] };
                do 
                { 
                    //Testing X increment

                    //First we want to check if the destination is behind us in the X direction or not
                    if (grid.X[grid.X.Length - 1] - grid.X[0] < 0)
                    {
                        //Behind

                    }
                    else
                    {
                        //In front
                        int test = grid.Road.GetLength(0) - currentPosition[0];
                        int test2 = grid.Road.GetLength(1) - currentPosition[1];

                        if (grid.Road[test, test2] == true)
                        {
                            totalDistance += 1;
                        }
                        else
                        {

                        }
                    }

                    //Testing Y increment
                } while (currentPosition[0] != grid.X[grid.X.Length - 1] && currentPosition[1] != grid.Y[grid.Y.Length - 1]);
            }
        }

        static Grid CalculateHValues(Grid pGrid, int pA, int pB)
        {
            for (int i = 0; i < pGrid.Road.GetLength(0); i++)
            {
                for (int k = 0; k < pGrid.Road.GetLength(1); k++)
                {
                    /*
                     * We can test to see if a coordinate is built on a Road if
                     * (Pi * x) / pA = 0, Pi or 2Pi
                     * or
                     * (Pi * y) / pB = 0 or Pi
                     * 
                     * The reason why we do it this way is because the Math.PI in c# isn't exact Pi, therefore
                     * we can not use it in a if statement
                     */

                    double firstTest = (Math.PI * pGrid.X[i]) / pA;
                    double secondTest = (Math.PI * pGrid.Y[k]) / pB;
                    switch (firstTest)
                    {
                        case 0:
                        case Math.PI:
                        case Math.PI * 2:
                            pGrid.Road[i, k] = true;
                            break;
                        default:
                            switch (secondTest)
                            {
                                case 0:
                                case Math.PI:
                                    pGrid.Road[i, k] = true;
                                    break;
                                default:
                                    pGrid.Road[i, k] = false;
                                    break;
                            }
                            break;
                    }
                }
            }

            return pGrid;
        }
    }
}
