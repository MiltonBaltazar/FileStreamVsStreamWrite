namespace WriteFile
{
    partial class frmWrite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWrite));
            this.btnGenerar = new System.Windows.Forms.Button();
            this.rtbInputFile1 = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtWriteStream = new System.Windows.Forms.RadioButton();
            this.rbtFileStream = new System.Windows.Forms.RadioButton();
            this.nudBucle = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.pgbProgress = new System.Windows.Forms.ProgressBar();
            this.txtFullPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblMiliseconds = new System.Windows.Forms.Label();
            this.rtbInputFile2 = new System.Windows.Forms.RichTextBox();
            this.rtbInputFile3 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBucle)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerar
            // 
            this.btnGenerar.Location = new System.Drawing.Point(177, 243);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(75, 23);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // rtbInputFile1
            // 
            this.rtbInputFile1.Location = new System.Drawing.Point(12, 56);
            this.rtbInputFile1.Name = "rtbInputFile1";
            this.rtbInputFile1.Size = new System.Drawing.Size(269, 176);
            this.rtbInputFile1.TabIndex = 1;
            this.rtbInputFile1.Text = resources.GetString("rtbInputFile1.Text");
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtWriteStream);
            this.groupBox1.Controls.Add(this.rbtFileStream);
            this.groupBox1.Location = new System.Drawing.Point(12, 276);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 56);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Método";
            // 
            // rbtWriteStream
            // 
            this.rbtWriteStream.AutoSize = true;
            this.rbtWriteStream.Location = new System.Drawing.Point(93, 24);
            this.rbtWriteStream.Name = "rbtWriteStream";
            this.rbtWriteStream.Size = new System.Drawing.Size(83, 17);
            this.rbtWriteStream.TabIndex = 1;
            this.rbtWriteStream.Text = "WriteStream";
            this.rbtWriteStream.UseVisualStyleBackColor = true;
            // 
            // rbtFileStream
            // 
            this.rbtFileStream.AutoSize = true;
            this.rbtFileStream.Checked = true;
            this.rbtFileStream.Location = new System.Drawing.Point(13, 24);
            this.rbtFileStream.Name = "rbtFileStream";
            this.rbtFileStream.Size = new System.Drawing.Size(74, 17);
            this.rbtFileStream.TabIndex = 0;
            this.rbtFileStream.TabStop = true;
            this.rbtFileStream.Text = "FileStream";
            this.rbtFileStream.UseVisualStyleBackColor = true;
            // 
            // nudBucle
            // 
            this.nudBucle.Location = new System.Drawing.Point(52, 243);
            this.nudBucle.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudBucle.Name = "nudBucle";
            this.nudBucle.Size = new System.Drawing.Size(97, 20);
            this.nudBucle.TabIndex = 3;
            this.nudBucle.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bucle";
            // 
            // pgbProgress
            // 
            this.pgbProgress.Location = new System.Drawing.Point(258, 308);
            this.pgbProgress.Name = "pgbProgress";
            this.pgbProgress.Size = new System.Drawing.Size(573, 24);
            this.pgbProgress.TabIndex = 5;
            // 
            // txtFullPath
            // 
            this.txtFullPath.Location = new System.Drawing.Point(58, 10);
            this.txtFullPath.Name = "txtFullPath";
            this.txtFullPath.Size = new System.Drawing.Size(474, 20);
            this.txtFullPath.TabIndex = 6;
            this.txtFullPath.Text = "C:\\\\output\\Lorem.txt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Archivo";
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(538, 8);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(47, 23);
            this.btnSelectFile.TabIndex = 8;
            this.btnSelectFile.Text = "...";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Texto a escribir";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSeconds.Location = new System.Drawing.Point(258, 273);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(91, 13);
            this.lblSeconds.TabIndex = 10;
            this.lblSeconds.Text = "                            ";
            // 
            // lblMiliseconds
            // 
            this.lblMiliseconds.AutoSize = true;
            this.lblMiliseconds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMiliseconds.Location = new System.Drawing.Point(258, 292);
            this.lblMiliseconds.Name = "lblMiliseconds";
            this.lblMiliseconds.Size = new System.Drawing.Size(91, 13);
            this.lblMiliseconds.TabIndex = 11;
            this.lblMiliseconds.Text = "                            ";
            // 
            // rtbInputFile2
            // 
            this.rtbInputFile2.Location = new System.Drawing.Point(287, 56);
            this.rtbInputFile2.Name = "rtbInputFile2";
            this.rtbInputFile2.Size = new System.Drawing.Size(269, 176);
            this.rtbInputFile2.TabIndex = 12;
            this.rtbInputFile2.Text = resources.GetString("rtbInputFile2.Text");
            // 
            // rtbInputFile3
            // 
            this.rtbInputFile3.Location = new System.Drawing.Point(562, 56);
            this.rtbInputFile3.Name = "rtbInputFile3";
            this.rtbInputFile3.Size = new System.Drawing.Size(269, 176);
            this.rtbInputFile3.TabIndex = 13;
            this.rtbInputFile3.Text = resources.GetString("rtbInputFile3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Texto a escribir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(559, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Texto a escribir";
            // 
            // frmWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 362);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rtbInputFile3);
            this.Controls.Add(this.rtbInputFile2);
            this.Controls.Add(this.lblMiliseconds);
            this.Controls.Add(this.lblSeconds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFullPath);
            this.Controls.Add(this.pgbProgress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudBucle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rtbInputFile1);
            this.Controls.Add(this.btnGenerar);
            this.Name = "frmWrite";
            this.Text = "Comparar métodos de escritura de archivo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudBucle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.RichTextBox rtbInputFile1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudBucle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pgbProgress;
        private System.Windows.Forms.RadioButton rbtFileStream;
        private System.Windows.Forms.TextBox txtFullPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMiliseconds;
        private System.Windows.Forms.RichTextBox rtbInputFile2;
        private System.Windows.Forms.RichTextBox rtbInputFile3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rbtWriteStream;
    }
}

