namespace ControleFinanceiroPessoal.Forms
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            button1 = new Button();
            pictureBox1 = new PictureBox();
            Txt_Usuario = new TextBox();
            Txt_Senha = new TextBox();
            Llbl_Forgot = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            Btn_Cancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(174, 145);
            button1.Name = "button1";
            button1.Size = new Size(82, 23);
            button1.TabIndex = 2;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(167, 151);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // Txt_Usuario
            // 
            Txt_Usuario.Location = new Point(174, 40);
            Txt_Usuario.Name = "Txt_Usuario";
            Txt_Usuario.Size = new Size(196, 23);
            Txt_Usuario.TabIndex = 4;
            // 
            // Txt_Senha
            // 
            Txt_Senha.Location = new Point(174, 100);
            Txt_Senha.Name = "Txt_Senha";
            Txt_Senha.PasswordChar = '*';
            Txt_Senha.Size = new Size(196, 23);
            Txt_Senha.TabIndex = 5;
            // 
            // Llbl_Forgot
            // 
            Llbl_Forgot.AutoSize = true;
            Llbl_Forgot.Location = new Point(212, 126);
            Llbl_Forgot.Name = "Llbl_Forgot";
            Llbl_Forgot.Size = new Size(106, 15);
            Llbl_Forgot.TabIndex = 6;
            Llbl_Forgot.TabStop = true;
            Llbl_Forgot.Text = "Esqueceu a Senha?";
            // 
            // label3
            // 
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(174, 66);
            label3.Name = "label3";
            label3.Size = new Size(133, 31);
            label3.TabIndex = 8;
            label3.Text = "Senha";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(174, 9);
            label4.Name = "label4";
            label4.Size = new Size(133, 31);
            label4.TabIndex = 7;
            label4.Text = "Usuário";
            label4.TextAlign = ContentAlignment.BottomCenter;
            // 
            // Btn_Cancel
            // 
            Btn_Cancel.Cursor = Cursors.Hand;
            Btn_Cancel.Location = new Point(262, 145);
            Btn_Cancel.Name = "Btn_Cancel";
            Btn_Cancel.Size = new Size(82, 23);
            Btn_Cancel.TabIndex = 9;
            Btn_Cancel.Text = "Cancelar";
            Btn_Cancel.UseVisualStyleBackColor = true;
            Btn_Cancel.Click += Btn_Cancel_Click;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(404, 180);
            Controls.Add(Btn_Cancel);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(Llbl_Forgot);
            Controls.Add(Txt_Senha);
            Controls.Add(Txt_Usuario);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Login ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private PictureBox pictureBox1;
        private TextBox Txt_Usuario;
        private TextBox Txt_Senha;
        private LinkLabel Llbl_Forgot;
        private Label label3;
        private Label label4;
        private Button Btn_Cancel;
    }
}