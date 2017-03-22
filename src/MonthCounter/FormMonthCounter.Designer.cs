namespace MonthCounter
{
    partial class formMonthCounter
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMonthCounter));
            this.buttonTodayCountUp = new System.Windows.Forms.Button();
            this.buttonTodayCountDown = new System.Windows.Forms.Button();
            this.textBoxTodayCount = new System.Windows.Forms.TextBox();
            this.labelToday = new System.Windows.Forms.Label();
            this.labelYesterday = new System.Windows.Forms.Label();
            this.textBoxYesterdayCount = new System.Windows.Forms.TextBox();
            this.buttonYesterdayCountDown = new System.Windows.Forms.Button();
            this.buttonYesterdayCountUp = new System.Windows.Forms.Button();
            this.labelMonth = new System.Windows.Forms.Label();
            this.textBoxMonthCount = new System.Windows.Forms.TextBox();
            this.buttonMonthCountDown = new System.Windows.Forms.Button();
            this.buttonMonthCountUp = new System.Windows.Forms.Button();
            this.labelDate = new System.Windows.Forms.Label();
            this.timerCheckDate = new System.Windows.Forms.Timer(this.components);
            this.checkBoxTopMost = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonTodayCountUp
            // 
            this.buttonTodayCountUp.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonTodayCountUp.Location = new System.Drawing.Point(12, 52);
            this.buttonTodayCountUp.Name = "buttonTodayCountUp";
            this.buttonTodayCountUp.Size = new System.Drawing.Size(83, 31);
            this.buttonTodayCountUp.TabIndex = 2;
            this.buttonTodayCountUp.Text = "+1";
            this.buttonTodayCountUp.UseVisualStyleBackColor = true;
            this.buttonTodayCountUp.Click += new System.EventHandler(this.buttonTodayCountUp_Click);
            // 
            // buttonTodayCountDown
            // 
            this.buttonTodayCountDown.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonTodayCountDown.Location = new System.Drawing.Point(12, 120);
            this.buttonTodayCountDown.Name = "buttonTodayCountDown";
            this.buttonTodayCountDown.Size = new System.Drawing.Size(83, 31);
            this.buttonTodayCountDown.TabIndex = 4;
            this.buttonTodayCountDown.Text = "-1";
            this.buttonTodayCountDown.UseVisualStyleBackColor = true;
            this.buttonTodayCountDown.Click += new System.EventHandler(this.buttonTodayCountDown_Click);
            // 
            // textBoxTodayCount
            // 
            this.textBoxTodayCount.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxTodayCount.Location = new System.Drawing.Point(28, 89);
            this.textBoxTodayCount.Name = "textBoxTodayCount";
            this.textBoxTodayCount.ReadOnly = true;
            this.textBoxTodayCount.Size = new System.Drawing.Size(50, 25);
            this.textBoxTodayCount.TabIndex = 3;
            this.textBoxTodayCount.Text = "0000";
            this.textBoxTodayCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelToday
            // 
            this.labelToday.AutoSize = true;
            this.labelToday.Location = new System.Drawing.Point(35, 34);
            this.labelToday.Name = "labelToday";
            this.labelToday.Size = new System.Drawing.Size(37, 15);
            this.labelToday.TabIndex = 1;
            this.labelToday.Text = "今日";
            // 
            // labelYesterday
            // 
            this.labelYesterday.AutoSize = true;
            this.labelYesterday.Location = new System.Drawing.Point(138, 34);
            this.labelYesterday.Name = "labelYesterday";
            this.labelYesterday.Size = new System.Drawing.Size(37, 15);
            this.labelYesterday.TabIndex = 5;
            this.labelYesterday.Text = "昨日";
            // 
            // textBoxYesterdayCount
            // 
            this.textBoxYesterdayCount.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxYesterdayCount.Location = new System.Drawing.Point(131, 89);
            this.textBoxYesterdayCount.Name = "textBoxYesterdayCount";
            this.textBoxYesterdayCount.ReadOnly = true;
            this.textBoxYesterdayCount.Size = new System.Drawing.Size(50, 25);
            this.textBoxYesterdayCount.TabIndex = 7;
            this.textBoxYesterdayCount.Text = "0000";
            this.textBoxYesterdayCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonYesterdayCountDown
            // 
            this.buttonYesterdayCountDown.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonYesterdayCountDown.Location = new System.Drawing.Point(115, 120);
            this.buttonYesterdayCountDown.Name = "buttonYesterdayCountDown";
            this.buttonYesterdayCountDown.Size = new System.Drawing.Size(83, 31);
            this.buttonYesterdayCountDown.TabIndex = 8;
            this.buttonYesterdayCountDown.Text = "-1";
            this.buttonYesterdayCountDown.UseVisualStyleBackColor = true;
            this.buttonYesterdayCountDown.Click += new System.EventHandler(this.buttonYesterdayCountDown_Click);
            // 
            // buttonYesterdayCountUp
            // 
            this.buttonYesterdayCountUp.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonYesterdayCountUp.Location = new System.Drawing.Point(115, 52);
            this.buttonYesterdayCountUp.Name = "buttonYesterdayCountUp";
            this.buttonYesterdayCountUp.Size = new System.Drawing.Size(83, 31);
            this.buttonYesterdayCountUp.TabIndex = 6;
            this.buttonYesterdayCountUp.Text = "+1";
            this.buttonYesterdayCountUp.UseVisualStyleBackColor = true;
            this.buttonYesterdayCountUp.Click += new System.EventHandler(this.buttonYesterdayCountUp_Click);
            // 
            // labelMonth
            // 
            this.labelMonth.AutoSize = true;
            this.labelMonth.Location = new System.Drawing.Point(225, 34);
            this.labelMonth.Name = "labelMonth";
            this.labelMonth.Size = new System.Drawing.Size(67, 15);
            this.labelMonth.TabIndex = 9;
            this.labelMonth.Text = "今月累計";
            // 
            // textBoxMonthCount
            // 
            this.textBoxMonthCount.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBoxMonthCount.Location = new System.Drawing.Point(233, 89);
            this.textBoxMonthCount.Name = "textBoxMonthCount";
            this.textBoxMonthCount.ReadOnly = true;
            this.textBoxMonthCount.Size = new System.Drawing.Size(50, 25);
            this.textBoxMonthCount.TabIndex = 11;
            this.textBoxMonthCount.Text = "0000";
            this.textBoxMonthCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonMonthCountDown
            // 
            this.buttonMonthCountDown.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonMonthCountDown.Location = new System.Drawing.Point(217, 120);
            this.buttonMonthCountDown.Name = "buttonMonthCountDown";
            this.buttonMonthCountDown.Size = new System.Drawing.Size(83, 31);
            this.buttonMonthCountDown.TabIndex = 12;
            this.buttonMonthCountDown.Text = "-1";
            this.buttonMonthCountDown.UseVisualStyleBackColor = true;
            this.buttonMonthCountDown.Click += new System.EventHandler(this.buttonMonthCountDown_Click);
            // 
            // buttonMonthCountUp
            // 
            this.buttonMonthCountUp.Font = new System.Drawing.Font("MS UI Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonMonthCountUp.Location = new System.Drawing.Point(217, 52);
            this.buttonMonthCountUp.Name = "buttonMonthCountUp";
            this.buttonMonthCountUp.Size = new System.Drawing.Size(83, 31);
            this.buttonMonthCountUp.TabIndex = 10;
            this.buttonMonthCountUp.Text = "+1";
            this.buttonMonthCountUp.UseVisualStyleBackColor = true;
            this.buttonMonthCountUp.Click += new System.EventHandler(this.buttonMonthCountUp_Click);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelDate.Location = new System.Drawing.Point(12, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(119, 20);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "2000/01/01";
            // 
            // timerCheckDate
            // 
            this.timerCheckDate.Interval = 1000;
            this.timerCheckDate.Tick += new System.EventHandler(this.timerCheckDate_Tick);
            // 
            // checkBoxTopMost
            // 
            this.checkBoxTopMost.AutoSize = true;
            this.checkBoxTopMost.Location = new System.Drawing.Point(211, 9);
            this.checkBoxTopMost.Name = "checkBoxTopMost";
            this.checkBoxTopMost.Size = new System.Drawing.Size(89, 19);
            this.checkBoxTopMost.TabIndex = 13;
            this.checkBoxTopMost.Text = "前面固定";
            this.checkBoxTopMost.UseVisualStyleBackColor = true;
            this.checkBoxTopMost.CheckedChanged += new System.EventHandler(this.checkBoxTopMost_CheckedChanged);
            // 
            // formMonthCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 173);
            this.Controls.Add(this.checkBoxTopMost);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelMonth);
            this.Controls.Add(this.textBoxMonthCount);
            this.Controls.Add(this.buttonMonthCountDown);
            this.Controls.Add(this.buttonMonthCountUp);
            this.Controls.Add(this.labelYesterday);
            this.Controls.Add(this.textBoxYesterdayCount);
            this.Controls.Add(this.buttonYesterdayCountDown);
            this.Controls.Add(this.buttonYesterdayCountUp);
            this.Controls.Add(this.labelToday);
            this.Controls.Add(this.textBoxTodayCount);
            this.Controls.Add(this.buttonTodayCountDown);
            this.Controls.Add(this.buttonTodayCountUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 100);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formMonthCounter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "月累計カウンター";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.formMonthCounter_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTodayCountUp;
        private System.Windows.Forms.Button buttonTodayCountDown;
        private System.Windows.Forms.TextBox textBoxTodayCount;
        private System.Windows.Forms.Label labelToday;
        private System.Windows.Forms.Label labelYesterday;
        private System.Windows.Forms.TextBox textBoxYesterdayCount;
        private System.Windows.Forms.Button buttonYesterdayCountDown;
        private System.Windows.Forms.Button buttonYesterdayCountUp;
        private System.Windows.Forms.Label labelMonth;
        private System.Windows.Forms.TextBox textBoxMonthCount;
        private System.Windows.Forms.Button buttonMonthCountDown;
        private System.Windows.Forms.Button buttonMonthCountUp;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Timer timerCheckDate;
        private System.Windows.Forms.CheckBox checkBoxTopMost;
    }
}

