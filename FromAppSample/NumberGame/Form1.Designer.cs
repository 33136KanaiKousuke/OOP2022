
namespace NumberGame {
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Message = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.number2 = new System.Windows.Forms.NumericUpDown();
            this.maxNum = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(174, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "1から";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(331, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 59);
            this.button1.TabIndex = 1;
            this.button1.Text = "判定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Message
            // 
            this.Message.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Message.Location = new System.Drawing.Point(66, 264);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(293, 34);
            this.Message.TabIndex = 3;
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number.Location = new System.Drawing.Point(165, 127);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(100, 34);
            this.number.TabIndex = 4;
            // 
            // number2
            // 
            this.number2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number2.Location = new System.Drawing.Point(442, 264);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(120, 34);
            this.number2.TabIndex = 5;
            // 
            // maxNum
            // 
            this.maxNum.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.maxNum.Location = new System.Drawing.Point(261, 50);
            this.maxNum.Name = "maxNum";
            this.maxNum.Size = new System.Drawing.Size(68, 34);
            this.maxNum.TabIndex = 6;
            this.maxNum.Value = new decimal(new int[] {
            51,
            0,
            0,
            0});
            this.maxNum.ValueChanged += new System.EventHandler(this.number3_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 439);
            this.Controls.Add(this.maxNum);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.number2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Message;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.NumericUpDown number2;
        private System.Windows.Forms.NumericUpDown maxNum;
    }
}

