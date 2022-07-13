using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyOwn
{
    internal class MyClass
    {
        //private string _ch_string;
        public string name;
        public int[] arr = new int[3];
        public enum MyClassName
        {
            國文 = 0,
            英文 = 1,
            數學 = 2
        }

        int _sum;
        public int sum
        {
            get
            {
                for(int i = 0; i < arr.Length; i++)
                {
                    _sum += arr[i]; 
                }
                return _sum;
            }
        }
        public double avg
        {
            get
            {
                return Math.Round((double)_sum / arr.Length,2);
            }
        }
        public string Max_class
        {
            get
            {
                string _Max_class= $"{(MyClassName)0}{arr[0]}";
                int _Max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > _Max)
                    {
                        _Max_class = $"{(MyClassName)i}{arr[i]}";
                        _Max = arr[i];
                    }
                }
                return _Max_class;
            }
        }
        public string min_class
        {
            get
            {
                string _min_class = $"{(MyClassName)0}{arr[0]}";
                int _min = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < _min)
                    {
                        _min_class= $"{(MyClassName)i}{arr[i]}";
                        _min = arr[i];
                    }
                }
                return _min_class;
            }
        }

        public override string ToString()
        {
            return 
                $"{name,-8}"
              + $"{arr[0],8}"
              + $"{arr[1],11}"
              + $"{arr[2],10}"
              + $"{sum,11}"
              + $"{avg,11}"
              + $"{min_class,10}"
              + $"{Max_class,9}"; 
        }

        public string na_string { set; get; }//------->接住字串  自動實作屬性
        public string ch_string { set; get; }
        public string en_string { set; get; }
        public string ma_string { set; get; }
        public int total;
        public int ch   //------->輸出數字
        {
            get
            {
                if (!int.TryParse(ch_string, out int _ch))  //--->判斷字串是否是數字
                {
                    return -1;//--------> -1為異常數值
                }
                if (_ch > 100 || _ch < 0)
                {
                    return -2;//--------> -2為異常數值
                }
                else return _ch;
            }
        }
        public int en   //------->輸出數字
        {
            get
            {
                if (!int.TryParse(en_string, out int _en))  //--->判斷字串是否是數字
                {
                    return -1;//--------> -1為異常數值
                }
                if (_en > 100 || _en < 0)
                {
                    return -2;//--------> -2為異常數值
                }
                else return _en;
            }
        }
        public int ma   //------->輸出數字
        {
            get
            {
                if (!int.TryParse(ma_string, out int _ma))  //--->判斷字串是否是數字
                {
                    return -1;//--------> -1為異常數值
                }
                if (_ma > 100 || _ma < 0)
                {
                    return -2;//--------> -2為異常數值
                }
                else return _ma;
            }
        }




    

    }
}
