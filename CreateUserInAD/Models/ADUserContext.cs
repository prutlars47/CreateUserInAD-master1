namespace CreateUserInAD.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    public class ADContext : DbContext
    {
        // Your context has been configured to use a 'WebsiteContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'Website.Models.WebsiteContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'WebsiteContext' 
        // connection string in the application configuration file.
        public ADContext() : base("name=ADContext")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<User> Users { get; set; }
    }
}