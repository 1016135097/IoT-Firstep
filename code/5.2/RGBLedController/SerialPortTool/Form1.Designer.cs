﻿namespace SerialPortTool
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.baudRateComboBox = new System.Windows.Forms.ComboBox();
            this.portComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.rTrackBar = new System.Windows.Forms.TrackBar();
            this.gTrackBar = new System.Windows.Forms.TrackBar();
            this.bTrackBar = new System.Windows.Forms.TrackBar();
            this.rLabel = new System.Windows.Forms.Label();
            this.gLabel = new System.Windows.Forms.Label();
            this.bLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // baudRateComboBox
            // 
            this.baudRateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.baudRateComboBox.FormattingEnabled = true;
            this.baudRateComboBox.Location = new System.Drawing.Point(72, 94);
            this.baudRateComboBox.Name = "baudRateComboBox";
            this.baudRateComboBox.Size = new System.Drawing.Size(96, 20);
            this.baudRateComboBox.TabIndex = 4;
            // 
            // portComboBox
            // 
            this.portComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portComboBox.FormattingEnabled = true;
            this.portComboBox.Location = new System.Drawing.Point(72, 38);
            this.portComboBox.Name = "portComboBox";
            this.portComboBox.Size = new System.Drawing.Size(96, 20);
            this.portComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "端口号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "波特率：";
            // 
            // openBtn
            // 
            this.openBtn.Location = new System.Drawing.Point(12, 146);
            this.openBtn.Name = "openBtn";
            this.openBtn.Size = new System.Drawing.Size(75, 23);
            this.openBtn.TabIndex = 8;
            this.openBtn.Text = "打开串口";
            this.openBtn.UseVisualStyleBackColor = true;
            this.openBtn.Click += new System.EventHandler(this.openBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(111, 146);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(75, 23);
            this.closeBtn.TabIndex = 9;
            this.closeBtn.Text = "关闭串口";
            this.closeBtn.UseVisualStyleBackColor = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // rTrackBar
            // 
            this.rTrackBar.Location = new System.Drawing.Point(228, 29);
            this.rTrackBar.Maximum = 49;
            this.rTrackBar.Name = "rTrackBar";
            this.rTrackBar.Size = new System.Drawing.Size(166, 45);
            this.rTrackBar.TabIndex = 11;
            this.rTrackBar.ValueChanged += new System.EventHandler(this.onTrackBarChanged);
            // 
            // gTrackBar
            // 
            this.gTrackBar.Location = new System.Drawing.Point(228, 80);
            this.gTrackBar.Maximum = 49;
            this.gTrackBar.Name = "gTrackBar";
            this.gTrackBar.Size = new System.Drawing.Size(166, 45);
            this.gTrackBar.TabIndex = 12;
            this.gTrackBar.ValueChanged += new System.EventHandler(this.onTrackBarChanged);
            // 
            // bTrackBar
            // 
            this.bTrackBar.Location = new System.Drawing.Point(228, 131);
            this.bTrackBar.Maximum = 49;
            this.bTrackBar.Name = "bTrackBar";
            this.bTrackBar.Size = new System.Drawing.Size(166, 45);
            this.bTrackBar.TabIndex = 13;
            this.bTrackBar.ValueChanged += new System.EventHandler(this.onTrackBarChanged);
            // 
            // rLabel
            // 
            this.rLabel.AutoSize = true;
            this.rLabel.Location = new System.Drawing.Point(285, 14);
            this.rLabel.Name = "rLabel";
            this.rLabel.Size = new System.Drawing.Size(41, 12);
            this.rLabel.TabIndex = 14;
            this.rLabel.Text = "rLabel";
            // 
            // gLabel
            // 
            this.gLabel.AutoSize = true;
            this.gLabel.Location = new System.Drawing.Point(285, 62);
            this.gLabel.Name = "gLabel";
            this.gLabel.Size = new System.Drawing.Size(41, 12);
            this.gLabel.TabIndex = 15;
            this.gLabel.Text = "gLabel";
            // 
            // bLabel
            // 
            this.bLabel.AutoSize = true;
            this.bLabel.Location = new System.Drawing.Point(285, 116);
            this.bLabel.Name = "bLabel";
            this.bLabel.Size = new System.Drawing.Size(41, 12);
            this.bLabel.TabIndex = 16;
            this.bLabel.Text = "bLabel";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 185);
            this.Controls.Add(this.bLabel);
            this.Controls.Add(this.gLabel);
            this.Controls.Add(this.rLabel);
            this.Controls.Add(this.bTrackBar);
            this.Controls.Add(this.gTrackBar);
            this.Controls.Add(this.rTrackBar);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.openBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portComboBox);
            this.Controls.Add(this.baudRateComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "RGB-LED测试";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox baudRateComboBox;
        private System.Windows.Forms.ComboBox portComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button openBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TrackBar rTrackBar;
        private System.Windows.Forms.TrackBar gTrackBar;
        private System.Windows.Forms.TrackBar bTrackBar;
        private System.Windows.Forms.Label rLabel;
        private System.Windows.Forms.Label gLabel;
        private System.Windows.Forms.Label bLabel;
    }
}

