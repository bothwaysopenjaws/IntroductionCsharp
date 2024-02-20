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
    /// Degré d'alcool
    /// </summary>
    public double PercentAlcohol { get; set; }
}
