using MediatR;

namespace CqrsMediatRFluentValidation.Queries;

public record GetProductByIdQuery(int Id) : IRequest<Product>;
