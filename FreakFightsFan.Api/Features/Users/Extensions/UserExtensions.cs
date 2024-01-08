using FreakFightsFan.Api.Data.Entities;
using FreakFightsFan.Api.Features.Users.Commands;
using FreakFightsFan.Api.Features.Users.Queries;
using FreakFightsFan.Shared.Abstractions;
using FreakFightsFan.Shared.Features.Users.Requests;
using FreakFightsFan.Shared.Features.Users.Responses;
using System.Linq.Expressions;

namespace FreakFightsFan.Api.Features.Users.Extensions
{
    public static class UserExtensions
    {
        public static IEndpointRouteBuilder AddUserEndpoints(this IEndpointRouteBuilder app)
        {
            ConfirmEmail.Endpoint(app);
            DegradeUser.Endpoint(app);
            Login.Endpoint(app);
            PromoteUser.Endpoint(app);
            Register.Endpoint(app);
            UpdateUser.Endpoint(app);
            GetAllUsers.Endpoint(app);
            GetUser.Endpoint(app);

            return app;
        }

        public static UserDto ToDto(this User user)
        {
            return new()
            {
                Id = user.Id,
                Created = user.Created,
                Modified = user.Modified,
                UserName = user.UserName,
                Email = user.Email,
                IsAdmin = user.IsAdmin,
                IsSuperAdmin = user.IsSuperAdmin,
            };
        }
        
        public static Login.Command ToLoginCommand(this LoginRequest request)
        {
            return new()
            {
                Email = request.Email,
                Password = request.Password,
            };
        }

        public static Register.Command ToRegisterCommand(this RegisterRequest request)
        {
            return new()
            {
                Email = request.Email,
                UserName = request.UserName,
                Password = request.Password,
                RepeatPassword = request.RepeatPassword,
            };
        }

        public static UpdateUser.Command ToUpdateUserCommand(this UpdateUserRequest request, int id)
        {
            return new()
            {
                Id = id,
                ImageBase64 = request.ImageBase64
            };
        }

        public static GetAllUsers.Query ToGetAllUsersQuery(this GetAllUsersRequest request)
        {
            return new()
            {
                Page = request.Page,
                PageSize = request.PageSize,
                SortOrder = request.SortOrder,
                SortColumn = request.SortColumn,
                SearchTerm = request.SearchTerm,
            };
        }

        public static IQueryable<User> FilterMyUsers(this IQueryable<User> users, GetAllUsers.Query query)
        {
            var searchTerm = query.SearchTerm.ToLower().Trim();
            if (!string.IsNullOrWhiteSpace(searchTerm))
                users = users.Where(x =>
                    x.UserName.ToLower().Contains(searchTerm) ||
                    x.Email.ToLower().Contains(searchTerm));

            return users;
        }

        public static IQueryable<User> SortMyUsers(this IQueryable<User> users, GetAllUsers.Query query)
        {
            return query.SortOrder switch
            {
                SortOrder.Ascending => users.OrderBy(GetUsersSortProperty(query)),
                SortOrder.Descending => users.OrderByDescending(GetUsersSortProperty(query)),
                SortOrder.None => users.OrderBy(x => x.UserName),
                _ => users.OrderBy(x => x.UserName),
            };
        }

        private static Expression<Func<User, object>> GetUsersSortProperty(GetAllUsers.Query query)
        {
            return query.SortColumn.ToLowerInvariant() switch
            {
                "username" => user => user.UserName,
                "email" => user => user.Email,
                _ => user => user.UserName,
            };
        }
    }
}
