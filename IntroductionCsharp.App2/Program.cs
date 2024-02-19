

internal class Program
{
    /// <summary>
    /// Liste des membres de la classe
    /// </summary>
    internal static List<string> classMember = new List<string>();

    /// <summary>
    /// Point d'entrée de l'application
    /// </summary>
    /// <param name="args">arguments</param>
    private static void Main(string[] args)
    {
        ShowMenu();
    }

    /// <summary>
    /// Affiche le menu
    /// </summary>
    private static void ShowMenu()
    {
        bool isFinished = false;
        do
        {
            //On affiche les choix possibles
            Console.WriteLine("Saisissez une action : ");
            Console.WriteLine(" 1 - Ajouter");
            Console.WriteLine(" 2 - Modifier");
            Console.WriteLine(" 3 - Supprimer");
            Console.WriteLine(" 4 - Lister");
            Console.WriteLine(" 0 - Sortir");

            string? userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    AddClassMember();
                    break;
                case "2":
                    Modifier();
                    break;
                case "3":
                    Supprimer();
                    break;
                case "4":
                    Lister();
                    break;
                case "0":
                    isFinished = true;
                    break;
                default:
                    Console.WriteLine("La saisie est incorrecte, go retry !");
                    break;
            }

        } while (!isFinished);
    }

    /// <summary>
    /// Supprime un member
    /// </summary>
    private static void Supprimer()
    {
        Console.WriteLine("Indiquer le nom et prénom de la personne à supprimer");
        bool isIncorrect = true;
        string? userInput = null;
        while (isIncorrect)
        {
            userInput = Console.ReadLine();
            if (classMember.Contains(userInput))
            {
                isIncorrect = false;
            }
            else
            {
                Console.WriteLine("Saisie incorrecte, réessayez.");
            }
        }
        classMember.Remove(userInput);
    }

    /// <summary>
    /// Modifie un membre
    /// </summary>
    private static void Modifier()
    {
        Console.WriteLine("Indiquer le nom et prénom de la personne à modifier");
        bool isIncorrect = true;
        string? userInput = null;
        while (isIncorrect)
        {
            userInput = Console.ReadLine();
            if (classMember.Contains(userInput))
            {
                isIncorrect = false;
            }
            else
            {
                Console.WriteLine("Saisie incorrecte, réessayez.");
            }
        }
        Console.WriteLine("Nouveau nom et prénom :");
        string newName = Console.ReadLine();
        classMember.Remove(userInput);
        classMember.Add(newName);
    }

    /// <summary>
    /// Lister les membres de la classe
    /// </summary>
    private static void Lister()
    {
        Console.WriteLine("Liste des membres : ");

        foreach (string name in classMember)
        {
            Console.WriteLine($" -> {name}");
        }
    }

    /// <summary>
    /// Ajout d'un membre à la classe.
    /// </summary>
    private static void AddClassMember()
    {
        Console.WriteLine("Indiquez le nom et le prénom de la personne à ajouter");
        string? userInput = Console.ReadLine();
        // On ajoute userInput à la fin de notre liste.
        classMember.Add(userInput ?? "Inconnu");
    }
}