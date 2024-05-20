using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programma84
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void but1Speletajs_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 speletajs1 = new Form2();
            speletajs1.Show();
        }

        private void but2Speletaji_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 speletajs2 = new Form3();
            speletajs2.Show();
        }

        private void butInfo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tavs uzdevums ir pareizi atrisināt reizināšanas piemērus un pirmajam savu spēles kauliņu nogādāt līdz finišam.\n\n" +
                "Ja atbildēsi pareiza, varēsi mest metamo kauliņu un tavs spēles kauliņš pavirzīsies uz priekšu par tik rūtiņām, cik uzmest uz metamā kauliņa.\n" +
                "Ja atbildēsi nepareizi, izlaidīsi gājienu.\n"+
                "Spēlējot vienam, nepareizi atrisināts piemērs būs jārisina, līdz tas tiks atrisināts.\n\n" +
                "Spēli veidoja: Inta\n" +
                "Liepāja 2019",
                "Spēles \"Matemātiskais Riču-Raču\" instrukcija",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
