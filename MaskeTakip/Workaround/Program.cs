using Business.Concrete;
using Entities.Concretes;

Person person = new();

person.FirstName = "Habip";
person.LastName = "Akyol";
person.DateOfBirthYear = 1999;
person.NationalIdentity = 11223344556;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person);