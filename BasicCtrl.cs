using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H.H.tool
{
    public partial class HouseHoldTool : Form
    {
        int nTotalAmount = 0;

        List<DateTime> datetimeList = new List<DateTime>();

        List<bool> bBdgtList = new List<bool>();

        List<int> AmountList = new List<int>();

        DialogResult judge;

        TglSwitch budgetTglSw;

        string strBudget = "";

        public HouseHoldTool()
        {
            InitializeComponent();
            AmountTxt.Maximum = long.MaxValue;
            TotalAmount.Text = 0.ToString("C");

            // トグルスイッチについての設定
            budgetTglSw = new TglSwitch();
            budgetTglSw.Location = new Point(275, 35);
            budgetTglSw.Size = new Size(40, 21);
            budgetTglSw.Cursor = Cursors.Hand;
            Controls.Add(budgetTglSw);
            budgetTglSw.Checked = false;

            // ショートカットキー使えると便利なのでオンにする。
            KeyPreview = true;
            // キーダウンイベントメソッドを使用する。
            KeyDown += HouseHold_KeyDown;
            // フォーム終了時のイベント
            FormClosing += HouseHold_Closing;
        }
        private void FixBtn_Click(object sender, EventArgs e)
        {
            DateTime HHdate = DateSelect.Value;
            int nMonth = HHdate.Month;
            int nDay   = HHdate.Day;

            if ((int)AmountTxt.Value > int.MaxValue || (int)AmountTxt.Value < int.MinValue)
            {
                MessageBox.Show( "異常な値が入力されました。",
                                 "無効な値です。",
                                 MessageBoxButtons.OK);
                return;
            }

            if (!budgetTglSw.Checked)
                strBudget = "支出";
            else
                strBudget = "収入";

            HH_List.Items.Add(nMonth.ToString("D2") + "月" + nDay.ToString("D2") + "日" + "  |  " + strBudget + "  |  " + AmountTxt.Value.ToString("C"));
            datetimeList.Add(HHdate);
            bBdgtList.Add(budgetTglSw.Checked);
            AmountList.Add((int)AmountTxt.Value);

            if (!budgetTglSw.Checked)
                nTotalAmount -= (int)AmountTxt.Value;
            else
                nTotalAmount += (int)AmountTxt.Value;

            if (nTotalAmount > int.MaxValue || nTotalAmount < int.MinValue)
            {
                MessageBox.Show( "本当にそんな収支あったんですか？",
                                 "合計値が異常です。",
                                 MessageBoxButtons.OK);

                HH_List.Items.RemoveAt(HH_List.Items.Count - 1);
                bBdgtList.    RemoveAt(bBdgtList.Count - 1);
                datetimeList. RemoveAt(datetimeList.Count - 1);

                AmountList.RemoveAt(AmountList.Count - 1);

                if (!budgetTglSw.Checked)
                    nTotalAmount += (int)AmountTxt.Value;
                else
                    nTotalAmount -= (int)AmountTxt.Value;

                return;
            }

            TotalAmount.Text = nTotalAmount.ToString("C");
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            judge = MessageBox.Show( "本当に削除しますか？",
                                     "選択項目を削除します。",
                                     MessageBoxButtons.YesNo);
            if (judge == DialogResult.No) return;

            if (HH_List.SelectedIndex == -1)
            {
                MessageBox.Show( "削除項目を選択してください。",
                                 "選択項目がありません。",
                                 MessageBoxButtons.OK);
                return;
            }

            while (HH_List.SelectedIndex > -1)
            {
                if (!bBdgtList[HH_List.SelectedIndex])
                        nTotalAmount += AmountList[HH_List.SelectedIndex];
                else
                        nTotalAmount -= AmountList[HH_List.SelectedIndex];
                TotalAmount.Text = nTotalAmount.ToString("C");
                datetimeList.RemoveAt(HH_List.SelectedIndex);
                bBdgtList.   RemoveAt(HH_List.SelectedIndex);
                AmountList.  RemoveAt(HH_List.SelectedIndex);
                HH_List.Items.RemoveAt(HH_List.SelectedIndex);
            }
        }
        /// </summary>
        /// キーダウン押下時イベント
        /// ShiftKey押下でStart_Stop
        /// ControlKey押下でLap_Reset
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HouseHold_KeyDown(object sender, KeyEventArgs e)
        {
            // Enter押下でFixボタン押下時イベント
            if (e.KeyCode == Keys.Enter)
                    FixBtn.PerformClick();
            // Delete押下でDeleteボタン押下時イベント
            if (e.KeyCode == Keys.Delete)
                    DeleteBtn.PerformClick();
            // Ctrl押下で支出⇔収入を切り替える。
            if (e.KeyCode == Keys.ControlKey)
            {
                if (budgetTglSw.Checked) budgetTglSw.Checked = false;
                else                     budgetTglSw.Checked = true;
            }
            // Escape押下でHouseHold_Closing
            if (e.KeyCode == Keys.Escape)
                    Close();
        }
        /// <summary>
        /// ウィンドウクローズ時確認メッセージ出力
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HouseHold_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (MessageBox.Show("本当に終了しますか？", "確認",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question)
                                    == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
