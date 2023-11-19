﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyUI;
using Basic;
using H_Pannel_lib;
using System.Diagnostics;//記得取用 FileVersionInfo繼承
using System.Reflection;//記得取用 Assembly繼承

namespace 智能落藥櫃系統
{
    public enum ContextMenuStrip_藥品資料_藥檔資料
    {
        [Description("S39007")]
        匯出,
        [Description("S39007")]
        匯入,
        [Description("S39007")]
        匯出選取資料,
        [Description("S39007")]
        登錄資料,
        [Description("S39007")]
        刪除選取資料,
        [Description("S39007")]
        設定安全庫存,
        [Description("S39021")]
        藥品群組設定,
    }

    public enum enum_藥品資料_藥檔資料
    {
        GUID,
        藥品碼,
        藥品中文名稱,
        藥品名稱,
        藥品學名,
        藥品群組,
        健保碼,
        藥品條碼,
        包裝單位,
        庫存,
        安全庫存,
        圖片網址,
        警訊藥品,
    }
    public enum enum_藥品資料_藥檔資料_匯入
    {
        藥品碼,
        藥品中文名稱,
        藥品名稱,
        藥品學名,
        藥品群組,
        健保碼,
        藥品條碼,
        包裝單位,
        庫存,
        安全庫存,
        警訊藥品,
    }
    public enum enum_藥品資料_藥檔資料_匯出
    {
        藥品碼,
        藥品中文名稱,
        藥品名稱,
        藥品學名,
        藥品群組,
        健保碼,
        藥品條碼,
        包裝單位,
        庫存,
        安全庫存,
        警訊藥品,
    }
    public enum enum_藥品群組
    {
        GUID,
        群組序號,
        群組名稱,
    }

    public partial class Form1 : Form
    {

        private void Program_藥品資料_藥檔資料_Init()
        {


  

            this.textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.KeyPress += TextBox_藥品資料_藥檔資料_資料查詢_藥品條碼_KeyPress;

            this.sqL_DataGridView_藥品資料_藥檔資料.Init();
            if (!this.sqL_DataGridView_藥品資料_藥檔資料.SQL_IsTableCreat())
            {
                this.sqL_DataGridView_藥品資料_藥檔資料.SQL_CreateTable();
            }
            this.sqL_DataGridView_藥品資料_藥檔資料.RowEnterEvent += SqL_DataGridView_藥品資料_藥檔資料_RowEnterEvent;
            this.sqL_DataGridView_藥品資料_藥檔資料.RowDoubleClickEvent += SqL_DataGridView_藥品資料_藥檔資料_RowDoubleClickEvent;
            this.sqL_DataGridView_藥品資料_藥檔資料.MouseDown += SqL_DataGridView_藥品資料_藥檔資料_MouseDown;
            this.sqL_DataGridView_藥品資料_藥檔資料.DataGridRefreshEvent += sqL_DataGridView_藥品資料_藥檔資料_DataGridRefreshEvent;
            this.sqL_DataGridView_藥品資料_藥檔資料.DataGridRowsChangeEvent += SqL_DataGridView_藥品資料_藥檔資料_DataGridRowsChangeEvent;
            this.comboBox_藥品資料_藥檔資料_警訊藥品.SelectedIndex = 0;

            this.plC_RJ_Button_藥品資料_藥檔資料_資料查詢.MouseDownEvent += PlC_RJ_Button_藥品資料_藥檔資料_資料查詢_MouseDownEvent;

            this.plC_RJ_Button_藥品資料_匯入.MouseDownEvent += PlC_RJ_Button_藥品資料_匯入_MouseDownEvent;
            this.plC_RJ_Button_藥品資料_匯出.MouseDownEvent += PlC_RJ_Button_藥品資料_匯出_MouseDownEvent;
            this.plC_RJ_Button_藥品資料_登錄.MouseDownEvent += PlC_RJ_Button_藥品資料_登錄_MouseDownEvent;
            this.plC_RJ_Button_藥品資料_刪除.MouseDownEvent += PlC_RJ_Button_藥品資料_刪除_MouseDownEvent;
            this.plC_RJ_Button_藥品資料_顯示有儲位藥品.MouseDownEvent += PlC_RJ_Button_藥品資料_顯示有儲位藥品_MouseDownEvent;
            this.plC_RJ_Button_藥品資料_HIS填入.MouseDownEvent += PlC_RJ_Button_藥品資料_HIS填入_MouseDownEvent;
            this.plC_RJ_Button_藥品資料_更新藥櫃資料.MouseDownEvent += PlC_RJ_Button_藥品資料_更新藥櫃資料_MouseDownEvent;
            this.plC_RJ_Button_藥品資料_HIS下載全部藥檔.MouseDownEvent += PlC_RJ_Button_藥品資料_HIS下載全部藥檔_MouseDownEvent;

            this.plC_UI_Init.Add_Method(this.sub_Program_藥品資料_藥檔資料);
        }



        bool flag_藥品資料_藥檔資料_頁面更新 = false;
        private void sub_Program_藥品資料_藥檔資料()
        {
            if (this.plC_ScreenPage_Main.PageText == "藥品資料" && this.plC_ScreenPage_藥品資料.PageText == "藥檔資料")
            {
                if (!this.flag_藥品資料_藥檔資料_頁面更新)
                {
                    this.Function_從SQL取得儲位到本地資料();
            
                    this.flag_藥品資料_藥檔資料_頁面更新 = true;
                }
                if(this.MySerialPort_Scanner.ReadByte() != null)
                {
                    string text = this.MySerialPort_Scanner.ReadString();
                    if(text != null)
                    {
                        MySerialPort_Scanner.ClearReadByte();
                        this.Invoke(new Action(delegate
                        {
                            text = text.Replace("\n\r", "");
                            textBox_藥品資料_藥檔資料_藥品條碼.Text = text;
                        }));
                    }
                }
            }
            else
            {
                this.flag_藥品資料_藥檔資料_頁面更新 = false;
            }
        }

