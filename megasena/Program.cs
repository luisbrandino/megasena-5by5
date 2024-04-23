// Faça um programa que sorteie os 6 numeros da mega sena e guarde os num vetor ordenado
int size = 6;

int[] numbers = new int[size];
int[] sorted = new int[size];

for (int i = 0; i < size; i++)
{
    numbers[i] = new Random().Next(0, 60);
    sorted[i] = numbers[i];
}

for (int i = 0; i < size; i++)
{
    int leastIndex = i;

    for (int j = i + 1; j < size; j++)
        if (sorted[j] < sorted[leastIndex])
            leastIndex = j;

    if (leastIndex == i)
        continue;

    int aux = sorted[leastIndex];

    sorted[leastIndex] = sorted[i];
    sorted[i] = aux;
}

Console.WriteLine("SORTEIO DA MEGA SENA: ");

for (int i = 0; i < size; i++)
{
    Console.Write($"{sorted[i].ToString("00")}");

    if (i < size - 1)
        Console.Write(" - ");
}