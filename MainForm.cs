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
    public partial class MainForm : Form
    {
        OrderInfoForm orderInfoForm;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private Form ShowForm(Form form, Type type)
        {
            if (form == null) {
                form = (Form)Activator.CreateInstance(type);
                form.MdiParent = this;
                form.WindowState = FormWindowState.Maximized;
                form.Show();
            } else {
                if (form.IsDisposed) {
                    form = (Form)Activator.CreateInstance(type);
                    form.MdiParent = this;
                    form.WindowState = FormWindowState.Maximized;
                    form.Show();
                } else {
                    form.Activate();
                }
            }
            return form;
        }

        private void 주문내역ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                if (this.ActiveMdiChild != orderInfoForm) {
                    ActiveMdiChild.Close();
                }

                orderInfoForm 
                    = ShowForm(orderInfoForm, typeof(OrderInfoForm))
                    as OrderInfoForm;
            } else { 
                orderInfoForm
                    = ShowForm(orderInfoForm, typeof(OrderInfoForm))
                    as OrderInfoForm;
            }
        }
    }
}
