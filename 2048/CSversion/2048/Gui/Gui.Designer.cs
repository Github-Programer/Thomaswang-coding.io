namespace Gui
{
    partial class Gui
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gui));
            this.label_2048 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.best = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.score = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.newGame = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tile33 = new System.Windows.Forms.Label();
            this.tile23 = new System.Windows.Forms.Label();
            this.tile13 = new System.Windows.Forms.Label();
            this.tile03 = new System.Windows.Forms.Label();
            this.tile32 = new System.Windows.Forms.Label();
            this.tile22 = new System.Windows.Forms.Label();
            this.tile12 = new System.Windows.Forms.Label();
            this.tile02 = new System.Windows.Forms.Label();
            this.tile31 = new System.Windows.Forms.Label();
            this.tile21 = new System.Windows.Forms.Label();
            this.tile11 = new System.Windows.Forms.Label();
            this.tile01 = new System.Windows.Forms.Label();
            this.tile30 = new System.Windows.Forms.Label();
            this.tile20 = new System.Windows.Forms.Label();
            this.tile10 = new System.Windows.Forms.Label();
            this.tile00 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_2048
            // 
            this.label_2048.Font = new System.Drawing.Font("Impact", 50F, System.Drawing.FontStyle.Bold);
            this.label_2048.ForeColor = System.Drawing.Color.PeachPuff;
            this.label_2048.Location = new System.Drawing.Point(12, 9);
            this.label_2048.Name = "label_2048";
            this.label_2048.Size = new System.Drawing.Size(179, 126);
            this.label_2048.TabIndex = 0;
            this.label_2048.Text = "2048";
            this.label_2048.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_2048.Click += new System.EventHandler(this.label_2048_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.best);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(301, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(121, 63);
            this.panel1.TabIndex = 1;
            // 
            // best
            // 
            this.best.BackColor = System.Drawing.Color.Transparent;
            this.best.Font = new System.Drawing.Font("Impact", 18F);
            this.best.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.best.Location = new System.Drawing.Point(4, 35);
            this.best.Name = "best";
            this.best.Size = new System.Drawing.Size(112, 27);
            this.best.TabIndex = 2;
            this.best.Text = "0";
            this.best.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Impact", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(3, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Best";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.score);
            this.panel2.Controls.Add(this.label);
            this.panel2.Location = new System.Drawing.Point(211, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(84, 63);
            this.panel2.TabIndex = 2;
            // 
            // score
            // 
            this.score.BackColor = System.Drawing.Color.Transparent;
            this.score.Font = new System.Drawing.Font("Impact", 18F);
            this.score.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.score.Location = new System.Drawing.Point(1, 34);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(80, 27);
            this.score.TabIndex = 1;
            this.score.Text = "0";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Impact", 20F);
            this.label.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label.Location = new System.Drawing.Point(1, 1);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 34);
            this.label.TabIndex = 0;
            this.label.Text = "Score";
            // 
            // newGame
            // 
            this.newGame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.newGame.FlatAppearance.BorderSize = 0;
            this.newGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGame.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGame.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newGame.Location = new System.Drawing.Point(301, 88);
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(121, 29);
            this.newGame.TabIndex = 3;
            this.newGame.Text = "New Game";
            this.newGame.UseVisualStyleBackColor = false;
            this.newGame.Click += new System.EventHandler(this.newGame_Click);
            // 
            // help
            // 
            this.help.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.help.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.help.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.help.Location = new System.Drawing.Point(211, 88);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(84, 29);
            this.help.TabIndex = 4;
            this.help.Text = "Help";
            this.help.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.help.Click += new System.EventHandler(this.help_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.tile33);
            this.panel3.Controls.Add(this.tile23);
            this.panel3.Controls.Add(this.tile13);
            this.panel3.Controls.Add(this.tile03);
            this.panel3.Controls.Add(this.tile32);
            this.panel3.Controls.Add(this.tile22);
            this.panel3.Controls.Add(this.tile12);
            this.panel3.Controls.Add(this.tile02);
            this.panel3.Controls.Add(this.tile31);
            this.panel3.Controls.Add(this.tile21);
            this.panel3.Controls.Add(this.tile11);
            this.panel3.Controls.Add(this.tile01);
            this.panel3.Controls.Add(this.tile30);
            this.panel3.Controls.Add(this.tile20);
            this.panel3.Controls.Add(this.tile10);
            this.panel3.Controls.Add(this.tile00);
            this.panel3.Location = new System.Drawing.Point(29, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(393, 413);
            this.panel3.TabIndex = 5;
            // 
            // tile33
            // 
            this.tile33.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile33.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile33.Font = new System.Drawing.Font("Impact", 20F);
            this.tile33.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile33.Location = new System.Drawing.Point(289, 308);
            this.tile33.Name = "tile33";
            this.tile33.Size = new System.Drawing.Size(85, 85);
            this.tile33.TabIndex = 2;
            this.tile33.Text = "0";
            this.tile33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile33.Visible = false;
            // 
            // tile23
            // 
            this.tile23.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile23.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile23.Font = new System.Drawing.Font("Impact", 20F);
            this.tile23.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile23.Location = new System.Drawing.Point(289, 209);
            this.tile23.Name = "tile23";
            this.tile23.Size = new System.Drawing.Size(85, 85);
            this.tile23.TabIndex = 2;
            this.tile23.Text = "0";
            this.tile23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile23.Visible = false;
            // 
            // tile13
            // 
            this.tile13.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile13.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile13.Font = new System.Drawing.Font("Impact", 20F);
            this.tile13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile13.Location = new System.Drawing.Point(289, 111);
            this.tile13.Name = "tile13";
            this.tile13.Size = new System.Drawing.Size(85, 85);
            this.tile13.TabIndex = 2;
            this.tile13.Text = "0";
            this.tile13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile13.Visible = false;
            // 
            // tile03
            // 
            this.tile03.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile03.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile03.Font = new System.Drawing.Font("Impact", 20F);
            this.tile03.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile03.Location = new System.Drawing.Point(289, 12);
            this.tile03.Name = "tile03";
            this.tile03.Size = new System.Drawing.Size(85, 85);
            this.tile03.TabIndex = 2;
            this.tile03.Text = "0";
            this.tile03.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile03.Visible = false;
            // 
            // tile32
            // 
            this.tile32.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile32.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile32.Font = new System.Drawing.Font("Impact", 20F);
            this.tile32.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile32.Location = new System.Drawing.Point(198, 308);
            this.tile32.Name = "tile32";
            this.tile32.Size = new System.Drawing.Size(85, 85);
            this.tile32.TabIndex = 1;
            this.tile32.Text = "0";
            this.tile32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile32.Visible = false;
            // 
            // tile22
            // 
            this.tile22.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile22.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile22.Font = new System.Drawing.Font("Impact", 20F);
            this.tile22.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile22.Location = new System.Drawing.Point(198, 209);
            this.tile22.Name = "tile22";
            this.tile22.Size = new System.Drawing.Size(85, 85);
            this.tile22.TabIndex = 1;
            this.tile22.Text = "0";
            this.tile22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile22.Visible = false;
            // 
            // tile12
            // 
            this.tile12.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile12.Font = new System.Drawing.Font("Impact", 20F);
            this.tile12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile12.Location = new System.Drawing.Point(198, 111);
            this.tile12.Name = "tile12";
            this.tile12.Size = new System.Drawing.Size(85, 85);
            this.tile12.TabIndex = 1;
            this.tile12.Text = "0";
            this.tile12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile12.Visible = false;
            // 
            // tile02
            // 
            this.tile02.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile02.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile02.Font = new System.Drawing.Font("Impact", 20F);
            this.tile02.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile02.Location = new System.Drawing.Point(198, 12);
            this.tile02.Name = "tile02";
            this.tile02.Size = new System.Drawing.Size(85, 85);
            this.tile02.TabIndex = 1;
            this.tile02.Text = "0";
            this.tile02.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile02.Visible = false;
            // 
            // tile31
            // 
            this.tile31.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile31.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile31.Font = new System.Drawing.Font("Impact", 20F);
            this.tile31.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile31.Location = new System.Drawing.Point(107, 308);
            this.tile31.Name = "tile31";
            this.tile31.Size = new System.Drawing.Size(85, 85);
            this.tile31.TabIndex = 1;
            this.tile31.Text = "0";
            this.tile31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile31.Visible = false;
            // 
            // tile21
            // 
            this.tile21.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile21.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile21.Font = new System.Drawing.Font("Impact", 20F);
            this.tile21.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile21.Location = new System.Drawing.Point(107, 209);
            this.tile21.Name = "tile21";
            this.tile21.Size = new System.Drawing.Size(85, 85);
            this.tile21.TabIndex = 1;
            this.tile21.Text = "0";
            this.tile21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile21.Visible = false;
            // 
            // tile11
            // 
            this.tile11.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile11.Font = new System.Drawing.Font("Impact", 20F);
            this.tile11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile11.Location = new System.Drawing.Point(107, 111);
            this.tile11.Name = "tile11";
            this.tile11.Size = new System.Drawing.Size(85, 85);
            this.tile11.TabIndex = 1;
            this.tile11.Text = "0";
            this.tile11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile11.Visible = false;
            // 
            // tile01
            // 
            this.tile01.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile01.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile01.Font = new System.Drawing.Font("Impact", 20F);
            this.tile01.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile01.Location = new System.Drawing.Point(107, 12);
            this.tile01.Name = "tile01";
            this.tile01.Size = new System.Drawing.Size(85, 85);
            this.tile01.TabIndex = 1;
            this.tile01.Text = "0";
            this.tile01.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile01.Visible = false;
            // 
            // tile30
            // 
            this.tile30.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile30.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile30.Font = new System.Drawing.Font("Impact", 20F);
            this.tile30.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile30.Location = new System.Drawing.Point(16, 308);
            this.tile30.Name = "tile30";
            this.tile30.Size = new System.Drawing.Size(85, 85);
            this.tile30.TabIndex = 0;
            this.tile30.Text = "0";
            this.tile30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile30.Visible = false;
            // 
            // tile20
            // 
            this.tile20.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile20.Font = new System.Drawing.Font("Impact", 20F);
            this.tile20.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile20.Location = new System.Drawing.Point(16, 209);
            this.tile20.Name = "tile20";
            this.tile20.Size = new System.Drawing.Size(85, 85);
            this.tile20.TabIndex = 0;
            this.tile20.Text = "0";
            this.tile20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile20.Visible = false;
            // 
            // tile10
            // 
            this.tile10.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile10.Font = new System.Drawing.Font("Impact", 20F);
            this.tile10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile10.Location = new System.Drawing.Point(16, 111);
            this.tile10.Name = "tile10";
            this.tile10.Size = new System.Drawing.Size(85, 85);
            this.tile10.TabIndex = 0;
            this.tile10.Text = "0";
            this.tile10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile10.Visible = false;
            // 
            // tile00
            // 
            this.tile00.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tile00.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.tile00.Font = new System.Drawing.Font("Impact", 20F);
            this.tile00.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tile00.Location = new System.Drawing.Point(16, 12);
            this.tile00.Name = "tile00";
            this.tile00.Size = new System.Drawing.Size(85, 85);
            this.tile00.TabIndex = 0;
            this.tile00.Text = "0";
            this.tile00.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tile00.Visible = false;
            // 
            // Gui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(452, 571);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.help);
            this.Controls.Add(this.newGame);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label_2048);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Gui";
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gui_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_2048;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label best;
        private System.Windows.Forms.Button newGame;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label tile00;
        private System.Windows.Forms.Label tile03;
        private System.Windows.Forms.Label tile02;
        private System.Windows.Forms.Label tile01;
        private System.Windows.Forms.Label tile33;
        private System.Windows.Forms.Label tile23;
        private System.Windows.Forms.Label tile13;
        private System.Windows.Forms.Label tile32;
        private System.Windows.Forms.Label tile22;
        private System.Windows.Forms.Label tile12;
        private System.Windows.Forms.Label tile31;
        private System.Windows.Forms.Label tile21;
        private System.Windows.Forms.Label tile11;
        private System.Windows.Forms.Label tile30;
        private System.Windows.Forms.Label tile20;
        private System.Windows.Forms.Label tile10;
    }
}

