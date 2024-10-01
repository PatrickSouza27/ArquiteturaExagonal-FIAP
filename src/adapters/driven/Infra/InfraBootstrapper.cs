using System.Net;
using Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace Infra;

public static class InfraBootstrapper
{
    public static void Register(IServiceCollection services)
    {
        services.AddTransient<IAuthenticatorRepository, AuthenticatorRepository>();
    }
}