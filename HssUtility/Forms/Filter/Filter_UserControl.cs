using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using HssUtility.General;
using HssUtility.SQLserver;

namespace HssUtility.Forms.Filter
{
    public partial class Filter_UserControl : UserControl
    {
        public const int X_pos = 250, Y_pos = 3;

        public Filter_UserControl()
        {
            InitializeComponent();
            this.Size = new Size(this.Size.Width, 30);
        }

        private Dictionary<int, ColumnInfo> colName_type_dic = new Dictionary<int, ColumnInfo>();
        private Type colType = null;

        public void Init_from_DT(DataTable dt)
        {
            if (dt == null) return;

            int index = 0;
            foreach (DataColumn col in dt.Columns)
            {
                if (col.ColumnName.StartsWith("$") && col.ColumnName.EndsWith("$")) continue;

                this.col_comboBox.Items.Add(col.Caption);
                this.colName_type_dic[index] = new ColumnInfo(index, col.ColumnName, col.DataType);
                ++index;
            }
        }

        public void Reset()
        {
            this.colName_type_dic.Clear();
            this.col_comboBox.Items.Clear();
        }

        public RelationalOperator Col_operater
        {
            get
            {
                string str = this.opt_comboBox.Text;
                if (str.Equals("=")) return RelationalOperator.Equals;
                if (str.Equals("!=")) return RelationalOperator.NotEqual;
                if (str.Equals(">=")) return RelationalOperator.Greater_or_Equals;
                if (str.Equals("<=")) return RelationalOperator.Less_or_Equals;
                if (str.Equals(">")) return RelationalOperator.GreaterThan;
                if (str.Equals("<")) return RelationalOperator.LessThan;

                return RelationalOperator.None;
            }
        }

        public SQL_relation SQL_Rela
        {
            get
            {
                SQL_relation rela = null;
                int index = this.col_comboBox.SelectedIndex;
                if (!this.colName_type_dic.ContainsKey(index)) return null;

                string colName = this.colName_type_dic[this.col_comboBox.SelectedIndex].ColName;

                if (this.colType == typeof(DateTime)) rela = new SQL_relation(colName, Col_operater, this.value_dateTimePicker.Value);
                else if (this.colType == typeof(int))
                {
                    int temp = 0;
                    if (int.TryParse(this.value_textBox.Text, out temp)) rela = new SQL_relation(colName, Col_operater, temp);
                }
                else if (this.colType == typeof(decimal))
                {
                    decimal temp = 0;
                    if (decimal.TryParse(this.value_textBox.Text, out temp)) rela = new SQL_relation(colName, Col_operater, temp);
                }
                else rela = new SQL_relation(colName, Col_operater, this.value_textBox.Text);

                return rela;
            }
        }

        public Utility.Void_NoParams_delegate Refresh_parentUI = Utility.Void_NoParams_emptyFunc;

        /*-----------------------------------------------------------------------------------------------------------------------*/

        private void col_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.colType = this.colName_type_dic[this.col_comboBox.SelectedIndex].ColType;

            if (this.colType == typeof(DateTime))
            {
                this.value_textBox.Visible = false;
                this.value_dateTimePicker.Visible = true;
                this.value_dateTimePicker.Location = new Point(X_pos, Y_pos);
            }
            else
            {
                this.value_textBox.Visible = true;
                this.value_dateTimePicker.Visible = false;
                this.value_textBox.Location = new Point(X_pos, Y_pos);
            }
        }

        private void value_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) this.Refresh_parentUI();
        }

        private void value_textBox_Leave(object sender, EventArgs e)
        {
            if (this.colType == typeof(int))
            {
                int temp = 0;
                if (!int.TryParse(this.value_textBox.Text, out temp)) MessageBox.Show("Invalid int value");
            }
            else if (this.colType == typeof(decimal))
            {
                decimal temp = 0;
                if (!decimal.TryParse(this.value_textBox.Text, out temp)) MessageBox.Show("Invalid decimal value");
            }
        }
    }

    class ColumnInfo
    {
        public readonly int Index = -1;
        public readonly string ColName = null;
        public readonly Type ColType = null;

        public ColumnInfo(int id, string name, Type tp)
        {
            this.Index = id;
            this.ColName = name;
            this.ColType = tp;
        }
    }
}
