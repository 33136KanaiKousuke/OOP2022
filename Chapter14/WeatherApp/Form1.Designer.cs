
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
            this.pbtWether = new System.Windows.Forms.PictureBox();
            this.pbDayAftertWether = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbMaxTemperature = new System.Windows.Forms.TextBox();
            this.tbToMinTemps = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbMinTemps = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbToMaxTemperature = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbMaxDafterTomorrow = new System.Windows.Forms.TextBox();
            this.tbMinDafterTomorrow = new System.Windows.Forms.TextBox();
            this.tbThreeDaysMinTemps = new System.Windows.Forms.TextBox();
            this.tbFourDaysMinTemps = new System.Windows.Forms.TextBox();
            this.tbFiveDaysMinTemps = new System.Windows.Forms.TextBox();
            this.tbSixDaysMinTemps = new System.Windows.Forms.TextBox();
            this.tbThreeDaysMaxTemps = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbFourDaysMaxTemps = new System.Windows.Forms.TextBox();
            this.tbFiveDaysMaxTemps = new System.Windows.Forms.TextBox();
            this.tbSixDaysMaxTemps = new System.Windows.Forms.TextBox();
            this.pbThreeDaysWether = new System.Windows.Forms.PictureBox();
            this.pbFourDaysWether = new System.Windows.Forms.PictureBox();
            this.pbFiveDaysWether = new System.Windows.Forms.PictureBox();
            this.pbSixDaysWether = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTodayWether)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbtWether)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAftertWether)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThreeDaysWether)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFourDaysWether)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiveDaysWether)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSixDaysWether)).BeginInit();
            this.SuspendLayout();
            // 
            // tbWeatherInfo
            // 
            this.tbWeatherInfo.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfo.Location = new System.Drawing.Point(129, 360);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(303, 293);
            this.tbWeatherInfo.TabIndex = 0;
            // 
            // btWeatherGet
            // 
            this.btWeatherGet.Font = new System.Drawing.Font("MS UI Gothic", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btWeatherGet.Location = new System.Drawing.Point(796, 18);
            this.btWeatherGet.Name = "btWeatherGet";
            this.btWeatherGet.Size = new System.Drawing.Size(75, 43);
            this.btWeatherGet.TabIndex = 1;
            this.btWeatherGet.Text = "取得";
            this.btWeatherGet.UseVisualStyleBackColor = true;
            this.btWeatherGet.Click += new System.EventHandler(this.btWeatherGet_Click);
            // 
            // cmArea
            // 
            this.cmArea.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cmArea.FormattingEnabled = true;
            this.cmArea.Location = new System.Drawing.Point(532, 28);
            this.cmArea.Name = "cmArea";
            this.cmArea.Size = new System.Drawing.Size(258, 29);
            this.cmArea.TabIndex = 2;
            this.cmArea.SelectedIndexChanged += new System.EventHandler(this.cmArea_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(17, 360);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "天気概況";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(420, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "対象地域";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(906, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "発表者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "報告日時";
            // 
            // pbTodayWether
            // 
            this.pbTodayWether.Location = new System.Drawing.Point(831, 109);
            this.pbTodayWether.Name = "pbTodayWether";
            this.pbTodayWether.Size = new System.Drawing.Size(98, 57);
            this.pbTodayWether.TabIndex = 4;
            this.pbTodayWether.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(14, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "明日の天気";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(14, 268);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "明後日の天気";
            // 
            // tbPublishingOffice
            // 
            this.tbPublishingOffice.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbPublishingOffice.Location = new System.Drawing.Point(994, 20);
            this.tbPublishingOffice.Multiline = true;
            this.tbPublishingOffice.Name = "tbPublishingOffice";
            this.tbPublishingOffice.Size = new System.Drawing.Size(227, 31);
            this.tbPublishingOffice.TabIndex = 5;
            // 
            // tbreportDatetime
            // 
            this.tbreportDatetime.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbreportDatetime.Location = new System.Drawing.Point(124, 30);
            this.tbreportDatetime.Name = "tbreportDatetime";
            this.tbreportDatetime.Size = new System.Drawing.Size(241, 31);
            this.tbreportDatetime.TabIndex = 5;
            // 
            // tbTomorrow
            // 
            this.tbTomorrow.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTomorrow.Location = new System.Drawing.Point(170, 191);
            this.tbTomorrow.Multiline = true;
            this.tbTomorrow.Name = "tbTomorrow";
            this.tbTomorrow.Size = new System.Drawing.Size(206, 51);
            this.tbTomorrow.TabIndex = 6;
            // 
            // tbDayAfterTomorrow
            // 
            this.tbDayAfterTomorrow.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbDayAfterTomorrow.Location = new System.Drawing.Point(170, 268);
            this.tbDayAfterTomorrow.Multiline = true;
            this.tbDayAfterTomorrow.Name = "tbDayAfterTomorrow";
            this.tbDayAfterTomorrow.Size = new System.Drawing.Size(206, 51);
            this.tbDayAfterTomorrow.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(14, 115);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "今日の天気";
            // 
            // tbToday
            // 
            this.tbToday.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbToday.Location = new System.Drawing.Point(170, 115);
            this.tbToday.Multiline = true;
            this.tbToday.Name = "tbToday";
            this.tbToday.Size = new System.Drawing.Size(206, 51);
            this.tbToday.TabIndex = 6;
            // 
            // pbtWether
            // 
            this.pbtWether.Location = new System.Drawing.Point(831, 185);
            this.pbtWether.Name = "pbtWether";
            this.pbtWether.Size = new System.Drawing.Size(98, 57);
            this.pbtWether.TabIndex = 4;
            this.pbtWether.TabStop = false;
            // 
            // pbDayAftertWether
            // 
            this.pbDayAftertWether.Location = new System.Drawing.Point(831, 262);
            this.pbDayAftertWether.Name = "pbDayAftertWether";
            this.pbDayAftertWether.Size = new System.Drawing.Size(98, 57);
            this.pbDayAftertWether.TabIndex = 4;
            this.pbDayAftertWether.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(651, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "最高気温";
            // 
            // tbMaxTemperature
            // 
            this.tbMaxTemperature.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMaxTemperature.Location = new System.Drawing.Point(663, 115);
            this.tbMaxTemperature.Multiline = true;
            this.tbMaxTemperature.Name = "tbMaxTemperature";
            this.tbMaxTemperature.Size = new System.Drawing.Size(75, 28);
            this.tbMaxTemperature.TabIndex = 5;
            // 
            // tbToMinTemps
            // 
            this.tbToMinTemps.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbToMinTemps.Location = new System.Drawing.Point(549, 193);
            this.tbToMinTemps.Multiline = true;
            this.tbToMinTemps.Name = "tbToMinTemps";
            this.tbToMinTemps.Size = new System.Drawing.Size(75, 28);
            this.tbToMinTemps.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox2.Location = new System.Drawing.Point(550, 278);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 28);
            this.textBox2.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(533, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 24);
            this.label13.TabIndex = 3;
            this.label13.Text = "最低気温";
            // 
            // tbMinTemps
            // 
            this.tbMinTemps.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMinTemps.Location = new System.Drawing.Point(551, 115);
            this.tbMinTemps.Multiline = true;
            this.tbMinTemps.Name = "tbMinTemps";
            this.tbMinTemps.Size = new System.Drawing.Size(75, 28);
            this.tbMinTemps.TabIndex = 5;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(632, 115);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(26, 27);
            this.label14.TabIndex = 7;
            this.label14.Text = "/";
            // 
            // tbToMaxTemperature
            // 
            this.tbToMaxTemperature.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbToMaxTemperature.Location = new System.Drawing.Point(663, 193);
            this.tbToMaxTemperature.Multiline = true;
            this.tbToMaxTemperature.Name = "tbToMaxTemperature";
            this.tbToMaxTemperature.Size = new System.Drawing.Size(76, 28);
            this.tbToMaxTemperature.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(630, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 27);
            this.label9.TabIndex = 7;
            this.label9.Text = "/";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(763, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 24);
            this.label10.TabIndex = 3;
            this.label10.Text = "(℃)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(631, 279);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 27);
            this.label11.TabIndex = 7;
            this.label11.Text = "/";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.textBox1.Location = new System.Drawing.Point(550, 278);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(75, 28);
            this.textBox1.TabIndex = 5;
            // 
            // tbMaxDafterTomorrow
            // 
            this.tbMaxDafterTomorrow.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMaxDafterTomorrow.Location = new System.Drawing.Point(664, 279);
            this.tbMaxDafterTomorrow.Multiline = true;
            this.tbMaxDafterTomorrow.Name = "tbMaxDafterTomorrow";
            this.tbMaxDafterTomorrow.Size = new System.Drawing.Size(75, 28);
            this.tbMaxDafterTomorrow.TabIndex = 5;
            // 
            // tbMinDafterTomorrow
            // 
            this.tbMinDafterTomorrow.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbMinDafterTomorrow.Location = new System.Drawing.Point(550, 278);
            this.tbMinDafterTomorrow.Multiline = true;
            this.tbMinDafterTomorrow.Name = "tbMinDafterTomorrow";
            this.tbMinDafterTomorrow.Size = new System.Drawing.Size(75, 28);
            this.tbMinDafterTomorrow.TabIndex = 5;
            // 
            // tbThreeDaysMinTemps
            // 
            this.tbThreeDaysMinTemps.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbThreeDaysMinTemps.Location = new System.Drawing.Point(550, 351);
            this.tbThreeDaysMinTemps.Multiline = true;
            this.tbThreeDaysMinTemps.Name = "tbThreeDaysMinTemps";
            this.tbThreeDaysMinTemps.Size = new System.Drawing.Size(75, 28);
            this.tbThreeDaysMinTemps.TabIndex = 5;
            // 
            // tbFourDaysMinTemps
            // 
            this.tbFourDaysMinTemps.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFourDaysMinTemps.Location = new System.Drawing.Point(550, 418);
            this.tbFourDaysMinTemps.Multiline = true;
            this.tbFourDaysMinTemps.Name = "tbFourDaysMinTemps";
            this.tbFourDaysMinTemps.Size = new System.Drawing.Size(75, 28);
            this.tbFourDaysMinTemps.TabIndex = 5;
            // 
            // tbFiveDaysMinTemps
            // 
            this.tbFiveDaysMinTemps.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFiveDaysMinTemps.Location = new System.Drawing.Point(550, 481);
            this.tbFiveDaysMinTemps.Multiline = true;
            this.tbFiveDaysMinTemps.Name = "tbFiveDaysMinTemps";
            this.tbFiveDaysMinTemps.Size = new System.Drawing.Size(75, 28);
            this.tbFiveDaysMinTemps.TabIndex = 5;
            // 
            // tbSixDaysMinTemps
            // 
            this.tbSixDaysMinTemps.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSixDaysMinTemps.Location = new System.Drawing.Point(550, 547);
            this.tbSixDaysMinTemps.Multiline = true;
            this.tbSixDaysMinTemps.Name = "tbSixDaysMinTemps";
            this.tbSixDaysMinTemps.Size = new System.Drawing.Size(75, 28);
            this.tbSixDaysMinTemps.TabIndex = 5;
            // 
            // tbThreeDaysMaxTemps
            // 
            this.tbThreeDaysMaxTemps.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbThreeDaysMaxTemps.Location = new System.Drawing.Point(664, 351);
            this.tbThreeDaysMaxTemps.Multiline = true;
            this.tbThreeDaysMaxTemps.Name = "tbThreeDaysMaxTemps";
            this.tbThreeDaysMaxTemps.Size = new System.Drawing.Size(75, 28);
            this.tbThreeDaysMaxTemps.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(631, 353);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 27);
            this.label15.TabIndex = 7;
            this.label15.Text = "/";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(632, 419);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(26, 27);
            this.label16.TabIndex = 7;
            this.label16.Text = "/";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label17.Location = new System.Drawing.Point(632, 482);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 27);
            this.label17.TabIndex = 7;
            this.label17.Text = "/";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(632, 547);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(26, 27);
            this.label18.TabIndex = 7;
            this.label18.Text = "/";
            // 
            // tbFourDaysMaxTemps
            // 
            this.tbFourDaysMaxTemps.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFourDaysMaxTemps.Location = new System.Drawing.Point(664, 418);
            this.tbFourDaysMaxTemps.Multiline = true;
            this.tbFourDaysMaxTemps.Name = "tbFourDaysMaxTemps";
            this.tbFourDaysMaxTemps.Size = new System.Drawing.Size(75, 28);
            this.tbFourDaysMaxTemps.TabIndex = 5;
            // 
            // tbFiveDaysMaxTemps
            // 
            this.tbFiveDaysMaxTemps.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbFiveDaysMaxTemps.Location = new System.Drawing.Point(664, 481);
            this.tbFiveDaysMaxTemps.Multiline = true;
            this.tbFiveDaysMaxTemps.Name = "tbFiveDaysMaxTemps";
            this.tbFiveDaysMaxTemps.Size = new System.Drawing.Size(75, 28);
            this.tbFiveDaysMaxTemps.TabIndex = 5;
            // 
            // tbSixDaysMaxTemps
            // 
            this.tbSixDaysMaxTemps.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSixDaysMaxTemps.Location = new System.Drawing.Point(663, 547);
            this.tbSixDaysMaxTemps.Multiline = true;
            this.tbSixDaysMaxTemps.Name = "tbSixDaysMaxTemps";
            this.tbSixDaysMaxTemps.Size = new System.Drawing.Size(75, 28);
            this.tbSixDaysMaxTemps.TabIndex = 5;
            // 
            // pbThreeDaysWether
            // 
            this.pbThreeDaysWether.Location = new System.Drawing.Point(831, 335);
            this.pbThreeDaysWether.Name = "pbThreeDaysWether";
            this.pbThreeDaysWether.Size = new System.Drawing.Size(98, 57);
            this.pbThreeDaysWether.TabIndex = 4;
            this.pbThreeDaysWether.TabStop = false;
            // 
            // pbFourDaysWether
            // 
            this.pbFourDaysWether.Location = new System.Drawing.Point(831, 398);
            this.pbFourDaysWether.Name = "pbFourDaysWether";
            this.pbFourDaysWether.Size = new System.Drawing.Size(98, 57);
            this.pbFourDaysWether.TabIndex = 4;
            this.pbFourDaysWether.TabStop = false;
            // 
            // pbFiveDaysWether
            // 
            this.pbFiveDaysWether.Location = new System.Drawing.Point(831, 461);
            this.pbFiveDaysWether.Name = "pbFiveDaysWether";
            this.pbFiveDaysWether.Size = new System.Drawing.Size(98, 57);
            this.pbFiveDaysWether.TabIndex = 4;
            this.pbFiveDaysWether.TabStop = false;
            // 
            // pbSixDaysWether
            // 
            this.pbSixDaysWether.Location = new System.Drawing.Point(831, 524);
            this.pbSixDaysWether.Name = "pbSixDaysWether";
            this.pbSixDaysWether.Size = new System.Drawing.Size(98, 57);
            this.pbSixDaysWether.TabIndex = 4;
            this.pbSixDaysWether.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1233, 678);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbDayAfterTomorrow);
            this.Controls.Add(this.tbToday);
            this.Controls.Add(this.tbTomorrow);
            this.Controls.Add(this.tbMaxDafterTomorrow);
            this.Controls.Add(this.tbSixDaysMaxTemps);
            this.Controls.Add(this.tbSixDaysMinTemps);
            this.Controls.Add(this.tbFiveDaysMaxTemps);
            this.Controls.Add(this.tbFiveDaysMinTemps);
            this.Controls.Add(this.tbFourDaysMaxTemps);
            this.Controls.Add(this.tbFourDaysMinTemps);
            this.Controls.Add(this.tbThreeDaysMaxTemps);
            this.Controls.Add(this.tbThreeDaysMinTemps);
            this.Controls.Add(this.tbMinDafterTomorrow);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.tbToMaxTemperature);
            this.Controls.Add(this.tbToMinTemps);
            this.Controls.Add(this.tbMinTemps);
            this.Controls.Add(this.tbMaxTemperature);
            this.Controls.Add(this.tbreportDatetime);
            this.Controls.Add(this.tbPublishingOffice);
            this.Controls.Add(this.pbSixDaysWether);
            this.Controls.Add(this.pbFiveDaysWether);
            this.Controls.Add(this.pbFourDaysWether);
            this.Controls.Add(this.pbThreeDaysWether);
            this.Controls.Add(this.pbDayAftertWether);
            this.Controls.Add(this.pbtWether);
            this.Controls.Add(this.pbTodayWether);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
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
            ((System.ComponentModel.ISupportInitialize)(this.pbtWether)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDayAftertWether)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbThreeDaysWether)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFourDaysWether)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFiveDaysWether)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSixDaysWether)).EndInit();
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
        private System.Windows.Forms.PictureBox pbtWether;
        private System.Windows.Forms.PictureBox pbDayAftertWether;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbMaxTemperature;
        private System.Windows.Forms.TextBox tbToMinTemps;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbMinTemps;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbToMaxTemperature;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbMaxDafterTomorrow;
        private System.Windows.Forms.TextBox tbMinDafterTomorrow;
        private System.Windows.Forms.TextBox tbThreeDaysMinTemps;
        private System.Windows.Forms.TextBox tbFourDaysMinTemps;
        private System.Windows.Forms.TextBox tbFiveDaysMinTemps;
        private System.Windows.Forms.TextBox tbSixDaysMinTemps;
        private System.Windows.Forms.TextBox tbThreeDaysMaxTemps;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbFourDaysMaxTemps;
        private System.Windows.Forms.TextBox tbFiveDaysMaxTemps;
        private System.Windows.Forms.TextBox tbSixDaysMaxTemps;
        private System.Windows.Forms.PictureBox pbThreeDaysWether;
        private System.Windows.Forms.PictureBox pbFourDaysWether;
        private System.Windows.Forms.PictureBox pbFiveDaysWether;
        private System.Windows.Forms.PictureBox pbSixDaysWether;
    }
}

