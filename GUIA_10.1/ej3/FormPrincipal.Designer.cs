using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ej3;

partial class FormPrincipal
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
        groupBox1 = new GroupBox();
        label6 = new Label();
        lbxPedidosEntrantes = new ListBox();
        label2 = new Label();
        label1 = new Label();
        btnAtender = new Button();
        tbDireccion = new TextBox();
        tbTelefono = new TextBox();
        groupBox2 = new GroupBox();
        label5 = new Label();
        label4 = new Label();
        lbxOcupados = new ListBox();
        lbxDisponibles = new ListBox();
        btnAsignar = new Button();
        groupBox3 = new GroupBox();
        label3 = new Label();
        nupNumeroMovil = new NumericUpDown();
        btnLiberar = new Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        groupBox3.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)nupNumeroMovil).BeginInit();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label6);
        groupBox1.Controls.Add(lbxPedidosEntrantes);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(label1);
        groupBox1.Controls.Add(btnAtender);
        groupBox1.Controls.Add(tbDireccion);
        groupBox1.Controls.Add(tbTelefono);
        groupBox1.Location = new Point(10, 10);
        groupBox1.Margin = new Padding(3, 4, 3, 4);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new Padding(3, 4, 3, 4);
        groupBox1.Size = new Size(233, 260);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Recibir Pedido Taxi";
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Location = new Point(3, 115);
        label6.Margin = new Padding(2, 0, 2, 0);
        label6.Name = "label6";
        label6.Size = new Size(101, 15);
        label6.TabIndex = 9;
        label6.Text = "Pedidos Entrantes";
        // 
        // lbxPedidosEntrantes
        // 
        lbxPedidosEntrantes.FormattingEnabled = true;
        lbxPedidosEntrantes.ItemHeight = 15;
        lbxPedidosEntrantes.Location = new Point(66, 132);
        lbxPedidosEntrantes.Margin = new Padding(2);
        lbxPedidosEntrantes.Name = "lbxPedidosEntrantes";
        lbxPedidosEntrantes.Size = new Size(158, 64);
        lbxPedidosEntrantes.TabIndex = 8;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(3, 51);
        label2.Margin = new Padding(2, 0, 2, 0);
        label2.Name = "label2";
        label2.Size = new Size(57, 15);
        label2.TabIndex = 4;
        label2.Text = "Direccion";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(5, 27);
        label1.Margin = new Padding(2, 0, 2, 0);
        label1.Name = "label1";
        label1.Size = new Size(53, 15);
        label1.TabIndex = 3;
        label1.Text = "Telefono";
        // 
        // btnAtender
        // 
        btnAtender.Location = new Point(66, 200);
        btnAtender.Margin = new Padding(2);
        btnAtender.Name = "btnAtender";
        btnAtender.Size = new Size(102, 50);
        btnAtender.TabIndex = 2;
        btnAtender.Text = "Atender";
        btnAtender.UseVisualStyleBackColor = true;
        btnAtender.Click += btnAtender_Click;
        // 
        // tbDireccion
        // 
        tbDireccion.Location = new Point(66, 49);
        tbDireccion.Margin = new Padding(2);
        tbDireccion.Multiline = true;
        tbDireccion.Name = "tbDireccion";
        tbDireccion.Size = new Size(160, 63);
        tbDireccion.TabIndex = 1;
        // 
        // tbTelefono
        // 
        tbTelefono.Location = new Point(66, 25);
        tbTelefono.Margin = new Padding(2);
        tbTelefono.Name = "tbTelefono";
        tbTelefono.Size = new Size(160, 23);
        tbTelefono.TabIndex = 0;
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(label5);
        groupBox2.Controls.Add(label4);
        groupBox2.Controls.Add(lbxOcupados);
        groupBox2.Controls.Add(lbxDisponibles);
        groupBox2.Controls.Add(btnAsignar);
        groupBox2.Location = new Point(249, 10);
        groupBox2.Margin = new Padding(2);
        groupBox2.Name = "groupBox2";
        groupBox2.Padding = new Padding(2);
        groupBox2.Size = new Size(233, 261);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Central de taxis";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Location = new Point(5, 25);
        label5.Margin = new Padding(2, 0, 2, 0);
        label5.Name = "label5";
        label5.Size = new Size(121, 15);
        label5.TabIndex = 7;
        label5.Text = "Vehículos Disponibles";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(5, 115);
        label4.Margin = new Padding(2, 0, 2, 0);
        label4.Name = "label4";
        label4.Size = new Size(114, 15);
        label4.TabIndex = 6;
        label4.Text = "Vehículos Ocupados";
        // 
        // lbxOcupados
        // 
        lbxOcupados.FormattingEnabled = true;
        lbxOcupados.ItemHeight = 15;
        lbxOcupados.Location = new Point(8, 132);
        lbxOcupados.Margin = new Padding(2);
        lbxOcupados.Name = "lbxOcupados";
        lbxOcupados.Size = new Size(221, 64);
        lbxOcupados.TabIndex = 4;
        // 
        // lbxDisponibles
        // 
        lbxDisponibles.FormattingEnabled = true;
        lbxDisponibles.ItemHeight = 15;
        lbxDisponibles.Location = new Point(5, 42);
        lbxDisponibles.Margin = new Padding(2);
        lbxDisponibles.Name = "lbxDisponibles";
        lbxDisponibles.Size = new Size(224, 64);
        lbxDisponibles.TabIndex = 4;
        // 
        // btnAsignar
        // 
        btnAsignar.Location = new Point(61, 200);
        btnAsignar.Margin = new Padding(2);
        btnAsignar.Name = "btnAsignar";
        btnAsignar.Size = new Size(101, 50);
        btnAsignar.TabIndex = 3;
        btnAsignar.Text = "Asignar Coche a Cliente";
        btnAsignar.UseVisualStyleBackColor = true;
        btnAsignar.Click += btnAsignar_Click;
        // 
        // groupBox3
        // 
        groupBox3.Controls.Add(label3);
        groupBox3.Controls.Add(nupNumeroMovil);
        groupBox3.Controls.Add(btnLiberar);
        groupBox3.Location = new Point(486, 10);
        groupBox3.Margin = new Padding(2);
        groupBox3.Name = "groupBox3";
        groupBox3.Padding = new Padding(2);
        groupBox3.Size = new Size(233, 261);
        groupBox3.TabIndex = 2;
        groupBox3.TabStop = false;
        groupBox3.Text = "Acciones del chofer";
        groupBox3.Enter += groupBox3_Enter;
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(25, 36);
        label3.Margin = new Padding(2, 0, 2, 0);
        label3.Name = "label3";
        label3.Size = new Size(99, 15);
        label3.TabIndex = 5;
        label3.Text = "Número Vehículo";
        // 
        // nupNumeroMovil
        // 
        nupNumeroMovil.Location = new Point(131, 34);
        nupNumeroMovil.Margin = new Padding(2);
        nupNumeroMovil.Name = "nupNumeroMovil";
        nupNumeroMovil.Size = new Size(61, 23);
        nupNumeroMovil.TabIndex = 4;
        // 
        // btnLiberar
        // 
        btnLiberar.Location = new Point(80, 200);
        btnLiberar.Margin = new Padding(2);
        btnLiberar.Name = "btnLiberar";
        btnLiberar.Size = new Size(101, 50);
        btnLiberar.TabIndex = 3;
        btnLiberar.Text = "Liberar Coche";
        btnLiberar.UseVisualStyleBackColor = true;
        btnLiberar.Click += btnLiberar_Click;
        // 
        // FormPrincipal
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(726, 275);
        Controls.Add(groupBox3);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Margin = new Padding(3, 4, 3, 4);
        Name = "FormPrincipal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Ejercicio3";
        Load += FormPrincipal_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        groupBox3.ResumeLayout(false);
        groupBox3.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)nupNumeroMovil).EndInit();
        ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button btnAtender;
    private System.Windows.Forms.TextBox tbDireccion;
    private System.Windows.Forms.TextBox tbTelefono;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.ListBox lbxOcupados;
    private System.Windows.Forms.ListBox lbxDisponibles;
    private System.Windows.Forms.Button btnAsignar;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.NumericUpDown nupNumeroMovil;
    private System.Windows.Forms.Button btnLiberar;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.ListBox lbxPedidosEntrantes;
}

