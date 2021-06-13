
namespace WinFormsApp1
{
    partial class Kreiraj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numKocki = new System.Windows.Forms.NumericUpDown();
            this.numMini = new System.Windows.Forms.NumericUpDown();
            this.btnSocujav = new System.Windows.Forms.Button();
            this.errorProviderMini = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numKocki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMini)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Создадете свој критериум";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Внесете број на полиња\r\nво една редица / колона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(20, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Внесете број на мини";
            // 
            // numKocki
            // 
            this.numKocki.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numKocki.Location = new System.Drawing.Point(261, 130);
            this.numKocki.Maximum = new decimal(new int[] {
            22,
            0,
            0,
            0});
            this.numKocki.Minimum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numKocki.Name = "numKocki";
            this.numKocki.Size = new System.Drawing.Size(46, 26);
            this.numKocki.TabIndex = 3;
            this.numKocki.Value = new decimal(new int[] {
            9,
            0,
            0,
            0});
            // 
            // numMini
            // 
            this.numMini.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numMini.Location = new System.Drawing.Point(261, 198);
            this.numMini.Maximum = new decimal(new int[] {
            121,
            0,
            0,
            0});
            this.numMini.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMini.Name = "numMini";
            this.numMini.Size = new System.Drawing.Size(46, 26);
            this.numMini.TabIndex = 4;
            this.numMini.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numMini.Validating += new System.ComponentModel.CancelEventHandler(this.numMini_Validating);
            // 
            // btnSocujav
            // 
            this.btnSocujav.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSocujav.Location = new System.Drawing.Point(100, 260);
            this.btnSocujav.Name = "btnSocujav";
            this.btnSocujav.Size = new System.Drawing.Size(150, 50);
            this.btnSocujav.TabIndex = 5;
            this.btnSocujav.Text = "Сочувај";
            this.btnSocujav.UseVisualStyleBackColor = true;
            this.btnSocujav.Click += new System.EventHandler(this.btnSocujav_Click);
            // 
            // errorProviderMini
            // 
            this.errorProviderMini.ContainerControl = this;
            // 
            // Kreiraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 331);
            this.Controls.Add(this.btnSocujav);
            this.Controls.Add(this.numMini);
            this.Controls.Add(this.numKocki);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 370);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 370);
            this.Name = "Kreiraj";
            this.Text = "Minesweeper";
            ((System.ComponentModel.ISupportInitialize)(this.numKocki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numKocki;
        private System.Windows.Forms.NumericUpDown numMini;
        private System.Windows.Forms.Button btnSocujav;
        private System.Windows.Forms.ErrorProvider errorProviderMini;
    }
}