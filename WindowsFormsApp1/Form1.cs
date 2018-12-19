using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewLife.RocketMQ;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private EventingBasicConsumer consumer = null;
        private IConnection connection = null;
        private IModel channel = null;
        delegate void ShowInfo(string msg);
        ConnectionFactory factory;
        public Form1()
        {
            InitializeComponent();
            factory = new ConnectionFactory();
            factory.HostName = "192.168.57.15";
            factory.UserName = "yy";
            factory.Password = "hello";
            factory.AutomaticRecoveryEnabled = true;
            connection = factory.CreateConnection();
           
            channel = connection.CreateModel();
           
            Run();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1.1.实例化连接工厂
            var factory = new ConnectionFactory() { HostName = "192.168.57.15"  };
            factory.UserName = "yy";
            factory.Password = "hello";
            //2. 建立连接
            using (var connection = factory.CreateConnection())
            {
                //3. 创建信道
                using (var channel = connection.CreateModel())
                {
                    //4. 申明队列
                    channel.QueueDeclare(queue: "hello", durable: false, exclusive: false, autoDelete: false, arguments: null);
                    //5. 构建byte消息数据包
                    string message =  "Hello RabbitMQ! 中文消息。";
                    var body = Encoding.UTF8.GetBytes(message);
                    //6. 发送数据包
                    channel.BasicPublish(exchange: "", routingKey: "hello", basicProperties: null, body: body);
                   MessageBox.Show(string.Format(" [x] Sent {0}", message),"tooltip");
                    listBox1.Items.Add(string.Format(" [x] Sent {0}", message));
                }
               
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

      
          
        }

        public void Run()
        {
            //  using (var connection = factory.CreateConnection())
            // {
            //using (var channel = connection.CreateModel())
            // {
 
            channel.QueueDeclare("hello", false, false, false, null);

                    if (consumer == null)
                    {
                        consumer = new EventingBasicConsumer(channel);
                    }
                    
                    consumer.Received += (model, ea) =>
                    {
                        var msgBody = Encoding.UTF8.GetString(ea.Body);
                        string msg = string.Format("***接收时间:{0}，消息内容：{1}", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), msgBody);

                        AddItem(msg);
                        //   listBox1.Items.Add();
                        //Console.WriteLine();
                    };
                    channel.BasicConsume("hello", true, consumer);
                    // channel.BasicConsume(  "hello",true, consumer: consumer);
               // }
           // }
        }

        public void AddItem(string msg)
        {
            if (!listBox1.InvokeRequired)
            {
                listBox1.Items.Add(msg);
            }
            else
            {
                ShowInfo showProgress = new ShowInfo(AddItem);
                // 如使用Invoke会等到函数调用结束，而BeginInvoke不会等待直接往后走
                this.BeginInvoke(showProgress, new object[] {  msg });
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            channel.Dispose();
            connection.Close();
        }
    }
}
