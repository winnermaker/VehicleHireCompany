namespace VehicleHireCompany
{
    partial class FrmRelocate
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
            this.label2 = new System.Windows.Forms.Label();
            this.nudKM = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKM)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(462, 173);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(462, 106);
            this.btnOK.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            // 
            // nudValue
            // 
            this.nudValue.Margin = new System.Windows.Forms.Padding(12, 12, 12, 12);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = "Driven KM";
            // 
            // nudKM
            // 
            this.nudKM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudKM.Location = new System.Drawing.Point(184, 173);
            this.nudKM.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.nudKM.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudKM.Name = "nudKM";
            this.nudKM.Size = new System.Drawing.Size(256, 37);
            this.nudKM.TabIndex = 14;
            // 
            // FrmRelocate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.ClientSize = new System.Drawing.Size(612, 248);
            this.Controls.Add(this.nudKM);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "FrmRelocate";
            this.Text = "Activity - Relocate";
            this.Controls.SetChildIndex(this.dtpActivityDate, 0);
            this.Controls.SetChildIndex(this.nudValue, 0);
            this.Controls.SetChildIndex(this.btnCancel, 0);
            this.Controls.SetChildIndex(this.btnOK, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.nudKM, 0);
            ((System.ComponentModel.ISupportInitialize)(this.nudValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudKM;
    }
}
