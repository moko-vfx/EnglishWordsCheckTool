namespace MT_WordCheck
{
	partial class Form1
	{
		/// <summary>
		/// 必要なデザイナー変数です。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 使用中のリソースをすべてクリーンアップします。
		/// </summary>
		/// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.btnRef = new System.Windows.Forms.Button();
			this.tbPath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.btnRead = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblMean = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.btnAnswer = new System.Windows.Forms.Button();
			this.panelLabel = new System.Windows.Forms.Panel();
			this.cbOmit = new System.Windows.Forms.CheckBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.lblWordEx2 = new System.Windows.Forms.TextBox();
			this.lblWord = new System.Windows.Forms.TextBox();
			this.lblWordEx1 = new System.Windows.Forms.TextBox();
			this.lblMeanEx2 = new System.Windows.Forms.Label();
			this.lblMeanEx1 = new System.Windows.Forms.Label();
			this.lblWordPoS = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.btn_GoogleT = new System.Windows.Forms.Button();
			this.rbChkEn = new System.Windows.Forms.RadioButton();
			this.rbChkJp = new System.Windows.Forms.RadioButton();
			this.btnClose = new System.Windows.Forms.Button();
			this.lblNo = new System.Windows.Forms.Label();
			this.cbShuffle = new System.Windows.Forms.CheckBox();
			this.btn_GoogleI = new System.Windows.Forms.Button();
			this.groupBox3.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnRef
			// 
			this.btnRef.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btnRef.Location = new System.Drawing.Point(29, 37);
			this.btnRef.Name = "btnRef";
			this.btnRef.Size = new System.Drawing.Size(59, 27);
			this.btnRef.TabIndex = 1;
			this.btnRef.TabStop = false;
			this.btnRef.Text = "参照";
			this.btnRef.UseVisualStyleBackColor = true;
			this.btnRef.Click += new System.EventHandler(this.BtnRef_Click);
			// 
			// tbPath
			// 
			this.tbPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPath.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.tbPath.Location = new System.Drawing.Point(100, 37);
			this.tbPath.Name = "tbPath";
			this.tbPath.Size = new System.Drawing.Size(511, 27);
			this.tbPath.TabIndex = 1;
			this.tbPath.TabStop = false;
			this.tbPath.Text = "WordsSet01.txt";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(221, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "① 英単語データを指定してください";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.label2.Location = new System.Drawing.Point(12, 86);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(325, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "② チェック内容を選んで開始ボタンを押してください";
			// 
			// btnRead
			// 
			this.btnRead.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.btnRead.Location = new System.Drawing.Point(29, 112);
			this.btnRead.Name = "btnRead";
			this.btnRead.Size = new System.Drawing.Size(59, 27);
			this.btnRead.TabIndex = 1;
			this.btnRead.TabStop = false;
			this.btnRead.Text = "開始";
			this.btnRead.UseVisualStyleBackColor = true;
			this.btnRead.Click += new System.EventHandler(this.BtnRead_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.label3.Location = new System.Drawing.Point(17, 29);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 36);
			this.label3.TabIndex = 1;
			this.label3.Text = "単語";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.label4.Location = new System.Drawing.Point(17, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(39, 36);
			this.label4.TabIndex = 1;
			this.label4.Text = "訳";
			// 
			// lblMean
			// 
			this.lblMean.AutoSize = true;
			this.lblMean.BackColor = System.Drawing.Color.Transparent;
			this.lblMean.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblMean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.lblMean.Location = new System.Drawing.Point(94, 120);
			this.lblMean.Name = "lblMean";
			this.lblMean.Size = new System.Drawing.Size(72, 41);
			this.lblMean.TabIndex = 1;
			this.lblMean.Text = "試験";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.label7.Location = new System.Drawing.Point(72, 29);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(25, 36);
			this.label7.TabIndex = 1;
			this.label7.Text = ":";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("メイリオ", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.label8.Location = new System.Drawing.Point(72, 123);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(25, 36);
			this.label8.TabIndex = 1;
			this.label8.Text = ":";
			// 
			// btnAnswer
			// 
			this.btnAnswer.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.btnAnswer.Location = new System.Drawing.Point(29, 411);
			this.btnAnswer.Name = "btnAnswer";
			this.btnAnswer.Size = new System.Drawing.Size(223, 50);
			this.btnAnswer.TabIndex = 1;
			this.btnAnswer.TabStop = false;
			this.btnAnswer.Text = "答えを見る / 次の問題";
			this.btnAnswer.UseVisualStyleBackColor = true;
			this.btnAnswer.Click += new System.EventHandler(this.BtnAnswer_Click);
			// 
			// panelLabel
			// 
			this.panelLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(92)))), ((int)(((byte)(55)))));
			this.panelLabel.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panelLabel.Location = new System.Drawing.Point(0, 474);
			this.panelLabel.Name = "panelLabel";
			this.panelLabel.Size = new System.Drawing.Size(634, 5);
			this.panelLabel.TabIndex = 15;
			// 
			// cbOmit
			// 
			this.cbOmit.AutoSize = true;
			this.cbOmit.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.cbOmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.cbOmit.Location = new System.Drawing.Point(32, 384);
			this.cbOmit.Name = "cbOmit";
			this.cbOmit.Size = new System.Drawing.Size(286, 24);
			this.cbOmit.TabIndex = 1;
			this.cbOmit.TabStop = false;
			this.cbOmit.Text = "この単語は100%覚えたので次から省略する";
			this.cbOmit.UseVisualStyleBackColor = true;
			this.cbOmit.CheckedChanged += new System.EventHandler(this.CbOmit_CheckedChanged);
			// 
			// groupBox3
			// 
			this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupBox3.BackColor = System.Drawing.Color.Transparent;
			this.groupBox3.Controls.Add(this.lblWordEx2);
			this.groupBox3.Controls.Add(this.lblWord);
			this.groupBox3.Controls.Add(this.lblWordEx1);
			this.groupBox3.Controls.Add(this.label3);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.lblMeanEx2);
			this.groupBox3.Controls.Add(this.lblMeanEx1);
			this.groupBox3.Controls.Add(this.lblWordPoS);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label8);
			this.groupBox3.Controls.Add(this.lblMean);
			this.groupBox3.Font = new System.Drawing.Font("メイリオ", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.groupBox3.Location = new System.Drawing.Point(23, 149);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(587, 229);
			this.groupBox3.TabIndex = 1;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = " 問題 ";
			// 
			// lblWordEx2
			// 
			this.lblWordEx2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblWordEx2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
			this.lblWordEx2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblWordEx2.Font = new System.Drawing.Font("メイリオ", 12F);
			this.lblWordEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
			this.lblWordEx2.Location = new System.Drawing.Point(27, 91);
			this.lblWordEx2.Name = "lblWordEx2";
			this.lblWordEx2.Size = new System.Drawing.Size(545, 24);
			this.lblWordEx2.TabIndex = 2;
			this.lblWordEx2.Text = "An American satellite provided Japan with data about the weather.";
			this.lblWordEx2.WordWrap = false;
			// 
			// lblWord
			// 
			this.lblWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
			this.lblWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblWord.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Bold);
			this.lblWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.lblWord.Location = new System.Drawing.Point(101, 26);
			this.lblWord.Name = "lblWord";
			this.lblWord.Size = new System.Drawing.Size(348, 41);
			this.lblWord.TabIndex = 2;
			this.lblWord.Text = "Test";
			this.lblWord.WordWrap = false;
			// 
			// lblWordEx1
			// 
			this.lblWordEx1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblWordEx1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
			this.lblWordEx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lblWordEx1.Font = new System.Drawing.Font("メイリオ", 12F);
			this.lblWordEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
			this.lblWordEx1.Location = new System.Drawing.Point(28, 65);
			this.lblWordEx1.Name = "lblWordEx1";
			this.lblWordEx1.Size = new System.Drawing.Size(545, 24);
			this.lblWordEx1.TabIndex = 2;
			this.lblWordEx1.Text = "They wanted more money for the milk their cows produced.";
			this.lblWordEx1.WordWrap = false;
			// 
			// lblMeanEx2
			// 
			this.lblMeanEx2.AutoSize = true;
			this.lblMeanEx2.BackColor = System.Drawing.Color.Transparent;
			this.lblMeanEx2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblMeanEx2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
			this.lblMeanEx2.Location = new System.Drawing.Point(23, 185);
			this.lblMeanEx2.Name = "lblMeanEx2";
			this.lblMeanEx2.Size = new System.Drawing.Size(458, 24);
			this.lblMeanEx2.TabIndex = 1;
			this.lblMeanEx2.Text = "アメリカの人工衛星は日本に気象に関するデータを提供した。";
			// 
			// lblMeanEx1
			// 
			this.lblMeanEx1.AutoSize = true;
			this.lblMeanEx1.BackColor = System.Drawing.Color.Transparent;
			this.lblMeanEx1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblMeanEx1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(165)))), ((int)(((byte)(140)))));
			this.lblMeanEx1.Location = new System.Drawing.Point(23, 159);
			this.lblMeanEx1.Name = "lblMeanEx1";
			this.lblMeanEx1.Size = new System.Drawing.Size(538, 24);
			this.lblMeanEx1.TabIndex = 1;
			this.lblMeanEx1.Text = "彼らは自分の牛が生産したミルクに対してもっとお金を欲しいと思った。";
			// 
			// lblWordPoS
			// 
			this.lblWordPoS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblWordPoS.AutoSize = true;
			this.lblWordPoS.BackColor = System.Drawing.Color.Transparent;
			this.lblWordPoS.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblWordPoS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(170)))), ((int)(((byte)(100)))));
			this.lblWordPoS.Location = new System.Drawing.Point(517, 24);
			this.lblWordPoS.Name = "lblWordPoS";
			this.lblWordPoS.Size = new System.Drawing.Size(69, 41);
			this.lblWordPoS.TabIndex = 1;
			this.lblWordPoS.Text = "[動]";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "txt ファイル(*.txt)|*.txt|すべてのファイル(*.*)|*.*";
			// 
			// btn_GoogleT
			// 
			this.btn_GoogleT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_GoogleT.BackColor = System.Drawing.Color.White;
			this.btn_GoogleT.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_GoogleT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(140)))), ((int)(((byte)(200)))));
			this.btn_GoogleT.Location = new System.Drawing.Point(455, 384);
			this.btn_GoogleT.Name = "btn_GoogleT";
			this.btn_GoogleT.Size = new System.Drawing.Size(73, 27);
			this.btn_GoogleT.TabIndex = 1;
			this.btn_GoogleT.TabStop = false;
			this.btn_GoogleT.Text = "音声確認";
			this.btn_GoogleT.UseVisualStyleBackColor = false;
			this.btn_GoogleT.Click += new System.EventHandler(this.btn_GoogleT_Click);
			// 
			// rbChkEn
			// 
			this.rbChkEn.AutoSize = true;
			this.rbChkEn.Checked = true;
			this.rbChkEn.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.rbChkEn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.rbChkEn.Location = new System.Drawing.Point(100, 114);
			this.rbChkEn.Name = "rbChkEn";
			this.rbChkEn.Size = new System.Drawing.Size(131, 24);
			this.rbChkEn.TabIndex = 1;
			this.rbChkEn.TabStop = true;
			this.rbChkEn.Text = "日本語訳チェック";
			this.rbChkEn.UseVisualStyleBackColor = true;
			this.rbChkEn.CheckedChanged += new System.EventHandler(this.RbChkEn_CheckedChanged);
			// 
			// rbChkJp
			// 
			this.rbChkJp.AutoSize = true;
			this.rbChkJp.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.rbChkJp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.rbChkJp.Location = new System.Drawing.Point(236, 114);
			this.rbChkJp.Name = "rbChkJp";
			this.rbChkJp.Size = new System.Drawing.Size(105, 24);
			this.rbChkJp.TabIndex = 1;
			this.rbChkJp.Text = "英訳チェック";
			this.rbChkJp.UseVisualStyleBackColor = true;
			this.rbChkJp.CheckedChanged += new System.EventHandler(this.RbChkJp_CheckedChanged);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.btnClose.Location = new System.Drawing.Point(275, 411);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(118, 50);
			this.btnClose.TabIndex = 1;
			this.btnClose.TabStop = false;
			this.btnClose.Text = "チェック終了";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
			// 
			// lblNo
			// 
			this.lblNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblNo.BackColor = System.Drawing.Color.Transparent;
			this.lblNo.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.lblNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.lblNo.Location = new System.Drawing.Point(473, 132);
			this.lblNo.Name = "lblNo";
			this.lblNo.Size = new System.Drawing.Size(138, 24);
			this.lblNo.TabIndex = 1;
			this.lblNo.Text = "000 / 000";
			this.lblNo.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// cbShuffle
			// 
			this.cbShuffle.AutoSize = true;
			this.cbShuffle.Checked = true;
			this.cbShuffle.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbShuffle.Font = new System.Drawing.Font("メイリオ", 9.75F);
			this.cbShuffle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(185)))), ((int)(((byte)(180)))));
			this.cbShuffle.Location = new System.Drawing.Point(350, 115);
			this.cbShuffle.Name = "cbShuffle";
			this.cbShuffle.Size = new System.Drawing.Size(119, 24);
			this.cbShuffle.TabIndex = 1;
			this.cbShuffle.TabStop = false;
			this.cbShuffle.Text = "シャッフルする";
			this.cbShuffle.UseVisualStyleBackColor = true;
			this.cbShuffle.CheckedChanged += new System.EventHandler(this.CbOmit_CheckedChanged);
			// 
			// btn_GoogleI
			// 
			this.btn_GoogleI.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_GoogleI.BackColor = System.Drawing.Color.White;
			this.btn_GoogleI.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
			this.btn_GoogleI.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(140)))), ((int)(((byte)(10)))));
			this.btn_GoogleI.Location = new System.Drawing.Point(537, 384);
			this.btn_GoogleI.Name = "btn_GoogleI";
			this.btn_GoogleI.Size = new System.Drawing.Size(73, 27);
			this.btn_GoogleI.TabIndex = 16;
			this.btn_GoogleI.TabStop = false;
			this.btn_GoogleI.Text = "画像検索";
			this.btn_GoogleI.UseVisualStyleBackColor = false;
			this.btn_GoogleI.Click += new System.EventHandler(this.btn_GoogleI_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
			this.ClientSize = new System.Drawing.Size(634, 479);
			this.Controls.Add(this.btn_GoogleI);
			this.Controls.Add(this.lblNo);
			this.Controls.Add(this.rbChkJp);
			this.Controls.Add(this.rbChkEn);
			this.Controls.Add(this.btn_GoogleT);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.cbShuffle);
			this.Controls.Add(this.cbOmit);
			this.Controls.Add(this.panelLabel);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnAnswer);
			this.Controls.Add(this.btnRead);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbPath);
			this.Controls.Add(this.btnRef);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximumSize = new System.Drawing.Size(1000, 518);
			this.MinimumSize = new System.Drawing.Size(600, 518);
			this.Name = "Form1";
			this.Text = "English Words Check Tool v1.02";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRef;
		private System.Windows.Forms.TextBox tbPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		public System.Windows.Forms.Button btnRead;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblMean;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		public System.Windows.Forms.Button btnAnswer;
		private System.Windows.Forms.Panel panelLabel;
		private System.Windows.Forms.CheckBox cbOmit;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button btn_GoogleT;
		private System.Windows.Forms.RadioButton rbChkEn;
		private System.Windows.Forms.Label lblMeanEx2;
		private System.Windows.Forms.Label lblMeanEx1;
		private System.Windows.Forms.Label lblWordPoS;
		private System.Windows.Forms.RadioButton rbChkJp;
		public System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Label lblNo;
		private System.Windows.Forms.CheckBox cbShuffle;
		private System.Windows.Forms.TextBox lblWordEx1;
		private System.Windows.Forms.TextBox lblWordEx2;
		private System.Windows.Forms.TextBox lblWord;
		private System.Windows.Forms.Button btn_GoogleI;
	}
}

