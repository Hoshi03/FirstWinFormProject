using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace singleProcess
{
    internal static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {

            bool mutexLock = false;
            Mutex mutex = new Mutex(true, Assembly.GetEntryAssembly().FullName, out mutexLock);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            ////이미 동일 프로세스가 생성되어있는지 체크하고 없을때만 새 프로세스 생성
            //if (mutexLock == true) {
            //    Application.EnableVisualStyles();
            //    Application.SetCompatibleTextRenderingDefault(false);
            //    Application.Run(new Form1());
            //}

            //else
            //{
            //    MessageBox.Show("Already running!", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}



        }
    }
}
