
namespace GeneratorPostaciWh2
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
            comboRasa = new ComboBox();
            comboProfesja = new ComboBox();
            txtImie = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonWybierzPlik = new Button();
            textBox2 = new TextBox();
            buttonGeneruj = new Button();
            SuspendLayout();
            // 
            // comboRasa
            // 
            comboRasa.FormattingEnabled = true;
            comboRasa.Location = new Point(12, 97);
            comboRasa.Name = "comboRasa";
            comboRasa.Size = new Size(242, 40);
            comboRasa.TabIndex = 0;
            comboRasa.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboProfesja
            // 
            comboProfesja.FormattingEnabled = true;
            comboProfesja.Location = new Point(12, 185);
            comboProfesja.Name = "comboProfesja";
            comboProfesja.Size = new Size(242, 40);
            comboProfesja.TabIndex = 1;
            comboProfesja.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // txtImie
            // 
            txtImie.Location = new Point(12, 22);
            txtImie.Name = "txtImie";
            txtImie.Size = new Size(242, 39);
            txtImie.TabIndex = 2;
            txtImie.TextChanged += txtImie_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 25);
            label1.Name = "label1";
            label1.Size = new Size(142, 32);
            label1.TabIndex = 3;
            label1.Text = "Imię postaci";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 105);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 4;
            label2.Text = "Wybierz rasę";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(292, 188);
            label3.Name = "label3";
            label3.Size = new Size(193, 32);
            label3.TabIndex = 5;
            label3.Text = "Wybierz profesje";
            // 
            // buttonWybierzPlik
            // 
            buttonWybierzPlik.Location = new Point(12, 283);
            buttonWybierzPlik.Name = "buttonWybierzPlik";
            buttonWybierzPlik.Size = new Size(205, 46);
            buttonWybierzPlik.TabIndex = 6;
            buttonWybierzPlik.Text = "Wybierz ścieżke zapisu";
            buttonWybierzPlik.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(214, 287);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(796, 39);
            textBox2.TabIndex = 7;
            // 
            // buttonGeneruj
            // 
            buttonGeneruj.Location = new Point(28, 391);
            buttonGeneruj.Name = "buttonGeneruj";
            buttonGeneruj.Size = new Size(189, 96);
            buttonGeneruj.TabIndex = 8;
            buttonGeneruj.Text = "Generuj postać";
            buttonGeneruj.UseVisualStyleBackColor = true;
            buttonGeneruj.Click += buttonGeneruj_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1022, 667);
            Controls.Add(buttonGeneruj);
            Controls.Add(textBox2);
            Controls.Add(buttonWybierzPlik);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtImie);
            Controls.Add(comboProfesja);
            Controls.Add(comboRasa);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        

        #endregion

        private ComboBox comboRasa;
        private ComboBox comboProfesja;
        private TextBox txtImie;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonWybierzPlik;
        private TextBox textBox2;
        private Button buttonGeneruj;
    }
}
