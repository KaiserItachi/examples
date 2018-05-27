using GraphQL.Types;
using StarWars.Types;

namespace StarWars
{
    public class GraphqlMutation : ObjectGraphType<object>
    {
        public GraphqlMutation(Respository respository)
        {
            Name = "Mutaiton";
            Description = "Mutaitons are used to perform the Create Update and Delete operations.";

            Field<AccountType>(
                "CreateAccount",
                arguments: new QueryArguments(
                    new QueryArgument<NonNullGraphType<AccountInputType>> { Name = "Account" }
                ),
                resolve: context =>
                {
                    var account = context.GetArgument<Account>("Account");
                    return respository.AddNewAccount(account);
                });
        }
    }
}
