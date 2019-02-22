using System;
using System.Collections.Generic;
using System.Text;

namespace HssUtility.General
{
    public class HssStr
    {
        /// <summary>
        /// NotePad and TextBox: only take "\r\n" as next line
        /// NotePad++: take "\n", "\r" and "\r\n" as next line, take "\n\r" as double next line
        /// </summary>
        public const string WinNextLine = "\r\n";

        public static Dictionary<string, string> GetDic_from_connStr(string connStr)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            if (connStr == null) return dic;

            string[] entries = connStr.Split(";".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in entries)
            {
                string[] arr = s.Split("=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                if (arr.Length < 2) continue;

                string name = arr[0].Trim("[' ]".ToCharArray()), value = arr[1].Trim("[' ]".ToCharArray());
                dic[name] = value;
            }

            return dic;
        }

        public static int WordDistance(string s1, string s2)
        {
            int n = s1.Length, m = s2.Length;
            int[,] d = new int[n + 1, m + 1];

            if (n == 0) return m;
            if (m == 0) return n;

            for (int i = 0; i <= n; ++i) d[i, 0] = i;
            for (int j = 0; j <= m; ++j) d[0, j] = j;

            for (int i = 1; i <= n; ++i)
            {
                for (int j = 1; j <= m; ++j)
                {
                    int cost = s2[j - 1] == s1[i - 1] ? 0 : 1;
                    int temp = Math.Min(d[i - 1, j] + 1, d[i, j - 1] + 1);//min of up and left
                    d[i, j] = Math.Min(temp, d[i - 1, j - 1] + cost);
                }
            }

            return d[n, m];
        }

        public static StringBuilder RemoveLastChar(StringBuilder sb, char lastChar)
        {
            if (sb == null) return sb;

            int startRM_id = -1;
            for (int i = sb.Length - 1; i >= 0; --i)
            {
                if (sb[i] == lastChar)
                {
                    startRM_id = i;
                    break;
                }
            }

            if (startRM_id >= 0) sb.Remove(startRM_id, 1);

            return sb;
        }

        public static HashSet<string> Str_to_wordSet(string str, bool caseSensitive = false)
        {
            String_to_words stw = new String_to_words(str, caseSensitive);
            stw.Get_wordHS();
            return stw.word_hs;
        }

        public static List<string> Str_to_wordList(string str)
        {
            String_to_words stw = new String_to_words(str, true);
            stw.Get_wordHS();
            return stw.word_list;
        }

        public static bool IsLetter(char c)
        {
            if (c >= 'a' && c <= 'z') return true;
            if (c >= 'A' && c <= 'Z') return true;

            return false;
        }

        public static bool IsNum(char c)
        {
            if (c >= '0' && c <= '9') return true;
            else return false;
        }

        public static List<string> CutString(string str, params int[] lenArr)
        {
            List<string> lst = new List<string>();
            List<StringBuilder> sb_list = new List<StringBuilder>();
            foreach (int i in lenArr)
            {
                sb_list.Add(new StringBuilder());
            }

            for (int i = 0; i < str.Length; ++i)
            {
                //more work needed...                
            }

            return lst;
        }

        //public static string Bytes_to_DBstr(byte[] arr)
        //{
        //    if (arr == null) return null;

        //    StringBuilder sb = new StringBuilder("0x");

        //    foreach (byte b in arr)
        //    {
        //        int first4bit = b >> 4;
        //        int secondbit = b - (first4bit << 4);

        //        char firstC, secondC;
        //        if (first4bit > 9) firstC = (char)('A' + first4bit - 10);
        //        else firstC = (char)('0' + first4bit);

        //        if (secondbit > 9) secondC = (char)('A' + secondbit - 10);
        //        else secondC = (char)('0' + secondbit);

        //        sb.Append(firstC).Append(secondC);
        //    }

        //    return sb.ToString();
        //}

        public static string Trim_to_size(int val, int size, char defaultChar = '0')
        {
            string str = val.ToString();
            if (size < 0) return str;

            if (str.Length == size) return str;
            else if (str.Length > size) return str.Substring(0, size);
            else
            {
                StringBuilder sb = new StringBuilder(str);
                int insertPos = 0;
                if (sb[0] == '-') insertPos = 1;
                while (sb.Length < size) sb.Insert(insertPos, defaultChar);
                return sb.ToString();
            }
        }

