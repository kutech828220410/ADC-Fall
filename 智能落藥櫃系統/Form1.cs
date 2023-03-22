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
[assembly: AssemblyVersion("1.0.10.0")]
[assembly: AssemblyFileVersion("1.0.10.0")]
namespace 智能落藥櫃系統
{
    public partial class Form1 : Form
    {
        Voice voice = new Voice();
        Basic.MyConvert myConvert = new Basic.MyConvert();
        PLC_Device PLC_Device_主頁面頁碼 = new PLC_Device("D0");
        MyTimer MyTimer_TickTime = new MyTimer();

        private string FormText = "";
        private Stopwatch stopwatch = new Stopwatch();

        #region DBConfigClass
        private const string DBConfigFileName = "DBConfig.txt";
        public DBConfigClass dBConfigClass = new DBConfigClass();
        public class DBConfigClass
        {
            private SQL_DataGridView.ConnentionClass dB_Basic = new SQL_DataGridView.ConnentionClass();
            private SQL_DataGridView.ConnentionClass dB_person_page = new SQL_DataGridView.ConnentionClass();
            private SQL_DataGridView.ConnentionClass dB_order_list = new SQL_DataGridView.ConnentionClass();
            private SQL_DataGridView.ConnentionClass dB_Medicine_Cloud = new SQL_DataGridView.ConnentionClass();
            private SQL_DataGridView.ConnentionClass dB_trading = new SQL_DataGridView.ConnentionClass();
            private string orderApiURL = "";
            private string medApiURL = "";


            public SQL_DataGridView.ConnentionClass DB_Basic { get => dB_Basic; set => dB_Basic = value; }
            public SQL_DataGridView.ConnentionClass DB_person_page { get => dB_person_page; set => dB_person_page = value; }
            public SQL_DataGridView.ConnentionClass DB_order_list { get => dB_order_list; set => dB_order_list = value; }
            public SQL_DataGridView.ConnentionClass DB_Medicine_Cloud { get => dB_Medicine_Cloud; set => dB_Medicine_Cloud = value; }
            public SQL_DataGridView.ConnentionClass DB_trading { get => dB_trading; set => dB_trading = value; }
            public string OrderApiURL { get => orderApiURL; set => orderApiURL = value; }
            public string MedApiURL { get => medApiURL; set => medApiURL = value; }
        }
        private void LoadDBConfig()
        {
            string jsonstr = MyFileStream.LoadFileAllText($".//{DBConfigFileName}");
            if (jsonstr.StringIsEmpty())
            {

                jsonstr = Basic.Net.JsonSerializationt<DBConfigClass>(new DBConfigClass(), true);
                List<string> list_jsonstring = new List<string>();
                list_jsonstring.Add(jsonstr);
                if (!MyFileStream.SaveFile($".//{DBConfigFileName}", list_jsonstring))
                {
                    MyMessageBox.ShowDialog($"建立{DBConfigFileName}檔案失敗!");
                }
                MyMessageBox.ShowDialog($"未建立參數文件!請至子目錄設定{DBConfigFileName}");
                Application.Exit();
            }
            else
            {
                dBConfigClass = Basic.Net.JsonDeserializet<DBConfigClass>(jsonstr);

                jsonstr = Basic.Net.JsonSerializationt<DBConfigClass>(dBConfigClass, true);
                List<string> list_jsonstring = new List<string>();
                list_jsonstring.Add(jsonstr);
                if (!MyFileStream.SaveFile($".//{DBConfigFileName}", list_jsonstring))
                {
                    MyMessageBox.ShowDialog($"建立{DBConfigFileName}檔案失敗!");
                }

            }
        }
        #endregion
        #region MyConfigClass
        private const string MyConfigFileName = "MyConfig.txt";
        public MyConfigClass myConfigClass = new MyConfigClass();
        public class MyConfigClass
        {
            private string fTP_Server = "";
            private bool _帳密登入_Enable = true;
            private string rFID_COMPort = "COM1";
            private string scanner_COMPort = "COM2";
            private string _藥物辨識網址 = "";

