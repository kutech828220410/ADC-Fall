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
    enum enum_儲位管理_儲位資訊_效期及庫存
    {
        效期,
        批號,
        庫存,
    }
    enum enum_儲位管理_儲位資訊
    {
        GUID,
        藥品碼,
        藥品名稱,
        包裝單位,
        層數,
        起始號碼,
        結束號碼,
        庫存,
    }
    public partial class Form1 : Form
    {

        int 單層格數 = 14;
        private void Program_儲位管理_Init()
        {
            this.sqL_DataGridView_儲位管理_儲位資訊.Init();

            this.sqL_DataGridView_儲位管理_藥品資料.Init(this.sqL_DataGridView_藥品資料_藥檔資料);

            this.sqL_DataGridView_儲位管理_藥品資料.Set_ColumnVisible(false, enum_藥品資料_藥檔資料.GUID);
            this.sqL_DataGridView_儲位管理_藥品資料.Set_ColumnVisible(false, enum_藥品資料_藥檔資料.藥品學名);
            this.sqL_DataGridView_儲位管理_藥品資料.Set_ColumnVisible(false, enum_藥品資料_藥檔資料.藥品群組);
            this.sqL_DataGridView_儲位管理_藥品資料.Set_ColumnVisible(false, enum_藥品資料_藥檔資料.健保碼);
            this.sqL_DataGridView_儲位管理_藥品資料.Set_ColumnVisible(false, enum_藥品資料_藥檔資料.藥品條碼);
            this.sqL_DataGridView_儲位管理_藥品資料.Set_ColumnVisible(false, enum_藥品資料_藥檔資料.包裝單位);
            this.sqL_DataGridView_儲位管理_藥品資料.Set_ColumnVisible(false, enum_藥品資料_藥檔資料.庫存);
            this.sqL_DataGridView_儲位管理_藥品資料.Set_ColumnVisible(false, enum_藥品資料_藥檔資料.安全庫存);
            this.sqL_DataGridView_儲位管理_藥品資料.Set_ColumnVisible(false, enum_藥品資料_藥檔資料.圖片網址);
            this.sqL_DataGridView_儲位管理_藥品資料.Set_ColumnVisible(false, enum_藥品資料_藥檔資料.警訊藥品);

            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.MouseDownEvent += PlC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋_MouseDownEvent;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.MouseDownEvent += PlC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋_MouseDownEvent;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.MouseDownEvent += PlC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋_MouseDownEvent;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.MouseDownEvent += PlC_RJ_Button_儲位管理_藥品資料_新增儲位_MouseDownEvent;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.MouseDownEvent += PlC_RJ_Button_儲位管理_藥品資料_顯示全部_MouseDownEvent;
            this.plC_RJ_Button_儲位設定_亮燈.MouseDownEvent += PlC_RJ_Button_儲位設定_亮燈_MouseDownEvent;
            this.plC_RJ_Button_儲位設定_滅燈.MouseDownEvent += PlC_RJ_Button_儲位設定_滅燈_MouseDownEvent;
            this.plC_RJ_Button_儲位設定_出料一次.MouseDownEvent += PlC_RJ_Button_儲位設定_出料一次_MouseDownEvent;

            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.MouseDownEvent += PlC_RJ_Button_儲位管理_儲位資訊_刪除儲位_MouseDownEvent;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.MouseDownEvent += PlC_RJ_Button_儲位設定_亮燈範圍填入_MouseDownEvent;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.MouseDownEvent += PlC_RJ_Button_儲位管理_儲位資訊_更新_MouseDownEvent;

            this.rJ_RatioButton_儲位管理_第一層.CheckedChanged += RJ_RatioButton_儲位管理_第一層_CheckedChanged;
            this.rJ_RatioButton_儲位管理_第二層.CheckedChanged += RJ_RatioButton_儲位管理_第二層_CheckedChanged;
            this.rJ_RatioButton_儲位管理_第三層.CheckedChanged += RJ_RatioButton_儲位管理_第三層_CheckedChanged;
            this.rJ_RatioButton_儲位管理_第四層.CheckedChanged += RJ_RatioButton_儲位管理_第四層_CheckedChanged;
            this.rJ_RatioButton_儲位管理_第五層.CheckedChanged += RJ_RatioButton_儲位管理_第五層_CheckedChanged;

            this.sqL_DataGridView_儲位管理_儲位資訊.DataGridRefreshEvent += SqL_DataGridView_儲位管理_儲位資訊_DataGridRefreshEvent;
            this.sqL_DataGridView_儲位管理_儲位資訊.DataGridRowsChangeRefEvent += SqL_DataGridView_儲位管理_儲位資訊_DataGridRowsChangeRefEvent;
            this.sqL_DataGridView_儲位管理_儲位資訊.RowEnterEvent += SqL_DataGridView_儲位管理_儲位資訊_RowEnterEvent;
            this.sqL_DataGridView_儲位管理_儲位資訊.RowDoubleClickEvent += SqL_DataGridView_儲位管理_儲位資訊_RowDoubleClickEvent;

            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Init();

            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.MouseDownEvent += PlC_RJ_Button_儲位管理_儲位資訊_新增效期_MouseDownEvent;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.MouseDownEvent += PlC_RJ_Button_儲位管理_儲位資訊_修正庫存_MouseDownEvent;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.MouseDownEvent += PlC_RJ_Button_儲位管理_儲位資訊_修正批號_MouseDownEvent;

            this.rowsLEDUI.Init(dBConfigClass.DB_Basic.DataBaseName, dBConfigClass.DB_Basic.UserName, dBConfigClass.DB_Basic.Password, dBConfigClass.DB_Basic.IP, dBConfigClass.DB_Basic.Port, dBConfigClass.DB_Basic.MySqlSslMode);
            this.RJ_RatioButton_儲位管理_第一層_CheckedChanged(null, null);
            this.plC_UI_Init.Add_Method(Program_儲位管理);
        }

 

        bool flag_儲位管理_頁面更新 = false;
        private void Program_儲位管理()
        {
            if (this.plC_ScreenPage_Main.PageText == "儲位管理")
            {
                if (!this.flag_儲位管理_頁面更新)
                {
                    PLC_Device_儲位管理_儲位資訊_資料更新.Bool = true;
                    this.flag_儲位管理_頁面更新 = true;
                }
            }
            else
            {
                this.flag_儲位管理_頁面更新 = false;
            }

            sub_Program_儲位管理_儲位資訊_資料更新();
        }
        #region PLC_儲位管理_儲位資訊_資料更新
        PLC_Device PLC_Device_儲位管理_儲位資訊_資料更新 = new PLC_Device("");
        int cnt_Program_儲位管理_儲位資訊_資料更新 = 65534;
        void sub_Program_儲位管理_儲位資訊_資料更新()
        {
            if (cnt_Program_儲位管理_儲位資訊_資料更新 == 65534)
            {
                PLC_Device_儲位管理_儲位資訊_資料更新.SetComment("PLC_儲位管理_儲位資訊_資料更新");
                PLC_Device_儲位管理_儲位資訊_資料更新.Bool = false;
                cnt_Program_儲位管理_儲位資訊_資料更新 = 65535;
            }
            if (cnt_Program_儲位管理_儲位資訊_資料更新 == 65535) cnt_Program_儲位管理_儲位資訊_資料更新 = 1;
            if (cnt_Program_儲位管理_儲位資訊_資料更新 == 1) cnt_Program_儲位管理_儲位資訊_資料更新_檢查按下(ref cnt_Program_儲位管理_儲位資訊_資料更新);
            if (cnt_Program_儲位管理_儲位資訊_資料更新 == 2) cnt_Program_儲位管理_儲位資訊_資料更新_初始化(ref cnt_Program_儲位管理_儲位資訊_資料更新);
            if (cnt_Program_儲位管理_儲位資訊_資料更新 == 3) cnt_Program_儲位管理_儲位資訊_資料更新_更新藥檔(ref cnt_Program_儲位管理_儲位資訊_資料更新);
            if (cnt_Program_儲位管理_儲位資訊_資料更新 == 4) cnt_Program_儲位管理_儲位資訊_資料更新_更新面板資料(ref cnt_Program_儲位管理_儲位資訊_資料更新);
            if (cnt_Program_儲位管理_儲位資訊_資料更新 == 5) cnt_Program_儲位管理_儲位資訊_資料更新 = 65500;
            if (cnt_Program_儲位管理_儲位資訊_資料更新 > 1) cnt_Program_儲位管理_儲位資訊_資料更新_檢查放開(ref cnt_Program_儲位管理_儲位資訊_資料更新);

            if (cnt_Program_儲位管理_儲位資訊_資料更新 == 65500)
            {
                PLC_Device_儲位管理_儲位資訊_資料更新.Bool = false;
                cnt_Program_儲位管理_儲位資訊_資料更新 = 65535;
            }
        }
        void cnt_Program_儲位管理_儲位資訊_資料更新_檢查按下(ref int cnt)
        {
            if (PLC_Device_儲位管理_儲位資訊_資料更新.Bool) cnt++;
        }
        void cnt_Program_儲位管理_儲位資訊_資料更新_檢查放開(ref int cnt)
        {
            if (!PLC_Device_儲位管理_儲位資訊_資料更新.Bool) cnt = 65500;
        }
        void cnt_Program_儲位管理_儲位資訊_資料更新_初始化(ref int cnt)
        {
            MyTimer_TickTime.TickStop();
            MyTimer_TickTime.StartTickTime(50000);
            List_RowsLED_本地資料 = this.rowsLEDUI.SQL_GetAllRowsLED();
        
            Console.Write($"儲位管理RowsLED:從SQL取得資料 ,耗時 :{MyTimer_TickTime.GetTickTime().ToString("0.000")}\n");
            cnt++;
        }
        void cnt_Program_儲位管理_儲位資訊_資料更新_更新藥檔(ref int cnt)
        {
            MyTimer_TickTime.TickStop();
            MyTimer_TickTime.StartTickTime(50000);

            List<object[]> list_藥品資料_藥檔資料 = this.sqL_DataGridView_藥品資料_藥檔資料.SQL_GetAllRows(false);
            List<object[]> list_藥品資料_藥檔資料_buf = new List<object[]>();
            List<RowsLED> list_replaceValue = new List<RowsLED>();
            string 藥品碼 = "";
            string 藥品名稱 = "";
            string 藥品學名 = "";
            string BarCode = "";
            string 包裝單位 = "";


            string 藥品碼_buf = "";
            string 藥品名稱_buf = "";
            string 藥品學名_buf = "";
            string BarCode_buf = "";
            string 包裝單位_buf = "";
            List<RowsDevice> rowsDevices = List_RowsLED_本地資料[0].GetAllRowsDevices();
            bool Is_Replace = false;
            for (int k = 0; k < rowsDevices.Count; k++)
            {
                藥品碼 = rowsDevices[k].GetValue(Device.ValueName.藥品碼, Device.ValueType.Value).ObjectToString();
                if (藥品碼.StringIsEmpty()) continue;
                list_藥品資料_藥檔資料_buf = list_藥品資料_藥檔資料.GetRows((int)enum_藥品資料_藥檔資料.藥品碼, 藥品碼);
                if (list_藥品資料_藥檔資料_buf.Count == 0)
                {
                    rowsDevices[k].Clear();
                    Is_Replace = true;
                }
                else
                {
                    藥品碼_buf = list_藥品資料_藥檔資料_buf[0][(int)enum_藥品資料_藥檔資料.藥品碼].ObjectToString();
                    藥品名稱_buf = list_藥品資料_藥檔資料_buf[0][(int)enum_藥品資料_藥檔資料.藥品名稱].ObjectToString();
                    藥品學名_buf = list_藥品資料_藥檔資料_buf[0][(int)enum_藥品資料_藥檔資料.藥品學名].ObjectToString();
                    BarCode_buf = list_藥品資料_藥檔資料_buf[0][(int)enum_藥品資料_藥檔資料.藥品條碼].ObjectToString();
                    包裝單位_buf = list_藥品資料_藥檔資料_buf[0][(int)enum_藥品資料_藥檔資料.包裝單位].ObjectToString();

                    藥品碼 = rowsDevices[k].GetValue(Device.ValueName.藥品碼, Device.ValueType.Value).ObjectToString();
                    藥品名稱 = rowsDevices[k].GetValue(Device.ValueName.藥品名稱, Device.ValueType.Value).ObjectToString();
                    藥品學名 = rowsDevices[k].GetValue(Device.ValueName.藥品學名, Device.ValueType.Value).ObjectToString();
                    BarCode = rowsDevices[k].GetValue(Device.ValueName.包裝單位, Device.ValueType.Value).ObjectToString();
                    包裝單位 = rowsDevices[k].GetValue(Device.ValueName.包裝單位, Device.ValueType.Value).ObjectToString();
           

                    if (藥品碼 != 藥品碼_buf) Is_Replace = true;
                    if (藥品名稱 != 藥品名稱_buf) Is_Replace = true;
                    if (藥品學名 != 藥品學名_buf) Is_Replace = true;
                    if (BarCode != BarCode_buf) Is_Replace = true;
                    if (包裝單位 != 包裝單位_buf) Is_Replace = true;

                    rowsDevices[k].SetValue(Device.ValueName.藥品碼, Device.ValueType.Value, 藥品碼_buf);
                    rowsDevices[k].SetValue(Device.ValueName.藥品名稱, Device.ValueType.Value, 藥品名稱_buf);
                    rowsDevices[k].SetValue(Device.ValueName.藥品學名, Device.ValueType.Value, 藥品學名_buf);
                    rowsDevices[k].SetValue(Device.ValueName.BarCode, Device.ValueType.Value, BarCode_buf);
                    rowsDevices[k].SetValue(Device.ValueName.包裝單位, Device.ValueType.Value, 包裝單位_buf);
                 

                }
            }
            if (Is_Replace)
            {
                list_replaceValue.Add(this.List_RowsLED_本地資料[0]);
            }

            this.rowsLEDUI.SQL_ReplaceRowsLED(list_replaceValue);
            Console.Write($"儲位管理RowsLED:更新藥檔完成 ,耗時 :{MyTimer_TickTime.GetTickTime().ToString("0.000")}\n");
            cnt++;
        }
        void cnt_Program_儲位管理_儲位資訊_資料更新_更新面板資料(ref int cnt)
        {
            MyTimer_TickTime.TickStop();
            MyTimer_TickTime.StartTickTime(50000);
     
            List<object[]> list_value = new List<object[]>();
            for (int i = 0; i < List_RowsLED_本地資料[0].RowsDevices.Count; i++)
            {
                object[] value = new object[new enum_儲位管理_儲位資訊().GetLength()];
                value[(int)enum_儲位管理_儲位資訊.GUID] = List_RowsLED_本地資料[0].RowsDevices[i].GUID;
                value[(int)enum_儲位管理_儲位資訊.藥品碼] = List_RowsLED_本地資料[0].RowsDevices[i].GetValue(Device.ValueName.藥品碼, Device.ValueType.Value).ObjectToString();
                value[(int)enum_儲位管理_儲位資訊.藥品名稱] = List_RowsLED_本地資料[0].RowsDevices[i].GetValue(Device.ValueName.藥品名稱, Device.ValueType.Value).ObjectToString();
                value[(int)enum_儲位管理_儲位資訊.包裝單位] = List_RowsLED_本地資料[0].RowsDevices[i].GetValue(Device.ValueName.包裝單位, Device.ValueType.Value).ObjectToString();
                value[(int)enum_儲位管理_儲位資訊.層數] = List_RowsLED_本地資料[0].RowsDevices[i].GetValue(Device.ValueName.儲位名稱, Device.ValueType.Value).ObjectToString();
                value[(int)enum_儲位管理_儲位資訊.起始號碼] = List_RowsLED_本地資料[0].RowsDevices[i].StartLED;
                value[(int)enum_儲位管理_儲位資訊.結束號碼] = List_RowsLED_本地資料[0].RowsDevices[i].EndLED;
                value[(int)enum_儲位管理_儲位資訊.庫存] = List_RowsLED_本地資料[0].RowsDevices[i].Inventory;
                list_value.Add(value);
            }
            this.sqL_DataGridView_儲位管理_儲位資訊.RefreshGrid(list_value);
            Console.Write($"儲位管理RowsLED:更新層架列表完成 ,耗時 :{MyTimer_TickTime.GetTickTime().ToString("0.000")}\n");
            cnt++;
        }

        #endregion
        #region Event
        private void SqL_DataGridView_儲位管理_儲位資訊_DataGridRowsChangeRefEvent(ref List<object[]> RowsList)
        {
            RowsList.Sort(new ICP_儲位管理_儲位資訊());
        }
        private void SqL_DataGridView_儲位管理_儲位資訊_DataGridRefreshEvent()
        {

        }
        private void SqL_DataGridView_儲位管理_儲位資訊_RowEnterEvent(object[] RowValue)
        {
            int 層數 = RowValue[(int)enum_儲位管理_儲位資訊.層數].ObjectToString().StringToInt32();
            int Start_value = RowValue[(int)enum_儲位管理_儲位資訊.起始號碼].ObjectToString().StringToInt32();
            int End_value = RowValue[(int)enum_儲位管理_儲位資訊.結束號碼].ObjectToString().StringToInt32();

            plC_NumBox_儲位管理_起始號碼.Value = Start_value;
            plC_NumBox_儲位管理_結束號碼.Value = End_value;
            this.Function_工程模式_LED_Clear();
            this.Function_工程模式_LED(Start_value, End_value, true);
            //if (層數 < 0 || Start_value < 0 || End_value < 0) return;

            //if (層數 == 1)
            //{
            //    rJ_RatioButton_儲位管理_第一層.Checked = true;
            //}
            //if (層數 == 2)
            //{
            //    rJ_RatioButton_儲位管理_第二層.Checked = true;
            //}
            //if (層數 == 3)
            //{
            //    rJ_RatioButton_儲位管理_第三層.Checked = true;
            //}
            //if (層數 == 4)
            //{
            //    rJ_RatioButton_儲位管理_第四層.Checked = true;
            //}
            //if (層數 == 5)
            //{
            //    rJ_RatioButton_儲位管理_第五層.Checked = true;
            //}

            //this.rowsLED_Pannel_儲位管理_儲位號碼.SetValue(Start_value, End_value);


            string GUID = RowValue[(int)enum_儲位管理_儲位資訊.GUID].ObjectToString();
            RowsDevice rowsDevice = List_RowsLED_本地資料.GetRowsDevice(GUID);
            if (rowsDevice == null) return;
            sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.ClearGrid();

            List<object[]> list_value = new List<object[]>();
            for (int i = 0; i < rowsDevice.List_Validity_period.Count; i++)
            {
                object[] value = new object[new enum_儲位管理_儲位資訊_效期及庫存().GetLength()];
                value[(int)enum_儲位管理_儲位資訊_效期及庫存.效期] = rowsDevice.List_Validity_period[i];
                value[(int)enum_儲位管理_儲位資訊_效期及庫存.批號] = rowsDevice.List_Lot_number[i];
                value[(int)enum_儲位管理_儲位資訊_效期及庫存.庫存] = rowsDevice.List_Inventory[i];
                list_value.Add(value);
            }

            sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.RefreshGrid(list_value);
        }
        private void SqL_DataGridView_儲位管理_儲位資訊_RowDoubleClickEvent(object[] RowValue)
        {
           
        }

        private void PlC_RJ_Button_儲位管理_儲位資訊_更新_MouseDownEvent(MouseEventArgs mevent)
        {
            PLC_Device_儲位管理_儲位資訊_資料更新.Bool = true;
        }
        private void PlC_RJ_Button_儲位管理_儲位資訊_刪除儲位_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_儲位管理_儲位資訊.Get_All_Select_RowsValues();
            if(list_value.Count == 0)
            {
                MyMessageBox.ShowDialog("未選擇儲位!");
                return;
            }
            if (MyMessageBox.ShowDialog($"確認刪除選取 {list_value.Count} 筆資料?", MyMessageBox.enum_BoxType.Warning, MyMessageBox.enum_Button.Confirm_Cancel) != DialogResult.Yes) return;

            this.sqL_DataGridView_儲位管理_儲位資訊.DeleteExtra(list_value, true);
            for (int i = 0; i < list_value.Count; i++)
            {
                List_RowsLED_本地資料[0].Delete(list_value[i][(int)enum_儲位管理_儲位資訊.GUID].ObjectToString());
            }
            this.rowsLEDUI.SQL_ReplaceRowsLED(List_RowsLED_本地資料[0]);
            PLC_Device_儲位管理_儲位資訊_資料更新.Bool = true;

        }
        private void PlC_RJ_Button_儲位設定_亮燈範圍填入_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_儲位管理_儲位資訊.Get_All_Select_RowsValues();
            if (list_value.Count == 0)
            {
                MyMessageBox.ShowDialog("未選取資料!");
                return;
            }
            List<RowsDevice> rowsDevices = new List<RowsDevice>();
            string GUID = list_value[0][(int)enum_儲位管理_儲位資訊.GUID].ObjectToString();
            int StartLED = plC_NumBox_儲位管理_起始號碼.Value;
            int EndLED = plC_NumBox_儲位管理_結束號碼.Value;
            for (int i = 0; i < List_RowsLED_本地資料[0].RowsDevices.Count; i++)
            {
                int len = List_RowsLED_本地資料[0].RowsDevices[i].EndLED - List_RowsLED_本地資料[0].RowsDevices[i].StartLED;
                for (int k = List_RowsLED_本地資料[0].RowsDevices[i].StartLED; k <= List_RowsLED_本地資料[0].RowsDevices[i].EndLED; k++)
                {
                    if (k >= StartLED && k <= EndLED)
                    {
                        rowsDevices.Add(List_RowsLED_本地資料[0].RowsDevices[i]);
                        break;
                    }
                }
                
            } 
            if(rowsDevices.Count >= 2)
            {
                MyMessageBox.ShowDialog("此範圍儲位,有藥品!");
                return;
            }
            if (rowsDevices.Count == 1)
            {
                if (rowsDevices[0].GUID != GUID)
                {
                    MyMessageBox.ShowDialog("此範圍儲位,有藥品!");
                    return;
                }
            }
            RowsDevice rowsDevice = List_RowsLED_本地資料[0].SortByGUID(GUID);
            if(rowsDevice == null)
            {
                MyMessageBox.ShowDialog("查無儲位!");
                return;
            }
            rowsDevice.StartLED = StartLED;
            rowsDevice.EndLED = EndLED;
            rowsDevice.StorageName = ((rowsDevice.StartLED - 1) / 單層格數 + 1).ToString();

            this.rowsLEDUI.SQL_ReplaceRowsLED(List_RowsLED_本地資料[0]);
            PLC_Device_儲位管理_儲位資訊_資料更新.Bool = true;
        }
        private void PlC_RJ_Button_儲位管理_藥品資料_新增儲位_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_儲位管理_藥品資料.Get_All_Select_RowsValues();
            if(list_value.Count == 0)
            {
                MyMessageBox.ShowDialog("未選取資料!");
                return;
            }
            RowsDevice rowsDevice = new RowsDevice(List_RowsLED_本地資料[0].IP, List_RowsLED_本地資料[0].Port, 0, 0);
            rowsDevice.SetValue(Device.ValueName.藥品碼, Device.ValueType.Value, list_value[0][(int)enum_儲位管理_儲位資訊.藥品碼]);
 
            //if (rJ_RatioButton_儲位管理_第一層.Checked) rowsDevice.SetValue(Device.ValueName.儲位名稱, Device.ValueType.Value, "1");
            //if (rJ_RatioButton_儲位管理_第二層.Checked) rowsDevice.SetValue(Device.ValueName.儲位名稱, Device.ValueType.Value, "2");
            //if (rJ_RatioButton_儲位管理_第三層.Checked) rowsDevice.SetValue(Device.ValueName.儲位名稱, Device.ValueType.Value, "3");
            //if (rJ_RatioButton_儲位管理_第四層.Checked) rowsDevice.SetValue(Device.ValueName.儲位名稱, Device.ValueType.Value, "4");
            //if (rJ_RatioButton_儲位管理_第五層.Checked) rowsDevice.SetValue(Device.ValueName.儲位名稱, Device.ValueType.Value, "5");

            List_RowsLED_本地資料[0].Add_NewRowsLED(rowsDevice);
            this.rowsLEDUI.SQL_ReplaceRowsLED(List_RowsLED_本地資料);
            PLC_Device_儲位管理_儲位資訊_資料更新.Bool = true;
        }
        private void PlC_RJ_Button_儲位管理_藥品資料_顯示全部_MouseDownEvent(MouseEventArgs mevent)
        {
            this.sqL_DataGridView_儲位管理_藥品資料.SQL_GetAllRows(true);
        }
        private void PlC_RJ_Button_儲位設定_亮燈_MouseDownEvent(MouseEventArgs mevent)
        {
  
            int StartLED = plC_NumBox_儲位管理_起始號碼.Value;
            int EndLED = plC_NumBox_儲位管理_結束號碼.Value;
            this.Function_工程模式_LED_Clear();
            this.Function_工程模式_LED(StartLED, EndLED, true);
        }
        private void PlC_RJ_Button_儲位設定_滅燈_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Function_工程模式_LED_Clear();
        }
        private void PlC_RJ_Button_儲位設定_出料一次_MouseDownEvent(MouseEventArgs mevent)
        {
            int StartLED = plC_NumBox_儲位管理_起始號碼.Value;
            int EndLED = plC_NumBox_儲位管理_結束號碼.Value;
            this.Function_工程模式_Motor(StartLED, EndLED, true);
        }

        private void PlC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋_MouseDownEvent(MouseEventArgs mevent)
        {
            if (rJ_TextBox_儲位管理_藥品資料_中文名稱.Text.Length < 3)
            {
                MyMessageBox.ShowDialog("搜尋字元不得小於3個!");
                return;
            }
            List<object[]> list_value = this.sqL_DataGridView_儲位管理_藥品資料.SQL_GetAllRows(false);
            list_value = list_value.GetRowsStartWithByLike((int)enum_藥品資料_藥檔資料.藥品中文名稱, rJ_TextBox_儲位管理_藥品資料_中文名稱.Text.ToUpper());
            this.sqL_DataGridView_儲位管理_藥品資料.RefreshGrid(list_value);
        }
        private void PlC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋_MouseDownEvent(MouseEventArgs mevent)
        {
            if (rJ_TextBox_儲位管理_藥品資料_藥品名稱.Text.Length < 3)
            {
                MyMessageBox.ShowDialog("搜尋字元不得小於3個!");
                return;
            }
            List<object[]> list_value = this.sqL_DataGridView_儲位管理_藥品資料.SQL_GetAllRows(false);
            list_value = list_value.GetRowsStartWithByLike((int)enum_藥品資料_藥檔資料.藥品名稱, rJ_TextBox_儲位管理_藥品資料_藥品名稱.Text.ToUpper());
            this.sqL_DataGridView_儲位管理_藥品資料.RefreshGrid(list_value);
        }
        private void PlC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋_MouseDownEvent(MouseEventArgs mevent)
        {
            if (rJ_TextBox_儲位管理_藥品資料_藥品碼.Text.Length < 3)
            {
                MyMessageBox.ShowDialog("搜尋字元不得小於3個!");
                return;
            }
            List<object[]> list_value = this.sqL_DataGridView_儲位管理_藥品資料.SQL_GetAllRows(false);
            list_value = list_value.GetRowsStartWithByLike((int)enum_藥品資料_藥檔資料.藥品碼, rJ_TextBox_儲位管理_藥品資料_藥品碼.Text.ToUpper());
            this.sqL_DataGridView_儲位管理_藥品資料.RefreshGrid(list_value);
        }
        private void PlC_RJ_Button_儲位管理_儲位資訊_修正批號_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_儲位資訊 = this.sqL_DataGridView_儲位管理_儲位資訊.Get_All_Select_RowsValues();
            if (list_儲位資訊.Count == 0)
            {
                MyMessageBox.ShowDialog("未選擇儲位!");
                return;
            }
            string GUID = list_儲位資訊[0][(int)enum_儲位管理_儲位資訊.GUID].ObjectToString();
            RowsDevice rowsDevice = List_RowsLED_本地資料.GetRowsDevice(GUID);
            RowsLED rowsLED = List_RowsLED_本地資料.SortByIP(rowsDevice.IP);
            if (rowsDevice == null || rowsLED == null)
            {
                MyMessageBox.ShowDialog("未搜尋到儲位!");
                return;
            }
            if (rowsLED == null) return;
            object[] value = sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.GetRowValues();
            if (value == null)
            {
                MyMessageBox.ShowDialog("未選擇效期!");
                return;
            }
            string 效期 = value[(int)enum_儲位管理_儲位資訊_效期及庫存.效期].ObjectToString();
            string 舊批號 = value[(int)enum_儲位管理_儲位資訊_效期及庫存.批號].ObjectToString();
            string 新批號 = "";

            Dialog_輸入批號 dialog_輸入批號 = new Dialog_輸入批號();
            if (dialog_輸入批號.ShowDialog() == DialogResult.Yes)
            {
                新批號 = dialog_輸入批號.Value;
            }
            else
            {
                return;
            }
            rowsDevice.修正批號(效期, 新批號);
            rowsLED.ReplaceRowsDevice(rowsDevice);
            List_RowsLED_本地資料.Add_NewRowsLED(rowsLED);
            this.rowsLEDUI.SQL_ReplaceRowsLED(rowsLED);



            GUID = Guid.NewGuid().ToString();
            string 動作 = enum_交易記錄查詢動作.效期庫存異動.GetEnumName();
            string 藥品名稱 = rowsDevice.Name;
            string 藥袋序號 = textBox_工程模式_設備名稱_名稱.Text;
            string 交易量 = (0).ToString();
            string 結存量 = 0.ToString();
            string 操作人 = this.登入者名稱;
            string 病人姓名 = "";
            string 病歷號 = "";
            string 操作時間 = DateTime.Now.ToDateTimeString_6();
            string 開方時間 = DateTime.Now.ToDateTimeString_6();
            string 備註 = $"效期[{效期}]新批號[{新批號}]";
            object[] value_trading = new object[new enum_交易記錄查詢資料().GetLength()];
            value_trading[(int)enum_交易記錄查詢資料.GUID] = GUID;
            value_trading[(int)enum_交易記錄查詢資料.動作] = 動作;
            value_trading[(int)enum_交易記錄查詢資料.藥品碼] = "";
            value_trading[(int)enum_交易記錄查詢資料.藥品名稱] = 藥品名稱;
            value_trading[(int)enum_交易記錄查詢資料.藥袋序號] = 藥袋序號;
            value_trading[(int)enum_交易記錄查詢資料.庫存量] = 0.ToString();
            value_trading[(int)enum_交易記錄查詢資料.交易量] = 交易量;
            value_trading[(int)enum_交易記錄查詢資料.結存量] = 結存量;
            value_trading[(int)enum_交易記錄查詢資料.操作人] = 操作人;
            value_trading[(int)enum_交易記錄查詢資料.病人姓名] = 病人姓名;
            value_trading[(int)enum_交易記錄查詢資料.病歷號] = 病歷號;
            value_trading[(int)enum_交易記錄查詢資料.操作時間] = 操作時間;
            value_trading[(int)enum_交易記錄查詢資料.開方時間] = 開方時間;
            value_trading[(int)enum_交易記錄查詢資料.備註] = 備註;

            this.sqL_DataGridView_交易記錄查詢.SQL_AddRow(value_trading, false);

            List<object[]> list_value = this.sqL_DataGridView_儲位管理_儲位資訊.GetRows((int)enum_儲位管理_儲位資訊.GUID, rowsDevice.GUID, false);
            if (list_value.Count == 0) return;
            list_value[0][(int)enum_儲位管理_儲位資訊.庫存] = rowsDevice.取得庫存();
            this.sqL_DataGridView_儲位管理_儲位資訊.Replace((int)enum_儲位管理_儲位資訊.GUID, rowsDevice.GUID, list_value[0], true);

            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.ClearGrid();
            list_value = new List<object[]>();
            for (int i = 0; i < rowsDevice.List_Validity_period.Count; i++)
            {
                value = new object[new enum_儲位管理_儲位資訊_效期及庫存().GetLength()];
                value[(int)enum_儲位管理_儲位資訊_效期及庫存.效期] = rowsDevice.List_Validity_period[i];
                value[(int)enum_儲位管理_儲位資訊_效期及庫存.批號] = rowsDevice.List_Lot_number[i];
                value[(int)enum_儲位管理_儲位資訊_效期及庫存.庫存] = rowsDevice.List_Inventory[i];
                list_value.Add(value);
            }
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.RefreshGrid(list_value);
            this.Function_設定雲端資料更新();
        }
        private void PlC_RJ_Button_儲位管理_儲位資訊_修正庫存_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_儲位資訊 = this.sqL_DataGridView_儲位管理_儲位資訊.Get_All_Select_RowsValues();
            if (list_儲位資訊.Count == 0)
            {
                MyMessageBox.ShowDialog("未選擇儲位!");
                return;
            }
            string GUID = list_儲位資訊[0][(int)enum_儲位管理_儲位資訊.GUID].ObjectToString();
            RowsDevice rowsDevice = List_RowsLED_本地資料.GetRowsDevice(GUID);
            RowsLED rowsLED = List_RowsLED_本地資料.SortByIP(rowsDevice.IP);
            if (rowsDevice == null || rowsLED == null)
            {
                MyMessageBox.ShowDialog("未搜尋到儲位!");
                return;
            }
            if (rowsLED == null) return;
            object[] value = sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.GetRowValues();
            if (value == null)
            {
                MyMessageBox.ShowDialog("未選擇效期!");
                return;
            }
            string 效期 = value[(int)enum_儲位管理_儲位資訊_效期及庫存.效期].ObjectToString();
            string 批號 = value[(int)enum_儲位管理_儲位資訊_效期及庫存.批號].ObjectToString();
            string 數量 = "";
            Dialog_NumPannel dialog_NumPannel = new Dialog_NumPannel();
            if (dialog_NumPannel.ShowDialog() == DialogResult.Yes)
            {
                數量 = dialog_NumPannel.Value.ToString();
            }
            else
            {
                return;
            }


            int 原有庫存 = rowsDevice.取得庫存();
            string 藥品碼 = rowsDevice.Code;
            藥品碼 = Function_藥品碼檢查(藥品碼);
            string 庫存量 = this.Function_從SQL取得庫存(藥品碼).ToString();
            rowsDevice.效期庫存覆蓋(效期, 數量);
            int 修正庫存 = rowsDevice.取得庫存();
            rowsLED.ReplaceRowsDevice(rowsDevice);
            List_RowsLED_本地資料.Add_NewRowsLED(rowsLED);
            this.rowsLEDUI.SQL_ReplaceRowsLED(rowsLED);


            GUID = Guid.NewGuid().ToString();
            string 動作 = enum_交易記錄查詢動作.效期庫存異動.GetEnumName();
            string 藥品名稱 = rowsDevice.Name;
            string 藥袋序號 = textBox_工程模式_設備名稱_名稱.Text;
            string 交易量 = (修正庫存 - 原有庫存).ToString();
            string 結存量 = this.Function_從SQL取得庫存(藥品碼).ToString();
            string 操作人 = this.登入者名稱;
            string 病人姓名 = "";
            string 病歷號 = "";
            string 操作時間 = DateTime.Now.ToDateTimeString_6();
            string 開方時間 = DateTime.Now.ToDateTimeString_6();
            string 備註 = $"效期[{效期}],批號[{批號}]";
            object[] value_trading = new object[new enum_交易記錄查詢資料().GetLength()];
            value_trading[(int)enum_交易記錄查詢資料.GUID] = GUID;
            value_trading[(int)enum_交易記錄查詢資料.動作] = 動作;
            value_trading[(int)enum_交易記錄查詢資料.藥品碼] = 藥品碼;
            value_trading[(int)enum_交易記錄查詢資料.藥品名稱] = 藥品名稱;
            value_trading[(int)enum_交易記錄查詢資料.藥袋序號] = 藥袋序號;
            value_trading[(int)enum_交易記錄查詢資料.庫存量] = 庫存量;
            value_trading[(int)enum_交易記錄查詢資料.交易量] = 交易量;
            value_trading[(int)enum_交易記錄查詢資料.結存量] = 結存量;
            value_trading[(int)enum_交易記錄查詢資料.操作人] = 操作人;
            value_trading[(int)enum_交易記錄查詢資料.病人姓名] = 病人姓名;
            value_trading[(int)enum_交易記錄查詢資料.病歷號] = 病歷號;
            value_trading[(int)enum_交易記錄查詢資料.操作時間] = 操作時間;
            value_trading[(int)enum_交易記錄查詢資料.開方時間] = 開方時間;
            value_trading[(int)enum_交易記錄查詢資料.備註] = 備註;

            this.sqL_DataGridView_交易記錄查詢.SQL_AddRow(value_trading, false);

            List<object[]> list_value = this.sqL_DataGridView_儲位管理_儲位資訊.GetRows((int)enum_儲位管理_儲位資訊.GUID, rowsDevice.GUID, false);
            if (list_value.Count == 0) return;
            list_value[0][(int)enum_儲位管理_儲位資訊.庫存] = rowsDevice.取得庫存();
            this.sqL_DataGridView_儲位管理_儲位資訊.Replace((int)enum_儲位管理_儲位資訊.GUID, rowsDevice.GUID, list_value[0], true);

            sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.ClearGrid();
            list_value = new List<object[]>();
            for (int i = 0; i < rowsDevice.List_Validity_period.Count; i++)
            {
                value = new object[new enum_儲位管理_儲位資訊_效期及庫存().GetLength()];
                value[(int)enum_儲位管理_儲位資訊_效期及庫存.效期] = rowsDevice.List_Validity_period[i];
                value[(int)enum_儲位管理_儲位資訊_效期及庫存.批號] = rowsDevice.List_Lot_number[i];
                value[(int)enum_儲位管理_儲位資訊_效期及庫存.庫存] = rowsDevice.List_Inventory[i];
                list_value.Add(value);
            }

            sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.RefreshGrid(list_value);
            this.Function_設定雲端資料更新();
        }
        private void PlC_RJ_Button_儲位管理_儲位資訊_新增效期_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_儲位資訊 = this.sqL_DataGridView_儲位管理_儲位資訊.Get_All_Select_RowsValues();
            if (list_儲位資訊.Count == 0)
            {
                MyMessageBox.ShowDialog("未選擇儲位!");
                return;
            }
            string GUID = list_儲位資訊[0][(int)enum_儲位管理_儲位資訊.GUID].ObjectToString();
            RowsDevice rowsDevice = List_RowsLED_本地資料.GetRowsDevice(GUID);
            RowsLED rowsLED = List_RowsLED_本地資料.SortByIP(rowsDevice.IP);
            if(rowsDevice == null || rowsLED == null)
            {
                MyMessageBox.ShowDialog("未搜尋到儲位!");
                return;
            }
            string 效期 = "";
            string 批號 = "";
            string 數量 = "";
            Dialog_DateTime dialog_DateTime = new Dialog_DateTime();
            if (dialog_DateTime.ShowDialog() == DialogResult.Yes)
            {
                效期 = dialog_DateTime.Value.ToDateString();
            }
            else
            {
                return;
            }
            Dialog_輸入批號 dialog_輸入批號 = new Dialog_輸入批號();
            if (dialog_輸入批號.ShowDialog() == DialogResult.Yes)
            {
                批號 = dialog_輸入批號.Value;
            }
            else
            {
                return;
            }

            Dialog_NumPannel dialog_NumPannel = new Dialog_NumPannel();
            if (dialog_NumPannel.ShowDialog() == DialogResult.Yes)
            {
                數量 = dialog_NumPannel.Value.ToString();
            }
            else
            {
                return;
            }

            int 原有庫存 = rowsDevice.取得庫存();
            string 藥品碼 = rowsDevice.Code;
            藥品碼 = Function_藥品碼檢查(藥品碼);
            string 庫存量 = this.Function_從SQL取得庫存(藥品碼).ToString();
            rowsDevice.效期庫存覆蓋(效期, 批號, 數量);
            int 修正庫存 = rowsDevice.取得庫存();
            rowsLED.ReplaceRowsDevice(rowsDevice);
            List_RowsLED_本地資料.Add_NewRowsLED(rowsLED);
            this.rowsLEDUI.SQL_ReplaceRowsLED(rowsLED);


            GUID = Guid.NewGuid().ToString();
            string 動作 = enum_交易記錄查詢動作.效期庫存異動.GetEnumName();
            string 藥品名稱 = rowsDevice.Name;
            string 藥袋序號 = textBox_工程模式_設備名稱_名稱.Text;
            string 交易量 = (修正庫存 - 原有庫存).ToString();
            string 結存量 = this.Function_從SQL取得庫存(藥品碼).ToString();
            string 操作人 = this.登入者名稱;
            string 病人姓名 = "";
            string 病歷號 = "";
            string 操作時間 = DateTime.Now.ToDateTimeString_6();
            string 開方時間 = DateTime.Now.ToDateTimeString_6();
            string 備註 = $"效期[{效期}],批號[{批號}]";
            object[] value_trading = new object[new enum_交易記錄查詢資料().GetLength()];
            value_trading[(int)enum_交易記錄查詢資料.GUID] = GUID;
            value_trading[(int)enum_交易記錄查詢資料.動作] = 動作;
            value_trading[(int)enum_交易記錄查詢資料.藥品碼] = 藥品碼;
            value_trading[(int)enum_交易記錄查詢資料.藥品名稱] = 藥品名稱;
            value_trading[(int)enum_交易記錄查詢資料.藥袋序號] = 藥袋序號;
            value_trading[(int)enum_交易記錄查詢資料.庫存量] = 庫存量;
            value_trading[(int)enum_交易記錄查詢資料.交易量] = 交易量;
            value_trading[(int)enum_交易記錄查詢資料.結存量] = 結存量;
            value_trading[(int)enum_交易記錄查詢資料.操作人] = 操作人;
            value_trading[(int)enum_交易記錄查詢資料.病人姓名] = 病人姓名;
            value_trading[(int)enum_交易記錄查詢資料.病歷號] = 病歷號;
            value_trading[(int)enum_交易記錄查詢資料.操作時間] = 操作時間;
            value_trading[(int)enum_交易記錄查詢資料.開方時間] = 開方時間;
            value_trading[(int)enum_交易記錄查詢資料.備註] = 備註;

            this.sqL_DataGridView_交易記錄查詢.SQL_AddRow(value_trading, false);

            List<object[]> list_value = this.sqL_DataGridView_儲位管理_儲位資訊.GetRows((int)enum_儲位管理_儲位資訊.GUID, rowsDevice.GUID, false);
            if (list_value.Count == 0) return;
            list_value[0][(int)enum_儲位管理_儲位資訊.庫存] = rowsDevice.取得庫存();
            this.sqL_DataGridView_儲位管理_儲位資訊.Replace((int)enum_儲位管理_儲位資訊.GUID, rowsDevice.GUID, list_value[0], true);

            sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.ClearGrid();
            list_value = new List<object[]>();
            for (int i = 0; i < rowsDevice.List_Validity_period.Count; i++)
            {
                object[] value = new object[new enum_儲位管理_儲位資訊_效期及庫存().GetLength()];
                value[(int)enum_儲位管理_儲位資訊_效期及庫存.效期] = rowsDevice.List_Validity_period[i];
                value[(int)enum_儲位管理_儲位資訊_效期及庫存.批號] = rowsDevice.List_Lot_number[i];
                value[(int)enum_儲位管理_儲位資訊_效期及庫存.庫存] = rowsDevice.List_Inventory[i];
                list_value.Add(value);
            }
            sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.RefreshGrid(list_value);
            this.Function_設定雲端資料更新();
        }

        private void RJ_RatioButton_儲位管理_第一層_CheckedChanged(object sender, EventArgs e)
        {
            if(rJ_RatioButton_儲位管理_第一層.Checked)
            {


                plC_NumBox_儲位管理_起始號碼.Value = 1 + 單層格數 * 0;
                plC_NumBox_儲位管理_結束號碼.Value = 單層格數 * 1;

                this.rowsLED_Pannel_儲位管理_儲位號碼.SetMaxMinmun(plC_NumBox_儲位管理_起始號碼.Value, plC_NumBox_儲位管理_結束號碼.Value);
                this.rowsLED_Pannel_儲位管理_儲位號碼.SetValue(plC_NumBox_儲位管理_起始號碼.Value + 5, this.plC_NumBox_儲位管理_起始號碼.Value + 10);

            }
           
        }
        private void RJ_RatioButton_儲位管理_第二層_CheckedChanged(object sender, EventArgs e)
        {
            if (rJ_RatioButton_儲位管理_第二層.Checked)
            {
                plC_NumBox_儲位管理_起始號碼.Value = 1 + 單層格數 * 1;
                plC_NumBox_儲位管理_結束號碼.Value = 單層格數 * 2;
                this.rowsLED_Pannel_儲位管理_儲位號碼.SetMaxMinmun(plC_NumBox_儲位管理_起始號碼.Value, plC_NumBox_儲位管理_結束號碼.Value);
                this.rowsLED_Pannel_儲位管理_儲位號碼.SetValue(plC_NumBox_儲位管理_起始號碼.Value + 5, this.plC_NumBox_儲位管理_起始號碼.Value + 10);
            }
             
        }
        private void RJ_RatioButton_儲位管理_第三層_CheckedChanged(object sender, EventArgs e)
        {
            if (rJ_RatioButton_儲位管理_第三層.Checked)
            {
                plC_NumBox_儲位管理_起始號碼.Value = 1 + 單層格數 * 2;
                plC_NumBox_儲位管理_結束號碼.Value = 單層格數 * 3;
                this.rowsLED_Pannel_儲位管理_儲位號碼.SetMaxMinmun(plC_NumBox_儲位管理_起始號碼.Value, plC_NumBox_儲位管理_結束號碼.Value);
                this.rowsLED_Pannel_儲位管理_儲位號碼.SetValue(plC_NumBox_儲位管理_起始號碼.Value + 5, this.plC_NumBox_儲位管理_起始號碼.Value + 10);
            }
              
        }
        private void RJ_RatioButton_儲位管理_第四層_CheckedChanged(object sender, EventArgs e)
        {
            if (rJ_RatioButton_儲位管理_第四層.Checked)
            {
                plC_NumBox_儲位管理_起始號碼.Value = 1 + 單層格數 * 3;
                plC_NumBox_儲位管理_結束號碼.Value = 單層格數 * 4;
                this.rowsLED_Pannel_儲位管理_儲位號碼.SetMaxMinmun(plC_NumBox_儲位管理_起始號碼.Value, plC_NumBox_儲位管理_結束號碼.Value);
                this.rowsLED_Pannel_儲位管理_儲位號碼.SetValue(plC_NumBox_儲位管理_起始號碼.Value + 5, this.plC_NumBox_儲位管理_起始號碼.Value + 10);
            }
             
        }
        private void RJ_RatioButton_儲位管理_第五層_CheckedChanged(object sender, EventArgs e)
        {
            if (rJ_RatioButton_儲位管理_第五層.Checked)
            {
                plC_NumBox_儲位管理_起始號碼.Value = 1 + 單層格數 * 4;
                plC_NumBox_儲位管理_結束號碼.Value = 單層格數 * 5;
                this.rowsLED_Pannel_儲位管理_儲位號碼.SetMaxMinmun(plC_NumBox_儲位管理_起始號碼.Value, plC_NumBox_儲位管理_結束號碼.Value);
                this.rowsLED_Pannel_儲位管理_儲位號碼.SetValue(plC_NumBox_儲位管理_起始號碼.Value + 5, this.plC_NumBox_儲位管理_起始號碼.Value + 10);
            }
          
        }
        #endregion

        public class ICP_儲位管理_儲位資訊 : IComparer<object[]>
        {
            //實作Compare方法
            //依Speed由小排到大。
            public int Compare(object[] x, object[] y)
            {
                int temp0 = x[(int)enum_儲位管理_儲位資訊.起始號碼].ObjectToString().StringToInt32();
                int temp1 = y[(int)enum_儲位管理_儲位資訊.起始號碼].ObjectToString().StringToInt32();
                if (temp0 == -1 || temp1 == -1) return 1;
                if (temp0 == 0 || temp1 == 0) return 1;
                return temp0.CompareTo(temp1);
    

            }
        }
    }
}
