int number_of_values = 5;
int lowestValue = 0;
int highestValue = 10;
int[] user_guess_array = new int[number_of_values];
int[] target_array = new int[number_of_values];
int[] correct_guesses_array = new int[number_of_values];

//This function accepts the user's input 
int[] collectInputs()
{
    int[] user_inputs = new int[number_of_values];
    int number_of_value_iteration = 0;
    while (number_of_value_iteration < number_of_values)
    {
        Console.WriteLine("number");
        if (int.TryParse(Console.ReadLine(), out int enteredValue))
        {
            if (LinearSearch(user_inputs, enteredValue, number_of_value_iteration) == -1)
            {
                if (enteredValue <= highestValue && enteredValue >= lowestValue)
                {
                    user_inputs[number_of_value_iteration] = enteredValue;
                    number_of_value_iteration++;
                }
                else
                {
                    Console.WriteLine($"The number has to be between {lowestValue} and {highestValue}");
                }
            }
            else
            {
                Console.WriteLine("You gave me that number before. Give me a new one");
            }
        }
        else
        {
            Console.WriteLine("Try again");
        }
    }
    return user_inputs;
}


int[] GenerateRandom()
{
    Random rnd = new Random();
    int i = 0; 
    int[] randomArray = new int[number_of_values]; 
    while (i < number_of_values)
        {
            int randomNumber = rnd.Next(lowestValue, highestValue);
            if (LinearSearch(randomArray, randomNumber, i) == -1)
            {
            randomArray[i] = randomNumber;
                i++;
            }
        }
    return randomArray;

}

//create print function
void PrintArray(int[] array, string array_type)
{
    Console.WriteLine($"The numbers in {array_type} were:");
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i]);
}   


// Linear Search to search if the number has previously been provided
int LinearSearch(int[] array, int valuetoSearch, int validLength)
{
    for (int i = 0; i < validLength; i++)
        if (array[i] == valuetoSearch)
        {
            return i;
        }
    return -1;
}


// BinarySearch to check the array for win conditions

int BinarySearch(int[] array, int valuetoSearch,int low, int high)
{
    Array.Sort(array);   
    if (high >= low)
    {
        int mid = (high + low) / 2;
        if (array[mid] == valuetoSearch) return mid;
        if (array[mid] > valuetoSearch) return BinarySearch(array, valuetoSearch, low, mid - 1);

            return BinarySearch(array, valuetoSearch, mid +1, high );
    }
    return -1;
}

int CountCorrectGuesses(int [] array)
{
    int correct_guess = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] != -1)
        {
            correct_guess++;
        }
    return correct_guess;
}

// main


target_array = GenerateRandom();
user_guess_array = collectInputs();
// Creates new array to store index of correct guess
for (int i = 0; i < number_of_values; i++)
    // this is a test scenario
    //correct_guesses_array[i] = BinarySearch([3,5,6,8,9], user_guess_array[i], 0 , number_of_values);
correct_guesses_array[i] = BinarySearch(target_array, user_guess_array[i], 0 , number_of_values);


Console.WriteLine($"You have gotten {CountCorrectGuesses(correct_guesses_array)} guesses correct");

PrintArray(target_array,"lottery numbers");
PrintArray(user_guess_array, "your guesses");

