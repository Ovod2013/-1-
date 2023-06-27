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

int dlMassiva;

Console.WriteLine($"Если вы желаете самостоятельно ввести элементы массива,");
Console.Write($"введите 'Д' или 'Y', иначе введите любой другой символ: ");
string otvet=Console.ReadLine()!;

if (otvet=="Д" | otvet=="д" | otvet== "Y" | otvet == "y")
{
    Console.WriteLine($"Введите длину массива в виде числа от 1 до 65000: ");
    dlMassiva = int.Parse(Console.ReadLine()!);
    otvet="Д";
}
else dlMassiva=4;

string[] res = new string[dlMassiva];
// res[0]="Hello";
// res[1]="2";
// res[2]="world";
// res[3]=":-)";

if (otvet=="Д")
{
    for (int i=0; i<dlMassiva; i++)
    {
        Console.Write($"Введите {i} элемент массива: ");
        res[i]=Console.ReadLine()!;
    }
}
else 
{
//res[]=["Hello","2", "3", "в"];
res[0]="Hello";
res[1]="2";
res[2]="world";
res[3]=":-)";
}

for (int j=0; j<dlMassiva; j++)
{
    Console.WriteLine($"{j} элемент массива: {res[j]}");
}


//int dl=dlMassiva;
int len;
int kolKor=0;
int kolDl=0;
int k=0;
while (k<dlMassiva)
{
len = res[k].Length;
//Console.WriteLine($"Длина {k} элемента массива: {len}, ");
if (len>3) 
    {
        for (int i = k + 1; i < res.Length; i++)
        {
           res[i - 1] = res[i]; 
            // Console.WriteLine($"00 {res[0]}");
            // Console.WriteLine($"11 {res[1]}");
            // Console.WriteLine($"22 {res[2]}");
            // Console.WriteLine($"33 {res[3]}");
        }
       res[res.Length - 1] = "";
            // Console.WriteLine($"0 {res[0]}");
            // Console.WriteLine($"1 {res[1]}");
            // Console.WriteLine($"2 {res[2]}");
            // Console.WriteLine($"3 {res[3]}");
    
        k=k-1;
        dlMassiva=dlMassiva-1;
    
    kolDl++; //Console.WriteLine($"kolDl {kolDl}");
    }
    else kolKor++; //Console.WriteLine($"kolKor {kolKor}");

k++;
}

//Console.WriteLine($"Количество элементов массива длиной 3 и менее символов: {kol}");





            string[] newArray = new string[kolKor];

            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = res[i];
            }

Console.WriteLine($"Новый массив длиной {newArray.Length} из элементов длиной менее или равно 3 символов: ");

for (int j=0; j<newArray.Length; j++)
{
    Console.WriteLine($"{j} элемент массива: {newArray[j]}");
}
Console.WriteLine();
