using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace StarWars.Types
{
    public class AccountInputType : InputObjectGraphType
    {
        public AccountInputType()
        {
            Name = "AccountInput";

            Field<NonNullGraphType<IntGraphType>>("AccountId");
            Field<StringGraphType>("Name");
            Field<StringGraphType>("Address");
            Field<StringGraphType>("Country");
            Field<StringGraphType>("Email");
            Field<IntGraphType>("HomeBranchId");
        }
    }
}
