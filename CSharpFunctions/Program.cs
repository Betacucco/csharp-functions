//------------------PROGRAMMA PRINCIPALE------------------------
int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };
StampaArray(arrayDiNumeri);
int sommaNumeriArray = SommaElementiArray(arrayDiNumeri);
Console.WriteLine(sommaNumeriArray);

int[] arrayDiNumeriAlQuadrato = ElevaArrayAlQuadrato(arrayDiNumeri);
StampaArray(arrayDiNumeriAlQuadrato);
int sommaNumeriArrayAlQuadrato = SommaElementiArray(arrayDiNumeriAlQuadrato);
Console.WriteLine(sommaNumeriArrayAlQuadrato);

//----------------------FUNZIONI----------------------------
void StampaArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1]);
    Console.WriteLine("]");
}

int Quadrato(int number)
{
    number = (int)Math.Pow(number, 2);
    return number;
}

int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = Quadrato(copiaArray[i]);
    }
    return copiaArray;  
}

int SommaElementiArray(int[] array)
{
    int somma = 0;

    for(int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}


//-------------------------------------------------------------