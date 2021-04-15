using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Mysql
{
    class Mysql
    {
        static string connectStr = "server=127.0.0.1;port=3306;database=user;user=root;password=password;SslMode=none;";
        public static MySqlConnection sqlConnect = new MySqlConnection(connectStr);
        public static void ConnectOpen()  //打开连接
        {
            try
            {
                sqlConnect.Open();
                MessageBox.Show( "数据库连接成功");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message,"数据库连接出错");
            }
        }

        public static void Insert(string admin,string password)  //增加
        {
            string sqlCommon = "insert into user (`admin`,`password`) values ('" + admin + "','" + password + "')";
            MessageBox.Show(sqlCommon, "数据库增加用户");
            MySqlCommand Common = new MySqlCommand(sqlCommon,sqlConnect);
            MySqlDataReader reader = Common.ExecuteReader();
        }

        public static void Update(string admin, string password)  //修改
        {
            string sqlCommon = "update user set password = '" + password + "' where admin = '" + admin + "'";
            MessageBox.Show(sqlCommon, "数据库修改用户密码");
            MySqlCommand Common = new MySqlCommand(sqlCommon, sqlConnect);
            MySqlDataReader reader = Common.ExecuteReader();
        }

        public static void Select(string admin, string password)  //查询
        {
            string sqlCommon = "select * from user where admin = '" + admin + "' and password = '" + password + "'";
            MessageBox.Show(sqlCommon, "数据库查询用户");
            MySqlCommand Common = new MySqlCommand(sqlCommon, sqlConnect);
            MySqlDataReader reader = Common.ExecuteReader();
            if(reader.Read())
            {
                MessageBox.Show("账号密码正确", "数据库查询用户");
            }
            else
            {
                MessageBox.Show("账号密码错误", "数据库查询用户");
            }
        }

        public static void Delete(string admin)  //删除
        {
            string sqlCommon = "delete from user where admin = '" + admin + "'";
            MessageBox.Show(sqlCommon, "数据库删除用户");
            MySqlCommand Common = new MySqlCommand(sqlCommon, sqlConnect);
            try
            {
                MySqlDataReader reader = Common.ExecuteReader();
                MessageBox.Show("删除成功", "数据库删除用户");
            }
            catch(Exception e)
            {
                MessageBox.Show("无此账号", "数据库删除用户");
            }
        }
    }
}
