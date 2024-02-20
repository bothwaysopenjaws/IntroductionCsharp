namespace IntroductionCsharp.WF
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
            label1 = new Label();
            button1 = new Button();
            buttonOpenWindowList = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 40F);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(330, 106);
            label1.Name = "label1";
            label1.Size = new Size(185, 72);
            label1.TabIndex = 0;
            label1.Text = "ZI APP";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Location = new Point(661, 2);
            button1.Name = "button1";
            button1.Size = new Size(136, 39);
            button1.TabIndex = 1;
            button1.Text = "Changement de thème";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonOpenWindowList
            // 
            buttonOpenWindowList.Location = new Point(115, 208);
            buttonOpenWindowList.Name = "buttonOpenWindowList";
            buttonOpenWindowList.Size = new Size(137, 41);
            buttonOpenWindowList.TabIndex = 2;
            buttonOpenWindowList.Text = "Liste des chips";
            buttonOpenWindowList.UseVisualStyleBackColor = true;
            buttonOpenWindowList.Click += buttonOpenWindowList_Click;
            // 
            // button2
            // 
            button2.Location = new Point(503, 209);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 3;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Chartreuse;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(buttonOpenWindowList);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Ma super fenêtre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button buttonOpenWindowList;
        private Button button2;
    }
}
