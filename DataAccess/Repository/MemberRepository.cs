
using BusinessObject;
using DataAccess;
namespace MyStoreWinApp
{
    public partial class MemberRepository : IMemberRepository
    {
        public MemberObject GetMemberID(int memberId) => MemberDAO.Instance.GetMemberByID(memberId);

        public IEnumerable<MemberObject> GetMembers() => MemberDAO.Instance.GetMemberList();

        public void InsertMember(MemberObject member) => MemberDAO.Instance.AddNew(member);

        public void DeleteMember(int memberId) => MemberDAO.Instance.Remove(memberId);

        public void UpdateMember(MemberObject member) => MemberDAO.Instance.Update(member);

        //  public MemberObject SearchMemberByName(string nameMember) => MemberDAO.Instance.SearchMemberByName(nameMember);

        public IEnumerable<MemberObject> SortNameDesc() => MemberDAO.Instance.SortNameDesc();


        public IEnumerable<MemberObject> FilterMemberByCountry(string country) => MemberDAO.Instance.FilterMemberByCountry(country);


        public IEnumerable<MemberObject> FilterMemberByCity(string city) => MemberDAO.Instance.FilterMemberByCity(city);


    }


}