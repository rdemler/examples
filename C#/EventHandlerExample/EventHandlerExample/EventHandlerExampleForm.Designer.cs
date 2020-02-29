namespace EventHandlerExample
{
    partial class EventHandlerExampleForm
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
            this.FirstCheck = new System.Windows.Forms.CheckBox();
            this.SecondCheck = new System.Windows.Forms.CheckBox();
            this.ThirdCheck = new System.Windows.Forms.CheckBox();
            this.FourthCheck = new System.Windows.Forms.CheckBox();
            this.FifthCheck = new System.Windows.Forms.CheckBox();
            this.DisplayLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FirstCheck
            // 
            this.FirstCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FirstCheck.AutoSize = true;
            this.FirstCheck.Location = new System.Drawing.Point(121, 283);
            this.FirstCheck.Name = "FirstCheck";
            this.FirstCheck.Size = new System.Drawing.Size(45, 17);
            this.FirstCheck.TabIndex = 0;
            this.FirstCheck.Text = "First";
            this.FirstCheck.UseVisualStyleBackColor = true;
            // 
            // SecondCheck
            // 
            this.SecondCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SecondCheck.AutoSize = true;
            this.SecondCheck.Location = new System.Drawing.Point(258, 283);
            this.SecondCheck.Name = "SecondCheck";
            this.SecondCheck.Size = new System.Drawing.Size(63, 17);
            this.SecondCheck.TabIndex = 0;
            this.SecondCheck.Text = "Second";
            this.SecondCheck.UseVisualStyleBackColor = true;
            // 
            // ThirdCheck
            // 
            this.ThirdCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ThirdCheck.AutoSize = true;
            this.ThirdCheck.Location = new System.Drawing.Point(395, 283);
            this.ThirdCheck.Name = "ThirdCheck";
            this.ThirdCheck.Size = new System.Drawing.Size(50, 17);
            this.ThirdCheck.TabIndex = 0;
            this.ThirdCheck.Text = "Third";
            this.ThirdCheck.UseVisualStyleBackColor = true;
            // 
            // FourthCheck
            // 
            this.FourthCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FourthCheck.AutoSize = true;
            this.FourthCheck.Location = new System.Drawing.Point(532, 283);
            this.FourthCheck.Name = "FourthCheck";
            this.FourthCheck.Size = new System.Drawing.Size(56, 17);
            this.FourthCheck.TabIndex = 0;
            this.FourthCheck.Text = "Fourth";
            this.FourthCheck.UseVisualStyleBackColor = true;
            // 
            // FifthCheck
            // 
            this.FifthCheck.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FifthCheck.AutoSize = true;
            this.FifthCheck.Location = new System.Drawing.Point(669, 283);
            this.FifthCheck.Name = "FifthCheck";
            this.FifthCheck.Size = new System.Drawing.Size(46, 17);
            this.FifthCheck.TabIndex = 0;
            this.FifthCheck.Text = "Fifth";
            this.FifthCheck.UseVisualStyleBackColor = true;
            // 
            // DisplayLabel
            // 
            this.DisplayLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DisplayLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DisplayLabel.Location = new System.Drawing.Point(198, 80);
            this.DisplayLabel.Name = "DisplayLabel";
            this.DisplayLabel.Size = new System.Drawing.Size(449, 162);
            this.DisplayLabel.TabIndex = 1;
            this.DisplayLabel.Text = "Check a thing";
            this.DisplayLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 349);
            this.Controls.Add(this.DisplayLabel);
            this.Controls.Add(this.FifthCheck);
            this.Controls.Add(this.FourthCheck);
            this.Controls.Add(this.ThirdCheck);
            this.Controls.Add(this.SecondCheck);
            this.Controls.Add(this.FirstCheck);
            this.Name = "Form1";
            this.Text = "Checkbox Event Handlers";
            this.Load += new System.EventHandler(this.EventHandlerExampleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox FirstCheck;
        private System.Windows.Forms.CheckBox SecondCheck;
        private System.Windows.Forms.CheckBox ThirdCheck;
        private System.Windows.Forms.CheckBox FourthCheck;
        private System.Windows.Forms.CheckBox FifthCheck;
        private System.Windows.Forms.Label DisplayLabel;
    }
}

