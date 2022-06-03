using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button_game
{
    internal class game
    {
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timer2 = new System.Windows.Forms.Timer();
        Random random = new Random();
        int point = 0;
        int _time = 0;
        int _time2 = 0;
        int diff = 0;
        Button btn;
        Form form;

        public game(Button btn , Form form)
        {
            timer.Tick += new EventHandler(this.time_counter);
            timer2.Tick += new EventHandler(this.time2_counter);
            timer.Interval = 1000;
            timer2.Interval = 250;
            timer.Start();
            this.btn = btn;
            this.form = form;
        }
        public void time2_counter(object sender, EventArgs e)
        {
            _time2++;
            if (_time2 == 2)
            {
                _time2 = 0;
                form.BackColor = Color.White;
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                timer2.Stop();
            }
        }
        public void time2_start()
        {
            timer2.Start();
            form.BackColor = Color.LightGreen;
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.White;
        }
        public void time_counter(object sender, EventArgs e)
        {
            _time++;
            if (_time == 2)
            {
                _time = 0;
                next_pozition();
            }
        }
        public void next_pozition()
        {
            int x = random.Next(0, form.Location.X);
            int y = random.Next(0, form.Location.Y);
            btn.Location = new Point(x + (btn.Width + btn.Height), y + (btn.Height + btn.Width));
        }
        public void click_btn()
        {
            this.point += 1;
            if (point <= 5)
            {
                timer.Interval = 1500;
            }
            else if (point <= 10 && point >= 5)
            {
                timer.Interval = 1200;
            }
            else if (point <= 20 && point >= 10)
            {
                timer.Interval = 1000;
            }
            else if (point <= 25 && point >= 20)
            {
                timer.Interval = 750;
            }
            else if (point <= 30 && point >= 25)
            {
                timer.Interval = 500;
            }
            else if (point <= 35 && point >= 30)
            {
                timer.Interval = 250;
            }
            if (point == 40)
            {
                timer.Stop();
                MessageBox.Show("KAZANDIN");
            }
            next_pozition();
        }
        public void fail_click_form()
        {
            this.point -= 1;
        }
        public int get_point()
        {
            return point;
        }
    }
}
