using System;
using System.Collections.Generic;

namespace DemoNUnit
{
	public static class BusinessRepository
	{
		public static Repository<Business> businessRepository = new Repository<Business>();
		public static Repository<Address> addressRepository = new Repository<Address>();

		public static void Save(this Business business)
		{
			businessRepository.Save(business);
			addressRepository.Save(business.Address);
		}

		public static Business Find(this Business business, Guid? id)
		{
			return new Business(businessRepository.Find(id));
		}

		public static void Delete(this Business business)
		{
			addressRepository.Delete(business.Address);
			businessRepository.Delete(business);
		}
	}
}
