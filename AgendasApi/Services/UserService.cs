using AgendasApi.Entities;
using AgendasApi.Models.DTOs.User.Requests;
using AgendasApi.Models.DTOs.User.Responses;
using AgendasApi.Models.Interfaces;
using AgendasApi.Repositories;
using System.Linq;

namespace AgendasApi.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public bool CheckIfUserExists(int userId)
        {
            return _userRepository.CheckIfUserExists(userId);
        }

        public UserDto Create(CreateAndUpdateUserDto dto)
        {
            User newUser = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                State = (User.MyEnum)dto.State,
            };
            int newId = _userRepository.Create(newUser);
            UserDto userDto = new UserDto
            {
                Id = newId,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Email = dto.Email,
                State = (UserDto.MyEnum)dto.State, 
            };
            return userDto;
        }

        public IEnumerable<UserDto> GetAll()
        {
            List<User> users = _userRepository.GetAll();
            return users.Select(n => new UserDto
            {
                Id = n.Id,
                FirstName = n.FirstName,
                LastName = n.LastName,
                Password = n.Password,
                Email = n.Email,
                State = (UserDto.MyEnum)n.State,
            });
        }

        public GetUserByIdDto? GetById(int userId)
        {
            var user = _userRepository.GetById(userId);
            if (user == null) {
                return null;
            }
            else
            {
                var dto = new GetUserByIdDto
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    State = (GetUserByIdDto.MyEnum)user.State,
                };
                return dto;
            }
        }

        public void RemoveUser(int userId)
        {
            _userRepository.RemoveUser(userId);
        }

        public void Update(CreateAndUpdateUserDto dto, int userId)
        {
            var updatedUser = new User
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Password = dto.Password,
                Email = dto.Email,
                State = (User.MyEnum)dto.State,
            };
            _userRepository.Update(updatedUser, userId);
        }
    }
}
