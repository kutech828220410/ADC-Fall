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
    enum enum_領藥內容
    {
        GUID,
        序號,
        動作,
        藥袋序號,
        藥品碼,
        藥品名稱,
        病歷號,
        操作時間,
        開方時間,
        儲位總量,
        異動量,
        結存量,
        單位,
        狀態,
    }
   
    public partial class Form1 : Form
    {
        MyThread MyThread_領藥作業;
        private void Program_領藥作業_Init()
        {
            this.sqL_DataGridView_領藥台_01_領藥內容.Init();
            this.sqL_DataGridView_領藥台_01_領藥內容.DataGridRefreshEvent += SqL_DataGridView_領藥台_01_領藥內容_DataGridRefreshEvent;

            this.textBox_領藥台_01_密碼.PassWordChar = true;
            this.textBox_領藥台_01_帳號.KeyPress += TextBox_領藥台_01_帳號_KeyPress;
            this.textBox_領藥台_01_密碼.KeyPress += TextBox_領藥台_01_密碼_KeyPress;

            this.plC_RJ_Button_領藥台_01_登入.MouseDownEvent += PlC_RJ_Button_領藥台_01_登入_MouseDownEvent;
            this.plC_RJ_Button_領藥台_01_登出.MouseDownEvent += PlC_RJ_Button_領藥台_01_登出_MouseDownEvent;
            this.plC_RJ_Button_領藥台_01_手動作業.MouseDownEvent += PlC_RJ_Button_領藥台_01_手動作業_MouseDownEvent;
            this.plC_RJ_Button_領藥台_01_取消作業.MouseDownEvent += PlC_RJ_Button_領藥台_01_取消作業_MouseDownEvent;

            MyThread_領藥作業 = new MyThread(this.FindForm());
            MyThread_領藥作業.SetSleepTime(10);
            MyThread_領藥作業.AutoRun(true);
            MyThread_領藥作業.Add_Method(Program_領藥作業);
            MyThread_領藥作業.Trigger();
            //plC_UI_Init.Add_Method(Program_領藥作業);
        }

  

        bool flag_Program_領藥台_01_換頁 = false;
        private void Program_領藥作業()
        {
            PLC_Device_領藥台_01_入賬完成時間.Value = 1000;
            if (this.plC_ScreenPage_Main.PageText == "領藥作業")
            {
                if (PLC_Device_領藥台_01_閒置登出時間.Value != 0)
                {
                    if (PLC_Device_領藥台_01_已登入.Bool)
                    {
                        rJ_ProgressBar_領藥台_01_閒置登出時間條.Maximum = PLC_Device_領藥台_01_閒置登出時間.Value;
                        if ((int)MyTimer_領藥台_01_閒置登出時間.GetTickTime() < rJ_ProgressBar_領藥台_01_閒置登出時間條.Maximum)
                        {
                            rJ_ProgressBar_領藥台_01_閒置登出時間條.Value = (int)MyTimer_領藥台_01_閒置登出時間.GetTickTime();
                        }
                        if (MyTimer_領藥台_01_閒置登出時間.IsTimeOut())
                        {
                            PlC_RJ_Button_領藥台_01_取消作業_MouseDownEvent(null);
                            this.PlC_RJ_Button_領藥台_01_登出_MouseDownEvent(null);
                        }
                    }
                    else
                    {
                        rJ_ProgressBar_領藥台_01_閒置登出時間條.Value = 0;
                        MyTimer_領藥台_01_閒置登出時間.TickStop();
                        MyTimer_領藥台_01_閒置登出時間.StartTickTime();
                    }
                }
                if (PLC_Device_領藥台_01_入賬完成時間.Value != 0)
                {
                    if (PLC_Device_領藥台_01_已登入.Bool)
                    {
                        rJ_ProgressBar_領藥台_01_入賬完成時間條.Maximum = PLC_Device_領藥台_01_入賬完成時間.Value;
                        if ((int)MyTimer_領藥台_01_入賬完成時間.GetTickTime() < rJ_ProgressBar_領藥台_01_入賬完成時間條.Maximum)
                        {
                            rJ_ProgressBar_領藥台_01_入賬完成時間條.Value = (int)MyTimer_領藥台_01_入賬完成時間.GetTickTime();
                        }
                        if (MyTimer_領藥台_01_入賬完成時間.IsTimeOut())
                        {
           
                        }
                    }
                    else
                    {
                        rJ_ProgressBar_領藥台_01_入賬完成時間條.Value = 0;
                        MyTimer_領藥台_01_入賬完成時間.TickStop();
                        MyTimer_領藥台_01_入賬完成時間.StartTickTime();
                    }
                }
                if (!this.flag_Program_領藥台_01_換頁)
                {
                    this.Function_登出();
                    PlC_RJ_Button_領藥台_01_取消作業_MouseDownEvent(null);

                    this.PlC_RJ_Button_領藥台_01_登出_MouseDownEvent(new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
                    this.flag_Program_領藥台_01_換頁 = true;
                }

            }
            else
            {
                if (this.flag_Program_領藥台_01_換頁)
                {
                    this.PlC_RJ_Button_領藥台_01_登出_MouseDownEvent(new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
                    this.flag_Program_領藥台_01_換頁 = false;
                }
            }
    
            sub_Program_領藥台_01_狀態顯示();
            sub_Program_領藥台_01_檢查登入();
            sub_Program_領藥台_01_檢查輸入資料();

            sub_Program_領藥台_01_刷新領藥內容();
        }

        #region 領藥台_01
        MyTimer MyTimer_領藥台_01_閒置登出時間 = new MyTimer("D100");
        PLC_Device PLC_Device_領藥台_01_閒置登出時間 = new PLC_Device("D100");
        MyTimer MyTimer_領藥台_01_入賬完成時間 = new MyTimer("D101");
        PLC_Device PLC_Device_領藥台_01_入賬完成時間 = new PLC_Device("D101");
        int 領藥台_01_RFID站號 = 1;
        List<object> 領藥台_01_儲位 = new List<object>();
        List<object[]> 領藥台_01_領藥儲位資訊 = new List<object[]>();
        List<string[]> 領藥台_01_掃描BUFFER = new List<string[]>();
        PLC_Device PLC_Device_領藥台_01_登出 = new PLC_Device();
        PLC_Device PLC_Device_領藥台_01_已登入 = new PLC_Device("S100");

        PLC_Device PLC_Device_領藥台_01_狀態顯示_等待登入 = new PLC_Device("M4000");
        PLC_Device PLC_Device_領藥台_01_狀態顯示_登入者姓名 = new PLC_Device("M4001");

        string 領藥台_01_登入者姓名 = "";
        string 領藥台_01_ID = "";
        string 領藥台_01_卡號 = "";
        string 領藥台_01_顏色 = "";
        string 領藥台_01_一維碼 = "";


        private string 領藥台_01_醫囑條碼 = "";

        #region PLC_領藥台_01_狀態顯示


        PLC_Device PLC_Device_領藥台_01_狀態顯示 = new PLC_Device("");
        PLC_Device PLC_Device_領藥台_01_狀態顯示_OK = new PLC_Device("");
        MyTimer MyTimer_領藥台_01_狀態顯示_結束延遲 = new MyTimer();
        int cnt_Program_領藥台_01_狀態顯示 = 65534;
        void sub_Program_領藥台_01_狀態顯示()
        {
            if (this.plC_ScreenPage_Main.PageText == "領藥作業")
            {
                this.plC_Button_領藥台_01_領.Bool = true;
                PLC_Device_領藥台_01_狀態顯示.Bool = true;
            }
            else
            {
                PLC_Device_領藥台_01_狀態顯示.Bool = false;
            }
            if (cnt_Program_領藥台_01_狀態顯示 == 65534)
            {
                this.MyTimer_領藥台_01_狀態顯示_結束延遲.StartTickTime(10000);
                PLC_Device_領藥台_01_狀態顯示.SetComment("PLC_領藥台_01_狀態顯示");
                PLC_Device_領藥台_01_狀態顯示_OK.SetComment("PLC_領藥台_01_狀態顯示_OK");
                PLC_Device_領藥台_01_狀態顯示.Bool = false;
                cnt_Program_領藥台_01_狀態顯示 = 65535;
            }
            if (cnt_Program_領藥台_01_狀態顯示 == 65535) cnt_Program_領藥台_01_狀態顯示 = 1;
            if (cnt_Program_領藥台_01_狀態顯示 == 1) cnt_Program_領藥台_01_狀態顯示_檢查按下(ref cnt_Program_領藥台_01_狀態顯示);
            if (cnt_Program_領藥台_01_狀態顯示 == 2) cnt_Program_領藥台_01_狀態顯示_初始化(ref cnt_Program_領藥台_01_狀態顯示);
            if (cnt_Program_領藥台_01_狀態顯示 == 3) cnt_Program_領藥台_01_狀態顯示 = 65500;
            if (cnt_Program_領藥台_01_狀態顯示 > 1) cnt_Program_領藥台_01_狀態顯示_檢查放開(ref cnt_Program_領藥台_01_狀態顯示);

            if (cnt_Program_領藥台_01_狀態顯示 == 65500)
            {
                this.MyTimer_領藥台_01_狀態顯示_結束延遲.TickStop();
                this.MyTimer_領藥台_01_狀態顯示_結束延遲.StartTickTime(10000);
                PLC_Device_領藥台_01_狀態顯示.Bool = false;
                PLC_Device_領藥台_01_狀態顯示_OK.Bool = false;
                cnt_Program_領藥台_01_狀態顯示 = 65535;
            }
        }
        void cnt_Program_領藥台_01_狀態顯示_檢查按下(ref int cnt)
        {
            if (PLC_Device_領藥台_01_狀態顯示.Bool) cnt++;
        }
        void cnt_Program_領藥台_01_狀態顯示_檢查放開(ref int cnt)
        {
            if (!PLC_Device_領藥台_01_狀態顯示.Bool) cnt = 65500;
        }
        void cnt_Program_領藥台_01_狀態顯示_初始化(ref int cnt)
        {
            if (!this.PLC_Device_領藥台_01_已登入.Bool)
            {
                PLC_Device_領藥台_01_狀態顯示_等待登入.Bool = true;
                PLC_Device_領藥台_01_狀態顯示_登入者姓名.Bool = false;
            }
            else
            {
                PLC_Device_領藥台_01_狀態顯示_等待登入.Bool = false;
                PLC_Device_領藥台_01_狀態顯示_登入者姓名.Bool = true;
            }
            cnt++;
        }


        #endregion

        #region PLC_領藥台_01_檢查登入

        PLC_Device PLC_Device_領藥台_01_檢查登入 = new PLC_Device("");
        PLC_Device PLC_Device_領藥台_01_檢查登入_OK = new PLC_Device("");


        int cnt_Program_領藥台_01_檢查登入 = 65534;
        void sub_Program_領藥台_01_檢查登入()
        {
            if (!PLC_Device_領藥台_01_已登入.Bool && this.plC_ScreenPage_Main.PageText == "領藥作業")
            {
                PLC_Device_領藥台_01_檢查登入.Bool = true;
            }
            else
            {
                PLC_Device_領藥台_01_檢查登入.Bool = false;
            }
            if (cnt_Program_領藥台_01_檢查登入 == 65534)
            {
                PLC_Device_領藥台_01_檢查登入.SetComment("PLC_領藥台_01_檢查登入");
                PLC_Device_領藥台_01_檢查登入_OK.SetComment("PLC_Device_領藥台_01_檢查登入_OK");
                PLC_Device_領藥台_01_檢查登入.Bool = false;
                cnt_Program_領藥台_01_檢查登入 = 65535;
            }
            if (cnt_Program_領藥台_01_檢查登入 == 65535) cnt_Program_領藥台_01_檢查登入 = 1;
            if (cnt_Program_領藥台_01_檢查登入 == 1) cnt_Program_領藥台_01_檢查登入_檢查按下(ref cnt_Program_領藥台_01_檢查登入);
            if (cnt_Program_領藥台_01_檢查登入 == 2) cnt_Program_領藥台_01_檢查登入_初始化(ref cnt_Program_領藥台_01_檢查登入);
            if (cnt_Program_領藥台_01_檢查登入 == 3) cnt_Program_領藥台_01_檢查登入_外部設備資料或帳號密碼登入(ref cnt_Program_領藥台_01_檢查登入);
            if (cnt_Program_領藥台_01_檢查登入 == 4) cnt_Program_領藥台_01_檢查登入 = 65500;
            if (cnt_Program_領藥台_01_檢查登入 > 1) cnt_Program_領藥台_01_檢查登入_檢查放開(ref cnt_Program_領藥台_01_檢查登入);

            if (cnt_Program_領藥台_01_檢查登入 == 65500)
            {
                PLC_Device_領藥台_01_檢查登入.Bool = false;
                cnt_Program_領藥台_01_檢查登入 = 65535;
            }
        }
        void cnt_Program_領藥台_01_檢查登入_檢查按下(ref int cnt)
        {
            if (PLC_Device_領藥台_01_檢查登入.Bool) cnt++;
        }
        void cnt_Program_領藥台_01_檢查登入_檢查放開(ref int cnt)
        {
            if (!PLC_Device_領藥台_01_檢查登入.Bool) cnt = 65500;
        }
        void cnt_Program_領藥台_01_檢查登入_初始化(ref int cnt)
        {
            PLC_Device_領藥台_01_檢查登入_OK.Bool = false;
            cnt++;
        }
        void cnt_Program_領藥台_01_檢查登入_外部設備資料或帳號密碼登入(ref int cnt)
        {
            List<RFID_FX600lib.RFID_FX600_UI.RFID_Device> list_RFID_Devices = this.rfiD_FX600_UI.Get_RFID();
            if (list_RFID_Devices.Count > 0)
            {
                for (int i = 0; i < list_RFID_Devices.Count; i++)
                {
                    if (list_RFID_Devices[i].station == this.領藥台_01_RFID站號)
                    {
                        this.領藥台_01_卡號 = list_RFID_Devices[i].UID;
                        List<object[]> list_人員資料 = this.sqL_DataGridView_人員資料.SQL_GetRows(enum_人員資料.卡號.GetEnumName(), this.領藥台_01_卡號, false);
                        if (list_人員資料.Count == 0) return;

                        this.Invoke(new Action(delegate
                        {
                            textBox_領藥台_01_帳號.Texts = list_人員資料[0][(int)enum_人員資料.ID].ObjectToString();
                            textBox_領藥台_01_密碼.Texts = list_人員資料[0][(int)enum_人員資料.密碼].ObjectToString();
                            this.PlC_RJ_Button_領藥台_01_登入_MouseDownEvent(null);
                        }));
                        Funnction_交易記錄查詢_動作紀錄新增(enum_交易記錄查詢動作.RFID登入, this.領藥台_01_登入者姓名, "01.號使用者");
                        cnt++;
                        return;
                    }
                }
            }
            else if (MySerialPort_Scanner.ReadByte() != null)
            {
                string text = this.MySerialPort_Scanner.ReadString();

                if (text.Length <= 2 || text.Length > 30) return;
                if (text.Substring(text.Length - 2, 2) != "\r\n") return;
                this.MySerialPort_Scanner.ClearReadByte();
                text = text.Replace("\r\n", "");
                this.領藥台_01_一維碼 = text;
                List<object[]> list_人員資料 = this.sqL_DataGridView_人員資料.SQL_GetRows(enum_人員資料.一維條碼.GetEnumName(), this.領藥台_01_一維碼, false);
                if (list_人員資料.Count == 0)
                {
                    this.voice.SpeakOnTask("查無此一維碼");
                    return;
                }

                this.Invoke(new Action(delegate
                {
                    textBox_領藥台_01_帳號.Texts = list_人員資料[0][(int)enum_人員資料.ID].ObjectToString();
                    textBox_領藥台_01_密碼.Texts = list_人員資料[0][(int)enum_人員資料.密碼].ObjectToString();
                    this.PlC_RJ_Button_領藥台_01_登入_MouseDownEvent(null);
                }));

                Funnction_交易記錄查詢_動作紀錄新增(enum_交易記錄查詢動作.一維碼登入, this.領藥台_01_登入者姓名, "01.號使用者");
                cnt++;
                return;
            }

            cnt = 65500;
            return;


        }

        #endregion
        #region PLC_領藥台_01_檢查輸入資料
        private string 領藥台_01_檢查輸入資料_藥品碼 = "";
        private PLC_Device PLC_Device_領藥台_01_已領取過藥品 = new PLC_Device();
        PLC_Device PLC_Device_領藥台_01_檢查輸入資料 = new PLC_Device("");
        PLC_Device PLC_Device_領藥台_01_檢查輸入資料_OK = new PLC_Device("");

        MyTimer MyTimer_領藥台_01_檢查輸入資料_NG訊息延遲 = new MyTimer();
        int cnt_Program_領藥台_01_檢查輸入資料 = 65534;
        void sub_Program_領藥台_01_檢查輸入資料()
        {
            
            if (this.plC_ScreenPage_Main.PageText == "領藥作業" && PLC_Device_領藥台_01_已登入.Bool)
            {
                PLC_Device_領藥台_01_檢查輸入資料.Bool = true;
            }
            else
            {
                PLC_Device_領藥台_01_檢查輸入資料.Bool = false;
            }

            if (cnt_Program_領藥台_01_檢查輸入資料 == 65534)
            {
                PLC_Device_領藥台_01_檢查輸入資料.SetComment("PLC_領藥台_01_檢查輸入資料");
                PLC_Device_領藥台_01_檢查輸入資料_OK.SetComment("PLC_Device_領藥台_01_檢查輸入資料_OK");
                PLC_Device_領藥台_01_檢查輸入資料.Bool = false;
                cnt_Program_領藥台_01_檢查輸入資料 = 65535;
            }
            if (cnt_Program_領藥台_01_檢查輸入資料 == 65535) cnt_Program_領藥台_01_檢查輸入資料 = 1;
            if (cnt_Program_領藥台_01_檢查輸入資料 == 1) cnt_Program_領藥台_01_檢查輸入資料_檢查按下(ref cnt_Program_領藥台_01_檢查輸入資料);
            if (cnt_Program_領藥台_01_檢查輸入資料 == 2) cnt_Program_領藥台_01_檢查輸入資料_初始化(ref cnt_Program_領藥台_01_檢查輸入資料);
            if (cnt_Program_領藥台_01_檢查輸入資料 == 3) cnt_Program_領藥台_01_檢查輸入資料 = 100;

            if (cnt_Program_領藥台_01_檢查輸入資料 == 100) cnt_Program_領藥台_01_檢查輸入資料_100_設定開始掃描(ref cnt_Program_領藥台_01_檢查輸入資料);
            if (cnt_Program_領藥台_01_檢查輸入資料 == 101) cnt_Program_領藥台_01_檢查輸入資料_100_設定掃描完成(ref cnt_Program_領藥台_01_檢查輸入資料);
            if (cnt_Program_領藥台_01_檢查輸入資料 == 102) cnt_Program_領藥台_01_檢查輸入資料 = 200;

            if (cnt_Program_領藥台_01_檢查輸入資料 == 200) cnt_Program_領藥台_01_檢查輸入資料_200_檢查重複領藥(ref cnt_Program_領藥台_01_檢查輸入資料);
            if (cnt_Program_領藥台_01_檢查輸入資料 == 201) cnt_Program_領藥台_01_檢查輸入資料_200_寫入取藥堆疊(ref cnt_Program_領藥台_01_檢查輸入資料);
            if (cnt_Program_領藥台_01_檢查輸入資料 == 202) cnt_Program_領藥台_01_檢查輸入資料_200_檢查取藥流程完成(ref cnt_Program_領藥台_01_檢查輸入資料);
            if (cnt_Program_領藥台_01_檢查輸入資料 == 203) cnt_Program_領藥台_01_檢查輸入資料_200_開始落藥及開門(ref cnt_Program_領藥台_01_檢查輸入資料);
            if (cnt_Program_領藥台_01_檢查輸入資料 == 204) cnt_Program_領藥台_01_檢查輸入資料_200_設定可入帳(ref cnt_Program_領藥台_01_檢查輸入資料);           
            if (cnt_Program_領藥台_01_檢查輸入資料 == 205) cnt_Program_領藥台_01_檢查輸入資料 = 65500;


            if (cnt_Program_領藥台_01_檢查輸入資料 > 1) cnt_Program_領藥台_01_檢查輸入資料_檢查放開(ref cnt_Program_領藥台_01_檢查輸入資料);

            if (cnt_Program_領藥台_01_檢查輸入資料 == 65500)
            {
                PLC_Device_Scanner_讀取藥單資料.Bool = false;
                PLC_Device_領藥台_01_檢查輸入資料.Bool = false;
                cnt_Program_領藥台_01_檢查輸入資料 = 65535;
            }
        }
        void cnt_Program_領藥台_01_檢查輸入資料_檢查按下(ref int cnt)
        {
            if (PLC_Device_領藥台_01_檢查輸入資料.Bool) cnt++;
        }
        void cnt_Program_領藥台_01_檢查輸入資料_檢查放開(ref int cnt)
        {
            if (!PLC_Device_領藥台_01_檢查輸入資料.Bool) cnt = 65500;
        }
        void cnt_Program_領藥台_01_檢查輸入資料_初始化(ref int cnt)
        {
            PLC_Device_領藥台_01_已領取過藥品.Bool = false;
            cnt++;
        }
        void cnt_Program_領藥台_01_檢查輸入資料_100_設定開始掃描(ref int cnt)
        {         
            if(!PLC_Device_Scanner_讀取藥單資料.Bool)
            {
                PLC_Device_Scanner_讀取藥單資料.Bool = true;
                cnt++;
            }

        }
        void cnt_Program_領藥台_01_檢查輸入資料_100_設定掃描完成(ref int cnt)
        {
            if (!PLC_Device_Scanner_讀取藥單資料.Bool)
            {
                if(PLC_Device_Scanner_讀取藥單資料_OK.Bool)
                {
                    
                    cnt++;
                    return;
                }
                else
                {
                    cnt = 100;
                    return;
                }
             
            }
        }

        void cnt_Program_領藥台_01_檢查輸入資料_200_檢查重複領藥(ref int cnt)
        {
            string 藥品碼 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.藥品碼];
            string 藥品名稱 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.藥品名稱];
            string 中文名稱 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.中文名稱];
            string 包裝單位 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.包裝單位];
            string 交易量 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.使用數量];
            string 病歷號 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.病歷號];
            string 病人姓名 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.病人姓名];
            string 開方時間 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.開方時間];
            this.Function_顯示藥物辨識圖片(藥品碼, this.pictureBox_領藥台_01_藥品圖片);
            Console.WriteLine($"掃碼成功!");
            Console.WriteLine($"藥品碼:{藥品碼}");
            Console.WriteLine($"藥品名稱:{藥品名稱}");
            Console.WriteLine($"中文名稱:{中文名稱}");
            Console.WriteLine($"包裝單位:{包裝單位}");
            Console.WriteLine($"交易量:{交易量}");
            Console.WriteLine($"病歷號:{病歷號}");
            Console.WriteLine($"病人姓名:{病人姓名}");
            Console.WriteLine($"開方時間:{開方時間}");
            if(plC_Button_重複領藥不檢查.Bool)
            {
                cnt++;
                return;
            }
            string[] serch_name = new string[] { enum_交易記錄查詢資料.藥品碼.GetEnumName(), enum_交易記錄查詢資料.病歷號.GetEnumName(), enum_交易記錄查詢資料.開方時間.GetEnumName() };
            string[] serch_value = new string[] { 藥品碼, 病歷號, 開方時間 };
            List<object[]> list_交易記錄 = this.sqL_DataGridView_交易記錄查詢.SQL_GetRows(serch_name, serch_value, false);
            List<object[]> list_取藥堆疊 = this.sqL_DataGridView_取藥堆疊母資料.SQL_GetRows(serch_name, serch_value, false);
            if (list_取藥堆疊.Count > 0)
            {
                MyMessageBox.ShowDialog("此藥單領取中!");
                cnt = 100;
                return;
            }
            if (list_交易記錄.Count > 0)
            {
                MyMessageBox.ShowDialog("此藥單已領取過!");
                cnt = 100;
                return;
            }
            cnt++;
        }
        void cnt_Program_領藥台_01_檢查輸入資料_200_寫入取藥堆疊(ref int cnt)
        {
            string GUID = Guid.NewGuid().ToString();
            string 調劑台名稱 = "P01";
            enum_交易記錄查詢動作 動作 = enum_交易記錄查詢動作.掃碼領藥;
            string 藥品碼 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.藥品碼];
            string 藥袋序號 = textBox_工程模式_設備名稱_名稱.Text; 
            string 藥品名稱 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.藥品名稱];
            string 中文名稱 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.中文名稱];
            string 單位 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.包裝單位];
            int 總異動量 = (Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.使用數量].StringToInt32() * -1);
            string 病歷號 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.病歷號];
            string 病人姓名 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.病人姓名];
            string 開方時間 = Scanner_讀取藥單資料_Array[(int)enum_Scanner_陣列內容.開方時間];
            string 操作人 = this.領藥台_01_登入者姓名;
            string 顏色 = this.領藥台_01_顏色;
            string 效期 = "";
            this.Function_取藥堆疊資料_新增母資料(GUID, 調劑台名稱, 動作, 藥品碼, 藥品名稱, 藥袋序號, 單位, 病歷號, 病人姓名, 開方時間, "", 操作人, 顏色, 總異動量, 效期);

            this.領藥台_01_檢查輸入資料_藥品碼 = 藥品碼;
            cnt++;
        }
        void cnt_Program_領藥台_01_檢查輸入資料_200_檢查取藥流程完成(ref int cnt)
        {
            PLC_Device_領藥台_01_已領取過藥品.Bool = true;
            List<object[]> list_value = this.sqL_DataGridView_領藥台_01_領藥內容.GetAllRows();
            if (list_value.Count > 1)
            {
                cnt = 65500;
                return;
            }
            if (list_value.Count == 0) return;
            if (list_value[0][(int)enum_領藥內容.狀態].ObjectToString() == enum_取藥堆疊母資料_狀態.庫存不足.GetEnumName())
            {
                cnt = 65500;
                return;
            }
            if (list_value[0][(int)enum_領藥內容.狀態].ObjectToString() == enum_取藥堆疊母資料_狀態.新增效期.GetEnumName())
            {
                cnt = 65500;
                return;
            }
            if (list_value[0][(int)enum_領藥內容.狀態].ObjectToString() == enum_取藥堆疊母資料_狀態.等待輸入效期.GetEnumName())
            {
                cnt = 65500;
                return;
            }
            if (list_value[0][(int)enum_領藥內容.狀態].ObjectToString() == enum_取藥堆疊母資料_狀態.等待作業.GetEnumName())
            {
                cnt++;
                return;
            }


        }
        void cnt_Program_領藥台_01_檢查輸入資料_200_開始落藥及開門(ref int cnt)
        {
            this.Function_從SQL取得儲位到本地資料();
            List<Task> taskList = new List<Task>();
            taskList.Add(Task.Run(() =>
            {
                List<object[]> list_value = Function_取藥堆疊資料_取得子資料();
                for (int i = 0; i < list_value.Count; i++)
                {
                    string GUID = list_value[i][(int)enum_取藥堆疊子資料.Device_GUID].ObjectToString();
                    int 交易量 = list_value[i][(int)enum_取藥堆疊子資料.異動量].ObjectToString().StringToInt32();
                    交易量 = 交易量 * -1;
                    if (交易量 < 0) break;
                    RowsDevice rowsDevice = List_RowsLED_本地資料.GetRowsDevice(GUID);
                    if (rowsDevice == null) break;
                    for (int k = 0; k < 交易量; k++)
                    {
                        int start = rowsDevice.StartLED;
                        int end = rowsDevice.EndLED;
                        int mcnt = 1;
                        while (true)
                        {
                            if (mcnt == 1)
                            {
                                if (!Function_工程模式_GetMotorState(start, end))
                                {
                                    this.Function_工程模式_Motor(start, end, true);
                                    mcnt++;
                                }
                            }
                            if (mcnt == 2)
                            {
                                if (!Function_工程模式_GetMotorState(start, end))
                                {
                                    mcnt++;
                                }
                            }
                            if (mcnt == 3)
                            {
                                System.Threading.Thread.Sleep(200);
                                break;
                            }
                            System.Threading.Thread.Sleep(10);
                        }
                        rJ_ProgressBar_領藥台_01_閒置登出時間條.Value = 0;
                        MyTimer_領藥台_01_閒置登出時間.TickStop();
                        MyTimer_領藥台_01_閒置登出時間.StartTickTime();
                    }
                }
            }));
            taskList.Add(Task.Run(() =>
            {
                if (!plC_Button_取藥門開.Bool)
                {
                    plC_Button_取藥門開.Bool = true;
                }
                rJ_ProgressBar_領藥台_01_閒置登出時間條.Value = 0;
                MyTimer_領藥台_01_閒置登出時間.TickStop();
                MyTimer_領藥台_01_閒置登出時間.StartTickTime();
            }));
          
            Task allTask = Task.WhenAll(taskList);
            allTask.Wait();
            cnt++;
         
  


        }
        void cnt_Program_領藥台_01_檢查輸入資料_200_設定可入帳(ref int cnt)
        {
          
            this.Function_取藥堆疊子資料_設定配藥完成ByCode("P01", this.領藥台_01_檢查輸入資料_藥品碼);
    
            cnt++;
        }
        #endregion

        #region PLC_領藥台_01_刷新領藥內容
        PLC_Device PLC_Device_領藥台_01_刷新領藥內容 = new PLC_Device("");
        PLC_Device PLC_Device_領藥台_01_刷新領藥內容_OK = new PLC_Device("");
        MyTimer MyTimer__領藥台_01_刷新領藥內容_刷新間隔 = new MyTimer();
        int cnt_Program_領藥台_01_刷新領藥內容 = 65534;
        void sub_Program_領藥台_01_刷新領藥內容()
        {
            if (this.plC_ScreenPage_Main.PageText == "領藥作業")
            {
                PLC_Device_領藥台_01_刷新領藥內容.Bool = true;
            }
            else
            {
                PLC_Device_領藥台_01_刷新領藥內容.Bool = false;
            }
            PLC_Device_領藥台_01_刷新領藥內容.Bool = (this.plC_ScreenPage_Main.PageText == "領藥作業");
            if (cnt_Program_領藥台_01_刷新領藥內容 == 65534)
            {
                this.MyTimer__領藥台_01_刷新領藥內容_刷新間隔.StartTickTime(100);
                PLC_Device_領藥台_01_刷新領藥內容.SetComment("PLC_領藥台_01_刷新領藥內容");
                PLC_Device_領藥台_01_刷新領藥內容_OK.SetComment("PLC_領藥台_01_刷新領藥內容_OK");
                PLC_Device_領藥台_01_刷新領藥內容.Bool = false;
                cnt_Program_領藥台_01_刷新領藥內容 = 65535;
            }
            if (cnt_Program_領藥台_01_刷新領藥內容 == 65535) cnt_Program_領藥台_01_刷新領藥內容 = 1;
            if (cnt_Program_領藥台_01_刷新領藥內容 == 1) cnt_Program_領藥台_01_刷新領藥內容_檢查按下(ref cnt_Program_領藥台_01_刷新領藥內容);
            if (cnt_Program_領藥台_01_刷新領藥內容 == 2) cnt_Program_領藥台_01_刷新領藥內容_初始化(ref cnt_Program_領藥台_01_刷新領藥內容);
            if (cnt_Program_領藥台_01_刷新領藥內容 == 3) cnt_Program_領藥台_01_刷新領藥內容_取得資料(ref cnt_Program_領藥台_01_刷新領藥內容);
            if (cnt_Program_領藥台_01_刷新領藥內容 == 4) cnt_Program_領藥台_01_刷新領藥內容_檢查是否需輸入效期(ref cnt_Program_領藥台_01_刷新領藥內容);
            if (cnt_Program_領藥台_01_刷新領藥內容 == 5) cnt_Program_領藥台_01_刷新領藥內容_檢查自動登出(ref cnt_Program_領藥台_01_刷新領藥內容);
            if (cnt_Program_領藥台_01_刷新領藥內容 == 6) cnt_Program_領藥台_01_刷新領藥內容_等待刷新間隔(ref cnt_Program_領藥台_01_刷新領藥內容);
            if (cnt_Program_領藥台_01_刷新領藥內容 == 7) cnt_Program_領藥台_01_刷新領藥內容 = 65500;
            if (cnt_Program_領藥台_01_刷新領藥內容 > 1) cnt_Program_領藥台_01_刷新領藥內容_檢查放開(ref cnt_Program_領藥台_01_刷新領藥內容);

            if (cnt_Program_領藥台_01_刷新領藥內容 == 65500)
            {
                PLC_Device_領藥台_01_刷新領藥內容.Bool = false;
                PLC_Device_領藥台_01_刷新領藥內容_OK.Bool = false;
                cnt_Program_領藥台_01_刷新領藥內容 = 65535;
            }
        }
        void cnt_Program_領藥台_01_刷新領藥內容_檢查按下(ref int cnt)
        {
            if (PLC_Device_領藥台_01_刷新領藥內容.Bool) cnt++;
        }
        void cnt_Program_領藥台_01_刷新領藥內容_檢查放開(ref int cnt)
        {
            if (!PLC_Device_領藥台_01_刷新領藥內容.Bool) cnt = 65500;
        }
        void cnt_Program_領藥台_01_刷新領藥內容_初始化(ref int cnt)
        {
            this.MyTimer__領藥台_01_刷新領藥內容_刷新間隔.StartTickTime(100);
            cnt++;
        }
        void cnt_Program_領藥台_01_刷新領藥內容_取得資料(ref int cnt)
        {
            List<object[]> list_value = new List<object[]>();
            List<object[]> list_取藥堆疊資料 = this.Function_取藥堆疊資料_取得指定調劑台名稱母資料("P01");
            string GUID = "";
            string 序號 = "";
            string 動作 = "";
            string 藥袋序號 = "";
            string 藥品碼 = "";
            string 藥品名稱 = "";
            string 病歷號 = "";
            string 操作時間 = "";
            string 開方時間 = "";
            string 儲位總量 = "";
            string 異動量 = "";
            string 結存量 = "";
            string 單位 = "";
            string 狀態 = "";

            list_取藥堆疊資料.Sort(new Icp_取藥堆疊母資料_index排序());

            for (int i = 0; i < list_取藥堆疊資料.Count; i++)
            {
                GUID = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.GUID].ObjectToString();
                序號 = (i + 1).ToString();
                動作 = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.動作].ObjectToString();
                藥袋序號 = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.藥袋序號].ObjectToString();
                藥品碼 = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.藥品碼].ObjectToString();
                藥品名稱 = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.藥品名稱].ObjectToString();
                病歷號 = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.病歷號].ObjectToString();
                操作時間 = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.操作時間].ObjectToString();
                開方時間 = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.開方時間].ObjectToString();
                儲位總量 = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.庫存量].ObjectToString();
                異動量 = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.總異動量].ObjectToString();
                結存量 = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.結存量].ObjectToString();
                單位 = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.單位].ObjectToString();
                狀態 = list_取藥堆疊資料[i][(int)enum_取藥堆疊母資料.狀態].ObjectToString();

                object[] value = new object[new enum_領藥內容().GetLength()];
                value[(int)enum_領藥內容.GUID] = GUID;
                value[(int)enum_領藥內容.序號] = 序號;
                value[(int)enum_領藥內容.動作] = 動作;
                value[(int)enum_領藥內容.藥袋序號] = 藥袋序號;
                value[(int)enum_領藥內容.藥品碼] = 藥品碼;
                value[(int)enum_領藥內容.藥品名稱] = 藥品名稱;
                value[(int)enum_領藥內容.病歷號] = 病歷號;
                value[(int)enum_領藥內容.操作時間] = 操作時間;
                value[(int)enum_領藥內容.開方時間] = 開方時間;
                value[(int)enum_領藥內容.儲位總量] = 儲位總量;
                value[(int)enum_領藥內容.異動量] = 異動量;
                value[(int)enum_領藥內容.結存量] = 結存量;
                value[(int)enum_領藥內容.單位] = 單位;
                value[(int)enum_領藥內容.狀態] = 狀態;

                list_value.Add(value);


            }

          
            this.sqL_DataGridView_領藥台_01_領藥內容.RefreshGrid(list_value);

            cnt++;
        }
        void cnt_Program_領藥台_01_刷新領藥內容_檢查是否需輸入效期(ref int cnt)
        {
        
            cnt++;
        }
        void cnt_Program_領藥台_01_刷新領藥內容_檢查自動登出(ref int cnt)
        {
            List<object[]> list_取藥堆疊資料 = this.Function_取藥堆疊資料_取得指定調劑台名稱母資料("P01");
            List<object[]> list_取藥堆疊資料_buf = new List<object[]>();
            list_取藥堆疊資料_buf = (from value in list_取藥堆疊資料
                               where value[(int)enum_取藥堆疊母資料.狀態].ObjectToString() != enum_取藥堆疊母資料_狀態.入賬完成.GetEnumName()
                               where value[(int)enum_取藥堆疊母資料.狀態].ObjectToString() != enum_取藥堆疊母資料_狀態.庫存不足.GetEnumName()
                               select value
                                ).ToList();

            if (list_取藥堆疊資料.Count == 0 && !PLC_Device_領藥台_01_已領取過藥品.Bool)
            {
                MyTimer_領藥台_01_閒置登出時間.TickStop();
                MyTimer_領藥台_01_閒置登出時間.StartTickTime();

                MyTimer_領藥台_01_入賬完成時間.TickStop();
                MyTimer_領藥台_01_入賬完成時間.StartTickTime();
            }
           
            this.MyTimer__領藥台_01_刷新領藥內容_刷新間隔.TickStop();
            this.MyTimer__領藥台_01_刷新領藥內容_刷新間隔.StartTickTime(100);
            cnt++;
        }
        void cnt_Program_領藥台_01_刷新領藥內容_等待刷新間隔(ref int cnt)
        {
            if (this.MyTimer__領藥台_01_刷新領藥內容_刷新間隔.IsTimeOut())
            {
                cnt++;
            }
        }
        #endregion
        #region Function
        #endregion
        #region Event
        private void SqL_DataGridView_領藥台_01_領藥內容_DataGridRefreshEvent()
        {
            String 狀態 = "";
            for (int i = 0; i < this.sqL_DataGridView_領藥台_01_領藥內容.dataGridView.Rows.Count; i++)
            {
                狀態 = this.sqL_DataGridView_領藥台_01_領藥內容.dataGridView.Rows[i].Cells[(int)enum_領藥內容.狀態].Value.ToString();
                if (狀態 == enum_取藥堆疊母資料_狀態.等待作業.GetEnumName())
                {
                    this.sqL_DataGridView_領藥台_01_領藥內容.dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    this.sqL_DataGridView_領藥台_01_領藥內容.dataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (狀態 == enum_取藥堆疊母資料_狀態.入賬完成.GetEnumName())
                {
                    this.sqL_DataGridView_領藥台_01_領藥內容.dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Lime;
                    this.sqL_DataGridView_領藥台_01_領藥內容.dataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (狀態 == enum_取藥堆疊母資料_狀態.庫存不足.GetEnumName())
                {
                    this.sqL_DataGridView_領藥台_01_領藥內容.dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    this.sqL_DataGridView_領藥台_01_領藥內容.dataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
        private void PlC_RJ_Button_領藥台_01_手動作業_MouseDownEvent(MouseEventArgs mevent)
        {
            //this.Invoke(new Action(delegate
            //{
            //    Dialog_手動作業.enum_狀態 enum_狀態 = Dialog_手動作業.enum_狀態.領藥;
            //    if (this.plC_Button_領藥台_01_領.Bool)
            //    {
            //        enum_狀態 = Dialog_手動作業.enum_狀態.領藥;
            //    }
            //    if (this.plC_Button_領藥台_01_退.Bool)
            //    {
            //        enum_狀態 = Dialog_手動作業.enum_狀態.退藥;
            //    }
            //    Dialog_手動作業 dialog_手動作業 = new Dialog_手動作業((Form1)this.FindForm(), this.sqL_DataGridView_藥品資料_藥檔資料, enum_狀態);
            //    dialog_手動作業.ShowDialog();
            //    List<object[]> list_value = dialog_手動作業.Value;
            //    if (list_value.Count == 0) return;
            //    List<object[]> list_藥品資料 = this.sqL_DataGridView_藥品資料_藥檔資料.SQL_GetAllRows(false);
            //    List<object[]> list_藥品資料_buf = new List<object[]>();
            //    for (int i = 0; i < list_value.Count; i++)
            //    {
            //        string GUID = Guid.NewGuid().ToString();
            //        string 調劑台名稱 = this.textBox_工程模式_領藥台_01_名稱.Text;

            //        string 藥品碼 = list_value[i][(int)enum_選擇藥品.藥品碼].ObjectToString();
            //        list_藥品資料_buf = list_藥品資料.GetRows((int)enum_藥品資料_藥檔資料.藥品碼, 藥品碼);
            //        if (list_藥品資料_buf.Count == 0) continue;
            //        string 藥品名稱 = list_藥品資料[0][(int)enum_藥品資料_藥檔資料.藥品名稱].ObjectToString();
            //        string 藥袋序號 = "";
            //        string 單位 = list_藥品資料_buf[0][(int)enum_藥品資料_藥檔資料.包裝單位].ObjectToString();
            //        string 病歷號 = "";
            //        string 病人姓名 = "";
            //        string 開方時間 = DateTime.Now.ToDateTimeString_6();
            //        string ID = this.領藥台_01_ID;
            //        string 操作人 = this.領藥台_01_登入者姓名;
            //        string 顏色 = this.領藥台_01_顏色;
            //        int 總異動量 = list_value[i][(int)enum_選擇藥品.交易量].ObjectToString().StringToInt32();
            //        enum_交易記錄查詢動作 動作 = enum_交易記錄查詢動作.掃碼領藥;
            //        if (總異動量 <= 0)
            //        {
            //            動作 = enum_交易記錄查詢動作.手輸領藥;
            //        }
            //        else
            //        {
            //            動作 = enum_交易記錄查詢動作.手輸退藥;
            //        }
            //        string 效期 = "";

            //        this.Function_取藥堆疊資料_新增母資料(GUID, 調劑台名稱, 動作, 藥品碼, 藥品名稱, 藥袋序號, 單位, 病歷號, 病人姓名, 開方時間, "", 操作人, 顏色, 總異動量, 效期);

            //    }

            //}));
        }
        private void PlC_RJ_Button_領藥台_01_登入_MouseDownEvent(MouseEventArgs mevent)
        {
            if (this.PLC_Device_領藥台_01_已登入.Bool) return;
            if (textBox_領藥台_01_帳號.Texts.StringIsEmpty()) return;

            if (textBox_領藥台_01_帳號.Texts.ToUpper() == Admin_ID.ToUpper())
            {
                if (textBox_領藥台_01_密碼.Texts.ToUpper() == Admoin_Password.ToUpper())
                {
                    this.PLC_Device_領藥台_01_已登入.Bool = true;
                    this.領藥台_01_登入者姓名 = "最高管理權限";
                    this.領藥台_01_ID = "admin";
                    this.PLC_Device_最高權限.Bool = true;
                    return;
                }
            }

            List<object[]> list_value = this.sqL_DataGridView_人員資料.SQL_GetAllRows(false);
            list_value = list_value.GetRows((int)enum_人員資料.ID, textBox_領藥台_01_帳號.Texts);
            if (list_value.Count == 0)
            {
                MyMessageBox.ShowDialog("查無此帳號!");
                return;
            }
            string password = list_value[0][(int)enum_人員資料.密碼].ObjectToString();
            if (textBox_領藥台_01_密碼.Texts != password)
            {
                MyMessageBox.ShowDialog("密碼錯誤!");
                return;
            }
            this.領藥台_01_登入者姓名 = list_value[0][(int)enum_人員資料.姓名].ObjectToString();
            this.領藥台_01_ID = list_value[0][(int)enum_人員資料.ID].ObjectToString();
            this.領藥台_01_顏色 = list_value[0][(int)enum_人員資料.顏色].ObjectToString();
            this.PLC_Device_領藥台_01_已登入.Bool = true;
            if (mevent != null) Funnction_交易記錄查詢_動作紀錄新增(enum_交易記錄查詢動作.密碼登入, this.領藥台_01_登入者姓名, "領藥台_01");
            string 狀態顯示 = "";
            狀態顯示 += this.plC_MultiStateDisplay_領藥台_01_狀態顯示.GetAlignmentString(PLC_MultiStateDisplay.TextValue.Alignment.Left);
            狀態顯示 += this.plC_MultiStateDisplay_領藥台_01_狀態顯示.GetFontColorString(Color.Black, true);
            狀態顯示 += this.plC_MultiStateDisplay_領藥台_01_狀態顯示.GetFontString(new Font("微軟正黑體", 24F, FontStyle.Bold), true);
            狀態顯示 += string.Format($"登入者姓名 : {this.領藥台_01_登入者姓名}");
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.SetTextValue(PLC_Device_領藥台_01_狀態顯示_登入者姓名.GetAdress(), 狀態顯示);
            if (!this.plC_Button_領藥台_01_領.Bool && !this.plC_Button_領藥台_01_退.Bool)
            {
                this.plC_Button_領藥台_01_領.Bool = true;
            }
            this.Invoke(new Action(delegate
            {
                textBox_領藥台_01_帳號.Texts = "";
                textBox_領藥台_01_密碼.Texts = "";
            }));
        }
        private void PlC_RJ_Button_領藥台_01_登出_MouseDownEvent(MouseEventArgs mevent)
        {
            plC_Button_取藥門關.Bool = true;
            if (!this.PLC_Device_領藥台_01_已登入.Bool) return;
            this.Invoke(new Action(delegate
            {
                this.pictureBox_領藥台_01_藥品圖片.Image = null;
            }));
            this.sqL_DataGridView_領藥台_01_領藥內容.ClearGrid();

            Funnction_交易記錄查詢_動作紀錄新增(enum_交易記錄查詢動作.登出, this.領藥台_01_登入者姓名, "01.號使用者");
            this.領藥台_01_登入者姓名 = "None";
            this.PLC_Device_領藥台_01_已登入.Bool = false;
            this.PLC_Device_最高權限.Bool = false;
        }
        private void PlC_RJ_Button_領藥台_01_取消作業_MouseDownEvent(MouseEventArgs mevent)
        {
            //if (!this.PLC_Device_領藥台_01_已登入.Bool) return;
            //this.Invoke(new Action(delegate
            //{
            //    this.pictureBox_領藥台_01_藥品圖片.Image = null;
            //}));
            this.Function_取藥堆疊資料_刪除指定調劑台名稱母資料("P01");
            this.sqL_DataGridView_領藥台_01_領藥內容.ClearGrid();
        }


        private void TextBox_領藥台_01_帳號_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                textBox_領藥台_01_密碼.Focus();
            }
        }
        private void TextBox_領藥台_01_密碼_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                this.PlC_RJ_Button_領藥台_01_登入_MouseDownEvent(new MouseEventArgs(MouseButtons.Left, 0, 0, 0, 0));
            }
        }

        #endregion

        #endregion

    }
}
