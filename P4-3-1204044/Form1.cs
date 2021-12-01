using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace P4_3_1204044
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtHuruf_Leave(object sender, EventArgs e)
        {

            if (txtHuruf.Text == "")
            {
                epWarning.SetError(txtHuruf, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtHuruf, "");
                epCorrect.SetError(txtHuruf, "");
            }
            else
            {
                if ((txtHuruf.Text).All(Char.IsLetter))
                {
                    epWarning.SetError(txtHuruf, "");
                    epWrong.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtHuruf, "Inputan hanya boleh huruf!");
                    epWarning.SetError(txtHuruf, "");
                    epCorrect.SetError(txtHuruf, "");
                }
            }
        }

        private void txtAngka_Leave(object sender, EventArgs e)
        {
            if (txtAngka.Text == "")
            {
                epWarning.SetError(txtAngka, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtAngka, "");
                epCorrect.SetError(txtAngka, "");
            }
            else
            {
                if ((txtAngka.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(txtAngka, "Betul!");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "");
                }
                else
                {
                    epCorrect.SetError(txtAngka, "");
                    epWarning.SetError(txtAngka, "");
                    epWrong.SetError(txtAngka, "Inputan hanya boleh huruf!");
                }
            }

        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epWarning.SetError(txtEmail, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(txtEmail, "");
                epCorrect.SetError(txtEmail, "");
            }
            else
            {
                if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
                {
                    epWarning.SetError(txtEmail, "");
                    epWrong.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "Betul!");
                }
                else
                {
                    epWrong.SetError(txtEmail, "Format email salah\ncontoh: a@b.c");
                    epWarning.SetError(txtEmail, "");
                    epCorrect.SetError(txtEmail, "");
                }
            }
        }

        private void Angka1_Leave(object sender, EventArgs e)
        {
            if (Angka1.Text == "")
            {
                epWarning.SetError(Angka1, "Textbox Huruf tidak boleh kosong!");
                epWrong.SetError(Angka1, "");
                epCorrect.SetError(Angka1, "");
            }
            else
            {
                if ((Angka1.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(Angka1, "Betul!");
                    epWarning.SetError(Angka1, "");
                    epWrong.SetError(Angka1, "");
                }
                else
                {
                    epCorrect.SetError(Angka1, "");
                    epWarning.SetError(Angka1, "");
                    epWrong.SetError(Angka1, "Inputan hanya boleh huruf!");
                }
            }
        }

        private void Angka2_Leave(object sender, EventArgs e)
        {
     
            if (int.Parse(Angka1.Text) > int.Parse(Angka2.Text))
            {
                epWarning.SetError(Angka2, "Betul Angka 1 lebih besar");
                epWrong.SetError(Angka2, "");
                epCorrect.SetError(Angka2, "");
            }
            
            else  
            { 
                if ((Angka2.Text).All(Char.IsNumber))
                {
                    epCorrect.SetError(Angka2, "Betul!");
                    epWarning.SetError(Angka2, "");
                    epWrong.SetError(Angka2, "");
                }
                else
                {
                    epCorrect.SetError(Angka2, "");
                    epWarning.SetError(Angka2, "");
                    epWrong.SetError(Angka2, "Inputan hanya boleh huruf!");
                }
             }
          }
      }
  }
 

