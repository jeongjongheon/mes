using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace MES
{
    public partial class OrderInfoForm : Form
    {
        MySqlConnection mySqlConnection = new MySqlConnection
            ("datasource=localhost;port=3307;database=mes;username=root;password=111111");
        MySqlCommand mySqlCommand;
        MySqlDataAdapter mySqlDataAdapter;

        OrderForm orderForm;

        public OrderInfoForm()
        {
            InitializeComponent();
        }

        private void OrderInfoForm_Load(object sender, EventArgs e)
        {

            showData();
        }

        private void showData()
        {

            string selectQuery =
                "SELECT * FROM ORDER_INFO_HEAD";

            mySqlCommand = new MySqlCommand(selectQuery, mySqlConnection);

            mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            orderInfoHeadDgv.DataSource = dataTable;

            // 컬럼 헤더 텍스트 변경
            //orderInfoHeadDgv.Columns[0].HeaderText = "아이디";
            //orderInfoHeadDgv.Columns[1].HeaderText = "구분";
            //orderInfoHeadDgv.Columns["ORDER_DATE"].HeaderText = "주문일자";

            // 컬럼 위치 변경
            orderInfoHeadDgv.Columns["CUST_NO"].DisplayIndex = 2;

            orderInfoHeadDgv.Columns["CUST_NO"].Frozen = true;

        }

        private void orderInfoHeadDgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string selectString = orderInfoHeadDgv.CurrentRow.Cells[0].Value.ToString();
            string selectQuery =
                "SELECT * FROM ORDER_INFO_BODY WHERE ORDER_NO = '" + selectString + "';";

            mySqlCommand = new MySqlCommand(selectQuery, mySqlConnection);

            mySqlDataAdapter = new MySqlDataAdapter(mySqlCommand);

            DataTable dataTable = new DataTable();
            mySqlDataAdapter.Fill(dataTable);

            orderInfoBodyDgv.DataSource = dataTable;

        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            orderForm = new OrderForm();
            orderForm.Show();
        }

        private void orderInfoHeadDgv_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            StringFormat sf = new StringFormat();
            sf.FormatFlags = StringFormatFlags.DirectionRightToLeft;
            using (Brush brush = new SolidBrush(Color.Black))
            {
                e.Graphics.DrawString(
                    (e.RowIndex + 1).ToString(),
                    e.InheritedRowStyle.Font,
                    brush,
                    e.RowBounds.Location.X + 30,
                    e.RowBounds.Location.Y + 4,
                    sf
                    );
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable originDt = (DataTable)orderInfoHeadDgv.DataSource;
            DataTable modifyDt;
            mySqlConnection.Open();
            modifyDt = originDt.GetChanges(DataRowState.Modified);
            if (modifyDt != null)
            {
                for (int i = 0; i < modifyDt.Rows.Count; i++)
                {
                    mySqlCommand.CommandText = 
                        "UPDATE ORDER_INFO_HEAD " +
                        "SET ORDER_GUBUN = '" + 
                        modifyDt.Rows[i]["ORDER_GUBUN"] + "' " +
                        "WHERE ORDER_NO = '" +
                        modifyDt.Rows[i]["ORDER_NO"] + "'";
                    mySqlCommand.ExecuteNonQuery();
                }
            }
            mySqlConnection.Close();
            showData();
        }

        private void excelExportBtn_Click(object sender, EventArgs e)
        {
            // 엑셀파일로 저장
            Microsoft.Office.Interop.Excel.Application xcelApp = 
                new Microsoft.Office.Interop.Excel.Application();
            xcelApp.Application.Workbooks.Add(Type.Missing);

            // 엑셀 서식 지정
            string rangStr = "A2:A" + (orderInfoHeadDgv.Rows.Count);
            MessageBox.Show(rangStr);
            Microsoft.Office.Interop.Excel.Range range =
                xcelApp.get_Range(rangStr, Type.Missing);
            range.NumberFormat = "0";

            // Head Text 설정
            for (int i = 1; i < orderInfoHeadDgv.Columns.Count + 1; i++){
                xcelApp.Cells[1, i] = orderInfoHeadDgv.Columns[i - 1].HeaderText;
            }

            // 데이터 설정
            for (int i = 0; i < orderInfoHeadDgv.Rows.Count - 1; i++){
                for (int j = 0; j < orderInfoHeadDgv.Columns.Count; j++){
                    xcelApp.Cells[i + 2, j + 1] = 
                        orderInfoHeadDgv.Rows[i].Cells[j].Value.ToString();
                }
            }
            xcelApp.Columns.AutoFit();
            xcelApp.Visible = true;

        }
    }
}
