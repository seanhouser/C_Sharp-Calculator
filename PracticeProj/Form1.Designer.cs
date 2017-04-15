namespace PracticeProj
{
    partial class frmMain
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.rtbResult = new System.Windows.Forms.RichTextBox();
            this.opr2 = new PracticeProj.Operand();
            this.opr1 = new PracticeProj.Operand();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(33, 102);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(63, 102);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(24, 24);
            this.btnSubtract.TabIndex = 3;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            // 
            // rtbResult
            // 
            this.rtbResult.Location = new System.Drawing.Point(33, 204);
            this.rtbResult.Name = "rtbResult";
            this.rtbResult.Size = new System.Drawing.Size(100, 96);
            this.rtbResult.TabIndex = 4;
            this.rtbResult.Text = "";
            // 
            // opr2
            // 
            this.opr2.Location = new System.Drawing.Point(3, 44);
            this.opr2.Name = "opr2";
            this.opr2.Size = new System.Drawing.Size(171, 26);
            this.opr2.TabIndex = 1;
            this.opr2.Value = 0;
            // 
            // opr1
            // 
            this.opr1.Location = new System.Drawing.Point(3, 12);
            this.opr1.Name = "opr1";
            this.opr1.Size = new System.Drawing.Size(171, 26);
            this.opr1.TabIndex = 0;
            this.opr1.Value = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 312);
            this.Controls.Add(this.rtbResult);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.opr2);
            this.Controls.Add(this.opr1);
            this.Name = "frmMain";
            this.Text = "My First App! :)";
            this.ResumeLayout(false);

        }

        #endregion

        private Operand opr1;
        private Operand opr2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubtract;
        private System.Windows.Forms.RichTextBox rtbResult;


    }
}

