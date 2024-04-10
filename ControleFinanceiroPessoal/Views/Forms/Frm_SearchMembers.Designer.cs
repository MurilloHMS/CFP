namespace ControleFinanceiroPessoal.Views.Forms
{
    partial class Frm_SearchMembers
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
            Lst_Busca = new ListBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Lst_Busca
            // 
            Lst_Busca.Dock = DockStyle.Fill;
            Lst_Busca.FormattingEnabled = true;
            Lst_Busca.ItemHeight = 15;
            Lst_Busca.Location = new Point(3, 19);
            Lst_Busca.Name = "Lst_Busca";
            Lst_Busca.Size = new Size(384, 404);
            Lst_Busca.TabIndex = 0;
            Lst_Busca.DoubleClick += Lst_Busca_DoubleClick;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Lst_Busca);
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(390, 426);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Lista de Membros";
            // 
            // Frm_SearchMembers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(413, 450);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Frm_SearchMembers";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_SearchMembers";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListBox Lst_Busca;
        private GroupBox groupBox1;
    }
}