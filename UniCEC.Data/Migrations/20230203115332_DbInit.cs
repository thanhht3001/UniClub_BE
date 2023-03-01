using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UniCEC.Data.Migrations
{
    public partial class DbInit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ClubRole",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClubRole", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionRole",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionRole", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionRoundType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionRoundType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "EntityType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Major",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Major", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "TeamRole",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamRole", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "University",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityID = table.Column<int>(type: "int", nullable: false),
                    UniCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Phone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: false),
                    ImageURL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Founding = table.Column<DateTime>(type: "datetime", nullable: false),
                    Openning = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    Closing = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_University", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Universit__CityI__76969D2E",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UniversityID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    TotalMember = table.Column<int>(type: "int", nullable: false),
                    Founding = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Image = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    ClubFanpage = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ClubContact = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Club__University__59063A47",
                        column: x => x.UniversityID,
                        principalTable: "University",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Competition",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionTypeID = table.Column<int>(type: "int", nullable: false),
                    UniversityID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AddressName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    NumberOfParticipation = table.Column<int>(type: "int", nullable: false),
                    NumberOfTeam = table.Column<int>(type: "int", nullable: true),
                    MinNumber = table.Column<int>(type: "int", nullable: true),
                    MaxNumber = table.Column<int>(type: "int", nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    StartTimeRegister = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTimeRegister = table.Column<DateTime>(type: "datetime", nullable: false),
                    CeremonyTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fee = table.Column<double>(type: "float", nullable: false),
                    SeedsCode = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    SeedsPoint = table.Column<double>(type: "float", nullable: false),
                    SeedsDeposited = table.Column<double>(type: "float", nullable: false),
                    View = table.Column<int>(type: "int", nullable: false),
                    Scope = table.Column<int>(type: "int", nullable: false),
                    IsSponsor = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RequiredMin = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Competition", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Competiti__Compe__59FA5E80",
                        column: x => x.CompetitionTypeID,
                        principalTable: "CompetitionType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Competiti__Unive__5AEE82B9",
                        column: x => x.UniversityID,
                        principalTable: "University",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Department",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorID = table.Column<int>(type: "int", nullable: false),
                    UniversityID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DepartmentCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Departmen__Major__6477ECF3",
                        column: x => x.MajorID,
                        principalTable: "Major",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Departmen__Unive__656C112C",
                        column: x => x.UniversityID,
                        principalTable: "University",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionActivity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionID = table.Column<int>(type: "int", nullable: false),
                    CreatorID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeedsPoint = table.Column<double>(type: "float", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Ending = table.Column<DateTime>(type: "datetime", nullable: false),
                    NumOfMember = table.Column<int>(type: "int", nullable: false),
                    Priority = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionActivity", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Competiti__Compe__5BE2A6F2",
                        column: x => x.CompetitionID,
                        principalTable: "Competition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionEntity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionID = table.Column<int>(type: "int", nullable: false),
                    EntityTypeID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImageURL = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: false),
                    Website = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Competiti__Compe__5CD6CB2B",
                        column: x => x.CompetitionID,
                        principalTable: "Competition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Competiti__Entit__5DCAEF64",
                        column: x => x.EntityTypeID,
                        principalTable: "EntityType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionHistory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionID = table.Column<int>(type: "int", nullable: false),
                    ChangerID = table.Column<int>(type: "int", nullable: true),
                    ChangeDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionHistory", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Competiti__Compe__5EBF139D",
                        column: x => x.CompetitionID,
                        principalTable: "Competition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionInClub",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubID = table.Column<int>(type: "int", nullable: false),
                    IsOwner = table.Column<bool>(type: "bit", nullable: false),
                    CompetitionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionInClub", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Competiti__ClubI__5FB337D6",
                        column: x => x.ClubID,
                        principalTable: "Club",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Competiti__Compe__60A75C0F",
                        column: x => x.CompetitionID,
                        principalTable: "Competition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionInMajor",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MajorID = table.Column<int>(type: "int", nullable: false),
                    CompetitionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionInMajor", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Competiti__Compe__619B8048",
                        column: x => x.CompetitionID,
                        principalTable: "Competition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Competiti__Major__628FA481",
                        column: x => x.MajorID,
                        principalTable: "Major",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CompetitionRound",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    NumberOfTeam = table.Column<int>(type: "int", nullable: false),
                    SeedsPoint = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    CompetitionRoundTypeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompetitionRound", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Competiti__Compe__3D2915A8",
                        column: x => x.CompetitionRoundTypeID,
                        principalTable: "CompetitionRoundType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Competiti__Compe__6383C8BA",
                        column: x => x.CompetitionID,
                        principalTable: "Competition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Team",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NumberOfStudentInTeam = table.Column<int>(type: "int", nullable: false),
                    InvitedCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Team", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Team__Competitio__73BA3083",
                        column: x => x.CompetitionID,
                        principalTable: "Competition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleID = table.Column<int>(type: "int", nullable: false),
                    UniversityID = table.Column<int>(type: "int", nullable: true),
                    DepartmentID = table.Column<int>(type: "int", nullable: true),
                    Fullname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StudentCode = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DOB = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Avatar = table.Column<string>(type: "varchar(500)", unicode: false, maxLength: 500, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsOnline = table.Column<bool>(type: "bit", nullable: false),
                    DeviceToken = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                    table.ForeignKey(
                        name: "FK__User__Department__778AC167",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__User__RoleID__787EE5A0",
                        column: x => x.RoleID,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__User__University__797309D9",
                        column: x => x.UniversityID,
                        principalTable: "University",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ActivitiesEntity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionActivityID = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivitiesEntity", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Activitie__Compe__5812160E",
                        column: x => x.CompetitionActivityID,
                        principalTable: "CompetitionActivity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Match",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoundID = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    NumberOfTeam = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    IsLoseMatch = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Match", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Match__RoundID__339FAB6E",
                        column: x => x.RoundID,
                        principalTable: "CompetitionRound",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamInRound",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    RoundID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Rank = table.Column<int>(type: "int", nullable: false),
                    Scores = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamInRound", x => x.ID);
                    table.ForeignKey(
                        name: "FK__TeamInRou__Round__74AE54BC",
                        column: x => x.RoundID,
                        principalTable: "CompetitionRound",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__TeamInRou__TeamI__75A278F5",
                        column: x => x.TeamID,
                        principalTable: "Team",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Member",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubRoleID = table.Column<int>(type: "int", nullable: false),
                    ClubID = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Member", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Member__ClubID__66603565",
                        column: x => x.ClubID,
                        principalTable: "Club",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Member__ClubRole__6754599E",
                        column: x => x.ClubRoleID,
                        principalTable: "ClubRole",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Member__UserID__68487DD7",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Notification",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Body = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    RedirectUrl = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreateTime = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notification", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Notificat__UserI__160F4887",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Participant",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    CompetitionID = table.Column<int>(type: "int", nullable: false),
                    RegisterTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    Attendance = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participant", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Participa__Compe__6E01572D",
                        column: x => x.CompetitionID,
                        principalTable: "Competition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Participa__Stude__6EF57B66",
                        column: x => x.StudentID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeedsWallet",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeedsWallet", x => x.ID);
                    table.ForeignKey(
                        name: "FK__SeedsWall__Stude__72C60C4A",
                        column: x => x.StudentID,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamInMatch",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MatchID = table.Column<int>(type: "int", nullable: false),
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    Scores = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamInMatch", x => x.ID);
                    table.ForeignKey(
                        name: "FK__TeamInMat__Match__37703C52",
                        column: x => x.MatchID,
                        principalTable: "Match",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__TeamInMat__TeamI__3864608B",
                        column: x => x.TeamID,
                        principalTable: "Team",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberInCompetition",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompetitionID = table.Column<int>(type: "int", nullable: false),
                    CompetitionRoleID = table.Column<int>(type: "int", nullable: false),
                    MemberID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberInCompetition", x => x.ID);
                    table.ForeignKey(
                        name: "FK__MemberInC__Compe__693CA210",
                        column: x => x.CompetitionID,
                        principalTable: "Competition",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__MemberInC__Compe__6A30C649",
                        column: x => x.CompetitionRoleID,
                        principalTable: "CompetitionRole",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__MemberInC__Membe__6B24EA82",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberTakesActivity",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberID = table.Column<int>(type: "int", nullable: false),
                    BookerID = table.Column<int>(type: "int", nullable: false),
                    CompetitionActivityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTakesActivity", x => x.ID);
                    table.ForeignKey(
                        name: "FK__MemberTak__Compe__6C190EBB",
                        column: x => x.CompetitionActivityID,
                        principalTable: "CompetitionActivity",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__MemberTak__Membe__6D0D32F4",
                        column: x => x.MemberID,
                        principalTable: "Member",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ParticipantInTeam",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamID = table.Column<int>(type: "int", nullable: false),
                    ParticipantID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    TeamRoleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipantInTeam", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Participa__Parti__6FE99F9F",
                        column: x => x.ParticipantID,
                        principalTable: "Participant",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Participa__TeamI__70DDC3D8",
                        column: x => x.TeamID,
                        principalTable: "Team",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__Participa__TeamR__71D1E811",
                        column: x => x.TeamRoleID,
                        principalTable: "TeamRole",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivitiesEntity_CompetitionActivityID",
                table: "ActivitiesEntity",
                column: "CompetitionActivityID");

            migrationBuilder.CreateIndex(
                name: "IX_Club_UniversityID",
                table: "Club",
                column: "UniversityID");

            migrationBuilder.CreateIndex(
                name: "IX_Competition_CompetitionTypeID",
                table: "Competition",
                column: "CompetitionTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Competition_UniversityID",
                table: "Competition",
                column: "UniversityID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionActivity_CompetitionID",
                table: "CompetitionActivity",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionEntity_CompetitionID",
                table: "CompetitionEntity",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionEntity_EntityTypeID",
                table: "CompetitionEntity",
                column: "EntityTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionHistory_CompetitionID",
                table: "CompetitionHistory",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionInClub_ClubID",
                table: "CompetitionInClub",
                column: "ClubID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionInClub_CompetitionID",
                table: "CompetitionInClub",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionInMajor_CompetitionID",
                table: "CompetitionInMajor",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionInMajor_MajorID",
                table: "CompetitionInMajor",
                column: "MajorID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionRound_CompetitionID",
                table: "CompetitionRound",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_CompetitionRound_CompetitionRoundTypeID",
                table: "CompetitionRound",
                column: "CompetitionRoundTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_MajorID",
                table: "Department",
                column: "MajorID");

            migrationBuilder.CreateIndex(
                name: "IX_Department_UniversityID",
                table: "Department",
                column: "UniversityID");

            migrationBuilder.CreateIndex(
                name: "IX_Match_RoundID",
                table: "Match",
                column: "RoundID");

            migrationBuilder.CreateIndex(
                name: "IX_Member_ClubID",
                table: "Member",
                column: "ClubID");

            migrationBuilder.CreateIndex(
                name: "IX_Member_ClubRoleID",
                table: "Member",
                column: "ClubRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_Member_UserID",
                table: "Member",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberInCompetition_CompetitionID",
                table: "MemberInCompetition",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberInCompetition_CompetitionRoleID",
                table: "MemberInCompetition",
                column: "CompetitionRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberInCompetition_MemberID",
                table: "MemberInCompetition",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberTakesActivity_CompetitionActivityID",
                table: "MemberTakesActivity",
                column: "CompetitionActivityID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberTakesActivity_MemberID",
                table: "MemberTakesActivity",
                column: "MemberID");

            migrationBuilder.CreateIndex(
                name: "IX_Notification_UserID",
                table: "Notification",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_CompetitionID",
                table: "Participant",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_StudentID",
                table: "Participant",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantInTeam_ParticipantID",
                table: "ParticipantInTeam",
                column: "ParticipantID");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantInTeam_TeamID",
                table: "ParticipantInTeam",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipantInTeam_TeamRoleID",
                table: "ParticipantInTeam",
                column: "TeamRoleID");

            migrationBuilder.CreateIndex(
                name: "IX_SeedsWallet_StudentID",
                table: "SeedsWallet",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_Team_CompetitionID",
                table: "Team",
                column: "CompetitionID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamInMatch_MatchID",
                table: "TeamInMatch",
                column: "MatchID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamInMatch_TeamID",
                table: "TeamInMatch",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamInRound_RoundID",
                table: "TeamInRound",
                column: "RoundID");

            migrationBuilder.CreateIndex(
                name: "IX_TeamInRound_TeamID",
                table: "TeamInRound",
                column: "TeamID");

            migrationBuilder.CreateIndex(
                name: "IX_University_CityID",
                table: "University",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_User_DepartmentID",
                table: "User",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_User_UniversityID",
                table: "User",
                column: "UniversityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivitiesEntity");

            migrationBuilder.DropTable(
                name: "CompetitionEntity");

            migrationBuilder.DropTable(
                name: "CompetitionHistory");

            migrationBuilder.DropTable(
                name: "CompetitionInClub");

            migrationBuilder.DropTable(
                name: "CompetitionInMajor");

            migrationBuilder.DropTable(
                name: "MemberInCompetition");

            migrationBuilder.DropTable(
                name: "MemberTakesActivity");

            migrationBuilder.DropTable(
                name: "Notification");

            migrationBuilder.DropTable(
                name: "ParticipantInTeam");

            migrationBuilder.DropTable(
                name: "SeedsWallet");

            migrationBuilder.DropTable(
                name: "TeamInMatch");

            migrationBuilder.DropTable(
                name: "TeamInRound");

            migrationBuilder.DropTable(
                name: "EntityType");

            migrationBuilder.DropTable(
                name: "CompetitionRole");

            migrationBuilder.DropTable(
                name: "CompetitionActivity");

            migrationBuilder.DropTable(
                name: "Member");

            migrationBuilder.DropTable(
                name: "Participant");

            migrationBuilder.DropTable(
                name: "TeamRole");

            migrationBuilder.DropTable(
                name: "Match");

            migrationBuilder.DropTable(
                name: "Team");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "ClubRole");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "CompetitionRound");

            migrationBuilder.DropTable(
                name: "Department");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "CompetitionRoundType");

            migrationBuilder.DropTable(
                name: "Competition");

            migrationBuilder.DropTable(
                name: "Major");

            migrationBuilder.DropTable(
                name: "CompetitionType");

            migrationBuilder.DropTable(
                name: "University");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
