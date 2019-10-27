using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Автошкола
{
    static class SearchingInDataGridViewClass
    {
        static SearchingInDataGridViewClass()
        {

        }

        static public void Search(TextBox Search_textBox, ref DataGridView dGV, CheckBox Direction_checkBox, 
            ref string LastSearchingText, ref int LastFoundRow, params string[] ColumnsForSearch)
        {
            bool Find = false;
            string CurrentSearchingText = Search_textBox.Text.Trim();

            int BeginRow;            

            if (LastSearchingText == CurrentSearchingText)
            {
                if (Direction_checkBox.Checked)
                    BeginRow = LastFoundRow + 1;
                else
                    BeginRow = LastFoundRow - 1;
            }
            else
            {
                LastSearchingText = CurrentSearchingText;
                if (Direction_checkBox.Checked)
                    BeginRow = 0;
                else
                    BeginRow = dGV.RowCount;
            }
            Search:
            if (Direction_checkBox.Checked)
            {
                for (int i = BeginRow; i < dGV.RowCount; i++)
                {
                    for (int j = 0; j < ColumnsForSearch.Length; j++)
                    {
                        if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, ColumnsForSearch[j]))
                            return;
                    }
                }
                /*switch (CountColumns)
                {
                    case 1:
                        for (int i = BeginRow; i < dGV.RowCount; i++)
                        {
                            if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, 1))
                                return;
                        }
                        break;
                    case 2:
                        for (int i = BeginRow; i < dGV.RowCount; i++)
                        {
                            if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, 1))
                                return;
                            if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, 2))
                                return;
                        }
                        break;
                    case 3:
                        for (int i = BeginRow; i < dGV.RowCount; i++)
                        {
                            if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, 1))
                                return;
                            if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, 2))
                                return;
                            if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, 3))
                                return;
                        }
                        break;
                }*/
                if (!Find)
                {
                    DialogResult result = MessageBox.Show("Поиск достиг последней строки таблицы. Продолжить поиск с начала таблицы?", "Поиск", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        BeginRow = 0;
                        goto Search;
                    }
                }
            }
            else
            {
                for (int i = BeginRow; i >= 0; i--)
                {
                    for (int j = 0; j < ColumnsForSearch.Length; j++)
                    {
                        if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, ColumnsForSearch[j]))
                            return;
                    }
                }
                /*switch (CountColumns)
                {
                    case 1:
                        for (int i = BeginRow; i >= 0; i--)
                        {
                            if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, 1))
                                return;
                        }
                        break;
                    case 2:
                        for (int i = BeginRow; i >= 0; i--)
                        {
                            if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, 1))
                                return;
                            if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, 2))
                                return;
                        }
                        break;
                    case 3:
                        for (int i = BeginRow; i >= 0; i--)
                        {
                            if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, 1))
                                return;
                            if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, 2))
                                return;
                            if (CheckRow(ref dGV, CurrentSearchingText, ref LastFoundRow, i, 3))
                                return;
                        }
                        break;
                }*/
                if (!Find)
                {
                    DialogResult result = MessageBox.Show("Поиск достиг первой строки таблицы. Продолжить поиск с конца таблицы?", "Поиск", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        BeginRow = dGV.RowCount - 1;
                        goto Search;
                    }
                }
            }
        }

        static bool CheckRow(ref DataGridView dGV, string CurrentSearchingText, ref int LastFoundRow, int CurrentRow, string ColumnName)
        {
            if (dGV[ColumnName, CurrentRow].FormattedValue.ToString().ToLower().Contains(CurrentSearchingText.ToLower()))
            {
                dGV.CurrentCell = dGV[ColumnName, CurrentRow];
                LastFoundRow = CurrentRow;
                return true;
            }
            else return false;
        }
    }
}