            public string FTP_Server { get => fTP_Server; set => fTP_Server = value; }
            public bool 帳密登入_Enable { get => _帳密登入_Enable; set => _帳密登入_Enable = value; }
            public string RFID_COMPort { get => rFID_COMPort; set => rFID_COMPort = value; }
            public string Scanner_COMPort { get => scanner_COMPort; set => scanner_COMPort = value; }
            public string 藥物辨識網址 { get => _藥物辨識網址; set => _藥物辨識網址 = value; }
        }
        private void LoadMyConfig()
        {
            string jsonstr = MyFileStream.LoadFileAllText($".//{MyConfigFileName}");
            if (jsonstr.StringIsEmpty())
            {
                jsonstr = Basic.Net.JsonSerializationt<MyConfigClass>(new MyConfigClass(), true);
                List<string> list_jsonstring = new List<string>();
                list_jsonstring.Add(jsonstr);
                if (!MyFileStream.SaveFile($".//{MyConfigFileName}", list_jsonstring))
                {
                    MyMessageBox.ShowDialog($"建立{MyConfigFileName}檔案失敗!");
                }
                MyMessageBox.ShowDialog($"未建立參數文件!請至子目錄設定{MyConfigFileName}");
                Application.Exit();
            }
            else
            {
                myConfigClass = Basic.Net.JsonDeserializet<MyConfigClass>(jsonstr);

                jsonstr = Basic.Net.JsonSerializationt<MyConfigClass>(myConfigClass, true);
                List<string> list_jsonstring = new List<string>();
                list_jsonstring.Add(jsonstr);
                if (!MyFileStream.SaveFile($".//{MyConfigFileName}", list_jsonstring))
                {
                    MyMessageBox.ShowDialog($"建立{MyConfigFileName}檔案失敗!");
                }

            }

        }
        #endregion
        #region FtpConfigClass
        private const string FtpConfigFileName = "FtpConfig.txt";
        public FtpConfigClass ftpConfigClass = new FtpConfigClass();
        public class FtpConfigClass
        {
            private string fTP_Server = "";
            private string fTP_username = "";
            private string fTP_password = "";

            public string FTP_Server { get => fTP_Server; set => fTP_Server = value; }
            public string FTP_username { get => fTP_username; set => fTP_username = value; }
            public string FTP_password { get => fTP_password; set => fTP_password = value; }
        }
        private void LoadFtpConfig()
        {
            string jsonstr = MyFileStream.LoadFileAllText($".//{FtpConfigFileName}");
            if (jsonstr.StringIsEmpty())
            {
                jsonstr = Basic.Net.JsonSerializationt<FtpConfigClass>(new FtpConfigClass(), true);
                List<string> list_jsonstring = new List<string>();
                list_jsonstring.Add(jsonstr);
                if (!MyFileStream.SaveFile($".//{FtpConfigFileName}", list_jsonstring))
                {
                    MyMessageBox.ShowDialog($"建立{FtpConfigFileName}檔案失敗!");
                }
                MyMessageBox.ShowDialog($"未建立參數文件!請至子目錄設定{FtpConfigFileName}");
                Application.Exit();
            }
            else
            {
                ftpConfigClass = Basic.Net.JsonDeserializet<FtpConfigClass>(jsonstr);

                jsonstr = Basic.Net.JsonSerializationt<FtpConfigClass>(ftpConfigClass, true);
                List<string> list_jsonstring = new List<string>();
                list_jsonstring.Add(jsonstr);
                if (!MyFileStream.SaveFile($".//{FtpConfigFileName}", list_jsonstring))
                {
                    MyMessageBox.ShowDialog($"建立{FtpConfigFileName}檔案失敗!");
                }

            }

            this.ftp_DounloadUI.FTP_Server = ftpConfigClass.FTP_Server;
            this.ftp_DounloadUI.Username = ftpConfigClass.FTP_username;
            this.ftp_DounloadUI.Password = ftpConfigClass.FTP_password;
            string updateVersion = this.ftp_DounloadUI.GetFileVersion();
            if (this.ftp_DounloadUI.CheckUpdate(this.ProductVersion, updateVersion))
            {
                if (Basic.MyMessageBox.ShowDialog(string.Format("有新版本是否更新? (Ver : {0})", updateVersion), "Update", Basic.MyMessageBox.enum_BoxType.Asterisk, Basic.MyMessageBox.enum_Button.Confirm_Cancel) == DialogResult.Yes)
                {
                    this.Invoke(new Action(delegate { this.Update(); }));
                }
            }
        }
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MyMessageBox.form = this.FindForm();
            Dialog_NumPannel.form = this.FindForm();
            Dialog_輸入批號.form = this.FindForm();
            Dialog_設定產出時間.form = this.FindForm();
            Dialog_DateTime.form = this.FindForm();
            Basic.MyMessageBox.音效 = false;

            LoadDBConfig();
            LoadMyConfig();
            LoadFtpConfig();
            this.stopwatch.Start();
            this.Text += "Ver" + this.ProductVersion;
            this.FormText = this.Text;
            this.WindowState = FormWindowState.Maximized;
            this.plC_UI_Init.音效 = false;
            this.plC_UI_Init.全螢幕顯示 = false;

      

