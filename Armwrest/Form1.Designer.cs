
namespace Armwrest
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnqeyd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtadi = new System.Windows.Forms.TextBox();
            this.btnelave = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btnbasla = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.List = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.groupBox1.Controls.Add(this.btnqeyd);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(59, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Yarisci sayi.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sayi";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(47, 42);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(32, 25);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnqeyd
            // 
            this.btnqeyd.Location = new System.Drawing.Point(137, 44);
            this.btnqeyd.Name = "btnqeyd";
            this.btnqeyd.Size = new System.Drawing.Size(75, 25);
            this.btnqeyd.TabIndex = 2;
            this.btnqeyd.Text = "Qeyd et";
            this.btnqeyd.UseVisualStyleBackColor = true;
            this.btnqeyd.Click += new System.EventHandler(this.btnqeyd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.btnelave);
            this.groupBox2.Controls.Add(this.txtadi);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(59, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Adi Qeyd Edin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Adi :";
            // 
            // txtadi
            // 
            this.txtadi.Location = new System.Drawing.Point(47, 36);
            this.txtadi.Name = "txtadi";
            this.txtadi.Size = new System.Drawing.Size(165, 25);
            this.txtadi.TabIndex = 1;
            // 
            // btnelave
            // 
            this.btnelave.Location = new System.Drawing.Point(137, 77);
            this.btnelave.Name = "btnelave";
            this.btnelave.Size = new System.Drawing.Size(75, 31);
            this.btnelave.TabIndex = 2;
            this.btnelave.Text = "Elave et";
            this.btnelave.UseVisualStyleBackColor = true;
            this.btnelave.Click += new System.EventHandler(this.btnelave_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox3.Controls.Add(this.List);
            this.groupBox3.Controls.Add(this.btntemizle);
            this.groupBox3.Controls.Add(this.Btnbasla);
            this.groupBox3.Location = new System.Drawing.Point(401, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(269, 323);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pusk_Atma";
            // 
            // Btnbasla
            // 
            this.Btnbasla.Location = new System.Drawing.Point(37, 45);
            this.Btnbasla.Name = "Btnbasla";
            this.Btnbasla.Size = new System.Drawing.Size(75, 23);
            this.Btnbasla.TabIndex = 0;
            this.Btnbasla.Text = "Basla";
            this.Btnbasla.UseVisualStyleBackColor = true;
            this.Btnbasla.Click += new System.EventHandler(this.Btnbasla_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(156, 45);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(75, 23);
            this.btntemizle.TabIndex = 0;
            this.btntemizle.Text = "Temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // List
            // 
            this.List.FormattingEnabled = true;
            this.List.ItemHeight = 15;
            this.List.Location = new System.Drawing.Point(37, 91);
            this.List.Name = "List";
            this.List.Size = new System.Drawing.Size(194, 199);
            this.List.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 379);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ArmWrestling";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnqeyd;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnelave;
        private System.Windows.Forms.TextBox txtadi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox List;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.Button Btnbasla;
    }
}