        #region Function

        public string Function_藥品資料_藥檔資料_從藥品條碼取得藥品碼(string 藥品條碼)
        {
            string str = null;
            List<object[]> list_obj = this.sqL_DataGridView_藥品資料_藥檔資料.SQL_GetRows(enum_藥品資料_藥檔資料.藥品條碼.GetEnumName(), 藥品條碼, false);
            if (list_obj.Count > 0)
            {
                str = list_obj[0][(int)enum_藥品資料_藥檔資料.藥品碼].ObjectToString();
            }
            return str;
        }
        private bool Function_藥品資料_藥檔資料_確認欄位正確(object[] SQL_Data, bool IsMyMessageBoxShow)
        {
            bool flag_OK = false;
            List<string> List_error_msg = new List<string>();
            string str_error_msg = "";
            if (SQL_Data[(int)enum_藥品資料_藥檔資料.藥品碼].ObjectToString().StringIsEmpty())
            {
                List_error_msg.Add("'藥品碼'欄位空白");
            }
            //if (SQL_Data[(int)enum_藥品資料_藥檔資料.藥品條碼].ObjectToString().StringIsEmpty())
            //{
            //    List_error_msg.Add("'藥品條碼'欄位空白");
            //}
            //if (SQL_Data[(int)enum_藥品資料_藥檔資料.藥品名稱].ObjectToString().StringIsEmpty())
            //{
            //    List_error_msg.Add("'藥品名稱'欄位空白");
            //}
            //if (SQL_Data[(int)enum_藥品資料_藥檔資料.健保碼].ObjectToString().StringIsEmpty())
            //{
            //    List_error_msg.Add("'健保碼'欄位空白");
            //}

            if (SQL_Data[(int)enum_藥品資料_藥檔資料.庫存].ObjectToString().StringToInt32() < 0)
            {
                SQL_Data[(int)enum_藥品資料_藥檔資料.庫存] = "0";
            }

            if (SQL_Data[(int)enum_藥品資料_藥檔資料.安全庫存].ObjectToString().StringToInt32() < 0)
            {
                SQL_Data[(int)enum_藥品資料_藥檔資料.安全庫存] = "0";
            }
            for (int i = 0; i < List_error_msg.Count; i++)
            {
                str_error_msg += i.ToString("00") + ". " + List_error_msg[i] + "\n\r";
            }
            if (str_error_msg == "") flag_OK = true;
            else
            {
                if (IsMyMessageBoxShow) MyMessageBox.ShowDialog(str_error_msg);
            }
            return flag_OK;
        }

