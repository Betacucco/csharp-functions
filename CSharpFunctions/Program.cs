//------------------PROGRAMMA PRINCIPALE------------------------
//Array di numeri precompilato e stampa
int[] arrayDiNumeri = { 2, 6, 7, 5, 3, 9 };
StampaArray(arrayDiNumeri);

//Somma numeri all'interno e stampa il risultato
int sommaNumeriArray = SommaElementiArray(arrayDiNumeri);
Console.WriteLine(sommaNumeriArray);

//Quadrato dei numeri dell'array in un nuovo array e stampa
int[] arrayDiNumeriAlQuadrato = ElevaArrayAlQuadrato(arrayDiNumeri);
StampaArray(arrayDiNumeriAlQuadrato);

//Somma numeri all'interno e stampa il risultato
int sommaNumeriArrayAlQuadrato = SommaElementiArray(arrayDiNumeriAlQuadrato);
Console.WriteLine(sommaNumeriArrayAlQuadrato);

//----------------------FUNZIONI----------------------------
//Funzione che stampa l'array
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
//Funzione che esegue il quadrato di un numero
int Quadrato(int number)
{
    number = (int)Math.Pow(number, 2);
    return number;
}
//Esegue il quadrato di ogni numero nell'array
int[] ElevaArrayAlQuadrato(int[] array)
{
    int[] copiaArray = (int[])array.Clone();

    for (int i = 0; i < copiaArray.Length; i++)
    {
        copiaArray[i] = Quadrato(copiaArray[i]);
    }
    return copiaArray;
}
//Somma gli elementi all'interno degli array
int SommaElementiArray(int[] array)
{
    int somma = 0;

    for (int i = 0; i < array.Length; i++)
    {
        somma += array[i];
    }
    return somma;
}

//-------------------------------------------------------------