using NLog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventHandlerCheckApp
{
    public partial class MainForm : Form
    {
        static readonly Logger logger = LogManager.GetCurrentClassLogger();//추가
        public MainForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            var result = TxtUserID.Text + "\n" + TxtPassWord.Text;
            MessageBox.Show($"your ID n PWD is {result}");

            try
            {
                var val = TxtPassWord.Text.Substring(3, 2);//string split method
                MessageBox.Show($"{val}");
                logger.Info("execute complete");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occur");
                logger.Error("Error Occur");
                logger.Error($"{ex}");
                //throw;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //초기화...

            //logger
            logger.Info("Load MainForm");
        }
    }
}
