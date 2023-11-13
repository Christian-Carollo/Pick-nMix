
using System.Collections;

Program program = new Program();

ArrayList arrayList = new ArrayList();


arrayList.Add(1);
arrayList.Add("due");
arrayList.Add(program);
arrayList.Add(true);
arrayList.Add(false);


Console.WriteLine("Contenuto dell'ArrayList:");

for (int i = 0; i < arrayList.Count; i++)
{
    Console.WriteLine(arrayList[i]);
}

/*gli elementi vengono stampati senza un tipo specifico, 
 * mostrando semplicemente il loro valore.
 * Questo accade perchè nell'ArrayList tutti i dati inseriti vengono trattati come tipo object
 */
