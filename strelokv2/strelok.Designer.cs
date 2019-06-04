namespace strelokv2
{
    partial class Strelok
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Strelok));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.levelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.juniorshootingxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.battleshootingxyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейтингToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.attempt = new System.Windows.Forms.Label();
            this.hit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelToolStripMenuItem,
            this.ruleToolStripMenuItem,
            this.рейтингToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1170, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // levelToolStripMenuItem
            // 
            this.levelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.juniorshootingxyToolStripMenuItem,
            this.battleshootingxyToolStripMenuItem});
            this.levelToolStripMenuItem.Name = "levelToolStripMenuItem";
            this.levelToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.levelToolStripMenuItem.Text = "Уровень";
            // 
            // juniorshootingxyToolStripMenuItem
            // 
            this.juniorshootingxyToolStripMenuItem.Name = "juniorshootingxyToolStripMenuItem";
            this.juniorshootingxyToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.juniorshootingxyToolStripMenuItem.Text = "Учебная стрельба (x,y)";
            // 
            // battleshootingxyToolStripMenuItem
            // 
            this.battleshootingxyToolStripMenuItem.Enabled = false;
            this.battleshootingxyToolStripMenuItem.Name = "battleshootingxyToolStripMenuItem";
            this.battleshootingxyToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.battleshootingxyToolStripMenuItem.Text = "Боевая стрельба (x,y)";
            // 
            // ruleToolStripMenuItem
            // 
            this.ruleToolStripMenuItem.Name = "ruleToolStripMenuItem";
            this.ruleToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.ruleToolStripMenuItem.Text = "Руководтсво";
            this.ruleToolStripMenuItem.Click += new System.EventHandler(this.ruleToolStripMenuItem_Click);
            // 
            // рейтингToolStripMenuItem
            // 
            this.рейтингToolStripMenuItem.Name = "рейтингToolStripMenuItem";
            this.рейтингToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.рейтингToolStripMenuItem.Text = "Рейтинг";
            this.рейтингToolStripMenuItem.Click += new System.EventHandler(this.рейтингToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.exitToolStripMenuItem.Text = "Выход и сохранение";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 579);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Учебная стрельба (x,y)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 646);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(339, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Укажите координаты центра относительно глаза:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 667);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "x =";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(55, 667);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(80, 22);
            this.textBoxX.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 667);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "y =";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(174, 667);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(80, 22);
            this.textBoxY.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(274, 664);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Выстрел";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // attempt
            // 
            this.attempt.AutoSize = true;
            this.attempt.Location = new System.Drawing.Point(682, 646);
            this.attempt.Name = "attempt";
            this.attempt.Size = new System.Drawing.Size(66, 17);
            this.attempt.TabIndex = 10;
            this.attempt.Text = "Попытка";
            // 
            // hit
            // 
            this.hit.AutoSize = true;
            this.hit.Location = new System.Drawing.Point(682, 666);
            this.hit.Name = "hit";
            this.hit.Size = new System.Drawing.Size(82, 17);
            this.hit.TabIndex = 11;
            this.hit.Text = "Попаданий";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 699);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "размер области 800*460";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(309, 699);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(223, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "за единицу измерения берем 40";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(1044, 32);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(126, 29);
            this.labelLogin.TabIndex = 14;
            this.labelLogin.Text = "labelLogin";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            // 
            // Strelok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1170, 725);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.hit);
            this.Controls.Add(this.attempt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Strelok";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стрелок";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juniorshootingxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem battleshootingxyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label attempt;
        private System.Windows.Forms.Label hit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ToolStripMenuItem ruleToolStripMenuItem;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.ToolStripMenuItem рейтингToolStripMenuItem;
    }
}

