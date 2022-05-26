/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76

*/


// метод создания массива с рандомными значениями

double [] ArrayCreation(int length) { 
    double[] arr = new double[length]; 
    Random rnd = new Random(); 
    for ( int i = 0 ; i< length ; i ++) { 
        arr[i] = rnd.Next(1,10); 
    } 
    return arr; 
    }  
 
// метод для нахождения максимального и минимального элемента массива

(double,double) minAndMaxOfArray(double[] array) {  
    double min = array[0]; 
    double max = array[0]; 
    for (int i = 0; i < array.Length; i++){ 
        if (array[i] < min) 
            min = array[i]; 
        if (array[i] > max) 
            max = array[i]; 
    } 
    return (min,max); 
}

// вывод в консоль массива

void PrintArray(double [] arr) { 
    foreach(double item in arr) 
        Console.Write($"{item} "); 
} 
 
 
double [] arr = ArrayCreation(10); 
double min = 0; 
double max = 0; 
(min,max) = minAndMaxOfArray(arr); 
PrintArray(arr); 
Console.WriteLine(); 
Console.WriteLine($"min = {min}, max = {max}, max - min = {max-min}");