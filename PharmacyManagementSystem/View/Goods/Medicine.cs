using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyManagementSystem.View.Goods
{
    public partial class Medicine : Form
    {
        public Medicine()
        {
            InitializeComponent();
        }
        // Open form child
        private void OpenChildForm(Form childForm)
        {
            // Lấy tọa độ tuyệt đối của Panel
            Point panelLocation = pnLeft.PointToScreen(Point.Empty);

            // Đặt vị trí và hiển thị form con
            childForm.StartPosition = FormStartPosition.Manual; // Sử dụng chế độ định vị thủ công
            childForm.Location = panelLocation; // Gán tọa độ tuyệt đối của Panel cho form con

            childForm.ShowDialog(this); // Hiển thị form con dưới dạng modal

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenChildForm(new MedicineDetail());
        }
    }
}
