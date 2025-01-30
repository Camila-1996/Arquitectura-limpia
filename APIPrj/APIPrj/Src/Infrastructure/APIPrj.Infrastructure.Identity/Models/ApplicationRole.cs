using System;
using Microsoft.AspNetCore.Identity;

namespace APIPrj.Infrastructure.Identity.Models
{
    public class ApplicationRole(string name) : IdentityRole<Guid>(name)
    {
    }
}
