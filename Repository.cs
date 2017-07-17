using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DemoNUnit
{
	public interface IRepository<T> where T : EntityBase
	{
		void Save(T item);
		void Delete(T item);
		T Find(Guid? id);
	}

	public class Repository<T> : IRepository<T> where T : EntityBase
	{
		public Dictionary<Guid, T> _db = new Dictionary<Guid, T>();

		public void Save(T item)
		{
			item.ID = Guid.NewGuid();
			_db.Add(item.ID.Value, item);
		}

		public void Delete(T item)
		{
			_db.Remove(item.ID.Value);
		}

		public T Find(System.Guid? id)
		{
			if (id != null & _db.ContainsKey(id.Value))
				return _db[id.Value];
			return default(T);
		}
	}
}