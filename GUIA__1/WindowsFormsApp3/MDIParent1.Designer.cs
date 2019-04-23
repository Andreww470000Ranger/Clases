namespace WindowsFormsApp3
{
    partial class MDIParent1
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
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verEjerciciosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ejercicio5ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEjerciciosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(722, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verEjerciciosToolStripMenuItem
            // 
            this.verEjerciciosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejercicio1ToolStripMenuItem,
            this.ejercicio2ToolStripMenuItem,
            this.ejercicio3ToolStripMenuItem,
            this.ejercicio4ToolStripMenuItem,
            this.ejercicio5ToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.verEjerciciosToolStripMenuItem.Name = "verEjerciciosToolStripMenuItem";
            this.verEjerciciosToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.verEjerciciosToolStripMenuItem.Text = "Ver Ejercicios";
            // 
            // ejercicio1ToolStripMenuItem
            // 
            this.ejercicio1ToolStripMenuItem.Name = "ejercicio1ToolStripMenuItem";
            this.ejercicio1ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio1ToolStripMenuItem.Text = "Ejercicio 1";
            this.ejercicio1ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio1ToolStripMenuItem_Click);
            // 
            // ejercicio2ToolStripMenuItem
            // 
            this.ejercicio2ToolStripMenuItem.Name = "ejercicio2ToolStripMenuItem";
            this.ejercicio2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio2ToolStripMenuItem.Text = "Ejercicio 2";
            this.ejercicio2ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio2ToolStripMenuItem_Click);
            // 
            // ejercicio3ToolStripMenuItem
            // 
            this.ejercicio3ToolStripMenuItem.Name = "ejercicio3ToolStripMenuItem";
            this.ejercicio3ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio3ToolStripMenuItem.Text = "Ejercicio 3";
            this.ejercicio3ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio3ToolStripMenuItem_Click);
            // 
            // ejercicio4ToolStripMenuItem
            // 
            this.ejercicio4ToolStripMenuItem.Name = "ejercicio4ToolStripMenuItem";
            this.ejercicio4ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio4ToolStripMenuItem.Text = "Ejercicio 4";
            this.ejercicio4ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio4ToolStripMenuItem_Click);
            // 
            // ejercicio5ToolStripMenuItem
            // 
            this.ejercicio5ToolStripMenuItem.Name = "ejercicio5ToolStripMenuItem";
            this.ejercicio5ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ejercicio5ToolStripMenuItem.Text = "Ejercicio 5";
            this.ejercicio5ToolStripMenuItem.Click += new System.EventHandler(this.ejercicio5ToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 477);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "MDIParent1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MDIParent1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verEjerciciosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ejercicio5ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}



