namespace TareaProgramacionII
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_mostranombre = new System.Windows.Forms.Label();
            this.btn_saludar = new System.Windows.Forms.Button();
            this.txt_palabras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.lst_palabrascontenido = new System.Windows.Forms.ListBox();
            this.lbl_cambios = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_palabravalidar = new System.Windows.Forms.TextBox();
            this.btn_ocultarlabel = new System.Windows.Forms.Button();
            this.lbl_ocultarse = new System.Windows.Forms.Label();
            this.btn_validar = new System.Windows.Forms.Button();
            this.lbl_cambiarporcodigo = new System.Windows.Forms.Label();
            this.btn_borrarcontenido = new System.Windows.Forms.Button();
            this.btn_mostraritemseleccionado = new System.Windows.Forms.Button();
            this.btn_azul = new System.Windows.Forms.Button();
            this.btn_amarillo = new System.Windows.Forms.Button();
            this.btn_verde = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_elementosagregados = new System.Windows.Forms.TextBox();
            this.btn_agregarElementos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. Hola Visual Studio";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(202, 68);
            this.txt_nombre.Multiline = true;
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 1;
            this.txt_nombre.TextChanged += new System.EventHandler(this.txt_nombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Ingrese su nombre:";
            // 
            // lbl_mostranombre
            // 
            this.lbl_mostranombre.AutoSize = true;
            this.lbl_mostranombre.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mostranombre.Location = new System.Drawing.Point(308, 69);
            this.lbl_mostranombre.Name = "lbl_mostranombre";
            this.lbl_mostranombre.Size = new System.Drawing.Size(14, 19);
            this.lbl_mostranombre.TabIndex = 4;
            this.lbl_mostranombre.Text = " ";
            // 
            // btn_saludar
            // 
            this.btn_saludar.Location = new System.Drawing.Point(213, 94);
            this.btn_saludar.Name = "btn_saludar";
            this.btn_saludar.Size = new System.Drawing.Size(75, 23);
            this.btn_saludar.TabIndex = 5;
            this.btn_saludar.Text = "¡Saludar!";
            this.btn_saludar.UseVisualStyleBackColor = true;
            this.btn_saludar.Click += new System.EventHandler(this.btn_saludar_Click);
            // 
            // txt_palabras
            // 
            this.txt_palabras.Location = new System.Drawing.Point(182, 162);
            this.txt_palabras.Multiline = true;
            this.txt_palabras.Name = "txt_palabras";
            this.txt_palabras.Size = new System.Drawing.Size(100, 20);
            this.txt_palabras.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "3.Ingrese palabras:";
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(290, 160);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 8;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // lst_palabrascontenido
            // 
            this.lst_palabrascontenido.FormattingEnabled = true;
            this.lst_palabrascontenido.Location = new System.Drawing.Point(49, 197);
            this.lst_palabrascontenido.Name = "lst_palabrascontenido";
            this.lst_palabrascontenido.Size = new System.Drawing.Size(120, 95);
            this.lst_palabrascontenido.TabIndex = 9;
            // 
            // lbl_cambios
            // 
            this.lbl_cambios.AutoSize = true;
            this.lbl_cambios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambios.Location = new System.Drawing.Point(424, 9);
            this.lbl_cambios.Name = "lbl_cambios";
            this.lbl_cambios.Size = new System.Drawing.Size(514, 20);
            this.lbl_cambios.TabIndex = 10;
            this.lbl_cambios.Text = "4. Este label y texto se cambiara de color al iniciar el FormLoad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 51);
            this.button1.TabIndex = 11;
            this.button1.Text = "5. Presione para mostrar un mensaje en una ventana";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(424, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "6. Ingrese una palabra al textbox:";
            // 
            // txt_palabravalidar
            // 
            this.txt_palabravalidar.Location = new System.Drawing.Point(704, 165);
            this.txt_palabravalidar.Multiline = true;
            this.txt_palabravalidar.Name = "txt_palabravalidar";
            this.txt_palabravalidar.Size = new System.Drawing.Size(100, 20);
            this.txt_palabravalidar.TabIndex = 13;
            // 
            // btn_ocultarlabel
            // 
            this.btn_ocultarlabel.Location = new System.Drawing.Point(604, 250);
            this.btn_ocultarlabel.Name = "btn_ocultarlabel";
            this.btn_ocultarlabel.Size = new System.Drawing.Size(126, 31);
            this.btn_ocultarlabel.TabIndex = 14;
            this.btn_ocultarlabel.Text = "Ocultar Label";
            this.btn_ocultarlabel.UseVisualStyleBackColor = true;
            this.btn_ocultarlabel.Click += new System.EventHandler(this.btn_ocultarlabel_Click);
            // 
            // lbl_ocultarse
            // 
            this.lbl_ocultarse.AutoSize = true;
            this.lbl_ocultarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ocultarse.Location = new System.Drawing.Point(458, 218);
            this.lbl_ocultarse.Name = "lbl_ocultarse";
            this.lbl_ocultarse.Size = new System.Drawing.Size(387, 20);
            this.lbl_ocultarse.TabIndex = 15;
            this.lbl_ocultarse.Text = "7. Si presiona este botón se ocultara este label";
            // 
            // btn_validar
            // 
            this.btn_validar.Location = new System.Drawing.Point(810, 159);
            this.btn_validar.Name = "btn_validar";
            this.btn_validar.Size = new System.Drawing.Size(80, 31);
            this.btn_validar.TabIndex = 16;
            this.btn_validar.Text = "Validar";
            this.btn_validar.UseVisualStyleBackColor = true;
            this.btn_validar.Click += new System.EventHandler(this.btn_validar_Click);
            // 
            // lbl_cambiarporcodigo
            // 
            this.lbl_cambiarporcodigo.AutoSize = true;
            this.lbl_cambiarporcodigo.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cambiarporcodigo.Location = new System.Drawing.Point(324, 328);
            this.lbl_cambiarporcodigo.Name = "lbl_cambiarporcodigo";
            this.lbl_cambiarporcodigo.Size = new System.Drawing.Size(266, 23);
            this.lbl_cambiarporcodigo.TabIndex = 18;
            this.lbl_cambiarporcodigo.Text = "8. A este label se le cambiara las propiedades por código.";
            this.lbl_cambiarporcodigo.Click += new System.EventHandler(this.lbl_cambiarporcodigo_Click);
            // 
            // btn_borrarcontenido
            // 
            this.btn_borrarcontenido.Location = new System.Drawing.Point(182, 197);
            this.btn_borrarcontenido.Name = "btn_borrarcontenido";
            this.btn_borrarcontenido.Size = new System.Drawing.Size(183, 41);
            this.btn_borrarcontenido.TabIndex = 19;
            this.btn_borrarcontenido.Text = "9. Este botón borrará el contenido del textbox y de listbox";
            this.btn_borrarcontenido.UseVisualStyleBackColor = true;
            this.btn_borrarcontenido.Click += new System.EventHandler(this.btn_borrarcontenido_Click);
            // 
            // btn_mostraritemseleccionado
            // 
            this.btn_mostraritemseleccionado.Location = new System.Drawing.Point(182, 250);
            this.btn_mostraritemseleccionado.Name = "btn_mostraritemseleccionado";
            this.btn_mostraritemseleccionado.Size = new System.Drawing.Size(183, 41);
            this.btn_mostraritemseleccionado.TabIndex = 20;
            this.btn_mostraritemseleccionado.Text = "10. elija un item y este botón lo mostrará por una ventana al item seleccionado.";
            this.btn_mostraritemseleccionado.UseVisualStyleBackColor = true;
            this.btn_mostraritemseleccionado.Click += new System.EventHandler(this.btn_mostraritemseleccionado_Click);
            // 
            // btn_azul
            // 
            this.btn_azul.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_azul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_azul.Location = new System.Drawing.Point(201, 384);
            this.btn_azul.Name = "btn_azul";
            this.btn_azul.Size = new System.Drawing.Size(106, 43);
            this.btn_azul.TabIndex = 21;
            this.btn_azul.Text = "11. FONDO AZUL";
            this.btn_azul.UseVisualStyleBackColor = false;
            // 
            // btn_amarillo
            // 
            this.btn_amarillo.BackColor = System.Drawing.Color.Yellow;
            this.btn_amarillo.Location = new System.Drawing.Point(364, 384);
            this.btn_amarillo.Name = "btn_amarillo";
            this.btn_amarillo.Size = new System.Drawing.Size(139, 43);
            this.btn_amarillo.TabIndex = 22;
            this.btn_amarillo.Text = "11. FONDO AMARILLO";
            this.btn_amarillo.UseVisualStyleBackColor = false;
            // 
            // btn_verde
            // 
            this.btn_verde.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_verde.Location = new System.Drawing.Point(550, 384);
            this.btn_verde.Name = "btn_verde";
            this.btn_verde.Size = new System.Drawing.Size(113, 43);
            this.btn_verde.TabIndex = 23;
            this.btn_verde.Text = "11. FONDO VERDE";
            this.btn_verde.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(262, 473);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(401, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "12. Agregue Elementos a este textbox (hasta 5)";
            // 
            // txt_elementosagregados
            // 
            this.txt_elementosagregados.Location = new System.Drawing.Point(392, 505);
            this.txt_elementosagregados.Multiline = true;
            this.txt_elementosagregados.Name = "txt_elementosagregados";
            this.txt_elementosagregados.Size = new System.Drawing.Size(149, 20);
            this.txt_elementosagregados.TabIndex = 25;
            // 
            // btn_agregarElementos
            // 
            this.btn_agregarElementos.BackColor = System.Drawing.Color.Lime;
            this.btn_agregarElementos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agregarElementos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregarElementos.Location = new System.Drawing.Point(392, 543);
            this.btn_agregarElementos.Name = "btn_agregarElementos";
            this.btn_agregarElementos.Size = new System.Drawing.Size(153, 41);
            this.btn_agregarElementos.TabIndex = 26;
            this.btn_agregarElementos.Text = "AGREGAR ELEMENTO";
            this.btn_agregarElementos.UseVisualStyleBackColor = false;
            this.btn_agregarElementos.Click += new System.EventHandler(this.btn_agregarElementos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 596);
            this.Controls.Add(this.btn_agregarElementos);
            this.Controls.Add(this.txt_elementosagregados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_verde);
            this.Controls.Add(this.btn_amarillo);
            this.Controls.Add(this.btn_azul);
            this.Controls.Add(this.btn_mostraritemseleccionado);
            this.Controls.Add(this.btn_borrarcontenido);
            this.Controls.Add(this.lbl_cambiarporcodigo);
            this.Controls.Add(this.btn_validar);
            this.Controls.Add(this.lbl_ocultarse);
            this.Controls.Add(this.btn_ocultarlabel);
            this.Controls.Add(this.txt_palabravalidar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_cambios);
            this.Controls.Add(this.lst_palabrascontenido);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_palabras);
            this.Controls.Add(this.btn_saludar);
            this.Controls.Add(this.lbl_mostranombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_mostranombre;
        private System.Windows.Forms.Button btn_saludar;
        private System.Windows.Forms.TextBox txt_palabras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ListBox lst_palabrascontenido;
        private System.Windows.Forms.Label lbl_cambios;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_palabravalidar;
        private System.Windows.Forms.Button btn_ocultarlabel;
        private System.Windows.Forms.Label lbl_ocultarse;
        private System.Windows.Forms.Button btn_validar;
        private System.Windows.Forms.Label lbl_cambiarporcodigo;
        private System.Windows.Forms.Button btn_borrarcontenido;
        private System.Windows.Forms.Button btn_mostraritemseleccionado;
        private System.Windows.Forms.Button btn_azul;
        private System.Windows.Forms.Button btn_amarillo;
        private System.Windows.Forms.Button btn_verde;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_elementosagregados;
        private System.Windows.Forms.Button btn_agregarElementos;
    }
}

