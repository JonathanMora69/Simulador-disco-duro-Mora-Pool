namespace Simulador_disco_duro
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
            labelFileName = new System.Windows.Forms.Label();
            labelFileSize = new System.Windows.Forms.Label();
            textBoxFileSize = new System.Windows.Forms.TextBox();
            textBoxFileName = new System.Windows.Forms.TextBox();
            buttonSave = new System.Windows.Forms.Button();
            listViewSectors = new System.Windows.Forms.ListView();
            listViewFiles = new System.Windows.Forms.ListView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Location = new System.Drawing.Point(12, 23);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new System.Drawing.Size(112, 15);
            labelFileName.TabIndex = 0;
            labelFileName.Text = "Nombre del archivo";
            // 
            // labelFileSize
            // 
            labelFileSize.AutoSize = true;
            labelFileSize.Location = new System.Drawing.Point(146, 23);
            labelFileSize.Name = "labelFileSize";
            labelFileSize.Size = new System.Drawing.Size(110, 15);
            labelFileSize.TabIndex = 1;
            labelFileSize.Text = "Tamaño del archivo";
            // 
            // textBoxFileSize
            // 
            textBoxFileSize.Location = new System.Drawing.Point(146, 41);
            textBoxFileSize.Name = "textBoxFileSize";
            textBoxFileSize.Size = new System.Drawing.Size(100, 23);
            textBoxFileSize.TabIndex = 2;
            // 
            // textBoxFileName
            // 
            textBoxFileName.Location = new System.Drawing.Point(12, 41);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new System.Drawing.Size(100, 23);
            textBoxFileName.TabIndex = 3;
            // 
            // buttonSave
            // 
            buttonSave.Location = new System.Drawing.Point(280, 41);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(75, 23);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Guardar";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // listViewSectors
            // 
            listViewSectors.HideSelection = false;
            listViewSectors.Location = new System.Drawing.Point(12, 115);
            listViewSectors.Name = "listViewSectors";
            listViewSectors.Size = new System.Drawing.Size(244, 167);
            listViewSectors.TabIndex = 5;
            listViewSectors.UseCompatibleStateImageBehavior = false;
            // 
            // listViewFiles
            // 
            listViewFiles.HideSelection = false;
            listViewFiles.Location = new System.Drawing.Point(332, 115);
            listViewFiles.Name = "listViewFiles";
            listViewFiles.Size = new System.Drawing.Size(258, 167);
            listViewFiles.TabIndex = 6;
            listViewFiles.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(642, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(113, 15);
            label1.TabIndex = 7;
            label1.Text = "Mora Pool Jonathan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(642, 75);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(126, 15);
            label2.TabIndex = 8;
            label2.Text = "Adamaris Gomez Leon";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.gatito_fachero;
            pictureBox1.Location = new System.Drawing.Point(628, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(160, 118);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listViewFiles);
            Controls.Add(listViewSectors);
            Controls.Add(buttonSave);
            Controls.Add(textBoxFileName);
            Controls.Add(textBoxFileSize);
            Controls.Add(labelFileSize);
            Controls.Add(labelFileName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelFileSize;
        private System.Windows.Forms.TextBox textBoxFileSize;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListView listViewSectors;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
