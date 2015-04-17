namespace The_Veil
{
    partial class Veil
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
            this.label_Welcome = new System.Windows.Forms.Label();
            this.button_Start = new System.Windows.Forms.Button();
            this.button_HowTo = new System.Windows.Forms.Button();
            this.button_AboutTheVeil = new System.Windows.Forms.Button();
            this.panel_Welcome = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label_Welcome
            // 
            this.label_Welcome.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label_Welcome.AutoSize = true;
            this.label_Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Welcome.ForeColor = System.Drawing.Color.White;
            this.label_Welcome.Location = new System.Drawing.Point(77, 40);
            this.label_Welcome.Name = "label_Welcome";
            this.label_Welcome.Size = new System.Drawing.Size(1015, 108);
            this.label_Welcome.TabIndex = 0;
            this.label_Welcome.Text = "Welcome to \"The Veil\"";
            this.label_Welcome.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Veil_KeyPress);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Start.Location = new System.Drawing.Point(73, 357);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(242, 89);
            this.button_Start.TabIndex = 1;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            this.button_Start.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Veil_KeyPress);
            // 
            // button_HowTo
            // 
            this.button_HowTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HowTo.Location = new System.Drawing.Point(409, 357);
            this.button_HowTo.Name = "button_HowTo";
            this.button_HowTo.Size = new System.Drawing.Size(325, 89);
            this.button_HowTo.TabIndex = 2;
            this.button_HowTo.Text = "How to";
            this.button_HowTo.UseVisualStyleBackColor = true;
            this.button_HowTo.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Veil_KeyPress);
            // 
            // button_AboutTheVeil
            // 
            this.button_AboutTheVeil.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AboutTheVeil.Location = new System.Drawing.Point(770, 357);
            this.button_AboutTheVeil.Name = "button_AboutTheVeil";
            this.button_AboutTheVeil.Size = new System.Drawing.Size(406, 89);
            this.button_AboutTheVeil.TabIndex = 3;
            this.button_AboutTheVeil.Text = "About \"The Veil\"";
            this.button_AboutTheVeil.UseVisualStyleBackColor = true;
            this.button_AboutTheVeil.Click += new System.EventHandler(this.button_AboutTheVeil_Click);
            this.button_AboutTheVeil.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Veil_KeyPress);
            // 
            // panel_Welcome
            // 
            this.panel_Welcome.Location = new System.Drawing.Point(437, 202);
            this.panel_Welcome.Name = "panel_Welcome";
            this.panel_Welcome.Size = new System.Drawing.Size(200, 100);
            this.panel_Welcome.TabIndex = 4;
            // 
            // Veil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1188, 615);
            this.Controls.Add(this.panel_Welcome);
            this.Controls.Add(this.button_AboutTheVeil);
            this.Controls.Add(this.button_HowTo);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.label_Welcome);
            this.Name = "Veil";
            this.Text = "The Veil";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Veil_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Welcome;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Button button_HowTo;
        private System.Windows.Forms.Button button_AboutTheVeil;
        private System.Windows.Forms.Panel panel_Welcome;

    }
}

