// Задача 1: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
int ReadInt(string text){
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] FillArray(int l, int h, int leftRange, int rigthRange){
    int[,] matrix = new int[l, h];
    Random rand = new Random();
    for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for(int j = 0; j < matrix.GetLength(1); j++)
                matrix[i, j] = rand.Next(leftRange, rigthRange +1);
            
        } 
    return matrix;
}

void PrintArray(int[,] array1){


    for(int i = 0; i < array1.GetLength(0); i++)
        {
            for(int j = 0; j < array1.GetLength(1); j++)
            {
                System.Console.Write(array1[i, j] + "\t");  
            }
        System.Console.WriteLine();
        }    
      
}
void PrintElements(int row, int col, int[,] array){
    if(row > array.GetLength(0) || col > array.GetLength(1))
         System.Console.WriteLine("В текущем массиве нет элемента с такими параметрами");
    else System.Console.WriteLine($"На данной позиции расположен элемент '{array[row, col]}'");
}


int rows = ReadInt("Введите количство строк в массиве");
int cols = ReadInt("Введите количство столбцов в массиве");
int[,] array = FillArray(rows,cols, -9, 9);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
int inRows = ReadInt("Введите позицию элемента в строке");
int inCols = ReadInt("Введите позицию элемента в столбце");
PrintElements(inRows, inCols, array);


