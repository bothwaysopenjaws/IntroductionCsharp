using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionCsharp.App3.Model
{
    internal class Beverage
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
    }
}
