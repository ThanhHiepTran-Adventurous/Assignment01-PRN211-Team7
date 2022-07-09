
using BusinessObject;
using DataAccess;
namespace MyStoreWinApp
{
    public partial class MemberRepository : IMemberRepository
    {


        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList();



    }


}