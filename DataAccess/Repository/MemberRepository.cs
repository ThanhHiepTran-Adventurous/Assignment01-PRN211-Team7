
using BusinessObject;
using DataAccess;
namespace MyStoreWinApp
{
    public partial class MemberRepository : IMemberRepository
    {
        public void DeleteMember(int memberId) => MemberDAO.Instance.Remove(memberId);

        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNew(member);

        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList();

        public MemberObject GetMemberID(int memberId) => MemberDAO.Instance.GetMemberByID(memberId);



    }


}