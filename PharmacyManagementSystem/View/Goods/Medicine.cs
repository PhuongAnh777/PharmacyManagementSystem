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
            // Đặt vị trí xuất hiện của form con là chính giữa form chính
            childForm.StartPosition = FormStartPosition.Manual; // Đặt chế độ thủ công
            childForm.Location = new Point(
                this.Location.X + (this.Width - childForm.Width) / 2,
                this.Location.Y + (this.Height - childForm.Height) / 2
            );

            // Làm mờ form chính
            this.Opacity = 0.1;

            // Hiển thị form con dưới dạng modal
            childForm.ShowDialog();

            // Khôi phục độ trong suốt của form chính
            this.Opacity = 1.0;

        }

        private void gridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OpenChildForm(new MedicineDetail());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MedicineAdd());
        }
    }
}
