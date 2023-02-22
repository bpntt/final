/* 
string[] array1 = new string[] {};
string[] array2 = new string[array1.Length];
ArrayCreate(array1, array2);
/* PrintArrayFinal(array2); */
/* void ArrayCreate(string[] array1, string[] array2)
{
        Console.WriteLine("Введите текст:");
    string[] textMass;
    string text = Console.ReadLine();
    textMass = text.Split(' ');
    int len = textMass.Length;
    Console.WriteLine("Количество слов:");
    Console.WriteLine($"{len}");
    int count = 0;
    for (int i = 0; i < len; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
     for (int i = 0; i < len; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
} */
/* void PrintArrayFinal(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
} */
/* int main()
{
    Console.WriteLine("Введите текст:");
    string[] textMass;
    string text = Console.ReadLine();
    textMass = text.Split(' ');
    int len = textMass.Length;
    Console.WriteLine("Количество слов:");
    Console.WriteLine($"{len}");
    return len;
} */

/* 
Console.WriteLine("Введите текст:");
string[] textMass;
string text = Console.ReadLine();
textMass = text.Split(' ');
int size = textMass.Length;
Console.WriteLine("Количество слов:");
Console.WriteLine($"{size}");
FillArray(size,text);
void FillArray(int size, string text)
{
    string[] array1 = new string[size];
    string[] array2 = new string[array1.Length];
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array1[i]} ");
    }
    Console.WriteLine();
} */

string[] array1 = new string[5] {"hello", "goodbie", "yep", "123", "bmw"};
string[] array2 = new string[array1.Length];
StringToArray(array1, array2);
PrintArray(array1);
PrintArray(array2);
void StringToArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array = array.Where(x => x != null).ToArray();
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine("]");
}