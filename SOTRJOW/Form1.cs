using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Newton JSON way:
using Newtonsoft.Json;

//using System.Diagnostics;

namespace STORJOW
{
   
     public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Language pack:
            langpack LanguagePack = new langpack();

            var culture = System.Globalization.CultureInfo.CurrentCulture;

            //Русская локализация:
            if (culture.ToString() == "ru-RU")
            {
                
                LanguagePack.Rus = new langpack.Russian();
                {
                    this.Text = LanguagePack.Rus.mFormTitle;
                    this.mainMenuToolStripMenuItem.Text = LanguagePack.Rus.fMainMenu[0];
                    this.optionsToolStripMenuItem.Text = LanguagePack.Rus.fMainMenu[1];
                    this.quitToolStripMenuItem.Text = LanguagePack.Rus.fMainMenu[2];
                        
                }
                            

            }
            else
            //Пока в любом другом случае English...
            {
               // this.Text = "Storj: Overwatch";
               
            }
            LanguagePack = null;

            GC.Collect();
            GC.WaitForPendingFinalizers();


        }

     
       
    }
}
