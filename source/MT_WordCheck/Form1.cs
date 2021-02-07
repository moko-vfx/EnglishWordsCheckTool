using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MT_WordCheck
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// 変数
		// DataTableを宣言
		DataTable dt = new DataTable("単語");
		// DataRowを宣言
		DataRow dr;
		// 英単語データを正しく読み込めたか
		bool loaded = false;
		// 英単語データ数
		int cnt;
		// 英単語データから省略しない数
		int notOmitCnt;
		// ランダムID
		int[] ary;
		int[] rdm;
		// 出題No
		int now = 0;
		// 省略せず出題したNo
		int notOmitNow = 0;
		// 英語チェックモードかどうか
		bool en = true;

		// ロードイベント
		private void Form1_Load(object sender, EventArgs e)
		{
			// 列を追加
			dt.Columns.Add("単語", typeof(string));
			dt.Columns.Add("意味", typeof(string));
			dt.Columns.Add("品詞", typeof(string));
			dt.Columns.Add("例文en1", typeof(string));
			dt.Columns.Add("例文en2", typeof(string));
			dt.Columns.Add("例文jp1", typeof(string));
			dt.Columns.Add("例文jp2", typeof(string));
			dt.Columns.Add("省略en", typeof(string));
			dt.Columns.Add("省略jp", typeof(string));

			// カレントディレクトリの設定
			openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();

			// 単語と訳を空欄にする
			lblWord.Text = "";
			lblWordPoS.Text = "";
			lblWordEx1.Text = "";
			lblWordEx2.Text = "";
			lblMean.Text = "";
			lblMeanEx1.Text = "";
			lblMeanEx2.Text = "";

			// 出題Noを非表示にする
			lblNo.Visible = false;
		}
		
		// ボタン：英単語データを参照する
		private void BtnRef_Click(object sender, EventArgs e)
		{
			// ダイアログを表示
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
			{
				tbPath.Text = openFileDialog1.FileName;
			}
		}

		// ラジオボタン：日本語訳チェック
		private void RbChkEn_CheckedChanged(object sender, EventArgs e)
		{
			if (rbChkEn.Checked)
			{
				rbChkJp.Checked = false;
			}
			else
			{
				rbChkJp.Checked = true;
			}
		}

		// ラジオボタン：英訳チェック
		private void RbChkJp_CheckedChanged(object sender, EventArgs e)
		{
			if (rbChkJp.Checked)
			{
				rbChkEn.Checked = false;
			}
			else
			{
				rbChkEn.Checked = true;
			}
		}

		// ボタン：開始
		private void BtnRead_Click(object sender, EventArgs e)
		{
			LoadData();

			if (loaded)
			{
				StartCheck();
			}
		}

		// ボタン：答えを見る / 次の問題
		private void BtnAnswer_Click(object sender, EventArgs e)
		{
			// 英単語データが正常に読み込まれていない場合
			if (!loaded)
			{
				MessageBox.Show("先に英単語データを読み込んでください");
				return;
			}

			// 英単語データがMAXを超えていたら
			if (now >= cnt)
			{
				MessageBox.Show("開始ボタンを押してください");
				return;
			}

			//************************//
			// 日本語訳チェックの場合 //
			//************************//
			if (rbChkEn.Checked)
			{
				// 訳が表示されていない場合は表示する
				if (lblMean.Text == "")
				{
					ShowEnChkJp();
				}
				// 訳が表示されていた場合は次の問題を表示する
				else
				{
					// 次回省略にチェックが入っていた場合
					if (cbOmit.Checked == true)
					{
						// 省略フラグをテーブルに反映
						EnableOmit(7);
					}

					now++;
					notOmitNow++;

					// 英単語データがMAXを超えたら
					if (now >= cnt)
					{
						MessageBox.Show("問題が一巡したので終了します");
						reset();
						return;
					}

					// 省略チェック
					if (!ChkOmit(7))
					{
						MessageBox.Show("残り全ての単語が省略する設定になっているので\r\n" +
										"これで終了します");

						reset();
						now = cnt;
						RbEnabled();
						return;
					}

					UpdateLabel();
					ShowEnChkEn();
				}
			}
			//************************//
			// 　英訳チェックの場合　 //
			//************************//
			else
			{
				// 訳が表示されていない場合は表示する
				if (lblWord.Text == "")
				{
					ShowJpChkEn();
				}
				// 訳が表示されていた場合は次の問題を表示する
				else
				{
					// 次回省略にチェックが入っていた場合
					if (cbOmit.Checked == true)
					{
						// 省略フラグをテーブルに反映
						EnableOmit(8);
					}

					now++;
					notOmitNow++;

					// 英単語データがMAXを超えたら
					if (now >= cnt)
					{
						MessageBox.Show("問題が一巡したので終了します");
						reset();
						return;
					}

					// 省略チェック
					if (!ChkOmit(8))
					{
						MessageBox.Show("残り全ての単語が省略する設定になっているので\r\n" +
										"これで終了します");

						reset();
						now = cnt;
						RbEnabled();
						return;
					}

					UpdateLabel();
					ShowJpChkJp();
				}
			}
		}

		// ボタン：Google翻訳
		private void btn_GoogleT_Click(object sender, EventArgs e)
		{
			string baseUrl = @"https://translate.google.com/?hl=ja#view=home&op=translate&sl=en&tl=ja&text=";
			string word = lblWord.Text;
			System.Diagnostics.Process.Start(baseUrl + word);
		}
		// ボタン：Google画像検索
		private void btn_GoogleI_Click(object sender, EventArgs e)
		{
			string baseUrl1 = @"https://www.google.co.jp/search?q=";
			string baseUrl2 = @"&tbm=isch";
			string word = lblWord.Text;
			System.Diagnostics.Process.Start(baseUrl1 + word + baseUrl2);
		}

		// ボタン：チェック終了
		private void BtnClose_Click(object sender, EventArgs e)
		{
			reset();

			now = cnt;
		}

		// チェックボックス：省略チェックに変更があった時
		private void CbOmit_CheckedChanged(object sender, EventArgs e)
		{
			if (cbOmit.Checked)
			{
				cbOmit.ForeColor = Color.FromArgb(100, 170, 230);

				// MessageBox.Show("この単語の出題は次回から省略します");
			}
			else
			{
				cbOmit.ForeColor = Color.FromArgb(190, 185, 180);
			}
		}

		// 関数：英単語データを読み込む
		private void LoadData()
		{
			// 英単語テーブルをクリア
			dt.Rows.Clear();

			string filePath = tbPath.Text;

			// 英単語データが存在する場合
			if (filePath != "" && File.Exists(filePath))
			{
				StreamReader sr = new StreamReader(filePath, Encoding.GetEncoding("Shift_JIS"));

				// データを読み込んでテーブルに登録
				while (sr.Peek() != -1)
				{
					string str = sr.ReadLine();
					string[] arr = str.Split("\t".ToCharArray());

					try
					{
						// 行を作成
						dr = dt.NewRow();
						dr["単語"] = arr[0];
						dr["意味"] = arr[1];
						dr["品詞"] = arr[2];
						dr["例文en1"] = arr[3];
						dr["例文en2"] = arr[4];
						dr["例文jp1"] = arr[5];
						dr["例文jp2"] = arr[6];
						dr["省略en"] = arr[7];
						dr["省略jp"] = arr[8];

						// 行を表に追加
						dt.Rows.Add(dr);
					}
					catch (Exception)
					{
						MessageBox.Show("デ－タエラーがあります");
					}
				}

				sr.Close();


				// 行数を取得
				cnt = dt.Rows.Count;

				// ランダムID生成用の配列
				ary = new int[cnt];
				for (int i = 0; i < cnt; i++)
				{
					ary[i] = i;
				}

				loaded = true;
			}
			else
			{
				MessageBox.Show("先に英単語データを読み込んでください");

				loaded = false;
			}
		}

		// 関数：最初の問題を出題する
		private void StartCheck()
		{
			// 出題Noをリセット
			now = 0;
			notOmitNow = 0;

			// シャッフルする設定ならシャッフルする
			if (cbShuffle.Checked)
			{
				rdm = ary.OrderBy(i => Guid.NewGuid()).ToArray();
			}
			else
			{
				rdm = ary;
			}

			// 英単語データが読み込み済みかチェック
			if (!loaded)
			{
				MessageBox.Show("正しい英単語データを指定しているか確認してください");
				return;
			}

			//************************//
			// 日本語訳チェックの場合 //
			//************************//
			if (rbChkEn.Checked)
			{
				if (!ChkOmit(7))
				{
					MessageBox.Show("全ての単語が省略する設定になっています");

					reset();
					now = cnt;
					RbEnabled();
					return;
				}
				else
				{
					// 出題Noを表示する
					lblNo.Visible = true;
					DataRow[] dRows = dt.Select("省略en = '0'");
					notOmitCnt = dRows.Count();
					notOmitNow = 1;
					UpdateLabel();

					// ラジオボタンを無効化
					RbDisabled();

					// 出題開始
					ShowEnChkEn();
				}
			}
			//************************//
			// 　英訳チェックの場合　 //
			//************************//
			else
			{
				if (!ChkOmit(8))
				{
					MessageBox.Show("全ての単語が省略する設定になっています");

					reset();
					now = cnt;
					RbEnabled();
					return;
				}
				else
				{
					// 出題Noを表示する
					lblNo.Visible = true;
					DataRow[] dRows = dt.Select("省略jp = '0'");
					notOmitCnt = dRows.Count();
					notOmitNow = 1;
					UpdateLabel();

					// ラジオボタンを無効化
					RbDisabled();

					// 出題開始
					ShowJpChkJp();
				}
			}
		}

		// 関数：ラジオボタンをグレーアウト
		private void RbDisabled()
		{
			if (rbChkEn.Checked)
			{
				rbChkJp.ForeColor = Color.FromArgb(100, 100, 100);
			}
			else
			{
				rbChkEn.ForeColor = Color.FromArgb(100, 100, 100);
			}
			
			rbChkEn.AutoCheck = false;
			rbChkJp.AutoCheck = false;
		}

		// 関数：ラジオボタンを元に戻す
		private void RbEnabled()
		{
			rbChkJp.ForeColor = Color.FromArgb(190, 185, 180);
			rbChkEn.ForeColor = Color.FromArgb(190, 185, 180);

			rbChkEn.AutoCheck = true;
			rbChkJp.AutoCheck = true;
		}

		// 関数：リセット
		private void reset()
		{
			lblWord.Text = "";
			lblWordPoS.Text = "";
			lblWordEx1.Text = "";
			lblWordEx2.Text = "";
			lblMean.Text = "";
			lblMeanEx1.Text = "";
			lblMeanEx2.Text = "";

			// ラジオボタンを元に戻す
			RbEnabled();

			// チェックボックスを元に戻す
			cbOmit.Checked = false;

			// 出題Noを非表示にする
			lblNo.Visible = false;

			SaveText();
		}

		// 関数：日本語訳チェックモードで英単語を表示
		private void ShowEnChkEn()
		{
			// ランダムIDを表示
			int id = rdm[now];
			lblWord.Text = dt.Rows[id][0].ToString();
			lblWordPoS.Text = "[" + dt.Rows[id][2].ToString() + "]";
			lblWordEx1.Text = dt.Rows[id][3].ToString();
			lblWordEx2.Text = dt.Rows[id][4].ToString();
			lblMean.Text = "";
			lblMeanEx1.Text = "";
			lblMeanEx2.Text = "";
		}

		// 関数：日本語訳チェックモードで日本語訳を表示
		private void ShowEnChkJp()
		{
			// ランダムIDを表示
			int id = rdm[now];
			lblMean.Text = dt.Rows[id][1].ToString();
			lblMeanEx1.Text = dt.Rows[id][5].ToString();
			lblMeanEx2.Text = dt.Rows[id][6].ToString();
		}

		// 関数：英訳チェックモードで英単語を表示
		private void ShowJpChkEn()
		{
			// ランダムIDを表示
			int id = rdm[now];
			lblWord.Text = dt.Rows[id][0].ToString();
			lblWordEx1.Text = dt.Rows[id][3].ToString();
			lblWordEx2.Text = dt.Rows[id][4].ToString();
		}

		// 関数：英訳チェックモードで日本語訳を表示
		private void ShowJpChkJp()
		{
			// ランダムIDを表示
			int id = rdm[now];
			lblWord.Text = "";
			lblWordPoS.Text = "[" + dt.Rows[id][2].ToString() + "]";
			lblWordEx1.Text = "";
			lblWordEx2.Text = "";
			lblMean.Text = dt.Rows[id][1].ToString();
			lblMeanEx1.Text = dt.Rows[id][5].ToString();
			lblMeanEx2.Text = dt.Rows[id][6].ToString();
		}

		// 関数：省略チェック
		private bool ChkOmit(int columnsId)
		{
			int id;

			// 今の出題IDから順にチェック
			for (int i = now; i < cnt; i++)
			{
				id = rdm[i];

				// 省略しない場合
				if (dt.Rows[id][columnsId].ToString() == "0")
				{
					// now変数を更新
					now = i;

					return true;
				}
				else
				{
					// now変数を更新
					now = i;
				}
			}

			return false;
		}

		// 関数：省略の反映
		private void EnableOmit(int columnsId)
		{
			if (cbOmit.Checked)
			{
				// ランダムIDを表示
				int id = rdm[now];
				// テーブルに書き込み
				dt.Rows[id][columnsId] = "1";
				
				// チェックボックスを元に戻す
				cbOmit.Checked = false;
			}
		}

		// 関数：テーブルの書き込み
		private void SaveText()
		{
			try
			{
				// 出力設定
				StreamWriter sw = new StreamWriter(
					tbPath.Text,
					false, // 追記ではなく上書き
					Encoding.Default);

				// 文字列データ作成用
				StringBuilder sb = new StringBuilder();

				// テーブルの内容を全て文字列データに格納
				for (int i = 0; i < cnt; i++)
				{
					for (int j = 0; j < 9; j++)
					{
						if (j == 8)
						{
							// 最後のデータなので改行する
							sb.Append(dt.Rows[i][j].ToString() + "\r\n");
						}
						else
						{
							// 最後のデータではないのでタブスペースを入れる
							sb.Append(dt.Rows[i][j].ToString() + "\t");
						}
					}
				}

				// 書き込む
				sw.WriteLine(sb.ToString().TrimEnd('\r', '\n'));
				
				sw.Close();
			}
			catch (Exception)
			{
				MessageBox.Show("データの保存に失敗しました");
			}
		}
		
		// 関数：ラベルの更新
		private void UpdateLabel()
		{
			lblNo.Text = notOmitNow.ToString() + " / " + notOmitCnt.ToString();
		}

		// フォーム終了時に保存
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (loaded)
			{
				SaveText();
			}
		}
	}
}
