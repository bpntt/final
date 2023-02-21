    Console.WriteLine("Введите текст:");
    string[] textMass;
    string text = Console.ReadLine();
    textMass = text.Split(' ');
    int len = textMass.Length;
    Console.WriteLine("Количество слов:");
    Console.WriteLine($"{len}"); 

string[] array1 = new string[] {text};
string[] array2 = new string[array1.Length];
ArrayCreate(array1, array2);
PrintArrayFinal(array2);
void ArrayCreate(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void PrintArrayFinal(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
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
}
 */
