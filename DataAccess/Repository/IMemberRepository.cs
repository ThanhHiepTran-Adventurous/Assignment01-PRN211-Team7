
using BusinessObject;
namespace MyStoreWinApp

{
     public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();

        MemberObject GetMemberID(int memberId);

        void InsertMember(MemberObject member);

        void DeleteMember(int memberId);

        void UpdateMember(MemberObject member);

        IEnumerable<MemberObject> SortNameDesc();

        IEnumerable<MemberObject> FilterMemberByCountry(string country);

        IEnumerable<MemberObject> FilterMemberByCity(string city);

    }
}