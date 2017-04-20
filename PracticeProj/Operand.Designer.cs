namespace PracticeProj
{
    partial class Operand
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOp = new System.Windows.Forms.Label();
            this.numOp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numOp)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOp.Location = new System.Drawing.Point(3, 5);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(35, 13);
            this.lblOp.TabIndex = 0;
            this.lblOp.Text = "label1";
            // 
            // numOp
            // 
            this.numOp.Location = new System.Drawing.Point(69, 3);
            this.numOp.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numOp.Name = "numOp";
            this.numOp.Size = new System.Drawing.Size(100, 20);
            this.numOp.TabIndex = 1;
            // 
            // Operand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.numOp);
            this.Controls.Add(this.lblOp);
            this.Name = "Operand";
            this.Size = new System.Drawing.Size(171, 26);
            ((System.ComponentModel.ISupportInitialize)(this.numOp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.NumericUpDown numOp;
    }
}
