using Week8_AccedemyA_Master_Core.BusinessLayer;
using Week8_AccedemyA_Master_Core.Entities;
using Week8_AccedemyA_Master_Core.InterfaceRepository;
using Week8_AccedemyA_Master_RepositoryMock;

//stiamo creando un oggetto bl tale da farmi accedere a tutti i metodi dell'interfaccia con l'operatore dot
//metto I come interfaccia perchè generalizziamo
//la riga sotto mi serve a far parlare i progetti tra loro
//IBusinessLayer bl = new MainBusinessLayer(new RepositoryCorsiMock(), new RepositoryStudentiMock());
IBusinessLayer bl = new MainBusinessLayer(new RepositoryCorsoEF());
bool continua = true; //scelgo una variabile bool
while(continua)
{
    int choose = Menu();
    continua=AnalizzaScelta(choose);
}

bool AnalizzaScelta(int choose)
{
    switch (choose)
    {
        case 1:
            VisualizzaCorsi();
            break;
        case 2:
            InserisciCorso();
            break;
        case 3:
            ModificaCorso();
            break;
        case 4:
            EliminaCorso();
            break;
        case 5:
            VisualizzaStudenti();
            break;
        case 6:
            InserisciStudente();
            break;
        case 7:
            ModificaStudente();
            break;
        case 8:
            EliminaStudente();
            break;
        case 9:
            VisualizzaStudenti();
            break;
        case 0:
            return false; //analizza la scelta e mi restituisce un booleano
        default:
            break;
    }
    return true;
}

void VisualizzaStudenti()
{
    //recupera la lista dei corsi
    //stampa la lista


    //ora mi serve una variabile dove memorizzare la lista di corsi
    List<Studente> listaStudenti = bl.GetAllStudente(); 
    //stampa lista
    //controllo se la lista è vuota
    if (listaStudenti.Count == 0)
    {
        Console.WriteLine("La lista è vuota");
    }
    else
    {
        foreach (var item in listaStudenti)
        {
            Console.WriteLine(item);
        }
    }
}

void EliminaStudente()
{
    throw new NotImplementedException();
}

void ModificaStudente()
{
    throw new NotImplementedException();
}

void InserisciStudente()
{
    Console.WriteLine("Inserisci l'ID per il nuovo studente");
    string id=Console.ReadLine();
    Console.WriteLine("Inserisci il nome: ");
    string nome=Console.ReadLine();
    Console.WriteLine("Inserisci il cognome: ");
    string cognome=Console.ReadLine();
    Console.WriteLine("Inserisci l' e-mail: ");
    string mail=Console.ReadLine();
    //Console.WriteLine("Inserisci la data di nascita: ");
    Console.WriteLine("Inserisci la data di nascita: ");
    DateTime datebirth=DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Inserisci titolo di studio: ");
    string titolo=Console.ReadLine();
    Console.WriteLine("Inserisci il codice del corso: ");
    string codicecorso=Console.ReadLine();

    Studente nuovoStudente=new Studente();
    
    nuovoStudente.Nome = nome;
    nuovoStudente.Cognome = cognome;
    nuovoStudente.Email = mail;
    nuovoStudente.DataNascita = datebirth;
    nuovoStudente.TitoloStudio = titolo;
    nuovoStudente.CorsoCodice = codicecorso;


    //contiene sia il booleano che il messaggio, 
    //questo bl viene richiamato nella businessLayer
    Esito esito = bl.AddNuovoStudente(nuovoStudente);
    Console.WriteLine(esito.Messaggio);

}

void EliminaCorso()
{
    Console.WriteLine("Questo è l'elenco dei corsi disponibili:");
    VisualizzaCorsi();
    Console.WriteLine("Quale corso vuoi eliminare? Inserisci il codice:");
    string codice = Console.ReadLine();

    Esito esito=bl.RimuoviCorso(codice);
    Console.WriteLine(esito.Messaggio);
    
}

void ModificaCorso()
{
    //stampa tutti i corsi
    Console.WriteLine("Questo è l'elenco dei corsi disponibili:");
    VisualizzaCorsi();
    Console.WriteLine("Quale corso vuoi modificare? Inserisci il codice:");
    string codice=Console.ReadLine();
    Console.WriteLine("Inserisci il nuovo nome del corso");
    string nuovoNome=Console.ReadLine();
    Console.WriteLine("Inserisci la nuova descrizione del corso");
    string nuovaDescrizione=Console.ReadLine();

    Esito esito=bl.ModificaCorso(codice, nuovoNome, nuovaDescrizione);
    Console.WriteLine(esito.Messaggio);

}

void InserisciCorso()
{
    //chiedo all'utente i dati per creare il nuovo corso da aggiungere
    Console.WriteLine("Inserisci il codice del nuovo corso");
    string code=Console.ReadLine();
    Console.WriteLine("Inserisci il nome del nuovo corso");
    string nome=Console.ReadLine();
    Console.WriteLine("Inserisci la descrizione del nuovo corso");
    string descrizione=Console.ReadLine();

    Corso nuovoCorso=new Corso();
    nuovoCorso.CorsoCodice = code;
    nuovoCorso.Nome = nome;
    nuovoCorso.Descrizione = descrizione;

    //ora lo deve aggiungere e far visualizzare il messaggio dell'aggiunta avvenuta
    //questo deve andare però nel core
    //e lo facciamo con il bl 


    //contiene sia il booleano che il messaggio
    Esito esito=bl.AddNuovoCorso(nuovoCorso);
    Console.WriteLine(esito.Messaggio);
}

int Menu()
{
    Console.WriteLine("****Benvenuto****");
    Console.WriteLine("\n Funzionalità Corsi");
    Console.WriteLine("1. Visualizza corsi");
    Console.WriteLine("2. Inserire nuovo corso");
    Console.WriteLine("3. Modifica corso");
    Console.WriteLine("4. Eliminare un corso");

    Console.WriteLine("\n Funzionalità Studenti");
    Console.WriteLine("5. Visualizza elenco completo degli studenti iscritti");
    Console.WriteLine("6. Inserire nuovo studente");
    Console.WriteLine("7. Visualizza corsi");
    Console.WriteLine("8. Elimina uno studente");
    Console.WriteLine("9. Visualizza l'elenco degli studenti iscritti ad un corso");
    Console.WriteLine("\n 0.Exit");
    Console.WriteLine("*****************");

    //recupero della scelta
    int scelta;
    Console.WriteLine("Inserisci la tua scelta");
    while (!(int.TryParse(Console.ReadLine(), out scelta) && scelta>=0 && scelta<=9))
    {
        Console.WriteLine("Scelta Errata. Inserisci una scelta corretta:");
    }return scelta;

    
    }


void VisualizzaCorsi()
{
    //recupera la lista dei corsi
    //stampa la lista

    
    //ora mi serve una variabile dove memorizzare la lista di corsi
    List<Corso > listaCorsi = bl.GetAllCorso(); //deve essere popolata dai corsi veri
    //stampa lista
    //controllo se la lista è vuota
    if (listaCorsi.Count == 0)
    {
        Console.WriteLine("La lista è vuota");
    }
    else
    {
        foreach (var item in listaCorsi)
        {
            Console.WriteLine(item);
        }
    }
}