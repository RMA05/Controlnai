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
