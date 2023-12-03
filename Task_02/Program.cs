// Задача 2: Задайте двумерный массив. Напишите программу, которая поменяет местами 
// первую и последнюю строку массива.
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

void ChangeArray(int[,] array){
    int temp = array[0, 0];
    for(int j = 0; j < array.GetLength(1); j++){
        temp = array[0, j];
        array[0, j] = array [array.GetLength(0)-1, j];
        array[array.GetLength(0)-1, j] = temp;
    }

}

int rows = ReadInt("Введите количство строк в массиве");
int cols = ReadInt("Введите количство столбцов в массиве");
int[,] array = FillArray(rows,cols, -9, 9);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
ChangeArray(array);
PrintArray(array);

