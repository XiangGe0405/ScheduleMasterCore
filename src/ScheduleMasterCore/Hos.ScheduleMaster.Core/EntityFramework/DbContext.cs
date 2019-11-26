﻿
//------------------------------------------------------------------------------
// <auto-generated>
// 此文件由T4模板生成，请勿手动修改
// by hoho
// 11/26/2019 11:59:56
// </auto-generated>
//------------------------------------------------------------------------------

using Hos.ScheduleMaster.Core.Models;
using Hos.ScheduleMaster.Core.Repository;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Hos.ScheduleMaster.Core.EntityFramework;

namespace Hos.ScheduleMaster.Core.Models
{
    public class SmDbContext : DbContext
    {
		public SmDbContext(DbContextOptions<SmDbContext> option) : base(option)
        {
        }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
            base.OnModelCreating(modelBuilder);		
			//初始化数据
            modelBuilder.SeedData();
		}
			public virtual DbSet<ScheduleEntity> Schedules { get; set; }

		public virtual DbSet<ScheduleKeeperEntity> ScheduleKeepers { get; set; }

		public virtual DbSet<ScheduleLockEntity> ScheduleLocks { get; set; }

		public virtual DbSet<ScheduleReferenceEntity> ScheduleReferences { get; set; }

		public virtual DbSet<ScheduleTraceEntity> ScheduleTraces { get; set; }

		public virtual DbSet<ServerNodeEntity> ServerNodes { get; set; }

		public virtual DbSet<SystemConfigEntity> SystemConfigs { get; set; }

		public virtual DbSet<SystemLogEntity> SystemLogs { get; set; }

		public virtual DbSet<SystemUserEntity> SystemUsers { get; set; }

	    }
}