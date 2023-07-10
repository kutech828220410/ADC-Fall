namespace 智能落藥櫃系統
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            MyUI.PLC_MultiStateDisplay.TextValue textValue1 = new MyUI.PLC_MultiStateDisplay.TextValue();
            MyUI.PLC_MultiStateDisplay.TextValue textValue2 = new MyUI.PLC_MultiStateDisplay.TextValue();
            MyUI.PLC_MultiStateDisplay.TextValue textValue3 = new MyUI.PLC_MultiStateDisplay.TextValue();
            MyUI.PLC_MultiStateDisplay.TextValue textValue4 = new MyUI.PLC_MultiStateDisplay.TextValue();
            MyUI.PLC_MultiStateDisplay.TextValue textValue5 = new MyUI.PLC_MultiStateDisplay.TextValue();
            MyUI.PLC_MultiStateDisplay.TextValue textValue6 = new MyUI.PLC_MultiStateDisplay.TextValue();
            this.plC_ScreenPage_Main = new MyUI.PLC_ScreenPage();
            this.領藥作業 = new System.Windows.Forms.TabPage();
            this.rJ_GroupBox4 = new MyUI.RJ_GroupBox();
            this.pictureBox_領藥台_01_藥品圖片 = new System.Windows.Forms.PictureBox();
            this.plC_RJ_Button_藥物辨識圖片測試 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_掃碼測試 = new MyUI.PLC_RJ_Button();
            this.rJ_GroupBox_領藥台_01 = new MyUI.RJ_GroupBox();
            this.plC_RJ_Button_領藥台_01_強制入帳 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_領藥台_01_手輸醫囑 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_領藥台_01_手動作業 = new MyUI.PLC_RJ_Button();
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條 = new MyUI.RJ_ProgressBar();
            this.plC_RJ_Button_領藥台_01_取消作業 = new MyUI.PLC_RJ_Button();
            this.plC_Button_領藥台_01_退 = new MyUI.PLC_Button();
            this.plC_Button_領藥台_01_領 = new MyUI.PLC_Button();
            this.plC_RJ_Button_領藥台_01_登出 = new MyUI.PLC_RJ_Button();
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條 = new MyUI.RJ_ProgressBar();
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示 = new MyUI.PLC_MultiStateDisplay();
            this.sqL_DataGridView_領藥台_01_領藥內容 = new SQLUI.SQL_DataGridView();
            this.rJ_GroupBox5 = new MyUI.RJ_GroupBox();
            this.plC_RJ_Button_領藥台_01_登入 = new MyUI.PLC_RJ_Button();
            this.textBox_領藥台_01_帳號 = new MyUI.RJ_TextBox();
            this.textBox_領藥台_01_密碼 = new MyUI.RJ_TextBox();
            this.後台登入 = new System.Windows.Forms.TabPage();
            this.groupBox26 = new System.Windows.Forms.GroupBox();
            this.plC_RJ_Button_系統更新 = new MyUI.PLC_RJ_Button();
            this.ftp_DounloadUI = new MyFtpUI.Ftp_DounloadUI();
            this.rJ_GroupBox7 = new MyUI.RJ_GroupBox();
            this.plC_RJ_Button_後台登入_登入 = new MyUI.PLC_RJ_Button();
            this.panel185 = new System.Windows.Forms.Panel();
            this.textBox_後台登入_帳號 = new System.Windows.Forms.TextBox();
            this.panel186 = new System.Windows.Forms.Panel();
            this.panel183 = new System.Windows.Forms.Panel();
            this.textBox_後台登入_密碼 = new System.Windows.Forms.TextBox();
            this.panel184 = new System.Windows.Forms.Panel();
            this.rJ_Lable5 = new MyUI.RJ_Lable();
            this.入庫作業 = new System.Windows.Forms.TabPage();
            this.交易記錄查詢 = new System.Windows.Forms.TabPage();
            this.plC_RJ_Button_交易記錄查詢_刪除 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_交易記錄查詢_顯示全部 = new MyUI.PLC_RJ_Button();
            this.rJ_GroupBox23 = new MyUI.RJ_GroupBox();
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間 = new MyUI.PLC_RJ_ChechBox();
            this.rJ_Lable44 = new MyUI.RJ_Lable();
            this.dateTimePicker_交易記錄查詢_開方時間_結束 = new MyUI.RJ_DatePicker();
            this.label117 = new System.Windows.Forms.Label();
            this.dateTimePicker_交易記錄查詢_開方時間_起始 = new MyUI.RJ_DatePicker();
            this.rJ_Lable30 = new MyUI.RJ_Lable();
            this.dateTimePicker_交易記錄查詢_操作時間_結束 = new MyUI.RJ_DatePicker();
            this.label106 = new System.Windows.Forms.Label();
            this.dateTimePicker_交易記錄查詢_操作時間_起始 = new MyUI.RJ_DatePicker();
            this.rJ_GroupBox19 = new MyUI.RJ_GroupBox();
            this.textBox_交易記錄查詢_操作人 = new MyUI.RJ_TextBox();
            this.rJ_Lable41 = new MyUI.RJ_Lable();
            this.textBox_交易記錄查詢_病人姓名 = new MyUI.RJ_TextBox();
            this.textBox_交易記錄查詢_病歷號 = new MyUI.RJ_TextBox();
            this.rJ_Lable42 = new MyUI.RJ_Lable();
            this.rJ_Lable43 = new MyUI.RJ_Lable();
            this.rJ_GroupBox18 = new MyUI.RJ_GroupBox();
            this.textBox_交易記錄查詢_藥品碼 = new MyUI.RJ_TextBox();
            this.rJ_Lable26 = new MyUI.RJ_Lable();
            this.textBox_交易記錄查詢_藥品名稱 = new MyUI.RJ_TextBox();
            this.textBox_交易記錄查詢_藥袋序號 = new MyUI.RJ_TextBox();
            this.textBox_交易記錄查詢_藥品條碼 = new MyUI.RJ_TextBox();
            this.rJ_Lable27 = new MyUI.RJ_Lable();
            this.rJ_Lable28 = new MyUI.RJ_Lable();
            this.rJ_Lable29 = new MyUI.RJ_Lable();
            this.rJ_GroupBox6 = new MyUI.RJ_GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳 = new MyUI.PLC_RJ_ChechBox();
            this.label123 = new System.Windows.Forms.Label();
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥 = new MyUI.PLC_RJ_ChechBox();
            this.label119 = new System.Windows.Forms.Label();
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出 = new MyUI.PLC_RJ_ChechBox();
            this.label115 = new System.Windows.Forms.Label();
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作 = new MyUI.PLC_RJ_ChechBox();
            this.label114 = new System.Windows.Forms.Label();
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動 = new MyUI.PLC_RJ_ChechBox();
            this.label113 = new System.Windows.Forms.Label();
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫 = new MyUI.PLC_RJ_ChechBox();
            this.label112 = new System.Windows.Forms.Label();
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥 = new MyUI.PLC_RJ_ChechBox();
            this.sqL_DataGridView_交易記錄查詢 = new SQLUI.SQL_DataGridView();
            this.醫囑資料 = new System.Windows.Forms.TabPage();
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼 = new MyUI.RJ_TextBox();
            this.plC_RJ_Button_醫囑資料_設為未過帳 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_醫囑資料_設定產出時間 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_醫囑資料_自動過帳 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋 = new MyUI.PLC_RJ_Button();
            this.rJ_Lable119 = new MyUI.RJ_Lable();
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼 = new MyUI.RJ_TextBox();
            this.rJ_Lable115 = new MyUI.RJ_Lable();
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號 = new MyUI.RJ_TextBox();
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱 = new MyUI.RJ_TextBox();
            this.rJ_Lable114 = new MyUI.RJ_Lable();
            this.rJ_Lable116 = new MyUI.RJ_Lable();
            this.dateTimePicke_醫囑資料_開方日期_起始 = new MyUI.RJ_DatePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicke_醫囑資料_開方日期_結束 = new MyUI.RJ_DatePicker();
            this.rJ_Lable111 = new MyUI.RJ_Lable();
            this.plC_RJ_Button_醫囑資料_顯示全部 = new MyUI.PLC_RJ_Button();
            this.sqL_DataGridView_醫囑資料 = new SQLUI.SQL_DataGridView();
            this.藥品資料 = new System.Windows.Forms.TabPage();
            this.plC_ScreenPage_藥品資料 = new MyUI.PLC_ScreenPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.plC_RJ_GroupBox2 = new MyUI.PLC_RJ_GroupBox();
            this.sqL_DataGridView_藥品群組 = new SQLUI.SQL_DataGridView();
            this.plC_RJ_Button_藥品群組_登錄 = new MyUI.PLC_RJ_Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rJ_Lable1 = new MyUI.RJ_Lable();
            this.rJ_TextBox_藥品群組_群組序號 = new MyUI.RJ_TextBox();
            this.panel144 = new System.Windows.Forms.Panel();
            this.rJ_Lable2 = new MyUI.RJ_Lable();
            this.rJ_TextBox_藥品群組_群組名稱 = new MyUI.RJ_TextBox();
            this.rJ_GroupBox13 = new MyUI.RJ_GroupBox();
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_藥品資料_匯出 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_藥品資料_匯入 = new MyUI.PLC_RJ_Button();
            this.rJ_Pannel5 = new MyUI.RJ_Pannel();
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼 = new MyUI.RJ_TextBox();
            this.rJ_Lable20 = new MyUI.RJ_Lable();
            this.rJ_Pannel4 = new MyUI.RJ_Pannel();
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組 = new MyUI.PLC_RJ_ChechBox();
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組 = new MyUI.RJ_ComboBox();
            this.rJ_Lable19 = new MyUI.RJ_Lable();
            this.rJ_Pannel3 = new MyUI.RJ_Pannel();
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱 = new MyUI.RJ_TextBox();
            this.rJ_Lable18 = new MyUI.RJ_Lable();
            this.rJ_Pannel2 = new MyUI.RJ_Pannel();
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼 = new MyUI.RJ_TextBox();
            this.rJ_Lable17 = new MyUI.RJ_Lable();
            this.rJ_GroupBox12 = new MyUI.RJ_GroupBox();
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_藥品資料_HIS填入 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_藥品資料_刪除 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_藥品資料_更新藥櫃資料 = new MyUI.PLC_RJ_Button();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel71 = new System.Windows.Forms.Panel();
            this.comboBox_藥品資料_藥檔資料_警訊藥品 = new MyUI.RJ_ComboBox();
            this.panel72 = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            this.panel69 = new System.Windows.Forms.Panel();
            this.textBox_藥品資料_藥檔資料_安全庫存 = new MyUI.RJ_TextBox();
            this.panel70 = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.panel64 = new System.Windows.Forms.Panel();
            this.textBox_藥品資料_藥檔資料_庫存 = new MyUI.RJ_TextBox();
            this.panel65 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panel67 = new System.Windows.Forms.Panel();
            this.textBox_藥品資料_藥檔資料_包裝單位 = new MyUI.RJ_TextBox();
            this.panel68 = new System.Windows.Forms.Panel();
            this.label23 = new System.Windows.Forms.Label();
            this.panel60 = new System.Windows.Forms.Panel();
            this.textBox_藥品資料_藥檔資料_藥品條碼 = new MyUI.RJ_TextBox();
            this.panel63 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.panel58 = new System.Windows.Forms.Panel();
            this.textBox_藥品資料_藥檔資料_健保碼 = new MyUI.RJ_TextBox();
            this.panel59 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.panel56 = new System.Windows.Forms.Panel();
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組 = new MyUI.RJ_ComboBox();
            this.panel57 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel54 = new System.Windows.Forms.Panel();
            this.textBox_藥品資料_藥檔資料_藥品中文名稱 = new MyUI.RJ_TextBox();
            this.panel55 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel52 = new System.Windows.Forms.Panel();
            this.textBox_藥品資料_藥檔資料_藥品學名 = new MyUI.RJ_TextBox();
            this.panel53 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel50 = new System.Windows.Forms.Panel();
            this.textBox_藥品資料_藥檔資料_藥品名稱 = new MyUI.RJ_TextBox();
            this.panel51 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.textBox_藥品資料_藥檔資料_藥品碼 = new MyUI.RJ_TextBox();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label21 = new System.Windows.Forms.Label();
            this.plC_RJ_Button_藥品資料_登錄 = new MyUI.PLC_RJ_Button();
            this.sqL_DataGridView_藥品資料_藥檔資料 = new SQLUI.SQL_DataGridView();
            this.panel_藥品資料 = new System.Windows.Forms.Panel();
            this.plC_RJ_ScreenButton8 = new MyUI.PLC_RJ_ScreenButton();
            this.人員資料 = new System.Windows.Forms.TabPage();
            this.plC_ScreenPage_人員資料 = new MyUI.PLC_ScreenPage();
            this.資料維護 = new System.Windows.Forms.TabPage();
            this.plC_RJ_Button_人員資料_清除內容 = new MyUI.PLC_RJ_Button();
            this.rJ_GroupBox15 = new MyUI.RJ_GroupBox();
            this.rJ_TextBox_人員資料_識別圖案 = new MyUI.RJ_TextBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.rJ_TextBox_人員資料_一維條碼 = new MyUI.RJ_TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rJ_TextBox_人員資料_卡號 = new MyUI.RJ_TextBox();
            this.comboBox_人員資料_權限等級 = new MyUI.RJ_ComboBox();
            this.rJ_TextBox_人員資料_單位 = new MyUI.RJ_TextBox();
            this.rJ_TextBox_人員資料_密碼 = new MyUI.RJ_TextBox();
            this.rJ_TextBox_人員資料_姓名 = new MyUI.RJ_TextBox();
            this.rJ_TextBox_人員資料_ID = new MyUI.RJ_TextBox();
            this.label49 = new System.Windows.Forms.Label();
            this.label144 = new System.Windows.Forms.Label();
            this.label108 = new System.Windows.Forms.Label();
            this.label138 = new System.Windows.Forms.Label();
            this.label143 = new System.Windows.Forms.Label();
            this.label102 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel149 = new System.Windows.Forms.Panel();
            this.panel150 = new System.Windows.Forms.Panel();
            this.button_人員資料_顏色選擇 = new System.Windows.Forms.Button();
            this.textBox_人員資料_顏色 = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.rJ_RatioButton_人員資料_男 = new MyUI.RJ_RatioButton();
            this.rJ_RatioButton_人員資料_女 = new MyUI.RJ_RatioButton();
            this.sqL_DataGridView_人員資料 = new SQLUI.SQL_DataGridView();
            this.plC_RJ_Button_人員資料_刪除 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_人員資料_匯出 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_人員資料_登錄 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_人員資料_匯入 = new MyUI.PLC_RJ_Button();
            this.權限管理 = new System.Windows.Forms.TabPage();
            this.rJ_GroupBox16 = new MyUI.RJ_GroupBox();
            this.loginIndex_Pannel = new MySQL_Login.LoginIndex_Pannel();
            this.plC_Button_權限設定_設定至Server = new MyUI.PLC_RJ_Button();
            this.plC_RJ_ComboBox_權限管理_權限等級 = new MyUI.PLC_RJ_ComboBox();
            this.rJ_Lable23 = new MyUI.RJ_Lable();
            this.panel_人員資料 = new System.Windows.Forms.Panel();
            this.plC_RJ_ScreenButton11 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton12 = new MyUI.PLC_RJ_ScreenButton();
            this.儲位管理 = new System.Windows.Forms.TabPage();
            this.rJ_GroupBox1 = new MyUI.RJ_GroupBox();
            this.plC_Button143 = new MyUI.PLC_Button();
            this.plC_RJ_Button_儲位設定_出料一次 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_儲位設定_滅燈 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_儲位設定_亮燈 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_儲位設定_亮燈範圍填入 = new MyUI.PLC_RJ_Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rJ_RatioButton_儲位管理_第一層 = new MyUI.RJ_RatioButton();
            this.rJ_RatioButton_儲位管理_第二層 = new MyUI.RJ_RatioButton();
            this.rJ_RatioButton_儲位管理_第三層 = new MyUI.RJ_RatioButton();
            this.rJ_RatioButton_儲位管理_第四層 = new MyUI.RJ_RatioButton();
            this.rJ_RatioButton_儲位管理_第五層 = new MyUI.RJ_RatioButton();
            this.rowsLED_Pannel_儲位管理_儲位號碼 = new H_Pannel_lib.RowsLED_Pannel();
            this.plC_NumBox_儲位管理_起始號碼 = new MyUI.PLC_NumBox();
            this.rJ_Lable4 = new MyUI.RJ_Lable();
            this.rJ_Lable3 = new MyUI.RJ_Lable();
            this.plC_NumBox_儲位管理_結束號碼 = new MyUI.PLC_NumBox();
            this.panel20 = new System.Windows.Forms.Panel();
            this.rJ_GroupBox3 = new MyUI.RJ_GroupBox();
            this.plC_RJ_GroupBox13 = new MyUI.PLC_RJ_GroupBox();
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期 = new MyUI.PLC_RJ_Button();
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存 = new SQLUI.SQL_DataGridView();
            this.plC_RJ_Button_儲位管理_儲位資訊_更新 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位 = new MyUI.PLC_RJ_Button();
            this.sqL_DataGridView_儲位管理_儲位資訊 = new SQLUI.SQL_DataGridView();
            this.rJ_GroupBox2 = new MyUI.RJ_GroupBox();
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位 = new MyUI.PLC_RJ_Button();
            this.rJ_Pannel7 = new MyUI.RJ_Pannel();
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋 = new MyUI.PLC_RJ_Button();
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱 = new MyUI.RJ_TextBox();
            this.rJ_Lable8 = new MyUI.RJ_Lable();
            this.rJ_Pannel6 = new MyUI.RJ_Pannel();
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋 = new MyUI.PLC_RJ_Button();
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱 = new MyUI.RJ_TextBox();
            this.rJ_Lable7 = new MyUI.RJ_Lable();
            this.rJ_Pannel1 = new MyUI.RJ_Pannel();
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋 = new MyUI.PLC_RJ_Button();
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼 = new MyUI.RJ_TextBox();
            this.rJ_Lable6 = new MyUI.RJ_Lable();
            this.sqL_DataGridView_儲位管理_藥品資料 = new SQLUI.SQL_DataGridView();
            this.工程模式 = new System.Windows.Forms.TabPage();
            this.plC_Button_下門鎖 = new MyUI.PLC_Button();
            this.plC_Button_上門鎖 = new MyUI.PLC_Button();
            this.plC_Button_取藥門關 = new MyUI.PLC_Button();
            this.plC_Button_取藥門開 = new MyUI.PLC_Button();
            this.plC_Button_重複領藥不檢查 = new MyUI.PLC_Button();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.label118 = new System.Windows.Forms.Label();
            this.plC_NumBox6 = new MyUI.PLC_NumBox();
            this.plC_Button142 = new MyUI.PLC_Button();
            this.plC_Button_LED全亮 = new MyUI.PLC_Button();
            this.rowsLED_Pannel_工程模式 = new H_Pannel_lib.RowsLED_Pannel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.plC_Button127 = new MyUI.PLC_Button();
            this.plC_Button128 = new MyUI.PLC_Button();
            this.plC_Button129 = new MyUI.PLC_Button();
            this.plC_Button130 = new MyUI.PLC_Button();
            this.plC_Button131 = new MyUI.PLC_Button();
            this.plC_Button132 = new MyUI.PLC_Button();
            this.plC_Button133 = new MyUI.PLC_Button();
            this.plC_Button134 = new MyUI.PLC_Button();
            this.plC_Button135 = new MyUI.PLC_Button();
            this.plC_Button136 = new MyUI.PLC_Button();
            this.plC_Button137 = new MyUI.PLC_Button();
            this.plC_Button138 = new MyUI.PLC_Button();
            this.plC_Button139 = new MyUI.PLC_Button();
            this.plC_Button140 = new MyUI.PLC_Button();
            this.panel14 = new System.Windows.Forms.Panel();
            this.plC_Button113 = new MyUI.PLC_Button();
            this.plC_Button114 = new MyUI.PLC_Button();
            this.plC_Button115 = new MyUI.PLC_Button();
            this.plC_Button116 = new MyUI.PLC_Button();
            this.plC_Button117 = new MyUI.PLC_Button();
            this.plC_Button118 = new MyUI.PLC_Button();
            this.plC_Button119 = new MyUI.PLC_Button();
            this.plC_Button120 = new MyUI.PLC_Button();
            this.plC_Button121 = new MyUI.PLC_Button();
            this.plC_Button122 = new MyUI.PLC_Button();
            this.plC_Button123 = new MyUI.PLC_Button();
            this.plC_Button124 = new MyUI.PLC_Button();
            this.plC_Button125 = new MyUI.PLC_Button();
            this.plC_Button126 = new MyUI.PLC_Button();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.plC_Button99 = new MyUI.PLC_Button();
            this.plC_Button100 = new MyUI.PLC_Button();
            this.plC_Button101 = new MyUI.PLC_Button();
            this.plC_Button102 = new MyUI.PLC_Button();
            this.plC_Button103 = new MyUI.PLC_Button();
            this.plC_Button104 = new MyUI.PLC_Button();
            this.plC_Button105 = new MyUI.PLC_Button();
            this.plC_Button106 = new MyUI.PLC_Button();
            this.plC_Button107 = new MyUI.PLC_Button();
            this.plC_Button108 = new MyUI.PLC_Button();
            this.plC_Button109 = new MyUI.PLC_Button();
            this.plC_Button110 = new MyUI.PLC_Button();
            this.plC_Button111 = new MyUI.PLC_Button();
            this.plC_Button112 = new MyUI.PLC_Button();
            this.panel11 = new System.Windows.Forms.Panel();
            this.plC_Button85 = new MyUI.PLC_Button();
            this.plC_Button86 = new MyUI.PLC_Button();
            this.plC_Button87 = new MyUI.PLC_Button();
            this.plC_Button88 = new MyUI.PLC_Button();
            this.plC_Button89 = new MyUI.PLC_Button();
            this.plC_Button90 = new MyUI.PLC_Button();
            this.plC_Button91 = new MyUI.PLC_Button();
            this.plC_Button92 = new MyUI.PLC_Button();
            this.plC_Button93 = new MyUI.PLC_Button();
            this.plC_Button94 = new MyUI.PLC_Button();
            this.plC_Button95 = new MyUI.PLC_Button();
            this.plC_Button96 = new MyUI.PLC_Button();
            this.plC_Button97 = new MyUI.PLC_Button();
            this.plC_Button98 = new MyUI.PLC_Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.plC_Button71 = new MyUI.PLC_Button();
            this.plC_Button72 = new MyUI.PLC_Button();
            this.plC_Button73 = new MyUI.PLC_Button();
            this.plC_Button74 = new MyUI.PLC_Button();
            this.plC_Button75 = new MyUI.PLC_Button();
            this.plC_Button76 = new MyUI.PLC_Button();
            this.plC_Button77 = new MyUI.PLC_Button();
            this.plC_Button78 = new MyUI.PLC_Button();
            this.plC_Button79 = new MyUI.PLC_Button();
            this.plC_Button80 = new MyUI.PLC_Button();
            this.plC_Button81 = new MyUI.PLC_Button();
            this.plC_Button82 = new MyUI.PLC_Button();
            this.plC_Button83 = new MyUI.PLC_Button();
            this.plC_Button84 = new MyUI.PLC_Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.plC_Button57 = new MyUI.PLC_Button();
            this.plC_Button58 = new MyUI.PLC_Button();
            this.plC_Button59 = new MyUI.PLC_Button();
            this.plC_Button60 = new MyUI.PLC_Button();
            this.plC_Button61 = new MyUI.PLC_Button();
            this.plC_Button62 = new MyUI.PLC_Button();
            this.plC_Button63 = new MyUI.PLC_Button();
            this.plC_Button64 = new MyUI.PLC_Button();
            this.plC_Button65 = new MyUI.PLC_Button();
            this.plC_Button66 = new MyUI.PLC_Button();
            this.plC_Button67 = new MyUI.PLC_Button();
            this.plC_Button68 = new MyUI.PLC_Button();
            this.plC_Button69 = new MyUI.PLC_Button();
            this.plC_Button70 = new MyUI.PLC_Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.plC_Button43 = new MyUI.PLC_Button();
            this.plC_Button44 = new MyUI.PLC_Button();
            this.plC_Button45 = new MyUI.PLC_Button();
            this.plC_Button46 = new MyUI.PLC_Button();
            this.plC_Button47 = new MyUI.PLC_Button();
            this.plC_Button48 = new MyUI.PLC_Button();
            this.plC_Button49 = new MyUI.PLC_Button();
            this.plC_Button50 = new MyUI.PLC_Button();
            this.plC_Button51 = new MyUI.PLC_Button();
            this.plC_Button52 = new MyUI.PLC_Button();
            this.plC_Button53 = new MyUI.PLC_Button();
            this.plC_Button54 = new MyUI.PLC_Button();
            this.plC_Button55 = new MyUI.PLC_Button();
            this.plC_Button56 = new MyUI.PLC_Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.plC_Button29 = new MyUI.PLC_Button();
            this.plC_Button30 = new MyUI.PLC_Button();
            this.plC_Button31 = new MyUI.PLC_Button();
            this.plC_Button32 = new MyUI.PLC_Button();
            this.plC_Button33 = new MyUI.PLC_Button();
            this.plC_Button34 = new MyUI.PLC_Button();
            this.plC_Button35 = new MyUI.PLC_Button();
            this.plC_Button36 = new MyUI.PLC_Button();
            this.plC_Button37 = new MyUI.PLC_Button();
            this.plC_Button38 = new MyUI.PLC_Button();
            this.plC_Button39 = new MyUI.PLC_Button();
            this.plC_Button40 = new MyUI.PLC_Button();
            this.plC_Button41 = new MyUI.PLC_Button();
            this.plC_Button42 = new MyUI.PLC_Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.plC_Button27 = new MyUI.PLC_Button();
            this.plC_Button25 = new MyUI.PLC_Button();
            this.plC_Button23 = new MyUI.PLC_Button();
            this.plC_Button13 = new MyUI.PLC_Button();
            this.plC_Button15 = new MyUI.PLC_Button();
            this.plC_Button17 = new MyUI.PLC_Button();
            this.plC_Button19 = new MyUI.PLC_Button();
            this.plC_Button21 = new MyUI.PLC_Button();
            this.plC_Button11 = new MyUI.PLC_Button();
            this.plC_Button9 = new MyUI.PLC_Button();
            this.plC_Button7 = new MyUI.PLC_Button();
            this.plC_Button5 = new MyUI.PLC_Button();
            this.plC_Button3 = new MyUI.PLC_Button();
            this.plC_Button2 = new MyUI.PLC_Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.plC_Button28 = new MyUI.PLC_Button();
            this.plC_Button26 = new MyUI.PLC_Button();
            this.plC_Button24 = new MyUI.PLC_Button();
            this.plC_Button14 = new MyUI.PLC_Button();
            this.plC_Button16 = new MyUI.PLC_Button();
            this.plC_Button18 = new MyUI.PLC_Button();
            this.plC_Button20 = new MyUI.PLC_Button();
            this.plC_Button22 = new MyUI.PLC_Button();
            this.plC_Button12 = new MyUI.PLC_Button();
            this.plC_Button10 = new MyUI.PLC_Button();
            this.plC_Button8 = new MyUI.PLC_Button();
            this.plC_Button6 = new MyUI.PLC_Button();
            this.plC_Button4 = new MyUI.PLC_Button();
            this.plC_Button1 = new MyUI.PLC_Button();
            this.plC_RJ_ScreenButton9 = new MyUI.PLC_RJ_ScreenButton();
            this.系統 = new System.Windows.Forms.TabPage();
            this.plC_ScreenPage_系統 = new MyUI.PLC_ScreenPage();
            this.設定01 = new System.Windows.Forms.TabPage();
            this.groupBox22 = new System.Windows.Forms.GroupBox();
            this.textBox_工程模式_設備名稱_名稱 = new System.Windows.Forms.TextBox();
            this.rJ_Lable45 = new MyUI.RJ_Lable();
            this.button_工程模式_調劑台名稱儲存 = new System.Windows.Forms.Button();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.rfiD_FX600_UI = new RFID_FX600lib.RFID_FX600_UI();
            this.plC_UI_Init = new MyUI.PLC_UI_Init();
            this.lowerMachine_Panel = new LadderUI.LowerMachine_Panel();
            this.設定02 = new System.Windows.Forms.TabPage();
            this.loginUI = new MySQL_Login.LoginUI();
            this.設定03 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.ioC12801 = new LeadShineUI.IOC1280();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.c12301 = new SLDUI.C1230();
            this.設定04 = new System.Windows.Forms.TabPage();
            this.rowsLEDUI = new H_Pannel_lib.RowsLEDUI();
            this.設定05 = new System.Windows.Forms.TabPage();
            this.groupBox27 = new System.Windows.Forms.GroupBox();
            this.sqL_DataGridView_取藥堆疊子資料 = new SQLUI.SQL_DataGridView();
            this.groupBox44 = new System.Windows.Forms.GroupBox();
            this.sqL_DataGridView_取藥堆疊母資料 = new SQLUI.SQL_DataGridView();
            this.設定06 = new System.Windows.Forms.TabPage();
            this.plC_RJ_GroupBox1 = new MyUI.PLC_RJ_GroupBox();
            this.plC_RJ_Button_雲端藥檔_取得資料 = new MyUI.PLC_RJ_Button();
            this.sqL_DataGridView_雲端藥檔 = new SQLUI.SQL_DataGridView();
            this.panel_系統 = new System.Windows.Forms.Panel();
            this.plC_RJ_ScreenButton6 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton5 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton4 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton1 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton2 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton3 = new MyUI.PLC_RJ_ScreenButton();
            this.panel_Main = new System.Windows.Forms.Panel();
            this.plC_RJ_ScreenButton_工程模式 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton_儲位管理 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton_人員資料 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton_醫囑資料 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton_交易紀錄查詢 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton_入庫作業 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton_後台登入 = new MyUI.PLC_RJ_ScreenButton();
            this.plC_RJ_ScreenButton_領藥作業 = new MyUI.PLC_RJ_ScreenButton();
            this.panel232 = new System.Windows.Forms.Panel();
            this.rJ_TextBox_登入者顏色 = new MyUI.RJ_TextBox();
            this.rJ_TextBox_登入者姓名 = new MyUI.RJ_TextBox();
            this.rJ_TextBox_登入者ID = new MyUI.RJ_TextBox();
            this.rJ_Lable51 = new MyUI.RJ_Lable();
            this.rJ_Lable52 = new MyUI.RJ_Lable();
            this.plC_RJ_Button_後台登入_登出 = new MyUI.PLC_RJ_Button();
            this.plC_RJ_ScreenButton143 = new MyUI.PLC_RJ_ScreenButton();
            this.saveFileDialog_SaveExcel = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_LoadExcel = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.plC_AlarmFlow1 = new MyUI.PLC_AlarmFlow();
            this.plC_ScreenPage_Main.SuspendLayout();
            this.領藥作業.SuspendLayout();
            this.rJ_GroupBox4.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_領藥台_01_藥品圖片)).BeginInit();
            this.rJ_GroupBox_領藥台_01.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox_領藥台_01.SuspendLayout();
            this.rJ_GroupBox5.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox5.SuspendLayout();
            this.後台登入.SuspendLayout();
            this.groupBox26.SuspendLayout();
            this.rJ_GroupBox7.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox7.SuspendLayout();
            this.panel185.SuspendLayout();
            this.panel183.SuspendLayout();
            this.交易記錄查詢.SuspendLayout();
            this.rJ_GroupBox23.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox23.SuspendLayout();
            this.rJ_GroupBox19.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox19.SuspendLayout();
            this.rJ_GroupBox18.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox18.SuspendLayout();
            this.rJ_GroupBox6.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox6.SuspendLayout();
            this.醫囑資料.SuspendLayout();
            this.藥品資料.SuspendLayout();
            this.plC_ScreenPage_藥品資料.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.plC_RJ_GroupBox2.ContentsPanel.SuspendLayout();
            this.plC_RJ_GroupBox2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel144.SuspendLayout();
            this.rJ_GroupBox13.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox13.SuspendLayout();
            this.rJ_Pannel5.SuspendLayout();
            this.rJ_Pannel4.SuspendLayout();
            this.rJ_Pannel3.SuspendLayout();
            this.rJ_Pannel2.SuspendLayout();
            this.rJ_GroupBox12.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox12.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel71.SuspendLayout();
            this.panel69.SuspendLayout();
            this.panel64.SuspendLayout();
            this.panel67.SuspendLayout();
            this.panel60.SuspendLayout();
            this.panel58.SuspendLayout();
            this.panel56.SuspendLayout();
            this.panel54.SuspendLayout();
            this.panel52.SuspendLayout();
            this.panel50.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel_藥品資料.SuspendLayout();
            this.人員資料.SuspendLayout();
            this.plC_ScreenPage_人員資料.SuspendLayout();
            this.資料維護.SuspendLayout();
            this.rJ_GroupBox15.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox15.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel149.SuspendLayout();
            this.panel150.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.權限管理.SuspendLayout();
            this.rJ_GroupBox16.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox16.SuspendLayout();
            this.panel_人員資料.SuspendLayout();
            this.儲位管理.SuspendLayout();
            this.rJ_GroupBox1.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel20.SuspendLayout();
            this.rJ_GroupBox3.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox3.SuspendLayout();
            this.plC_RJ_GroupBox13.ContentsPanel.SuspendLayout();
            this.plC_RJ_GroupBox13.SuspendLayout();
            this.rJ_GroupBox2.ContentsPanel.SuspendLayout();
            this.rJ_GroupBox2.SuspendLayout();
            this.rJ_Pannel7.SuspendLayout();
            this.rJ_Pannel6.SuspendLayout();
            this.rJ_Pannel1.SuspendLayout();
            this.工程模式.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.系統.SuspendLayout();
            this.plC_ScreenPage_系統.SuspendLayout();
            this.設定01.SuspendLayout();
            this.groupBox22.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.設定02.SuspendLayout();
            this.設定03.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.設定04.SuspendLayout();
            this.設定05.SuspendLayout();
            this.groupBox27.SuspendLayout();
            this.groupBox44.SuspendLayout();
            this.設定06.SuspendLayout();
            this.plC_RJ_GroupBox1.ContentsPanel.SuspendLayout();
            this.plC_RJ_GroupBox1.SuspendLayout();
            this.panel_系統.SuspendLayout();
            this.panel_Main.SuspendLayout();
            this.panel232.SuspendLayout();
            this.SuspendLayout();
            // 
            // plC_ScreenPage_Main
            // 
            this.plC_ScreenPage_Main.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.plC_ScreenPage_Main.BackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_Main.Controls.Add(this.領藥作業);
            this.plC_ScreenPage_Main.Controls.Add(this.後台登入);
            this.plC_ScreenPage_Main.Controls.Add(this.入庫作業);
            this.plC_ScreenPage_Main.Controls.Add(this.交易記錄查詢);
            this.plC_ScreenPage_Main.Controls.Add(this.醫囑資料);
            this.plC_ScreenPage_Main.Controls.Add(this.藥品資料);
            this.plC_ScreenPage_Main.Controls.Add(this.人員資料);
            this.plC_ScreenPage_Main.Controls.Add(this.儲位管理);
            this.plC_ScreenPage_Main.Controls.Add(this.工程模式);
            this.plC_ScreenPage_Main.Controls.Add(this.系統);
            this.plC_ScreenPage_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plC_ScreenPage_Main.ForekColor = System.Drawing.Color.Black;
            this.plC_ScreenPage_Main.ItemSize = new System.Drawing.Size(54, 21);
            this.plC_ScreenPage_Main.Location = new System.Drawing.Point(258, 0);
            this.plC_ScreenPage_Main.Name = "plC_ScreenPage_Main";
            this.plC_ScreenPage_Main.SelectedIndex = 0;
            this.plC_ScreenPage_Main.Size = new System.Drawing.Size(1646, 1015);
            this.plC_ScreenPage_Main.TabBackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_Main.TabIndex = 0;
            this.plC_ScreenPage_Main.顯示標籤列 = MyUI.PLC_ScreenPage.TabVisibleEnum.顯示;
            this.plC_ScreenPage_Main.顯示頁面 = 0;
            // 
            // 領藥作業
            // 
            this.領藥作業.BackColor = System.Drawing.Color.White;
            this.領藥作業.Controls.Add(this.rJ_GroupBox4);
            this.領藥作業.Controls.Add(this.plC_RJ_Button_藥物辨識圖片測試);
            this.領藥作業.Controls.Add(this.plC_RJ_Button_掃碼測試);
            this.領藥作業.Controls.Add(this.rJ_GroupBox_領藥台_01);
            this.領藥作業.Location = new System.Drawing.Point(4, 25);
            this.領藥作業.Name = "領藥作業";
            this.領藥作業.Size = new System.Drawing.Size(1638, 986);
            this.領藥作業.TabIndex = 0;
            this.領藥作業.Text = "領藥作業";
            // 
            // rJ_GroupBox4
            // 
            // 
            // rJ_GroupBox4.ContentsPanel
            // 
            this.rJ_GroupBox4.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox4.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox4.ContentsPanel.BorderRadius = 5;
            this.rJ_GroupBox4.ContentsPanel.BorderSize = 0;
            this.rJ_GroupBox4.ContentsPanel.Controls.Add(this.pictureBox_領藥台_01_藥品圖片);
            this.rJ_GroupBox4.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox4.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox4.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox4.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox4.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox4.ContentsPanel.Size = new System.Drawing.Size(812, 689);
            this.rJ_GroupBox4.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.rJ_GroupBox4.Location = new System.Drawing.Point(826, 0);
            this.rJ_GroupBox4.Name = "rJ_GroupBox4";
            this.rJ_GroupBox4.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox4.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox4.PannelBorderRadius = 5;
            this.rJ_GroupBox4.PannelBorderSize = 0;
            this.rJ_GroupBox4.Size = new System.Drawing.Size(812, 726);
            this.rJ_GroupBox4.TabIndex = 124;
            this.rJ_GroupBox4.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox4.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox4.TitleBorderRadius = 5;
            this.rJ_GroupBox4.TitleBorderSize = 0;
            this.rJ_GroupBox4.TitleFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_GroupBox4.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox4.TitleHeight = 37;
            this.rJ_GroupBox4.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox4.TitleTexts = "藥物辨識圖片";
            // 
            // pictureBox_領藥台_01_藥品圖片
            // 
            this.pictureBox_領藥台_01_藥品圖片.BackColor = System.Drawing.Color.LightBlue;
            this.pictureBox_領藥台_01_藥品圖片.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox_領藥台_01_藥品圖片.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_領藥台_01_藥品圖片.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_領藥台_01_藥品圖片.Name = "pictureBox_領藥台_01_藥品圖片";
            this.pictureBox_領藥台_01_藥品圖片.Size = new System.Drawing.Size(812, 689);
            this.pictureBox_領藥台_01_藥品圖片.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_領藥台_01_藥品圖片.TabIndex = 0;
            this.pictureBox_領藥台_01_藥品圖片.TabStop = false;
            // 
            // plC_RJ_Button_藥物辨識圖片測試
            // 
            this.plC_RJ_Button_藥物辨識圖片測試.AutoResetState = true;
            this.plC_RJ_Button_藥物辨識圖片測試.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_藥物辨識圖片測試.Bool = false;
            this.plC_RJ_Button_藥物辨識圖片測試.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥物辨識圖片測試.BorderRadius = 10;
            this.plC_RJ_Button_藥物辨識圖片測試.BorderSize = 0;
            this.plC_RJ_Button_藥物辨識圖片測試.but_press = false;
            this.plC_RJ_Button_藥物辨識圖片測試.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_藥物辨識圖片測試.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_藥物辨識圖片測試.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_藥物辨識圖片測試.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_藥物辨識圖片測試.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_藥物辨識圖片測試.Location = new System.Drawing.Point(832, 886);
            this.plC_RJ_Button_藥物辨識圖片測試.Name = "plC_RJ_Button_藥物辨識圖片測試";
            this.plC_RJ_Button_藥物辨識圖片測試.OFF_文字內容 = "藥物辨識\n圖片測試";
            this.plC_RJ_Button_藥物辨識圖片測試.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_藥物辨識圖片測試.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_藥物辨識圖片測試.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥物辨識圖片測試.ON_BorderSize = 5;
            this.plC_RJ_Button_藥物辨識圖片測試.ON_文字內容 = "藥物辨識\n圖片測試";
            this.plC_RJ_Button_藥物辨識圖片測試.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_藥物辨識圖片測試.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_藥物辨識圖片測試.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥物辨識圖片測試.Size = new System.Drawing.Size(152, 69);
            this.plC_RJ_Button_藥物辨識圖片測試.State = false;
            this.plC_RJ_Button_藥物辨識圖片測試.TabIndex = 123;
            this.plC_RJ_Button_藥物辨識圖片測試.Text = "藥物辨識\n圖片測試";
            this.plC_RJ_Button_藥物辨識圖片測試.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_藥物辨識圖片測試.Texts = "藥物辨識\n圖片測試";
            this.plC_RJ_Button_藥物辨識圖片測試.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_藥物辨識圖片測試.Visible = false;
            this.plC_RJ_Button_藥物辨識圖片測試.字型鎖住 = false;
            this.plC_RJ_Button_藥物辨識圖片測試.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_藥物辨識圖片測試.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_藥物辨識圖片測試.文字鎖住 = false;
            this.plC_RJ_Button_藥物辨識圖片測試.致能讀取位置 = "S4077";
            this.plC_RJ_Button_藥物辨識圖片測試.讀取位元反向 = false;
            this.plC_RJ_Button_藥物辨識圖片測試.讀寫鎖住 = false;
            this.plC_RJ_Button_藥物辨識圖片測試.音效 = true;
            this.plC_RJ_Button_藥物辨識圖片測試.顯示 = false;
            this.plC_RJ_Button_藥物辨識圖片測試.顯示狀態 = false;
            this.plC_RJ_Button_藥物辨識圖片測試.顯示讀取位置 = "S4077";
            // 
            // plC_RJ_Button_掃碼測試
            // 
            this.plC_RJ_Button_掃碼測試.AutoResetState = true;
            this.plC_RJ_Button_掃碼測試.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_掃碼測試.Bool = false;
            this.plC_RJ_Button_掃碼測試.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_掃碼測試.BorderRadius = 10;
            this.plC_RJ_Button_掃碼測試.BorderSize = 0;
            this.plC_RJ_Button_掃碼測試.but_press = false;
            this.plC_RJ_Button_掃碼測試.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_掃碼測試.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_掃碼測試.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_掃碼測試.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_掃碼測試.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_掃碼測試.Location = new System.Drawing.Point(832, 811);
            this.plC_RJ_Button_掃碼測試.Name = "plC_RJ_Button_掃碼測試";
            this.plC_RJ_Button_掃碼測試.OFF_文字內容 = "掃碼測試";
            this.plC_RJ_Button_掃碼測試.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_掃碼測試.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_掃碼測試.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_掃碼測試.ON_BorderSize = 5;
            this.plC_RJ_Button_掃碼測試.ON_文字內容 = "掃碼測試";
            this.plC_RJ_Button_掃碼測試.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_掃碼測試.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_掃碼測試.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_掃碼測試.Size = new System.Drawing.Size(152, 69);
            this.plC_RJ_Button_掃碼測試.State = false;
            this.plC_RJ_Button_掃碼測試.TabIndex = 122;
            this.plC_RJ_Button_掃碼測試.Text = "掃碼測試";
            this.plC_RJ_Button_掃碼測試.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_掃碼測試.Texts = "掃碼測試";
            this.plC_RJ_Button_掃碼測試.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_掃碼測試.Visible = false;
            this.plC_RJ_Button_掃碼測試.字型鎖住 = false;
            this.plC_RJ_Button_掃碼測試.寫入元件位置 = "S4051";
            this.plC_RJ_Button_掃碼測試.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.交替型;
            this.plC_RJ_Button_掃碼測試.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_掃碼測試.文字鎖住 = false;
            this.plC_RJ_Button_掃碼測試.致能讀取位置 = "S4077";
            this.plC_RJ_Button_掃碼測試.讀取位元反向 = false;
            this.plC_RJ_Button_掃碼測試.讀取元件位置 = "S4051";
            this.plC_RJ_Button_掃碼測試.讀寫鎖住 = false;
            this.plC_RJ_Button_掃碼測試.音效 = true;
            this.plC_RJ_Button_掃碼測試.顯示 = false;
            this.plC_RJ_Button_掃碼測試.顯示狀態 = false;
            this.plC_RJ_Button_掃碼測試.顯示讀取位置 = "S4077";
            // 
            // rJ_GroupBox_領藥台_01
            // 
            // 
            // rJ_GroupBox_領藥台_01.ContentsPanel
            // 
            this.rJ_GroupBox_領藥台_01.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox_領藥台_01.ContentsPanel.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox_領藥台_01.ContentsPanel.BorderRadius = 5;
            this.rJ_GroupBox_領藥台_01.ContentsPanel.BorderSize = 5;
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Controls.Add(this.plC_RJ_Button_領藥台_01_強制入帳);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Controls.Add(this.plC_RJ_Button_領藥台_01_手輸醫囑);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Controls.Add(this.plC_RJ_Button_領藥台_01_手動作業);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Controls.Add(this.rJ_ProgressBar_領藥台_01_入賬完成時間條);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Controls.Add(this.plC_RJ_Button_領藥台_01_取消作業);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Controls.Add(this.plC_Button_領藥台_01_退);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Controls.Add(this.plC_Button_領藥台_01_領);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Controls.Add(this.plC_RJ_Button_領藥台_01_登出);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Controls.Add(this.rJ_ProgressBar_領藥台_01_閒置登出時間條);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Controls.Add(this.plC_MultiStateDisplay_領藥台_01_狀態顯示);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Controls.Add(this.sqL_DataGridView_領藥台_01_領藥內容);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Controls.Add(this.rJ_GroupBox5);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox_領藥台_01.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox_領藥台_01.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox_領藥台_01.ContentsPanel.Size = new System.Drawing.Size(826, 949);
            this.rJ_GroupBox_領藥台_01.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox_領藥台_01.Dock = System.Windows.Forms.DockStyle.Left;
            this.rJ_GroupBox_領藥台_01.Location = new System.Drawing.Point(0, 0);
            this.rJ_GroupBox_領藥台_01.Name = "rJ_GroupBox_領藥台_01";
            this.rJ_GroupBox_領藥台_01.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox_領藥台_01.PannelBorderColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox_領藥台_01.PannelBorderRadius = 5;
            this.rJ_GroupBox_領藥台_01.PannelBorderSize = 5;
            this.rJ_GroupBox_領藥台_01.Size = new System.Drawing.Size(826, 986);
            this.rJ_GroupBox_領藥台_01.TabIndex = 8;
            this.rJ_GroupBox_領藥台_01.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox_領藥台_01.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox_領藥台_01.TitleBorderRadius = 5;
            this.rJ_GroupBox_領藥台_01.TitleBorderSize = 0;
            this.rJ_GroupBox_領藥台_01.TitleFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_GroupBox_領藥台_01.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox_領藥台_01.TitleHeight = 37;
            this.rJ_GroupBox_領藥台_01.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_GroupBox_領藥台_01.TitleTexts = "    01.號使用者";
            // 
            // plC_RJ_Button_領藥台_01_強制入帳
            // 
            this.plC_RJ_Button_領藥台_01_強制入帳.AutoResetState = false;
            this.plC_RJ_Button_領藥台_01_強制入帳.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_領藥台_01_強制入帳.Bool = false;
            this.plC_RJ_Button_領藥台_01_強制入帳.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_領藥台_01_強制入帳.BorderRadius = 10;
            this.plC_RJ_Button_領藥台_01_強制入帳.BorderSize = 0;
            this.plC_RJ_Button_領藥台_01_強制入帳.but_press = false;
            this.plC_RJ_Button_領藥台_01_強制入帳.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_領藥台_01_強制入帳.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_領藥台_01_強制入帳.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_領藥台_01_強制入帳.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_領藥台_01_強制入帳.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_領藥台_01_強制入帳.Location = new System.Drawing.Point(638, 136);
            this.plC_RJ_Button_領藥台_01_強制入帳.Name = "plC_RJ_Button_領藥台_01_強制入帳";
            this.plC_RJ_Button_領藥台_01_強制入帳.OFF_文字內容 = "強制入帳";
            this.plC_RJ_Button_領藥台_01_強制入帳.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_領藥台_01_強制入帳.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_領藥台_01_強制入帳.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_領藥台_01_強制入帳.ON_BorderSize = 5;
            this.plC_RJ_Button_領藥台_01_強制入帳.ON_文字內容 = "強制入帳";
            this.plC_RJ_Button_領藥台_01_強制入帳.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_領藥台_01_強制入帳.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_領藥台_01_強制入帳.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_領藥台_01_強制入帳.Size = new System.Drawing.Size(152, 69);
            this.plC_RJ_Button_領藥台_01_強制入帳.State = false;
            this.plC_RJ_Button_領藥台_01_強制入帳.TabIndex = 121;
            this.plC_RJ_Button_領藥台_01_強制入帳.Text = "強制入帳";
            this.plC_RJ_Button_領藥台_01_強制入帳.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_領藥台_01_強制入帳.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_領藥台_01_強制入帳.Visible = false;
            this.plC_RJ_Button_領藥台_01_強制入帳.字型鎖住 = false;
            this.plC_RJ_Button_領藥台_01_強制入帳.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_領藥台_01_強制入帳.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_領藥台_01_強制入帳.文字鎖住 = false;
            this.plC_RJ_Button_領藥台_01_強制入帳.致能讀取位置 = "S4077";
            this.plC_RJ_Button_領藥台_01_強制入帳.讀取位元反向 = false;
            this.plC_RJ_Button_領藥台_01_強制入帳.讀寫鎖住 = false;
            this.plC_RJ_Button_領藥台_01_強制入帳.音效 = true;
            this.plC_RJ_Button_領藥台_01_強制入帳.顯示 = false;
            this.plC_RJ_Button_領藥台_01_強制入帳.顯示狀態 = false;
            this.plC_RJ_Button_領藥台_01_強制入帳.顯示讀取位置 = "M8001";
            // 
            // plC_RJ_Button_領藥台_01_手輸醫囑
            // 
            this.plC_RJ_Button_領藥台_01_手輸醫囑.AutoResetState = true;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.Bool = false;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.BorderRadius = 10;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.BorderSize = 0;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.but_press = false;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_領藥台_01_手輸醫囑.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.Location = new System.Drawing.Point(188, 136);
            this.plC_RJ_Button_領藥台_01_手輸醫囑.Name = "plC_RJ_Button_領藥台_01_手輸醫囑";
            this.plC_RJ_Button_領藥台_01_手輸醫囑.OFF_文字內容 = "手輸醫囑";
            this.plC_RJ_Button_領藥台_01_手輸醫囑.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_領藥台_01_手輸醫囑.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.ON_BorderSize = 5;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.ON_文字內容 = "手輸醫囑";
            this.plC_RJ_Button_領藥台_01_手輸醫囑.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_領藥台_01_手輸醫囑.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.Size = new System.Drawing.Size(152, 69);
            this.plC_RJ_Button_領藥台_01_手輸醫囑.State = false;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.TabIndex = 120;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.Text = "手輸醫囑";
            this.plC_RJ_Button_領藥台_01_手輸醫囑.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.Visible = false;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.字型鎖住 = false;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.文字鎖住 = false;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.致能讀取位置 = "S100";
            this.plC_RJ_Button_領藥台_01_手輸醫囑.讀取位元反向 = false;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.讀寫鎖住 = false;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.音效 = true;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.顯示 = false;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.顯示狀態 = false;
            this.plC_RJ_Button_領藥台_01_手輸醫囑.顯示讀取位置 = "M8001";
            // 
            // plC_RJ_Button_領藥台_01_手動作業
            // 
            this.plC_RJ_Button_領藥台_01_手動作業.AutoResetState = true;
            this.plC_RJ_Button_領藥台_01_手動作業.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_領藥台_01_手動作業.Bool = false;
            this.plC_RJ_Button_領藥台_01_手動作業.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_領藥台_01_手動作業.BorderRadius = 10;
            this.plC_RJ_Button_領藥台_01_手動作業.BorderSize = 0;
            this.plC_RJ_Button_領藥台_01_手動作業.but_press = false;
            this.plC_RJ_Button_領藥台_01_手動作業.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_領藥台_01_手動作業.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_領藥台_01_手動作業.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_領藥台_01_手動作業.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_領藥台_01_手動作業.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_領藥台_01_手動作業.Location = new System.Drawing.Point(30, 136);
            this.plC_RJ_Button_領藥台_01_手動作業.Name = "plC_RJ_Button_領藥台_01_手動作業";
            this.plC_RJ_Button_領藥台_01_手動作業.OFF_文字內容 = "手動作業";
            this.plC_RJ_Button_領藥台_01_手動作業.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_領藥台_01_手動作業.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_領藥台_01_手動作業.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_領藥台_01_手動作業.ON_BorderSize = 5;
            this.plC_RJ_Button_領藥台_01_手動作業.ON_文字內容 = "手動作業";
            this.plC_RJ_Button_領藥台_01_手動作業.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_領藥台_01_手動作業.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_領藥台_01_手動作業.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_領藥台_01_手動作業.Size = new System.Drawing.Size(152, 69);
            this.plC_RJ_Button_領藥台_01_手動作業.State = false;
            this.plC_RJ_Button_領藥台_01_手動作業.TabIndex = 119;
            this.plC_RJ_Button_領藥台_01_手動作業.Text = "手動作業";
            this.plC_RJ_Button_領藥台_01_手動作業.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_領藥台_01_手動作業.Texts = "手動作業";
            this.plC_RJ_Button_領藥台_01_手動作業.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_領藥台_01_手動作業.字型鎖住 = false;
            this.plC_RJ_Button_領藥台_01_手動作業.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_領藥台_01_手動作業.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_領藥台_01_手動作業.文字鎖住 = false;
            this.plC_RJ_Button_領藥台_01_手動作業.致能讀取位置 = "S100";
            this.plC_RJ_Button_領藥台_01_手動作業.讀取位元反向 = false;
            this.plC_RJ_Button_領藥台_01_手動作業.讀寫鎖住 = false;
            this.plC_RJ_Button_領藥台_01_手動作業.音效 = true;
            this.plC_RJ_Button_領藥台_01_手動作業.顯示 = false;
            this.plC_RJ_Button_領藥台_01_手動作業.顯示狀態 = false;
            // 
            // rJ_ProgressBar_領藥台_01_入賬完成時間條
            // 
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.ChannelHeight = 6;
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.ForeColor = System.Drawing.Color.White;
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.Location = new System.Drawing.Point(595, 930);
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.Name = "rJ_ProgressBar_領藥台_01_入賬完成時間條";
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.ShowMaximun = true;
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.ShowValue = MyUI.TextPosition.Right;
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.Size = new System.Drawing.Size(102, 23);
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.SliderColor = System.Drawing.Color.RoyalBlue;
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.SliderHeight = 6;
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.SymbolAfter = "";
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.SymbolBefore = "";
            this.rJ_ProgressBar_領藥台_01_入賬完成時間條.TabIndex = 118;
            // 
            // plC_RJ_Button_領藥台_01_取消作業
            // 
            this.plC_RJ_Button_領藥台_01_取消作業.AutoResetState = false;
            this.plC_RJ_Button_領藥台_01_取消作業.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_領藥台_01_取消作業.Bool = false;
            this.plC_RJ_Button_領藥台_01_取消作業.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_領藥台_01_取消作業.BorderRadius = 20;
            this.plC_RJ_Button_領藥台_01_取消作業.BorderSize = 0;
            this.plC_RJ_Button_領藥台_01_取消作業.but_press = false;
            this.plC_RJ_Button_領藥台_01_取消作業.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_領藥台_01_取消作業.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_領藥台_01_取消作業.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_領藥台_01_取消作業.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.plC_RJ_Button_領藥台_01_取消作業.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_領藥台_01_取消作業.Location = new System.Drawing.Point(597, 771);
            this.plC_RJ_Button_領藥台_01_取消作業.Name = "plC_RJ_Button_領藥台_01_取消作業";
            this.plC_RJ_Button_領藥台_01_取消作業.OFF_文字內容 = "取消作業";
            this.plC_RJ_Button_領藥台_01_取消作業.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 18F);
            this.plC_RJ_Button_領藥台_01_取消作業.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_領藥台_01_取消作業.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_領藥台_01_取消作業.ON_BorderSize = 5;
            this.plC_RJ_Button_領藥台_01_取消作業.ON_文字內容 = "取消作業";
            this.plC_RJ_Button_領藥台_01_取消作業.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 18F);
            this.plC_RJ_Button_領藥台_01_取消作業.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_領藥台_01_取消作業.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_領藥台_01_取消作業.Size = new System.Drawing.Size(200, 72);
            this.plC_RJ_Button_領藥台_01_取消作業.State = false;
            this.plC_RJ_Button_領藥台_01_取消作業.TabIndex = 117;
            this.plC_RJ_Button_領藥台_01_取消作業.Text = "取消作業";
            this.plC_RJ_Button_領藥台_01_取消作業.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_領藥台_01_取消作業.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_領藥台_01_取消作業.字型鎖住 = false;
            this.plC_RJ_Button_領藥台_01_取消作業.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_領藥台_01_取消作業.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_領藥台_01_取消作業.文字鎖住 = false;
            this.plC_RJ_Button_領藥台_01_取消作業.讀取位元反向 = false;
            this.plC_RJ_Button_領藥台_01_取消作業.讀寫鎖住 = false;
            this.plC_RJ_Button_領藥台_01_取消作業.音效 = true;
            this.plC_RJ_Button_領藥台_01_取消作業.顯示 = false;
            this.plC_RJ_Button_領藥台_01_取消作業.顯示狀態 = false;
            this.plC_RJ_Button_領藥台_01_取消作業.顯示讀取位置 = "M8000";
            // 
            // plC_Button_領藥台_01_退
            // 
            this.plC_Button_領藥台_01_退.Bool = false;
            this.plC_Button_領藥台_01_退.but_press = false;
            this.plC_Button_領藥台_01_退.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button_領藥台_01_退.Location = new System.Drawing.Point(700, 686);
            this.plC_Button_領藥台_01_退.Name = "plC_Button_領藥台_01_退";
            this.plC_Button_領藥台_01_退.OFF_文字內容 = "退";
            this.plC_Button_領藥台_01_退.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 26F, System.Drawing.FontStyle.Bold);
            this.plC_Button_領藥台_01_退.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_Button_領藥台_01_退.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_領藥台_01_退.ON_文字內容 = "退";
            this.plC_Button_領藥台_01_退.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 26F, System.Drawing.FontStyle.Bold);
            this.plC_Button_領藥台_01_退.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button_領藥台_01_退.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_領藥台_01_退.Size = new System.Drawing.Size(97, 72);
            this.plC_Button_領藥台_01_退.Style = MyUI.PLC_Button.StyleEnum.Light_Rect_藍;
            this.plC_Button_領藥台_01_退.TabIndex = 116;
            this.plC_Button_領藥台_01_退.Visible = false;
            this.plC_Button_領藥台_01_退.事件驅動 = true;
            this.plC_Button_領藥台_01_退.字型鎖住 = false;
            this.plC_Button_領藥台_01_退.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button_領藥台_01_退.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button_領藥台_01_退.文字鎖住 = false;
            this.plC_Button_領藥台_01_退.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_領藥台_01_退.狀態OFF圖片")));
            this.plC_Button_領藥台_01_退.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_領藥台_01_退.狀態ON圖片")));
            this.plC_Button_領藥台_01_退.讀取位元反向 = false;
            this.plC_Button_領藥台_01_退.讀寫鎖住 = false;
            this.plC_Button_領藥台_01_退.起始狀態 = false;
            this.plC_Button_領藥台_01_退.音效 = true;
            this.plC_Button_領藥台_01_退.顯示 = false;
            this.plC_Button_領藥台_01_退.顯示狀態 = false;
            // 
            // plC_Button_領藥台_01_領
            // 
            this.plC_Button_領藥台_01_領.Bool = false;
            this.plC_Button_領藥台_01_領.but_press = false;
            this.plC_Button_領藥台_01_領.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button_領藥台_01_領.Location = new System.Drawing.Point(597, 686);
            this.plC_Button_領藥台_01_領.Name = "plC_Button_領藥台_01_領";
            this.plC_Button_領藥台_01_領.OFF_文字內容 = "領";
            this.plC_Button_領藥台_01_領.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 26F, System.Drawing.FontStyle.Bold);
            this.plC_Button_領藥台_01_領.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_Button_領藥台_01_領.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_領藥台_01_領.ON_文字內容 = "領";
            this.plC_Button_領藥台_01_領.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 26F, System.Drawing.FontStyle.Bold);
            this.plC_Button_領藥台_01_領.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button_領藥台_01_領.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_領藥台_01_領.Size = new System.Drawing.Size(97, 72);
            this.plC_Button_領藥台_01_領.Style = MyUI.PLC_Button.StyleEnum.Light_Rect_藍;
            this.plC_Button_領藥台_01_領.TabIndex = 115;
            this.plC_Button_領藥台_01_領.事件驅動 = true;
            this.plC_Button_領藥台_01_領.字型鎖住 = false;
            this.plC_Button_領藥台_01_領.寫入位置註解 = "領藥台_01_領藥";
            this.plC_Button_領藥台_01_領.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button_領藥台_01_領.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button_領藥台_01_領.文字鎖住 = false;
            this.plC_Button_領藥台_01_領.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_領藥台_01_領.狀態OFF圖片")));
            this.plC_Button_領藥台_01_領.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_領藥台_01_領.狀態ON圖片")));
            this.plC_Button_領藥台_01_領.讀取位元反向 = false;
            this.plC_Button_領藥台_01_領.讀寫鎖住 = false;
            this.plC_Button_領藥台_01_領.起始狀態 = false;
            this.plC_Button_領藥台_01_領.音效 = true;
            this.plC_Button_領藥台_01_領.顯示 = false;
            this.plC_Button_領藥台_01_領.顯示狀態 = false;
            // 
            // plC_RJ_Button_領藥台_01_登出
            // 
            this.plC_RJ_Button_領藥台_01_登出.AutoResetState = false;
            this.plC_RJ_Button_領藥台_01_登出.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_領藥台_01_登出.Bool = false;
            this.plC_RJ_Button_領藥台_01_登出.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_領藥台_01_登出.BorderRadius = 20;
            this.plC_RJ_Button_領藥台_01_登出.BorderSize = 0;
            this.plC_RJ_Button_領藥台_01_登出.but_press = false;
            this.plC_RJ_Button_領藥台_01_登出.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_領藥台_01_登出.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_領藥台_01_登出.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_領藥台_01_登出.Font = new System.Drawing.Font("微軟正黑體", 18F);
            this.plC_RJ_Button_領藥台_01_登出.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_領藥台_01_登出.Location = new System.Drawing.Point(597, 849);
            this.plC_RJ_Button_領藥台_01_登出.Name = "plC_RJ_Button_領藥台_01_登出";
            this.plC_RJ_Button_領藥台_01_登出.OFF_文字內容 = "登出";
            this.plC_RJ_Button_領藥台_01_登出.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 18F);
            this.plC_RJ_Button_領藥台_01_登出.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_領藥台_01_登出.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_領藥台_01_登出.ON_BorderSize = 5;
            this.plC_RJ_Button_領藥台_01_登出.ON_文字內容 = "登出";
            this.plC_RJ_Button_領藥台_01_登出.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 18F);
            this.plC_RJ_Button_領藥台_01_登出.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_領藥台_01_登出.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_領藥台_01_登出.Size = new System.Drawing.Size(200, 72);
            this.plC_RJ_Button_領藥台_01_登出.State = false;
            this.plC_RJ_Button_領藥台_01_登出.TabIndex = 9;
            this.plC_RJ_Button_領藥台_01_登出.Text = "登出";
            this.plC_RJ_Button_領藥台_01_登出.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_領藥台_01_登出.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_領藥台_01_登出.字型鎖住 = false;
            this.plC_RJ_Button_領藥台_01_登出.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_領藥台_01_登出.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_領藥台_01_登出.文字鎖住 = false;
            this.plC_RJ_Button_領藥台_01_登出.讀取位元反向 = false;
            this.plC_RJ_Button_領藥台_01_登出.讀寫鎖住 = false;
            this.plC_RJ_Button_領藥台_01_登出.音效 = true;
            this.plC_RJ_Button_領藥台_01_登出.顯示 = false;
            this.plC_RJ_Button_領藥台_01_登出.顯示狀態 = false;
            // 
            // rJ_ProgressBar_領藥台_01_閒置登出時間條
            // 
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.ChannelColor = System.Drawing.Color.LightSteelBlue;
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.ChannelHeight = 6;
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.ForeBackColor = System.Drawing.Color.RoyalBlue;
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.ForeColor = System.Drawing.Color.White;
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.Location = new System.Drawing.Point(703, 930);
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.Name = "rJ_ProgressBar_領藥台_01_閒置登出時間條";
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.ShowMaximun = true;
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.ShowValue = MyUI.TextPosition.Right;
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.Size = new System.Drawing.Size(102, 23);
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.SliderColor = System.Drawing.Color.RoyalBlue;
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.SliderHeight = 6;
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.SymbolAfter = "";
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.SymbolBefore = "";
            this.rJ_ProgressBar_領藥台_01_閒置登出時間條.TabIndex = 14;
            // 
            // plC_MultiStateDisplay_領藥台_01_狀態顯示
            // 
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.BackColor = System.Drawing.Color.SkyBlue;
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.BorderRadius = 20;
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.Cursor = System.Windows.Forms.Cursors.Default;
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.Location = new System.Drawing.Point(376, 13);
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.Name = "plC_MultiStateDisplay_領藥台_01_狀態顯示";
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.RefreshTime = 1;
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.Size = new System.Drawing.Size(414, 120);
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.TabIndex = 7;
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.字體顏色 = System.Drawing.Color.Black;
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.文字對齊位置 = System.Drawing.ContentAlignment.TopLeft;
            textValue1.Name = "M4000";
            textValue1.Text = "請登入身分...";
            textValue1.字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            textValue1.文字對齊方式 = MyUI.PLC_MultiStateDisplay.TextValue.Alignment.Left;
            textValue1.文字顏色 = System.Drawing.Color.Black;
            textValue1.自定義參數 = false;
            textValue2.Name = "M4001";
            textValue2.Text = "登入者姓名 : XXX";
            textValue2.字體 = new System.Drawing.Font("微軟正黑體", 30F);
            textValue2.文字對齊方式 = MyUI.PLC_MultiStateDisplay.TextValue.Alignment.Left;
            textValue2.文字顏色 = System.Drawing.Color.Black;
            textValue2.自定義參數 = true;
            textValue3.Name = "M4002";
            textValue3.Text = "登入失敗,查無此資料!";
            textValue3.字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            textValue3.文字對齊方式 = MyUI.PLC_MultiStateDisplay.TextValue.Alignment.Left;
            textValue3.文字顏色 = System.Drawing.Color.Red;
            textValue3.自定義參數 = false;
            textValue4.Name = "M4005";
            textValue4.Text = "請選擇領/退藥";
            textValue4.字體 = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold);
            textValue4.文字對齊方式 = MyUI.PLC_MultiStateDisplay.TextValue.Alignment.Left;
            textValue4.文字顏色 = System.Drawing.Color.Red;
            textValue4.自定義參數 = false;
            textValue5.Name = "M4006";
            textValue5.Text = "此藥單已領用過!";
            textValue5.字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            textValue5.文字對齊方式 = MyUI.PLC_MultiStateDisplay.TextValue.Alignment.Left;
            textValue5.文字顏色 = System.Drawing.Color.Red;
            textValue5.自定義參數 = false;
            textValue6.Name = "M4007";
            textValue6.Text = "掃碼失敗!";
            textValue6.字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            textValue6.文字對齊方式 = MyUI.PLC_MultiStateDisplay.TextValue.Alignment.Left;
            textValue6.文字顏色 = System.Drawing.Color.Red;
            textValue6.自定義參數 = false;
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.狀態內容.Add(textValue1);
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.狀態內容.Add(textValue2);
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.狀態內容.Add(textValue3);
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.狀態內容.Add(textValue4);
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.狀態內容.Add(textValue5);
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.狀態內容.Add(textValue6);
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.背景顏色 = System.Drawing.Color.SkyBlue;
            this.plC_MultiStateDisplay_領藥台_01_狀態顯示.顯示字體 = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            // 
            // sqL_DataGridView_領藥台_01_領藥內容
            // 
            this.sqL_DataGridView_領藥台_01_領藥內容.AutoSelectToDeep = false;
            this.sqL_DataGridView_領藥台_01_領藥內容.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_領藥台_01_領藥內容.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_領藥台_01_領藥內容.BorderRadius = 10;
            this.sqL_DataGridView_領藥台_01_領藥內容.BorderSize = 2;
            this.sqL_DataGridView_領藥台_01_領藥內容.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_領藥台_01_領藥內容.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_領藥台_01_領藥內容.cellStyleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sqL_DataGridView_領藥台_01_領藥內容.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_領藥台_01_領藥內容.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_領藥台_01_領藥內容.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sqL_DataGridView_領藥台_01_領藥內容.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_領藥台_01_領藥內容.columnHeadersHeight = 44;
            this.sqL_DataGridView_領藥台_01_領藥內容.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns1"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns2"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns3"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns4"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns5"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns6"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns7"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns8"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns9"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns10"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns11"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns12"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_領藥台_01_領藥內容.Columns13"))));
            this.sqL_DataGridView_領藥台_01_領藥內容.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_領藥台_01_領藥內容.ImageBox = false;
            this.sqL_DataGridView_領藥台_01_領藥內容.Location = new System.Drawing.Point(14, 209);
            this.sqL_DataGridView_領藥台_01_領藥內容.Name = "sqL_DataGridView_領藥台_01_領藥內容";
            this.sqL_DataGridView_領藥台_01_領藥內容.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_領藥台_01_領藥內容.Password = "user82822040";
            this.sqL_DataGridView_領藥台_01_領藥內容.Port = ((uint)(3306u));
            this.sqL_DataGridView_領藥台_01_領藥內容.rowHeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.sqL_DataGridView_領藥台_01_領藥內容.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_領藥台_01_領藥內容.RowsColor = System.Drawing.SystemColors.Window;
            this.sqL_DataGridView_領藥台_01_領藥內容.RowsHeight = 80;
            this.sqL_DataGridView_領藥台_01_領藥內容.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_領藥台_01_領藥內容.Server = "127.0.0.0";
            this.sqL_DataGridView_領藥台_01_領藥內容.Size = new System.Drawing.Size(783, 471);
            this.sqL_DataGridView_領藥台_01_領藥內容.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_領藥台_01_領藥內容.TabIndex = 6;
            this.sqL_DataGridView_領藥台_01_領藥內容.UserName = "root";
            this.sqL_DataGridView_領藥台_01_領藥內容.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_領藥台_01_領藥內容.可選擇多列 = false;
            this.sqL_DataGridView_領藥台_01_領藥內容.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_領藥台_01_領藥內容.自動換行 = true;
            this.sqL_DataGridView_領藥台_01_領藥內容.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_領藥台_01_領藥內容.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_領藥台_01_領藥內容.顯示CheckBox = false;
            this.sqL_DataGridView_領藥台_01_領藥內容.顯示首列 = false;
            this.sqL_DataGridView_領藥台_01_領藥內容.顯示首行 = true;
            this.sqL_DataGridView_領藥台_01_領藥內容.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_領藥台_01_領藥內容.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // rJ_GroupBox5
            // 
            // 
            // rJ_GroupBox5.ContentsPanel
            // 
            this.rJ_GroupBox5.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox5.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox5.ContentsPanel.BorderRadius = 5;
            this.rJ_GroupBox5.ContentsPanel.BorderSize = 1;
            this.rJ_GroupBox5.ContentsPanel.Controls.Add(this.plC_RJ_Button_領藥台_01_登入);
            this.rJ_GroupBox5.ContentsPanel.Controls.Add(this.textBox_領藥台_01_帳號);
            this.rJ_GroupBox5.ContentsPanel.Controls.Add(this.textBox_領藥台_01_密碼);
            this.rJ_GroupBox5.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox5.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox5.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox5.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox5.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox5.ContentsPanel.Size = new System.Drawing.Size(340, 83);
            this.rJ_GroupBox5.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox5.Location = new System.Drawing.Point(30, 13);
            this.rJ_GroupBox5.Name = "rJ_GroupBox5";
            this.rJ_GroupBox5.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox5.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox5.PannelBorderRadius = 5;
            this.rJ_GroupBox5.PannelBorderSize = 1;
            this.rJ_GroupBox5.Size = new System.Drawing.Size(340, 120);
            this.rJ_GroupBox5.TabIndex = 5;
            this.rJ_GroupBox5.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox5.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox5.TitleBorderRadius = 5;
            this.rJ_GroupBox5.TitleBorderSize = 0;
            this.rJ_GroupBox5.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.rJ_GroupBox5.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox5.TitleHeight = 37;
            this.rJ_GroupBox5.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox5.TitleTexts = "使用者登入";
            // 
            // plC_RJ_Button_領藥台_01_登入
            // 
            this.plC_RJ_Button_領藥台_01_登入.AutoResetState = false;
            this.plC_RJ_Button_領藥台_01_登入.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_領藥台_01_登入.Bool = false;
            this.plC_RJ_Button_領藥台_01_登入.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_領藥台_01_登入.BorderRadius = 20;
            this.plC_RJ_Button_領藥台_01_登入.BorderSize = 0;
            this.plC_RJ_Button_領藥台_01_登入.but_press = false;
            this.plC_RJ_Button_領藥台_01_登入.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_領藥台_01_登入.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_領藥台_01_登入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_領藥台_01_登入.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_領藥台_01_登入.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_領藥台_01_登入.Location = new System.Drawing.Point(185, 4);
            this.plC_RJ_Button_領藥台_01_登入.Name = "plC_RJ_Button_領藥台_01_登入";
            this.plC_RJ_Button_領藥台_01_登入.OFF_文字內容 = "登入";
            this.plC_RJ_Button_領藥台_01_登入.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_領藥台_01_登入.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_領藥台_01_登入.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_領藥台_01_登入.ON_BorderSize = 5;
            this.plC_RJ_Button_領藥台_01_登入.ON_文字內容 = "登入";
            this.plC_RJ_Button_領藥台_01_登入.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_領藥台_01_登入.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_領藥台_01_登入.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_領藥台_01_登入.Size = new System.Drawing.Size(152, 74);
            this.plC_RJ_Button_領藥台_01_登入.State = false;
            this.plC_RJ_Button_領藥台_01_登入.TabIndex = 12;
            this.plC_RJ_Button_領藥台_01_登入.Text = "登入";
            this.plC_RJ_Button_領藥台_01_登入.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_領藥台_01_登入.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_領藥台_01_登入.字型鎖住 = false;
            this.plC_RJ_Button_領藥台_01_登入.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_領藥台_01_登入.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_領藥台_01_登入.文字鎖住 = false;
            this.plC_RJ_Button_領藥台_01_登入.讀取位元反向 = false;
            this.plC_RJ_Button_領藥台_01_登入.讀寫鎖住 = false;
            this.plC_RJ_Button_領藥台_01_登入.音效 = true;
            this.plC_RJ_Button_領藥台_01_登入.顯示 = false;
            this.plC_RJ_Button_領藥台_01_登入.顯示狀態 = false;
            // 
            // textBox_領藥台_01_帳號
            // 
            this.textBox_領藥台_01_帳號.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_領藥台_01_帳號.BorderColor = System.Drawing.Color.RoyalBlue;
            this.textBox_領藥台_01_帳號.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_領藥台_01_帳號.BorderRadius = 10;
            this.textBox_領藥台_01_帳號.BorderSize = 1;
            this.textBox_領藥台_01_帳號.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_領藥台_01_帳號.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_領藥台_01_帳號.Location = new System.Drawing.Point(18, 4);
            this.textBox_領藥台_01_帳號.Multiline = false;
            this.textBox_領藥台_01_帳號.Name = "textBox_領藥台_01_帳號";
            this.textBox_領藥台_01_帳號.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_領藥台_01_帳號.PassWordChar = false;
            this.textBox_領藥台_01_帳號.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_領藥台_01_帳號.PlaceholderText = "UserName";
            this.textBox_領藥台_01_帳號.ShowTouchPannel = false;
            this.textBox_領藥台_01_帳號.Size = new System.Drawing.Size(158, 34);
            this.textBox_領藥台_01_帳號.TabIndex = 1;
            this.textBox_領藥台_01_帳號.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_領藥台_01_帳號.Texts = "";
            this.textBox_領藥台_01_帳號.UnderlineStyle = false;
            // 
            // textBox_領藥台_01_密碼
            // 
            this.textBox_領藥台_01_密碼.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_領藥台_01_密碼.BorderColor = System.Drawing.Color.RoyalBlue;
            this.textBox_領藥台_01_密碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_領藥台_01_密碼.BorderRadius = 10;
            this.textBox_領藥台_01_密碼.BorderSize = 1;
            this.textBox_領藥台_01_密碼.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_領藥台_01_密碼.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_領藥台_01_密碼.Location = new System.Drawing.Point(18, 44);
            this.textBox_領藥台_01_密碼.Multiline = false;
            this.textBox_領藥台_01_密碼.Name = "textBox_領藥台_01_密碼";
            this.textBox_領藥台_01_密碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_領藥台_01_密碼.PassWordChar = false;
            this.textBox_領藥台_01_密碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_領藥台_01_密碼.PlaceholderText = "Password";
            this.textBox_領藥台_01_密碼.ShowTouchPannel = false;
            this.textBox_領藥台_01_密碼.Size = new System.Drawing.Size(158, 34);
            this.textBox_領藥台_01_密碼.TabIndex = 2;
            this.textBox_領藥台_01_密碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_領藥台_01_密碼.Texts = "";
            this.textBox_領藥台_01_密碼.UnderlineStyle = false;
            // 
            // 後台登入
            // 
            this.後台登入.BackColor = System.Drawing.Color.White;
            this.後台登入.Controls.Add(this.groupBox26);
            this.後台登入.Controls.Add(this.rJ_GroupBox7);
            this.後台登入.Controls.Add(this.rJ_Lable5);
            this.後台登入.Location = new System.Drawing.Point(4, 25);
            this.後台登入.Name = "後台登入";
            this.後台登入.Size = new System.Drawing.Size(1638, 986);
            this.後台登入.TabIndex = 1;
            this.後台登入.Text = "後台登入";
            // 
            // groupBox26
            // 
            this.groupBox26.Controls.Add(this.plC_RJ_Button_系統更新);
            this.groupBox26.Controls.Add(this.ftp_DounloadUI);
            this.groupBox26.Location = new System.Drawing.Point(989, 856);
            this.groupBox26.Name = "groupBox26";
            this.groupBox26.Size = new System.Drawing.Size(641, 148);
            this.groupBox26.TabIndex = 112;
            this.groupBox26.TabStop = false;
            this.groupBox26.Text = "系統更新";
            // 
            // plC_RJ_Button_系統更新
            // 
            this.plC_RJ_Button_系統更新.AutoResetState = false;
            this.plC_RJ_Button_系統更新.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_系統更新.Bool = false;
            this.plC_RJ_Button_系統更新.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_系統更新.BorderRadius = 20;
            this.plC_RJ_Button_系統更新.BorderSize = 0;
            this.plC_RJ_Button_系統更新.but_press = false;
            this.plC_RJ_Button_系統更新.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_系統更新.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_系統更新.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_系統更新.Font = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_系統更新.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_系統更新.Location = new System.Drawing.Point(480, 76);
            this.plC_RJ_Button_系統更新.Name = "plC_RJ_Button_系統更新";
            this.plC_RJ_Button_系統更新.OFF_文字內容 = "系統更新";
            this.plC_RJ_Button_系統更新.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_系統更新.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_系統更新.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_系統更新.ON_BorderSize = 5;
            this.plC_RJ_Button_系統更新.ON_文字內容 = "系統更新";
            this.plC_RJ_Button_系統更新.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 15.75F);
            this.plC_RJ_Button_系統更新.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_系統更新.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_系統更新.Size = new System.Drawing.Size(155, 61);
            this.plC_RJ_Button_系統更新.State = false;
            this.plC_RJ_Button_系統更新.TabIndex = 123;
            this.plC_RJ_Button_系統更新.Text = "系統更新";
            this.plC_RJ_Button_系統更新.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_系統更新.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_系統更新.字型鎖住 = false;
            this.plC_RJ_Button_系統更新.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_系統更新.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_系統更新.文字鎖住 = false;
            this.plC_RJ_Button_系統更新.致能讀取位置 = "S39019";
            this.plC_RJ_Button_系統更新.讀取位元反向 = false;
            this.plC_RJ_Button_系統更新.讀寫鎖住 = false;
            this.plC_RJ_Button_系統更新.音效 = true;
            this.plC_RJ_Button_系統更新.顯示 = false;
            this.plC_RJ_Button_系統更新.顯示狀態 = false;
            // 
            // ftp_DounloadUI
            // 
            this.ftp_DounloadUI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ftp_DounloadUI.DownloadType = MyFtpUI.Ftp_DounloadUI.E_DownloadType.URL;
            this.ftp_DounloadUI.FileName = "Setup.msi";
            this.ftp_DounloadUI.FTP_Groupbox_要顯示 = false;
            this.ftp_DounloadUI.FTP_Server = "ftp://kutech.myds.me/FTP";
            this.ftp_DounloadUI.FTP_Server_要顯示 = false;
            this.ftp_DounloadUI.Location = new System.Drawing.Point(6, 26);
            this.ftp_DounloadUI.Name = "ftp_DounloadUI";
            this.ftp_DounloadUI.Password = "test";
            this.ftp_DounloadUI.Password_要顯示 = false;
            this.ftp_DounloadUI.Size = new System.Drawing.Size(431, 111);
            this.ftp_DounloadUI.TabIndex = 12;
            this.ftp_DounloadUI.Username = "test";
            this.ftp_DounloadUI.Username_要顯示 = false;
            // 
            // rJ_GroupBox7
            // 
            // 
            // rJ_GroupBox7.ContentsPanel
            // 
            this.rJ_GroupBox7.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox7.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox7.ContentsPanel.BorderRadius = 5;
            this.rJ_GroupBox7.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox7.ContentsPanel.Controls.Add(this.plC_RJ_Button_後台登入_登入);
            this.rJ_GroupBox7.ContentsPanel.Controls.Add(this.panel185);
            this.rJ_GroupBox7.ContentsPanel.Controls.Add(this.panel183);
            this.rJ_GroupBox7.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox7.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox7.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox7.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox7.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox7.ContentsPanel.Size = new System.Drawing.Size(533, 249);
            this.rJ_GroupBox7.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox7.Location = new System.Drawing.Point(546, 423);
            this.rJ_GroupBox7.Name = "rJ_GroupBox7";
            this.rJ_GroupBox7.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox7.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox7.PannelBorderRadius = 5;
            this.rJ_GroupBox7.PannelBorderSize = 2;
            this.rJ_GroupBox7.Size = new System.Drawing.Size(533, 286);
            this.rJ_GroupBox7.TabIndex = 111;
            this.rJ_GroupBox7.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox7.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox7.TitleBorderRadius = 5;
            this.rJ_GroupBox7.TitleBorderSize = 0;
            this.rJ_GroupBox7.TitleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_GroupBox7.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox7.TitleHeight = 37;
            this.rJ_GroupBox7.TitleTextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rJ_GroupBox7.TitleTexts = "    帳號登入";
            // 
            // plC_RJ_Button_後台登入_登入
            // 
            this.plC_RJ_Button_後台登入_登入.AutoResetState = false;
            this.plC_RJ_Button_後台登入_登入.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_後台登入_登入.Bool = false;
            this.plC_RJ_Button_後台登入_登入.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_後台登入_登入.BorderRadius = 5;
            this.plC_RJ_Button_後台登入_登入.BorderSize = 0;
            this.plC_RJ_Button_後台登入_登入.but_press = false;
            this.plC_RJ_Button_後台登入_登入.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_後台登入_登入.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_後台登入_登入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_後台登入_登入.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_後台登入_登入.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_後台登入_登入.Location = new System.Drawing.Point(317, 173);
            this.plC_RJ_Button_後台登入_登入.Name = "plC_RJ_Button_後台登入_登入";
            this.plC_RJ_Button_後台登入_登入.OFF_文字內容 = "登入";
            this.plC_RJ_Button_後台登入_登入.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_後台登入_登入.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_後台登入_登入.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_後台登入_登入.ON_BorderSize = 5;
            this.plC_RJ_Button_後台登入_登入.ON_文字內容 = "登入";
            this.plC_RJ_Button_後台登入_登入.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14.25F);
            this.plC_RJ_Button_後台登入_登入.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_後台登入_登入.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_後台登入_登入.Size = new System.Drawing.Size(133, 66);
            this.plC_RJ_Button_後台登入_登入.State = false;
            this.plC_RJ_Button_後台登入_登入.TabIndex = 31;
            this.plC_RJ_Button_後台登入_登入.Text = "登入";
            this.plC_RJ_Button_後台登入_登入.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_後台登入_登入.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_後台登入_登入.字型鎖住 = false;
            this.plC_RJ_Button_後台登入_登入.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_後台登入_登入.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_後台登入_登入.文字鎖住 = false;
            this.plC_RJ_Button_後台登入_登入.讀取位元反向 = false;
            this.plC_RJ_Button_後台登入_登入.讀寫鎖住 = false;
            this.plC_RJ_Button_後台登入_登入.音效 = true;
            this.plC_RJ_Button_後台登入_登入.顯示 = false;
            this.plC_RJ_Button_後台登入_登入.顯示狀態 = false;
            // 
            // panel185
            // 
            this.panel185.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel185.Controls.Add(this.textBox_後台登入_帳號);
            this.panel185.Controls.Add(this.panel186);
            this.panel185.Location = new System.Drawing.Point(81, 27);
            this.panel185.Name = "panel185";
            this.panel185.Size = new System.Drawing.Size(369, 67);
            this.panel185.TabIndex = 2;
            // 
            // textBox_後台登入_帳號
            // 
            this.textBox_後台登入_帳號.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_後台登入_帳號.Location = new System.Drawing.Point(82, 23);
            this.textBox_後台登入_帳號.Name = "textBox_後台登入_帳號";
            this.textBox_後台登入_帳號.Size = new System.Drawing.Size(260, 27);
            this.textBox_後台登入_帳號.TabIndex = 1;
            // 
            // panel186
            // 
            this.panel186.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel186.BackgroundImage")));
            this.panel186.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel186.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel186.Location = new System.Drawing.Point(14, 10);
            this.panel186.Name = "panel186";
            this.panel186.Size = new System.Drawing.Size(51, 47);
            this.panel186.TabIndex = 0;
            // 
            // panel183
            // 
            this.panel183.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel183.Controls.Add(this.textBox_後台登入_密碼);
            this.panel183.Controls.Add(this.panel184);
            this.panel183.Location = new System.Drawing.Point(81, 100);
            this.panel183.Name = "panel183";
            this.panel183.Size = new System.Drawing.Size(369, 67);
            this.panel183.TabIndex = 3;
            // 
            // textBox_後台登入_密碼
            // 
            this.textBox_後台登入_密碼.Font = new System.Drawing.Font("新細明體", 12F);
            this.textBox_後台登入_密碼.Location = new System.Drawing.Point(82, 22);
            this.textBox_後台登入_密碼.Name = "textBox_後台登入_密碼";
            this.textBox_後台登入_密碼.Size = new System.Drawing.Size(260, 27);
            this.textBox_後台登入_密碼.TabIndex = 2;
            this.textBox_後台登入_密碼.UseSystemPasswordChar = true;
            // 
            // panel184
            // 
            this.panel184.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel184.BackgroundImage")));
            this.panel184.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel184.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel184.Location = new System.Drawing.Point(14, 10);
            this.panel184.Name = "panel184";
            this.panel184.Size = new System.Drawing.Size(51, 47);
            this.panel184.TabIndex = 0;
            // 
            // rJ_Lable5
            // 
            this.rJ_Lable5.BackColor = System.Drawing.Color.RoyalBlue;
            this.rJ_Lable5.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rJ_Lable5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable5.BorderRadius = 12;
            this.rJ_Lable5.BorderSize = 0;
            this.rJ_Lable5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable5.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable5.ForeColor = System.Drawing.Color.White;
            this.rJ_Lable5.Location = new System.Drawing.Point(319, 304);
            this.rJ_Lable5.Name = "rJ_Lable5";
            this.rJ_Lable5.Size = new System.Drawing.Size(1001, 103);
            this.rJ_Lable5.TabIndex = 110;
            this.rJ_Lable5.Text = "智能落藥櫃系統";
            this.rJ_Lable5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable5.TextColor = System.Drawing.Color.White;
            // 
            // 入庫作業
            // 
            this.入庫作業.BackColor = System.Drawing.Color.White;
            this.入庫作業.Location = new System.Drawing.Point(4, 25);
            this.入庫作業.Name = "入庫作業";
            this.入庫作業.Size = new System.Drawing.Size(1638, 986);
            this.入庫作業.TabIndex = 4;
            this.入庫作業.Text = "入庫作業";
            // 
            // 交易記錄查詢
            // 
            this.交易記錄查詢.BackColor = System.Drawing.Color.White;
            this.交易記錄查詢.Controls.Add(this.plC_RJ_Button_交易記錄查詢_刪除);
            this.交易記錄查詢.Controls.Add(this.plC_RJ_Button_交易記錄查詢_顯示全部);
            this.交易記錄查詢.Controls.Add(this.rJ_GroupBox23);
            this.交易記錄查詢.Controls.Add(this.rJ_GroupBox19);
            this.交易記錄查詢.Controls.Add(this.rJ_GroupBox18);
            this.交易記錄查詢.Controls.Add(this.rJ_GroupBox6);
            this.交易記錄查詢.Controls.Add(this.sqL_DataGridView_交易記錄查詢);
            this.交易記錄查詢.Location = new System.Drawing.Point(4, 25);
            this.交易記錄查詢.Name = "交易記錄查詢";
            this.交易記錄查詢.Size = new System.Drawing.Size(1638, 986);
            this.交易記錄查詢.TabIndex = 5;
            this.交易記錄查詢.Text = "交易記錄查詢";
            // 
            // plC_RJ_Button_交易記錄查詢_刪除
            // 
            this.plC_RJ_Button_交易記錄查詢_刪除.AutoResetState = false;
            this.plC_RJ_Button_交易記錄查詢_刪除.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_交易記錄查詢_刪除.Bool = false;
            this.plC_RJ_Button_交易記錄查詢_刪除.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_交易記錄查詢_刪除.BorderRadius = 5;
            this.plC_RJ_Button_交易記錄查詢_刪除.BorderSize = 0;
            this.plC_RJ_Button_交易記錄查詢_刪除.but_press = false;
            this.plC_RJ_Button_交易記錄查詢_刪除.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_交易記錄查詢_刪除.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_交易記錄查詢_刪除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_交易記錄查詢_刪除.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_交易記錄查詢_刪除.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_交易記錄查詢_刪除.Location = new System.Drawing.Point(1547, 702);
            this.plC_RJ_Button_交易記錄查詢_刪除.Name = "plC_RJ_Button_交易記錄查詢_刪除";
            this.plC_RJ_Button_交易記錄查詢_刪除.OFF_文字內容 = "刪除";
            this.plC_RJ_Button_交易記錄查詢_刪除.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_交易記錄查詢_刪除.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_交易記錄查詢_刪除.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_交易記錄查詢_刪除.ON_BorderSize = 5;
            this.plC_RJ_Button_交易記錄查詢_刪除.ON_文字內容 = "刪除";
            this.plC_RJ_Button_交易記錄查詢_刪除.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_交易記錄查詢_刪除.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_交易記錄查詢_刪除.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_交易記錄查詢_刪除.Size = new System.Drawing.Size(88, 148);
            this.plC_RJ_Button_交易記錄查詢_刪除.State = false;
            this.plC_RJ_Button_交易記錄查詢_刪除.TabIndex = 171;
            this.plC_RJ_Button_交易記錄查詢_刪除.Text = "刪除";
            this.plC_RJ_Button_交易記錄查詢_刪除.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_交易記錄查詢_刪除.Texts = "刪除";
            this.plC_RJ_Button_交易記錄查詢_刪除.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_交易記錄查詢_刪除.字型鎖住 = false;
            this.plC_RJ_Button_交易記錄查詢_刪除.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_交易記錄查詢_刪除.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_交易記錄查詢_刪除.文字鎖住 = false;
            this.plC_RJ_Button_交易記錄查詢_刪除.讀取位元反向 = false;
            this.plC_RJ_Button_交易記錄查詢_刪除.讀寫鎖住 = false;
            this.plC_RJ_Button_交易記錄查詢_刪除.音效 = true;
            this.plC_RJ_Button_交易記錄查詢_刪除.顯示 = false;
            this.plC_RJ_Button_交易記錄查詢_刪除.顯示狀態 = false;
            this.plC_RJ_Button_交易記錄查詢_刪除.顯示讀取位置 = "S4077";
            // 
            // plC_RJ_Button_交易記錄查詢_顯示全部
            // 
            this.plC_RJ_Button_交易記錄查詢_顯示全部.AutoResetState = false;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.Bool = false;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.BorderRadius = 5;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.BorderSize = 0;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.but_press = false;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_交易記錄查詢_顯示全部.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.Location = new System.Drawing.Point(1544, 856);
            this.plC_RJ_Button_交易記錄查詢_顯示全部.Name = "plC_RJ_Button_交易記錄查詢_顯示全部";
            this.plC_RJ_Button_交易記錄查詢_顯示全部.OFF_文字內容 = "顯示全部";
            this.plC_RJ_Button_交易記錄查詢_顯示全部.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_交易記錄查詢_顯示全部.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.ON_BorderSize = 5;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.ON_文字內容 = "顯示全部";
            this.plC_RJ_Button_交易記錄查詢_顯示全部.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_交易記錄查詢_顯示全部.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.Size = new System.Drawing.Size(88, 148);
            this.plC_RJ_Button_交易記錄查詢_顯示全部.State = false;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.TabIndex = 170;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.Text = "顯示全部";
            this.plC_RJ_Button_交易記錄查詢_顯示全部.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.Texts = "顯示全部";
            this.plC_RJ_Button_交易記錄查詢_顯示全部.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.字型鎖住 = false;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.文字鎖住 = false;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.讀取位元反向 = false;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.讀寫鎖住 = false;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.音效 = true;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.顯示 = false;
            this.plC_RJ_Button_交易記錄查詢_顯示全部.顯示狀態 = false;
            // 
            // rJ_GroupBox23
            // 
            // 
            // rJ_GroupBox23.ContentsPanel
            // 
            this.rJ_GroupBox23.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox23.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox23.ContentsPanel.BorderRadius = 5;
            this.rJ_GroupBox23.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox23.ContentsPanel.Controls.Add(this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間);
            this.rJ_GroupBox23.ContentsPanel.Controls.Add(this.rJ_Lable44);
            this.rJ_GroupBox23.ContentsPanel.Controls.Add(this.dateTimePicker_交易記錄查詢_開方時間_結束);
            this.rJ_GroupBox23.ContentsPanel.Controls.Add(this.label117);
            this.rJ_GroupBox23.ContentsPanel.Controls.Add(this.dateTimePicker_交易記錄查詢_開方時間_起始);
            this.rJ_GroupBox23.ContentsPanel.Controls.Add(this.rJ_Lable30);
            this.rJ_GroupBox23.ContentsPanel.Controls.Add(this.dateTimePicker_交易記錄查詢_操作時間_結束);
            this.rJ_GroupBox23.ContentsPanel.Controls.Add(this.label106);
            this.rJ_GroupBox23.ContentsPanel.Controls.Add(this.dateTimePicker_交易記錄查詢_操作時間_起始);
            this.rJ_GroupBox23.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox23.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox23.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox23.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox23.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox23.ContentsPanel.Size = new System.Drawing.Size(513, 243);
            this.rJ_GroupBox23.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox23.Location = new System.Drawing.Point(1025, 724);
            this.rJ_GroupBox23.Name = "rJ_GroupBox23";
            this.rJ_GroupBox23.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox23.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox23.PannelBorderRadius = 5;
            this.rJ_GroupBox23.PannelBorderSize = 2;
            this.rJ_GroupBox23.Size = new System.Drawing.Size(513, 280);
            this.rJ_GroupBox23.TabIndex = 169;
            this.rJ_GroupBox23.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox23.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox23.TitleBorderRadius = 5;
            this.rJ_GroupBox23.TitleBorderSize = 0;
            this.rJ_GroupBox23.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.rJ_GroupBox23.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox23.TitleHeight = 37;
            this.rJ_GroupBox23.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox23.TitleTexts = "時間條件";
            // 
            // plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間
            // 
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.Bool = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.ForeColor = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.Location = new System.Drawing.Point(11, 78);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.MinimumSize = new System.Drawing.Size(45, 22);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.Name = "plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.OffBackColor = System.Drawing.Color.Gray;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.Size = new System.Drawing.Size(62, 29);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.SolidStyle = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.TabIndex = 61;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.UseVisualStyleBackColor = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.寫入位置註解 = "動作條件選擇_開方時間";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.寫入元件位置 = "S4131";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.讀取元件位置 = "S4131";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.讀寫鎖住 = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間.音效 = true;
            // 
            // rJ_Lable44
            // 
            this.rJ_Lable44.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable44.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable44.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable44.BorderRadius = 8;
            this.rJ_Lable44.BorderSize = 0;
            this.rJ_Lable44.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable44.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable44.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable44.Location = new System.Drawing.Point(79, 69);
            this.rJ_Lable44.Name = "rJ_Lable44";
            this.rJ_Lable44.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable44.TabIndex = 57;
            this.rJ_Lable44.Text = "開方時間";
            this.rJ_Lable44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable44.TextColor = System.Drawing.Color.Black;
            // 
            // dateTimePicker_交易記錄查詢_開方時間_結束
            // 
            this.dateTimePicker_交易記錄查詢_開方時間_結束.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePicker_交易記錄查詢_開方時間_結束.BorderSize = 0;
            this.dateTimePicker_交易記錄查詢_開方時間_結束.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.dateTimePicker_交易記錄查詢_開方時間_結束.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_交易記錄查詢_開方時間_結束.Location = new System.Drawing.Point(369, 75);
            this.dateTimePicker_交易記錄查詢_開方時間_結束.MinimumSize = new System.Drawing.Size(100, 35);
            this.dateTimePicker_交易記錄查詢_開方時間_結束.Name = "dateTimePicker_交易記錄查詢_開方時間_結束";
            this.dateTimePicker_交易記錄查詢_開方時間_結束.Size = new System.Drawing.Size(131, 35);
            this.dateTimePicker_交易記錄查詢_開方時間_結束.SkinColor = System.Drawing.Color.CornflowerBlue;
            this.dateTimePicker_交易記錄查詢_開方時間_結束.TabIndex = 60;
            this.dateTimePicker_交易記錄查詢_開方時間_結束.TextColor = System.Drawing.Color.White;
            // 
            // label117
            // 
            this.label117.AutoSize = true;
            this.label117.ForeColor = System.Drawing.Color.Black;
            this.label117.Location = new System.Drawing.Point(352, 86);
            this.label117.Name = "label117";
            this.label117.Size = new System.Drawing.Size(11, 12);
            this.label117.TabIndex = 59;
            this.label117.Text = "~";
            // 
            // dateTimePicker_交易記錄查詢_開方時間_起始
            // 
            this.dateTimePicker_交易記錄查詢_開方時間_起始.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePicker_交易記錄查詢_開方時間_起始.BorderSize = 0;
            this.dateTimePicker_交易記錄查詢_開方時間_起始.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.dateTimePicker_交易記錄查詢_開方時間_起始.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_交易記錄查詢_開方時間_起始.Location = new System.Drawing.Point(214, 75);
            this.dateTimePicker_交易記錄查詢_開方時間_起始.MinimumSize = new System.Drawing.Size(100, 35);
            this.dateTimePicker_交易記錄查詢_開方時間_起始.Name = "dateTimePicker_交易記錄查詢_開方時間_起始";
            this.dateTimePicker_交易記錄查詢_開方時間_起始.Size = new System.Drawing.Size(132, 35);
            this.dateTimePicker_交易記錄查詢_開方時間_起始.SkinColor = System.Drawing.Color.CornflowerBlue;
            this.dateTimePicker_交易記錄查詢_開方時間_起始.TabIndex = 58;
            this.dateTimePicker_交易記錄查詢_開方時間_起始.TextColor = System.Drawing.Color.White;
            // 
            // rJ_Lable30
            // 
            this.rJ_Lable30.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable30.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable30.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable30.BorderRadius = 8;
            this.rJ_Lable30.BorderSize = 0;
            this.rJ_Lable30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable30.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable30.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable30.Location = new System.Drawing.Point(79, 16);
            this.rJ_Lable30.Name = "rJ_Lable30";
            this.rJ_Lable30.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable30.TabIndex = 52;
            this.rJ_Lable30.Text = "操作時間";
            this.rJ_Lable30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable30.TextColor = System.Drawing.Color.Black;
            // 
            // dateTimePicker_交易記錄查詢_操作時間_結束
            // 
            this.dateTimePicker_交易記錄查詢_操作時間_結束.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePicker_交易記錄查詢_操作時間_結束.BorderSize = 0;
            this.dateTimePicker_交易記錄查詢_操作時間_結束.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.dateTimePicker_交易記錄查詢_操作時間_結束.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_交易記錄查詢_操作時間_結束.Location = new System.Drawing.Point(369, 22);
            this.dateTimePicker_交易記錄查詢_操作時間_結束.MinimumSize = new System.Drawing.Size(100, 35);
            this.dateTimePicker_交易記錄查詢_操作時間_結束.Name = "dateTimePicker_交易記錄查詢_操作時間_結束";
            this.dateTimePicker_交易記錄查詢_操作時間_結束.Size = new System.Drawing.Size(131, 35);
            this.dateTimePicker_交易記錄查詢_操作時間_結束.SkinColor = System.Drawing.Color.CornflowerBlue;
            this.dateTimePicker_交易記錄查詢_操作時間_結束.TabIndex = 55;
            this.dateTimePicker_交易記錄查詢_操作時間_結束.TextColor = System.Drawing.Color.White;
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.ForeColor = System.Drawing.Color.Black;
            this.label106.Location = new System.Drawing.Point(352, 33);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(11, 12);
            this.label106.TabIndex = 54;
            this.label106.Text = "~";
            // 
            // dateTimePicker_交易記錄查詢_操作時間_起始
            // 
            this.dateTimePicker_交易記錄查詢_操作時間_起始.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePicker_交易記錄查詢_操作時間_起始.BorderSize = 0;
            this.dateTimePicker_交易記錄查詢_操作時間_起始.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.dateTimePicker_交易記錄查詢_操作時間_起始.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_交易記錄查詢_操作時間_起始.Location = new System.Drawing.Point(214, 22);
            this.dateTimePicker_交易記錄查詢_操作時間_起始.MinimumSize = new System.Drawing.Size(100, 35);
            this.dateTimePicker_交易記錄查詢_操作時間_起始.Name = "dateTimePicker_交易記錄查詢_操作時間_起始";
            this.dateTimePicker_交易記錄查詢_操作時間_起始.Size = new System.Drawing.Size(132, 35);
            this.dateTimePicker_交易記錄查詢_操作時間_起始.SkinColor = System.Drawing.Color.CornflowerBlue;
            this.dateTimePicker_交易記錄查詢_操作時間_起始.TabIndex = 53;
            this.dateTimePicker_交易記錄查詢_操作時間_起始.TextColor = System.Drawing.Color.White;
            // 
            // rJ_GroupBox19
            // 
            // 
            // rJ_GroupBox19.ContentsPanel
            // 
            this.rJ_GroupBox19.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox19.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox19.ContentsPanel.BorderRadius = 5;
            this.rJ_GroupBox19.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox19.ContentsPanel.Controls.Add(this.textBox_交易記錄查詢_操作人);
            this.rJ_GroupBox19.ContentsPanel.Controls.Add(this.rJ_Lable41);
            this.rJ_GroupBox19.ContentsPanel.Controls.Add(this.textBox_交易記錄查詢_病人姓名);
            this.rJ_GroupBox19.ContentsPanel.Controls.Add(this.textBox_交易記錄查詢_病歷號);
            this.rJ_GroupBox19.ContentsPanel.Controls.Add(this.rJ_Lable42);
            this.rJ_GroupBox19.ContentsPanel.Controls.Add(this.rJ_Lable43);
            this.rJ_GroupBox19.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox19.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox19.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox19.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox19.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox19.ContentsPanel.Size = new System.Drawing.Size(294, 243);
            this.rJ_GroupBox19.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox19.Location = new System.Drawing.Point(725, 724);
            this.rJ_GroupBox19.Name = "rJ_GroupBox19";
            this.rJ_GroupBox19.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox19.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox19.PannelBorderRadius = 5;
            this.rJ_GroupBox19.PannelBorderSize = 2;
            this.rJ_GroupBox19.Size = new System.Drawing.Size(294, 280);
            this.rJ_GroupBox19.TabIndex = 168;
            this.rJ_GroupBox19.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox19.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox19.TitleBorderRadius = 5;
            this.rJ_GroupBox19.TitleBorderSize = 0;
            this.rJ_GroupBox19.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.rJ_GroupBox19.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox19.TitleHeight = 37;
            this.rJ_GroupBox19.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox19.TitleTexts = "其他條件";
            // 
            // textBox_交易記錄查詢_操作人
            // 
            this.textBox_交易記錄查詢_操作人.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_交易記錄查詢_操作人.BorderColor = System.Drawing.Color.SkyBlue;
            this.textBox_交易記錄查詢_操作人.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_交易記錄查詢_操作人.BorderRadius = 5;
            this.textBox_交易記錄查詢_操作人.BorderSize = 2;
            this.textBox_交易記錄查詢_操作人.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.textBox_交易記錄查詢_操作人.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_交易記錄查詢_操作人.Location = new System.Drawing.Point(150, 20);
            this.textBox_交易記錄查詢_操作人.Multiline = false;
            this.textBox_交易記錄查詢_操作人.Name = "textBox_交易記錄查詢_操作人";
            this.textBox_交易記錄查詢_操作人.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_交易記錄查詢_操作人.PassWordChar = false;
            this.textBox_交易記錄查詢_操作人.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_交易記錄查詢_操作人.PlaceholderText = "";
            this.textBox_交易記錄查詢_操作人.ShowTouchPannel = false;
            this.textBox_交易記錄查詢_操作人.Size = new System.Drawing.Size(135, 36);
            this.textBox_交易記錄查詢_操作人.TabIndex = 45;
            this.textBox_交易記錄查詢_操作人.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_交易記錄查詢_操作人.Texts = "";
            this.textBox_交易記錄查詢_操作人.UnderlineStyle = false;
            // 
            // rJ_Lable41
            // 
            this.rJ_Lable41.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable41.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable41.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable41.BorderRadius = 8;
            this.rJ_Lable41.BorderSize = 0;
            this.rJ_Lable41.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable41.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable41.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable41.Location = new System.Drawing.Point(20, 15);
            this.rJ_Lable41.Name = "rJ_Lable41";
            this.rJ_Lable41.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable41.TabIndex = 44;
            this.rJ_Lable41.Text = "操作人";
            this.rJ_Lable41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable41.TextColor = System.Drawing.Color.Black;
            // 
            // textBox_交易記錄查詢_病人姓名
            // 
            this.textBox_交易記錄查詢_病人姓名.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_交易記錄查詢_病人姓名.BorderColor = System.Drawing.Color.SkyBlue;
            this.textBox_交易記錄查詢_病人姓名.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_交易記錄查詢_病人姓名.BorderRadius = 5;
            this.textBox_交易記錄查詢_病人姓名.BorderSize = 2;
            this.textBox_交易記錄查詢_病人姓名.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.textBox_交易記錄查詢_病人姓名.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_交易記錄查詢_病人姓名.Location = new System.Drawing.Point(150, 75);
            this.textBox_交易記錄查詢_病人姓名.Multiline = false;
            this.textBox_交易記錄查詢_病人姓名.Name = "textBox_交易記錄查詢_病人姓名";
            this.textBox_交易記錄查詢_病人姓名.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_交易記錄查詢_病人姓名.PassWordChar = false;
            this.textBox_交易記錄查詢_病人姓名.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_交易記錄查詢_病人姓名.PlaceholderText = "";
            this.textBox_交易記錄查詢_病人姓名.ShowTouchPannel = false;
            this.textBox_交易記錄查詢_病人姓名.Size = new System.Drawing.Size(135, 36);
            this.textBox_交易記錄查詢_病人姓名.TabIndex = 47;
            this.textBox_交易記錄查詢_病人姓名.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_交易記錄查詢_病人姓名.Texts = "";
            this.textBox_交易記錄查詢_病人姓名.UnderlineStyle = false;
            // 
            // textBox_交易記錄查詢_病歷號
            // 
            this.textBox_交易記錄查詢_病歷號.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_交易記錄查詢_病歷號.BorderColor = System.Drawing.Color.SkyBlue;
            this.textBox_交易記錄查詢_病歷號.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_交易記錄查詢_病歷號.BorderRadius = 5;
            this.textBox_交易記錄查詢_病歷號.BorderSize = 2;
            this.textBox_交易記錄查詢_病歷號.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.textBox_交易記錄查詢_病歷號.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_交易記錄查詢_病歷號.Location = new System.Drawing.Point(150, 130);
            this.textBox_交易記錄查詢_病歷號.Multiline = false;
            this.textBox_交易記錄查詢_病歷號.Name = "textBox_交易記錄查詢_病歷號";
            this.textBox_交易記錄查詢_病歷號.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_交易記錄查詢_病歷號.PassWordChar = false;
            this.textBox_交易記錄查詢_病歷號.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_交易記錄查詢_病歷號.PlaceholderText = "";
            this.textBox_交易記錄查詢_病歷號.ShowTouchPannel = false;
            this.textBox_交易記錄查詢_病歷號.Size = new System.Drawing.Size(135, 36);
            this.textBox_交易記錄查詢_病歷號.TabIndex = 49;
            this.textBox_交易記錄查詢_病歷號.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_交易記錄查詢_病歷號.Texts = "";
            this.textBox_交易記錄查詢_病歷號.UnderlineStyle = false;
            // 
            // rJ_Lable42
            // 
            this.rJ_Lable42.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable42.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable42.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable42.BorderRadius = 8;
            this.rJ_Lable42.BorderSize = 0;
            this.rJ_Lable42.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable42.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable42.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable42.Location = new System.Drawing.Point(20, 70);
            this.rJ_Lable42.Name = "rJ_Lable42";
            this.rJ_Lable42.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable42.TabIndex = 46;
            this.rJ_Lable42.Text = "病人姓名";
            this.rJ_Lable42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable42.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Lable43
            // 
            this.rJ_Lable43.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable43.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable43.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable43.BorderRadius = 8;
            this.rJ_Lable43.BorderSize = 0;
            this.rJ_Lable43.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable43.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable43.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable43.Location = new System.Drawing.Point(20, 125);
            this.rJ_Lable43.Name = "rJ_Lable43";
            this.rJ_Lable43.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable43.TabIndex = 48;
            this.rJ_Lable43.Text = "病歷號";
            this.rJ_Lable43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable43.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_GroupBox18
            // 
            // 
            // rJ_GroupBox18.ContentsPanel
            // 
            this.rJ_GroupBox18.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox18.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox18.ContentsPanel.BorderRadius = 5;
            this.rJ_GroupBox18.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox18.ContentsPanel.Controls.Add(this.textBox_交易記錄查詢_藥品碼);
            this.rJ_GroupBox18.ContentsPanel.Controls.Add(this.rJ_Lable26);
            this.rJ_GroupBox18.ContentsPanel.Controls.Add(this.textBox_交易記錄查詢_藥品名稱);
            this.rJ_GroupBox18.ContentsPanel.Controls.Add(this.textBox_交易記錄查詢_藥袋序號);
            this.rJ_GroupBox18.ContentsPanel.Controls.Add(this.textBox_交易記錄查詢_藥品條碼);
            this.rJ_GroupBox18.ContentsPanel.Controls.Add(this.rJ_Lable27);
            this.rJ_GroupBox18.ContentsPanel.Controls.Add(this.rJ_Lable28);
            this.rJ_GroupBox18.ContentsPanel.Controls.Add(this.rJ_Lable29);
            this.rJ_GroupBox18.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox18.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox18.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox18.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox18.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox18.ContentsPanel.Size = new System.Drawing.Size(294, 243);
            this.rJ_GroupBox18.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox18.Location = new System.Drawing.Point(425, 724);
            this.rJ_GroupBox18.Name = "rJ_GroupBox18";
            this.rJ_GroupBox18.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox18.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox18.PannelBorderRadius = 5;
            this.rJ_GroupBox18.PannelBorderSize = 2;
            this.rJ_GroupBox18.Size = new System.Drawing.Size(294, 280);
            this.rJ_GroupBox18.TabIndex = 167;
            this.rJ_GroupBox18.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox18.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox18.TitleBorderRadius = 5;
            this.rJ_GroupBox18.TitleBorderSize = 0;
            this.rJ_GroupBox18.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.rJ_GroupBox18.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox18.TitleHeight = 37;
            this.rJ_GroupBox18.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox18.TitleTexts = "藥品條件";
            // 
            // textBox_交易記錄查詢_藥品碼
            // 
            this.textBox_交易記錄查詢_藥品碼.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_交易記錄查詢_藥品碼.BorderColor = System.Drawing.Color.SkyBlue;
            this.textBox_交易記錄查詢_藥品碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_交易記錄查詢_藥品碼.BorderRadius = 5;
            this.textBox_交易記錄查詢_藥品碼.BorderSize = 2;
            this.textBox_交易記錄查詢_藥品碼.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.textBox_交易記錄查詢_藥品碼.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_交易記錄查詢_藥品碼.Location = new System.Drawing.Point(150, 20);
            this.textBox_交易記錄查詢_藥品碼.Multiline = false;
            this.textBox_交易記錄查詢_藥品碼.Name = "textBox_交易記錄查詢_藥品碼";
            this.textBox_交易記錄查詢_藥品碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_交易記錄查詢_藥品碼.PassWordChar = false;
            this.textBox_交易記錄查詢_藥品碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_交易記錄查詢_藥品碼.PlaceholderText = "";
            this.textBox_交易記錄查詢_藥品碼.ShowTouchPannel = false;
            this.textBox_交易記錄查詢_藥品碼.Size = new System.Drawing.Size(135, 36);
            this.textBox_交易記錄查詢_藥品碼.TabIndex = 45;
            this.textBox_交易記錄查詢_藥品碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_交易記錄查詢_藥品碼.Texts = "";
            this.textBox_交易記錄查詢_藥品碼.UnderlineStyle = false;
            // 
            // rJ_Lable26
            // 
            this.rJ_Lable26.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable26.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable26.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable26.BorderRadius = 8;
            this.rJ_Lable26.BorderSize = 0;
            this.rJ_Lable26.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable26.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable26.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable26.Location = new System.Drawing.Point(20, 15);
            this.rJ_Lable26.Name = "rJ_Lable26";
            this.rJ_Lable26.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable26.TabIndex = 44;
            this.rJ_Lable26.Text = "藥品碼";
            this.rJ_Lable26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable26.TextColor = System.Drawing.Color.Black;
            // 
            // textBox_交易記錄查詢_藥品名稱
            // 
            this.textBox_交易記錄查詢_藥品名稱.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_交易記錄查詢_藥品名稱.BorderColor = System.Drawing.Color.SkyBlue;
            this.textBox_交易記錄查詢_藥品名稱.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_交易記錄查詢_藥品名稱.BorderRadius = 5;
            this.textBox_交易記錄查詢_藥品名稱.BorderSize = 2;
            this.textBox_交易記錄查詢_藥品名稱.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.textBox_交易記錄查詢_藥品名稱.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_交易記錄查詢_藥品名稱.Location = new System.Drawing.Point(150, 75);
            this.textBox_交易記錄查詢_藥品名稱.Multiline = false;
            this.textBox_交易記錄查詢_藥品名稱.Name = "textBox_交易記錄查詢_藥品名稱";
            this.textBox_交易記錄查詢_藥品名稱.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_交易記錄查詢_藥品名稱.PassWordChar = false;
            this.textBox_交易記錄查詢_藥品名稱.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_交易記錄查詢_藥品名稱.PlaceholderText = "";
            this.textBox_交易記錄查詢_藥品名稱.ShowTouchPannel = false;
            this.textBox_交易記錄查詢_藥品名稱.Size = new System.Drawing.Size(135, 36);
            this.textBox_交易記錄查詢_藥品名稱.TabIndex = 47;
            this.textBox_交易記錄查詢_藥品名稱.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_交易記錄查詢_藥品名稱.Texts = "";
            this.textBox_交易記錄查詢_藥品名稱.UnderlineStyle = false;
            // 
            // textBox_交易記錄查詢_藥袋序號
            // 
            this.textBox_交易記錄查詢_藥袋序號.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_交易記錄查詢_藥袋序號.BorderColor = System.Drawing.Color.SkyBlue;
            this.textBox_交易記錄查詢_藥袋序號.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_交易記錄查詢_藥袋序號.BorderRadius = 5;
            this.textBox_交易記錄查詢_藥袋序號.BorderSize = 2;
            this.textBox_交易記錄查詢_藥袋序號.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.textBox_交易記錄查詢_藥袋序號.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_交易記錄查詢_藥袋序號.Location = new System.Drawing.Point(150, 185);
            this.textBox_交易記錄查詢_藥袋序號.Multiline = false;
            this.textBox_交易記錄查詢_藥袋序號.Name = "textBox_交易記錄查詢_藥袋序號";
            this.textBox_交易記錄查詢_藥袋序號.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_交易記錄查詢_藥袋序號.PassWordChar = false;
            this.textBox_交易記錄查詢_藥袋序號.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_交易記錄查詢_藥袋序號.PlaceholderText = "";
            this.textBox_交易記錄查詢_藥袋序號.ShowTouchPannel = false;
            this.textBox_交易記錄查詢_藥袋序號.Size = new System.Drawing.Size(135, 36);
            this.textBox_交易記錄查詢_藥袋序號.TabIndex = 51;
            this.textBox_交易記錄查詢_藥袋序號.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_交易記錄查詢_藥袋序號.Texts = "";
            this.textBox_交易記錄查詢_藥袋序號.UnderlineStyle = false;
            // 
            // textBox_交易記錄查詢_藥品條碼
            // 
            this.textBox_交易記錄查詢_藥品條碼.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_交易記錄查詢_藥品條碼.BorderColor = System.Drawing.Color.SkyBlue;
            this.textBox_交易記錄查詢_藥品條碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_交易記錄查詢_藥品條碼.BorderRadius = 5;
            this.textBox_交易記錄查詢_藥品條碼.BorderSize = 2;
            this.textBox_交易記錄查詢_藥品條碼.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.textBox_交易記錄查詢_藥品條碼.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_交易記錄查詢_藥品條碼.Location = new System.Drawing.Point(150, 130);
            this.textBox_交易記錄查詢_藥品條碼.Multiline = false;
            this.textBox_交易記錄查詢_藥品條碼.Name = "textBox_交易記錄查詢_藥品條碼";
            this.textBox_交易記錄查詢_藥品條碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_交易記錄查詢_藥品條碼.PassWordChar = false;
            this.textBox_交易記錄查詢_藥品條碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_交易記錄查詢_藥品條碼.PlaceholderText = "";
            this.textBox_交易記錄查詢_藥品條碼.ShowTouchPannel = false;
            this.textBox_交易記錄查詢_藥品條碼.Size = new System.Drawing.Size(135, 36);
            this.textBox_交易記錄查詢_藥品條碼.TabIndex = 49;
            this.textBox_交易記錄查詢_藥品條碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_交易記錄查詢_藥品條碼.Texts = "";
            this.textBox_交易記錄查詢_藥品條碼.UnderlineStyle = false;
            // 
            // rJ_Lable27
            // 
            this.rJ_Lable27.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable27.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable27.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable27.BorderRadius = 8;
            this.rJ_Lable27.BorderSize = 0;
            this.rJ_Lable27.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable27.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable27.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable27.Location = new System.Drawing.Point(20, 70);
            this.rJ_Lable27.Name = "rJ_Lable27";
            this.rJ_Lable27.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable27.TabIndex = 46;
            this.rJ_Lable27.Text = "藥品名稱";
            this.rJ_Lable27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable27.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Lable28
            // 
            this.rJ_Lable28.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable28.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable28.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable28.BorderRadius = 8;
            this.rJ_Lable28.BorderSize = 0;
            this.rJ_Lable28.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable28.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable28.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable28.Location = new System.Drawing.Point(20, 125);
            this.rJ_Lable28.Name = "rJ_Lable28";
            this.rJ_Lable28.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable28.TabIndex = 48;
            this.rJ_Lable28.Text = "藥品條碼";
            this.rJ_Lable28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable28.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Lable29
            // 
            this.rJ_Lable29.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable29.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable29.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable29.BorderRadius = 8;
            this.rJ_Lable29.BorderSize = 0;
            this.rJ_Lable29.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable29.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable29.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable29.Location = new System.Drawing.Point(20, 180);
            this.rJ_Lable29.Name = "rJ_Lable29";
            this.rJ_Lable29.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable29.TabIndex = 50;
            this.rJ_Lable29.Text = "藥袋序號";
            this.rJ_Lable29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable29.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_GroupBox6
            // 
            // 
            // rJ_GroupBox6.ContentsPanel
            // 
            this.rJ_GroupBox6.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox6.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox6.ContentsPanel.BorderRadius = 5;
            this.rJ_GroupBox6.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.label3);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.label123);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.label119);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.label115);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.label114);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.label113);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.label112);
            this.rJ_GroupBox6.ContentsPanel.Controls.Add(this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥);
            this.rJ_GroupBox6.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox6.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox6.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox6.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox6.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox6.ContentsPanel.Size = new System.Drawing.Size(402, 243);
            this.rJ_GroupBox6.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox6.Location = new System.Drawing.Point(17, 724);
            this.rJ_GroupBox6.Name = "rJ_GroupBox6";
            this.rJ_GroupBox6.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox6.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox6.PannelBorderRadius = 5;
            this.rJ_GroupBox6.PannelBorderSize = 2;
            this.rJ_GroupBox6.Size = new System.Drawing.Size(402, 280);
            this.rJ_GroupBox6.TabIndex = 166;
            this.rJ_GroupBox6.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox6.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox6.TitleBorderRadius = 5;
            this.rJ_GroupBox6.TitleBorderSize = 0;
            this.rJ_GroupBox6.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.rJ_GroupBox6.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox6.TitleHeight = 37;
            this.rJ_GroupBox6.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox6.TitleTexts = "動作條件選擇";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(268, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 15;
            this.label3.Text = "自動過帳";
            this.label3.Visible = false;
            // 
            // plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳
            // 
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.Bool = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.ForeColor = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.Location = new System.Drawing.Point(200, 15);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.MinimumSize = new System.Drawing.Size(45, 22);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.Name = "plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.OffBackColor = System.Drawing.Color.Gray;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.Size = new System.Drawing.Size(62, 29);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.SolidStyle = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.TabIndex = 14;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.UseVisualStyleBackColor = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.Visible = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.寫入元件位置 = "S4115";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.讀取元件位置 = "S4115";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.讀寫鎖住 = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳.音效 = true;
            // 
            // label123
            // 
            this.label123.AutoSize = true;
            this.label123.Font = new System.Drawing.Font("新細明體", 12F);
            this.label123.ForeColor = System.Drawing.Color.Black;
            this.label123.Location = new System.Drawing.Point(87, 53);
            this.label123.Name = "label123";
            this.label123.Size = new System.Drawing.Size(40, 16);
            this.label123.TabIndex = 13;
            this.label123.Text = "退藥";
            this.label123.Visible = false;
            // 
            // plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥
            // 
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.Bool = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.ForeColor = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.Location = new System.Drawing.Point(19, 47);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.MinimumSize = new System.Drawing.Size(45, 22);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.Name = "plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.OffBackColor = System.Drawing.Color.Gray;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.Size = new System.Drawing.Size(62, 29);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.SolidStyle = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.TabIndex = 12;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.UseVisualStyleBackColor = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.Visible = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.寫入元件位置 = "S4114";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.讀取元件位置 = "S4114";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.讀寫鎖住 = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥.音效 = true;
            // 
            // label119
            // 
            this.label119.AutoSize = true;
            this.label119.Font = new System.Drawing.Font("新細明體", 12F);
            this.label119.ForeColor = System.Drawing.Color.Black;
            this.label119.Location = new System.Drawing.Point(87, 184);
            this.label119.Name = "label119";
            this.label119.Size = new System.Drawing.Size(76, 16);
            this.label119.TabIndex = 11;
            this.label119.Text = "登入/登出";
            // 
            // lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出
            // 
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.Bool = false;
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.ForeColor = System.Drawing.Color.Black;
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.Location = new System.Drawing.Point(19, 178);
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.MinimumSize = new System.Drawing.Size(45, 22);
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.Name = "lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出";
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.OffBackColor = System.Drawing.Color.Gray;
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.Size = new System.Drawing.Size(62, 29);
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.SolidStyle = true;
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.TabIndex = 10;
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.UseVisualStyleBackColor = true;
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.寫入元件位置 = "S4120";
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.文字顏色 = System.Drawing.Color.Black;
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.讀取元件位置 = "S4120";
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.讀寫鎖住 = false;
            this.lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出.音效 = true;
            // 
            // label115
            // 
            this.label115.AutoSize = true;
            this.label115.Font = new System.Drawing.Font("新細明體", 12F);
            this.label115.ForeColor = System.Drawing.Color.Black;
            this.label115.Location = new System.Drawing.Point(87, 149);
            this.label115.Name = "label115";
            this.label115.Size = new System.Drawing.Size(72, 16);
            this.label115.TabIndex = 7;
            this.label115.Text = "後臺操作";
            // 
            // plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作
            // 
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.Bool = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.ForeColor = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.Location = new System.Drawing.Point(19, 143);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.MinimumSize = new System.Drawing.Size(45, 22);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.Name = "plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.OffBackColor = System.Drawing.Color.Gray;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.Size = new System.Drawing.Size(62, 29);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.SolidStyle = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.TabIndex = 6;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.UseVisualStyleBackColor = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.寫入元件位置 = "S4113";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.讀取元件位置 = "S4113";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.讀寫鎖住 = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作.音效 = true;
            // 
            // label114
            // 
            this.label114.AutoSize = true;
            this.label114.Font = new System.Drawing.Font("新細明體", 12F);
            this.label114.ForeColor = System.Drawing.Color.Black;
            this.label114.Location = new System.Drawing.Point(87, 117);
            this.label114.Name = "label114";
            this.label114.Size = new System.Drawing.Size(104, 16);
            this.label114.TabIndex = 5;
            this.label114.Text = "效期庫存異動";
            // 
            // plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動
            // 
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.Bool = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.ForeColor = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.Location = new System.Drawing.Point(19, 111);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.MinimumSize = new System.Drawing.Size(45, 22);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.Name = "plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.OffBackColor = System.Drawing.Color.Gray;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.Size = new System.Drawing.Size(62, 29);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.SolidStyle = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.TabIndex = 4;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.UseVisualStyleBackColor = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.寫入元件位置 = "S4112";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.讀取元件位置 = "S4112";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.讀寫鎖住 = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動.音效 = true;
            // 
            // label113
            // 
            this.label113.AutoSize = true;
            this.label113.Font = new System.Drawing.Font("新細明體", 12F);
            this.label113.ForeColor = System.Drawing.Color.Black;
            this.label113.Location = new System.Drawing.Point(87, 85);
            this.label113.Name = "label113";
            this.label113.Size = new System.Drawing.Size(40, 16);
            this.label113.TabIndex = 3;
            this.label113.Text = "入庫";
            this.label113.Visible = false;
            // 
            // plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫
            // 
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.Bool = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.ForeColor = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.Location = new System.Drawing.Point(19, 79);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.MinimumSize = new System.Drawing.Size(45, 22);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.Name = "plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.OffBackColor = System.Drawing.Color.Gray;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.Size = new System.Drawing.Size(62, 29);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.SolidStyle = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.TabIndex = 2;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.UseVisualStyleBackColor = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.Visible = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.寫入元件位置 = "S4111";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.讀取元件位置 = "S4111";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.讀寫鎖住 = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫.音效 = true;
            // 
            // label112
            // 
            this.label112.AutoSize = true;
            this.label112.Font = new System.Drawing.Font("新細明體", 12F);
            this.label112.ForeColor = System.Drawing.Color.Black;
            this.label112.Location = new System.Drawing.Point(87, 21);
            this.label112.Name = "label112";
            this.label112.Size = new System.Drawing.Size(40, 16);
            this.label112.TabIndex = 1;
            this.label112.Text = "領藥";
            // 
            // plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥
            // 
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.Bool = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.ForeColor = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.Location = new System.Drawing.Point(19, 15);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.MinimumSize = new System.Drawing.Size(45, 22);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.Name = "plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.OffBackColor = System.Drawing.Color.Gray;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.Size = new System.Drawing.Size(62, 29);
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.SolidStyle = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.TabIndex = 0;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.UseVisualStyleBackColor = true;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.寫入元件位置 = "S4110";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.讀取元件位置 = "S4110";
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.讀寫鎖住 = false;
            this.plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥.音效 = true;
            // 
            // sqL_DataGridView_交易記錄查詢
            // 
            this.sqL_DataGridView_交易記錄查詢.AutoSelectToDeep = true;
            this.sqL_DataGridView_交易記錄查詢.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_交易記錄查詢.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_交易記錄查詢.BorderRadius = 0;
            this.sqL_DataGridView_交易記錄查詢.BorderSize = 2;
            this.sqL_DataGridView_交易記錄查詢.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_交易記錄查詢.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_交易記錄查詢.cellStyleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_交易記錄查詢.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_交易記錄查詢.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_交易記錄查詢.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_交易記錄查詢.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_交易記錄查詢.columnHeadersHeight = 23;
            this.sqL_DataGridView_交易記錄查詢.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns1"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns2"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns3"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns4"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns5"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns6"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns7"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns8"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns9"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns10"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns11"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns12"))));
            this.sqL_DataGridView_交易記錄查詢.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_交易記錄查詢.Columns13"))));
            this.sqL_DataGridView_交易記錄查詢.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqL_DataGridView_交易記錄查詢.Font = new System.Drawing.Font("新細明體", 12F);
            this.sqL_DataGridView_交易記錄查詢.ImageBox = false;
            this.sqL_DataGridView_交易記錄查詢.Location = new System.Drawing.Point(0, 0);
            this.sqL_DataGridView_交易記錄查詢.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sqL_DataGridView_交易記錄查詢.Name = "sqL_DataGridView_交易記錄查詢";
            this.sqL_DataGridView_交易記錄查詢.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_交易記錄查詢.Password = "user82822040";
            this.sqL_DataGridView_交易記錄查詢.Port = ((uint)(3306u));
            this.sqL_DataGridView_交易記錄查詢.rowHeaderBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_交易記錄查詢.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_交易記錄查詢.RowsColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqL_DataGridView_交易記錄查詢.RowsHeight = 60;
            this.sqL_DataGridView_交易記錄查詢.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_交易記錄查詢.Server = "localhost";
            this.sqL_DataGridView_交易記錄查詢.Size = new System.Drawing.Size(1638, 688);
            this.sqL_DataGridView_交易記錄查詢.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_交易記錄查詢.TabIndex = 165;
            this.sqL_DataGridView_交易記錄查詢.TableName = "trading";
            this.sqL_DataGridView_交易記錄查詢.UserName = "root";
            this.sqL_DataGridView_交易記錄查詢.可拖曳欄位寬度 = true;
            this.sqL_DataGridView_交易記錄查詢.可選擇多列 = true;
            this.sqL_DataGridView_交易記錄查詢.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_交易記錄查詢.自動換行 = true;
            this.sqL_DataGridView_交易記錄查詢.表單字體 = new System.Drawing.Font("新細明體", 12F);
            this.sqL_DataGridView_交易記錄查詢.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_交易記錄查詢.顯示CheckBox = false;
            this.sqL_DataGridView_交易記錄查詢.顯示首列 = true;
            this.sqL_DataGridView_交易記錄查詢.顯示首行 = true;
            this.sqL_DataGridView_交易記錄查詢.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_交易記錄查詢.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // 醫囑資料
            // 
            this.醫囑資料.BackColor = System.Drawing.Color.White;
            this.醫囑資料.Controls.Add(this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼);
            this.醫囑資料.Controls.Add(this.plC_RJ_Button_醫囑資料_設為未過帳);
            this.醫囑資料.Controls.Add(this.plC_RJ_Button_醫囑資料_設定產出時間);
            this.醫囑資料.Controls.Add(this.plC_RJ_Button_醫囑資料_自動過帳);
            this.醫囑資料.Controls.Add(this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋);
            this.醫囑資料.Controls.Add(this.rJ_Lable119);
            this.醫囑資料.Controls.Add(this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼);
            this.醫囑資料.Controls.Add(this.rJ_Lable115);
            this.醫囑資料.Controls.Add(this.rJ_TextBox_醫囑資料_搜尋條件_病歷號);
            this.醫囑資料.Controls.Add(this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱);
            this.醫囑資料.Controls.Add(this.rJ_Lable114);
            this.醫囑資料.Controls.Add(this.rJ_Lable116);
            this.醫囑資料.Controls.Add(this.dateTimePicke_醫囑資料_開方日期_起始);
            this.醫囑資料.Controls.Add(this.label8);
            this.醫囑資料.Controls.Add(this.dateTimePicke_醫囑資料_開方日期_結束);
            this.醫囑資料.Controls.Add(this.rJ_Lable111);
            this.醫囑資料.Controls.Add(this.plC_RJ_Button_醫囑資料_顯示全部);
            this.醫囑資料.Controls.Add(this.sqL_DataGridView_醫囑資料);
            this.醫囑資料.Location = new System.Drawing.Point(4, 25);
            this.醫囑資料.Name = "醫囑資料";
            this.醫囑資料.Size = new System.Drawing.Size(1638, 986);
            this.醫囑資料.TabIndex = 6;
            this.醫囑資料.Text = "醫囑資料";
            // 
            // rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼
            // 
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.BorderRadius = 5;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.BorderSize = 2;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.Location = new System.Drawing.Point(516, 811);
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.Multiline = false;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.Name = "rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼";
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.PassWordChar = false;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.PlaceholderText = "";
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.ShowTouchPannel = false;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.Size = new System.Drawing.Size(215, 36);
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.TabIndex = 191;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.Texts = "";
            this.rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼.UnderlineStyle = false;
            // 
            // plC_RJ_Button_醫囑資料_設為未過帳
            // 
            this.plC_RJ_Button_醫囑資料_設為未過帳.AutoResetState = false;
            this.plC_RJ_Button_醫囑資料_設為未過帳.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_醫囑資料_設為未過帳.Bool = false;
            this.plC_RJ_Button_醫囑資料_設為未過帳.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_醫囑資料_設為未過帳.BorderRadius = 5;
            this.plC_RJ_Button_醫囑資料_設為未過帳.BorderSize = 0;
            this.plC_RJ_Button_醫囑資料_設為未過帳.but_press = false;
            this.plC_RJ_Button_醫囑資料_設為未過帳.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_醫囑資料_設為未過帳.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_醫囑資料_設為未過帳.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_醫囑資料_設為未過帳.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_醫囑資料_設為未過帳.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_醫囑資料_設為未過帳.Location = new System.Drawing.Point(1183, 949);
            this.plC_RJ_Button_醫囑資料_設為未過帳.Name = "plC_RJ_Button_醫囑資料_設為未過帳";
            this.plC_RJ_Button_醫囑資料_設為未過帳.OFF_文字內容 = "設為未過帳";
            this.plC_RJ_Button_醫囑資料_設為未過帳.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_醫囑資料_設為未過帳.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_醫囑資料_設為未過帳.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_醫囑資料_設為未過帳.ON_BorderSize = 5;
            this.plC_RJ_Button_醫囑資料_設為未過帳.ON_文字內容 = "設為未過帳";
            this.plC_RJ_Button_醫囑資料_設為未過帳.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_醫囑資料_設為未過帳.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_醫囑資料_設為未過帳.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_醫囑資料_設為未過帳.Size = new System.Drawing.Size(145, 58);
            this.plC_RJ_Button_醫囑資料_設為未過帳.State = false;
            this.plC_RJ_Button_醫囑資料_設為未過帳.TabIndex = 190;
            this.plC_RJ_Button_醫囑資料_設為未過帳.Text = "設為未過帳";
            this.plC_RJ_Button_醫囑資料_設為未過帳.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_醫囑資料_設為未過帳.Texts = "設為未過帳";
            this.plC_RJ_Button_醫囑資料_設為未過帳.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_醫囑資料_設為未過帳.字型鎖住 = false;
            this.plC_RJ_Button_醫囑資料_設為未過帳.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_醫囑資料_設為未過帳.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_醫囑資料_設為未過帳.文字鎖住 = false;
            this.plC_RJ_Button_醫囑資料_設為未過帳.致能讀取位置 = "S4077";
            this.plC_RJ_Button_醫囑資料_設為未過帳.讀取位元反向 = false;
            this.plC_RJ_Button_醫囑資料_設為未過帳.讀寫鎖住 = false;
            this.plC_RJ_Button_醫囑資料_設為未過帳.音效 = true;
            this.plC_RJ_Button_醫囑資料_設為未過帳.顯示 = false;
            this.plC_RJ_Button_醫囑資料_設為未過帳.顯示狀態 = false;
            this.plC_RJ_Button_醫囑資料_設為未過帳.顯示讀取位置 = "S4077";
            // 
            // plC_RJ_Button_醫囑資料_設定產出時間
            // 
            this.plC_RJ_Button_醫囑資料_設定產出時間.AutoResetState = false;
            this.plC_RJ_Button_醫囑資料_設定產出時間.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_醫囑資料_設定產出時間.Bool = false;
            this.plC_RJ_Button_醫囑資料_設定產出時間.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_醫囑資料_設定產出時間.BorderRadius = 5;
            this.plC_RJ_Button_醫囑資料_設定產出時間.BorderSize = 0;
            this.plC_RJ_Button_醫囑資料_設定產出時間.but_press = false;
            this.plC_RJ_Button_醫囑資料_設定產出時間.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_醫囑資料_設定產出時間.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_醫囑資料_設定產出時間.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_醫囑資料_設定產出時間.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_醫囑資料_設定產出時間.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_醫囑資料_設定產出時間.Location = new System.Drawing.Point(1334, 949);
            this.plC_RJ_Button_醫囑資料_設定產出時間.Name = "plC_RJ_Button_醫囑資料_設定產出時間";
            this.plC_RJ_Button_醫囑資料_設定產出時間.OFF_文字內容 = "設定產出時間";
            this.plC_RJ_Button_醫囑資料_設定產出時間.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_醫囑資料_設定產出時間.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_醫囑資料_設定產出時間.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_醫囑資料_設定產出時間.ON_BorderSize = 5;
            this.plC_RJ_Button_醫囑資料_設定產出時間.ON_文字內容 = "設定產出時間";
            this.plC_RJ_Button_醫囑資料_設定產出時間.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_醫囑資料_設定產出時間.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_醫囑資料_設定產出時間.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_醫囑資料_設定產出時間.Size = new System.Drawing.Size(145, 58);
            this.plC_RJ_Button_醫囑資料_設定產出時間.State = false;
            this.plC_RJ_Button_醫囑資料_設定產出時間.TabIndex = 189;
            this.plC_RJ_Button_醫囑資料_設定產出時間.Text = "設定產出時間";
            this.plC_RJ_Button_醫囑資料_設定產出時間.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_醫囑資料_設定產出時間.Texts = "設定產出時間";
            this.plC_RJ_Button_醫囑資料_設定產出時間.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_醫囑資料_設定產出時間.字型鎖住 = false;
            this.plC_RJ_Button_醫囑資料_設定產出時間.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_醫囑資料_設定產出時間.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_醫囑資料_設定產出時間.文字鎖住 = false;
            this.plC_RJ_Button_醫囑資料_設定產出時間.致能讀取位置 = "S4077";
            this.plC_RJ_Button_醫囑資料_設定產出時間.讀取位元反向 = false;
            this.plC_RJ_Button_醫囑資料_設定產出時間.讀寫鎖住 = false;
            this.plC_RJ_Button_醫囑資料_設定產出時間.音效 = true;
            this.plC_RJ_Button_醫囑資料_設定產出時間.顯示 = false;
            this.plC_RJ_Button_醫囑資料_設定產出時間.顯示狀態 = false;
            this.plC_RJ_Button_醫囑資料_設定產出時間.顯示讀取位置 = "S4077";
            // 
            // plC_RJ_Button_醫囑資料_自動過帳
            // 
            this.plC_RJ_Button_醫囑資料_自動過帳.AutoResetState = false;
            this.plC_RJ_Button_醫囑資料_自動過帳.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_醫囑資料_自動過帳.Bool = false;
            this.plC_RJ_Button_醫囑資料_自動過帳.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_醫囑資料_自動過帳.BorderRadius = 5;
            this.plC_RJ_Button_醫囑資料_自動過帳.BorderSize = 0;
            this.plC_RJ_Button_醫囑資料_自動過帳.but_press = false;
            this.plC_RJ_Button_醫囑資料_自動過帳.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_醫囑資料_自動過帳.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_醫囑資料_自動過帳.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_醫囑資料_自動過帳.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_醫囑資料_自動過帳.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_醫囑資料_自動過帳.Location = new System.Drawing.Point(1485, 949);
            this.plC_RJ_Button_醫囑資料_自動過帳.Name = "plC_RJ_Button_醫囑資料_自動過帳";
            this.plC_RJ_Button_醫囑資料_自動過帳.OFF_文字內容 = "自動過帳";
            this.plC_RJ_Button_醫囑資料_自動過帳.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_醫囑資料_自動過帳.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_醫囑資料_自動過帳.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_醫囑資料_自動過帳.ON_BorderSize = 5;
            this.plC_RJ_Button_醫囑資料_自動過帳.ON_文字內容 = "自動過帳";
            this.plC_RJ_Button_醫囑資料_自動過帳.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_醫囑資料_自動過帳.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_醫囑資料_自動過帳.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_醫囑資料_自動過帳.Size = new System.Drawing.Size(145, 58);
            this.plC_RJ_Button_醫囑資料_自動過帳.State = false;
            this.plC_RJ_Button_醫囑資料_自動過帳.TabIndex = 188;
            this.plC_RJ_Button_醫囑資料_自動過帳.Text = "自動過帳";
            this.plC_RJ_Button_醫囑資料_自動過帳.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_醫囑資料_自動過帳.Texts = "自動過帳";
            this.plC_RJ_Button_醫囑資料_自動過帳.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_醫囑資料_自動過帳.字型鎖住 = false;
            this.plC_RJ_Button_醫囑資料_自動過帳.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_醫囑資料_自動過帳.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_醫囑資料_自動過帳.文字鎖住 = false;
            this.plC_RJ_Button_醫囑資料_自動過帳.致能讀取位置 = "S4077";
            this.plC_RJ_Button_醫囑資料_自動過帳.讀取位元反向 = false;
            this.plC_RJ_Button_醫囑資料_自動過帳.讀寫鎖住 = false;
            this.plC_RJ_Button_醫囑資料_自動過帳.音效 = true;
            this.plC_RJ_Button_醫囑資料_自動過帳.顯示 = false;
            this.plC_RJ_Button_醫囑資料_自動過帳.顯示狀態 = false;
            this.plC_RJ_Button_醫囑資料_自動過帳.顯示讀取位置 = "S4077";
            // 
            // plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋
            // 
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.AutoResetState = false;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.Bool = false;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.BorderRadius = 5;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.BorderSize = 0;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.but_press = false;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.Location = new System.Drawing.Point(739, 806);
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.Name = "plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋";
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.OFF_文字內容 = "搜尋";
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.ON_BorderSize = 5;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.ON_文字內容 = "搜尋";
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.Size = new System.Drawing.Size(96, 46);
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.State = false;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.TabIndex = 187;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.Text = "搜尋";
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.Texts = "搜尋";
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.字型鎖住 = false;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.文字鎖住 = false;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.讀取位元反向 = false;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.讀寫鎖住 = false;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.音效 = true;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.顯示 = false;
            this.plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋.顯示狀態 = false;
            // 
            // rJ_Lable119
            // 
            this.rJ_Lable119.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable119.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable119.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable119.BorderRadius = 8;
            this.rJ_Lable119.BorderSize = 0;
            this.rJ_Lable119.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable119.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable119.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable119.Location = new System.Drawing.Point(388, 806);
            this.rJ_Lable119.Name = "rJ_Lable119";
            this.rJ_Lable119.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable119.TabIndex = 186;
            this.rJ_Lable119.Text = "藥袋條碼";
            this.rJ_Lable119.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable119.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_TextBox_醫囑資料_搜尋條件_藥品碼
            // 
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.BorderRadius = 5;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.BorderSize = 2;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.Location = new System.Drawing.Point(146, 811);
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.Multiline = false;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.Name = "rJ_TextBox_醫囑資料_搜尋條件_藥品碼";
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.PassWordChar = false;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.PlaceholderText = "";
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.ShowTouchPannel = false;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.Size = new System.Drawing.Size(215, 36);
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.TabIndex = 176;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.Texts = "";
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品碼.UnderlineStyle = false;
            // 
            // rJ_Lable115
            // 
            this.rJ_Lable115.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable115.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable115.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable115.BorderRadius = 8;
            this.rJ_Lable115.BorderSize = 0;
            this.rJ_Lable115.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable115.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable115.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable115.Location = new System.Drawing.Point(16, 806);
            this.rJ_Lable115.Name = "rJ_Lable115";
            this.rJ_Lable115.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable115.TabIndex = 175;
            this.rJ_Lable115.Text = "藥品碼";
            this.rJ_Lable115.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable115.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_TextBox_醫囑資料_搜尋條件_病歷號
            // 
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.BorderRadius = 5;
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.BorderSize = 2;
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.Location = new System.Drawing.Point(146, 920);
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.Multiline = false;
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.Name = "rJ_TextBox_醫囑資料_搜尋條件_病歷號";
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.PassWordChar = false;
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.PlaceholderText = "";
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.ShowTouchPannel = false;
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.Size = new System.Drawing.Size(215, 36);
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.TabIndex = 180;
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.Texts = "";
            this.rJ_TextBox_醫囑資料_搜尋條件_病歷號.UnderlineStyle = false;
            // 
            // rJ_TextBox_醫囑資料_搜尋條件_藥品名稱
            // 
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.BorderRadius = 5;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.BorderSize = 2;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.Font = new System.Drawing.Font("微軟正黑體", 12F);
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.Location = new System.Drawing.Point(146, 866);
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.Multiline = false;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.Name = "rJ_TextBox_醫囑資料_搜尋條件_藥品名稱";
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.PassWordChar = false;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.PlaceholderText = "";
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.ShowTouchPannel = false;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.Size = new System.Drawing.Size(215, 36);
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.TabIndex = 178;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.Texts = "";
            this.rJ_TextBox_醫囑資料_搜尋條件_藥品名稱.UnderlineStyle = false;
            // 
            // rJ_Lable114
            // 
            this.rJ_Lable114.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable114.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable114.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable114.BorderRadius = 8;
            this.rJ_Lable114.BorderSize = 0;
            this.rJ_Lable114.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable114.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable114.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable114.Location = new System.Drawing.Point(16, 915);
            this.rJ_Lable114.Name = "rJ_Lable114";
            this.rJ_Lable114.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable114.TabIndex = 179;
            this.rJ_Lable114.Text = "病歷號";
            this.rJ_Lable114.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable114.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Lable116
            // 
            this.rJ_Lable116.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable116.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable116.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable116.BorderRadius = 8;
            this.rJ_Lable116.BorderSize = 0;
            this.rJ_Lable116.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable116.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable116.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable116.Location = new System.Drawing.Point(16, 861);
            this.rJ_Lable116.Name = "rJ_Lable116";
            this.rJ_Lable116.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable116.TabIndex = 177;
            this.rJ_Lable116.Text = "藥品名稱";
            this.rJ_Lable116.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable116.TextColor = System.Drawing.Color.Black;
            // 
            // dateTimePicke_醫囑資料_開方日期_起始
            // 
            this.dateTimePicke_醫囑資料_開方日期_起始.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePicke_醫囑資料_開方日期_起始.BorderSize = 0;
            this.dateTimePicke_醫囑資料_開方日期_起始.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.dateTimePicke_醫囑資料_開方日期_起始.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicke_醫囑資料_開方日期_起始.Location = new System.Drawing.Point(1184, 813);
            this.dateTimePicke_醫囑資料_開方日期_起始.MinimumSize = new System.Drawing.Size(100, 35);
            this.dateTimePicke_醫囑資料_開方日期_起始.Name = "dateTimePicke_醫囑資料_開方日期_起始";
            this.dateTimePicke_醫囑資料_開方日期_起始.Size = new System.Drawing.Size(132, 35);
            this.dateTimePicke_醫囑資料_開方日期_起始.SkinColor = System.Drawing.Color.CornflowerBlue;
            this.dateTimePicke_醫囑資料_開方日期_起始.TabIndex = 183;
            this.dateTimePicke_醫囑資料_開方日期_起始.TextColor = System.Drawing.Color.White;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(1322, 824);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 12);
            this.label8.TabIndex = 184;
            this.label8.Text = "~";
            // 
            // dateTimePicke_醫囑資料_開方日期_結束
            // 
            this.dateTimePicke_醫囑資料_開方日期_結束.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.dateTimePicke_醫囑資料_開方日期_結束.BorderSize = 0;
            this.dateTimePicke_醫囑資料_開方日期_結束.Font = new System.Drawing.Font("新細明體", 15.75F);
            this.dateTimePicke_醫囑資料_開方日期_結束.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicke_醫囑資料_開方日期_結束.Location = new System.Drawing.Point(1339, 813);
            this.dateTimePicke_醫囑資料_開方日期_結束.MinimumSize = new System.Drawing.Size(100, 35);
            this.dateTimePicke_醫囑資料_開方日期_結束.Name = "dateTimePicke_醫囑資料_開方日期_結束";
            this.dateTimePicke_醫囑資料_開方日期_結束.Size = new System.Drawing.Size(131, 35);
            this.dateTimePicke_醫囑資料_開方日期_結束.SkinColor = System.Drawing.Color.CornflowerBlue;
            this.dateTimePicke_醫囑資料_開方日期_結束.TabIndex = 185;
            this.dateTimePicke_醫囑資料_開方日期_結束.TextColor = System.Drawing.Color.White;
            // 
            // rJ_Lable111
            // 
            this.rJ_Lable111.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable111.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable111.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable111.BorderRadius = 8;
            this.rJ_Lable111.BorderSize = 0;
            this.rJ_Lable111.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable111.Font = new System.Drawing.Font("新細明體", 12F);
            this.rJ_Lable111.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable111.Location = new System.Drawing.Point(1006, 807);
            this.rJ_Lable111.Name = "rJ_Lable111";
            this.rJ_Lable111.Size = new System.Drawing.Size(172, 46);
            this.rJ_Lable111.TabIndex = 182;
            this.rJ_Lable111.Text = "開方日期";
            this.rJ_Lable111.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable111.TextColor = System.Drawing.Color.Black;
            // 
            // plC_RJ_Button_醫囑資料_顯示全部
            // 
            this.plC_RJ_Button_醫囑資料_顯示全部.AutoResetState = false;
            this.plC_RJ_Button_醫囑資料_顯示全部.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_醫囑資料_顯示全部.Bool = false;
            this.plC_RJ_Button_醫囑資料_顯示全部.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_醫囑資料_顯示全部.BorderRadius = 5;
            this.plC_RJ_Button_醫囑資料_顯示全部.BorderSize = 0;
            this.plC_RJ_Button_醫囑資料_顯示全部.but_press = false;
            this.plC_RJ_Button_醫囑資料_顯示全部.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_醫囑資料_顯示全部.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_醫囑資料_顯示全部.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_醫囑資料_顯示全部.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_醫囑資料_顯示全部.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_醫囑資料_顯示全部.Location = new System.Drawing.Point(1485, 802);
            this.plC_RJ_Button_醫囑資料_顯示全部.Name = "plC_RJ_Button_醫囑資料_顯示全部";
            this.plC_RJ_Button_醫囑資料_顯示全部.OFF_文字內容 = "顯示全部";
            this.plC_RJ_Button_醫囑資料_顯示全部.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_醫囑資料_顯示全部.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_醫囑資料_顯示全部.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_醫囑資料_顯示全部.ON_BorderSize = 5;
            this.plC_RJ_Button_醫囑資料_顯示全部.ON_文字內容 = "顯示全部";
            this.plC_RJ_Button_醫囑資料_顯示全部.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_醫囑資料_顯示全部.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_醫囑資料_顯示全部.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_醫囑資料_顯示全部.Size = new System.Drawing.Size(145, 57);
            this.plC_RJ_Button_醫囑資料_顯示全部.State = false;
            this.plC_RJ_Button_醫囑資料_顯示全部.TabIndex = 181;
            this.plC_RJ_Button_醫囑資料_顯示全部.Text = "顯示全部";
            this.plC_RJ_Button_醫囑資料_顯示全部.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_醫囑資料_顯示全部.Texts = "顯示全部";
            this.plC_RJ_Button_醫囑資料_顯示全部.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_醫囑資料_顯示全部.字型鎖住 = false;
            this.plC_RJ_Button_醫囑資料_顯示全部.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_醫囑資料_顯示全部.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_醫囑資料_顯示全部.文字鎖住 = false;
            this.plC_RJ_Button_醫囑資料_顯示全部.讀取位元反向 = false;
            this.plC_RJ_Button_醫囑資料_顯示全部.讀寫鎖住 = false;
            this.plC_RJ_Button_醫囑資料_顯示全部.音效 = true;
            this.plC_RJ_Button_醫囑資料_顯示全部.顯示 = false;
            this.plC_RJ_Button_醫囑資料_顯示全部.顯示狀態 = false;
            // 
            // sqL_DataGridView_醫囑資料
            // 
            this.sqL_DataGridView_醫囑資料.AutoSelectToDeep = true;
            this.sqL_DataGridView_醫囑資料.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_醫囑資料.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_醫囑資料.BorderRadius = 0;
            this.sqL_DataGridView_醫囑資料.BorderSize = 2;
            this.sqL_DataGridView_醫囑資料.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_醫囑資料.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_醫囑資料.cellStyleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sqL_DataGridView_醫囑資料.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_醫囑資料.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_醫囑資料.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sqL_DataGridView_醫囑資料.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_醫囑資料.columnHeadersHeight = 44;
            this.sqL_DataGridView_醫囑資料.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns"))));
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns1"))));
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns2"))));
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns3"))));
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns4"))));
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns5"))));
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns6"))));
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns7"))));
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns8"))));
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns9"))));
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns10"))));
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns11"))));
            this.sqL_DataGridView_醫囑資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_醫囑資料.Columns12"))));
            this.sqL_DataGridView_醫囑資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqL_DataGridView_醫囑資料.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_醫囑資料.ImageBox = false;
            this.sqL_DataGridView_醫囑資料.Location = new System.Drawing.Point(0, 0);
            this.sqL_DataGridView_醫囑資料.Name = "sqL_DataGridView_醫囑資料";
            this.sqL_DataGridView_醫囑資料.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_醫囑資料.Password = "user82822040";
            this.sqL_DataGridView_醫囑資料.Port = ((uint)(3306u));
            this.sqL_DataGridView_醫囑資料.rowHeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.sqL_DataGridView_醫囑資料.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_醫囑資料.RowsColor = System.Drawing.Color.White;
            this.sqL_DataGridView_醫囑資料.RowsHeight = 60;
            this.sqL_DataGridView_醫囑資料.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_醫囑資料.Server = "127.0.0.0";
            this.sqL_DataGridView_醫囑資料.Size = new System.Drawing.Size(1638, 790);
            this.sqL_DataGridView_醫囑資料.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_醫囑資料.TabIndex = 174;
            this.sqL_DataGridView_醫囑資料.TableName = "order_list";
            this.sqL_DataGridView_醫囑資料.UserName = "root";
            this.sqL_DataGridView_醫囑資料.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_醫囑資料.可選擇多列 = true;
            this.sqL_DataGridView_醫囑資料.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_醫囑資料.自動換行 = true;
            this.sqL_DataGridView_醫囑資料.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_醫囑資料.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_醫囑資料.顯示CheckBox = false;
            this.sqL_DataGridView_醫囑資料.顯示首列 = true;
            this.sqL_DataGridView_醫囑資料.顯示首行 = true;
            this.sqL_DataGridView_醫囑資料.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_醫囑資料.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // 藥品資料
            // 
            this.藥品資料.BackColor = System.Drawing.Color.White;
            this.藥品資料.Controls.Add(this.plC_ScreenPage_藥品資料);
            this.藥品資料.Controls.Add(this.panel_藥品資料);
            this.藥品資料.Location = new System.Drawing.Point(4, 25);
            this.藥品資料.Name = "藥品資料";
            this.藥品資料.Size = new System.Drawing.Size(1638, 986);
            this.藥品資料.TabIndex = 7;
            this.藥品資料.Text = "藥品資料";
            // 
            // plC_ScreenPage_藥品資料
            // 
            this.plC_ScreenPage_藥品資料.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.plC_ScreenPage_藥品資料.BackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_藥品資料.Controls.Add(this.tabPage1);
            this.plC_ScreenPage_藥品資料.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plC_ScreenPage_藥品資料.ForekColor = System.Drawing.Color.Black;
            this.plC_ScreenPage_藥品資料.ItemSize = new System.Drawing.Size(54, 21);
            this.plC_ScreenPage_藥品資料.Location = new System.Drawing.Point(0, 51);
            this.plC_ScreenPage_藥品資料.Name = "plC_ScreenPage_藥品資料";
            this.plC_ScreenPage_藥品資料.SelectedIndex = 0;
            this.plC_ScreenPage_藥品資料.Size = new System.Drawing.Size(1638, 935);
            this.plC_ScreenPage_藥品資料.TabBackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_藥品資料.TabIndex = 119;
            this.plC_ScreenPage_藥品資料.顯示標籤列 = MyUI.PLC_ScreenPage.TabVisibleEnum.顯示;
            this.plC_ScreenPage_藥品資料.顯示頁面 = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.plC_RJ_GroupBox2);
            this.tabPage1.Controls.Add(this.rJ_GroupBox13);
            this.tabPage1.Controls.Add(this.rJ_GroupBox12);
            this.tabPage1.Controls.Add(this.sqL_DataGridView_藥品資料_藥檔資料);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1630, 906);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "藥檔資料";
            // 
            // plC_RJ_GroupBox2
            // 
            // 
            // plC_RJ_GroupBox2.ContentsPanel
            // 
            this.plC_RJ_GroupBox2.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.plC_RJ_GroupBox2.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_GroupBox2.ContentsPanel.BorderRadius = 0;
            this.plC_RJ_GroupBox2.ContentsPanel.BorderSize = 2;
            this.plC_RJ_GroupBox2.ContentsPanel.Controls.Add(this.sqL_DataGridView_藥品群組);
            this.plC_RJ_GroupBox2.ContentsPanel.Controls.Add(this.plC_RJ_Button_藥品群組_登錄);
            this.plC_RJ_GroupBox2.ContentsPanel.Controls.Add(this.panel2);
            this.plC_RJ_GroupBox2.ContentsPanel.Controls.Add(this.panel144);
            this.plC_RJ_GroupBox2.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plC_RJ_GroupBox2.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.plC_RJ_GroupBox2.ContentsPanel.IsSelected = false;
            this.plC_RJ_GroupBox2.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.plC_RJ_GroupBox2.ContentsPanel.Name = "ContentsPanel";
            this.plC_RJ_GroupBox2.ContentsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.plC_RJ_GroupBox2.ContentsPanel.Size = new System.Drawing.Size(651, 369);
            this.plC_RJ_GroupBox2.ContentsPanel.TabIndex = 2;
            this.plC_RJ_GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plC_RJ_GroupBox2.Location = new System.Drawing.Point(979, 500);
            this.plC_RJ_GroupBox2.Name = "plC_RJ_GroupBox2";
            this.plC_RJ_GroupBox2.PannelBackColor = System.Drawing.Color.White;
            this.plC_RJ_GroupBox2.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_GroupBox2.PannelBorderRadius = 0;
            this.plC_RJ_GroupBox2.PannelBorderSize = 2;
            this.plC_RJ_GroupBox2.Size = new System.Drawing.Size(651, 406);
            this.plC_RJ_GroupBox2.TabIndex = 132;
            this.plC_RJ_GroupBox2.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.plC_RJ_GroupBox2.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_GroupBox2.TitleBorderRadius = 5;
            this.plC_RJ_GroupBox2.TitleBorderSize = 0;
            this.plC_RJ_GroupBox2.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.plC_RJ_GroupBox2.TitleForeColor = System.Drawing.Color.White;
            this.plC_RJ_GroupBox2.TitleHeight = 37;
            this.plC_RJ_GroupBox2.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plC_RJ_GroupBox2.TitleTexts = "藥品群組";
            this.plC_RJ_GroupBox2.致能讀取位置 = "S39021";
            // 
            // sqL_DataGridView_藥品群組
            // 
            this.sqL_DataGridView_藥品群組.AutoSelectToDeep = false;
            this.sqL_DataGridView_藥品群組.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_藥品群組.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_藥品群組.BorderRadius = 0;
            this.sqL_DataGridView_藥品群組.BorderSize = 2;
            this.sqL_DataGridView_藥品群組.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_藥品群組.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_藥品群組.cellStyleFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sqL_DataGridView_藥品群組.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_藥品群組.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_藥品群組.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_藥品群組.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_藥品群組.columnHeadersHeight = 25;
            this.sqL_DataGridView_藥品群組.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.sqL_DataGridView_藥品群組.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品群組.Columns"))));
            this.sqL_DataGridView_藥品群組.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品群組.Columns1"))));
            this.sqL_DataGridView_藥品群組.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品群組.Columns2"))));
            this.sqL_DataGridView_藥品群組.Dock = System.Windows.Forms.DockStyle.Left;
            this.sqL_DataGridView_藥品群組.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_藥品群組.ImageBox = false;
            this.sqL_DataGridView_藥品群組.Location = new System.Drawing.Point(5, 5);
            this.sqL_DataGridView_藥品群組.Name = "sqL_DataGridView_藥品群組";
            this.sqL_DataGridView_藥品群組.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_藥品群組.Password = "user82822040";
            this.sqL_DataGridView_藥品群組.Port = ((uint)(3306u));
            this.sqL_DataGridView_藥品群組.rowHeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.sqL_DataGridView_藥品群組.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_藥品群組.RowsColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqL_DataGridView_藥品群組.RowsHeight = 30;
            this.sqL_DataGridView_藥品群組.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_藥品群組.Server = "127.0.0.0";
            this.sqL_DataGridView_藥品群組.Size = new System.Drawing.Size(308, 359);
            this.sqL_DataGridView_藥品群組.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_藥品群組.TabIndex = 138;
            this.sqL_DataGridView_藥品群組.TableName = "medicine_group";
            this.sqL_DataGridView_藥品群組.UserName = "root";
            this.sqL_DataGridView_藥品群組.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_藥品群組.可選擇多列 = false;
            this.sqL_DataGridView_藥品群組.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_藥品群組.自動換行 = true;
            this.sqL_DataGridView_藥品群組.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_藥品群組.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_藥品群組.顯示CheckBox = false;
            this.sqL_DataGridView_藥品群組.顯示首列 = false;
            this.sqL_DataGridView_藥品群組.顯示首行 = true;
            this.sqL_DataGridView_藥品群組.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_藥品群組.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // plC_RJ_Button_藥品群組_登錄
            // 
            this.plC_RJ_Button_藥品群組_登錄.AutoResetState = false;
            this.plC_RJ_Button_藥品群組_登錄.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_藥品群組_登錄.Bool = false;
            this.plC_RJ_Button_藥品群組_登錄.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥品群組_登錄.BorderRadius = 5;
            this.plC_RJ_Button_藥品群組_登錄.BorderSize = 0;
            this.plC_RJ_Button_藥品群組_登錄.but_press = false;
            this.plC_RJ_Button_藥品群組_登錄.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_藥品群組_登錄.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_藥品群組_登錄.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_藥品群組_登錄.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品群組_登錄.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_藥品群組_登錄.Location = new System.Drawing.Point(319, 99);
            this.plC_RJ_Button_藥品群組_登錄.Name = "plC_RJ_Button_藥品群組_登錄";
            this.plC_RJ_Button_藥品群組_登錄.OFF_文字內容 = "登錄";
            this.plC_RJ_Button_藥品群組_登錄.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品群組_登錄.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品群組_登錄.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品群組_登錄.ON_BorderSize = 5;
            this.plC_RJ_Button_藥品群組_登錄.ON_文字內容 = "登錄";
            this.plC_RJ_Button_藥品群組_登錄.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品群組_登錄.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_藥品群組_登錄.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品群組_登錄.Size = new System.Drawing.Size(75, 46);
            this.plC_RJ_Button_藥品群組_登錄.State = false;
            this.plC_RJ_Button_藥品群組_登錄.TabIndex = 137;
            this.plC_RJ_Button_藥品群組_登錄.Text = "登錄";
            this.plC_RJ_Button_藥品群組_登錄.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品群組_登錄.Texts = "登錄";
            this.plC_RJ_Button_藥品群組_登錄.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_藥品群組_登錄.字型鎖住 = false;
            this.plC_RJ_Button_藥品群組_登錄.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_藥品群組_登錄.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_藥品群組_登錄.文字鎖住 = false;
            this.plC_RJ_Button_藥品群組_登錄.致能讀取位置 = "S39021";
            this.plC_RJ_Button_藥品群組_登錄.讀取位元反向 = false;
            this.plC_RJ_Button_藥品群組_登錄.讀寫鎖住 = false;
            this.plC_RJ_Button_藥品群組_登錄.音效 = true;
            this.plC_RJ_Button_藥品群組_登錄.顯示 = false;
            this.plC_RJ_Button_藥品群組_登錄.顯示狀態 = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rJ_Lable1);
            this.panel2.Controls.Add(this.rJ_TextBox_藥品群組_群組序號);
            this.panel2.Location = new System.Drawing.Point(319, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(319, 41);
            this.panel2.TabIndex = 131;
            // 
            // rJ_Lable1
            // 
            this.rJ_Lable1.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable1.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable1.BorderRadius = 12;
            this.rJ_Lable1.BorderSize = 0;
            this.rJ_Lable1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable1.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable1.Location = new System.Drawing.Point(3, 0);
            this.rJ_Lable1.Name = "rJ_Lable1";
            this.rJ_Lable1.Size = new System.Drawing.Size(102, 40);
            this.rJ_Lable1.TabIndex = 122;
            this.rJ_Lable1.Text = "群組序號";
            this.rJ_Lable1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable1.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_TextBox_藥品群組_群組序號
            // 
            this.rJ_TextBox_藥品群組_群組序號.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_藥品群組_群組序號.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_TextBox_藥品群組_群組序號.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_藥品群組_群組序號.BorderRadius = 3;
            this.rJ_TextBox_藥品群組_群組序號.BorderSize = 2;
            this.rJ_TextBox_藥品群組_群組序號.Enabled = false;
            this.rJ_TextBox_藥品群組_群組序號.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_藥品群組_群組序號.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_藥品群組_群組序號.Location = new System.Drawing.Point(111, 5);
            this.rJ_TextBox_藥品群組_群組序號.Multiline = false;
            this.rJ_TextBox_藥品群組_群組序號.Name = "rJ_TextBox_藥品群組_群組序號";
            this.rJ_TextBox_藥品群組_群組序號.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_藥品群組_群組序號.PassWordChar = false;
            this.rJ_TextBox_藥品群組_群組序號.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_藥品群組_群組序號.PlaceholderText = "";
            this.rJ_TextBox_藥品群組_群組序號.ShowTouchPannel = false;
            this.rJ_TextBox_藥品群組_群組序號.Size = new System.Drawing.Size(66, 30);
            this.rJ_TextBox_藥品群組_群組序號.TabIndex = 121;
            this.rJ_TextBox_藥品群組_群組序號.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_藥品群組_群組序號.Texts = "";
            this.rJ_TextBox_藥品群組_群組序號.UnderlineStyle = false;
            // 
            // panel144
            // 
            this.panel144.Controls.Add(this.rJ_Lable2);
            this.panel144.Controls.Add(this.rJ_TextBox_藥品群組_群組名稱);
            this.panel144.Location = new System.Drawing.Point(319, 48);
            this.panel144.Name = "panel144";
            this.panel144.Size = new System.Drawing.Size(319, 41);
            this.panel144.TabIndex = 130;
            // 
            // rJ_Lable2
            // 
            this.rJ_Lable2.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable2.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable2.BorderRadius = 12;
            this.rJ_Lable2.BorderSize = 0;
            this.rJ_Lable2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable2.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable2.Location = new System.Drawing.Point(3, 0);
            this.rJ_Lable2.Name = "rJ_Lable2";
            this.rJ_Lable2.Size = new System.Drawing.Size(102, 40);
            this.rJ_Lable2.TabIndex = 122;
            this.rJ_Lable2.Text = "群組名稱";
            this.rJ_Lable2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable2.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_TextBox_藥品群組_群組名稱
            // 
            this.rJ_TextBox_藥品群組_群組名稱.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_藥品群組_群組名稱.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_TextBox_藥品群組_群組名稱.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_藥品群組_群組名稱.BorderRadius = 3;
            this.rJ_TextBox_藥品群組_群組名稱.BorderSize = 2;
            this.rJ_TextBox_藥品群組_群組名稱.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_藥品群組_群組名稱.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_藥品群組_群組名稱.Location = new System.Drawing.Point(111, 5);
            this.rJ_TextBox_藥品群組_群組名稱.Multiline = false;
            this.rJ_TextBox_藥品群組_群組名稱.Name = "rJ_TextBox_藥品群組_群組名稱";
            this.rJ_TextBox_藥品群組_群組名稱.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_藥品群組_群組名稱.PassWordChar = false;
            this.rJ_TextBox_藥品群組_群組名稱.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_藥品群組_群組名稱.PlaceholderText = "";
            this.rJ_TextBox_藥品群組_群組名稱.ShowTouchPannel = false;
            this.rJ_TextBox_藥品群組_群組名稱.Size = new System.Drawing.Size(117, 30);
            this.rJ_TextBox_藥品群組_群組名稱.TabIndex = 121;
            this.rJ_TextBox_藥品群組_群組名稱.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_藥品群組_群組名稱.Texts = "";
            this.rJ_TextBox_藥品群組_群組名稱.UnderlineStyle = false;
            // 
            // rJ_GroupBox13
            // 
            // 
            // rJ_GroupBox13.ContentsPanel
            // 
            this.rJ_GroupBox13.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox13.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox13.ContentsPanel.BorderRadius = 2;
            this.rJ_GroupBox13.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox13.ContentsPanel.Controls.Add(this.plC_RJ_Button_藥品資料_顯示有儲位藥品);
            this.rJ_GroupBox13.ContentsPanel.Controls.Add(this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢);
            this.rJ_GroupBox13.ContentsPanel.Controls.Add(this.plC_RJ_Button_藥品資料_匯出);
            this.rJ_GroupBox13.ContentsPanel.Controls.Add(this.plC_RJ_Button_藥品資料_匯入);
            this.rJ_GroupBox13.ContentsPanel.Controls.Add(this.rJ_Pannel5);
            this.rJ_GroupBox13.ContentsPanel.Controls.Add(this.rJ_Pannel4);
            this.rJ_GroupBox13.ContentsPanel.Controls.Add(this.rJ_Pannel3);
            this.rJ_GroupBox13.ContentsPanel.Controls.Add(this.rJ_Pannel2);
            this.rJ_GroupBox13.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox13.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox13.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox13.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox13.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox13.ContentsPanel.Size = new System.Drawing.Size(401, 369);
            this.rJ_GroupBox13.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox13.Dock = System.Windows.Forms.DockStyle.Left;
            this.rJ_GroupBox13.Location = new System.Drawing.Point(578, 500);
            this.rJ_GroupBox13.Name = "rJ_GroupBox13";
            this.rJ_GroupBox13.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox13.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox13.PannelBorderRadius = 2;
            this.rJ_GroupBox13.PannelBorderSize = 2;
            this.rJ_GroupBox13.Size = new System.Drawing.Size(401, 406);
            this.rJ_GroupBox13.TabIndex = 131;
            this.rJ_GroupBox13.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox13.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox13.TitleBorderRadius = 5;
            this.rJ_GroupBox13.TitleBorderSize = 0;
            this.rJ_GroupBox13.TitleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_GroupBox13.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox13.TitleHeight = 37;
            this.rJ_GroupBox13.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox13.TitleTexts = "藥櫃資料查詢";
            // 
            // plC_RJ_Button_藥品資料_顯示有儲位藥品
            // 
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.AutoResetState = false;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.Bool = false;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.BorderRadius = 5;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.but_press = false;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.Location = new System.Drawing.Point(168, 315);
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.Name = "plC_RJ_Button_藥品資料_顯示有儲位藥品";
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.OFF_文字內容 = "顯示\n[有儲位藥品]";
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.ON_BorderSize = 5;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.ON_文字內容 = "顯示\n[有儲位藥品]";
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.Size = new System.Drawing.Size(137, 67);
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.State = false;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.TabIndex = 138;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.Text = "顯示\n[有儲位藥品]";
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.Texts = "顯示\n[有儲位藥品]";
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.字型鎖住 = false;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.文字鎖住 = false;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.致能讀取位置 = "S39007";
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.讀取位元反向 = false;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.讀寫鎖住 = false;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.音效 = true;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.顯示 = false;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.顯示狀態 = false;
            // 
            // plC_RJ_Button_藥品資料_藥檔資料_資料查詢
            // 
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.AutoResetState = false;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.Bool = false;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.BorderRadius = 5;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.but_press = false;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.Location = new System.Drawing.Point(311, 315);
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.Name = "plC_RJ_Button_藥品資料_藥檔資料_資料查詢";
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.OFF_文字內容 = "搜尋";
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.ON_BorderSize = 5;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.ON_文字內容 = "搜尋";
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.Size = new System.Drawing.Size(84, 67);
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.State = false;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.TabIndex = 128;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.Text = "搜尋";
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.Texts = "搜尋";
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.字型鎖住 = false;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.文字鎖住 = false;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.讀取位元反向 = false;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.讀寫鎖住 = false;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.音效 = true;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.顯示 = false;
            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.顯示狀態 = false;
            // 
            // plC_RJ_Button_藥品資料_匯出
            // 
            this.plC_RJ_Button_藥品資料_匯出.AutoResetState = true;
            this.plC_RJ_Button_藥品資料_匯出.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_藥品資料_匯出.Bool = false;
            this.plC_RJ_Button_藥品資料_匯出.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥品資料_匯出.BorderRadius = 5;
            this.plC_RJ_Button_藥品資料_匯出.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_匯出.but_press = false;
            this.plC_RJ_Button_藥品資料_匯出.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_藥品資料_匯出.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_匯出.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_藥品資料_匯出.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_匯出.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_藥品資料_匯出.Location = new System.Drawing.Point(6, 315);
            this.plC_RJ_Button_藥品資料_匯出.Name = "plC_RJ_Button_藥品資料_匯出";
            this.plC_RJ_Button_藥品資料_匯出.OFF_文字內容 = "匯出";
            this.plC_RJ_Button_藥品資料_匯出.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_匯出.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_匯出.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_匯出.ON_BorderSize = 5;
            this.plC_RJ_Button_藥品資料_匯出.ON_文字內容 = "匯出";
            this.plC_RJ_Button_藥品資料_匯出.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_匯出.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_藥品資料_匯出.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_匯出.Size = new System.Drawing.Size(75, 67);
            this.plC_RJ_Button_藥品資料_匯出.State = false;
            this.plC_RJ_Button_藥品資料_匯出.TabIndex = 135;
            this.plC_RJ_Button_藥品資料_匯出.Text = "匯出";
            this.plC_RJ_Button_藥品資料_匯出.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_匯出.Texts = "匯出";
            this.plC_RJ_Button_藥品資料_匯出.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_藥品資料_匯出.字型鎖住 = false;
            this.plC_RJ_Button_藥品資料_匯出.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_藥品資料_匯出.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_藥品資料_匯出.文字鎖住 = false;
            this.plC_RJ_Button_藥品資料_匯出.致能讀取位置 = "S39007";
            this.plC_RJ_Button_藥品資料_匯出.讀取位元反向 = false;
            this.plC_RJ_Button_藥品資料_匯出.讀寫鎖住 = false;
            this.plC_RJ_Button_藥品資料_匯出.音效 = true;
            this.plC_RJ_Button_藥品資料_匯出.顯示 = false;
            this.plC_RJ_Button_藥品資料_匯出.顯示狀態 = false;
            // 
            // plC_RJ_Button_藥品資料_匯入
            // 
            this.plC_RJ_Button_藥品資料_匯入.AutoResetState = true;
            this.plC_RJ_Button_藥品資料_匯入.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_藥品資料_匯入.Bool = false;
            this.plC_RJ_Button_藥品資料_匯入.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥品資料_匯入.BorderRadius = 5;
            this.plC_RJ_Button_藥品資料_匯入.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_匯入.but_press = false;
            this.plC_RJ_Button_藥品資料_匯入.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_藥品資料_匯入.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_匯入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_藥品資料_匯入.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_匯入.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_藥品資料_匯入.Location = new System.Drawing.Point(87, 315);
            this.plC_RJ_Button_藥品資料_匯入.Name = "plC_RJ_Button_藥品資料_匯入";
            this.plC_RJ_Button_藥品資料_匯入.OFF_文字內容 = "匯入";
            this.plC_RJ_Button_藥品資料_匯入.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_匯入.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_匯入.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_匯入.ON_BorderSize = 5;
            this.plC_RJ_Button_藥品資料_匯入.ON_文字內容 = "匯入";
            this.plC_RJ_Button_藥品資料_匯入.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_匯入.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_藥品資料_匯入.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_匯入.Size = new System.Drawing.Size(75, 67);
            this.plC_RJ_Button_藥品資料_匯入.State = false;
            this.plC_RJ_Button_藥品資料_匯入.TabIndex = 134;
            this.plC_RJ_Button_藥品資料_匯入.Text = "匯入";
            this.plC_RJ_Button_藥品資料_匯入.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_匯入.Texts = "匯入";
            this.plC_RJ_Button_藥品資料_匯入.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_藥品資料_匯入.字型鎖住 = false;
            this.plC_RJ_Button_藥品資料_匯入.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_藥品資料_匯入.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_藥品資料_匯入.文字鎖住 = false;
            this.plC_RJ_Button_藥品資料_匯入.致能讀取位置 = "S39007";
            this.plC_RJ_Button_藥品資料_匯入.讀取位元反向 = false;
            this.plC_RJ_Button_藥品資料_匯入.讀寫鎖住 = false;
            this.plC_RJ_Button_藥品資料_匯入.音效 = true;
            this.plC_RJ_Button_藥品資料_匯入.顯示 = false;
            this.plC_RJ_Button_藥品資料_匯入.顯示狀態 = false;
            // 
            // rJ_Pannel5
            // 
            this.rJ_Pannel5.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel5.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_Pannel5.BorderRadius = 10;
            this.rJ_Pannel5.BorderSize = 2;
            this.rJ_Pannel5.Controls.Add(this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼);
            this.rJ_Pannel5.Controls.Add(this.rJ_Lable20);
            this.rJ_Pannel5.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel5.IsSelected = false;
            this.rJ_Pannel5.Location = new System.Drawing.Point(6, 198);
            this.rJ_Pannel5.Name = "rJ_Pannel5";
            this.rJ_Pannel5.Size = new System.Drawing.Size(384, 59);
            this.rJ_Pannel5.TabIndex = 113;
            // 
            // textBox_藥品資料_藥檔資料_資料查詢_藥品條碼
            // 
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.BorderRadius = 2;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.BorderSize = 1;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.Location = new System.Drawing.Point(148, 9);
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.Multiline = false;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.Name = "textBox_藥品資料_藥檔資料_資料查詢_藥品條碼";
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.PassWordChar = false;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.PlaceholderText = "";
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.ShowTouchPannel = false;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.Size = new System.Drawing.Size(217, 40);
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.TabIndex = 114;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.Texts = "";
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.UnderlineStyle = false;
            // 
            // rJ_Lable20
            // 
            this.rJ_Lable20.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable20.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable20.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable20.BorderRadius = 8;
            this.rJ_Lable20.BorderSize = 0;
            this.rJ_Lable20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable20.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable20.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable20.Location = new System.Drawing.Point(13, 6);
            this.rJ_Lable20.Name = "rJ_Lable20";
            this.rJ_Lable20.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable20.TabIndex = 2;
            this.rJ_Lable20.Text = "藥品條碼";
            this.rJ_Lable20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable20.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Pannel4
            // 
            this.rJ_Pannel4.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel4.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_Pannel4.BorderRadius = 10;
            this.rJ_Pannel4.BorderSize = 2;
            this.rJ_Pannel4.Controls.Add(this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組);
            this.rJ_Pannel4.Controls.Add(this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組);
            this.rJ_Pannel4.Controls.Add(this.rJ_Lable19);
            this.rJ_Pannel4.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel4.IsSelected = false;
            this.rJ_Pannel4.Location = new System.Drawing.Point(6, 135);
            this.rJ_Pannel4.Name = "rJ_Pannel4";
            this.rJ_Pannel4.Size = new System.Drawing.Size(384, 59);
            this.rJ_Pannel4.TabIndex = 112;
            // 
            // plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組
            // 
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.Bool = false;
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.ForeColor = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.Location = new System.Drawing.Point(329, 16);
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.MinimumSize = new System.Drawing.Size(45, 22);
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.Name = "plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組";
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.OffBackColor = System.Drawing.Color.Gray;
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.Size = new System.Drawing.Size(45, 24);
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.SolidStyle = true;
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.TabIndex = 125;
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.UseVisualStyleBackColor = true;
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.讀寫鎖住 = false;
            this.plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.音效 = true;
            // 
            // rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組
            // 
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.BorderSize = 1;
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.IconColor = System.Drawing.Color.RoyalBlue;
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.ListTextColor = System.Drawing.Color.DimGray;
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.Location = new System.Drawing.Point(149, 10);
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.MinimumSize = new System.Drawing.Size(50, 30);
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.Name = "rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組";
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.Padding = new System.Windows.Forms.Padding(1);
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.Size = new System.Drawing.Size(174, 38);
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.TabIndex = 116;
            this.rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.Texts = "";
            // 
            // rJ_Lable19
            // 
            this.rJ_Lable19.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable19.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable19.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable19.BorderRadius = 8;
            this.rJ_Lable19.BorderSize = 0;
            this.rJ_Lable19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable19.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable19.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable19.Location = new System.Drawing.Point(13, 6);
            this.rJ_Lable19.Name = "rJ_Lable19";
            this.rJ_Lable19.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable19.TabIndex = 2;
            this.rJ_Lable19.Text = "藥品群組";
            this.rJ_Lable19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable19.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Pannel3
            // 
            this.rJ_Pannel3.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel3.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_Pannel3.BorderRadius = 10;
            this.rJ_Pannel3.BorderSize = 2;
            this.rJ_Pannel3.Controls.Add(this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱);
            this.rJ_Pannel3.Controls.Add(this.rJ_Lable18);
            this.rJ_Pannel3.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel3.IsSelected = false;
            this.rJ_Pannel3.Location = new System.Drawing.Point(6, 72);
            this.rJ_Pannel3.Name = "rJ_Pannel3";
            this.rJ_Pannel3.Size = new System.Drawing.Size(384, 59);
            this.rJ_Pannel3.TabIndex = 111;
            // 
            // textBox_藥品資料_藥檔資料_資料查詢_藥品名稱
            // 
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.BorderRadius = 2;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.BorderSize = 1;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.Location = new System.Drawing.Point(149, 9);
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.Multiline = false;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.Name = "textBox_藥品資料_藥檔資料_資料查詢_藥品名稱";
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.PassWordChar = false;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.PlaceholderText = "";
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.ShowTouchPannel = false;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.Size = new System.Drawing.Size(217, 40);
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.TabIndex = 5;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.Texts = "";
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.UnderlineStyle = false;
            // 
            // rJ_Lable18
            // 
            this.rJ_Lable18.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable18.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable18.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable18.BorderRadius = 8;
            this.rJ_Lable18.BorderSize = 0;
            this.rJ_Lable18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable18.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable18.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable18.Location = new System.Drawing.Point(13, 6);
            this.rJ_Lable18.Name = "rJ_Lable18";
            this.rJ_Lable18.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable18.TabIndex = 2;
            this.rJ_Lable18.Text = "藥名";
            this.rJ_Lable18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable18.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Pannel2
            // 
            this.rJ_Pannel2.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel2.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_Pannel2.BorderRadius = 10;
            this.rJ_Pannel2.BorderSize = 2;
            this.rJ_Pannel2.Controls.Add(this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼);
            this.rJ_Pannel2.Controls.Add(this.rJ_Lable17);
            this.rJ_Pannel2.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel2.IsSelected = false;
            this.rJ_Pannel2.Location = new System.Drawing.Point(6, 7);
            this.rJ_Pannel2.Name = "rJ_Pannel2";
            this.rJ_Pannel2.Size = new System.Drawing.Size(384, 59);
            this.rJ_Pannel2.TabIndex = 110;
            // 
            // textBox_藥品資料_藥檔資料_資料查詢_藥品碼
            // 
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.BorderRadius = 2;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.BorderSize = 1;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.ForeColor = System.Drawing.Color.DimGray;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.Location = new System.Drawing.Point(149, 9);
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.Multiline = false;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.Name = "textBox_藥品資料_藥檔資料_資料查詢_藥品碼";
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.PassWordChar = false;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.PlaceholderText = "";
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.ShowTouchPannel = false;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.Size = new System.Drawing.Size(217, 40);
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.TabIndex = 3;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.Texts = "";
            this.textBox_藥品資料_藥檔資料_資料查詢_藥品碼.UnderlineStyle = false;
            // 
            // rJ_Lable17
            // 
            this.rJ_Lable17.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable17.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable17.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable17.BorderRadius = 8;
            this.rJ_Lable17.BorderSize = 0;
            this.rJ_Lable17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable17.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable17.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable17.Location = new System.Drawing.Point(13, 6);
            this.rJ_Lable17.Name = "rJ_Lable17";
            this.rJ_Lable17.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable17.TabIndex = 2;
            this.rJ_Lable17.Text = "藥碼";
            this.rJ_Lable17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable17.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_GroupBox12
            // 
            // 
            // rJ_GroupBox12.ContentsPanel
            // 
            this.rJ_GroupBox12.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox12.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox12.ContentsPanel.BorderRadius = 2;
            this.rJ_GroupBox12.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox12.ContentsPanel.Controls.Add(this.plC_RJ_Button_藥品資料_HIS下載全部藥檔);
            this.rJ_GroupBox12.ContentsPanel.Controls.Add(this.plC_RJ_Button_藥品資料_HIS填入);
            this.rJ_GroupBox12.ContentsPanel.Controls.Add(this.plC_RJ_Button_藥品資料_刪除);
            this.rJ_GroupBox12.ContentsPanel.Controls.Add(this.plC_RJ_Button_藥品資料_更新藥櫃資料);
            this.rJ_GroupBox12.ContentsPanel.Controls.Add(this.panel17);
            this.rJ_GroupBox12.ContentsPanel.Controls.Add(this.plC_RJ_Button_藥品資料_登錄);
            this.rJ_GroupBox12.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox12.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox12.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox12.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox12.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox12.ContentsPanel.Padding = new System.Windows.Forms.Padding(3);
            this.rJ_GroupBox12.ContentsPanel.Size = new System.Drawing.Size(578, 369);
            this.rJ_GroupBox12.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox12.Dock = System.Windows.Forms.DockStyle.Left;
            this.rJ_GroupBox12.Location = new System.Drawing.Point(0, 500);
            this.rJ_GroupBox12.Name = "rJ_GroupBox12";
            this.rJ_GroupBox12.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox12.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox12.PannelBorderRadius = 2;
            this.rJ_GroupBox12.PannelBorderSize = 2;
            this.rJ_GroupBox12.Size = new System.Drawing.Size(578, 406);
            this.rJ_GroupBox12.TabIndex = 130;
            this.rJ_GroupBox12.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox12.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox12.TitleBorderRadius = 5;
            this.rJ_GroupBox12.TitleBorderSize = 0;
            this.rJ_GroupBox12.TitleFont = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_GroupBox12.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox12.TitleHeight = 37;
            this.rJ_GroupBox12.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox12.TitleTexts = "建檔資料";
            // 
            // plC_RJ_Button_藥品資料_HIS下載全部藥檔
            // 
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.AutoResetState = false;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.Bool = false;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.BorderRadius = 5;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.but_press = false;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.Location = new System.Drawing.Point(388, 330);
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.Name = "plC_RJ_Button_藥品資料_HIS下載全部藥檔";
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.OFF_文字內容 = "HIS下載全部藥檔";
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.ON_BorderSize = 5;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.ON_文字內容 = "HIS下載全部藥檔";
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.Size = new System.Drawing.Size(103, 52);
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.State = false;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.TabIndex = 139;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.Text = "HIS下載全部藥檔";
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.Texts = "HIS下載全部藥檔";
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.字型鎖住 = false;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.文字鎖住 = false;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.讀取位元反向 = false;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.讀寫鎖住 = false;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.音效 = true;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.顯示 = false;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.顯示狀態 = false;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.顯示讀取位置 = "S4077";
            // 
            // plC_RJ_Button_藥品資料_HIS填入
            // 
            this.plC_RJ_Button_藥品資料_HIS填入.AutoResetState = false;
            this.plC_RJ_Button_藥品資料_HIS填入.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_藥品資料_HIS填入.Bool = false;
            this.plC_RJ_Button_藥品資料_HIS填入.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥品資料_HIS填入.BorderRadius = 5;
            this.plC_RJ_Button_藥品資料_HIS填入.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_HIS填入.but_press = false;
            this.plC_RJ_Button_藥品資料_HIS填入.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_藥品資料_HIS填入.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_HIS填入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_藥品資料_HIS填入.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_藥品資料_HIS填入.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_藥品資料_HIS填入.Location = new System.Drawing.Point(9, 330);
            this.plC_RJ_Button_藥品資料_HIS填入.Name = "plC_RJ_Button_藥品資料_HIS填入";
            this.plC_RJ_Button_藥品資料_HIS填入.OFF_文字內容 = "HIS資料填入";
            this.plC_RJ_Button_藥品資料_HIS填入.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_藥品資料_HIS填入.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_HIS填入.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_HIS填入.ON_BorderSize = 5;
            this.plC_RJ_Button_藥品資料_HIS填入.ON_文字內容 = "HIS資料填入";
            this.plC_RJ_Button_藥品資料_HIS填入.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_藥品資料_HIS填入.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_藥品資料_HIS填入.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_HIS填入.Size = new System.Drawing.Size(132, 52);
            this.plC_RJ_Button_藥品資料_HIS填入.State = false;
            this.plC_RJ_Button_藥品資料_HIS填入.TabIndex = 139;
            this.plC_RJ_Button_藥品資料_HIS填入.Text = "HIS資料填入";
            this.plC_RJ_Button_藥品資料_HIS填入.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_HIS填入.Texts = "HIS資料填入";
            this.plC_RJ_Button_藥品資料_HIS填入.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_藥品資料_HIS填入.字型鎖住 = false;
            this.plC_RJ_Button_藥品資料_HIS填入.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_藥品資料_HIS填入.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_藥品資料_HIS填入.文字鎖住 = false;
            this.plC_RJ_Button_藥品資料_HIS填入.讀取位元反向 = false;
            this.plC_RJ_Button_藥品資料_HIS填入.讀寫鎖住 = false;
            this.plC_RJ_Button_藥品資料_HIS填入.音效 = true;
            this.plC_RJ_Button_藥品資料_HIS填入.顯示 = false;
            this.plC_RJ_Button_藥品資料_HIS填入.顯示狀態 = false;
            // 
            // plC_RJ_Button_藥品資料_刪除
            // 
            this.plC_RJ_Button_藥品資料_刪除.AutoResetState = false;
            this.plC_RJ_Button_藥品資料_刪除.BackgroundColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥品資料_刪除.Bool = false;
            this.plC_RJ_Button_藥品資料_刪除.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥品資料_刪除.BorderRadius = 5;
            this.plC_RJ_Button_藥品資料_刪除.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_刪除.but_press = false;
            this.plC_RJ_Button_藥品資料_刪除.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_藥品資料_刪除.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_刪除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_藥品資料_刪除.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_刪除.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_藥品資料_刪除.Location = new System.Drawing.Point(497, 330);
            this.plC_RJ_Button_藥品資料_刪除.Name = "plC_RJ_Button_藥品資料_刪除";
            this.plC_RJ_Button_藥品資料_刪除.OFF_文字內容 = "刪除";
            this.plC_RJ_Button_藥品資料_刪除.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_刪除.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_刪除.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_刪除.ON_BorderSize = 5;
            this.plC_RJ_Button_藥品資料_刪除.ON_文字內容 = "刪除";
            this.plC_RJ_Button_藥品資料_刪除.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_刪除.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_藥品資料_刪除.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_刪除.Size = new System.Drawing.Size(75, 52);
            this.plC_RJ_Button_藥品資料_刪除.State = false;
            this.plC_RJ_Button_藥品資料_刪除.TabIndex = 137;
            this.plC_RJ_Button_藥品資料_刪除.Text = "刪除";
            this.plC_RJ_Button_藥品資料_刪除.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_刪除.Texts = "刪除";
            this.plC_RJ_Button_藥品資料_刪除.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_藥品資料_刪除.字型鎖住 = false;
            this.plC_RJ_Button_藥品資料_刪除.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_藥品資料_刪除.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_藥品資料_刪除.文字鎖住 = false;
            this.plC_RJ_Button_藥品資料_刪除.致能讀取位置 = "S39007";
            this.plC_RJ_Button_藥品資料_刪除.讀取位元反向 = false;
            this.plC_RJ_Button_藥品資料_刪除.讀寫鎖住 = false;
            this.plC_RJ_Button_藥品資料_刪除.音效 = true;
            this.plC_RJ_Button_藥品資料_刪除.顯示 = false;
            this.plC_RJ_Button_藥品資料_刪除.顯示狀態 = false;
            // 
            // plC_RJ_Button_藥品資料_更新藥櫃資料
            // 
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.AutoResetState = false;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.Bool = false;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.BorderRadius = 5;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.but_press = false;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.Location = new System.Drawing.Point(147, 330);
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.Name = "plC_RJ_Button_藥品資料_更新藥櫃資料";
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.OFF_文字內容 = "更新藥櫃資料";
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.ON_BorderSize = 5;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.ON_文字內容 = "更新藥櫃資料";
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.Size = new System.Drawing.Size(154, 52);
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.State = false;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.TabIndex = 130;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.Text = "更新藥櫃資料";
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.Texts = "更新藥櫃資料";
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.字型鎖住 = false;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.文字鎖住 = false;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.讀取位元反向 = false;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.讀寫鎖住 = false;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.音效 = true;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.顯示 = false;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.顯示狀態 = false;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.panel71);
            this.panel17.Controls.Add(this.panel69);
            this.panel17.Controls.Add(this.panel64);
            this.panel17.Controls.Add(this.panel67);
            this.panel17.Controls.Add(this.panel60);
            this.panel17.Controls.Add(this.panel58);
            this.panel17.Controls.Add(this.panel56);
            this.panel17.Controls.Add(this.panel54);
            this.panel17.Controls.Add(this.panel52);
            this.panel17.Controls.Add(this.panel50);
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel17.Location = new System.Drawing.Point(3, 3);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(572, 321);
            this.panel17.TabIndex = 129;
            // 
            // panel71
            // 
            this.panel71.Controls.Add(this.comboBox_藥品資料_藥檔資料_警訊藥品);
            this.panel71.Controls.Add(this.panel72);
            this.panel71.Controls.Add(this.label25);
            this.panel71.Location = new System.Drawing.Point(246, 277);
            this.panel71.Name = "panel71";
            this.panel71.Size = new System.Drawing.Size(237, 36);
            this.panel71.TabIndex = 10;
            // 
            // comboBox_藥品資料_藥檔資料_警訊藥品
            // 
            this.comboBox_藥品資料_藥檔資料_警訊藥品.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_藥品資料_藥檔資料_警訊藥品.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.comboBox_藥品資料_藥檔資料_警訊藥品.BorderSize = 1;
            this.comboBox_藥品資料_藥檔資料_警訊藥品.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBox_藥品資料_藥檔資料_警訊藥品.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBox_藥品資料_藥檔資料_警訊藥品.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_藥品資料_藥檔資料_警訊藥品.IconColor = System.Drawing.Color.RoyalBlue;
            this.comboBox_藥品資料_藥檔資料_警訊藥品.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBox_藥品資料_藥檔資料_警訊藥品.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBox_藥品資料_藥檔資料_警訊藥品.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBox_藥品資料_藥檔資料_警訊藥品.Location = new System.Drawing.Point(122, 0);
            this.comboBox_藥品資料_藥檔資料_警訊藥品.MinimumSize = new System.Drawing.Size(50, 30);
            this.comboBox_藥品資料_藥檔資料_警訊藥品.Name = "comboBox_藥品資料_藥檔資料_警訊藥品";
            this.comboBox_藥品資料_藥檔資料_警訊藥品.Padding = new System.Windows.Forms.Padding(1);
            this.comboBox_藥品資料_藥檔資料_警訊藥品.Size = new System.Drawing.Size(115, 36);
            this.comboBox_藥品資料_藥檔資料_警訊藥品.TabIndex = 109;
            this.comboBox_藥品資料_藥檔資料_警訊藥品.Texts = "";
            // 
            // panel72
            // 
            this.panel72.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel72.Location = new System.Drawing.Point(112, 0);
            this.panel72.Name = "panel72";
            this.panel72.Size = new System.Drawing.Size(10, 36);
            this.panel72.TabIndex = 1;
            // 
            // label25
            // 
            this.label25.BackColor = System.Drawing.Color.LightCyan;
            this.label25.Dock = System.Windows.Forms.DockStyle.Left;
            this.label25.Font = new System.Drawing.Font("新細明體", 12F);
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(0, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(112, 36);
            this.label25.TabIndex = 0;
            this.label25.Text = "警訊藥品";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel69
            // 
            this.panel69.Controls.Add(this.textBox_藥品資料_藥檔資料_安全庫存);
            this.panel69.Controls.Add(this.panel70);
            this.panel69.Controls.Add(this.label24);
            this.panel69.Location = new System.Drawing.Point(3, 277);
            this.panel69.Name = "panel69";
            this.panel69.Size = new System.Drawing.Size(237, 36);
            this.panel69.TabIndex = 9;
            // 
            // textBox_藥品資料_藥檔資料_安全庫存
            // 
            this.textBox_藥品資料_藥檔資料_安全庫存.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_藥品資料_藥檔資料_安全庫存.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_藥品資料_藥檔資料_安全庫存.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_藥品資料_藥檔資料_安全庫存.BorderRadius = 2;
            this.textBox_藥品資料_藥檔資料_安全庫存.BorderSize = 1;
            this.textBox_藥品資料_藥檔資料_安全庫存.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_藥品資料_藥檔資料_安全庫存.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_藥品資料_藥檔資料_安全庫存.ForeColor = System.Drawing.Color.Black;
            this.textBox_藥品資料_藥檔資料_安全庫存.Location = new System.Drawing.Point(122, 0);
            this.textBox_藥品資料_藥檔資料_安全庫存.Multiline = false;
            this.textBox_藥品資料_藥檔資料_安全庫存.Name = "textBox_藥品資料_藥檔資料_安全庫存";
            this.textBox_藥品資料_藥檔資料_安全庫存.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_藥品資料_藥檔資料_安全庫存.PassWordChar = false;
            this.textBox_藥品資料_藥檔資料_安全庫存.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_藥品資料_藥檔資料_安全庫存.PlaceholderText = "";
            this.textBox_藥品資料_藥檔資料_安全庫存.ShowTouchPannel = false;
            this.textBox_藥品資料_藥檔資料_安全庫存.Size = new System.Drawing.Size(115, 34);
            this.textBox_藥品資料_藥檔資料_安全庫存.TabIndex = 115;
            this.textBox_藥品資料_藥檔資料_安全庫存.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_藥品資料_藥檔資料_安全庫存.Texts = "";
            this.textBox_藥品資料_藥檔資料_安全庫存.UnderlineStyle = false;
            // 
            // panel70
            // 
            this.panel70.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel70.Location = new System.Drawing.Point(112, 0);
            this.panel70.Name = "panel70";
            this.panel70.Size = new System.Drawing.Size(10, 36);
            this.panel70.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.LightCyan;
            this.label24.Dock = System.Windows.Forms.DockStyle.Left;
            this.label24.Font = new System.Drawing.Font("新細明體", 12F);
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(0, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(112, 36);
            this.label24.TabIndex = 0;
            this.label24.Text = "安全庫存";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel64
            // 
            this.panel64.Controls.Add(this.textBox_藥品資料_藥檔資料_庫存);
            this.panel64.Controls.Add(this.panel65);
            this.panel64.Controls.Add(this.label22);
            this.panel64.Location = new System.Drawing.Point(246, 238);
            this.panel64.Name = "panel64";
            this.panel64.Size = new System.Drawing.Size(237, 36);
            this.panel64.TabIndex = 8;
            // 
            // textBox_藥品資料_藥檔資料_庫存
            // 
            this.textBox_藥品資料_藥檔資料_庫存.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_藥品資料_藥檔資料_庫存.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_藥品資料_藥檔資料_庫存.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_藥品資料_藥檔資料_庫存.BorderRadius = 2;
            this.textBox_藥品資料_藥檔資料_庫存.BorderSize = 1;
            this.textBox_藥品資料_藥檔資料_庫存.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_藥品資料_藥檔資料_庫存.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_藥品資料_藥檔資料_庫存.ForeColor = System.Drawing.Color.Black;
            this.textBox_藥品資料_藥檔資料_庫存.Location = new System.Drawing.Point(122, 0);
            this.textBox_藥品資料_藥檔資料_庫存.Multiline = false;
            this.textBox_藥品資料_藥檔資料_庫存.Name = "textBox_藥品資料_藥檔資料_庫存";
            this.textBox_藥品資料_藥檔資料_庫存.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_藥品資料_藥檔資料_庫存.PassWordChar = false;
            this.textBox_藥品資料_藥檔資料_庫存.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_藥品資料_藥檔資料_庫存.PlaceholderText = "";
            this.textBox_藥品資料_藥檔資料_庫存.ShowTouchPannel = false;
            this.textBox_藥品資料_藥檔資料_庫存.Size = new System.Drawing.Size(115, 34);
            this.textBox_藥品資料_藥檔資料_庫存.TabIndex = 114;
            this.textBox_藥品資料_藥檔資料_庫存.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_藥品資料_藥檔資料_庫存.Texts = "";
            this.textBox_藥品資料_藥檔資料_庫存.UnderlineStyle = false;
            // 
            // panel65
            // 
            this.panel65.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel65.Location = new System.Drawing.Point(112, 0);
            this.panel65.Name = "panel65";
            this.panel65.Size = new System.Drawing.Size(10, 36);
            this.panel65.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.LightCyan;
            this.label22.Dock = System.Windows.Forms.DockStyle.Left;
            this.label22.Font = new System.Drawing.Font("新細明體", 12F);
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(0, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(112, 36);
            this.label22.TabIndex = 0;
            this.label22.Text = "庫存";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel67
            // 
            this.panel67.Controls.Add(this.textBox_藥品資料_藥檔資料_包裝單位);
            this.panel67.Controls.Add(this.panel68);
            this.panel67.Controls.Add(this.label23);
            this.panel67.Location = new System.Drawing.Point(3, 238);
            this.panel67.Name = "panel67";
            this.panel67.Size = new System.Drawing.Size(237, 36);
            this.panel67.TabIndex = 7;
            // 
            // textBox_藥品資料_藥檔資料_包裝單位
            // 
            this.textBox_藥品資料_藥檔資料_包裝單位.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_藥品資料_藥檔資料_包裝單位.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_藥品資料_藥檔資料_包裝單位.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_藥品資料_藥檔資料_包裝單位.BorderRadius = 2;
            this.textBox_藥品資料_藥檔資料_包裝單位.BorderSize = 1;
            this.textBox_藥品資料_藥檔資料_包裝單位.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_藥品資料_藥檔資料_包裝單位.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_藥品資料_藥檔資料_包裝單位.ForeColor = System.Drawing.Color.Black;
            this.textBox_藥品資料_藥檔資料_包裝單位.Location = new System.Drawing.Point(122, 0);
            this.textBox_藥品資料_藥檔資料_包裝單位.Multiline = false;
            this.textBox_藥品資料_藥檔資料_包裝單位.Name = "textBox_藥品資料_藥檔資料_包裝單位";
            this.textBox_藥品資料_藥檔資料_包裝單位.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_藥品資料_藥檔資料_包裝單位.PassWordChar = false;
            this.textBox_藥品資料_藥檔資料_包裝單位.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_藥品資料_藥檔資料_包裝單位.PlaceholderText = "";
            this.textBox_藥品資料_藥檔資料_包裝單位.ShowTouchPannel = false;
            this.textBox_藥品資料_藥檔資料_包裝單位.Size = new System.Drawing.Size(115, 34);
            this.textBox_藥品資料_藥檔資料_包裝單位.TabIndex = 113;
            this.textBox_藥品資料_藥檔資料_包裝單位.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_藥品資料_藥檔資料_包裝單位.Texts = "";
            this.textBox_藥品資料_藥檔資料_包裝單位.UnderlineStyle = false;
            // 
            // panel68
            // 
            this.panel68.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel68.Location = new System.Drawing.Point(112, 0);
            this.panel68.Name = "panel68";
            this.panel68.Size = new System.Drawing.Size(10, 36);
            this.panel68.TabIndex = 1;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.LightCyan;
            this.label23.Dock = System.Windows.Forms.DockStyle.Left;
            this.label23.Font = new System.Drawing.Font("新細明體", 12F);
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(0, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(112, 36);
            this.label23.TabIndex = 0;
            this.label23.Text = "包裝單位";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel60
            // 
            this.panel60.Controls.Add(this.textBox_藥品資料_藥檔資料_藥品條碼);
            this.panel60.Controls.Add(this.panel63);
            this.panel60.Controls.Add(this.label17);
            this.panel60.Location = new System.Drawing.Point(246, 199);
            this.panel60.Name = "panel60";
            this.panel60.Size = new System.Drawing.Size(323, 36);
            this.panel60.TabIndex = 6;
            // 
            // textBox_藥品資料_藥檔資料_藥品條碼
            // 
            this.textBox_藥品資料_藥檔資料_藥品條碼.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_藥品資料_藥檔資料_藥品條碼.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_藥品資料_藥檔資料_藥品條碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_藥品資料_藥檔資料_藥品條碼.BorderRadius = 2;
            this.textBox_藥品資料_藥檔資料_藥品條碼.BorderSize = 1;
            this.textBox_藥品資料_藥檔資料_藥品條碼.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_藥品資料_藥檔資料_藥品條碼.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_藥品資料_藥檔資料_藥品條碼.ForeColor = System.Drawing.Color.Black;
            this.textBox_藥品資料_藥檔資料_藥品條碼.Location = new System.Drawing.Point(122, 0);
            this.textBox_藥品資料_藥檔資料_藥品條碼.Multiline = false;
            this.textBox_藥品資料_藥檔資料_藥品條碼.Name = "textBox_藥品資料_藥檔資料_藥品條碼";
            this.textBox_藥品資料_藥檔資料_藥品條碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_藥品資料_藥檔資料_藥品條碼.PassWordChar = false;
            this.textBox_藥品資料_藥檔資料_藥品條碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_藥品資料_藥檔資料_藥品條碼.PlaceholderText = "";
            this.textBox_藥品資料_藥檔資料_藥品條碼.ShowTouchPannel = false;
            this.textBox_藥品資料_藥檔資料_藥品條碼.Size = new System.Drawing.Size(201, 34);
            this.textBox_藥品資料_藥檔資料_藥品條碼.TabIndex = 112;
            this.textBox_藥品資料_藥檔資料_藥品條碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_藥品資料_藥檔資料_藥品條碼.Texts = "";
            this.textBox_藥品資料_藥檔資料_藥品條碼.UnderlineStyle = false;
            // 
            // panel63
            // 
            this.panel63.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel63.Location = new System.Drawing.Point(112, 0);
            this.panel63.Name = "panel63";
            this.panel63.Size = new System.Drawing.Size(10, 36);
            this.panel63.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.LightCyan;
            this.label17.Dock = System.Windows.Forms.DockStyle.Left;
            this.label17.Font = new System.Drawing.Font("新細明體", 12F);
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(0, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(112, 36);
            this.label17.TabIndex = 0;
            this.label17.Text = "藥品條碼";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel58
            // 
            this.panel58.Controls.Add(this.textBox_藥品資料_藥檔資料_健保碼);
            this.panel58.Controls.Add(this.panel59);
            this.panel58.Controls.Add(this.label16);
            this.panel58.Location = new System.Drawing.Point(3, 199);
            this.panel58.Name = "panel58";
            this.panel58.Size = new System.Drawing.Size(237, 36);
            this.panel58.TabIndex = 5;
            // 
            // textBox_藥品資料_藥檔資料_健保碼
            // 
            this.textBox_藥品資料_藥檔資料_健保碼.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_藥品資料_藥檔資料_健保碼.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_藥品資料_藥檔資料_健保碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_藥品資料_藥檔資料_健保碼.BorderRadius = 2;
            this.textBox_藥品資料_藥檔資料_健保碼.BorderSize = 1;
            this.textBox_藥品資料_藥檔資料_健保碼.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_藥品資料_藥檔資料_健保碼.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_藥品資料_藥檔資料_健保碼.ForeColor = System.Drawing.Color.Black;
            this.textBox_藥品資料_藥檔資料_健保碼.Location = new System.Drawing.Point(122, 0);
            this.textBox_藥品資料_藥檔資料_健保碼.Multiline = false;
            this.textBox_藥品資料_藥檔資料_健保碼.Name = "textBox_藥品資料_藥檔資料_健保碼";
            this.textBox_藥品資料_藥檔資料_健保碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_藥品資料_藥檔資料_健保碼.PassWordChar = false;
            this.textBox_藥品資料_藥檔資料_健保碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_藥品資料_藥檔資料_健保碼.PlaceholderText = "";
            this.textBox_藥品資料_藥檔資料_健保碼.ShowTouchPannel = false;
            this.textBox_藥品資料_藥檔資料_健保碼.Size = new System.Drawing.Size(115, 34);
            this.textBox_藥品資料_藥檔資料_健保碼.TabIndex = 111;
            this.textBox_藥品資料_藥檔資料_健保碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_藥品資料_藥檔資料_健保碼.Texts = "";
            this.textBox_藥品資料_藥檔資料_健保碼.UnderlineStyle = false;
            // 
            // panel59
            // 
            this.panel59.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel59.Location = new System.Drawing.Point(112, 0);
            this.panel59.Name = "panel59";
            this.panel59.Size = new System.Drawing.Size(10, 36);
            this.panel59.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.LightCyan;
            this.label16.Dock = System.Windows.Forms.DockStyle.Left;
            this.label16.Font = new System.Drawing.Font("新細明體", 12F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 36);
            this.label16.TabIndex = 0;
            this.label16.Text = "健保碼";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel56
            // 
            this.panel56.Controls.Add(this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組);
            this.panel56.Controls.Add(this.panel57);
            this.panel56.Controls.Add(this.label14);
            this.panel56.Location = new System.Drawing.Point(3, 160);
            this.panel56.Name = "panel56";
            this.panel56.Size = new System.Drawing.Size(480, 36);
            this.panel56.TabIndex = 4;
            // 
            // rJ_ComboBox_藥品資料_藥檔資料_藥品群組
            // 
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.BorderSize = 1;
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.IconColor = System.Drawing.Color.RoyalBlue;
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.ListTextColor = System.Drawing.Color.DimGray;
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.Location = new System.Drawing.Point(122, 0);
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.MinimumSize = new System.Drawing.Size(50, 30);
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.Name = "rJ_ComboBox_藥品資料_藥檔資料_藥品群組";
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.Padding = new System.Windows.Forms.Padding(1);
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.Size = new System.Drawing.Size(358, 36);
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.TabIndex = 116;
            this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.Texts = "";
            // 
            // panel57
            // 
            this.panel57.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel57.Location = new System.Drawing.Point(112, 0);
            this.panel57.Name = "panel57";
            this.panel57.Size = new System.Drawing.Size(10, 36);
            this.panel57.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.LightCyan;
            this.label14.Dock = System.Windows.Forms.DockStyle.Left;
            this.label14.Font = new System.Drawing.Font("新細明體", 12F);
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(0, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 36);
            this.label14.TabIndex = 0;
            this.label14.Text = "藥品群組";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel54
            // 
            this.panel54.Controls.Add(this.textBox_藥品資料_藥檔資料_藥品中文名稱);
            this.panel54.Controls.Add(this.panel55);
            this.panel54.Controls.Add(this.label12);
            this.panel54.Location = new System.Drawing.Point(3, 121);
            this.panel54.Name = "panel54";
            this.panel54.Size = new System.Drawing.Size(480, 36);
            this.panel54.TabIndex = 3;
            // 
            // textBox_藥品資料_藥檔資料_藥品中文名稱
            // 
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.BorderRadius = 2;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.BorderSize = 1;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.ForeColor = System.Drawing.Color.Black;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.Location = new System.Drawing.Point(122, 0);
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.Multiline = false;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.Name = "textBox_藥品資料_藥檔資料_藥品中文名稱";
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.PassWordChar = false;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.PlaceholderText = "";
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.ShowTouchPannel = false;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.Size = new System.Drawing.Size(358, 34);
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.TabIndex = 21;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.Texts = "";
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.UnderlineStyle = false;
            // 
            // panel55
            // 
            this.panel55.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel55.Location = new System.Drawing.Point(112, 0);
            this.panel55.Name = "panel55";
            this.panel55.Size = new System.Drawing.Size(10, 36);
            this.panel55.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.LightCyan;
            this.label12.Dock = System.Windows.Forms.DockStyle.Left;
            this.label12.Font = new System.Drawing.Font("新細明體", 12F);
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(0, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(112, 36);
            this.label12.TabIndex = 0;
            this.label12.Text = "中文名";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel52
            // 
            this.panel52.Controls.Add(this.textBox_藥品資料_藥檔資料_藥品學名);
            this.panel52.Controls.Add(this.panel53);
            this.panel52.Controls.Add(this.label10);
            this.panel52.Location = new System.Drawing.Point(3, 82);
            this.panel52.Name = "panel52";
            this.panel52.Size = new System.Drawing.Size(480, 36);
            this.panel52.TabIndex = 2;
            // 
            // textBox_藥品資料_藥檔資料_藥品學名
            // 
            this.textBox_藥品資料_藥檔資料_藥品學名.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_藥品資料_藥檔資料_藥品學名.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_藥品資料_藥檔資料_藥品學名.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_藥品資料_藥檔資料_藥品學名.BorderRadius = 2;
            this.textBox_藥品資料_藥檔資料_藥品學名.BorderSize = 1;
            this.textBox_藥品資料_藥檔資料_藥品學名.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_藥品資料_藥檔資料_藥品學名.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_藥品資料_藥檔資料_藥品學名.ForeColor = System.Drawing.Color.Black;
            this.textBox_藥品資料_藥檔資料_藥品學名.Location = new System.Drawing.Point(122, 0);
            this.textBox_藥品資料_藥檔資料_藥品學名.Multiline = false;
            this.textBox_藥品資料_藥檔資料_藥品學名.Name = "textBox_藥品資料_藥檔資料_藥品學名";
            this.textBox_藥品資料_藥檔資料_藥品學名.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_藥品資料_藥檔資料_藥品學名.PassWordChar = false;
            this.textBox_藥品資料_藥檔資料_藥品學名.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_藥品資料_藥檔資料_藥品學名.PlaceholderText = "";
            this.textBox_藥品資料_藥檔資料_藥品學名.ShowTouchPannel = false;
            this.textBox_藥品資料_藥檔資料_藥品學名.Size = new System.Drawing.Size(358, 34);
            this.textBox_藥品資料_藥檔資料_藥品學名.TabIndex = 20;
            this.textBox_藥品資料_藥檔資料_藥品學名.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_藥品資料_藥檔資料_藥品學名.Texts = "";
            this.textBox_藥品資料_藥檔資料_藥品學名.UnderlineStyle = false;
            // 
            // panel53
            // 
            this.panel53.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel53.Location = new System.Drawing.Point(112, 0);
            this.panel53.Name = "panel53";
            this.panel53.Size = new System.Drawing.Size(10, 36);
            this.panel53.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.LightCyan;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("新細明體", 12F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 36);
            this.label10.TabIndex = 0;
            this.label10.Text = "學名";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel50
            // 
            this.panel50.Controls.Add(this.textBox_藥品資料_藥檔資料_藥品名稱);
            this.panel50.Controls.Add(this.panel51);
            this.panel50.Controls.Add(this.label9);
            this.panel50.Location = new System.Drawing.Point(3, 43);
            this.panel50.Name = "panel50";
            this.panel50.Size = new System.Drawing.Size(480, 36);
            this.panel50.TabIndex = 1;
            // 
            // textBox_藥品資料_藥檔資料_藥品名稱
            // 
            this.textBox_藥品資料_藥檔資料_藥品名稱.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_藥品資料_藥檔資料_藥品名稱.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_藥品資料_藥檔資料_藥品名稱.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_藥品資料_藥檔資料_藥品名稱.BorderRadius = 2;
            this.textBox_藥品資料_藥檔資料_藥品名稱.BorderSize = 1;
            this.textBox_藥品資料_藥檔資料_藥品名稱.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_藥品資料_藥檔資料_藥品名稱.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_藥品資料_藥檔資料_藥品名稱.ForeColor = System.Drawing.Color.Black;
            this.textBox_藥品資料_藥檔資料_藥品名稱.Location = new System.Drawing.Point(122, 0);
            this.textBox_藥品資料_藥檔資料_藥品名稱.Multiline = false;
            this.textBox_藥品資料_藥檔資料_藥品名稱.Name = "textBox_藥品資料_藥檔資料_藥品名稱";
            this.textBox_藥品資料_藥檔資料_藥品名稱.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_藥品資料_藥檔資料_藥品名稱.PassWordChar = false;
            this.textBox_藥品資料_藥檔資料_藥品名稱.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_藥品資料_藥檔資料_藥品名稱.PlaceholderText = "";
            this.textBox_藥品資料_藥檔資料_藥品名稱.ShowTouchPannel = false;
            this.textBox_藥品資料_藥檔資料_藥品名稱.Size = new System.Drawing.Size(358, 34);
            this.textBox_藥品資料_藥檔資料_藥品名稱.TabIndex = 19;
            this.textBox_藥品資料_藥檔資料_藥品名稱.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_藥品資料_藥檔資料_藥品名稱.Texts = "";
            this.textBox_藥品資料_藥檔資料_藥品名稱.UnderlineStyle = false;
            // 
            // panel51
            // 
            this.panel51.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel51.Location = new System.Drawing.Point(112, 0);
            this.panel51.Name = "panel51";
            this.panel51.Size = new System.Drawing.Size(10, 36);
            this.panel51.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.LightCyan;
            this.label9.Dock = System.Windows.Forms.DockStyle.Left;
            this.label9.Font = new System.Drawing.Font("新細明體", 12F);
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(0, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 36);
            this.label9.TabIndex = 0;
            this.label9.Text = "藥名";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.textBox_藥品資料_藥檔資料_藥品碼);
            this.panel18.Controls.Add(this.panel19);
            this.panel18.Controls.Add(this.label21);
            this.panel18.Location = new System.Drawing.Point(3, 4);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(263, 36);
            this.panel18.TabIndex = 0;
            // 
            // textBox_藥品資料_藥檔資料_藥品碼
            // 
            this.textBox_藥品資料_藥檔資料_藥品碼.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_藥品資料_藥檔資料_藥品碼.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.textBox_藥品資料_藥檔資料_藥品碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.textBox_藥品資料_藥檔資料_藥品碼.BorderRadius = 2;
            this.textBox_藥品資料_藥檔資料_藥品碼.BorderSize = 1;
            this.textBox_藥品資料_藥檔資料_藥品碼.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox_藥品資料_藥檔資料_藥品碼.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox_藥品資料_藥檔資料_藥品碼.ForeColor = System.Drawing.Color.Black;
            this.textBox_藥品資料_藥檔資料_藥品碼.Location = new System.Drawing.Point(122, 0);
            this.textBox_藥品資料_藥檔資料_藥品碼.Multiline = false;
            this.textBox_藥品資料_藥檔資料_藥品碼.Name = "textBox_藥品資料_藥檔資料_藥品碼";
            this.textBox_藥品資料_藥檔資料_藥品碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.textBox_藥品資料_藥檔資料_藥品碼.PassWordChar = false;
            this.textBox_藥品資料_藥檔資料_藥品碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.textBox_藥品資料_藥檔資料_藥品碼.PlaceholderText = "";
            this.textBox_藥品資料_藥檔資料_藥品碼.ShowTouchPannel = false;
            this.textBox_藥品資料_藥檔資料_藥品碼.Size = new System.Drawing.Size(141, 34);
            this.textBox_藥品資料_藥檔資料_藥品碼.TabIndex = 3;
            this.textBox_藥品資料_藥檔資料_藥品碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_藥品資料_藥檔資料_藥品碼.Texts = "";
            this.textBox_藥品資料_藥檔資料_藥品碼.UnderlineStyle = false;
            // 
            // panel19
            // 
            this.panel19.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel19.Location = new System.Drawing.Point(112, 0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(10, 36);
            this.panel19.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.LightCyan;
            this.label21.Dock = System.Windows.Forms.DockStyle.Left;
            this.label21.Font = new System.Drawing.Font("新細明體", 12F);
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(0, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 36);
            this.label21.TabIndex = 0;
            this.label21.Text = "藥碼";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // plC_RJ_Button_藥品資料_登錄
            // 
            this.plC_RJ_Button_藥品資料_登錄.AutoResetState = false;
            this.plC_RJ_Button_藥品資料_登錄.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_藥品資料_登錄.Bool = false;
            this.plC_RJ_Button_藥品資料_登錄.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_藥品資料_登錄.BorderRadius = 5;
            this.plC_RJ_Button_藥品資料_登錄.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_登錄.but_press = false;
            this.plC_RJ_Button_藥品資料_登錄.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_藥品資料_登錄.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_藥品資料_登錄.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_藥品資料_登錄.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_登錄.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_藥品資料_登錄.Location = new System.Drawing.Point(307, 330);
            this.plC_RJ_Button_藥品資料_登錄.Name = "plC_RJ_Button_藥品資料_登錄";
            this.plC_RJ_Button_藥品資料_登錄.OFF_文字內容 = "登錄";
            this.plC_RJ_Button_藥品資料_登錄.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_登錄.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_登錄.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_登錄.ON_BorderSize = 5;
            this.plC_RJ_Button_藥品資料_登錄.ON_文字內容 = "登錄";
            this.plC_RJ_Button_藥品資料_登錄.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_藥品資料_登錄.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_藥品資料_登錄.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_藥品資料_登錄.Size = new System.Drawing.Size(75, 52);
            this.plC_RJ_Button_藥品資料_登錄.State = false;
            this.plC_RJ_Button_藥品資料_登錄.TabIndex = 136;
            this.plC_RJ_Button_藥品資料_登錄.Text = "登錄";
            this.plC_RJ_Button_藥品資料_登錄.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_藥品資料_登錄.Texts = "登錄";
            this.plC_RJ_Button_藥品資料_登錄.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_藥品資料_登錄.字型鎖住 = false;
            this.plC_RJ_Button_藥品資料_登錄.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_藥品資料_登錄.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_藥品資料_登錄.文字鎖住 = false;
            this.plC_RJ_Button_藥品資料_登錄.致能讀取位置 = "S39007";
            this.plC_RJ_Button_藥品資料_登錄.讀取位元反向 = false;
            this.plC_RJ_Button_藥品資料_登錄.讀寫鎖住 = false;
            this.plC_RJ_Button_藥品資料_登錄.音效 = true;
            this.plC_RJ_Button_藥品資料_登錄.顯示 = false;
            this.plC_RJ_Button_藥品資料_登錄.顯示狀態 = false;
            // 
            // sqL_DataGridView_藥品資料_藥檔資料
            // 
            this.sqL_DataGridView_藥品資料_藥檔資料.AutoSelectToDeep = false;
            this.sqL_DataGridView_藥品資料_藥檔資料.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_藥品資料_藥檔資料.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_藥品資料_藥檔資料.BorderRadius = 0;
            this.sqL_DataGridView_藥品資料_藥檔資料.BorderSize = 2;
            this.sqL_DataGridView_藥品資料_藥檔資料.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_藥品資料_藥檔資料.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_藥品資料_藥檔資料.cellStyleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_藥品資料_藥檔資料.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_藥品資料_藥檔資料.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_藥品資料_藥檔資料.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_藥品資料_藥檔資料.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_藥品資料_藥檔資料.columnHeadersHeight = 44;
            this.sqL_DataGridView_藥品資料_藥檔資料.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns1"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns2"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns3"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns4"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns5"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns6"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns7"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns8"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns9"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns10"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns11"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_藥品資料_藥檔資料.Columns12"))));
            this.sqL_DataGridView_藥品資料_藥檔資料.DataBaseName = "Dispensing_000";
            this.sqL_DataGridView_藥品資料_藥檔資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqL_DataGridView_藥品資料_藥檔資料.Font = new System.Drawing.Font("新細明體", 12F);
            this.sqL_DataGridView_藥品資料_藥檔資料.ImageBox = false;
            this.sqL_DataGridView_藥品資料_藥檔資料.Location = new System.Drawing.Point(0, 0);
            this.sqL_DataGridView_藥品資料_藥檔資料.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sqL_DataGridView_藥品資料_藥檔資料.Name = "sqL_DataGridView_藥品資料_藥檔資料";
            this.sqL_DataGridView_藥品資料_藥檔資料.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_藥品資料_藥檔資料.Password = "user82822040";
            this.sqL_DataGridView_藥品資料_藥檔資料.Port = ((uint)(3306u));
            this.sqL_DataGridView_藥品資料_藥檔資料.rowHeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.sqL_DataGridView_藥品資料_藥檔資料.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_藥品資料_藥檔資料.RowsColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqL_DataGridView_藥品資料_藥檔資料.RowsHeight = 50;
            this.sqL_DataGridView_藥品資料_藥檔資料.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_藥品資料_藥檔資料.Server = "localhost";
            this.sqL_DataGridView_藥品資料_藥檔資料.Size = new System.Drawing.Size(1630, 500);
            this.sqL_DataGridView_藥品資料_藥檔資料.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_藥品資料_藥檔資料.TabIndex = 129;
            this.sqL_DataGridView_藥品資料_藥檔資料.TableName = "medicine_page";
            this.sqL_DataGridView_藥品資料_藥檔資料.UserName = "root";
            this.sqL_DataGridView_藥品資料_藥檔資料.可拖曳欄位寬度 = true;
            this.sqL_DataGridView_藥品資料_藥檔資料.可選擇多列 = true;
            this.sqL_DataGridView_藥品資料_藥檔資料.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_藥品資料_藥檔資料.自動換行 = true;
            this.sqL_DataGridView_藥品資料_藥檔資料.表單字體 = new System.Drawing.Font("新細明體", 12F);
            this.sqL_DataGridView_藥品資料_藥檔資料.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_藥品資料_藥檔資料.顯示CheckBox = true;
            this.sqL_DataGridView_藥品資料_藥檔資料.顯示首列 = true;
            this.sqL_DataGridView_藥品資料_藥檔資料.顯示首行 = true;
            this.sqL_DataGridView_藥品資料_藥檔資料.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_藥品資料_藥檔資料.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // panel_藥品資料
            // 
            this.panel_藥品資料.Controls.Add(this.plC_RJ_ScreenButton8);
            this.panel_藥品資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_藥品資料.Location = new System.Drawing.Point(0, 0);
            this.panel_藥品資料.Name = "panel_藥品資料";
            this.panel_藥品資料.Size = new System.Drawing.Size(1638, 51);
            this.panel_藥品資料.TabIndex = 118;
            // 
            // plC_RJ_ScreenButton8
            // 
            this.plC_RJ_ScreenButton8.but_press = false;
            this.plC_RJ_ScreenButton8.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton8.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton8.IconSize = 32;
            this.plC_RJ_ScreenButton8.Location = new System.Drawing.Point(0, 0);
            this.plC_RJ_ScreenButton8.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton8.Name = "plC_RJ_ScreenButton8";
            this.plC_RJ_ScreenButton8.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton8.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton8.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton8.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton8.OffText = "藥檔資料";
            this.plC_RJ_ScreenButton8.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton8.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton8.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton8.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton8.OnText = "藥檔資料";
            this.plC_RJ_ScreenButton8.ShowIcon = false;
            this.plC_RJ_ScreenButton8.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton8.TabIndex = 0;
            this.plC_RJ_ScreenButton8.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton8.寫入位置註解 = "";
            this.plC_RJ_ScreenButton8.寫入元件位置 = "";
            this.plC_RJ_ScreenButton8.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton8.控制位址 = "D0";
            this.plC_RJ_ScreenButton8.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton8.致能讀取位置 = "";
            this.plC_RJ_ScreenButton8.讀取位元反向 = false;
            this.plC_RJ_ScreenButton8.讀取位置註解 = "";
            this.plC_RJ_ScreenButton8.讀取元件位置 = "";
            this.plC_RJ_ScreenButton8.音效 = true;
            this.plC_RJ_ScreenButton8.頁面名稱 = "藥檔資料";
            this.plC_RJ_ScreenButton8.頁面編號 = 0;
            this.plC_RJ_ScreenButton8.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton8.顯示狀態 = false;
            this.plC_RJ_ScreenButton8.顯示讀取位置 = "";
            // 
            // 人員資料
            // 
            this.人員資料.BackColor = System.Drawing.Color.White;
            this.人員資料.Controls.Add(this.plC_ScreenPage_人員資料);
            this.人員資料.Controls.Add(this.panel_人員資料);
            this.人員資料.Location = new System.Drawing.Point(4, 25);
            this.人員資料.Name = "人員資料";
            this.人員資料.Size = new System.Drawing.Size(1638, 986);
            this.人員資料.TabIndex = 8;
            this.人員資料.Text = "人員資料";
            // 
            // plC_ScreenPage_人員資料
            // 
            this.plC_ScreenPage_人員資料.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.plC_ScreenPage_人員資料.BackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_人員資料.Controls.Add(this.資料維護);
            this.plC_ScreenPage_人員資料.Controls.Add(this.權限管理);
            this.plC_ScreenPage_人員資料.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plC_ScreenPage_人員資料.ForekColor = System.Drawing.Color.Black;
            this.plC_ScreenPage_人員資料.ItemSize = new System.Drawing.Size(54, 21);
            this.plC_ScreenPage_人員資料.Location = new System.Drawing.Point(0, 51);
            this.plC_ScreenPage_人員資料.Name = "plC_ScreenPage_人員資料";
            this.plC_ScreenPage_人員資料.SelectedIndex = 0;
            this.plC_ScreenPage_人員資料.Size = new System.Drawing.Size(1638, 935);
            this.plC_ScreenPage_人員資料.TabBackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_人員資料.TabIndex = 118;
            this.plC_ScreenPage_人員資料.顯示標籤列 = MyUI.PLC_ScreenPage.TabVisibleEnum.顯示;
            this.plC_ScreenPage_人員資料.顯示頁面 = 0;
            // 
            // 資料維護
            // 
            this.資料維護.BackColor = System.Drawing.Color.White;
            this.資料維護.Controls.Add(this.plC_RJ_Button_人員資料_清除內容);
            this.資料維護.Controls.Add(this.rJ_GroupBox15);
            this.資料維護.Controls.Add(this.sqL_DataGridView_人員資料);
            this.資料維護.Controls.Add(this.plC_RJ_Button_人員資料_刪除);
            this.資料維護.Controls.Add(this.plC_RJ_Button_人員資料_匯出);
            this.資料維護.Controls.Add(this.plC_RJ_Button_人員資料_登錄);
            this.資料維護.Controls.Add(this.plC_RJ_Button_人員資料_匯入);
            this.資料維護.Location = new System.Drawing.Point(4, 25);
            this.資料維護.Name = "資料維護";
            this.資料維護.Size = new System.Drawing.Size(1630, 906);
            this.資料維護.TabIndex = 0;
            this.資料維護.Text = "資料維護";
            // 
            // plC_RJ_Button_人員資料_清除內容
            // 
            this.plC_RJ_Button_人員資料_清除內容.AutoResetState = false;
            this.plC_RJ_Button_人員資料_清除內容.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_人員資料_清除內容.Bool = false;
            this.plC_RJ_Button_人員資料_清除內容.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_人員資料_清除內容.BorderRadius = 5;
            this.plC_RJ_Button_人員資料_清除內容.BorderSize = 0;
            this.plC_RJ_Button_人員資料_清除內容.but_press = false;
            this.plC_RJ_Button_人員資料_清除內容.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_人員資料_清除內容.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_人員資料_清除內容.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_人員資料_清除內容.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_清除內容.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_人員資料_清除內容.Location = new System.Drawing.Point(872, 882);
            this.plC_RJ_Button_人員資料_清除內容.Name = "plC_RJ_Button_人員資料_清除內容";
            this.plC_RJ_Button_人員資料_清除內容.OFF_文字內容 = "清除內容";
            this.plC_RJ_Button_人員資料_清除內容.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_清除內容.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_人員資料_清除內容.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_人員資料_清除內容.ON_BorderSize = 5;
            this.plC_RJ_Button_人員資料_清除內容.ON_文字內容 = "清除內容";
            this.plC_RJ_Button_人員資料_清除內容.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_清除內容.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_人員資料_清除內容.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_人員資料_清除內容.Size = new System.Drawing.Size(117, 46);
            this.plC_RJ_Button_人員資料_清除內容.State = false;
            this.plC_RJ_Button_人員資料_清除內容.TabIndex = 136;
            this.plC_RJ_Button_人員資料_清除內容.Text = "清除內容";
            this.plC_RJ_Button_人員資料_清除內容.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_人員資料_清除內容.Texts = "清除內容";
            this.plC_RJ_Button_人員資料_清除內容.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_人員資料_清除內容.字型鎖住 = false;
            this.plC_RJ_Button_人員資料_清除內容.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_人員資料_清除內容.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_人員資料_清除內容.文字鎖住 = false;
            this.plC_RJ_Button_人員資料_清除內容.致能讀取位置 = "S39014";
            this.plC_RJ_Button_人員資料_清除內容.讀取位元反向 = false;
            this.plC_RJ_Button_人員資料_清除內容.讀寫鎖住 = false;
            this.plC_RJ_Button_人員資料_清除內容.音效 = true;
            this.plC_RJ_Button_人員資料_清除內容.顯示 = false;
            this.plC_RJ_Button_人員資料_清除內容.顯示狀態 = false;
            // 
            // rJ_GroupBox15
            // 
            // 
            // rJ_GroupBox15.ContentsPanel
            // 
            this.rJ_GroupBox15.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox15.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox15.ContentsPanel.BorderRadius = 2;
            this.rJ_GroupBox15.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox15.ContentsPanel.Controls.Add(this.rJ_TextBox_人員資料_識別圖案);
            this.rJ_GroupBox15.ContentsPanel.Controls.Add(this.tableLayoutPanel5);
            this.rJ_GroupBox15.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox15.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox15.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox15.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox15.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox15.ContentsPanel.Padding = new System.Windows.Forms.Padding(3);
            this.rJ_GroupBox15.ContentsPanel.Size = new System.Drawing.Size(542, 355);
            this.rJ_GroupBox15.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox15.Dock = System.Windows.Forms.DockStyle.Left;
            this.rJ_GroupBox15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_GroupBox15.Location = new System.Drawing.Point(0, 514);
            this.rJ_GroupBox15.Name = "rJ_GroupBox15";
            this.rJ_GroupBox15.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox15.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox15.PannelBorderRadius = 2;
            this.rJ_GroupBox15.PannelBorderSize = 2;
            this.rJ_GroupBox15.Size = new System.Drawing.Size(542, 392);
            this.rJ_GroupBox15.TabIndex = 110;
            this.rJ_GroupBox15.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox15.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox15.TitleBorderRadius = 5;
            this.rJ_GroupBox15.TitleBorderSize = 0;
            this.rJ_GroupBox15.TitleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_GroupBox15.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox15.TitleHeight = 37;
            this.rJ_GroupBox15.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox15.TitleTexts = "資料內容";
            // 
            // rJ_TextBox_人員資料_識別圖案
            // 
            this.rJ_TextBox_人員資料_識別圖案.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_人員資料_識別圖案.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_TextBox_人員資料_識別圖案.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_人員資料_識別圖案.BorderRadius = 0;
            this.rJ_TextBox_人員資料_識別圖案.BorderSize = 2;
            this.rJ_TextBox_人員資料_識別圖案.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_人員資料_識別圖案.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_人員資料_識別圖案.Location = new System.Drawing.Point(49, 334);
            this.rJ_TextBox_人員資料_識別圖案.Multiline = false;
            this.rJ_TextBox_人員資料_識別圖案.Name = "rJ_TextBox_人員資料_識別圖案";
            this.rJ_TextBox_人員資料_識別圖案.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_人員資料_識別圖案.PassWordChar = false;
            this.rJ_TextBox_人員資料_識別圖案.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_人員資料_識別圖案.PlaceholderText = "";
            this.rJ_TextBox_人員資料_識別圖案.ShowTouchPannel = false;
            this.rJ_TextBox_人員資料_識別圖案.Size = new System.Drawing.Size(421, 30);
            this.rJ_TextBox_人員資料_識別圖案.TabIndex = 135;
            this.rJ_TextBox_人員資料_識別圖案.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_人員資料_識別圖案.Texts = "";
            this.rJ_TextBox_人員資料_識別圖案.UnderlineStyle = false;
            this.rJ_TextBox_人員資料_識別圖案.Visible = false;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.00766F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.99234F));
            this.tableLayoutPanel5.Controls.Add(this.rJ_TextBox_人員資料_一維條碼, 1, 8);
            this.tableLayoutPanel5.Controls.Add(this.label7, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.rJ_TextBox_人員資料_卡號, 1, 7);
            this.tableLayoutPanel5.Controls.Add(this.comboBox_人員資料_權限等級, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.rJ_TextBox_人員資料_單位, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.rJ_TextBox_人員資料_密碼, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.rJ_TextBox_人員資料_姓名, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.rJ_TextBox_人員資料_ID, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label49, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label144, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.label108, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.label138, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.label143, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.label102, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label44, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.label13, 0, 7);
            this.tableLayoutPanel5.Controls.Add(this.panel149, 1, 6);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 14;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(536, 325);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // rJ_TextBox_人員資料_一維條碼
            // 
            this.rJ_TextBox_人員資料_一維條碼.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_人員資料_一維條碼.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_TextBox_人員資料_一維條碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_人員資料_一維條碼.BorderRadius = 0;
            this.rJ_TextBox_人員資料_一維條碼.BorderSize = 2;
            this.rJ_TextBox_人員資料_一維條碼.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_人員資料_一維條碼.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_人員資料_一維條碼.Location = new System.Drawing.Point(100, 292);
            this.rJ_TextBox_人員資料_一維條碼.Multiline = false;
            this.rJ_TextBox_人員資料_一維條碼.Name = "rJ_TextBox_人員資料_一維條碼";
            this.rJ_TextBox_人員資料_一維條碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_人員資料_一維條碼.PassWordChar = false;
            this.rJ_TextBox_人員資料_一維條碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_人員資料_一維條碼.PlaceholderText = "";
            this.rJ_TextBox_人員資料_一維條碼.ShowTouchPannel = false;
            this.rJ_TextBox_人員資料_一維條碼.Size = new System.Drawing.Size(421, 30);
            this.rJ_TextBox_人員資料_一維條碼.TabIndex = 134;
            this.rJ_TextBox_人員資料_一維條碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_人員資料_一維條碼.Texts = "";
            this.rJ_TextBox_人員資料_一維條碼.UnderlineStyle = false;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.LightCyan;
            this.label7.Font = new System.Drawing.Font("新細明體", 12F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(4, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 35);
            this.label7.TabIndex = 134;
            this.label7.Text = "一維條碼";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // rJ_TextBox_人員資料_卡號
            // 
            this.rJ_TextBox_人員資料_卡號.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_人員資料_卡號.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_TextBox_人員資料_卡號.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_人員資料_卡號.BorderRadius = 0;
            this.rJ_TextBox_人員資料_卡號.BorderSize = 2;
            this.rJ_TextBox_人員資料_卡號.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_人員資料_卡號.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_人員資料_卡號.Location = new System.Drawing.Point(100, 256);
            this.rJ_TextBox_人員資料_卡號.Multiline = false;
            this.rJ_TextBox_人員資料_卡號.Name = "rJ_TextBox_人員資料_卡號";
            this.rJ_TextBox_人員資料_卡號.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_人員資料_卡號.PassWordChar = false;
            this.rJ_TextBox_人員資料_卡號.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_人員資料_卡號.PlaceholderText = "";
            this.rJ_TextBox_人員資料_卡號.ShowTouchPannel = false;
            this.rJ_TextBox_人員資料_卡號.Size = new System.Drawing.Size(421, 30);
            this.rJ_TextBox_人員資料_卡號.TabIndex = 113;
            this.rJ_TextBox_人員資料_卡號.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_人員資料_卡號.Texts = "";
            this.rJ_TextBox_人員資料_卡號.UnderlineStyle = false;
            // 
            // comboBox_人員資料_權限等級
            // 
            this.comboBox_人員資料_權限等級.BackColor = System.Drawing.Color.WhiteSmoke;
            this.comboBox_人員資料_權限等級.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.comboBox_人員資料_權限等級.BorderSize = 1;
            this.comboBox_人員資料_權限等級.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.comboBox_人員資料_權限等級.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.comboBox_人員資料_權限等級.ForeColor = System.Drawing.Color.DimGray;
            this.comboBox_人員資料_權限等級.IconColor = System.Drawing.Color.RoyalBlue;
            this.comboBox_人員資料_權限等級.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comboBox_人員資料_權限等級.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.comboBox_人員資料_權限等級.ListTextColor = System.Drawing.Color.DimGray;
            this.comboBox_人員資料_權限等級.Location = new System.Drawing.Point(100, 184);
            this.comboBox_人員資料_權限等級.MinimumSize = new System.Drawing.Size(50, 30);
            this.comboBox_人員資料_權限等級.Name = "comboBox_人員資料_權限等級";
            this.comboBox_人員資料_權限等級.Padding = new System.Windows.Forms.Padding(1);
            this.comboBox_人員資料_權限等級.Size = new System.Drawing.Size(119, 30);
            this.comboBox_人員資料_權限等級.TabIndex = 111;
            this.comboBox_人員資料_權限等級.Texts = "";
            // 
            // rJ_TextBox_人員資料_單位
            // 
            this.rJ_TextBox_人員資料_單位.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_人員資料_單位.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_TextBox_人員資料_單位.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_人員資料_單位.BorderRadius = 0;
            this.rJ_TextBox_人員資料_單位.BorderSize = 2;
            this.rJ_TextBox_人員資料_單位.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_人員資料_單位.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_人員資料_單位.Location = new System.Drawing.Point(100, 148);
            this.rJ_TextBox_人員資料_單位.Multiline = false;
            this.rJ_TextBox_人員資料_單位.Name = "rJ_TextBox_人員資料_單位";
            this.rJ_TextBox_人員資料_單位.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_人員資料_單位.PassWordChar = false;
            this.rJ_TextBox_人員資料_單位.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_人員資料_單位.PlaceholderText = "";
            this.rJ_TextBox_人員資料_單位.ShowTouchPannel = false;
            this.rJ_TextBox_人員資料_單位.Size = new System.Drawing.Size(421, 30);
            this.rJ_TextBox_人員資料_單位.TabIndex = 112;
            this.rJ_TextBox_人員資料_單位.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_人員資料_單位.Texts = "";
            this.rJ_TextBox_人員資料_單位.UnderlineStyle = false;
            // 
            // rJ_TextBox_人員資料_密碼
            // 
            this.rJ_TextBox_人員資料_密碼.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_人員資料_密碼.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_TextBox_人員資料_密碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_人員資料_密碼.BorderRadius = 0;
            this.rJ_TextBox_人員資料_密碼.BorderSize = 2;
            this.rJ_TextBox_人員資料_密碼.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_人員資料_密碼.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_人員資料_密碼.Location = new System.Drawing.Point(100, 112);
            this.rJ_TextBox_人員資料_密碼.Multiline = false;
            this.rJ_TextBox_人員資料_密碼.Name = "rJ_TextBox_人員資料_密碼";
            this.rJ_TextBox_人員資料_密碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_人員資料_密碼.PassWordChar = false;
            this.rJ_TextBox_人員資料_密碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_人員資料_密碼.PlaceholderText = "";
            this.rJ_TextBox_人員資料_密碼.ShowTouchPannel = false;
            this.rJ_TextBox_人員資料_密碼.Size = new System.Drawing.Size(421, 30);
            this.rJ_TextBox_人員資料_密碼.TabIndex = 111;
            this.rJ_TextBox_人員資料_密碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_人員資料_密碼.Texts = "";
            this.rJ_TextBox_人員資料_密碼.UnderlineStyle = false;
            // 
            // rJ_TextBox_人員資料_姓名
            // 
            this.rJ_TextBox_人員資料_姓名.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_人員資料_姓名.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_TextBox_人員資料_姓名.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_人員資料_姓名.BorderRadius = 0;
            this.rJ_TextBox_人員資料_姓名.BorderSize = 2;
            this.rJ_TextBox_人員資料_姓名.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_人員資料_姓名.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_人員資料_姓名.Location = new System.Drawing.Point(100, 40);
            this.rJ_TextBox_人員資料_姓名.Multiline = false;
            this.rJ_TextBox_人員資料_姓名.Name = "rJ_TextBox_人員資料_姓名";
            this.rJ_TextBox_人員資料_姓名.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_人員資料_姓名.PassWordChar = false;
            this.rJ_TextBox_人員資料_姓名.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_人員資料_姓名.PlaceholderText = "";
            this.rJ_TextBox_人員資料_姓名.ShowTouchPannel = false;
            this.rJ_TextBox_人員資料_姓名.Size = new System.Drawing.Size(421, 30);
            this.rJ_TextBox_人員資料_姓名.TabIndex = 17;
            this.rJ_TextBox_人員資料_姓名.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_人員資料_姓名.Texts = "";
            this.rJ_TextBox_人員資料_姓名.UnderlineStyle = false;
            // 
            // rJ_TextBox_人員資料_ID
            // 
            this.rJ_TextBox_人員資料_ID.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_人員資料_ID.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_TextBox_人員資料_ID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_人員資料_ID.BorderRadius = 0;
            this.rJ_TextBox_人員資料_ID.BorderSize = 2;
            this.rJ_TextBox_人員資料_ID.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_人員資料_ID.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_人員資料_ID.Location = new System.Drawing.Point(100, 4);
            this.rJ_TextBox_人員資料_ID.Multiline = false;
            this.rJ_TextBox_人員資料_ID.Name = "rJ_TextBox_人員資料_ID";
            this.rJ_TextBox_人員資料_ID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_人員資料_ID.PassWordChar = false;
            this.rJ_TextBox_人員資料_ID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_人員資料_ID.PlaceholderText = "";
            this.rJ_TextBox_人員資料_ID.ShowTouchPannel = false;
            this.rJ_TextBox_人員資料_ID.Size = new System.Drawing.Size(421, 30);
            this.rJ_TextBox_人員資料_ID.TabIndex = 2;
            this.rJ_TextBox_人員資料_ID.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_人員資料_ID.Texts = "";
            this.rJ_TextBox_人員資料_ID.UnderlineStyle = false;
            // 
            // label49
            // 
            this.label49.BackColor = System.Drawing.Color.LightCyan;
            this.label49.Font = new System.Drawing.Font("新細明體", 12F);
            this.label49.ForeColor = System.Drawing.Color.Black;
            this.label49.Location = new System.Drawing.Point(4, 1);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(87, 35);
            this.label49.TabIndex = 8;
            this.label49.Text = "ID";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label144
            // 
            this.label144.BackColor = System.Drawing.Color.LightCyan;
            this.label144.Font = new System.Drawing.Font("新細明體", 12F);
            this.label144.ForeColor = System.Drawing.Color.Black;
            this.label144.Location = new System.Drawing.Point(4, 37);
            this.label144.Name = "label144";
            this.label144.Size = new System.Drawing.Size(86, 35);
            this.label144.TabIndex = 0;
            this.label144.Text = "姓名";
            this.label144.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label108
            // 
            this.label108.BackColor = System.Drawing.Color.LightCyan;
            this.label108.Font = new System.Drawing.Font("新細明體", 12F);
            this.label108.ForeColor = System.Drawing.Color.Black;
            this.label108.Location = new System.Drawing.Point(4, 181);
            this.label108.Name = "label108";
            this.label108.Size = new System.Drawing.Size(86, 35);
            this.label108.TabIndex = 12;
            this.label108.Text = "權限等級";
            this.label108.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label138
            // 
            this.label138.BackColor = System.Drawing.Color.LightCyan;
            this.label138.Font = new System.Drawing.Font("新細明體", 12F);
            this.label138.ForeColor = System.Drawing.Color.Black;
            this.label138.Location = new System.Drawing.Point(4, 145);
            this.label138.Name = "label138";
            this.label138.Size = new System.Drawing.Size(86, 35);
            this.label138.TabIndex = 6;
            this.label138.Text = "單位";
            this.label138.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label143
            // 
            this.label143.BackColor = System.Drawing.Color.LightCyan;
            this.label143.Font = new System.Drawing.Font("新細明體", 12F);
            this.label143.ForeColor = System.Drawing.Color.Black;
            this.label143.Location = new System.Drawing.Point(4, 73);
            this.label143.Name = "label143";
            this.label143.Size = new System.Drawing.Size(86, 35);
            this.label143.TabIndex = 2;
            this.label143.Text = "性別";
            this.label143.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label102
            // 
            this.label102.BackColor = System.Drawing.Color.LightCyan;
            this.label102.Font = new System.Drawing.Font("新細明體", 12F);
            this.label102.ForeColor = System.Drawing.Color.Black;
            this.label102.Location = new System.Drawing.Point(4, 109);
            this.label102.Name = "label102";
            this.label102.Size = new System.Drawing.Size(86, 35);
            this.label102.TabIndex = 15;
            this.label102.Text = "密碼";
            this.label102.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label44
            // 
            this.label44.BackColor = System.Drawing.Color.LightCyan;
            this.label44.Font = new System.Drawing.Font("新細明體", 12F);
            this.label44.ForeColor = System.Drawing.Color.Black;
            this.label44.Location = new System.Drawing.Point(4, 217);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(86, 35);
            this.label44.TabIndex = 14;
            this.label44.Text = "顏色";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.LightCyan;
            this.label13.Font = new System.Drawing.Font("新細明體", 12F);
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(4, 253);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(86, 35);
            this.label13.TabIndex = 13;
            this.label13.Text = "卡號";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel149
            // 
            this.panel149.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel149.Controls.Add(this.panel150);
            this.panel149.Controls.Add(this.textBox_人員資料_顏色);
            this.panel149.Location = new System.Drawing.Point(100, 220);
            this.panel149.Name = "panel149";
            this.panel149.Size = new System.Drawing.Size(216, 29);
            this.panel149.TabIndex = 16;
            // 
            // panel150
            // 
            this.panel150.Controls.Add(this.button_人員資料_顏色選擇);
            this.panel150.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel150.Location = new System.Drawing.Point(179, 0);
            this.panel150.Name = "panel150";
            this.panel150.Size = new System.Drawing.Size(37, 29);
            this.panel150.TabIndex = 0;
            // 
            // button_人員資料_顏色選擇
            // 
            this.button_人員資料_顏色選擇.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button_人員資料_顏色選擇.Location = new System.Drawing.Point(0, 0);
            this.button_人員資料_顏色選擇.Name = "button_人員資料_顏色選擇";
            this.button_人員資料_顏色選擇.Size = new System.Drawing.Size(37, 29);
            this.button_人員資料_顏色選擇.TabIndex = 5;
            this.button_人員資料_顏色選擇.Text = "...";
            this.button_人員資料_顏色選擇.UseVisualStyleBackColor = true;
            // 
            // textBox_人員資料_顏色
            // 
            this.textBox_人員資料_顏色.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_人員資料_顏色.Location = new System.Drawing.Point(2, 2);
            this.textBox_人員資料_顏色.Name = "textBox_人員資料_顏色";
            this.textBox_人員資料_顏色.ReadOnly = true;
            this.textBox_人員資料_顏色.Size = new System.Drawing.Size(177, 29);
            this.textBox_人員資料_顏色.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rJ_RatioButton_人員資料_男);
            this.flowLayoutPanel1.Controls.Add(this.rJ_RatioButton_人員資料_女);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(100, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(432, 29);
            this.flowLayoutPanel1.TabIndex = 114;
            // 
            // rJ_RatioButton_人員資料_男
            // 
            this.rJ_RatioButton_人員資料_男.AutoSize = true;
            this.rJ_RatioButton_人員資料_男.BackColor = System.Drawing.Color.White;
            this.rJ_RatioButton_人員資料_男.CheckColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_RatioButton_人員資料_男.Checked = true;
            this.rJ_RatioButton_人員資料_男.ForeColor = System.Drawing.Color.Black;
            this.rJ_RatioButton_人員資料_男.Location = new System.Drawing.Point(3, 3);
            this.rJ_RatioButton_人員資料_男.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.rJ_RatioButton_人員資料_男.MinimumSize = new System.Drawing.Size(0, 21);
            this.rJ_RatioButton_人員資料_男.Name = "rJ_RatioButton_人員資料_男";
            this.rJ_RatioButton_人員資料_男.Size = new System.Drawing.Size(55, 24);
            this.rJ_RatioButton_人員資料_男.TabIndex = 115;
            this.rJ_RatioButton_人員資料_男.TabStop = true;
            this.rJ_RatioButton_人員資料_男.Text = "男";
            this.rJ_RatioButton_人員資料_男.UncheckColor = System.Drawing.Color.Gray;
            this.rJ_RatioButton_人員資料_男.UseVisualStyleBackColor = false;
            // 
            // rJ_RatioButton_人員資料_女
            // 
            this.rJ_RatioButton_人員資料_女.AutoSize = true;
            this.rJ_RatioButton_人員資料_女.BackColor = System.Drawing.Color.White;
            this.rJ_RatioButton_人員資料_女.CheckColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_RatioButton_人員資料_女.ForeColor = System.Drawing.Color.Black;
            this.rJ_RatioButton_人員資料_女.Location = new System.Drawing.Point(69, 3);
            this.rJ_RatioButton_人員資料_女.MinimumSize = new System.Drawing.Size(0, 21);
            this.rJ_RatioButton_人員資料_女.Name = "rJ_RatioButton_人員資料_女";
            this.rJ_RatioButton_人員資料_女.Size = new System.Drawing.Size(55, 24);
            this.rJ_RatioButton_人員資料_女.TabIndex = 116;
            this.rJ_RatioButton_人員資料_女.Text = "女";
            this.rJ_RatioButton_人員資料_女.UncheckColor = System.Drawing.Color.Gray;
            this.rJ_RatioButton_人員資料_女.UseVisualStyleBackColor = false;
            // 
            // sqL_DataGridView_人員資料
            // 
            this.sqL_DataGridView_人員資料.AutoSelectToDeep = false;
            this.sqL_DataGridView_人員資料.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_人員資料.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_人員資料.BorderRadius = 10;
            this.sqL_DataGridView_人員資料.BorderSize = 2;
            this.sqL_DataGridView_人員資料.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_人員資料.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_人員資料.cellStyleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_人員資料.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_人員資料.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_人員資料.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_人員資料.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_人員資料.columnHeadersHeight = 23;
            this.sqL_DataGridView_人員資料.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_人員資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_人員資料.Columns"))));
            this.sqL_DataGridView_人員資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_人員資料.Columns1"))));
            this.sqL_DataGridView_人員資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_人員資料.Columns2"))));
            this.sqL_DataGridView_人員資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_人員資料.Columns3"))));
            this.sqL_DataGridView_人員資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_人員資料.Columns4"))));
            this.sqL_DataGridView_人員資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_人員資料.Columns5"))));
            this.sqL_DataGridView_人員資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_人員資料.Columns6"))));
            this.sqL_DataGridView_人員資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_人員資料.Columns7"))));
            this.sqL_DataGridView_人員資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_人員資料.Columns8"))));
            this.sqL_DataGridView_人員資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_人員資料.Columns9"))));
            this.sqL_DataGridView_人員資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_人員資料.Columns10"))));
            this.sqL_DataGridView_人員資料.DataBaseName = "Dispensing_000";
            this.sqL_DataGridView_人員資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqL_DataGridView_人員資料.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_人員資料.ImageBox = false;
            this.sqL_DataGridView_人員資料.Location = new System.Drawing.Point(0, 0);
            this.sqL_DataGridView_人員資料.Name = "sqL_DataGridView_人員資料";
            this.sqL_DataGridView_人員資料.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_人員資料.Password = "user82822040";
            this.sqL_DataGridView_人員資料.Port = ((uint)(3306u));
            this.sqL_DataGridView_人員資料.rowHeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.sqL_DataGridView_人員資料.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_人員資料.RowsColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqL_DataGridView_人員資料.RowsHeight = 50;
            this.sqL_DataGridView_人員資料.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_人員資料.Server = "localhost";
            this.sqL_DataGridView_人員資料.Size = new System.Drawing.Size(1630, 514);
            this.sqL_DataGridView_人員資料.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_人員資料.TabIndex = 109;
            this.sqL_DataGridView_人員資料.TableName = "person_page";
            this.sqL_DataGridView_人員資料.UserName = "root";
            this.sqL_DataGridView_人員資料.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_人員資料.可選擇多列 = true;
            this.sqL_DataGridView_人員資料.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_人員資料.自動換行 = true;
            this.sqL_DataGridView_人員資料.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_人員資料.邊框樣式 = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sqL_DataGridView_人員資料.顯示CheckBox = true;
            this.sqL_DataGridView_人員資料.顯示首列 = true;
            this.sqL_DataGridView_人員資料.顯示首行 = true;
            this.sqL_DataGridView_人員資料.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_人員資料.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // plC_RJ_Button_人員資料_刪除
            // 
            this.plC_RJ_Button_人員資料_刪除.AutoResetState = false;
            this.plC_RJ_Button_人員資料_刪除.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_人員資料_刪除.Bool = false;
            this.plC_RJ_Button_人員資料_刪除.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_人員資料_刪除.BorderRadius = 5;
            this.plC_RJ_Button_人員資料_刪除.BorderSize = 0;
            this.plC_RJ_Button_人員資料_刪除.but_press = false;
            this.plC_RJ_Button_人員資料_刪除.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_人員資料_刪除.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_人員資料_刪除.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_人員資料_刪除.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_刪除.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_人員資料_刪除.Location = new System.Drawing.Point(791, 882);
            this.plC_RJ_Button_人員資料_刪除.Name = "plC_RJ_Button_人員資料_刪除";
            this.plC_RJ_Button_人員資料_刪除.OFF_文字內容 = "刪除";
            this.plC_RJ_Button_人員資料_刪除.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_刪除.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_人員資料_刪除.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_人員資料_刪除.ON_BorderSize = 5;
            this.plC_RJ_Button_人員資料_刪除.ON_文字內容 = "刪除";
            this.plC_RJ_Button_人員資料_刪除.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_刪除.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_人員資料_刪除.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_人員資料_刪除.Size = new System.Drawing.Size(75, 46);
            this.plC_RJ_Button_人員資料_刪除.State = false;
            this.plC_RJ_Button_人員資料_刪除.TabIndex = 133;
            this.plC_RJ_Button_人員資料_刪除.Text = "刪除";
            this.plC_RJ_Button_人員資料_刪除.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_人員資料_刪除.Texts = "刪除";
            this.plC_RJ_Button_人員資料_刪除.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_人員資料_刪除.字型鎖住 = false;
            this.plC_RJ_Button_人員資料_刪除.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_人員資料_刪除.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_人員資料_刪除.文字鎖住 = false;
            this.plC_RJ_Button_人員資料_刪除.致能讀取位置 = "S39014";
            this.plC_RJ_Button_人員資料_刪除.讀取位元反向 = false;
            this.plC_RJ_Button_人員資料_刪除.讀寫鎖住 = false;
            this.plC_RJ_Button_人員資料_刪除.音效 = true;
            this.plC_RJ_Button_人員資料_刪除.顯示 = false;
            this.plC_RJ_Button_人員資料_刪除.顯示狀態 = false;
            // 
            // plC_RJ_Button_人員資料_匯出
            // 
            this.plC_RJ_Button_人員資料_匯出.AutoResetState = true;
            this.plC_RJ_Button_人員資料_匯出.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_人員資料_匯出.Bool = false;
            this.plC_RJ_Button_人員資料_匯出.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_人員資料_匯出.BorderRadius = 5;
            this.plC_RJ_Button_人員資料_匯出.BorderSize = 0;
            this.plC_RJ_Button_人員資料_匯出.but_press = false;
            this.plC_RJ_Button_人員資料_匯出.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_人員資料_匯出.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_人員資料_匯出.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_人員資料_匯出.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_匯出.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_人員資料_匯出.Location = new System.Drawing.Point(548, 882);
            this.plC_RJ_Button_人員資料_匯出.Name = "plC_RJ_Button_人員資料_匯出";
            this.plC_RJ_Button_人員資料_匯出.OFF_文字內容 = "匯出";
            this.plC_RJ_Button_人員資料_匯出.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_匯出.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_人員資料_匯出.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_人員資料_匯出.ON_BorderSize = 5;
            this.plC_RJ_Button_人員資料_匯出.ON_文字內容 = "匯出";
            this.plC_RJ_Button_人員資料_匯出.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_匯出.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_人員資料_匯出.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_人員資料_匯出.Size = new System.Drawing.Size(75, 46);
            this.plC_RJ_Button_人員資料_匯出.State = false;
            this.plC_RJ_Button_人員資料_匯出.TabIndex = 130;
            this.plC_RJ_Button_人員資料_匯出.Text = "匯出";
            this.plC_RJ_Button_人員資料_匯出.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_人員資料_匯出.Texts = "匯出";
            this.plC_RJ_Button_人員資料_匯出.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_人員資料_匯出.字型鎖住 = false;
            this.plC_RJ_Button_人員資料_匯出.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_人員資料_匯出.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_人員資料_匯出.文字鎖住 = false;
            this.plC_RJ_Button_人員資料_匯出.致能讀取位置 = "S39014";
            this.plC_RJ_Button_人員資料_匯出.讀取位元反向 = false;
            this.plC_RJ_Button_人員資料_匯出.讀寫鎖住 = false;
            this.plC_RJ_Button_人員資料_匯出.音效 = true;
            this.plC_RJ_Button_人員資料_匯出.顯示 = false;
            this.plC_RJ_Button_人員資料_匯出.顯示狀態 = false;
            // 
            // plC_RJ_Button_人員資料_登錄
            // 
            this.plC_RJ_Button_人員資料_登錄.AutoResetState = false;
            this.plC_RJ_Button_人員資料_登錄.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_人員資料_登錄.Bool = false;
            this.plC_RJ_Button_人員資料_登錄.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_人員資料_登錄.BorderRadius = 5;
            this.plC_RJ_Button_人員資料_登錄.BorderSize = 0;
            this.plC_RJ_Button_人員資料_登錄.but_press = false;
            this.plC_RJ_Button_人員資料_登錄.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_人員資料_登錄.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_人員資料_登錄.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_人員資料_登錄.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_登錄.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_人員資料_登錄.Location = new System.Drawing.Point(710, 882);
            this.plC_RJ_Button_人員資料_登錄.Name = "plC_RJ_Button_人員資料_登錄";
            this.plC_RJ_Button_人員資料_登錄.OFF_文字內容 = "登錄";
            this.plC_RJ_Button_人員資料_登錄.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_登錄.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_人員資料_登錄.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_人員資料_登錄.ON_BorderSize = 5;
            this.plC_RJ_Button_人員資料_登錄.ON_文字內容 = "登錄";
            this.plC_RJ_Button_人員資料_登錄.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_登錄.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_人員資料_登錄.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_人員資料_登錄.Size = new System.Drawing.Size(75, 46);
            this.plC_RJ_Button_人員資料_登錄.State = false;
            this.plC_RJ_Button_人員資料_登錄.TabIndex = 132;
            this.plC_RJ_Button_人員資料_登錄.Text = "登錄";
            this.plC_RJ_Button_人員資料_登錄.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_人員資料_登錄.Texts = "登錄";
            this.plC_RJ_Button_人員資料_登錄.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_人員資料_登錄.字型鎖住 = false;
            this.plC_RJ_Button_人員資料_登錄.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_人員資料_登錄.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_人員資料_登錄.文字鎖住 = false;
            this.plC_RJ_Button_人員資料_登錄.致能讀取位置 = "S39014";
            this.plC_RJ_Button_人員資料_登錄.讀取位元反向 = false;
            this.plC_RJ_Button_人員資料_登錄.讀寫鎖住 = false;
            this.plC_RJ_Button_人員資料_登錄.音效 = true;
            this.plC_RJ_Button_人員資料_登錄.顯示 = false;
            this.plC_RJ_Button_人員資料_登錄.顯示狀態 = false;
            // 
            // plC_RJ_Button_人員資料_匯入
            // 
            this.plC_RJ_Button_人員資料_匯入.AutoResetState = true;
            this.plC_RJ_Button_人員資料_匯入.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.plC_RJ_Button_人員資料_匯入.Bool = false;
            this.plC_RJ_Button_人員資料_匯入.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_人員資料_匯入.BorderRadius = 5;
            this.plC_RJ_Button_人員資料_匯入.BorderSize = 0;
            this.plC_RJ_Button_人員資料_匯入.but_press = false;
            this.plC_RJ_Button_人員資料_匯入.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_人員資料_匯入.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_人員資料_匯入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_人員資料_匯入.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_匯入.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_人員資料_匯入.Location = new System.Drawing.Point(629, 882);
            this.plC_RJ_Button_人員資料_匯入.Name = "plC_RJ_Button_人員資料_匯入";
            this.plC_RJ_Button_人員資料_匯入.OFF_文字內容 = "匯入";
            this.plC_RJ_Button_人員資料_匯入.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_匯入.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_人員資料_匯入.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_人員資料_匯入.ON_BorderSize = 5;
            this.plC_RJ_Button_人員資料_匯入.ON_文字內容 = "匯入";
            this.plC_RJ_Button_人員資料_匯入.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_人員資料_匯入.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_人員資料_匯入.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_人員資料_匯入.Size = new System.Drawing.Size(75, 46);
            this.plC_RJ_Button_人員資料_匯入.State = false;
            this.plC_RJ_Button_人員資料_匯入.TabIndex = 131;
            this.plC_RJ_Button_人員資料_匯入.Text = "匯入";
            this.plC_RJ_Button_人員資料_匯入.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_人員資料_匯入.Texts = "匯入";
            this.plC_RJ_Button_人員資料_匯入.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_人員資料_匯入.字型鎖住 = false;
            this.plC_RJ_Button_人員資料_匯入.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_人員資料_匯入.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_人員資料_匯入.文字鎖住 = false;
            this.plC_RJ_Button_人員資料_匯入.致能讀取位置 = "S39014";
            this.plC_RJ_Button_人員資料_匯入.讀取位元反向 = false;
            this.plC_RJ_Button_人員資料_匯入.讀寫鎖住 = false;
            this.plC_RJ_Button_人員資料_匯入.音效 = true;
            this.plC_RJ_Button_人員資料_匯入.顯示 = false;
            this.plC_RJ_Button_人員資料_匯入.顯示狀態 = false;
            // 
            // 權限管理
            // 
            this.權限管理.BackColor = System.Drawing.Color.White;
            this.權限管理.Controls.Add(this.rJ_GroupBox16);
            this.權限管理.Location = new System.Drawing.Point(4, 25);
            this.權限管理.Name = "權限管理";
            this.權限管理.Size = new System.Drawing.Size(1630, 906);
            this.權限管理.TabIndex = 1;
            this.權限管理.Text = "權限管理";
            // 
            // rJ_GroupBox16
            // 
            // 
            // rJ_GroupBox16.ContentsPanel
            // 
            this.rJ_GroupBox16.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox16.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox16.ContentsPanel.BorderRadius = 2;
            this.rJ_GroupBox16.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox16.ContentsPanel.Controls.Add(this.loginIndex_Pannel);
            this.rJ_GroupBox16.ContentsPanel.Controls.Add(this.plC_Button_權限設定_設定至Server);
            this.rJ_GroupBox16.ContentsPanel.Controls.Add(this.plC_RJ_ComboBox_權限管理_權限等級);
            this.rJ_GroupBox16.ContentsPanel.Controls.Add(this.rJ_Lable23);
            this.rJ_GroupBox16.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox16.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox16.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox16.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox16.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox16.ContentsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.rJ_GroupBox16.ContentsPanel.Size = new System.Drawing.Size(1630, 869);
            this.rJ_GroupBox16.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox16.Location = new System.Drawing.Point(0, 0);
            this.rJ_GroupBox16.Name = "rJ_GroupBox16";
            this.rJ_GroupBox16.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox16.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox16.PannelBorderRadius = 2;
            this.rJ_GroupBox16.PannelBorderSize = 2;
            this.rJ_GroupBox16.Size = new System.Drawing.Size(1630, 906);
            this.rJ_GroupBox16.TabIndex = 110;
            this.rJ_GroupBox16.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox16.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox16.TitleBorderRadius = 5;
            this.rJ_GroupBox16.TitleBorderSize = 0;
            this.rJ_GroupBox16.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.rJ_GroupBox16.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox16.TitleHeight = 37;
            this.rJ_GroupBox16.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox16.TitleTexts = "權限內容設定";
            // 
            // loginIndex_Pannel
            // 
            this.loginIndex_Pannel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginIndex_Pannel.CheckBox_OffBackColor = System.Drawing.Color.Gray;
            this.loginIndex_Pannel.CheckBox_OffToggleColor = System.Drawing.Color.Gainsboro;
            this.loginIndex_Pannel.CheckBox_OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.loginIndex_Pannel.CheckBox_OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.loginIndex_Pannel.CheckBox_SolidStyle = true;
            this.loginIndex_Pannel.CheckBoxWidth = 80;
            this.loginIndex_Pannel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.loginIndex_Pannel.Index = -1;
            this.loginIndex_Pannel.Location = new System.Drawing.Point(5, 57);
            this.loginIndex_Pannel.LoginIndex = ((System.Collections.Generic.List<string>)(resources.GetObject("loginIndex_Pannel.LoginIndex")));
            this.loginIndex_Pannel.Name = "loginIndex_Pannel";
            this.loginIndex_Pannel.PanelHeight = 40;
            this.loginIndex_Pannel.PanelWidth = 310;
            this.loginIndex_Pannel.Show_Index = true;
            this.loginIndex_Pannel.Size = new System.Drawing.Size(1620, 807);
            this.loginIndex_Pannel.SpaceWidth = 10;
            this.loginIndex_Pannel.TabIndex = 121;
            this.loginIndex_Pannel.Title_BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.loginIndex_Pannel.Title_BorderColor = System.Drawing.Color.PaleVioletRed;
            this.loginIndex_Pannel.Title_BorderRadius = 5;
            this.loginIndex_Pannel.Title_BorderSize = 0;
            this.loginIndex_Pannel.Title_Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.loginIndex_Pannel.Title_TextColor = System.Drawing.Color.White;
            this.loginIndex_Pannel.TitleTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginIndex_Pannel.TitleWidth = 100;
            // 
            // plC_Button_權限設定_設定至Server
            // 
            this.plC_Button_權限設定_設定至Server.AutoResetState = false;
            this.plC_Button_權限設定_設定至Server.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_Button_權限設定_設定至Server.Bool = false;
            this.plC_Button_權限設定_設定至Server.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_Button_權限設定_設定至Server.BorderRadius = 5;
            this.plC_Button_權限設定_設定至Server.BorderSize = 0;
            this.plC_Button_權限設定_設定至Server.but_press = false;
            this.plC_Button_權限設定_設定至Server.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_Button_權限設定_設定至Server.FlatAppearance.BorderSize = 0;
            this.plC_Button_權限設定_設定至Server.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_Button_權限設定_設定至Server.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_Button_權限設定_設定至Server.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button_權限設定_設定至Server.Location = new System.Drawing.Point(295, 5);
            this.plC_Button_權限設定_設定至Server.Name = "plC_Button_權限設定_設定至Server";
            this.plC_Button_權限設定_設定至Server.OFF_文字內容 = "上傳資料";
            this.plC_Button_權限設定_設定至Server.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_Button_權限設定_設定至Server.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_Button_權限設定_設定至Server.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_權限設定_設定至Server.ON_BorderSize = 5;
            this.plC_Button_權限設定_設定至Server.ON_文字內容 = "上傳資料";
            this.plC_Button_權限設定_設定至Server.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_Button_權限設定_設定至Server.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button_權限設定_設定至Server.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_權限設定_設定至Server.Size = new System.Drawing.Size(136, 58);
            this.plC_Button_權限設定_設定至Server.State = false;
            this.plC_Button_權限設定_設定至Server.TabIndex = 120;
            this.plC_Button_權限設定_設定至Server.Text = "上傳資料";
            this.plC_Button_權限設定_設定至Server.TextColor = System.Drawing.Color.White;
            this.plC_Button_權限設定_設定至Server.UseVisualStyleBackColor = false;
            this.plC_Button_權限設定_設定至Server.字型鎖住 = false;
            this.plC_Button_權限設定_設定至Server.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.交替型;
            this.plC_Button_權限設定_設定至Server.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_Button_權限設定_設定至Server.文字鎖住 = false;
            this.plC_Button_權限設定_設定至Server.致能讀取位置 = "S39014";
            this.plC_Button_權限設定_設定至Server.讀取位元反向 = false;
            this.plC_Button_權限設定_設定至Server.讀寫鎖住 = false;
            this.plC_Button_權限設定_設定至Server.音效 = true;
            this.plC_Button_權限設定_設定至Server.顯示 = false;
            this.plC_Button_權限設定_設定至Server.顯示狀態 = false;
            // 
            // plC_RJ_ComboBox_權限管理_權限等級
            // 
            this.plC_RJ_ComboBox_權限管理_權限等級.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plC_RJ_ComboBox_權限管理_權限等級.BorderColor = System.Drawing.Color.LightSteelBlue;
            this.plC_RJ_ComboBox_權限管理_權限等級.BorderSize = 1;
            this.plC_RJ_ComboBox_權限管理_權限等級.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.plC_RJ_ComboBox_權限管理_權限等級.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ComboBox_權限管理_權限等級.ForeColor = System.Drawing.Color.DimGray;
            this.plC_RJ_ComboBox_權限管理_權限等級.IconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ComboBox_權限管理_權限等級.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.plC_RJ_ComboBox_權限管理_權限等級.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.plC_RJ_ComboBox_權限管理_權限等級.ListTextColor = System.Drawing.Color.DimGray;
            this.plC_RJ_ComboBox_權限管理_權限等級.Location = new System.Drawing.Point(144, 19);
            this.plC_RJ_ComboBox_權限管理_權限等級.MinimumSize = new System.Drawing.Size(100, 30);
            this.plC_RJ_ComboBox_權限管理_權限等級.Name = "plC_RJ_ComboBox_權限管理_權限等級";
            this.plC_RJ_ComboBox_權限管理_權限等級.Padding = new System.Windows.Forms.Padding(1);
            this.plC_RJ_ComboBox_權限管理_權限等級.Size = new System.Drawing.Size(100, 30);
            this.plC_RJ_ComboBox_權限管理_權限等級.TabIndex = 111;
            this.plC_RJ_ComboBox_權限管理_權限等級.Texts = "";
            this.plC_RJ_ComboBox_權限管理_權限等級.音效 = true;
            // 
            // rJ_Lable23
            // 
            this.rJ_Lable23.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rJ_Lable23.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.rJ_Lable23.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable23.BorderRadius = 12;
            this.rJ_Lable23.BorderSize = 0;
            this.rJ_Lable23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable23.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable23.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable23.Location = new System.Drawing.Point(29, 14);
            this.rJ_Lable23.Name = "rJ_Lable23";
            this.rJ_Lable23.Size = new System.Drawing.Size(107, 40);
            this.rJ_Lable23.TabIndex = 110;
            this.rJ_Lable23.Text = "權限等級";
            this.rJ_Lable23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable23.TextColor = System.Drawing.Color.Black;
            // 
            // panel_人員資料
            // 
            this.panel_人員資料.Controls.Add(this.plC_RJ_ScreenButton11);
            this.panel_人員資料.Controls.Add(this.plC_RJ_ScreenButton12);
            this.panel_人員資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_人員資料.Location = new System.Drawing.Point(0, 0);
            this.panel_人員資料.Name = "panel_人員資料";
            this.panel_人員資料.Size = new System.Drawing.Size(1638, 51);
            this.panel_人員資料.TabIndex = 117;
            // 
            // plC_RJ_ScreenButton11
            // 
            this.plC_RJ_ScreenButton11.but_press = false;
            this.plC_RJ_ScreenButton11.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton11.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton11.IconSize = 32;
            this.plC_RJ_ScreenButton11.Location = new System.Drawing.Point(172, 0);
            this.plC_RJ_ScreenButton11.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton11.Name = "plC_RJ_ScreenButton11";
            this.plC_RJ_ScreenButton11.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton11.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton11.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton11.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton11.OffText = "權限管理";
            this.plC_RJ_ScreenButton11.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton11.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton11.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton11.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton11.OnText = "權限管理";
            this.plC_RJ_ScreenButton11.ShowIcon = false;
            this.plC_RJ_ScreenButton11.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton11.TabIndex = 1;
            this.plC_RJ_ScreenButton11.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton11.寫入位置註解 = "";
            this.plC_RJ_ScreenButton11.寫入元件位置 = "";
            this.plC_RJ_ScreenButton11.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton11.控制位址 = "D0";
            this.plC_RJ_ScreenButton11.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton11.致能讀取位置 = "";
            this.plC_RJ_ScreenButton11.讀取位元反向 = false;
            this.plC_RJ_ScreenButton11.讀取位置註解 = "";
            this.plC_RJ_ScreenButton11.讀取元件位置 = "";
            this.plC_RJ_ScreenButton11.音效 = true;
            this.plC_RJ_ScreenButton11.頁面名稱 = "權限管理";
            this.plC_RJ_ScreenButton11.頁面編號 = 0;
            this.plC_RJ_ScreenButton11.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton11.顯示狀態 = false;
            this.plC_RJ_ScreenButton11.顯示讀取位置 = "S39017";
            // 
            // plC_RJ_ScreenButton12
            // 
            this.plC_RJ_ScreenButton12.but_press = false;
            this.plC_RJ_ScreenButton12.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton12.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton12.IconSize = 32;
            this.plC_RJ_ScreenButton12.Location = new System.Drawing.Point(0, 0);
            this.plC_RJ_ScreenButton12.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton12.Name = "plC_RJ_ScreenButton12";
            this.plC_RJ_ScreenButton12.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton12.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton12.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton12.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton12.OffText = "資料維護";
            this.plC_RJ_ScreenButton12.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton12.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton12.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton12.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton12.OnText = "資料維護";
            this.plC_RJ_ScreenButton12.ShowIcon = false;
            this.plC_RJ_ScreenButton12.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton12.TabIndex = 0;
            this.plC_RJ_ScreenButton12.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton12.寫入位置註解 = "";
            this.plC_RJ_ScreenButton12.寫入元件位置 = "";
            this.plC_RJ_ScreenButton12.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton12.控制位址 = "D0";
            this.plC_RJ_ScreenButton12.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton12.致能讀取位置 = "";
            this.plC_RJ_ScreenButton12.讀取位元反向 = false;
            this.plC_RJ_ScreenButton12.讀取位置註解 = "";
            this.plC_RJ_ScreenButton12.讀取元件位置 = "";
            this.plC_RJ_ScreenButton12.音效 = true;
            this.plC_RJ_ScreenButton12.頁面名稱 = "資料維護";
            this.plC_RJ_ScreenButton12.頁面編號 = 0;
            this.plC_RJ_ScreenButton12.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton12.顯示狀態 = false;
            this.plC_RJ_ScreenButton12.顯示讀取位置 = "";
            // 
            // 儲位管理
            // 
            this.儲位管理.BackColor = System.Drawing.Color.White;
            this.儲位管理.Controls.Add(this.rJ_GroupBox1);
            this.儲位管理.Controls.Add(this.panel20);
            this.儲位管理.Location = new System.Drawing.Point(4, 25);
            this.儲位管理.Name = "儲位管理";
            this.儲位管理.Size = new System.Drawing.Size(1638, 986);
            this.儲位管理.TabIndex = 9;
            this.儲位管理.Text = "儲位管理";
            // 
            // rJ_GroupBox1
            // 
            // 
            // rJ_GroupBox1.ContentsPanel
            // 
            this.rJ_GroupBox1.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox1.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox1.ContentsPanel.BorderRadius = 5;
            this.rJ_GroupBox1.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox1.ContentsPanel.Controls.Add(this.plC_Button143);
            this.rJ_GroupBox1.ContentsPanel.Controls.Add(this.plC_RJ_Button_儲位設定_出料一次);
            this.rJ_GroupBox1.ContentsPanel.Controls.Add(this.plC_RJ_Button_儲位設定_滅燈);
            this.rJ_GroupBox1.ContentsPanel.Controls.Add(this.plC_RJ_Button_儲位設定_亮燈);
            this.rJ_GroupBox1.ContentsPanel.Controls.Add(this.plC_RJ_Button_儲位設定_亮燈範圍填入);
            this.rJ_GroupBox1.ContentsPanel.Controls.Add(this.groupBox1);
            this.rJ_GroupBox1.ContentsPanel.Controls.Add(this.rowsLED_Pannel_儲位管理_儲位號碼);
            this.rJ_GroupBox1.ContentsPanel.Controls.Add(this.plC_NumBox_儲位管理_起始號碼);
            this.rJ_GroupBox1.ContentsPanel.Controls.Add(this.rJ_Lable4);
            this.rJ_GroupBox1.ContentsPanel.Controls.Add(this.rJ_Lable3);
            this.rJ_GroupBox1.ContentsPanel.Controls.Add(this.plC_NumBox_儲位管理_結束號碼);
            this.rJ_GroupBox1.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox1.ContentsPanel.ForeColor = System.Drawing.Color.Black;
            this.rJ_GroupBox1.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox1.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox1.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox1.ContentsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.rJ_GroupBox1.ContentsPanel.Size = new System.Drawing.Size(1638, 263);
            this.rJ_GroupBox1.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.rJ_GroupBox1.Location = new System.Drawing.Point(0, 854);
            this.rJ_GroupBox1.Name = "rJ_GroupBox1";
            this.rJ_GroupBox1.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox1.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox1.PannelBorderRadius = 5;
            this.rJ_GroupBox1.PannelBorderSize = 2;
            this.rJ_GroupBox1.Size = new System.Drawing.Size(1638, 300);
            this.rJ_GroupBox1.TabIndex = 8;
            this.rJ_GroupBox1.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox1.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox1.TitleBorderRadius = 5;
            this.rJ_GroupBox1.TitleBorderSize = 0;
            this.rJ_GroupBox1.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.rJ_GroupBox1.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox1.TitleHeight = 37;
            this.rJ_GroupBox1.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox1.TitleTexts = "儲位設定";
            // 
            // plC_Button143
            // 
            this.plC_Button143.Bool = false;
            this.plC_Button143.but_press = false;
            this.plC_Button143.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button143.Location = new System.Drawing.Point(610, 12);
            this.plC_Button143.Name = "plC_Button143";
            this.plC_Button143.OFF_文字內容 = "門鎖";
            this.plC_Button143.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button143.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button143.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button143.ON_文字內容 = "門鎖";
            this.plC_Button143.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button143.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button143.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button143.Size = new System.Drawing.Size(153, 62);
            this.plC_Button143.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button143.TabIndex = 152;
            this.plC_Button143.事件驅動 = false;
            this.plC_Button143.字型鎖住 = false;
            this.plC_Button143.寫入元件位置 = "M136";
            this.plC_Button143.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button143.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button143.文字鎖住 = false;
            this.plC_Button143.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button143.狀態OFF圖片")));
            this.plC_Button143.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button143.狀態ON圖片")));
            this.plC_Button143.讀取位元反向 = false;
            this.plC_Button143.讀取元件位置 = "M136";
            this.plC_Button143.讀寫鎖住 = false;
            this.plC_Button143.起始狀態 = false;
            this.plC_Button143.音效 = true;
            this.plC_Button143.顯示 = false;
            this.plC_Button143.顯示狀態 = false;
            // 
            // plC_RJ_Button_儲位設定_出料一次
            // 
            this.plC_RJ_Button_儲位設定_出料一次.AutoResetState = false;
            this.plC_RJ_Button_儲位設定_出料一次.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位設定_出料一次.Bool = false;
            this.plC_RJ_Button_儲位設定_出料一次.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位設定_出料一次.BorderRadius = 5;
            this.plC_RJ_Button_儲位設定_出料一次.BorderSize = 0;
            this.plC_RJ_Button_儲位設定_出料一次.but_press = false;
            this.plC_RJ_Button_儲位設定_出料一次.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位設定_出料一次.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位設定_出料一次.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位設定_出料一次.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位設定_出料一次.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位設定_出料一次.Location = new System.Drawing.Point(1079, 12);
            this.plC_RJ_Button_儲位設定_出料一次.Name = "plC_RJ_Button_儲位設定_出料一次";
            this.plC_RJ_Button_儲位設定_出料一次.OFF_文字內容 = "出料一次";
            this.plC_RJ_Button_儲位設定_出料一次.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位設定_出料一次.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位設定_出料一次.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位設定_出料一次.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位設定_出料一次.ON_文字內容 = "出料一次";
            this.plC_RJ_Button_儲位設定_出料一次.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位設定_出料一次.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位設定_出料一次.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位設定_出料一次.Size = new System.Drawing.Size(149, 64);
            this.plC_RJ_Button_儲位設定_出料一次.State = false;
            this.plC_RJ_Button_儲位設定_出料一次.TabIndex = 139;
            this.plC_RJ_Button_儲位設定_出料一次.Text = "出料一次";
            this.plC_RJ_Button_儲位設定_出料一次.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位設定_出料一次.Texts = "出料一次";
            this.plC_RJ_Button_儲位設定_出料一次.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位設定_出料一次.字型鎖住 = false;
            this.plC_RJ_Button_儲位設定_出料一次.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位設定_出料一次.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位設定_出料一次.文字鎖住 = false;
            this.plC_RJ_Button_儲位設定_出料一次.讀取位元反向 = false;
            this.plC_RJ_Button_儲位設定_出料一次.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位設定_出料一次.音效 = true;
            this.plC_RJ_Button_儲位設定_出料一次.顯示 = false;
            this.plC_RJ_Button_儲位設定_出料一次.顯示狀態 = false;
            // 
            // plC_RJ_Button_儲位設定_滅燈
            // 
            this.plC_RJ_Button_儲位設定_滅燈.AutoResetState = false;
            this.plC_RJ_Button_儲位設定_滅燈.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位設定_滅燈.Bool = false;
            this.plC_RJ_Button_儲位設定_滅燈.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位設定_滅燈.BorderRadius = 5;
            this.plC_RJ_Button_儲位設定_滅燈.BorderSize = 0;
            this.plC_RJ_Button_儲位設定_滅燈.but_press = false;
            this.plC_RJ_Button_儲位設定_滅燈.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位設定_滅燈.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位設定_滅燈.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位設定_滅燈.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位設定_滅燈.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位設定_滅燈.Location = new System.Drawing.Point(769, 11);
            this.plC_RJ_Button_儲位設定_滅燈.Name = "plC_RJ_Button_儲位設定_滅燈";
            this.plC_RJ_Button_儲位設定_滅燈.OFF_文字內容 = "滅燈";
            this.plC_RJ_Button_儲位設定_滅燈.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位設定_滅燈.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位設定_滅燈.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位設定_滅燈.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位設定_滅燈.ON_文字內容 = "滅燈";
            this.plC_RJ_Button_儲位設定_滅燈.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位設定_滅燈.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位設定_滅燈.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位設定_滅燈.Size = new System.Drawing.Size(149, 64);
            this.plC_RJ_Button_儲位設定_滅燈.State = false;
            this.plC_RJ_Button_儲位設定_滅燈.TabIndex = 138;
            this.plC_RJ_Button_儲位設定_滅燈.Text = "滅燈";
            this.plC_RJ_Button_儲位設定_滅燈.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位設定_滅燈.Texts = "滅燈";
            this.plC_RJ_Button_儲位設定_滅燈.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位設定_滅燈.字型鎖住 = false;
            this.plC_RJ_Button_儲位設定_滅燈.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位設定_滅燈.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位設定_滅燈.文字鎖住 = false;
            this.plC_RJ_Button_儲位設定_滅燈.讀取位元反向 = false;
            this.plC_RJ_Button_儲位設定_滅燈.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位設定_滅燈.音效 = true;
            this.plC_RJ_Button_儲位設定_滅燈.顯示 = false;
            this.plC_RJ_Button_儲位設定_滅燈.顯示狀態 = false;
            // 
            // plC_RJ_Button_儲位設定_亮燈
            // 
            this.plC_RJ_Button_儲位設定_亮燈.AutoResetState = false;
            this.plC_RJ_Button_儲位設定_亮燈.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位設定_亮燈.Bool = false;
            this.plC_RJ_Button_儲位設定_亮燈.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位設定_亮燈.BorderRadius = 5;
            this.plC_RJ_Button_儲位設定_亮燈.BorderSize = 0;
            this.plC_RJ_Button_儲位設定_亮燈.but_press = false;
            this.plC_RJ_Button_儲位設定_亮燈.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位設定_亮燈.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位設定_亮燈.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位設定_亮燈.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位設定_亮燈.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位設定_亮燈.Location = new System.Drawing.Point(924, 11);
            this.plC_RJ_Button_儲位設定_亮燈.Name = "plC_RJ_Button_儲位設定_亮燈";
            this.plC_RJ_Button_儲位設定_亮燈.OFF_文字內容 = "亮燈";
            this.plC_RJ_Button_儲位設定_亮燈.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位設定_亮燈.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位設定_亮燈.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位設定_亮燈.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位設定_亮燈.ON_文字內容 = "亮燈";
            this.plC_RJ_Button_儲位設定_亮燈.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位設定_亮燈.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位設定_亮燈.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位設定_亮燈.Size = new System.Drawing.Size(149, 64);
            this.plC_RJ_Button_儲位設定_亮燈.State = false;
            this.plC_RJ_Button_儲位設定_亮燈.TabIndex = 137;
            this.plC_RJ_Button_儲位設定_亮燈.Text = "亮燈";
            this.plC_RJ_Button_儲位設定_亮燈.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位設定_亮燈.Texts = "亮燈";
            this.plC_RJ_Button_儲位設定_亮燈.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位設定_亮燈.字型鎖住 = false;
            this.plC_RJ_Button_儲位設定_亮燈.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位設定_亮燈.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位設定_亮燈.文字鎖住 = false;
            this.plC_RJ_Button_儲位設定_亮燈.讀取位元反向 = false;
            this.plC_RJ_Button_儲位設定_亮燈.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位設定_亮燈.音效 = true;
            this.plC_RJ_Button_儲位設定_亮燈.顯示 = false;
            this.plC_RJ_Button_儲位設定_亮燈.顯示狀態 = false;
            // 
            // plC_RJ_Button_儲位設定_亮燈範圍填入
            // 
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.AutoResetState = false;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.Bool = false;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.BorderRadius = 5;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.BorderSize = 0;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.but_press = false;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.Location = new System.Drawing.Point(1243, 12);
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.Name = "plC_RJ_Button_儲位設定_亮燈範圍填入";
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.OFF_文字內容 = "亮燈範圍填入";
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.ON_文字內容 = "亮燈範圍填入";
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.Size = new System.Drawing.Size(267, 64);
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.State = false;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.TabIndex = 136;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.Text = "亮燈範圍填入";
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.Texts = "亮燈範圍填入";
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.字型鎖住 = false;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.文字鎖住 = false;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.讀取位元反向 = false;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.音效 = true;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.顯示 = false;
            this.plC_RJ_Button_儲位設定_亮燈範圍填入.顯示狀態 = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rJ_RatioButton_儲位管理_第一層);
            this.groupBox1.Controls.Add(this.rJ_RatioButton_儲位管理_第二層);
            this.groupBox1.Controls.Add(this.rJ_RatioButton_儲位管理_第三層);
            this.groupBox1.Controls.Add(this.rJ_RatioButton_儲位管理_第四層);
            this.groupBox1.Controls.Add(this.rJ_RatioButton_儲位管理_第五層);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "層數選擇";
            this.groupBox1.Visible = false;
            // 
            // rJ_RatioButton_儲位管理_第一層
            // 
            this.rJ_RatioButton_儲位管理_第一層.AutoSize = true;
            this.rJ_RatioButton_儲位管理_第一層.CheckColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_RatioButton_儲位管理_第一層.Checked = true;
            this.rJ_RatioButton_儲位管理_第一層.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_RatioButton_儲位管理_第一層.Location = new System.Drawing.Point(16, 178);
            this.rJ_RatioButton_儲位管理_第一層.MinimumSize = new System.Drawing.Size(0, 21);
            this.rJ_RatioButton_儲位管理_第一層.Name = "rJ_RatioButton_儲位管理_第一層";
            this.rJ_RatioButton_儲位管理_第一層.Size = new System.Drawing.Size(105, 31);
            this.rJ_RatioButton_儲位管理_第一層.TabIndex = 4;
            this.rJ_RatioButton_儲位管理_第一層.TabStop = true;
            this.rJ_RatioButton_儲位管理_第一層.Text = "第一層";
            this.rJ_RatioButton_儲位管理_第一層.UncheckColor = System.Drawing.Color.Gray;
            this.rJ_RatioButton_儲位管理_第一層.UseVisualStyleBackColor = true;
            // 
            // rJ_RatioButton_儲位管理_第二層
            // 
            this.rJ_RatioButton_儲位管理_第二層.AutoSize = true;
            this.rJ_RatioButton_儲位管理_第二層.CheckColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_RatioButton_儲位管理_第二層.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_RatioButton_儲位管理_第二層.Location = new System.Drawing.Point(16, 142);
            this.rJ_RatioButton_儲位管理_第二層.MinimumSize = new System.Drawing.Size(0, 21);
            this.rJ_RatioButton_儲位管理_第二層.Name = "rJ_RatioButton_儲位管理_第二層";
            this.rJ_RatioButton_儲位管理_第二層.Size = new System.Drawing.Size(105, 31);
            this.rJ_RatioButton_儲位管理_第二層.TabIndex = 3;
            this.rJ_RatioButton_儲位管理_第二層.Text = "第二層";
            this.rJ_RatioButton_儲位管理_第二層.UncheckColor = System.Drawing.Color.Gray;
            this.rJ_RatioButton_儲位管理_第二層.UseVisualStyleBackColor = true;
            // 
            // rJ_RatioButton_儲位管理_第三層
            // 
            this.rJ_RatioButton_儲位管理_第三層.AutoSize = true;
            this.rJ_RatioButton_儲位管理_第三層.CheckColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_RatioButton_儲位管理_第三層.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_RatioButton_儲位管理_第三層.Location = new System.Drawing.Point(16, 106);
            this.rJ_RatioButton_儲位管理_第三層.MinimumSize = new System.Drawing.Size(0, 21);
            this.rJ_RatioButton_儲位管理_第三層.Name = "rJ_RatioButton_儲位管理_第三層";
            this.rJ_RatioButton_儲位管理_第三層.Size = new System.Drawing.Size(105, 31);
            this.rJ_RatioButton_儲位管理_第三層.TabIndex = 2;
            this.rJ_RatioButton_儲位管理_第三層.Text = "第三層";
            this.rJ_RatioButton_儲位管理_第三層.UncheckColor = System.Drawing.Color.Gray;
            this.rJ_RatioButton_儲位管理_第三層.UseVisualStyleBackColor = true;
            // 
            // rJ_RatioButton_儲位管理_第四層
            // 
            this.rJ_RatioButton_儲位管理_第四層.AutoSize = true;
            this.rJ_RatioButton_儲位管理_第四層.CheckColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_RatioButton_儲位管理_第四層.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_RatioButton_儲位管理_第四層.Location = new System.Drawing.Point(16, 70);
            this.rJ_RatioButton_儲位管理_第四層.MinimumSize = new System.Drawing.Size(0, 21);
            this.rJ_RatioButton_儲位管理_第四層.Name = "rJ_RatioButton_儲位管理_第四層";
            this.rJ_RatioButton_儲位管理_第四層.Size = new System.Drawing.Size(105, 31);
            this.rJ_RatioButton_儲位管理_第四層.TabIndex = 1;
            this.rJ_RatioButton_儲位管理_第四層.Text = "第四層";
            this.rJ_RatioButton_儲位管理_第四層.UncheckColor = System.Drawing.Color.Gray;
            this.rJ_RatioButton_儲位管理_第四層.UseVisualStyleBackColor = true;
            // 
            // rJ_RatioButton_儲位管理_第五層
            // 
            this.rJ_RatioButton_儲位管理_第五層.AutoSize = true;
            this.rJ_RatioButton_儲位管理_第五層.CheckColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_RatioButton_儲位管理_第五層.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_RatioButton_儲位管理_第五層.Location = new System.Drawing.Point(16, 34);
            this.rJ_RatioButton_儲位管理_第五層.MinimumSize = new System.Drawing.Size(0, 21);
            this.rJ_RatioButton_儲位管理_第五層.Name = "rJ_RatioButton_儲位管理_第五層";
            this.rJ_RatioButton_儲位管理_第五層.Size = new System.Drawing.Size(105, 31);
            this.rJ_RatioButton_儲位管理_第五層.TabIndex = 0;
            this.rJ_RatioButton_儲位管理_第五層.Text = "第五層";
            this.rJ_RatioButton_儲位管理_第五層.UncheckColor = System.Drawing.Color.Gray;
            this.rJ_RatioButton_儲位管理_第五層.UseVisualStyleBackColor = true;
            // 
            // rowsLED_Pannel_儲位管理_儲位號碼
            // 
            this.rowsLED_Pannel_儲位管理_儲位號碼.AutoWrite = true;
            this.rowsLED_Pannel_儲位管理_儲位號碼.BackColor = System.Drawing.SystemColors.Window;
            this.rowsLED_Pannel_儲位管理_儲位號碼.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rowsLED_Pannel_儲位管理_儲位號碼.BarFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rowsLED_Pannel_儲位管理_儲位號碼.BarForeColor = System.Drawing.Color.Black;
            this.rowsLED_Pannel_儲位管理_儲位號碼.BarSize = 50;
            this.rowsLED_Pannel_儲位管理_儲位號碼.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rowsLED_Pannel_儲位管理_儲位號碼.BottomSliderColor = System.Drawing.Color.Red;
            this.rowsLED_Pannel_儲位管理_儲位號碼.CurrentRowsDevice = null;
            this.rowsLED_Pannel_儲位管理_儲位號碼.CurrentRowsLED = null;
            this.rowsLED_Pannel_儲位管理_儲位號碼.Location = new System.Drawing.Point(156, 82);
            this.rowsLED_Pannel_儲位管理_儲位號碼.Maximum = 100;
            this.rowsLED_Pannel_儲位管理_儲位號碼.MaxValue = 0;
            this.rowsLED_Pannel_儲位管理_儲位號碼.Minimum = 0;
            this.rowsLED_Pannel_儲位管理_儲位號碼.MinValue = 0;
            this.rowsLED_Pannel_儲位管理_儲位號碼.Name = "rowsLED_Pannel_儲位管理_儲位號碼";
            this.rowsLED_Pannel_儲位管理_儲位號碼.RowsDeviceGUID = "";
            this.rowsLED_Pannel_儲位管理_儲位號碼.Size = new System.Drawing.Size(1295, 160);
            this.rowsLED_Pannel_儲位管理_儲位號碼.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rowsLED_Pannel_儲位管理_儲位號碼.SliderSize = 30;
            this.rowsLED_Pannel_儲位管理_儲位號碼.TabIndex = 5;
            this.rowsLED_Pannel_儲位管理_儲位號碼.TopSliderColor = System.Drawing.Color.Silver;
            this.rowsLED_Pannel_儲位管理_儲位號碼.Visible = false;
            // 
            // plC_NumBox_儲位管理_起始號碼
            // 
            this.plC_NumBox_儲位管理_起始號碼.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_NumBox_儲位管理_起始號碼.Location = new System.Drawing.Point(279, 19);
            this.plC_NumBox_儲位管理_起始號碼.mBackColor = System.Drawing.SystemColors.Window;
            this.plC_NumBox_儲位管理_起始號碼.mForeColor = System.Drawing.SystemColors.WindowText;
            this.plC_NumBox_儲位管理_起始號碼.Name = "plC_NumBox_儲位管理_起始號碼";
            this.plC_NumBox_儲位管理_起始號碼.ReadOnly = false;
            this.plC_NumBox_儲位管理_起始號碼.Size = new System.Drawing.Size(79, 46);
            this.plC_NumBox_儲位管理_起始號碼.TabIndex = 1;
            this.plC_NumBox_儲位管理_起始號碼.Value = 0;
            this.plC_NumBox_儲位管理_起始號碼.字元長度 = MyUI.PLC_NumBox.WordLengthEnum.單字元;
            this.plC_NumBox_儲位管理_起始號碼.密碼欄位 = false;
            this.plC_NumBox_儲位管理_起始號碼.小數點位置 = 0;
            this.plC_NumBox_儲位管理_起始號碼.微調數值 = 1;
            this.plC_NumBox_儲位管理_起始號碼.致能讀取位置 = "M8000";
            this.plC_NumBox_儲位管理_起始號碼.音效 = true;
            this.plC_NumBox_儲位管理_起始號碼.顯示微調按鈕 = false;
            this.plC_NumBox_儲位管理_起始號碼.顯示螢幕小鍵盤 = true;
            // 
            // rJ_Lable4
            // 
            this.rJ_Lable4.BackColor = System.Drawing.Color.RoyalBlue;
            this.rJ_Lable4.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rJ_Lable4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable4.BorderRadius = 12;
            this.rJ_Lable4.BorderSize = 0;
            this.rJ_Lable4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable4.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable4.ForeColor = System.Drawing.Color.White;
            this.rJ_Lable4.Location = new System.Drawing.Point(378, 12);
            this.rJ_Lable4.Name = "rJ_Lable4";
            this.rJ_Lable4.Size = new System.Drawing.Size(121, 53);
            this.rJ_Lable4.TabIndex = 4;
            this.rJ_Lable4.Text = "結束號碼";
            this.rJ_Lable4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable4.TextColor = System.Drawing.Color.White;
            // 
            // rJ_Lable3
            // 
            this.rJ_Lable3.BackColor = System.Drawing.Color.RoyalBlue;
            this.rJ_Lable3.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.rJ_Lable3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable3.BorderRadius = 12;
            this.rJ_Lable3.BorderSize = 0;
            this.rJ_Lable3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable3.ForeColor = System.Drawing.Color.White;
            this.rJ_Lable3.Location = new System.Drawing.Point(152, 12);
            this.rJ_Lable3.Name = "rJ_Lable3";
            this.rJ_Lable3.Size = new System.Drawing.Size(121, 53);
            this.rJ_Lable3.TabIndex = 2;
            this.rJ_Lable3.Text = "起始號碼";
            this.rJ_Lable3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable3.TextColor = System.Drawing.Color.White;
            // 
            // plC_NumBox_儲位管理_結束號碼
            // 
            this.plC_NumBox_儲位管理_結束號碼.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_NumBox_儲位管理_結束號碼.Location = new System.Drawing.Point(505, 19);
            this.plC_NumBox_儲位管理_結束號碼.mBackColor = System.Drawing.SystemColors.Window;
            this.plC_NumBox_儲位管理_結束號碼.mForeColor = System.Drawing.SystemColors.WindowText;
            this.plC_NumBox_儲位管理_結束號碼.Name = "plC_NumBox_儲位管理_結束號碼";
            this.plC_NumBox_儲位管理_結束號碼.ReadOnly = false;
            this.plC_NumBox_儲位管理_結束號碼.Size = new System.Drawing.Size(79, 46);
            this.plC_NumBox_儲位管理_結束號碼.TabIndex = 3;
            this.plC_NumBox_儲位管理_結束號碼.Value = 0;
            this.plC_NumBox_儲位管理_結束號碼.字元長度 = MyUI.PLC_NumBox.WordLengthEnum.單字元;
            this.plC_NumBox_儲位管理_結束號碼.密碼欄位 = false;
            this.plC_NumBox_儲位管理_結束號碼.小數點位置 = 0;
            this.plC_NumBox_儲位管理_結束號碼.微調數值 = 1;
            this.plC_NumBox_儲位管理_結束號碼.致能讀取位置 = "M8000";
            this.plC_NumBox_儲位管理_結束號碼.音效 = true;
            this.plC_NumBox_儲位管理_結束號碼.顯示微調按鈕 = false;
            this.plC_NumBox_儲位管理_結束號碼.顯示螢幕小鍵盤 = true;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.rJ_GroupBox3);
            this.panel20.Controls.Add(this.rJ_GroupBox2);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(1638, 854);
            this.panel20.TabIndex = 7;
            // 
            // rJ_GroupBox3
            // 
            // 
            // rJ_GroupBox3.ContentsPanel
            // 
            this.rJ_GroupBox3.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox3.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox3.ContentsPanel.BorderRadius = 5;
            this.rJ_GroupBox3.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox3.ContentsPanel.Controls.Add(this.plC_RJ_GroupBox13);
            this.rJ_GroupBox3.ContentsPanel.Controls.Add(this.plC_RJ_Button_儲位管理_儲位資訊_更新);
            this.rJ_GroupBox3.ContentsPanel.Controls.Add(this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位);
            this.rJ_GroupBox3.ContentsPanel.Controls.Add(this.sqL_DataGridView_儲位管理_儲位資訊);
            this.rJ_GroupBox3.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox3.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox3.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox3.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox3.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox3.ContentsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.rJ_GroupBox3.ContentsPanel.Size = new System.Drawing.Size(939, 817);
            this.rJ_GroupBox3.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox3.Location = new System.Drawing.Point(699, 0);
            this.rJ_GroupBox3.Name = "rJ_GroupBox3";
            this.rJ_GroupBox3.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox3.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox3.PannelBorderRadius = 5;
            this.rJ_GroupBox3.PannelBorderSize = 2;
            this.rJ_GroupBox3.Size = new System.Drawing.Size(939, 854);
            this.rJ_GroupBox3.TabIndex = 10;
            this.rJ_GroupBox3.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox3.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox3.TitleBorderRadius = 5;
            this.rJ_GroupBox3.TitleBorderSize = 0;
            this.rJ_GroupBox3.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.rJ_GroupBox3.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox3.TitleHeight = 37;
            this.rJ_GroupBox3.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox3.TitleTexts = "儲位資訊";
            // 
            // plC_RJ_GroupBox13
            // 
            // 
            // plC_RJ_GroupBox13.ContentsPanel
            // 
            this.plC_RJ_GroupBox13.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.plC_RJ_GroupBox13.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_GroupBox13.ContentsPanel.BorderRadius = 0;
            this.plC_RJ_GroupBox13.ContentsPanel.BorderSize = 2;
            this.plC_RJ_GroupBox13.ContentsPanel.Controls.Add(this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存);
            this.plC_RJ_GroupBox13.ContentsPanel.Controls.Add(this.plC_RJ_Button_儲位管理_儲位資訊_修正批號);
            this.plC_RJ_GroupBox13.ContentsPanel.Controls.Add(this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存);
            this.plC_RJ_GroupBox13.ContentsPanel.Controls.Add(this.plC_RJ_Button_儲位管理_儲位資訊_新增效期);
            this.plC_RJ_GroupBox13.ContentsPanel.Controls.Add(this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存);
            this.plC_RJ_GroupBox13.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plC_RJ_GroupBox13.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.plC_RJ_GroupBox13.ContentsPanel.IsSelected = false;
            this.plC_RJ_GroupBox13.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.plC_RJ_GroupBox13.ContentsPanel.Name = "ContentsPanel";
            this.plC_RJ_GroupBox13.ContentsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.plC_RJ_GroupBox13.ContentsPanel.Size = new System.Drawing.Size(582, 309);
            this.plC_RJ_GroupBox13.ContentsPanel.TabIndex = 2;
            this.plC_RJ_GroupBox13.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_GroupBox13.Location = new System.Drawing.Point(5, 466);
            this.plC_RJ_GroupBox13.Name = "plC_RJ_GroupBox13";
            this.plC_RJ_GroupBox13.PannelBackColor = System.Drawing.Color.White;
            this.plC_RJ_GroupBox13.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_GroupBox13.PannelBorderRadius = 0;
            this.plC_RJ_GroupBox13.PannelBorderSize = 2;
            this.plC_RJ_GroupBox13.Size = new System.Drawing.Size(582, 346);
            this.plC_RJ_GroupBox13.TabIndex = 139;
            this.plC_RJ_GroupBox13.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.plC_RJ_GroupBox13.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_GroupBox13.TitleBorderRadius = 5;
            this.plC_RJ_GroupBox13.TitleBorderSize = 0;
            this.plC_RJ_GroupBox13.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.plC_RJ_GroupBox13.TitleForeColor = System.Drawing.Color.White;
            this.plC_RJ_GroupBox13.TitleHeight = 37;
            this.plC_RJ_GroupBox13.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plC_RJ_GroupBox13.TitleTexts = "效期管理";
            // 
            // plC_RJ_Button_儲位管理_儲位資訊_新增庫存
            // 
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.AutoResetState = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.Bool = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.BorderRadius = 5;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.but_press = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.Location = new System.Drawing.Point(465, 163);
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.Name = "plC_RJ_Button_儲位管理_儲位資訊_新增庫存";
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.OFF_文字內容 = "新增庫存";
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.ON_文字內容 = "新增庫存";
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.Size = new System.Drawing.Size(111, 44);
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.State = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.TabIndex = 132;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.Text = "新增庫存";
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.Texts = "新增庫存";
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.字型鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.文字鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.致能讀取位置 = "S39012";
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.讀取位元反向 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.音效 = true;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.顯示 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增庫存.顯示狀態 = false;
            // 
            // plC_RJ_Button_儲位管理_儲位資訊_修正批號
            // 
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.AutoResetState = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.Bool = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.BorderRadius = 5;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.but_press = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.Location = new System.Drawing.Point(465, 113);
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.Name = "plC_RJ_Button_儲位管理_儲位資訊_修正批號";
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.OFF_文字內容 = "修正批號";
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.ON_文字內容 = "修正批號";
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.Size = new System.Drawing.Size(111, 44);
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.State = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.TabIndex = 131;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.Text = "修正批號";
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.Texts = "修正批號";
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.字型鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.文字鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.致能讀取位置 = "S39012";
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.讀取位元反向 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.音效 = true;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.顯示 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正批號.顯示狀態 = false;
            // 
            // plC_RJ_Button_儲位管理_儲位資訊_修正庫存
            // 
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.AutoResetState = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.Bool = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.BorderRadius = 5;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.but_press = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.Location = new System.Drawing.Point(465, 63);
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.Name = "plC_RJ_Button_儲位管理_儲位資訊_修正庫存";
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.OFF_文字內容 = "修正庫存";
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.ON_文字內容 = "修正庫存";
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.Size = new System.Drawing.Size(111, 44);
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.State = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.TabIndex = 129;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.Text = "修正庫存";
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.字型鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.文字鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.致能讀取位置 = "S39012";
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.讀取位元反向 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.音效 = true;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.顯示 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_修正庫存.顯示狀態 = false;
            // 
            // plC_RJ_Button_儲位管理_儲位資訊_新增效期
            // 
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.AutoResetState = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.Bool = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.BorderRadius = 5;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.but_press = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.Location = new System.Drawing.Point(465, 13);
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.Name = "plC_RJ_Button_儲位管理_儲位資訊_新增效期";
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.OFF_文字內容 = "新增效期";
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.ON_文字內容 = "新增效期";
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.Size = new System.Drawing.Size(111, 44);
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.State = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.TabIndex = 128;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.Text = "新增效期";
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.字型鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.文字鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.致能讀取位置 = "S39012";
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.讀取位元反向 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.音效 = true;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.顯示 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_新增效期.顯示狀態 = false;
            // 
            // sqL_DataGridView_儲位管理_儲位資訊_效期及庫存
            // 
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.AutoSelectToDeep = true;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.BorderRadius = 0;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.BorderSize = 2;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.cellStyleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.columnHeadersHeight = 23;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Columns"))));
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Columns1"))));
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Columns2"))));
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Dock = System.Windows.Forms.DockStyle.Left;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.ImageBox = false;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Location = new System.Drawing.Point(5, 5);
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Margin = new System.Windows.Forms.Padding(5);
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Name = "sqL_DataGridView_儲位管理_儲位資訊_效期及庫存";
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Password = "user82822040";
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Port = ((uint)(3306u));
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.rowHeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.RowsColor = System.Drawing.SystemColors.Window;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.RowsHeight = 40;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Server = "127.0.0.0";
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.Size = new System.Drawing.Size(452, 299);
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.TabIndex = 0;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.UserName = "root";
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.可選擇多列 = false;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.自動換行 = true;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.顯示CheckBox = false;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.顯示首列 = false;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.顯示首行 = true;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_儲位管理_儲位資訊_效期及庫存.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // plC_RJ_Button_儲位管理_儲位資訊_更新
            // 
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.AutoResetState = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.Bool = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.BorderRadius = 5;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.but_press = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.Location = new System.Drawing.Point(782, 540);
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.Name = "plC_RJ_Button_儲位管理_儲位資訊_更新";
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.OFF_文字內容 = "更新";
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.ON_文字內容 = "更新";
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.Size = new System.Drawing.Size(149, 103);
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.State = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.TabIndex = 136;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.Text = "更新";
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.Texts = "更新";
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.字型鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.文字鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.讀取位元反向 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.音效 = true;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.顯示 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_更新.顯示狀態 = false;
            // 
            // plC_RJ_Button_儲位管理_儲位資訊_刪除儲位
            // 
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.AutoResetState = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.Bool = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.BorderRadius = 5;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.but_press = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.Location = new System.Drawing.Point(628, 541);
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.Name = "plC_RJ_Button_儲位管理_儲位資訊_刪除儲位";
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.OFF_文字內容 = "刪除儲位";
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.ON_文字內容 = "刪除儲位";
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.Size = new System.Drawing.Size(149, 103);
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.State = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.TabIndex = 135;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.Text = "刪除儲位";
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.Texts = "刪除儲位";
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.字型鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.文字鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.讀取位元反向 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.音效 = true;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.顯示 = false;
            this.plC_RJ_Button_儲位管理_儲位資訊_刪除儲位.顯示狀態 = false;
            // 
            // sqL_DataGridView_儲位管理_儲位資訊
            // 
            this.sqL_DataGridView_儲位管理_儲位資訊.AutoSelectToDeep = false;
            this.sqL_DataGridView_儲位管理_儲位資訊.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_儲位管理_儲位資訊.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_儲位管理_儲位資訊.BorderRadius = 0;
            this.sqL_DataGridView_儲位管理_儲位資訊.BorderSize = 2;
            this.sqL_DataGridView_儲位管理_儲位資訊.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_儲位管理_儲位資訊.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_儲位管理_儲位資訊.cellStyleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_儲位管理_儲位資訊.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_儲位管理_儲位資訊.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_儲位管理_儲位資訊.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_儲位管理_儲位資訊.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_儲位管理_儲位資訊.columnHeadersHeight = 44;
            this.sqL_DataGridView_儲位管理_儲位資訊.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_儲位管理_儲位資訊.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_儲位管理_儲位資訊.Columns"))));
            this.sqL_DataGridView_儲位管理_儲位資訊.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_儲位管理_儲位資訊.Columns1"))));
            this.sqL_DataGridView_儲位管理_儲位資訊.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_儲位管理_儲位資訊.Columns2"))));
            this.sqL_DataGridView_儲位管理_儲位資訊.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_儲位管理_儲位資訊.Columns3"))));
            this.sqL_DataGridView_儲位管理_儲位資訊.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_儲位管理_儲位資訊.Columns4"))));
            this.sqL_DataGridView_儲位管理_儲位資訊.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_儲位管理_儲位資訊.Columns5"))));
            this.sqL_DataGridView_儲位管理_儲位資訊.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_儲位管理_儲位資訊.Columns6"))));
            this.sqL_DataGridView_儲位管理_儲位資訊.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_儲位管理_儲位資訊.Columns7"))));
            this.sqL_DataGridView_儲位管理_儲位資訊.DataBaseName = "Dispensing_000";
            this.sqL_DataGridView_儲位管理_儲位資訊.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqL_DataGridView_儲位管理_儲位資訊.Font = new System.Drawing.Font("新細明體", 12F);
            this.sqL_DataGridView_儲位管理_儲位資訊.ImageBox = false;
            this.sqL_DataGridView_儲位管理_儲位資訊.Location = new System.Drawing.Point(5, 5);
            this.sqL_DataGridView_儲位管理_儲位資訊.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sqL_DataGridView_儲位管理_儲位資訊.Name = "sqL_DataGridView_儲位管理_儲位資訊";
            this.sqL_DataGridView_儲位管理_儲位資訊.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_儲位管理_儲位資訊.Password = "user82822040";
            this.sqL_DataGridView_儲位管理_儲位資訊.Port = ((uint)(3306u));
            this.sqL_DataGridView_儲位管理_儲位資訊.rowHeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.sqL_DataGridView_儲位管理_儲位資訊.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_儲位管理_儲位資訊.RowsColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqL_DataGridView_儲位管理_儲位資訊.RowsHeight = 80;
            this.sqL_DataGridView_儲位管理_儲位資訊.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_儲位管理_儲位資訊.Server = "localhost";
            this.sqL_DataGridView_儲位管理_儲位資訊.Size = new System.Drawing.Size(929, 461);
            this.sqL_DataGridView_儲位管理_儲位資訊.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_儲位管理_儲位資訊.TabIndex = 131;
            this.sqL_DataGridView_儲位管理_儲位資訊.TableName = "medicine_page";
            this.sqL_DataGridView_儲位管理_儲位資訊.UserName = "root";
            this.sqL_DataGridView_儲位管理_儲位資訊.可拖曳欄位寬度 = true;
            this.sqL_DataGridView_儲位管理_儲位資訊.可選擇多列 = true;
            this.sqL_DataGridView_儲位管理_儲位資訊.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_儲位管理_儲位資訊.自動換行 = true;
            this.sqL_DataGridView_儲位管理_儲位資訊.表單字體 = new System.Drawing.Font("新細明體", 12F);
            this.sqL_DataGridView_儲位管理_儲位資訊.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_儲位管理_儲位資訊.顯示CheckBox = false;
            this.sqL_DataGridView_儲位管理_儲位資訊.顯示首列 = true;
            this.sqL_DataGridView_儲位管理_儲位資訊.顯示首行 = true;
            this.sqL_DataGridView_儲位管理_儲位資訊.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_儲位管理_儲位資訊.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // rJ_GroupBox2
            // 
            // 
            // rJ_GroupBox2.ContentsPanel
            // 
            this.rJ_GroupBox2.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.rJ_GroupBox2.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox2.ContentsPanel.BorderRadius = 5;
            this.rJ_GroupBox2.ContentsPanel.BorderSize = 2;
            this.rJ_GroupBox2.ContentsPanel.Controls.Add(this.plC_RJ_Button_儲位管理_藥品資料_顯示全部);
            this.rJ_GroupBox2.ContentsPanel.Controls.Add(this.plC_RJ_Button_儲位管理_藥品資料_新增儲位);
            this.rJ_GroupBox2.ContentsPanel.Controls.Add(this.rJ_Pannel7);
            this.rJ_GroupBox2.ContentsPanel.Controls.Add(this.rJ_Pannel6);
            this.rJ_GroupBox2.ContentsPanel.Controls.Add(this.rJ_Pannel1);
            this.rJ_GroupBox2.ContentsPanel.Controls.Add(this.sqL_DataGridView_儲位管理_藥品資料);
            this.rJ_GroupBox2.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rJ_GroupBox2.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox2.ContentsPanel.IsSelected = false;
            this.rJ_GroupBox2.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.rJ_GroupBox2.ContentsPanel.Name = "ContentsPanel";
            this.rJ_GroupBox2.ContentsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.rJ_GroupBox2.ContentsPanel.Size = new System.Drawing.Size(699, 817);
            this.rJ_GroupBox2.ContentsPanel.TabIndex = 2;
            this.rJ_GroupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.rJ_GroupBox2.Location = new System.Drawing.Point(0, 0);
            this.rJ_GroupBox2.Name = "rJ_GroupBox2";
            this.rJ_GroupBox2.PannelBackColor = System.Drawing.Color.White;
            this.rJ_GroupBox2.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_GroupBox2.PannelBorderRadius = 5;
            this.rJ_GroupBox2.PannelBorderSize = 2;
            this.rJ_GroupBox2.Size = new System.Drawing.Size(699, 854);
            this.rJ_GroupBox2.TabIndex = 9;
            this.rJ_GroupBox2.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.rJ_GroupBox2.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_GroupBox2.TitleBorderRadius = 5;
            this.rJ_GroupBox2.TitleBorderSize = 0;
            this.rJ_GroupBox2.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.rJ_GroupBox2.TitleForeColor = System.Drawing.Color.White;
            this.rJ_GroupBox2.TitleHeight = 37;
            this.rJ_GroupBox2.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_GroupBox2.TitleTexts = "藥品資料";
            // 
            // plC_RJ_Button_儲位管理_藥品資料_顯示全部
            // 
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.AutoResetState = false;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.Bool = false;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.BorderRadius = 5;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.but_press = false;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.Location = new System.Drawing.Point(528, 476);
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.Name = "plC_RJ_Button_儲位管理_藥品資料_顯示全部";
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.OFF_文字內容 = "顯示全部";
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.ON_文字內容 = "顯示全部";
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.Size = new System.Drawing.Size(149, 78);
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.State = false;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.TabIndex = 135;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.Text = "顯示全部";
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.Texts = "顯示全部";
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.字型鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.文字鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.讀取位元反向 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.音效 = true;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.顯示 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_顯示全部.顯示狀態 = false;
            // 
            // plC_RJ_Button_儲位管理_藥品資料_新增儲位
            // 
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.AutoResetState = false;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.Bool = false;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.BorderRadius = 5;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.but_press = false;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.Location = new System.Drawing.Point(528, 566);
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.Name = "plC_RJ_Button_儲位管理_藥品資料_新增儲位";
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.OFF_文字內容 = "新增儲位";
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.ON_文字內容 = "新增儲位";
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.Size = new System.Drawing.Size(149, 78);
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.State = false;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.TabIndex = 134;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.Text = "新增儲位";
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.Texts = "新增儲位";
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.字型鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.文字鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.讀取位元反向 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.音效 = true;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.顯示 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_新增儲位.顯示狀態 = false;
            // 
            // rJ_Pannel7
            // 
            this.rJ_Pannel7.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel7.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_Pannel7.BorderRadius = 10;
            this.rJ_Pannel7.BorderSize = 2;
            this.rJ_Pannel7.Controls.Add(this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋);
            this.rJ_Pannel7.Controls.Add(this.rJ_TextBox_儲位管理_藥品資料_中文名稱);
            this.rJ_Pannel7.Controls.Add(this.rJ_Lable8);
            this.rJ_Pannel7.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel7.IsSelected = false;
            this.rJ_Pannel7.Location = new System.Drawing.Point(13, 592);
            this.rJ_Pannel7.Name = "rJ_Pannel7";
            this.rJ_Pannel7.Size = new System.Drawing.Size(443, 59);
            this.rJ_Pannel7.TabIndex = 133;
            // 
            // plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋
            // 
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.AutoResetState = false;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.Bool = false;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.BorderRadius = 5;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.but_press = false;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.Location = new System.Drawing.Point(367, 6);
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.Name = "plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.OFF_文字內容 = "搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.ON_文字內容 = "搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.Size = new System.Drawing.Size(69, 45);
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.State = false;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.TabIndex = 132;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.Text = "搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.Texts = "搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.字型鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.文字鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.讀取位元反向 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.音效 = true;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.顯示 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋.顯示狀態 = false;
            // 
            // rJ_TextBox_儲位管理_藥品資料_中文名稱
            // 
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.BorderRadius = 0;
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.BorderSize = 2;
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.Location = new System.Drawing.Point(141, 14);
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.Multiline = false;
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.Name = "rJ_TextBox_儲位管理_藥品資料_中文名稱";
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.PassWordChar = false;
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.PlaceholderText = "";
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.ShowTouchPannel = false;
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.Size = new System.Drawing.Size(217, 31);
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.TabIndex = 3;
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.Texts = "";
            this.rJ_TextBox_儲位管理_藥品資料_中文名稱.UnderlineStyle = false;
            // 
            // rJ_Lable8
            // 
            this.rJ_Lable8.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable8.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable8.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable8.BorderRadius = 8;
            this.rJ_Lable8.BorderSize = 0;
            this.rJ_Lable8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable8.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable8.Location = new System.Drawing.Point(13, 6);
            this.rJ_Lable8.Name = "rJ_Lable8";
            this.rJ_Lable8.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable8.TabIndex = 2;
            this.rJ_Lable8.Text = "中文名稱";
            this.rJ_Lable8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable8.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Pannel6
            // 
            this.rJ_Pannel6.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel6.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_Pannel6.BorderRadius = 10;
            this.rJ_Pannel6.BorderSize = 2;
            this.rJ_Pannel6.Controls.Add(this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋);
            this.rJ_Pannel6.Controls.Add(this.rJ_TextBox_儲位管理_藥品資料_藥品名稱);
            this.rJ_Pannel6.Controls.Add(this.rJ_Lable7);
            this.rJ_Pannel6.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel6.IsSelected = false;
            this.rJ_Pannel6.Location = new System.Drawing.Point(13, 527);
            this.rJ_Pannel6.Name = "rJ_Pannel6";
            this.rJ_Pannel6.Size = new System.Drawing.Size(443, 59);
            this.rJ_Pannel6.TabIndex = 132;
            // 
            // plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋
            // 
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.AutoResetState = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.Bool = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.BorderRadius = 5;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.but_press = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.Location = new System.Drawing.Point(367, 6);
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.Name = "plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.OFF_文字內容 = "搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.ON_文字內容 = "搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.Size = new System.Drawing.Size(69, 45);
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.State = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.TabIndex = 132;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.Text = "搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.Texts = "搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.字型鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.文字鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.讀取位元反向 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.音效 = true;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.顯示 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋.顯示狀態 = false;
            // 
            // rJ_TextBox_儲位管理_藥品資料_藥品名稱
            // 
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.BorderRadius = 0;
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.BorderSize = 2;
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.Location = new System.Drawing.Point(141, 14);
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.Multiline = false;
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.Name = "rJ_TextBox_儲位管理_藥品資料_藥品名稱";
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.PassWordChar = false;
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.PlaceholderText = "";
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.ShowTouchPannel = false;
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.Size = new System.Drawing.Size(217, 31);
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.TabIndex = 3;
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.Texts = "";
            this.rJ_TextBox_儲位管理_藥品資料_藥品名稱.UnderlineStyle = false;
            // 
            // rJ_Lable7
            // 
            this.rJ_Lable7.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable7.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable7.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable7.BorderRadius = 8;
            this.rJ_Lable7.BorderSize = 0;
            this.rJ_Lable7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable7.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable7.Location = new System.Drawing.Point(13, 6);
            this.rJ_Lable7.Name = "rJ_Lable7";
            this.rJ_Lable7.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable7.TabIndex = 2;
            this.rJ_Lable7.Text = "藥品名稱";
            this.rJ_Lable7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable7.TextColor = System.Drawing.Color.Black;
            // 
            // rJ_Pannel1
            // 
            this.rJ_Pannel1.BackColor = System.Drawing.Color.White;
            this.rJ_Pannel1.BorderColor = System.Drawing.Color.SkyBlue;
            this.rJ_Pannel1.BorderRadius = 10;
            this.rJ_Pannel1.BorderSize = 2;
            this.rJ_Pannel1.Controls.Add(this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋);
            this.rJ_Pannel1.Controls.Add(this.rJ_TextBox_儲位管理_藥品資料_藥品碼);
            this.rJ_Pannel1.Controls.Add(this.rJ_Lable6);
            this.rJ_Pannel1.ForeColor = System.Drawing.Color.White;
            this.rJ_Pannel1.IsSelected = false;
            this.rJ_Pannel1.Location = new System.Drawing.Point(13, 462);
            this.rJ_Pannel1.Name = "rJ_Pannel1";
            this.rJ_Pannel1.Size = new System.Drawing.Size(443, 59);
            this.rJ_Pannel1.TabIndex = 131;
            // 
            // plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋
            // 
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.AutoResetState = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.Bool = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.BorderRadius = 5;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.but_press = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.Location = new System.Drawing.Point(367, 6);
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.Name = "plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.OFF_文字內容 = "搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.ON_BorderSize = 5;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.ON_文字內容 = "搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.Size = new System.Drawing.Size(69, 45);
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.State = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.TabIndex = 132;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.Text = "搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.Texts = "搜尋";
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.字型鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.文字鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.讀取位元反向 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.讀寫鎖住 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.音效 = true;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.顯示 = false;
            this.plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋.顯示狀態 = false;
            // 
            // rJ_TextBox_儲位管理_藥品資料_藥品碼
            // 
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.BorderRadius = 0;
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.BorderSize = 2;
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.Location = new System.Drawing.Point(141, 14);
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.Multiline = false;
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.Name = "rJ_TextBox_儲位管理_藥品資料_藥品碼";
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.PassWordChar = false;
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.PlaceholderText = "";
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.ShowTouchPannel = false;
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.Size = new System.Drawing.Size(217, 31);
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.TabIndex = 3;
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.Texts = "";
            this.rJ_TextBox_儲位管理_藥品資料_藥品碼.UnderlineStyle = false;
            // 
            // rJ_Lable6
            // 
            this.rJ_Lable6.BackColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable6.BackgroundColor = System.Drawing.Color.SkyBlue;
            this.rJ_Lable6.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable6.BorderRadius = 8;
            this.rJ_Lable6.BorderSize = 0;
            this.rJ_Lable6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_Lable6.ForeColor = System.Drawing.Color.Black;
            this.rJ_Lable6.Location = new System.Drawing.Point(13, 6);
            this.rJ_Lable6.Name = "rJ_Lable6";
            this.rJ_Lable6.Size = new System.Drawing.Size(122, 46);
            this.rJ_Lable6.TabIndex = 2;
            this.rJ_Lable6.Text = "藥品碼";
            this.rJ_Lable6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable6.TextColor = System.Drawing.Color.Black;
            // 
            // sqL_DataGridView_儲位管理_藥品資料
            // 
            this.sqL_DataGridView_儲位管理_藥品資料.AutoSelectToDeep = false;
            this.sqL_DataGridView_儲位管理_藥品資料.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_儲位管理_藥品資料.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_儲位管理_藥品資料.BorderRadius = 0;
            this.sqL_DataGridView_儲位管理_藥品資料.BorderSize = 2;
            this.sqL_DataGridView_儲位管理_藥品資料.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_儲位管理_藥品資料.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_儲位管理_藥品資料.cellStyleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_儲位管理_藥品資料.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_儲位管理_藥品資料.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_儲位管理_藥品資料.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_儲位管理_藥品資料.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_儲位管理_藥品資料.columnHeadersHeight = 18;
            this.sqL_DataGridView_儲位管理_藥品資料.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_儲位管理_藥品資料.DataBaseName = "Dispensing_000";
            this.sqL_DataGridView_儲位管理_藥品資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqL_DataGridView_儲位管理_藥品資料.Font = new System.Drawing.Font("新細明體", 12F);
            this.sqL_DataGridView_儲位管理_藥品資料.ImageBox = false;
            this.sqL_DataGridView_儲位管理_藥品資料.Location = new System.Drawing.Point(5, 5);
            this.sqL_DataGridView_儲位管理_藥品資料.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sqL_DataGridView_儲位管理_藥品資料.Name = "sqL_DataGridView_儲位管理_藥品資料";
            this.sqL_DataGridView_儲位管理_藥品資料.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_儲位管理_藥品資料.Password = "user82822040";
            this.sqL_DataGridView_儲位管理_藥品資料.Port = ((uint)(3306u));
            this.sqL_DataGridView_儲位管理_藥品資料.rowHeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.sqL_DataGridView_儲位管理_藥品資料.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_儲位管理_藥品資料.RowsColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqL_DataGridView_儲位管理_藥品資料.RowsHeight = 80;
            this.sqL_DataGridView_儲位管理_藥品資料.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_儲位管理_藥品資料.Server = "localhost";
            this.sqL_DataGridView_儲位管理_藥品資料.Size = new System.Drawing.Size(689, 450);
            this.sqL_DataGridView_儲位管理_藥品資料.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_儲位管理_藥品資料.TabIndex = 130;
            this.sqL_DataGridView_儲位管理_藥品資料.TableName = "medicine_page";
            this.sqL_DataGridView_儲位管理_藥品資料.UserName = "root";
            this.sqL_DataGridView_儲位管理_藥品資料.可拖曳欄位寬度 = true;
            this.sqL_DataGridView_儲位管理_藥品資料.可選擇多列 = false;
            this.sqL_DataGridView_儲位管理_藥品資料.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_儲位管理_藥品資料.自動換行 = true;
            this.sqL_DataGridView_儲位管理_藥品資料.表單字體 = new System.Drawing.Font("新細明體", 12F);
            this.sqL_DataGridView_儲位管理_藥品資料.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_儲位管理_藥品資料.顯示CheckBox = false;
            this.sqL_DataGridView_儲位管理_藥品資料.顯示首列 = true;
            this.sqL_DataGridView_儲位管理_藥品資料.顯示首行 = true;
            this.sqL_DataGridView_儲位管理_藥品資料.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_儲位管理_藥品資料.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // 工程模式
            // 
            this.工程模式.BackColor = System.Drawing.Color.White;
            this.工程模式.Controls.Add(this.plC_Button_下門鎖);
            this.工程模式.Controls.Add(this.plC_Button_上門鎖);
            this.工程模式.Controls.Add(this.plC_Button_取藥門關);
            this.工程模式.Controls.Add(this.plC_Button_取藥門開);
            this.工程模式.Controls.Add(this.plC_Button_重複領藥不檢查);
            this.工程模式.Controls.Add(this.groupBox19);
            this.工程模式.Controls.Add(this.plC_Button142);
            this.工程模式.Controls.Add(this.plC_Button_LED全亮);
            this.工程模式.Controls.Add(this.rowsLED_Pannel_工程模式);
            this.工程模式.Controls.Add(this.panel16);
            this.工程模式.Controls.Add(this.panel15);
            this.工程模式.Controls.Add(this.panel14);
            this.工程模式.Controls.Add(this.panel13);
            this.工程模式.Controls.Add(this.panel12);
            this.工程模式.Controls.Add(this.panel11);
            this.工程模式.Controls.Add(this.panel10);
            this.工程模式.Controls.Add(this.panel9);
            this.工程模式.Controls.Add(this.panel8);
            this.工程模式.Controls.Add(this.panel7);
            this.工程模式.Controls.Add(this.panel6);
            this.工程模式.Controls.Add(this.panel5);
            this.工程模式.Controls.Add(this.panel4);
            this.工程模式.Controls.Add(this.panel3);
            this.工程模式.Controls.Add(this.panel1);
            this.工程模式.Controls.Add(this.plC_RJ_ScreenButton9);
            this.工程模式.Location = new System.Drawing.Point(4, 25);
            this.工程模式.Name = "工程模式";
            this.工程模式.Size = new System.Drawing.Size(1638, 986);
            this.工程模式.TabIndex = 2;
            this.工程模式.Text = "工程模式";
            // 
            // plC_Button_下門鎖
            // 
            this.plC_Button_下門鎖.Bool = false;
            this.plC_Button_下門鎖.but_press = false;
            this.plC_Button_下門鎖.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button_下門鎖.Location = new System.Drawing.Point(1603, 95);
            this.plC_Button_下門鎖.Name = "plC_Button_下門鎖";
            this.plC_Button_下門鎖.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button_下門鎖.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button_下門鎖.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_下門鎖.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button_下門鎖.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button_下門鎖.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_下門鎖.Size = new System.Drawing.Size(22, 21);
            this.plC_Button_下門鎖.Style = MyUI.PLC_Button.StyleEnum.Lamp_綠;
            this.plC_Button_下門鎖.TabIndex = 157;
            this.plC_Button_下門鎖.事件驅動 = false;
            this.plC_Button_下門鎖.字型鎖住 = false;
            this.plC_Button_下門鎖.寫入元件位置 = "X22";
            this.plC_Button_下門鎖.按鈕型態 = MyUI.PLC_Button.StatusEnum.保持型;
            this.plC_Button_下門鎖.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button_下門鎖.文字鎖住 = false;
            this.plC_Button_下門鎖.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_下門鎖.狀態OFF圖片")));
            this.plC_Button_下門鎖.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_下門鎖.狀態ON圖片")));
            this.plC_Button_下門鎖.讀取位元反向 = false;
            this.plC_Button_下門鎖.讀取元件位置 = "X22";
            this.plC_Button_下門鎖.讀寫鎖住 = false;
            this.plC_Button_下門鎖.起始狀態 = false;
            this.plC_Button_下門鎖.音效 = true;
            this.plC_Button_下門鎖.顯示 = false;
            this.plC_Button_下門鎖.顯示狀態 = false;
            // 
            // plC_Button_上門鎖
            // 
            this.plC_Button_上門鎖.Bool = false;
            this.plC_Button_上門鎖.but_press = false;
            this.plC_Button_上門鎖.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button_上門鎖.Location = new System.Drawing.Point(1603, 68);
            this.plC_Button_上門鎖.Name = "plC_Button_上門鎖";
            this.plC_Button_上門鎖.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button_上門鎖.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button_上門鎖.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_上門鎖.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button_上門鎖.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button_上門鎖.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_上門鎖.Size = new System.Drawing.Size(22, 21);
            this.plC_Button_上門鎖.Style = MyUI.PLC_Button.StyleEnum.Lamp_綠;
            this.plC_Button_上門鎖.TabIndex = 156;
            this.plC_Button_上門鎖.事件驅動 = false;
            this.plC_Button_上門鎖.字型鎖住 = false;
            this.plC_Button_上門鎖.寫入元件位置 = "X21";
            this.plC_Button_上門鎖.按鈕型態 = MyUI.PLC_Button.StatusEnum.保持型;
            this.plC_Button_上門鎖.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button_上門鎖.文字鎖住 = false;
            this.plC_Button_上門鎖.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_上門鎖.狀態OFF圖片")));
            this.plC_Button_上門鎖.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_上門鎖.狀態ON圖片")));
            this.plC_Button_上門鎖.讀取位元反向 = false;
            this.plC_Button_上門鎖.讀取元件位置 = "X21";
            this.plC_Button_上門鎖.讀寫鎖住 = false;
            this.plC_Button_上門鎖.起始狀態 = false;
            this.plC_Button_上門鎖.音效 = true;
            this.plC_Button_上門鎖.顯示 = false;
            this.plC_Button_上門鎖.顯示狀態 = false;
            // 
            // plC_Button_取藥門關
            // 
            this.plC_Button_取藥門關.Bool = false;
            this.plC_Button_取藥門關.but_press = false;
            this.plC_Button_取藥門關.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button_取藥門關.Location = new System.Drawing.Point(1002, 79);
            this.plC_Button_取藥門關.Name = "plC_Button_取藥門關";
            this.plC_Button_取藥門關.OFF_文字內容 = "取藥門關";
            this.plC_Button_取藥門關.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button_取藥門關.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button_取藥門關.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_取藥門關.ON_文字內容 = "取藥門關";
            this.plC_Button_取藥門關.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button_取藥門關.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button_取藥門關.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_取藥門關.Size = new System.Drawing.Size(122, 62);
            this.plC_Button_取藥門關.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button_取藥門關.TabIndex = 155;
            this.plC_Button_取藥門關.事件驅動 = false;
            this.plC_Button_取藥門關.字型鎖住 = false;
            this.plC_Button_取藥門關.寫入元件位置 = "M117";
            this.plC_Button_取藥門關.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button_取藥門關.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button_取藥門關.文字鎖住 = false;
            this.plC_Button_取藥門關.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_取藥門關.狀態OFF圖片")));
            this.plC_Button_取藥門關.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_取藥門關.狀態ON圖片")));
            this.plC_Button_取藥門關.讀取位元反向 = false;
            this.plC_Button_取藥門關.讀取元件位置 = "M117";
            this.plC_Button_取藥門關.讀寫鎖住 = false;
            this.plC_Button_取藥門關.起始狀態 = false;
            this.plC_Button_取藥門關.音效 = true;
            this.plC_Button_取藥門關.顯示 = false;
            this.plC_Button_取藥門關.顯示狀態 = false;
            // 
            // plC_Button_取藥門開
            // 
            this.plC_Button_取藥門開.Bool = false;
            this.plC_Button_取藥門開.but_press = false;
            this.plC_Button_取藥門開.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button_取藥門開.Location = new System.Drawing.Point(1002, 11);
            this.plC_Button_取藥門開.Name = "plC_Button_取藥門開";
            this.plC_Button_取藥門開.OFF_文字內容 = "取藥門開";
            this.plC_Button_取藥門開.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button_取藥門開.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button_取藥門開.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_取藥門開.ON_文字內容 = "取藥門開";
            this.plC_Button_取藥門開.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button_取藥門開.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button_取藥門開.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_取藥門開.Size = new System.Drawing.Size(122, 62);
            this.plC_Button_取藥門開.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button_取藥門開.TabIndex = 154;
            this.plC_Button_取藥門開.事件驅動 = false;
            this.plC_Button_取藥門開.字型鎖住 = false;
            this.plC_Button_取藥門開.寫入元件位置 = "M116";
            this.plC_Button_取藥門開.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button_取藥門開.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button_取藥門開.文字鎖住 = false;
            this.plC_Button_取藥門開.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_取藥門開.狀態OFF圖片")));
            this.plC_Button_取藥門開.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_取藥門開.狀態ON圖片")));
            this.plC_Button_取藥門開.讀取位元反向 = false;
            this.plC_Button_取藥門開.讀取元件位置 = "M116";
            this.plC_Button_取藥門開.讀寫鎖住 = false;
            this.plC_Button_取藥門開.起始狀態 = false;
            this.plC_Button_取藥門開.音效 = true;
            this.plC_Button_取藥門開.顯示 = false;
            this.plC_Button_取藥門開.顯示狀態 = false;
            // 
            // plC_Button_重複領藥不檢查
            // 
            this.plC_Button_重複領藥不檢查.Bool = false;
            this.plC_Button_重複領藥不檢查.but_press = false;
            this.plC_Button_重複領藥不檢查.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button_重複領藥不檢查.Location = new System.Drawing.Point(1154, 118);
            this.plC_Button_重複領藥不檢查.Name = "plC_Button_重複領藥不檢查";
            this.plC_Button_重複領藥不檢查.OFF_文字內容 = "重複領藥要檢查";
            this.plC_Button_重複領藥不檢查.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button_重複領藥不檢查.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button_重複領藥不檢查.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_重複領藥不檢查.ON_文字內容 = "重複領藥不檢查";
            this.plC_Button_重複領藥不檢查.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button_重複領藥不檢查.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button_重複領藥不檢查.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_重複領藥不檢查.Size = new System.Drawing.Size(153, 62);
            this.plC_Button_重複領藥不檢查.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button_重複領藥不檢查.TabIndex = 153;
            this.plC_Button_重複領藥不檢查.事件驅動 = false;
            this.plC_Button_重複領藥不檢查.字型鎖住 = false;
            this.plC_Button_重複領藥不檢查.寫入元件位置 = "S4015";
            this.plC_Button_重複領藥不檢查.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button_重複領藥不檢查.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button_重複領藥不檢查.文字鎖住 = false;
            this.plC_Button_重複領藥不檢查.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_重複領藥不檢查.狀態OFF圖片")));
            this.plC_Button_重複領藥不檢查.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_重複領藥不檢查.狀態ON圖片")));
            this.plC_Button_重複領藥不檢查.讀取位元反向 = false;
            this.plC_Button_重複領藥不檢查.讀取元件位置 = "S4015";
            this.plC_Button_重複領藥不檢查.讀寫鎖住 = false;
            this.plC_Button_重複領藥不檢查.起始狀態 = false;
            this.plC_Button_重複領藥不檢查.音效 = true;
            this.plC_Button_重複領藥不檢查.顯示 = false;
            this.plC_Button_重複領藥不檢查.顯示狀態 = false;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.label118);
            this.groupBox19.Controls.Add(this.plC_NumBox6);
            this.groupBox19.Location = new System.Drawing.Point(1222, 11);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(146, 54);
            this.groupBox19.TabIndex = 152;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "閒置登出時間";
            // 
            // label118
            // 
            this.label118.AutoSize = true;
            this.label118.Location = new System.Drawing.Point(92, 31);
            this.label118.Name = "label118";
            this.label118.Size = new System.Drawing.Size(19, 12);
            this.label118.TabIndex = 2;
            this.label118.Text = "sec";
            // 
            // plC_NumBox6
            // 
            this.plC_NumBox6.Location = new System.Drawing.Point(15, 21);
            this.plC_NumBox6.mBackColor = System.Drawing.SystemColors.Window;
            this.plC_NumBox6.mForeColor = System.Drawing.SystemColors.WindowText;
            this.plC_NumBox6.Name = "plC_NumBox6";
            this.plC_NumBox6.ReadOnly = false;
            this.plC_NumBox6.Size = new System.Drawing.Size(71, 22);
            this.plC_NumBox6.TabIndex = 2;
            this.plC_NumBox6.Value = 0;
            this.plC_NumBox6.字元長度 = MyUI.PLC_NumBox.WordLengthEnum.單字元;
            this.plC_NumBox6.密碼欄位 = false;
            this.plC_NumBox6.寫入位置註解 = "閒置登出時間";
            this.plC_NumBox6.寫入元件位置 = "D100";
            this.plC_NumBox6.小數點位置 = 3;
            this.plC_NumBox6.微調數值 = 1;
            this.plC_NumBox6.讀取位置註解 = "閒置登出時間";
            this.plC_NumBox6.讀取元件位置 = "D100";
            this.plC_NumBox6.音效 = true;
            this.plC_NumBox6.顯示微調按鈕 = false;
            this.plC_NumBox6.顯示螢幕小鍵盤 = true;
            // 
            // plC_Button142
            // 
            this.plC_Button142.Bool = false;
            this.plC_Button142.but_press = false;
            this.plC_Button142.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button142.Location = new System.Drawing.Point(1472, 118);
            this.plC_Button142.Name = "plC_Button142";
            this.plC_Button142.OFF_文字內容 = "門鎖";
            this.plC_Button142.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button142.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button142.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button142.ON_文字內容 = "門鎖";
            this.plC_Button142.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button142.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button142.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button142.Size = new System.Drawing.Size(153, 62);
            this.plC_Button142.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button142.TabIndex = 151;
            this.plC_Button142.事件驅動 = false;
            this.plC_Button142.字型鎖住 = false;
            this.plC_Button142.寫入元件位置 = "M136";
            this.plC_Button142.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button142.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button142.文字鎖住 = false;
            this.plC_Button142.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button142.狀態OFF圖片")));
            this.plC_Button142.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button142.狀態ON圖片")));
            this.plC_Button142.讀取位元反向 = false;
            this.plC_Button142.讀取元件位置 = "M136";
            this.plC_Button142.讀寫鎖住 = false;
            this.plC_Button142.起始狀態 = false;
            this.plC_Button142.音效 = true;
            this.plC_Button142.顯示 = false;
            this.plC_Button142.顯示狀態 = false;
            // 
            // plC_Button_LED全亮
            // 
            this.plC_Button_LED全亮.Bool = false;
            this.plC_Button_LED全亮.but_press = false;
            this.plC_Button_LED全亮.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button_LED全亮.Location = new System.Drawing.Point(1313, 118);
            this.plC_Button_LED全亮.Name = "plC_Button_LED全亮";
            this.plC_Button_LED全亮.OFF_文字內容 = "LED全亮";
            this.plC_Button_LED全亮.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button_LED全亮.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button_LED全亮.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_LED全亮.ON_文字內容 = "LED全亮";
            this.plC_Button_LED全亮.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button_LED全亮.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button_LED全亮.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button_LED全亮.Size = new System.Drawing.Size(153, 62);
            this.plC_Button_LED全亮.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button_LED全亮.TabIndex = 150;
            this.plC_Button_LED全亮.事件驅動 = false;
            this.plC_Button_LED全亮.字型鎖住 = false;
            this.plC_Button_LED全亮.寫入元件位置 = "S4010";
            this.plC_Button_LED全亮.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button_LED全亮.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button_LED全亮.文字鎖住 = false;
            this.plC_Button_LED全亮.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_LED全亮.狀態OFF圖片")));
            this.plC_Button_LED全亮.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button_LED全亮.狀態ON圖片")));
            this.plC_Button_LED全亮.讀取位元反向 = false;
            this.plC_Button_LED全亮.讀取元件位置 = "S4010";
            this.plC_Button_LED全亮.讀寫鎖住 = false;
            this.plC_Button_LED全亮.起始狀態 = false;
            this.plC_Button_LED全亮.音效 = true;
            this.plC_Button_LED全亮.顯示 = false;
            this.plC_Button_LED全亮.顯示狀態 = false;
            // 
            // rowsLED_Pannel_工程模式
            // 
            this.rowsLED_Pannel_工程模式.AutoWrite = true;
            this.rowsLED_Pannel_工程模式.BackColor = System.Drawing.SystemColors.Window;
            this.rowsLED_Pannel_工程模式.BarColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.rowsLED_Pannel_工程模式.BarFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rowsLED_Pannel_工程模式.BarForeColor = System.Drawing.Color.Black;
            this.rowsLED_Pannel_工程模式.BarSize = 50;
            this.rowsLED_Pannel_工程模式.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rowsLED_Pannel_工程模式.BottomSliderColor = System.Drawing.Color.Red;
            this.rowsLED_Pannel_工程模式.CurrentRowsDevice = null;
            this.rowsLED_Pannel_工程模式.CurrentRowsLED = null;
            this.rowsLED_Pannel_工程模式.Location = new System.Drawing.Point(12, 20);
            this.rowsLED_Pannel_工程模式.Maximum = 70;
            this.rowsLED_Pannel_工程模式.MaxValue = 5;
            this.rowsLED_Pannel_工程模式.Minimum = 1;
            this.rowsLED_Pannel_工程模式.MinValue = 1;
            this.rowsLED_Pannel_工程模式.Name = "rowsLED_Pannel_工程模式";
            this.rowsLED_Pannel_工程模式.RowsDeviceGUID = "";
            this.rowsLED_Pannel_工程模式.Size = new System.Drawing.Size(984, 160);
            this.rowsLED_Pannel_工程模式.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rowsLED_Pannel_工程模式.SliderSize = 30;
            this.rowsLED_Pannel_工程模式.TabIndex = 96;
            this.rowsLED_Pannel_工程模式.TopSliderColor = System.Drawing.Color.Silver;
            // 
            // panel16
            // 
            this.panel16.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel16.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel16.Location = new System.Drawing.Point(0, 171);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1638, 17);
            this.panel16.TabIndex = 95;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.plC_Button127);
            this.panel15.Controls.Add(this.plC_Button128);
            this.panel15.Controls.Add(this.plC_Button129);
            this.panel15.Controls.Add(this.plC_Button130);
            this.panel15.Controls.Add(this.plC_Button131);
            this.panel15.Controls.Add(this.plC_Button132);
            this.panel15.Controls.Add(this.plC_Button133);
            this.panel15.Controls.Add(this.plC_Button134);
            this.panel15.Controls.Add(this.plC_Button135);
            this.panel15.Controls.Add(this.plC_Button136);
            this.panel15.Controls.Add(this.plC_Button137);
            this.panel15.Controls.Add(this.plC_Button138);
            this.panel15.Controls.Add(this.plC_Button139);
            this.panel15.Controls.Add(this.plC_Button140);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel15.Location = new System.Drawing.Point(0, 188);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(1638, 73);
            this.panel15.TabIndex = 94;
            // 
            // plC_Button127
            // 
            this.plC_Button127.Bool = false;
            this.plC_Button127.but_press = false;
            this.plC_Button127.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button127.Location = new System.Drawing.Point(1442, 12);
            this.plC_Button127.Name = "plC_Button127";
            this.plC_Button127.OFF_文字內容 = "Motor_05-14";
            this.plC_Button127.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button127.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button127.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button127.ON_文字內容 = "Motor_05-14";
            this.plC_Button127.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button127.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button127.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button127.Size = new System.Drawing.Size(104, 52);
            this.plC_Button127.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button127.TabIndex = 150;
            this.plC_Button127.事件驅動 = false;
            this.plC_Button127.字型鎖住 = false;
            this.plC_Button127.寫入元件位置 = "M514";
            this.plC_Button127.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button127.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button127.文字鎖住 = false;
            this.plC_Button127.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button127.狀態OFF圖片")));
            this.plC_Button127.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button127.狀態ON圖片")));
            this.plC_Button127.讀取位元反向 = false;
            this.plC_Button127.讀取元件位置 = "M514";
            this.plC_Button127.讀寫鎖住 = false;
            this.plC_Button127.起始狀態 = false;
            this.plC_Button127.音效 = true;
            this.plC_Button127.顯示 = false;
            this.plC_Button127.顯示狀態 = false;
            // 
            // plC_Button128
            // 
            this.plC_Button128.Bool = false;
            this.plC_Button128.but_press = false;
            this.plC_Button128.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button128.Location = new System.Drawing.Point(1332, 12);
            this.plC_Button128.Name = "plC_Button128";
            this.plC_Button128.OFF_文字內容 = "Motor_05-13";
            this.plC_Button128.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button128.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button128.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button128.ON_文字內容 = "Motor_05-13";
            this.plC_Button128.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button128.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button128.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button128.Size = new System.Drawing.Size(104, 52);
            this.plC_Button128.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button128.TabIndex = 149;
            this.plC_Button128.事件驅動 = false;
            this.plC_Button128.字型鎖住 = false;
            this.plC_Button128.寫入元件位置 = "M513";
            this.plC_Button128.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button128.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button128.文字鎖住 = false;
            this.plC_Button128.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button128.狀態OFF圖片")));
            this.plC_Button128.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button128.狀態ON圖片")));
            this.plC_Button128.讀取位元反向 = false;
            this.plC_Button128.讀取元件位置 = "M513";
            this.plC_Button128.讀寫鎖住 = false;
            this.plC_Button128.起始狀態 = false;
            this.plC_Button128.音效 = true;
            this.plC_Button128.顯示 = false;
            this.plC_Button128.顯示狀態 = false;
            // 
            // plC_Button129
            // 
            this.plC_Button129.Bool = false;
            this.plC_Button129.but_press = false;
            this.plC_Button129.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button129.Location = new System.Drawing.Point(1222, 12);
            this.plC_Button129.Name = "plC_Button129";
            this.plC_Button129.OFF_文字內容 = "Motor_05-12";
            this.plC_Button129.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button129.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button129.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button129.ON_文字內容 = "Motor_05-12";
            this.plC_Button129.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button129.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button129.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button129.Size = new System.Drawing.Size(104, 52);
            this.plC_Button129.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button129.TabIndex = 148;
            this.plC_Button129.事件驅動 = false;
            this.plC_Button129.字型鎖住 = false;
            this.plC_Button129.寫入元件位置 = "M512";
            this.plC_Button129.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button129.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button129.文字鎖住 = false;
            this.plC_Button129.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button129.狀態OFF圖片")));
            this.plC_Button129.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button129.狀態ON圖片")));
            this.plC_Button129.讀取位元反向 = false;
            this.plC_Button129.讀取元件位置 = "M512";
            this.plC_Button129.讀寫鎖住 = false;
            this.plC_Button129.起始狀態 = false;
            this.plC_Button129.音效 = true;
            this.plC_Button129.顯示 = false;
            this.plC_Button129.顯示狀態 = false;
            // 
            // plC_Button130
            // 
            this.plC_Button130.Bool = false;
            this.plC_Button130.but_press = false;
            this.plC_Button130.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button130.Location = new System.Drawing.Point(1112, 12);
            this.plC_Button130.Name = "plC_Button130";
            this.plC_Button130.OFF_文字內容 = "Motor_05-11";
            this.plC_Button130.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button130.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button130.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button130.ON_文字內容 = "Motor_05-11";
            this.plC_Button130.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button130.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button130.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button130.Size = new System.Drawing.Size(104, 52);
            this.plC_Button130.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button130.TabIndex = 147;
            this.plC_Button130.事件驅動 = false;
            this.plC_Button130.字型鎖住 = false;
            this.plC_Button130.寫入元件位置 = "M511";
            this.plC_Button130.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button130.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button130.文字鎖住 = false;
            this.plC_Button130.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button130.狀態OFF圖片")));
            this.plC_Button130.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button130.狀態ON圖片")));
            this.plC_Button130.讀取位元反向 = false;
            this.plC_Button130.讀取元件位置 = "M511";
            this.plC_Button130.讀寫鎖住 = false;
            this.plC_Button130.起始狀態 = false;
            this.plC_Button130.音效 = true;
            this.plC_Button130.顯示 = false;
            this.plC_Button130.顯示狀態 = false;
            // 
            // plC_Button131
            // 
            this.plC_Button131.Bool = false;
            this.plC_Button131.but_press = false;
            this.plC_Button131.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button131.Location = new System.Drawing.Point(1002, 12);
            this.plC_Button131.Name = "plC_Button131";
            this.plC_Button131.OFF_文字內容 = "Motor_05-10";
            this.plC_Button131.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button131.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button131.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button131.ON_文字內容 = "Motor_05-10";
            this.plC_Button131.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button131.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button131.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button131.Size = new System.Drawing.Size(104, 52);
            this.plC_Button131.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button131.TabIndex = 146;
            this.plC_Button131.事件驅動 = false;
            this.plC_Button131.字型鎖住 = false;
            this.plC_Button131.寫入元件位置 = "M510";
            this.plC_Button131.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button131.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button131.文字鎖住 = false;
            this.plC_Button131.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button131.狀態OFF圖片")));
            this.plC_Button131.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button131.狀態ON圖片")));
            this.plC_Button131.讀取位元反向 = false;
            this.plC_Button131.讀取元件位置 = "M510";
            this.plC_Button131.讀寫鎖住 = false;
            this.plC_Button131.起始狀態 = false;
            this.plC_Button131.音效 = true;
            this.plC_Button131.顯示 = false;
            this.plC_Button131.顯示狀態 = false;
            // 
            // plC_Button132
            // 
            this.plC_Button132.Bool = false;
            this.plC_Button132.but_press = false;
            this.plC_Button132.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button132.Location = new System.Drawing.Point(892, 12);
            this.plC_Button132.Name = "plC_Button132";
            this.plC_Button132.OFF_文字內容 = "Motor_05-09";
            this.plC_Button132.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button132.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button132.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button132.ON_文字內容 = "Motor_05-09";
            this.plC_Button132.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button132.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button132.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button132.Size = new System.Drawing.Size(104, 52);
            this.plC_Button132.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button132.TabIndex = 145;
            this.plC_Button132.事件驅動 = false;
            this.plC_Button132.字型鎖住 = false;
            this.plC_Button132.寫入元件位置 = "M509";
            this.plC_Button132.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button132.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button132.文字鎖住 = false;
            this.plC_Button132.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button132.狀態OFF圖片")));
            this.plC_Button132.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button132.狀態ON圖片")));
            this.plC_Button132.讀取位元反向 = false;
            this.plC_Button132.讀取元件位置 = "M509";
            this.plC_Button132.讀寫鎖住 = false;
            this.plC_Button132.起始狀態 = false;
            this.plC_Button132.音效 = true;
            this.plC_Button132.顯示 = false;
            this.plC_Button132.顯示狀態 = false;
            // 
            // plC_Button133
            // 
            this.plC_Button133.Bool = false;
            this.plC_Button133.but_press = false;
            this.plC_Button133.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button133.Location = new System.Drawing.Point(782, 12);
            this.plC_Button133.Name = "plC_Button133";
            this.plC_Button133.OFF_文字內容 = "Motor_05-08";
            this.plC_Button133.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button133.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button133.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button133.ON_文字內容 = "Motor_05-08";
            this.plC_Button133.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button133.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button133.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button133.Size = new System.Drawing.Size(104, 52);
            this.plC_Button133.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button133.TabIndex = 144;
            this.plC_Button133.事件驅動 = false;
            this.plC_Button133.字型鎖住 = false;
            this.plC_Button133.寫入元件位置 = "M508";
            this.plC_Button133.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button133.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button133.文字鎖住 = false;
            this.plC_Button133.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button133.狀態OFF圖片")));
            this.plC_Button133.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button133.狀態ON圖片")));
            this.plC_Button133.讀取位元反向 = false;
            this.plC_Button133.讀取元件位置 = "M508";
            this.plC_Button133.讀寫鎖住 = false;
            this.plC_Button133.起始狀態 = false;
            this.plC_Button133.音效 = true;
            this.plC_Button133.顯示 = false;
            this.plC_Button133.顯示狀態 = false;
            // 
            // plC_Button134
            // 
            this.plC_Button134.Bool = false;
            this.plC_Button134.but_press = false;
            this.plC_Button134.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button134.Location = new System.Drawing.Point(672, 12);
            this.plC_Button134.Name = "plC_Button134";
            this.plC_Button134.OFF_文字內容 = "Motor_05-07";
            this.plC_Button134.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button134.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button134.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button134.ON_文字內容 = "Motor_05-07";
            this.plC_Button134.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button134.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button134.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button134.Size = new System.Drawing.Size(104, 52);
            this.plC_Button134.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button134.TabIndex = 143;
            this.plC_Button134.事件驅動 = false;
            this.plC_Button134.字型鎖住 = false;
            this.plC_Button134.寫入元件位置 = "M507";
            this.plC_Button134.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button134.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button134.文字鎖住 = false;
            this.plC_Button134.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button134.狀態OFF圖片")));
            this.plC_Button134.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button134.狀態ON圖片")));
            this.plC_Button134.讀取位元反向 = false;
            this.plC_Button134.讀取元件位置 = "M507";
            this.plC_Button134.讀寫鎖住 = false;
            this.plC_Button134.起始狀態 = false;
            this.plC_Button134.音效 = true;
            this.plC_Button134.顯示 = false;
            this.plC_Button134.顯示狀態 = false;
            // 
            // plC_Button135
            // 
            this.plC_Button135.Bool = false;
            this.plC_Button135.but_press = false;
            this.plC_Button135.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button135.Location = new System.Drawing.Point(562, 12);
            this.plC_Button135.Name = "plC_Button135";
            this.plC_Button135.OFF_文字內容 = "Motor_05-06";
            this.plC_Button135.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button135.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button135.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button135.ON_文字內容 = "Motor_05-06";
            this.plC_Button135.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button135.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button135.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button135.Size = new System.Drawing.Size(104, 52);
            this.plC_Button135.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button135.TabIndex = 142;
            this.plC_Button135.事件驅動 = false;
            this.plC_Button135.字型鎖住 = false;
            this.plC_Button135.寫入元件位置 = "M506";
            this.plC_Button135.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button135.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button135.文字鎖住 = false;
            this.plC_Button135.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button135.狀態OFF圖片")));
            this.plC_Button135.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button135.狀態ON圖片")));
            this.plC_Button135.讀取位元反向 = false;
            this.plC_Button135.讀取元件位置 = "M506";
            this.plC_Button135.讀寫鎖住 = false;
            this.plC_Button135.起始狀態 = false;
            this.plC_Button135.音效 = true;
            this.plC_Button135.顯示 = false;
            this.plC_Button135.顯示狀態 = false;
            // 
            // plC_Button136
            // 
            this.plC_Button136.Bool = false;
            this.plC_Button136.but_press = false;
            this.plC_Button136.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button136.Location = new System.Drawing.Point(452, 12);
            this.plC_Button136.Name = "plC_Button136";
            this.plC_Button136.OFF_文字內容 = "Motor_05-05";
            this.plC_Button136.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button136.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button136.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button136.ON_文字內容 = "Motor_05-05";
            this.plC_Button136.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button136.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button136.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button136.Size = new System.Drawing.Size(104, 52);
            this.plC_Button136.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button136.TabIndex = 141;
            this.plC_Button136.事件驅動 = false;
            this.plC_Button136.字型鎖住 = false;
            this.plC_Button136.寫入元件位置 = "M505";
            this.plC_Button136.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button136.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button136.文字鎖住 = false;
            this.plC_Button136.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button136.狀態OFF圖片")));
            this.plC_Button136.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button136.狀態ON圖片")));
            this.plC_Button136.讀取位元反向 = false;
            this.plC_Button136.讀取元件位置 = "M505";
            this.plC_Button136.讀寫鎖住 = false;
            this.plC_Button136.起始狀態 = false;
            this.plC_Button136.音效 = true;
            this.plC_Button136.顯示 = false;
            this.plC_Button136.顯示狀態 = false;
            // 
            // plC_Button137
            // 
            this.plC_Button137.Bool = false;
            this.plC_Button137.but_press = false;
            this.plC_Button137.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button137.Location = new System.Drawing.Point(342, 12);
            this.plC_Button137.Name = "plC_Button137";
            this.plC_Button137.OFF_文字內容 = "Motor_05-04";
            this.plC_Button137.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button137.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button137.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button137.ON_文字內容 = "Motor_05-04";
            this.plC_Button137.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button137.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button137.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button137.Size = new System.Drawing.Size(104, 52);
            this.plC_Button137.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button137.TabIndex = 140;
            this.plC_Button137.事件驅動 = false;
            this.plC_Button137.字型鎖住 = false;
            this.plC_Button137.寫入元件位置 = "M504";
            this.plC_Button137.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button137.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button137.文字鎖住 = false;
            this.plC_Button137.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button137.狀態OFF圖片")));
            this.plC_Button137.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button137.狀態ON圖片")));
            this.plC_Button137.讀取位元反向 = false;
            this.plC_Button137.讀取元件位置 = "M504";
            this.plC_Button137.讀寫鎖住 = false;
            this.plC_Button137.起始狀態 = false;
            this.plC_Button137.音效 = true;
            this.plC_Button137.顯示 = false;
            this.plC_Button137.顯示狀態 = false;
            // 
            // plC_Button138
            // 
            this.plC_Button138.Bool = false;
            this.plC_Button138.but_press = false;
            this.plC_Button138.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button138.Location = new System.Drawing.Point(232, 12);
            this.plC_Button138.Name = "plC_Button138";
            this.plC_Button138.OFF_文字內容 = "Motor_05-03";
            this.plC_Button138.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button138.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button138.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button138.ON_文字內容 = "Motor_05-03";
            this.plC_Button138.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button138.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button138.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button138.Size = new System.Drawing.Size(104, 52);
            this.plC_Button138.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button138.TabIndex = 139;
            this.plC_Button138.事件驅動 = false;
            this.plC_Button138.字型鎖住 = false;
            this.plC_Button138.寫入元件位置 = "M503";
            this.plC_Button138.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button138.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button138.文字鎖住 = false;
            this.plC_Button138.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button138.狀態OFF圖片")));
            this.plC_Button138.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button138.狀態ON圖片")));
            this.plC_Button138.讀取位元反向 = false;
            this.plC_Button138.讀取元件位置 = "M503";
            this.plC_Button138.讀寫鎖住 = false;
            this.plC_Button138.起始狀態 = false;
            this.plC_Button138.音效 = true;
            this.plC_Button138.顯示 = false;
            this.plC_Button138.顯示狀態 = false;
            // 
            // plC_Button139
            // 
            this.plC_Button139.Bool = false;
            this.plC_Button139.but_press = false;
            this.plC_Button139.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button139.Location = new System.Drawing.Point(122, 12);
            this.plC_Button139.Name = "plC_Button139";
            this.plC_Button139.OFF_文字內容 = "Motor_05-02";
            this.plC_Button139.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button139.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button139.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button139.ON_文字內容 = "Motor_05-02";
            this.plC_Button139.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button139.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button139.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button139.Size = new System.Drawing.Size(104, 52);
            this.plC_Button139.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button139.TabIndex = 138;
            this.plC_Button139.事件驅動 = false;
            this.plC_Button139.字型鎖住 = false;
            this.plC_Button139.寫入元件位置 = "M502";
            this.plC_Button139.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button139.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button139.文字鎖住 = false;
            this.plC_Button139.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button139.狀態OFF圖片")));
            this.plC_Button139.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button139.狀態ON圖片")));
            this.plC_Button139.讀取位元反向 = false;
            this.plC_Button139.讀取元件位置 = "M502";
            this.plC_Button139.讀寫鎖住 = false;
            this.plC_Button139.起始狀態 = false;
            this.plC_Button139.音效 = true;
            this.plC_Button139.顯示 = false;
            this.plC_Button139.顯示狀態 = false;
            // 
            // plC_Button140
            // 
            this.plC_Button140.Bool = false;
            this.plC_Button140.but_press = false;
            this.plC_Button140.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button140.Location = new System.Drawing.Point(12, 12);
            this.plC_Button140.Name = "plC_Button140";
            this.plC_Button140.OFF_文字內容 = "Motor_05-01";
            this.plC_Button140.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button140.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button140.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button140.ON_文字內容 = "Motor_05-01";
            this.plC_Button140.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button140.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button140.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button140.Size = new System.Drawing.Size(104, 52);
            this.plC_Button140.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button140.TabIndex = 137;
            this.plC_Button140.事件驅動 = false;
            this.plC_Button140.字型鎖住 = false;
            this.plC_Button140.寫入元件位置 = "M501";
            this.plC_Button140.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button140.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button140.文字鎖住 = false;
            this.plC_Button140.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button140.狀態OFF圖片")));
            this.plC_Button140.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button140.狀態ON圖片")));
            this.plC_Button140.讀取位元反向 = false;
            this.plC_Button140.讀取元件位置 = "M501";
            this.plC_Button140.讀寫鎖住 = false;
            this.plC_Button140.起始狀態 = false;
            this.plC_Button140.音效 = true;
            this.plC_Button140.顯示 = false;
            this.plC_Button140.顯示狀態 = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.plC_Button113);
            this.panel14.Controls.Add(this.plC_Button114);
            this.panel14.Controls.Add(this.plC_Button115);
            this.panel14.Controls.Add(this.plC_Button116);
            this.panel14.Controls.Add(this.plC_Button117);
            this.panel14.Controls.Add(this.plC_Button118);
            this.panel14.Controls.Add(this.plC_Button119);
            this.panel14.Controls.Add(this.plC_Button120);
            this.panel14.Controls.Add(this.plC_Button121);
            this.panel14.Controls.Add(this.plC_Button122);
            this.panel14.Controls.Add(this.plC_Button123);
            this.panel14.Controls.Add(this.plC_Button124);
            this.panel14.Controls.Add(this.plC_Button125);
            this.panel14.Controls.Add(this.plC_Button126);
            this.panel14.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel14.Location = new System.Drawing.Point(0, 261);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(1638, 73);
            this.panel14.TabIndex = 93;
            // 
            // plC_Button113
            // 
            this.plC_Button113.Bool = false;
            this.plC_Button113.but_press = false;
            this.plC_Button113.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button113.Location = new System.Drawing.Point(1442, 11);
            this.plC_Button113.Name = "plC_Button113";
            this.plC_Button113.OFF_文字內容 = "LED_05-14";
            this.plC_Button113.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button113.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button113.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button113.ON_文字內容 = "LED_05-14";
            this.plC_Button113.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button113.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button113.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button113.Size = new System.Drawing.Size(104, 52);
            this.plC_Button113.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button113.TabIndex = 135;
            this.plC_Button113.事件驅動 = false;
            this.plC_Button113.字型鎖住 = false;
            this.plC_Button113.寫入元件位置 = "M1514";
            this.plC_Button113.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button113.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button113.文字鎖住 = false;
            this.plC_Button113.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button113.狀態OFF圖片")));
            this.plC_Button113.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button113.狀態ON圖片")));
            this.plC_Button113.讀取位元反向 = false;
            this.plC_Button113.讀取元件位置 = "M1514";
            this.plC_Button113.讀寫鎖住 = false;
            this.plC_Button113.起始狀態 = false;
            this.plC_Button113.音效 = true;
            this.plC_Button113.顯示 = false;
            this.plC_Button113.顯示狀態 = false;
            // 
            // plC_Button114
            // 
            this.plC_Button114.Bool = false;
            this.plC_Button114.but_press = false;
            this.plC_Button114.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button114.Location = new System.Drawing.Point(1332, 11);
            this.plC_Button114.Name = "plC_Button114";
            this.plC_Button114.OFF_文字內容 = "LED_05-13";
            this.plC_Button114.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button114.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button114.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button114.ON_文字內容 = "LED_05-13";
            this.plC_Button114.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button114.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button114.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button114.Size = new System.Drawing.Size(104, 52);
            this.plC_Button114.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button114.TabIndex = 133;
            this.plC_Button114.事件驅動 = false;
            this.plC_Button114.字型鎖住 = false;
            this.plC_Button114.寫入元件位置 = "M1513";
            this.plC_Button114.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button114.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button114.文字鎖住 = false;
            this.plC_Button114.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button114.狀態OFF圖片")));
            this.plC_Button114.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button114.狀態ON圖片")));
            this.plC_Button114.讀取位元反向 = false;
            this.plC_Button114.讀取元件位置 = "M1513";
            this.plC_Button114.讀寫鎖住 = false;
            this.plC_Button114.起始狀態 = false;
            this.plC_Button114.音效 = true;
            this.plC_Button114.顯示 = false;
            this.plC_Button114.顯示狀態 = false;
            // 
            // plC_Button115
            // 
            this.plC_Button115.Bool = false;
            this.plC_Button115.but_press = false;
            this.plC_Button115.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button115.Location = new System.Drawing.Point(1222, 11);
            this.plC_Button115.Name = "plC_Button115";
            this.plC_Button115.OFF_文字內容 = "LED_05-12";
            this.plC_Button115.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button115.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button115.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button115.ON_文字內容 = "LED_05-12";
            this.plC_Button115.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button115.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button115.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button115.Size = new System.Drawing.Size(104, 52);
            this.plC_Button115.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button115.TabIndex = 131;
            this.plC_Button115.事件驅動 = false;
            this.plC_Button115.字型鎖住 = false;
            this.plC_Button115.寫入元件位置 = "M1512";
            this.plC_Button115.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button115.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button115.文字鎖住 = false;
            this.plC_Button115.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button115.狀態OFF圖片")));
            this.plC_Button115.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button115.狀態ON圖片")));
            this.plC_Button115.讀取位元反向 = false;
            this.plC_Button115.讀取元件位置 = "M1512";
            this.plC_Button115.讀寫鎖住 = false;
            this.plC_Button115.起始狀態 = false;
            this.plC_Button115.音效 = true;
            this.plC_Button115.顯示 = false;
            this.plC_Button115.顯示狀態 = false;
            // 
            // plC_Button116
            // 
            this.plC_Button116.Bool = false;
            this.plC_Button116.but_press = false;
            this.plC_Button116.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button116.Location = new System.Drawing.Point(1112, 11);
            this.plC_Button116.Name = "plC_Button116";
            this.plC_Button116.OFF_文字內容 = "LED_05-11";
            this.plC_Button116.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button116.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button116.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button116.ON_文字內容 = "LED_05-11";
            this.plC_Button116.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button116.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button116.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button116.Size = new System.Drawing.Size(104, 52);
            this.plC_Button116.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button116.TabIndex = 129;
            this.plC_Button116.事件驅動 = false;
            this.plC_Button116.字型鎖住 = false;
            this.plC_Button116.寫入元件位置 = "M1511";
            this.plC_Button116.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button116.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button116.文字鎖住 = false;
            this.plC_Button116.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button116.狀態OFF圖片")));
            this.plC_Button116.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button116.狀態ON圖片")));
            this.plC_Button116.讀取位元反向 = false;
            this.plC_Button116.讀取元件位置 = "M1511";
            this.plC_Button116.讀寫鎖住 = false;
            this.plC_Button116.起始狀態 = false;
            this.plC_Button116.音效 = true;
            this.plC_Button116.顯示 = false;
            this.plC_Button116.顯示狀態 = false;
            // 
            // plC_Button117
            // 
            this.plC_Button117.Bool = false;
            this.plC_Button117.but_press = false;
            this.plC_Button117.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button117.Location = new System.Drawing.Point(1002, 11);
            this.plC_Button117.Name = "plC_Button117";
            this.plC_Button117.OFF_文字內容 = "LED_05-10";
            this.plC_Button117.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button117.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button117.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button117.ON_文字內容 = "LED_05-10";
            this.plC_Button117.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button117.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button117.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button117.Size = new System.Drawing.Size(104, 52);
            this.plC_Button117.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button117.TabIndex = 127;
            this.plC_Button117.事件驅動 = false;
            this.plC_Button117.字型鎖住 = false;
            this.plC_Button117.寫入元件位置 = "M1510";
            this.plC_Button117.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button117.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button117.文字鎖住 = false;
            this.plC_Button117.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button117.狀態OFF圖片")));
            this.plC_Button117.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button117.狀態ON圖片")));
            this.plC_Button117.讀取位元反向 = false;
            this.plC_Button117.讀取元件位置 = "M1510";
            this.plC_Button117.讀寫鎖住 = false;
            this.plC_Button117.起始狀態 = false;
            this.plC_Button117.音效 = true;
            this.plC_Button117.顯示 = false;
            this.plC_Button117.顯示狀態 = false;
            // 
            // plC_Button118
            // 
            this.plC_Button118.Bool = false;
            this.plC_Button118.but_press = false;
            this.plC_Button118.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button118.Location = new System.Drawing.Point(892, 11);
            this.plC_Button118.Name = "plC_Button118";
            this.plC_Button118.OFF_文字內容 = "LED_05-09";
            this.plC_Button118.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button118.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button118.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button118.ON_文字內容 = "LED_05-09";
            this.plC_Button118.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button118.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button118.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button118.Size = new System.Drawing.Size(104, 52);
            this.plC_Button118.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button118.TabIndex = 125;
            this.plC_Button118.事件驅動 = false;
            this.plC_Button118.字型鎖住 = false;
            this.plC_Button118.寫入元件位置 = "M1509";
            this.plC_Button118.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button118.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button118.文字鎖住 = false;
            this.plC_Button118.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button118.狀態OFF圖片")));
            this.plC_Button118.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button118.狀態ON圖片")));
            this.plC_Button118.讀取位元反向 = false;
            this.plC_Button118.讀取元件位置 = "M1509";
            this.plC_Button118.讀寫鎖住 = false;
            this.plC_Button118.起始狀態 = false;
            this.plC_Button118.音效 = true;
            this.plC_Button118.顯示 = false;
            this.plC_Button118.顯示狀態 = false;
            // 
            // plC_Button119
            // 
            this.plC_Button119.Bool = false;
            this.plC_Button119.but_press = false;
            this.plC_Button119.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button119.Location = new System.Drawing.Point(782, 11);
            this.plC_Button119.Name = "plC_Button119";
            this.plC_Button119.OFF_文字內容 = "LED_05-08";
            this.plC_Button119.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button119.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button119.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button119.ON_文字內容 = "LED_05-08";
            this.plC_Button119.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button119.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button119.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button119.Size = new System.Drawing.Size(104, 52);
            this.plC_Button119.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button119.TabIndex = 123;
            this.plC_Button119.事件驅動 = false;
            this.plC_Button119.字型鎖住 = false;
            this.plC_Button119.寫入元件位置 = "M1508";
            this.plC_Button119.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button119.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button119.文字鎖住 = false;
            this.plC_Button119.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button119.狀態OFF圖片")));
            this.plC_Button119.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button119.狀態ON圖片")));
            this.plC_Button119.讀取位元反向 = false;
            this.plC_Button119.讀取元件位置 = "M1508";
            this.plC_Button119.讀寫鎖住 = false;
            this.plC_Button119.起始狀態 = false;
            this.plC_Button119.音效 = true;
            this.plC_Button119.顯示 = false;
            this.plC_Button119.顯示狀態 = false;
            // 
            // plC_Button120
            // 
            this.plC_Button120.Bool = false;
            this.plC_Button120.but_press = false;
            this.plC_Button120.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button120.Location = new System.Drawing.Point(672, 11);
            this.plC_Button120.Name = "plC_Button120";
            this.plC_Button120.OFF_文字內容 = "LED_05-07";
            this.plC_Button120.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button120.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button120.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button120.ON_文字內容 = "LED_05-07";
            this.plC_Button120.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button120.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button120.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button120.Size = new System.Drawing.Size(104, 52);
            this.plC_Button120.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button120.TabIndex = 121;
            this.plC_Button120.事件驅動 = false;
            this.plC_Button120.字型鎖住 = false;
            this.plC_Button120.寫入元件位置 = "M1507";
            this.plC_Button120.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button120.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button120.文字鎖住 = false;
            this.plC_Button120.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button120.狀態OFF圖片")));
            this.plC_Button120.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button120.狀態ON圖片")));
            this.plC_Button120.讀取位元反向 = false;
            this.plC_Button120.讀取元件位置 = "M1507";
            this.plC_Button120.讀寫鎖住 = false;
            this.plC_Button120.起始狀態 = false;
            this.plC_Button120.音效 = true;
            this.plC_Button120.顯示 = false;
            this.plC_Button120.顯示狀態 = false;
            // 
            // plC_Button121
            // 
            this.plC_Button121.Bool = false;
            this.plC_Button121.but_press = false;
            this.plC_Button121.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button121.Location = new System.Drawing.Point(562, 11);
            this.plC_Button121.Name = "plC_Button121";
            this.plC_Button121.OFF_文字內容 = "LED_05-06";
            this.plC_Button121.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button121.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button121.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button121.ON_文字內容 = "LED_05-06";
            this.plC_Button121.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button121.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button121.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button121.Size = new System.Drawing.Size(104, 52);
            this.plC_Button121.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button121.TabIndex = 119;
            this.plC_Button121.事件驅動 = false;
            this.plC_Button121.字型鎖住 = false;
            this.plC_Button121.寫入元件位置 = "M1506";
            this.plC_Button121.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button121.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button121.文字鎖住 = false;
            this.plC_Button121.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button121.狀態OFF圖片")));
            this.plC_Button121.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button121.狀態ON圖片")));
            this.plC_Button121.讀取位元反向 = false;
            this.plC_Button121.讀取元件位置 = "M1506";
            this.plC_Button121.讀寫鎖住 = false;
            this.plC_Button121.起始狀態 = false;
            this.plC_Button121.音效 = true;
            this.plC_Button121.顯示 = false;
            this.plC_Button121.顯示狀態 = false;
            // 
            // plC_Button122
            // 
            this.plC_Button122.Bool = false;
            this.plC_Button122.but_press = false;
            this.plC_Button122.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button122.Location = new System.Drawing.Point(452, 11);
            this.plC_Button122.Name = "plC_Button122";
            this.plC_Button122.OFF_文字內容 = "LED_05-05";
            this.plC_Button122.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button122.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button122.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button122.ON_文字內容 = "LED_05-05";
            this.plC_Button122.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button122.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button122.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button122.Size = new System.Drawing.Size(104, 52);
            this.plC_Button122.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button122.TabIndex = 117;
            this.plC_Button122.事件驅動 = false;
            this.plC_Button122.字型鎖住 = false;
            this.plC_Button122.寫入元件位置 = "M1505";
            this.plC_Button122.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button122.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button122.文字鎖住 = false;
            this.plC_Button122.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button122.狀態OFF圖片")));
            this.plC_Button122.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button122.狀態ON圖片")));
            this.plC_Button122.讀取位元反向 = false;
            this.plC_Button122.讀取元件位置 = "M1505";
            this.plC_Button122.讀寫鎖住 = false;
            this.plC_Button122.起始狀態 = false;
            this.plC_Button122.音效 = true;
            this.plC_Button122.顯示 = false;
            this.plC_Button122.顯示狀態 = false;
            // 
            // plC_Button123
            // 
            this.plC_Button123.Bool = false;
            this.plC_Button123.but_press = false;
            this.plC_Button123.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button123.Location = new System.Drawing.Point(342, 11);
            this.plC_Button123.Name = "plC_Button123";
            this.plC_Button123.OFF_文字內容 = "LED_05-04";
            this.plC_Button123.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button123.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button123.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button123.ON_文字內容 = "LED_05-04";
            this.plC_Button123.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button123.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button123.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button123.Size = new System.Drawing.Size(104, 52);
            this.plC_Button123.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button123.TabIndex = 115;
            this.plC_Button123.事件驅動 = false;
            this.plC_Button123.字型鎖住 = false;
            this.plC_Button123.寫入元件位置 = "M1504";
            this.plC_Button123.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button123.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button123.文字鎖住 = false;
            this.plC_Button123.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button123.狀態OFF圖片")));
            this.plC_Button123.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button123.狀態ON圖片")));
            this.plC_Button123.讀取位元反向 = false;
            this.plC_Button123.讀取元件位置 = "M1504";
            this.plC_Button123.讀寫鎖住 = false;
            this.plC_Button123.起始狀態 = false;
            this.plC_Button123.音效 = true;
            this.plC_Button123.顯示 = false;
            this.plC_Button123.顯示狀態 = false;
            // 
            // plC_Button124
            // 
            this.plC_Button124.Bool = false;
            this.plC_Button124.but_press = false;
            this.plC_Button124.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button124.Location = new System.Drawing.Point(232, 11);
            this.plC_Button124.Name = "plC_Button124";
            this.plC_Button124.OFF_文字內容 = "LED_05-03";
            this.plC_Button124.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button124.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button124.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button124.ON_文字內容 = "LED_05-03";
            this.plC_Button124.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button124.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button124.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button124.Size = new System.Drawing.Size(104, 52);
            this.plC_Button124.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button124.TabIndex = 113;
            this.plC_Button124.事件驅動 = false;
            this.plC_Button124.字型鎖住 = false;
            this.plC_Button124.寫入元件位置 = "M1503";
            this.plC_Button124.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button124.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button124.文字鎖住 = false;
            this.plC_Button124.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button124.狀態OFF圖片")));
            this.plC_Button124.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button124.狀態ON圖片")));
            this.plC_Button124.讀取位元反向 = false;
            this.plC_Button124.讀取元件位置 = "M1503";
            this.plC_Button124.讀寫鎖住 = false;
            this.plC_Button124.起始狀態 = false;
            this.plC_Button124.音效 = true;
            this.plC_Button124.顯示 = false;
            this.plC_Button124.顯示狀態 = false;
            // 
            // plC_Button125
            // 
            this.plC_Button125.Bool = false;
            this.plC_Button125.but_press = false;
            this.plC_Button125.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button125.Location = new System.Drawing.Point(122, 11);
            this.plC_Button125.Name = "plC_Button125";
            this.plC_Button125.OFF_文字內容 = "LED_05-02";
            this.plC_Button125.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button125.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button125.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button125.ON_文字內容 = "LED_05-02";
            this.plC_Button125.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button125.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button125.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button125.Size = new System.Drawing.Size(104, 52);
            this.plC_Button125.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button125.TabIndex = 111;
            this.plC_Button125.事件驅動 = false;
            this.plC_Button125.字型鎖住 = false;
            this.plC_Button125.寫入元件位置 = "M1502";
            this.plC_Button125.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button125.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button125.文字鎖住 = false;
            this.plC_Button125.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button125.狀態OFF圖片")));
            this.plC_Button125.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button125.狀態ON圖片")));
            this.plC_Button125.讀取位元反向 = false;
            this.plC_Button125.讀取元件位置 = "M1502";
            this.plC_Button125.讀寫鎖住 = false;
            this.plC_Button125.起始狀態 = false;
            this.plC_Button125.音效 = true;
            this.plC_Button125.顯示 = false;
            this.plC_Button125.顯示狀態 = false;
            // 
            // plC_Button126
            // 
            this.plC_Button126.Bool = false;
            this.plC_Button126.but_press = false;
            this.plC_Button126.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button126.Location = new System.Drawing.Point(12, 11);
            this.plC_Button126.Name = "plC_Button126";
            this.plC_Button126.OFF_文字內容 = "LED_05-01";
            this.plC_Button126.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button126.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button126.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button126.ON_文字內容 = "LED_05-01";
            this.plC_Button126.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button126.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button126.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button126.Size = new System.Drawing.Size(104, 52);
            this.plC_Button126.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button126.TabIndex = 109;
            this.plC_Button126.事件驅動 = false;
            this.plC_Button126.字型鎖住 = false;
            this.plC_Button126.寫入元件位置 = "M1501";
            this.plC_Button126.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button126.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button126.文字鎖住 = false;
            this.plC_Button126.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button126.狀態OFF圖片")));
            this.plC_Button126.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button126.狀態ON圖片")));
            this.plC_Button126.讀取位元反向 = false;
            this.plC_Button126.讀取元件位置 = "M1501";
            this.plC_Button126.讀寫鎖住 = false;
            this.plC_Button126.起始狀態 = false;
            this.plC_Button126.音效 = true;
            this.plC_Button126.顯示 = false;
            this.plC_Button126.顯示狀態 = false;
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 334);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(1638, 17);
            this.panel13.TabIndex = 92;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.plC_Button99);
            this.panel12.Controls.Add(this.plC_Button100);
            this.panel12.Controls.Add(this.plC_Button101);
            this.panel12.Controls.Add(this.plC_Button102);
            this.panel12.Controls.Add(this.plC_Button103);
            this.panel12.Controls.Add(this.plC_Button104);
            this.panel12.Controls.Add(this.plC_Button105);
            this.panel12.Controls.Add(this.plC_Button106);
            this.panel12.Controls.Add(this.plC_Button107);
            this.panel12.Controls.Add(this.plC_Button108);
            this.panel12.Controls.Add(this.plC_Button109);
            this.panel12.Controls.Add(this.plC_Button110);
            this.panel12.Controls.Add(this.plC_Button111);
            this.panel12.Controls.Add(this.plC_Button112);
            this.panel12.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel12.Location = new System.Drawing.Point(0, 351);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(1638, 73);
            this.panel12.TabIndex = 91;
            // 
            // plC_Button99
            // 
            this.plC_Button99.Bool = false;
            this.plC_Button99.but_press = false;
            this.plC_Button99.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button99.Location = new System.Drawing.Point(1442, 12);
            this.plC_Button99.Name = "plC_Button99";
            this.plC_Button99.OFF_文字內容 = "Motor_04-14";
            this.plC_Button99.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button99.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button99.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button99.ON_文字內容 = "Motor_04-14";
            this.plC_Button99.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button99.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button99.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button99.Size = new System.Drawing.Size(104, 52);
            this.plC_Button99.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button99.TabIndex = 150;
            this.plC_Button99.事件驅動 = false;
            this.plC_Button99.字型鎖住 = false;
            this.plC_Button99.寫入元件位置 = "M414";
            this.plC_Button99.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button99.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button99.文字鎖住 = false;
            this.plC_Button99.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button99.狀態OFF圖片")));
            this.plC_Button99.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button99.狀態ON圖片")));
            this.plC_Button99.讀取位元反向 = false;
            this.plC_Button99.讀取元件位置 = "M414";
            this.plC_Button99.讀寫鎖住 = false;
            this.plC_Button99.起始狀態 = false;
            this.plC_Button99.音效 = true;
            this.plC_Button99.顯示 = false;
            this.plC_Button99.顯示狀態 = false;
            // 
            // plC_Button100
            // 
            this.plC_Button100.Bool = false;
            this.plC_Button100.but_press = false;
            this.plC_Button100.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button100.Location = new System.Drawing.Point(1332, 12);
            this.plC_Button100.Name = "plC_Button100";
            this.plC_Button100.OFF_文字內容 = "Motor_04-13";
            this.plC_Button100.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button100.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button100.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button100.ON_文字內容 = "Motor_04-13";
            this.plC_Button100.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button100.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button100.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button100.Size = new System.Drawing.Size(104, 52);
            this.plC_Button100.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button100.TabIndex = 149;
            this.plC_Button100.事件驅動 = false;
            this.plC_Button100.字型鎖住 = false;
            this.plC_Button100.寫入元件位置 = "M413";
            this.plC_Button100.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button100.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button100.文字鎖住 = false;
            this.plC_Button100.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button100.狀態OFF圖片")));
            this.plC_Button100.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button100.狀態ON圖片")));
            this.plC_Button100.讀取位元反向 = false;
            this.plC_Button100.讀取元件位置 = "M413";
            this.plC_Button100.讀寫鎖住 = false;
            this.plC_Button100.起始狀態 = false;
            this.plC_Button100.音效 = true;
            this.plC_Button100.顯示 = false;
            this.plC_Button100.顯示狀態 = false;
            // 
            // plC_Button101
            // 
            this.plC_Button101.Bool = false;
            this.plC_Button101.but_press = false;
            this.plC_Button101.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button101.Location = new System.Drawing.Point(1222, 12);
            this.plC_Button101.Name = "plC_Button101";
            this.plC_Button101.OFF_文字內容 = "Motor_04-12";
            this.plC_Button101.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button101.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button101.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button101.ON_文字內容 = "Motor_04-12";
            this.plC_Button101.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button101.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button101.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button101.Size = new System.Drawing.Size(104, 52);
            this.plC_Button101.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button101.TabIndex = 148;
            this.plC_Button101.事件驅動 = false;
            this.plC_Button101.字型鎖住 = false;
            this.plC_Button101.寫入元件位置 = "M412";
            this.plC_Button101.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button101.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button101.文字鎖住 = false;
            this.plC_Button101.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button101.狀態OFF圖片")));
            this.plC_Button101.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button101.狀態ON圖片")));
            this.plC_Button101.讀取位元反向 = false;
            this.plC_Button101.讀取元件位置 = "M412";
            this.plC_Button101.讀寫鎖住 = false;
            this.plC_Button101.起始狀態 = false;
            this.plC_Button101.音效 = true;
            this.plC_Button101.顯示 = false;
            this.plC_Button101.顯示狀態 = false;
            // 
            // plC_Button102
            // 
            this.plC_Button102.Bool = false;
            this.plC_Button102.but_press = false;
            this.plC_Button102.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button102.Location = new System.Drawing.Point(1112, 12);
            this.plC_Button102.Name = "plC_Button102";
            this.plC_Button102.OFF_文字內容 = "Motor_04-11";
            this.plC_Button102.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button102.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button102.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button102.ON_文字內容 = "Motor_04-11";
            this.plC_Button102.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button102.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button102.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button102.Size = new System.Drawing.Size(104, 52);
            this.plC_Button102.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button102.TabIndex = 147;
            this.plC_Button102.事件驅動 = false;
            this.plC_Button102.字型鎖住 = false;
            this.plC_Button102.寫入元件位置 = "M411";
            this.plC_Button102.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button102.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button102.文字鎖住 = false;
            this.plC_Button102.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button102.狀態OFF圖片")));
            this.plC_Button102.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button102.狀態ON圖片")));
            this.plC_Button102.讀取位元反向 = false;
            this.plC_Button102.讀取元件位置 = "M411";
            this.plC_Button102.讀寫鎖住 = false;
            this.plC_Button102.起始狀態 = false;
            this.plC_Button102.音效 = true;
            this.plC_Button102.顯示 = false;
            this.plC_Button102.顯示狀態 = false;
            // 
            // plC_Button103
            // 
            this.plC_Button103.Bool = false;
            this.plC_Button103.but_press = false;
            this.plC_Button103.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button103.Location = new System.Drawing.Point(1002, 12);
            this.plC_Button103.Name = "plC_Button103";
            this.plC_Button103.OFF_文字內容 = "Motor_04-10";
            this.plC_Button103.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button103.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button103.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button103.ON_文字內容 = "Motor_04-10";
            this.plC_Button103.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button103.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button103.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button103.Size = new System.Drawing.Size(104, 52);
            this.plC_Button103.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button103.TabIndex = 146;
            this.plC_Button103.事件驅動 = false;
            this.plC_Button103.字型鎖住 = false;
            this.plC_Button103.寫入元件位置 = "M410";
            this.plC_Button103.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button103.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button103.文字鎖住 = false;
            this.plC_Button103.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button103.狀態OFF圖片")));
            this.plC_Button103.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button103.狀態ON圖片")));
            this.plC_Button103.讀取位元反向 = false;
            this.plC_Button103.讀取元件位置 = "M410";
            this.plC_Button103.讀寫鎖住 = false;
            this.plC_Button103.起始狀態 = false;
            this.plC_Button103.音效 = true;
            this.plC_Button103.顯示 = false;
            this.plC_Button103.顯示狀態 = false;
            // 
            // plC_Button104
            // 
            this.plC_Button104.Bool = false;
            this.plC_Button104.but_press = false;
            this.plC_Button104.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button104.Location = new System.Drawing.Point(892, 12);
            this.plC_Button104.Name = "plC_Button104";
            this.plC_Button104.OFF_文字內容 = "Motor_04-09";
            this.plC_Button104.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button104.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button104.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button104.ON_文字內容 = "Motor_04-09";
            this.plC_Button104.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button104.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button104.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button104.Size = new System.Drawing.Size(104, 52);
            this.plC_Button104.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button104.TabIndex = 145;
            this.plC_Button104.事件驅動 = false;
            this.plC_Button104.字型鎖住 = false;
            this.plC_Button104.寫入元件位置 = "M409";
            this.plC_Button104.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button104.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button104.文字鎖住 = false;
            this.plC_Button104.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button104.狀態OFF圖片")));
            this.plC_Button104.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button104.狀態ON圖片")));
            this.plC_Button104.讀取位元反向 = false;
            this.plC_Button104.讀取元件位置 = "M409";
            this.plC_Button104.讀寫鎖住 = false;
            this.plC_Button104.起始狀態 = false;
            this.plC_Button104.音效 = true;
            this.plC_Button104.顯示 = false;
            this.plC_Button104.顯示狀態 = false;
            // 
            // plC_Button105
            // 
            this.plC_Button105.Bool = false;
            this.plC_Button105.but_press = false;
            this.plC_Button105.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button105.Location = new System.Drawing.Point(782, 12);
            this.plC_Button105.Name = "plC_Button105";
            this.plC_Button105.OFF_文字內容 = "Motor_04-08";
            this.plC_Button105.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button105.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button105.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button105.ON_文字內容 = "Motor_04-08";
            this.plC_Button105.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button105.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button105.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button105.Size = new System.Drawing.Size(104, 52);
            this.plC_Button105.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button105.TabIndex = 144;
            this.plC_Button105.事件驅動 = false;
            this.plC_Button105.字型鎖住 = false;
            this.plC_Button105.寫入元件位置 = "M408";
            this.plC_Button105.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button105.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button105.文字鎖住 = false;
            this.plC_Button105.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button105.狀態OFF圖片")));
            this.plC_Button105.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button105.狀態ON圖片")));
            this.plC_Button105.讀取位元反向 = false;
            this.plC_Button105.讀取元件位置 = "M408";
            this.plC_Button105.讀寫鎖住 = false;
            this.plC_Button105.起始狀態 = false;
            this.plC_Button105.音效 = true;
            this.plC_Button105.顯示 = false;
            this.plC_Button105.顯示狀態 = false;
            // 
            // plC_Button106
            // 
            this.plC_Button106.Bool = false;
            this.plC_Button106.but_press = false;
            this.plC_Button106.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button106.Location = new System.Drawing.Point(672, 12);
            this.plC_Button106.Name = "plC_Button106";
            this.plC_Button106.OFF_文字內容 = "Motor_04-07";
            this.plC_Button106.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button106.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button106.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button106.ON_文字內容 = "Motor_04-07";
            this.plC_Button106.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button106.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button106.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button106.Size = new System.Drawing.Size(104, 52);
            this.plC_Button106.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button106.TabIndex = 143;
            this.plC_Button106.事件驅動 = false;
            this.plC_Button106.字型鎖住 = false;
            this.plC_Button106.寫入元件位置 = "M407";
            this.plC_Button106.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button106.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button106.文字鎖住 = false;
            this.plC_Button106.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button106.狀態OFF圖片")));
            this.plC_Button106.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button106.狀態ON圖片")));
            this.plC_Button106.讀取位元反向 = false;
            this.plC_Button106.讀取元件位置 = "M407";
            this.plC_Button106.讀寫鎖住 = false;
            this.plC_Button106.起始狀態 = false;
            this.plC_Button106.音效 = true;
            this.plC_Button106.顯示 = false;
            this.plC_Button106.顯示狀態 = false;
            // 
            // plC_Button107
            // 
            this.plC_Button107.Bool = false;
            this.plC_Button107.but_press = false;
            this.plC_Button107.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button107.Location = new System.Drawing.Point(562, 12);
            this.plC_Button107.Name = "plC_Button107";
            this.plC_Button107.OFF_文字內容 = "Motor_04-06";
            this.plC_Button107.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button107.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button107.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button107.ON_文字內容 = "Motor_04-06";
            this.plC_Button107.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button107.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button107.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button107.Size = new System.Drawing.Size(104, 52);
            this.plC_Button107.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button107.TabIndex = 142;
            this.plC_Button107.事件驅動 = false;
            this.plC_Button107.字型鎖住 = false;
            this.plC_Button107.寫入元件位置 = "M406";
            this.plC_Button107.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button107.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button107.文字鎖住 = false;
            this.plC_Button107.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button107.狀態OFF圖片")));
            this.plC_Button107.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button107.狀態ON圖片")));
            this.plC_Button107.讀取位元反向 = false;
            this.plC_Button107.讀取元件位置 = "M406";
            this.plC_Button107.讀寫鎖住 = false;
            this.plC_Button107.起始狀態 = false;
            this.plC_Button107.音效 = true;
            this.plC_Button107.顯示 = false;
            this.plC_Button107.顯示狀態 = false;
            // 
            // plC_Button108
            // 
            this.plC_Button108.Bool = false;
            this.plC_Button108.but_press = false;
            this.plC_Button108.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button108.Location = new System.Drawing.Point(452, 12);
            this.plC_Button108.Name = "plC_Button108";
            this.plC_Button108.OFF_文字內容 = "Motor_04-05";
            this.plC_Button108.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button108.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button108.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button108.ON_文字內容 = "Motor_04-05";
            this.plC_Button108.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button108.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button108.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button108.Size = new System.Drawing.Size(104, 52);
            this.plC_Button108.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button108.TabIndex = 141;
            this.plC_Button108.事件驅動 = false;
            this.plC_Button108.字型鎖住 = false;
            this.plC_Button108.寫入元件位置 = "M405";
            this.plC_Button108.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button108.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button108.文字鎖住 = false;
            this.plC_Button108.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button108.狀態OFF圖片")));
            this.plC_Button108.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button108.狀態ON圖片")));
            this.plC_Button108.讀取位元反向 = false;
            this.plC_Button108.讀取元件位置 = "M405";
            this.plC_Button108.讀寫鎖住 = false;
            this.plC_Button108.起始狀態 = false;
            this.plC_Button108.音效 = true;
            this.plC_Button108.顯示 = false;
            this.plC_Button108.顯示狀態 = false;
            // 
            // plC_Button109
            // 
            this.plC_Button109.Bool = false;
            this.plC_Button109.but_press = false;
            this.plC_Button109.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button109.Location = new System.Drawing.Point(342, 12);
            this.plC_Button109.Name = "plC_Button109";
            this.plC_Button109.OFF_文字內容 = "Motor_04-04";
            this.plC_Button109.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button109.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button109.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button109.ON_文字內容 = "Motor_04-04";
            this.plC_Button109.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button109.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button109.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button109.Size = new System.Drawing.Size(104, 52);
            this.plC_Button109.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button109.TabIndex = 140;
            this.plC_Button109.事件驅動 = false;
            this.plC_Button109.字型鎖住 = false;
            this.plC_Button109.寫入元件位置 = "M404";
            this.plC_Button109.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button109.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button109.文字鎖住 = false;
            this.plC_Button109.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button109.狀態OFF圖片")));
            this.plC_Button109.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button109.狀態ON圖片")));
            this.plC_Button109.讀取位元反向 = false;
            this.plC_Button109.讀取元件位置 = "M404";
            this.plC_Button109.讀寫鎖住 = false;
            this.plC_Button109.起始狀態 = false;
            this.plC_Button109.音效 = true;
            this.plC_Button109.顯示 = false;
            this.plC_Button109.顯示狀態 = false;
            // 
            // plC_Button110
            // 
            this.plC_Button110.Bool = false;
            this.plC_Button110.but_press = false;
            this.plC_Button110.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button110.Location = new System.Drawing.Point(232, 12);
            this.plC_Button110.Name = "plC_Button110";
            this.plC_Button110.OFF_文字內容 = "Motor_04-03";
            this.plC_Button110.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button110.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button110.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button110.ON_文字內容 = "Motor_04-03";
            this.plC_Button110.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button110.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button110.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button110.Size = new System.Drawing.Size(104, 52);
            this.plC_Button110.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button110.TabIndex = 139;
            this.plC_Button110.事件驅動 = false;
            this.plC_Button110.字型鎖住 = false;
            this.plC_Button110.寫入元件位置 = "M403";
            this.plC_Button110.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button110.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button110.文字鎖住 = false;
            this.plC_Button110.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button110.狀態OFF圖片")));
            this.plC_Button110.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button110.狀態ON圖片")));
            this.plC_Button110.讀取位元反向 = false;
            this.plC_Button110.讀取元件位置 = "M403";
            this.plC_Button110.讀寫鎖住 = false;
            this.plC_Button110.起始狀態 = false;
            this.plC_Button110.音效 = true;
            this.plC_Button110.顯示 = false;
            this.plC_Button110.顯示狀態 = false;
            // 
            // plC_Button111
            // 
            this.plC_Button111.Bool = false;
            this.plC_Button111.but_press = false;
            this.plC_Button111.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button111.Location = new System.Drawing.Point(122, 12);
            this.plC_Button111.Name = "plC_Button111";
            this.plC_Button111.OFF_文字內容 = "Motor_04-02";
            this.plC_Button111.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button111.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button111.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button111.ON_文字內容 = "Motor_04-02";
            this.plC_Button111.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button111.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button111.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button111.Size = new System.Drawing.Size(104, 52);
            this.plC_Button111.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button111.TabIndex = 138;
            this.plC_Button111.事件驅動 = false;
            this.plC_Button111.字型鎖住 = false;
            this.plC_Button111.寫入元件位置 = "M402";
            this.plC_Button111.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button111.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button111.文字鎖住 = false;
            this.plC_Button111.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button111.狀態OFF圖片")));
            this.plC_Button111.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button111.狀態ON圖片")));
            this.plC_Button111.讀取位元反向 = false;
            this.plC_Button111.讀取元件位置 = "M402";
            this.plC_Button111.讀寫鎖住 = false;
            this.plC_Button111.起始狀態 = false;
            this.plC_Button111.音效 = true;
            this.plC_Button111.顯示 = false;
            this.plC_Button111.顯示狀態 = false;
            // 
            // plC_Button112
            // 
            this.plC_Button112.Bool = false;
            this.plC_Button112.but_press = false;
            this.plC_Button112.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button112.Location = new System.Drawing.Point(12, 12);
            this.plC_Button112.Name = "plC_Button112";
            this.plC_Button112.OFF_文字內容 = "Motor_04-01";
            this.plC_Button112.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button112.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button112.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button112.ON_文字內容 = "Motor_04-01";
            this.plC_Button112.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button112.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button112.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button112.Size = new System.Drawing.Size(104, 52);
            this.plC_Button112.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button112.TabIndex = 137;
            this.plC_Button112.事件驅動 = false;
            this.plC_Button112.字型鎖住 = false;
            this.plC_Button112.寫入元件位置 = "M401";
            this.plC_Button112.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button112.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button112.文字鎖住 = false;
            this.plC_Button112.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button112.狀態OFF圖片")));
            this.plC_Button112.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button112.狀態ON圖片")));
            this.plC_Button112.讀取位元反向 = false;
            this.plC_Button112.讀取元件位置 = "M401";
            this.plC_Button112.讀寫鎖住 = false;
            this.plC_Button112.起始狀態 = false;
            this.plC_Button112.音效 = true;
            this.plC_Button112.顯示 = false;
            this.plC_Button112.顯示狀態 = false;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.plC_Button85);
            this.panel11.Controls.Add(this.plC_Button86);
            this.panel11.Controls.Add(this.plC_Button87);
            this.panel11.Controls.Add(this.plC_Button88);
            this.panel11.Controls.Add(this.plC_Button89);
            this.panel11.Controls.Add(this.plC_Button90);
            this.panel11.Controls.Add(this.plC_Button91);
            this.panel11.Controls.Add(this.plC_Button92);
            this.panel11.Controls.Add(this.plC_Button93);
            this.panel11.Controls.Add(this.plC_Button94);
            this.panel11.Controls.Add(this.plC_Button95);
            this.panel11.Controls.Add(this.plC_Button96);
            this.panel11.Controls.Add(this.plC_Button97);
            this.panel11.Controls.Add(this.plC_Button98);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel11.Location = new System.Drawing.Point(0, 424);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(1638, 73);
            this.panel11.TabIndex = 90;
            // 
            // plC_Button85
            // 
            this.plC_Button85.Bool = false;
            this.plC_Button85.but_press = false;
            this.plC_Button85.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button85.Location = new System.Drawing.Point(1442, 11);
            this.plC_Button85.Name = "plC_Button85";
            this.plC_Button85.OFF_文字內容 = "LED_04-14";
            this.plC_Button85.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button85.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button85.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button85.ON_文字內容 = "LED_04-14";
            this.plC_Button85.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button85.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button85.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button85.Size = new System.Drawing.Size(104, 52);
            this.plC_Button85.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button85.TabIndex = 135;
            this.plC_Button85.事件驅動 = false;
            this.plC_Button85.字型鎖住 = false;
            this.plC_Button85.寫入元件位置 = "M1414";
            this.plC_Button85.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button85.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button85.文字鎖住 = false;
            this.plC_Button85.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button85.狀態OFF圖片")));
            this.plC_Button85.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button85.狀態ON圖片")));
            this.plC_Button85.讀取位元反向 = false;
            this.plC_Button85.讀取元件位置 = "M1414";
            this.plC_Button85.讀寫鎖住 = false;
            this.plC_Button85.起始狀態 = false;
            this.plC_Button85.音效 = true;
            this.plC_Button85.顯示 = false;
            this.plC_Button85.顯示狀態 = false;
            // 
            // plC_Button86
            // 
            this.plC_Button86.Bool = false;
            this.plC_Button86.but_press = false;
            this.plC_Button86.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button86.Location = new System.Drawing.Point(1332, 11);
            this.plC_Button86.Name = "plC_Button86";
            this.plC_Button86.OFF_文字內容 = "LED_04-13";
            this.plC_Button86.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button86.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button86.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button86.ON_文字內容 = "LED_04-13";
            this.plC_Button86.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button86.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button86.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button86.Size = new System.Drawing.Size(104, 52);
            this.plC_Button86.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button86.TabIndex = 133;
            this.plC_Button86.事件驅動 = false;
            this.plC_Button86.字型鎖住 = false;
            this.plC_Button86.寫入元件位置 = "M1413";
            this.plC_Button86.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button86.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button86.文字鎖住 = false;
            this.plC_Button86.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button86.狀態OFF圖片")));
            this.plC_Button86.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button86.狀態ON圖片")));
            this.plC_Button86.讀取位元反向 = false;
            this.plC_Button86.讀取元件位置 = "M1413";
            this.plC_Button86.讀寫鎖住 = false;
            this.plC_Button86.起始狀態 = false;
            this.plC_Button86.音效 = true;
            this.plC_Button86.顯示 = false;
            this.plC_Button86.顯示狀態 = false;
            // 
            // plC_Button87
            // 
            this.plC_Button87.Bool = false;
            this.plC_Button87.but_press = false;
            this.plC_Button87.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button87.Location = new System.Drawing.Point(1222, 11);
            this.plC_Button87.Name = "plC_Button87";
            this.plC_Button87.OFF_文字內容 = "LED_04-12";
            this.plC_Button87.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button87.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button87.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button87.ON_文字內容 = "LED_04-12";
            this.plC_Button87.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button87.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button87.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button87.Size = new System.Drawing.Size(104, 52);
            this.plC_Button87.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button87.TabIndex = 131;
            this.plC_Button87.事件驅動 = false;
            this.plC_Button87.字型鎖住 = false;
            this.plC_Button87.寫入元件位置 = "M1412";
            this.plC_Button87.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button87.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button87.文字鎖住 = false;
            this.plC_Button87.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button87.狀態OFF圖片")));
            this.plC_Button87.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button87.狀態ON圖片")));
            this.plC_Button87.讀取位元反向 = false;
            this.plC_Button87.讀取元件位置 = "M1412";
            this.plC_Button87.讀寫鎖住 = false;
            this.plC_Button87.起始狀態 = false;
            this.plC_Button87.音效 = true;
            this.plC_Button87.顯示 = false;
            this.plC_Button87.顯示狀態 = false;
            // 
            // plC_Button88
            // 
            this.plC_Button88.Bool = false;
            this.plC_Button88.but_press = false;
            this.plC_Button88.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button88.Location = new System.Drawing.Point(1112, 11);
            this.plC_Button88.Name = "plC_Button88";
            this.plC_Button88.OFF_文字內容 = "LED_04-11";
            this.plC_Button88.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button88.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button88.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button88.ON_文字內容 = "LED_04-11";
            this.plC_Button88.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button88.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button88.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button88.Size = new System.Drawing.Size(104, 52);
            this.plC_Button88.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button88.TabIndex = 129;
            this.plC_Button88.事件驅動 = false;
            this.plC_Button88.字型鎖住 = false;
            this.plC_Button88.寫入元件位置 = "M1411";
            this.plC_Button88.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button88.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button88.文字鎖住 = false;
            this.plC_Button88.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button88.狀態OFF圖片")));
            this.plC_Button88.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button88.狀態ON圖片")));
            this.plC_Button88.讀取位元反向 = false;
            this.plC_Button88.讀取元件位置 = "M1411";
            this.plC_Button88.讀寫鎖住 = false;
            this.plC_Button88.起始狀態 = false;
            this.plC_Button88.音效 = true;
            this.plC_Button88.顯示 = false;
            this.plC_Button88.顯示狀態 = false;
            // 
            // plC_Button89
            // 
            this.plC_Button89.Bool = false;
            this.plC_Button89.but_press = false;
            this.plC_Button89.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button89.Location = new System.Drawing.Point(1002, 11);
            this.plC_Button89.Name = "plC_Button89";
            this.plC_Button89.OFF_文字內容 = "LED_04-10";
            this.plC_Button89.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button89.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button89.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button89.ON_文字內容 = "LED_04-10";
            this.plC_Button89.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button89.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button89.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button89.Size = new System.Drawing.Size(104, 52);
            this.plC_Button89.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button89.TabIndex = 127;
            this.plC_Button89.事件驅動 = false;
            this.plC_Button89.字型鎖住 = false;
            this.plC_Button89.寫入元件位置 = "M1410";
            this.plC_Button89.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button89.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button89.文字鎖住 = false;
            this.plC_Button89.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button89.狀態OFF圖片")));
            this.plC_Button89.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button89.狀態ON圖片")));
            this.plC_Button89.讀取位元反向 = false;
            this.plC_Button89.讀取元件位置 = "M1410";
            this.plC_Button89.讀寫鎖住 = false;
            this.plC_Button89.起始狀態 = false;
            this.plC_Button89.音效 = true;
            this.plC_Button89.顯示 = false;
            this.plC_Button89.顯示狀態 = false;
            // 
            // plC_Button90
            // 
            this.plC_Button90.Bool = false;
            this.plC_Button90.but_press = false;
            this.plC_Button90.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button90.Location = new System.Drawing.Point(892, 11);
            this.plC_Button90.Name = "plC_Button90";
            this.plC_Button90.OFF_文字內容 = "LED_04-09";
            this.plC_Button90.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button90.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button90.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button90.ON_文字內容 = "LED_04-09";
            this.plC_Button90.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button90.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button90.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button90.Size = new System.Drawing.Size(104, 52);
            this.plC_Button90.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button90.TabIndex = 125;
            this.plC_Button90.事件驅動 = false;
            this.plC_Button90.字型鎖住 = false;
            this.plC_Button90.寫入元件位置 = "M1409";
            this.plC_Button90.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button90.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button90.文字鎖住 = false;
            this.plC_Button90.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button90.狀態OFF圖片")));
            this.plC_Button90.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button90.狀態ON圖片")));
            this.plC_Button90.讀取位元反向 = false;
            this.plC_Button90.讀取元件位置 = "M1409";
            this.plC_Button90.讀寫鎖住 = false;
            this.plC_Button90.起始狀態 = false;
            this.plC_Button90.音效 = true;
            this.plC_Button90.顯示 = false;
            this.plC_Button90.顯示狀態 = false;
            // 
            // plC_Button91
            // 
            this.plC_Button91.Bool = false;
            this.plC_Button91.but_press = false;
            this.plC_Button91.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button91.Location = new System.Drawing.Point(782, 11);
            this.plC_Button91.Name = "plC_Button91";
            this.plC_Button91.OFF_文字內容 = "LED_04-08";
            this.plC_Button91.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button91.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button91.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button91.ON_文字內容 = "LED_04-08";
            this.plC_Button91.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button91.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button91.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button91.Size = new System.Drawing.Size(104, 52);
            this.plC_Button91.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button91.TabIndex = 123;
            this.plC_Button91.事件驅動 = false;
            this.plC_Button91.字型鎖住 = false;
            this.plC_Button91.寫入元件位置 = "M1408";
            this.plC_Button91.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button91.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button91.文字鎖住 = false;
            this.plC_Button91.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button91.狀態OFF圖片")));
            this.plC_Button91.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button91.狀態ON圖片")));
            this.plC_Button91.讀取位元反向 = false;
            this.plC_Button91.讀取元件位置 = "M1408";
            this.plC_Button91.讀寫鎖住 = false;
            this.plC_Button91.起始狀態 = false;
            this.plC_Button91.音效 = true;
            this.plC_Button91.顯示 = false;
            this.plC_Button91.顯示狀態 = false;
            // 
            // plC_Button92
            // 
            this.plC_Button92.Bool = false;
            this.plC_Button92.but_press = false;
            this.plC_Button92.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button92.Location = new System.Drawing.Point(672, 11);
            this.plC_Button92.Name = "plC_Button92";
            this.plC_Button92.OFF_文字內容 = "LED_04-07";
            this.plC_Button92.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button92.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button92.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button92.ON_文字內容 = "LED_04-07";
            this.plC_Button92.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button92.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button92.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button92.Size = new System.Drawing.Size(104, 52);
            this.plC_Button92.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button92.TabIndex = 121;
            this.plC_Button92.事件驅動 = false;
            this.plC_Button92.字型鎖住 = false;
            this.plC_Button92.寫入元件位置 = "M1407";
            this.plC_Button92.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button92.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button92.文字鎖住 = false;
            this.plC_Button92.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button92.狀態OFF圖片")));
            this.plC_Button92.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button92.狀態ON圖片")));
            this.plC_Button92.讀取位元反向 = false;
            this.plC_Button92.讀取元件位置 = "M1407";
            this.plC_Button92.讀寫鎖住 = false;
            this.plC_Button92.起始狀態 = false;
            this.plC_Button92.音效 = true;
            this.plC_Button92.顯示 = false;
            this.plC_Button92.顯示狀態 = false;
            // 
            // plC_Button93
            // 
            this.plC_Button93.Bool = false;
            this.plC_Button93.but_press = false;
            this.plC_Button93.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button93.Location = new System.Drawing.Point(562, 11);
            this.plC_Button93.Name = "plC_Button93";
            this.plC_Button93.OFF_文字內容 = "LED_04-06";
            this.plC_Button93.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button93.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button93.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button93.ON_文字內容 = "LED_04-06";
            this.plC_Button93.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button93.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button93.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button93.Size = new System.Drawing.Size(104, 52);
            this.plC_Button93.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button93.TabIndex = 119;
            this.plC_Button93.事件驅動 = false;
            this.plC_Button93.字型鎖住 = false;
            this.plC_Button93.寫入元件位置 = "M1406";
            this.plC_Button93.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button93.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button93.文字鎖住 = false;
            this.plC_Button93.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button93.狀態OFF圖片")));
            this.plC_Button93.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button93.狀態ON圖片")));
            this.plC_Button93.讀取位元反向 = false;
            this.plC_Button93.讀取元件位置 = "M1406";
            this.plC_Button93.讀寫鎖住 = false;
            this.plC_Button93.起始狀態 = false;
            this.plC_Button93.音效 = true;
            this.plC_Button93.顯示 = false;
            this.plC_Button93.顯示狀態 = false;
            // 
            // plC_Button94
            // 
            this.plC_Button94.Bool = false;
            this.plC_Button94.but_press = false;
            this.plC_Button94.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button94.Location = new System.Drawing.Point(452, 11);
            this.plC_Button94.Name = "plC_Button94";
            this.plC_Button94.OFF_文字內容 = "LED_04-05";
            this.plC_Button94.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button94.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button94.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button94.ON_文字內容 = "LED_04-05";
            this.plC_Button94.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button94.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button94.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button94.Size = new System.Drawing.Size(104, 52);
            this.plC_Button94.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button94.TabIndex = 117;
            this.plC_Button94.事件驅動 = false;
            this.plC_Button94.字型鎖住 = false;
            this.plC_Button94.寫入元件位置 = "M1405";
            this.plC_Button94.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button94.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button94.文字鎖住 = false;
            this.plC_Button94.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button94.狀態OFF圖片")));
            this.plC_Button94.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button94.狀態ON圖片")));
            this.plC_Button94.讀取位元反向 = false;
            this.plC_Button94.讀取元件位置 = "M1405";
            this.plC_Button94.讀寫鎖住 = false;
            this.plC_Button94.起始狀態 = false;
            this.plC_Button94.音效 = true;
            this.plC_Button94.顯示 = false;
            this.plC_Button94.顯示狀態 = false;
            // 
            // plC_Button95
            // 
            this.plC_Button95.Bool = false;
            this.plC_Button95.but_press = false;
            this.plC_Button95.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button95.Location = new System.Drawing.Point(342, 11);
            this.plC_Button95.Name = "plC_Button95";
            this.plC_Button95.OFF_文字內容 = "LED_04-04";
            this.plC_Button95.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button95.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button95.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button95.ON_文字內容 = "LED_04-04";
            this.plC_Button95.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button95.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button95.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button95.Size = new System.Drawing.Size(104, 52);
            this.plC_Button95.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button95.TabIndex = 115;
            this.plC_Button95.事件驅動 = false;
            this.plC_Button95.字型鎖住 = false;
            this.plC_Button95.寫入元件位置 = "M1404";
            this.plC_Button95.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button95.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button95.文字鎖住 = false;
            this.plC_Button95.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button95.狀態OFF圖片")));
            this.plC_Button95.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button95.狀態ON圖片")));
            this.plC_Button95.讀取位元反向 = false;
            this.plC_Button95.讀取元件位置 = "M1404";
            this.plC_Button95.讀寫鎖住 = false;
            this.plC_Button95.起始狀態 = false;
            this.plC_Button95.音效 = true;
            this.plC_Button95.顯示 = false;
            this.plC_Button95.顯示狀態 = false;
            // 
            // plC_Button96
            // 
            this.plC_Button96.Bool = false;
            this.plC_Button96.but_press = false;
            this.plC_Button96.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button96.Location = new System.Drawing.Point(232, 11);
            this.plC_Button96.Name = "plC_Button96";
            this.plC_Button96.OFF_文字內容 = "LED_04-03";
            this.plC_Button96.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button96.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button96.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button96.ON_文字內容 = "LED_04-03";
            this.plC_Button96.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button96.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button96.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button96.Size = new System.Drawing.Size(104, 52);
            this.plC_Button96.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button96.TabIndex = 113;
            this.plC_Button96.事件驅動 = false;
            this.plC_Button96.字型鎖住 = false;
            this.plC_Button96.寫入元件位置 = "M1403";
            this.plC_Button96.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button96.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button96.文字鎖住 = false;
            this.plC_Button96.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button96.狀態OFF圖片")));
            this.plC_Button96.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button96.狀態ON圖片")));
            this.plC_Button96.讀取位元反向 = false;
            this.plC_Button96.讀取元件位置 = "M1403";
            this.plC_Button96.讀寫鎖住 = false;
            this.plC_Button96.起始狀態 = false;
            this.plC_Button96.音效 = true;
            this.plC_Button96.顯示 = false;
            this.plC_Button96.顯示狀態 = false;
            // 
            // plC_Button97
            // 
            this.plC_Button97.Bool = false;
            this.plC_Button97.but_press = false;
            this.plC_Button97.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button97.Location = new System.Drawing.Point(122, 11);
            this.plC_Button97.Name = "plC_Button97";
            this.plC_Button97.OFF_文字內容 = "LED_04-02";
            this.plC_Button97.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button97.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button97.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button97.ON_文字內容 = "LED_04-02";
            this.plC_Button97.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button97.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button97.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button97.Size = new System.Drawing.Size(104, 52);
            this.plC_Button97.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button97.TabIndex = 111;
            this.plC_Button97.事件驅動 = false;
            this.plC_Button97.字型鎖住 = false;
            this.plC_Button97.寫入元件位置 = "M1402";
            this.plC_Button97.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button97.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button97.文字鎖住 = false;
            this.plC_Button97.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button97.狀態OFF圖片")));
            this.plC_Button97.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button97.狀態ON圖片")));
            this.plC_Button97.讀取位元反向 = false;
            this.plC_Button97.讀取元件位置 = "M1402";
            this.plC_Button97.讀寫鎖住 = false;
            this.plC_Button97.起始狀態 = false;
            this.plC_Button97.音效 = true;
            this.plC_Button97.顯示 = false;
            this.plC_Button97.顯示狀態 = false;
            // 
            // plC_Button98
            // 
            this.plC_Button98.Bool = false;
            this.plC_Button98.but_press = false;
            this.plC_Button98.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button98.Location = new System.Drawing.Point(12, 11);
            this.plC_Button98.Name = "plC_Button98";
            this.plC_Button98.OFF_文字內容 = "LED_04-01";
            this.plC_Button98.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button98.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button98.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button98.ON_文字內容 = "LED_04-01";
            this.plC_Button98.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button98.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button98.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button98.Size = new System.Drawing.Size(104, 52);
            this.plC_Button98.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button98.TabIndex = 109;
            this.plC_Button98.事件驅動 = false;
            this.plC_Button98.字型鎖住 = false;
            this.plC_Button98.寫入元件位置 = "M1401";
            this.plC_Button98.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button98.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button98.文字鎖住 = false;
            this.plC_Button98.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button98.狀態OFF圖片")));
            this.plC_Button98.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button98.狀態ON圖片")));
            this.plC_Button98.讀取位元反向 = false;
            this.plC_Button98.讀取元件位置 = "M1401";
            this.plC_Button98.讀寫鎖住 = false;
            this.plC_Button98.起始狀態 = false;
            this.plC_Button98.音效 = true;
            this.plC_Button98.顯示 = false;
            this.plC_Button98.顯示狀態 = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel10.Location = new System.Drawing.Point(0, 497);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1638, 17);
            this.panel10.TabIndex = 89;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.plC_Button71);
            this.panel9.Controls.Add(this.plC_Button72);
            this.panel9.Controls.Add(this.plC_Button73);
            this.panel9.Controls.Add(this.plC_Button74);
            this.panel9.Controls.Add(this.plC_Button75);
            this.panel9.Controls.Add(this.plC_Button76);
            this.panel9.Controls.Add(this.plC_Button77);
            this.panel9.Controls.Add(this.plC_Button78);
            this.panel9.Controls.Add(this.plC_Button79);
            this.panel9.Controls.Add(this.plC_Button80);
            this.panel9.Controls.Add(this.plC_Button81);
            this.panel9.Controls.Add(this.plC_Button82);
            this.panel9.Controls.Add(this.plC_Button83);
            this.panel9.Controls.Add(this.plC_Button84);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 514);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1638, 73);
            this.panel9.TabIndex = 88;
            // 
            // plC_Button71
            // 
            this.plC_Button71.Bool = false;
            this.plC_Button71.but_press = false;
            this.plC_Button71.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button71.Location = new System.Drawing.Point(1442, 12);
            this.plC_Button71.Name = "plC_Button71";
            this.plC_Button71.OFF_文字內容 = "Motor_03-14";
            this.plC_Button71.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button71.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button71.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button71.ON_文字內容 = "Motor_03-14";
            this.plC_Button71.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button71.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button71.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button71.Size = new System.Drawing.Size(104, 52);
            this.plC_Button71.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button71.TabIndex = 150;
            this.plC_Button71.事件驅動 = false;
            this.plC_Button71.字型鎖住 = false;
            this.plC_Button71.寫入元件位置 = "M314";
            this.plC_Button71.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button71.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button71.文字鎖住 = false;
            this.plC_Button71.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button71.狀態OFF圖片")));
            this.plC_Button71.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button71.狀態ON圖片")));
            this.plC_Button71.讀取位元反向 = false;
            this.plC_Button71.讀取元件位置 = "M314";
            this.plC_Button71.讀寫鎖住 = false;
            this.plC_Button71.起始狀態 = false;
            this.plC_Button71.音效 = true;
            this.plC_Button71.顯示 = false;
            this.plC_Button71.顯示狀態 = false;
            // 
            // plC_Button72
            // 
            this.plC_Button72.Bool = false;
            this.plC_Button72.but_press = false;
            this.plC_Button72.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button72.Location = new System.Drawing.Point(1332, 12);
            this.plC_Button72.Name = "plC_Button72";
            this.plC_Button72.OFF_文字內容 = "Motor_03-13";
            this.plC_Button72.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button72.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button72.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button72.ON_文字內容 = "Motor_03-13";
            this.plC_Button72.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button72.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button72.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button72.Size = new System.Drawing.Size(104, 52);
            this.plC_Button72.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button72.TabIndex = 149;
            this.plC_Button72.事件驅動 = false;
            this.plC_Button72.字型鎖住 = false;
            this.plC_Button72.寫入元件位置 = "M313";
            this.plC_Button72.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button72.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button72.文字鎖住 = false;
            this.plC_Button72.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button72.狀態OFF圖片")));
            this.plC_Button72.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button72.狀態ON圖片")));
            this.plC_Button72.讀取位元反向 = false;
            this.plC_Button72.讀取元件位置 = "M313";
            this.plC_Button72.讀寫鎖住 = false;
            this.plC_Button72.起始狀態 = false;
            this.plC_Button72.音效 = true;
            this.plC_Button72.顯示 = false;
            this.plC_Button72.顯示狀態 = false;
            // 
            // plC_Button73
            // 
            this.plC_Button73.Bool = false;
            this.plC_Button73.but_press = false;
            this.plC_Button73.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button73.Location = new System.Drawing.Point(1222, 12);
            this.plC_Button73.Name = "plC_Button73";
            this.plC_Button73.OFF_文字內容 = "Motor_03-12";
            this.plC_Button73.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button73.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button73.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button73.ON_文字內容 = "Motor_03-12";
            this.plC_Button73.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button73.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button73.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button73.Size = new System.Drawing.Size(104, 52);
            this.plC_Button73.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button73.TabIndex = 148;
            this.plC_Button73.事件驅動 = false;
            this.plC_Button73.字型鎖住 = false;
            this.plC_Button73.寫入元件位置 = "M312";
            this.plC_Button73.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button73.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button73.文字鎖住 = false;
            this.plC_Button73.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button73.狀態OFF圖片")));
            this.plC_Button73.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button73.狀態ON圖片")));
            this.plC_Button73.讀取位元反向 = false;
            this.plC_Button73.讀取元件位置 = "M312";
            this.plC_Button73.讀寫鎖住 = false;
            this.plC_Button73.起始狀態 = false;
            this.plC_Button73.音效 = true;
            this.plC_Button73.顯示 = false;
            this.plC_Button73.顯示狀態 = false;
            // 
            // plC_Button74
            // 
            this.plC_Button74.Bool = false;
            this.plC_Button74.but_press = false;
            this.plC_Button74.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button74.Location = new System.Drawing.Point(1112, 12);
            this.plC_Button74.Name = "plC_Button74";
            this.plC_Button74.OFF_文字內容 = "Motor_03-11";
            this.plC_Button74.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button74.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button74.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button74.ON_文字內容 = "Motor_03-11";
            this.plC_Button74.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button74.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button74.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button74.Size = new System.Drawing.Size(104, 52);
            this.plC_Button74.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button74.TabIndex = 147;
            this.plC_Button74.事件驅動 = false;
            this.plC_Button74.字型鎖住 = false;
            this.plC_Button74.寫入元件位置 = "M311";
            this.plC_Button74.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button74.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button74.文字鎖住 = false;
            this.plC_Button74.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button74.狀態OFF圖片")));
            this.plC_Button74.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button74.狀態ON圖片")));
            this.plC_Button74.讀取位元反向 = false;
            this.plC_Button74.讀取元件位置 = "M311";
            this.plC_Button74.讀寫鎖住 = false;
            this.plC_Button74.起始狀態 = false;
            this.plC_Button74.音效 = true;
            this.plC_Button74.顯示 = false;
            this.plC_Button74.顯示狀態 = false;
            // 
            // plC_Button75
            // 
            this.plC_Button75.Bool = false;
            this.plC_Button75.but_press = false;
            this.plC_Button75.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button75.Location = new System.Drawing.Point(1002, 12);
            this.plC_Button75.Name = "plC_Button75";
            this.plC_Button75.OFF_文字內容 = "Motor_03-10";
            this.plC_Button75.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button75.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button75.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button75.ON_文字內容 = "Motor_03-10";
            this.plC_Button75.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button75.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button75.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button75.Size = new System.Drawing.Size(104, 52);
            this.plC_Button75.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button75.TabIndex = 146;
            this.plC_Button75.事件驅動 = false;
            this.plC_Button75.字型鎖住 = false;
            this.plC_Button75.寫入元件位置 = "M310";
            this.plC_Button75.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button75.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button75.文字鎖住 = false;
            this.plC_Button75.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button75.狀態OFF圖片")));
            this.plC_Button75.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button75.狀態ON圖片")));
            this.plC_Button75.讀取位元反向 = false;
            this.plC_Button75.讀取元件位置 = "M310";
            this.plC_Button75.讀寫鎖住 = false;
            this.plC_Button75.起始狀態 = false;
            this.plC_Button75.音效 = true;
            this.plC_Button75.顯示 = false;
            this.plC_Button75.顯示狀態 = false;
            // 
            // plC_Button76
            // 
            this.plC_Button76.Bool = false;
            this.plC_Button76.but_press = false;
            this.plC_Button76.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button76.Location = new System.Drawing.Point(892, 12);
            this.plC_Button76.Name = "plC_Button76";
            this.plC_Button76.OFF_文字內容 = "Motor_03-09";
            this.plC_Button76.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button76.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button76.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button76.ON_文字內容 = "Motor_03-09";
            this.plC_Button76.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button76.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button76.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button76.Size = new System.Drawing.Size(104, 52);
            this.plC_Button76.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button76.TabIndex = 145;
            this.plC_Button76.事件驅動 = false;
            this.plC_Button76.字型鎖住 = false;
            this.plC_Button76.寫入元件位置 = "M309";
            this.plC_Button76.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button76.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button76.文字鎖住 = false;
            this.plC_Button76.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button76.狀態OFF圖片")));
            this.plC_Button76.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button76.狀態ON圖片")));
            this.plC_Button76.讀取位元反向 = false;
            this.plC_Button76.讀取元件位置 = "M309";
            this.plC_Button76.讀寫鎖住 = false;
            this.plC_Button76.起始狀態 = false;
            this.plC_Button76.音效 = true;
            this.plC_Button76.顯示 = false;
            this.plC_Button76.顯示狀態 = false;
            // 
            // plC_Button77
            // 
            this.plC_Button77.Bool = false;
            this.plC_Button77.but_press = false;
            this.plC_Button77.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button77.Location = new System.Drawing.Point(782, 12);
            this.plC_Button77.Name = "plC_Button77";
            this.plC_Button77.OFF_文字內容 = "Motor_03-08";
            this.plC_Button77.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button77.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button77.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button77.ON_文字內容 = "Motor_03-08";
            this.plC_Button77.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button77.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button77.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button77.Size = new System.Drawing.Size(104, 52);
            this.plC_Button77.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button77.TabIndex = 144;
            this.plC_Button77.事件驅動 = false;
            this.plC_Button77.字型鎖住 = false;
            this.plC_Button77.寫入元件位置 = "M308";
            this.plC_Button77.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button77.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button77.文字鎖住 = false;
            this.plC_Button77.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button77.狀態OFF圖片")));
            this.plC_Button77.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button77.狀態ON圖片")));
            this.plC_Button77.讀取位元反向 = false;
            this.plC_Button77.讀取元件位置 = "M308";
            this.plC_Button77.讀寫鎖住 = false;
            this.plC_Button77.起始狀態 = false;
            this.plC_Button77.音效 = true;
            this.plC_Button77.顯示 = false;
            this.plC_Button77.顯示狀態 = false;
            // 
            // plC_Button78
            // 
            this.plC_Button78.Bool = false;
            this.plC_Button78.but_press = false;
            this.plC_Button78.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button78.Location = new System.Drawing.Point(672, 12);
            this.plC_Button78.Name = "plC_Button78";
            this.plC_Button78.OFF_文字內容 = "Motor_03-07";
            this.plC_Button78.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button78.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button78.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button78.ON_文字內容 = "Motor_03-07";
            this.plC_Button78.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button78.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button78.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button78.Size = new System.Drawing.Size(104, 52);
            this.plC_Button78.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button78.TabIndex = 143;
            this.plC_Button78.事件驅動 = false;
            this.plC_Button78.字型鎖住 = false;
            this.plC_Button78.寫入元件位置 = "M307";
            this.plC_Button78.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button78.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button78.文字鎖住 = false;
            this.plC_Button78.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button78.狀態OFF圖片")));
            this.plC_Button78.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button78.狀態ON圖片")));
            this.plC_Button78.讀取位元反向 = false;
            this.plC_Button78.讀取元件位置 = "M307";
            this.plC_Button78.讀寫鎖住 = false;
            this.plC_Button78.起始狀態 = false;
            this.plC_Button78.音效 = true;
            this.plC_Button78.顯示 = false;
            this.plC_Button78.顯示狀態 = false;
            // 
            // plC_Button79
            // 
            this.plC_Button79.Bool = false;
            this.plC_Button79.but_press = false;
            this.plC_Button79.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button79.Location = new System.Drawing.Point(562, 12);
            this.plC_Button79.Name = "plC_Button79";
            this.plC_Button79.OFF_文字內容 = "Motor_03-06";
            this.plC_Button79.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button79.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button79.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button79.ON_文字內容 = "Motor_03-06";
            this.plC_Button79.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button79.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button79.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button79.Size = new System.Drawing.Size(104, 52);
            this.plC_Button79.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button79.TabIndex = 142;
            this.plC_Button79.事件驅動 = false;
            this.plC_Button79.字型鎖住 = false;
            this.plC_Button79.寫入元件位置 = "M306";
            this.plC_Button79.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button79.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button79.文字鎖住 = false;
            this.plC_Button79.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button79.狀態OFF圖片")));
            this.plC_Button79.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button79.狀態ON圖片")));
            this.plC_Button79.讀取位元反向 = false;
            this.plC_Button79.讀取元件位置 = "M306";
            this.plC_Button79.讀寫鎖住 = false;
            this.plC_Button79.起始狀態 = false;
            this.plC_Button79.音效 = true;
            this.plC_Button79.顯示 = false;
            this.plC_Button79.顯示狀態 = false;
            // 
            // plC_Button80
            // 
            this.plC_Button80.Bool = false;
            this.plC_Button80.but_press = false;
            this.plC_Button80.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button80.Location = new System.Drawing.Point(452, 12);
            this.plC_Button80.Name = "plC_Button80";
            this.plC_Button80.OFF_文字內容 = "Motor_03-05";
            this.plC_Button80.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button80.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button80.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button80.ON_文字內容 = "Motor_03-05";
            this.plC_Button80.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button80.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button80.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button80.Size = new System.Drawing.Size(104, 52);
            this.plC_Button80.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button80.TabIndex = 141;
            this.plC_Button80.事件驅動 = false;
            this.plC_Button80.字型鎖住 = false;
            this.plC_Button80.寫入元件位置 = "M305";
            this.plC_Button80.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button80.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button80.文字鎖住 = false;
            this.plC_Button80.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button80.狀態OFF圖片")));
            this.plC_Button80.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button80.狀態ON圖片")));
            this.plC_Button80.讀取位元反向 = false;
            this.plC_Button80.讀取元件位置 = "M305";
            this.plC_Button80.讀寫鎖住 = false;
            this.plC_Button80.起始狀態 = false;
            this.plC_Button80.音效 = true;
            this.plC_Button80.顯示 = false;
            this.plC_Button80.顯示狀態 = false;
            // 
            // plC_Button81
            // 
            this.plC_Button81.Bool = false;
            this.plC_Button81.but_press = false;
            this.plC_Button81.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button81.Location = new System.Drawing.Point(342, 12);
            this.plC_Button81.Name = "plC_Button81";
            this.plC_Button81.OFF_文字內容 = "Motor_03-04";
            this.plC_Button81.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button81.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button81.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button81.ON_文字內容 = "Motor_03-04";
            this.plC_Button81.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button81.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button81.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button81.Size = new System.Drawing.Size(104, 52);
            this.plC_Button81.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button81.TabIndex = 140;
            this.plC_Button81.事件驅動 = false;
            this.plC_Button81.字型鎖住 = false;
            this.plC_Button81.寫入元件位置 = "M304";
            this.plC_Button81.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button81.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button81.文字鎖住 = false;
            this.plC_Button81.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button81.狀態OFF圖片")));
            this.plC_Button81.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button81.狀態ON圖片")));
            this.plC_Button81.讀取位元反向 = false;
            this.plC_Button81.讀取元件位置 = "M304";
            this.plC_Button81.讀寫鎖住 = false;
            this.plC_Button81.起始狀態 = false;
            this.plC_Button81.音效 = true;
            this.plC_Button81.顯示 = false;
            this.plC_Button81.顯示狀態 = false;
            // 
            // plC_Button82
            // 
            this.plC_Button82.Bool = false;
            this.plC_Button82.but_press = false;
            this.plC_Button82.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button82.Location = new System.Drawing.Point(232, 12);
            this.plC_Button82.Name = "plC_Button82";
            this.plC_Button82.OFF_文字內容 = "Motor_03-03";
            this.plC_Button82.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button82.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button82.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button82.ON_文字內容 = "Motor_03-03";
            this.plC_Button82.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button82.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button82.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button82.Size = new System.Drawing.Size(104, 52);
            this.plC_Button82.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button82.TabIndex = 139;
            this.plC_Button82.事件驅動 = false;
            this.plC_Button82.字型鎖住 = false;
            this.plC_Button82.寫入元件位置 = "M303";
            this.plC_Button82.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button82.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button82.文字鎖住 = false;
            this.plC_Button82.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button82.狀態OFF圖片")));
            this.plC_Button82.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button82.狀態ON圖片")));
            this.plC_Button82.讀取位元反向 = false;
            this.plC_Button82.讀取元件位置 = "M303";
            this.plC_Button82.讀寫鎖住 = false;
            this.plC_Button82.起始狀態 = false;
            this.plC_Button82.音效 = true;
            this.plC_Button82.顯示 = false;
            this.plC_Button82.顯示狀態 = false;
            // 
            // plC_Button83
            // 
            this.plC_Button83.Bool = false;
            this.plC_Button83.but_press = false;
            this.plC_Button83.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button83.Location = new System.Drawing.Point(122, 12);
            this.plC_Button83.Name = "plC_Button83";
            this.plC_Button83.OFF_文字內容 = "Motor_03-02";
            this.plC_Button83.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button83.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button83.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button83.ON_文字內容 = "Motor_03-02";
            this.plC_Button83.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button83.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button83.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button83.Size = new System.Drawing.Size(104, 52);
            this.plC_Button83.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button83.TabIndex = 138;
            this.plC_Button83.事件驅動 = false;
            this.plC_Button83.字型鎖住 = false;
            this.plC_Button83.寫入元件位置 = "M302";
            this.plC_Button83.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button83.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button83.文字鎖住 = false;
            this.plC_Button83.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button83.狀態OFF圖片")));
            this.plC_Button83.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button83.狀態ON圖片")));
            this.plC_Button83.讀取位元反向 = false;
            this.plC_Button83.讀取元件位置 = "M302";
            this.plC_Button83.讀寫鎖住 = false;
            this.plC_Button83.起始狀態 = false;
            this.plC_Button83.音效 = true;
            this.plC_Button83.顯示 = false;
            this.plC_Button83.顯示狀態 = false;
            // 
            // plC_Button84
            // 
            this.plC_Button84.Bool = false;
            this.plC_Button84.but_press = false;
            this.plC_Button84.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button84.Location = new System.Drawing.Point(12, 12);
            this.plC_Button84.Name = "plC_Button84";
            this.plC_Button84.OFF_文字內容 = "Motor_03-01";
            this.plC_Button84.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button84.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button84.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button84.ON_文字內容 = "Motor_03-01";
            this.plC_Button84.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button84.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button84.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button84.Size = new System.Drawing.Size(104, 52);
            this.plC_Button84.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button84.TabIndex = 137;
            this.plC_Button84.事件驅動 = false;
            this.plC_Button84.字型鎖住 = false;
            this.plC_Button84.寫入元件位置 = "M301";
            this.plC_Button84.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button84.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button84.文字鎖住 = false;
            this.plC_Button84.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button84.狀態OFF圖片")));
            this.plC_Button84.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button84.狀態ON圖片")));
            this.plC_Button84.讀取位元反向 = false;
            this.plC_Button84.讀取元件位置 = "M301";
            this.plC_Button84.讀寫鎖住 = false;
            this.plC_Button84.起始狀態 = false;
            this.plC_Button84.音效 = true;
            this.plC_Button84.顯示 = false;
            this.plC_Button84.顯示狀態 = false;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.plC_Button57);
            this.panel8.Controls.Add(this.plC_Button58);
            this.panel8.Controls.Add(this.plC_Button59);
            this.panel8.Controls.Add(this.plC_Button60);
            this.panel8.Controls.Add(this.plC_Button61);
            this.panel8.Controls.Add(this.plC_Button62);
            this.panel8.Controls.Add(this.plC_Button63);
            this.panel8.Controls.Add(this.plC_Button64);
            this.panel8.Controls.Add(this.plC_Button65);
            this.panel8.Controls.Add(this.plC_Button66);
            this.panel8.Controls.Add(this.plC_Button67);
            this.panel8.Controls.Add(this.plC_Button68);
            this.panel8.Controls.Add(this.plC_Button69);
            this.panel8.Controls.Add(this.plC_Button70);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 587);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1638, 73);
            this.panel8.TabIndex = 87;
            // 
            // plC_Button57
            // 
            this.plC_Button57.Bool = false;
            this.plC_Button57.but_press = false;
            this.plC_Button57.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button57.Location = new System.Drawing.Point(1442, 11);
            this.plC_Button57.Name = "plC_Button57";
            this.plC_Button57.OFF_文字內容 = "LED_03-14";
            this.plC_Button57.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button57.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button57.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button57.ON_文字內容 = "LED_03-14";
            this.plC_Button57.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button57.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button57.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button57.Size = new System.Drawing.Size(104, 52);
            this.plC_Button57.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button57.TabIndex = 135;
            this.plC_Button57.事件驅動 = false;
            this.plC_Button57.字型鎖住 = false;
            this.plC_Button57.寫入元件位置 = "M1314";
            this.plC_Button57.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button57.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button57.文字鎖住 = false;
            this.plC_Button57.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button57.狀態OFF圖片")));
            this.plC_Button57.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button57.狀態ON圖片")));
            this.plC_Button57.讀取位元反向 = false;
            this.plC_Button57.讀取元件位置 = "M1314";
            this.plC_Button57.讀寫鎖住 = false;
            this.plC_Button57.起始狀態 = false;
            this.plC_Button57.音效 = true;
            this.plC_Button57.顯示 = false;
            this.plC_Button57.顯示狀態 = false;
            // 
            // plC_Button58
            // 
            this.plC_Button58.Bool = false;
            this.plC_Button58.but_press = false;
            this.plC_Button58.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button58.Location = new System.Drawing.Point(1332, 11);
            this.plC_Button58.Name = "plC_Button58";
            this.plC_Button58.OFF_文字內容 = "LED_03-13";
            this.plC_Button58.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button58.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button58.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button58.ON_文字內容 = "LED_03-13";
            this.plC_Button58.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button58.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button58.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button58.Size = new System.Drawing.Size(104, 52);
            this.plC_Button58.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button58.TabIndex = 133;
            this.plC_Button58.事件驅動 = false;
            this.plC_Button58.字型鎖住 = false;
            this.plC_Button58.寫入元件位置 = "M1313";
            this.plC_Button58.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button58.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button58.文字鎖住 = false;
            this.plC_Button58.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button58.狀態OFF圖片")));
            this.plC_Button58.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button58.狀態ON圖片")));
            this.plC_Button58.讀取位元反向 = false;
            this.plC_Button58.讀取元件位置 = "M1313";
            this.plC_Button58.讀寫鎖住 = false;
            this.plC_Button58.起始狀態 = false;
            this.plC_Button58.音效 = true;
            this.plC_Button58.顯示 = false;
            this.plC_Button58.顯示狀態 = false;
            // 
            // plC_Button59
            // 
            this.plC_Button59.Bool = false;
            this.plC_Button59.but_press = false;
            this.plC_Button59.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button59.Location = new System.Drawing.Point(1222, 11);
            this.plC_Button59.Name = "plC_Button59";
            this.plC_Button59.OFF_文字內容 = "LED_03-12";
            this.plC_Button59.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button59.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button59.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button59.ON_文字內容 = "LED_03-12";
            this.plC_Button59.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button59.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button59.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button59.Size = new System.Drawing.Size(104, 52);
            this.plC_Button59.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button59.TabIndex = 131;
            this.plC_Button59.事件驅動 = false;
            this.plC_Button59.字型鎖住 = false;
            this.plC_Button59.寫入元件位置 = "M1312";
            this.plC_Button59.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button59.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button59.文字鎖住 = false;
            this.plC_Button59.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button59.狀態OFF圖片")));
            this.plC_Button59.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button59.狀態ON圖片")));
            this.plC_Button59.讀取位元反向 = false;
            this.plC_Button59.讀取元件位置 = "M1312";
            this.plC_Button59.讀寫鎖住 = false;
            this.plC_Button59.起始狀態 = false;
            this.plC_Button59.音效 = true;
            this.plC_Button59.顯示 = false;
            this.plC_Button59.顯示狀態 = false;
            // 
            // plC_Button60
            // 
            this.plC_Button60.Bool = false;
            this.plC_Button60.but_press = false;
            this.plC_Button60.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button60.Location = new System.Drawing.Point(1112, 11);
            this.plC_Button60.Name = "plC_Button60";
            this.plC_Button60.OFF_文字內容 = "LED_03-11";
            this.plC_Button60.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button60.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button60.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button60.ON_文字內容 = "LED_03-11";
            this.plC_Button60.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button60.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button60.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button60.Size = new System.Drawing.Size(104, 52);
            this.plC_Button60.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button60.TabIndex = 129;
            this.plC_Button60.事件驅動 = false;
            this.plC_Button60.字型鎖住 = false;
            this.plC_Button60.寫入元件位置 = "M1311";
            this.plC_Button60.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button60.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button60.文字鎖住 = false;
            this.plC_Button60.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button60.狀態OFF圖片")));
            this.plC_Button60.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button60.狀態ON圖片")));
            this.plC_Button60.讀取位元反向 = false;
            this.plC_Button60.讀取元件位置 = "M1311";
            this.plC_Button60.讀寫鎖住 = false;
            this.plC_Button60.起始狀態 = false;
            this.plC_Button60.音效 = true;
            this.plC_Button60.顯示 = false;
            this.plC_Button60.顯示狀態 = false;
            // 
            // plC_Button61
            // 
            this.plC_Button61.Bool = false;
            this.plC_Button61.but_press = false;
            this.plC_Button61.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button61.Location = new System.Drawing.Point(1002, 11);
            this.plC_Button61.Name = "plC_Button61";
            this.plC_Button61.OFF_文字內容 = "LED_03-10";
            this.plC_Button61.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button61.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button61.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button61.ON_文字內容 = "LED_03-10";
            this.plC_Button61.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button61.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button61.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button61.Size = new System.Drawing.Size(104, 52);
            this.plC_Button61.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button61.TabIndex = 127;
            this.plC_Button61.事件驅動 = false;
            this.plC_Button61.字型鎖住 = false;
            this.plC_Button61.寫入元件位置 = "M1310";
            this.plC_Button61.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button61.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button61.文字鎖住 = false;
            this.plC_Button61.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button61.狀態OFF圖片")));
            this.plC_Button61.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button61.狀態ON圖片")));
            this.plC_Button61.讀取位元反向 = false;
            this.plC_Button61.讀取元件位置 = "M1310";
            this.plC_Button61.讀寫鎖住 = false;
            this.plC_Button61.起始狀態 = false;
            this.plC_Button61.音效 = true;
            this.plC_Button61.顯示 = false;
            this.plC_Button61.顯示狀態 = false;
            // 
            // plC_Button62
            // 
            this.plC_Button62.Bool = false;
            this.plC_Button62.but_press = false;
            this.plC_Button62.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button62.Location = new System.Drawing.Point(892, 11);
            this.plC_Button62.Name = "plC_Button62";
            this.plC_Button62.OFF_文字內容 = "LED_03-09";
            this.plC_Button62.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button62.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button62.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button62.ON_文字內容 = "LED_03-09";
            this.plC_Button62.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button62.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button62.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button62.Size = new System.Drawing.Size(104, 52);
            this.plC_Button62.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button62.TabIndex = 125;
            this.plC_Button62.事件驅動 = false;
            this.plC_Button62.字型鎖住 = false;
            this.plC_Button62.寫入元件位置 = "M1309";
            this.plC_Button62.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button62.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button62.文字鎖住 = false;
            this.plC_Button62.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button62.狀態OFF圖片")));
            this.plC_Button62.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button62.狀態ON圖片")));
            this.plC_Button62.讀取位元反向 = false;
            this.plC_Button62.讀取元件位置 = "M1309";
            this.plC_Button62.讀寫鎖住 = false;
            this.plC_Button62.起始狀態 = false;
            this.plC_Button62.音效 = true;
            this.plC_Button62.顯示 = false;
            this.plC_Button62.顯示狀態 = false;
            // 
            // plC_Button63
            // 
            this.plC_Button63.Bool = false;
            this.plC_Button63.but_press = false;
            this.plC_Button63.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button63.Location = new System.Drawing.Point(782, 11);
            this.plC_Button63.Name = "plC_Button63";
            this.plC_Button63.OFF_文字內容 = "LED_03-08";
            this.plC_Button63.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button63.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button63.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button63.ON_文字內容 = "LED_03-08";
            this.plC_Button63.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button63.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button63.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button63.Size = new System.Drawing.Size(104, 52);
            this.plC_Button63.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button63.TabIndex = 123;
            this.plC_Button63.事件驅動 = false;
            this.plC_Button63.字型鎖住 = false;
            this.plC_Button63.寫入元件位置 = "M1308";
            this.plC_Button63.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button63.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button63.文字鎖住 = false;
            this.plC_Button63.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button63.狀態OFF圖片")));
            this.plC_Button63.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button63.狀態ON圖片")));
            this.plC_Button63.讀取位元反向 = false;
            this.plC_Button63.讀取元件位置 = "M1308";
            this.plC_Button63.讀寫鎖住 = false;
            this.plC_Button63.起始狀態 = false;
            this.plC_Button63.音效 = true;
            this.plC_Button63.顯示 = false;
            this.plC_Button63.顯示狀態 = false;
            // 
            // plC_Button64
            // 
            this.plC_Button64.Bool = false;
            this.plC_Button64.but_press = false;
            this.plC_Button64.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button64.Location = new System.Drawing.Point(672, 11);
            this.plC_Button64.Name = "plC_Button64";
            this.plC_Button64.OFF_文字內容 = "LED_03-07";
            this.plC_Button64.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button64.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button64.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button64.ON_文字內容 = "LED_03-07";
            this.plC_Button64.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button64.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button64.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button64.Size = new System.Drawing.Size(104, 52);
            this.plC_Button64.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button64.TabIndex = 121;
            this.plC_Button64.事件驅動 = false;
            this.plC_Button64.字型鎖住 = false;
            this.plC_Button64.寫入元件位置 = "M1307";
            this.plC_Button64.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button64.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button64.文字鎖住 = false;
            this.plC_Button64.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button64.狀態OFF圖片")));
            this.plC_Button64.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button64.狀態ON圖片")));
            this.plC_Button64.讀取位元反向 = false;
            this.plC_Button64.讀取元件位置 = "M1307";
            this.plC_Button64.讀寫鎖住 = false;
            this.plC_Button64.起始狀態 = false;
            this.plC_Button64.音效 = true;
            this.plC_Button64.顯示 = false;
            this.plC_Button64.顯示狀態 = false;
            // 
            // plC_Button65
            // 
            this.plC_Button65.Bool = false;
            this.plC_Button65.but_press = false;
            this.plC_Button65.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button65.Location = new System.Drawing.Point(562, 11);
            this.plC_Button65.Name = "plC_Button65";
            this.plC_Button65.OFF_文字內容 = "LED_03-06";
            this.plC_Button65.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button65.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button65.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button65.ON_文字內容 = "LED_03-06";
            this.plC_Button65.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button65.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button65.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button65.Size = new System.Drawing.Size(104, 52);
            this.plC_Button65.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button65.TabIndex = 119;
            this.plC_Button65.事件驅動 = false;
            this.plC_Button65.字型鎖住 = false;
            this.plC_Button65.寫入元件位置 = "M1306";
            this.plC_Button65.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button65.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button65.文字鎖住 = false;
            this.plC_Button65.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button65.狀態OFF圖片")));
            this.plC_Button65.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button65.狀態ON圖片")));
            this.plC_Button65.讀取位元反向 = false;
            this.plC_Button65.讀取元件位置 = "M1306";
            this.plC_Button65.讀寫鎖住 = false;
            this.plC_Button65.起始狀態 = false;
            this.plC_Button65.音效 = true;
            this.plC_Button65.顯示 = false;
            this.plC_Button65.顯示狀態 = false;
            // 
            // plC_Button66
            // 
            this.plC_Button66.Bool = false;
            this.plC_Button66.but_press = false;
            this.plC_Button66.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button66.Location = new System.Drawing.Point(452, 11);
            this.plC_Button66.Name = "plC_Button66";
            this.plC_Button66.OFF_文字內容 = "LED_03-05";
            this.plC_Button66.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button66.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button66.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button66.ON_文字內容 = "LED_03-05";
            this.plC_Button66.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button66.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button66.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button66.Size = new System.Drawing.Size(104, 52);
            this.plC_Button66.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button66.TabIndex = 117;
            this.plC_Button66.事件驅動 = false;
            this.plC_Button66.字型鎖住 = false;
            this.plC_Button66.寫入元件位置 = "M1305";
            this.plC_Button66.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button66.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button66.文字鎖住 = false;
            this.plC_Button66.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button66.狀態OFF圖片")));
            this.plC_Button66.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button66.狀態ON圖片")));
            this.plC_Button66.讀取位元反向 = false;
            this.plC_Button66.讀取元件位置 = "M1305";
            this.plC_Button66.讀寫鎖住 = false;
            this.plC_Button66.起始狀態 = false;
            this.plC_Button66.音效 = true;
            this.plC_Button66.顯示 = false;
            this.plC_Button66.顯示狀態 = false;
            // 
            // plC_Button67
            // 
            this.plC_Button67.Bool = false;
            this.plC_Button67.but_press = false;
            this.plC_Button67.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button67.Location = new System.Drawing.Point(342, 11);
            this.plC_Button67.Name = "plC_Button67";
            this.plC_Button67.OFF_文字內容 = "LED_03-04";
            this.plC_Button67.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button67.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button67.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button67.ON_文字內容 = "LED_03-04";
            this.plC_Button67.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button67.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button67.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button67.Size = new System.Drawing.Size(104, 52);
            this.plC_Button67.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button67.TabIndex = 115;
            this.plC_Button67.事件驅動 = false;
            this.plC_Button67.字型鎖住 = false;
            this.plC_Button67.寫入元件位置 = "M1304";
            this.plC_Button67.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button67.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button67.文字鎖住 = false;
            this.plC_Button67.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button67.狀態OFF圖片")));
            this.plC_Button67.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button67.狀態ON圖片")));
            this.plC_Button67.讀取位元反向 = false;
            this.plC_Button67.讀取元件位置 = "M1304";
            this.plC_Button67.讀寫鎖住 = false;
            this.plC_Button67.起始狀態 = false;
            this.plC_Button67.音效 = true;
            this.plC_Button67.顯示 = false;
            this.plC_Button67.顯示狀態 = false;
            // 
            // plC_Button68
            // 
            this.plC_Button68.Bool = false;
            this.plC_Button68.but_press = false;
            this.plC_Button68.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button68.Location = new System.Drawing.Point(232, 11);
            this.plC_Button68.Name = "plC_Button68";
            this.plC_Button68.OFF_文字內容 = "LED_03-03";
            this.plC_Button68.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button68.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button68.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button68.ON_文字內容 = "LED_03-03";
            this.plC_Button68.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button68.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button68.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button68.Size = new System.Drawing.Size(104, 52);
            this.plC_Button68.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button68.TabIndex = 113;
            this.plC_Button68.事件驅動 = false;
            this.plC_Button68.字型鎖住 = false;
            this.plC_Button68.寫入元件位置 = "M1303";
            this.plC_Button68.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button68.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button68.文字鎖住 = false;
            this.plC_Button68.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button68.狀態OFF圖片")));
            this.plC_Button68.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button68.狀態ON圖片")));
            this.plC_Button68.讀取位元反向 = false;
            this.plC_Button68.讀取元件位置 = "M1303";
            this.plC_Button68.讀寫鎖住 = false;
            this.plC_Button68.起始狀態 = false;
            this.plC_Button68.音效 = true;
            this.plC_Button68.顯示 = false;
            this.plC_Button68.顯示狀態 = false;
            // 
            // plC_Button69
            // 
            this.plC_Button69.Bool = false;
            this.plC_Button69.but_press = false;
            this.plC_Button69.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button69.Location = new System.Drawing.Point(122, 11);
            this.plC_Button69.Name = "plC_Button69";
            this.plC_Button69.OFF_文字內容 = "LED_03-02";
            this.plC_Button69.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button69.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button69.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button69.ON_文字內容 = "LED_03-02";
            this.plC_Button69.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button69.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button69.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button69.Size = new System.Drawing.Size(104, 52);
            this.plC_Button69.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button69.TabIndex = 111;
            this.plC_Button69.事件驅動 = false;
            this.plC_Button69.字型鎖住 = false;
            this.plC_Button69.寫入元件位置 = "M1302";
            this.plC_Button69.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button69.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button69.文字鎖住 = false;
            this.plC_Button69.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button69.狀態OFF圖片")));
            this.plC_Button69.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button69.狀態ON圖片")));
            this.plC_Button69.讀取位元反向 = false;
            this.plC_Button69.讀取元件位置 = "M1302";
            this.plC_Button69.讀寫鎖住 = false;
            this.plC_Button69.起始狀態 = false;
            this.plC_Button69.音效 = true;
            this.plC_Button69.顯示 = false;
            this.plC_Button69.顯示狀態 = false;
            // 
            // plC_Button70
            // 
            this.plC_Button70.Bool = false;
            this.plC_Button70.but_press = false;
            this.plC_Button70.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button70.Location = new System.Drawing.Point(12, 11);
            this.plC_Button70.Name = "plC_Button70";
            this.plC_Button70.OFF_文字內容 = "LED_03-01";
            this.plC_Button70.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button70.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button70.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button70.ON_文字內容 = "LED_03-01";
            this.plC_Button70.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button70.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button70.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button70.Size = new System.Drawing.Size(104, 52);
            this.plC_Button70.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button70.TabIndex = 109;
            this.plC_Button70.事件驅動 = false;
            this.plC_Button70.字型鎖住 = false;
            this.plC_Button70.寫入元件位置 = "M1301";
            this.plC_Button70.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button70.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button70.文字鎖住 = false;
            this.plC_Button70.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button70.狀態OFF圖片")));
            this.plC_Button70.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button70.狀態ON圖片")));
            this.plC_Button70.讀取位元反向 = false;
            this.plC_Button70.讀取元件位置 = "M1301";
            this.plC_Button70.讀寫鎖住 = false;
            this.plC_Button70.起始狀態 = false;
            this.plC_Button70.音效 = true;
            this.plC_Button70.顯示 = false;
            this.plC_Button70.顯示狀態 = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 660);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1638, 17);
            this.panel7.TabIndex = 86;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.plC_Button43);
            this.panel6.Controls.Add(this.plC_Button44);
            this.panel6.Controls.Add(this.plC_Button45);
            this.panel6.Controls.Add(this.plC_Button46);
            this.panel6.Controls.Add(this.plC_Button47);
            this.panel6.Controls.Add(this.plC_Button48);
            this.panel6.Controls.Add(this.plC_Button49);
            this.panel6.Controls.Add(this.plC_Button50);
            this.panel6.Controls.Add(this.plC_Button51);
            this.panel6.Controls.Add(this.plC_Button52);
            this.panel6.Controls.Add(this.plC_Button53);
            this.panel6.Controls.Add(this.plC_Button54);
            this.panel6.Controls.Add(this.plC_Button55);
            this.panel6.Controls.Add(this.plC_Button56);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 677);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1638, 73);
            this.panel6.TabIndex = 85;
            // 
            // plC_Button43
            // 
            this.plC_Button43.Bool = false;
            this.plC_Button43.but_press = false;
            this.plC_Button43.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button43.Location = new System.Drawing.Point(1442, 12);
            this.plC_Button43.Name = "plC_Button43";
            this.plC_Button43.OFF_文字內容 = "Motor_02-14";
            this.plC_Button43.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button43.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button43.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button43.ON_文字內容 = "Motor_02-14";
            this.plC_Button43.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button43.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button43.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button43.Size = new System.Drawing.Size(104, 52);
            this.plC_Button43.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button43.TabIndex = 150;
            this.plC_Button43.事件驅動 = false;
            this.plC_Button43.字型鎖住 = false;
            this.plC_Button43.寫入元件位置 = "M214";
            this.plC_Button43.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button43.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button43.文字鎖住 = false;
            this.plC_Button43.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button43.狀態OFF圖片")));
            this.plC_Button43.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button43.狀態ON圖片")));
            this.plC_Button43.讀取位元反向 = false;
            this.plC_Button43.讀取元件位置 = "M214";
            this.plC_Button43.讀寫鎖住 = false;
            this.plC_Button43.起始狀態 = false;
            this.plC_Button43.音效 = true;
            this.plC_Button43.顯示 = false;
            this.plC_Button43.顯示狀態 = false;
            // 
            // plC_Button44
            // 
            this.plC_Button44.Bool = false;
            this.plC_Button44.but_press = false;
            this.plC_Button44.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button44.Location = new System.Drawing.Point(1332, 12);
            this.plC_Button44.Name = "plC_Button44";
            this.plC_Button44.OFF_文字內容 = "Motor_02-13";
            this.plC_Button44.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button44.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button44.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button44.ON_文字內容 = "Motor_02-13";
            this.plC_Button44.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button44.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button44.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button44.Size = new System.Drawing.Size(104, 52);
            this.plC_Button44.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button44.TabIndex = 149;
            this.plC_Button44.事件驅動 = false;
            this.plC_Button44.字型鎖住 = false;
            this.plC_Button44.寫入元件位置 = "M213";
            this.plC_Button44.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button44.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button44.文字鎖住 = false;
            this.plC_Button44.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button44.狀態OFF圖片")));
            this.plC_Button44.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button44.狀態ON圖片")));
            this.plC_Button44.讀取位元反向 = false;
            this.plC_Button44.讀取元件位置 = "M213";
            this.plC_Button44.讀寫鎖住 = false;
            this.plC_Button44.起始狀態 = false;
            this.plC_Button44.音效 = true;
            this.plC_Button44.顯示 = false;
            this.plC_Button44.顯示狀態 = false;
            // 
            // plC_Button45
            // 
            this.plC_Button45.Bool = false;
            this.plC_Button45.but_press = false;
            this.plC_Button45.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button45.Location = new System.Drawing.Point(1222, 12);
            this.plC_Button45.Name = "plC_Button45";
            this.plC_Button45.OFF_文字內容 = "Motor_02-12";
            this.plC_Button45.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button45.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button45.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button45.ON_文字內容 = "Motor_02-12";
            this.plC_Button45.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button45.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button45.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button45.Size = new System.Drawing.Size(104, 52);
            this.plC_Button45.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button45.TabIndex = 148;
            this.plC_Button45.事件驅動 = false;
            this.plC_Button45.字型鎖住 = false;
            this.plC_Button45.寫入元件位置 = "M212";
            this.plC_Button45.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button45.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button45.文字鎖住 = false;
            this.plC_Button45.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button45.狀態OFF圖片")));
            this.plC_Button45.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button45.狀態ON圖片")));
            this.plC_Button45.讀取位元反向 = false;
            this.plC_Button45.讀取元件位置 = "M212";
            this.plC_Button45.讀寫鎖住 = false;
            this.plC_Button45.起始狀態 = false;
            this.plC_Button45.音效 = true;
            this.plC_Button45.顯示 = false;
            this.plC_Button45.顯示狀態 = false;
            // 
            // plC_Button46
            // 
            this.plC_Button46.Bool = false;
            this.plC_Button46.but_press = false;
            this.plC_Button46.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button46.Location = new System.Drawing.Point(1112, 12);
            this.plC_Button46.Name = "plC_Button46";
            this.plC_Button46.OFF_文字內容 = "Motor_02-11";
            this.plC_Button46.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button46.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button46.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button46.ON_文字內容 = "Motor_02-11";
            this.plC_Button46.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button46.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button46.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button46.Size = new System.Drawing.Size(104, 52);
            this.plC_Button46.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button46.TabIndex = 147;
            this.plC_Button46.事件驅動 = false;
            this.plC_Button46.字型鎖住 = false;
            this.plC_Button46.寫入元件位置 = "M211";
            this.plC_Button46.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button46.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button46.文字鎖住 = false;
            this.plC_Button46.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button46.狀態OFF圖片")));
            this.plC_Button46.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button46.狀態ON圖片")));
            this.plC_Button46.讀取位元反向 = false;
            this.plC_Button46.讀取元件位置 = "M211";
            this.plC_Button46.讀寫鎖住 = false;
            this.plC_Button46.起始狀態 = false;
            this.plC_Button46.音效 = true;
            this.plC_Button46.顯示 = false;
            this.plC_Button46.顯示狀態 = false;
            // 
            // plC_Button47
            // 
            this.plC_Button47.Bool = false;
            this.plC_Button47.but_press = false;
            this.plC_Button47.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button47.Location = new System.Drawing.Point(1002, 12);
            this.plC_Button47.Name = "plC_Button47";
            this.plC_Button47.OFF_文字內容 = "Motor_02-10";
            this.plC_Button47.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button47.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button47.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button47.ON_文字內容 = "Motor_02-10";
            this.plC_Button47.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button47.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button47.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button47.Size = new System.Drawing.Size(104, 52);
            this.plC_Button47.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button47.TabIndex = 146;
            this.plC_Button47.事件驅動 = false;
            this.plC_Button47.字型鎖住 = false;
            this.plC_Button47.寫入元件位置 = "M210";
            this.plC_Button47.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button47.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button47.文字鎖住 = false;
            this.plC_Button47.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button47.狀態OFF圖片")));
            this.plC_Button47.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button47.狀態ON圖片")));
            this.plC_Button47.讀取位元反向 = false;
            this.plC_Button47.讀取元件位置 = "M210";
            this.plC_Button47.讀寫鎖住 = false;
            this.plC_Button47.起始狀態 = false;
            this.plC_Button47.音效 = true;
            this.plC_Button47.顯示 = false;
            this.plC_Button47.顯示狀態 = false;
            // 
            // plC_Button48
            // 
            this.plC_Button48.Bool = false;
            this.plC_Button48.but_press = false;
            this.plC_Button48.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button48.Location = new System.Drawing.Point(892, 12);
            this.plC_Button48.Name = "plC_Button48";
            this.plC_Button48.OFF_文字內容 = "Motor_02-09";
            this.plC_Button48.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button48.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button48.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button48.ON_文字內容 = "Motor_02-09";
            this.plC_Button48.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button48.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button48.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button48.Size = new System.Drawing.Size(104, 52);
            this.plC_Button48.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button48.TabIndex = 145;
            this.plC_Button48.事件驅動 = false;
            this.plC_Button48.字型鎖住 = false;
            this.plC_Button48.寫入元件位置 = "M209";
            this.plC_Button48.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button48.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button48.文字鎖住 = false;
            this.plC_Button48.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button48.狀態OFF圖片")));
            this.plC_Button48.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button48.狀態ON圖片")));
            this.plC_Button48.讀取位元反向 = false;
            this.plC_Button48.讀取元件位置 = "M209";
            this.plC_Button48.讀寫鎖住 = false;
            this.plC_Button48.起始狀態 = false;
            this.plC_Button48.音效 = true;
            this.plC_Button48.顯示 = false;
            this.plC_Button48.顯示狀態 = false;
            // 
            // plC_Button49
            // 
            this.plC_Button49.Bool = false;
            this.plC_Button49.but_press = false;
            this.plC_Button49.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button49.Location = new System.Drawing.Point(782, 12);
            this.plC_Button49.Name = "plC_Button49";
            this.plC_Button49.OFF_文字內容 = "Motor_02-08";
            this.plC_Button49.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button49.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button49.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button49.ON_文字內容 = "Motor_02-08";
            this.plC_Button49.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button49.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button49.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button49.Size = new System.Drawing.Size(104, 52);
            this.plC_Button49.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button49.TabIndex = 144;
            this.plC_Button49.事件驅動 = false;
            this.plC_Button49.字型鎖住 = false;
            this.plC_Button49.寫入元件位置 = "M208";
            this.plC_Button49.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button49.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button49.文字鎖住 = false;
            this.plC_Button49.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button49.狀態OFF圖片")));
            this.plC_Button49.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button49.狀態ON圖片")));
            this.plC_Button49.讀取位元反向 = false;
            this.plC_Button49.讀取元件位置 = "M208";
            this.plC_Button49.讀寫鎖住 = false;
            this.plC_Button49.起始狀態 = false;
            this.plC_Button49.音效 = true;
            this.plC_Button49.顯示 = false;
            this.plC_Button49.顯示狀態 = false;
            // 
            // plC_Button50
            // 
            this.plC_Button50.Bool = false;
            this.plC_Button50.but_press = false;
            this.plC_Button50.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button50.Location = new System.Drawing.Point(672, 12);
            this.plC_Button50.Name = "plC_Button50";
            this.plC_Button50.OFF_文字內容 = "Motor_02-07";
            this.plC_Button50.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button50.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button50.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button50.ON_文字內容 = "Motor_02-07";
            this.plC_Button50.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button50.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button50.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button50.Size = new System.Drawing.Size(104, 52);
            this.plC_Button50.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button50.TabIndex = 143;
            this.plC_Button50.事件驅動 = false;
            this.plC_Button50.字型鎖住 = false;
            this.plC_Button50.寫入元件位置 = "M207";
            this.plC_Button50.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button50.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button50.文字鎖住 = false;
            this.plC_Button50.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button50.狀態OFF圖片")));
            this.plC_Button50.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button50.狀態ON圖片")));
            this.plC_Button50.讀取位元反向 = false;
            this.plC_Button50.讀取元件位置 = "M207";
            this.plC_Button50.讀寫鎖住 = false;
            this.plC_Button50.起始狀態 = false;
            this.plC_Button50.音效 = true;
            this.plC_Button50.顯示 = false;
            this.plC_Button50.顯示狀態 = false;
            // 
            // plC_Button51
            // 
            this.plC_Button51.Bool = false;
            this.plC_Button51.but_press = false;
            this.plC_Button51.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button51.Location = new System.Drawing.Point(562, 12);
            this.plC_Button51.Name = "plC_Button51";
            this.plC_Button51.OFF_文字內容 = "Motor_02-06";
            this.plC_Button51.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button51.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button51.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button51.ON_文字內容 = "Motor_02-06";
            this.plC_Button51.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button51.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button51.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button51.Size = new System.Drawing.Size(104, 52);
            this.plC_Button51.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button51.TabIndex = 142;
            this.plC_Button51.事件驅動 = false;
            this.plC_Button51.字型鎖住 = false;
            this.plC_Button51.寫入元件位置 = "M206";
            this.plC_Button51.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button51.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button51.文字鎖住 = false;
            this.plC_Button51.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button51.狀態OFF圖片")));
            this.plC_Button51.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button51.狀態ON圖片")));
            this.plC_Button51.讀取位元反向 = false;
            this.plC_Button51.讀取元件位置 = "M206";
            this.plC_Button51.讀寫鎖住 = false;
            this.plC_Button51.起始狀態 = false;
            this.plC_Button51.音效 = true;
            this.plC_Button51.顯示 = false;
            this.plC_Button51.顯示狀態 = false;
            // 
            // plC_Button52
            // 
            this.plC_Button52.Bool = false;
            this.plC_Button52.but_press = false;
            this.plC_Button52.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button52.Location = new System.Drawing.Point(452, 12);
            this.plC_Button52.Name = "plC_Button52";
            this.plC_Button52.OFF_文字內容 = "Motor_02-05";
            this.plC_Button52.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button52.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button52.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button52.ON_文字內容 = "Motor_02-05";
            this.plC_Button52.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button52.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button52.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button52.Size = new System.Drawing.Size(104, 52);
            this.plC_Button52.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button52.TabIndex = 141;
            this.plC_Button52.事件驅動 = false;
            this.plC_Button52.字型鎖住 = false;
            this.plC_Button52.寫入元件位置 = "M205";
            this.plC_Button52.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button52.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button52.文字鎖住 = false;
            this.plC_Button52.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button52.狀態OFF圖片")));
            this.plC_Button52.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button52.狀態ON圖片")));
            this.plC_Button52.讀取位元反向 = false;
            this.plC_Button52.讀取元件位置 = "M205";
            this.plC_Button52.讀寫鎖住 = false;
            this.plC_Button52.起始狀態 = false;
            this.plC_Button52.音效 = true;
            this.plC_Button52.顯示 = false;
            this.plC_Button52.顯示狀態 = false;
            // 
            // plC_Button53
            // 
            this.plC_Button53.Bool = false;
            this.plC_Button53.but_press = false;
            this.plC_Button53.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button53.Location = new System.Drawing.Point(342, 12);
            this.plC_Button53.Name = "plC_Button53";
            this.plC_Button53.OFF_文字內容 = "Motor_02-04";
            this.plC_Button53.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button53.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button53.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button53.ON_文字內容 = "Motor_02-04";
            this.plC_Button53.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button53.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button53.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button53.Size = new System.Drawing.Size(104, 52);
            this.plC_Button53.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button53.TabIndex = 140;
            this.plC_Button53.事件驅動 = false;
            this.plC_Button53.字型鎖住 = false;
            this.plC_Button53.寫入元件位置 = "M204";
            this.plC_Button53.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button53.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button53.文字鎖住 = false;
            this.plC_Button53.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button53.狀態OFF圖片")));
            this.plC_Button53.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button53.狀態ON圖片")));
            this.plC_Button53.讀取位元反向 = false;
            this.plC_Button53.讀取元件位置 = "M204";
            this.plC_Button53.讀寫鎖住 = false;
            this.plC_Button53.起始狀態 = false;
            this.plC_Button53.音效 = true;
            this.plC_Button53.顯示 = false;
            this.plC_Button53.顯示狀態 = false;
            // 
            // plC_Button54
            // 
            this.plC_Button54.Bool = false;
            this.plC_Button54.but_press = false;
            this.plC_Button54.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button54.Location = new System.Drawing.Point(232, 12);
            this.plC_Button54.Name = "plC_Button54";
            this.plC_Button54.OFF_文字內容 = "Motor_02-03";
            this.plC_Button54.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button54.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button54.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button54.ON_文字內容 = "Motor_02-03";
            this.plC_Button54.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button54.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button54.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button54.Size = new System.Drawing.Size(104, 52);
            this.plC_Button54.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button54.TabIndex = 139;
            this.plC_Button54.事件驅動 = false;
            this.plC_Button54.字型鎖住 = false;
            this.plC_Button54.寫入元件位置 = "M203";
            this.plC_Button54.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button54.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button54.文字鎖住 = false;
            this.plC_Button54.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button54.狀態OFF圖片")));
            this.plC_Button54.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button54.狀態ON圖片")));
            this.plC_Button54.讀取位元反向 = false;
            this.plC_Button54.讀取元件位置 = "M203";
            this.plC_Button54.讀寫鎖住 = false;
            this.plC_Button54.起始狀態 = false;
            this.plC_Button54.音效 = true;
            this.plC_Button54.顯示 = false;
            this.plC_Button54.顯示狀態 = false;
            // 
            // plC_Button55
            // 
            this.plC_Button55.Bool = false;
            this.plC_Button55.but_press = false;
            this.plC_Button55.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button55.Location = new System.Drawing.Point(122, 12);
            this.plC_Button55.Name = "plC_Button55";
            this.plC_Button55.OFF_文字內容 = "Motor_02-02";
            this.plC_Button55.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button55.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button55.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button55.ON_文字內容 = "Motor_02-02";
            this.plC_Button55.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button55.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button55.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button55.Size = new System.Drawing.Size(104, 52);
            this.plC_Button55.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button55.TabIndex = 138;
            this.plC_Button55.事件驅動 = false;
            this.plC_Button55.字型鎖住 = false;
            this.plC_Button55.寫入元件位置 = "M202";
            this.plC_Button55.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button55.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button55.文字鎖住 = false;
            this.plC_Button55.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button55.狀態OFF圖片")));
            this.plC_Button55.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button55.狀態ON圖片")));
            this.plC_Button55.讀取位元反向 = false;
            this.plC_Button55.讀取元件位置 = "M202";
            this.plC_Button55.讀寫鎖住 = false;
            this.plC_Button55.起始狀態 = false;
            this.plC_Button55.音效 = true;
            this.plC_Button55.顯示 = false;
            this.plC_Button55.顯示狀態 = false;
            // 
            // plC_Button56
            // 
            this.plC_Button56.Bool = false;
            this.plC_Button56.but_press = false;
            this.plC_Button56.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button56.Location = new System.Drawing.Point(12, 12);
            this.plC_Button56.Name = "plC_Button56";
            this.plC_Button56.OFF_文字內容 = "Motor_02-01";
            this.plC_Button56.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button56.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button56.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button56.ON_文字內容 = "Motor_02-01";
            this.plC_Button56.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button56.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button56.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button56.Size = new System.Drawing.Size(104, 52);
            this.plC_Button56.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button56.TabIndex = 137;
            this.plC_Button56.事件驅動 = false;
            this.plC_Button56.字型鎖住 = false;
            this.plC_Button56.寫入元件位置 = "M201";
            this.plC_Button56.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button56.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button56.文字鎖住 = false;
            this.plC_Button56.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button56.狀態OFF圖片")));
            this.plC_Button56.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button56.狀態ON圖片")));
            this.plC_Button56.讀取位元反向 = false;
            this.plC_Button56.讀取元件位置 = "M201";
            this.plC_Button56.讀寫鎖住 = false;
            this.plC_Button56.起始狀態 = false;
            this.plC_Button56.音效 = true;
            this.plC_Button56.顯示 = false;
            this.plC_Button56.顯示狀態 = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.plC_Button29);
            this.panel5.Controls.Add(this.plC_Button30);
            this.panel5.Controls.Add(this.plC_Button31);
            this.panel5.Controls.Add(this.plC_Button32);
            this.panel5.Controls.Add(this.plC_Button33);
            this.panel5.Controls.Add(this.plC_Button34);
            this.panel5.Controls.Add(this.plC_Button35);
            this.panel5.Controls.Add(this.plC_Button36);
            this.panel5.Controls.Add(this.plC_Button37);
            this.panel5.Controls.Add(this.plC_Button38);
            this.panel5.Controls.Add(this.plC_Button39);
            this.panel5.Controls.Add(this.plC_Button40);
            this.panel5.Controls.Add(this.plC_Button41);
            this.panel5.Controls.Add(this.plC_Button42);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 750);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1638, 73);
            this.panel5.TabIndex = 84;
            // 
            // plC_Button29
            // 
            this.plC_Button29.Bool = false;
            this.plC_Button29.but_press = false;
            this.plC_Button29.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button29.Location = new System.Drawing.Point(1442, 11);
            this.plC_Button29.Name = "plC_Button29";
            this.plC_Button29.OFF_文字內容 = "LED_02-14";
            this.plC_Button29.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button29.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button29.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button29.ON_文字內容 = "LED_02-14";
            this.plC_Button29.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button29.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button29.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button29.Size = new System.Drawing.Size(104, 52);
            this.plC_Button29.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button29.TabIndex = 135;
            this.plC_Button29.事件驅動 = false;
            this.plC_Button29.字型鎖住 = false;
            this.plC_Button29.寫入元件位置 = "M1214";
            this.plC_Button29.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button29.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button29.文字鎖住 = false;
            this.plC_Button29.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button29.狀態OFF圖片")));
            this.plC_Button29.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button29.狀態ON圖片")));
            this.plC_Button29.讀取位元反向 = false;
            this.plC_Button29.讀取元件位置 = "M1214";
            this.plC_Button29.讀寫鎖住 = false;
            this.plC_Button29.起始狀態 = false;
            this.plC_Button29.音效 = true;
            this.plC_Button29.顯示 = false;
            this.plC_Button29.顯示狀態 = false;
            // 
            // plC_Button30
            // 
            this.plC_Button30.Bool = false;
            this.plC_Button30.but_press = false;
            this.plC_Button30.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button30.Location = new System.Drawing.Point(1332, 11);
            this.plC_Button30.Name = "plC_Button30";
            this.plC_Button30.OFF_文字內容 = "LED_02-13";
            this.plC_Button30.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button30.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button30.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button30.ON_文字內容 = "LED_02-13";
            this.plC_Button30.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button30.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button30.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button30.Size = new System.Drawing.Size(104, 52);
            this.plC_Button30.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button30.TabIndex = 133;
            this.plC_Button30.事件驅動 = false;
            this.plC_Button30.字型鎖住 = false;
            this.plC_Button30.寫入元件位置 = "M1213";
            this.plC_Button30.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button30.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button30.文字鎖住 = false;
            this.plC_Button30.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button30.狀態OFF圖片")));
            this.plC_Button30.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button30.狀態ON圖片")));
            this.plC_Button30.讀取位元反向 = false;
            this.plC_Button30.讀取元件位置 = "M1213";
            this.plC_Button30.讀寫鎖住 = false;
            this.plC_Button30.起始狀態 = false;
            this.plC_Button30.音效 = true;
            this.plC_Button30.顯示 = false;
            this.plC_Button30.顯示狀態 = false;
            // 
            // plC_Button31
            // 
            this.plC_Button31.Bool = false;
            this.plC_Button31.but_press = false;
            this.plC_Button31.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button31.Location = new System.Drawing.Point(1222, 11);
            this.plC_Button31.Name = "plC_Button31";
            this.plC_Button31.OFF_文字內容 = "LED_02-12";
            this.plC_Button31.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button31.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button31.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button31.ON_文字內容 = "LED_02-12";
            this.plC_Button31.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button31.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button31.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button31.Size = new System.Drawing.Size(104, 52);
            this.plC_Button31.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button31.TabIndex = 131;
            this.plC_Button31.事件驅動 = false;
            this.plC_Button31.字型鎖住 = false;
            this.plC_Button31.寫入元件位置 = "M1212";
            this.plC_Button31.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button31.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button31.文字鎖住 = false;
            this.plC_Button31.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button31.狀態OFF圖片")));
            this.plC_Button31.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button31.狀態ON圖片")));
            this.plC_Button31.讀取位元反向 = false;
            this.plC_Button31.讀取元件位置 = "M1212";
            this.plC_Button31.讀寫鎖住 = false;
            this.plC_Button31.起始狀態 = false;
            this.plC_Button31.音效 = true;
            this.plC_Button31.顯示 = false;
            this.plC_Button31.顯示狀態 = false;
            // 
            // plC_Button32
            // 
            this.plC_Button32.Bool = false;
            this.plC_Button32.but_press = false;
            this.plC_Button32.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button32.Location = new System.Drawing.Point(1112, 11);
            this.plC_Button32.Name = "plC_Button32";
            this.plC_Button32.OFF_文字內容 = "LED_02-11";
            this.plC_Button32.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button32.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button32.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button32.ON_文字內容 = "LED_02-11";
            this.plC_Button32.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button32.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button32.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button32.Size = new System.Drawing.Size(104, 52);
            this.plC_Button32.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button32.TabIndex = 129;
            this.plC_Button32.事件驅動 = false;
            this.plC_Button32.字型鎖住 = false;
            this.plC_Button32.寫入元件位置 = "M1211";
            this.plC_Button32.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button32.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button32.文字鎖住 = false;
            this.plC_Button32.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button32.狀態OFF圖片")));
            this.plC_Button32.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button32.狀態ON圖片")));
            this.plC_Button32.讀取位元反向 = false;
            this.plC_Button32.讀取元件位置 = "M1211";
            this.plC_Button32.讀寫鎖住 = false;
            this.plC_Button32.起始狀態 = false;
            this.plC_Button32.音效 = true;
            this.plC_Button32.顯示 = false;
            this.plC_Button32.顯示狀態 = false;
            // 
            // plC_Button33
            // 
            this.plC_Button33.Bool = false;
            this.plC_Button33.but_press = false;
            this.plC_Button33.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button33.Location = new System.Drawing.Point(1002, 11);
            this.plC_Button33.Name = "plC_Button33";
            this.plC_Button33.OFF_文字內容 = "LED_02-10";
            this.plC_Button33.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button33.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button33.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button33.ON_文字內容 = "LED_02-10";
            this.plC_Button33.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button33.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button33.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button33.Size = new System.Drawing.Size(104, 52);
            this.plC_Button33.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button33.TabIndex = 127;
            this.plC_Button33.事件驅動 = false;
            this.plC_Button33.字型鎖住 = false;
            this.plC_Button33.寫入元件位置 = "M1210";
            this.plC_Button33.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button33.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button33.文字鎖住 = false;
            this.plC_Button33.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button33.狀態OFF圖片")));
            this.plC_Button33.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button33.狀態ON圖片")));
            this.plC_Button33.讀取位元反向 = false;
            this.plC_Button33.讀取元件位置 = "M1210";
            this.plC_Button33.讀寫鎖住 = false;
            this.plC_Button33.起始狀態 = false;
            this.plC_Button33.音效 = true;
            this.plC_Button33.顯示 = false;
            this.plC_Button33.顯示狀態 = false;
            // 
            // plC_Button34
            // 
            this.plC_Button34.Bool = false;
            this.plC_Button34.but_press = false;
            this.plC_Button34.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button34.Location = new System.Drawing.Point(892, 11);
            this.plC_Button34.Name = "plC_Button34";
            this.plC_Button34.OFF_文字內容 = "LED_02-09";
            this.plC_Button34.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button34.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button34.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button34.ON_文字內容 = "LED_02-09";
            this.plC_Button34.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button34.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button34.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button34.Size = new System.Drawing.Size(104, 52);
            this.plC_Button34.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button34.TabIndex = 125;
            this.plC_Button34.事件驅動 = false;
            this.plC_Button34.字型鎖住 = false;
            this.plC_Button34.寫入元件位置 = "M1209";
            this.plC_Button34.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button34.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button34.文字鎖住 = false;
            this.plC_Button34.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button34.狀態OFF圖片")));
            this.plC_Button34.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button34.狀態ON圖片")));
            this.plC_Button34.讀取位元反向 = false;
            this.plC_Button34.讀取元件位置 = "M1209";
            this.plC_Button34.讀寫鎖住 = false;
            this.plC_Button34.起始狀態 = false;
            this.plC_Button34.音效 = true;
            this.plC_Button34.顯示 = false;
            this.plC_Button34.顯示狀態 = false;
            // 
            // plC_Button35
            // 
            this.plC_Button35.Bool = false;
            this.plC_Button35.but_press = false;
            this.plC_Button35.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button35.Location = new System.Drawing.Point(782, 11);
            this.plC_Button35.Name = "plC_Button35";
            this.plC_Button35.OFF_文字內容 = "LED_02-08";
            this.plC_Button35.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button35.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button35.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button35.ON_文字內容 = "LED_02-08";
            this.plC_Button35.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button35.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button35.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button35.Size = new System.Drawing.Size(104, 52);
            this.plC_Button35.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button35.TabIndex = 123;
            this.plC_Button35.事件驅動 = false;
            this.plC_Button35.字型鎖住 = false;
            this.plC_Button35.寫入元件位置 = "M1208";
            this.plC_Button35.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button35.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button35.文字鎖住 = false;
            this.plC_Button35.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button35.狀態OFF圖片")));
            this.plC_Button35.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button35.狀態ON圖片")));
            this.plC_Button35.讀取位元反向 = false;
            this.plC_Button35.讀取元件位置 = "M1208";
            this.plC_Button35.讀寫鎖住 = false;
            this.plC_Button35.起始狀態 = false;
            this.plC_Button35.音效 = true;
            this.plC_Button35.顯示 = false;
            this.plC_Button35.顯示狀態 = false;
            // 
            // plC_Button36
            // 
            this.plC_Button36.Bool = false;
            this.plC_Button36.but_press = false;
            this.plC_Button36.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button36.Location = new System.Drawing.Point(672, 11);
            this.plC_Button36.Name = "plC_Button36";
            this.plC_Button36.OFF_文字內容 = "LED_02-07";
            this.plC_Button36.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button36.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button36.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button36.ON_文字內容 = "LED_02-07";
            this.plC_Button36.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button36.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button36.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button36.Size = new System.Drawing.Size(104, 52);
            this.plC_Button36.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button36.TabIndex = 121;
            this.plC_Button36.事件驅動 = false;
            this.plC_Button36.字型鎖住 = false;
            this.plC_Button36.寫入元件位置 = "M1207";
            this.plC_Button36.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button36.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button36.文字鎖住 = false;
            this.plC_Button36.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button36.狀態OFF圖片")));
            this.plC_Button36.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button36.狀態ON圖片")));
            this.plC_Button36.讀取位元反向 = false;
            this.plC_Button36.讀取元件位置 = "M1207";
            this.plC_Button36.讀寫鎖住 = false;
            this.plC_Button36.起始狀態 = false;
            this.plC_Button36.音效 = true;
            this.plC_Button36.顯示 = false;
            this.plC_Button36.顯示狀態 = false;
            // 
            // plC_Button37
            // 
            this.plC_Button37.Bool = false;
            this.plC_Button37.but_press = false;
            this.plC_Button37.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button37.Location = new System.Drawing.Point(562, 11);
            this.plC_Button37.Name = "plC_Button37";
            this.plC_Button37.OFF_文字內容 = "LED_02-06";
            this.plC_Button37.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button37.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button37.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button37.ON_文字內容 = "LED_02-06";
            this.plC_Button37.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button37.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button37.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button37.Size = new System.Drawing.Size(104, 52);
            this.plC_Button37.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button37.TabIndex = 119;
            this.plC_Button37.事件驅動 = false;
            this.plC_Button37.字型鎖住 = false;
            this.plC_Button37.寫入元件位置 = "M1206";
            this.plC_Button37.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button37.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button37.文字鎖住 = false;
            this.plC_Button37.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button37.狀態OFF圖片")));
            this.plC_Button37.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button37.狀態ON圖片")));
            this.plC_Button37.讀取位元反向 = false;
            this.plC_Button37.讀取元件位置 = "M1206";
            this.plC_Button37.讀寫鎖住 = false;
            this.plC_Button37.起始狀態 = false;
            this.plC_Button37.音效 = true;
            this.plC_Button37.顯示 = false;
            this.plC_Button37.顯示狀態 = false;
            // 
            // plC_Button38
            // 
            this.plC_Button38.Bool = false;
            this.plC_Button38.but_press = false;
            this.plC_Button38.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button38.Location = new System.Drawing.Point(452, 11);
            this.plC_Button38.Name = "plC_Button38";
            this.plC_Button38.OFF_文字內容 = "LED_02-05";
            this.plC_Button38.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button38.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button38.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button38.ON_文字內容 = "LED_02-05";
            this.plC_Button38.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button38.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button38.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button38.Size = new System.Drawing.Size(104, 52);
            this.plC_Button38.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button38.TabIndex = 117;
            this.plC_Button38.事件驅動 = false;
            this.plC_Button38.字型鎖住 = false;
            this.plC_Button38.寫入元件位置 = "M1205";
            this.plC_Button38.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button38.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button38.文字鎖住 = false;
            this.plC_Button38.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button38.狀態OFF圖片")));
            this.plC_Button38.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button38.狀態ON圖片")));
            this.plC_Button38.讀取位元反向 = false;
            this.plC_Button38.讀取元件位置 = "M1205";
            this.plC_Button38.讀寫鎖住 = false;
            this.plC_Button38.起始狀態 = false;
            this.plC_Button38.音效 = true;
            this.plC_Button38.顯示 = false;
            this.plC_Button38.顯示狀態 = false;
            // 
            // plC_Button39
            // 
            this.plC_Button39.Bool = false;
            this.plC_Button39.but_press = false;
            this.plC_Button39.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button39.Location = new System.Drawing.Point(342, 11);
            this.plC_Button39.Name = "plC_Button39";
            this.plC_Button39.OFF_文字內容 = "LED_02-04";
            this.plC_Button39.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button39.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button39.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button39.ON_文字內容 = "LED_02-04";
            this.plC_Button39.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button39.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button39.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button39.Size = new System.Drawing.Size(104, 52);
            this.plC_Button39.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button39.TabIndex = 115;
            this.plC_Button39.事件驅動 = false;
            this.plC_Button39.字型鎖住 = false;
            this.plC_Button39.寫入元件位置 = "M1204";
            this.plC_Button39.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button39.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button39.文字鎖住 = false;
            this.plC_Button39.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button39.狀態OFF圖片")));
            this.plC_Button39.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button39.狀態ON圖片")));
            this.plC_Button39.讀取位元反向 = false;
            this.plC_Button39.讀取元件位置 = "M1204";
            this.plC_Button39.讀寫鎖住 = false;
            this.plC_Button39.起始狀態 = false;
            this.plC_Button39.音效 = true;
            this.plC_Button39.顯示 = false;
            this.plC_Button39.顯示狀態 = false;
            // 
            // plC_Button40
            // 
            this.plC_Button40.Bool = false;
            this.plC_Button40.but_press = false;
            this.plC_Button40.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button40.Location = new System.Drawing.Point(232, 11);
            this.plC_Button40.Name = "plC_Button40";
            this.plC_Button40.OFF_文字內容 = "LED_02-03";
            this.plC_Button40.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button40.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button40.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button40.ON_文字內容 = "LED_02-03";
            this.plC_Button40.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button40.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button40.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button40.Size = new System.Drawing.Size(104, 52);
            this.plC_Button40.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button40.TabIndex = 113;
            this.plC_Button40.事件驅動 = false;
            this.plC_Button40.字型鎖住 = false;
            this.plC_Button40.寫入元件位置 = "M1203";
            this.plC_Button40.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button40.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button40.文字鎖住 = false;
            this.plC_Button40.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button40.狀態OFF圖片")));
            this.plC_Button40.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button40.狀態ON圖片")));
            this.plC_Button40.讀取位元反向 = false;
            this.plC_Button40.讀取元件位置 = "M1203";
            this.plC_Button40.讀寫鎖住 = false;
            this.plC_Button40.起始狀態 = false;
            this.plC_Button40.音效 = true;
            this.plC_Button40.顯示 = false;
            this.plC_Button40.顯示狀態 = false;
            // 
            // plC_Button41
            // 
            this.plC_Button41.Bool = false;
            this.plC_Button41.but_press = false;
            this.plC_Button41.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button41.Location = new System.Drawing.Point(122, 11);
            this.plC_Button41.Name = "plC_Button41";
            this.plC_Button41.OFF_文字內容 = "LED_02-02";
            this.plC_Button41.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button41.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button41.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button41.ON_文字內容 = "LED_02-02";
            this.plC_Button41.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button41.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button41.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button41.Size = new System.Drawing.Size(104, 52);
            this.plC_Button41.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button41.TabIndex = 111;
            this.plC_Button41.事件驅動 = false;
            this.plC_Button41.字型鎖住 = false;
            this.plC_Button41.寫入元件位置 = "M1202";
            this.plC_Button41.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button41.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button41.文字鎖住 = false;
            this.plC_Button41.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button41.狀態OFF圖片")));
            this.plC_Button41.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button41.狀態ON圖片")));
            this.plC_Button41.讀取位元反向 = false;
            this.plC_Button41.讀取元件位置 = "M1202";
            this.plC_Button41.讀寫鎖住 = false;
            this.plC_Button41.起始狀態 = false;
            this.plC_Button41.音效 = true;
            this.plC_Button41.顯示 = false;
            this.plC_Button41.顯示狀態 = false;
            // 
            // plC_Button42
            // 
            this.plC_Button42.Bool = false;
            this.plC_Button42.but_press = false;
            this.plC_Button42.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button42.Location = new System.Drawing.Point(12, 11);
            this.plC_Button42.Name = "plC_Button42";
            this.plC_Button42.OFF_文字內容 = "LED_02-01";
            this.plC_Button42.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button42.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button42.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button42.ON_文字內容 = "LED_02-01";
            this.plC_Button42.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button42.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button42.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button42.Size = new System.Drawing.Size(104, 52);
            this.plC_Button42.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button42.TabIndex = 109;
            this.plC_Button42.事件驅動 = false;
            this.plC_Button42.字型鎖住 = false;
            this.plC_Button42.寫入元件位置 = "M1201";
            this.plC_Button42.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button42.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button42.文字鎖住 = false;
            this.plC_Button42.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button42.狀態OFF圖片")));
            this.plC_Button42.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button42.狀態ON圖片")));
            this.plC_Button42.讀取位元反向 = false;
            this.plC_Button42.讀取元件位置 = "M1201";
            this.plC_Button42.讀寫鎖住 = false;
            this.plC_Button42.起始狀態 = false;
            this.plC_Button42.音效 = true;
            this.plC_Button42.顯示 = false;
            this.plC_Button42.顯示狀態 = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 823);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1638, 17);
            this.panel4.TabIndex = 83;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.plC_Button27);
            this.panel3.Controls.Add(this.plC_Button25);
            this.panel3.Controls.Add(this.plC_Button23);
            this.panel3.Controls.Add(this.plC_Button13);
            this.panel3.Controls.Add(this.plC_Button15);
            this.panel3.Controls.Add(this.plC_Button17);
            this.panel3.Controls.Add(this.plC_Button19);
            this.panel3.Controls.Add(this.plC_Button21);
            this.panel3.Controls.Add(this.plC_Button11);
            this.panel3.Controls.Add(this.plC_Button9);
            this.panel3.Controls.Add(this.plC_Button7);
            this.panel3.Controls.Add(this.plC_Button5);
            this.panel3.Controls.Add(this.plC_Button3);
            this.panel3.Controls.Add(this.plC_Button2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 840);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1638, 73);
            this.panel3.TabIndex = 82;
            // 
            // plC_Button27
            // 
            this.plC_Button27.Bool = false;
            this.plC_Button27.but_press = false;
            this.plC_Button27.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button27.Location = new System.Drawing.Point(1442, 12);
            this.plC_Button27.Name = "plC_Button27";
            this.plC_Button27.OFF_文字內容 = "Motor_01-14";
            this.plC_Button27.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button27.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button27.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button27.ON_文字內容 = "Motor_01-14";
            this.plC_Button27.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button27.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button27.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button27.Size = new System.Drawing.Size(104, 52);
            this.plC_Button27.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button27.TabIndex = 150;
            this.plC_Button27.事件驅動 = false;
            this.plC_Button27.字型鎖住 = false;
            this.plC_Button27.寫入元件位置 = "M114";
            this.plC_Button27.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button27.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button27.文字鎖住 = false;
            this.plC_Button27.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button27.狀態OFF圖片")));
            this.plC_Button27.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button27.狀態ON圖片")));
            this.plC_Button27.讀取位元反向 = false;
            this.plC_Button27.讀取元件位置 = "M114";
            this.plC_Button27.讀寫鎖住 = false;
            this.plC_Button27.起始狀態 = false;
            this.plC_Button27.音效 = true;
            this.plC_Button27.顯示 = false;
            this.plC_Button27.顯示狀態 = false;
            // 
            // plC_Button25
            // 
            this.plC_Button25.Bool = false;
            this.plC_Button25.but_press = false;
            this.plC_Button25.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button25.Location = new System.Drawing.Point(1332, 12);
            this.plC_Button25.Name = "plC_Button25";
            this.plC_Button25.OFF_文字內容 = "Motor_01-13";
            this.plC_Button25.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button25.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button25.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button25.ON_文字內容 = "Motor_01-13";
            this.plC_Button25.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button25.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button25.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button25.Size = new System.Drawing.Size(104, 52);
            this.plC_Button25.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button25.TabIndex = 149;
            this.plC_Button25.事件驅動 = false;
            this.plC_Button25.字型鎖住 = false;
            this.plC_Button25.寫入元件位置 = "M113";
            this.plC_Button25.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button25.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button25.文字鎖住 = false;
            this.plC_Button25.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button25.狀態OFF圖片")));
            this.plC_Button25.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button25.狀態ON圖片")));
            this.plC_Button25.讀取位元反向 = false;
            this.plC_Button25.讀取元件位置 = "M113";
            this.plC_Button25.讀寫鎖住 = false;
            this.plC_Button25.起始狀態 = false;
            this.plC_Button25.音效 = true;
            this.plC_Button25.顯示 = false;
            this.plC_Button25.顯示狀態 = false;
            // 
            // plC_Button23
            // 
            this.plC_Button23.Bool = false;
            this.plC_Button23.but_press = false;
            this.plC_Button23.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button23.Location = new System.Drawing.Point(1222, 12);
            this.plC_Button23.Name = "plC_Button23";
            this.plC_Button23.OFF_文字內容 = "Motor_01-12";
            this.plC_Button23.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button23.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button23.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button23.ON_文字內容 = "Motor_01-12";
            this.plC_Button23.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button23.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button23.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button23.Size = new System.Drawing.Size(104, 52);
            this.plC_Button23.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button23.TabIndex = 148;
            this.plC_Button23.事件驅動 = false;
            this.plC_Button23.字型鎖住 = false;
            this.plC_Button23.寫入元件位置 = "M112";
            this.plC_Button23.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button23.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button23.文字鎖住 = false;
            this.plC_Button23.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button23.狀態OFF圖片")));
            this.plC_Button23.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button23.狀態ON圖片")));
            this.plC_Button23.讀取位元反向 = false;
            this.plC_Button23.讀取元件位置 = "M112";
            this.plC_Button23.讀寫鎖住 = false;
            this.plC_Button23.起始狀態 = false;
            this.plC_Button23.音效 = true;
            this.plC_Button23.顯示 = false;
            this.plC_Button23.顯示狀態 = false;
            // 
            // plC_Button13
            // 
            this.plC_Button13.Bool = false;
            this.plC_Button13.but_press = false;
            this.plC_Button13.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button13.Location = new System.Drawing.Point(1112, 12);
            this.plC_Button13.Name = "plC_Button13";
            this.plC_Button13.OFF_文字內容 = "Motor_01-11";
            this.plC_Button13.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button13.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button13.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button13.ON_文字內容 = "Motor_01-11";
            this.plC_Button13.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button13.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button13.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button13.Size = new System.Drawing.Size(104, 52);
            this.plC_Button13.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button13.TabIndex = 147;
            this.plC_Button13.事件驅動 = false;
            this.plC_Button13.字型鎖住 = false;
            this.plC_Button13.寫入元件位置 = "M111";
            this.plC_Button13.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button13.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button13.文字鎖住 = false;
            this.plC_Button13.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button13.狀態OFF圖片")));
            this.plC_Button13.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button13.狀態ON圖片")));
            this.plC_Button13.讀取位元反向 = false;
            this.plC_Button13.讀取元件位置 = "M111";
            this.plC_Button13.讀寫鎖住 = false;
            this.plC_Button13.起始狀態 = false;
            this.plC_Button13.音效 = true;
            this.plC_Button13.顯示 = false;
            this.plC_Button13.顯示狀態 = false;
            // 
            // plC_Button15
            // 
            this.plC_Button15.Bool = false;
            this.plC_Button15.but_press = false;
            this.plC_Button15.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button15.Location = new System.Drawing.Point(1002, 12);
            this.plC_Button15.Name = "plC_Button15";
            this.plC_Button15.OFF_文字內容 = "Motor_01-10";
            this.plC_Button15.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button15.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button15.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button15.ON_文字內容 = "Motor_01-10";
            this.plC_Button15.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button15.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button15.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button15.Size = new System.Drawing.Size(104, 52);
            this.plC_Button15.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button15.TabIndex = 146;
            this.plC_Button15.事件驅動 = false;
            this.plC_Button15.字型鎖住 = false;
            this.plC_Button15.寫入元件位置 = "M110";
            this.plC_Button15.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button15.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button15.文字鎖住 = false;
            this.plC_Button15.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button15.狀態OFF圖片")));
            this.plC_Button15.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button15.狀態ON圖片")));
            this.plC_Button15.讀取位元反向 = false;
            this.plC_Button15.讀取元件位置 = "M110";
            this.plC_Button15.讀寫鎖住 = false;
            this.plC_Button15.起始狀態 = false;
            this.plC_Button15.音效 = true;
            this.plC_Button15.顯示 = false;
            this.plC_Button15.顯示狀態 = false;
            // 
            // plC_Button17
            // 
            this.plC_Button17.Bool = false;
            this.plC_Button17.but_press = false;
            this.plC_Button17.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button17.Location = new System.Drawing.Point(892, 12);
            this.plC_Button17.Name = "plC_Button17";
            this.plC_Button17.OFF_文字內容 = "Motor_01-09";
            this.plC_Button17.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button17.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button17.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button17.ON_文字內容 = "Motor_01-09";
            this.plC_Button17.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button17.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button17.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button17.Size = new System.Drawing.Size(104, 52);
            this.plC_Button17.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button17.TabIndex = 145;
            this.plC_Button17.事件驅動 = false;
            this.plC_Button17.字型鎖住 = false;
            this.plC_Button17.寫入元件位置 = "M109";
            this.plC_Button17.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button17.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button17.文字鎖住 = false;
            this.plC_Button17.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button17.狀態OFF圖片")));
            this.plC_Button17.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button17.狀態ON圖片")));
            this.plC_Button17.讀取位元反向 = false;
            this.plC_Button17.讀取元件位置 = "M109";
            this.plC_Button17.讀寫鎖住 = false;
            this.plC_Button17.起始狀態 = false;
            this.plC_Button17.音效 = true;
            this.plC_Button17.顯示 = false;
            this.plC_Button17.顯示狀態 = false;
            // 
            // plC_Button19
            // 
            this.plC_Button19.Bool = false;
            this.plC_Button19.but_press = false;
            this.plC_Button19.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button19.Location = new System.Drawing.Point(782, 12);
            this.plC_Button19.Name = "plC_Button19";
            this.plC_Button19.OFF_文字內容 = "Motor_01-08";
            this.plC_Button19.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button19.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button19.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button19.ON_文字內容 = "Motor_01-08";
            this.plC_Button19.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button19.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button19.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button19.Size = new System.Drawing.Size(104, 52);
            this.plC_Button19.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button19.TabIndex = 144;
            this.plC_Button19.事件驅動 = false;
            this.plC_Button19.字型鎖住 = false;
            this.plC_Button19.寫入元件位置 = "M108";
            this.plC_Button19.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button19.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button19.文字鎖住 = false;
            this.plC_Button19.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button19.狀態OFF圖片")));
            this.plC_Button19.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button19.狀態ON圖片")));
            this.plC_Button19.讀取位元反向 = false;
            this.plC_Button19.讀取元件位置 = "M108";
            this.plC_Button19.讀寫鎖住 = false;
            this.plC_Button19.起始狀態 = false;
            this.plC_Button19.音效 = true;
            this.plC_Button19.顯示 = false;
            this.plC_Button19.顯示狀態 = false;
            // 
            // plC_Button21
            // 
            this.plC_Button21.Bool = false;
            this.plC_Button21.but_press = false;
            this.plC_Button21.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button21.Location = new System.Drawing.Point(672, 12);
            this.plC_Button21.Name = "plC_Button21";
            this.plC_Button21.OFF_文字內容 = "Motor_01-07";
            this.plC_Button21.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button21.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button21.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button21.ON_文字內容 = "Motor_01-07";
            this.plC_Button21.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button21.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button21.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button21.Size = new System.Drawing.Size(104, 52);
            this.plC_Button21.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button21.TabIndex = 143;
            this.plC_Button21.事件驅動 = false;
            this.plC_Button21.字型鎖住 = false;
            this.plC_Button21.寫入元件位置 = "M107";
            this.plC_Button21.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button21.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button21.文字鎖住 = false;
            this.plC_Button21.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button21.狀態OFF圖片")));
            this.plC_Button21.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button21.狀態ON圖片")));
            this.plC_Button21.讀取位元反向 = false;
            this.plC_Button21.讀取元件位置 = "M107";
            this.plC_Button21.讀寫鎖住 = false;
            this.plC_Button21.起始狀態 = false;
            this.plC_Button21.音效 = true;
            this.plC_Button21.顯示 = false;
            this.plC_Button21.顯示狀態 = false;
            // 
            // plC_Button11
            // 
            this.plC_Button11.Bool = false;
            this.plC_Button11.but_press = false;
            this.plC_Button11.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button11.Location = new System.Drawing.Point(562, 12);
            this.plC_Button11.Name = "plC_Button11";
            this.plC_Button11.OFF_文字內容 = "Motor_01-06";
            this.plC_Button11.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button11.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button11.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button11.ON_文字內容 = "Motor_01-06";
            this.plC_Button11.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button11.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button11.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button11.Size = new System.Drawing.Size(104, 52);
            this.plC_Button11.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button11.TabIndex = 142;
            this.plC_Button11.事件驅動 = false;
            this.plC_Button11.字型鎖住 = false;
            this.plC_Button11.寫入元件位置 = "M106";
            this.plC_Button11.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button11.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button11.文字鎖住 = false;
            this.plC_Button11.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button11.狀態OFF圖片")));
            this.plC_Button11.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button11.狀態ON圖片")));
            this.plC_Button11.讀取位元反向 = false;
            this.plC_Button11.讀取元件位置 = "M106";
            this.plC_Button11.讀寫鎖住 = false;
            this.plC_Button11.起始狀態 = false;
            this.plC_Button11.音效 = true;
            this.plC_Button11.顯示 = false;
            this.plC_Button11.顯示狀態 = false;
            // 
            // plC_Button9
            // 
            this.plC_Button9.Bool = false;
            this.plC_Button9.but_press = false;
            this.plC_Button9.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button9.Location = new System.Drawing.Point(452, 12);
            this.plC_Button9.Name = "plC_Button9";
            this.plC_Button9.OFF_文字內容 = "Motor_01-05";
            this.plC_Button9.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button9.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button9.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button9.ON_文字內容 = "Motor_01-05";
            this.plC_Button9.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button9.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button9.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button9.Size = new System.Drawing.Size(104, 52);
            this.plC_Button9.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button9.TabIndex = 141;
            this.plC_Button9.事件驅動 = false;
            this.plC_Button9.字型鎖住 = false;
            this.plC_Button9.寫入元件位置 = "M105";
            this.plC_Button9.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button9.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button9.文字鎖住 = false;
            this.plC_Button9.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button9.狀態OFF圖片")));
            this.plC_Button9.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button9.狀態ON圖片")));
            this.plC_Button9.讀取位元反向 = false;
            this.plC_Button9.讀取元件位置 = "M105";
            this.plC_Button9.讀寫鎖住 = false;
            this.plC_Button9.起始狀態 = false;
            this.plC_Button9.音效 = true;
            this.plC_Button9.顯示 = false;
            this.plC_Button9.顯示狀態 = false;
            // 
            // plC_Button7
            // 
            this.plC_Button7.Bool = false;
            this.plC_Button7.but_press = false;
            this.plC_Button7.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button7.Location = new System.Drawing.Point(342, 12);
            this.plC_Button7.Name = "plC_Button7";
            this.plC_Button7.OFF_文字內容 = "Motor_01-04";
            this.plC_Button7.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button7.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button7.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button7.ON_文字內容 = "Motor_01-04";
            this.plC_Button7.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button7.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button7.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button7.Size = new System.Drawing.Size(104, 52);
            this.plC_Button7.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button7.TabIndex = 140;
            this.plC_Button7.事件驅動 = false;
            this.plC_Button7.字型鎖住 = false;
            this.plC_Button7.寫入元件位置 = "M104";
            this.plC_Button7.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button7.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button7.文字鎖住 = false;
            this.plC_Button7.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button7.狀態OFF圖片")));
            this.plC_Button7.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button7.狀態ON圖片")));
            this.plC_Button7.讀取位元反向 = false;
            this.plC_Button7.讀取元件位置 = "M104";
            this.plC_Button7.讀寫鎖住 = false;
            this.plC_Button7.起始狀態 = false;
            this.plC_Button7.音效 = true;
            this.plC_Button7.顯示 = false;
            this.plC_Button7.顯示狀態 = false;
            // 
            // plC_Button5
            // 
            this.plC_Button5.Bool = false;
            this.plC_Button5.but_press = false;
            this.plC_Button5.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button5.Location = new System.Drawing.Point(232, 12);
            this.plC_Button5.Name = "plC_Button5";
            this.plC_Button5.OFF_文字內容 = "Motor_01-03";
            this.plC_Button5.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button5.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button5.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button5.ON_文字內容 = "Motor_01-03";
            this.plC_Button5.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button5.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button5.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button5.Size = new System.Drawing.Size(104, 52);
            this.plC_Button5.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button5.TabIndex = 139;
            this.plC_Button5.事件驅動 = false;
            this.plC_Button5.字型鎖住 = false;
            this.plC_Button5.寫入元件位置 = "M103";
            this.plC_Button5.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button5.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button5.文字鎖住 = false;
            this.plC_Button5.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button5.狀態OFF圖片")));
            this.plC_Button5.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button5.狀態ON圖片")));
            this.plC_Button5.讀取位元反向 = false;
            this.plC_Button5.讀取元件位置 = "M103";
            this.plC_Button5.讀寫鎖住 = false;
            this.plC_Button5.起始狀態 = false;
            this.plC_Button5.音效 = true;
            this.plC_Button5.顯示 = false;
            this.plC_Button5.顯示狀態 = false;
            // 
            // plC_Button3
            // 
            this.plC_Button3.Bool = false;
            this.plC_Button3.but_press = false;
            this.plC_Button3.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button3.Location = new System.Drawing.Point(122, 12);
            this.plC_Button3.Name = "plC_Button3";
            this.plC_Button3.OFF_文字內容 = "Motor_01-02";
            this.plC_Button3.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button3.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button3.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button3.ON_文字內容 = "Motor_01-02";
            this.plC_Button3.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button3.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button3.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button3.Size = new System.Drawing.Size(104, 52);
            this.plC_Button3.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button3.TabIndex = 138;
            this.plC_Button3.事件驅動 = false;
            this.plC_Button3.字型鎖住 = false;
            this.plC_Button3.寫入元件位置 = "M102";
            this.plC_Button3.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button3.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button3.文字鎖住 = false;
            this.plC_Button3.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button3.狀態OFF圖片")));
            this.plC_Button3.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button3.狀態ON圖片")));
            this.plC_Button3.讀取位元反向 = false;
            this.plC_Button3.讀取元件位置 = "M102";
            this.plC_Button3.讀寫鎖住 = false;
            this.plC_Button3.起始狀態 = false;
            this.plC_Button3.音效 = true;
            this.plC_Button3.顯示 = false;
            this.plC_Button3.顯示狀態 = false;
            // 
            // plC_Button2
            // 
            this.plC_Button2.Bool = false;
            this.plC_Button2.but_press = false;
            this.plC_Button2.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button2.Location = new System.Drawing.Point(12, 12);
            this.plC_Button2.Name = "plC_Button2";
            this.plC_Button2.OFF_文字內容 = "Motor_01-01";
            this.plC_Button2.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button2.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button2.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button2.ON_文字內容 = "Motor_01-01";
            this.plC_Button2.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button2.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button2.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button2.Size = new System.Drawing.Size(104, 52);
            this.plC_Button2.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button2.TabIndex = 137;
            this.plC_Button2.事件驅動 = false;
            this.plC_Button2.字型鎖住 = false;
            this.plC_Button2.寫入元件位置 = "M101";
            this.plC_Button2.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button2.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button2.文字鎖住 = false;
            this.plC_Button2.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button2.狀態OFF圖片")));
            this.plC_Button2.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button2.狀態ON圖片")));
            this.plC_Button2.讀取位元反向 = false;
            this.plC_Button2.讀取元件位置 = "M101";
            this.plC_Button2.讀寫鎖住 = false;
            this.plC_Button2.起始狀態 = false;
            this.plC_Button2.音效 = true;
            this.plC_Button2.顯示 = false;
            this.plC_Button2.顯示狀態 = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.plC_Button28);
            this.panel1.Controls.Add(this.plC_Button26);
            this.panel1.Controls.Add(this.plC_Button24);
            this.panel1.Controls.Add(this.plC_Button14);
            this.panel1.Controls.Add(this.plC_Button16);
            this.panel1.Controls.Add(this.plC_Button18);
            this.panel1.Controls.Add(this.plC_Button20);
            this.panel1.Controls.Add(this.plC_Button22);
            this.panel1.Controls.Add(this.plC_Button12);
            this.panel1.Controls.Add(this.plC_Button10);
            this.panel1.Controls.Add(this.plC_Button8);
            this.panel1.Controls.Add(this.plC_Button6);
            this.panel1.Controls.Add(this.plC_Button4);
            this.panel1.Controls.Add(this.plC_Button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 913);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1638, 73);
            this.panel1.TabIndex = 81;
            // 
            // plC_Button28
            // 
            this.plC_Button28.Bool = false;
            this.plC_Button28.but_press = false;
            this.plC_Button28.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button28.Location = new System.Drawing.Point(1442, 11);
            this.plC_Button28.Name = "plC_Button28";
            this.plC_Button28.OFF_文字內容 = "LED_01-14";
            this.plC_Button28.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button28.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button28.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button28.ON_文字內容 = "LED_01-14";
            this.plC_Button28.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button28.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button28.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button28.Size = new System.Drawing.Size(104, 52);
            this.plC_Button28.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button28.TabIndex = 135;
            this.plC_Button28.事件驅動 = false;
            this.plC_Button28.字型鎖住 = false;
            this.plC_Button28.寫入元件位置 = "M1114";
            this.plC_Button28.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button28.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button28.文字鎖住 = false;
            this.plC_Button28.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button28.狀態OFF圖片")));
            this.plC_Button28.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button28.狀態ON圖片")));
            this.plC_Button28.讀取位元反向 = false;
            this.plC_Button28.讀取元件位置 = "M1114";
            this.plC_Button28.讀寫鎖住 = false;
            this.plC_Button28.起始狀態 = false;
            this.plC_Button28.音效 = true;
            this.plC_Button28.顯示 = false;
            this.plC_Button28.顯示狀態 = false;
            // 
            // plC_Button26
            // 
            this.plC_Button26.Bool = false;
            this.plC_Button26.but_press = false;
            this.plC_Button26.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button26.Location = new System.Drawing.Point(1332, 11);
            this.plC_Button26.Name = "plC_Button26";
            this.plC_Button26.OFF_文字內容 = "LED_01-13";
            this.plC_Button26.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button26.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button26.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button26.ON_文字內容 = "LED_01-13";
            this.plC_Button26.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button26.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button26.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button26.Size = new System.Drawing.Size(104, 52);
            this.plC_Button26.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button26.TabIndex = 133;
            this.plC_Button26.事件驅動 = false;
            this.plC_Button26.字型鎖住 = false;
            this.plC_Button26.寫入元件位置 = "M1113";
            this.plC_Button26.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button26.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button26.文字鎖住 = false;
            this.plC_Button26.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button26.狀態OFF圖片")));
            this.plC_Button26.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button26.狀態ON圖片")));
            this.plC_Button26.讀取位元反向 = false;
            this.plC_Button26.讀取元件位置 = "M1113";
            this.plC_Button26.讀寫鎖住 = false;
            this.plC_Button26.起始狀態 = false;
            this.plC_Button26.音效 = true;
            this.plC_Button26.顯示 = false;
            this.plC_Button26.顯示狀態 = false;
            // 
            // plC_Button24
            // 
            this.plC_Button24.Bool = false;
            this.plC_Button24.but_press = false;
            this.plC_Button24.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button24.Location = new System.Drawing.Point(1222, 11);
            this.plC_Button24.Name = "plC_Button24";
            this.plC_Button24.OFF_文字內容 = "LED_01-12";
            this.plC_Button24.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button24.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button24.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button24.ON_文字內容 = "LED_01-12";
            this.plC_Button24.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button24.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button24.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button24.Size = new System.Drawing.Size(104, 52);
            this.plC_Button24.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button24.TabIndex = 131;
            this.plC_Button24.事件驅動 = false;
            this.plC_Button24.字型鎖住 = false;
            this.plC_Button24.寫入元件位置 = "M1112";
            this.plC_Button24.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button24.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button24.文字鎖住 = false;
            this.plC_Button24.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button24.狀態OFF圖片")));
            this.plC_Button24.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button24.狀態ON圖片")));
            this.plC_Button24.讀取位元反向 = false;
            this.plC_Button24.讀取元件位置 = "M1112";
            this.plC_Button24.讀寫鎖住 = false;
            this.plC_Button24.起始狀態 = false;
            this.plC_Button24.音效 = true;
            this.plC_Button24.顯示 = false;
            this.plC_Button24.顯示狀態 = false;
            // 
            // plC_Button14
            // 
            this.plC_Button14.Bool = false;
            this.plC_Button14.but_press = false;
            this.plC_Button14.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button14.Location = new System.Drawing.Point(1112, 11);
            this.plC_Button14.Name = "plC_Button14";
            this.plC_Button14.OFF_文字內容 = "LED_01-11";
            this.plC_Button14.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button14.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button14.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button14.ON_文字內容 = "LED_01-11";
            this.plC_Button14.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button14.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button14.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button14.Size = new System.Drawing.Size(104, 52);
            this.plC_Button14.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button14.TabIndex = 129;
            this.plC_Button14.事件驅動 = false;
            this.plC_Button14.字型鎖住 = false;
            this.plC_Button14.寫入元件位置 = "M1111";
            this.plC_Button14.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button14.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button14.文字鎖住 = false;
            this.plC_Button14.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button14.狀態OFF圖片")));
            this.plC_Button14.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button14.狀態ON圖片")));
            this.plC_Button14.讀取位元反向 = false;
            this.plC_Button14.讀取元件位置 = "M1111";
            this.plC_Button14.讀寫鎖住 = false;
            this.plC_Button14.起始狀態 = false;
            this.plC_Button14.音效 = true;
            this.plC_Button14.顯示 = false;
            this.plC_Button14.顯示狀態 = false;
            // 
            // plC_Button16
            // 
            this.plC_Button16.Bool = false;
            this.plC_Button16.but_press = false;
            this.plC_Button16.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button16.Location = new System.Drawing.Point(1002, 11);
            this.plC_Button16.Name = "plC_Button16";
            this.plC_Button16.OFF_文字內容 = "LED_01-10";
            this.plC_Button16.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button16.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button16.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button16.ON_文字內容 = "LED_01-10";
            this.plC_Button16.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button16.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button16.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button16.Size = new System.Drawing.Size(104, 52);
            this.plC_Button16.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button16.TabIndex = 127;
            this.plC_Button16.事件驅動 = false;
            this.plC_Button16.字型鎖住 = false;
            this.plC_Button16.寫入元件位置 = "M1110";
            this.plC_Button16.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button16.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button16.文字鎖住 = false;
            this.plC_Button16.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button16.狀態OFF圖片")));
            this.plC_Button16.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button16.狀態ON圖片")));
            this.plC_Button16.讀取位元反向 = false;
            this.plC_Button16.讀取元件位置 = "M1110";
            this.plC_Button16.讀寫鎖住 = false;
            this.plC_Button16.起始狀態 = false;
            this.plC_Button16.音效 = true;
            this.plC_Button16.顯示 = false;
            this.plC_Button16.顯示狀態 = false;
            // 
            // plC_Button18
            // 
            this.plC_Button18.Bool = false;
            this.plC_Button18.but_press = false;
            this.plC_Button18.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button18.Location = new System.Drawing.Point(892, 11);
            this.plC_Button18.Name = "plC_Button18";
            this.plC_Button18.OFF_文字內容 = "LED_01-09";
            this.plC_Button18.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button18.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button18.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button18.ON_文字內容 = "LED_01-09";
            this.plC_Button18.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button18.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button18.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button18.Size = new System.Drawing.Size(104, 52);
            this.plC_Button18.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button18.TabIndex = 125;
            this.plC_Button18.事件驅動 = false;
            this.plC_Button18.字型鎖住 = false;
            this.plC_Button18.寫入元件位置 = "M1109";
            this.plC_Button18.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button18.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button18.文字鎖住 = false;
            this.plC_Button18.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button18.狀態OFF圖片")));
            this.plC_Button18.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button18.狀態ON圖片")));
            this.plC_Button18.讀取位元反向 = false;
            this.plC_Button18.讀取元件位置 = "M1109";
            this.plC_Button18.讀寫鎖住 = false;
            this.plC_Button18.起始狀態 = false;
            this.plC_Button18.音效 = true;
            this.plC_Button18.顯示 = false;
            this.plC_Button18.顯示狀態 = false;
            // 
            // plC_Button20
            // 
            this.plC_Button20.Bool = false;
            this.plC_Button20.but_press = false;
            this.plC_Button20.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button20.Location = new System.Drawing.Point(782, 11);
            this.plC_Button20.Name = "plC_Button20";
            this.plC_Button20.OFF_文字內容 = "LED_01-08";
            this.plC_Button20.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button20.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button20.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button20.ON_文字內容 = "LED_01-08";
            this.plC_Button20.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button20.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button20.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button20.Size = new System.Drawing.Size(104, 52);
            this.plC_Button20.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button20.TabIndex = 123;
            this.plC_Button20.事件驅動 = false;
            this.plC_Button20.字型鎖住 = false;
            this.plC_Button20.寫入元件位置 = "M1108";
            this.plC_Button20.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button20.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button20.文字鎖住 = false;
            this.plC_Button20.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button20.狀態OFF圖片")));
            this.plC_Button20.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button20.狀態ON圖片")));
            this.plC_Button20.讀取位元反向 = false;
            this.plC_Button20.讀取元件位置 = "M1108";
            this.plC_Button20.讀寫鎖住 = false;
            this.plC_Button20.起始狀態 = false;
            this.plC_Button20.音效 = true;
            this.plC_Button20.顯示 = false;
            this.plC_Button20.顯示狀態 = false;
            // 
            // plC_Button22
            // 
            this.plC_Button22.Bool = false;
            this.plC_Button22.but_press = false;
            this.plC_Button22.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button22.Location = new System.Drawing.Point(672, 11);
            this.plC_Button22.Name = "plC_Button22";
            this.plC_Button22.OFF_文字內容 = "LED_01-07";
            this.plC_Button22.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button22.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button22.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button22.ON_文字內容 = "LED_01-07";
            this.plC_Button22.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button22.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button22.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button22.Size = new System.Drawing.Size(104, 52);
            this.plC_Button22.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button22.TabIndex = 121;
            this.plC_Button22.事件驅動 = false;
            this.plC_Button22.字型鎖住 = false;
            this.plC_Button22.寫入元件位置 = "M1107";
            this.plC_Button22.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button22.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button22.文字鎖住 = false;
            this.plC_Button22.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button22.狀態OFF圖片")));
            this.plC_Button22.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button22.狀態ON圖片")));
            this.plC_Button22.讀取位元反向 = false;
            this.plC_Button22.讀取元件位置 = "M1107";
            this.plC_Button22.讀寫鎖住 = false;
            this.plC_Button22.起始狀態 = false;
            this.plC_Button22.音效 = true;
            this.plC_Button22.顯示 = false;
            this.plC_Button22.顯示狀態 = false;
            // 
            // plC_Button12
            // 
            this.plC_Button12.Bool = false;
            this.plC_Button12.but_press = false;
            this.plC_Button12.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button12.Location = new System.Drawing.Point(562, 11);
            this.plC_Button12.Name = "plC_Button12";
            this.plC_Button12.OFF_文字內容 = "LED_01-06";
            this.plC_Button12.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button12.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button12.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button12.ON_文字內容 = "LED_01-06";
            this.plC_Button12.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button12.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button12.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button12.Size = new System.Drawing.Size(104, 52);
            this.plC_Button12.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button12.TabIndex = 119;
            this.plC_Button12.事件驅動 = false;
            this.plC_Button12.字型鎖住 = false;
            this.plC_Button12.寫入元件位置 = "M1106";
            this.plC_Button12.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button12.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button12.文字鎖住 = false;
            this.plC_Button12.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button12.狀態OFF圖片")));
            this.plC_Button12.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button12.狀態ON圖片")));
            this.plC_Button12.讀取位元反向 = false;
            this.plC_Button12.讀取元件位置 = "M1106";
            this.plC_Button12.讀寫鎖住 = false;
            this.plC_Button12.起始狀態 = false;
            this.plC_Button12.音效 = true;
            this.plC_Button12.顯示 = false;
            this.plC_Button12.顯示狀態 = false;
            // 
            // plC_Button10
            // 
            this.plC_Button10.Bool = false;
            this.plC_Button10.but_press = false;
            this.plC_Button10.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button10.Location = new System.Drawing.Point(452, 11);
            this.plC_Button10.Name = "plC_Button10";
            this.plC_Button10.OFF_文字內容 = "LED_01-05";
            this.plC_Button10.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button10.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button10.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button10.ON_文字內容 = "LED_01-05";
            this.plC_Button10.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button10.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button10.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button10.Size = new System.Drawing.Size(104, 52);
            this.plC_Button10.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button10.TabIndex = 117;
            this.plC_Button10.事件驅動 = false;
            this.plC_Button10.字型鎖住 = false;
            this.plC_Button10.寫入元件位置 = "M1105";
            this.plC_Button10.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button10.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button10.文字鎖住 = false;
            this.plC_Button10.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button10.狀態OFF圖片")));
            this.plC_Button10.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button10.狀態ON圖片")));
            this.plC_Button10.讀取位元反向 = false;
            this.plC_Button10.讀取元件位置 = "M1105";
            this.plC_Button10.讀寫鎖住 = false;
            this.plC_Button10.起始狀態 = false;
            this.plC_Button10.音效 = true;
            this.plC_Button10.顯示 = false;
            this.plC_Button10.顯示狀態 = false;
            // 
            // plC_Button8
            // 
            this.plC_Button8.Bool = false;
            this.plC_Button8.but_press = false;
            this.plC_Button8.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button8.Location = new System.Drawing.Point(342, 11);
            this.plC_Button8.Name = "plC_Button8";
            this.plC_Button8.OFF_文字內容 = "LED_01-04";
            this.plC_Button8.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button8.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button8.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button8.ON_文字內容 = "LED_01-04";
            this.plC_Button8.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button8.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button8.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button8.Size = new System.Drawing.Size(104, 52);
            this.plC_Button8.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button8.TabIndex = 115;
            this.plC_Button8.事件驅動 = false;
            this.plC_Button8.字型鎖住 = false;
            this.plC_Button8.寫入元件位置 = "M1104";
            this.plC_Button8.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button8.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button8.文字鎖住 = false;
            this.plC_Button8.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button8.狀態OFF圖片")));
            this.plC_Button8.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button8.狀態ON圖片")));
            this.plC_Button8.讀取位元反向 = false;
            this.plC_Button8.讀取元件位置 = "M1104";
            this.plC_Button8.讀寫鎖住 = false;
            this.plC_Button8.起始狀態 = false;
            this.plC_Button8.音效 = true;
            this.plC_Button8.顯示 = false;
            this.plC_Button8.顯示狀態 = false;
            // 
            // plC_Button6
            // 
            this.plC_Button6.Bool = false;
            this.plC_Button6.but_press = false;
            this.plC_Button6.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button6.Location = new System.Drawing.Point(232, 11);
            this.plC_Button6.Name = "plC_Button6";
            this.plC_Button6.OFF_文字內容 = "LED_01-03";
            this.plC_Button6.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button6.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button6.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button6.ON_文字內容 = "LED_01-03";
            this.plC_Button6.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button6.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button6.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button6.Size = new System.Drawing.Size(104, 52);
            this.plC_Button6.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button6.TabIndex = 113;
            this.plC_Button6.事件驅動 = false;
            this.plC_Button6.字型鎖住 = false;
            this.plC_Button6.寫入元件位置 = "M1103";
            this.plC_Button6.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button6.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button6.文字鎖住 = false;
            this.plC_Button6.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button6.狀態OFF圖片")));
            this.plC_Button6.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button6.狀態ON圖片")));
            this.plC_Button6.讀取位元反向 = false;
            this.plC_Button6.讀取元件位置 = "M1103";
            this.plC_Button6.讀寫鎖住 = false;
            this.plC_Button6.起始狀態 = false;
            this.plC_Button6.音效 = true;
            this.plC_Button6.顯示 = false;
            this.plC_Button6.顯示狀態 = false;
            // 
            // plC_Button4
            // 
            this.plC_Button4.Bool = false;
            this.plC_Button4.but_press = false;
            this.plC_Button4.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button4.Location = new System.Drawing.Point(122, 11);
            this.plC_Button4.Name = "plC_Button4";
            this.plC_Button4.OFF_文字內容 = "LED_01-02";
            this.plC_Button4.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button4.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button4.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button4.ON_文字內容 = "LED_01-02";
            this.plC_Button4.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button4.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button4.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button4.Size = new System.Drawing.Size(104, 52);
            this.plC_Button4.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button4.TabIndex = 111;
            this.plC_Button4.事件驅動 = false;
            this.plC_Button4.字型鎖住 = false;
            this.plC_Button4.寫入元件位置 = "M1102";
            this.plC_Button4.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button4.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button4.文字鎖住 = false;
            this.plC_Button4.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button4.狀態OFF圖片")));
            this.plC_Button4.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button4.狀態ON圖片")));
            this.plC_Button4.讀取位元反向 = false;
            this.plC_Button4.讀取元件位置 = "M1102";
            this.plC_Button4.讀寫鎖住 = false;
            this.plC_Button4.起始狀態 = false;
            this.plC_Button4.音效 = true;
            this.plC_Button4.顯示 = false;
            this.plC_Button4.顯示狀態 = false;
            // 
            // plC_Button1
            // 
            this.plC_Button1.Bool = false;
            this.plC_Button1.but_press = false;
            this.plC_Button1.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_Button1.Location = new System.Drawing.Point(12, 11);
            this.plC_Button1.Name = "plC_Button1";
            this.plC_Button1.OFF_文字內容 = "LED_01-01";
            this.plC_Button1.OFF_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button1.OFF_文字顏色 = System.Drawing.Color.Black;
            this.plC_Button1.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button1.ON_文字內容 = "LED_01-01";
            this.plC_Button1.ON_文字字體 = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.plC_Button1.ON_文字顏色 = System.Drawing.Color.White;
            this.plC_Button1.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_Button1.Size = new System.Drawing.Size(104, 52);
            this.plC_Button1.Style = MyUI.PLC_Button.StyleEnum.經典;
            this.plC_Button1.TabIndex = 109;
            this.plC_Button1.事件驅動 = false;
            this.plC_Button1.字型鎖住 = false;
            this.plC_Button1.寫入元件位置 = "M1101";
            this.plC_Button1.按鈕型態 = MyUI.PLC_Button.StatusEnum.交替型;
            this.plC_Button1.按鍵方式 = MyUI.PLC_Button.PressEnum.Mouse_左鍵;
            this.plC_Button1.文字鎖住 = false;
            this.plC_Button1.狀態OFF圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button1.狀態OFF圖片")));
            this.plC_Button1.狀態ON圖片 = ((System.Drawing.Image)(resources.GetObject("plC_Button1.狀態ON圖片")));
            this.plC_Button1.讀取位元反向 = false;
            this.plC_Button1.讀取元件位置 = "M1101";
            this.plC_Button1.讀寫鎖住 = false;
            this.plC_Button1.起始狀態 = false;
            this.plC_Button1.音效 = true;
            this.plC_Button1.顯示 = false;
            this.plC_Button1.顯示狀態 = false;
            // 
            // plC_RJ_ScreenButton9
            // 
            this.plC_RJ_ScreenButton9.but_press = false;
            this.plC_RJ_ScreenButton9.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.plC_RJ_ScreenButton9.IconSize = 40;
            this.plC_RJ_ScreenButton9.Location = new System.Drawing.Point(1375, 0);
            this.plC_RJ_ScreenButton9.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton9.Name = "plC_RJ_ScreenButton9";
            this.plC_RJ_ScreenButton9.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton9.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton9.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton9.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton9.OffText = "系統";
            this.plC_RJ_ScreenButton9.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton9.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton9.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton9.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton9.OnText = "系統";
            this.plC_RJ_ScreenButton9.ShowIcon = true;
            this.plC_RJ_ScreenButton9.Size = new System.Drawing.Size(258, 65);
            this.plC_RJ_ScreenButton9.TabIndex = 80;
            this.plC_RJ_ScreenButton9.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton9.寫入位置註解 = "";
            this.plC_RJ_ScreenButton9.寫入元件位置 = "";
            this.plC_RJ_ScreenButton9.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton9.控制位址 = "D0";
            this.plC_RJ_ScreenButton9.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton9.致能讀取位置 = "";
            this.plC_RJ_ScreenButton9.讀取位元反向 = false;
            this.plC_RJ_ScreenButton9.讀取位置註解 = "";
            this.plC_RJ_ScreenButton9.讀取元件位置 = "";
            this.plC_RJ_ScreenButton9.音效 = true;
            this.plC_RJ_ScreenButton9.頁面名稱 = "系統";
            this.plC_RJ_ScreenButton9.頁面編號 = 0;
            this.plC_RJ_ScreenButton9.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton9.顯示狀態 = false;
            this.plC_RJ_ScreenButton9.顯示讀取位置 = "";
            // 
            // 系統
            // 
            this.系統.BackColor = System.Drawing.Color.White;
            this.系統.Controls.Add(this.plC_ScreenPage_系統);
            this.系統.Controls.Add(this.panel_系統);
            this.系統.Location = new System.Drawing.Point(4, 25);
            this.系統.Name = "系統";
            this.系統.Size = new System.Drawing.Size(1638, 986);
            this.系統.TabIndex = 3;
            this.系統.Text = "系統";
            // 
            // plC_ScreenPage_系統
            // 
            this.plC_ScreenPage_系統.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.plC_ScreenPage_系統.BackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_系統.Controls.Add(this.設定01);
            this.plC_ScreenPage_系統.Controls.Add(this.設定02);
            this.plC_ScreenPage_系統.Controls.Add(this.設定03);
            this.plC_ScreenPage_系統.Controls.Add(this.設定04);
            this.plC_ScreenPage_系統.Controls.Add(this.設定05);
            this.plC_ScreenPage_系統.Controls.Add(this.設定06);
            this.plC_ScreenPage_系統.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plC_ScreenPage_系統.ForekColor = System.Drawing.Color.Black;
            this.plC_ScreenPage_系統.ItemSize = new System.Drawing.Size(54, 21);
            this.plC_ScreenPage_系統.Location = new System.Drawing.Point(0, 51);
            this.plC_ScreenPage_系統.Name = "plC_ScreenPage_系統";
            this.plC_ScreenPage_系統.SelectedIndex = 0;
            this.plC_ScreenPage_系統.Size = new System.Drawing.Size(1638, 935);
            this.plC_ScreenPage_系統.TabBackColor = System.Drawing.Color.White;
            this.plC_ScreenPage_系統.TabIndex = 117;
            this.plC_ScreenPage_系統.顯示標籤列 = MyUI.PLC_ScreenPage.TabVisibleEnum.顯示;
            this.plC_ScreenPage_系統.顯示頁面 = 0;
            // 
            // 設定01
            // 
            this.設定01.BackColor = System.Drawing.Color.White;
            this.設定01.Controls.Add(this.groupBox22);
            this.設定01.Controls.Add(this.button_工程模式_調劑台名稱儲存);
            this.設定01.Controls.Add(this.groupBox18);
            this.設定01.Controls.Add(this.plC_UI_Init);
            this.設定01.Controls.Add(this.lowerMachine_Panel);
            this.設定01.Location = new System.Drawing.Point(4, 25);
            this.設定01.Name = "設定01";
            this.設定01.Size = new System.Drawing.Size(1630, 906);
            this.設定01.TabIndex = 0;
            this.設定01.Text = "設定01";
            // 
            // groupBox22
            // 
            this.groupBox22.Controls.Add(this.textBox_工程模式_設備名稱_名稱);
            this.groupBox22.Controls.Add(this.rJ_Lable45);
            this.groupBox22.Location = new System.Drawing.Point(878, 241);
            this.groupBox22.Name = "groupBox22";
            this.groupBox22.Size = new System.Drawing.Size(175, 65);
            this.groupBox22.TabIndex = 47;
            this.groupBox22.TabStop = false;
            this.groupBox22.Text = "設備名稱";
            // 
            // textBox_工程模式_設備名稱_名稱
            // 
            this.textBox_工程模式_設備名稱_名稱.Location = new System.Drawing.Point(82, 31);
            this.textBox_工程模式_設備名稱_名稱.Name = "textBox_工程模式_設備名稱_名稱";
            this.textBox_工程模式_設備名稱_名稱.Size = new System.Drawing.Size(81, 22);
            this.textBox_工程模式_設備名稱_名稱.TabIndex = 0;
            // 
            // rJ_Lable45
            // 
            this.rJ_Lable45.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_Lable45.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.rJ_Lable45.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable45.BorderRadius = 8;
            this.rJ_Lable45.BorderSize = 0;
            this.rJ_Lable45.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable45.ForeColor = System.Drawing.Color.White;
            this.rJ_Lable45.Location = new System.Drawing.Point(6, 29);
            this.rJ_Lable45.Name = "rJ_Lable45";
            this.rJ_Lable45.Size = new System.Drawing.Size(70, 24);
            this.rJ_Lable45.TabIndex = 0;
            this.rJ_Lable45.Text = "名稱";
            this.rJ_Lable45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable45.TextColor = System.Drawing.Color.White;
            // 
            // button_工程模式_調劑台名稱儲存
            // 
            this.button_工程模式_調劑台名稱儲存.Location = new System.Drawing.Point(1059, 241);
            this.button_工程模式_調劑台名稱儲存.Name = "button_工程模式_調劑台名稱儲存";
            this.button_工程模式_調劑台名稱儲存.Size = new System.Drawing.Size(75, 65);
            this.button_工程模式_調劑台名稱儲存.TabIndex = 46;
            this.button_工程模式_調劑台名稱儲存.Text = "儲存";
            this.button_工程模式_調劑台名稱儲存.UseVisualStyleBackColor = true;
            this.button_工程模式_調劑台名稱儲存.Click += new System.EventHandler(this.button_工程模式_調劑台名稱儲存_Click);
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.rfiD_FX600_UI);
            this.groupBox18.Location = new System.Drawing.Point(878, 35);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(398, 200);
            this.groupBox18.TabIndex = 33;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "RFID";
            // 
            // rfiD_FX600_UI
            // 
            this.rfiD_FX600_UI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rfiD_FX600_UI.Location = new System.Drawing.Point(6, 21);
            this.rfiD_FX600_UI.Name = "rfiD_FX600_UI";
            this.rfiD_FX600_UI.Size = new System.Drawing.Size(373, 158);
            this.rfiD_FX600_UI.TabIndex = 25;
            this.rfiD_FX600_UI.從站數量 = 3;
            this.rfiD_FX600_UI.掃描速度 = 1;
            this.rfiD_FX600_UI.是否自動通訊 = true;
            // 
            // plC_UI_Init
            // 
            this.plC_UI_Init.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.plC_UI_Init.Location = new System.Drawing.Point(878, 4);
            this.plC_UI_Init.Name = "plC_UI_Init";
            this.plC_UI_Init.Size = new System.Drawing.Size(72, 25);
            this.plC_UI_Init.TabIndex = 32;
            this.plC_UI_Init.光道視覺元件初始化 = false;
            this.plC_UI_Init.全螢幕顯示 = true;
            this.plC_UI_Init.掃描速度 = 1;
            this.plC_UI_Init.起始畫面標題內容 = "鴻森整合機電有限公司";
            this.plC_UI_Init.起始畫面標題字體 = new System.Drawing.Font("標楷體", 20F, System.Drawing.FontStyle.Bold);
            this.plC_UI_Init.起始畫面背景 = ((System.Drawing.Image)(resources.GetObject("plC_UI_Init.起始畫面背景")));
            this.plC_UI_Init.起始畫面顯示 = false;
            this.plC_UI_Init.邁得威視元件初始化 = false;
            this.plC_UI_Init.開機延遲 = 0;
            this.plC_UI_Init.音效 = false;
            // 
            // lowerMachine_Panel
            // 
            this.lowerMachine_Panel.Location = new System.Drawing.Point(3, 3);
            this.lowerMachine_Panel.Name = "lowerMachine_Panel";
            this.lowerMachine_Panel.Size = new System.Drawing.Size(869, 565);
            this.lowerMachine_Panel.TabIndex = 31;
            this.lowerMachine_Panel.掃描速度 = 1;
            // 
            // 設定02
            // 
            this.設定02.BackColor = System.Drawing.Color.White;
            this.設定02.Controls.Add(this.loginUI);
            this.設定02.Location = new System.Drawing.Point(4, 25);
            this.設定02.Name = "設定02";
            this.設定02.Size = new System.Drawing.Size(1630, 906);
            this.設定02.TabIndex = 1;
            this.設定02.Text = "設定02";
            // 
            // loginUI
            // 
            this.loginUI.Level_num = ((uint)(20u));
            this.loginUI.Location = new System.Drawing.Point(3, 3);
            this.loginUI.Login_data_index_mySqlSslMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.loginUI.Login_data_index_Password = "66437068";
            this.loginUI.Login_data_index_Port = ((uint)(3306u));
            this.loginUI.Login_data_index_Server = "localhost";
            this.loginUI.Login_data_index_UserName = "user";
            this.loginUI.Login_data_mySqlSslMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.loginUI.Login_data_Password = "66437068";
            this.loginUI.Login_data_Port = ((uint)(3306u));
            this.loginUI.Login_data_Server = "localhost";
            this.loginUI.Login_data_UserName = "user";
            this.loginUI.Name = "loginUI";
            this.loginUI.Size = new System.Drawing.Size(861, 641);
            this.loginUI.TabIndex = 1;
            // 
            // 設定03
            // 
            this.設定03.BackColor = System.Drawing.Color.White;
            this.設定03.Controls.Add(this.tabControl2);
            this.設定03.Location = new System.Drawing.Point(4, 25);
            this.設定03.Name = "設定03";
            this.設定03.Size = new System.Drawing.Size(1630, 906);
            this.設定03.TabIndex = 2;
            this.設定03.Text = "設定03";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage7);
            this.tabControl2.Location = new System.Drawing.Point(12, 16);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(844, 556);
            this.tabControl2.TabIndex = 11;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.ioC12801);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(836, 530);
            this.tabPage6.TabIndex = 0;
            this.tabPage6.Text = "0640";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // ioC12801
            // 
            this.ioC12801.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ioC12801.CycleTime = 1;
            this.ioC12801.Location = new System.Drawing.Point(3, 6);
            this.ioC12801.Name = "ioC12801";
            this.ioC12801.Size = new System.Drawing.Size(807, 389);
            this.ioC12801.TabIndex = 0;
            this.ioC12801.設備名稱 = "IOC1280-001";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(836, 530);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "PCI_9016";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.c12301);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(836, 530);
            this.tabPage7.TabIndex = 1;
            this.tabPage7.Text = "PCI_1232";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // c12301
            // 
            this.c12301.CycleTime = 1;
            this.c12301.Location = new System.Drawing.Point(-4, 3);
            this.c12301.Name = "c12301";
            this.c12301.Size = new System.Drawing.Size(510, 361);
            this.c12301.TabIndex = 0;
            this.c12301.設備名稱 = "C1230-001";
            // 
            // 設定04
            // 
            this.設定04.BackColor = System.Drawing.Color.White;
            this.設定04.Controls.Add(this.rowsLEDUI);
            this.設定04.Location = new System.Drawing.Point(4, 25);
            this.設定04.Name = "設定04";
            this.設定04.Size = new System.Drawing.Size(1630, 906);
            this.設定04.TabIndex = 3;
            this.設定04.Text = "設定04";
            // 
            // rowsLEDUI
            // 
            this.rowsLEDUI.DataBaseName = "TEST";
            this.rowsLEDUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rowsLEDUI.IP = "localhost";
            this.rowsLEDUI.Location = new System.Drawing.Point(0, 0);
            this.rowsLEDUI.Name = "rowsLEDUI";
            this.rowsLEDUI.Password = "user82822040";
            this.rowsLEDUI.Port = ((uint)(3306u));
            this.rowsLEDUI.Size = new System.Drawing.Size(1630, 906);
            this.rowsLEDUI.TabIndex = 0;
            this.rowsLEDUI.TableName = "RowsLED_Jsonstring";
            this.rowsLEDUI.UDP_LocalPorts = ((System.Collections.Generic.List<string>)(resources.GetObject("rowsLEDUI.UDP_LocalPorts")));
            this.rowsLEDUI.UDP_ServerPorts = ((System.Collections.Generic.List<string>)(resources.GetObject("rowsLEDUI.UDP_ServerPorts")));
            this.rowsLEDUI.UserName = "root";
            // 
            // 設定05
            // 
            this.設定05.BackColor = System.Drawing.Color.White;
            this.設定05.Controls.Add(this.groupBox27);
            this.設定05.Controls.Add(this.groupBox44);
            this.設定05.Location = new System.Drawing.Point(4, 25);
            this.設定05.Name = "設定05";
            this.設定05.Size = new System.Drawing.Size(1630, 906);
            this.設定05.TabIndex = 4;
            this.設定05.Text = "設定05";
            // 
            // groupBox27
            // 
            this.groupBox27.Controls.Add(this.sqL_DataGridView_取藥堆疊子資料);
            this.groupBox27.Location = new System.Drawing.Point(809, 3);
            this.groupBox27.Name = "groupBox27";
            this.groupBox27.Size = new System.Drawing.Size(800, 289);
            this.groupBox27.TabIndex = 37;
            this.groupBox27.TabStop = false;
            this.groupBox27.Text = "取藥堆疊子資料";
            // 
            // sqL_DataGridView_取藥堆疊子資料
            // 
            this.sqL_DataGridView_取藥堆疊子資料.AutoSelectToDeep = false;
            this.sqL_DataGridView_取藥堆疊子資料.backColor = System.Drawing.SystemColors.Control;
            this.sqL_DataGridView_取藥堆疊子資料.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_取藥堆疊子資料.BorderRadius = 10;
            this.sqL_DataGridView_取藥堆疊子資料.BorderSize = 2;
            this.sqL_DataGridView_取藥堆疊子資料.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_取藥堆疊子資料.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_取藥堆疊子資料.cellStyleFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_取藥堆疊子資料.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_取藥堆疊子資料.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_取藥堆疊子資料.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_取藥堆疊子資料.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_取藥堆疊子資料.columnHeadersHeight = 21;
            this.sqL_DataGridView_取藥堆疊子資料.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns1"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns2"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns3"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns4"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns5"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns6"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns7"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns8"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns9"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns10"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns11"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns12"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns13"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns14"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns15"))));
            this.sqL_DataGridView_取藥堆疊子資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊子資料.Columns16"))));
            this.sqL_DataGridView_取藥堆疊子資料.DataBaseName = "Dispensing_000";
            this.sqL_DataGridView_取藥堆疊子資料.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqL_DataGridView_取藥堆疊子資料.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_取藥堆疊子資料.ImageBox = false;
            this.sqL_DataGridView_取藥堆疊子資料.Location = new System.Drawing.Point(3, 18);
            this.sqL_DataGridView_取藥堆疊子資料.Name = "sqL_DataGridView_取藥堆疊子資料";
            this.sqL_DataGridView_取藥堆疊子資料.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_取藥堆疊子資料.Password = "user82822040";
            this.sqL_DataGridView_取藥堆疊子資料.Port = ((uint)(3306u));
            this.sqL_DataGridView_取藥堆疊子資料.rowHeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.sqL_DataGridView_取藥堆疊子資料.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_取藥堆疊子資料.RowsColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqL_DataGridView_取藥堆疊子資料.RowsHeight = 20;
            this.sqL_DataGridView_取藥堆疊子資料.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_取藥堆疊子資料.Server = "localhost";
            this.sqL_DataGridView_取藥堆疊子資料.Size = new System.Drawing.Size(794, 268);
            this.sqL_DataGridView_取藥堆疊子資料.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_取藥堆疊子資料.TabIndex = 26;
            this.sqL_DataGridView_取藥堆疊子資料.TableName = "take_medicine_substack_new";
            this.sqL_DataGridView_取藥堆疊子資料.UserName = "root";
            this.sqL_DataGridView_取藥堆疊子資料.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_取藥堆疊子資料.可選擇多列 = false;
            this.sqL_DataGridView_取藥堆疊子資料.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_取藥堆疊子資料.自動換行 = true;
            this.sqL_DataGridView_取藥堆疊子資料.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_取藥堆疊子資料.邊框樣式 = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sqL_DataGridView_取藥堆疊子資料.顯示CheckBox = false;
            this.sqL_DataGridView_取藥堆疊子資料.顯示首列 = false;
            this.sqL_DataGridView_取藥堆疊子資料.顯示首行 = true;
            this.sqL_DataGridView_取藥堆疊子資料.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_取藥堆疊子資料.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            // 
            // groupBox44
            // 
            this.groupBox44.Controls.Add(this.sqL_DataGridView_取藥堆疊母資料);
            this.groupBox44.Location = new System.Drawing.Point(3, 3);
            this.groupBox44.Name = "groupBox44";
            this.groupBox44.Size = new System.Drawing.Size(800, 289);
            this.groupBox44.TabIndex = 36;
            this.groupBox44.TabStop = false;
            this.groupBox44.Text = "取藥堆疊母資料";
            // 
            // sqL_DataGridView_取藥堆疊母資料
            // 
            this.sqL_DataGridView_取藥堆疊母資料.AutoSelectToDeep = false;
            this.sqL_DataGridView_取藥堆疊母資料.backColor = System.Drawing.SystemColors.Control;
            this.sqL_DataGridView_取藥堆疊母資料.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_取藥堆疊母資料.BorderRadius = 10;
            this.sqL_DataGridView_取藥堆疊母資料.BorderSize = 2;
            this.sqL_DataGridView_取藥堆疊母資料.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_取藥堆疊母資料.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_取藥堆疊母資料.cellStyleFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_取藥堆疊母資料.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_取藥堆疊母資料.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_取藥堆疊母資料.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_取藥堆疊母資料.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_取藥堆疊母資料.columnHeadersHeight = 21;
            this.sqL_DataGridView_取藥堆疊母資料.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns1"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns2"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns3"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns4"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns5"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns6"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns7"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns8"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns9"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns10"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns11"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns12"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns13"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns14"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns15"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns16"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns17"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns18"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns19"))));
            this.sqL_DataGridView_取藥堆疊母資料.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_取藥堆疊母資料.Columns20"))));
            this.sqL_DataGridView_取藥堆疊母資料.DataBaseName = "Dispensing_000";
            this.sqL_DataGridView_取藥堆疊母資料.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqL_DataGridView_取藥堆疊母資料.Font = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_取藥堆疊母資料.ImageBox = false;
            this.sqL_DataGridView_取藥堆疊母資料.Location = new System.Drawing.Point(3, 18);
            this.sqL_DataGridView_取藥堆疊母資料.Name = "sqL_DataGridView_取藥堆疊母資料";
            this.sqL_DataGridView_取藥堆疊母資料.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_取藥堆疊母資料.Password = "user82822040";
            this.sqL_DataGridView_取藥堆疊母資料.Port = ((uint)(3306u));
            this.sqL_DataGridView_取藥堆疊母資料.rowHeaderBackColor = System.Drawing.Color.CornflowerBlue;
            this.sqL_DataGridView_取藥堆疊母資料.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_取藥堆疊母資料.RowsColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqL_DataGridView_取藥堆疊母資料.RowsHeight = 20;
            this.sqL_DataGridView_取藥堆疊母資料.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_取藥堆疊母資料.Server = "localhost";
            this.sqL_DataGridView_取藥堆疊母資料.Size = new System.Drawing.Size(794, 268);
            this.sqL_DataGridView_取藥堆疊母資料.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_取藥堆疊母資料.TabIndex = 26;
            this.sqL_DataGridView_取藥堆疊母資料.TableName = "take_medicine_stack_new";
            this.sqL_DataGridView_取藥堆疊母資料.UserName = "root";
            this.sqL_DataGridView_取藥堆疊母資料.可拖曳欄位寬度 = false;
            this.sqL_DataGridView_取藥堆疊母資料.可選擇多列 = false;
            this.sqL_DataGridView_取藥堆疊母資料.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.sqL_DataGridView_取藥堆疊母資料.自動換行 = true;
            this.sqL_DataGridView_取藥堆疊母資料.表單字體 = new System.Drawing.Font("新細明體", 9F);
            this.sqL_DataGridView_取藥堆疊母資料.邊框樣式 = System.Windows.Forms.BorderStyle.Fixed3D;
            this.sqL_DataGridView_取藥堆疊母資料.顯示CheckBox = false;
            this.sqL_DataGridView_取藥堆疊母資料.顯示首列 = false;
            this.sqL_DataGridView_取藥堆疊母資料.顯示首行 = true;
            this.sqL_DataGridView_取藥堆疊母資料.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            this.sqL_DataGridView_取藥堆疊母資料.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.Raised;
            // 
            // 設定06
            // 
            this.設定06.BackColor = System.Drawing.Color.White;
            this.設定06.Controls.Add(this.plC_RJ_GroupBox1);
            this.設定06.Location = new System.Drawing.Point(4, 25);
            this.設定06.Name = "設定06";
            this.設定06.Size = new System.Drawing.Size(1630, 906);
            this.設定06.TabIndex = 5;
            this.設定06.Text = "設定06";
            // 
            // plC_RJ_GroupBox1
            // 
            // 
            // plC_RJ_GroupBox1.ContentsPanel
            // 
            this.plC_RJ_GroupBox1.ContentsPanel.BackColor = System.Drawing.Color.White;
            this.plC_RJ_GroupBox1.ContentsPanel.BorderColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_GroupBox1.ContentsPanel.BorderRadius = 5;
            this.plC_RJ_GroupBox1.ContentsPanel.BorderSize = 2;
            this.plC_RJ_GroupBox1.ContentsPanel.Controls.Add(this.plC_RJ_Button_雲端藥檔_取得資料);
            this.plC_RJ_GroupBox1.ContentsPanel.Controls.Add(this.sqL_DataGridView_雲端藥檔);
            this.plC_RJ_GroupBox1.ContentsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plC_RJ_GroupBox1.ContentsPanel.ForeColor = System.Drawing.Color.White;
            this.plC_RJ_GroupBox1.ContentsPanel.IsSelected = false;
            this.plC_RJ_GroupBox1.ContentsPanel.Location = new System.Drawing.Point(0, 37);
            this.plC_RJ_GroupBox1.ContentsPanel.Name = "ContentsPanel";
            this.plC_RJ_GroupBox1.ContentsPanel.Padding = new System.Windows.Forms.Padding(5);
            this.plC_RJ_GroupBox1.ContentsPanel.Size = new System.Drawing.Size(1630, 593);
            this.plC_RJ_GroupBox1.ContentsPanel.TabIndex = 2;
            this.plC_RJ_GroupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.plC_RJ_GroupBox1.Name = "plC_RJ_GroupBox1";
            this.plC_RJ_GroupBox1.PannelBackColor = System.Drawing.Color.White;
            this.plC_RJ_GroupBox1.PannelBorderColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_GroupBox1.PannelBorderRadius = 5;
            this.plC_RJ_GroupBox1.PannelBorderSize = 2;
            this.plC_RJ_GroupBox1.Size = new System.Drawing.Size(1630, 630);
            this.plC_RJ_GroupBox1.TabIndex = 0;
            this.plC_RJ_GroupBox1.TitleBackColor = System.Drawing.Color.DeepSkyBlue;
            this.plC_RJ_GroupBox1.TitleBorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_GroupBox1.TitleBorderRadius = 5;
            this.plC_RJ_GroupBox1.TitleBorderSize = 0;
            this.plC_RJ_GroupBox1.TitleFont = new System.Drawing.Font("新細明體", 12F);
            this.plC_RJ_GroupBox1.TitleForeColor = System.Drawing.Color.White;
            this.plC_RJ_GroupBox1.TitleHeight = 37;
            this.plC_RJ_GroupBox1.TitleTextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.plC_RJ_GroupBox1.TitleTexts = "雲端藥檔";
            // 
            // plC_RJ_Button_雲端藥檔_取得資料
            // 
            this.plC_RJ_Button_雲端藥檔_取得資料.AutoResetState = false;
            this.plC_RJ_Button_雲端藥檔_取得資料.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_雲端藥檔_取得資料.Bool = false;
            this.plC_RJ_Button_雲端藥檔_取得資料.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_雲端藥檔_取得資料.BorderRadius = 5;
            this.plC_RJ_Button_雲端藥檔_取得資料.BorderSize = 0;
            this.plC_RJ_Button_雲端藥檔_取得資料.but_press = false;
            this.plC_RJ_Button_雲端藥檔_取得資料.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_雲端藥檔_取得資料.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_雲端藥檔_取得資料.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_雲端藥檔_取得資料.Font = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_雲端藥檔_取得資料.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_雲端藥檔_取得資料.Location = new System.Drawing.Point(16, 511);
            this.plC_RJ_Button_雲端藥檔_取得資料.Name = "plC_RJ_Button_雲端藥檔_取得資料";
            this.plC_RJ_Button_雲端藥檔_取得資料.OFF_文字內容 = "取得資料";
            this.plC_RJ_Button_雲端藥檔_取得資料.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_雲端藥檔_取得資料.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_雲端藥檔_取得資料.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_雲端藥檔_取得資料.ON_BorderSize = 5;
            this.plC_RJ_Button_雲端藥檔_取得資料.ON_文字內容 = "取得資料";
            this.plC_RJ_Button_雲端藥檔_取得資料.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 14F);
            this.plC_RJ_Button_雲端藥檔_取得資料.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_雲端藥檔_取得資料.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_雲端藥檔_取得資料.Size = new System.Drawing.Size(152, 67);
            this.plC_RJ_Button_雲端藥檔_取得資料.State = false;
            this.plC_RJ_Button_雲端藥檔_取得資料.TabIndex = 145;
            this.plC_RJ_Button_雲端藥檔_取得資料.Text = "取得資料";
            this.plC_RJ_Button_雲端藥檔_取得資料.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_雲端藥檔_取得資料.Texts = "取得資料";
            this.plC_RJ_Button_雲端藥檔_取得資料.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_雲端藥檔_取得資料.字型鎖住 = false;
            this.plC_RJ_Button_雲端藥檔_取得資料.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_雲端藥檔_取得資料.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_雲端藥檔_取得資料.文字鎖住 = false;
            this.plC_RJ_Button_雲端藥檔_取得資料.讀取位元反向 = false;
            this.plC_RJ_Button_雲端藥檔_取得資料.讀寫鎖住 = false;
            this.plC_RJ_Button_雲端藥檔_取得資料.音效 = true;
            this.plC_RJ_Button_雲端藥檔_取得資料.顯示 = false;
            this.plC_RJ_Button_雲端藥檔_取得資料.顯示狀態 = false;
            // 
            // sqL_DataGridView_雲端藥檔
            // 
            this.sqL_DataGridView_雲端藥檔.AutoSelectToDeep = false;
            this.sqL_DataGridView_雲端藥檔.backColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_雲端藥檔.BorderColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_雲端藥檔.BorderRadius = 0;
            this.sqL_DataGridView_雲端藥檔.BorderSize = 2;
            this.sqL_DataGridView_雲端藥檔.cellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_雲端藥檔.cellStylBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_雲端藥檔.cellStyleFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_雲端藥檔.cellStylForeColor = System.Drawing.Color.Black;
            this.sqL_DataGridView_雲端藥檔.columnHeaderBackColor = System.Drawing.Color.SkyBlue;
            this.sqL_DataGridView_雲端藥檔.columnHeaderFont = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold);
            this.sqL_DataGridView_雲端藥檔.columnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_雲端藥檔.columnHeadersHeight = 65;
            this.sqL_DataGridView_雲端藥檔.columnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sqL_DataGridView_雲端藥檔.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_雲端藥檔.Columns"))));
            this.sqL_DataGridView_雲端藥檔.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_雲端藥檔.Columns1"))));
            this.sqL_DataGridView_雲端藥檔.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_雲端藥檔.Columns2"))));
            this.sqL_DataGridView_雲端藥檔.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_雲端藥檔.Columns3"))));
            this.sqL_DataGridView_雲端藥檔.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_雲端藥檔.Columns4"))));
            this.sqL_DataGridView_雲端藥檔.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_雲端藥檔.Columns5"))));
            this.sqL_DataGridView_雲端藥檔.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_雲端藥檔.Columns6"))));
            this.sqL_DataGridView_雲端藥檔.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_雲端藥檔.Columns7"))));
            this.sqL_DataGridView_雲端藥檔.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_雲端藥檔.Columns8"))));
            this.sqL_DataGridView_雲端藥檔.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_雲端藥檔.Columns9"))));
            this.sqL_DataGridView_雲端藥檔.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_雲端藥檔.Columns10"))));
            this.sqL_DataGridView_雲端藥檔.Columns.Add(((SQLUI.SQL_DataGridView.ColumnElement)(resources.GetObject("sqL_DataGridView_雲端藥檔.Columns11"))));
            this.sqL_DataGridView_雲端藥檔.DataBaseName = "storehouse_0";
            this.sqL_DataGridView_雲端藥檔.Dock = System.Windows.Forms.DockStyle.Top;
            this.sqL_DataGridView_雲端藥檔.Font = new System.Drawing.Font("新細明體", 12F);
            this.sqL_DataGridView_雲端藥檔.ImageBox = false;
            this.sqL_DataGridView_雲端藥檔.Location = new System.Drawing.Point(5, 5);
            this.sqL_DataGridView_雲端藥檔.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sqL_DataGridView_雲端藥檔.Name = "sqL_DataGridView_雲端藥檔";
            this.sqL_DataGridView_雲端藥檔.OnlineState = SQLUI.SQL_DataGridView.OnlineEnum.Online;
            this.sqL_DataGridView_雲端藥檔.Password = "user82822040";
            this.sqL_DataGridView_雲端藥檔.Port = ((uint)(3306u));
            this.sqL_DataGridView_雲端藥檔.rowHeaderBackColor = System.Drawing.Color.LightBlue;
            this.sqL_DataGridView_雲端藥檔.rowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_雲端藥檔.RowsColor = System.Drawing.SystemColors.ButtonHighlight;
            this.sqL_DataGridView_雲端藥檔.RowsHeight = 60;
            this.sqL_DataGridView_雲端藥檔.SaveFileName = "SQL_DataGridView";
            this.sqL_DataGridView_雲端藥檔.Server = "localhost";
            this.sqL_DataGridView_雲端藥檔.Size = new System.Drawing.Size(1620, 442);
            this.sqL_DataGridView_雲端藥檔.SSLMode = MySql.Data.MySqlClient.MySqlSslMode.None;
            this.sqL_DataGridView_雲端藥檔.TabIndex = 144;
            this.sqL_DataGridView_雲端藥檔.TableName = "medicine_page_cloud";
            this.sqL_DataGridView_雲端藥檔.UserName = "root";
            this.sqL_DataGridView_雲端藥檔.可拖曳欄位寬度 = true;
            this.sqL_DataGridView_雲端藥檔.可選擇多列 = true;
            this.sqL_DataGridView_雲端藥檔.單格樣式 = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.sqL_DataGridView_雲端藥檔.自動換行 = true;
            this.sqL_DataGridView_雲端藥檔.表單字體 = new System.Drawing.Font("新細明體", 12F);
            this.sqL_DataGridView_雲端藥檔.邊框樣式 = System.Windows.Forms.BorderStyle.None;
            this.sqL_DataGridView_雲端藥檔.顯示CheckBox = false;
            this.sqL_DataGridView_雲端藥檔.顯示首列 = true;
            this.sqL_DataGridView_雲端藥檔.顯示首行 = true;
            this.sqL_DataGridView_雲端藥檔.首列樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.sqL_DataGridView_雲端藥檔.首行樣式 = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            // 
            // panel_系統
            // 
            this.panel_系統.Controls.Add(this.plC_RJ_ScreenButton6);
            this.panel_系統.Controls.Add(this.plC_RJ_ScreenButton5);
            this.panel_系統.Controls.Add(this.plC_RJ_ScreenButton4);
            this.panel_系統.Controls.Add(this.plC_RJ_ScreenButton1);
            this.panel_系統.Controls.Add(this.plC_RJ_ScreenButton2);
            this.panel_系統.Controls.Add(this.plC_RJ_ScreenButton3);
            this.panel_系統.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_系統.Location = new System.Drawing.Point(0, 0);
            this.panel_系統.Name = "panel_系統";
            this.panel_系統.Size = new System.Drawing.Size(1638, 51);
            this.panel_系統.TabIndex = 116;
            // 
            // plC_RJ_ScreenButton6
            // 
            this.plC_RJ_ScreenButton6.but_press = false;
            this.plC_RJ_ScreenButton6.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton6.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton6.IconSize = 32;
            this.plC_RJ_ScreenButton6.Location = new System.Drawing.Point(860, 0);
            this.plC_RJ_ScreenButton6.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton6.Name = "plC_RJ_ScreenButton6";
            this.plC_RJ_ScreenButton6.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton6.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton6.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton6.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton6.OffText = "設定06";
            this.plC_RJ_ScreenButton6.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton6.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton6.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton6.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton6.OnText = "設定06";
            this.plC_RJ_ScreenButton6.ShowIcon = false;
            this.plC_RJ_ScreenButton6.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton6.TabIndex = 5;
            this.plC_RJ_ScreenButton6.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton6.寫入位置註解 = "";
            this.plC_RJ_ScreenButton6.寫入元件位置 = "";
            this.plC_RJ_ScreenButton6.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton6.控制位址 = "D0";
            this.plC_RJ_ScreenButton6.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton6.致能讀取位置 = "";
            this.plC_RJ_ScreenButton6.讀取位元反向 = false;
            this.plC_RJ_ScreenButton6.讀取位置註解 = "";
            this.plC_RJ_ScreenButton6.讀取元件位置 = "";
            this.plC_RJ_ScreenButton6.音效 = true;
            this.plC_RJ_ScreenButton6.頁面名稱 = "設定06";
            this.plC_RJ_ScreenButton6.頁面編號 = 0;
            this.plC_RJ_ScreenButton6.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton6.顯示狀態 = false;
            this.plC_RJ_ScreenButton6.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton5
            // 
            this.plC_RJ_ScreenButton5.but_press = false;
            this.plC_RJ_ScreenButton5.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton5.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton5.IconSize = 32;
            this.plC_RJ_ScreenButton5.Location = new System.Drawing.Point(688, 0);
            this.plC_RJ_ScreenButton5.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton5.Name = "plC_RJ_ScreenButton5";
            this.plC_RJ_ScreenButton5.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton5.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton5.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton5.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton5.OffText = "設定05";
            this.plC_RJ_ScreenButton5.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton5.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton5.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton5.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton5.OnText = "設定05";
            this.plC_RJ_ScreenButton5.ShowIcon = false;
            this.plC_RJ_ScreenButton5.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton5.TabIndex = 4;
            this.plC_RJ_ScreenButton5.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton5.寫入位置註解 = "";
            this.plC_RJ_ScreenButton5.寫入元件位置 = "";
            this.plC_RJ_ScreenButton5.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton5.控制位址 = "D0";
            this.plC_RJ_ScreenButton5.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton5.致能讀取位置 = "";
            this.plC_RJ_ScreenButton5.讀取位元反向 = false;
            this.plC_RJ_ScreenButton5.讀取位置註解 = "";
            this.plC_RJ_ScreenButton5.讀取元件位置 = "";
            this.plC_RJ_ScreenButton5.音效 = true;
            this.plC_RJ_ScreenButton5.頁面名稱 = "設定05";
            this.plC_RJ_ScreenButton5.頁面編號 = 0;
            this.plC_RJ_ScreenButton5.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton5.顯示狀態 = false;
            this.plC_RJ_ScreenButton5.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton4
            // 
            this.plC_RJ_ScreenButton4.but_press = false;
            this.plC_RJ_ScreenButton4.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton4.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton4.IconSize = 32;
            this.plC_RJ_ScreenButton4.Location = new System.Drawing.Point(516, 0);
            this.plC_RJ_ScreenButton4.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton4.Name = "plC_RJ_ScreenButton4";
            this.plC_RJ_ScreenButton4.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton4.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton4.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton4.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton4.OffText = "設定04";
            this.plC_RJ_ScreenButton4.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton4.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton4.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton4.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton4.OnText = "設定04";
            this.plC_RJ_ScreenButton4.ShowIcon = false;
            this.plC_RJ_ScreenButton4.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton4.TabIndex = 3;
            this.plC_RJ_ScreenButton4.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton4.寫入位置註解 = "";
            this.plC_RJ_ScreenButton4.寫入元件位置 = "";
            this.plC_RJ_ScreenButton4.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton4.控制位址 = "D0";
            this.plC_RJ_ScreenButton4.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton4.致能讀取位置 = "";
            this.plC_RJ_ScreenButton4.讀取位元反向 = false;
            this.plC_RJ_ScreenButton4.讀取位置註解 = "";
            this.plC_RJ_ScreenButton4.讀取元件位置 = "";
            this.plC_RJ_ScreenButton4.音效 = true;
            this.plC_RJ_ScreenButton4.頁面名稱 = "設定04";
            this.plC_RJ_ScreenButton4.頁面編號 = 0;
            this.plC_RJ_ScreenButton4.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton4.顯示狀態 = false;
            this.plC_RJ_ScreenButton4.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton1
            // 
            this.plC_RJ_ScreenButton1.but_press = false;
            this.plC_RJ_ScreenButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton1.IconSize = 32;
            this.plC_RJ_ScreenButton1.Location = new System.Drawing.Point(344, 0);
            this.plC_RJ_ScreenButton1.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton1.Name = "plC_RJ_ScreenButton1";
            this.plC_RJ_ScreenButton1.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton1.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton1.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton1.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton1.OffText = "設定03";
            this.plC_RJ_ScreenButton1.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton1.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton1.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton1.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton1.OnText = "設定03";
            this.plC_RJ_ScreenButton1.ShowIcon = false;
            this.plC_RJ_ScreenButton1.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton1.TabIndex = 2;
            this.plC_RJ_ScreenButton1.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton1.寫入位置註解 = "";
            this.plC_RJ_ScreenButton1.寫入元件位置 = "";
            this.plC_RJ_ScreenButton1.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton1.控制位址 = "D0";
            this.plC_RJ_ScreenButton1.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton1.致能讀取位置 = "";
            this.plC_RJ_ScreenButton1.讀取位元反向 = false;
            this.plC_RJ_ScreenButton1.讀取位置註解 = "";
            this.plC_RJ_ScreenButton1.讀取元件位置 = "";
            this.plC_RJ_ScreenButton1.音效 = true;
            this.plC_RJ_ScreenButton1.頁面名稱 = "設定03";
            this.plC_RJ_ScreenButton1.頁面編號 = 0;
            this.plC_RJ_ScreenButton1.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton1.顯示狀態 = false;
            this.plC_RJ_ScreenButton1.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton2
            // 
            this.plC_RJ_ScreenButton2.but_press = false;
            this.plC_RJ_ScreenButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton2.IconSize = 32;
            this.plC_RJ_ScreenButton2.Location = new System.Drawing.Point(172, 0);
            this.plC_RJ_ScreenButton2.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton2.Name = "plC_RJ_ScreenButton2";
            this.plC_RJ_ScreenButton2.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton2.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton2.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton2.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton2.OffText = "設定02";
            this.plC_RJ_ScreenButton2.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton2.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton2.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton2.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton2.OnText = "設定02";
            this.plC_RJ_ScreenButton2.ShowIcon = false;
            this.plC_RJ_ScreenButton2.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton2.TabIndex = 1;
            this.plC_RJ_ScreenButton2.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton2.寫入位置註解 = "";
            this.plC_RJ_ScreenButton2.寫入元件位置 = "";
            this.plC_RJ_ScreenButton2.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton2.控制位址 = "D0";
            this.plC_RJ_ScreenButton2.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton2.致能讀取位置 = "";
            this.plC_RJ_ScreenButton2.讀取位元反向 = false;
            this.plC_RJ_ScreenButton2.讀取位置註解 = "";
            this.plC_RJ_ScreenButton2.讀取元件位置 = "";
            this.plC_RJ_ScreenButton2.音效 = true;
            this.plC_RJ_ScreenButton2.頁面名稱 = "設定02";
            this.plC_RJ_ScreenButton2.頁面編號 = 0;
            this.plC_RJ_ScreenButton2.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton2.顯示狀態 = false;
            this.plC_RJ_ScreenButton2.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton3
            // 
            this.plC_RJ_ScreenButton3.but_press = false;
            this.plC_RJ_ScreenButton3.Dock = System.Windows.Forms.DockStyle.Left;
            this.plC_RJ_ScreenButton3.IconChar = FontAwesome.Sharp.IconChar.None;
            this.plC_RJ_ScreenButton3.IconSize = 32;
            this.plC_RJ_ScreenButton3.Location = new System.Drawing.Point(0, 0);
            this.plC_RJ_ScreenButton3.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton3.Name = "plC_RJ_ScreenButton3";
            this.plC_RJ_ScreenButton3.OffBackColor = System.Drawing.Color.DarkCyan;
            this.plC_RJ_ScreenButton3.OffFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton3.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton3.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton3.OffText = "設定01";
            this.plC_RJ_ScreenButton3.OnBackColor = System.Drawing.Color.LightSeaGreen;
            this.plC_RJ_ScreenButton3.OnFont = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton3.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton3.OnIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton3.OnText = "設定01";
            this.plC_RJ_ScreenButton3.ShowIcon = false;
            this.plC_RJ_ScreenButton3.Size = new System.Drawing.Size(172, 51);
            this.plC_RJ_ScreenButton3.TabIndex = 0;
            this.plC_RJ_ScreenButton3.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton3.寫入位置註解 = "";
            this.plC_RJ_ScreenButton3.寫入元件位置 = "";
            this.plC_RJ_ScreenButton3.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton3.控制位址 = "D0";
            this.plC_RJ_ScreenButton3.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton3.致能讀取位置 = "";
            this.plC_RJ_ScreenButton3.讀取位元反向 = false;
            this.plC_RJ_ScreenButton3.讀取位置註解 = "";
            this.plC_RJ_ScreenButton3.讀取元件位置 = "";
            this.plC_RJ_ScreenButton3.音效 = true;
            this.plC_RJ_ScreenButton3.頁面名稱 = "設定01";
            this.plC_RJ_ScreenButton3.頁面編號 = 0;
            this.plC_RJ_ScreenButton3.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton3.顯示狀態 = false;
            this.plC_RJ_ScreenButton3.顯示讀取位置 = "";
            // 
            // panel_Main
            // 
            this.panel_Main.BackColor = System.Drawing.Color.SkyBlue;
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_工程模式);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_儲位管理);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_人員資料);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_藥品資料_藥檔資料);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_醫囑資料);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_交易紀錄查詢);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_入庫作業);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_後台登入);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton_領藥作業);
            this.panel_Main.Controls.Add(this.panel232);
            this.panel_Main.Controls.Add(this.plC_RJ_ScreenButton143);
            this.panel_Main.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Main.Location = new System.Drawing.Point(0, 0);
            this.panel_Main.Name = "panel_Main";
            this.panel_Main.Size = new System.Drawing.Size(258, 1015);
            this.panel_Main.TabIndex = 4;
            // 
            // plC_RJ_ScreenButton_工程模式
            // 
            this.plC_RJ_ScreenButton_工程模式.but_press = false;
            this.plC_RJ_ScreenButton_工程模式.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_ScreenButton_工程模式.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.plC_RJ_ScreenButton_工程模式.IconSize = 40;
            this.plC_RJ_ScreenButton_工程模式.Location = new System.Drawing.Point(0, 520);
            this.plC_RJ_ScreenButton_工程模式.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_工程模式.Name = "plC_RJ_ScreenButton_工程模式";
            this.plC_RJ_ScreenButton_工程模式.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton_工程模式.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_工程模式.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_工程模式.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_工程模式.OffText = "工程模式";
            this.plC_RJ_ScreenButton_工程模式.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_工程模式.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_工程模式.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_工程模式.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_工程模式.OnText = "工程模式";
            this.plC_RJ_ScreenButton_工程模式.ShowIcon = true;
            this.plC_RJ_ScreenButton_工程模式.Size = new System.Drawing.Size(258, 65);
            this.plC_RJ_ScreenButton_工程模式.TabIndex = 108;
            this.plC_RJ_ScreenButton_工程模式.Visible = false;
            this.plC_RJ_ScreenButton_工程模式.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_工程模式.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_工程模式.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_工程模式.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_工程模式.控制位址 = "D0";
            this.plC_RJ_ScreenButton_工程模式.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_工程模式.致能讀取位置 = "S39006";
            this.plC_RJ_ScreenButton_工程模式.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_工程模式.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_工程模式.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_工程模式.音效 = true;
            this.plC_RJ_ScreenButton_工程模式.頁面名稱 = "工程模式";
            this.plC_RJ_ScreenButton_工程模式.頁面編號 = 0;
            this.plC_RJ_ScreenButton_工程模式.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_工程模式.顯示狀態 = false;
            this.plC_RJ_ScreenButton_工程模式.顯示讀取位置 = "S39006";
            // 
            // plC_RJ_ScreenButton_儲位管理
            // 
            this.plC_RJ_ScreenButton_儲位管理.but_press = false;
            this.plC_RJ_ScreenButton_儲位管理.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_ScreenButton_儲位管理.IconChar = FontAwesome.Sharp.IconChar.SolarPanel;
            this.plC_RJ_ScreenButton_儲位管理.IconSize = 40;
            this.plC_RJ_ScreenButton_儲位管理.Location = new System.Drawing.Point(0, 455);
            this.plC_RJ_ScreenButton_儲位管理.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_儲位管理.Name = "plC_RJ_ScreenButton_儲位管理";
            this.plC_RJ_ScreenButton_儲位管理.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton_儲位管理.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_儲位管理.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_儲位管理.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_儲位管理.OffText = "儲位管理";
            this.plC_RJ_ScreenButton_儲位管理.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_儲位管理.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_儲位管理.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_儲位管理.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_儲位管理.OnText = "儲位管理";
            this.plC_RJ_ScreenButton_儲位管理.ShowIcon = true;
            this.plC_RJ_ScreenButton_儲位管理.Size = new System.Drawing.Size(258, 65);
            this.plC_RJ_ScreenButton_儲位管理.TabIndex = 107;
            this.plC_RJ_ScreenButton_儲位管理.Visible = false;
            this.plC_RJ_ScreenButton_儲位管理.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_儲位管理.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_儲位管理.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_儲位管理.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_儲位管理.控制位址 = "D0";
            this.plC_RJ_ScreenButton_儲位管理.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_儲位管理.致能讀取位置 = "S39005";
            this.plC_RJ_ScreenButton_儲位管理.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_儲位管理.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_儲位管理.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_儲位管理.音效 = true;
            this.plC_RJ_ScreenButton_儲位管理.頁面名稱 = "儲位管理";
            this.plC_RJ_ScreenButton_儲位管理.頁面編號 = 0;
            this.plC_RJ_ScreenButton_儲位管理.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_儲位管理.顯示狀態 = false;
            this.plC_RJ_ScreenButton_儲位管理.顯示讀取位置 = "S39005";
            // 
            // plC_RJ_ScreenButton_人員資料
            // 
            this.plC_RJ_ScreenButton_人員資料.but_press = false;
            this.plC_RJ_ScreenButton_人員資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_ScreenButton_人員資料.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.plC_RJ_ScreenButton_人員資料.IconSize = 40;
            this.plC_RJ_ScreenButton_人員資料.Location = new System.Drawing.Point(0, 390);
            this.plC_RJ_ScreenButton_人員資料.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_人員資料.Name = "plC_RJ_ScreenButton_人員資料";
            this.plC_RJ_ScreenButton_人員資料.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton_人員資料.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_人員資料.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_人員資料.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_人員資料.OffText = "人員資料";
            this.plC_RJ_ScreenButton_人員資料.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_人員資料.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_人員資料.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_人員資料.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_人員資料.OnText = "人員資料";
            this.plC_RJ_ScreenButton_人員資料.ShowIcon = true;
            this.plC_RJ_ScreenButton_人員資料.Size = new System.Drawing.Size(258, 65);
            this.plC_RJ_ScreenButton_人員資料.TabIndex = 106;
            this.plC_RJ_ScreenButton_人員資料.Visible = false;
            this.plC_RJ_ScreenButton_人員資料.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_人員資料.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_人員資料.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_人員資料.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_人員資料.控制位址 = "D0";
            this.plC_RJ_ScreenButton_人員資料.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_人員資料.致能讀取位置 = "S39004";
            this.plC_RJ_ScreenButton_人員資料.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_人員資料.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_人員資料.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_人員資料.音效 = true;
            this.plC_RJ_ScreenButton_人員資料.頁面名稱 = "人員資料";
            this.plC_RJ_ScreenButton_人員資料.頁面編號 = 0;
            this.plC_RJ_ScreenButton_人員資料.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_人員資料.顯示狀態 = false;
            this.plC_RJ_ScreenButton_人員資料.顯示讀取位置 = "S39004";
            // 
            // plC_RJ_ScreenButton_藥品資料_藥檔資料
            // 
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.but_press = false;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.IconChar = FontAwesome.Sharp.IconChar.FileMedical;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.IconSize = 40;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.Location = new System.Drawing.Point(0, 325);
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.Name = "plC_RJ_ScreenButton_藥品資料_藥檔資料";
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.OffText = "藥品資料";
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.OnText = "藥品資料";
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.ShowIcon = true;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.Size = new System.Drawing.Size(258, 65);
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.TabIndex = 104;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.Visible = false;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.控制位址 = "D0";
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.致能讀取位置 = "S39002";
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.音效 = true;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.頁面名稱 = "藥品資料";
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.頁面編號 = 0;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.顯示狀態 = false;
            this.plC_RJ_ScreenButton_藥品資料_藥檔資料.顯示讀取位置 = "S39002";
            // 
            // plC_RJ_ScreenButton_醫囑資料
            // 
            this.plC_RJ_ScreenButton_醫囑資料.but_press = false;
            this.plC_RJ_ScreenButton_醫囑資料.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_ScreenButton_醫囑資料.IconChar = FontAwesome.Sharp.IconChar.FileMedicalAlt;
            this.plC_RJ_ScreenButton_醫囑資料.IconSize = 40;
            this.plC_RJ_ScreenButton_醫囑資料.Location = new System.Drawing.Point(0, 260);
            this.plC_RJ_ScreenButton_醫囑資料.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_醫囑資料.Name = "plC_RJ_ScreenButton_醫囑資料";
            this.plC_RJ_ScreenButton_醫囑資料.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton_醫囑資料.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_醫囑資料.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_醫囑資料.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_醫囑資料.OffText = "醫囑資料";
            this.plC_RJ_ScreenButton_醫囑資料.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_醫囑資料.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_醫囑資料.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_醫囑資料.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_醫囑資料.OnText = "醫囑資料";
            this.plC_RJ_ScreenButton_醫囑資料.ShowIcon = true;
            this.plC_RJ_ScreenButton_醫囑資料.Size = new System.Drawing.Size(258, 65);
            this.plC_RJ_ScreenButton_醫囑資料.TabIndex = 103;
            this.plC_RJ_ScreenButton_醫囑資料.Visible = false;
            this.plC_RJ_ScreenButton_醫囑資料.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_醫囑資料.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_醫囑資料.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_醫囑資料.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_醫囑資料.控制位址 = "D0";
            this.plC_RJ_ScreenButton_醫囑資料.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_醫囑資料.致能讀取位置 = "S39022";
            this.plC_RJ_ScreenButton_醫囑資料.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_醫囑資料.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_醫囑資料.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_醫囑資料.音效 = true;
            this.plC_RJ_ScreenButton_醫囑資料.頁面名稱 = "醫囑資料";
            this.plC_RJ_ScreenButton_醫囑資料.頁面編號 = 0;
            this.plC_RJ_ScreenButton_醫囑資料.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_醫囑資料.顯示狀態 = false;
            this.plC_RJ_ScreenButton_醫囑資料.顯示讀取位置 = "M8001";
            // 
            // plC_RJ_ScreenButton_交易紀錄查詢
            // 
            this.plC_RJ_ScreenButton_交易紀錄查詢.but_press = false;
            this.plC_RJ_ScreenButton_交易紀錄查詢.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_ScreenButton_交易紀錄查詢.IconChar = FontAwesome.Sharp.IconChar.CalendarAlt;
            this.plC_RJ_ScreenButton_交易紀錄查詢.IconSize = 40;
            this.plC_RJ_ScreenButton_交易紀錄查詢.Location = new System.Drawing.Point(0, 195);
            this.plC_RJ_ScreenButton_交易紀錄查詢.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_交易紀錄查詢.Name = "plC_RJ_ScreenButton_交易紀錄查詢";
            this.plC_RJ_ScreenButton_交易紀錄查詢.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton_交易紀錄查詢.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_交易紀錄查詢.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_交易紀錄查詢.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_交易紀錄查詢.OffText = "交易記錄查詢";
            this.plC_RJ_ScreenButton_交易紀錄查詢.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_交易紀錄查詢.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_交易紀錄查詢.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_交易紀錄查詢.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_交易紀錄查詢.OnText = "交易記錄查詢";
            this.plC_RJ_ScreenButton_交易紀錄查詢.ShowIcon = true;
            this.plC_RJ_ScreenButton_交易紀錄查詢.Size = new System.Drawing.Size(258, 65);
            this.plC_RJ_ScreenButton_交易紀錄查詢.TabIndex = 97;
            this.plC_RJ_ScreenButton_交易紀錄查詢.Visible = false;
            this.plC_RJ_ScreenButton_交易紀錄查詢.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_交易紀錄查詢.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_交易紀錄查詢.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_交易紀錄查詢.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_交易紀錄查詢.控制位址 = "D0";
            this.plC_RJ_ScreenButton_交易紀錄查詢.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_交易紀錄查詢.致能讀取位置 = "S39001";
            this.plC_RJ_ScreenButton_交易紀錄查詢.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_交易紀錄查詢.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_交易紀錄查詢.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_交易紀錄查詢.音效 = true;
            this.plC_RJ_ScreenButton_交易紀錄查詢.頁面名稱 = "交易記錄查詢";
            this.plC_RJ_ScreenButton_交易紀錄查詢.頁面編號 = 0;
            this.plC_RJ_ScreenButton_交易紀錄查詢.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_交易紀錄查詢.顯示狀態 = false;
            this.plC_RJ_ScreenButton_交易紀錄查詢.顯示讀取位置 = "S39001";
            // 
            // plC_RJ_ScreenButton_入庫作業
            // 
            this.plC_RJ_ScreenButton_入庫作業.but_press = false;
            this.plC_RJ_ScreenButton_入庫作業.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_ScreenButton_入庫作業.IconChar = FontAwesome.Sharp.IconChar.Cube;
            this.plC_RJ_ScreenButton_入庫作業.IconSize = 40;
            this.plC_RJ_ScreenButton_入庫作業.Location = new System.Drawing.Point(0, 130);
            this.plC_RJ_ScreenButton_入庫作業.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_入庫作業.Name = "plC_RJ_ScreenButton_入庫作業";
            this.plC_RJ_ScreenButton_入庫作業.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton_入庫作業.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_入庫作業.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_入庫作業.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_入庫作業.OffText = "入庫作業";
            this.plC_RJ_ScreenButton_入庫作業.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_入庫作業.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_入庫作業.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_入庫作業.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_入庫作業.OnText = "入庫作業";
            this.plC_RJ_ScreenButton_入庫作業.ShowIcon = true;
            this.plC_RJ_ScreenButton_入庫作業.Size = new System.Drawing.Size(258, 65);
            this.plC_RJ_ScreenButton_入庫作業.TabIndex = 96;
            this.plC_RJ_ScreenButton_入庫作業.Visible = false;
            this.plC_RJ_ScreenButton_入庫作業.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_入庫作業.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_入庫作業.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_入庫作業.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_入庫作業.控制位址 = "D0";
            this.plC_RJ_ScreenButton_入庫作業.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_入庫作業.致能讀取位置 = "S39000";
            this.plC_RJ_ScreenButton_入庫作業.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_入庫作業.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_入庫作業.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_入庫作業.音效 = true;
            this.plC_RJ_ScreenButton_入庫作業.頁面名稱 = "入庫作業";
            this.plC_RJ_ScreenButton_入庫作業.頁面編號 = 0;
            this.plC_RJ_ScreenButton_入庫作業.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_入庫作業.顯示狀態 = false;
            this.plC_RJ_ScreenButton_入庫作業.顯示讀取位置 = "M8001";
            // 
            // plC_RJ_ScreenButton_後台登入
            // 
            this.plC_RJ_ScreenButton_後台登入.but_press = false;
            this.plC_RJ_ScreenButton_後台登入.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_ScreenButton_後台登入.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.plC_RJ_ScreenButton_後台登入.IconSize = 40;
            this.plC_RJ_ScreenButton_後台登入.Location = new System.Drawing.Point(0, 65);
            this.plC_RJ_ScreenButton_後台登入.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_後台登入.Name = "plC_RJ_ScreenButton_後台登入";
            this.plC_RJ_ScreenButton_後台登入.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton_後台登入.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_後台登入.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_後台登入.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_後台登入.OffText = "後台登入";
            this.plC_RJ_ScreenButton_後台登入.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_後台登入.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_後台登入.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_後台登入.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_後台登入.OnText = "後台登入";
            this.plC_RJ_ScreenButton_後台登入.ShowIcon = true;
            this.plC_RJ_ScreenButton_後台登入.Size = new System.Drawing.Size(258, 65);
            this.plC_RJ_ScreenButton_後台登入.TabIndex = 95;
            this.plC_RJ_ScreenButton_後台登入.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_後台登入.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_後台登入.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_後台登入.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_後台登入.控制位址 = "D0";
            this.plC_RJ_ScreenButton_後台登入.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_後台登入.致能讀取位置 = "";
            this.plC_RJ_ScreenButton_後台登入.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_後台登入.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_後台登入.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_後台登入.音效 = true;
            this.plC_RJ_ScreenButton_後台登入.頁面名稱 = "後台登入";
            this.plC_RJ_ScreenButton_後台登入.頁面編號 = 0;
            this.plC_RJ_ScreenButton_後台登入.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_後台登入.顯示狀態 = false;
            this.plC_RJ_ScreenButton_後台登入.顯示讀取位置 = "";
            // 
            // plC_RJ_ScreenButton_領藥作業
            // 
            this.plC_RJ_ScreenButton_領藥作業.but_press = false;
            this.plC_RJ_ScreenButton_領藥作業.Dock = System.Windows.Forms.DockStyle.Top;
            this.plC_RJ_ScreenButton_領藥作業.IconChar = FontAwesome.Sharp.IconChar.Allergies;
            this.plC_RJ_ScreenButton_領藥作業.IconSize = 40;
            this.plC_RJ_ScreenButton_領藥作業.Location = new System.Drawing.Point(0, 0);
            this.plC_RJ_ScreenButton_領藥作業.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton_領藥作業.Name = "plC_RJ_ScreenButton_領藥作業";
            this.plC_RJ_ScreenButton_領藥作業.OffBackColor = System.Drawing.Color.SkyBlue;
            this.plC_RJ_ScreenButton_領藥作業.OffFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_領藥作業.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_領藥作業.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton_領藥作業.OffText = "領藥作業";
            this.plC_RJ_ScreenButton_領藥作業.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton_領藥作業.OnFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton_領藥作業.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton_領藥作業.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton_領藥作業.OnText = "領藥作業";
            this.plC_RJ_ScreenButton_領藥作業.ShowIcon = true;
            this.plC_RJ_ScreenButton_領藥作業.Size = new System.Drawing.Size(258, 65);
            this.plC_RJ_ScreenButton_領藥作業.TabIndex = 94;
            this.plC_RJ_ScreenButton_領藥作業.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton_領藥作業.寫入位置註解 = "";
            this.plC_RJ_ScreenButton_領藥作業.寫入元件位置 = "";
            this.plC_RJ_ScreenButton_領藥作業.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton_領藥作業.控制位址 = "D0";
            this.plC_RJ_ScreenButton_領藥作業.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.名稱;
            this.plC_RJ_ScreenButton_領藥作業.致能讀取位置 = "";
            this.plC_RJ_ScreenButton_領藥作業.讀取位元反向 = false;
            this.plC_RJ_ScreenButton_領藥作業.讀取位置註解 = "";
            this.plC_RJ_ScreenButton_領藥作業.讀取元件位置 = "";
            this.plC_RJ_ScreenButton_領藥作業.音效 = true;
            this.plC_RJ_ScreenButton_領藥作業.頁面名稱 = "領藥作業";
            this.plC_RJ_ScreenButton_領藥作業.頁面編號 = 0;
            this.plC_RJ_ScreenButton_領藥作業.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton_領藥作業.顯示狀態 = false;
            this.plC_RJ_ScreenButton_領藥作業.顯示讀取位置 = "";
            // 
            // panel232
            // 
            this.panel232.Controls.Add(this.rJ_TextBox_登入者顏色);
            this.panel232.Controls.Add(this.rJ_TextBox_登入者姓名);
            this.panel232.Controls.Add(this.rJ_TextBox_登入者ID);
            this.panel232.Controls.Add(this.rJ_Lable51);
            this.panel232.Controls.Add(this.rJ_Lable52);
            this.panel232.Controls.Add(this.plC_RJ_Button_後台登入_登出);
            this.panel232.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel232.Location = new System.Drawing.Point(0, 861);
            this.panel232.Name = "panel232";
            this.panel232.Size = new System.Drawing.Size(258, 73);
            this.panel232.TabIndex = 93;
            // 
            // rJ_TextBox_登入者顏色
            // 
            this.rJ_TextBox_登入者顏色.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_登入者顏色.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rJ_TextBox_登入者顏色.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_登入者顏色.BorderRadius = 2;
            this.rJ_TextBox_登入者顏色.BorderSize = 1;
            this.rJ_TextBox_登入者顏色.Enabled = false;
            this.rJ_TextBox_登入者顏色.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_登入者顏色.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_登入者顏色.Location = new System.Drawing.Point(142, 2);
            this.rJ_TextBox_登入者顏色.Multiline = false;
            this.rJ_TextBox_登入者顏色.Name = "rJ_TextBox_登入者顏色";
            this.rJ_TextBox_登入者顏色.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_登入者顏色.PassWordChar = false;
            this.rJ_TextBox_登入者顏色.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_登入者顏色.PlaceholderText = "";
            this.rJ_TextBox_登入者顏色.ShowTouchPannel = false;
            this.rJ_TextBox_登入者顏色.Size = new System.Drawing.Size(34, 30);
            this.rJ_TextBox_登入者顏色.TabIndex = 114;
            this.rJ_TextBox_登入者顏色.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_登入者顏色.Texts = "";
            this.rJ_TextBox_登入者顏色.UnderlineStyle = false;
            // 
            // rJ_TextBox_登入者姓名
            // 
            this.rJ_TextBox_登入者姓名.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_登入者姓名.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rJ_TextBox_登入者姓名.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_登入者姓名.BorderRadius = 2;
            this.rJ_TextBox_登入者姓名.BorderSize = 1;
            this.rJ_TextBox_登入者姓名.Enabled = false;
            this.rJ_TextBox_登入者姓名.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_登入者姓名.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_登入者姓名.Location = new System.Drawing.Point(68, 38);
            this.rJ_TextBox_登入者姓名.Multiline = false;
            this.rJ_TextBox_登入者姓名.Name = "rJ_TextBox_登入者姓名";
            this.rJ_TextBox_登入者姓名.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_登入者姓名.PassWordChar = false;
            this.rJ_TextBox_登入者姓名.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_登入者姓名.PlaceholderText = "";
            this.rJ_TextBox_登入者姓名.ShowTouchPannel = false;
            this.rJ_TextBox_登入者姓名.Size = new System.Drawing.Size(108, 30);
            this.rJ_TextBox_登入者姓名.TabIndex = 114;
            this.rJ_TextBox_登入者姓名.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_登入者姓名.Texts = "";
            this.rJ_TextBox_登入者姓名.UnderlineStyle = false;
            // 
            // rJ_TextBox_登入者ID
            // 
            this.rJ_TextBox_登入者ID.BackColor = System.Drawing.SystemColors.Window;
            this.rJ_TextBox_登入者ID.BorderColor = System.Drawing.Color.RoyalBlue;
            this.rJ_TextBox_登入者ID.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rJ_TextBox_登入者ID.BorderRadius = 2;
            this.rJ_TextBox_登入者ID.BorderSize = 1;
            this.rJ_TextBox_登入者ID.Enabled = false;
            this.rJ_TextBox_登入者ID.Font = new System.Drawing.Font("新細明體", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rJ_TextBox_登入者ID.ForeColor = System.Drawing.Color.DimGray;
            this.rJ_TextBox_登入者ID.Location = new System.Drawing.Point(68, 2);
            this.rJ_TextBox_登入者ID.Multiline = false;
            this.rJ_TextBox_登入者ID.Name = "rJ_TextBox_登入者ID";
            this.rJ_TextBox_登入者ID.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rJ_TextBox_登入者ID.PassWordChar = false;
            this.rJ_TextBox_登入者ID.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rJ_TextBox_登入者ID.PlaceholderText = "";
            this.rJ_TextBox_登入者ID.ShowTouchPannel = false;
            this.rJ_TextBox_登入者ID.Size = new System.Drawing.Size(68, 30);
            this.rJ_TextBox_登入者ID.TabIndex = 113;
            this.rJ_TextBox_登入者ID.TextAlgin = System.Windows.Forms.HorizontalAlignment.Left;
            this.rJ_TextBox_登入者ID.Texts = "";
            this.rJ_TextBox_登入者ID.UnderlineStyle = false;
            // 
            // rJ_Lable51
            // 
            this.rJ_Lable51.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_Lable51.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_Lable51.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable51.BorderRadius = 12;
            this.rJ_Lable51.BorderSize = 0;
            this.rJ_Lable51.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable51.ForeColor = System.Drawing.Color.White;
            this.rJ_Lable51.Location = new System.Drawing.Point(4, 2);
            this.rJ_Lable51.Name = "rJ_Lable51";
            this.rJ_Lable51.Size = new System.Drawing.Size(58, 30);
            this.rJ_Lable51.TabIndex = 20;
            this.rJ_Lable51.Text = "ID";
            this.rJ_Lable51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable51.TextColor = System.Drawing.Color.White;
            // 
            // rJ_Lable52
            // 
            this.rJ_Lable52.BackColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_Lable52.BackgroundColor = System.Drawing.Color.CornflowerBlue;
            this.rJ_Lable52.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.rJ_Lable52.BorderRadius = 12;
            this.rJ_Lable52.BorderSize = 0;
            this.rJ_Lable52.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rJ_Lable52.ForeColor = System.Drawing.Color.White;
            this.rJ_Lable52.Location = new System.Drawing.Point(4, 38);
            this.rJ_Lable52.Name = "rJ_Lable52";
            this.rJ_Lable52.Size = new System.Drawing.Size(58, 30);
            this.rJ_Lable52.TabIndex = 22;
            this.rJ_Lable52.Text = "Name";
            this.rJ_Lable52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rJ_Lable52.TextColor = System.Drawing.Color.White;
            // 
            // plC_RJ_Button_後台登入_登出
            // 
            this.plC_RJ_Button_後台登入_登出.AutoResetState = false;
            this.plC_RJ_Button_後台登入_登出.BackgroundColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_Button_後台登入_登出.Bool = false;
            this.plC_RJ_Button_後台登入_登出.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.plC_RJ_Button_後台登入_登出.BorderRadius = 5;
            this.plC_RJ_Button_後台登入_登出.BorderSize = 0;
            this.plC_RJ_Button_後台登入_登出.but_press = false;
            this.plC_RJ_Button_後台登入_登出.buttonType = MyUI.RJ_Button.ButtonType.Toggle;
            this.plC_RJ_Button_後台登入_登出.FlatAppearance.BorderSize = 0;
            this.plC_RJ_Button_後台登入_登出.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plC_RJ_Button_後台登入_登出.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_後台登入_登出.Icon = System.Windows.Forms.MessageBoxIcon.Warning;
            this.plC_RJ_Button_後台登入_登出.Location = new System.Drawing.Point(182, 2);
            this.plC_RJ_Button_後台登入_登出.Name = "plC_RJ_Button_後台登入_登出";
            this.plC_RJ_Button_後台登入_登出.OFF_文字內容 = "登出";
            this.plC_RJ_Button_後台登入_登出.OFF_文字字體 = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_Button_後台登入_登出.OFF_文字顏色 = System.Drawing.Color.White;
            this.plC_RJ_Button_後台登入_登出.OFF_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_後台登入_登出.ON_BorderSize = 5;
            this.plC_RJ_Button_後台登入_登出.ON_文字內容 = "登出";
            this.plC_RJ_Button_後台登入_登出.ON_文字字體 = new System.Drawing.Font("微軟正黑體", 12F);
            this.plC_RJ_Button_後台登入_登出.ON_文字顏色 = System.Drawing.Color.Black;
            this.plC_RJ_Button_後台登入_登出.ON_背景顏色 = System.Drawing.SystemColors.Control;
            this.plC_RJ_Button_後台登入_登出.Size = new System.Drawing.Size(66, 66);
            this.plC_RJ_Button_後台登入_登出.State = false;
            this.plC_RJ_Button_後台登入_登出.TabIndex = 23;
            this.plC_RJ_Button_後台登入_登出.Text = "登出";
            this.plC_RJ_Button_後台登入_登出.TextColor = System.Drawing.Color.White;
            this.plC_RJ_Button_後台登入_登出.UseVisualStyleBackColor = false;
            this.plC_RJ_Button_後台登入_登出.字型鎖住 = false;
            this.plC_RJ_Button_後台登入_登出.按鈕型態 = MyUI.PLC_RJ_Button.StatusEnum.保持型;
            this.plC_RJ_Button_後台登入_登出.按鍵方式 = MyUI.PLC_RJ_Button.PressEnum.Mouse_左鍵;
            this.plC_RJ_Button_後台登入_登出.文字鎖住 = false;
            this.plC_RJ_Button_後台登入_登出.致能讀取位置 = "S4000";
            this.plC_RJ_Button_後台登入_登出.讀取位元反向 = false;
            this.plC_RJ_Button_後台登入_登出.讀寫鎖住 = false;
            this.plC_RJ_Button_後台登入_登出.音效 = true;
            this.plC_RJ_Button_後台登入_登出.顯示 = false;
            this.plC_RJ_Button_後台登入_登出.顯示狀態 = false;
            // 
            // plC_RJ_ScreenButton143
            // 
            this.plC_RJ_ScreenButton143.but_press = false;
            this.plC_RJ_ScreenButton143.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plC_RJ_ScreenButton143.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            this.plC_RJ_ScreenButton143.IconSize = 40;
            this.plC_RJ_ScreenButton143.Location = new System.Drawing.Point(0, 934);
            this.plC_RJ_ScreenButton143.Margin = new System.Windows.Forms.Padding(0);
            this.plC_RJ_ScreenButton143.Name = "plC_RJ_ScreenButton143";
            this.plC_RJ_ScreenButton143.OffBackColor = System.Drawing.Color.CornflowerBlue;
            this.plC_RJ_ScreenButton143.OffFont = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_RJ_ScreenButton143.OffForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton143.OffIconColor = System.Drawing.Color.Black;
            this.plC_RJ_ScreenButton143.OffText = "退出程式";
            this.plC_RJ_ScreenButton143.OnBackColor = System.Drawing.Color.LightBlue;
            this.plC_RJ_ScreenButton143.OnFont = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold);
            this.plC_RJ_ScreenButton143.OnForeColor = System.Drawing.Color.White;
            this.plC_RJ_ScreenButton143.OnIconColor = System.Drawing.Color.RoyalBlue;
            this.plC_RJ_ScreenButton143.OnText = "退出程式";
            this.plC_RJ_ScreenButton143.ShowIcon = true;
            this.plC_RJ_ScreenButton143.Size = new System.Drawing.Size(258, 81);
            this.plC_RJ_ScreenButton143.TabIndex = 92;
            this.plC_RJ_ScreenButton143.字元長度 = MyUI.PLC_RJ_ScreenButton.WordLengthEnum.單字元;
            this.plC_RJ_ScreenButton143.寫入位置註解 = "";
            this.plC_RJ_ScreenButton143.寫入元件位置 = "";
            this.plC_RJ_ScreenButton143.按鈕型態 = MyUI.PLC_RJ_ScreenButton.StatusEnum.保持型;
            this.plC_RJ_ScreenButton143.控制位址 = "D0";
            this.plC_RJ_ScreenButton143.換頁選擇方式 = MyUI.PLC_RJ_ScreenButton.換頁選擇方式Enum.退出程式;
            this.plC_RJ_ScreenButton143.致能讀取位置 = "";
            this.plC_RJ_ScreenButton143.讀取位元反向 = false;
            this.plC_RJ_ScreenButton143.讀取位置註解 = "";
            this.plC_RJ_ScreenButton143.讀取元件位置 = "";
            this.plC_RJ_ScreenButton143.音效 = true;
            this.plC_RJ_ScreenButton143.頁面名稱 = "";
            this.plC_RJ_ScreenButton143.頁面編號 = 0;
            this.plC_RJ_ScreenButton143.顯示方式 = MyUI.PLC_RJ_ScreenButton.StateEnum.顯示為OFF;
            this.plC_RJ_ScreenButton143.顯示狀態 = false;
            this.plC_RJ_ScreenButton143.顯示讀取位置 = "";
            // 
            // saveFileDialog_SaveExcel
            // 
            this.saveFileDialog_SaveExcel.DefaultExt = "txt";
            this.saveFileDialog_SaveExcel.Filter = "Excel File (*.xls)|*.xls|txt File (*.txt)|*.txt;";
            // 
            // openFileDialog_LoadExcel
            // 
            this.openFileDialog_LoadExcel.DefaultExt = "txt";
            this.openFileDialog_LoadExcel.Filter = "Excel File (*.xls)|*.xls|txt File (*.txt)|*.txt;";
            // 
            // plC_AlarmFlow1
            // 
            this.plC_AlarmFlow1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plC_AlarmFlow1.Location = new System.Drawing.Point(0, 1015);
            this.plC_AlarmFlow1.Name = "plC_AlarmFlow1";
            this.plC_AlarmFlow1.Size = new System.Drawing.Size(1904, 26);
            this.plC_AlarmFlow1.TabIndex = 124;
            this.plC_AlarmFlow1.Visible = false;
            this.plC_AlarmFlow1.捲動速度 = 200;
            this.plC_AlarmFlow1.文字字體 = new System.Drawing.Font("標楷體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.plC_AlarmFlow1.文字顏色 = System.Drawing.Color.White;
            this.plC_AlarmFlow1.自動隱藏 = false;
            this.plC_AlarmFlow1.警報編輯 = ((System.Collections.Generic.List<string>)(resources.GetObject("plC_AlarmFlow1.警報編輯")));
            this.plC_AlarmFlow1.顯示警報編號 = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.plC_ScreenPage_Main);
            this.Controls.Add(this.panel_Main);
            this.Controls.Add(this.plC_AlarmFlow1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "智能落藥櫃系統";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plC_ScreenPage_Main.ResumeLayout(false);
            this.領藥作業.ResumeLayout(false);
            this.rJ_GroupBox4.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_領藥台_01_藥品圖片)).EndInit();
            this.rJ_GroupBox_領藥台_01.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox_領藥台_01.ResumeLayout(false);
            this.rJ_GroupBox5.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox5.ResumeLayout(false);
            this.後台登入.ResumeLayout(false);
            this.groupBox26.ResumeLayout(false);
            this.rJ_GroupBox7.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox7.ResumeLayout(false);
            this.panel185.ResumeLayout(false);
            this.panel185.PerformLayout();
            this.panel183.ResumeLayout(false);
            this.panel183.PerformLayout();
            this.交易記錄查詢.ResumeLayout(false);
            this.rJ_GroupBox23.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox23.ContentsPanel.PerformLayout();
            this.rJ_GroupBox23.ResumeLayout(false);
            this.rJ_GroupBox19.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox19.ResumeLayout(false);
            this.rJ_GroupBox18.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox18.ResumeLayout(false);
            this.rJ_GroupBox6.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox6.ContentsPanel.PerformLayout();
            this.rJ_GroupBox6.ResumeLayout(false);
            this.醫囑資料.ResumeLayout(false);
            this.醫囑資料.PerformLayout();
            this.藥品資料.ResumeLayout(false);
            this.plC_ScreenPage_藥品資料.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.plC_RJ_GroupBox2.ContentsPanel.ResumeLayout(false);
            this.plC_RJ_GroupBox2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel144.ResumeLayout(false);
            this.rJ_GroupBox13.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox13.ResumeLayout(false);
            this.rJ_Pannel5.ResumeLayout(false);
            this.rJ_Pannel4.ResumeLayout(false);
            this.rJ_Pannel3.ResumeLayout(false);
            this.rJ_Pannel2.ResumeLayout(false);
            this.rJ_GroupBox12.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox12.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel71.ResumeLayout(false);
            this.panel69.ResumeLayout(false);
            this.panel64.ResumeLayout(false);
            this.panel67.ResumeLayout(false);
            this.panel60.ResumeLayout(false);
            this.panel58.ResumeLayout(false);
            this.panel56.ResumeLayout(false);
            this.panel54.ResumeLayout(false);
            this.panel52.ResumeLayout(false);
            this.panel50.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel_藥品資料.ResumeLayout(false);
            this.人員資料.ResumeLayout(false);
            this.plC_ScreenPage_人員資料.ResumeLayout(false);
            this.資料維護.ResumeLayout(false);
            this.rJ_GroupBox15.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox15.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.panel149.ResumeLayout(false);
            this.panel149.PerformLayout();
            this.panel150.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.權限管理.ResumeLayout(false);
            this.rJ_GroupBox16.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox16.ResumeLayout(false);
            this.panel_人員資料.ResumeLayout(false);
            this.儲位管理.ResumeLayout(false);
            this.rJ_GroupBox1.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel20.ResumeLayout(false);
            this.rJ_GroupBox3.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox3.ResumeLayout(false);
            this.plC_RJ_GroupBox13.ContentsPanel.ResumeLayout(false);
            this.plC_RJ_GroupBox13.ResumeLayout(false);
            this.rJ_GroupBox2.ContentsPanel.ResumeLayout(false);
            this.rJ_GroupBox2.ResumeLayout(false);
            this.rJ_Pannel7.ResumeLayout(false);
            this.rJ_Pannel6.ResumeLayout(false);
            this.rJ_Pannel1.ResumeLayout(false);
            this.工程模式.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox19.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.系統.ResumeLayout(false);
            this.plC_ScreenPage_系統.ResumeLayout(false);
            this.設定01.ResumeLayout(false);
            this.groupBox22.ResumeLayout(false);
            this.groupBox22.PerformLayout();
            this.groupBox18.ResumeLayout(false);
            this.設定02.ResumeLayout(false);
            this.設定03.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.設定04.ResumeLayout(false);
            this.設定05.ResumeLayout(false);
            this.groupBox27.ResumeLayout(false);
            this.groupBox44.ResumeLayout(false);
            this.設定06.ResumeLayout(false);
            this.plC_RJ_GroupBox1.ContentsPanel.ResumeLayout(false);
            this.plC_RJ_GroupBox1.ResumeLayout(false);
            this.panel_系統.ResumeLayout(false);
            this.panel_Main.ResumeLayout(false);
            this.panel232.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MyUI.PLC_ScreenPage plC_ScreenPage_Main;
        private System.Windows.Forms.TabPage 領藥作業;
        private System.Windows.Forms.TabPage 後台登入;
        private System.Windows.Forms.TabPage 工程模式;
        private System.Windows.Forms.TabPage 系統;
        private System.Windows.Forms.Panel panel_Main;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_工程模式;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_儲位管理;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_人員資料;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_藥品資料_藥檔資料;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_醫囑資料;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_交易紀錄查詢;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_入庫作業;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_後台登入;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton_領藥作業;
        private System.Windows.Forms.Panel panel232;
        private MyUI.RJ_TextBox rJ_TextBox_登入者顏色;
        private MyUI.RJ_TextBox rJ_TextBox_登入者姓名;
        private MyUI.RJ_TextBox rJ_TextBox_登入者ID;
        private MyUI.RJ_Lable rJ_Lable51;
        private MyUI.RJ_Lable rJ_Lable52;
        private MyUI.PLC_RJ_Button plC_RJ_Button_後台登入_登出;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton143;
        private System.Windows.Forms.TabPage 入庫作業;
        private System.Windows.Forms.TabPage 交易記錄查詢;
        private System.Windows.Forms.TabPage 醫囑資料;
        private System.Windows.Forms.TabPage 藥品資料;
        private System.Windows.Forms.TabPage 人員資料;
        private System.Windows.Forms.TabPage 儲位管理;
        private MyUI.RJ_GroupBox rJ_GroupBox7;
        private MyUI.PLC_RJ_Button plC_RJ_Button_後台登入_登入;
        private System.Windows.Forms.Panel panel185;
        private System.Windows.Forms.TextBox textBox_後台登入_帳號;
        private System.Windows.Forms.Panel panel186;
        private System.Windows.Forms.Panel panel183;
        private System.Windows.Forms.TextBox textBox_後台登入_密碼;
        private System.Windows.Forms.Panel panel184;
        private MyUI.RJ_Lable rJ_Lable5;
        private MyUI.PLC_ScreenPage plC_ScreenPage_系統;
        private System.Windows.Forms.TabPage 設定01;
        private System.Windows.Forms.TabPage 設定02;
        private System.Windows.Forms.TabPage 設定03;
        private System.Windows.Forms.TabPage 設定04;
        private System.Windows.Forms.TabPage 設定05;
        private System.Windows.Forms.TabPage 設定06;
        private System.Windows.Forms.Panel panel_系統;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton6;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton5;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton4;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton1;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton2;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton3;
        private MyUI.PLC_UI_Init plC_UI_Init;
        private LadderUI.LowerMachine_Panel lowerMachine_Panel;
        private MySQL_Login.LoginUI loginUI;
        private MyUI.PLC_ScreenPage plC_ScreenPage_人員資料;
        private System.Windows.Forms.TabPage 資料維護;
        private System.Windows.Forms.TabPage 權限管理;
        private System.Windows.Forms.Panel panel_人員資料;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton11;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton12;
        private MyUI.PLC_RJ_Button plC_RJ_Button_人員資料_清除內容;
        private MyUI.RJ_GroupBox rJ_GroupBox15;
        private MyUI.RJ_TextBox rJ_TextBox_人員資料_識別圖案;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private MyUI.RJ_TextBox rJ_TextBox_人員資料_一維條碼;
        private System.Windows.Forms.Label label7;
        private MyUI.RJ_TextBox rJ_TextBox_人員資料_卡號;
        private MyUI.RJ_ComboBox comboBox_人員資料_權限等級;
        private MyUI.RJ_TextBox rJ_TextBox_人員資料_單位;
        private MyUI.RJ_TextBox rJ_TextBox_人員資料_密碼;
        private MyUI.RJ_TextBox rJ_TextBox_人員資料_姓名;
        private MyUI.RJ_TextBox rJ_TextBox_人員資料_ID;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.Label label144;
        private System.Windows.Forms.Label label108;
        private System.Windows.Forms.Label label138;
        private System.Windows.Forms.Label label143;
        private System.Windows.Forms.Label label102;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel149;
        private System.Windows.Forms.Panel panel150;
        private System.Windows.Forms.Button button_人員資料_顏色選擇;
        private System.Windows.Forms.TextBox textBox_人員資料_顏色;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MyUI.RJ_RatioButton rJ_RatioButton_人員資料_男;
        private MyUI.RJ_RatioButton rJ_RatioButton_人員資料_女;
        private SQLUI.SQL_DataGridView sqL_DataGridView_人員資料;
        private MyUI.PLC_RJ_Button plC_RJ_Button_人員資料_刪除;
        private MyUI.PLC_RJ_Button plC_RJ_Button_人員資料_匯出;
        private MyUI.PLC_RJ_Button plC_RJ_Button_人員資料_登錄;
        private MyUI.PLC_RJ_Button plC_RJ_Button_人員資料_匯入;
        private MyUI.RJ_GroupBox rJ_GroupBox16;
        private MyUI.PLC_RJ_Button plC_Button_權限設定_設定至Server;
        private MyUI.PLC_RJ_ComboBox plC_RJ_ComboBox_權限管理_權限等級;
        private MyUI.RJ_Lable rJ_Lable23;
        private System.Windows.Forms.GroupBox groupBox18;
        private RFID_FX600lib.RFID_FX600_UI rfiD_FX600_UI;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_SaveExcel;
        private System.Windows.Forms.OpenFileDialog openFileDialog_LoadExcel;
        private System.Windows.Forms.FontDialog fontDialog;
        private System.Windows.Forms.ColorDialog colorDialog;
        private MyUI.PLC_RJ_Button plC_RJ_Button_交易記錄查詢_顯示全部;
        private MyUI.RJ_GroupBox rJ_GroupBox23;
        private MyUI.PLC_RJ_ChechBox plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_開方時間;
        private MyUI.RJ_Lable rJ_Lable44;
        private MyUI.RJ_DatePicker dateTimePicker_交易記錄查詢_開方時間_結束;
        private System.Windows.Forms.Label label117;
        private MyUI.RJ_DatePicker dateTimePicker_交易記錄查詢_開方時間_起始;
        private MyUI.RJ_Lable rJ_Lable30;
        private MyUI.RJ_DatePicker dateTimePicker_交易記錄查詢_操作時間_結束;
        private System.Windows.Forms.Label label106;
        private MyUI.RJ_DatePicker dateTimePicker_交易記錄查詢_操作時間_起始;
        private MyUI.RJ_GroupBox rJ_GroupBox19;
        private MyUI.RJ_TextBox textBox_交易記錄查詢_操作人;
        private MyUI.RJ_Lable rJ_Lable41;
        private MyUI.RJ_TextBox textBox_交易記錄查詢_病人姓名;
        private MyUI.RJ_TextBox textBox_交易記錄查詢_病歷號;
        private MyUI.RJ_Lable rJ_Lable42;
        private MyUI.RJ_Lable rJ_Lable43;
        private MyUI.RJ_GroupBox rJ_GroupBox18;
        private MyUI.RJ_TextBox textBox_交易記錄查詢_藥品碼;
        private MyUI.RJ_Lable rJ_Lable26;
        private MyUI.RJ_TextBox textBox_交易記錄查詢_藥品名稱;
        private MyUI.RJ_TextBox textBox_交易記錄查詢_藥袋序號;
        private MyUI.RJ_TextBox textBox_交易記錄查詢_藥品條碼;
        private MyUI.RJ_Lable rJ_Lable27;
        private MyUI.RJ_Lable rJ_Lable28;
        private MyUI.RJ_Lable rJ_Lable29;
        private MyUI.RJ_GroupBox rJ_GroupBox6;
        private System.Windows.Forms.Label label3;
        private MyUI.PLC_RJ_ChechBox plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_自動過帳;
        private System.Windows.Forms.Label label123;
        private MyUI.PLC_RJ_ChechBox plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_退藥;
        private System.Windows.Forms.Label label119;
        private MyUI.PLC_RJ_ChechBox lC_RJ_ChechBox_交易紀錄查詢_搜尋條件_登入及登出;
        private System.Windows.Forms.Label label115;
        private MyUI.PLC_RJ_ChechBox plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_後臺操作;
        private System.Windows.Forms.Label label114;
        private MyUI.PLC_RJ_ChechBox plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_效期庫存異動;
        private System.Windows.Forms.Label label113;
        private MyUI.PLC_RJ_ChechBox plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_入庫;
        private System.Windows.Forms.Label label112;
        private MyUI.PLC_RJ_ChechBox plC_RJ_ChechBox_交易紀錄查詢_搜尋條件_領藥;
        private SQLUI.SQL_DataGridView sqL_DataGridView_交易記錄查詢;
        private MySQL_Login.LoginIndex_Pannel loginIndex_Pannel;
        private MyUI.PLC_ScreenPage plC_ScreenPage_藥品資料;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel_藥品資料;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton8;
        private SQLUI.SQL_DataGridView sqL_DataGridView_藥品資料_藥檔資料;
        private MyUI.RJ_TextBox rJ_TextBox_醫囑資料_搜尋條件_藥袋條碼;
        private MyUI.PLC_RJ_Button plC_RJ_Button_醫囑資料_設為未過帳;
        private MyUI.PLC_RJ_Button plC_RJ_Button_醫囑資料_設定產出時間;
        private MyUI.PLC_RJ_Button plC_RJ_Button_醫囑資料_自動過帳;
        private MyUI.PLC_RJ_Button plC_RJ_Button_醫囑資料_搜尋條件_藥袋條碼_搜尋;
        private MyUI.RJ_Lable rJ_Lable119;
        private MyUI.RJ_TextBox rJ_TextBox_醫囑資料_搜尋條件_藥品碼;
        private MyUI.RJ_Lable rJ_Lable115;
        private MyUI.RJ_TextBox rJ_TextBox_醫囑資料_搜尋條件_病歷號;
        private MyUI.RJ_TextBox rJ_TextBox_醫囑資料_搜尋條件_藥品名稱;
        private MyUI.RJ_Lable rJ_Lable114;
        private MyUI.RJ_Lable rJ_Lable116;
        private MyUI.RJ_DatePicker dateTimePicke_醫囑資料_開方日期_起始;
        private System.Windows.Forms.Label label8;
        private MyUI.RJ_DatePicker dateTimePicke_醫囑資料_開方日期_結束;
        private MyUI.RJ_Lable rJ_Lable111;
        private MyUI.PLC_RJ_Button plC_RJ_Button_醫囑資料_顯示全部;
        private SQLUI.SQL_DataGridView sqL_DataGridView_醫囑資料;
        private H_Pannel_lib.RowsLEDUI rowsLEDUI;
        private MyUI.PLC_RJ_ScreenButton plC_RJ_ScreenButton9;
        private System.Windows.Forms.Panel panel1;
        private MyUI.PLC_Button plC_Button28;
        private MyUI.PLC_Button plC_Button26;
        private MyUI.PLC_Button plC_Button24;
        private MyUI.PLC_Button plC_Button14;
        private MyUI.PLC_Button plC_Button16;
        private MyUI.PLC_Button plC_Button18;
        private MyUI.PLC_Button plC_Button20;
        private MyUI.PLC_Button plC_Button22;
        private MyUI.PLC_Button plC_Button12;
        private MyUI.PLC_Button plC_Button10;
        private MyUI.PLC_Button plC_Button8;
        private MyUI.PLC_Button plC_Button6;
        private MyUI.PLC_Button plC_Button4;
        private MyUI.PLC_Button plC_Button1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private MyUI.PLC_Button plC_Button27;
        private MyUI.PLC_Button plC_Button25;
        private MyUI.PLC_Button plC_Button23;
        private MyUI.PLC_Button plC_Button13;
        private MyUI.PLC_Button plC_Button15;
        private MyUI.PLC_Button plC_Button17;
        private MyUI.PLC_Button plC_Button19;
        private MyUI.PLC_Button plC_Button21;
        private MyUI.PLC_Button plC_Button11;
        private MyUI.PLC_Button plC_Button9;
        private MyUI.PLC_Button plC_Button7;
        private MyUI.PLC_Button plC_Button5;
        private MyUI.PLC_Button plC_Button3;
        private MyUI.PLC_Button plC_Button2;
        private System.Windows.Forms.Panel panel5;
        private MyUI.PLC_Button plC_Button29;
        private MyUI.PLC_Button plC_Button30;
        private MyUI.PLC_Button plC_Button31;
        private MyUI.PLC_Button plC_Button32;
        private MyUI.PLC_Button plC_Button33;
        private MyUI.PLC_Button plC_Button34;
        private MyUI.PLC_Button plC_Button35;
        private MyUI.PLC_Button plC_Button36;
        private MyUI.PLC_Button plC_Button37;
        private MyUI.PLC_Button plC_Button38;
        private MyUI.PLC_Button plC_Button39;
        private MyUI.PLC_Button plC_Button40;
        private MyUI.PLC_Button plC_Button41;
        private MyUI.PLC_Button plC_Button42;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private MyUI.PLC_Button plC_Button43;
        private MyUI.PLC_Button plC_Button44;
        private MyUI.PLC_Button plC_Button45;
        private MyUI.PLC_Button plC_Button46;
        private MyUI.PLC_Button plC_Button47;
        private MyUI.PLC_Button plC_Button48;
        private MyUI.PLC_Button plC_Button49;
        private MyUI.PLC_Button plC_Button50;
        private MyUI.PLC_Button plC_Button51;
        private MyUI.PLC_Button plC_Button52;
        private MyUI.PLC_Button plC_Button53;
        private MyUI.PLC_Button plC_Button54;
        private MyUI.PLC_Button plC_Button55;
        private MyUI.PLC_Button plC_Button56;
        private System.Windows.Forms.Panel panel8;
        private MyUI.PLC_Button plC_Button57;
        private MyUI.PLC_Button plC_Button58;
        private MyUI.PLC_Button plC_Button59;
        private MyUI.PLC_Button plC_Button60;
        private MyUI.PLC_Button plC_Button61;
        private MyUI.PLC_Button plC_Button62;
        private MyUI.PLC_Button plC_Button63;
        private MyUI.PLC_Button plC_Button64;
        private MyUI.PLC_Button plC_Button65;
        private MyUI.PLC_Button plC_Button66;
        private MyUI.PLC_Button plC_Button67;
        private MyUI.PLC_Button plC_Button68;
        private MyUI.PLC_Button plC_Button69;
        private MyUI.PLC_Button plC_Button70;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private MyUI.PLC_Button plC_Button71;
        private MyUI.PLC_Button plC_Button72;
        private MyUI.PLC_Button plC_Button73;
        private MyUI.PLC_Button plC_Button74;
        private MyUI.PLC_Button plC_Button75;
        private MyUI.PLC_Button plC_Button76;
        private MyUI.PLC_Button plC_Button77;
        private MyUI.PLC_Button plC_Button78;
        private MyUI.PLC_Button plC_Button79;
        private MyUI.PLC_Button plC_Button80;
        private MyUI.PLC_Button plC_Button81;
        private MyUI.PLC_Button plC_Button82;
        private MyUI.PLC_Button plC_Button83;
        private MyUI.PLC_Button plC_Button84;
        private System.Windows.Forms.Panel panel11;
        private MyUI.PLC_Button plC_Button85;
        private MyUI.PLC_Button plC_Button86;
        private MyUI.PLC_Button plC_Button87;
        private MyUI.PLC_Button plC_Button88;
        private MyUI.PLC_Button plC_Button89;
        private MyUI.PLC_Button plC_Button90;
        private MyUI.PLC_Button plC_Button91;
        private MyUI.PLC_Button plC_Button92;
        private MyUI.PLC_Button plC_Button93;
        private MyUI.PLC_Button plC_Button94;
        private MyUI.PLC_Button plC_Button95;
        private MyUI.PLC_Button plC_Button96;
        private MyUI.PLC_Button plC_Button97;
        private MyUI.PLC_Button plC_Button98;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private MyUI.PLC_Button plC_Button99;
        private MyUI.PLC_Button plC_Button100;
        private MyUI.PLC_Button plC_Button101;
        private MyUI.PLC_Button plC_Button102;
        private MyUI.PLC_Button plC_Button103;
        private MyUI.PLC_Button plC_Button104;
        private MyUI.PLC_Button plC_Button105;
        private MyUI.PLC_Button plC_Button106;
        private MyUI.PLC_Button plC_Button107;
        private MyUI.PLC_Button plC_Button108;
        private MyUI.PLC_Button plC_Button109;
        private MyUI.PLC_Button plC_Button110;
        private MyUI.PLC_Button plC_Button111;
        private MyUI.PLC_Button plC_Button112;
        private System.Windows.Forms.Panel panel14;
        private MyUI.PLC_Button plC_Button113;
        private MyUI.PLC_Button plC_Button114;
        private MyUI.PLC_Button plC_Button115;
        private MyUI.PLC_Button plC_Button116;
        private MyUI.PLC_Button plC_Button117;
        private MyUI.PLC_Button plC_Button118;
        private MyUI.PLC_Button plC_Button119;
        private MyUI.PLC_Button plC_Button120;
        private MyUI.PLC_Button plC_Button121;
        private MyUI.PLC_Button plC_Button122;
        private MyUI.PLC_Button plC_Button123;
        private MyUI.PLC_Button plC_Button124;
        private MyUI.PLC_Button plC_Button125;
        private MyUI.PLC_Button plC_Button126;
        private System.Windows.Forms.Panel panel15;
        private MyUI.PLC_Button plC_Button127;
        private MyUI.PLC_Button plC_Button128;
        private MyUI.PLC_Button plC_Button129;
        private MyUI.PLC_Button plC_Button130;
        private MyUI.PLC_Button plC_Button131;
        private MyUI.PLC_Button plC_Button132;
        private MyUI.PLC_Button plC_Button133;
        private MyUI.PLC_Button plC_Button134;
        private MyUI.PLC_Button plC_Button135;
        private MyUI.PLC_Button plC_Button136;
        private MyUI.PLC_Button plC_Button137;
        private MyUI.PLC_Button plC_Button138;
        private MyUI.PLC_Button plC_Button139;
        private MyUI.PLC_Button plC_Button140;
        private System.Windows.Forms.Panel panel16;
        private H_Pannel_lib.RowsLED_Pannel rowsLED_Pannel_工程模式;
        private MyUI.RJ_GroupBox rJ_GroupBox_領藥台_01;
        private MyUI.PLC_RJ_Button plC_RJ_Button_領藥台_01_強制入帳;
        private MyUI.PLC_RJ_Button plC_RJ_Button_領藥台_01_手輸醫囑;
        private MyUI.PLC_RJ_Button plC_RJ_Button_領藥台_01_手動作業;
        private MyUI.RJ_ProgressBar rJ_ProgressBar_領藥台_01_入賬完成時間條;
        private MyUI.PLC_RJ_Button plC_RJ_Button_領藥台_01_取消作業;
        private MyUI.PLC_Button plC_Button_領藥台_01_退;
        private MyUI.PLC_Button plC_Button_領藥台_01_領;
        private MyUI.PLC_RJ_Button plC_RJ_Button_領藥台_01_登出;
        private MyUI.RJ_ProgressBar rJ_ProgressBar_領藥台_01_閒置登出時間條;
        private MyUI.PLC_MultiStateDisplay plC_MultiStateDisplay_領藥台_01_狀態顯示;
        private SQLUI.SQL_DataGridView sqL_DataGridView_領藥台_01_領藥內容;
        private MyUI.RJ_GroupBox rJ_GroupBox5;
        private MyUI.PLC_RJ_Button plC_RJ_Button_領藥台_01_登入;
        private MyUI.RJ_TextBox textBox_領藥台_01_帳號;
        private MyUI.RJ_TextBox textBox_領藥台_01_密碼;
        private System.Windows.Forms.GroupBox groupBox27;
        private SQLUI.SQL_DataGridView sqL_DataGridView_取藥堆疊子資料;
        private System.Windows.Forms.GroupBox groupBox44;
        private SQLUI.SQL_DataGridView sqL_DataGridView_取藥堆疊母資料;
        private MyUI.PLC_RJ_GroupBox plC_RJ_GroupBox1;
        private SQLUI.SQL_DataGridView sqL_DataGridView_雲端藥檔;
        private MyUI.PLC_RJ_Button plC_RJ_Button_雲端藥檔_取得資料;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage6;
        private LeadShineUI.IOC1280 ioC12801;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage7;
        private SLDUI.C1230 c12301;
        private MyUI.PLC_Button plC_Button_LED全亮;
        private MyUI.PLC_Button plC_Button142;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.Label label118;
        private MyUI.PLC_NumBox plC_NumBox6;
        private MyUI.PLC_Button plC_Button_重複領藥不檢查;
        private MyUI.PLC_Button plC_Button_取藥門關;
        private MyUI.PLC_Button plC_Button_取藥門開;
        private MyUI.PLC_RJ_Button plC_RJ_Button_掃碼測試;
        private System.Windows.Forms.GroupBox groupBox22;
        private System.Windows.Forms.TextBox textBox_工程模式_設備名稱_名稱;
        private MyUI.RJ_Lable rJ_Lable45;
        private System.Windows.Forms.Button button_工程模式_調劑台名稱儲存;
        private System.Windows.Forms.GroupBox groupBox26;
        private MyUI.PLC_RJ_Button plC_RJ_Button_系統更新;
        private MyFtpUI.Ftp_DounloadUI ftp_DounloadUI;
        private MyUI.PLC_Button plC_Button_下門鎖;
        private MyUI.PLC_Button plC_Button_上門鎖;
        private MyUI.PLC_AlarmFlow plC_AlarmFlow1;
        private MyUI.PLC_RJ_Button plC_RJ_Button_藥物辨識圖片測試;
        private MyUI.RJ_GroupBox rJ_GroupBox4;
        private System.Windows.Forms.PictureBox pictureBox_領藥台_01_藥品圖片;
        private MyUI.PLC_RJ_GroupBox plC_RJ_GroupBox2;
        private MyUI.PLC_RJ_Button plC_RJ_Button_藥品群組_登錄;
        private System.Windows.Forms.Panel panel2;
        private MyUI.RJ_Lable rJ_Lable1;
        private MyUI.RJ_TextBox rJ_TextBox_藥品群組_群組序號;
        private System.Windows.Forms.Panel panel144;
        private MyUI.RJ_Lable rJ_Lable2;
        private MyUI.RJ_TextBox rJ_TextBox_藥品群組_群組名稱;
        private MyUI.RJ_GroupBox rJ_GroupBox13;
        private MyUI.PLC_RJ_Button plC_RJ_Button_藥品資料_顯示有儲位藥品;
        private MyUI.PLC_RJ_Button plC_RJ_Button_藥品資料_藥檔資料_資料查詢;
        private MyUI.PLC_RJ_Button plC_RJ_Button_藥品資料_匯出;
        private MyUI.PLC_RJ_Button plC_RJ_Button_藥品資料_匯入;
        private MyUI.RJ_Pannel rJ_Pannel5;
        private MyUI.RJ_TextBox textBox_藥品資料_藥檔資料_資料查詢_藥品條碼;
        private MyUI.RJ_Lable rJ_Lable20;
        private MyUI.RJ_Pannel rJ_Pannel4;
        private MyUI.PLC_RJ_ChechBox plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組;
        private MyUI.RJ_ComboBox rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組;
        private MyUI.RJ_Lable rJ_Lable19;
        private MyUI.RJ_Pannel rJ_Pannel3;
        private MyUI.RJ_TextBox textBox_藥品資料_藥檔資料_資料查詢_藥品名稱;
        private MyUI.RJ_Lable rJ_Lable18;
        private MyUI.RJ_Pannel rJ_Pannel2;
        private MyUI.RJ_TextBox textBox_藥品資料_藥檔資料_資料查詢_藥品碼;
        private MyUI.RJ_Lable rJ_Lable17;
        private MyUI.RJ_GroupBox rJ_GroupBox12;
        private MyUI.PLC_RJ_Button plC_RJ_Button_藥品資料_HIS下載全部藥檔;
        private MyUI.PLC_RJ_Button plC_RJ_Button_藥品資料_HIS填入;
        private MyUI.PLC_RJ_Button plC_RJ_Button_藥品資料_刪除;
        private MyUI.PLC_RJ_Button plC_RJ_Button_藥品資料_更新藥櫃資料;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel71;
        private MyUI.RJ_ComboBox comboBox_藥品資料_藥檔資料_警訊藥品;
        private System.Windows.Forms.Panel panel72;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Panel panel69;
        private MyUI.RJ_TextBox textBox_藥品資料_藥檔資料_安全庫存;
        private System.Windows.Forms.Panel panel70;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel64;
        private MyUI.RJ_TextBox textBox_藥品資料_藥檔資料_庫存;
        private System.Windows.Forms.Panel panel65;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel67;
        private MyUI.RJ_TextBox textBox_藥品資料_藥檔資料_包裝單位;
        private System.Windows.Forms.Panel panel68;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Panel panel60;
        private MyUI.RJ_TextBox textBox_藥品資料_藥檔資料_藥品條碼;
        private System.Windows.Forms.Panel panel63;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Panel panel58;
        private MyUI.RJ_TextBox textBox_藥品資料_藥檔資料_健保碼;
        private System.Windows.Forms.Panel panel59;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel56;
        private MyUI.RJ_ComboBox rJ_ComboBox_藥品資料_藥檔資料_藥品群組;
        private System.Windows.Forms.Panel panel57;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel54;
        private MyUI.RJ_TextBox textBox_藥品資料_藥檔資料_藥品中文名稱;
        private System.Windows.Forms.Panel panel55;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel52;
        private MyUI.RJ_TextBox textBox_藥品資料_藥檔資料_藥品學名;
        private System.Windows.Forms.Panel panel53;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel50;
        private MyUI.RJ_TextBox textBox_藥品資料_藥檔資料_藥品名稱;
        private System.Windows.Forms.Panel panel51;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel18;
        private MyUI.RJ_TextBox textBox_藥品資料_藥檔資料_藥品碼;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label21;
        private MyUI.PLC_RJ_Button plC_RJ_Button_藥品資料_登錄;
        private SQLUI.SQL_DataGridView sqL_DataGridView_藥品群組;
        private MyUI.RJ_GroupBox rJ_GroupBox1;
        private MyUI.PLC_Button plC_Button143;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位設定_出料一次;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位設定_滅燈;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位設定_亮燈;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位設定_亮燈範圍填入;
        private System.Windows.Forms.GroupBox groupBox1;
        private MyUI.RJ_RatioButton rJ_RatioButton_儲位管理_第一層;
        private MyUI.RJ_RatioButton rJ_RatioButton_儲位管理_第二層;
        private MyUI.RJ_RatioButton rJ_RatioButton_儲位管理_第三層;
        private MyUI.RJ_RatioButton rJ_RatioButton_儲位管理_第四層;
        private MyUI.RJ_RatioButton rJ_RatioButton_儲位管理_第五層;
        private H_Pannel_lib.RowsLED_Pannel rowsLED_Pannel_儲位管理_儲位號碼;
        private MyUI.PLC_NumBox plC_NumBox_儲位管理_起始號碼;
        private MyUI.RJ_Lable rJ_Lable4;
        private MyUI.RJ_Lable rJ_Lable3;
        private MyUI.PLC_NumBox plC_NumBox_儲位管理_結束號碼;
        private System.Windows.Forms.Panel panel20;
        private MyUI.RJ_GroupBox rJ_GroupBox3;
        private MyUI.PLC_RJ_GroupBox plC_RJ_GroupBox13;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位管理_儲位資訊_修正批號;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位管理_儲位資訊_修正庫存;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位管理_儲位資訊_新增效期;
        private SQLUI.SQL_DataGridView sqL_DataGridView_儲位管理_儲位資訊_效期及庫存;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位管理_儲位資訊_更新;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位管理_儲位資訊_刪除儲位;
        private SQLUI.SQL_DataGridView sqL_DataGridView_儲位管理_儲位資訊;
        private MyUI.RJ_GroupBox rJ_GroupBox2;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位管理_藥品資料_顯示全部;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位管理_藥品資料_新增儲位;
        private MyUI.RJ_Pannel rJ_Pannel7;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位管理_藥品資料_中文名稱搜尋;
        private MyUI.RJ_TextBox rJ_TextBox_儲位管理_藥品資料_中文名稱;
        private MyUI.RJ_Lable rJ_Lable8;
        private MyUI.RJ_Pannel rJ_Pannel6;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位管理_藥品資料_藥品名稱搜尋;
        private MyUI.RJ_TextBox rJ_TextBox_儲位管理_藥品資料_藥品名稱;
        private MyUI.RJ_Lable rJ_Lable7;
        private MyUI.RJ_Pannel rJ_Pannel1;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位管理_藥品資料_藥品碼搜尋;
        private MyUI.RJ_TextBox rJ_TextBox_儲位管理_藥品資料_藥品碼;
        private MyUI.RJ_Lable rJ_Lable6;
        private SQLUI.SQL_DataGridView sqL_DataGridView_儲位管理_藥品資料;
        private MyUI.PLC_RJ_Button plC_RJ_Button_交易記錄查詢_刪除;
        private MyUI.PLC_RJ_Button plC_RJ_Button_儲位管理_儲位資訊_新增庫存;
    }
}

