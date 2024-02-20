using IntroductionCsharp.App3.Model;

namespace IntroductionCsharp.App3;

internal class Program
{
    #region Lists

    public static List<Brand> Brands = new();
    public static List<Beverage> Beverages = new();

    #endregion

    #region Methods

    #region System


    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    #endregion


    private static void AddData()
    {
        Brand brandLeffe = new() { Name="Leffe" };
        Brand brandCoreff = new() { Name="Coreff" };
        Brand brandCocaColaCompany = new() { Name="CocaColaCompany" };

        Brands.Add(brandLeffe);
        Brands.Add(brandCoreff);
        Brands.Add(brandCocaColaCompany);

        Beer ruby = new Beer() 
        { 
            Name="Ruby", 
            Brand=brandLeffe,
            PercentAlcohol=3.2
            ,Price = 2
        };
        brandLeffe.Beverages.Add(ruby);
        Beer maximator = new Beer()
        {
            Name = "Maximator",
            Brand = brandLeffe,
            PercentAlcohol = 13.2,
            Price = 2
        };
        brandLeffe.Beverages.Add(maximator);

        Soda sodaCoca = new Soda()
        {
            Name = "Coca-Cola",
            Brand = brandCocaColaCompany,
            Price = 2.5,
            CaffeineRate = 0.1
        };
        brandCocaColaCompany.Beverages.Add(sodaCoca);
    }

    #endregion

}
