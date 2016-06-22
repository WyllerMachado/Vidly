namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1d857335-f1a2-4573-809b-02f5cd046672', N'guest@vidly.com', 0, N'AKora2uM1T5yM1BeOjBDtcmXtT8fl7hhQTlnuyQdrKXrKb6JF2KkBhNM8UpHGlZpqA==', N'ea6d6a84-1528-4090-aed1-7c7ed73c645e', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'849e4646-e356-493f-8cc1-582a8b0007d0', N'admin@vidly.com', 0, N'AIVmn1N7BJ6asPkW/Sf+V1HmI+y4EdT5DA3QOmeWaIACdkHKHP3AKUiHQOOHGQhqzg==', N'1f876dd2-3517-413b-9eab-56b456312522', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3d1f90de-66fb-4fab-8d9d-efada0a0114e', N'CanManageMovies')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'849e4646-e356-493f-8cc1-582a8b0007d0', N'3d1f90de-66fb-4fab-8d9d-efada0a0114e')
");
        }
        
        public override void Down()
        {
        }
    }
}
