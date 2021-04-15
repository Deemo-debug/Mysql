using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mysql.ConnectOpen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //增
            Mysql.Insert("王晨煜", "1813001006"); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //改
            Mysql.Update("王晨煜", "8888");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //查
            Mysql.Select("王晨煜","8888");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //删
            Mysql.Delete("王晨煜");
        }
    }
}
