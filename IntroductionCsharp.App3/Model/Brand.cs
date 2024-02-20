using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCsharp.App3.Model;

/// <summary>
/// Marque
/// </summary>
internal class Brand
{
    /// <summary>
    /// Nom
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Liste des boissons
    /// </summary>
    public List<Beverage> Beverages { get; set; }
}