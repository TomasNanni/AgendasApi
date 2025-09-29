using AgendasApi.Entities;
using AgendasApi.Models.Interfaces;

namespace AgendasApi.Repositories
{

    public class ContactRepository : IContactRepository
    {
        private List<Contact> _contacts = new List<Contact>{
    new Contact {Id = 1, FirstName = "Juan", LastName = "Pérez", Address = "Av. Siempre Viva 123", Number = "1122334455", Email = "juan.perez@mail.com", UrlImage = "https://picsum.photos/200?1", Company = "TechCorp", Description = "Amigo de la infancia", UserId = 1 },
    new Contact { Id = 2, FirstName = "María", LastName = "González", Address = "Calle Falsa 456", Number = "1133445566", Email = "maria.gonzalez@mail.com", UrlImage = "https://picsum.photos/200?2", Company = "SoftSolutions", Description = "Compañera de trabajo", UserId = 1 },
    new Contact { Id = 3, FirstName = "Carlos", LastName = "Ramírez", Address = "Boulevard Central 789", Number = "1144556677", Email = "carlos.ramirez@mail.com", UrlImage = "https://picsum.photos/200?3", Company = "BuildIt", Description = "Vecino", UserId = 2 },
    new Contact { Id = 4, FirstName = "Lucía", LastName = "Fernández", Address = "Diagonal Norte 321", Number = "1155667788", Email = "lucia.fernandez@mail.com", UrlImage = "https://picsum.photos/200?4", Company = "HealthCare Inc", Description = "Médica de confianza", UserId = 2 },
    new Contact { Id = 5, FirstName = "Pedro", LastName = "Martínez", Address = "San Martín 654", Number = "1166778899", Email = "pedro.martinez@mail.com", UrlImage = "https://picsum.photos/200?5", Company = "FinanzasYA", Description = "Asesor financiero", UserId = 3 },
    new Contact { Id = 6, FirstName = "Ana", LastName = "López", Address = "Colon 999", Number = "1177889900", Email = "ana.lopez@mail.com", UrlImage = "https://picsum.photos/200?6", Company = "DesignPro", Description = "Diseñadora gráfica", UserId = 3 },
    new Contact { Id = 7, FirstName = "Diego", LastName = "Suárez", Address = "Belgrano 321", Number = "1188990011", Email = "diego.suarez@mail.com", UrlImage = "https://picsum.photos/200?7", Company = "CodeFactory", Description = "Programador .NET", UserId = 4 },
    new Contact { Id = 8, FirstName = "Valeria", LastName = "Castro", Address = "Mitre 741", Number = "1199001122", Email = "valeria.castro@mail.com", UrlImage = "https://picsum.photos/200?8", Company = "GreenLife", Description = "Consultora ambiental", UserId = 4 },
    new Contact { Id = 9, FirstName = "Martín", LastName = "Ortiz", Address = "Rivadavia 159", Number = "1100112233", Email = "martin.ortiz@mail.com", UrlImage = "https://picsum.photos/200?9", Company = "EduTech", Description = "Profesor universitario", UserId = 5 },
    new Contact { Id = 10, FirstName = "Sofía", LastName = "Moreno", Address = "Güemes 222", Number = "1111223344", Email = "sofia.moreno@mail.com", UrlImage = "https://picsum.photos/200?10", Company = "Art&Co", Description = "Artista plástica", UserId = 5 },
    new Contact { Id = 11, FirstName = "Ricardo", LastName = "Vega", Address = "Catamarca 909", Number = "1122334466", Email = "ricardo.vega@mail.com", UrlImage = "https://picsum.photos/200?11", Company = "SafeHome", Description = "Arquitecto", UserId = 6 },
    new Contact { Id = 12, FirstName = "Julieta", LastName = "Navarro", Address = "Entre Ríos 303", Number = "1133445567", Email = "julieta.navarro@mail.com", UrlImage = "https://picsum.photos/200?12", Company = "HealthyFood", Description = "Nutricionista", UserId = 6 },
    new Contact { Id = 13, FirstName = "Tomás", LastName = "Silva", Address = "Corrientes 400", Number = "1144556678", Email = "tomas.silva@mail.com", UrlImage = "https://picsum.photos/200?13", Company = "SportMax", Description = "Entrenador personal", UserId = 7 },
    new Contact { Id = 14, FirstName = "Camila", LastName = "Mendoza", Address = "Sarmiento 123", Number = "1155667789", Email = "camila.mendoza@mail.com", UrlImage = "https://picsum.photos/200?14", Company = "TravelWorld", Description = "Agente de viajes", UserId = 7 },
    new Contact { Id = 15, FirstName = "Esteban", LastName = "Herrera", Address = "Lavalle 888", Number = "1166778890", Email = "esteban.herrera@mail.com", UrlImage = "https://picsum.photos/200?15", Company = "FixIt", Description = "Técnico electrónico", UserId = 8 }
};
        public int Create(Contact newContact)
        {
            int lastId = 1;
            if (_contacts[0] != null)
            {
                lastId = _contacts.Last().Id;
            }
            newContact.Id = lastId++;
            _contacts.Add(newContact);
            return newContact.Id;
        }

        public void Delete(int id)
        {
            _contacts.RemoveAt(id);
        }

        public IEnumerable<Contact> GetAllByUser(int id)
        {
            List<Contact> userContacts = [];
            foreach (var contact in _contacts)
            {
                if (contact.UserId == id)
                {
                    userContacts.Add(contact);
                }
            }
            return userContacts;
        }

        public Contact? GetByContactId(int contactId)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Id == contactId)
                {
                    return contact;
                }
            }
            return null;
        }

        public Contact? GetOneByUser(int userId, int contactId)
        {
            foreach (var contact in _contacts)
            {
                if (contact.Id == contactId && contact.UserId == userId)
                {
                    return contact;
                }
            }
            return null;
        }

        public void Update(Contact updatedContact, int contactId)
        {
            _contacts[contactId] = updatedContact;
        }
    }
}
