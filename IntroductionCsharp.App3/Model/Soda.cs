using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCsharp.App3.Model;

/// <summary>
/// Classe d'un soda
/// </summary>
internal class Soda : Beverage
{
    /// <summary>
    /// Taux de cafféine.
    /// </summary>
    public double CaffeineRate { get; set; }

    /// <summary>
    /// Initialise un soda
    /// </summary>
    /// <param name="name">Nom</param>
    /// <param name="price">Prix</param>
    /// <param name="brand">Marque</param>
    /// <param name="caffeineRate">Taux de cafféine</param>
    public Soda(string name, double price, Brand brand, double caffeineRate) 
        : base(name, price, brand)
    {
        CaffeineRate = caffeineRate;
    }
}
