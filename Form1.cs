using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParkingReportApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnViewReport_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var data = db.ParkingLots
                    .Select(pl => new
                    {
                        TenBaiDo = pl.Name,
                        DiaChi = pl.Address,
                        TongLuotGui = pl.Tickets.Count()
                    }).ToList();

                if (data.Count == 0 || data.All(x => x.TongLuotGui == 0))
                {
                    MessageBox.Show("Không có dữ liệu", "Thông báo");
                    dgvReport.DataSource = null;
                    return;
                }

                dgvReport.DataSource = data;
            }
        }

        private void dgvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
