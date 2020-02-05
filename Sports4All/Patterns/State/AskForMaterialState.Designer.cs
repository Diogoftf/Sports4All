namespace Sports4All.Patterns.State
{
    partial class AskForMaterialState
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
            this.lblQuestionMaterial = new System.Windows.Forms.Label();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // nextScreenButton
            // 
            this.nextScreenButton.Location = new System.Drawing.Point(1024, 556);
            this.nextScreenButton.Name = "nextScreenButton";
            this.nextScreenButton.ReserveNoviceForm = null;
            this.nextScreenButton.Size = new System.Drawing.Size(63, 63);
            this.nextScreenButton.TabIndex = 8;
            // 
            // previousScreenButton
            // 
            this.previousScreenButton.Location = new System.Drawing.Point(3, 553);
            this.previousScreenButton.Name = "previousScreenButton";
            this.previousScreenButton.ReserveNoviceForm = null;
            this.previousScreenButton.Size = new System.Drawing.Size(63, 63);
            this.previousScreenButton.TabIndex = 7;
            // 
            // lblQuestionMaterial
            // 
            this.lblQuestionMaterial.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.lblQuestionMaterial.Location = new System.Drawing.Point(3, 199);
            this.lblQuestionMaterial.Name = "lblQuestionMaterial";
            this.lblQuestionMaterial.Size = new System.Drawing.Size(1084, 46);
            this.lblQuestionMaterial.TabIndex = 9;
            this.lblQuestionMaterial.Text = "Pretende alugar material desportivo?";
            this.lblQuestionMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.rbNo.Location = new System.Drawing.Point(490, 275);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(78, 29);
            this.rbNo.TabIndex = 10;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "Não";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Font = new System.Drawing.Font("Century Gothic", 13F);
            this.rbYes.Location = new System.Drawing.Point(490, 325);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(70, 29);
            this.rbYes.TabIndex = 11;
            this.rbYes.Text = "Sim";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // AskForMaterialState
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.rbYes);
            this.Controls.Add(this.rbNo);
            this.Controls.Add(this.lblQuestionMaterial);
            this.Controls.Add(this.nextScreenButton);
            this.Controls.Add(this.previousScreenButton);
            this.Name = "AskForMaterialState";
            this.Size = new System.Drawing.Size(1090, 622);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private View.UserControls_Items.NextScreenButton nextScreenButton;
        private View.UserControls_Items.PreviousScreenButton previousScreenButton;
        private System.Windows.Forms.Label lblQuestionMaterial;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
    }
}
