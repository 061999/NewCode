using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL
    {
        public bool isStudentLogined(string username,string pwd)
        {
            DAL.StudentInfo studentInfo = new DAL.StudentInfo();
            System.Data.DataSet ds= studentInfo.GetList("sid="+username+" and spwd="+pwd);
            if (ds.Tables[0].Rows.Count>=1)
            {
                return true;
            }
            return false;
        }
        public bool isAdminLogined(string username,string pwd)
        {
            DAL.AdminInfo adminInfo = new DAL.AdminInfo();
            System.Data.DataSet ds = adminInfo.GetList("adminid=" + username + " and adminpwd=" + pwd);
            if (ds.Tables[0].Rows.Count >= 1)
            {
                return true;
            }
            return false;
        }
    }
}
