namespace Bookify.Domain.Users;

public interface IUserRepository
{
    Task<User?> GetByUserId (Guid userId, CancellationToken cancellationToken = default);
    void Add(User user);
}