using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Media;

namespace Titanic_infographic
{
    public partial class Form1 : Form
    {
        private PictureBox temp;
        private SoundPlayer horn = new SoundPlayer(@"..\..\sounds\horn.wav");
        public Form1()
        {
            InitializeComponent();
            temp = ptc_gym_lib;
            lbl_desc.Text = "";
            PrivateFontCollection pfc = new PrivateFontCollection();
            pfc.AddFontFile(@"..\..\TrajanPro-Regular.ttf");
            label1.Font = new Font(pfc.Families[0], 10, FontStyle.Bold);
            horn.Play();
        }

        private void DrawLinePoint(PaintEventArgs e, float x, float y, float width, float height)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Red, 3);

            // Draw line to screen.
            e.Graphics.DrawRectangle(blackPen, x, y, width, height);
        }

        private void pct_bow_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            //this.pct_bow.BorderStyle = BorderStyle.Fixed3D;            
            temp = pct_bow;
            lbl_desc.Text = "Crew compartment and storage area.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/crew quarters.jpg");
        }

        private void pct_boiler_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pct_boiler.BorderStyle = BorderStyle.Fixed3D;
            temp = pct_boiler;
            lbl_desc.Text = "The boiler rooms and coal storage.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/Boiler-Room.jpg");
        }

        private void pct_2_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pct_2.BorderStyle = BorderStyle.Fixed3D;
            temp = pct_2;
            lbl_desc.Text = "Bow third class compartment.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/Third Class Cabin.jpg");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            temp = pictureBox3;
            lbl_desc.Text = "Bow cargo area.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/Storage.jpg");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            temp = pictureBox4;
            lbl_desc.Text = "Bow first class area.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/first class cabin.jpg");
        }

        private void pct_bridge_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pct_bridge.BorderStyle = BorderStyle.Fixed3D;
            temp = pct_bridge;
            lbl_desc.Text = "Captain's bridge and wheel house.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/bridge.jpg");
        }

        private void ptc_gym_lib_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.ptc_gym_lib.BorderStyle = BorderStyle.Fixed3D;
            temp = ptc_gym_lib;
            lbl_desc.Text = "Gymnasium and library of the ship.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/gym.jpg");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            temp = pictureBox5;
            lbl_desc.Text = "Middle first class area.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/first class cabin.jpg");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            temp = pictureBox6;
            lbl_desc.Text = "First class dining saloon.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/dining room.jpg");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            temp = pictureBox1;
            lbl_desc.Text = "First class lounge.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/lounge.jpg");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            temp = pictureBox2;
            lbl_desc.Text = "Engine room.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/engine room.jpg");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pictureBox7.BorderStyle = BorderStyle.Fixed3D;
            temp = pictureBox7;
            lbl_desc.Text = "Turbine engine room.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/turbine.jpg");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pictureBox8.BorderStyle = BorderStyle.Fixed3D;
            temp = pictureBox8;
            lbl_desc.Text = "First class area.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/first class cabin.jpg");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pictureBox9.BorderStyle = BorderStyle.Fixed3D;
            temp = pictureBox9;
            lbl_desc.Text = "Smoke room and restaurant.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/First+Class+Smoking+Room+Titanic.jpg");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pictureBox10.BorderStyle = BorderStyle.Fixed3D;
            temp = pictureBox10;
            lbl_desc.Text = "Provisions rooms (water etc).";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/Storage.jpg");
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pictureBox11.BorderStyle = BorderStyle.Fixed3D;
            temp = pictureBox11;
            lbl_desc.Text = "Stern second and third class quarters.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/2ndcabin.jpg");
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            temp.BorderStyle = BorderStyle.None;
            this.pictureBox12.BorderStyle = BorderStyle.Fixed3D;
            temp = pictureBox12;
            lbl_desc.Text = "Electricity generator room.";
            pct_img.BackgroundImage = Image.FromFile("../../../../images/generator.jpg");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pct_img_Click(object sender, EventArgs e)
        {
            Ship_data sd = new Ship_data();
            sd.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.1;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.008;
            }
            else
            {
                timer1.Stop();
                horn.Stop();
            }
        }
    }
}
