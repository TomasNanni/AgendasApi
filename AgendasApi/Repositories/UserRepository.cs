using AgendasApi.Entities;
using AgendasApi.Models.Interfaces;

namespace AgendasApi.Repositories
{
    public class UserRepository : IUserRepository
    {
        private List<User> _users = new List<User>
{
    new User { Id = 1, FirstName = "Juan", LastName = "Pérez", Password = "Pass123!", Email = "juan.perez@mail.com", State = User.MyEnum.Active },
    new User { Id = 2, FirstName = "María", LastName = "González", Password = "Secure456$", Email = "maria.gonzalez@mail.com", State = User.MyEnum.Active },
    new User { Id = 3, FirstName = "Carlos", LastName = "Ramírez", Password = "Carlos789@", Email = "carlos.ramirez@mail.com", State = User.MyEnum.Deleted },
    new User { Id = 4, FirstName = "Lucía", LastName = "Fernández", Password = "Lucy2024#", Email = "lucia.fernandez@mail.com", State = User.MyEnum.Active },
    new User { Id = 5, FirstName = "Pedro", LastName = "Martínez", Password = "PedroPwd!", Email = "pedro.martinez@mail.com", State = User.MyEnum.Active },
    new User { Id = 6, FirstName = "Ana", LastName = "López", Password = "AnaL0pez$", Email = "ana.lopez@mail.com", State = User.MyEnum.Active },
    new User { Id = 7, FirstName = "Diego", LastName = "Suárez", Password = "DiegoPass1", Email = "diego.suarez@mail.com", State = User.MyEnum.Deleted },
    new User { Id = 8, FirstName = "Valeria", LastName = "Castro", Password = "ValeCastro2", Email = "valeria.castro@mail.com", State = User.MyEnum.Active },
    new User { Id = 9, FirstName = "Martín", LastName = "Ortiz", Password = "OrtizM!99", Email = "martin.ortiz@mail.com", State = User.MyEnum.Active },
    new User { Id = 10, FirstName = "Sofía", LastName = "Moreno", Password = "SofiPwd12", Email = "sofia.moreno@mail.com", State = User.MyEnum.Deleted },
    new User { Id = 11, FirstName = "Ricardo", LastName = "Vega", Password = "RicVega22", Email = "ricardo.vega@mail.com", State = User.MyEnum.Active },
    new User { Id = 12, FirstName = "Julieta", LastName = "Navarro", Password = "JuliePwd33", Email = "julieta.navarro@mail.com", State = User.MyEnum.Active },
    new User { Id = 13, FirstName = "Tomás", LastName = "Silva", Password = "TomiPass@", Email = "tomas.silva@mail.com", State = User.MyEnum.Deleted },
    new User { Id = 14, FirstName = "Camila", LastName = "Mendoza", Password = "Cami123$", Email = "camila.mendoza@mail.com", State = User.MyEnum.Active },
    new User { Id = 15, FirstName = "Esteban", LastName = "Herrera", Password = "EstebanP@ss", Email = "esteban.herrera@mail.com", State = User.MyEnum.Active },
    new User { Id = 16, FirstName = "Florencia", LastName = "Santos", Password = "FloriPwd!", Email = "florencia.santos@mail.com", State = User.MyEnum.Active },
    new User { Id = 17, FirstName = "Javier", LastName = "Domínguez", Password = "JaviDom99", Email = "javier.dominguez@mail.com", State = User.MyEnum.Deleted },
    new User { Id = 18, FirstName = "Patricia", LastName = "Muñoz", Password = "PatriPwd@", Email = "patricia.munoz@mail.com", State = User.MyEnum.Active },
    new User { Id = 19, FirstName = "Alejandro", LastName = "Ruiz", Password = "AlexPass55", Email = "alejandro.ruiz@mail.com", State = User.MyEnum.Active },
    new User { Id = 20, FirstName = "Gabriela", LastName = "Cruz", Password = "GabyCruz1", Email = "gabriela.cruz@mail.com", State = User.MyEnum.Active },
    new User { Id = 21, FirstName = "Fernando", LastName = "Paz", Password = "FerPwd88", Email = "fernando.paz@mail.com", State = User.MyEnum.Deleted },
    new User { Id = 22, FirstName = "Natalia", LastName = "Luna", Password = "NatyPass!", Email = "natalia.luna@mail.com", State = User.MyEnum.Active },
    new User { Id = 23, FirstName = "Andrés", LastName = "Molina", Password = "AndresPwd@", Email = "andres.molina@mail.com", State = User.MyEnum.Active },
    new User { Id = 24, FirstName = "Carolina", LastName = "Aguilar", Password = "Caro2024$", Email = "carolina.aguilar@mail.com", State = User.MyEnum.Active },
    new User { Id = 25, FirstName = "Hernán", LastName = "Peralta", Password = "HernanPwd1", Email = "hernan.peralta@mail.com", State = User.MyEnum.Active },
    new User { Id = 26, FirstName = "Micaela", LastName = "Benítez", Password = "MicaPwd22", Email = "micaela.benitez@mail.com", State = User.MyEnum.Active },
    new User { Id = 27, FirstName = "Rodrigo", LastName = "Torres", Password = "RoroPass@", Email = "rodrigo.torres@mail.com", State = User.MyEnum.Deleted },
    new User { Id = 28, FirstName = "Paula", LastName = "Rojas", Password = "PauliPwd!", Email = "paula.rojas@mail.com", State = User.MyEnum.Active },
    new User { Id = 29, FirstName = "Ignacio", LastName = "Medina", Password = "NachoPwd$", Email = "ignacio.medina@mail.com", State = User.MyEnum.Active },
    new User { Id = 30, FirstName = "Lorena", LastName = "Cáceres", Password = "LorePass1", Email = "lorena.caceres@mail.com", State = User.MyEnum.Active }
};

        public bool CheckIfUserExists(int userId)
        {
            bool flag = false;
            foreach (var user in _users)
            {
                if (user.Id == userId)
                {
                    flag = true;
                }
            }
            return flag;
        }

        public int Create(User newUser)
        {
            int lastId = 1;
            if (_users[0] != null )
            {
                lastId = _users.Last().Id;
            }
            newUser.Id = lastId++;
            _users.Add(newUser);
            return newUser.Id;
        }

        public List<User> GetAll()
        {
            return _users;
        }

        public User? GetById(int userId)
        {
            foreach (var user in _users)
            {
                if (user.Id == userId)
                {
                    return user;
                }
            }
            return null;
        }

        public void RemoveUser(int userId)
        {
            _users.RemoveAt(userId);
        }

        public void Update(User updatedUser, int userId)
        {
            _users[userId] = updatedUser;
        }
    }
}
