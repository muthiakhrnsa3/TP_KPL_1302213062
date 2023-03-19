Console.Write("Masukan satu karakter huruf : ");
char input = Console.ReadKey().KeyChar;

if (isVowel(input))
{
    Console.WriteLine($"\nHuruf {input} merupakan huruf vokal\n");
}
else
{
    Console.WriteLine($"\nHuruf {input} merupakan huruf konsonan\n");
}

bool isVowel(char input)
{
    char[] vowelList = { 'a', 'e', 'i', 'o', 'u', 'A', 'I', 'U', 'E', 'O' };

    foreach (char vowel in vowelList)
    {
        if (vowel == input)
        {
            return true;
        }
    }

    return false;
}

int[] evenList = new int[5];

for (int i = 0, j = 2; i < 5; i++, j += 2)
{
    evenList[i] = j;
}

for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Angka genap {i + 1} : {evenList[i]}");
}