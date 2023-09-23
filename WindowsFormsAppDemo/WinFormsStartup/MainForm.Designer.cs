namespace WinFormsStartup
{
    partial class MainForm
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
            firstNameLabel = new Label();
            firstNameText = new TextBox();
            sayHelloButton = new Button();
            lastNameText = new TextBox();
            lastNameLabel = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(197, 101);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(102, 25);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // firstNameText
            // 
            firstNameText.Location = new Point(330, 98);
            firstNameText.Name = "firstNameText";
            firstNameText.Size = new Size(227, 33);
            firstNameText.TabIndex = 1;
            // 
            // sayHelloButton
            // 
            sayHelloButton.Location = new Point(307, 298);
            sayHelloButton.Name = "sayHelloButton";
            sayHelloButton.Size = new Size(185, 80);
            sayHelloButton.TabIndex = 3;
            sayHelloButton.Text = "Say Hello";
            sayHelloButton.UseVisualStyleBackColor = true;
            sayHelloButton.Click += sayHelloButton_Click;
            // 
            // lastNameText
            // 
            lastNameText.Location = new Point(330, 163);
            lastNameText.Name = "lastNameText";
            lastNameText.Size = new Size(227, 33);
            lastNameText.TabIndex = 2;
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(197, 166);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(100, 25);
            lastNameLabel.TabIndex = 0;
            lastNameLabel.Text = "Last Name";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(771, 492);
            Controls.Add(lastNameText);
            Controls.Add(lastNameLabel);
            Controls.Add(sayHelloButton);
            Controls.Add(firstNameText);
            Controls.Add(firstNameLabel);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "MainForm";
            Text = "Main Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label firstNameLabel;
        private TextBox firstNameText;
        private Button sayHelloButton;
        private TextBox lastNameText;
        private Label lastNameLabel;
    }
}