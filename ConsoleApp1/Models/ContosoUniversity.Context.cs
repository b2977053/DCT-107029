﻿//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApp1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ContosoUniversityEntities : DbContext
    {
        public ContosoUniversityEntities()
            : base("name=ContosoUniversityEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Enrollment> Enrollment { get; set; }
        public virtual DbSet<OfficeAssignment> OfficeAssignment { get; set; }
        public virtual DbSet<Person> Person { get; set; }
    
        public virtual int Department_Delete(Nullable<int> departmentID, byte[] rowVersion_Original)
        {
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            var rowVersion_OriginalParameter = rowVersion_Original != null ?
                new ObjectParameter("RowVersion_Original", rowVersion_Original) :
                new ObjectParameter("RowVersion_Original", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Department_Delete", departmentIDParameter, rowVersion_OriginalParameter);
        }
    
        public virtual ObjectResult<Department_Insert_Result> Department_Insert(string name, Nullable<decimal> budget, Nullable<System.DateTime> startDate, Nullable<int> instructorID)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var budgetParameter = budget.HasValue ?
                new ObjectParameter("Budget", budget) :
                new ObjectParameter("Budget", typeof(decimal));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var instructorIDParameter = instructorID.HasValue ?
                new ObjectParameter("InstructorID", instructorID) :
                new ObjectParameter("InstructorID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Department_Insert_Result>("Department_Insert", nameParameter, budgetParameter, startDateParameter, instructorIDParameter);
        }
    
        public virtual ObjectResult<byte[]> Department_Update(Nullable<int> departmentID, string name, Nullable<decimal> budget, Nullable<System.DateTime> startDate, Nullable<int> instructorID, byte[] rowVersion_Original)
        {
            var departmentIDParameter = departmentID.HasValue ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var budgetParameter = budget.HasValue ?
                new ObjectParameter("Budget", budget) :
                new ObjectParameter("Budget", typeof(decimal));
    
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("StartDate", startDate) :
                new ObjectParameter("StartDate", typeof(System.DateTime));
    
            var instructorIDParameter = instructorID.HasValue ?
                new ObjectParameter("InstructorID", instructorID) :
                new ObjectParameter("InstructorID", typeof(int));
    
            var rowVersion_OriginalParameter = rowVersion_Original != null ?
                new ObjectParameter("RowVersion_Original", rowVersion_Original) :
                new ObjectParameter("RowVersion_Original", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<byte[]>("Department_Update", departmentIDParameter, nameParameter, budgetParameter, startDateParameter, instructorIDParameter, rowVersion_OriginalParameter);
        }
    }
}
