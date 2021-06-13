
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPocetnicki = new System.Windows.Forms.Button();
            this.btnSreden = new System.Windows.Forms.Button();
            this.btnProfesionalen = new System.Windows.Forms.Button();
            this.btnKreiraj = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuProzorec = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPocetno = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKreiraj = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIzlez = new System.Windows.Forms.ToolStripMenuItem();
            this.menuIgra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovaIgra = new System.Windows.Forms.ToolStripMenuItem();
            this.menuKraj = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOdnovo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPocetnicki
            // 
            this.btnPocetnicki.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPocetnicki.Location = new System.Drawing.Point(90, 95);
            this.btnPocetnicki.Name = "btnPocetnicki";
            this.btnPocetnicki.Size = new System.Drawing.Size(250, 70);
            this.btnPocetnicki.TabIndex = 0;
            this.btnPocetnicki.Text = "Почетнички";
            this.btnPocetnicki.UseVisualStyleBackColor = true;
            this.btnPocetnicki.Click += new System.EventHandler(this.btnPocetnicki_Click);
            // 
            // btnSreden
            // 
            this.btnSreden.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSreden.Location = new System.Drawing.Point(90, 195);
            this.btnSreden.Name = "btnSreden";
            this.btnSreden.Size = new System.Drawing.Size(250, 70);
            this.btnSreden.TabIndex = 1;
            this.btnSreden.Text = "Среден";
            this.btnSreden.UseVisualStyleBackColor = true;
            this.btnSreden.Click += new System.EventHandler(this.btnSreden_Click);
            // 
            // btnProfesionalen
            // 
            this.btnProfesionalen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfesionalen.Location = new System.Drawing.Point(90, 295);
            this.btnProfesionalen.Name = "btnProfesionalen";
            this.btnProfesionalen.Size = new System.Drawing.Size(250, 70);
            this.btnProfesionalen.TabIndex = 2;
            this.btnProfesionalen.Text = "Професионален";
            this.btnProfesionalen.UseVisualStyleBackColor = true;
            this.btnProfesionalen.Click += new System.EventHandler(this.btnProfesionalen_Click);
            // 
            // btnKreiraj
            // 
            this.btnKreiraj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnKreiraj.Location = new System.Drawing.Point(90, 395);
            this.btnKreiraj.Name = "btnKreiraj";
            this.btnKreiraj.Size = new System.Drawing.Size(250, 70);
            this.btnKreiraj.TabIndex = 3;
            this.btnKreiraj.Text = "Креирај";
            this.btnKreiraj.UseVisualStyleBackColor = true;
            this.btnKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // panel
            // 
            this.panel.Location = new System.Drawing.Point(40, 40);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(40, 40);
            this.panel.TabIndex = 4;
            this.panel.Visible = false;
            this.panel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Paint);
            this.panel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel_MouseClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProzorec,
            this.menuIgra});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(434, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuProzorec
            // 
            this.menuProzorec.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuPocetno,
            this.menuKreiraj,
            this.menuIzlez});
            this.menuProzorec.Name = "menuProzorec";
            this.menuProzorec.Size = new System.Drawing.Size(74, 20);
            this.menuProzorec.Text = "Прозорец";
            // 
            // menuPocetno
            // 
            this.menuPocetno.Name = "menuPocetno";
            this.menuPocetno.Size = new System.Drawing.Size(154, 22);
            this.menuPocetno.Text = "Почетно мени";
            this.menuPocetno.Click += new System.EventHandler(this.menuPocetno_Click);
            // 
            // menuKreiraj
            // 
            this.menuKreiraj.Name = "menuKreiraj";
            this.menuKreiraj.Size = new System.Drawing.Size(154, 22);
            this.menuKreiraj.Text = "Креирај игра";
            this.menuKreiraj.Click += new System.EventHandler(this.btnKreiraj_Click);
            // 
            // menuIzlez
            // 
            this.menuIzlez.Name = "menuIzlez";
            this.menuIzlez.Size = new System.Drawing.Size(154, 22);
            this.menuIzlez.Text = "Излез";
            this.menuIzlez.Click += new System.EventHandler(this.menuIzlez_Click);
            // 
            // menuIgra
            // 
            this.menuIgra.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaIgra,
            this.menuKraj,
            this.menuOdnovo});
            this.menuIgra.Name = "menuIgra";
            this.menuIgra.Size = new System.Drawing.Size(46, 20);
            this.menuIgra.Text = "Игра";
            // 
            // menuNovaIgra
            // 
            this.menuNovaIgra.Name = "menuNovaIgra";
            this.menuNovaIgra.Size = new System.Drawing.Size(184, 22);
            this.menuNovaIgra.Text = "Нова игра";
            this.menuNovaIgra.Click += new System.EventHandler(this.menuNovaIgra_Click);
            // 
            // menuKraj
            // 
            this.menuKraj.Name = "menuKraj";
            this.menuKraj.Size = new System.Drawing.Size(184, 22);
            this.menuKraj.Text = "Покажи ги бомбите";
            this.menuKraj.Click += new System.EventHandler(this.menuKraj_Click);
            // 
            // menuOdnovo
            // 
            this.menuOdnovo.Name = "menuOdnovo";
            this.menuOdnovo.Size = new System.Drawing.Size(184, 22);
            this.menuOdnovo.Text = "Играј одново";
            this.menuOdnovo.Click += new System.EventHandler(this.menuOdnovo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(434, 561);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.btnKreiraj);
            this.Controls.Add(this.btnProfesionalen);
            this.Controls.Add(this.btnSreden);
            this.Controls.Add(this.btnPocetnicki);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPocetnicki;
        private System.Windows.Forms.Button btnSreden;
        private System.Windows.Forms.Button btnProfesionalen;
        private System.Windows.Forms.Button btnKreiraj;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuProzorec;
        private System.Windows.Forms.ToolStripMenuItem menuPocetno;
        private System.Windows.Forms.ToolStripMenuItem menuKreiraj;
        private System.Windows.Forms.ToolStripMenuItem menuIzlez;
        private System.Windows.Forms.ToolStripMenuItem menuIgra;
        private System.Windows.Forms.ToolStripMenuItem menuNovaIgra;
        private System.Windows.Forms.ToolStripMenuItem menuKraj;
        private System.Windows.Forms.ToolStripMenuItem menuOdnovo;
    }
}

