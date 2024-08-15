namespace consumindoAPISimples
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            txtID = new TextBox();
            txtUserName = new TextBox();
            txtEmail = new TextBox();
            txtIdade = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button8 = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(704, 77);
            button2.Name = "button2";
            button2.Size = new Size(196, 54);
            button2.TabIndex = 1;
            button2.Text = "Buscar por email";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(704, 137);
            button3.Name = "button3";
            button3.Size = new Size(196, 54);
            button3.TabIndex = 2;
            button3.Text = "Buscar por email com senha";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(704, 197);
            button4.Name = "button4";
            button4.Size = new Size(196, 54);
            button4.TabIndex = 3;
            button4.Text = "Criar User";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(704, 257);
            button5.Name = "button5";
            button5.Size = new Size(196, 54);
            button5.TabIndex = 4;
            button5.Text = "Deletar por email";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(704, 317);
            button6.Name = "button6";
            button6.Size = new Size(196, 54);
            button6.TabIndex = 5;
            button6.Text = "Atualizar";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(704, 377);
            button7.Name = "button7";
            button7.Size = new Size(196, 54);
            button7.TabIndex = 6;
            button7.Text = "Atualizar senha";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(23, 61);
            txtID.Name = "txtID";
            txtID.Size = new Size(636, 27);
            txtID.TabIndex = 7;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(23, 154);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(636, 27);
            txtUserName.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(23, 241);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(636, 27);
            txtEmail.TabIndex = 9;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(23, 324);
            txtIdade.Multiline = true;
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(636, 27);
            txtIdade.TabIndex = 10;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(23, 408);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(636, 27);
            txtPassword.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(313, 25);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 12;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(313, 111);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 13;
            label2.Text = "UserName";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 201);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 14;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(313, 291);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 15;
            label4.Text = "Idade";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(313, 368);
            label5.Name = "label5";
            label5.Size = new Size(104, 20);
            label5.TabIndex = 16;
            label5.Text = "PasswordCRYP";
            // 
            // button8
            // 
            button8.Location = new Point(239, 461);
            button8.Name = "button8";
            button8.Size = new Size(196, 54);
            button8.TabIndex = 17;
            button8.Text = "Clear";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(955, 540);
            Controls.Add(button8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtIdade);
            Controls.Add(txtEmail);
            Controls.Add(txtUserName);
            Controls.Add(txtID);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private TextBox txtID;
        private TextBox txtUserName;
        private TextBox txtEmail;
        private TextBox txtIdade;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button8;
    }
}
