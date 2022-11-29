string[] array1 = { "KeK", "Hi!", "Moscow",
      "Go", "Denmark", "Friday", "SOS" };
string[] array2 = new string[array1.Length];

void methodArray (string [] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {      
        if (array1[i].Length <= 3)
        {
        array2 [count]=array1[i];;
        count++;
        }
    }
}

methodArray(array1);