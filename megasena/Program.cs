// Faça um programa que sorteie os 6 numeros da mega sena e guarde os num vetor ordenado
int size = 60;
int sortedSize = 6;

int[] numbers = new int[size];
int[] sorted = new int[sortedSize];

for (int i = 0; i < size; i++)
{
    numbers[i] = i + 1;
}

for (int i = 0; i < sortedSize; i++)
{
    int index; 
    int chosenNumber;

    while (true)
    {
        index = new Random().Next(0, 59);
        chosenNumber = numbers[index];

        if (chosenNumber > 0)
            break;
    }

    sorted[i] = numbers[index];
    numbers[index] = 0;
}

for (int i = 0; i < sortedSize; i++)
{
    int leastIndex = i;

    for (int j = i + 1; j < sortedSize; j++)
        if (sorted[j] < sorted[leastIndex])
            leastIndex = j;

    if (leastIndex == i)
        continue;

    int aux = sorted[leastIndex];

    sorted[leastIndex] = sorted[i];
    sorted[i] = aux;
}

Console.WriteLine("SORTEIO DA MEGA SENA: ");

for (int i = 0; i < sortedSize; i++)
{
    Console.Write($"{sorted[i].ToString("00")}");

    if (i < sortedSize - 1)
        Console.Write(" - ");
}