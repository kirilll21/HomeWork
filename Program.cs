Console.Clear();
string[] myArrayStrings = { "Hello", "2", "world", "231", "223", "ggez" };

string[] Selection(string[] myArrayStrings)
{
    string[] ArrayFinite = new string[0];
    int j = 0;
    for (int i = 0; i < myArrayStrings.Length; i++)
    {
        if (myArrayStrings[i].Length <= 3)
        {
            int lenght = ArrayFinite.Length;
            Array.Resize(ref ArrayFinite, lenght + 1);
            ArrayFinite[j] = myArrayStrings[i];
            j++;

        }
    }
    return (ArrayFinite);
}

void WriteArray(string[] myArrayStrings, string[] ArrayFinite)

{
    Console.Write("[");
    for (int i = 0; i < myArrayStrings.Length; i++)
    {
        Console.Write(myArrayStrings[i]);
        if (i != myArrayStrings.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("] -> [");
    for (int i = 0; i < ArrayFinite.Length; i++)
    {
        Console.Write(ArrayFinite[i]);
        if (i != ArrayFinite.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}
WriteArray(myArrayStrings, Selection(myArrayStrings));