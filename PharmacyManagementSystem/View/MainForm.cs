using Guna.UI2.WinForms;
using PharmacyManagementSystem.View.Goods;

namespace PharmacyManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //Show drop down list
            showPanelChild(pnHangHoa, btnHangHoa);
        }
        // Fill child form
        private void CreateFormChild(Form form)
        {
            // Kiểm tra nếu đã có form nào khác trong pnChild
            foreach (Control ctrl in pnChild.Controls)
            {
                if (ctrl is Form existingForm)
                {
                    existingForm.Close();
                    pnChild.Controls.Remove(existingForm);
                    break;
                }
            }

            form.TopLevel = false;
            pnChild.Controls.Add(form);
            form.Show();
        }
        private void btnThuoc_Click(object sender, EventArgs e)
        {
            CreateFormChild(new Medicine());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            CreateFormChild(new MedicineCategory());
        }
       
        // Show drop down list
        private void HidePanelIfMouseNotOver(Panel panel, Guna2Button button)
        {
            // Kiểm tra chuột có nằm ngoài cả panel và button hay không
            if (!panel.Bounds.Contains(PointToClient(MousePosition)) &&
                !button.Bounds.Contains(PointToClient(MousePosition)))
            {
                panel.Visible = false; // Ẩn panel nếu chuột nằm ngoài cả hai
            }
        }
        private void showPanelChild(Panel panel, Guna2Button button)
        {
            // Đảm bảo panel và button luôn gắn sự kiện
            button.MouseEnter += (s, e) => panel.Visible = true;
            button.MouseLeave += (s, e) => HidePanelIfMouseNotOver(panel, button);

            panel.MouseEnter += (s, e) => { /* Không làm gì, giữ panel hiện */ };
            panel.MouseLeave += (s, e) => HidePanelIfMouseNotOver(panel, button);

        }
        
    }
}
