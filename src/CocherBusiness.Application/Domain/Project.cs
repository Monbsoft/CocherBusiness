using Ardalis.GuardClauses;
using Monbsoft.CocherBusiness.SharedKernel;
using Monbsoft.CocherBusiness.SharedKernel.Interfaces;

namespace Monbsoft.CocherBusiness.Application.Domain;

public class Project : EntityBase, IAggregateRoot
{
	public Project(string name, string? description)
	{
		Name = Guard.Against.NullOrEmpty(name, nameof(name));
		Description = description;
	}

    public string Name { get; private set; }
	public string? Description { get; private set; }
}