        private string Function_藥品資料_藥檔資料_檢查內容(object[] value)
        {
            string str_error = "";
            List<string> list_error = new List<string>();
            if (value[(int)enum_藥品資料_藥檔資料.藥品碼].ObjectToString().StringIsEmpty())
            {
                list_error.Add("'藥品碼'欄位不得空白!");
            }
            for (int i = 0; i < list_error.Count; i++)
            {
                str_error += $"{(i + 1).ToString("00")}. {list_error[i]}";
                if (i != list_error.Count - 1) str_error += "\n";
            }
            return str_error;
        }
        private void Function_藥品資料_藥檔資料_登錄()
        {
            object[] value = new object[new enum_藥品資料_藥檔資料().GetLength()];
            string Code = Function_藥品碼檢查(this.textBox_藥品資料_藥檔資料_藥品碼.Text);
            value[(int)enum_藥品資料_藥檔資料.藥品碼] = Code;
            value[(int)enum_藥品資料_藥檔資料.藥品名稱] = this.textBox_藥品資料_藥檔資料_藥品名稱.Text;
            value[(int)enum_藥品資料_藥檔資料.藥品學名] = this.textBox_藥品資料_藥檔資料_藥品學名.Text;
            value[(int)enum_藥品資料_藥檔資料.藥品中文名稱] = this.textBox_藥品資料_藥檔資料_藥品中文名稱.Text;
            value[(int)enum_藥品資料_藥檔資料.藥品群組] = this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.SelectedIndex;
            value[(int)enum_藥品資料_藥檔資料.健保碼] = this.textBox_藥品資料_藥檔資料_健保碼.Text;
            value[(int)enum_藥品資料_藥檔資料.藥品條碼] = this.textBox_藥品資料_藥檔資料_藥品條碼.Text;
            value[(int)enum_藥品資料_藥檔資料.包裝單位] = this.textBox_藥品資料_藥檔資料_包裝單位.Text;
            value[(int)enum_藥品資料_藥檔資料.庫存] = this.textBox_藥品資料_藥檔資料_庫存.Text;
            value[(int)enum_藥品資料_藥檔資料.安全庫存] = this.textBox_藥品資料_藥檔資料_安全庫存.Text;
            value[(int)enum_藥品資料_藥檔資料.警訊藥品] = this.comboBox_藥品資料_藥檔資料_警訊藥品.Texts;
            if (this.Function_藥品資料_藥檔資料_確認欄位正確(value, true))
            {
                List<object[]> list_value = this.sqL_DataGridView_藥品資料_藥檔資料.SQL_GetRows(enum_藥品資料_藥檔資料.藥品碼.GetEnumName(), this.textBox_藥品資料_藥檔資料_藥品碼.Text, false);
                if (list_value.Count > 0)
                {
                    value[(int)enum_藥品資料_藥檔資料.GUID] = list_value[0][(int)enum_藥品資料_藥檔資料.GUID].ObjectToString();
                    this.sqL_DataGridView_藥品資料_藥檔資料.SQL_Replace((int)enum_藥品資料_藥檔資料.GUID, value[(int)enum_藥品資料_藥檔資料.GUID].ObjectToString(), value, false);
                    this.sqL_DataGridView_藥品資料_藥檔資料.ReplaceExtra(value, true);
                }
                else
                {
                    value[(int)enum_藥品資料_藥檔資料.GUID] = Guid.NewGuid().ToString();
                    this.sqL_DataGridView_藥品資料_藥檔資料.SQL_AddRow(value, false);
                    this.sqL_DataGridView_藥品資料_藥檔資料.AddRow(value, true);
                }
                this.Function_藥品資料_藥檔資料_清除攔位();
            }
        }
        private void Function_藥品資料_藥檔資料_清除攔位()
        {
            this.Invoke(new Action(delegate
            {
                this.textBox_藥品資料_藥檔資料_藥品碼.Text = "";
                this.textBox_藥品資料_藥檔資料_藥品名稱.Text = "";
                this.textBox_藥品資料_藥檔資料_藥品學名.Text = "";
                this.textBox_藥品資料_藥檔資料_藥品中文名稱.Text = "";
                this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.SelectedIndex = 0;
                this.textBox_藥品資料_藥檔資料_健保碼.Text = "";
                this.textBox_藥品資料_藥檔資料_庫存.Text = "";
                this.textBox_藥品資料_藥檔資料_安全庫存.Text = "";
                this.textBox_藥品資料_藥檔資料_包裝單位.Text = "";
                this.textBox_藥品資料_藥檔資料_藥品條碼.Text = "";
                this.comboBox_藥品資料_藥檔資料_警訊藥品.SelectedIndex = 0;
            }));

        }
        private void Function_藥品資料_藥檔資料_匯出()
        {
            saveFileDialog_SaveExcel.OverwritePrompt = false;
            if (saveFileDialog_SaveExcel.ShowDialog(this) == DialogResult.OK)
            {
                DataTable datatable = new DataTable();
                datatable = sqL_DataGridView_藥品資料_藥檔資料.GetDataTable();
                datatable = datatable.ReorderTable(new enum_藥品資料_藥檔資料_匯出());
                string Extension = System.IO.Path.GetExtension(this.saveFileDialog_SaveExcel.FileName);
                if (Extension == ".txt")
                {
                    CSVHelper.SaveFile(datatable, this.saveFileDialog_SaveExcel.FileName);
                    MyMessageBox.ShowDialog("匯出完成!");
                }
                else if (Extension == ".xls")
                {
                    MyOffice.ExcelClass.NPOI_SaveFile(datatable, this.saveFileDialog_SaveExcel.FileName);
                    MyMessageBox.ShowDialog("匯出完成!");
                }

            }
        }
        private void Function_藥品資料_藥檔資料_匯入()
        {
            if (openFileDialog_LoadExcel.ShowDialog(this) == DialogResult.OK)
            {
                this.Cursor = Cursors.WaitCursor;

                DataTable dataTable = new DataTable();
                string Extension = System.IO.Path.GetExtension(this.openFileDialog_LoadExcel.FileName);

                if (Extension == ".txt")
                {
                    CSVHelper.LoadFile(this.openFileDialog_LoadExcel.FileName, 0, dataTable);
                }
                else if (Extension == ".xls")
                {
                    dataTable = MyOffice.ExcelClass.NPOI_LoadFile(this.openFileDialog_LoadExcel.FileName);
                }
                if (dataTable == null)
                {
                    MyMessageBox.ShowDialog("匯入失敗,請檢查是否檔案開啟中!");
                    this.Cursor = Cursors.Default;
                    return;
                }
                DataTable datatable_buf = dataTable.ReorderTable(new enum_藥品資料_藥檔資料_匯入());
                if (datatable_buf == null)
                {
                    MyMessageBox.ShowDialog("匯入檔案,資料錯誤!");
                    this.Cursor = Cursors.Default;
                    return;
                }
                List<object[]> list_LoadValue = datatable_buf.DataTableToRowList();
                List<object[]> list_SQL_Value = this.sqL_DataGridView_藥品資料_藥檔資料.SQL_GetAllRows(false);
                List<object[]> list_Add = new List<object[]>();
                List<object[]> list_Delete_ColumnName = new List<object[]>();
                List<object[]> list_Delete_SerchValue = new List<object[]>();
                List<string> list_Replace_SerchValue = new List<string>();
                List<object[]> list_Replace_Value = new List<object[]>();
                List<object[]> list_SQL_Value_buf = new List<object[]>();

                for (int i = 0; i < list_LoadValue.Count; i++)
                {
                    object[] value_load = list_LoadValue[i];
                    value_load = value_load.CopyRow(new enum_藥品資料_藥檔資料_匯入(), new enum_藥品資料_藥檔資料());
                    if (!Function_藥品資料_藥檔資料_檢查內容(value_load).StringIsEmpty()) continue;
                    list_SQL_Value_buf = list_SQL_Value.GetRows((int)enum_藥品資料_藥檔資料.藥品碼, value_load[(int)enum_藥品資料_藥檔資料.藥品碼].ObjectToString());
                    if (list_SQL_Value_buf.Count > 0)
                    {
                        object[] value_SQL = list_SQL_Value_buf[0];
                        value_load[(int)enum_藥品資料_藥檔資料.GUID] = value_SQL[(int)enum_藥品資料_藥檔資料.GUID];
                        bool flag_Equal = value_load.IsEqual(value_SQL);
                        if (!flag_Equal)
                        {
                            list_Replace_SerchValue.Add(value_load[(int)enum_藥品資料_藥檔資料.GUID].ObjectToString());
                            list_Replace_Value.Add(value_load);
                        }
                    }
                    else
                    {
                        value_load[(int)enum_藥品資料_藥檔資料.GUID] = Guid.NewGuid().ToString();
                        list_Add.Add(value_load);
                    }
                }
                this.sqL_DataGridView_藥品資料_藥檔資料.SQL_AddRows(list_Add, false);
                this.sqL_DataGridView_藥品資料_藥檔資料.SQL_ReplaceExtra(enum_藥品資料_藥檔資料.GUID.GetEnumName(), list_Replace_SerchValue, list_Replace_Value, false);
                this.sqL_DataGridView_藥品資料_藥檔資料.SQL_GetAllRows(true);
                this.Cursor = Cursors.Default;
            }
            this.Cursor = Cursors.Default;
            MyMessageBox.ShowDialog("匯入完成!");
        }
        #endregion
        #region Event
        private void SqL_DataGridView_藥品資料_藥檔資料_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Dialog_ContextMenuStrip dialog_ContextMenuStrip = new Dialog_ContextMenuStrip(new ContextMenuStrip_藥品資料_藥檔資料());
                if (dialog_ContextMenuStrip.ShowDialog() == DialogResult.Yes)
                {
                    if (dialog_ContextMenuStrip.Value == ContextMenuStrip_藥品資料_藥檔資料.匯出.GetEnumName())
                    {
                        Function_藥品資料_藥檔資料_匯出();
                    }
                    else if (dialog_ContextMenuStrip.Value == ContextMenuStrip_藥品資料_藥檔資料.匯入.GetEnumName())
                    {
                        Function_藥品資料_藥檔資料_匯入();
                    }
                    else if (dialog_ContextMenuStrip.Value == ContextMenuStrip_藥品資料_藥檔資料.匯出選取資料.GetEnumName())
                    {
                        saveFileDialog_SaveExcel.OverwritePrompt = false;
                        if (saveFileDialog_SaveExcel.ShowDialog(this) == DialogResult.OK)
                        {
                            DataTable datatable = new DataTable();
                            datatable = sqL_DataGridView_藥品資料_藥檔資料.GetSelectRowsDataTable();
                            datatable = datatable.ReorderTable(new enum_藥品資料_藥檔資料_匯出());
                            CSVHelper.SaveFile(datatable, saveFileDialog_SaveExcel.FileName);
                            MyMessageBox.ShowDialog("匯出完成!");
                        }
                    }
                    else if (dialog_ContextMenuStrip.Value == ContextMenuStrip_藥品資料_藥檔資料.刪除選取資料.GetEnumName())
                    {
                        if (MyMessageBox.ShowDialog("是否刪除選取資料", MyMessageBox.enum_BoxType.Warning, MyMessageBox.enum_Button.Confirm_Cancel) == DialogResult.Yes)
                        {
                            this.Cursor = Cursors.WaitCursor;
                            List<object[]> list_value = this.sqL_DataGridView_藥品資料_藥檔資料.Get_All_Select_RowsValues();
                            List<object> list_delete_serchValue = new List<object>();
                            for (int i = 0; i < list_value.Count; i++)
                            {
                                string GUID = list_value[i][(int)enum_藥品資料_藥檔資料.GUID].ObjectToString();
                                list_delete_serchValue.Add(GUID);
                            }
                            this.sqL_DataGridView_藥品資料_藥檔資料.SQL_DeleteExtra(enum_藥品資料_藥檔資料.GUID.GetEnumName(), list_delete_serchValue, true);
                            this.Cursor = Cursors.Default;
                        }
                    }
                    else if (dialog_ContextMenuStrip.Value == ContextMenuStrip_藥品資料_藥檔資料.登錄資料.GetEnumName())
                    {
                        Function_藥品資料_藥檔資料_登錄();
                    }
                    else if (dialog_ContextMenuStrip.Value == ContextMenuStrip_藥品資料_藥檔資料.設定安全庫存.GetEnumName())
                    {
                        Dialog_NumPannel dialog_NumPannel = new Dialog_NumPannel();
                        if (dialog_NumPannel.ShowDialog() == DialogResult.Yes)
                        {
                            List<object[]> list_value = sqL_DataGridView_藥品資料_藥檔資料.Get_All_Select_RowsValues();
                            for (int i = 0; i < list_value.Count; i++)
                            {
                                list_value[i][(int)enum_藥品資料_藥檔資料.安全庫存] = dialog_NumPannel.Value.ToString();
                            }
                            sqL_DataGridView_藥品資料_藥檔資料.SQL_ReplaceExtra(list_value, true);
                        }
                        else
                        {
                            this.SqL_DataGridView_藥品資料_藥檔資料_MouseDown(sender, e);
                        }
                    }
                
                }
            }
        }
        private void SqL_DataGridView_藥品資料_藥檔資料_RowEnterEvent(object[] RowValue)
        {
            //this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.SetDataSource(this.Function_藥品群組_取得選單());
            //int index = RowValue[(int)enum_藥品資料_藥檔資料.藥品群組].ObjectToString().StringToInt32() - 1;
            //Finction_藥品群組_名稱轉序號(RowValue, (int)enum_藥品資料_藥檔資料.藥品群組);
            //this.textBox_藥品資料_藥檔資料_藥品碼.Text = RowValue[(int)enum_藥品資料_藥檔資料.藥品碼].ObjectToString();
            //this.textBox_藥品資料_藥檔資料_藥品名稱.Text = RowValue[(int)enum_藥品資料_藥檔資料.藥品名稱].ObjectToString();
            //this.textBox_藥品資料_藥檔資料_藥品學名.Text = RowValue[(int)enum_藥品資料_藥檔資料.藥品學名].ObjectToString();
            //this.textBox_藥品資料_藥檔資料_藥品中文名稱.Text = RowValue[(int)enum_藥品資料_藥檔資料.藥品中文名稱].ObjectToString();
            //if (index >= 0) this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.SelectedIndex = index;
            //this.textBox_藥品資料_藥檔資料_健保碼.Text = RowValue[(int)enum_藥品資料_藥檔資料.健保碼].ObjectToString();
            //this.textBox_藥品資料_藥檔資料_庫存.Text = RowValue[(int)enum_藥品資料_藥檔資料.庫存].ObjectToString();
            //this.textBox_藥品資料_藥檔資料_安全庫存.Text = RowValue[(int)enum_藥品資料_藥檔資料.安全庫存].ObjectToString();
            //this.textBox_藥品資料_藥檔資料_包裝單位.Text = RowValue[(int)enum_藥品資料_藥檔資料.包裝單位].ObjectToString();
            //this.textBox_藥品資料_藥檔資料_藥品條碼.Text = RowValue[(int)enum_藥品資料_藥檔資料.藥品條碼].ObjectToString();
            //this.comboBox_藥品資料_藥檔資料_警訊藥品.Texts = RowValue[(int)enum_藥品資料_藥檔資料.警訊藥品].ObjectToString();
        }
        private void SqL_DataGridView_藥品資料_藥檔資料_RowDoubleClickEvent(object[] RowValue)
        {
            int index = RowValue[(int)enum_藥品資料_藥檔資料.藥品群組].ObjectToString().StringToInt32() - 1;
            this.textBox_藥品資料_藥檔資料_藥品碼.Text = RowValue[(int)enum_藥品資料_藥檔資料.藥品碼].ObjectToString();
            this.textBox_藥品資料_藥檔資料_藥品名稱.Text = RowValue[(int)enum_藥品資料_藥檔資料.藥品名稱].ObjectToString();
            this.textBox_藥品資料_藥檔資料_藥品學名.Text = RowValue[(int)enum_藥品資料_藥檔資料.藥品學名].ObjectToString();
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.Text = RowValue[(int)enum_藥品資料_藥檔資料.藥品中文名稱].ObjectToString();
            if (index >= 0) this.rJ_ComboBox_藥品資料_藥檔資料_藥品群組.SelectedIndex = index;
            this.textBox_藥品資料_藥檔資料_健保碼.Text = RowValue[(int)enum_藥品資料_藥檔資料.健保碼].ObjectToString();
            this.textBox_藥品資料_藥檔資料_庫存.Text = RowValue[(int)enum_藥品資料_藥檔資料.庫存].ObjectToString();
            this.textBox_藥品資料_藥檔資料_安全庫存.Text = RowValue[(int)enum_藥品資料_藥檔資料.安全庫存].ObjectToString();
            this.textBox_藥品資料_藥檔資料_包裝單位.Text = RowValue[(int)enum_藥品資料_藥檔資料.包裝單位].ObjectToString();
            this.textBox_藥品資料_藥檔資料_藥品條碼.Text = RowValue[(int)enum_藥品資料_藥檔資料.藥品條碼].ObjectToString();
            this.comboBox_藥品資料_藥檔資料_警訊藥品.Texts = RowValue[(int)enum_藥品資料_藥檔資料.警訊藥品].ObjectToString();
        }
        private void SqL_DataGridView_藥品資料_藥檔資料_DataGridRowsChangeEvent(List<object[]> RowsList)
        {
            for (int i = 0; i < RowsList.Count; i++)
            {
                RowsList[i][(int)enum_藥品資料_藥檔資料.庫存] = this.Function_從本地資料取得庫存(RowsList[i][(int)enum_藥品資料_藥檔資料.藥品碼].ObjectToString()).ToString();
            }
            RowsList.Sort(new Icp_藥品資料_藥檔資料());
        }
        private void sqL_DataGridView_藥品資料_藥檔資料_DataGridRefreshEvent()
        {
            for (int i = 0; i < this.sqL_DataGridView_藥品資料_藥檔資料.dataGridView.Rows.Count; i++)
            {
                if (this.sqL_DataGridView_藥品資料_藥檔資料.dataGridView.Rows[i].Cells[enum_藥品資料_藥檔資料.安全庫存.GetEnumName()].Value.ToString().StringToInt32() != 0)
                {
                    if (this.sqL_DataGridView_藥品資料_藥檔資料.dataGridView.Rows[i].Cells[enum_藥品資料_藥檔資料.庫存.GetEnumName()].Value.ToString().StringToInt32() < this.sqL_DataGridView_藥品資料_藥檔資料.dataGridView.Rows[i].Cells[enum_藥品資料_藥檔資料.安全庫存.GetEnumName()].Value.ToString().StringToInt32())
                    {
                        this.sqL_DataGridView_藥品資料_藥檔資料.dataGridView.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        this.sqL_DataGridView_藥品資料_藥檔資料.dataGridView.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                }
            }
        }

        private void TextBox_藥品資料_藥檔資料_資料查詢_藥品條碼_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.Text != "")
                {
                    this.sqL_DataGridView_藥品資料_藥檔資料.SQL_GetRows(enum_藥品資料_藥檔資料.藥品條碼.GetEnumName(), textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.Text, true);
                }
            }
        }
        private void PlC_RJ_Button_藥品資料_藥檔資料_資料查詢_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_value = this.sqL_DataGridView_藥品資料_藥檔資料.SQL_GetAllRows(false);
            if (!textBox_藥品資料_藥檔資料_資料查詢_藥品碼.Text.StringIsEmpty()) list_value = list_value.GetRowsByLike((int)enum_藥品資料_藥檔資料.藥品碼, textBox_藥品資料_藥檔資料_資料查詢_藥品碼.Text);
            if (!textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.Text.StringIsEmpty())
            {
                if (textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.Text.Length < 3)
                {
                    MyMessageBox.ShowDialog("藥品名稱搜尋字元不得小於3個!");
                    return;
                }
                list_value = list_value.GetRowsStartWithByLike((int)enum_藥品資料_藥檔資料.藥品名稱, textBox_藥品資料_藥檔資料_資料查詢_藥品名稱.Text);

            }
            if (!textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.Text.StringIsEmpty()) list_value = list_value.GetRows((int)enum_藥品資料_藥檔資料.藥品條碼, textBox_藥品資料_藥檔資料_資料查詢_藥品條碼.Text);
            if (plC_RJ_ChechBox_藥品資料_藥檔資料_資料查詢_藥品群組.Checked)
            {
                int index = rJ_ComboBox_藥品資料_藥檔資料_資料查詢_藥品群組.SelectedIndex;
                index++;
                if (index > 0)
                {
                    list_value = list_value.GetRows((int)enum_藥品資料_藥檔資料.藥品群組, index.ToString("00"));
                }
            }
            this.sqL_DataGridView_藥品資料_藥檔資料.RefreshGrid(list_value);
            if (list_value.Count == 0)
            {
                MyMessageBox.ShowDialog("查無資料!");
            }
        }
        private void PlC_RJ_Button_藥品資料_刪除_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate
            {
                if (MyMessageBox.ShowDialog("是否刪除選取資料", MyMessageBox.enum_BoxType.Warning, MyMessageBox.enum_Button.Confirm_Cancel) == DialogResult.Yes)
                {
                    this.Cursor = Cursors.WaitCursor;
                    List<object[]> list_value = this.sqL_DataGridView_藥品資料_藥檔資料.Get_All_Checked_RowsValues();
                    List<object> list_delete_serchValue = new List<object>();
                    for (int i = 0; i < list_value.Count; i++)
                    {
                        string GUID = list_value[i][(int)enum_藥品資料_藥檔資料.GUID].ObjectToString();
                        string 藥品碼 = list_value[i][(int)enum_藥品資料_藥檔資料.藥品碼].ObjectToString();
                        if (Function_從SQL取得儲位到本地資料(藥品碼).Count > 0)
                        {
                            //MyMessageBox.ShowDialog("刪除藥品有建立儲位,無法刪除!");
                            //return;
                            continue;
                        }

                        list_delete_serchValue.Add(GUID);
                    }
                    this.sqL_DataGridView_藥品資料_藥檔資料.SQL_DeleteExtra(enum_藥品資料_藥檔資料.GUID.GetEnumName(), list_delete_serchValue, true);

                }
                this.Cursor = Cursors.Default;
            }));

        }
        private void PlC_RJ_Button_藥品資料_登錄_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate
            {
                Function_藥品資料_藥檔資料_登錄();
            }));
        }
        private void PlC_RJ_Button_藥品資料_匯出_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate
            {
                Function_藥品資料_藥檔資料_匯出();
            }));
        }
        private void PlC_RJ_Button_藥品資料_匯入_MouseDownEvent(MouseEventArgs mevent)
        {
            this.Invoke(new Action(delegate
            {
                Function_藥品資料_藥檔資料_匯入();
            }));
        }
        private void PlC_RJ_Button_藥品資料_顯示有儲位藥品_MouseDownEvent(MouseEventArgs mevent)
        {
            List<object[]> list_藥品資料 = this.sqL_DataGridView_藥品資料_藥檔資料.SQL_GetAllRows(false);
            List<object[]> list_藥品資料_buf = new List<object[]>();
            List<object[]> list_value = new List<object[]>();

            List<Device> devices = this.Function_從SQL取得所有儲位();
            List<string> list_code = (from value in devices
                                      select value.Code).ToList().Distinct().ToList();
            for (int i = 0; i < list_code.Count; i++)
            {
                list_藥品資料_buf = list_藥品資料.GetRows((int)enum_藥品資料_藥檔資料.藥品碼, list_code[i]);
                if (list_藥品資料_buf.Count > 0)
                {
                    list_value.Add(list_藥品資料_buf[0]);
                }
            }
            this.sqL_DataGridView_藥品資料_藥檔資料.RefreshGrid(list_value);
        }
        private void PlC_RJ_Button_藥品資料_更新藥櫃資料_MouseDownEvent(MouseEventArgs mevent)
        {
            if (MyMessageBox.ShowDialog("是否更新勾選的藥品資料?", MyMessageBox.enum_BoxType.Warning, MyMessageBox.enum_Button.Confirm_Cancel) != DialogResult.Yes) return;
            List<object[]> list_本地藥檔 = this.sqL_DataGridView_藥品資料_藥檔資料.Get_All_Checked_RowsValues();
            List<object[]> list_本地藥檔_replace = new List<object[]>();
            if (list_本地藥檔.Count == 0)
            {
                MyMessageBox.ShowDialog("未勾選藥品,請勾選要更新藥品!");
                return;
            }
            string url = dBConfigClass.MedApiURL;
            if (!url.StringIsEmpty())
            {
                MyTimer myTimer = new MyTimer();
                myTimer.StartTickTime(50000);
                string response = Basic.Net.WEBApiGet($"{url}?Code");
                Console.WriteLine($"HIS填入 , response:{response},耗時{myTimer.ToString()}ms");
            }
            List<object[]> list_雲端藥檔 = this.sqL_DataGridView_雲端藥檔.SQL_GetAllRows(false);
            List<object[]> list_雲端藥檔_buf = new List<object[]>();

            for (int i = 0; i < list_本地藥檔.Count; i++)
            {
                string 藥品碼 = list_本地藥檔[i][(int)enum_藥品資料_藥檔資料.藥品碼].ObjectToString();
                list_雲端藥檔_buf = list_雲端藥檔.GetRows((int)enum_雲端藥檔.藥品碼, 藥品碼);
                if (list_雲端藥檔_buf.Count > 0)
                {
                    bool replace = false;
                    if (list_本地藥檔[i][(int)enum_藥品資料_藥檔資料.藥品名稱].ObjectToString() != list_雲端藥檔_buf[0][(int)enum_雲端藥檔.藥品名稱].ObjectToString()) replace = true;
                    if (list_本地藥檔[i][(int)enum_藥品資料_藥檔資料.藥品中文名稱].ObjectToString() != list_雲端藥檔_buf[0][(int)enum_雲端藥檔.中文名稱].ObjectToString()) replace = true;
                    if (list_本地藥檔[i][(int)enum_藥品資料_藥檔資料.包裝單位].ObjectToString() != list_雲端藥檔_buf[0][(int)enum_雲端藥檔.包裝數量].ObjectToString()) replace = true;
                    if (list_本地藥檔[i][(int)enum_藥品資料_藥檔資料.藥品條碼].ObjectToString() != list_雲端藥檔_buf[0][(int)enum_雲端藥檔.藥品條碼1].ObjectToString()) replace = true;
                    if (list_本地藥檔[i][(int)enum_藥品資料_藥檔資料.警訊藥品].ObjectToString() != list_雲端藥檔_buf[0][(int)enum_雲端藥檔.警訊藥品].ObjectToString()) replace = true;

                    list_本地藥檔[i][(int)enum_藥品資料_藥檔資料.藥品名稱] = list_雲端藥檔_buf[0][(int)enum_雲端藥檔.藥品名稱];
                    list_本地藥檔[i][(int)enum_藥品資料_藥檔資料.藥品學名] = list_雲端藥檔_buf[0][(int)enum_雲端藥檔.藥品學名];
                    list_本地藥檔[i][(int)enum_藥品資料_藥檔資料.藥品中文名稱] = list_雲端藥檔_buf[0][(int)enum_雲端藥檔.中文名稱];
                    list_本地藥檔[i][(int)enum_藥品資料_藥檔資料.包裝單位] = list_雲端藥檔_buf[0][(int)enum_雲端藥檔.包裝單位];
                    list_本地藥檔[i][(int)enum_藥品資料_藥檔資料.藥品條碼] = list_雲端藥檔_buf[0][(int)enum_雲端藥檔.藥品條碼1];
                    list_本地藥檔[i][(int)enum_藥品資料_藥檔資料.警訊藥品] = list_雲端藥檔_buf[0][(int)enum_雲端藥檔.警訊藥品];
                    if (replace)
                    {
                        list_本地藥檔_replace.Add(list_本地藥檔[i]);
                    }

                }
            }
            this.sqL_DataGridView_藥品資料_藥檔資料.SQL_ReplaceExtra(list_本地藥檔_replace, true);
            MyMessageBox.ShowDialog("更新完成!");
        }
        private void PlC_RJ_Button_藥品資料_HIS填入_MouseDownEvent(MouseEventArgs mevent)
        {
            string 藥品碼 = this.textBox_藥品資料_藥檔資料_藥品碼.Text;
            string url = dBConfigClass.MedApiURL;
            if (!url.StringIsEmpty())
            {
                MyTimer myTimer = new MyTimer();
                myTimer.StartTickTime(50000);
                string response = Basic.Net.WEBApiGet($"{url}?Code={藥品碼}");
                Console.WriteLine($"HIS填入 , response:{response},耗時{myTimer.ToString()}ms");
            }
            List<object[]> list_雲端藥檔 = this.sqL_DataGridView_雲端藥檔.SQL_GetAllRows(false);
            List<object[]> list_雲端藥檔_buf = new List<object[]>();

            list_雲端藥檔_buf = list_雲端藥檔.GetRows((int)enum_雲端藥檔.藥品碼, 藥品碼);
            if (list_雲端藥檔_buf.Count == 0)
            {
                MyMessageBox.ShowDialog("查無資料!");
                return;
            }
            this.textBox_藥品資料_藥檔資料_藥品名稱.Text = list_雲端藥檔_buf[0][(int)enum_雲端藥檔.藥品名稱].ObjectToString();
            this.textBox_藥品資料_藥檔資料_藥品學名.Text = list_雲端藥檔_buf[0][(int)enum_雲端藥檔.藥品學名].ObjectToString();
            this.textBox_藥品資料_藥檔資料_藥品中文名稱.Text = list_雲端藥檔_buf[0][(int)enum_雲端藥檔.中文名稱].ObjectToString();
            this.textBox_藥品資料_藥檔資料_藥品條碼.Text = list_雲端藥檔_buf[0][(int)enum_雲端藥檔.藥品條碼1].ObjectToString();
            this.textBox_藥品資料_藥檔資料_健保碼.Text = list_雲端藥檔_buf[0][(int)enum_雲端藥檔.健保碼].ObjectToString();
            this.textBox_藥品資料_藥檔資料_包裝單位.Text = list_雲端藥檔_buf[0][(int)enum_雲端藥檔.包裝單位].ObjectToString();
            this.comboBox_藥品資料_藥檔資料_警訊藥品.Text = (list_雲端藥檔_buf[0][(int)enum_雲端藥檔.警訊藥品].ObjectToString().ToLower() == "true") ? "True" : "False";
        }
     
        private void PlC_RJ_Button_藥品資料_HIS下載全部藥檔_MouseDownEvent(MouseEventArgs mevent)
        {
            if (MyMessageBox.ShowDialog("是否下載全部藥檔?", MyMessageBox.enum_BoxType.Warning, MyMessageBox.enum_Button.Confirm_Cancel) != DialogResult.Yes) return;
            List<object[]> list_雲端藥檔 = this.sqL_DataGridView_雲端藥檔.SQL_GetAllRows(false);
            List<object[]> list_雲端藥檔_buf = new List<object[]>();
            List<object[]> list_藥品資料 = this.sqL_DataGridView_藥品資料_藥檔資料.SQL_GetAllRows(false);
            List<object[]> list_藥品資料_buf = new List<object[]>();
            List<object[]> list_藥品資料_add = new List<object[]>();
            List<object[]> list_藥品資料_replace = new List<object[]>();
            List<object[]> list_藥品資料_delete = new List<object[]>();
            Dialog_Prcessbar dialog_Prcessbar = new Dialog_Prcessbar(list_雲端藥檔.Count);
            dialog_Prcessbar.State = $"開始比對線上藥檔...";
            string url = dBConfigClass.MedApiURL;
            if (!url.StringIsEmpty())
            {
                MyTimer myTimer = new MyTimer();
                myTimer.StartTickTime(50000);
                string response = Basic.Net.WEBApiGet($"{url}");
                Console.WriteLine($"HIS下載全部藥檔 , response:{response},耗時{myTimer.ToString()}ms");
            }




            for (int i = 0; i < list_雲端藥檔.Count; i++)
            {
                dialog_Prcessbar.Value = i;
                list_藥品資料_buf = list_藥品資料.GetRows((int)enum_藥品資料_藥檔資料.藥品碼, list_雲端藥檔[i][(int)enum_雲端藥檔.藥品碼].ObjectToString());
                if (list_藥品資料_buf.Count == 0)
                {
                    object[] value = new object[new enum_藥品資料_藥檔資料().GetLength()];
                    value[(int)enum_藥品資料_藥檔資料.GUID] = Guid.NewGuid().ToString();
                    value[(int)enum_藥品資料_藥檔資料.藥品碼] = list_雲端藥檔[i][(int)enum_雲端藥檔.藥品碼].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.藥品名稱] = list_雲端藥檔[i][(int)enum_雲端藥檔.藥品名稱].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.藥品學名] = list_雲端藥檔[i][(int)enum_雲端藥檔.藥品學名].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.藥品中文名稱] = list_雲端藥檔[i][(int)enum_雲端藥檔.中文名稱].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.藥品條碼] = list_雲端藥檔[i][(int)enum_雲端藥檔.藥品條碼1].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.健保碼] = list_雲端藥檔[i][(int)enum_雲端藥檔.健保碼].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.包裝單位] = list_雲端藥檔[i][(int)enum_雲端藥檔.包裝單位].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.庫存] = "0";
                    value[(int)enum_藥品資料_藥檔資料.安全庫存] = "0";
                    value[(int)enum_藥品資料_藥檔資料.警訊藥品] = list_雲端藥檔[i][(int)enum_雲端藥檔.警訊藥品].ObjectToString();
                    list_藥品資料_add.Add(value);
                }
                else
                {
                    object[] value = list_藥品資料_buf[0];
                    value[(int)enum_藥品資料_藥檔資料.GUID] = Guid.NewGuid().ToString();
                    value[(int)enum_藥品資料_藥檔資料.藥品碼] = list_雲端藥檔[i][(int)enum_雲端藥檔.藥品碼].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.藥品名稱] = list_雲端藥檔[i][(int)enum_雲端藥檔.藥品名稱].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.藥品學名] = list_雲端藥檔[i][(int)enum_雲端藥檔.藥品學名].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.藥品中文名稱] = list_雲端藥檔[i][(int)enum_雲端藥檔.中文名稱].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.藥品條碼] = list_雲端藥檔[i][(int)enum_雲端藥檔.藥品條碼1].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.健保碼] = list_雲端藥檔[i][(int)enum_雲端藥檔.健保碼].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.包裝單位] = list_雲端藥檔[i][(int)enum_雲端藥檔.包裝單位].ObjectToString();
                    value[(int)enum_藥品資料_藥檔資料.警訊藥品] = list_雲端藥檔[i][(int)enum_雲端藥檔.警訊藥品].ObjectToString();
                    list_藥品資料_replace.Add(value);
                }
            }
            dialog_Prcessbar.State = $"寫入資料庫...";
            if (list_藥品資料_add.Count > 0) this.sqL_DataGridView_藥品資料_藥檔資料.SQL_AddRows(list_藥品資料_add, false);
            if (list_藥品資料_replace.Count > 0) this.sqL_DataGridView_藥品資料_藥檔資料.SQL_ReplaceExtra(list_藥品資料_replace, false);
            dialog_Prcessbar.Close();
        }

        #endregion
        public class Icp_藥品資料_藥檔資料 : IComparer<object[]>
        {
            public int Compare(object[] x, object[] y)
            {
                string 藥品碼_0 = x[(int)enum_藥品資料_藥檔資料.藥品碼].ObjectToString();
                string 藥品碼_1 = y[(int)enum_藥品資料_藥檔資料.藥品碼].ObjectToString();
                return 藥品碼_0.CompareTo(藥品碼_1);
            }
        }
        public class Icp_藥品群組 : IComparer<object[]>
        {
            public int Compare(object[] x, object[] y)
            {
                int index_0 = x[(int)enum_藥品群組.群組序號].ObjectToString().StringToInt32();
                int index_1 = y[(int)enum_藥品群組.群組序號].ObjectToString().StringToInt32();
                return index_0.CompareTo(index_1);
            }
        }
    }
}
