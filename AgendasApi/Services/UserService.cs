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
        private readonly UserRepository userRepository =  new UserRepository(); 
        public bool CheckIfUserExists(int userId)
        {
            return userRepository.CheckIfUserExists(userId);
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
            int newId = userRepository.Create(newUser);
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
            List<User> users = userRepository.GetAll();
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
            var user = userRepository.GetById(userId);
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
            userRepository.RemoveUser(userId);
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
            userRepository.Update(updatedUser, userId);
        }
    }
}
