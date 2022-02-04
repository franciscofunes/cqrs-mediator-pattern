using DemoLibrary.Models;
using System.Collections.Generic;

namespace DemoLibrary.DataAcces
{
    public interface IDataAccess
    {
        List<PersonModel> GetPeople();
        PersonModel InsertPerson(string firstName, string lastName);
    }
}