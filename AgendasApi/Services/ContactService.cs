﻿using AgendasApi.Entities;
using AgendasApi.Models.DTOs.Contact.Requests;
using AgendasApi.Models.DTOs.Contact.Responses;
using AgendasApi.Models.Interfaces;
using AgendasApi.Repositories;

namespace AgendasApi.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }
        public ContactDto Create(CreateAndUpdateContactDto dto, int loggedUserId)
        {
            var contact = new Contact
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Address = dto.Address,
                Number = dto.Number,
                Email = dto.Email,
                UrlImage = dto.UrlImage,
                Company = dto.Company,
                Description = dto.Description,
            };
            int id = _contactRepository.Create(contact);
            ContactDto contactDto = new ContactDto
            {
                Id = id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Address = dto.Address,
                Number = dto.Number,
                Email = dto.Email,
                UrlImage = dto.UrlImage,
                Company = dto.Company,
                Description = dto.Description,
            };
            return contactDto;
        }

        public void Delete(int id)
        {
            _contactRepository.Delete(id);
        }

        public List<ContactWithGroupIdsDto> GetAllByUser(int id)
        {
            IEnumerable<Contact> listContact = _contactRepository.GetAllByUser(id);
            List<ContactWithGroupIdsDto> listContactDto = [];
            foreach (var contact in listContact)
            {
                var contactDto = new ContactWithGroupIdsDto
                {
                    FirstName = contact.FirstName,
                    LastName = contact.LastName,

                };
                listContactDto.Add(contactDto);
            }
            return listContactDto;
        }

        public ContactWithGroupIdsDto? GetOneByUser(int userId, int contactId)
        {
            Contact? contact = _contactRepository.GetOneByUser(userId, contactId);
            var contactWithGroupIdsDto = new ContactWithGroupIdsDto
            {
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                Address = contact.Address,
                Number = contact.Number,
                Email = contact.Email,
                UrlImage = contact.UrlImage,
                Company = contact.Company,
                Description = contact.Description,
            };
            return contactWithGroupIdsDto;
        }

        public void Update(CreateAndUpdateContactDto dto, int contactId)
        {
            var contact = new Contact
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Address = dto.Address,
                Number = dto.Number,
                Email = dto.Email,
                UrlImage = dto.UrlImage,
                Company = dto.Company,
                Description = dto.Description,
            };
            _contactRepository.Update(contact, contactId);
        }
    }
}
