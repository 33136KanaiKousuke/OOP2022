
namespace CarReportSystem {
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpRegistDate = new System.Windows.Forms.DateTimePicker();
            this.cbAuther = new System.Windows.Forms.ComboBox();
            this.gbMaker = new System.Windows.Forms.GroupBox();
            this.rbOther = new System.Windows.Forms.RadioButton();
            this.rbOutsidecar = new System.Windows.Forms.RadioButton();
            this.rbSubaru = new System.Windows.Forms.RadioButton();
            this.rbHonda = new System.Windows.Forms.RadioButton();
            this.rbNissann = new System.Windows.Forms.RadioButton();
            this.rbToyota = new System.Windows.Forms.RadioButton();
            this.cbCarName = new System.Windows.Forms.ComboBox();
            this.tbReport = new System.Windows.Forms.TextBox();
            this.btPictureOpen = new System.Windows.Forms.Button();
            this.btPictureClear = new System.Windows.Forms.Button();
            this.pbPicture = new System.Windows.Forms.PictureBox();
            this.btAddPerson = new System.Windows.Forms.Button();
            this.btCorrect = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.ofdFileOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.sfdSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.データベース接続ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色の設定ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.終了ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cdColorSelect = new System.Windows.Forms.ColorDialog();
            this.pbModeSelect = new System.Windows.Forms.Button();
            this.infosys202212DataSet = new CarReportSystem.infosys202212DataSet();
            this.carReportDbBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carReportDbTableAdapter = new CarReportSystem.infosys202212DataSetTableAdapters.CarReportDbTableAdapter();
            this.tableAdapterManager = new CarReportSystem.infosys202212DataSetTableAdapters.TableAdapterManager();
            this.carReportDbDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btClear = new System.Windows.Forms.Button();
            this.btSearchAuther = new System.Windows.Forms.Button();
            this.tbSearchAuther = new System.Windows.Forms.TextBox();
            this.gbMaker.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202212DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDbBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDbDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "日付：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "記録者：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(31, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "メーカー：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(53, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "車名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(30, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "レポート：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(11, 363);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 1;
            this.label6.Text = "記事一覧：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label7.Location = new System.Drawing.Point(638, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "画像：";
            // 
            // dtpRegistDate
            // 
            this.dtpRegistDate.Location = new System.Drawing.Point(122, 37);
            this.dtpRegistDate.Name = "dtpRegistDate";
            this.dtpRegistDate.Size = new System.Drawing.Size(200, 19);
            this.dtpRegistDate.TabIndex = 13;
            // 
            // cbAuther
            // 
            this.cbAuther.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbAuther.FormattingEnabled = true;
            this.cbAuther.Location = new System.Drawing.Point(122, 73);
            this.cbAuther.Name = "cbAuther";
            this.cbAuther.Size = new System.Drawing.Size(398, 29);
            this.cbAuther.TabIndex = 14;
            // 
            // gbMaker
            // 
            this.gbMaker.Controls.Add(this.rbOther);
            this.gbMaker.Controls.Add(this.rbOutsidecar);
            this.gbMaker.Controls.Add(this.rbSubaru);
            this.gbMaker.Controls.Add(this.rbHonda);
            this.gbMaker.Controls.Add(this.rbNissann);
            this.gbMaker.Controls.Add(this.rbToyota);
            this.gbMaker.Location = new System.Drawing.Point(122, 119);
            this.gbMaker.Name = "gbMaker";
            this.gbMaker.Size = new System.Drawing.Size(398, 35);
            this.gbMaker.TabIndex = 15;
            this.gbMaker.TabStop = false;
            // 
            // rbOther
            // 
            this.rbOther.AutoSize = true;
            this.rbOther.Location = new System.Drawing.Point(292, 5);
            this.rbOther.Name = "rbOther";
            this.rbOther.Size = new System.Drawing.Size(54, 16);
            this.rbOther.TabIndex = 1;
            this.rbOther.Text = "その他";
            this.rbOther.UseVisualStyleBackColor = true;
            // 
            // rbOutsidecar
            // 
            this.rbOutsidecar.AutoSize = true;
            this.rbOutsidecar.Location = new System.Drawing.Point(227, 5);
            this.rbOutsidecar.Name = "rbOutsidecar";
            this.rbOutsidecar.Size = new System.Drawing.Size(59, 16);
            this.rbOutsidecar.TabIndex = 1;
            this.rbOutsidecar.Text = "外国車";
            this.rbOutsidecar.UseVisualStyleBackColor = true;
            // 
            // rbSubaru
            // 
            this.rbSubaru.AutoSize = true;
            this.rbSubaru.Location = new System.Drawing.Point(169, 6);
            this.rbSubaru.Name = "rbSubaru";
            this.rbSubaru.Size = new System.Drawing.Size(52, 16);
            this.rbSubaru.TabIndex = 1;
            this.rbSubaru.Text = "スバル";
            this.rbSubaru.UseVisualStyleBackColor = true;
            // 
            // rbHonda
            // 
            this.rbHonda.AutoSize = true;
            this.rbHonda.Location = new System.Drawing.Point(112, 6);
            this.rbHonda.Name = "rbHonda";
            this.rbHonda.Size = new System.Drawing.Size(51, 16);
            this.rbHonda.TabIndex = 1;
            this.rbHonda.Text = "ホンダ";
            this.rbHonda.UseVisualStyleBackColor = true;
            // 
            // rbNissann
            // 
            this.rbNissann.AutoSize = true;
            this.rbNissann.Location = new System.Drawing.Point(59, 6);
            this.rbNissann.Name = "rbNissann";
            this.rbNissann.Size = new System.Drawing.Size(47, 16);
            this.rbNissann.TabIndex = 1;
            this.rbNissann.Text = "日産";
            this.rbNissann.UseVisualStyleBackColor = true;
            // 
            // rbToyota
            // 
            this.rbToyota.AutoSize = true;
            this.rbToyota.Location = new System.Drawing.Point(6, 6);
            this.rbToyota.Name = "rbToyota";
            this.rbToyota.Size = new System.Drawing.Size(47, 16);
            this.rbToyota.TabIndex = 0;
            this.rbToyota.Text = "トヨタ";
            this.rbToyota.UseVisualStyleBackColor = true;
            // 
            // cbCarName
            // 
            this.cbCarName.Font = new System.Drawing.Font("MS UI Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.cbCarName.FormattingEnabled = true;
            this.cbCarName.Location = new System.Drawing.Point(122, 160);
            this.cbCarName.Name = "cbCarName";
            this.cbCarName.Size = new System.Drawing.Size(398, 29);
            this.cbCarName.TabIndex = 14;
            // 
            // tbReport
            // 
            this.tbReport.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbReport.Location = new System.Drawing.Point(122, 210);
            this.tbReport.Multiline = true;
            this.tbReport.Name = "tbReport";
            this.tbReport.Size = new System.Drawing.Size(413, 137);
            this.tbReport.TabIndex = 16;
            // 
            // btPictureOpen
            // 
            this.btPictureOpen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btPictureOpen.Location = new System.Drawing.Point(707, 40);
            this.btPictureOpen.Name = "btPictureOpen";
            this.btPictureOpen.Size = new System.Drawing.Size(69, 23);
            this.btPictureOpen.TabIndex = 18;
            this.btPictureOpen.Text = "開く...";
            this.btPictureOpen.UseVisualStyleBackColor = true;
            this.btPictureOpen.Click += new System.EventHandler(this.btPictureOpen_Click);
            // 
            // btPictureClear
            // 
            this.btPictureClear.Location = new System.Drawing.Point(782, 40);
            this.btPictureClear.Name = "btPictureClear";
            this.btPictureClear.Size = new System.Drawing.Size(65, 23);
            this.btPictureClear.TabIndex = 19;
            this.btPictureClear.Text = "削除";
            this.btPictureClear.UseVisualStyleBackColor = true;
            this.btPictureClear.Click += new System.EventHandler(this.btPictureClear_Click);
            // 
            // pbPicture
            // 
            this.pbPicture.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbPicture.Location = new System.Drawing.Point(707, 69);
            this.pbPicture.Name = "pbPicture";
            this.pbPicture.Size = new System.Drawing.Size(221, 176);
            this.pbPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPicture.TabIndex = 20;
            this.pbPicture.TabStop = false;
            // 
            // btAddPerson
            // 
            this.btAddPerson.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAddPerson.Location = new System.Drawing.Point(707, 251);
            this.btAddPerson.Name = "btAddPerson";
            this.btAddPerson.Size = new System.Drawing.Size(71, 52);
            this.btAddPerson.TabIndex = 21;
            this.btAddPerson.Text = "追加";
            this.btAddPerson.UseVisualStyleBackColor = true;
            this.btAddPerson.Click += new System.EventHandler(this.btAddPerson_Click);
            // 
            // btCorrect
            // 
            this.btCorrect.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btCorrect.Location = new System.Drawing.Point(784, 251);
            this.btCorrect.Name = "btCorrect";
            this.btCorrect.Size = new System.Drawing.Size(71, 52);
            this.btCorrect.TabIndex = 21;
            this.btCorrect.Text = "修正";
            this.btCorrect.UseVisualStyleBackColor = true;
            this.btCorrect.Click += new System.EventHandler(this.btCorrect_Click);
            // 
            // btDelete
            // 
            this.btDelete.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btDelete.Location = new System.Drawing.Point(861, 251);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(71, 52);
            this.btDelete.TabIndex = 21;
            this.btDelete.Text = "削除";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // ofdFileOpenDialog
            // 
            this.ofdFileOpenDialog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルFToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルFToolStripMenuItem
            // 
            this.ファイルFToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.データベース接続ToolStripMenuItem,
            this.色の設定ToolStripMenuItem,
            this.終了ToolStripMenuItem});
            this.ファイルFToolStripMenuItem.Name = "ファイルFToolStripMenuItem";
            this.ファイルFToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.ファイルFToolStripMenuItem.Text = "ファイル(F)";
            // 
            // データベース接続ToolStripMenuItem
            // 
            this.データベース接続ToolStripMenuItem.Name = "データベース接続ToolStripMenuItem";
            this.データベース接続ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.データベース接続ToolStripMenuItem.Text = "データベース接続";
            this.データベース接続ToolStripMenuItem.Click += new System.EventHandler(this.データベース接続ToolStripMenuItem_Click);
            // 
            // 色の設定ToolStripMenuItem
            // 
            this.色の設定ToolStripMenuItem.Name = "色の設定ToolStripMenuItem";
            this.色の設定ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.色の設定ToolStripMenuItem.Text = "色の設定";
            this.色の設定ToolStripMenuItem.Click += new System.EventHandler(this.色の設定ToolStripMenuItem_Click);
            // 
            // 終了ToolStripMenuItem
            // 
            this.終了ToolStripMenuItem.Name = "終了ToolStripMenuItem";
            this.終了ToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.終了ToolStripMenuItem.Text = "終了";
            this.終了ToolStripMenuItem.Click += new System.EventHandler(this.終了ToolStripMenuItem_Click);
            // 
            // pbModeSelect
            // 
            this.pbModeSelect.Location = new System.Drawing.Point(853, 40);
            this.pbModeSelect.Name = "pbModeSelect";
            this.pbModeSelect.Size = new System.Drawing.Size(67, 23);
            this.pbModeSelect.TabIndex = 25;
            this.pbModeSelect.Text = "★";
            this.pbModeSelect.UseVisualStyleBackColor = true;
            this.pbModeSelect.Click += new System.EventHandler(this.pbModeSelect_Click_1);
            // 
            // infosys202212DataSet
            // 
            this.infosys202212DataSet.DataSetName = "infosys202212DataSet";
            this.infosys202212DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // carReportDbBindingSource
            // 
            this.carReportDbBindingSource.DataMember = "CarReportDb";
            this.carReportDbBindingSource.DataSource = this.infosys202212DataSet;
            // 
            // carReportDbTableAdapter
            // 
            this.carReportDbTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CarReportDbTableAdapter = this.carReportDbTableAdapter;
            this.tableAdapterManager.UpdateOrder = CarReportSystem.infosys202212DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // carReportDbDataGridView
            // 
            this.carReportDbDataGridView.AllowUserToAddRows = false;
            this.carReportDbDataGridView.AutoGenerateColumns = false;
            this.carReportDbDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carReportDbDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewImageColumn1});
            this.carReportDbDataGridView.DataSource = this.carReportDbBindingSource;
            this.carReportDbDataGridView.Location = new System.Drawing.Point(122, 363);
            this.carReportDbDataGridView.MultiSelect = false;
            this.carReportDbDataGridView.Name = "carReportDbDataGridView";
            this.carReportDbDataGridView.ReadOnly = true;
            this.carReportDbDataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.carReportDbDataGridView.RowTemplate.Height = 21;
            this.carReportDbDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carReportDbDataGridView.Size = new System.Drawing.Size(744, 183);
            this.carReportDbDataGridView.TabIndex = 26;
            this.carReportDbDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.carReportDbDataGridView_DataError);
            this.carReportDbDataGridView.Click += new System.EventHandler(this.carReportDbDataGridView_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Authcr";
            this.dataGridViewTextBoxColumn3.HeaderText = "Authcr";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Maker";
            this.dataGridViewTextBoxColumn4.HeaderText = "Maker";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CarName";
            this.dataGridViewTextBoxColumn5.HeaderText = "CarName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Report";
            this.dataGridViewTextBoxColumn6.HeaderText = "Report";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.DataPropertyName = "Image";
            this.dataGridViewImageColumn1.HeaderText = "Image";
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // btClear
            // 
            this.btClear.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btClear.Location = new System.Drawing.Point(882, 373);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(71, 38);
            this.btClear.TabIndex = 27;
            this.btClear.Text = "クリア";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btSearchAuther
            // 
            this.btSearchAuther.Location = new System.Drawing.Point(576, 316);
            this.btSearchAuther.Name = "btSearchAuther";
            this.btSearchAuther.Size = new System.Drawing.Size(75, 31);
            this.btSearchAuther.TabIndex = 28;
            this.btSearchAuther.Text = "名前検索";
            this.btSearchAuther.UseVisualStyleBackColor = true;
            this.btSearchAuther.Click += new System.EventHandler(this.btSearchAuther_Click);
            // 
            // tbSearchAuther
            // 
            this.tbSearchAuther.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbSearchAuther.Location = new System.Drawing.Point(657, 316);
            this.tbSearchAuther.Name = "tbSearchAuther";
            this.tbSearchAuther.Size = new System.Drawing.Size(235, 31);
            this.tbSearchAuther.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 770);
            this.Controls.Add(this.tbSearchAuther);
            this.Controls.Add(this.btSearchAuther);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.carReportDbDataGridView);
            this.Controls.Add(this.pbModeSelect);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btCorrect);
            this.Controls.Add(this.btAddPerson);
            this.Controls.Add(this.pbPicture);
            this.Controls.Add(this.btPictureClear);
            this.Controls.Add(this.btPictureOpen);
            this.Controls.Add(this.tbReport);
            this.Controls.Add(this.gbMaker);
            this.Controls.Add(this.cbCarName);
            this.Controls.Add(this.cbAuther);
            this.Controls.Add(this.dtpRegistDate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ID";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.gbMaker.ResumeLayout(false);
            this.gbMaker.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPicture)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infosys202212DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDbBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carReportDbDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpRegistDate;
        private System.Windows.Forms.ComboBox cbAuther;
        private System.Windows.Forms.GroupBox gbMaker;
        private System.Windows.Forms.RadioButton rbOther;
        private System.Windows.Forms.RadioButton rbOutsidecar;
        private System.Windows.Forms.RadioButton rbSubaru;
        private System.Windows.Forms.RadioButton rbHonda;
        private System.Windows.Forms.RadioButton rbNissann;
        private System.Windows.Forms.RadioButton rbToyota;
        private System.Windows.Forms.ComboBox cbCarName;
        private System.Windows.Forms.TextBox tbReport;
        private System.Windows.Forms.Button btPictureOpen;
        private System.Windows.Forms.Button btPictureClear;
        private System.Windows.Forms.PictureBox pbPicture;
        private System.Windows.Forms.Button btAddPerson;
        private System.Windows.Forms.Button btCorrect;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.OpenFileDialog ofdFileOpenDialog;
        private System.Windows.Forms.SaveFileDialog sfdSaveDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色の設定ToolStripMenuItem;
        private System.Windows.Forms.ColorDialog cdColorSelect;
        private System.Windows.Forms.Button pbModeSelect;
        private infosys202212DataSet infosys202212DataSet;
        private System.Windows.Forms.BindingSource carReportDbBindingSource;
        private infosys202212DataSetTableAdapters.CarReportDbTableAdapter carReportDbTableAdapter;
        private infosys202212DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView carReportDbDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ToolStripMenuItem データベース接続ToolStripMenuItem;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btSearchAuther;
        private System.Windows.Forms.TextBox tbSearchAuther;
        private System.Windows.Forms.ToolStripMenuItem 終了ToolStripMenuItem;
    }
}

