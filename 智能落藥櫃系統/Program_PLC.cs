using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using MyUI;
using Basic;
using SQLUI;
using System.Text.Json;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;

using System.Reflection;
using System.Runtime.InteropServices;

namespace 智能落藥櫃系統
{
    public partial class Form1 : Form
    {

        #region PLC_門未關閉警示
        PLC_Device PLC_Device_門未關閉警示 = new PLC_Device("M8001");
     //   PLC_Device PLC_Device_門未關閉警示 = new PLC_Device("S800");
        PLC_Device PLC_Device_門未關閉警示_OK = new PLC_Device("");
        Task Task_門未關閉警示;
        MyTimer MyTimer_門未關閉警示_結束延遲 = new MyTimer();
        MyTimer MyTimer_門未關閉警示_LED_ON時間 = new MyTimer();
        MyTimer MyTimer_門未關閉警示_LED_OFF時間 = new MyTimer();
        int cnt_Program_門未關閉警示 = 65534;
        void sub_Program_門未關閉警示()
        {
            if (cnt_Program_門未關閉警示 == 65534)
            {
                this.MyTimer_門未關閉警示_結束延遲.StartTickTime(10000);
                PLC_Device_門未關閉警示.SetComment("PLC_門未關閉警示");
                PLC_Device_門未關閉警示_OK.SetComment("PLC_門未關閉警示_OK");
                PLC_Device_門未關閉警示.Bool = false;
                plC_Button_LED全亮.Bool = false;
                cnt_Program_門未關閉警示 = 65535;
            }
            if (cnt_Program_門未關閉警示 == 65535) cnt_Program_門未關閉警示 = 1;
            if (cnt_Program_門未關閉警示 == 1) cnt_Program_門未關閉警示_檢查按下(ref cnt_Program_門未關閉警示);
            if (cnt_Program_門未關閉警示 == 2) cnt_Program_門未關閉警示_初始化(ref cnt_Program_門未關閉警示);
            if (cnt_Program_門未關閉警示 == 3) cnt_Program_門未關閉警示_LED全亮_ON(ref cnt_Program_門未關閉警示);
            if (cnt_Program_門未關閉警示 == 4) cnt_Program_門未關閉警示_LED全亮_ON等待延遲(ref cnt_Program_門未關閉警示);
            if (cnt_Program_門未關閉警示 == 5) cnt_Program_門未關閉警示_LED全亮_OFF(ref cnt_Program_門未關閉警示);
            if (cnt_Program_門未關閉警示 == 6) cnt_Program_門未關閉警示_LED全亮_OFF等待延遲(ref cnt_Program_門未關閉警示);
            if (cnt_Program_門未關閉警示 == 7) cnt_Program_門未關閉警示 = 65500;
            if (cnt_Program_門未關閉警示 > 1) cnt_Program_門未關閉警示_檢查放開(ref cnt_Program_門未關閉警示);

            if (cnt_Program_門未關閉警示 == 65500)
            {
                this.MyTimer_門未關閉警示_結束延遲.TickStop();
                this.MyTimer_門未關閉警示_結束延遲.StartTickTime(10000);
                PLC_Device_門未關閉警示.Bool = false;
                PLC_Device_門未關閉警示_OK.Bool = false;
                plC_Button_LED全亮.Bool = false;
                cnt_Program_門未關閉警示 = 65535;
            }
        }
        void cnt_Program_門未關閉警示_檢查按下(ref int cnt)
        {
            if (PLC_Device_門未關閉警示.Bool) cnt++;
        }
        void cnt_Program_門未關閉警示_檢查放開(ref int cnt)
        {
            if (!PLC_Device_門未關閉警示.Bool) cnt = 65500;
        }
        void cnt_Program_門未關閉警示_初始化(ref int cnt)
        {
            cnt++;
        }
        void cnt_Program_門未關閉警示_LED全亮_ON(ref int cnt)
        {
            MyTimer_門未關閉警示_LED_ON時間.StartTickTime(500);
            plC_Button_LED全亮.Bool = true;
            cnt++;
        }
        void cnt_Program_門未關閉警示_LED全亮_ON等待延遲(ref int cnt)
        {
            if(MyTimer_門未關閉警示_LED_ON時間.IsTimeOut())
            {
                cnt++;
            }
        }
        void cnt_Program_門未關閉警示_LED全亮_OFF(ref int cnt)
        {
            MyTimer_門未關閉警示_LED_OFF時間.StartTickTime(500);
            plC_Button_LED全亮.Bool = false;
            cnt++;
        }
        void cnt_Program_門未關閉警示_LED全亮_OFF等待延遲(ref int cnt)
        {
            if (MyTimer_門未關閉警示_LED_OFF時間.IsTimeOut())
            {
                cnt++;
            }
        }





        #endregion
    }
}
