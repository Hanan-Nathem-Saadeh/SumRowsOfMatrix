using System;

namespace SumRowsOfMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please insert dimention of the array");
            Console.WriteLine("Number of rows");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of columns");
            int columns = Convert.ToInt32(Console.ReadLine());
            int [] arr2=new int[rows];
            arr2 =sumArray(rows, columns);
            Console.WriteLine("the sum of each row =  [" + string.Join(", ", arr2) + "] ");
            
        }
        public static int []  sumArray(int rows, int columns)
        {
            int [] sum = new int[rows];
            string [,] Matrix = new string [rows,columns];
            int theNumber;


            for (int i = 0; i < rows; i++)
            {
                for ( int j = 0; j < columns; j++)
                {
                   
                        Console.Write($"matrix[[{i}][{j}]] =  ");
                        Matrix[i, j] = Console.ReadLine();
                    if (Matrix[i, j] == "")
                    {
                        Matrix[i, j] = "0";

                    }
                    else if (!(int.TryParse(Matrix[i, j], out theNumber)))
                        {
                       
                        Console.WriteLine ("it is not integer...try again ...");
                        Console.Write($"matrix[[{i}][{j}]] =  ");
                        Matrix[i, j] = Console.ReadLine();
                    }
                    
                   
                sum[i] = sum[i] + Convert.ToInt32(Matrix[i, j]);

                }
            }

            return sum;

        }

    }

}
