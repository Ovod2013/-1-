## Аннотация к программе "Выборка строк из массива" ##
Данная программа из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам.
Предлагается выбрать ввод массива с клавиатуры либо использовать пример массива, заложенный в программе.
В качестве примера используется следующий массив из четырёх элементов:
“Hello”, “2”, “world”, “:-)”.
  При выборе ввода массива с клавиатуры предлагается ввести длину массива, затем ввести каждый элемент по порядку от 0 элемента до конца массива.
  После обработки этого массива на консоль выводится новый массив из строк, длина которых меньше или равна 3 символам. После обработки заложенного примера выводится массив из двух элементов: “2”, “:-)”.

## Описание программы ##

### 1 Общие сведения ###
Программа написана на языке высокого уровня С#. Программа именуется "Выборка строк из массива". 
### 2 Функциональное назначение ###
Программа предназначена для создания нового массива из строк, длина которых меньше, либо равна 3 символам из имеющегося массива. Первоначальный массив можно ввести с клавиатуры, либо использовать тестовую последовательность, заложенную в программе. В качестве примера используется следующий массив из четырёх элементов: “Hello”, “2”, “world”, “:-)”. После обработки этого массива на консоль выводится следующий новый массив из двух элементов: “2”, “:-)”. 
### 3 Описание логической структуры ###
Логическая структура программы приведена в виде блок–схемы алгоритма в приложении 1.
### 3.1 Руководство пользователя ###
После запуска программы на выполнение производится очистка экрана и на экране появится сообщение (сообщения показаны после длинного тире в кавычках): 
— «Если вы желаете самостоятельно ввести элементы массива, введите 'Д', иначе введите любой другой символ: ».
Пользователю необходимо набрать ответ на клавиатуре и завершить ввод нажатием клавиши <Enter>. 
Например, пользователь ввёл «Д».
После этого на экране появится запрос:
— «Введите длину массива в виде числа от 1 до 65535: »
Необходимо набрать требуемое число.
Например, набрано число «3», на экране появится запрос «0» элемента массива:
— «Введите 0 элемент массива: »
Введите элемент массива. 
Далее последовательно введите оставшиеся элементы массива.
После введения последнего элемента программа выводит список  введённых элементов: 
— «Массив для поиска элементов длиной 3 и менее символов: 
123, 4567, 4»
И выводит ответ:
— «Новый массив из 2 элементов длиной 3 и менее символов: 
123, 4»
При вводе иного символа, чем «Д», в качестве массива используются элементы контрольного примера: “Hello”, “2”, “world”, “:-)”. Ответом будет массив “2”, “:-).
### 4 Используемые технические средства ###
Для создания программы использовался компьютер на платформе ЭВМ IBM PC, с процессором Intel(R) Core(TM) i5-4670 CPU @ 3.40GHz   3.40 GHz, тактовой частотой 3.40GHz и  3.40 GHz, оперативной памятью 16,0 ГБ, под управлением операционной системы Windows 10 Домашняя.
Для нормального функционирования программы необходимо следующее программное обеспечение:
операционная система Windows; программа Visual Studio Code.
### 5 Вызов и загрузка ###
Вызов программы производится с жесткого диска. Объем папки с программой составляет 499296 байт.
Для загрузки данной программой необходимо открыть папку «task01», запустить файл "Program.cs". Запустится программа «Visual studio Code»,  на экране появится текст программы. В проводнике этой программы выбрать папку «task01», кликнуть правой кнопкой мыши на файле "Program.cs", кликнуть левой кнопкой мыши «открыть во встроенном терминале»,  на экране в нижней части появится окно терминала программы. Для запуска программы на исполнение пользователю необходимо в терминале ввести команду «dotnet run».
### 6 Входные данные ###
Входными данными являются:
Массив строк (тип str);
Целое число (тип int).
### 7 Выходные данные ###
Выходные данные:
Массив строк (тип str).
### 8 Контрольный пример ###
“Hello”, “2”, “world”, “:-)”  →  “2”, “:-)”.

