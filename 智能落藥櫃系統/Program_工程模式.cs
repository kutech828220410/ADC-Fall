using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using MyUI;
using Basic;
using SQLUI;
using System.Diagnostics;//記得取用 FileVersionInfo繼承
using System.Reflection;//記得取用 Assembly繼承

using H_Pannel_lib;

namespace 智能落藥櫃系統
{
    public partial class Form1 : Form
    {
        private void Program_工程模式_Init()
        {
            this.rowsLED_Pannel_工程模式.ValueChanged += RowsLED_Pannel_工程模式_ValueChanged;
            this.plC_UI_Init.Add_Method(Program_工程模式);
        }

    

        bool flag_工程模式_頁面更新 = false;
        private void Program_工程模式()
        {
            if (this.plC_ScreenPage_Main.PageText == "工程模式")
            {
                if (!this.flag_工程模式_頁面更新)
                {
                    this.Function_工程模式_LED_Clear();
                    this.flag_工程模式_頁面更新 = true;
                }
            }
            else
            {
                this.flag_工程模式_頁面更新 = false;
            }

        }

        #region Function
        public void Function_工程模式_LED(int MinValue, int MaxValue, bool state)
        {
            for (int i = 1; i <= 70; i++)
            {
                if (i >= MinValue && i <= MaxValue)
                {
                    Function_工程模式_LED(i, state);
                }    
            }
        }
        public void Function_工程模式_LED_Clear()
        {
            for (int i = 1; i <= 70; i++)
            {
                Function_工程模式_LED(i, false);
            }
        }
        public void Function_工程模式_LED(int num, bool state)
        {
            PLC_Device pLC_Device = new PLC_Device("Z6");
            num--;
            int 層數 = num / 14;
            int index = num % 14 + 層數 * 100;
            pLC_Device.Value = index++;
            PLC_Device_LED.Bool = state;
        }

        public void Function_工程模式_Motor(int MinValue, int MaxValue, bool state)
        {
            for (int i = 1; i <= 70; i++)
            {
                if (i >= MinValue && i <= MaxValue)
                {
                    Function_工程模式_Motor(i, state);
                }
            }
        }
        public void Function_工程模式_Motor_Clear()
        {
            for (int i = 1; i <= 70; i++)
            {
                Function_工程模式_Motor(i, false);
            }
        }
        public void Function_工程模式_Motor(int num, bool state)
        {
            PLC_Device pLC_Device = new PLC_Device("Z8");
            num--;
            int 層數 = num / 14;
            int index = num % 14 + 層數 * 100;
            pLC_Device.Value = index++;
            PLC_Device_Motor.Bool = state;
        }
        public bool Function_工程模式_GetMotorState(int MinValue, int MaxValue)
        {
            for (int i = 1; i <= 70; i++)
            {
                if (i >= MinValue && i <= MaxValue)
                {
                    if (Function_工程模式_GetMotorState(i)) return true;
                }
            }
            return false;
        }
        public bool Function_工程模式_GetMotorState(int num)
        {
            PLC_Device pLC_Device = new PLC_Device("Z8");
            num--;
            int 層數 = num / 14;
            int index = num % 14 + 層數 * 100;
            pLC_Device.Value = index++;
            return PLC_Device_Motor.Bool;
        }


        #endregion
        #region Event
        private void RowsLED_Pannel_工程模式_ValueChanged(int MinValue, int MaxValue)
        {
            for(int i = 1; i <= 70; i++)
            {
                if (i >= MinValue && i <= MaxValue)
                {
                    Function_工程模式_LED(i, true);
                }
                else
                {
                    Function_工程模式_LED(i, false);
                }
            }
        }
        #endregion
    }
}