            string ProcessName = "WINWORD";//換成想要結束的進程名字
            System.Diagnostics.Process[] MyProcess = System.Diagnostics.Process.GetProcessesByName(ProcessName);
            for (int i = 0; i < MyProcess.Length; i++)
            {
                MyProcess[i].Kill();
            }
            this.plC_UI_Init.Run(this.FindForm(), this.lowerMachine_Panel);
            this.plC_UI_Init.UI_Finished_Event += PlC_UI_Init_UI_Finished_Event;
        }
        private void PlC_UI_Init_UI_Finished_Event()
        {

            if (!myConfigClass.RFID_COMPort.StringIsEmpty()) this.rfiD_FX600_UI.Init(myConfigClass.RFID_COMPort);


            PLC_UI_Init.Set_PLC_ScreenPage(panel_Main, this.plC_ScreenPage_Main);
            PLC_UI_Init.Set_PLC_ScreenPage(panel_系統, this.plC_ScreenPage_系統);
            PLC_UI_Init.Set_PLC_ScreenPage(panel_人員資料, this.plC_ScreenPage_人員資料);
            PLC_UI_Init.Set_PLC_ScreenPage(panel_藥品資料, this.plC_ScreenPage_藥品資料);

            SQLUI.SQL_DataGridView.SQL_Set_Properties(dBConfigClass.DB_Basic.DataBaseName, dBConfigClass.DB_Basic.UserName, dBConfigClass.DB_Basic.Password, dBConfigClass.DB_Basic.IP, dBConfigClass.DB_Basic.Port, dBConfigClass.DB_Basic.MySqlSslMode, this.FindForm());


            this.Program_系統_Init();
            this.Program_藥品資料_藥檔資料_Init();
            this.Program_交易記錄查詢_Init();
            this.Program_人員資料_Init();
            this.Program_儲位管理_Init();
            this.Program_領藥作業_Init();
            this.Program_後台登入_Init();
            this.Program_工程模式_Init();
            this.Program_取藥堆疊資料_Init();
            this.Program_Scanner_Init();

            this.plC_UI_Init.Add_Method(sub_Program_門未關閉警示);

            this.plC_RJ_Button_系統更新.MouseDownEvent += PlC_RJ_Button_系統更新_MouseDownEvent;
            this.plC_RJ_Button_藥物辨識圖片測試.MouseDownEvent += PlC_RJ_Button_藥物辨識圖片測試_MouseDownEvent;
        }

        private void PlC_RJ_Button_藥物辨識圖片測試_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Function_顯示藥物辨識圖片("08566", this.pictureBox_領藥台_01_藥品圖片);
        }



        #region PLC_Method
        PLC_Device PLC_Device_Method = new PLC_Device("");
        PLC_Device PLC_Device_Method_OK = new PLC_Device("");
        Task Task_Method;
        MyTimer MyTimer_Method_結束延遲 = new MyTimer();
        int cnt_Program_Method = 65534;
        void sub_Program_Method()
        {
            if (cnt_Program_Method == 65534)
            {
                this.MyTimer_Method_結束延遲.StartTickTime(10000);
                PLC_Device_Method.SetComment("PLC_Method");
                PLC_Device_Method_OK.SetComment("PLC_Method_OK");
                PLC_Device_Method.Bool = false;
                cnt_Program_Method = 65535;
            }
            if (cnt_Program_Method == 65535) cnt_Program_Method = 1;
            if (cnt_Program_Method == 1) cnt_Program_Method_檢查按下(ref cnt_Program_Method);
            if (cnt_Program_Method == 2) cnt_Program_Method_初始化(ref cnt_Program_Method);
            if (cnt_Program_Method == 3) cnt_Program_Method = 65500;
            if (cnt_Program_Method > 1) cnt_Program_Method_檢查放開(ref cnt_Program_Method);

            if (cnt_Program_Method == 65500)
            {
                this.MyTimer_Method_結束延遲.TickStop();
                this.MyTimer_Method_結束延遲.StartTickTime(10000);
                PLC_Device_Method.Bool = false;
                PLC_Device_Method_OK.Bool = false;
                cnt_Program_Method = 65535;
            }
        }
        void cnt_Program_Method_檢查按下(ref int cnt)
        {
            if (PLC_Device_Method.Bool) cnt++;
        }
        void cnt_Program_Method_檢查放開(ref int cnt)
        {
            if (!PLC_Device_Method.Bool) cnt = 65500;
        }
        void cnt_Program_Method_初始化(ref int cnt)
        {
            if (this.MyTimer_Method_結束延遲.IsTimeOut())
            {
                if (Task_Method == null)
                {
                    Task_Method = new Task(new Action(delegate { }));
                }
                if (Task_Method.Status == TaskStatus.RanToCompletion)
                {
                    Task_Method = new Task(new Action(delegate { }));
                }
                if (Task_Method.Status == TaskStatus.Created)
                {
                    Task_Method.Start();
                }
                cnt++;
            }
        }







        #endregion
        private void PlC_RJ_Button_系統更新_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Update();
        }
        private void Update()
        {
            if (this.ftp_DounloadUI.DownloadFile())
            {
                if (this.ftp_DounloadUI.SaveFile())
                {
                    this.ftp_DounloadUI.RunFile(this.FindForm());
                }
                else
                {
                    Basic.MyMessageBox.ShowDialog("安裝檔存檔失敗!");
                }
            }
            else
            {
                Basic.MyMessageBox.ShowDialog("下載失敗!");
            }
        }
    }
}
