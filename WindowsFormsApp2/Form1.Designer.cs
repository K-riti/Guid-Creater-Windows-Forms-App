namespace WindowsFormsApp2
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
            this.labelresult = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttoncreateguid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Location = new System.Drawing.Point(217, 195);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(51, 20);
            this.labelresult.TabIndex = 0;
            this.labelresult.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(8, 8);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // buttoncreateguid
            // 
            this.buttoncreateguid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttoncreateguid.Location = new System.Drawing.Point(190, 75);
            this.buttoncreateguid.Name = "buttoncreateguid";
            this.buttoncreateguid.Size = new System.Drawing.Size(348, 46);
            this.buttoncreateguid.TabIndex = 2;
            this.buttoncreateguid.Text = "Click here to create a Guid";
            this.buttoncreateguid.UseVisualStyleBackColor = true;
            this.buttoncreateguid.Click += new System.EventHandler(this.buttoncreateguid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttoncreateguid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelresult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttoncreateguid;
    }
}

