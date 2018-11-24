namespace Generaciones
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.txtGeneracion = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarnodo = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnAgregarRaiz = new System.Windows.Forms.Button();
            this.txtRaiz = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(665, 409);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // txtGeneracion
            // 
            this.txtGeneracion.Location = new System.Drawing.Point(749, 5);
            this.txtGeneracion.Name = "txtGeneracion";
            this.txtGeneracion.Size = new System.Drawing.Size(33, 20);
            this.txtGeneracion.TabIndex = 1;
            this.txtGeneracion.Text = "1";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(789, 3);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(91, 23);
            this.btnGenerar.TabIndex = 2;
            this.btnGenerar.Text = "Generar Arbol";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(805, 32);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Generar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(749, 34);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(50, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Generaciones:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(667, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Total de Asc:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(765, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(671, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Padre:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(671, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Raiz:";
            // 
            // btnAgregarnodo
            // 
            this.btnAgregarnodo.Location = new System.Drawing.Point(793, 212);
            this.btnAgregarnodo.Name = "btnAgregarnodo";
            this.btnAgregarnodo.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarnodo.TabIndex = 11;
            this.btnAgregarnodo.Text = "Agregar Hijo";
            this.btnAgregarnodo.UseVisualStyleBackColor = true;
            this.btnAgregarnodo.Click += new System.EventHandler(this.btnAgregarnodo_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(708, 214);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 10;
            // 
            // btnAgregarRaiz
            // 
            this.btnAgregarRaiz.Location = new System.Drawing.Point(793, 145);
            this.btnAgregarRaiz.Name = "btnAgregarRaiz";
            this.btnAgregarRaiz.Size = new System.Drawing.Size(91, 23);
            this.btnAgregarRaiz.TabIndex = 9;
            this.btnAgregarRaiz.Text = "Agregar";
            this.btnAgregarRaiz.UseVisualStyleBackColor = true;
            this.btnAgregarRaiz.Click += new System.EventHandler(this.btnAgregarRaiz_Click);
            // 
            // txtRaiz
            // 
            this.txtRaiz.Location = new System.Drawing.Point(708, 147);
            this.txtRaiz.Name = "txtRaiz";
            this.txtRaiz.Size = new System.Drawing.Size(78, 20);
            this.txtRaiz.TabIndex = 8;
            this.txtRaiz.Text = "1";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(708, 182);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(671, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Hijo:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(684, 283);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Expand";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(684, 312);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Colapse";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(674, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total De Nodos:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(793, 241);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAgregarnodo);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAgregarRaiz);
            this.Controls.Add(this.txtRaiz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtGeneracion);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TextBox txtGeneracion;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarnodo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnAgregarRaiz;
        private System.Windows.Forms.TextBox txtRaiz;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEliminar;
    }
}

