using System;

namespace DemoNUnit
{
	public abstract class EntityBase
	{
		public Guid? ID { get; set; }
	}

	public class Person : EntityBase
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public Address adress { get; set; }

		//created parametrised constructor for test scenarios like: var address = new Address("5455 Apache Trail", "Queen Creek", "AZ", "85243");
		public Person(string fname, string lname, Address address)
		{
			this.FirstName = fname;
			this.LastName = lname;
			this.adress = address;
		}

		//created constructor for test scenarios like: Assert.AreEqual(savedPerson.adress, address);
		public Person(Person newPerson)
		{
			this.FirstName = newPerson.FirstName;
			this.LastName = newPerson.LastName;
			this.adress = new Address(newPerson.adress);
			this.ID = newPerson.ID;
		}

		//created constructor for test scenarios like: Assert.AreEqual(savedPerson.adress, address);
		public override bool Equals(Object obj)
		{
			// Check for null values and compare run-time types.
			if (obj == null || GetType() != obj.GetType())
				return false;

			Person p = (Person)obj;
			return (FirstName == p.FirstName) && (LastName == p.LastName) && (adress.City == p.adress.City) && (adress.Country == p.adress.Country) && (adress.Street == p.adress.Street) && (adress.PostCode == p.adress.PostCode);

		}
		//created constructor for test scenarios like: Assert.AreEqual(savedPerson.adress, address);
		public override int GetHashCode()
		{
			byte[] _bytes = ID.Value.ToByteArray();
			int i = ((int)_bytes[0]) | ((int)_bytes[1] << 8) | ((int)_bytes[2] << 16) | ((int)_bytes[3] << 24);

			return i;
		}

	}

	public class Address : EntityBase
	{
		public string Street { get; set; }
		public string City { get; set; }
		public string Country { get; set; }
		public string PostCode { get; set; }

		//created parametrised constructor for test scenarios like: var address = new Address("5455 Apache Trail", "Queen Creek", "AZ", "85243");
		public Address(string street, string city, string country, string postcode)
		{
			this.Street = street;
			this.City = city;
			this.Country = country;
			this.PostCode = postcode;
		}

		//created constructor for test scenarios like: Assert.AreEqual(savedPerson.adress, address);
		public Address(Address newAddress)
		{
			this.City = newAddress.City;
			this.Country = newAddress.Country;
			this.Street = newAddress.Street;
			this.PostCode = newAddress.PostCode;
			this.ID = newAddress.ID;
		}

		//created constructor for test scenarios like: Assert.AreEqual(savedPerson.adress, address);
		public override bool Equals(Object obj)
		{
			// Check for null values and compare run-time types.
			if (obj == null || GetType() != obj.GetType())
				return false;

			Address p = (Address)obj;
			return (Street == p.Street) && (Country == p.Country) && (City == p.City) & (PostCode == p.PostCode);

		}

		//created constructor for test scenarios like: Assert.AreEqual(savedPerson.adress, address);
		public override int GetHashCode()
		{
			byte[] _bytes = ID.Value.ToByteArray();
			int i = ((int)_bytes[0]) | ((int)_bytes[1] << 8) | ((int)_bytes[2] << 16) | ((int)_bytes[3] << 24);

			return i;
		}

	}

	public class Business : EntityBase
	{
		public string Name { get; set; }
		public Address Address { get; set; }

		//created parametrised constructor for test scenarios like: var address = new Address("5455 Apache Trail", "Queen Creek", "AZ", "85243");
		public Business(string bname, Address address)
		{
			this.Name = bname;
			this.Address = address;
		}

		//created constructor for test scenarios like: Assert.AreEqual(savedPerson.adress, address);
		public Business(Business newBusiness)
		{
			Name = newBusiness.Name;
			ID = newBusiness.ID;
			Address = new Address(newBusiness.Address);
		}

		//created constructor for test scenarios like: Assert.AreEqual(savedPerson.adress, address);
		public override bool Equals(Object obj)
		{
			// Check for null values and compare run-time types.
			if (obj == null || GetType() != obj.GetType())
				return false;

			Business p = (Business)obj;
			return (Name == p.Name) && (Address.City == p.Address.City) && (Address.Country == p.Address.Country) && (Address.Street == p.Address.Street) && (Address.PostCode == p.Address.PostCode);

		}

		//created constructor for test scenarios like: Assert.AreEqual(savedPerson.adress, address);
		public override int GetHashCode()
		{
			byte[] _bytes = ID.Value.ToByteArray();
			int i = ((int)_bytes[0]) | ((int)_bytes[1] << 8) | ((int)_bytes[2] << 16) | ((int)_bytes[3] << 24);

			return i;
		}


	}
}