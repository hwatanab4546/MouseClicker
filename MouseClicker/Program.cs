using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseClicker
{
    internal static class Program
    {
        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());

            // 起動時にMainForm()を表示させない
            // MainFormを閉じてもアプリは終了しないという噂なので、注意が必要
            // 起動直後から最初にフォームが表示されるまで、MainForm.Load()に書いたコードは実行されない
            using (new MainForm())
            {
                Application.Run();
            }
        }
    }
}
