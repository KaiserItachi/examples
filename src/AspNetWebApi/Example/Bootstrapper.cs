using GraphQL.Http;
using IoC;
using GraphQLSample;
using GraphQLSample.GraphqlTypes;
using GraphQLSample.GraphqlMutation;
using GraphQLSample.GraphqlQuery;
using GraphQLSample.GraphqlSchema;

namespace GraphQL.GraphiQL
{
    public class Bootstrapper
    {
        public System.Web.Http.Dependencies.IDependencyResolver Resolver()
        {
            var container = BuildContainer();
            var resolver = new SimpleContainerDependencyResolver(container);
            return resolver;
        }

        private ISimpleContainer BuildContainer()
        {
            var container = new SimpleContainer();
            container.Singleton<IDocumentExecuter>(new DocumentExecuter());
            container.Singleton<IDocumentWriter>(new DocumentWriter(true));

            container.Singleton(new Repository());
            container.Register<AccountType>();
            container.Register<BranchType>();
            container.Register<GraphqlQuery>();
            container.Register<GraphqlMutation>();
            container.Singleton(new GraphqlSchema(new FuncDependencyResolver(type => container.Get(type))));

            return container;
        }
    }
}
