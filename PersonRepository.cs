using System;
using System.Collections.Generic;

namespace DemoNUnit
{
	public static class PersonRepository
	{
		public static Repository<Person> personRepository = new Repository<Person>();
		public static Repository<Address> addressRepository = new Repository<Address>();

		public static void Save(this Person person) 
		{
			personRepository.Save(person);
			addressRepository.Save(person.adress);
		}

		public static Person Find(this Person person, Guid? id)
		{
			return new Person(personRepository.Find(id));
		}

		public static void Delete(this Person person)
		{
			addressRepository.Delete(person.adress);
			personRepository.Delete(person);
		}
	}
}
