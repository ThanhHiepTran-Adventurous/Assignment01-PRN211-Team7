using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using BusinessObject;
using Microsoft.Data.SqlClient;



namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        //---------------------------------
        //
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();

        private MemberDAO()
        {

        }

        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }

        public IEnumerable<MemberObject> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "SELECT MemberID, MemberName, Password, RoleID, City, Country, Email FROM Members";
            var members = new List<MemberObject>();
            try
            {
                dataReader = memberDataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    members.Add(new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        RoleID = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5),
                        Email = dataReader.GetString(6)
                    });
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }

    }
}
