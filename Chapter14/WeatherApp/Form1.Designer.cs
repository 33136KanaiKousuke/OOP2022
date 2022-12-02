
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
            this.tbPublishingOffice = new System.Windows.Forms.TextBox();
            this.tbTomorrow = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbToday = new System.Windows.Forms.TextBox();
            this.pbtWether = new System.Windows.Forms.PictureBox();
            this.pbDayAftertWether = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pbThreeDaysWether = new System.Windows.Forms.PictureBox();
            this.pbFourDaysWether = new System.Windows.Forms.PictureBox();
            this.pbFiveDaysWether = new System.Windows.Forms.PictureBox();
            this.pbSixDaysWether = new System.Windows.Forms.PictureBox();
            this.lbThreeDays = new System.Windows.Forms.Label();
            this.lbFourDays = new System.Windows.Forms.Label();
            this.lbFiveDays = new System.Windows.Forms.Label();
            this.lbSixDays = new System.Windows.Forms.Label();
            this.lbMinTemps = new System.Windows.Forms.Label();
            this.lbMaxTemperature = new System.Windows.Forms.Label();
            this.lbToMinTemps = new System.Windows.Forms.Label();
            this.lbToMaxTemperature = new System.Windows.Forms.Label();
            this.lbMinDafterTomorrow = new System.Windows.Forms.Label();
            this.lbMaxDafterTomorrow = new System.Windows.Forms.Label();
            this.lbThreeDaysMinTemps = new System.Windows.Forms.Label();
            this.lbThreeDaysMaxTemps = new System.Windows.Forms.Label();
            this.lbFourDaysMinTemps = new System.Windows.Forms.Label();
            this.lbFourDaysMaxTemps = new System.Windows.Forms.Label();
            this.lbFiveDaysMinTemps = new System.Windows.Forms.Label();
            this.lbFiveDaysMaxTemps = new System.Windows.Forms.Label();
            this.lbSixDaysMinTemps = new System.Windows.Forms.Label();
            this.lbSixDaysMaxTemps = new System.Windows.Forms.Label();
            this.lbreportDatetime = new System.Windows.Forms.Label();
            this.lbDayAfterTomorrow = new System.Windows.Forms.Label();
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
            this.tbWeatherInfo.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbWeatherInfo.Location = new System.Drawing.Point(141, 335);
            this.tbWeatherInfo.Multiline = true;
            this.tbWeatherInfo.Name = "tbWeatherInfo";
            this.tbWeatherInfo.Size = new System.Drawing.Size(303, 331);
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
            this.label1.Location = new System.Drawing.Point(17, 335);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "天気概況：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(408, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "対象地域：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(906, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "発表者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(12, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "報告日時 ：";
            // 
            // pbTodayWether
            // 
            this.pbTodayWether.Location = new System.Drawing.Point(773, 109);
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
            this.label5.Location = new System.Drawing.Point(25, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "明日の天気：";
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
            // tbTomorrow
            // 
            this.tbTomorrow.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbTomorrow.Location = new System.Drawing.Point(181, 197);
            this.tbTomorrow.Multiline = true;
            this.tbTomorrow.Name = "tbTomorrow";
            this.tbTomorrow.Size = new System.Drawing.Size(278, 51);
            this.tbTomorrow.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(25, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "今日の天気：";
            // 
            // tbToday
            // 
            this.tbToday.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbToday.Location = new System.Drawing.Point(181, 109);
            this.tbToday.Multiline = true;
            this.tbToday.Name = "tbToday";
            this.tbToday.Size = new System.Drawing.Size(278, 51);
            this.tbToday.TabIndex = 6;
            // 
            // pbtWether
            // 
            this.pbtWether.Location = new System.Drawing.Point(773, 185);
            this.pbtWether.Name = "pbtWether";
            this.pbtWether.Size = new System.Drawing.Size(98, 57);
            this.pbtWether.TabIndex = 4;
            this.pbtWether.TabStop = false;
            // 
            // pbDayAftertWether
            // 
            this.pbDayAftertWether.Location = new System.Drawing.Point(773, 262);
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
            this.label8.Location = new System.Drawing.Point(651, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 3;
            this.label8.Text = "最高気温";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(533, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 24);
            this.label13.TabIndex = 3;
            this.label13.Text = "最低気温";
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
            this.label10.Location = new System.Drawing.Point(763, 74);
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
            // pbThreeDaysWether
            // 
            this.pbThreeDaysWether.Location = new System.Drawing.Point(773, 335);
            this.pbThreeDaysWether.Name = "pbThreeDaysWether";
            this.pbThreeDaysWether.Size = new System.Drawing.Size(98, 57);
            this.pbThreeDaysWether.TabIndex = 4;
            this.pbThreeDaysWether.TabStop = false;
            // 
            // pbFourDaysWether
            // 
            this.pbFourDaysWether.Location = new System.Drawing.Point(773, 398);
            this.pbFourDaysWether.Name = "pbFourDaysWether";
            this.pbFourDaysWether.Size = new System.Drawing.Size(98, 57);
            this.pbFourDaysWether.TabIndex = 4;
            this.pbFourDaysWether.TabStop = false;
            // 
            // pbFiveDaysWether
            // 
            this.pbFiveDaysWether.Location = new System.Drawing.Point(773, 461);
            this.pbFiveDaysWether.Name = "pbFiveDaysWether";
            this.pbFiveDaysWether.Size = new System.Drawing.Size(98, 57);
            this.pbFiveDaysWether.TabIndex = 4;
            this.pbFiveDaysWether.TabStop = false;
            // 
            // pbSixDaysWether
            // 
            this.pbSixDaysWether.Location = new System.Drawing.Point(773, 524);
            this.pbSixDaysWether.Name = "pbSixDaysWether";
            this.pbSixDaysWether.Size = new System.Drawing.Size(98, 57);
            this.pbSixDaysWether.TabIndex = 4;
            this.pbSixDaysWether.TabStop = false;
            // 
            // lbThreeDays
            // 
            this.lbThreeDays.AutoSize = true;
            this.lbThreeDays.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbThreeDays.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbThreeDays.Location = new System.Drawing.Point(454, 356);
            this.lbThreeDays.Name = "lbThreeDays";
            this.lbThreeDays.Size = new System.Drawing.Size(34, 24);
            this.lbThreeDays.TabIndex = 3;
            this.lbThreeDays.Text = "日";
            // 
            // lbFourDays
            // 
            this.lbFourDays.AutoSize = true;
            this.lbFourDays.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFourDays.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFourDays.Location = new System.Drawing.Point(454, 422);
            this.lbFourDays.Name = "lbFourDays";
            this.lbFourDays.Size = new System.Drawing.Size(34, 24);
            this.lbFourDays.TabIndex = 3;
            this.lbFourDays.Text = "日";
            // 
            // lbFiveDays
            // 
            this.lbFiveDays.AutoSize = true;
            this.lbFiveDays.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFiveDays.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFiveDays.Location = new System.Drawing.Point(454, 485);
            this.lbFiveDays.Name = "lbFiveDays";
            this.lbFiveDays.Size = new System.Drawing.Size(34, 24);
            this.lbFiveDays.TabIndex = 3;
            this.lbFiveDays.Text = "日";
            // 
            // lbSixDays
            // 
            this.lbSixDays.AutoSize = true;
            this.lbSixDays.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbSixDays.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSixDays.Location = new System.Drawing.Point(454, 547);
            this.lbSixDays.Name = "lbSixDays";
            this.lbSixDays.Size = new System.Drawing.Size(34, 24);
            this.lbSixDays.TabIndex = 3;
            this.lbSixDays.Text = "日";
            // 
            // lbMinTemps
            // 
            this.lbMinTemps.AutoSize = true;
            this.lbMinTemps.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbMinTemps.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbMinTemps.Location = new System.Drawing.Point(573, 115);
            this.lbMinTemps.Name = "lbMinTemps";
            this.lbMinTemps.Size = new System.Drawing.Size(0, 27);
            this.lbMinTemps.TabIndex = 8;
            // 
            // lbMaxTemperature
            // 
            this.lbMaxTemperature.AutoSize = true;
            this.lbMaxTemperature.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbMaxTemperature.ForeColor = System.Drawing.Color.Red;
            this.lbMaxTemperature.Location = new System.Drawing.Point(677, 115);
            this.lbMaxTemperature.Name = "lbMaxTemperature";
            this.lbMaxTemperature.Size = new System.Drawing.Size(0, 27);
            this.lbMaxTemperature.TabIndex = 8;
            // 
            // lbToMinTemps
            // 
            this.lbToMinTemps.AutoSize = true;
            this.lbToMinTemps.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbToMinTemps.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbToMinTemps.Location = new System.Drawing.Point(573, 194);
            this.lbToMinTemps.Name = "lbToMinTemps";
            this.lbToMinTemps.Size = new System.Drawing.Size(0, 27);
            this.lbToMinTemps.TabIndex = 8;
            // 
            // lbToMaxTemperature
            // 
            this.lbToMaxTemperature.AutoSize = true;
            this.lbToMaxTemperature.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbToMaxTemperature.ForeColor = System.Drawing.Color.Red;
            this.lbToMaxTemperature.Location = new System.Drawing.Point(677, 194);
            this.lbToMaxTemperature.Name = "lbToMaxTemperature";
            this.lbToMaxTemperature.Size = new System.Drawing.Size(0, 27);
            this.lbToMaxTemperature.TabIndex = 8;
            // 
            // lbMinDafterTomorrow
            // 
            this.lbMinDafterTomorrow.AutoSize = true;
            this.lbMinDafterTomorrow.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbMinDafterTomorrow.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbMinDafterTomorrow.Location = new System.Drawing.Point(573, 280);
            this.lbMinDafterTomorrow.Name = "lbMinDafterTomorrow";
            this.lbMinDafterTomorrow.Size = new System.Drawing.Size(0, 27);
            this.lbMinDafterTomorrow.TabIndex = 8;
            // 
            // lbMaxDafterTomorrow
            // 
            this.lbMaxDafterTomorrow.AutoSize = true;
            this.lbMaxDafterTomorrow.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbMaxDafterTomorrow.ForeColor = System.Drawing.Color.Red;
            this.lbMaxDafterTomorrow.Location = new System.Drawing.Point(677, 280);
            this.lbMaxDafterTomorrow.Name = "lbMaxDafterTomorrow";
            this.lbMaxDafterTomorrow.Size = new System.Drawing.Size(0, 27);
            this.lbMaxDafterTomorrow.TabIndex = 8;
            // 
            // lbThreeDaysMinTemps
            // 
            this.lbThreeDaysMinTemps.AutoSize = true;
            this.lbThreeDaysMinTemps.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbThreeDaysMinTemps.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbThreeDaysMinTemps.Location = new System.Drawing.Point(573, 353);
            this.lbThreeDaysMinTemps.Name = "lbThreeDaysMinTemps";
            this.lbThreeDaysMinTemps.Size = new System.Drawing.Size(0, 27);
            this.lbThreeDaysMinTemps.TabIndex = 8;
            // 
            // lbThreeDaysMaxTemps
            // 
            this.lbThreeDaysMaxTemps.AutoSize = true;
            this.lbThreeDaysMaxTemps.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbThreeDaysMaxTemps.ForeColor = System.Drawing.Color.Red;
            this.lbThreeDaysMaxTemps.Location = new System.Drawing.Point(677, 351);
            this.lbThreeDaysMaxTemps.Name = "lbThreeDaysMaxTemps";
            this.lbThreeDaysMaxTemps.Size = new System.Drawing.Size(0, 27);
            this.lbThreeDaysMaxTemps.TabIndex = 8;
            // 
            // lbFourDaysMinTemps
            // 
            this.lbFourDaysMinTemps.AutoSize = true;
            this.lbFourDaysMinTemps.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFourDaysMinTemps.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbFourDaysMinTemps.Location = new System.Drawing.Point(573, 420);
            this.lbFourDaysMinTemps.Name = "lbFourDaysMinTemps";
            this.lbFourDaysMinTemps.Size = new System.Drawing.Size(0, 27);
            this.lbFourDaysMinTemps.TabIndex = 8;
            // 
            // lbFourDaysMaxTemps
            // 
            this.lbFourDaysMaxTemps.AutoSize = true;
            this.lbFourDaysMaxTemps.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFourDaysMaxTemps.ForeColor = System.Drawing.Color.Red;
            this.lbFourDaysMaxTemps.Location = new System.Drawing.Point(677, 419);
            this.lbFourDaysMaxTemps.Name = "lbFourDaysMaxTemps";
            this.lbFourDaysMaxTemps.Size = new System.Drawing.Size(0, 27);
            this.lbFourDaysMaxTemps.TabIndex = 8;
            // 
            // lbFiveDaysMinTemps
            // 
            this.lbFiveDaysMinTemps.AutoSize = true;
            this.lbFiveDaysMinTemps.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFiveDaysMinTemps.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbFiveDaysMinTemps.Location = new System.Drawing.Point(573, 485);
            this.lbFiveDaysMinTemps.Name = "lbFiveDaysMinTemps";
            this.lbFiveDaysMinTemps.Size = new System.Drawing.Size(0, 27);
            this.lbFiveDaysMinTemps.TabIndex = 8;
            // 
            // lbFiveDaysMaxTemps
            // 
            this.lbFiveDaysMaxTemps.AutoSize = true;
            this.lbFiveDaysMaxTemps.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFiveDaysMaxTemps.ForeColor = System.Drawing.Color.Red;
            this.lbFiveDaysMaxTemps.Location = new System.Drawing.Point(677, 482);
            this.lbFiveDaysMaxTemps.Name = "lbFiveDaysMaxTemps";
            this.lbFiveDaysMaxTemps.Size = new System.Drawing.Size(0, 27);
            this.lbFiveDaysMaxTemps.TabIndex = 8;
            // 
            // lbSixDaysMinTemps
            // 
            this.lbSixDaysMinTemps.AutoSize = true;
            this.lbSixDaysMinTemps.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbSixDaysMinTemps.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbSixDaysMinTemps.Location = new System.Drawing.Point(573, 544);
            this.lbSixDaysMinTemps.Name = "lbSixDaysMinTemps";
            this.lbSixDaysMinTemps.Size = new System.Drawing.Size(0, 27);
            this.lbSixDaysMinTemps.TabIndex = 8;
            // 
            // lbSixDaysMaxTemps
            // 
            this.lbSixDaysMaxTemps.AutoSize = true;
            this.lbSixDaysMaxTemps.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbSixDaysMaxTemps.ForeColor = System.Drawing.Color.Red;
            this.lbSixDaysMaxTemps.Location = new System.Drawing.Point(677, 547);
            this.lbSixDaysMaxTemps.Name = "lbSixDaysMaxTemps";
            this.lbSixDaysMaxTemps.Size = new System.Drawing.Size(0, 27);
            this.lbSixDaysMaxTemps.TabIndex = 8;
            // 
            // lbreportDatetime
            // 
            this.lbreportDatetime.AutoSize = true;
            this.lbreportDatetime.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbreportDatetime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbreportDatetime.Location = new System.Drawing.Point(165, 33);
            this.lbreportDatetime.Name = "lbreportDatetime";
            this.lbreportDatetime.Size = new System.Drawing.Size(71, 29);
            this.lbreportDatetime.TabIndex = 3;
            this.lbreportDatetime.Text = "日時";
            // 
            // lbDayAfterTomorrow
            // 
            this.lbDayAfterTomorrow.AutoSize = true;
            this.lbDayAfterTomorrow.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbDayAfterTomorrow.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDayAfterTomorrow.Location = new System.Drawing.Point(454, 283);
            this.lbDayAfterTomorrow.Name = "lbDayAfterTomorrow";
            this.lbDayAfterTomorrow.Size = new System.Drawing.Size(34, 24);
            this.lbDayAfterTomorrow.TabIndex = 3;
            this.lbDayAfterTomorrow.Text = "日";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1233, 678);
            this.Controls.Add(this.lbSixDaysMaxTemps);
            this.Controls.Add(this.lbFiveDaysMaxTemps);
            this.Controls.Add(this.lbFourDaysMaxTemps);
            this.Controls.Add(this.lbThreeDaysMaxTemps);
            this.Controls.Add(this.lbMaxDafterTomorrow);
            this.Controls.Add(this.lbToMaxTemperature);
            this.Controls.Add(this.lbMaxTemperature);
            this.Controls.Add(this.lbSixDaysMinTemps);
            this.Controls.Add(this.lbFiveDaysMinTemps);
            this.Controls.Add(this.lbFourDaysMinTemps);
            this.Controls.Add(this.lbThreeDaysMinTemps);
            this.Controls.Add(this.lbMinDafterTomorrow);
            this.Controls.Add(this.lbToMinTemps);
            this.Controls.Add(this.lbMinTemps);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbToday);
            this.Controls.Add(this.tbTomorrow);
            this.Controls.Add(this.tbPublishingOffice);
            this.Controls.Add(this.pbSixDaysWether);
            this.Controls.Add(this.pbFiveDaysWether);
            this.Controls.Add(this.pbFourDaysWether);
            this.Controls.Add(this.pbThreeDaysWether);
            this.Controls.Add(this.pbDayAftertWether);
            this.Controls.Add(this.pbtWether);
            this.Controls.Add(this.pbTodayWether);
            this.Controls.Add(this.lbreportDatetime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbSixDays);
            this.Controls.Add(this.lbFiveDays);
            this.Controls.Add(this.lbFourDays);
            this.Controls.Add(this.lbDayAfterTomorrow);
            this.Controls.Add(this.lbThreeDays);
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
        private System.Windows.Forms.TextBox tbPublishingOffice;
        private System.Windows.Forms.TextBox tbTomorrow;
        private System.Windows.Forms.TextBox tbDayAfterTomorrow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbToday;
        private System.Windows.Forms.PictureBox pbtWether;
        private System.Windows.Forms.PictureBox pbDayAftertWether;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.PictureBox pbThreeDaysWether;
        private System.Windows.Forms.PictureBox pbFourDaysWether;
        private System.Windows.Forms.PictureBox pbFiveDaysWether;
        private System.Windows.Forms.PictureBox pbSixDaysWether;
        private System.Windows.Forms.Label lbThreeDays;
        private System.Windows.Forms.Label lbFourDays;
        private System.Windows.Forms.Label lbFiveDays;
        private System.Windows.Forms.Label lbSixDays;
        private System.Windows.Forms.Label lbMinTemps;
        private System.Windows.Forms.Label lbMaxTemperature;
        private System.Windows.Forms.Label lbToMinTemps;
        private System.Windows.Forms.Label lbToMaxTemperature;
        private System.Windows.Forms.Label lbMinDafterTomorrow;
        private System.Windows.Forms.Label lbMaxDafterTomorrow;
        private System.Windows.Forms.Label lbThreeDaysMinTemps;
        private System.Windows.Forms.Label lbThreeDaysMaxTemps;
        private System.Windows.Forms.Label lbFourDaysMinTemps;
        private System.Windows.Forms.Label lbFourDaysMaxTemps;
        private System.Windows.Forms.Label lbFiveDaysMinTemps;
        private System.Windows.Forms.Label lbFiveDaysMaxTemps;
        private System.Windows.Forms.Label lbSixDaysMinTemps;
        private System.Windows.Forms.Label lbSixDaysMaxTemps;
        private System.Windows.Forms.Label lbreportDatetime;
        private System.Windows.Forms.Label lbDayAfterTomorrow;
    }
}

