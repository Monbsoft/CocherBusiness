using Ardalis.GuardClauses;
using Monbsoft.CocherBusiness.SharedKernel;
using Monbsoft.CocherBusiness.SharedKernel.Interfaces;

namespace Monbsoft.CocherBusiness.Application.Domain;

public class Product : EntityBase, IAggregateRoot
{
	public Product(string name)
	{
		Name = Guard.Against.NullOrEmpty(name, nameof(name));
	}

	public string Name { get; private set; }
}
