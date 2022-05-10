using System; // riferimento alla libreria di base

// namespace: spazio di nomi
// permette di utilizzare variabili con stesso nome ma natura diversa
// es. string, int
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program // classe (internal > non viene vista all'esterno)
    {
        // metodo statico > esiste sempre, non viene creata la classe
        // MAIN > programma principale, pezzo di codice che viene mandato in esecuzione
        //        appena viene lanciato il programma (entry point)
        //        "il nostro programma inizia qui"
        static void Main(string[] args) // entry point
        {
            int n1, n2;

            // Parse o TryParse (corregge gli errori, funziona come la TryCatch)
            // converte la stringa in un n. a 32 bit

            // OUT > la variabile non viene inizializzata prima
            //       in uscita la variabile viene valorizzata dalla funzione
            //       senza out non viene modificato

            if (!int.TryParse(Console.ReadLine(), out n1))
            {
                Console.WriteLine("Invalid! Digitare un numero");
                // termina il programma, e' un modo per uscire
                // 1 > per il SO c'e' un errore
                // 0 > per il SO e' tutto okay
                System.Environment.Exit(1);
            }
            System.Console.WriteLine("Inserisci il primo numero:");

            if (!int.TryParse(Console.ReadLine(), out n2))
            {
                Console.WriteLine("Invalid! Digitare un numero");
                System.Environment.Exit(1);
            }
            System.Console.WriteLine("Inserisci il secondo numero:");

            // stampo in console il risultato
            System.Console.WriteLine("Risultato: {0}", Mult(n1, n2));
        }

        static int Mult(int n1, int n2)
        {   
            return n1 * n2;
        }
    }
}

