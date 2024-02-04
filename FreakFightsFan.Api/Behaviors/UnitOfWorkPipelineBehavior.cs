using FreakFightsFan.Api.Data.Database;
using MediatR;

namespace FreakFightsFan.Api.Behaviors
{
    public class UnitOfWorkPipelineBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
    {
        private readonly AppDbContext _dbContext;
        private readonly ILogger<UnitOfWorkPipelineBehavior<TRequest, TResponse>> _logger;

        private static bool IsNotCommand
            => !typeof(TRequest).Name.EndsWith("Command");
        private static bool IsImportFighterImagesCommand
            => typeof(TRequest).Name.EndsWith("ImportFighterImagesCommand");

        public UnitOfWorkPipelineBehavior(
            AppDbContext dbContext,
            ILogger<UnitOfWorkPipelineBehavior<TRequest, TResponse>> logger)
        {
            _dbContext = dbContext;
            _logger = logger;
        }

        public async Task<TResponse> Handle(
            TRequest request,
            RequestHandlerDelegate<TResponse> next,
            CancellationToken cancellationToken)
        {
            if (IsNotCommand || IsImportFighterImagesCommand)
            {
                return await next();
            }

            _logger.LogInformation("[UnitOfWork] Begin Transaction");

            await using var transaction = await _dbContext.Database.BeginTransactionAsync(cancellationToken);

            try
            {
                var response = await next();
                await _dbContext.SaveChangesAsync(cancellationToken);
                await transaction.CommitAsync(cancellationToken);

                _logger.LogInformation("[UnitOfWork] Commited Transaction");

                return response;
            }
            catch (Exception exception)
            {
                _logger.LogError("[UnitOfWork] Rollback Transaction {Exception}", exception);

                await transaction.RollbackAsync(cancellationToken);
                throw;
            }
        }
    }
}
