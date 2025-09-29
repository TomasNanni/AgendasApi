namespace AgendasApi.Models.Interfaces
{
    public interface IContactService
    {
        ContactDto Create(CreateAndUpdateContactDto dto, int loggedUserId);
        void Delete(int id);
        List<ContactWithGroupIdsDto> GetAllByUser(int id);
        ContactWithGroupIdsDto? GetOneByUser(int userId, int contactId);
        void Update(CreateAndUpdateContactDto dto, int contactId);
    }
}
