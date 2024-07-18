using Application.Contexts.Groups.Repositories;
using Domain.Entities;
using Repository.Context;

namespace Repository.Repositories.Groups;

public class GroupsRepository(ApplicationDbContext dbContext) 
    : Repository<Group>(dbContext), IGroupsRepository
{

}