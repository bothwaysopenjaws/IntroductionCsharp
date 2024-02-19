
// On affichier une phrase.
Console.WriteLine("Comment t'appelle-tu ?");

// On récupère la saisie utilisateur
string? saisie = Console.ReadLine();

// On affiche la saisie utilisateur
Console.WriteLine($"Bonjour {saisie}");

Random random = new Random();

Console.WriteLine("Quel niveau souhaitez-vous ? Facile, Intermédiaire, Difficile");

string? choixUtilisateur = null;
bool correctChoice = false;
int minValue = 0;
int maxValue = 0;
int pointVie = 5;

while (!correctChoice)
{
    choixUtilisateur = Console.ReadLine();
    switch (choixUtilisateur)
    {
        case "Facile":
            correctChoice = true;
            minValue = 0;
            maxValue = 5;
            pointVie = 5;
            break;
        case "Intermédiaire":
            correctChoice = true;
            minValue = 0;
            maxValue = 10;
            pointVie = 5;
            break;
        case "Difficile":
            correctChoice = true;
            minValue = 0;
            maxValue = 10;
            pointVie = 3;
            break;
        default:
            //Cas général
            Console.WriteLine("Saisie incorrecte, ressaisissez :(Facile, Intermédiaire, Difficile)");
            break;
    }
}

// Je génère un nombre aléatoire entre minValue et maxValue
int nombreSecret = random.Next(minValue, maxValue);

string? nombreChoisi = null;  

int nombreChoisiEntier = -1; 

// booléen de vérification de fin de jeu
bool isFinished = false;


// boucle du jeu
while (!isFinished)
{
    Console.WriteLine("Devine le nombre que j'ai généré ?");
    nombreChoisi = Console.ReadLine();
    // Solution 1 : On essaye, et on passe dans le catch si on a une erreur.
    try
    {
        nombreChoisiEntier = int.Parse(nombreChoisi);
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ceci n'est pas un nombre !" + ex.Message);
    }
    /*
    do
    {
        nombreChoisi = Console.ReadLine();
    } while (int.TryParse(nombreChoisi, out nombreChoisiEntier));
    */

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
            string plusOuMoins = (nombreChoisiEntier >= nombreSecret) ? "inférieur" : "supérieur";
            Console.WriteLine($"Try again, il te reste {pointVie} points de vie");
            Console.WriteLine($"Petit indice, le nombre secret est {plusOuMoins}");
        }
    }
}