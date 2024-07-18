using MediatR;

namespace CqrsMediatRFluentValidation.Queries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}