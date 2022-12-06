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
using MySQL_Login;
using H_Pannel_lib;

namespace 智能落藥櫃系統
{
    public enum enum_儲位資訊
    {
        IP,
        TYPE,
        效期,
        庫存,
        異動量,
        Value,
    }
    public partial class Form1 : Form
    {
        public List<RowsLED> List_RowsLED_本地資料 = new List<RowsLED>();
        public List<RowsLED> List_RowsLED_雲端資料 = new List<RowsLED>();
        public PLC_Device PLC_Device_LED = new PLC_Device("M1101Z6");
        public PLC_Device PLC_Device_Motor = new PLC_Device("M101Z8");

        public void Function_設定雲端資料更新()
        {
            this.Function_取藥堆疊資料_新增母資料(Guid.NewGuid().ToString(), "更新資料", enum_交易記錄查詢動作.None, "", "", "", "", "", "", "", "", "", "", 0, "");
        }
        public void Function_從SQL取得儲位到雲端資料()
        {
            try
            {
                MyTimer myTimer = new MyTimer();
                myTimer.StartTickTime(50000);
                Console.WriteLine($"開始SQL讀取儲位資料到雲端!");
                List<Task> taskList = new List<Task>();
   
      
                taskList.Add(Task.Run(() =>
                {
                    MyTimer myTimer2 = new MyTimer();
                    myTimer2.StartTickTime(50000);
                    List_RowsLED_雲端資料 = this.rowsLEDUI.SQL_GetAllRowsLED();
                    Console.WriteLine($"讀取RowsLED資料! 耗時 :{myTimer2.GetTickTime().ToString("0.000")} ");

                }));

                Task allTask = Task.WhenAll(taskList);
                allTask.Wait();
                Console.WriteLine($"SQL讀取儲位資料到雲端結束! 耗時 : {myTimer.GetTickTime().ToString("0.000")}");
            }
            catch
            {

            }

        }
        public List<object> Function_從SQL取得儲位到雲端資料(string 藥品碼)
        {
            List<object> list_value = new List<object>();

            List<RowsDevice> rowsDevices = this.List_RowsLED_雲端資料.SortByCode(藥品碼);
  
            for (int i = 0; i < rowsDevices.Count; i++)
            {
                RowsDevice rowsDevice = this.rowsLEDUI.SQL_GetRowsDevice(rowsDevices[i]);
                this.List_RowsLED_雲端資料.Add_NewRowsLED(rowsDevice);
                list_value.Add(rowsDevice);
            }
        
            return list_value;
        }
        public List<object> Function_從雲端資料取得儲位(string 藥品碼)
        {
            List<object> list_value = new List<object>();
            List<RowsDevice> rowsDevices = this.List_RowsLED_雲端資料.SortByCode(藥品碼);
    
            for (int i = 0; i < rowsDevices.Count; i++)
            {
                list_value.Add(rowsDevices[i]);
            }
         
            return list_value;
        }
        public void Function_從雲端資料取得儲位(string 藥品碼, ref List<string> TYPE, ref List<object> values)
        {
            List<object> list_value = this.Function_從雲端資料取得儲位(藥品碼);
            TYPE.Clear();
            values.Clear();
            for (int i = 0; i < list_value.Count; i++)
            {
                if (list_value[i] is Device)
                {
                    Device device = (Device)list_value[i];
                    values.Add(list_value[i]);
                    TYPE.Add(device.DeviceType.GetEnumName());
                }

            }
        }
        public int Function_從雲端資料取得庫存(string 藥品碼)
        {
            int 庫存 = 0;
            List<object> list_value = new List<object>();
            List<string> 儲位_TYPE = new List<string>();
            this.Function_從雲端資料取得儲位(this.Function_藥品碼檢查(藥品碼), ref 儲位_TYPE, ref list_value);

            for (int i = 0; i < list_value.Count; i++)
            {
                if (list_value[i] is Device)
                {
                    庫存 += ((Device)list_value[i]).Inventory.StringToInt32();
                }
            }
            if (list_value.Count == 0) return -999;
            return 庫存;
        }
        public List<object[]> Function_取得異動儲位資訊從雲端資料(string 藥品碼, int 異動量, string 效期, string IP)
        {
            List<object> 儲位 = new List<object>();
            List<string> 儲位_TYPE = new List<string>();
            this.Function_從雲端資料取得儲位(this.Function_藥品碼檢查(藥品碼), ref 儲位_TYPE, ref 儲位);
            List<object[]> 儲位資訊_buf = new List<object[]>();
            List<object[]> 儲位資訊 = new List<object[]>();
            for (int k = 0; k < 儲位.Count; k++)
            {
                object value_device = 儲位[k];
                object[] value = new object[new enum_儲位資訊().GetLength()];
                if (value_device is Device)
                {
                    Device device = (Device)value_device;
                    for (int i = 0; i < device.List_Validity_period.Count; i++)
                    {
                        if (device.List_Validity_period[i] == 效期 && device.IP == IP)
                        {
                            value[(int)enum_儲位資訊.IP] = device.IP;
                            value[(int)enum_儲位資訊.TYPE] = 儲位_TYPE[k];
                            value[(int)enum_儲位資訊.效期] = device.List_Validity_period[i];
                            value[(int)enum_儲位資訊.庫存] = device.List_Inventory[i];
                            value[(int)enum_儲位資訊.異動量] = 異動量.ToString();
                            value[(int)enum_儲位資訊.Value] = value_device;
                            儲位資訊.Add(value);
                            break;
                        }
                    }
                }
            }
            return 儲位資訊;
        }
        public List<object[]> Function_取得異動儲位資訊從雲端資料(string 藥品碼, int 異動量, string 效期)
        {
            List<object> 儲位 = new List<object>();
            List<string> 儲位_TYPE = new List<string>();
            this.Function_從雲端資料取得儲位(this.Function_藥品碼檢查(藥品碼), ref 儲位_TYPE, ref 儲位);
            List<object[]> 儲位資訊_buf = new List<object[]>();
            List<object[]> 儲位資訊 = new List<object[]>();
            for (int k = 0; k < 儲位.Count; k++)
            {
                object value_device = 儲位[k];
                object[] value = new object[new enum_儲位資訊().GetLength()];
                if (value_device is Device)
                {
                    Device device = (Device)value_device;
                    for (int i = 0; i < device.List_Validity_period.Count; i++)
                    {
                        if (device.List_Validity_period[i] == 效期)
                        {
                            value[(int)enum_儲位資訊.IP] = device.IP;
                            value[(int)enum_儲位資訊.TYPE] = 儲位_TYPE[k];
                            value[(int)enum_儲位資訊.效期] = device.List_Validity_period[i];
                            value[(int)enum_儲位資訊.庫存] = device.List_Inventory[i];
                            value[(int)enum_儲位資訊.異動量] = 異動量.ToString();
                            value[(int)enum_儲位資訊.Value] = value_device;
                            儲位資訊.Add(value);
                            break;
                        }
                    }
                }
            }
            return 儲位資訊;
        }
        public List<object[]> Function_取得異動儲位資訊從雲端資料(string 藥品碼, int 異動量)
        {
            List<object> 儲位 = new List<object>();
            List<string> 儲位_TYPE = new List<string>();
            this.Function_從雲端資料取得儲位(this.Function_藥品碼檢查(藥品碼), ref 儲位_TYPE, ref 儲位);
            List<object[]> 儲位資訊_buf = new List<object[]>();
            List<object[]> 儲位資訊 = new List<object[]>();
            if (儲位.Count == 0) return 儲位資訊_buf;


            for (int k = 0; k < 儲位.Count; k++)
            {
                object value_device = 儲位[k];
                if (value_device is Device)
                {
                    Device device = (Device)value_device;
                    for (int i = 0; i < device.List_Validity_period.Count; i++)
                    {
                        object[] value = new object[new enum_儲位資訊().GetLength()];
                        value[(int)enum_儲位資訊.IP] = device.IP;
                        value[(int)enum_儲位資訊.TYPE] = 儲位_TYPE[k];
                        value[(int)enum_儲位資訊.效期] = device.List_Validity_period[i];
                        value[(int)enum_儲位資訊.庫存] = device.List_Inventory[i];
                        value[(int)enum_儲位資訊.異動量] = "0";
                        value[(int)enum_儲位資訊.Value] = value_device;
                        儲位資訊.Add(value);
                    }
                }
            }
            儲位資訊 = 儲位資訊.OrderBy(r => DateTime.Parse(r[(int)enum_儲位資訊.效期].ToDateString())).ToList();

            if (異動量 == 0) return 儲位資訊;
            int 使用數量 = 異動量;
            int 庫存數量 = 0;
            int 剩餘庫存數量 = 0;
            for (int i = 0; i < 儲位資訊.Count; i++)
            {
                庫存數量 = 儲位資訊[i][(int)enum_儲位資訊.庫存].ObjectToString().StringToInt32();
                if ((使用數量 < 0 && 庫存數量 > 0) || (使用數量 > 0 && 庫存數量 >= 0))
                {
                    剩餘庫存數量 = 庫存數量 + 使用數量;
                    if (剩餘庫存數量 >= 0)
                    {
                        儲位資訊[i][(int)enum_儲位資訊.異動量] = (使用數量).ToString();
                        儲位資訊_buf.Add(儲位資訊[i]);
                        break;
                    }
                    else
                    {
                        儲位資訊[i][(int)enum_儲位資訊.異動量] = (庫存數量 * -1).ToString();
                        使用數量 = 剩餘庫存數量;
                        儲位資訊_buf.Add(儲位資訊[i]);
                    }
                }
            }

            return 儲位資訊_buf;
        }
        public object Function_庫存異動至雲端資料(object[] 儲位資訊)
        {
            return this.Function_庫存異動至雲端資料(儲位資訊, false);
        }
        public object Function_庫存異動至雲端資料(object[] 儲位資訊, bool upToSQL)
        {
            object Value = 儲位資訊[(int)enum_儲位資訊.Value];
            string 效期 = 儲位資訊[(int)enum_儲位資訊.效期].ObjectToString();
            string 異動量 = 儲位資訊[(int)enum_儲位資訊.異動量].ObjectToString();
            string TYPE = 儲位資訊[(int)enum_儲位資訊.TYPE].ObjectToString();
        
