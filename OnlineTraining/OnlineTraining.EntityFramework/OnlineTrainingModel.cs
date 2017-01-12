[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace OnlineTraining.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineTrainingModel : DbContext
    {
        public OnlineTrainingModel()
            : base("name=OnlineTrainingModel1")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public virtual DbSet<Courses> courses { get; set; }
        public virtual DbSet<Customers> customers { get; set; }
        public virtual DbSet<Performances> performances { get; set; }
    }
}
