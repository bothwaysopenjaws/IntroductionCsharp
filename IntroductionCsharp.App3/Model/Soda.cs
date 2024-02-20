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
}