            if (Value is RowsDevice)
            {
                if (TYPE == DeviceType.RowsLED.GetEnumName())
                {
                    RowsDevice rowsDevice = Value as RowsDevice;
                    rowsDevice.效期庫存異動(效期, 異動量, false);
                    this.List_RowsLED_雲端資料.Add_NewRowsLED(rowsDevice);
                    RowsLED rowsLED = this.List_RowsLED_雲端資料.SortByIP(rowsDevice.IP);
                    if (upToSQL) this.rowsLEDUI.SQL_ReplaceRowsLED(rowsLED);
                    rowsLED.UpToSQL = true;
                    return rowsLED;
                }

            }
   
            return null;
        }
        public void Function_雲端資料上傳至SQL()
        {

            List<RowsLED> list_RowsLED = this.List_RowsLED_雲端資料.GetUpToSQL();

            if (list_RowsLED.Count > 0) this.rowsLEDUI.SQL_ReplaceRowsLED(list_RowsLED);

        }


        public void Function_從SQL取得儲位到本地資料()
        {

            MyTimer myTimer = new MyTimer();
            myTimer.StartTickTime(50000);
            Console.WriteLine($"開始SQL讀取儲位資料到本地!");
            List<Task> taskList = new List<Task>();
            taskList.Add(Task.Run(() =>
            {
                MyTimer myTimer2 = new MyTimer();
                myTimer2.StartTickTime(50000);
                List_RowsLED_本地資料 = this.rowsLEDUI.SQL_GetAllRowsLED();
                Console.WriteLine($"讀取RowsLED資料! 耗時 :{myTimer2.GetTickTime().ToString("0.000")} ");

            }));
            Task allTask = Task.WhenAll(taskList);
            allTask.Wait();
            Console.WriteLine($"SQL讀取儲位資料到本地結束! 耗時 : {myTimer.GetTickTime().ToString("0.000")}");
        }
        public List<object> Function_從本地資料取得儲位(string 藥品碼)
        {
            List<object> list_value = new List<object>();
            List<RowsDevice> rowsDevices = this.List_RowsLED_本地資料.SortByCode(藥品碼);
    
            for (int i = 0; i < rowsDevices.Count; i++)
            {
                list_value.Add(rowsDevices[i]);
            }
            
            return list_value;
        }
        public object Fucnction_從本地資料取得儲位(string IP)
        {
            RowsLED rowsLED = this.List_RowsLED_本地資料.SortByIP(IP);
            if (rowsLED != null) return rowsLED;
            return null;
        }
        public List<Device> Function_從SQL取得所有儲位()
        {
            List<List<Device>> list_list_devices = new List<List<Device>>();
            List<Device> devices = new List<Device>();
            this.Function_從SQL取得儲位到本地資料();

            list_list_devices.Add(this.List_RowsLED_本地資料.GetAllDevice());

            for (int i = 0; i < list_list_devices.Count; i++)
            {
                foreach (Device device in list_list_devices[i])
                {
                    device.確認效期庫存(true);
                    devices.Add(device);
                }
            }
            return devices;
        }
        public List<object> Function_從SQL取得儲位到本地資料(string 藥品碼)
        {
            List<object> list_value = new List<object>();

            List<RowsDevice> rowsDevices = this.List_RowsLED_本地資料.SortByCode(藥品碼);

       
            for (int i = 0; i < rowsDevices.Count; i++)
            {
                RowsDevice rowsDevice = this.rowsLEDUI.SQL_GetRowsDevice(rowsDevices[i]);
                this.List_RowsLED_本地資料.Add_NewRowsLED(rowsDevice);
                list_value.Add(rowsDevice);
            }
          
            return list_value;
        }
        public int Function_從本地資料取得庫存(string 藥品碼)
        {
            int 庫存 = 0;
            List<object> list_value = this.Function_從本地資料取得儲位(藥品碼);
            for (int i = 0; i < list_value.Count; i++)
            {
                if (list_value[i] is Device)
                {
                    Device device = (Device)list_value[i];
                    if (device != null)
                    {
                        庫存 += device.Inventory.StringToInt32();
                    }
                }
            }
            return 庫存;
        }
        public int Function_從SQL取得庫存(string 藥品碼)
        {
            int 庫存 = 0;
            List<object> list_value = this.Function_從SQL取得儲位到本地資料(藥品碼);
            for (int i = 0; i < list_value.Count; i++)
            {

                if (list_value[i] is Device)
                {
                    Device device = list_value[i] as Device;
                    if (device != null)
                    {
                        庫存 += device.Inventory.StringToInt32();
                    }
                }

            }
            return 庫存;
        }

        public void Function_LED(int 層數, int 個數, bool state)
        {
            PLC_Device pLC_Device = new PLC_Device("Z6");
            int index = 層數 * 100;
            index = index + 個數;
            pLC_Device.Value = index;
            PLC_Device_LED.Bool = state;
        }
        public void Function_Set_Motor(int 層數, int 個數, bool state)
        {
            PLC_Device pLC_Device = new PLC_Device("Z8");
            int index = 層數 * 100;
            index = index + 個數;
            pLC_Device.Value = index;
            PLC_Device_Motor.Bool = state;
        }
        public bool Function_Get_Motor(int 層數, int 個數)
        {
            PLC_Device pLC_Device = new PLC_Device("Z8");
            int index = 層數 * 100;
            index = index + 個數;
            pLC_Device.Value = index;
            return PLC_Device_Motor.Bool;
        }
        public string Function_藥品碼檢查(string Code)
        {
            //if (Code.Length < 5) Code = "0" + Code;
            //if (Code.Length < 5) Code = "0" + Code;
            //if (Code.Length < 5) Code = "0" + Code;
            //if (Code.Length < 5) Code = "0" + Code;
            //if (Code.Length < 5) Code = "0" + Code;
            return Code;
        }
    }
}
