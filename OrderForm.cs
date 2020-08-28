using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MES
{
    public partial class OrderForm : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection
            ("datasource=localhost;port=3307;database=mes;username=root;password=111111");
        MySqlCommand mySqlCommand;
        MySqlDataAdapter mySqlDataAdapter;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string insertQuery =
                "START TRANSACTION; " +
                "INSERT INTO ORDER_INFO_HEAD(ORDER_NO) values('" 
                + orderNoTxt.Text + "');" +
                "INSERT INTO ORDER_INFO_BODY(DATA_ID,ORDER_NO) values(" 
                + dataIdTxt.Text + ",'" + orderNoTxt.Text + "');" +
                "COMMIT;";

            mySqlConnection.Open();
            mySqlCommand = new MySqlCommand(insertQuery, mySqlConnection);

            try
            {
                if (mySqlCommand.ExecuteNonQuery() == 1) {
                    MessageBox.Show("성공");
                }else{
                    MessageBox.Show("실패");
                }
            }catch (Exception ex) { MessageBox.Show(ex.Message); }


        }
    }
}
