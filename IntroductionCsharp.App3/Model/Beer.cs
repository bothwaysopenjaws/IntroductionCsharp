using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCsharp.App3.Model;

/// <summary>
/// Bière
/// Hérite de beverage
/// </summary>
internal class Beer : Beverage
{
    /// <summary>
    /// Initialise une bière
    /// </summary>
    /// <param name="name">Nom</param>
    /// <param name="price">Prix</param>
    /// <param name="brand">Marque</param>
    /// <param name="percentAlcohol">Taux d'alcool</param>
    public Beer(string name, double price, Brand brand, double percentAlcohol)
        : base(name, price, brand) 
        => PercentAlcohol = percentAlcohol;

    /// <summary>
    /// Degré d'alcool
    /// </summary>
    public double PercentAlcohol { get; set; }

    /// <summary>
    /// Donne les informations sur la bière
    /// </summary>
    /// <returns></returns>
    public override string ToString() => "[BIERE] > " + base.ToString();
}
