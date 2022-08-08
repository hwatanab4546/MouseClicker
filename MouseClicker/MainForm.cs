using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace MouseClicker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // 起動時にMainFormを表示させないようにApplication.Run()をいじった場合、
            // 最初にMainFormが起動されるまでLoad()は実行されないので、
            // コンストラクタで定義しておくのが無難

            SettingLoad();

            foreach (var s in Settings)
            {
                HotKeys.Add(s.GenHotKey());
            }

            dataGridView1.DataSource = Settings;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                return;
            }
            var index = dataGridView1.SelectedRows[0].Index;
            if (index < 1)
            {
                return;
            }

            dataGridView1.DataSource = null;

            Settings.SwapElements(index - 1, index);
            HotKeys.SwapElements(index - 1, index);

            dataGridView1.DataSource = Settings;

            SettingSave();
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                return;
            }
            var index = dataGridView1.SelectedRows[0].Index;
            if (index < 0 || index >= dataGridView1.Rows.Count - 1)
            {
                return;
            }

            dataGridView1.DataSource = null;

            Settings.SwapElements(index, index + 1);
            HotKeys.SwapElements(index, index + 1);

            dataGridView1.DataSource = Settings;

            SettingSave();
        }

        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                return;
            }
            var index = dataGridView1.SelectedRows[0].Index;

            if (Settings[index].Enabled)
            {
                Settings[index].Enabled = false;

                HotKeys[index].Dispose();
                HotKeys[index] = null;
            }
            else
            {
                Settings[index].Enabled = true;

                HotKeys[index] = Settings[index].GenHotKey();
            }
            dataGridView1.Refresh();

            SettingSave();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            using (var dlg = new SettingForm())
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                dataGridView1.DataSource = null;

                Settings.Add(dlg.Result);
                HotKeys.Add(null);

                dataGridView1.DataSource = Settings;
            }

            SettingSave();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                return;
            }
            var index = dataGridView1.SelectedRows[0].Index;

            using (var dlg = new SettingForm(Settings[index]))
            {
                if (dlg.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                // 一度ホットキーを無効にしてから・・・
                if (Settings[index].Enabled)
                {
                    Settings[index].Enabled = false;

                    HotKeys[index].Dispose();
                    HotKeys[index] = null;
                }

                // ・・・設定を更新する
                Settings[index] = dlg.Result;

                dataGridView1.Refresh();
            }

            SettingSave();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 1)
            {
                return;
            }
            var index = dataGridView1.SelectedRows[0].Index;

            if (MessageBox.Show($"{index + 1}行目の設定を削除します。よろしいですか？", "確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                return;
            }

            if (Settings[index].Enabled)
            {
                Settings[index].Enabled = false;

                HotKeys[index].Dispose();
                HotKeys[index] = null;
            }

            dataGridView1.DataSource = null;

            Settings.RemoveAt(index);
            HotKeys.RemoveAt(index);

            dataGridView1.DataSource = Settings;

            SettingSave();
        }

        //CellPaintingイベントハンドラ
        private void DataGridView1_CellPainting(object sender,
            DataGridViewCellPaintingEventArgs e)
        {
            //列ヘッダーかどうか調べる
            if (e.ColumnIndex < 0 && e.RowIndex >= 0)
            {
                //セルを描画する
                e.Paint(e.ClipBounds, DataGridViewPaintParts.All);

                //行番号を描画する範囲を決定する
                //e.AdvancedBorderStyleやe.CellStyle.Paddingは無視しています
                Rectangle indexRect = e.CellBounds;
                indexRect.Inflate(-2, -2);
                //行番号を描画する
                TextRenderer.DrawText(e.Graphics,
                    (e.RowIndex + 1).ToString(),
                    e.CellStyle.Font,
                    indexRect,
                    e.CellStyle.ForeColor,
                    TextFormatFlags.Right | TextFormatFlags.VerticalCenter);
                //描画が完了したことを知らせる
                e.Handled = true;
            }
        }

        [JsonObject]
        public class Setting
        {
            [JsonProperty]
            [DisplayName("有効/無効")]
            public bool Enabled { get; set; }
            [JsonProperty]
            [DisplayName("Cntrl修飾")]
            public bool Mod_C { get; set; }
            [JsonProperty]
            [DisplayName("Shift修飾")]
            public bool Mod_S { get; set; }
            [JsonProperty]
            [DisplayName("Alt修飾")]
            public bool Mod_A { get; set; }
            [JsonProperty]
            [DisplayName("キー名称")]
            public Keys KeyCode { get; set; }
            [JsonProperty]
            [DisplayName("マウスカーソルX座標")]
            public int CursorPosX { get; set; }
            [JsonProperty]
            [DisplayName("マウスカーソルY座標")]
            public int CursorPosY { get; set; }
            [JsonProperty]
            [DisplayName("クリックボタン")]
            public MouseButtons MouseButton { get; set; }
            [JsonProperty]
            [DisplayName("クリック回数")]
            public int ClickCount { get; set; }
            [JsonProperty]
            [DisplayName("クリック間隔(ミリ秒)")]
            public int ClickIntervalMs { get; set; }

            public HotKey GenHotKey()
            {
                if (Enabled)
                {
                    var modKeys = MOD_KEY.None;
                    if (Mod_C) modKeys |= MOD_KEY.CONTROL;
                    if (Mod_S) modKeys |= MOD_KEY.SHIFT;
                    if (Mod_A) modKeys |= MOD_KEY.ALT;

                    var hk = new HotKey(modKeys, KeyCode);
                    hk.HotKeyPush += (s, e) => mouseClick(CursorPosX, CursorPosY, ClickCount, MouseButton, ClickIntervalMs);

                    return hk;
                }
                else
                {
                    return null;
                }
            }

            private static void mouseClick(int x, int y, int clickCount = 1, MouseButtons mouseButton = MouseButtons.Left, int clickIntervalMilliseconds = 50)
            {
                int dFlag, uFlag;
                switch (mouseButton)
                {
                    case MouseButtons.Left:
                        dFlag = NativeMethods.MOUSEEVENTF_LEFTDOWN;
                        uFlag = NativeMethods.MOUSEEVENTF_LEFTUP;
                        break;
                    case MouseButtons.Right:
                        dFlag = NativeMethods.MOUSEEVENTF_RIGHTDOWN;
                        uFlag = NativeMethods.MOUSEEVENTF_RIGHTUP;
                        break;
                    case MouseButtons.Middle:
                        dFlag = NativeMethods.MOUSEEVENTF_MIDDLEDOWN;
                        uFlag = NativeMethods.MOUSEEVENTF_MIDDLEUP;
                        break;
                    default:
                        throw new ArgumentException("The value must be Left, Right, or Middle", nameof(mouseButton));
                }
                var clickInterval = new TimeSpan(0, 0, 0, 0, clickIntervalMilliseconds);

                // 指定された座標にマウスカーソルを移動
                Cursor.Position = new System.Drawing.Point(x, y);

                var mousePosition = new Win32Point();

                // マウスポインタの現在位置を取得する。
                NativeMethods.GetCursorPos(ref mousePosition);

                // マウスポインタの現在位置でマウスの左ボタンの押し下げ・押し上げを連続で行うためのパラメータを設定する。
                var inputs = new INPUT[] {
                    new INPUT {
                        type = NativeMethods.INPUT_MOUSE,
                        ui = new INPUT_UNION {
                            mouse = new MOUSEINPUT {
                                dwFlags = dFlag,
                                dx = mousePosition.X,
                                dy = mousePosition.Y,
                                mouseData = 0,
                                dwExtraInfo = IntPtr.Zero,
                                time = 0
                            }
                        }
                    },
                    new INPUT {
                        type = NativeMethods.INPUT_MOUSE,
                        ui = new INPUT_UNION {
                            mouse = new MOUSEINPUT {
                                dwFlags = uFlag,
                                dx = mousePosition.X,
                                dy = mousePosition.Y,
                                mouseData = 0,
                                dwExtraInfo = IntPtr.Zero,
                                time = 0
                            }
                        }
                    }
                };

                // 指定された時間化間隔を空けて、指定された回数だけマウス動作を繰り返す
                while (clickCount-- > 0)
                {
                    // 設定したパラメータに従ってマウス動作を行う。
                    NativeMethods.SendInput(2, ref inputs[0], Marshal.SizeOf(inputs[0]));

                    Thread.Sleep(clickInterval);
                }
            }
        }

        private static readonly List<Setting> Settings = new List<Setting>()
        {
            new Setting { Enabled = true, Mod_C = false, Mod_S = false, Mod_A = false, KeyCode = Keys.F1, CursorPosX = 0, CursorPosY = 0, MouseButton = MouseButtons.Left, ClickCount = 1, ClickIntervalMs = 50, },
            new Setting { Enabled = true, Mod_C = false, Mod_S = false, Mod_A = false, KeyCode = Keys.F2, CursorPosX = 990, CursorPosY = 540, MouseButton = MouseButtons.Left, ClickCount = 2, ClickIntervalMs = 50, },
        };
        private static readonly List<HotKey> HotKeys = new List<HotKey>();

        #region 設定ファイル入出力

        private const string settingFile = "settings.json";

        private void SettingLoad()
        {
            if (System.IO.File.Exists(settingFile))
            {
                Settings.Clear();

                using (var sr = new System.IO.StreamReader(settingFile))
                {
                    Settings.AddRange(JsonConvert.DeserializeObject<Setting[]>(sr.ReadToEnd()));
                }
            }
        }

        private void SettingSave()
        {
            using (var sw = new System.IO.StreamWriter(settingFile, false))
            {
                sw.Write(JsonConvert.SerializeObject(Settings, Formatting.Indented));
            }
        }

        #endregion

        #region タスクバー通知領域アイコン関連

        private void dispHideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Visible = !Visible;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        protected override void WndProc(ref Message m)
        {
            //※下記例は、最小化ボタンクリックで、FormをHideするだけの処理にしている。
            //　最小化されません！
            //　その他の場合には、既定の処理をさせる！→base.WndProc(ref m) ;
            //　Msgが、WM_SYSCOMMAND(0x112)
            //　WParamが、SC_MINIMIZE(0xF020)
            if ((m.Msg == 0x112) && (m.WParam == (IntPtr)0xF020))
            {
                Hide();
            }
            else
            {
                base.WndProc(ref m);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // MainFormが終了したらアプリも終了させる

            Application.Exit();
        }

        #endregion
    }

    static class Extensions
    {
        public static void SwapElements<T>(this IList<T> list, int index1, int index2)
        {
            (list[index2], list[index1]) = (list[index1], list[index2]);
        }
    }
}
