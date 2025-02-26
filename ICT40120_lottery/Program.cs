int number_of_values = 2;
int[] user_guess = new int[number_of_values];


for (int i =0; i < number_of_values; i++)
{
    Console.WriteLine("Gimme number");
    user_guess[i] = int.Parse(Console.ReadLine());
}

//Console.WriteLine(user_guess);

foreach (int i in user_guess)
{
    Console.WriteLine(i);
}

