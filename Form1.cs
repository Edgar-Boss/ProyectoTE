using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int gripe = 0, rubeola = 0, malaria = 0, hepatitis = 0, tuberculosis = 0, anemia = 0, cont = 0;
        bool jarabe = false, contrex = false, vitamina = false, vacuna = false, paracetamol = false, otorrino=false,endo=false,nutri=false,mg=false;

        string[] diag = new string[5];

        private void Escalofrios_Check_OnChange(object sender, EventArgs e)
        {
            if (Escalofrios_Check.Checked == true)
            {
                cont++;
                rubeola++;
                malaria++;
                tuberculosis++;
            }
            else
            {
                cont--;
                rubeola--;
                malaria--;
                tuberculosis--;
            }
        }

        private void Jaqueca_Check_OnChange(object sender, EventArgs e)
        {
            if (Jaqueca_Check.Checked == true)
            {
                rubeola++;
                cont++;
            }
            else
            {
                cont--;
                rubeola--;
            }
        }

        private void Secrecion_Check_OnChange(object sender, EventArgs e)
        {
            if (Secrecion_Check.Checked == true)
            {
                rubeola++;
                cont++;
            }
            else
            {
                cont--;
                rubeola--;
            }
        }

        
       

        private void Apatia_Check_OnChange(object sender, EventArgs e)
        {
            if (Apatia_Check.Checked == true)
            {
                anemia++;
                cont++;
            }
            else
            {
                cont--;
                anemia--;
            }
        }

        private void Ictericea_Check_OnChange(object sender, EventArgs e)
        {
            if (Ictericea_Check.Checked == true)
            {
                malaria++;
                hepatitis++;
                cont++;
            }
            else
            {
                cont--;
                malaria--;
                hepatitis--;
            }
        }

        private void Nauseas_Check_OnChange(object sender, EventArgs e)
        {
            if (Nauseas_Check.Checked == true)
            {
                hepatitis++;
                anemia++;
                cont++;
            }
            else
            {
                cont--;
                hepatitis--;
                anemia--;
            }
        }

        private void Cabeza_Check_OnChange(object sender, EventArgs e)
        {
            if (Cabeza_Check.Checked == true)
            {
                gripe++;
                cont++;

            }
            else
            {
                cont--;
                gripe--;
            }
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {

        }

        private void Fiebre_Check_OnChange(object sender, EventArgs e)
        {
            if (Fiebre_Check.Checked == true)
            {
                gripe++;
                rubeola++;
                malaria++;
                tuberculosis++;
                cont++;
            }
            else
            {
                cont--;
                gripe--;
                rubeola--;
                malaria--;
                tuberculosis--;
            }
        }

        private void Cansancio_Check_OnChange(object sender, EventArgs e)
        {
            if (Cansancio_Check.Checked == true)
            {
                cont++;
                gripe++;
                tuberculosis++;
                anemia++;
            }
            else
            {
                cont--;
                gripe--;
                tuberculosis--;
                anemia--;
            }
        }

        private void Tos_Check_OnChange(object sender, EventArgs e)
        {

            if (Tos_Check.Checked == true)
            {
                gripe++;
                tuberculosis++;
                cont++;
            }
            else
            {
                cont--;
                gripe--;
                tuberculosis--;
            }
        }

        
        private void Diarrea_Check_OnChange(object sender, EventArgs e)
        {
            if (Diarrea_Check.Checked == true)
            {
                malaria++;
                hepatitis++;
                cont++;
            }

            else
            {
                cont--;
                malaria--;
                hepatitis--;
            }
                
            
                
            
        }
        
        

        
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
        }

        bool enf = false;
        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {

            if (gripe == 4 && cont == gripe)
            {
                jarabe = true;
                contrex = true;
                vacuna = true;
                enf = true;
            }
            else if (rubeola == 4 && cont == rubeola)
            {
               
                vacuna = true;
                paracetamol = true;
                enf = true;
            }
            else if (malaria == 4 && cont == malaria)
            {
                vacuna = true;
                enf = true;
            }
            else if (hepatitis == 3 && cont == hepatitis)
            {
                vacuna = true;
                paracetamol = true;
                enf = true;
            }
            else if (tuberculosis == 4 && cont == tuberculosis)
            {
                paracetamol = true;
                enf = true;
            }
            else if (anemia == 3 && cont == anemia)
            {
                vitamina = true;
                enf = true;
            }
           

            if(enf == true)
            {
                seleccionar_especialista();
                mostrar_res();
                Limpiar_variables();
            }
            else
            {
                MessageBox.Show("Sintomas no coinciden con ninguna enfermedad");
            }

        }
        void seleccionar_especialista()
        {

            if (jarabe == true || contrex == true )
                otorrino = true;
            if (vacuna == true)
                endo = true;
            if (vitamina == true)
                nutri = true;
            if (vacuna == true || paracetamol == true)
                mg = true;
            
        }
        void mostrar_res()
        {

            Form f = new Resultados();
            ListViewItem it = new ListViewItem("Enfermedad: ");
            listView1.Items.Add(it);
           

            if (gripe == 4 && gripe ==  cont)
            {
                it=new ListViewItem ("Gripe");
                listView1.Items.Add(it);
            }
           
            if(rubeola==4 && cont == rubeola)
            {
                it = new ListViewItem("Rubeola");
                listView1.Items.Add(it);
            }
            if (malaria==3 && cont == malaria)
            {
                it = new ListViewItem("Malaria");
                listView1.Items.Add(it);
            }
            if (hepatitis==3 && cont == hepatitis)
            {
                it = new ListViewItem("Hepatitis");
                listView1.Items.Add(it);
            }
            if (tuberculosis== 4 && cont == tuberculosis)
            {
                it = new ListViewItem("Tuberculosis");
                listView1.Items.Add(it);
            }
            if (anemia== 3 && cont == anemia)
            {
                it = new ListViewItem("Anemia");
                listView1.Items.Add(it);
            }



            it = new ListViewItem("");
            listView1.Items.Add(it);
            it = new ListViewItem("Medicamentos: ");
            listView1.Items.Add(it);
            
            if (jarabe == true)
            {
                it = new ListViewItem("Jarabe");
                listView1.Items.Add(it);
            }
            if (contrex == true)
            {
                it = new ListViewItem("Contrex");
                listView1.Items.Add(it);
            }
            if (vitamina == true)
            {
                it = new ListViewItem("Vitamina");
                listView1.Items.Add(it);
            }
            if (vacuna == true)
            {
                it = new ListViewItem("Vacuna");
                listView1.Items.Add(it);
            }
            if (paracetamol == true)
            {
                it = new ListViewItem("Paracetamol");
                listView1.Items.Add(it);
            }




            it = new ListViewItem("");
            listView1.Items.Add(it);
            it = new ListViewItem("Especialistas: ");
            listView1.Items.Add(it);
           
            if (otorrino == true)
            {
                it = new ListViewItem("Otorrinolaringologo");
                listView1.Items.Add(it);
            }
            if (endo == true)
            {
                it = new ListViewItem("Endocinologo");
                listView1.Items.Add(it);
            }
            if (nutri == true)
            {
                it = new ListViewItem("Nutriologo");
                listView1.Items.Add(it);
            }
            if (mg == true)
            {
                it = new ListViewItem("Medico General");
                listView1.Items.Add(it);
            }


        }

        void Limpiar_variables()
        {
            jarabe = false;
            contrex = false;
            vitamina = false;
            vacuna = false;
            paracetamol = false;
            otorrino = false;
            endo = false;
            nutri = false;
            mg = false;

        }
    }
}
