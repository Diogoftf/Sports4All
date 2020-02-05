namespace Sports4All.Patterns.State
{
    partial class ShowPriceState
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
            this.nextScreenButton = new Sports4All.View.UserControls_Items.NextScreenButton();
            this.previousScreenButton = new Sports4All.View.UserControls_Items.PreviousScreenButton();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceValue = new System.Windows.Forms.Label();
            this.lblConclude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nextScreenButton
            // 
            this.nextScreenButton.Location = new System.Drawing.Point(1024, 556);
            this.nextScreenButton.Name = "nextScreenButton";
            this.nextScreenButton.ReserveNoviceForm = null;
            this.nextScreenButton.Size = new System.Drawing.Size(63, 63);
            this.nextScreenButton.TabIndex = 14;
            // 
            // previousScreenButton
            // 
            this.previousScreenButton.Location = new System.Drawing.Point(3, 556);
            this.previousScreenButton.Name = "previousScreenButton";
            this.previousScreenButton.ReserveNoviceForm = null;
            this.previousScreenButton.Size = new System.Drawing.Size(63, 63);
            this.previousScreenButton.TabIndex = 13;
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblPrice.Location = new System.Drawing.Point(3, 181);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(1084, 46);
            this.lblPrice.TabIndex = 16;
            this.lblPrice.Text = "Preço final:";
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPriceValue
            // 
            this.lblPriceValue.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblPriceValue.Location = new System.Drawing.Point(3, 233);
            this.lblPriceValue.Name = "lblPriceValue";
            this.lblPriceValue.Size = new System.Drawing.Size(1084, 46);
            this.lblPriceValue.TabIndex = 17;
            this.lblPriceValue.Text = "Preço final:";
            this.lblPriceValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblConclude
            // 
            this.lblConclude.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblConclude.Location = new System.Drawing.Point(3, 421);
            this.lblConclude.Name = "lblConclude";
            this.lblConclude.Size = new System.Drawing.Size(1084, 46);
            this.lblConclude.TabIndex = 18;
            this.lblConclude.Text = "Concluir criação do evento?";
            this.lblConclude.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShowPriceState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lblConclude);
            this.Controls.Add(this.lblPriceValue);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.nextScreenButton);
            this.Controls.Add(this.previousScreenButton);
            this.Name = "ShowPriceState";
            this.Size = new System.Drawing.Size(1090, 622);
            this.ResumeLayout(false);

        }

        #endregion

        private View.UserControls_Items.NextScreenButton nextScreenButton;
        private View.UserControls_Items.PreviousScreenButton previousScreenButton;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceValue;
        private System.Windows.Forms.Label lblConclude;
    }
}
