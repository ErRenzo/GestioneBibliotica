using GestioneBiblioteca;

Console.WriteLine("Gestione Bibliotecha");

Console.WriteLine("Inserimento libbri");

Libro[] biblioteca = new Libro[500];

bool continua = true;
int indice = 0;

while (continua)
{
    // sinatssi di creazione di un ogetto
    // da una classe
    Libro oggettoLibro = new Libro();

    Console.WriteLine("Inserisci il titolo: ");
    oggettoLibro.Titolo = Console.ReadLine();
    Console.WriteLine("Inserisci il autore: ");
    oggettoLibro.Autore = Console.ReadLine();
    Console.WriteLine("Inserisci il numero di pagine: ");
    oggettoLibro.Pagine = int.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci il prezzo");
    oggettoLibro.Prezzo = decimal.Parse(Console.ReadLine());

    Console.WriteLine("Il prezzo in dollari sarà " + oggettoLibro.PrezzoInDollari());

    biblioteca[indice] = oggettoLibro;
    indice++;

    Console.WriteLine("Vuoi inserire un altro libro (S/N)");
    string risposta = Console.ReadLine();
    if (risposta == "N") continua = false;
}
