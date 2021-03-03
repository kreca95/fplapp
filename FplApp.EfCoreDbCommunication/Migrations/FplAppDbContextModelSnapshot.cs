﻿// <auto-generated />
using System;
using System.Collections.Generic;
using FplApp.EfCoreDbCommunication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace FplApp.EfCoreDbCommunication.Migrations
{
    [DbContext(typeof(FplAppDbContext))]
    partial class FplAppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.3")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("FplApp.Models.Models.Element", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Assists")
                        .HasColumnType("integer");

                    b.Property<int>("Bonus")
                        .HasColumnType("integer");

                    b.Property<int>("Bps")
                        .HasColumnType("integer");

                    b.Property<int?>("ChanceOfPlayingNextRound")
                        .HasColumnType("integer");

                    b.Property<int?>("ChanceOfPlayingThisRound")
                        .HasColumnType("integer");

                    b.Property<int>("CleanSheets")
                        .HasColumnType("integer");

                    b.Property<int>("Code")
                        .HasColumnType("integer");

                    b.Property<int?>("CornersAndIndirectFreekicksOrder")
                        .HasColumnType("integer");

                    b.Property<string>("CornersAndIndirectFreekicksText")
                        .HasColumnType("text");

                    b.Property<int>("CostChangeEvent")
                        .HasColumnType("integer");

                    b.Property<int>("CostChangeEventFall")
                        .HasColumnType("integer");

                    b.Property<int>("CostChangeStart")
                        .HasColumnType("integer");

                    b.Property<int>("CostChangeStartFall")
                        .HasColumnType("integer");

                    b.Property<string>("Creativity")
                        .HasColumnType("text");

                    b.Property<int>("CreativityRank")
                        .HasColumnType("integer");

                    b.Property<int>("CreativityRankType")
                        .HasColumnType("integer");

                    b.Property<int?>("DirectFreekicksOrder")
                        .HasColumnType("integer");

                    b.Property<string>("DirectFreekicksText")
                        .HasColumnType("text");

                    b.Property<int>("DreamteamCount")
                        .HasColumnType("integer");

                    b.Property<int>("ElementType")
                        .HasColumnType("integer");

                    b.Property<string>("EpNext")
                        .HasColumnType("text");

                    b.Property<string>("EpThis")
                        .HasColumnType("text");

                    b.Property<int>("EventPoints")
                        .HasColumnType("integer");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<string>("Form")
                        .HasColumnType("text");

                    b.Property<int>("GoalsConceded")
                        .HasColumnType("integer");

                    b.Property<int>("GoalsScored")
                        .HasColumnType("integer");

                    b.Property<string>("IctIndex")
                        .HasColumnType("text");

                    b.Property<int>("IctIndexRank")
                        .HasColumnType("integer");

                    b.Property<int>("IctIndexRankType")
                        .HasColumnType("integer");

                    b.Property<bool>("InDreamteam")
                        .HasColumnType("boolean");

                    b.Property<string>("Influence")
                        .HasColumnType("text");

                    b.Property<int>("InfluenceRank")
                        .HasColumnType("integer");

                    b.Property<int>("InfluenceRankType")
                        .HasColumnType("integer");

                    b.Property<int>("Minutes")
                        .HasColumnType("integer");

                    b.Property<string>("News")
                        .HasColumnType("text");

                    b.Property<DateTime?>("NewsAdded")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("NowCost")
                        .HasColumnType("integer");

                    b.Property<int>("OwnGoals")
                        .HasColumnType("integer");

                    b.Property<int>("PenaltiesMissed")
                        .HasColumnType("integer");

                    b.Property<int?>("PenaltiesOrder")
                        .HasColumnType("integer");

                    b.Property<int>("PenaltiesSaved")
                        .HasColumnType("integer");

                    b.Property<string>("PenaltiesText")
                        .HasColumnType("text");

                    b.Property<string>("Photo")
                        .HasColumnType("text");

                    b.Property<string>("PointsPerGame")
                        .HasColumnType("text");

                    b.Property<int>("RedCards")
                        .HasColumnType("integer");

                    b.Property<int>("Saves")
                        .HasColumnType("integer");

                    b.Property<string>("SecondName")
                        .HasColumnType("text");

                    b.Property<string>("SelectedByPercent")
                        .HasColumnType("text");

                    b.Property<bool>("Special")
                        .HasColumnType("boolean");

                    b.Property<string>("SquadNumber")
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<int>("Team")
                        .HasColumnType("integer");

                    b.Property<int>("TeamCode")
                        .HasColumnType("integer");

                    b.Property<string>("Threat")
                        .HasColumnType("text");

                    b.Property<int>("ThreatRank")
                        .HasColumnType("integer");

                    b.Property<int>("ThreatRankType")
                        .HasColumnType("integer");

                    b.Property<int>("TotalPoints")
                        .HasColumnType("integer");

                    b.Property<int>("TransfersIn")
                        .HasColumnType("integer");

                    b.Property<int>("TransfersInEvent")
                        .HasColumnType("integer");

                    b.Property<int>("TransfersOut")
                        .HasColumnType("integer");

                    b.Property<int>("TransfersOutEvent")
                        .HasColumnType("integer");

                    b.Property<string>("ValueForm")
                        .HasColumnType("text");

                    b.Property<string>("ValueSeason")
                        .HasColumnType("text");

                    b.Property<string>("WebName")
                        .HasColumnType("text");

                    b.Property<int>("YellowCards")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Elements");
                });

            modelBuilder.Entity("FplApp.Models.Models.ElementStat", b =>
                {
                    b.Property<string>("Label")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Label", "Name");

                    b.ToTable("ElementStats");
                });

            modelBuilder.Entity("FplApp.Models.Models.ElementType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("ElementCount")
                        .HasColumnType("integer");

                    b.Property<string>("PluralName")
                        .HasColumnType("text");

                    b.Property<string>("PluralNameShort")
                        .HasColumnType("text");

                    b.Property<string>("SingularName")
                        .HasColumnType("text");

                    b.Property<string>("SingularNameShort")
                        .HasColumnType("text");

                    b.Property<int>("SquadMaxPlay")
                        .HasColumnType("integer");

                    b.Property<int>("SquadMinPlay")
                        .HasColumnType("integer");

                    b.Property<int>("SquadSelect")
                        .HasColumnType("integer");

                    b.Property<List<int>>("SubPositionsLocked")
                        .HasColumnType("integer[]");

                    b.Property<bool>("UiShirtSpecific")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("ElementTypes");
                });

            modelBuilder.Entity("FplApp.Models.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("AverageEntryScore")
                        .HasColumnType("integer");

                    b.Property<bool>("DataChecked")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("DeadlineTime")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("DeadlineTimeEpoch")
                        .HasColumnType("integer");

                    b.Property<int>("DeadlineTimeGameOffset")
                        .HasColumnType("integer");

                    b.Property<bool>("Finished")
                        .HasColumnType("boolean");

                    b.Property<int?>("HighestScore")
                        .HasColumnType("integer");

                    b.Property<int?>("HighestScoringEntry")
                        .HasColumnType("integer");

                    b.Property<bool>("IsCurrent")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsNext")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsPrevious")
                        .HasColumnType("boolean");

                    b.Property<int?>("MostCaptained")
                        .HasColumnType("integer");

                    b.Property<int?>("MostSelected")
                        .HasColumnType("integer");

                    b.Property<int?>("MostTransferredIn")
                        .HasColumnType("integer");

                    b.Property<int?>("MostViceCaptained")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("TopElement")
                        .HasColumnType("integer");

                    b.Property<int?>("TopElementInfoId")
                        .HasColumnType("integer");

                    b.Property<int>("TransfersMade")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("TopElementInfoId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("FplApp.Models.Models.GameSettings", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("CupQualifyingMethod")
                        .HasColumnType("text");

                    b.Property<int>("CupStartEventId")
                        .HasColumnType("integer");

                    b.Property<int>("CupStopEventId")
                        .HasColumnType("integer");

                    b.Property<string>("CupType")
                        .HasColumnType("text");

                    b.Property<List<string>>("LeagueH2hTiebreakStats")
                        .HasColumnType("text[]");

                    b.Property<int>("LeagueJoinPrivateMax")
                        .HasColumnType("integer");

                    b.Property<int>("LeagueJoinPublicMax")
                        .HasColumnType("integer");

                    b.Property<bool>("LeagueKoFirstInsteadOfRandom")
                        .HasColumnType("boolean");

                    b.Property<int>("LeagueMaxKoRoundsPrivateH2h")
                        .HasColumnType("integer");

                    b.Property<int>("LeagueMaxSizePrivateH2h")
                        .HasColumnType("integer");

                    b.Property<int>("LeagueMaxSizePublicClassic")
                        .HasColumnType("integer");

                    b.Property<int>("LeagueMaxSizePublicH2h")
                        .HasColumnType("integer");

                    b.Property<int>("LeaguePointsH2hDraw")
                        .HasColumnType("integer");

                    b.Property<int>("LeaguePointsH2hLose")
                        .HasColumnType("integer");

                    b.Property<int>("LeaguePointsH2hWin")
                        .HasColumnType("integer");

                    b.Property<string>("LeaguePrefixPublic")
                        .HasColumnType("text");

                    b.Property<int>("SquadSquadplay")
                        .HasColumnType("integer");

                    b.Property<int>("SquadSquadsize")
                        .HasColumnType("integer");

                    b.Property<int>("SquadTeamLimit")
                        .HasColumnType("integer");

                    b.Property<int>("SquadTotalSpend")
                        .HasColumnType("integer");

                    b.Property<int>("StatsFormDays")
                        .HasColumnType("integer");

                    b.Property<bool>("SysViceCaptainEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("Timezone")
                        .HasColumnType("text");

                    b.Property<int>("TransfersCap")
                        .HasColumnType("integer");

                    b.Property<double>("TransfersSellOnFee")
                        .HasColumnType("double precision");

                    b.Property<int>("UiCurrencyMultiplier")
                        .HasColumnType("integer");

                    b.Property<bool>("UiUseSpecialShirts")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("GameSettings");
                });

            modelBuilder.Entity("FplApp.Models.Models.Phase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("StartEvent")
                        .HasColumnType("integer");

                    b.Property<int>("StopEvent")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Phases");
                });

            modelBuilder.Entity("FplApp.Models.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Code")
                        .HasColumnType("integer");

                    b.Property<int>("Draw")
                        .HasColumnType("integer");

                    b.Property<int>("Loss")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int>("Played")
                        .HasColumnType("integer");

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.Property<int>("Position")
                        .HasColumnType("integer");

                    b.Property<int>("PulseId")
                        .HasColumnType("integer");

                    b.Property<string>("ShortName")
                        .HasColumnType("text");

                    b.Property<int>("Strength")
                        .HasColumnType("integer");

                    b.Property<int>("StrengthAttackAway")
                        .HasColumnType("integer");

                    b.Property<int>("StrengthAttackHome")
                        .HasColumnType("integer");

                    b.Property<int>("StrengthDefenceAway")
                        .HasColumnType("integer");

                    b.Property<int>("StrengthDefenceHome")
                        .HasColumnType("integer");

                    b.Property<int>("StrengthOverallAway")
                        .HasColumnType("integer");

                    b.Property<int>("StrengthOverallHome")
                        .HasColumnType("integer");

                    b.Property<bool>("Unavailable")
                        .HasColumnType("boolean");

                    b.Property<int>("Win")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("FplApp.Models.Models.TopElementInfo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<int>("Points")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.ToTable("TopElementInfos");
                });

            modelBuilder.Entity("FplApp.Models.Models.Event", b =>
                {
                    b.HasOne("FplApp.Models.Models.TopElementInfo", "TopElementInfo")
                        .WithMany()
                        .HasForeignKey("TopElementInfoId");

                    b.Navigation("TopElementInfo");
                });
#pragma warning restore 612, 618
        }
    }
}
