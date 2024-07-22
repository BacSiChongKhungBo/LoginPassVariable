namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        UserService s = new UserService();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //lấy nội dung của các ô textbox cần thiết
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            MessageBox.Show(s.FindUser(username, password));
            //Sau khi hiển thị thông báo
            //=> tắt form hiện tại + mở form mới
            this.Hide(); //Ẩn form đăng nhập
            Form2 f2 = new Form2(username); //Khai báo và khởi tạo form 2
            f2.ShowDialog(); //Như 1 thông báo, 
            //Nếu là ShowDialog => code sẽ tạm dừng ở đây cho đến khi nào tắt form đi
            //f2.Show(); Hiển thị 1 form mới độc lập, code ở form hiện tại vẫn tiếp tục chạy
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //lấy nội dung của các ô textbox cần thiết
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            MessageBox.Show(s.FindUser(username, password));
            //Sau khi hiển thị thông báo
            //=> tắt form hiện tại + mở form mới
            this.Hide(); //Ẩn form đăng nhập
            Form3 f3;
            f3 = new Form3();
            f3.Username = username;
            f3.Show();
        }
    }
}
