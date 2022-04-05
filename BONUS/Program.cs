//------------PROGRAMMA PRINCIPALE-----------------------
//Chiediamo la dimensione dell'array
Console.Write("Inserisci la dimensione del tuo array: ");
int dimensione = Convert.ToInt32(Console.ReadLine());

//inizializziamo l'array con una dimensione scelta da noi 
int[] arrayDiNumeri = new int[dimensione];
InserisciElementiArray(arrayDiNumeri, dimensione);
StampaArray(arrayDiNumeri);

//Sommiamo i numeri all'interno dell'array
int sommaNumeriArray = SommaElementiArray(arrayDiNumeri);
Console.WriteLine(sommaNumeriArray);

//Eleviamo al quadrato i numeri all'interno dell'array e li stampiamo in un nuovo array
int[] arrayDiNumeriAlQuadrato = ElevaArrayAlQuadrato(arrayDiNumeri);
StampaArray(arrayDiNumeriAlQuadrato);

//Sommiamo i numeri al quadrato all'interno di questo nuovo array 
int sommaNumeriArrayAlQuadrato = SommaElementiArray(arrayDiNumeriAlQuadrato);
Console.WriteLine(sommaNumeriArrayAlQuadrato);

//----------------------FUNZIONI----------------------------
//Funzione per inserire gli elementi nell'array in base alla dimensione scelta
void InserisciElementiArray(int[] array, int n)
{
    for (int i = 0; i < n; i++)
    {
        Console.Write("Inserisci elemento nell'array: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    } 
}
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
