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

        //-----------------------------------------------------------------
        public MemberObject GetMemberByID(int memberId)
        {
            MemberObject member = null;
            IDataReader dataReader = null;
            string SQLSelect1 = "SELECT MemberID, MemberName, Password, RoleID, City, Country, Email " +
                " FROM Members WHERE MemberID = @MemberID";

            //string SQLSelect = "SELECT * FROM Members WHERE MemberID = @MemberID";
            try
            {
                var param = memberDataProvider.CreateParameter("@MemberID", 4, memberId, DbType.Int32);
                dataReader = memberDataProvider.GetDataReader(SQLSelect1, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new MemberObject
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Password = dataReader.GetString(2),
                        RoleID = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5),
                        Email = dataReader.GetString(6)
                    };
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
            return member;
        }

        public IEnumerable<MemberObject> SortNameDesc()
        {
            var members = this.GetMemberList();

            members = new List<MemberObject>(members.OrderByDescending(member => member.MemberName));

            return members;
        }
        //---------------------------------------------------------

        public void AddNew(MemberObject member)
        {
            try
            {
                MemberObject mem = GetMemberByID(member.MemberID);
                if (mem == null)
                {
                    string SQLInsert = "Insert Members values(@MemberID,@MemberName, @Password, @RoleID, @City, @Country, @Email)";
                    var paremeters = new List<SqlParameter>();
                    paremeters.Add(memberDataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    paremeters.Add(memberDataProvider.CreateParameter("@MemberName", 50, member.MemberName, DbType.String));
                    paremeters.Add(memberDataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                    paremeters.Add(memberDataProvider.CreateParameter("@RoleID", 50, member.RoleID, DbType.String));
                    paremeters.Add(memberDataProvider.CreateParameter("@City", 50, member.City, DbType.String));
                    paremeters.Add(memberDataProvider.CreateParameter("@Country", 50, member.Country, DbType.String));
                    paremeters.Add(memberDataProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                    memberDataProvider.Insert(SQLInsert, CommandType.Text, paremeters.ToArray());
                }
                else
                {
                    throw new Exception("The member is already exist");
                }


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        //---------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------
        public void Remove(int memberId)
        {
            try
            {
                MemberObject member = GetMemberByID(memberId);
                if (member != null)
                {
                    string SQLDelete = "DELETE Members WHERE MemberID = @MemberID";
                    var param = memberDataProvider.CreateParameter("@MemberID", 4, memberId, DbType.Int32);
                    memberDataProvider.Delete(SQLDelete, CommandType.Text, param);
                    // throw new Exception("The Member Delete is succesfully");
                }

            }
            catch (Exception ex)
            {
                throw new Exception("The member does not already exist");
            }
            finally
            {
                CloseConnection();
            }
        }//end function Delete members
    }
}
