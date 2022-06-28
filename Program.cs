namespace csharp_functions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Quanti numeri vuoi inserire?");
            int n = int.Parse(Console.ReadLine());

            int[] numeri = new int[n];


            Console.WriteLine("Digita i " + n + " numeri");
            //int itemArray = int.Parse(Console.ReadLine());
            for (int i = 0; i < numeri.Length; i++)
            {
                int itemArray = int.Parse(Console.ReadLine());
                numeri[i] = itemArray;
            }
            
            // stampa array
            Console.WriteLine("Stampa array dei numeri base");
            StampaArray(numeri);
            Console.WriteLine();

            // stampa array al quadrato con verifica
            int[] arrayQuadrato = ElevaArrayAlQuadrato(numeri);
            Console.WriteLine("Stampa array dei numeri elevati al quadrato");
            StampaArray(arrayQuadrato);
            Console.WriteLine();
            Console.WriteLine("Stampa verifica array dei numeri base");
            StampaArray(numeri);

            // somma elementi array
            Console.WriteLine();
            int sommaItemArray = sommaElementiArray(numeri);
            Console.WriteLine("Somma Array: " + sommaItemArray);

            // somma elementi array al quadrato
            Console.WriteLine();
            int sommaArrayQuadrato = sommaElementiArray(arrayQuadrato);
            Console.WriteLine("la somma degli item dell'array al quadrato è: " + sommaArrayQuadrato);


            // funzioni
            // funzione stampa array
            void StampaArray(int[] array)
            {
                Console.Write("[");
                for (int i = 0; i < array.Length; i++)
                {
                    Console.Write("elemento " + (i + 1) + "-> " + +array[i] + ", ");
                }
                Console.WriteLine("]");
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