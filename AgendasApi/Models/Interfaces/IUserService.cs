namespace AgendasApi.Models.Interfaces
{
    public interface IUserService
    {
        bool CheckIfUserExists(int userId);
        UserDto Create(CreateAndUpdateUserDto dto);
        IEnumerable<UserDto> GetAll();
        GetUserByIdDto? GetById(int userId);
        void RemoveUser(int userId);
        void Update(CreateAndUpdateUserDto dto, int userId);
    }
}
