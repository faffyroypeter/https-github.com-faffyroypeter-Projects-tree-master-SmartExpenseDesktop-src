using SIS.DataAccess;
using System;
using System.Data;

namespace SIS.BusinessLogic
{
    public class clsStudentSystem
    {
        public void SaveUserRecord(string name, string userName, string email, string password)
        {
            clsDataAccess objClsDataAccess = new clsDataAccess();
            objClsDataAccess.InsertUser(name, userName, email, password);
        }

        public DataTable FetchUsers()
        {
            clsDataAccess objClsDataAccess = new clsDataAccess();
            return objClsDataAccess.FetchUsers();
        }
    }
}