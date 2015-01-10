using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using ConsoleApp.Test.Models.Mapping;

namespace ConsoleApp.Test.Models
{
    public partial class SocialGoalContext : DbContext
    {
        static SocialGoalContext()
        {
            Database.SetInitializer<SocialGoalContext>(null);
        }

        public SocialGoalContext()
            : base("Name=SocialGoalContext")
        {
        }

        public DbSet<AspNetRole> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public DbSet<AspNetUser> AspNetUsers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentUser> CommentUsers { get; set; }
        public DbSet<Focus> Foci { get; set; }
        public DbSet<FollowRequest> FollowRequests { get; set; }
        public DbSet<FollowUser> FollowUsers { get; set; }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<GoalStatu> GoalStatus { get; set; }
        public DbSet<GroupComment> GroupComments { get; set; }
        public DbSet<GroupCommentUser> GroupCommentUsers { get; set; }
        public DbSet<GroupGoal> GroupGoals { get; set; }
        public DbSet<GroupInvitation> GroupInvitations { get; set; }
        public DbSet<GroupRequest> GroupRequests { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<GroupUpdate> GroupUpdates { get; set; }
        public DbSet<GroupUpdateSupport> GroupUpdateSupports { get; set; }
        public DbSet<GroupUpdateUser> GroupUpdateUsers { get; set; }
        public DbSet<GroupUser> GroupUsers { get; set; }
        public DbSet<Metric> Metrics { get; set; }
        public DbSet<RegistrationToken> RegistrationTokens { get; set; }
        public DbSet<SecurityToken> SecurityTokens { get; set; }
        public DbSet<SupportInvitation> SupportInvitations { get; set; }
        public DbSet<Support> Supports { get; set; }
        public DbSet<Update> Updates { get; set; }
        public DbSet<UpdateSupport> UpdateSupports { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AspNetRoleMap());
            modelBuilder.Configurations.Add(new AspNetUserClaimMap());
            modelBuilder.Configurations.Add(new AspNetUserLoginMap());
            modelBuilder.Configurations.Add(new AspNetUserMap());
            modelBuilder.Configurations.Add(new CommentMap());
            modelBuilder.Configurations.Add(new CommentUserMap());
            modelBuilder.Configurations.Add(new FocusMap());
            modelBuilder.Configurations.Add(new FollowRequestMap());
            modelBuilder.Configurations.Add(new FollowUserMap());
            modelBuilder.Configurations.Add(new GoalMap());
            modelBuilder.Configurations.Add(new GoalStatuMap());
            modelBuilder.Configurations.Add(new GroupCommentMap());
            modelBuilder.Configurations.Add(new GroupCommentUserMap());
            modelBuilder.Configurations.Add(new GroupGoalMap());
            modelBuilder.Configurations.Add(new GroupInvitationMap());
            modelBuilder.Configurations.Add(new GroupRequestMap());
            modelBuilder.Configurations.Add(new GroupMap());
            modelBuilder.Configurations.Add(new GroupUpdateMap());
            modelBuilder.Configurations.Add(new GroupUpdateSupportMap());
            modelBuilder.Configurations.Add(new GroupUpdateUserMap());
            modelBuilder.Configurations.Add(new GroupUserMap());
            modelBuilder.Configurations.Add(new MetricMap());
            modelBuilder.Configurations.Add(new RegistrationTokenMap());
            modelBuilder.Configurations.Add(new SecurityTokenMap());
            modelBuilder.Configurations.Add(new SupportInvitationMap());
            modelBuilder.Configurations.Add(new SupportMap());
            modelBuilder.Configurations.Add(new UpdateMap());
            modelBuilder.Configurations.Add(new UpdateSupportMap());
            modelBuilder.Configurations.Add(new UserProfileMap());
        }
    }
}
