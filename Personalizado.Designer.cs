namespace ClinicaMedica
{
    partial class Personalizado
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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            checkedListBox1 = new CheckedListBox();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textBox3 = new TextBox();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Blue;
            button1.Location = new Point(579, 420);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Guardar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Location = new Point(264, 420);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 1;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 280);
            label1.Name = "label1";
            label1.Size = new Size(162, 25);
            label1.TabIndex = 4;
            label1.Text = "Ubicacion de Hotel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 166);
            label2.Name = "label2";
            label2.Size = new Size(114, 25);
            label2.TabIndex = 6;
            label2.Text = "Habitaciones";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.Teal;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hotel Santiago", "Hotel Esperanza", "Hotel Libertad" });
            comboBox1.Location = new Point(52, 320);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(258, 33);
            comboBox1.TabIndex = 7;
            // 
            // checkedListBox1
            // 
            checkedListBox1.BackColor = Color.Teal;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Habitacion Sencilla", "Habitacion Doble", "Habitacion Cuadruple" });
            checkedListBox1.Location = new Point(444, 203);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(222, 88);
            checkedListBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 35);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 10;
            label3.Text = "Nombre";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Teal;
            textBox1.Location = new Point(49, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(261, 31);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Teal;
            textBox2.Location = new Point(444, 75);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(279, 31);
            textBox2.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(444, 35);
            label4.Name = "label4";
            label4.Size = new Size(66, 25);
            label4.TabIndex = 13;
            label4.Text = "Correo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 150);
            label5.Name = "label5";
            label5.Size = new Size(79, 25);
            label5.TabIndex = 14;
            label5.Text = "Telefono";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Teal;
            textBox3.Location = new Point(52, 190);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(258, 31);
            textBox3.TabIndex = 15;
            // 
            // button3
            // 
            button3.Location = new Point(425, 420);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 16;
            button3.Text = "Editar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Personalizado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(783, 487);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(checkedListBox1);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            ForeColor = SystemColors.ControlText;
            Name = "Personalizado";
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private CheckedListBox checkedListBox1;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Label label5;
        private TextBox textBox3;
        private Button button3;
    }
}