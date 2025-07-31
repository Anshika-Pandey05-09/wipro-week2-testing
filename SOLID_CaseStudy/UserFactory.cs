using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_CaseStudy
{
    public static class UserFactory
    {
        public static User CreateUser(string role)
        {
            return role.ToLower() switch
            {
                "student" => new Student(),
                "instructor" => new Instructor(),
                _ => throw new ArgumentException("Invalid role: " + role)
            };
        }
    }
}
