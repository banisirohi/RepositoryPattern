using System;
using System.Collections.Generic;

namespace DemoNUnit
{
	public static class AddressRepository  
	{
		public static Repository<Address> addressRepository = new Repository<Address>();

		public static void Save(this Address address)
		{
			addressRepository.Save(address);
		}

		public static Address Find(this Address address, Guid? id)
		{
			return addressRepository.Find(id);
		}

		public static void Delete(this Address address)
		{
			addressRepository.Delete(address);
		}
	}
}
