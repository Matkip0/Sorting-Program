int[] arrayInts = { 10, 20, 50, 40, 30 };

int maxLength = arrayInts.Length;


int[] newArray = QuickSort(arrayInts, maxLength);

static int[] QuickSort(int[] arrayInts, int maxLength)
{
    Random rng = new Random();
    int number = arrayInts[rng.Next(0, maxLength)];
    int[] newArray = new int[maxLength * 2]; // Laver det nye array klar til at blive sent tilbage.



    int counter = 0;
    int counterLower = 0;
    int counterUpper = 0;

    int[] lowerArray = new int[maxLength];
    int[] upperArray = new int[maxLength];


    foreach (int i in arrayInts)
    {
        if (i != 0)
        {
            if (i <= number)
            {
                lowerArray[counterLower] = i;
                counterLower++;
            }

            else if (i > number)
            {
                upperArray[counterUpper] = i;
                counterUpper++;
            }
        }
    }

    if (counterLower > 1)
    {
        lowerArray = QuickSort(lowerArray, counterLower);


    }

    if (counterUpper > 1)
    {
        upperArray = QuickSort(upperArray, counterUpper);
    }


    foreach (int j in lowerArray)
    {
        if (j != 0)
        {
            newArray[counter] = j;
            counter++;
        }
    }

    foreach (int j in upperArray)
    {
        if (j != 0)
        {
            newArray[counter] = j;
            counter++;
        }
    }

    return newArray;
}



int arrayLength = newArray.Length;


for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine(newArray[i]);
}