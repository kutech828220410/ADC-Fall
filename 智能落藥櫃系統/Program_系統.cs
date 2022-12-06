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
    public enum enum_雲端藥檔
    {
        GUID,
        藥品碼,
        中文名稱,
        藥品名稱,
        藥品學名,
        健保碼,
        包裝單位,
        包裝數量,
        最小包裝單位,
        最小包裝數量,
        藥品條碼1,
        藥品條碼2,
    }

    public partial class Form1 : Form
    {
        private void Program_系統_Init()
        {
            LoadConfig工程模式();
            SQL_DataGridView.SQL_Set_Properties(this.sqL_DataGridView_雲端藥檔, dBConfigClass.DB_Medicine_Cloud);

            this.sqL_DataGridView_雲端藥檔.Init();

            this.plC_RJ_Button_雲端藥檔_取得資料.MouseDownEvent += PlC_RJ_Button_雲端藥檔_取得資料_MouseDownEvent;
        }

        private void PlC_RJ_Button_雲端藥檔_取得資料_MouseDownEvent(MouseEventArgs mevent)
        {
            MyTimer myTimer = new MyTimer();
            myTimer.StartTickTime(50000);

            List<object[]> list_value = this.sqL_DataGridView_雲端藥檔.SQL_GetAllRows(false);
            Console.WriteLine($"取得雲端藥檔資料,耗時{myTimer.ToString()}ms");
            this.sqL_DataGridView_雲端藥檔.RefreshGrid(list_value);
            Console.WriteLine($"更新雲端藥檔至Datagridview,耗時{myTimer.ToString()}ms");
        }

        private void button_工程模式_調劑台名稱儲存_Click(object sender, EventArgs e)
        {
            SaveConfig工程模式();
            MyMessageBox.ShowDialog("儲存成功!");
        }
        #region StreamIO
        [Serializable]
        private class SaveConfig工程模式Class
        {
            public string 領藥台_01_名稱 = "";
            public string 領藥台_02_名稱 = "";
            public string 領藥台03_名稱 = "";
            public string 領藥台04_名稱 = "";
            public string 門未關閉警報語音內容 = "";

            public Color 領藥台_01_Color = Color.Black;
            public Color 領藥台_02_Color = Color.Black;
            public Color 領藥台03_Color = Color.Black;
            public Color 領藥台04_Color = Color.Black;
        }
        public void SaveConfig工程模式()
        {
            string StreamName = @".\\" + "adminConfig" + ".pro";
            SaveConfig工程模式Class saveConfig = new SaveConfig工程模式Class();
            saveConfig.領藥台_01_名稱 = this.textBox_工程模式_設備名稱_名稱.Text;
      
            Basic.FileIO.SaveProperties(saveConfig, StreamName);
        }
        public void LoadConfig工程模式()
        {
            string StreamName = @".\\" + "adminConfig" + ".pro";
            object temp = new object();
            Basic.FileIO.LoadProperties(ref temp, StreamName);
            if (temp is SaveConfig工程模式Class)
            {
                this.Invoke(new Action(delegate
                {
                    this.textBox_工程模式_設備名稱_名稱.Text = ((SaveConfig工程模式Class)temp).領藥台_01_名稱;
                }));
            }

        }
        #endregion
    }
}
