using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCsharp.App3.Model;

/// <summary>
/// Boisson
/// Ne peut pas être instanciée car abstraite.
/// Doit donc être définie par ses enfants (ici Beer et Soda)
/// </summary>
internal abstract class Beverage
{
    /// <summary>
    /// Nom
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Prix
    /// </summary>
    public double Price { get; set; }

    /// <summary>
    /// Marque associée
    /// </summary>
    public Brand Brand { get; set; }

    /// <summary>
    /// Initialise une boisson.
    /// </summary>
    /// <param name="name">Nom de la boisson</param>
    /// <param name="price">Le prix</param>
    /// <param name="brand">La marque</param>
    protected Beverage(string name, double price, Brand brand)
    {
        Name = name;
        Price = price;
        Brand = brand;

        // On affecte la boisson que l'on vient de créé à la liste
        brand.Beverages.Add(this);
    }

    /// <summary>
    /// Retourne le nom de la boisson
    /// </summary>
    /// <returns>Nom de la boisson</returns>
    public override string ToString() 
        => $"{Brand.Name} - {Name} ({Price}€)";
}
