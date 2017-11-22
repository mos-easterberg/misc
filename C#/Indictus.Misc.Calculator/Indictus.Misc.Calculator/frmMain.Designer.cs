namespace Indictus.Misc.Calculator
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
            this.txtOne = new System.Windows.Forms.TextBox();
            this.txtTwo = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 64);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtOne
            // 
            this.txtOne.Location = new System.Drawing.Point(12, 12);
            this.txtOne.Name = "txtOne";
            this.txtOne.Size = new System.Drawing.Size(100, 20);
            this.txtOne.TabIndex = 1;
            // 
            // txtTwo
            // 
            this.txtTwo.Location = new System.Drawing.Point(12, 38);
            this.txtTwo.Name = "txtTwo";
            this.txtTwo.Size = new System.Drawing.Size(100, 20);
            this.txtTwo.TabIndex = 2;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 93);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 3;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtTwo);
            this.Controls.Add(this.txtOne);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmMain";
            this.Text = "Indictus.Misc.Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtOne;
        private System.Windows.Forms.TextBox txtTwo;
        private System.Windows.Forms.TextBox txtResult;
    }
}

