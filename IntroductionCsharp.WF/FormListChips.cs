using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntroductionCsharp.WF
{
    public partial class FormListChips : Form
    {
        /// <summary>
        /// Liste des chips
        /// </summary>
        public List<string> ListChips { get; set; }

        /// <summary>
        /// Constructeur de la fenêtre
        /// </summary>
        public FormListChips()
        {
            ListChips = new();
            ListChips.Add("Barbecue");
            ListChips.Add("Poulet");
            ListChips.Add("Bolognaise");
            ListChips.Add("Crème oignons");
            ListChips.Add("Paprika");
            ListChips.Add("Hot & Spicy");
            InitializeComponent();
            listBoxChips.DataSource = ListChips;
        }
    }
}
