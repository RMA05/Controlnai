//Из заданного массива,находим элемнты массива котрый меньше или равно 3-м символам - это главный алгоритм.
string[] array = { "Hello", "2", "mouse", "ok", "-2" };

int count = 0;
for (int index = 0; index < array.Length; index++)
{
    if (array[index].Length < 4)
    {
        count++;
    }
}
//Создать новый массив равное размером колличеством этих элементов.
string[] Array = new string[count];
int indexx = 0;
for (int i = 0; i < array.Length; i++)
{
//Записываем элементы который мы вывели в новый масиив.
    if (array[i].Length < 4)
    {
        Array[indexx] = array[i];
        indexx++;
    }
}
//Выводим изночальный заданый массив и конечный на печать.
PrintArray(array);
PrintArray(Array);
void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + "  |  ");
    }
    System.Console.WriteLine();
}