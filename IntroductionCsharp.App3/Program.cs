using IntroductionCsharp.App3.Model;
using System.Net.WebSockets;

namespace IntroductionCsharp.App3;

internal class Program
{
    #region Lists

    public static List<Brand> Brands = new();
    public static List<Beverage> Beverages = new();

    #endregion

    #region Methods

    #region System

    /// <summary>
    /// Méthode d'entrée
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        // Permet d'afficher les caractères spéciaux
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        AddData();


        Brand? selectedBrand = null;
        // On recherche la marque par son nom dans la liste
        foreach (Brand brand in Brands)
            if (brand.Name == "Leffe")
                selectedBrand = brand;
        Console.WriteLine("Liste des boissons Leffe");       
        
        if (selectedBrand != null)
            // On boucle sur les boissons de la marque pour les afficher
            foreach (Beverage beverage in selectedBrand.Beverages)
                Console.WriteLine($" - {beverage}");
    }

    #endregion

    /// <summary>
    /// Ajout de données
    /// </summary>
    private static void AddData()
    {
        Brand brandLeffe = new() { Name="Leffe" };
        Brand brandCoreff = new() { Name="Coreff" };
        Brand brandCocaColaCompany = new() { Name="CocaColaCompany" };

        Brands.Add(brandLeffe);
        Brands.Add(brandCoreff);
        Brands.Add(brandCocaColaCompany);

        Beer ruby = new Beer("Ruby", 2, brandLeffe, 3.2);
        Beer maximator = new Beer("Maximator", 2, brandLeffe, 13.2);
        Soda sodaCoca = new Soda("Coca-Cola", 2.5, brandCocaColaCompany, 0.1);

    }

    #endregion
}
