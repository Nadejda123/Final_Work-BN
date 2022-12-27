/* Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
 длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
 либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/
		
			
string[] Filling_2nd_array(string[] array,int words_length)
{
    string[] arr2 = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= words_length)
        {
            arr2[count] = array[i];
            count++;
        }
    }return arr2;
}

void PrintArray(string[] array)
{
    if(array.Length == 0)
    Console.WriteLine("Array is empty");
    else
    {
        Array.ForEach(array, (str) => Console.Write($"{str} "));
        Console.WriteLine();
    }
}
		

string [] array1= {"1234", "1567", "-2", "computer science"};
int words_length=3;
string[] array2 = Filling_2nd_array(array1,words_length);
Console.WriteLine("Initial Array:");
PrintArray(array1);
Console.WriteLine($"Result array (words are less or equal than {words_length} symbols)");
PrintArray(array2);
		
