namespace WFA_Reto_Lenguaje_Candidatos
{
    partial class Perfiles
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
            this.Btt_Senior = new System.Windows.Forms.Button();
            this.Btt_Director = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btt_Junior = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btt_Senior
            // 
            this.Btt_Senior.Location = new System.Drawing.Point(35, 63);
            this.Btt_Senior.Margin = new System.Windows.Forms.Padding(4);
            this.Btt_Senior.Name = "Btt_Senior";
            this.Btt_Senior.Size = new System.Drawing.Size(100, 30);
            this.Btt_Senior.TabIndex = 0;
            this.Btt_Senior.Text = "Senior";
            this.Btt_Senior.UseVisualStyleBackColor = true;
            this.Btt_Senior.Click += new System.EventHandler(this.Btt_Senior_Click);
            // 
            // Btt_Director
            // 
            this.Btt_Director.Location = new System.Drawing.Point(190, 63);
            this.Btt_Director.Margin = new System.Windows.Forms.Padding(4);
            this.Btt_Director.Name = "Btt_Director";
            this.Btt_Director.Size = new System.Drawing.Size(164, 30);
            this.Btt_Director.TabIndex = 1;
            this.Btt_Director.Text = "Director de proyectos";
            this.Btt_Director.UseVisualStyleBackColor = true;
            this.Btt_Director.Click += new System.EventHandler(this.Btt_Director_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escoja uno de los perfiles para ingresar ";
            // 
            // Btt_Junior
            // 
            this.Btt_Junior.Location = new System.Drawing.Point(402, 63);
            this.Btt_Junior.Name = "Btt_Junior";
            this.Btt_Junior.Size = new System.Drawing.Size(100, 29);
            this.Btt_Junior.TabIndex = 4;
            this.Btt_Junior.Text = "Junior";
            this.Btt_Junior.UseVisualStyleBackColor = true;
            this.Btt_Junior.Click += new System.EventHandler(this.Btt_Junior_Click);
            // 
            // Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 124);
            this.Controls.Add(this.Btt_Junior);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btt_Director);
            this.Controls.Add(this.Btt_Senior);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Perfiles";
            this.ShowIcon = false;
            this.Text = "Perfiles de candidatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btt_Senior;
        private System.Windows.Forms.Button Btt_Director;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btt_Junior;
    }
}