using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HssUtility.Text.FixLength
{
    public class Sheet
    {
        public const string nextLine = "\r\n";
        private List<Line> line_list = new List<Line>();

        public void Add(Line li)
        {
            if (li != null) this.line_list.Add(li);
        }

        public void Clear()
        {
            this.line_list.Clear();
        }

        public bool Remove(int index)
        {
            if (index < 0 || index >= this.line_list.Count) return false;
            else
            {
                this.line_list.RemoveAt(index);
                return true;
            }
        }

        public string GetContent()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < this.line_list.Count - 1; i++)
            {
                Line li = this.line_list.ElementAt(i);
                sb.Append(li.GetStr()).Append(Sheet.nextLine);
            }

            if (this.line_list.Count > 0)
            {
                Line li = this.line_list.ElementAt(this.line_list.Count - 1);
                sb.Append(li.GetStr());
            }

            return sb.ToString();
        }

        public Line GetLine(int index)
        {
            if (index < 0 || index >= this.line_list.Count) return null;
            return this.line_list.ElementAt(index);
        }

        public int Length
        {
            get
            {
                return this.GetContent().Length;
            }
        }
    }
}
