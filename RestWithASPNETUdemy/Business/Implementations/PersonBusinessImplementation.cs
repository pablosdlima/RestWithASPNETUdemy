﻿using RestWithASPNETUdemy.Data.Convert.Implementation;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository.Generic;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Business.Implementations
{
    public class PersonBusinessImplementation : IPersonBusiness
    {
        private readonly IRepository<Person> _repository;
        private readonly PersonConverter _converter;

        public PersonBusinessImplementation(IRepository<Person> repository)
        {
            _repository = repository;
            _converter = new PersonConverter();
        }
        
        // Method responsible for returning all people,
        public List<PersonVO> FindAll()
        {
            return _converter.Parse(_repository.FindAll());
        }

        // Method responsible for returning one PersonVO by ID
        public PersonVO FindByID(long id)
        {
            return _converter.Parse(_repository.FindById(id));
        }

        //Method responsible to crete one new PersonVO
        public PersonVO Create(PersonVO PersonVO)
        {
            var personEntity = _converter.Parse(PersonVO);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        // Method responsible for updating one PersonVO
        public PersonVO Update(PersonVO PersonVO)
        {
            var personEntity = _converter.Parse(PersonVO);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity);
        }

        // Method responsible for deleting a person from an ID
        public void Delete(long id)
        {
            _repository.Delete(id);
        }
    }
}
