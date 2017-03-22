//  0.1     作成
//  0.1.1   前面固定チェックボックス追加
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MonthCounter
{
    public partial class formMonthCounter : Form
    {
        //定数
        const ushort INITIALCOUNTER =0;         //カウンター初期値
        const ushort COUNTVALUE = 1;            //カウント増減値
        const ushort LIMITMAX = 9999;           //カウンター最大値
        const ushort LIMITMIN = 0;              //カウンター最小値

        //変数
        private DateTime dateToday;             //本日の日付
        private ushort ushortTodayCount;        //今日のカウント数
        private ushort ushortYesterdayCount;    //昨日のカウント数
        private ushort ushortMonthCount;        //月累計のカウント数
        public formMonthCounter()
        {
            InitializeComponent();
            this.Location = new Point(Properties.Settings.Default.X, Properties.Settings.Default.Y);
            //カウント数日付初期化
            initialCountDate();
            //前面固定指定読み込み
            checkBoxTopMost.Checked = Properties.Settings.Default.TopMost;
            //Timer起動
            timerCheckDate.Start();
        }

        //月日付変更チェック
        private void checkChangeMonthDate()
        {
            DateTime dateNow = DateTime.Now.Date;
            //日付変更チェック
            if (dateToday != dateNow)
            {
                //年か月変更チェック
                if (dateToday.Year != dateNow.Year || dateToday.Month != dateNow.Month)
                {
                    //月をまたいだら月累計と昨日のカウント数初期化
                    ushortMonthCount = INITIALCOUNTER;
                    ushortYesterdayCount = INITIALCOUNTER;
                    textBoxMonthCount.Text = ushortMonthCount.ToString("0000");
                }
                //月をまたいでない場合、1日差なら今日のカウント数を昨日へコピー
                else if ((dateNow - dateToday).Days == 1) ushortYesterdayCount = ushortTodayCount;
                else ushortYesterdayCount = INITIALCOUNTER;
                //今日のカウント数を初期化
                ushortTodayCount = INITIALCOUNTER;
                labelDate.Text = dateNow.ToString("yyyy/MM/dd");
                textBoxYesterdayCount.Text = ushortYesterdayCount.ToString("0000");
                textBoxTodayCount.Text = ushortTodayCount.ToString("0000"); ;
                //日付の更新は最後に行う
                dateToday = dateNow;
            }
        }
        //カウント日付初期化
        private void initialCountDate()
        {
            ushortTodayCount = Properties.Settings.Default.TodayCount;
            ushortYesterdayCount = Properties.Settings.Default.YesterdayCount;
            ushortMonthCount = Properties.Settings.Default.MonthCount;
            textBoxTodayCount.Text = ushortTodayCount.ToString("0000");
            textBoxYesterdayCount.Text = ushortYesterdayCount.ToString("0000");
            textBoxMonthCount.Text = ushortMonthCount.ToString("0000");
            //今日の日付挿入 前回起動時と日付が変わっていたら日付変更チェックを入れる
            dateToday = Properties.Settings.Default.dateToday;
            checkChangeMonthDate();
            labelDate.Text = dateToday.ToString("yyyy/MM/dd");

        }

        //カウントの数値増減
        //CountUpDownがTrueならUp、FalseならDown
        private bool changeCount(TextBox textBoxCount,ref ushort ushortCount, bool CountUpDown)
        {
            if (CountUpDown)
            {
                //LIMITMAXを超えないようにする
                if (ushortCount == LIMITMAX)
                {
                    return false;
                }
                ushortCount += COUNTVALUE;
            }
            else
            {
                //LIMITMINを下回らないようにする
                if (ushortCount == LIMITMIN)
                {
                    return false;
                }
                ushortCount -= COUNTVALUE;
            }
            textBoxCount.Text = ushortCount.ToString("0000");
            return true;
        }

        private void timerCheckDate_Tick(object sender, EventArgs e)
        {
            //処理中タイマーを止める
            timerCheckDate.Stop();
            checkChangeMonthDate();
            //タイマーを再開する
            timerCheckDate.Start();
        }

        private void buttonTodayCountUp_Click(object sender, EventArgs e)
        {
            if (changeCount(textBoxTodayCount, ref ushortTodayCount, true))
            {
                changeCount(textBoxMonthCount, ref ushortMonthCount, true);
            }
        }

        private void buttonTodayCountDown_Click(object sender, EventArgs e)
        {
            
            
            if(changeCount(textBoxTodayCount, ref ushortTodayCount, false))
            {
                changeCount(textBoxMonthCount, ref ushortMonthCount, false);
            }
        }

        private void buttonYesterdayCountUp_Click(object sender, EventArgs e)
        {
            if (changeCount(textBoxYesterdayCount, ref ushortYesterdayCount, true))
            {
                changeCount(textBoxMonthCount, ref ushortMonthCount, true);
            }
        }

        private void buttonYesterdayCountDown_Click(object sender, EventArgs e)
        {
            if (changeCount(textBoxYesterdayCount, ref ushortYesterdayCount, false))
            {
                changeCount(textBoxMonthCount, ref ushortMonthCount, false);
            }
        }

        private void buttonMonthCountUp_Click(object sender, EventArgs e)
        {
            changeCount(textBoxMonthCount, ref ushortMonthCount, true);
        }

        private void buttonMonthCountDown_Click(object sender, EventArgs e)
        {
            changeCount(textBoxMonthCount, ref ushortMonthCount, false);
        }

        private void formMonthCounter_FormClosed(object sender, FormClosedEventArgs e)
        {
            //終了時に各値を保存する
            Properties.Settings.Default.X = this.Location.X;
            Properties.Settings.Default.Y = this.Location.Y;
            Properties.Settings.Default.TodayCount = ushortTodayCount;
            Properties.Settings.Default.YesterdayCount = ushortYesterdayCount;
            Properties.Settings.Default.MonthCount = ushortMonthCount;
            Properties.Settings.Default.dateToday = dateToday;
            Properties.Settings.Default.TopMost = checkBoxTopMost.Checked;
            Properties.Settings.Default.Save();
        }

        private void checkBoxTopMost_CheckedChanged(object sender, EventArgs e)
        {
            this.TopMost = checkBoxTopMost.Checked;
        }
    }
}
