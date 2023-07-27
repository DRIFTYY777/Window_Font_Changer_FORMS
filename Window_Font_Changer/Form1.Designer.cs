namespace Window_Font_Changer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Select_text_btn = new System.Windows.Forms.Button();
            this.Fonts_List = new System.Windows.Forms.ListBox();
            this.Done = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Select_text_btn
            // 
            this.Select_text_btn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Select_text_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Select_text_btn.Location = new System.Drawing.Point(12, 12);
            this.Select_text_btn.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Select_text_btn.Name = "Select_text_btn";
            this.Select_text_btn.Size = new System.Drawing.Size(212, 26);
            this.Select_text_btn.TabIndex = 0;
            this.Select_text_btn.Text = "Load Font";
            this.Select_text_btn.UseVisualStyleBackColor = false;
            this.Select_text_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Fonts_List
            // 
            this.Fonts_List.FormattingEnabled = true;
            this.Fonts_List.ItemHeight = 16;
            this.Fonts_List.Location = new System.Drawing.Point(12, 44);
            this.Fonts_List.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Fonts_List.Name = "Fonts_List";
            this.Fonts_List.Size = new System.Drawing.Size(212, 484);
            this.Fonts_List.TabIndex = 1;
            // 
            // Done
            // 
            this.Done.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Done.Location = new System.Drawing.Point(12, 534);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(212, 29);
            this.Done.TabIndex = 2;
            this.Done.Text = "Change";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(239, 575);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Fonts_List);
            this.Controls.Add(this.Select_text_btn);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Change Window Font";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Select_text_btn;
        private ListBox Fonts_List;
        private Button Done;
    }
}