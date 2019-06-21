using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParticipantDatabse.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ResearchGroup",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResearchGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudyTask",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyTask", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Participant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    ActualDueDate = table.Column<DateTime>(nullable: false),
                    Parents = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    MobilePhoneNumber = table.Column<string>(nullable: true),
                    AlternativePhoneNumber = table.Column<string>(nullable: true),
                    EveningPhoneNumber = table.Column<string>(nullable: true),
                    AlternateName = table.Column<string>(nullable: true),
                    Recruitment = table.Column<string>(nullable: true),
                    EthnicityOfChild = table.Column<int>(nullable: false),
                    EthnicityOfMother = table.Column<int>(nullable: false),
                    EthnicityOfFather = table.Column<int>(nullable: false),
                    GroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Participant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Participant_ResearchGroup_GroupId",
                        column: x => x.GroupId,
                        principalTable: "ResearchGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Study",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    GroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Study", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Study_ResearchGroup_GroupId",
                        column: x => x.GroupId,
                        principalTable: "ResearchGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudyParticipation",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParticipantId = table.Column<int>(nullable: true),
                    StudyId = table.Column<int>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyParticipation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyParticipation_Participant_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyParticipation_Study_StudyId",
                        column: x => x.StudyId,
                        principalTable: "Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Assistant",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    StudyParticipationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assistant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assistant_ResearchGroup_GroupId",
                        column: x => x.GroupId,
                        principalTable: "ResearchGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Assistant_StudyParticipation_StudyParticipationId",
                        column: x => x.StudyParticipationId,
                        principalTable: "StudyParticipation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Investigator",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    StudyParticipationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Investigator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Investigator_ResearchGroup_GroupId",
                        column: x => x.GroupId,
                        principalTable: "ResearchGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Investigator_StudyParticipation_StudyParticipationId",
                        column: x => x.StudyParticipationId,
                        principalTable: "StudyParticipation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    GroupId = table.Column<int>(nullable: true),
                    StudyParticipationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Student_ResearchGroup_GroupId",
                        column: x => x.GroupId,
                        principalTable: "ResearchGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Student_StudyParticipation_StudyParticipationId",
                        column: x => x.StudyParticipationId,
                        principalTable: "StudyParticipation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudyVisit",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ParticipantId = table.Column<int>(nullable: true),
                    StudyId = table.Column<int>(nullable: true),
                    VisitDate = table.Column<DateTime>(nullable: false),
                    StudyParticipationId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyVisit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudyVisit_Participant_ParticipantId",
                        column: x => x.ParticipantId,
                        principalTable: "Participant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyVisit_Study_StudyId",
                        column: x => x.StudyId,
                        principalTable: "Study",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudyVisit_StudyParticipation_StudyParticipationId",
                        column: x => x.StudyParticipationId,
                        principalTable: "StudyParticipation",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StudyVisitTask",
                columns: table => new
                {
                    StudyVisitId = table.Column<int>(nullable: false),
                    StudyTaskId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudyVisitTask", x => new { x.StudyTaskId, x.StudyVisitId });
                    table.ForeignKey(
                        name: "FK_StudyVisitTask_StudyTask_StudyTaskId",
                        column: x => x.StudyTaskId,
                        principalTable: "StudyTask",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudyVisitTask_StudyVisit_StudyVisitId",
                        column: x => x.StudyVisitId,
                        principalTable: "StudyVisit",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assistant_GroupId",
                table: "Assistant",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Assistant_StudyParticipationId",
                table: "Assistant",
                column: "StudyParticipationId");

            migrationBuilder.CreateIndex(
                name: "IX_Investigator_GroupId",
                table: "Investigator",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Investigator_StudyParticipationId",
                table: "Investigator",
                column: "StudyParticipationId");

            migrationBuilder.CreateIndex(
                name: "IX_Participant_GroupId",
                table: "Participant",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_GroupId",
                table: "Student",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Student_StudyParticipationId",
                table: "Student",
                column: "StudyParticipationId");

            migrationBuilder.CreateIndex(
                name: "IX_Study_GroupId",
                table: "Study",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyParticipation_ParticipantId",
                table: "StudyParticipation",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyParticipation_StudyId",
                table: "StudyParticipation",
                column: "StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyVisit_ParticipantId",
                table: "StudyVisit",
                column: "ParticipantId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyVisit_StudyId",
                table: "StudyVisit",
                column: "StudyId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyVisit_StudyParticipationId",
                table: "StudyVisit",
                column: "StudyParticipationId");

            migrationBuilder.CreateIndex(
                name: "IX_StudyVisitTask_StudyVisitId",
                table: "StudyVisitTask",
                column: "StudyVisitId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assistant");

            migrationBuilder.DropTable(
                name: "Investigator");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "StudyVisitTask");

            migrationBuilder.DropTable(
                name: "StudyTask");

            migrationBuilder.DropTable(
                name: "StudyVisit");

            migrationBuilder.DropTable(
                name: "StudyParticipation");

            migrationBuilder.DropTable(
                name: "Participant");

            migrationBuilder.DropTable(
                name: "Study");

            migrationBuilder.DropTable(
                name: "ResearchGroup");
        }
    }
}
