using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;

namespace MyWebRecruit.Data.Entities
{
    public partial class MyWebRecruitDataBaseContext : DbContext
    {
        public MyWebRecruitDataBaseContext(DbContextOptions options) : base(options)
        {
        }

        public virtual DbSet<AssigType> AssigType { get; set; }
        public virtual DbSet<Assignment> Assignment { get; set; }
        public virtual DbSet<Candidate> Candidate { get; set; }        
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Contact> Contact { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<Cv> Cv { get; set; }
        public virtual DbSet<JobGeneral> JobGeneral { get; set; }
        public virtual DbSet<Journal> Journal { get; set; }
        public virtual DbSet<PayMethod> PayMethod { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<XClientContact> XClientContact { get; set; }
        public virtual DbSet<XJobContact> XJobContact { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<AssigType>(entity =>
            {
                entity.ToTable("Assig_Type");

                entity.Property(e => e.Id)
                    .HasColumnName("ASSIG_TYPE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssigTypeDescr)
                    .IsRequired()
                    .HasColumnName("ASSIG_TYPE_DESCR")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Assignment>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.Property(e => e.Id)
                    .HasColumnName("ASSIG_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AssigType).HasColumnName("ASSIG_TYPE");

                entity.Property(e => e.CandId).HasColumnName("CAND_ID");

                entity.Property(e => e.EndDt)
                    .HasColumnName("END_DT")
                    .HasColumnType("date");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.Property(e => e.JobName)
                    .IsRequired()
                    .HasColumnName("JOB_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.ReasonLeave)
                    .HasColumnName("REASON_LEAVE")
                    .HasMaxLength(100);

                entity.Property(e => e.Salary)
                    .HasColumnName("SALARY")
                    .HasColumnType("money");

                entity.Property(e => e.StartDt)
                    .HasColumnName("START_DT")
                    .HasColumnType("date");

                entity.HasOne(d => d.AssigTypeNavigation)
                    .WithMany(p => p.Assignment)
                    .HasForeignKey(d => d.AssigType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assignment_Assig_Type");

                entity.HasOne(d => d.Cand)
                    .WithMany(p => p.Assignment)
                    .HasForeignKey(d => d.CandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assignment_Candidate");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Assignment)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Assignment_Job_General");
            });

            modelBuilder.Entity<Candidate>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("CANDIDATE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AlterTelNo)
                    .HasColumnName("ALTER_TEL_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.DisturbYn).HasColumnName("DISTURB_YN");

                entity.Property(e => e.Dob)
                    .HasColumnName("DOB")
                    .HasColumnType("date");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255);

                entity.Property(e => e.Facebook)
                    .HasColumnName("FACEBOOK")
                    .HasMaxLength(100);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Linkedin)
                    .HasColumnName("LINKEDIN")
                    .HasMaxLength(100);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("MIDDLE_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.Skype)
                    .HasColumnName("SKYPE")
                    .HasMaxLength(100);

                entity.Property(e => e.TelNo)
                    .IsRequired()
                    .HasColumnName("TEL_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.AddressLine)
                .HasColumnName("ADDRESS_LINE")
                .HasMaxLength(100);

                entity.Property(e => e.AddressCity)
                .HasColumnName("ADDRESS_CITY")
                .HasMaxLength(20);

                entity.Property(e => e.AddressIndex)
                .HasColumnName("ADDRESS_INDEX")
                .HasMaxLength(10);

                entity.Property(e => e.Country)
                .HasColumnName("COUNTRY_ID");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Candidate)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Candidate_User");

                entity.HasOne(d => d.Country)
                .WithMany(p => p.Candidate)
                .HasForeignKey(d => d.CountryId)
                .HasConstraintName("FK_Candidate_Country");
            });

            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("CLIENT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressCity)
                    .HasColumnName("ADDRESS_CITY")
                    .HasMaxLength(50);

                entity.Property(e => e.AddressIndex)
                    .HasColumnName("ADDRESS_INDEX")
                    .HasMaxLength(10);

                entity.Property(e => e.AddressLine)
                    .HasColumnName("ADDRESS_LINE")
                    .HasMaxLength(200);

                entity.Property(e => e.CountryId).HasColumnName("COUNTRY");

                entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.TelNo)
                    .IsRequired()
                    .HasColumnName("TEL_NO")
                    .HasMaxLength(20);

                entity.Property(e => e.WebSite)
                    .HasColumnName("WEB_SITE")
                    .HasMaxLength(200);

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Client_Country");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Client_User");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("CONTACT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Department)
                    .HasColumnName("DEPARTMENT")
                    .HasMaxLength(100);

                entity.Property(e => e.DisturbYn).HasColumnName("DISTURB_YN");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasColumnName("EMAIL")
                    .HasMaxLength(255);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasColumnName("FIRST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.JobTitle)
                    .HasColumnName("JOB_TITLE")
                    .HasMaxLength(100);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasColumnName("LAST_NAME")
                    .HasMaxLength(50);

                entity.Property(e => e.TelNo)
                    .IsRequired()
                    .HasColumnName("TEL_NO")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("COUNTRY_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryName)
                    .IsRequired()
                    .HasColumnName("COUNTRY_NAME")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Cv>(entity =>
            {
                entity.ToTable("CV");

                entity.Property(e => e.Id)
                    .HasColumnName("CV_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CandId).HasColumnName("CAND_ID");

                entity.Property(e => e.CvLink)
                    .IsRequired()
                    .HasColumnName("CV_LINK")
                    .HasMaxLength(250);

                entity.HasOne(d => d.Cand)
                    .WithMany(p => p.Cv)
                    .HasForeignKey(d => d.CandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CV_Candidate");
            });            

            modelBuilder.Entity<JobGeneral>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("Job_General");

                entity.Property(e => e.Id)
                    .HasColumnName("JOB_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressCity)
                    .HasColumnName("ADDRESS_CITY")
                    .HasMaxLength(100);

                entity.Property(e => e.AddressIndex)
                    .HasColumnName("ADDRESS_INDEX")
                    .HasMaxLength(10);

                entity.Property(e => e.AddressLine)
                    .HasColumnName("ADDRESS_LINE")
                    .HasMaxLength(100);

                entity.Property(e => e.CountryId).HasColumnName("COUNTRY");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100);

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasColumnName("CATEGORY")
                    .HasMaxLength(50);

                entity.Property(e => e.EndDt)
                    .HasColumnName("END_DT")
                    .HasColumnType("date");

                entity.Property(e => e.IntershipYn).HasColumnName("INTERSHIP_YN");

                entity.Property(e => e.JobCurrency)
                    .HasColumnName("JOB_CURRENCY")
                    .HasMaxLength(10);

                entity.Property(e => e.JobStatus)
                    .HasColumnName("JOB_STATUS")
                    .HasMaxLength(50);

                entity.Property(e => e.NoReq).HasColumnName("NO_REQ");

                entity.Property(e => e.PayMethod).HasColumnName("PAY_METHOD");

                entity.Property(e => e.Salary)
                    .HasColumnName("SALARY")
                    .HasColumnType("money");

                entity.Property(e => e.StartDt)
                    .HasColumnName("START_DT")
                    .HasColumnType("date");

                entity.HasOne(d => d.PayMethodNavigation)
                    .WithMany(p => p.JobGeneral)
                    .HasForeignKey(d => d.PayMethod)
                    .HasConstraintName("FK_Job_General_Pay_Method");

                entity.HasOne(d => d.CountryNavigation)
                    .WithMany(p => p.JobGeneral)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_Job_General_Country");
            });

            modelBuilder.Entity<Journal>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("JOURNAL_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("DESCRIPTION")
                    .HasMaxLength(500);

                entity.Property(e => e.DtLogged)
                    .HasColumnName("DT_LOGGED")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntityId).HasColumnName("ENTITY_ID");

                entity.HasOne(d => d.Entity)
                    .WithMany(p => p.Journal)
                    .HasForeignKey(d => d.EntityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Journal_User");
            });

            modelBuilder.Entity<PayMethod>(entity =>
            {
                entity.ToTable("Pay_Method");

                entity.Property(e => e.Id)
                    .HasColumnName("PAY_METHOD_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.PayMethodDescr)
                    .IsRequired()
                    .HasColumnName("PAY_METHOD_DESCR")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("USER_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.AdminYn).HasColumnName("ADMIN_YN");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("CREATE_TIME")
                    .HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("PASSWORD")
                    .HasMaxLength(50);

                entity.Property(e => e.UserEmail)
                    .IsRequired()
                    .HasColumnName("USER_EMAIL")
                    .HasMaxLength(255);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasColumnName("USER_NAME")
                    .HasMaxLength(16);
            });

            modelBuilder.Entity<XClientContact>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("X_Client_Contact");

                entity.Property(e => e.Id)
                    .HasColumnName("UNIQUE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ClientId).HasColumnName("CLIENT_ID");

                entity.Property(e => e.ContactId).HasColumnName("CONTACT_ID");

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.XClientContact)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_X_Client_Contact_Client");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.XClientContact)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_X_Client_Contact_Contact");
            });

            modelBuilder.Entity<XJobContact>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.ToTable("X_Job_Contact");

                entity.Property(e => e.Id)
                    .HasColumnName("UNIQUE_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ContactId).HasColumnName("CONTACT_ID");

                entity.Property(e => e.JobId).HasColumnName("JOB_ID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.XJobContact)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_X_Job_Contact_Contact");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.XJobContact)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_X_Job_Contact_Job_General");
            });
        }
    }
}
