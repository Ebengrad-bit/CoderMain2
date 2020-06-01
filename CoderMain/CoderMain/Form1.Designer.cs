namespace CoderMain
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.NormalTextB = new System.Windows.Forms.TextBox();
            this.CodedTextB = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DecodingBtn = new System.Windows.Forms.RadioButton();
            this.KodingBtn = new System.Windows.Forms.RadioButton();
            this.KeyTextB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StartBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.OpendCodeText = new System.Windows.Forms.TextBox();
            this.ClosedCodeText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // NormalTextB
            // 
            this.NormalTextB.Location = new System.Drawing.Point(12, 12);
            this.NormalTextB.Multiline = true;
            this.NormalTextB.Name = "NormalTextB";
            this.NormalTextB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NormalTextB.Size = new System.Drawing.Size(252, 399);
            this.NormalTextB.TabIndex = 0;
            // 
            // CodedTextB
            // 
            this.CodedTextB.Location = new System.Drawing.Point(270, 12);
            this.CodedTextB.Multiline = true;
            this.CodedTextB.Name = "CodedTextB";
            this.CodedTextB.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CodedTextB.Size = new System.Drawing.Size(252, 399);
            this.CodedTextB.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DecodingBtn);
            this.groupBox1.Controls.Add(this.KodingBtn);
            this.groupBox1.Location = new System.Drawing.Point(528, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(170, 66);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим";
            // 
            // DecodingBtn
            // 
            this.DecodingBtn.Location = new System.Drawing.Point(6, 42);
            this.DecodingBtn.Name = "DecodingBtn";
            this.DecodingBtn.Size = new System.Drawing.Size(104, 24);
            this.DecodingBtn.TabIndex = 1;
            this.DecodingBtn.Text = "Декодировка";
            this.DecodingBtn.UseVisualStyleBackColor = true;
            this.DecodingBtn.CheckedChanged += new System.EventHandler(this.DecodingBtn_CheckedChanged);
            // 
            // KodingBtn
            // 
            this.KodingBtn.AutoSize = true;
            this.KodingBtn.Location = new System.Drawing.Point(6, 19);
            this.KodingBtn.Name = "KodingBtn";
            this.KodingBtn.Size = new System.Drawing.Size(80, 17);
            this.KodingBtn.TabIndex = 0;
            this.KodingBtn.Text = "Кодировка";
            this.KodingBtn.UseVisualStyleBackColor = true;
            this.KodingBtn.CheckedChanged += new System.EventHandler(this.KodingBtn_CheckedChanged);
            // 
            // KeyTextB
            // 
            this.KeyTextB.Location = new System.Drawing.Point(528, 12);
            this.KeyTextB.Name = "KeyTextB";
            this.KeyTextB.Size = new System.Drawing.Size(170, 20);
            this.KeyTextB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(704, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ключ";
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(528, 110);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 5;
            this.StartBtn.Text = "Начать";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(528, 379);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(75, 23);
            this.LoadBtn.TabIndex = 6;
            this.LoadBtn.Text = "Загрузка";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(623, 379);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Сохранение";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Location = new System.Drawing.Point(528, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(219, 114);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(47, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "RSA";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "DES";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(48, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "XOR";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // OpendCodeText
            // 
            this.OpendCodeText.Location = new System.Drawing.Point(528, 272);
            this.OpendCodeText.Name = "OpendCodeText";
            this.OpendCodeText.Size = new System.Drawing.Size(100, 20);
            this.OpendCodeText.TabIndex = 3;
            // 
            // ClosedCodeText
            // 
            this.ClosedCodeText.Location = new System.Drawing.Point(647, 272);
            this.ClosedCodeText.Name = "ClosedCodeText";
            this.ClosedCodeText.Size = new System.Drawing.Size(100, 20);
            this.ClosedCodeText.TabIndex = 9;
            this.ClosedCodeText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Открытый код";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Закрытый код";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 414);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ClosedCodeText);
            this.Controls.Add(this.OpendCodeText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KeyTextB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CodedTextB);
            this.Controls.Add(this.NormalTextB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NormalTextB;
        private System.Windows.Forms.TextBox CodedTextB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox KeyTextB;
        private System.Windows.Forms.RadioButton DecodingBtn;
        private System.Windows.Forms.RadioButton KodingBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox OpendCodeText;
        private System.Windows.Forms.TextBox ClosedCodeText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

