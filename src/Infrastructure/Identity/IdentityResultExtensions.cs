using xhuyz_dotnet_clean_architechture.Application.Common.Models;
using Microsoft.AspNetCore.Identity;

namespace xhuyz_dotnet_clean_architechture.Infrastructure.Identity;

public static class IdentityResultExtensions
{
    public static Result ToApplicationResult(this IdentityResult result)
    {
        return result.Succeeded
            ? Result.Success()
            : Result.Failure(result.Errors.Select(e => e.Description));
    }
}
