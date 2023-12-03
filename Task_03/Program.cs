// Задача 3: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

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
int FindLowStringSum(int[,] array){
int numString = 0;
int[] tempArray = new int[array.GetLength(0)];
    for(int i = 0; i < array.GetLength(0); i++)
        {
            for(int j = 0; j < array.GetLength(1); j++)
                tempArray[i] += array[i, j];
        }
int min = tempArray[0];
    for(int i = 0; i < tempArray.Length; i++){
        if (tempArray[i] < min){
            min = tempArray[i];
            numString = i;
        }
    }   
return numString;
}

int[] NotSqrt(){
    int[] temp = new int[2];
    int r = ReadInt("Введите количство строк в массиве");
    int c = ReadInt("Введите количство столбцов в массиве");
while(true){
if (r == c) {
    System.Console.WriteLine("Массив не прямоугольный, посторите ввод размера");
    r = ReadInt("Введите количство строк в массиве");
    c = ReadInt("Введите количство столбцов в массиве");
}
else {
    temp[0] = r;
    temp[1] = c;
    return temp;
}

}
}

int[] arrayLen = NotSqrt(); //Проверка, что не квадрататная матица получится
// Незнал как вернуть 2 значения из функции, воспользовался массивом
int[,] array = FillArray(arrayLen[0],arrayLen[1], -9, 9);
System.Console.WriteLine();
PrintArray(array);
System.Console.WriteLine();
int numString = FindLowStringSum(array);
System.Console.WriteLine($"Сумма цифр меньше всего в строке {numString}");