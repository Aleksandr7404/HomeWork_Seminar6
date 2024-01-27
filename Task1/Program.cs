// Задайте двумерный массив символов (тип char [,]).
// Создать строку из символов этого массива.

string ArrCharsToString(char[,] array)
{
    //int size = array.GetLength(0) * array.GetLength(1);
    string str = "";
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            str += array[i, j];
        }
    }
    return str;
}
char[,] array_chars = {
    {'H','e','l','l','o',' '},
    {'c','r','a','z','y',' '},
    {'W', 'o', 'r', 'l','d','!'}
};
Console.WriteLine(ArrCharsToString(array_chars));



