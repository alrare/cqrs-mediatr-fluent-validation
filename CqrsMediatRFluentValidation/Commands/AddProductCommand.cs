using MediatR;

namespace CqrsMediatRFluentValidation.Commands;

                                //Utilizar DTO
public record AddProductCommand(Product Product) : IRequest<Product>;
