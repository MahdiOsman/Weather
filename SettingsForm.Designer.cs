
namespace Weather
{
    partial class SettingsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.celciusRadioButton = new System.Windows.Forms.RadioButton();
            this.farenheitRadioButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Preferred Unit";
            // 
            // celciusRadioButton
            // 
            this.celciusRadioButton.AutoSize = true;
            this.celciusRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celciusRadioButton.Location = new System.Drawing.Point(188, 41);
            this.celciusRadioButton.Name = "celciusRadioButton";
            this.celciusRadioButton.Size = new System.Drawing.Size(130, 29);
            this.celciusRadioButton.TabIndex = 1;
            this.celciusRadioButton.TabStop = true;
            this.celciusRadioButton.Text = "Celcius °C";
            this.celciusRadioButton.UseVisualStyleBackColor = true;
            // 
            // farenheitRadioButton
            // 
            this.farenheitRadioButton.AutoSize = true;
            this.farenheitRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.farenheitRadioButton.Location = new System.Drawing.Point(188, 76);
            this.farenheitRadioButton.Name = "farenheitRadioButton";
            this.farenheitRadioButton.Size = new System.Drawing.Size(144, 29);
            this.farenheitRadioButton.TabIndex = 2;
            this.farenheitRadioButton.TabStop = true;
            this.farenheitRadioButton.Text = "Farenheit °F";
            this.farenheitRadioButton.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 160);
            this.Controls.Add(this.farenheitRadioButton);
            this.Controls.Add(this.celciusRadioButton);
            this.Controls.Add(this.label1);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton celciusRadioButton;
        private System.Windows.Forms.RadioButton farenheitRadioButton;
    }
}