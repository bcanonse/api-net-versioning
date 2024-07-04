using Asp.Versioning.ApiExplorer;
using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.SwaggerGen;


namespace VersionsApi.Helpers.Swagger;
public class ConfigureSwaggerOptions(
    IApiVersionDescriptionProvider provider
) : IConfigureOptions<SwaggerGenOptions>
{
    private readonly IApiVersionDescriptionProvider _provider = provider;
    public void Configure(SwaggerGenOptions options)
    {
        foreach (var description in _provider.ApiVersionDescriptions)
        {
            options.SwaggerDoc(description.GroupName, CreateInfoForApiVersion(description));
        }
    }

    private static OpenApiInfo CreateInfoForApiVersion(ApiVersionDescription description)
    {
        var info = new OpenApiInfo
        {
            Version = description.ApiVersion.ToString(),
            Title = "Net Core Web Api Versioning",
            Description = "Example on how to versioning a Web Api in Net Core",
            Contact = new OpenApiContact
            {
                Name = "Bryan Canon",
                Email = "bcanonse@gmail.com",
                Url = new Uri("https://www.linkedin.com/in/bcanonse/")
            },
            License = new OpenApiLicense
            {
                Name = "Use under LICX"
            }
        };
        if (description.IsDeprecated)
        {
            info.Description += "This API version has been deprecated.";
        }
        return info;
    }
}
