using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace fullControl.Model
{
    public partial class cmsContext : DbContext
    {
        public cmsContext()
        {
        }

        public cmsContext(DbContextOptions<cmsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AnswerLanguage> AnswerLanguage { get; set; }
        public virtual DbSet<AnswerQuestion> AnswerQuestion { get; set; }
        public virtual DbSet<Article> Article { get; set; }
        public virtual DbSet<ArticleLanguage> ArticleLanguage { get; set; }
        public virtual DbSet<AspnetApplications> AspnetApplications { get; set; }
        public virtual DbSet<AspnetMembership> AspnetMembership { get; set; }
        public virtual DbSet<AspnetPaths> AspnetPaths { get; set; }
        public virtual DbSet<AspnetPersonalizationAllUsers> AspnetPersonalizationAllUsers { get; set; }
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUser { get; set; }
        public virtual DbSet<AspnetProfile> AspnetProfile { get; set; }
        public virtual DbSet<AspnetRoles> AspnetRoles { get; set; }
        public virtual DbSet<AspnetSchemaVersions> AspnetSchemaVersions { get; set; }
        public virtual DbSet<AspnetUsers> AspnetUsers { get; set; }
        public virtual DbSet<AspnetUsersInRoles> AspnetUsersInRoles { get; set; }
        public virtual DbSet<AspnetWebEventEvents> AspnetWebEventEvents { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DoctorAvailabeTime> DoctorAvailabeTime { get; set; }
        public virtual DbSet<DoctorDepartMent> DoctorDepartMent { get; set; }
        public virtual DbSet<Doctors> Doctors { get; set; }
        public virtual DbSet<Event> Event { get; set; }
        public virtual DbSet<EventLanguage> EventLanguage { get; set; }
        public virtual DbSet<FeedBack> FeedBack { get; set; }
        public virtual DbSet<Governareate> Governareate { get; set; }
        public virtual DbSet<GuideCategory> GuideCategory { get; set; }
        public virtual DbSet<GuideCategoryLanguage> GuideCategoryLanguage { get; set; }
        public virtual DbSet<GuideDirectory> GuideDirectory { get; set; }
        public virtual DbSet<GuideDirectoryLanguage> GuideDirectoryLanguage { get; set; }
        public virtual DbSet<Job> Job { get; set; }
        public virtual DbSet<JobApplicant> JobApplicant { get; set; }
        public virtual DbSet<JobLanguage> JobLanguage { get; set; }
        public virtual DbSet<LabScans> LabScans { get; set; }
        public virtual DbSet<Meeenu> Meeenu { get; set; }
        public virtual DbSet<MenuItem> MenuItem { get; set; }
        public virtual DbSet<MenuItemLanguage> MenuItemLanguage { get; set; }
        public virtual DbSet<MenuLanguage> MenuLanguage { get; set; }
        public virtual DbSet<NewLanguage> NewLanguage { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<OrderItems> OrderItems { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<Patient> Patient { get; set; }
        public virtual DbSet<PatientVisit> PatientVisit { get; set; }
        public virtual DbSet<Pharmacy> Pharmacy { get; set; }
        public virtual DbSet<Photo> Photo { get; set; }
        public virtual DbSet<PhotoGallery> PhotoGallery { get; set; }
        public virtual DbSet<PhotoGalleryLanguage> PhotoGalleryLanguage { get; set; }
        public virtual DbSet<QuestionLanguage> QuestionLanguage { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RelatedLink> RelatedLink { get; set; }
        public virtual DbSet<RelatedLinkLanguage> RelatedLinkLanguage { get; set; }
        public virtual DbSet<Reservations> Reservations { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<SettingType> SettingType { get; set; }
        public virtual DbSet<Survay> Survay { get; set; }
        public virtual DbSet<SurvayLanguage> SurvayLanguage { get; set; }
        public virtual DbSet<SurvayQuestion> SurvayQuestion { get; set; }
        public virtual DbSet<TCompanies> TCompanies { get; set; }
        public virtual DbSet<TCompPro> TCompPro { get; set; }
        public virtual DbSet<Tesst> Tesst { get; set; }
        public virtual DbSet<TProducts> TProducts { get; set; }
        public virtual DbSet<TSlides> TSlides { get; set; }
        public virtual DbSet<TUsage> TUsage { get; set; }
        public virtual DbSet<Video> Video { get; set; }

        // Unable to generate entity type for table 'dbo.testtable'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.\\;Database=CMS;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AnswerLanguage>(entity =>
            {
                entity.Property(e => e.AnswerContent)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.FkAnswer)
                    .WithMany(p => p.AnswerLanguage)
                    .HasForeignKey(d => d.FkAnswerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerLanguage_AnswerQuestion");
            });

            modelBuilder.Entity<AnswerQuestion>(entity =>
            {
                entity.Property(e => e.AnswerDate).HasColumnType("datetime");

                entity.Property(e => e.NoOfReplies).HasColumnName("No_Of_Replies");

                entity.HasOne(d => d.FkSurvayQuestion)
                    .WithMany(p => p.AnswerQuestion)
                    .HasForeignKey(d => d.FkSurvayQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerQuestion_SurvayQuestion");
            });

            modelBuilder.Entity<Article>(entity =>
            {
                entity.Property(e => e.Aricledate).HasColumnType("datetime");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.Article)
                    .HasForeignKey(d => d.FkUserId)
                    .HasConstraintName("FK_Article_User");
            });

            modelBuilder.Entity<ArticleLanguage>(entity =>
            {
                entity.Property(e => e.LangName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.FkArticle)
                    .WithMany(p => p.ArticleLanguage)
                    .HasForeignKey(d => d.FkArticleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ArticleLanguage_Article");
            });

            modelBuilder.Entity<AspnetApplications>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.ApplicationName)
                    .HasName("UQ__aspnet_A__309103317F60ED59")
                    .IsUnique();

                entity.HasIndex(e => e.LoweredApplicationName)
                    .HasName("UQ__aspnet_A__17477DE4023D5A04")
                    .IsUnique();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName)
                    .IsRequired()
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasColumnName("MobilePIN")
                    .HasMaxLength(16);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMembership)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__719CDDE7");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__72910220");
            });

            modelBuilder.Entity<AspnetPaths>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Path)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__6CD828CA");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUsers>(entity =>
            {
                entity.HasKey(e => e.PathId);

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUsers)
                    .HasForeignKey<AspnetPersonalizationAllUsers>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__6EC0713C");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings)
                    .IsRequired()
                    .HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__6FB49575");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUser)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__70A8B9AE");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary)
                    .IsRequired()
                    .HasColumnType("image");

                entity.Property(e => e.PropertyValuesString)
                    .IsRequired()
                    .HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__7B264821");
            });

            modelBuilder.Entity<AspnetRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__6DCC4D03");
            });

            modelBuilder.Entity<AspnetSchemaVersions>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion });

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUsers>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .ForSqlServerIsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LoweredUserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__6442E2C9");
            });

            modelBuilder.Entity<AspnetUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId });

                entity.ToTable("aspnet_UsersInRoles");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__RoleI__7C1A6C5A");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__UserI__7D0E9093");
            });

            modelBuilder.Entity<AspnetWebEventEvents>(entity =>
            {
                entity.HasKey(e => e.EventId);

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .ValueGeneratedNever();

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName)
                    .IsRequired()
                    .HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CommentContent).IsRequired();

                entity.Property(e => e.NoOfComments).HasColumnName("No_Of_Comments");

                entity.Property(e => e.SubjectId).HasColumnName("Subject_id");

                entity.Property(e => e.SubjectType)
                    .IsRequired()
                    .HasColumnName("Subject_Type")
                    .HasMaxLength(10);

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.FkUserId)
                    .HasConstraintName("FK_Comment_aspnet_Users");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DeptId);

                entity.Property(e => e.DeptDescription).HasMaxLength(200);

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<DoctorAvailabeTime>(entity =>
            {
                entity.HasKey(e => e.AvaiableTimeId);

                entity.Property(e => e.Day).HasColumnType("date");

                entity.Property(e => e.TimeFrom).HasColumnType("datetime");

                entity.Property(e => e.TimeTo).HasColumnType("datetime");
            });

            modelBuilder.Entity<DoctorDepartMent>(entity =>
            {
                entity.HasKey(e => e.DoPartId);

                entity.ToTable("Doctor_DepartMent");
            });

            modelBuilder.Entity<Doctors>(entity =>
            {
                entity.HasKey(e => e.DoctorId);

                entity.Property(e => e.DoctorContacts).HasMaxLength(200);

                entity.Property(e => e.DoctorInfo).IsRequired();

                entity.Property(e => e.DoctorName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Event>(entity =>
            {
                entity.Property(e => e.EventDate).HasMaxLength(50);
            });

            modelBuilder.Entity<EventLanguage>(entity =>
            {
                entity.Property(e => e.LangName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.FkEvent)
                    .WithMany(p => p.EventLanguage)
                    .HasForeignKey(d => d.FkEventId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EventLanguage_Event");
            });

            modelBuilder.Entity<FeedBack>(entity =>
            {
                entity.Property(e => e.FeedBackContent).IsRequired();

                entity.Property(e => e.FeedBackEmail)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.FeedbackTitle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.FeedBack)
                    .HasForeignKey(d => d.FkUserId)
                    .HasConstraintName("FK_FeedBack_aspnet_Users");
            });

            modelBuilder.Entity<Governareate>(entity =>
            {
                entity.Property(e => e.GovernareteName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<GuideCategoryLanguage>(entity =>
            {
                entity.Property(e => e.GuideCategoryTitle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.FkGuideCategory)
                    .WithMany(p => p.GuideCategoryLanguage)
                    .HasForeignKey(d => d.FkGuideCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuideCategoryLanguage_GuideCategory");
            });

            modelBuilder.Entity<GuideDirectory>(entity =>
            {
                entity.HasOne(d => d.FkGuideCategory)
                    .WithMany(p => p.GuideDirectory)
                    .HasForeignKey(d => d.FkGuideCategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuideDirectory_GuideCategory");
            });

            modelBuilder.Entity<GuideDirectoryLanguage>(entity =>
            {
                entity.Property(e => e.GuideDirectoryContent).IsRequired();

                entity.Property(e => e.GuideDirectoryName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.FkGuideDirectory)
                    .WithMany(p => p.GuideDirectoryLanguage)
                    .HasForeignKey(d => d.FkGuideDirectoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GuideDirectoryLanguage_GuideDirectory");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.Property(e => e.JobDate)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<JobApplicant>(entity =>
            {
                entity.HasKey(e => e.ApplicantId);

                entity.ToTable("Job_Applicant");

                entity.Property(e => e.ApplicantEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ApplicantName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FkJob)
                    .WithMany(p => p.JobApplicant)
                    .HasForeignKey(d => d.FkJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_Applicant_Job");
            });

            modelBuilder.Entity<JobLanguage>(entity =>
            {
                entity.Property(e => e.JobDescription).IsRequired();

                entity.Property(e => e.JobTitle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.FkJob)
                    .WithMany(p => p.JobLanguage)
                    .HasForeignKey(d => d.FkJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLanguage_Job");
            });

            modelBuilder.Entity<LabScans>(entity =>
            {
                entity.HasKey(e => e.LabScanId);

                entity.Property(e => e.LabScanId).ValueGeneratedNever();

                entity.Property(e => e.Attachment).IsRequired();

                entity.Property(e => e.LsType)
                    .HasColumnName("Ls_Type")
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Value)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Meeenu>(entity =>
            {
                entity.HasKey(e => e.MenuId);

                entity.Property(e => e.MenuDate).HasColumnType("datetime");

                entity.HasOne(d => d.MenuSettingDisplay)
                    .WithMany(p => p.Meeenu)
                    .HasForeignKey(d => d.MenuSettingDisplayId)
                    .HasConstraintName("FK_Meeenu_Setting");
            });

            modelBuilder.Entity<MenuItem>(entity =>
            {
                entity.Property(e => e.MenuItemDate).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.FkArticle)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.FkArticleId)
                    .HasConstraintName("FK_MenuItem_Article");

                entity.HasOne(d => d.FkMenu)
                    .WithMany(p => p.MenuItem)
                    .HasForeignKey(d => d.FkMenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuItem_Meeenu");

                entity.HasOne(d => d.FkMenuItemParent)
                    .WithMany(p => p.InverseFkMenuItemParent)
                    .HasForeignKey(d => d.FkMenuItemParentId)
                    .HasConstraintName("FK_MenuItem_MenuItem");
            });

            modelBuilder.Entity<MenuItemLanguage>(entity =>
            {
                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MenuItemName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkMenuItem)
                    .WithMany(p => p.MenuItemLanguage)
                    .HasForeignKey(d => d.FkMenuItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuItemLanguage_MenuItem");
            });

            modelBuilder.Entity<MenuLanguage>(entity =>
            {
                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.MenuName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkMenu)
                    .WithMany(p => p.MenuLanguage)
                    .HasForeignKey(d => d.FkMenuId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MenuLanguage_Meeenu");
            });

            modelBuilder.Entity<NewLanguage>(entity =>
            {
                entity.HasKey(e => e.NewsLanguageId);

                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.Title).IsRequired();

                entity.HasOne(d => d.FkNews)
                    .WithMany(p => p.NewLanguage)
                    .HasForeignKey(d => d.FkNewsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NewLanguage_News1");
            });

            modelBuilder.Entity<News>(entity =>
            {
                entity.Property(e => e.FkCompId).HasColumnName("fk_compId");

                entity.Property(e => e.NewsDate).HasMaxLength(50);
            });

            modelBuilder.Entity<OrderItems>(entity =>
            {
                entity.HasKey(e => e.OrderItemId);

                entity.Property(e => e.TotalPrice).HasComputedColumnSql("([UnitPrice]*[Quantity])");

                entity.HasOne(d => d.FkOrder)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.FkOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItems_Orders");

                entity.HasOne(d => d.FkProduct)
                    .WithMany(p => p.OrderItems)
                    .HasForeignKey(d => d.FkProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderItems_t_products");
            });

            modelBuilder.Entity<Orders>(entity =>
            {
                entity.HasKey(e => e.OrderId);

                entity.Property(e => e.OrderDate).HasColumnType("date");

                entity.HasOne(d => d.FkCompany)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.FkCompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_t_Companies");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.FkUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Orders_aspnet_Users");
            });

            modelBuilder.Entity<Patient>(entity =>
            {
                entity.Property(e => e.BirthDate)
                    .HasColumnName("birthDate")
                    .HasColumnType("date");

                entity.Property(e => e.PatientName).IsRequired();

                entity.Property(e => e.RserveDate)
                    .HasColumnName("rserveDate")
                    .HasColumnType("date");
            });

            modelBuilder.Entity<PatientVisit>(entity =>
            {
                entity.Property(e => e.VisitDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<Pharmacy>(entity =>
            {
                entity.HasKey(e => e.PharmId);

                entity.Property(e => e.PharmId).HasColumnName("Pharm_Id");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkRegion).HasColumnName("fk_Region");

                entity.Property(e => e.FkUserId).HasColumnName("fk_userID");

                entity.Property(e => e.IsActive).HasColumnName("isActive");

                entity.Property(e => e.NewExpierdDate)
                    .HasColumnName("newExpierdDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PharmAdress)
                    .HasColumnName("Pharm_adress")
                    .HasMaxLength(200);

                entity.Property(e => e.PharmMobile1)
                    .HasColumnName("Pharm_Mobile1")
                    .HasMaxLength(20);

                entity.Property(e => e.PharmMobile2)
                    .HasColumnName("Pharm_Mobile2")
                    .HasMaxLength(20);

                entity.Property(e => e.PharmName)
                    .IsRequired()
                    .HasColumnName("Pharm_name")
                    .HasMaxLength(150);

                entity.Property(e => e.PharmPhone)
                    .HasColumnName("Pharm_Phone")
                    .HasMaxLength(15);
            });

            modelBuilder.Entity<Photo>(entity =>
            {
                entity.Property(e => e.PhotoResizedPath).IsRequired();

                entity.Property(e => e.PhotoTnumbnailPath).IsRequired();

                entity.Property(e => e.PhotoToolTip).HasMaxLength(200);

                entity.HasOne(d => d.FkPhotoGallery)
                    .WithMany(p => p.Photo)
                    .HasForeignKey(d => d.FkPhotoGalleryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Photo_PhotoGallery");
            });

            modelBuilder.Entity<PhotoGallery>(entity =>
            {
                entity.Property(e => e.PhotoGalleryDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkPhotoGalleryDisplay)
                    .WithMany(p => p.PhotoGallery)
                    .HasForeignKey(d => d.FkPhotoGalleryDisplayId)
                    .HasConstraintName("FK_PhotoGallery_Setting");
            });

            modelBuilder.Entity<PhotoGalleryLanguage>(entity =>
            {
                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.PhotoGalleryName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkPhotoGallery)
                    .WithMany(p => p.PhotoGalleryLanguage)
                    .HasForeignKey(d => d.FkPhotoGalleryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PhotoGalleryLanguage_PhotoGallery");
            });

            modelBuilder.Entity<QuestionLanguage>(entity =>
            {
                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.QuestionContent)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkQuestion)
                    .WithMany(p => p.QuestionLanguage)
                    .HasForeignKey(d => d.FkQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionLanguage_SurvayQuestion");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.RegionName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkGovernerate)
                    .WithMany(p => p.Region)
                    .HasForeignKey(d => d.FkGovernerateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Region_Governareate");
            });

            modelBuilder.Entity<RelatedLink>(entity =>
            {
                entity.Property(e => e.RelatedLinkDate).HasColumnType("datetime");

                entity.Property(e => e.RelatedLinkUrl)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<RelatedLinkLanguage>(entity =>
            {
                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.RelatedLinkTitle)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkRelatedLink)
                    .WithMany(p => p.RelatedLinkLanguage)
                    .HasForeignKey(d => d.FkRelatedLinkId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RelatedLinkLanguage_RelatedLink");
            });

            modelBuilder.Entity<Reservations>(entity =>
            {
                entity.HasKey(e => e.ReservationId);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.SettingName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SettingValue)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkSettingType)
                    .WithMany(p => p.Setting)
                    .HasForeignKey(d => d.FkSettingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Setting_SettingType");
            });

            modelBuilder.Entity<SettingType>(entity =>
            {
                entity.Property(e => e.SettingTypeName)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Survay>(entity =>
            {
                entity.Property(e => e.SurvayDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<SurvayLanguage>(entity =>
            {
                entity.Property(e => e.LanguageName)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.SurvayHeader)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SurvayMessage)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SurvayName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.FkSurvay)
                    .WithMany(p => p.SurvayLanguage)
                    .HasForeignKey(d => d.FkSurvayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurvayLanguage_Survay");
            });

            modelBuilder.Entity<SurvayQuestion>(entity =>
            {
                entity.HasKey(e => e.QuestionId);

                entity.Property(e => e.QuestionDate).HasColumnType("datetime");

                entity.HasOne(d => d.FkSurvay)
                    .WithMany(p => p.SurvayQuestion)
                    .HasForeignKey(d => d.FkSurvayId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SurvayQuestion_Survay");
            });

            modelBuilder.Entity<TCompanies>(entity =>
            {
                entity.HasKey(e => e.CompanyId);

                entity.ToTable("t_Companies");

                entity.Property(e => e.CompanyId).HasColumnName("companyId");

                entity.Property(e => e.Adress)
                    .HasColumnName("adress")
                    .HasMaxLength(250);

                entity.Property(e => e.ComOriginalPhoto).HasColumnName("Com_originalPhoto");

                entity.Property(e => e.ComThumbPhoto).HasColumnName("Com_thumbPhoto");

                entity.Property(e => e.CompanyDesc).IsRequired();

                entity.Property(e => e.CompanyName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.FkGovid).HasColumnName("fk_Govid");

                entity.Property(e => e.FkUserid).HasColumnName("fk_userid");

                entity.Property(e => e.LastActivationDate)
                    .HasColumnName("lastActivationDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayWays).HasColumnName("pay_ways");

                entity.Property(e => e.Phons)
                    .HasColumnName("phons")
                    .HasMaxLength(250);

                entity.Property(e => e.PreferedLanguage).HasMaxLength(5);

                entity.Property(e => e.ReturnsPolicy).HasColumnName("Returns_Policy");
            });

            modelBuilder.Entity<TCompPro>(entity =>
            {
                entity.ToTable("t_comp_pro");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CompId).HasColumnName("Comp_ID");

                entity.Property(e => e.ProId).HasColumnName("Pro_ID");
            });

            modelBuilder.Entity<Tesst>(entity =>
            {
                entity.HasKey(e => e.Tid);

                entity.ToTable("tesst");

                entity.Property(e => e.Tid)
                    .HasColumnName("tid")
                    .ValueGeneratedNever();

                entity.Property(e => e.Tname)
                    .HasColumnName("tname")
                    .HasMaxLength(50);

                entity.Property(e => e.Tphone)
                    .HasColumnName("tphone")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TProducts>(entity =>
            {
                entity.HasKey(e => e.ProId);

                entity.ToTable("t_products");

                entity.Property(e => e.ProId).HasColumnName("Pro_id");

                entity.Property(e => e.AskedForDelete).HasColumnName("askedForDelete");

                entity.Property(e => e.AvrageRating).HasColumnName("avrageRating");

                entity.Property(e => e.CreationDate)
                    .HasColumnName("creation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DiscountRate).HasColumnName("discount_rate");

                entity.Property(e => e.FkCompId).HasColumnName("FkComp_id");

                entity.Property(e => e.FkUsageId).HasColumnName("FkUsage_id");

                entity.Property(e => e.IsDeleted).HasColumnName("isDeleted");

                entity.Property(e => e.IsPublished).HasColumnName("isPublished");

                entity.Property(e => e.LargResizedImg).HasColumnName("larg_resized_img");

                entity.Property(e => e.PharmPrice).HasColumnName("Pharm_Price");

                entity.Property(e => e.ProDesc).HasColumnName("pro_desc");

                entity.Property(e => e.ProIngredients)
                    .IsRequired()
                    .HasColumnName("pro_Ingredients")
                    .HasMaxLength(200);

                entity.Property(e => e.ProName)
                    .IsRequired()
                    .HasColumnName("Pro_name")
                    .HasMaxLength(50);

                entity.Property(e => e.ProductCode)
                    .HasColumnName("productCode")
                    .HasMaxLength(50);

                entity.Property(e => e.PublicPrice).HasColumnName("public_price");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.SmallThumbImg).HasColumnName("small_thumb_img");
            });

            modelBuilder.Entity<TSlides>(entity =>
            {
                entity.ToTable("t_Slides");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AddValue).HasColumnName("addValue");

                entity.Property(e => e.FkProid).HasColumnName("fkProid");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<TUsage>(entity =>
            {
                entity.HasKey(e => e.UsageId);

                entity.ToTable("t_Usage");

                entity.Property(e => e.UsageId).HasColumnName("usageId");

                entity.Property(e => e.FkParentIt).HasColumnName("fk_parentIT");

                entity.Property(e => e.UsageDesc).HasColumnName("usageDesc");

                entity.Property(e => e.UsageImage).HasColumnName("usageImage");

                entity.Property(e => e.UsageTitle)
                    .IsRequired()
                    .HasColumnName("usageTitle")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Video>(entity =>
            {
                entity.Property(e => e.Embed).IsRequired();

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(50);
            });
        }
    }
}
