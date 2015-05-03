using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slump
{
    public partial class Form1 : Form
    {
        List<string> Rader { get; set; }
        public Form1()
        {
            InitializeComponent();
            var fil = HämtaFörstaTxtFilen();
            ÖppnaNyFil(fil);
        }

        private void ÖppnaNyFil(string fil)
        {            
            if (fil != null)
            {
                txtSökväg.Text = Path.Combine(Directory.GetCurrentDirectory(), fil);
                LaddaFil(fil);
                UppdateraAntal();
            }
        }

        private void UppdateraAntal()
        {
            label1.Text = Rader.Count + " rader laddades";
        }

        private void LaddaFil(string fil)
        {
            Rader = File.ReadAllLines(fil).ToList();
        }

        private string HämtaFörstaTxtFilen()
        {
            DirectoryInfo di = new DirectoryInfo(Directory.GetCurrentDirectory());
            return di.GetFiles("*.txt")
                .Select(fi => fi.Name)
                .FirstOrDefault();
        }

        private void btnSlumpa_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            var valdRad = Rader[r.Next(Rader.Count)];
            lstTidigareSlag.Items.Insert(0, ParsaRad(valdRad));            
        }

        private void btnÖppnaFil_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {                
                ÖppnaNyFil(openFileDialog1.FileName);
            }
        }        

        private void btnSpecifik_Click(object sender, EventArgs e)
        {
            try
            {
                var valdRad = Rader[Convert.ToInt32(txtRadnummer.Text) - 1];
                lstTidigareSlag.Items.Insert(0, ParsaRad(valdRad));
            }
            catch
            {
                MessageBox.Show("Ange ett värde mellan 1 och "+ Rader.Count());
            }
        }

        private string ParsaRad(string valdRad)
        {
            string pattern = @"(\d+)[td](\d+)([+-]\d+)*";
            var reg = new Regex(pattern, RegexOptions.IgnoreCase);
            var match = reg.Match(valdRad);
            if(match.Success)
            {
                var antal =  Convert.ToInt32(match.Groups[1].Value);
                var tärning =  Convert.ToInt32(match.Groups[2].Value);
                var modifierare =  TillSiffra(match.Groups[3].Value);

                var resultat = SlåTärning(antal, tärning, modifierare);
                return reg.Replace(valdRad, resultat).Replace("[", "").Replace("]", "");
            }
            return valdRad;
        }


        private int TillSiffra(string modifierare)
        {
            if (string.IsNullOrEmpty(modifierare))
                return 0;

            bool negativ = false;
            if(modifierare.Contains("-"))
                negativ = true;
            
            modifierare = modifierare.Replace("+", "").Replace("-", "");
            var siffra = Convert.ToInt32(modifierare);
            if(negativ)
                siffra = siffra * - 1;

            return siffra;            
        }

        private string SlåTärning(int antal, int tärning, int modifierare)
        {
            var resultat = modifierare;
            for(int i = 0; i < antal; i++)
            {
                Random r = new Random();
                resultat += r.Next(1, tärning);
            }
            return resultat.ToString();
        }        
    }
}
