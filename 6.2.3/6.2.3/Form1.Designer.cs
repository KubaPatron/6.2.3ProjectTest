
namespace _6._2._3
{
    partial class frmKuba
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
            this.lbxAdvies = new System.Windows.Forms.ListBox();
            this.rdbWhile = new System.Windows.Forms.RadioButton();
            this.rdbFor = new System.Windows.Forms.RadioButton();
            this.txtEind = new System.Windows.Forms.TextBox();
            this.txtBegin = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxAdvies
            // 
            this.lbxAdvies.FormattingEnabled = true;
            this.lbxAdvies.ItemHeight = 16;
            this.lbxAdvies.Location = new System.Drawing.Point(114, 179);
            this.lbxAdvies.Name = "lbxAdvies";
            this.lbxAdvies.Size = new System.Drawing.Size(120, 148);
            this.lbxAdvies.TabIndex = 18;
            // 
            // rdbWhile
            // 
            this.rdbWhile.AutoSize = true;
            this.rdbWhile.Location = new System.Drawing.Point(190, 91);
            this.rdbWhile.Name = "rdbWhile";
            this.rdbWhile.Size = new System.Drawing.Size(64, 21);
            this.rdbWhile.TabIndex = 17;
            this.rdbWhile.TabStop = true;
            this.rdbWhile.Text = "While";
            this.rdbWhile.UseVisualStyleBackColor = true;
            // 
            // rdbFor
            // 
            this.rdbFor.AutoSize = true;
            this.rdbFor.Location = new System.Drawing.Point(134, 91);
            this.rdbFor.Name = "rdbFor";
            this.rdbFor.Size = new System.Drawing.Size(50, 21);
            this.rdbFor.TabIndex = 16;
            this.rdbFor.TabStop = true;
            this.rdbFor.Text = "For";
            this.rdbFor.UseVisualStyleBackColor = true;
            // 
            // txtEind
            // 
            this.txtEind.Location = new System.Drawing.Point(134, 51);
            this.txtEind.Name = "txtEind";
            this.txtEind.Size = new System.Drawing.Size(100, 22);
            this.txtEind.TabIndex = 15;
            // 
            // txtBegin
            // 
            this.txtBegin.Location = new System.Drawing.Point(134, 14);
            this.txtBegin.Name = "txtBegin";
            this.txtBegin.Size = new System.Drawing.Size(100, 22);
            this.txtBegin.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(102, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 34);
            this.button1.TabIndex = 13;
            this.button1.Text = "Geef advies";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(46, 51);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(82, 17);
            this.lbl2.TabIndex = 12;
            this.lbl2.Text = "Eindwaarde";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(38, 14);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(90, 17);
            this.lb1.TabIndex = 11;
            this.lb1.Text = "Beginwaarde";
            // 
            // frmKuba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 371);
            this.Controls.Add(this.lbxAdvies);
            this.Controls.Add(this.rdbWhile);
            this.Controls.Add(this.rdbFor);
            this.Controls.Add(this.txtEind);
            this.Controls.Add(this.txtBegin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lb1);
            this.Name = "frmKuba";
            this.Text = "6.2.3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAdvies;
        private System.Windows.Forms.RadioButton rdbWhile;
        private System.Windows.Forms.RadioButton rdbFor;
        private System.Windows.Forms.TextBox txtEind;
        private System.Windows.Forms.TextBox txtBegin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lb1;
    }
}

