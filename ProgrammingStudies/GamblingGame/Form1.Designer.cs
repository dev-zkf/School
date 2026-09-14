namespace GamblingGame
{
    partial class Form1
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
            this.GambleBtn = new System.Windows.Forms.Button();
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.spendAmountTxt = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.spendAmountTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // GambleBtn
            // 
            this.GambleBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.GambleBtn.Location = new System.Drawing.Point(261, 274);
            this.GambleBtn.Name = "GambleBtn";
            this.GambleBtn.Size = new System.Drawing.Size(193, 63);
            this.GambleBtn.TabIndex = 0;
            this.GambleBtn.Text = "Gamble";
            this.GambleBtn.UseVisualStyleBackColor = true;
            this.GambleBtn.Click += new System.EventHandler(this.GambleBtn_Click);
            // 
            // LogText
            // 
            this.LogText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogText.Location = new System.Drawing.Point(12, 12);
            this.LogText.Name = "LogText";
            this.LogText.ReadOnly = true;
            this.LogText.Size = new System.Drawing.Size(442, 239);
            this.LogText.TabIndex = 2;
            this.LogText.Text = "";
            this.LogText.TextChanged += new System.EventHandler(this.LogText_TextChanged);
            // 
            // spendAmountTxt
            // 
            this.spendAmountTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spendAmountTxt.Location = new System.Drawing.Point(12, 288);
            this.spendAmountTxt.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.spendAmountTxt.Name = "spendAmountTxt";
            this.spendAmountTxt.Size = new System.Drawing.Size(138, 32);
            this.spendAmountTxt.TabIndex = 3;
            this.spendAmountTxt.ValueChanged += new System.EventHandler(this.spendAmountTxt_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 349);
            this.Controls.Add(this.spendAmountTxt);
            this.Controls.Add(this.LogText);
            this.Controls.Add(this.GambleBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.spendAmountTxt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GambleBtn;
        private System.Windows.Forms.RichTextBox LogText;
        private System.Windows.Forms.NumericUpDown spendAmountTxt;
    }
}

