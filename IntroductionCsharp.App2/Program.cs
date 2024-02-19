

using IntroductionCsharp.App2.Model;

internal class Program
{
    /// <summary>
    /// Liste des membres de la classe
    /// </summary>
    internal static List<ClassMember> classMember = new List<ClassMember>();

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
    /// 
    private static void Supprimer()
    {
        ClassMember? selectedClassMember = null;
        do
        {
            Console.WriteLine("Indiquer le nom de la personne à supprimer");
            string? searchLastName = Console.ReadLine();
            Console.WriteLine("Indiquer le prénom de la personne à supprimer");
            string? searchFirstName = Console.ReadLine();

            selectedClassMember = null;

            foreach (ClassMember classmate in classMember)
            {
                if (classmate.FirstName == searchFirstName && classmate.LastName == searchLastName)
                {
                    selectedClassMember = classmate;
                }
            }
        } while (selectedClassMember == null);
        classMember.Remove(selectedClassMember);

    }
    /*
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
    }*/

    /// <summary>
    /// Modifie un membre
    /// </summary>
    private static void Modifier()
    {
        ClassMember? selectedClassMember = null;
        do
        {
            Console.WriteLine("Indiquer le nom de la personne à modifier");
            string? searchLastName = Console.ReadLine();
            Console.WriteLine("Indiquer le prénom de la personne à modifier");
            string? searchFirstName = Console.ReadLine();

            selectedClassMember = null;

            foreach (ClassMember classmate in classMember)
            {
                if (classmate.FirstName == searchFirstName && classmate.LastName == searchLastName)
                {
                    selectedClassMember = classmate;
                }
            }
        } while (selectedClassMember == null);

        Console.WriteLine("Indiquez le nouveau nom de la personne");
        selectedClassMember.LastName = Console.ReadLine() ?? "non renseigné";
        Console.WriteLine("Indiquez le nouveau prénom de la personne");
        selectedClassMember.FirstName = Console.ReadLine() ?? "non renseigné";
    }

    /*
    private static void ModifierOld()
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
    }*/

    /// <summary>
    /// Lister les membres de la classe
    /// </summary>
    private static void Lister()
    {
        Console.WriteLine("Liste des membres : ");

        foreach (ClassMember classmate in classMember)
        {
            Console.WriteLine($" -> {classmate.FullName}");
        }
    }

    /// <summary>
    /// Ajout d'un membre à la classe.
    /// </summary>
    private static void AddClassMember()
    {
        Console.WriteLine("Indiquez le nom de la personne à ajouter");
        string? userInputLastName = Console.ReadLine() ?? "";

        Console.WriteLine("Indiquez le prénom de la personne à ajouter");
        string? userInputFirstName = Console.ReadLine() ?? "";

        ClassMember classmate = new ClassMember(userInputLastName, userInputFirstName);
        // On ajoute userInput à la fin de notre liste.
        classMember.Add(classmate);
    }
}