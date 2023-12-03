// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива. 
// Под удалением понимается создание нового двумерного массива без строки и столбца

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
int[,] DelRouAnDCols(int[,] array){
//Ищем мин элемент и его соответствующую строку и столбец
    int tempI = 0;
    int tempJ = 0;
    int min = array[0,0];
        for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min){
                        min = array[i, j];
                        tempI = i;
                        tempJ = j;
                    }  
                }
            }
    System.Console.WriteLine($"Минимальный элемент {min} Исключить строку {tempI} и столбец {tempJ}");
    System.Console.WriteLine();
    // Генерируем новый массив на 1 строку меньше и на 1 столбец
    int[,] newArray = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int temp1 = 0;
    int temp2 = 0;
// Заполняем массив из старого обходя не нужную строку и столбец
    for(int i = 0; i < array.GetLength(0); i++)
            { if ( i != tempI) {
                for(int j = 0; j < array.GetLength(1); j++)
                    {if (j != tempJ) 
                        {
                        newArray[temp1, temp2] = array[i, j];
                        temp2++;
                        }
                    }
            temp1++;
            temp2 = 0;   
        }
        
    }
    return newArray;
}

int rows = ReadInt("Введите количство строк в массиве");
int cols = ReadInt("Введите количство столбцов в массиве");
int[,] array = FillArray(rows,cols, -9, 9);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
int[,] newArray = DelRouAnDCols(array);
PrintArray(newArray);




