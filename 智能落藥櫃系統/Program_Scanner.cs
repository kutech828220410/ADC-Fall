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
        private enum enum_Scanner_陣列內容
        {
            病人姓名 = 10,
            藥品碼 = 14,
            使用數量 = 9,
            病歷號 = 10,
            開方日期 = 11,
            開方時間 = 13,
            藥品名稱 = 0,
            中文名稱 = 1,
            包裝單位 = 8,
        }

        private MySerialPort MySerialPort_Scanner = new MySerialPort();
        private void Program_Scanner_Init()
        {
            if (!myConfigClass.Scanner_COMPort.StringIsEmpty()) MySerialPort_Scanner.Init(myConfigClass.Scanner_COMPort, 115200, 8, System.IO.Ports.Parity.None, System.IO.Ports.StopBits.One);

            if (!this.MySerialPort_Scanner.IsConnected)
            {
                MyMessageBox.ShowDialog("掃碼器初始化失敗!");
            }
            this.plC_UI_Init.Add_Method(Program_Scanner);
        }
        private void Program_Scanner()
        {
            sub_Program_Scanner_讀取藥單資料();
        }


        #region PLC_Scanner_讀取藥單資料

        PLC_Device PLC_Device_Scanner_讀取藥單資料 = new PLC_Device("");
        PLC_Device PLC_Device_Scanner_讀取藥單資料_OK = new PLC_Device("");
        string[] Scanner_讀取藥單資料_Array;
        MyTimer MyTimer_Scanner_讀取藥單資料 = new MyTimer();
        int cnt_Program_Scanner_讀取藥單資料 = 65534;
        void sub_Program_Scanner_讀取藥單資料()
        {
            if (cnt_Program_Scanner_讀取藥單資料 == 65534)
            {
                PLC_Device_Scanner_讀取藥單資料.SetComment("PLC_Scanner_讀取藥單資料");
                PLC_Device_Scanner_讀取藥單資料_OK.SetComment("PLC_Scanner_讀取藥單資料_OK");
                PLC_Device_Scanner_讀取藥單資料.Bool = false;
                cnt_Program_Scanner_讀取藥單資料 = 65535;
            }
            if (cnt_Program_Scanner_讀取藥單資料 == 65535) cnt_Program_Scanner_讀取藥單資料 = 1;
            if (cnt_Program_Scanner_讀取藥單資料 == 1) cnt_Program_Scanner_讀取藥單資料_檢查按下(ref cnt_Program_Scanner_讀取藥單資料);
            if (cnt_Program_Scanner_讀取藥單資料 == 2) cnt_Program_Scanner_讀取藥單資料_初始化(ref cnt_Program_Scanner_讀取藥單資料);
            if (cnt_Program_Scanner_讀取藥單資料 == 3) cnt_Program_Scanner_讀取藥單資料_等待有資料(ref cnt_Program_Scanner_讀取藥單資料);
            if (cnt_Program_Scanner_讀取藥單資料 == 4) cnt_Program_Scanner_讀取藥單資料_等待接收延遲(ref cnt_Program_Scanner_讀取藥單資料);
            if (cnt_Program_Scanner_讀取藥單資料 == 5) cnt_Program_Scanner_讀取藥單資料_檢查接收結果(ref cnt_Program_Scanner_讀取藥單資料);
            if (cnt_Program_Scanner_讀取藥單資料 == 6) cnt_Program_Scanner_讀取藥單資料 = 65500;
            if (cnt_Program_Scanner_讀取藥單資料 > 1) cnt_Program_Scanner_讀取藥單資料_檢查放開(ref cnt_Program_Scanner_讀取藥單資料);

            if (cnt_Program_Scanner_讀取藥單資料 == 65500)
            {
                PLC_Device_Scanner_讀取藥單資料.Bool = false;
                cnt_Program_Scanner_讀取藥單資料 = 65535;
            }
        }
        void cnt_Program_Scanner_讀取藥單資料_檢查按下(ref int cnt)
        {
            if (PLC_Device_Scanner_讀取藥單資料.Bool) cnt++;
        }
        void cnt_Program_Scanner_讀取藥單資料_檢查放開(ref int cnt)
        {
            if (!PLC_Device_Scanner_讀取藥單資料.Bool) cnt = 65500;
        }
        void cnt_Program_Scanner_讀取藥單資料_初始化(ref int cnt)
        {
            PLC_Device_Scanner_讀取藥單資料_OK.Bool = false;
            MySerialPort_Scanner.ClearReadByte();
            cnt++;
        }
        void cnt_Program_Scanner_讀取藥單資料_等待有資料(ref int cnt)
        {
          
            if (MySerialPort_Scanner.ReadByte() != null || plC_RJ_Button_掃碼測試.Bool)
            {
                MyTimer_Scanner_讀取藥單資料.StartTickTime(100);
                cnt++;
            }

        }
        void cnt_Program_Scanner_讀取藥單資料_等待接收延遲(ref int cnt)
        {

            if (MyTimer_Scanner_讀取藥單資料.IsTimeOut())
            {
                cnt++;
            }

        }
        void cnt_Program_Scanner_讀取藥單資料_檢查接收結果(ref int cnt)
        {
            if (MySerialPort_Scanner.ReadByte() != null || plC_RJ_Button_掃碼測試.Bool)
            {
                string text = "";

                if (!plC_RJ_Button_掃碼測試.Bool) text = this.MySerialPort_Scanner.ReadString();
                else text = "1;A123456794;4013;1960-02-12;屏榮門;AC58156212;2       ;Q12H    ;IVA;0006;567260;2022-10-12;44;1113;03348;1042;\r\n";

                plC_RJ_Button_掃碼測試.Bool = false;

                Console.WriteLine($"接收資料長度 : {text.Length} ");
                this.MySerialPort_Scanner.ClearReadByte();
                if (text.Length <= 2 || text.Length > 300)
                {
                    Console.WriteLine($"接收資料長度異常");
                    cnt = 65500;
                    return;
                }
                if (text.Substring(text.Length - 2, 2) != "\r\n")
                {
                    Console.WriteLine($"接收資料結束碼異常");
                    cnt = 65500;
                    return;
                }
                text = text.Replace("\r\n", "");
                Console.WriteLine($"接收結尾碼!");
                string[] array = myConvert.分解分隔號字串(text, ";");
                if (array.Length <= 15)
                {
                    Console.WriteLine($"接收資料長度分析內容異常");
                    cnt = 65500;
                    return;
                }
                string 病人姓名 = array[(int)enum_Scanner_陣列內容.病人姓名];
                string 藥品代碼 = array[(int)enum_Scanner_陣列內容.藥品碼];
                string 使用數量 = array[(int)enum_Scanner_陣列內容.使用數量];
                string 病歷號 = array[(int)enum_Scanner_陣列內容.病歷號];
                string 開方日期 = array[(int)enum_Scanner_陣列內容.開方日期];
                string 開方時間 = array[(int)enum_Scanner_陣列內容.開方時間];

                string[] 開方日期_array = myConvert.分解分隔號字串(開方日期, "-");
                if (開方日期_array.Length == 2)
                {
                    array[(int)enum_Scanner_陣列內容.開方日期] = $"{DateTime.Now.Year}/{開方日期_array[0]}/{開方日期_array[1]}";
                }
                else if (開方日期_array.Length == 1)
                {
                    array[(int)enum_Scanner_陣列內容.開方日期] = $"{開方日期_array[0]}";
                }
                if (開方時間.Length == 4)
                {
                    string Hour = 開方時間.Substring(0, 2);
                    string Min = 開方時間.Substring(2, 2);
                    array[(int)enum_Scanner_陣列內容.開方時間] = $"{ array[(int)enum_Scanner_陣列內容.開方日期]} {Hour}:{Min}";
                }
                else if (開方時間.Length == 8)
                {
                    array[(int)enum_Scanner_陣列內容.開方時間] = $"{array[(int)enum_Scanner_陣列內容.開方日期]} {開方時間}";
                }
                DateTime dateTime = new DateTime();
                if (!DateTime.TryParse(array[(int)enum_Scanner_陣列內容.開方時間], out dateTime))
                {
                    Console.WriteLine($"{array[(int)enum_Scanner_陣列內容.開方時間]} 開方時間輸入異常!");
                    cnt = 65500;
                    return;
                }
                array[(int)enum_Scanner_陣列內容.使用數量] = ((int)使用數量.StringToDouble()).ToString();

                List<object[]> list_藥品資料 = this.sqL_DataGridView_藥品資料_藥檔資料.SQL_GetRows((int)enum_藥品資料_藥檔資料.藥品碼, 藥品代碼, false);
                if (list_藥品資料.Count == 0)
                {
                    Console.WriteLine($"查無此藥品代碼({藥品代碼})");
                    cnt = 65500;
                    return;
                }
                array[(int)enum_Scanner_陣列內容.藥品名稱] = list_藥品資料[0][(int)enum_藥品資料_藥檔資料.藥品名稱].ObjectToString();
                array[(int)enum_Scanner_陣列內容.中文名稱] = list_藥品資料[0][(int)enum_藥品資料_藥檔資料.藥品中文名稱].ObjectToString();
                array[(int)enum_Scanner_陣列內容.包裝單位] = list_藥品資料[0][(int)enum_藥品資料_藥檔資料.包裝單位].ObjectToString();

                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine($"{((enum_Scanner_陣列內容)i).GetEnumName()} : {array[i]}");
                }
                PLC_Device_Scanner_讀取藥單資料_OK.Bool = true;
                Scanner_讀取藥單資料_Array = array.DeepClone();
                cnt++;
                return;
            }
        }










        #endregion
    }
}
