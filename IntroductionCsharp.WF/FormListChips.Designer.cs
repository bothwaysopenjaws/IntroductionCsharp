namespace IntroductionCsharp.WF
{
    partial class FormListChips
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
            listBoxChips = new ListBox();
            SuspendLayout();
            // 
            // listBoxChips
            // 
            listBoxChips.FormattingEnabled = true;
            listBoxChips.ItemHeight = 15;
            listBoxChips.Location = new Point(22, 18);
            listBoxChips.Name = "listBoxChips";
            listBoxChips.Size = new Size(200, 409);
            listBoxChips.TabIndex = 0;
            // 
            // FormListChips
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxChips);
            Name = "FormListChips";
            Text = "FormListChips";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxChips;
    }
}