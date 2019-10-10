using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ANSH.DataBase.EFCore.SQLServer {
    /// <summary>
    /// EF操作SqlServer
    /// </summary>
    public abstract class ANSHDomainSqlContextTypeConfigurationBase<TEntity, TIEntityTypeConfiguration, TPKey> : ANSHSqlContextTypeConfigurationBase<TEntity, TIEntityTypeConfiguration>
        where TIEntityTypeConfiguration : ANSHDbDomainEntityTypeConfigurationBase<TEntity, TPKey>, new ()
    where TEntity : class, IANSHDbDomainEntityBase<TPKey>, new ()
    where TPKey : struct, IEquatable<TPKey> {

        /// <summary>
        /// 模型绑定
        /// </summary>
        /// <param name="modelBuilder">模型绑定</param>
        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration (new TIEntityTypeConfiguration ());
        }
    }
}