        public static string Trim_to_size(string str, int size, char defaultChar = '_')
        {
            if (size < 0) return str;
            if (str == null) str = "";

            if (str.Length == size) return str;
            else if (str.Length > size) return str.Substring(0, size);
            else
            {
                StringBuilder sb = new StringBuilder(str);
                while (sb.Length < size) sb.Append(defaultChar);
                return sb.ToString();
            }
        }

        public static string ToSafeXML_str(string s)
        {
            if (s == null) return s;

            s = s.Replace("&", "&amp;");
            return s.Replace(">", "&gt;").Replace("<", "&lt;");
        }

        public static string SafeXML_to_ori(string s)
        {
            if (s == null) return s;

            s = s.Replace("&gt;", ">").Replace("&lt;", "<");
            return s.Replace("&amp;", "&");
        }

        public static List<int> FindAll_substrings(string ori, string sub, bool caseSensitive)
        {
            List<int> list = new List<int>();
            if (string.IsNullOrEmpty(ori) || string.IsNullOrEmpty(sub)) return list;

            for (int i = 0; i < ori.Length - sub.Length; ++i)
            {
                bool match = true;
                for (int j = 0; j < sub.Length; ++j)
                {
                    if (!HssStr.CharEqual(ori[i + j], sub[j], caseSensitive))
                    {
                        match = false;
                        break;
                    }
                }

                if (match)
                {
                    list.Add(i);
                    i += sub.Length - 1;
                }
            }

            return list;
        }

        public static bool CharEqual(char c1, char c2, bool caseSensitive)
        {
            if (c1 == c2) return true;

            if (!caseSensitive)
            {
                if (c1 >= 'a' && c1 <= 'z') return (c1 - 32) == c2;
                if (c1 >= 'A' && c1 <= 'Z') return (c1 + 32) == c2;
            }

            return false;
        }

        /// <summary>
        /// Check if a string represents True or False (mainly used in XML parsing)
        /// </summary>
        public static bool True_or_False(string str)
        {
            if (str == null) return false;
            else str = str.Trim();

            return str.Equals("True", StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Convert index to Excel column header
        /// </summary>
        /// <param name="id">Starts from 0</param>
        public static string Excel_ID_to_Title(int id)
        {
            StringBuilder sb = new StringBuilder();
            ++id;

            while (id > 0)
            {
                --id;
                sb.Insert(0, (char)('A' + id % 26));
                id /= 26;
            }
            return sb.ToString();
        }
    }

    class String_to_words
    {
        public readonly HashSet<string> word_hs = null;
        public readonly List<string> word_list = new List<string>();
        private string str = null;

        private StringBuilder sb = new StringBuilder();
        private bool all_num_flag = true;
        private int dot_count = 0;

        public String_to_words(string str, bool caseSensitive)
        {
            if (caseSensitive) this.word_hs = new HashSet<string>();
            else this.word_hs = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            this.str = str;
        }

        public void Get_wordHS()
        {
            if (string.IsNullOrEmpty(this.str)) return;

            for (int i = 0; i < str.Length; ++i)
            {
                char c = str[i];

                if (HssStr.IsNum(c)) this.sb.Append(c);
                else if (HssStr.IsLetter(c))
                {
                    if (this.sb.Length > 0 && this.sb[0] == '-') this.sb.Remove(0, 1);
                    this.sb.Append(c);
                    all_num_flag = false;
                }
                else if (c == '.')
                {
                    if (this.sb.Length > 0)
                    {
                        if (all_num_flag)
                        {
                            this.sb.Append(c);
                            if (this.dot_count > 1 && this.sb[0] == '-') this.sb.Remove(0, 1);
                            ++this.dot_count;
                        }
                        else this.Commit();
                    }
                }
                else if (c == '-')
                {
                    if (this.sb.Length < 1) this.sb.Append(c);
                    else this.Commit();
                }
                else this.Commit();
            }

            this.Commit();
        }

        private void Commit()
        {
            if (this.sb.Length > 0)
            {
                this.word_hs.Add(this.sb.ToString());
                this.word_list.Add(this.sb.ToString());
            }
            this.sb.Clear();
            this.all_num_flag = true;
            this.dot_count = 0;
        }
    }
}
