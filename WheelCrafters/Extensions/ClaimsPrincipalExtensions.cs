using System.Security.Claims;

namespace WheelCrafters.Extensions
{
    public static class ClaimsPrincipalExtensions
    {   
        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.NameIdentifier).Value;
        }
    }
}
