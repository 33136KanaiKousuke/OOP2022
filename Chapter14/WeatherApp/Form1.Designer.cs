
namespace WeatherApp {
    partial class Form1 {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.tbWeatherInfo = new System.Windows.Forms.TextBox();
            this.btWeatherGet = new System.Windows.Forms.Button();
            this.cmArea = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbTodayWether = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPublishingOffice = new System.Windows.Forms.TextBox();
            this.tbreportDatetime = new System.Windows.Forms.TextBox();
            this.tbTomorrow = new System.Windows.Forms.TextBox();
            this.tbDayAfterTomorrow = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbToday = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayWether)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Location = new System.Drawing.Point(164, 361);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(364, 186);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Location = new System.Drawing.Point(348, 85);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(75, 43);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // cmArea
            // 
            this.cmArea.FormattingEnabled = true;
            this.cmArea.Location = new System.Drawing.Point(170, 93);
            this.cmArea.Name = "cmArea";
            this.cmArea.Size = new System.Drawing.Size(141, 20);
            this.cmArea.TabIndex = 2;
            this.cmArea.SelectedIndexChanged += new System.EventHandler(this.cmArea_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(23, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "天気概況";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(23, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "対象地域";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(29, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "発表者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(388, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "報告日時";
            // 
            // pbTodayWether
            // 
            this.pbTodayWether.Location = new System.Drawing.Point(485, 106);
            this.pbTodayWether.Name = "pbTodayWether";
            this.pbTodayWether.Size = new System.Drawing.Size(186, 105);
            this.pbTodayWether.TabIndex = 4;
            this.pbTodayWether.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(23, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "明日の天気";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(23, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "明後日の天気";
            // 
            // tbPublishingOffice
            // 
            this.tbPublishingOffice.Location = new System.Drawing.Point(170, 37);
            this.tbPublishingOffice.Name = "tbPublishingOffice";
            this.tbPublishingOffice.Size = new System.Drawing.Size(141, 19);
            this.tbPublishingOffice.TabIndex = 5;
            // 
            // tbreportDatetime
            // 
            this.tbreportDatetime.Location = new System.Drawing.Point(515, 34);
            this.tbreportDatetime.Name = "tbreportDatetime";
            this.tbreportDatetime.Size = new System.Drawing.Size(141, 19);
            this.tbreportDatetime.TabIndex = 5;
            // 
            // tbTomorrow
            // 
            this.tbTomorrow.Location = new System.Drawing.Point(179, 226);
            this.tbTomorrow.Name = "tbTomorrow";
            this.tbTomorrow.Size = new System.Drawing.Size(185, 19);
            this.tbTomorrow.TabIndex = 6;
            // 
            // tbDayAfterTomorrow
            // 
            this.tbDayAfterTomorrow.Location = new System.Drawing.Point(179, 313);
            this.tbDayAfterTomorrow.Name = "tbDayAfterTomorrow";
            this.tbDayAfterTomorrow.Size = new System.Drawing.Size(185, 19);
            this.tbDayAfterTomorrow.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(23, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "今日の天気";
            // 
            // tbToday
            // 
            this.tbToday.Location = new System.Drawing.Point(179, 158);
            this.tbToday.Name = "tbToday";
            this.tbToday.Size = new System.Drawing.Size(185, 19);
            this.tbToday.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 579);
            this.Controls.Add(this.tbDayAfterTomorrow);
            this.Controls.Add(this.tbToday);
            this.Controls.Add(this.tbTomorrow);
            this.Controls.Add(this.tbreportDatetime);
            this.Controls.Add(this.tbPublishingOffice);
            this.Controls.Add(this.pbTodayWether);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmArea);
            this.Controls.Add(this.btWeatherGet);
            this.Controls.Add(this.tbWeatherInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayWether)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWeatherInfo;
        private System.Windows.Forms.Button btWeatherGet;
        private System.Windows.Forms.ComboBox cmArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbTodayWether;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPublishingOffice;
        private System.Windows.Forms.TextBox tbreportDatetime;
        private System.Windows.Forms.TextBox tbTomorrow;
        private System.Windows.Forms.TextBox tbDayAfterTomorrow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbToday;
    }
}

