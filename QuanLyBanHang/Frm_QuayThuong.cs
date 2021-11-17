using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class Frm_QuayThuong : Form
    {
        string[] FullNames;
        string[] FullImageName;

        int count;
        int times;

        public Frm_QuayThuong()
        {
            InitializeComponent();
            Initialize();
        }
        private void Initialize()
        {
            BackgroundImage = Image.FromFile(@"F:\DoAnCNPM\Quan Ly Cua Hang Ban Balo\QuanLyBanHang\Resources\aabb.jpg");
            picturegift.Image = Image.FromFile(@"F:\DoAnCNPM\Quan Ly Cua Hang Ban Balo\QuanLyBanHang\Resources\dau hoi.jpg");



            FullImageName = new string[]
            {
               "0.jpg","1.jpg","2.jpg","3.jpg",
               "0.jpg","4.jpg","5.jpg","6.jpg",
               "0.jpg","7.jpg","8.jpg",
               "0.jpg","9.jpg","10.jpg",
               "0.jpg","11.jpg","12.jpg",
               "0.jpg","13.jpg", "0.jpg","14.png","15.jfif",
               "0.jpg","16.jpg", "0.jpg","17.JPG","18.jpg",
               "0.jpg","19.jfif","20.jpg"
                 };
            FullNames = new string[]
                    {
                 "Chúc bạn may mắn lần sau" , "Một con bò Mỹ"," Một chú Chó dễ thương"," Một siêu xe ferrari",
                 "Chúc bạn may mắn lần sau" ,"Một đt iphone 8Plus"," Một máy ép trái cây","Một nồi cơm điện siêu to",
                 "Chúc bạn may mắn lần sau","Một quạt hơi sunhouse","Một xe thăng bằng cgo bé ",
                 "Chúc bạn may mắn lần sau" ,"Một balo siêu xịn","Một đồng hồ casio",
                 "Chúc bạn may mắn lần sau","Một laptop Dell","Một máy ảnh nikon798",
                 "Chúc bạn may mắn lần sau"," Một con mèo dễ thương", "Chúc bạn may mắn lần sau","Một đt samsung","Một tivi 100 inhs",
                 "Chúc bạn may mắn lần sau","Một xe Sh300i", "Chúc bạn may mắn lần sau","Một con heo vàng 9999","Một đôi giày Gucci",
                 "Chúc bạn may mắn lần sau","Một áo khác real Gucci","Một chỉ vàng SJC"

                    };
        }

        private void QuayThuong_Load(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Today.ToShortDateString();
        }

        private void btnboctham_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            times = random.Next(10, 200);


            count = 0;
            picturegift.LoadAsync(@"F:\DoAnCNPM\Quan Ly Cua Hang Ban Balo\QuanLyBanHang\Resources\");
            SoundPlayer sound = new SoundPlayer(@"F:\DoAnCNPM\Quan Ly Cua Hang Ban Balo\QuanLyBanHang\Resources\NhacCacVongQuayCuaChiecNonKyDieu-VA-6226417 (online-audio-converter (mp3cut.net).wav");
            sound.Play();
        }
       
          
        

        private void picturegift_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (count < times)


            {
                count++;
                picturegift.LoadAsync(@"F:\DoAnCNPM\Quan Ly Cua Hang Ban Balo\QuanLyBanHang\Resources\" + FullImageName[count % FullImageName.Length]);
            }
            else
            {
                if (FullImageName[count % FullImageName.Length] == "0.jpg")
                    MessageBox.Show(FullNames[count % FullImageName.Length]+"!!!!","Rất tiếc");

                else
                    MessageBox.Show("Chúc mừng bạn đã giành được giải thưởng" +"---"  + FullNames[count % FullImageName.Length] + "!!!!", "Chúc mừng");
            }
           
          
       
        }

        private void Stop_Click(object sender, EventArgs e)
        {

            Application.Restart();
        }

        private void picturegift_Click(object sender, EventArgs e)
        {

        }
    }
}

