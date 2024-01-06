using FreakFightsFan.Api.Data.Database;
using MediatR;

namespace FreakFightsFan.Api.Behaviors
{
    public class UnitOfWorkPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly AppDbContext _dbContext;
        private static bool IsNotCommand => !typeof(TRequest).Name.EndsWith("Command");
        private static bool IsImportFighterImagesCommand => typeof(TRequest).Name.EndsWith("ImportFighterImagesCommand");

        public UnitOfWorkPipelineBehavior(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (IsNotCommand || IsImportFighterImagesCommand)
            {
                return await next();
            }

            await using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);

            try
            {
                var response = await next();
                await _dbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);
                return response;
            }
            catch (Exception)
            {
                await transaction.RollbackAsync(cancellationToken);
                throw;
            }
        }
    }
}
