using System;
using System.Text;

public class CharMatrix
{
    
    private char[,] matrix;
    
    private int digitCount;
    
    public CharMatrix(char[,] matrix)
    {
        this.matrix = matrix;
        
        CountDigits();
    }
    
    private void CountDigits()
    {
        digitCount = 0;

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (char.IsDigit(matrix[i, j]))
                {
                    digitCount++;
                }
            }
        }
    }
    
    public int DigitCount
    {
        get { return digitCount; }
    }
    
    public string this[int column]
    {
        get
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                result.Append(matrix[i, column]);
            }

            return result.ToString();
        }
    }
    
    public void ShowMatrix()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}