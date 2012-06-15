using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CMBCHINALib;


namespace testmerchantdll
{
    /// <summary>
    /// 1���½����̣��ڹ��̵������У�ѡ��������á����ڵ����ĶԻ�����ѡ���������
    /// �ڱ���ϵͳ��Ѱ��CMBChina.dll�ļ���ѡ�в����ȷ����
    /// 2������Ҫʹ��CMBChina.dll�еķ����Ĵ����cs�ļ����ϲ�����ӡ�using CMBCHINALib;����䡣
    /// 3������Ҫʹ��CMBChina.dll�еķ����ĵط����� CMBCHINALib.FirmClientClass ʵ����fc���������Զ�;
    /// 4�����з�����ʹ�õ��������ɵ���fc�����á�
    /// </summary>
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            //txths.Text = "99.1.101.64";
            txths.Text="netpay.cmbchina.com";   //֧�����ص�ַ����
            txtbr.Text = "0571";                //�̻����ڷ��кţ����滻�����ķ��к�
            txtco.Text = "000000";              //�̻��ţ����滻�������̻���
            txtpwd.Text = "000000";             //�̻����룬���滻�������̻�����

        }
        /// <summary>
        /// ʵ���̻���¼����
        /// ������Ҫ����exSetOptions����������֧�����ص�ַ
        /// Ȼ�����exLoginC���������ò�����¼ϵͳ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            CMBCHINALib.FirmClientClass fc;
            short r;
            Form1 fm;
            fc = new FirmClientClass();
            fc.exSetOptions(this.txths.Text.Trim(), "");//����ϵͳ��֧������
            r = fc.exLoginC(txtbr.Text, txtco.Text, txtpwd.Text);//��¼ϵͳ
            if  (r!= 0) {
                MessageBox.Show(fc.exGetLastErr(r));
                return;
            }
            fm = new Form1();
            fm.m_fc = fc;
            fm.m_cono = txtco.Text;
            this.Hide();
            fm.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}