using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelAp
{
    class Helper
    {
        public void clearAllTextBox(TextBox tb1, TextBox tb2)
        {
            tb1.Text = "";
            tb2.Text = "";
        }
        public void clearAllTextBox(TextBox tb1, TextBox tb2, TextBox tb3)
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
        }
        public void clearAllTextBox(TextBox tb1, TextBox tb2, TextBox tb3, TextBox tb4)
        {
            tb1.Text = "";
            tb2.Text = "";
            tb3.Text = "";
            tb4.Text = "";
        }
        public string addSpecialCharacters(string inputStr)
        {
            return inputStr.Insert(0, "@");
        }
        public string randomizePassword()
        {
            string output = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                output += random.Next(0, 100).ToString();
            }

            return output;
        }
        public void clearDataGridView(DataGridView input)
        {
            for (int i = 0; i < input.RowCount; i++)
            {
                for (int j = 0; j < input.ColumnCount; j++)
                {
                    input.Rows[i].Cells[j].Value = "";
                }
            }
            input.RowCount = 0;
        }
        public void seachDateGridView(DataGridView input, double BeginPrice, double EndPrice)
        {
            for (int i = 0; i < input.RowCount; i++)
            {
                if (double.Parse(input.Rows[i].Cells[4].Value.ToString()) <= BeginPrice ||
                    double.Parse(input.Rows[i].Cells[4].Value.ToString()) >= EndPrice)
                {
                    clearSeachDataGridView(input, i);
                }
            }
            clearNullRows(input);
        }
        private void clearSeachDataGridView(DataGridView input, int indexClear)
        {
            for (int i = 0; i < input.ColumnCount; i++)
            {
                input.Rows[indexClear].Cells[i].Value = "";
            }
        }

        private void clearNullRows(DataGridView input)
        {
            for (int i = 0; i < input.RowCount; i++)
            {
                if (input.Rows[i].Cells[1].Value.ToString().Length != 0)
                {
                    for (int j = i; j > 0; j--)
                    {
                        if (input.Rows[j - 1].Cells[1].Value.ToString().Length == 0)
                        {
                            input.Rows[j - 1].Cells[0].Value = input.Rows[j].Cells[0].Value;
                            input.Rows[j - 1].Cells[1].Value = input.Rows[j].Cells[1].Value;
                            input.Rows[j - 1].Cells[2].Value = input.Rows[j].Cells[2].Value;
                            input.Rows[j - 1].Cells[3].Value = input.Rows[j].Cells[3].Value;
                            input.Rows[j - 1].Cells[4].Value = input.Rows[j].Cells[4].Value;
                            input.Rows[j].Cells[0].Value = "";
                            input.Rows[j].Cells[1].Value = "";
                            input.Rows[j].Cells[2].Value = "";
                            input.Rows[j].Cells[3].Value = "";
                            input.Rows[j].Cells[4].Value = "";
                        }
                    }
                }
            }
            deleteNull(input);
        }

        private void deleteNull(DataGridView input)
        {
            int n = 0;
            for (int i = 0; i < input.RowCount; i++)
            {
                if (input.Rows[i].Cells[1].Value.ToString().Length != 0)
                {
                    n++;
                }
            }
            input.RowCount = n;
        }

        public void sortByPrice(DataGridView sortDataGridView)
        {
            DataGridView temp = new DataGridView();
            temp.RowCount = 1;
            temp.ColumnCount = 5;
            for (int i = 0; i < sortDataGridView.RowCount; i++)
            {
                for (int j = i + 1; j < sortDataGridView.RowCount; j++)
                {
                    if (double.Parse(sortDataGridView.Rows[i].Cells[4].Value.ToString()) > double.Parse(sortDataGridView.Rows[j].Cells[4].Value.ToString()))
                    {
                        temp.Rows[0].Cells[0].Value = sortDataGridView.Rows[i].Cells[0].Value;
                        temp.Rows[0].Cells[1].Value = sortDataGridView.Rows[i].Cells[1].Value;
                        temp.Rows[0].Cells[2].Value = sortDataGridView.Rows[i].Cells[2].Value;
                        temp.Rows[0].Cells[3].Value = sortDataGridView.Rows[i].Cells[3].Value;
                        temp.Rows[0].Cells[4].Value = sortDataGridView.Rows[i].Cells[4].Value;

                        sortDataGridView.Rows[i].Cells[0].Value = sortDataGridView.Rows[j].Cells[0].Value;
                        sortDataGridView.Rows[i].Cells[1].Value = sortDataGridView.Rows[j].Cells[1].Value;
                        sortDataGridView.Rows[i].Cells[2].Value = sortDataGridView.Rows[j].Cells[2].Value;
                        sortDataGridView.Rows[i].Cells[3].Value = sortDataGridView.Rows[j].Cells[3].Value;
                        sortDataGridView.Rows[i].Cells[4].Value = sortDataGridView.Rows[j].Cells[4].Value;

                        sortDataGridView.Rows[j].Cells[0].Value = temp.Rows[0].Cells[0].Value;
                        sortDataGridView.Rows[j].Cells[1].Value = temp.Rows[0].Cells[1].Value;
                        sortDataGridView.Rows[j].Cells[2].Value = temp.Rows[0].Cells[2].Value;
                        sortDataGridView.Rows[j].Cells[3].Value = temp.Rows[0].Cells[3].Value;
                        sortDataGridView.Rows[j].Cells[4].Value = temp.Rows[0].Cells[4].Value;

                    }
                }
            }
        }

        public int replaceFreeSpace(DataGridView dataGridView)
        {
            int n = 0;
            for (int i = 0; i < dataGridView.RowCount; i++)
            {
                if (dataGridView.Rows[i].Cells[0].Value.ToString().Length != 0)
                {
                    n++;
                }
            }

            return n;
        }
    }
}
