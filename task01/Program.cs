// Написать программу, которая из 
// имеющегося массива строк формирует 
// новый массив из строк, длина 
// которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении 
// не рекомендуется пользоваться 
// коллекциями, лучше обойтись 
// исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
Console.WriteLine();
string[] res = new string[4];
res[0]="Hello";
res[1]="2";
res[2]="world";
res[3]=":-)";

Console.WriteLine($"Вы желаете самостоятельно ввести элементы массива от 0 до 3?");
Console.Write($"Введите 'Да' или 'Нет' : ");
string otvet=Console.ReadLine()!;

if (otvet=="Да")
{
    for (int i=0; i<4; i++)
{
    Console.Write($"Введите {i} элемент массива: ");
    res[i]=Console.ReadLine()!;
}
}
else 

for (int j=0; j<4; j++)
{
    Console.WriteLine($"{j} элемент массива: {res[j]}");
}



int len;
int kol=0;
for (int k=0; k<4; k++)
{
len = res[k].Length;
Console.WriteLine($"Длина {k} элемента массива: {len}");
if (len>3) 
{
    kol++;
    for (int i = k + 1; i < res.Length; i++)
        {
            res[i - 1] = res[i];
        }

        // set the last element to zero
        res[res.Length - 1] = "";

        // print the modified array
        Console.WriteLine("The modified array is:");
        for (int i = 0; i < res.Length; i++)
        {
            
            Console.Write(res[i] + " " + "i");
        }


    }
}

Console.WriteLine($"Количество элементов массива длиной 3 и менее символов: {kol}");

//string[] newArray = new string[kol];


//string[] arr = { "1", "2", "3", "4", "5" };
  //      int index = 2; // the index to start shifting from

    //    for (int i = index + 1; i < arr.Length; i++)
    //    {
    //        arr[i - 1] = arr[i];
    //    }

        // set the last element to zero
    //    arr[arr.Length - 1] = "";

        // print the modified array
    //    Console.WriteLine("The modified array is:");
    //    for (int i = 0; i < arr.Length; i++)
    //    {
            
    //        Console.Write(arr[i] + " " + "i");
    //    }






//string[] res = new string[4];

//int[] originalArray = { 1, 2, 3, 4, 5 };
            string[] newArray = new string[kol];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = res[i];
            }

Console.WriteLine($"Новый массив длиной {newArray.Length} из элементов менее 3 символов: ");

for (int j=0; j<newArray.Length; j++)
{
    Console.WriteLine($"{j} элемент массива: {newArray[j]}");
}






// List<string> numbers = new List<string> { "1", "2", "3", "4", "5" };
//             int indexToRemove = 2; // remove the third element (index 2)

//             numbers.RemoveAt(indexToRemove); // remove the element at index 2
//            // for (int m=0; m<numbers.Length; m++)
// Console.WriteLine($"нумб: {numbers[0]}");
// Console.WriteLine($"нумб: {numbers[1]}");
// Console.WriteLine($"нумб: {numbers[2]}");
// Console.WriteLine($"нумб: {numbers[3]}");
//Console.WriteLine($"нумб: {numbers[4]}");