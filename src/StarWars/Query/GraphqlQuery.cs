using System;
using GraphQL.Types;
using StarWars.Types;

namespace StarWars
{
    public class GraphqlQuery : ObjectGraphType<object>
    {
        public GraphqlQuery(Respository respository)
        {
            Name = "Query";
            Description = "....";

            Field<ListGraphType<AccountType>>(
                "Account",
                resolve: context => respository.GetAccountDetails()
                );

            Field<ListGraphType<BranchType>>(
                "Branch",
                resolve: context => respository.GetBranchDetails()
                );
        }
    }
}
