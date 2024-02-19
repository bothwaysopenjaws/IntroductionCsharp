
// On affichier une phrase.
Console.WriteLine("Comment t'appelle-tu ?");

// On récupère la saisie utilisateur
string? saisie = Console.ReadLine();

// On affiche la saisie utilisateur
Console.WriteLine($"Bonjour {saisie}");

Random random = new Random();

// Je génère un nombre aléatoire entre 0 et 10
int nombreSecret = random.Next(0, 10);

//Console.WriteLine("Devine le nombre que j'ai généré ?");

string? nombreChoisi = null;  //Console.ReadLine();

int nombreChoisiEntier = -1; // int.Parse(nombreChoisi);

// booléen de vérification de fin de jeu
bool isFinished = false;
int pointVie = 5;


// boucle du jeu
while (!isFinished)
{
    Console.WriteLine("Devine le nombre que j'ai généré ?");
    nombreChoisi = Console.ReadLine();
    nombreChoisiEntier = int.Parse(nombreChoisi);

    if (nombreChoisiEntier == nombreSecret)
    {
        Console.WriteLine("gégé, t'es un champion !");
        isFinished = true;
    }
    else
    {
        pointVie--;
        if (pointVie == 0)
        {
            Console.WriteLine($"T'es un looser, c'était {nombreSecret}");
            isFinished = true;
        }
        else
        {
            Console.WriteLine($"Try again, il te reste {pointVie} points de vie");
        }
    }
}