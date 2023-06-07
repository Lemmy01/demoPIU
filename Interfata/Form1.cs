using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AdministrareStocare;

using LibrarieModele;

namespace Interfata
{
    public partial class Form1 : Form
    {
        AdministrareSondaje admin;

         const int DISTANTA_X = 150;
         const int DISTANTA_Y = 50;

        Label nume;
        Label localitate;
        Label postRadio;
        Label anonim;

        Label[] lbl1;
        Label[] lbl2;
        Label[] lbl3;
        Label[] lbl4;
        DataGridView data;
        public Form1()
        {
            admin = new AdministrareSondaje();
            InitializeComponent();
        }

        private void localitateCBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void anonimBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (!verificareDate())
            {
                MessageBox.Show("Adauga un nume");
            }
            else
            {
                Sondaj sondaj = new Sondaj(nameBox.Text,localitateCBox.Text, postRadioActiv(),anonimBox.Checked);
                admin.adaugaSondaj(sondaj);
                nameBox.Clear();
                localitateCBox.Text="";
                anonimBox.Checked=true;
                elibereazaRadioButtons();
            }
        }

       void elibereazaRadioButtons()
        {
            radBtn1.Checked=false; 
            radBtn2.Checked=false;
            radBtn3.Checked=false;

        }

        void AfiseazaInfo()
        {


            dataGridView1.Rows.Clear();
            foreach (Sondaj sondaj in admin.getSondaje())
            {

                dataGridView1.Rows.Add(sondaj.NumePrenume,sondaj.Localitate,sondaj.PostRadio,sondaj.Anonim);


               
              
                dataGridView1.Update();
            }
        }



        string postRadioActiv()
        {
            if(radBtn1.Checked) { return radBtn1.Text; }
            if (radBtn2.Checked) { return radBtn2.Text; }
            if (radBtn3.Checked) { return radBtn3.Text; }
            return "";
        }
        bool verificareDate()
        {
            if(!anonimBox.Checked)
            {
                if(nameBox.Text == "") { return false; }
                if (!nameBox.Text.Contains(" ")) { return false; }
            }
            else {
                if (nameBox.Text == "") { return true; }
                if (!nameBox.Text.Contains(" ")) { return false; }
            }
            return true;
        }

        private void afiseazaBtn_Click(object sender, EventArgs e)
        {
            AfiseazaInfo();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cautaBtn_Click(object sender, EventArgs e)
        {
            cautaLBox.Items.Clear();
            foreach (Sondaj sondaj in admin.getSondaje()) {
            if(sondaj.PostRadio== postRadioActiv())
                {
                    cautaLBox.Items.Add(sondaj.ToString());
                }
            }
            cautaLBox.Update();
            lblCount.Text = string.Format("Nr: {0}", cautaLBox.Items.Count);
            lblCount.Update();
        }


    }
}
