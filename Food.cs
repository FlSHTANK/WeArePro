using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project_Me_No._1
{
    public class Food
    {
        private string _Food1;
        private string _Food2;
        private string _Food3;
      

        public Food(string _Food1, string _Food2, string _Food3)
        {
            this._Food1 = _Food1;
            this._Food2 = _Food2;
            this._Food3 = _Food3;
            
        }
        public string วันที่ยืม
        {
            get { return this._Food1; }
        }
        public string ช่วงเวลา
        {
            get { return this._Food2; }
        }
        public string หมายเหตุ
        {
            get { return this._Food3; }
        }
      
        

    }
}
