using LmycDataLib;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LmycWebSite.Startup))]
namespace LmycWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            CreateRolesandUsers();
        }

        // Make sure to create User roles and Admin user "a"
        // Resource: ASP.NET MVC 5 Security And Creating User Role
        // Link: https://code.msdn.microsoft.com/vstudio/ASPNET-MVC-5-Security-And-44cbdb97/sourcecode?fileId=147300&pathId=1885231566
        private void CreateRolesandUsers()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));


            // In Startup, creating first Admin Role and creating a default Admin User 
            if (!roleManager.RoleExists("Admin"))
            {

                // first we create Admin rool
                var role = new IdentityRole();
                role.Name = "Admin";
                roleManager.Create(role);

                //Here we create a Admin user who will maintain the website				

                var user = new ApplicationUser();
                user.UserName = "a";
                user.Email = "a@a.a";

                string userPWD = "P@$$w0rd";

                var chkUser = UserManager.Create(user, userPWD);

                //Add default User to Role Admin
                if (chkUser.Succeeded)
                {
                    var result1 = UserManager.AddToRole(user.Id, "Admin");

                }
            }

            // creating Creating Member role 
            if (!roleManager.RoleExists("Member"))
            {
                var role = new IdentityRole();
                role.Name = "Member";
                roleManager.Create(role);

            }
        }
    }
}

