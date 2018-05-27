using GraphQL;
using GraphQL.Types;

namespace StarWars
{
    public class GraphqlSchema: Schema
    {
        public GraphqlSchema(IDependencyResolver resolver)
            : base(resolver)
        {
            Query = resolver.Resolve<GraphqlQuery>();
            Mutation = resolver.Resolve<GraphqlMutation>();
        }
    }
}
