using SIS.DataAccess;
using System;
using System.Data;

namespace SIS.BusinessLogic
{
    public class clsStudentSystem
    {
        public void SaveStudentRecord(string roleNo, string firstName, string lastName, string place)
        {
            clsDataAccess objClsDataAccess = new clsDataAccess();
            objClsDataAccess.InsertStudent(roleNo, firstName, lastName, place);
        }

        public DataTable FetchStudents()
        {
            clsDataAccess objClsDataAccess = new clsDataAccess();
            return objClsDataAccess.FetchStudents();
        }
    }
}