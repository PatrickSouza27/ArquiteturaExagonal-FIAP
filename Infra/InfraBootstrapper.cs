using System.Net;
using Infra.Repositories;
using Infra.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Infra;

public static class InfraBootstrapper
{
    public static void Register(IServiceCollection services)
    {
        services.AddTransient<IAuthenticatorRepository, AuthenticatorRepository>();
    }
}