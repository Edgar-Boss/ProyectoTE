namespace ProyectoTE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.header = new System.Windows.Forms.Panel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Resultados = new System.Windows.Forms.Label();
            this.bunifuFlatButton12 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Secrecion_Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Jaqueca_Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton11 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Tos_Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton10 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Escalofrios_Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton9 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Apatia_Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton8 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Ictericea_Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Cansancio_Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton7 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Nauseas_Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton6 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Cabeza_Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton5 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Fiebre_Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton4 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Diarrea_Check = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.enfermedades = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Medicamentos = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(1063, 31);
            this.header.TabIndex = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.Resultados);
            this.panel1.Controls.Add(this.bunifuFlatButton12);
            this.panel1.Controls.Add(this.Secrecion_Check);
            this.panel1.Controls.Add(this.bunifuFlatButton2);
            this.panel1.Controls.Add(this.Jaqueca_Check);
            this.panel1.Controls.Add(this.bunifuFlatButton11);
            this.panel1.Controls.Add(this.Tos_Check);
            this.panel1.Controls.Add(this.bunifuFlatButton10);
            this.panel1.Controls.Add(this.Escalofrios_Check);
            this.panel1.Controls.Add(this.bunifuFlatButton9);
            this.panel1.Controls.Add(this.Apatia_Check);
            this.panel1.Controls.Add(this.bunifuFlatButton8);
            this.panel1.Controls.Add(this.Ictericea_Check);
            this.panel1.Controls.Add(this.bunifuFlatButton3);
            this.panel1.Controls.Add(this.Cansancio_Check);
            this.panel1.Controls.Add(this.bunifuFlatButton7);
            this.panel1.Controls.Add(this.Nauseas_Check);
            this.panel1.Controls.Add(this.bunifuFlatButton6);
            this.panel1.Controls.Add(this.Cabeza_Check);
            this.panel1.Controls.Add(this.bunifuFlatButton5);
            this.panel1.Controls.Add(this.Fiebre_Check);
            this.panel1.Controls.Add(this.bunifuFlatButton4);
            this.panel1.Controls.Add(this.Diarrea_Check);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.bunifuThinButton21);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 487);
            this.panel1.TabIndex = 1;
            // 
            // listView1
            // 
            this.listView1.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.enfermedades,
            this.Medicamentos});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(730, 19);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(321, 456);
            this.listView1.TabIndex = 30;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Tile;
            // 
            // Resultados
            // 
            this.Resultados.AutoSize = true;
            this.Resultados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Resultados.Location = new System.Drawing.Point(727, 3);
            this.Resultados.Name = "Resultados";
            this.Resultados.Size = new System.Drawing.Size(60, 13);
            this.Resultados.TabIndex = 29;
            this.Resultados.Text = "Resultados";
            // 
            // bunifuFlatButton12
            // 
            this.bunifuFlatButton12.Activecolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton12.BackColor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton12.BorderRadius = 5;
            this.bunifuFlatButton12.ButtonText = "                                  Iniciar";
            this.bunifuFlatButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton12.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton12.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton12.Iconimage = null;
            this.bunifuFlatButton12.Iconimage_right = null;
            this.bunifuFlatButton12.Iconimage_right_Selected = null;
            this.bunifuFlatButton12.Iconimage_Selected = null;
            this.bunifuFlatButton12.IconMarginLeft = 0;
            this.bunifuFlatButton12.IconMarginRight = 0;
            this.bunifuFlatButton12.IconRightVisible = true;
            this.bunifuFlatButton12.IconRightZoom = 0D;
            this.bunifuFlatButton12.IconVisible = true;
            this.bunifuFlatButton12.IconZoom = 90D;
            this.bunifuFlatButton12.IsTab = false;
            this.bunifuFlatButton12.Location = new System.Drawing.Point(278, 422);
            this.bunifuFlatButton12.Name = "bunifuFlatButton12";
            this.bunifuFlatButton12.Normalcolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton12.OnHovercolor = System.Drawing.Color.SeaGreen;
            this.bunifuFlatButton12.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton12.selected = false;
            this.bunifuFlatButton12.Size = new System.Drawing.Size(229, 42);
            this.bunifuFlatButton12.TabIndex = 27;
            this.bunifuFlatButton12.Text = "                                  Iniciar";
            this.bunifuFlatButton12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton12.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton12.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton12.Click += new System.EventHandler(this.bunifuFlatButton12_Click);
            // 
            // Secrecion_Check
            // 
            this.Secrecion_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Secrecion_Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Secrecion_Check.Checked = false;
            this.Secrecion_Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Secrecion_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Secrecion_Check.ForeColor = System.Drawing.Color.White;
            this.Secrecion_Check.Location = new System.Drawing.Point(341, 345);
            this.Secrecion_Check.Name = "Secrecion_Check";
            this.Secrecion_Check.Size = new System.Drawing.Size(20, 20);
            this.Secrecion_Check.TabIndex = 26;
            this.Secrecion_Check.OnChange += new System.EventHandler(this.Secrecion_Check_OnChange);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "             Secreción";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(341, 332);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(116, 48);
            this.bunifuFlatButton2.TabIndex = 25;
            this.bunifuFlatButton2.Text = "             Secreción";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Jaqueca_Check
            // 
            this.Jaqueca_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Jaqueca_Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Jaqueca_Check.Checked = false;
            this.Jaqueca_Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Jaqueca_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Jaqueca_Check.ForeColor = System.Drawing.Color.White;
            this.Jaqueca_Check.Location = new System.Drawing.Point(106, 345);
            this.Jaqueca_Check.Name = "Jaqueca_Check";
            this.Jaqueca_Check.Size = new System.Drawing.Size(20, 20);
            this.Jaqueca_Check.TabIndex = 24;
            this.Jaqueca_Check.OnChange += new System.EventHandler(this.Jaqueca_Check_OnChange);
            // 
            // bunifuFlatButton11
            // 
            this.bunifuFlatButton11.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton11.BorderRadius = 0;
            this.bunifuFlatButton11.ButtonText = "               Jaqueca";
            this.bunifuFlatButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton11.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton11.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton11.Iconimage = null;
            this.bunifuFlatButton11.Iconimage_right = null;
            this.bunifuFlatButton11.Iconimage_right_Selected = null;
            this.bunifuFlatButton11.Iconimage_Selected = null;
            this.bunifuFlatButton11.IconMarginLeft = 0;
            this.bunifuFlatButton11.IconMarginRight = 0;
            this.bunifuFlatButton11.IconRightVisible = true;
            this.bunifuFlatButton11.IconRightZoom = 0D;
            this.bunifuFlatButton11.IconVisible = true;
            this.bunifuFlatButton11.IconZoom = 90D;
            this.bunifuFlatButton11.IsTab = false;
            this.bunifuFlatButton11.Location = new System.Drawing.Point(106, 332);
            this.bunifuFlatButton11.Name = "bunifuFlatButton11";
            this.bunifuFlatButton11.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton11.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton11.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton11.selected = false;
            this.bunifuFlatButton11.Size = new System.Drawing.Size(116, 48);
            this.bunifuFlatButton11.TabIndex = 23;
            this.bunifuFlatButton11.Text = "               Jaqueca";
            this.bunifuFlatButton11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton11.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton11.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Tos_Check
            // 
            this.Tos_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Tos_Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Tos_Check.Checked = false;
            this.Tos_Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Tos_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Tos_Check.ForeColor = System.Drawing.Color.White;
            this.Tos_Check.Location = new System.Drawing.Point(341, 124);
            this.Tos_Check.Name = "Tos_Check";
            this.Tos_Check.Size = new System.Drawing.Size(20, 20);
            this.Tos_Check.TabIndex = 22;
            this.Tos_Check.OnChange += new System.EventHandler(this.Tos_Check_OnChange);
            // 
            // bunifuFlatButton10
            // 
            this.bunifuFlatButton10.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton10.BorderRadius = 0;
            this.bunifuFlatButton10.ButtonText = "                  Tos";
            this.bunifuFlatButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton10.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton10.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton10.Iconimage = null;
            this.bunifuFlatButton10.Iconimage_right = null;
            this.bunifuFlatButton10.Iconimage_right_Selected = null;
            this.bunifuFlatButton10.Iconimage_Selected = null;
            this.bunifuFlatButton10.IconMarginLeft = 0;
            this.bunifuFlatButton10.IconMarginRight = 0;
            this.bunifuFlatButton10.IconRightVisible = true;
            this.bunifuFlatButton10.IconRightZoom = 0D;
            this.bunifuFlatButton10.IconVisible = true;
            this.bunifuFlatButton10.IconZoom = 90D;
            this.bunifuFlatButton10.IsTab = false;
            this.bunifuFlatButton10.Location = new System.Drawing.Point(341, 111);
            this.bunifuFlatButton10.Name = "bunifuFlatButton10";
            this.bunifuFlatButton10.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton10.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton10.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton10.selected = false;
            this.bunifuFlatButton10.Size = new System.Drawing.Size(116, 48);
            this.bunifuFlatButton10.TabIndex = 21;
            this.bunifuFlatButton10.Text = "                  Tos";
            this.bunifuFlatButton10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton10.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton10.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Escalofrios_Check
            // 
            this.Escalofrios_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Escalofrios_Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Escalofrios_Check.Checked = false;
            this.Escalofrios_Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Escalofrios_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Escalofrios_Check.ForeColor = System.Drawing.Color.White;
            this.Escalofrios_Check.Location = new System.Drawing.Point(539, 271);
            this.Escalofrios_Check.Name = "Escalofrios_Check";
            this.Escalofrios_Check.Size = new System.Drawing.Size(20, 20);
            this.Escalofrios_Check.TabIndex = 20;
            this.Escalofrios_Check.OnChange += new System.EventHandler(this.Escalofrios_Check_OnChange);
            // 
            // bunifuFlatButton9
            // 
            this.bunifuFlatButton9.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton9.BorderRadius = 0;
            this.bunifuFlatButton9.ButtonText = "           Escalofrios";
            this.bunifuFlatButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton9.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton9.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton9.Iconimage = null;
            this.bunifuFlatButton9.Iconimage_right = null;
            this.bunifuFlatButton9.Iconimage_right_Selected = null;
            this.bunifuFlatButton9.Iconimage_Selected = null;
            this.bunifuFlatButton9.IconMarginLeft = 0;
            this.bunifuFlatButton9.IconMarginRight = 0;
            this.bunifuFlatButton9.IconRightVisible = true;
            this.bunifuFlatButton9.IconRightZoom = 0D;
            this.bunifuFlatButton9.IconVisible = true;
            this.bunifuFlatButton9.IconZoom = 90D;
            this.bunifuFlatButton9.IsTab = false;
            this.bunifuFlatButton9.Location = new System.Drawing.Point(539, 258);
            this.bunifuFlatButton9.Name = "bunifuFlatButton9";
            this.bunifuFlatButton9.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton9.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton9.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton9.selected = false;
            this.bunifuFlatButton9.Size = new System.Drawing.Size(116, 48);
            this.bunifuFlatButton9.TabIndex = 19;
            this.bunifuFlatButton9.Text = "           Escalofrios";
            this.bunifuFlatButton9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton9.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton9.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Apatia_Check
            // 
            this.Apatia_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Apatia_Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Apatia_Check.Checked = false;
            this.Apatia_Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Apatia_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Apatia_Check.ForeColor = System.Drawing.Color.White;
            this.Apatia_Check.Location = new System.Drawing.Point(341, 271);
            this.Apatia_Check.Name = "Apatia_Check";
            this.Apatia_Check.Size = new System.Drawing.Size(20, 20);
            this.Apatia_Check.TabIndex = 18;
            this.Apatia_Check.OnChange += new System.EventHandler(this.Apatia_Check_OnChange);
            // 
            // bunifuFlatButton8
            // 
            this.bunifuFlatButton8.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton8.BorderRadius = 0;
            this.bunifuFlatButton8.ButtonText = "                  Apatia";
            this.bunifuFlatButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton8.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton8.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton8.Iconimage = null;
            this.bunifuFlatButton8.Iconimage_right = null;
            this.bunifuFlatButton8.Iconimage_right_Selected = null;
            this.bunifuFlatButton8.Iconimage_Selected = null;
            this.bunifuFlatButton8.IconMarginLeft = 0;
            this.bunifuFlatButton8.IconMarginRight = 0;
            this.bunifuFlatButton8.IconRightVisible = true;
            this.bunifuFlatButton8.IconRightZoom = 0D;
            this.bunifuFlatButton8.IconVisible = true;
            this.bunifuFlatButton8.IconZoom = 90D;
            this.bunifuFlatButton8.IsTab = false;
            this.bunifuFlatButton8.Location = new System.Drawing.Point(341, 258);
            this.bunifuFlatButton8.Name = "bunifuFlatButton8";
            this.bunifuFlatButton8.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton8.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton8.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton8.selected = false;
            this.bunifuFlatButton8.Size = new System.Drawing.Size(116, 48);
            this.bunifuFlatButton8.TabIndex = 17;
            this.bunifuFlatButton8.Text = "                  Apatia";
            this.bunifuFlatButton8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton8.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton8.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Ictericea_Check
            // 
            this.Ictericea_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Ictericea_Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Ictericea_Check.Checked = false;
            this.Ictericea_Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Ictericea_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ictericea_Check.ForeColor = System.Drawing.Color.White;
            this.Ictericea_Check.Location = new System.Drawing.Point(106, 271);
            this.Ictericea_Check.Name = "Ictericea_Check";
            this.Ictericea_Check.Size = new System.Drawing.Size(20, 20);
            this.Ictericea_Check.TabIndex = 16;
            this.Ictericea_Check.OnChange += new System.EventHandler(this.Ictericea_Check_OnChange);
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "                  Ictericia";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(106, 258);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(116, 48);
            this.bunifuFlatButton3.TabIndex = 15;
            this.bunifuFlatButton3.Text = "                  Ictericia";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Cansancio_Check
            // 
            this.Cansancio_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Cansancio_Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Cansancio_Check.Checked = false;
            this.Cansancio_Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Cansancio_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cansancio_Check.ForeColor = System.Drawing.Color.White;
            this.Cansancio_Check.Location = new System.Drawing.Point(539, 124);
            this.Cansancio_Check.Name = "Cansancio_Check";
            this.Cansancio_Check.Size = new System.Drawing.Size(20, 20);
            this.Cansancio_Check.TabIndex = 14;
            this.Cansancio_Check.OnChange += new System.EventHandler(this.Cansancio_Check_OnChange);
            // 
            // bunifuFlatButton7
            // 
            this.bunifuFlatButton7.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton7.BorderRadius = 0;
            this.bunifuFlatButton7.ButtonText = "          Cansancio";
            this.bunifuFlatButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton7.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton7.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton7.Iconimage = null;
            this.bunifuFlatButton7.Iconimage_right = null;
            this.bunifuFlatButton7.Iconimage_right_Selected = null;
            this.bunifuFlatButton7.Iconimage_Selected = null;
            this.bunifuFlatButton7.IconMarginLeft = 0;
            this.bunifuFlatButton7.IconMarginRight = 0;
            this.bunifuFlatButton7.IconRightVisible = true;
            this.bunifuFlatButton7.IconRightZoom = 0D;
            this.bunifuFlatButton7.IconVisible = true;
            this.bunifuFlatButton7.IconZoom = 90D;
            this.bunifuFlatButton7.IsTab = false;
            this.bunifuFlatButton7.Location = new System.Drawing.Point(539, 111);
            this.bunifuFlatButton7.Name = "bunifuFlatButton7";
            this.bunifuFlatButton7.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton7.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton7.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton7.selected = false;
            this.bunifuFlatButton7.Size = new System.Drawing.Size(116, 48);
            this.bunifuFlatButton7.TabIndex = 13;
            this.bunifuFlatButton7.Text = "          Cansancio";
            this.bunifuFlatButton7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton7.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton7.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Nauseas_Check
            // 
            this.Nauseas_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Nauseas_Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Nauseas_Check.Checked = false;
            this.Nauseas_Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Nauseas_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Nauseas_Check.ForeColor = System.Drawing.Color.White;
            this.Nauseas_Check.Location = new System.Drawing.Point(539, 199);
            this.Nauseas_Check.Name = "Nauseas_Check";
            this.Nauseas_Check.Size = new System.Drawing.Size(20, 20);
            this.Nauseas_Check.TabIndex = 12;
            this.Nauseas_Check.OnChange += new System.EventHandler(this.Nauseas_Check_OnChange);
            // 
            // bunifuFlatButton6
            // 
            this.bunifuFlatButton6.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton6.BorderRadius = 0;
            this.bunifuFlatButton6.ButtonText = "             Náuseas";
            this.bunifuFlatButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton6.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton6.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton6.Iconimage = null;
            this.bunifuFlatButton6.Iconimage_right = null;
            this.bunifuFlatButton6.Iconimage_right_Selected = null;
            this.bunifuFlatButton6.Iconimage_Selected = null;
            this.bunifuFlatButton6.IconMarginLeft = 0;
            this.bunifuFlatButton6.IconMarginRight = 0;
            this.bunifuFlatButton6.IconRightVisible = true;
            this.bunifuFlatButton6.IconRightZoom = 0D;
            this.bunifuFlatButton6.IconVisible = true;
            this.bunifuFlatButton6.IconZoom = 90D;
            this.bunifuFlatButton6.IsTab = false;
            this.bunifuFlatButton6.Location = new System.Drawing.Point(539, 186);
            this.bunifuFlatButton6.Name = "bunifuFlatButton6";
            this.bunifuFlatButton6.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton6.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton6.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton6.selected = false;
            this.bunifuFlatButton6.Size = new System.Drawing.Size(116, 48);
            this.bunifuFlatButton6.TabIndex = 11;
            this.bunifuFlatButton6.Text = "             Náuseas";
            this.bunifuFlatButton6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton6.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton6.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Cabeza_Check
            // 
            this.Cabeza_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Cabeza_Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Cabeza_Check.Checked = false;
            this.Cabeza_Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Cabeza_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cabeza_Check.ForeColor = System.Drawing.Color.White;
            this.Cabeza_Check.Location = new System.Drawing.Point(341, 199);
            this.Cabeza_Check.Name = "Cabeza_Check";
            this.Cabeza_Check.Size = new System.Drawing.Size(20, 20);
            this.Cabeza_Check.TabIndex = 10;
            this.Cabeza_Check.OnChange += new System.EventHandler(this.Cabeza_Check_OnChange);
            // 
            // bunifuFlatButton5
            // 
            this.bunifuFlatButton5.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton5.BorderRadius = 0;
            this.bunifuFlatButton5.ButtonText = "        Dolor de Cabeza";
            this.bunifuFlatButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton5.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton5.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton5.Iconimage = null;
            this.bunifuFlatButton5.Iconimage_right = null;
            this.bunifuFlatButton5.Iconimage_right_Selected = null;
            this.bunifuFlatButton5.Iconimage_Selected = null;
            this.bunifuFlatButton5.IconMarginLeft = 0;
            this.bunifuFlatButton5.IconMarginRight = 0;
            this.bunifuFlatButton5.IconRightVisible = true;
            this.bunifuFlatButton5.IconRightZoom = 0D;
            this.bunifuFlatButton5.IconVisible = true;
            this.bunifuFlatButton5.IconZoom = 90D;
            this.bunifuFlatButton5.IsTab = false;
            this.bunifuFlatButton5.Location = new System.Drawing.Point(341, 186);
            this.bunifuFlatButton5.Name = "bunifuFlatButton5";
            this.bunifuFlatButton5.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton5.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton5.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton5.selected = false;
            this.bunifuFlatButton5.Size = new System.Drawing.Size(166, 48);
            this.bunifuFlatButton5.TabIndex = 9;
            this.bunifuFlatButton5.Text = "        Dolor de Cabeza";
            this.bunifuFlatButton5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton5.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton5.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton5.Click += new System.EventHandler(this.bunifuFlatButton5_Click);
            // 
            // Fiebre_Check
            // 
            this.Fiebre_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Fiebre_Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Fiebre_Check.Checked = false;
            this.Fiebre_Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Fiebre_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fiebre_Check.ForeColor = System.Drawing.Color.White;
            this.Fiebre_Check.Location = new System.Drawing.Point(106, 199);
            this.Fiebre_Check.Name = "Fiebre_Check";
            this.Fiebre_Check.Size = new System.Drawing.Size(20, 20);
            this.Fiebre_Check.TabIndex = 8;
            this.Fiebre_Check.OnChange += new System.EventHandler(this.Fiebre_Check_OnChange);
            // 
            // bunifuFlatButton4
            // 
            this.bunifuFlatButton4.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton4.BorderRadius = 0;
            this.bunifuFlatButton4.ButtonText = "                  Fiebre";
            this.bunifuFlatButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton4.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton4.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton4.Iconimage = null;
            this.bunifuFlatButton4.Iconimage_right = null;
            this.bunifuFlatButton4.Iconimage_right_Selected = null;
            this.bunifuFlatButton4.Iconimage_Selected = null;
            this.bunifuFlatButton4.IconMarginLeft = 0;
            this.bunifuFlatButton4.IconMarginRight = 0;
            this.bunifuFlatButton4.IconRightVisible = true;
            this.bunifuFlatButton4.IconRightZoom = 0D;
            this.bunifuFlatButton4.IconVisible = true;
            this.bunifuFlatButton4.IconZoom = 90D;
            this.bunifuFlatButton4.IsTab = false;
            this.bunifuFlatButton4.Location = new System.Drawing.Point(106, 186);
            this.bunifuFlatButton4.Name = "bunifuFlatButton4";
            this.bunifuFlatButton4.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton4.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton4.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton4.selected = false;
            this.bunifuFlatButton4.Size = new System.Drawing.Size(116, 48);
            this.bunifuFlatButton4.TabIndex = 7;
            this.bunifuFlatButton4.Text = "                  Fiebre";
            this.bunifuFlatButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton4.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton4.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Diarrea_Check
            // 
            this.Diarrea_Check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Diarrea_Check.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.Diarrea_Check.Checked = false;
            this.Diarrea_Check.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.Diarrea_Check.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Diarrea_Check.ForeColor = System.Drawing.Color.White;
            this.Diarrea_Check.Location = new System.Drawing.Point(106, 124);
            this.Diarrea_Check.Name = "Diarrea_Check";
            this.Diarrea_Check.Size = new System.Drawing.Size(20, 20);
            this.Diarrea_Check.TabIndex = 2;
            this.Diarrea_Check.OnChange += new System.EventHandler(this.Diarrea_Check_OnChange);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "                  Diarrea";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(106, 111);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(35)))), ((int)(((byte)(42)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(116, 48);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = "                  Diarrea";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(51)))), ((int)(((byte)(62)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Seleccione sus sintomas";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(227, 17);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(280, 56);
            this.bunifuThinButton21.TabIndex = 0;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // enfermedades
            // 
            this.enfermedades.Text = "Resultados";
            this.enfermedades.Width = 84;
            // 
            // Medicamentos
            // 
            this.Medicamentos.Text = "Medicamentos";
            this.Medicamentos.Width = 89;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCheckbox Diarrea_Check;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuCheckbox Tos_Check;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton10;
        private Bunifu.Framework.UI.BunifuCheckbox Escalofrios_Check;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton9;
        private Bunifu.Framework.UI.BunifuCheckbox Apatia_Check;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton8;
        private Bunifu.Framework.UI.BunifuCheckbox Ictericea_Check;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuCheckbox Cansancio_Check;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton7;
        private Bunifu.Framework.UI.BunifuCheckbox Nauseas_Check;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton6;
        private Bunifu.Framework.UI.BunifuCheckbox Cabeza_Check;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton5;
        private Bunifu.Framework.UI.BunifuCheckbox Fiebre_Check;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton4;
        private Bunifu.Framework.UI.BunifuCheckbox Secrecion_Check;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuCheckbox Jaqueca_Check;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton11;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton12;
        private System.Windows.Forms.Label Resultados;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader enfermedades;
        private System.Windows.Forms.ColumnHeader Medicamentos;
    }
}

