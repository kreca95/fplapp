using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FplApp.EfCoreDbCommunication.Migrations
{
    public partial class Models : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Elements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ChanceOfPlayingNextRound = table.Column<int>(type: "integer", nullable: true),
                    ChanceOfPlayingThisRound = table.Column<int>(type: "integer", nullable: true),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    CostChangeEvent = table.Column<int>(type: "integer", nullable: false),
                    CostChangeEventFall = table.Column<int>(type: "integer", nullable: false),
                    CostChangeStart = table.Column<int>(type: "integer", nullable: false),
                    CostChangeStartFall = table.Column<int>(type: "integer", nullable: false),
                    DreamteamCount = table.Column<int>(type: "integer", nullable: false),
                    ElementType = table.Column<int>(type: "integer", nullable: false),
                    EpNext = table.Column<string>(type: "text", nullable: true),
                    EpThis = table.Column<string>(type: "text", nullable: true),
                    EventPoints = table.Column<int>(type: "integer", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: true),
                    Form = table.Column<string>(type: "text", nullable: true),
                    InDreamteam = table.Column<bool>(type: "boolean", nullable: false),
                    News = table.Column<string>(type: "text", nullable: true),
                    NewsAdded = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    NowCost = table.Column<int>(type: "integer", nullable: false),
                    Photo = table.Column<string>(type: "text", nullable: true),
                    PointsPerGame = table.Column<string>(type: "text", nullable: true),
                    SecondName = table.Column<string>(type: "text", nullable: true),
                    SelectedByPercent = table.Column<string>(type: "text", nullable: true),
                    Special = table.Column<bool>(type: "boolean", nullable: false),
                    SquadNumber = table.Column<string>(type: "text", nullable: true),
                    Status = table.Column<string>(type: "text", nullable: true),
                    Team = table.Column<int>(type: "integer", nullable: false),
                    TeamCode = table.Column<int>(type: "integer", nullable: false),
                    TotalPoints = table.Column<int>(type: "integer", nullable: false),
                    TransfersIn = table.Column<int>(type: "integer", nullable: false),
                    TransfersInEvent = table.Column<int>(type: "integer", nullable: false),
                    TransfersOut = table.Column<int>(type: "integer", nullable: false),
                    TransfersOutEvent = table.Column<int>(type: "integer", nullable: false),
                    ValueForm = table.Column<string>(type: "text", nullable: true),
                    ValueSeason = table.Column<string>(type: "text", nullable: true),
                    WebName = table.Column<string>(type: "text", nullable: true),
                    Minutes = table.Column<int>(type: "integer", nullable: false),
                    GoalsScored = table.Column<int>(type: "integer", nullable: false),
                    Assists = table.Column<int>(type: "integer", nullable: false),
                    CleanSheets = table.Column<int>(type: "integer", nullable: false),
                    GoalsConceded = table.Column<int>(type: "integer", nullable: false),
                    OwnGoals = table.Column<int>(type: "integer", nullable: false),
                    PenaltiesSaved = table.Column<int>(type: "integer", nullable: false),
                    PenaltiesMissed = table.Column<int>(type: "integer", nullable: false),
                    YellowCards = table.Column<int>(type: "integer", nullable: false),
                    RedCards = table.Column<int>(type: "integer", nullable: false),
                    Saves = table.Column<int>(type: "integer", nullable: false),
                    Bonus = table.Column<int>(type: "integer", nullable: false),
                    Bps = table.Column<int>(type: "integer", nullable: false),
                    Influence = table.Column<string>(type: "text", nullable: true),
                    Creativity = table.Column<string>(type: "text", nullable: true),
                    Threat = table.Column<string>(type: "text", nullable: true),
                    IctIndex = table.Column<string>(type: "text", nullable: true),
                    InfluenceRank = table.Column<int>(type: "integer", nullable: false),
                    InfluenceRankType = table.Column<int>(type: "integer", nullable: false),
                    CreativityRank = table.Column<int>(type: "integer", nullable: false),
                    CreativityRankType = table.Column<int>(type: "integer", nullable: false),
                    ThreatRank = table.Column<int>(type: "integer", nullable: false),
                    ThreatRankType = table.Column<int>(type: "integer", nullable: false),
                    IctIndexRank = table.Column<int>(type: "integer", nullable: false),
                    IctIndexRankType = table.Column<int>(type: "integer", nullable: false),
                    CornersAndIndirectFreekicksOrder = table.Column<int>(type: "integer", nullable: true),
                    CornersAndIndirectFreekicksText = table.Column<string>(type: "text", nullable: true),
                    DirectFreekicksOrder = table.Column<int>(type: "integer", nullable: true),
                    DirectFreekicksText = table.Column<string>(type: "text", nullable: true),
                    PenaltiesOrder = table.Column<int>(type: "integer", nullable: true),
                    PenaltiesText = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elements", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ElementStats",
                columns: table => new
                {
                    Label = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementStats", x => new { x.Label, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "ElementTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PluralName = table.Column<string>(type: "text", nullable: true),
                    PluralNameShort = table.Column<string>(type: "text", nullable: true),
                    SingularName = table.Column<string>(type: "text", nullable: true),
                    SingularNameShort = table.Column<string>(type: "text", nullable: true),
                    SquadSelect = table.Column<int>(type: "integer", nullable: false),
                    SquadMinPlay = table.Column<int>(type: "integer", nullable: false),
                    SquadMaxPlay = table.Column<int>(type: "integer", nullable: false),
                    UiShirtSpecific = table.Column<bool>(type: "boolean", nullable: false),
                    SubPositionsLocked = table.Column<List<int>>(type: "integer[]", nullable: true),
                    ElementCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElementTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LeagueJoinPrivateMax = table.Column<int>(type: "integer", nullable: false),
                    LeagueJoinPublicMax = table.Column<int>(type: "integer", nullable: false),
                    LeagueMaxSizePublicClassic = table.Column<int>(type: "integer", nullable: false),
                    LeagueMaxSizePublicH2h = table.Column<int>(type: "integer", nullable: false),
                    LeagueMaxSizePrivateH2h = table.Column<int>(type: "integer", nullable: false),
                    LeagueMaxKoRoundsPrivateH2h = table.Column<int>(type: "integer", nullable: false),
                    LeaguePrefixPublic = table.Column<string>(type: "text", nullable: true),
                    LeaguePointsH2hWin = table.Column<int>(type: "integer", nullable: false),
                    LeaguePointsH2hLose = table.Column<int>(type: "integer", nullable: false),
                    LeaguePointsH2hDraw = table.Column<int>(type: "integer", nullable: false),
                    LeagueKoFirstInsteadOfRandom = table.Column<bool>(type: "boolean", nullable: false),
                    CupStartEventId = table.Column<int>(type: "integer", nullable: false),
                    CupStopEventId = table.Column<int>(type: "integer", nullable: false),
                    CupQualifyingMethod = table.Column<string>(type: "text", nullable: true),
                    CupType = table.Column<string>(type: "text", nullable: true),
                    SquadSquadplay = table.Column<int>(type: "integer", nullable: false),
                    SquadSquadsize = table.Column<int>(type: "integer", nullable: false),
                    SquadTeamLimit = table.Column<int>(type: "integer", nullable: false),
                    SquadTotalSpend = table.Column<int>(type: "integer", nullable: false),
                    UiCurrencyMultiplier = table.Column<int>(type: "integer", nullable: false),
                    UiUseSpecialShirts = table.Column<bool>(type: "boolean", nullable: false),
                    StatsFormDays = table.Column<int>(type: "integer", nullable: false),
                    SysViceCaptainEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    TransfersCap = table.Column<int>(type: "integer", nullable: false),
                    TransfersSellOnFee = table.Column<double>(type: "double precision", nullable: false),
                    LeagueH2hTiebreakStats = table.Column<List<string>>(type: "text[]", nullable: true),
                    Timezone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Phases",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    StartEvent = table.Column<int>(type: "integer", nullable: false),
                    StopEvent = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Phases", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<int>(type: "integer", nullable: false),
                    Draw = table.Column<int>(type: "integer", nullable: false),
                    Loss = table.Column<int>(type: "integer", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Played = table.Column<int>(type: "integer", nullable: false),
                    Points = table.Column<int>(type: "integer", nullable: false),
                    Position = table.Column<int>(type: "integer", nullable: false),
                    ShortName = table.Column<string>(type: "text", nullable: true),
                    Strength = table.Column<int>(type: "integer", nullable: false),
                    Unavailable = table.Column<bool>(type: "boolean", nullable: false),
                    Win = table.Column<int>(type: "integer", nullable: false),
                    StrengthOverallHome = table.Column<int>(type: "integer", nullable: false),
                    StrengthOverallAway = table.Column<int>(type: "integer", nullable: false),
                    StrengthAttackHome = table.Column<int>(type: "integer", nullable: false),
                    StrengthAttackAway = table.Column<int>(type: "integer", nullable: false),
                    StrengthDefenceHome = table.Column<int>(type: "integer", nullable: false),
                    StrengthDefenceAway = table.Column<int>(type: "integer", nullable: false),
                    PulseId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TopElementInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Points = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopElementInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    DeadlineTime = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    AverageEntryScore = table.Column<int>(type: "integer", nullable: false),
                    Finished = table.Column<bool>(type: "boolean", nullable: false),
                    DataChecked = table.Column<bool>(type: "boolean", nullable: false),
                    HighestScoringEntry = table.Column<int>(type: "integer", nullable: true),
                    DeadlineTimeEpoch = table.Column<int>(type: "integer", nullable: false),
                    DeadlineTimeGameOffset = table.Column<int>(type: "integer", nullable: false),
                    HighestScore = table.Column<int>(type: "integer", nullable: true),
                    IsPrevious = table.Column<bool>(type: "boolean", nullable: false),
                    IsCurrent = table.Column<bool>(type: "boolean", nullable: false),
                    IsNext = table.Column<bool>(type: "boolean", nullable: false),
                    MostSelected = table.Column<int>(type: "integer", nullable: true),
                    MostTransferredIn = table.Column<int>(type: "integer", nullable: true),
                    TopElement = table.Column<int>(type: "integer", nullable: true),
                    TopElementInfoId = table.Column<int>(type: "integer", nullable: true),
                    TransfersMade = table.Column<int>(type: "integer", nullable: false),
                    MostCaptained = table.Column<int>(type: "integer", nullable: true),
                    MostViceCaptained = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Events_TopElementInfos_TopElementInfoId",
                        column: x => x.TopElementInfoId,
                        principalTable: "TopElementInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_TopElementInfoId",
                table: "Events",
                column: "TopElementInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elements");

            migrationBuilder.DropTable(
                name: "ElementStats");

            migrationBuilder.DropTable(
                name: "ElementTypes");

            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "GameSettings");

            migrationBuilder.DropTable(
                name: "Phases");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "TopElementInfos");
        }
    }
}
