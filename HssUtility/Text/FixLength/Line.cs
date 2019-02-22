using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssUtility.Text.FixLength
{
    public class Line
    {
        private List<Cell> cell_list = new List<Cell>();

        public void Add(Cell cl)
        {
            if (cl != null) this.cell_list.Add(cl);
        }

        public Cell Add(object obj, bool leftJustified = false, char fill_char = ' ')
        {
            Cell cl = new Cell(obj, leftJustified, fill_char);
            this.cell_list.Add(cl);

            return cl;
        }

        public Cell Add(object obj, int len, bool leftJustified = false, char fill_char = ' ')
        {
            Cell cl = new Cell(obj, len, leftJustified, fill_char);
            this.cell_list.Add(cl);

            return cl;
        }

        public Cell Add(char c, int len, bool leftJustified = false, char fill_char = ' ')
        {
            Cell cl = new Cell(c, len, leftJustified, fill_char);
            this.cell_list.Add(cl);

            return cl;
        }

        public Cell Add(int val, int len, bool leftJustified = false, char fill_char = '0')
        {
            Cell cl = new Cell(val, len, leftJustified, fill_char);
            this.cell_list.Add(cl);

            return cl;
        }

        public void Clear()
        {
            this.cell_list.Clear();
        }

        public bool Remove(int index)
        {
            if (index < 0 || index >= this.cell_list.Count) return false;
            else
            {
                this.cell_list.RemoveAt(index);
                return true;
            }
        }

        public string GetStr()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Cell cl in this.cell_list) sb.Append(cl.Value);

            return sb.ToString();
        }

        public Cell GetCell(int index)
        {
            if (index < 0 || index >= this.cell_list.Count) return null;
            return this.cell_list.ElementAt(index);
        }

        public int Length
        {
            get { return this.GetStr().Length; }
        }
    }
}
