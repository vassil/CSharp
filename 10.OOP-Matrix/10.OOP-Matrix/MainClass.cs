using System;
class MainClass
{
    static void Main()
    {
        Matrix<double> matrix = new Matrix<double>(4, 4);

        matrix[1, 1] = 1.5;

        Matrix<double> matrix2 = new Matrix<double>(4, 4);

        matrix2[1, 1] = 6;

        Console.WriteLine(matrix+matrix2);
    }
}