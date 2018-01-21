using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMTracNghiem.BUSI
{
    class FTest
    {
        public void Tick (int min, int sec, int ms)
        {
            min = 0;
            sec = 11;
            ms = 0;
            if (min > 0)
            {
                if (sec > 0)
                {
                    if (ms > 0)
                    {
                        ms--;
                    }
                    else
                    {
                        if (ms < 10)
                        {
                            ms = 10;
                            sec--;
                        }
                    }
                }
                else
                {
                    sec = 59;
                    min--;
                }
            }
            else if (min == 0)
            {
                if (sec > 0)
                {
                    if (ms > 0)
                    {
                        ms--;
                    }
                    else
                    {
                        ms = 10;
                        sec--;
                    }
                }
                else
                {
                    ms--;
                }

            }

            if (min == 0 && sec == 0 && ms == -1)
            {
                timer1.Stop();
                MessageBox.Show("Đã đếm xong!", "Thông Báo!");
                btn_Start.Enabled = false;
            }
        }
    }
}
