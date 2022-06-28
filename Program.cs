namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello, World!");

            int[] numeri = { 2, 6, 7, 5, 3, 9 };

            StampaArray(numeri);

            Console.WriteLine();

            int[] arrayQuadrato = ElevaArrayAlQuadrato(numeri);
            StampaArray(arrayQuadrato);


            int sommaItemArray = sommaElementiArray(numeri);
            Console.WriteLine("Somma Array:" + sommaItemArray);

            int sommaArrayQuadrato = sommaElementiArray(arrayQuadrato);
            Console.WriteLine("la somma degli item dell'array al quadrato è " + sommaArrayQuadrato);


            








            // funzioni
            // funzione stampa array
            void StampaArray(int[] array)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine("elemento " + (i + 1) + "-> " + +array[i]);
                }
            }

            // funzione numero elevato a quadrato
            int Quadrato(int numero)
            {
                int risultato = numero * numero;
                return risultato;
            }
            // funzione che restituisce un array con tutti gli elementi elevati al quadrato 
            int[] ElevaArrayAlQuadrato(int[] array)
            {
                int[] arrayCopiato = (int[])array.Clone();

                for (int i = 0; i < arrayCopiato.Length; i++)
                {
                    
                    arrayCopiato[i] = Quadrato(arrayCopiato[i]);
                   
                }
                return arrayCopiato;
            }


            // funzione che restituisce la somma di tutti gli elementi dell'array
            int sommaElementiArray(int[] array)
            {
                int somma = 0;
                for(int i = 0; i < array.Length; i++)
                {
                    somma += array[i];
                }
                return somma;
            }
        }
    }
}