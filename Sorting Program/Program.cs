int[] arrayInts = { 10, 20, 50, 40, 30,};

int maxLength = arrayInts.Length;


int[] newArray = QuickSort(arrayInts, maxLength);

int arrayLength = newArray.Length;


for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine(newArray[i]);
}

/* sorts an array from low to high
 * uses a pivot at a random position in the array and makes an array with all the numbers smaller and an array with all the equal or bigger then the pivot
 * it keeps doing it until there is only one number in each array and then puts all the numbers back together
 */
static int[] QuickSort(int[] arrayInts, int maxLength)
{
    Random rng = new Random();
    int number = arrayInts[rng.Next(0, maxLength)];
    int[] newArray = new int[maxLength]; // Makes the new array that we are going to return



    int counter = 0;
    int counterLower = 0;
    int counterUpper = 0;

    //we makes 2 new Arrays, one for values lower then pivot and one for higher or equal pivot
    int[] lowerArray = new int[maxLength];
    int[] upperArray = new int[maxLength];


    //sort the numbers into the temp arrays 
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

    //Does the QuickSort method again with the array with the lower values 
    if (counterLower > 1)
    {
        lowerArray = QuickSort(lowerArray, counterLower);
    }

    //Does the QuickSort method again with the array with the higher values 
    if (counterUpper > 1)
    {
        upperArray = QuickSort(upperArray, counterUpper);
    }


    //puts the values from the lowerArray in the newArray
    foreach (int j in lowerArray)
    {
        if (j != 0)
        {
            newArray[counter] = j;
            counter++;
        }
    }

    //puts the values from the upperArray in the newArray
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
