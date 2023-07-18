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

Console.Clear(); // Очистка консоли

int dlMassiva; // Объявление переменной целочисленного типа
// Запрос пользователя, хочет ли он самостоятельно ввести элементы массива
Console.WriteLine($"Если вы желаете самостоятельно ввести элементы массива,");
Console.Write($"введите 'Д' или 'Y', иначе введите любой другой символ: ");
string otvet=Console.ReadLine()!;
// Проверка введённого символа на согласие с учётом возможной ошибки 
// в раскладке клавиатуры
if (otvet == "Д" | otvet == "д" | otvet == "L" | otvet == "l")
{
    // Запрос желаемой длины массива
    Console.WriteLine($"Введите длину массива в виде числа от 1 до 65000: ");
    dlMassiva = int.Parse(Console.ReadLine()!);
    otvet = "Д"; // Приведение введённого символа к единому виду
}
else dlMassiva = 4; // Если ответ "Нет", длина массива устанавливается 4

string[] array = new string[dlMassiva]; // Объявление массива строк длиной 4

// При ответе "Да" в цикле заполнение массива пользователем
if (otvet=="Д")
{
    for (int i=0; i<dlMassiva; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        array[i]=Console.ReadLine()!;
    }
}
else // При ответе "Нет" заполнение массива длиной 4 по умолчанию
{
array[0]="Hello";
array[1]="2";
array[2]="world";
array[3]=":-)";
}
// Вывод заполненного по умолчанию массива на консоль 
//PrintArray(array);

for (int j=0; j<dlMassiva; j++)
{
    Console.WriteLine($"{j} элемент массива: {array[j]}");
}

int DlinaElem;
int kolKorotkixElem=0;
int kolDlinnyxElem=0;
int NomerElem=0;

while (NomerElem<dlMassiva)
{
DlinaElem = array[NomerElem].Length;
    if (DlinaElem>3) 
        {
        for (int i = NomerElem + 1; i < array.Length; i++)
            {
            array[i - 1] = array[i]; 
            }
        array[array.Length - 1] = "";
        NomerElem--;
        dlMassiva--;
        kolDlinnyxElem++; //Console.WriteLine($"kolDl {kolDl}");
        }
    else kolKorotkixElem++; //Console.WriteLine($"kolKor {kolKor}");
NomerElem++;
}

string[] newArray = new string[kolKorotkixElem];

for (int i = 0; i < newArray.Length; i++)
    {
    newArray[i] = array[i];
    }

Console.WriteLine($"Новый массив длиной {newArray.Length} из элементов длиной менее или равно 3 символов: ");

void PrintArray (string[] array)
{

}

for (int j=0; j<newArray.Length; j++)
{
    Console.WriteLine($"{j} элемент массива: {newArray[j]}");
}

