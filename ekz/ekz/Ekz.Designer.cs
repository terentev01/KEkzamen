namespace ekz
{
    partial class Ekz
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.f1txtNaprav = new System.Windows.Forms.TextBox();
            this.f1txtProdolz = new System.Windows.Forms.TextBox();
            this.f1txtCena = new System.Windows.Forms.TextBox();
            this.f1btnSave = new System.Windows.Forms.Button();
            this.labelnapr = new System.Windows.Forms.Label();
            this.labelprod = new System.Windows.Forms.Label();
            this.labelcena = new System.Windows.Forms.Label();
            this.labelrazm = new System.Windows.Forms.Label();
            this.f1nudRazm = new System.Windows.Forms.NumericUpDown();
            this.f1btnOk = new System.Windows.Forms.Button();
            this.labelputkfailu = new System.Windows.Forms.Label();
            this.f1txtputfile = new System.Windows.Forms.TextBox();
            this.f1btnOpenfile = new System.Windows.Forms.Button();
            this.f1btnadd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1nudRazm)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(685, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // f1txtNaprav
            // 
            this.f1txtNaprav.Location = new System.Drawing.Point(597, 304);
            this.f1txtNaprav.Name = "f1txtNaprav";
            this.f1txtNaprav.Size = new System.Drawing.Size(100, 20);
            this.f1txtNaprav.TabIndex = 1;
            // 
            // f1txtProdolz
            // 
            this.f1txtProdolz.Location = new System.Drawing.Point(597, 330);
            this.f1txtProdolz.Name = "f1txtProdolz";
            this.f1txtProdolz.Size = new System.Drawing.Size(100, 20);
            this.f1txtProdolz.TabIndex = 2;
            // 
            // f1txtCena
            // 
            this.f1txtCena.Location = new System.Drawing.Point(597, 356);
            this.f1txtCena.Name = "f1txtCena";
            this.f1txtCena.Size = new System.Drawing.Size(100, 20);
            this.f1txtCena.TabIndex = 3;
            // 
            // f1btnSave
            // 
            this.f1btnSave.Location = new System.Drawing.Point(487, 383);
            this.f1btnSave.Name = "f1btnSave";
            this.f1btnSave.Size = new System.Drawing.Size(100, 23);
            this.f1btnSave.TabIndex = 4;
            this.f1btnSave.Text = "Сохранить";
            this.f1btnSave.UseVisualStyleBackColor = true;
            this.f1btnSave.Click += new System.EventHandler(this.f1btnSave_Click);
            // 
            // labelnapr
            // 
            this.labelnapr.AutoSize = true;
            this.labelnapr.Location = new System.Drawing.Point(484, 307);
            this.labelnapr.Name = "labelnapr";
            this.labelnapr.Size = new System.Drawing.Size(75, 13);
            this.labelnapr.TabIndex = 5;
            this.labelnapr.Text = "Направление";
            // 
            // labelprod
            // 
            this.labelprod.AutoSize = true;
            this.labelprod.Location = new System.Drawing.Point(484, 333);
            this.labelprod.Name = "labelprod";
            this.labelprod.Size = new System.Drawing.Size(111, 13);
            this.labelprod.TabIndex = 6;
            this.labelprod.Text = "Продолжительность";
            // 
            // labelcena
            // 
            this.labelcena.AutoSize = true;
            this.labelcena.Location = new System.Drawing.Point(484, 359);
            this.labelcena.Name = "labelcena";
            this.labelcena.Size = new System.Drawing.Size(33, 13);
            this.labelcena.TabIndex = 7;
            this.labelcena.Text = "Цена";
            // 
            // labelrazm
            // 
            this.labelrazm.AutoSize = true;
            this.labelrazm.Location = new System.Drawing.Point(12, 307);
            this.labelrazm.Name = "labelrazm";
            this.labelrazm.Size = new System.Drawing.Size(93, 13);
            this.labelrazm.TabIndex = 8;
            this.labelrazm.Text = "Размер массива";
            // 
            // f1nudRazm
            // 
            this.f1nudRazm.Location = new System.Drawing.Point(12, 325);
            this.f1nudRazm.Name = "f1nudRazm";
            this.f1nudRazm.Size = new System.Drawing.Size(120, 20);
            this.f1nudRazm.TabIndex = 9;
            // 
            // f1btnOk
            // 
            this.f1btnOk.Location = new System.Drawing.Point(12, 352);
            this.f1btnOk.Name = "f1btnOk";
            this.f1btnOk.Size = new System.Drawing.Size(75, 23);
            this.f1btnOk.TabIndex = 10;
            this.f1btnOk.Text = "OK";
            this.f1btnOk.UseVisualStyleBackColor = true;
            this.f1btnOk.Click += new System.EventHandler(this.f1btnOk_Click);
            // 
            // labelputkfailu
            // 
            this.labelputkfailu.AutoSize = true;
            this.labelputkfailu.Location = new System.Drawing.Point(227, 325);
            this.labelputkfailu.Name = "labelputkfailu";
            this.labelputkfailu.Size = new System.Drawing.Size(74, 13);
            this.labelputkfailu.TabIndex = 11;
            this.labelputkfailu.Text = "Путь к файлу";
            // 
            // f1txtputfile
            // 
            this.f1txtputfile.Location = new System.Drawing.Point(230, 342);
            this.f1txtputfile.Name = "f1txtputfile";
            this.f1txtputfile.Size = new System.Drawing.Size(100, 20);
            this.f1txtputfile.TabIndex = 12;
            // 
            // f1btnOpenfile
            // 
            this.f1btnOpenfile.Location = new System.Drawing.Point(230, 369);
            this.f1btnOpenfile.Name = "f1btnOpenfile";
            this.f1btnOpenfile.Size = new System.Drawing.Size(100, 23);
            this.f1btnOpenfile.TabIndex = 13;
            this.f1btnOpenfile.Text = "Открыть файл";
            this.f1btnOpenfile.UseVisualStyleBackColor = true;
            this.f1btnOpenfile.Click += new System.EventHandler(this.f1btnOpenfile_Click);
            // 
            // f1btnadd
            // 
            this.f1btnadd.Location = new System.Drawing.Point(597, 383);
            this.f1btnadd.Name = "f1btnadd";
            this.f1btnadd.Size = new System.Drawing.Size(100, 23);
            this.f1btnadd.TabIndex = 14;
            this.f1btnadd.Text = "Добавить";
            this.f1btnadd.UseVisualStyleBackColor = true;
            this.f1btnadd.Click += new System.EventHandler(this.f1btnadd_Click);
            // 
            // Ekz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 409);
            this.Controls.Add(this.f1btnadd);
            this.Controls.Add(this.f1btnOpenfile);
            this.Controls.Add(this.f1txtputfile);
            this.Controls.Add(this.labelputkfailu);
            this.Controls.Add(this.f1btnOk);
            this.Controls.Add(this.f1nudRazm);
            this.Controls.Add(this.labelrazm);
            this.Controls.Add(this.labelcena);
            this.Controls.Add(this.labelprod);
            this.Controls.Add(this.labelnapr);
            this.Controls.Add(this.f1btnSave);
            this.Controls.Add(this.f1txtCena);
            this.Controls.Add(this.f1txtProdolz);
            this.Controls.Add(this.f1txtNaprav);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Ekz";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.f1nudRazm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox f1txtNaprav;
        private System.Windows.Forms.TextBox f1txtProdolz;
        private System.Windows.Forms.TextBox f1txtCena;
        private System.Windows.Forms.Button f1btnSave;
        private System.Windows.Forms.Label labelnapr;
        private System.Windows.Forms.Label labelprod;
        private System.Windows.Forms.Label labelcena;
        private System.Windows.Forms.Label labelrazm;
        private System.Windows.Forms.NumericUpDown f1nudRazm;
        private System.Windows.Forms.Button f1btnOk;
        private System.Windows.Forms.Label labelputkfailu;
        private System.Windows.Forms.TextBox f1txtputfile;
        private System.Windows.Forms.Button f1btnOpenfile;
        private System.Windows.Forms.Button f1btnadd;
    }
}

