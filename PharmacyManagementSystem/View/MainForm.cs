using System.Windows.Forms;
using Guna.UI2.WinForms;
using PharmacyManagementSystem.View.Goods;
using Timer = System.Windows.Forms.Timer;

namespace PharmacyManagementSystem
{
    public partial class MainForm : Form
    {
        private Dictionary<Panel, Timer> panelTimers = new Dictionary<Panel, Timer>();
        private Dictionary<Control, bool> mouseStates = new Dictionary<Control, bool>();
        public MainForm()
        {
            InitializeComponent();

            //Show drop down list
            ConfigureHoverEvents(pnHangHoa, btnHangHoa);
            ConfigureHoverEvents(pnGiaoDich, btnGiaoDich);
            ConfigureHoverEvents(pnDoiTac, btnDoiTac);
            ConfigureHoverEvents(pnNhanVien, btnNhanVien);
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

        // Hàm cấu hình sự kiện cho một cặp Button và Panel
        private void ConfigureHoverEvents(Panel panel, Guna2Button button)
        {
            // Đặt panel ban đầu ẩn
            panel.Visible = false;

            // Sử dụng Timer để kiểm tra vị trí chuột
            Timer timer = new Timer { Interval = 100 }; // Kiểm tra mỗi 100ms
            timer.Tick += (s, args) =>
            {
                Point cursorPosition = Cursor.Position;

                // Lấy vị trí và kích thước của Button và Panel trên màn hình
                Rectangle panelBounds = panel.RectangleToScreen(panel.ClientRectangle);
                Rectangle buttonBounds = button.RectangleToScreen(button.ClientRectangle);

                // Tạo vùng bao quanh Button và Panel
                Rectangle hitArea = Rectangle.Union(panelBounds, buttonBounds);

                // Nếu chuột nằm ngoài vùng hit-test, ẩn Panel
                if (!hitArea.Contains(cursorPosition))
                {
                    panel.Visible = false;
                    timer.Stop(); // Dừng Timer
                }
            };

            // Sự kiện chuột cho Button
            button.MouseEnter += (s, args) =>
            {
                panel.Visible = true; // Hiển thị Panel
                timer.Stop();         // Dừng kiểm tra tự động
            };

            button.MouseLeave += (s, args) =>
            {
                if (!panel.Bounds.Contains(button.PointToClient(Cursor.Position))) // Kiểm tra chuột có thật sự rời button
                {
                    timer.Start(); // Bắt đầu kiểm tra tự động
                }
            };

            // Sự kiện chuột cho Panel
            panel.MouseEnter += (s, args) =>
            {
                timer.Stop(); // Dừng kiểm tra tự động khi chuột vào Panel
            };

            panel.MouseLeave += (s, args) =>
            {
                if (!button.Bounds.Contains(panel.PointToClient(Cursor.Position))) // Kiểm tra chuột có thật sự rời panel
                {
                    timer.Start(); // Bắt đầu kiểm tra tự động
                }
            };
        }

        // Hàm kiểm tra và ẩn panel
        //private void CheckPanelVisibility(Guna2Button button, Panel panel)
        //{
        //    if (!mouseStates[button] && !mouseStates[panel])
        //    {
        //        panel.Visible = false; // Ẩn panel nếu chuột không nằm trên cả button và panel
        //    }
        //}


        private void btnThuoc_Click(object sender, EventArgs e)
        {
            CreateFormChild(new Product());
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            //CreateFormChild(new MedicineCategoryAdd());
        }
        
    }
}
