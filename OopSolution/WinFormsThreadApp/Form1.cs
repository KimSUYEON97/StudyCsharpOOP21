using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsThreadApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10000;

            /*for (int i = 0; i <= 100000; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(50);//50ms 걸리는 처리할 일 존재,
                                 //loading걸리게 된다, 내부적 처리가 필요한 코드는 작성하지 않는다.


            }*/ //응답없음 발생

            //thread로 분리! 화면 스레드와 처리 스레드의 분리
            Thread th = new Thread(() =>
            {
                for (int i = 0; i <= 10000; i++)
                {
                    //progressBar1.Value = i;//에러 수정방식? -> progressBar1.BeginInvoke 비동기 호출 메소드 이용
                    progressBar1.BeginInvoke(//cross thread문제를 해결해준다. 화면thread와 처리스레드가 분리되었는데, 화면thread에 접근하려고 하는 것을 도와주는 역할
                        new Action(() =>
                        {
                            progressBar1.Value = i;
                        }));
                    Thread.Sleep(5);
                    //Thread.Sleep(5);//50ms 걸리는 처리할 일 존재,
                    //loading걸리게 된다, 내부적 처리가 필요한 코드는 작성하지 않는다.
                }
            }); //응답없음 발생 안함
            th.IsBackground = true;//bqckground로 실행 여부 
            th.Start();
        }
    }
}
