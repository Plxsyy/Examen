namespace Examen
{
    partial class FormIngreso
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxEdad = new System.Windows.Forms.MaskedTextBox();
            this.radioButtonSoltero = new System.Windows.Forms.RadioButton();
            this.radioButtonCasado = new System.Windows.Forms.RadioButton();
            this.checkBoxHTML = new System.Windows.Forms.CheckBox();
            this.checkBoxCSS = new System.Windows.Forms.CheckBox();
            this.checkBoxC = new System.Windows.Forms.CheckBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonVerLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad Empleado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado Civil";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Habilidades";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(199, 80);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 22);
            this.textBoxNombre.TabIndex = 5;
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Items.AddRange(new object[] {
            "FrontEnd",
            "BackEnd"});
            this.comboBoxDepartamento.Location = new System.Drawing.Point(199, 121);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(121, 24);
            this.comboBoxDepartamento.TabIndex = 10;
            // 
            // maskedTextBoxEdad
            // 
            this.maskedTextBoxEdad.Location = new System.Drawing.Point(199, 177);
            this.maskedTextBoxEdad.Mask = "000";
            this.maskedTextBoxEdad.Name = "maskedTextBoxEdad";
            this.maskedTextBoxEdad.Size = new System.Drawing.Size(31, 22);
            this.maskedTextBoxEdad.TabIndex = 11;
            // 
            // radioButtonSoltero
            // 
            this.radioButtonSoltero.AutoSize = true;
            this.radioButtonSoltero.Location = new System.Drawing.Point(199, 240);
            this.radioButtonSoltero.Name = "radioButtonSoltero";
            this.radioButtonSoltero.Size = new System.Drawing.Size(71, 20);
            this.radioButtonSoltero.TabIndex = 12;
            this.radioButtonSoltero.TabStop = true;
            this.radioButtonSoltero.Text = "Soltero";
            this.radioButtonSoltero.UseVisualStyleBackColor = true;
            // 
            // radioButtonCasado
            // 
            this.radioButtonCasado.AutoSize = true;
            this.radioButtonCasado.Location = new System.Drawing.Point(309, 240);
            this.radioButtonCasado.Name = "radioButtonCasado";
            this.radioButtonCasado.Size = new System.Drawing.Size(76, 20);
            this.radioButtonCasado.TabIndex = 13;
            this.radioButtonCasado.TabStop = true;
            this.radioButtonCasado.Text = "Casado";
            this.radioButtonCasado.UseVisualStyleBackColor = true;
            // 
            // checkBoxHTML
            // 
            this.checkBoxHTML.AutoSize = true;
            this.checkBoxHTML.Location = new System.Drawing.Point(199, 291);
            this.checkBoxHTML.Name = "checkBoxHTML";
            this.checkBoxHTML.Size = new System.Drawing.Size(66, 20);
            this.checkBoxHTML.TabIndex = 14;
            this.checkBoxHTML.Text = "HTML";
            this.checkBoxHTML.UseVisualStyleBackColor = true;
            // 
            // checkBoxCSS
            // 
            this.checkBoxCSS.AutoSize = true;
            this.checkBoxCSS.Location = new System.Drawing.Point(309, 291);
            this.checkBoxCSS.Name = "checkBoxCSS";
            this.checkBoxCSS.Size = new System.Drawing.Size(56, 20);
            this.checkBoxCSS.TabIndex = 15;
            this.checkBoxCSS.Text = "CSS";
            this.checkBoxCSS.UseVisualStyleBackColor = true;
            // 
            // checkBoxC
            // 
            this.checkBoxC.AutoSize = true;
            this.checkBoxC.Location = new System.Drawing.Point(411, 291);
            this.checkBoxC.Name = "checkBoxC";
            this.checkBoxC.Size = new System.Drawing.Size(45, 20);
            this.checkBoxC.TabIndex = 16;
            this.checkBoxC.Text = "C#";
            this.checkBoxC.UseVisualStyleBackColor = true;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(290, 359);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 31);
            this.buttonAgregar.TabIndex = 17;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonVerLista
            // 
            this.buttonVerLista.Location = new System.Drawing.Point(465, 359);
            this.buttonVerLista.Name = "buttonVerLista";
            this.buttonVerLista.Size = new System.Drawing.Size(107, 43);
            this.buttonVerLista.TabIndex = 18;
            this.buttonVerLista.Text = "Ver Lista Empleados";
            this.buttonVerLista.UseVisualStyleBackColor = true;
            this.buttonVerLista.Click += new System.EventHandler(this.buttonVerLista_Click_1);
            // 
            // FormIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonVerLista);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.checkBoxC);
            this.Controls.Add(this.checkBoxCSS);
            this.Controls.Add(this.checkBoxHTML);
            this.Controls.Add(this.radioButtonCasado);
            this.Controls.Add(this.radioButtonSoltero);
            this.Controls.Add(this.maskedTextBoxEdad);
            this.Controls.Add(this.comboBoxDepartamento);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormIngreso";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxDepartamento;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxEdad;
        private System.Windows.Forms.RadioButton radioButtonSoltero;
        private System.Windows.Forms.RadioButton radioButtonCasado;
        private System.Windows.Forms.CheckBox checkBoxHTML;
        private System.Windows.Forms.CheckBox checkBoxCSS;
        private System.Windows.Forms.CheckBox checkBoxC;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonVerLista;
    }
}

