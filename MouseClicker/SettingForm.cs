using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MouseClicker
{
    public partial class SettingForm : Form
    {
        public SettingForm(MainForm.Setting setting = null)
        {
            InitializeComponent();

            cbxClickButton.Items.Clear();
            cbxClickButton.Items.AddRange(new[] { "Left", "Middle", "Right", });

            if (setting is null)
            {
                return;
            }

            cbCntrl.Checked = setting.Mod_C;
            cbShift.Checked = setting.Mod_S;
            cbAlt.Checked = setting.Mod_A;
            txtKeyCode.Text = setting.KeyCode.ToString();
            nudCursorPosX.Value = setting.CursorPosX;
            nudCursorPosY.Value = setting.CursorPosY;
            cbxClickButton.Text = setting.MouseButton.ToString();
            nudClickCount.Value = setting.ClickCount;
            nudClickIntervalMs.Value = setting.ClickIntervalMs;
        }

        public MainForm.Setting Result { get; private set; }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKeyCode.Text))
            {
                MessageBox.Show(this, "ホットキーが入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(cbxClickButton.Text))
            {
                MessageBox.Show(this, "クリックボタンが選択されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var keyConverter = new EnumConverter(typeof(Keys));
            var key = (Keys)keyConverter.ConvertFromString(txtKeyCode.Text);

            var mouseButtonConverter = new EnumConverter(typeof(MouseButtons));
            var mouseButton = (MouseButtons)mouseButtonConverter.ConvertFromString(cbxClickButton.Text);

            Result = new MainForm.Setting()
            {
                Enabled = false,
                Mod_C = cbCntrl.Checked,
                Mod_S = cbShift.Checked,
                Mod_A = cbAlt.Checked,
                KeyCode = key,
                CursorPosX = Convert.ToInt32(nudCursorPosX.Value),
                CursorPosY = Convert.ToInt32(nudCursorPosY.Value),
                MouseButton = mouseButton,
                ClickCount = Convert.ToInt32(nudClickCount.Value),
                ClickIntervalMs = Convert.ToInt32(nudClickIntervalMs.Value),
            };

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
