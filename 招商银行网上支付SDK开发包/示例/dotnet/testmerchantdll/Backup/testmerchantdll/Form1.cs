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
    /// 
    /// </summary>
    public partial class Form1 : Form
    {
        public CMBCHINALib.FirmClientClass  m_fc;   //�̻���¼���ʵ��
        public string m_cono;   //��¼�µ�¼���̻���
        private short r;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            m_fc.exLogout ( );
            Application.Exit ( );
            
        }
        /// <summary>
        /// ���ܣ���ѯδ���˶���
        /// ��飺����exQueryUnsettledOrder�����õ�����δ���˶����������ڱ���objout�У�
        /// �����ַ������������Զ����ݽ��д���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnqus_Click(object sender, EventArgs e)
        {

            object objout = null;
            
            r = m_fc.exQueryUnsettledOrder(out objout);
            if (r != 0)
            {
                MessageBox.Show(m_fc.exGetLastErr(r));
               // m_fc.exLogout();
                return;

            }
            MessageBox.Show ( "Query OK !" );
            txtcontent.Text = objout.ToString ( ).Replace ( "\n", "\\n" );
            

        }
        /// <summary>
        /// ���ܣ���ѯһ��ʱ������ѽ��˶���
        /// ��飺����exQuerySettledOrder�����õ�һ��ָ��ʱ��εĽ��˶����������ڱ���objout�У�
        /// �����ַ������������Զ����ݽ��д���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            object objout = null;
            r = m_fc.exQuerySettledOrder ( dtpst.Text, dtpend.Text, out objout );
            
             if (r != 0) 
             {
                 MessageBox.Show(m_fc.exGetLastErr(r));
                 //m_fc.exLogout();
                 return;
                        
             }
           MessageBox.Show ( "Query OK!" );
           txtcontent.Text = objout.ToString().Replace("\n","\\n");
          

        }
        /// <summary>
        /// ���ܣ����ս����ղ�ѯ�����Ѿ����˶���
        /// ��飺����exQueryTransact�����õ����н��˶����������ڱ���objout�У�
        /// �����ַ������������Զ����ݽ��д���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            object objout = null;
            r = m_fc.exQueryTransact ( dtpst.Text, out objout );
            if (r != 0)
            {
                MessageBox.Show(m_fc.exGetLastErr(r));
               // m_fc.exLogout();
                return;
            }
            MessageBox.Show ( "Transact OK !" );
            txtcontent.Text = objout.ToString ( ).Replace ( "\n", "\\n" );
            

        }
        /// <summary>
        /// ���ܣ����ս������ڲ�ѯδ���˶���
        /// ��飺����exQueryUnsettledOrderByPage�������趨���β�ѯ�����ض�����Ŀ����ѯδ���˶�����
        /// �����ڱ���objout�У������ַ������������Զ����ݽ��д���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button6_Click(object sender, EventArgs e)
        {
            
           // StringBuilder s = new StringBuilder();
            object objout = null;
            r = m_fc.exQueryUnsettledOrderByPage(100, out objout);
            if( r!= 0){
                MessageBox.Show(m_fc.exGetLastErr(r));
                //m_fc.exLogout();
                return;
            }
            txtcontent.Text = objout.ToString ( ).Replace ( "\n", "\\n" );
            MessageBox.Show( "Query OK with nextpage flag=" + m_fc.exHasNextPage().ToString());
          
        }
        /// <summary>
        /// ���ܣ����ո����Ľ������ڶβ�ѯ�Ѿ����˶���
        /// ��飺����exQuerySettledOrderByPage�������趨���β�ѯ�����ض�����Ŀ����ѯ�Ѿ����˶�����
        /// �����ڱ���objout�У������ַ������������Զ����ݽ��д���        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button5_Click(object sender, EventArgs e)
        {
            object objout=null;
            r = m_fc.exQuerySettledOrderByPage ( dtpst.Text, dtpend.Text, 100, out objout );
            if( r!= 0)
            {
                MessageBox.Show( m_fc.exGetLastErr(r));
                //m_fc.exLogout();
                return;
            }
            txtcontent.Text = objout.ToString ( ).Replace ( "\n", "\\n" );
            MessageBox.Show("Query OK with nextpage flag=" + m_fc.exHasNextPage().ToString());
        }
        /// <summary>
        /// ���ܣ����ո����Ľ�����ʼ���ڲ�ѯ�Ѿ����˶���
        /// ��飺����exQueryTransactByPage�������趨���β�ѯ�����ض�����Ŀ����ѯ�Ѿ����˶�����
        /// �����ڱ���objout�У������ַ������������Զ����ݽ��д���       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click ( object sender, EventArgs e )
        {
            object objout=null;
            r = m_fc.exQueryTransactByPage ( dtpst.Text, 100, out objout );
            if(r!= 0)
            {
                MessageBox.Show(m_fc.exGetLastErr(r));
                //m_fc.exLogout();
                return;
            }
            txtcontent.Text = objout.ToString ( ).Replace ( "\n", "\\n" );
            MessageBox.Show ( "Query OK with nextpage flag=" + m_fc.exHasNextPage ( ) );//exHasNextPage()���жϵ�ǰҳ���Ƿ��к���ҳ������
        }
        /// <summary>
        /// ���ܣ��ڽ��з�ҳ��ѯ֮ǰ�������ȵ���һ��exPageReset(),����ѯ��¼����Ϊ��һҳ��
        /// Ȼ����Զ�ε��÷�ҳ��ѯ��ֱ������ȫ�����ݡ�
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button7_Click ( object sender, EventArgs e )
        {
            m_fc.exPageReset ( );
            MessageBox.Show ( "PageReset OK !" );

        }
        /// <summary>
        /// ���ܣ������̻���֤��
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button8_Click ( object sender, EventArgs e )
        {
            txtcontent.Text = m_fc.exGenMerchantCode("abc", "20031106", "0571", "001139", "000361", "0.01", 
                "md-merchantdata", "http://99.1.101.64/testserver/testserver.dll?MerchantAnswerWithPara","","" ).ToString();

        }
        /// <summary>
        /// ���ܣ������̻��š������ź�������ˮ�ŶԵ�һ�������н��˴���
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button10_Click ( object sender, EventArgs e )
        {
       string bill = "\0";
            string refno = "\0";

            getBillRef ( ref bill, ref refno );
            r = m_fc.exSettleOrder ( m_cono, bill, refno );//000354Ϊ�����̻��ţ��̻��ڴ˿��Ը���Ϊ�Լ����̻���
            if (r != 0)
            {
                MessageBox.Show ( m_fc.exGetLastErr ( r ) );
                return;
            }
            MessageBox.Show ( "Settle OK !" );
        }
        /// <summary>
        /// ���ܣ����ݽ������ںͶ����Ų�ѯ���ʶ����Ĵ�������
        /// ��ѯ���������objout�����У������ַ������������Զ����ݽ��д���  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button11_Click ( object sender, EventArgs e )
        {
           object objout=null;
           r = m_fc.exQuerySingleOrder ( dtpsingle.Text, singlebill.Text, out objout );
           if(r!=0)
           {
               MessageBox.Show(m_fc.exGetLastErr(r));
              // m_fc.exLogout();
               return;
           
           }
           objout.ToString ( ).Replace ( "\r\n", " " );
           MessageBox.Show ( "Query OK !" );
           txtcontent.Text = objout.ToString ( ).Replace ( "\n", "\\n" );
            

        }

        /// <summary>
        /// ���ܣ������̻��š������ź�������ˮ�Ų�ѯ��һ������¼�����Զ������г�������
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button12_Click ( object sender, EventArgs e )
        {
            string bill = "\0";
            string refno = "\0";
            if (txtcontent.SelectedText == "")
            {
                MessageBox.Show ( "û��ѡ���κ�һ������" );
                return;
            }

            getBillRef ( ref bill, ref refno );
            r = m_fc.exCancelOrder ( m_cono, bill, refno );
            if (r != 0)
            {
                MessageBox.Show ( m_fc.exGetLastErr ( r ) );
                return;
            }

            MessageBox.Show ( "Cancel OK !" );
        }
        /// <summary>
        /// ��ȡָ����¼�Ķ����źͶ�����ˮ��
        /// </summary>
        /// <param name="bill"></param>
        /// <param name="refno"></param>
        void getBillRef ( ref String bill, ref String refno )
    {
       
       //     String[,] s = new String[2,];
        char[] c = new char[1];
        c[0] = '|';
            string[] s=new string[2];
            string temp = txtcontent.SelectedText.Replace ("\\n", "|" );
            s = temp.Split ( c, StringSplitOptions.None );
        bill = s[0];
        refno = s[1];        
}
        /// <summary>
        /// ���ܣ������̻��š������ź�������ˮ�Ų�ѯ��һ������¼�����뱾�ν��˽��Զ������в��ֽ��˴���
        /// ���ν��˽��ܴ���ԭʼ������ 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button9_Click ( object sender, EventArgs e )
        {
            string newamount;
            string bill = "\0";
            string refno = "\0";
            newamount = Microsoft.VisualBasic.Interaction.InputBox ( "��������ʽ��", " ", Convert.ToString ( 0 ), this.Width / 2, this.Height / 2 );
            getBillRef ( ref bill, ref refno );
            r = m_fc.exSettlePartOrder ( m_cono, bill, refno, newamount );
            if (r != 0)
            {
                MessageBox.Show ( m_fc.exGetLastErr ( r ) );
                return;
            }
            MessageBox.Show ( "Partial Settle OK !" );

        }

        private void Form1_FormClosing ( object sender, FormClosingEventArgs e )
        {
           
        }

        private void Form1_FormClosed ( object sender, FormClosedEventArgs e )
        {
            m_fc.exLogout ( );
            Application.Exit ( );

        }

    
       
       
    }
}