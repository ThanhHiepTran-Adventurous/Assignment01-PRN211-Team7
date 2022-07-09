
using BusinessObject;
namespace MyStoreWinApp

{
     public interface IMemberRepository
    {
        IEnumerable<MemberObject> GetMembers();

        void DeleteMember(int memberID);
    }
}