namespace FIghter__MP_HP_Calculator
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lvnow = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mpnow = new System.Windows.Forms.TextBox();
            this.intnow = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hpmax = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.hpnow = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.finallv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.deltamp = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.skillpoints = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.mpneeded = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.hpneeded = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.deltahp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.hpgain = new System.Windows.Forms.TextBox();
            this.deltalv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.costs = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(801, 440);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lv Now";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lvnow
            // 
            this.lvnow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvnow.Location = new System.Drawing.Point(0, 70);
            this.lvnow.Name = "lvnow";
            this.lvnow.Size = new System.Drawing.Size(107, 29);
            this.lvnow.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mpnow);
            this.groupBox1.Controls.Add(this.intnow);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.hpmax);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.hpnow);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lvnow);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 489);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // mpnow
            // 
            this.mpnow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.mpnow.Location = new System.Drawing.Point(6, 438);
            this.mpnow.Name = "mpnow";
            this.mpnow.Size = new System.Drawing.Size(100, 29);
            this.mpnow.TabIndex = 8;
            // 
            // intnow
            // 
            this.intnow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.intnow.Location = new System.Drawing.Point(6, 363);
            this.intnow.Name = "intnow";
            this.intnow.Size = new System.Drawing.Size(100, 29);
            this.intnow.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 317);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 22);
            this.label12.TabIndex = 6;
            this.label12.Text = "int Now";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(20, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "MP Now";
            // 
            // hpmax
            // 
            this.hpmax.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hpmax.Location = new System.Drawing.Point(6, 256);
            this.hpmax.Name = "hpmax";
            this.hpmax.Size = new System.Drawing.Size(100, 29);
            this.hpmax.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "HP you want @Lv200";
            // 
            // hpnow
            // 
            this.hpnow.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.hpnow.Location = new System.Drawing.Point(0, 154);
            this.hpnow.Name = "hpnow";
            this.hpnow.Size = new System.Drawing.Size(107, 29);
            this.hpnow.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "HP Now";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.finallv);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.deltamp);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.skillpoints);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.mpneeded);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.hpneeded);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.deltahp);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.hpgain);
            this.groupBox3.Controls.Add(this.deltalv);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(253, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(468, 489);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // finallv
            // 
            this.finallv.Location = new System.Drawing.Point(270, 363);
            this.finallv.Name = "finallv";
            this.finallv.ReadOnly = true;
            this.finallv.Size = new System.Drawing.Size(100, 29);
            this.finallv.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(289, 317);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 22);
            this.label14.TabIndex = 14;
            this.label14.Text = "Final Lv";
            // 
            // deltamp
            // 
            this.deltamp.Location = new System.Drawing.Point(22, 363);
            this.deltamp.Name = "deltamp";
            this.deltamp.ReadOnly = true;
            this.deltamp.Size = new System.Drawing.Size(100, 29);
            this.deltamp.TabIndex = 13;
            this.deltamp.TextChanged += new System.EventHandler(this.deltamp_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 317);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(104, 22);
            this.label13.TabIndex = 12;
            this.label13.Text = "ΔMP per Lv";
            // 
            // skillpoints
            // 
            this.skillpoints.Location = new System.Drawing.Point(270, 256);
            this.skillpoints.Name = "skillpoints";
            this.skillpoints.ReadOnly = true;
            this.skillpoints.Size = new System.Drawing.Size(100, 29);
            this.skillpoints.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(247, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(166, 22);
            this.label11.TabIndex = 10;
            this.label11.Text = "Skill Points needed";
            // 
            // mpneeded
            // 
            this.mpneeded.Location = new System.Drawing.Point(22, 256);
            this.mpneeded.Name = "mpneeded";
            this.mpneeded.ReadOnly = true;
            this.mpneeded.Size = new System.Drawing.Size(100, 29);
            this.mpneeded.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "MP needed";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // hpneeded
            // 
            this.hpneeded.Location = new System.Drawing.Point(270, 163);
            this.hpneeded.Name = "hpneeded";
            this.hpneeded.ReadOnly = true;
            this.hpneeded.Size = new System.Drawing.Size(100, 29);
            this.hpneeded.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(227, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "HP need to be gained";
            // 
            // deltahp
            // 
            this.deltahp.Location = new System.Drawing.Point(270, 67);
            this.deltahp.Name = "deltahp";
            this.deltahp.ReadOnly = true;
            this.deltahp.Size = new System.Drawing.Size(100, 29);
            this.deltahp.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(299, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "ΔHP";
            // 
            // hpgain
            // 
            this.hpgain.Location = new System.Drawing.Point(22, 163);
            this.hpgain.Name = "hpgain";
            this.hpgain.ReadOnly = true;
            this.hpgain.Size = new System.Drawing.Size(100, 29);
            this.hpgain.TabIndex = 3;
            // 
            // deltalv
            // 
            this.deltalv.Location = new System.Drawing.Point(22, 70);
            this.deltalv.Name = "deltalv";
            this.deltalv.ReadOnly = true;
            this.deltalv.Size = new System.Drawing.Size(100, 29);
            this.deltalv.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "HP gain based on ΔLv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "ΔLv";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 517);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(530, 46);
            this.label9.TabIndex = 6;
            this.label9.Text = "Autor: Shukang Zhang @ Raspberry\r\nCopyright Notice: Software are licensed under B" +
    "Y-NC-SA unless stating additionally. \r\nStatic based on @ V079 明日谷 Maplestory";
            this.label9.UseCompatibleTextRendering = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(815, 212);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(63, 26);
            this.label15.TabIndex = 7;
            this.label15.Text = "Costs";
            // 
            // costs
            // 
            this.costs.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.costs.Location = new System.Drawing.Point(800, 291);
            this.costs.Name = "costs";
            this.costs.ReadOnly = true;
            this.costs.Size = new System.Drawing.Size(100, 33);
            this.costs.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(907, 294);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(24, 26);
            this.label16.TabIndex = 9;
            this.label16.Text = "€";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 572);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.costs);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "战士洗血计算器@Raspberry";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lvnow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox hpnow;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hpmax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox hpneeded;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox deltahp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox hpgain;
        private System.Windows.Forms.TextBox deltalv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox intnow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox deltamp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox skillpoints;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox mpneeded;
        private System.Windows.Forms.TextBox finallv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox costs;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox mpnow;
    }
}

