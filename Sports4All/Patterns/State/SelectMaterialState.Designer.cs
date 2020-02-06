namespace Sports4All.Patterns.State
{
    partial class SelectMaterialState
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
            this.lblSelectMaterial = new System.Windows.Forms.Label();
            this.flpMaterial = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // nextScreenButton
            // 
            this.nextScreenButton.Location = new System.Drawing.Point(1024, 556);
            this.nextScreenButton.Name = "nextScreenButton";
            this.nextScreenButton.ReserveNoviceForm = null;
            this.nextScreenButton.Size = new System.Drawing.Size(63, 63);
            this.nextScreenButton.TabIndex = 10;
            this.nextScreenButton.Load += new System.EventHandler(this.nextScreenButton_Load);
            // 
            // previousScreenButton
            // 
            this.previousScreenButton.Location = new System.Drawing.Point(3, 556);
            this.previousScreenButton.Name = "previousScreenButton";
            this.previousScreenButton.ReserveNoviceForm = null;
            this.previousScreenButton.Size = new System.Drawing.Size(63, 63);
            this.previousScreenButton.TabIndex = 9;
            // 
            // lblSelectMaterial
            // 
            this.lblSelectMaterial.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblSelectMaterial.Location = new System.Drawing.Point(3, 177);
            this.lblSelectMaterial.Name = "lblSelectMaterial";
            this.lblSelectMaterial.Size = new System.Drawing.Size(1084, 46);
            this.lblSelectMaterial.TabIndex = 11;
            this.lblSelectMaterial.Text = "Escolha o material entre o disponível:";
            this.lblSelectMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flpMaterial
            // 
            this.flpMaterial.Location = new System.Drawing.Point(382, 236);
            this.flpMaterial.Name = "flpMaterial";
            this.flpMaterial.Size = new System.Drawing.Size(325, 152);
            this.flpMaterial.TabIndex = 13;
            // 
            // SelectMaterialState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.flpMaterial);
            this.Controls.Add(this.lblSelectMaterial);
            this.Controls.Add(this.nextScreenButton);
            this.Controls.Add(this.previousScreenButton);
            this.Name = "SelectMaterialState";
            this.Size = new System.Drawing.Size(1090, 622);
            this.Load += new System.EventHandler(this.SelectMaterialState_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private View.UserControls_Items.NextScreenButton nextScreenButton;
        private View.UserControls_Items.PreviousScreenButton previousScreenButton;
        private System.Windows.Forms.Label lblSelectMaterial;
        private System.Windows.Forms.FlowLayoutPanel flpMaterial;
    }
}
