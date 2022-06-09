
namespace Sample0607 {
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
            this.btRandom = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.NumericUpDown();
            this.numberMin = new System.Windows.Forms.NumericUpDown();
            this.numberMax = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.number)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMax)).BeginInit();
            this.SuspendLayout();
            // 
            // btRandom
            // 
            this.btRandom.Location = new System.Drawing.Point(377, 306);
            this.btRandom.Name = "btRandom";
            this.btRandom.Size = new System.Drawing.Size(164, 64);
            this.btRandom.TabIndex = 0;
            this.btRandom.Text = "乱数取得";
            this.btRandom.UseVisualStyleBackColor = true;
            this.btRandom.Click += new System.EventHandler(this.btRandom_Click);
            // 
            // number
            // 
            this.number.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.number.Location = new System.Drawing.Point(126, 326);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(120, 44);
            this.number.TabIndex = 1;
            // 
            // numberMin
            // 
            this.numberMin.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numberMin.Location = new System.Drawing.Point(404, 70);
            this.numberMin.Name = "numberMin";
            this.numberMin.Size = new System.Drawing.Size(120, 44);
            this.numberMin.TabIndex = 1;
            // 
            // numberMax
            // 
            this.numberMax.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numberMax.Location = new System.Drawing.Point(404, 206);
            this.numberMax.Name = "numberMax";
            this.numberMax.Size = new System.Drawing.Size(120, 44);
            this.numberMax.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(134, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "最小値";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(134, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "最大値";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1012, 626);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numberMax);
            this.Controls.Add(this.numberMin);
            this.Controls.Add(this.number);
            this.Controls.Add(this.btRandom);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "乱数アプリ";
            ((System.ComponentModel.ISupportInitialize)(this.number)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberMax)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRandom;
        private System.Windows.Forms.NumericUpDown number;
        private System.Windows.Forms.NumericUpDown numberMin;
        private System.Windows.Forms.NumericUpDown numberMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

