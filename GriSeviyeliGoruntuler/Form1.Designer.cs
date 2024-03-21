namespace GriSeviyeliGoruntuler
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btn_resimyukle = new Button();
            btn_griyap = new Button();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Location = new Point(42, 65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(422, 65);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(334, 300);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // btn_resimyukle
            // 
            btn_resimyukle.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_resimyukle.FlatStyle = FlatStyle.Flat;
            btn_resimyukle.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_resimyukle.Location = new Point(221, 388);
            btn_resimyukle.Name = "btn_resimyukle";
            btn_resimyukle.Size = new Size(121, 36);
            btn_resimyukle.TabIndex = 2;
            btn_resimyukle.Text = "Resim Yükle";
            btn_resimyukle.UseVisualStyleBackColor = true;
            btn_resimyukle.Click += btn_resimyukle_Click;
            // 
            // btn_griyap
            // 
            btn_griyap.FlatAppearance.MouseOverBackColor = Color.Gray;
            btn_griyap.FlatStyle = FlatStyle.Flat;
            btn_griyap.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btn_griyap.Location = new Point(612, 388);
            btn_griyap.Name = "btn_griyap";
            btn_griyap.Size = new Size(121, 36);
            btn_griyap.TabIndex = 3;
            btn_griyap.Text = "Gri Yap";
            btn_griyap.UseVisualStyleBackColor = true;
            btn_griyap.Click += btn_griyap_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.FlatAppearance.MouseOverBackColor = Color.Gray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            button1.Location = new Point(422, 388);
            button1.Name = "button1";
            button1.Size = new Size(121, 36);
            button1.TabIndex = 4;
            button1.Text = "Binary Yap";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btn_griyap);
            Controls.Add(btn_resimyukle);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btn_resimyukle;
        private Button btn_griyap;
        private OpenFileDialog openFileDialog1;
        private Button button1;
    }
}
