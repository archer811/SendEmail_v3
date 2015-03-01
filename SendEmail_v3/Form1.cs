using System;
using System.Collections.Generic;
using System.Windows.Forms;
using GetData;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace SendEmail_v3
{
    public partial class MainForm : Form
    {
        public Data mydata = new Data();
        private int up_index, down_index;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //页面更新时数据更新
            mydata = new Data();

            //左边人名加载
            foreach(Person singlePerson in mydata.Personlist)
            {
                Names.Items.Add(singlePerson.name);
            }
            Names.Text = "选择";

            //右边打勾列表加载
            foreach (Person singlePerson in mydata.Personlist)
            {
                Checks.Items.Add(singlePerson.name);
            }
            up_index = 0;
            down_index = 0;
        }
        
        //当选择了新的选项时 把表里的行都删除
        private void clear()
        {
            while(up_index>0)
            {
                up_index--;
                mydata.dt.Rows.RemoveAt(up_index);
            }
            while (down_index > 0)
            {
                down_index--;
                mydata.dt2.Rows.RemoveAt(down_index);
            }
        }
        private void Names_SelectedIndexChanged(object sender, EventArgs e)
        {
            clear();
            int x = Names.SelectedIndex;            
            List<Project> list = mydata.personProject[x].Projects;
            foreach (Project pj in list)
            {
                mydata.dt.Rows.Add(new object[] { pj.appid, pj.name, pj.engName });
                up_index++;
                Error error = mydata.work[pj.appid];
                mydata.dt2.Rows.Add(new object[] { pj.appid, error.name, error.type, error.time, error.reason });
                down_index++;
            }
            up.AutoGenerateColumns = true;
            up.DataSource = mydata.dt;

            down.AutoGenerateColumns = true;
            down.DataSource = mydata.dt2;

            mydata.dt.BeginLoadData();
            mydata.dt2.BeginLoadData();
             
        }

        private void submit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Checks.Items.Count; i++)
            {
                if (Checks.GetItemChecked(i))
                {
                    MessageBox.Show(Checks.GetItemText(Checks.Items[i]));
                }
            }
            SendMailUseZj();
        }

        public void SendMailUseZj() 
        { 
            System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage(); 
            msg.To.Add("zhouxj327@sina.com"); 
            msg.To.Add("2427396824@qq.com"); 
            /* 
             * msg.To.Add("b@b.com"); 
             * msg.To.Add("b@b.com"); 
             * msg.To.Add("b@b.com");可以发送给多人 
             */ 
            //msg.CC.Add("c@c.com"); 
            /* 
            * msg.CC.Add("c@c.com"); 
            * msg.CC.Add("c@c.com");可以抄送给多人 
            */ 
            msg.From = new MailAddress("a@a.com", "AlphaWu", System.Text.Encoding.UTF8); 
            /* 上面3个参数分别是发件人地址（可以随便写），发件人姓名，编码*/ 
            msg.Subject = "这是测试邮件";//邮件标题 
            msg.SubjectEncoding = System.Text.Encoding.UTF8;//邮件标题编码 
            msg.Body = "邮件内容";//邮件内容 
            msg.BodyEncoding = System.Text.Encoding.UTF8;//邮件内容编码 
            msg.IsBodyHtml = true;//是否是HTML邮件 
            msg.Priority = MailPriority.High;//邮件优先级 

            System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient("smtp.163.com");
            client.Credentials = new System.Net.NetworkCredential("***@163.com", "**"); 
            //在zj.com注册的邮箱和密码 
            client.Host = "smtp.163.com";
            client.EnableSsl = false;
            object userState = msg; 
            try 
            { 
            client.SendAsync(msg, userState); 
            //简单一点儿可以client.Send(msg); 
            MessageBox.Show("发送成功"); 
            } 
            catch (System.Net.Mail.SmtpException ex) 
            { 
            MessageBox.Show(ex.Message, "发送邮件出错"); 
            } 
        }


    }
}
