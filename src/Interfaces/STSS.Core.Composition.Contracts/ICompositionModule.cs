using Microsoft.Extensions.DependencyInjection;

namespace STSS.Core.Composition.Contracts;

public interface ICompositionModule
{
    IServiceCollection Register(
        IServiceCollection services,
        IConfiguration configuration);
}
