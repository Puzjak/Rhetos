﻿// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\Autofac.dll
// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\Rhetos.Extensibility.Interfaces.dll
// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\Rhetos.Utilities.dll
// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\Rhetos.Security.Interfaces.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.ComponentModel.Composition\v4.0_4.0.0.0__b77a5c561934e089\System.ComponentModel.Composition.dll
// Reference: C:\Windows\Microsoft.NET\Framework64\v4.0.30319\mscorlib.dll
// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\Plugins\Rhetos.Dom.DefaultConcepts.dll
// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\Rhetos.Logging.Interfaces.dll
// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\EntityFramework.dll
// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\EntityFramework.SqlServer.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_64\System.Data\v4.0_4.0.0.0__b77a5c561934e089\System.Data.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System\v4.0_4.0.0.0__b77a5c561934e089\System.dll
// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\Rhetos.Persistence.Interfaces.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Core\v4.0_4.0.0.0__b77a5c561934e089\System.Core.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\Microsoft.CSharp\v4.0_4.0.0.0__b03f5f7f11d50a3a\Microsoft.CSharp.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Data.DataSetExtensions\v4.0_4.0.0.0__b77a5c561934e089\System.Data.DataSetExtensions.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Xml.Linq\v4.0_4.0.0.0__b77a5c561934e089\System.Xml.Linq.dll
// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\Plugins\Rhetos.Dom.DefaultConcepts.Interfaces.dll
// Reference: C:\Windows\Microsoft.Net\assembly\GAC_MSIL\System.Runtime.Serialization\v4.0_4.0.0.0__b77a5c561934e089\System.Runtime.Serialization.dll
// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\Plugins\OmegaCommonConcepts.dll
// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\Generated\ServerDom.Model.dll
// Reference: C:\Projects\MojPrviRhetos\Rhetos\bin\Generated\ServerDom.Orm.dll
// CompilerOptions: "/optimize"

namespace Common
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;
    using Autofac;
    /*CommonUsing*/

    public class DomRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public DomRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private PrviRhetos._Helper._ModuleRepository _PrviRhetos;
        public PrviRhetos._Helper._ModuleRepository PrviRhetos { get { return _PrviRhetos ?? (_PrviRhetos = new PrviRhetos._Helper._ModuleRepository(_repositories)); } }

        private Common._Helper._ModuleRepository _Common;
        public Common._Helper._ModuleRepository Common { get { return _Common ?? (_Common = new Common._Helper._ModuleRepository(_repositories)); } }

        /*CommonDomRepositoryMembers*/
    }

    public static class Infrastructure
    {
        public static readonly RegisteredInterfaceImplementations RegisteredInterfaceImplementationName = new RegisteredInterfaceImplementations
        {
            { typeof(Rhetos.Dom.DefaultConcepts.ICommonFilterId), @"Common.FilterId" },
            { typeof(Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata), @"Common.KeepSynchronizedMetadata" },
            { typeof(Rhetos.Dom.DefaultConcepts.ICommonClaim), @"Common.Claim" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipal), @"Common.Principal" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipalHasRole), @"Common.PrincipalHasRole" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRole), @"Common.Role" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRoleInheritsRole), @"Common.RoleInheritsRole" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipalPermission), @"Common.PrincipalPermission" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRolePermission), @"Common.RolePermission" },
            /*RegisteredInterfaceImplementationName*/
        };

        public static readonly ApplyFiltersOnClientRead ApplyFiltersOnClientRead = new ApplyFiltersOnClientRead
        {
            /*ApplyFiltersOnClientRead*/
        };

        public static readonly CurrentKeepSynchronizedMetadata CurrentKeepSynchronizedMetadata = new CurrentKeepSynchronizedMetadata
        {
            /*AddKeepSynchronizedMetadata*/
        };

        /*CommonInfrastructureMembers*/
    }

    public class ExecutionContext
    {
        protected Lazy<Rhetos.Persistence.IPersistenceTransaction> _persistenceTransaction;
        public Rhetos.Persistence.IPersistenceTransaction PersistenceTransaction { get { return _persistenceTransaction.Value; } }

        protected Lazy<Rhetos.Utilities.IUserInfo> _userInfo;
        public Rhetos.Utilities.IUserInfo UserInfo { get { return _userInfo.Value; } }

        protected Lazy<Rhetos.Utilities.ISqlExecuter> _sqlExecuter;
        public Rhetos.Utilities.ISqlExecuter SqlExecuter { get { return _sqlExecuter.Value; } }

        protected Lazy<Rhetos.Security.IAuthorizationManager> _authorizationManager;
        public Rhetos.Security.IAuthorizationManager AuthorizationManager { get { return _authorizationManager.Value; } }

        protected Lazy<Rhetos.Dom.DefaultConcepts.GenericRepositories> _genericRepositories;
        public Rhetos.Dom.DefaultConcepts.GenericRepositories GenericRepositories { get { return _genericRepositories.Value; } }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<TEntity> GenericRepository<TEntity>() where TEntity : class, IEntity
        {
            return GenericRepositories.GetGenericRepository<TEntity>();
        }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<TEntity> GenericRepository<TEntity>(string entityName) where TEntity : class, IEntity
        {
            return GenericRepositories.GetGenericRepository<TEntity>(entityName);
        }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<IEntity> GenericRepository(string entityName)
        {
            return GenericRepositories.GetGenericRepository(entityName);
        }

        protected Lazy<Common.DomRepository> _repository;
        public Common.DomRepository Repository { get { return _repository.Value; } }

        public Rhetos.Logging.ILogProvider LogProvider { get; private set; }

        protected Lazy<Rhetos.Security.IWindowsSecurity> _windowsSecurity;
        public Rhetos.Security.IWindowsSecurity WindowsSecurity { get { return _windowsSecurity.Value; } }

        public EntityFrameworkContext EntityFrameworkContext { get; private set; }

        /*ExecutionContextMember*/

        // This constructor is used for automatic parameter injection with autofac.
        public ExecutionContext(
            Lazy<Rhetos.Persistence.IPersistenceTransaction> persistenceTransaction,
            Lazy<Rhetos.Utilities.IUserInfo> userInfo,
            Lazy<Rhetos.Utilities.ISqlExecuter> sqlExecuter,
            Lazy<Rhetos.Security.IAuthorizationManager> authorizationManager,
            Lazy<Rhetos.Dom.DefaultConcepts.GenericRepositories> genericRepositories,
            Lazy<Common.DomRepository> repository,
            Rhetos.Logging.ILogProvider logProvider,
            Lazy<Rhetos.Security.IWindowsSecurity> windowsSecurity/*ExecutionContextConstructorArgument*/,
            EntityFrameworkContext entityFrameworkContext)
        {
            _persistenceTransaction = persistenceTransaction;
            _userInfo = userInfo;
            _sqlExecuter = sqlExecuter;
            _authorizationManager = authorizationManager;
            _genericRepositories = genericRepositories;
            _repository = repository;
            LogProvider = logProvider;
            _windowsSecurity = windowsSecurity;
            EntityFrameworkContext = entityFrameworkContext;
            /*ExecutionContextConstructorAssignment*/
        }

        // This constructor is used for manual context creation (unit testing)
        public ExecutionContext()
        {
        }
    }

    [System.ComponentModel.Composition.Export(typeof(Autofac.Module))]
    public class AutofacModuleConfiguration : Autofac.Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            builder.RegisterType<DomRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EntityFrameworkConfiguration>().SingleInstance();
            builder.RegisterType<EntityFrameworkContext>()
                .As<EntityFrameworkContext>()
                .As<System.Data.Entity.DbContext>()
                .As<Rhetos.Persistence.IPersistenceCache>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ExecutionContext>().InstancePerLifetimeScope();
            builder.RegisterInstance(Infrastructure.RegisteredInterfaceImplementationName).ExternallyOwned();
            builder.RegisterInstance(Infrastructure.ApplyFiltersOnClientRead).ExternallyOwned();
            builder.RegisterInstance(Infrastructure.CurrentKeepSynchronizedMetadata).ExternallyOwned();
            builder.RegisterType<PrviRhetos._Helper.Drzava_Repository>().Keyed<IRepository>("PrviRhetos.Drzava").InstancePerLifetimeScope();
            builder.RegisterType<PrviRhetos._Helper.Grad_Repository>().Keyed<IRepository>("PrviRhetos.Grad").InstancePerLifetimeScope();
            builder.RegisterType<PrviRhetos._Helper.Osoba_Repository>().Keyed<IRepository>("PrviRhetos.Osoba").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AutoCodeCache_Repository>().Keyed<IRepository>("Common.AutoCodeCache").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.FilterId_Repository>().Keyed<IRepository>("Common.FilterId").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.KeepSynchronizedMetadata_Repository>().Keyed<IRepository>("Common.KeepSynchronizedMetadata").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ExclusiveLock_Repository>().Keyed<IRepository>("Common.ExclusiveLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.SetLock_Repository>().Keyed<IRepository>("Common.SetLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.SetLock_Repository>().Keyed<IActionRepository>("Common.SetLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ReleaseLock_Repository>().Keyed<IRepository>("Common.ReleaseLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ReleaseLock_Repository>().Keyed<IActionRepository>("Common.ReleaseLock").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.LogReader_Repository>().Keyed<IRepository>("Common.LogReader").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.LogRelatedItemReader_Repository>().Keyed<IRepository>("Common.LogRelatedItemReader").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Log_Repository>().Keyed<IRepository>("Common.Log").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AddToLog_Repository>().Keyed<IRepository>("Common.AddToLog").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AddToLog_Repository>().Keyed<IActionRepository>("Common.AddToLog").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.LogRelatedItem_Repository>().Keyed<IRepository>("Common.LogRelatedItem").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RelatedEventsSource_Repository>().Keyed<IRepository>("Common.RelatedEventsSource").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Claim_Repository>().Keyed<IRepository>("Common.Claim").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.MyClaim_Repository>().Keyed<IRepository>("Common.MyClaim").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Principal_Repository>().Keyed<IRepository>("Common.Principal").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalHasRole_Repository>().Keyed<IRepository>("Common.PrincipalHasRole").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Role_Repository>().Keyed<IRepository>("Common.Role").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RoleInheritsRole_Repository>().Keyed<IRepository>("Common.RoleInheritsRole").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalPermission_Repository>().Keyed<IRepository>("Common.PrincipalPermission").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RolePermission_Repository>().Keyed<IRepository>("Common.RolePermission").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AuditRelatedEvents_Repository>().Keyed<IRepository>("Common.AuditRelatedEvents").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.AuditDataModifications_Repository>().Keyed<IRepository>("Common.AuditDataModifications").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.ReportTemplate_Repository>().Keyed<IRepository>("Common.ReportTemplate").InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.FilterId_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.ICommonFilterId>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.KeepSynchronizedMetadata_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Claim_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.ICommonClaim>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Principal_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipal>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalHasRole_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipalHasRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.Role_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RoleInheritsRole_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRoleInheritsRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.PrincipalPermission_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipalPermission>>().InstancePerLifetimeScope();
            builder.RegisterType<Common._Helper.RolePermission_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRolePermission>>().InstancePerLifetimeScope();
            /*CommonAutofacConfigurationMembers*/

            base.Load(builder);
        }
    }

    public abstract class RepositoryBase : IRepository
    {
        protected Common.DomRepository _domRepository;
        protected Common.ExecutionContext _executionContext;
    }

    public abstract class ReadableRepositoryBase<TEntity> : RepositoryBase, IReadableRepository<TEntity>
        where TEntity : class, IEntity
    {
        public IEnumerable<TEntity> Load(object parameter, Type parameterType)
        {
            var items = _executionContext.GenericRepository(typeof(TEntity).FullName)
                .Load(parameter, parameterType);
            return (IEnumerable<TEntity>)items;
        }

        public IEnumerable<TEntity> Read(object parameter, Type parameterType, bool preferQuery)
        {
            var items = _executionContext.GenericRepository(typeof(TEntity).FullName)
                .Read(parameter, parameterType, preferQuery);
            return (IEnumerable<TEntity>)items;
        }

        [Obsolete("Use Load() or Query() method.")]
        public abstract TEntity[] All();

        [Obsolete("Use Load() or Query() method.")]
        public TEntity[] Filter(FilterAll filterAll)
        {
            return All();
        }
    }

    public abstract class QueryableRepositoryBase<TQueryableEntity, TEntity> : ReadableRepositoryBase<TEntity>, IQueryableRepository<TQueryableEntity>
        where TEntity : class, IEntity
        where TQueryableEntity : class, IEntity, TEntity, IQueryableEntity<TEntity>
    {
        [Obsolete("Use Load(identifiers)or Query(identifiers) method.")]
        public TEntity[] Filter(IEnumerable<Guid> identifiers)
        {
            const int BufferSize = 500; // EF 6.1.3 LINQ query has O(n^2) time complexity. Batch size of 500 results with optimal total time on the test system.
            int n = identifiers.Count();
            var result = new List<TEntity>(n);
            for (int i = 0; i < (n + BufferSize - 1) / BufferSize; i++)
            {
                Guid[] idBuffer = identifiers.Skip(i * BufferSize).Take(BufferSize).ToArray();
                List<TEntity> itemBuffer;
                if (idBuffer.Count() == 1) // EF 6.1.3. does not use parametrized SQL query for Contains() function. The equality comparer is used instead, to reuse cached execution plans.
                {
                    Guid id = idBuffer.Single();
                    itemBuffer = Query().Where(item => item.ID == id).GenericToSimple<TEntity>().ToList();
                }
                else
                    itemBuffer = Query().Where(item => idBuffer.Contains(item.ID)).GenericToSimple<TEntity>().ToList();
                result.AddRange(itemBuffer);
            }
            return result.ToArray();
        }

        public abstract IQueryable<TQueryableEntity> Query();

        // LINQ to Entity does not support Query() method in subqueries.
        public IQueryable<TQueryableEntity> Subquery { get { return Query(); } }

        public IQueryable<TQueryableEntity> Query(object parameter, Type parameterType)
        {
            var query = _executionContext.GenericRepository(typeof(TEntity).FullName).Query(parameter, parameterType);
            return (IQueryable<TQueryableEntity>)query;
        }
    }

    public abstract class OrmRepositoryBase<TQueryableEntity, TEntity> : QueryableRepositoryBase<TQueryableEntity, TEntity>
        where TEntity : class, IEntity
        where TQueryableEntity : class, IEntity, TEntity, IQueryableEntity<TEntity>
    {
        public IQueryable<TQueryableEntity> Filter(IQueryable<TQueryableEntity> items, IEnumerable<Guid> ids)
        {
            if (!(ids is System.Collections.IList))
                ids = ids.ToList();

            if (ids.Count() == 1) // EF 6.1.3. does not use parametrized SQL query for Contains() function. The equality comparer is used instead, to reuse cached execution plans.
            {
                Guid id = ids.Single();
                return items.Where(item => item.ID == id);
            }
            else
            {
                // Depending on the ids count, this method will return the list of IDs, or insert the ids to the database and return an SQL query that selects the ids.
                var idsQuery = _domRepository.Common.FilterId.CreateQueryableFilterIds(ids);
                return items.Where(item => idsQuery.Contains(item.ID));
            }
        }
    }

    internal class DontTrackHistory<T> : List<T>
    {
    }
    /*CommonNamespaceMembers*/
}

namespace PrviRhetos._Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using PrviRhetos*/

    public class _ModuleRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public _ModuleRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private Drzava_Repository _Drzava_Repository;
        public Drzava_Repository Drzava { get { return _Drzava_Repository ?? (_Drzava_Repository = (Drzava_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"PrviRhetos.Drzava")); } }

        private Grad_Repository _Grad_Repository;
        public Grad_Repository Grad { get { return _Grad_Repository ?? (_Grad_Repository = (Grad_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"PrviRhetos.Grad")); } }

        private Osoba_Repository _Osoba_Repository;
        public Osoba_Repository Osoba { get { return _Osoba_Repository ?? (_Osoba_Repository = (Osoba_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"PrviRhetos.Osoba")); } }

        /*ModuleInfo RepositoryMembers PrviRhetos*/
    }

    /*DataStructureInfo RepositoryAttributes PrviRhetos.Drzava*/
    public class Drzava_Repository : /*DataStructureInfo OverrideBaseType PrviRhetos.Drzava*/ Common.OrmRepositoryBase<Common.Queryable.PrviRhetos_Drzava, PrviRhetos.Drzava> // Common.QueryableRepositoryBase<Common.Queryable.PrviRhetos_Drzava, PrviRhetos.Drzava> // Common.ReadableRepositoryBase<PrviRhetos.Drzava> // global::Common.RepositoryBase
        , IWritableRepository<PrviRhetos.Drzava>, IValidateRepository/*DataStructureInfo RepositoryInterface PrviRhetos.Drzava*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers PrviRhetos.Drzava*/

        public Drzava_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments PrviRhetos.Drzava*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode PrviRhetos.Drzava*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::PrviRhetos.Drzava[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.PrviRhetos_Drzava> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery PrviRhetos.Drzava*/
            return _executionContext.EntityFrameworkContext.PrviRhetos_Drzava.AsNoTracking();
        }

        public void Save(IEnumerable<PrviRhetos.Drzava> insertedNew, IEnumerable<PrviRhetos.Drzava> updatedNew, IEnumerable<PrviRhetos.Drzava> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext PrviRhetos.Drzava*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Naziv != null && newItem.Naziv.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Drzava.Naziv", "256" },
                        "DataStructure:PrviRhetos.Drzava,ID:" + invalidItem.ID.ToString() + ",Property:Naziv",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.PozivniBroj != null && newItem.PozivniBroj.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Drzava.PozivniBroj", "256" },
                        "DataStructure:PrviRhetos.Drzava,ID:" + invalidItem.ID.ToString() + ",Property:PozivniBroj",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation PrviRhetos.Drzava*/

            /*DataStructureInfo WritableOrm Initialization PrviRhetos.Drzava*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.PrviRhetos_Drzava> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.PrviRhetos_Drzava>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.PrviRhetos_Drzava> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.PrviRhetos_Drzava>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded PrviRhetos.Drzava*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Naziv == null || string.IsNullOrWhiteSpace(item.Naziv) /*RequiredPropertyInfo OrCondition PrviRhetos.Drzava.Naziv*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "PrviRhetos.Drzava", "Naziv" },
                        "DataStructure:PrviRhetos.Drzava,ID:" + invalid.ID.ToString() + ",Property:Naziv", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PozivniBroj == null || string.IsNullOrWhiteSpace(item.PozivniBroj) /*RequiredPropertyInfo OrCondition PrviRhetos.Drzava.PozivniBroj*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "PrviRhetos.Drzava", "PozivniBroj" },
                        "DataStructure:PrviRhetos.Drzava,ID:" + invalid.ID.ToString() + ",Property:PozivniBroj", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData PrviRhetos.Drzava*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.PrviRhetos_Drzava.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"PrviRhetos.Grad", @"UDrzaviID", @"FK_Grad_Drzava_UDrzaviID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:PrviRhetos.Grad,Property:UDrzaviID,Referenced:PrviRhetos.Drzava";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"PrviRhetos.Osoba", @"DrzavaRodenjaID", @"FK_Osoba_Drzava_DrzavaRodenjaID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:PrviRhetos.Osoba,Property:DrzavaRodenjaID,Referenced:PrviRhetos.Drzava";
                /*DataStructureInfo WritableOrm OnDatabaseError PrviRhetos.Drzava*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "PrviRhetos.Drzava");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.PrviRhetos_Drzava> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 PrviRhetos.Drzava*/

                /*DataStructureInfo WritableOrm OnSaveTag2 PrviRhetos.Drzava*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "PrviRhetos.Drzava");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new PozivniBroj_MaxLengthFilter()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_PozivniBroj__MaxLengthFilter(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate PrviRhetos.Drzava*/
            yield break;
        }

        public global::PrviRhetos.Drzava CreateInstance()
        {
            var _item = new global::PrviRhetos.Drzava();
            /*DataStructureInfo CreateInstance PrviRhetos.Drzava*/
            return _item;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_PozivniBroj__MaxLengthFilter(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Maximum allowed length of {0} is {1} characters.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"PozivniBroj_MaxLengthFilter";
            metadata[@"Property"] = @"PozivniBroj";
            /*InvalidDataInfo ErrorMetadata PrviRhetos.Drzava.PozivniBroj_MaxLengthFilter*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"PozivniBroj", 4 },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages PrviRhetos.Drzava.PozivniBroj_MaxLengthFilter*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.PrviRhetos_Drzava> Filter(IQueryable<Common.Queryable.PrviRhetos_Drzava> localSource, PrviRhetos.PozivniBroj_MaxLengthFilter localParameter)
        {
            Func<IQueryable<Common.Queryable.PrviRhetos_Drzava>, Common.DomRepository, PrviRhetos.PozivniBroj_MaxLengthFilter/*ComposableFilterByInfo AdditionalParametersType PrviRhetos.Drzava.'PrviRhetos.PozivniBroj_MaxLengthFilter'*/, IQueryable<Common.Queryable.PrviRhetos_Drzava>> filterFunction =
            (source, repository, parameter) => source.Where(item => !String.IsNullOrEmpty(item.PozivniBroj) && item.PozivniBroj.Length > 4);

            /*ComposableFilterByInfo BeforeFilter PrviRhetos.Drzava.'PrviRhetos.PozivniBroj_MaxLengthFilter'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument PrviRhetos.Drzava.'PrviRhetos.PozivniBroj_MaxLengthFilter'*/);
        }

        public global::PrviRhetos.Drzava[] Filter(PrviRhetos.PozivniBroj_MaxLengthFilter filter_Parameter)
        {
            Func<Common.DomRepository, PrviRhetos.PozivniBroj_MaxLengthFilter/*FilterByInfo AdditionalParametersType PrviRhetos.Drzava.'PrviRhetos.PozivniBroj_MaxLengthFilter'*/, PrviRhetos.Drzava[]> filter_Function =
                (repository, parameter) => repository.PrviRhetos.Drzava.Filter(repository.PrviRhetos.Drzava.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument PrviRhetos.Drzava.'PrviRhetos.PozivniBroj_MaxLengthFilter'*/);
        }

        /*DataStructureInfo RepositoryMembers PrviRhetos.Drzava*/
    }

    /*DataStructureInfo RepositoryAttributes PrviRhetos.Grad*/
    public class Grad_Repository : /*DataStructureInfo OverrideBaseType PrviRhetos.Grad*/ Common.OrmRepositoryBase<Common.Queryable.PrviRhetos_Grad, PrviRhetos.Grad> // Common.QueryableRepositoryBase<Common.Queryable.PrviRhetos_Grad, PrviRhetos.Grad> // Common.ReadableRepositoryBase<PrviRhetos.Grad> // global::Common.RepositoryBase
        , IWritableRepository<PrviRhetos.Grad>, IValidateRepository/*DataStructureInfo RepositoryInterface PrviRhetos.Grad*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers PrviRhetos.Grad*/

        public Grad_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments PrviRhetos.Grad*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode PrviRhetos.Grad*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::PrviRhetos.Grad[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.PrviRhetos_Grad> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery PrviRhetos.Grad*/
            return _executionContext.EntityFrameworkContext.PrviRhetos_Grad.AsNoTracking();
        }

        public void Save(IEnumerable<PrviRhetos.Grad> insertedNew, IEnumerable<PrviRhetos.Grad> updatedNew, IEnumerable<PrviRhetos.Grad> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext PrviRhetos.Grad*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Naziv != null && newItem.Naziv.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Grad.Naziv", "256" },
                        "DataStructure:PrviRhetos.Grad,ID:" + invalidItem.ID.ToString() + ",Property:Naziv",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.PostanskiBroj != null && newItem.PostanskiBroj.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Grad.PostanskiBroj", "256" },
                        "DataStructure:PrviRhetos.Grad,ID:" + invalidItem.ID.ToString() + ",Property:PostanskiBroj",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation PrviRhetos.Grad*/

            /*DataStructureInfo WritableOrm Initialization PrviRhetos.Grad*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.PrviRhetos_Grad> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.PrviRhetos_Grad>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.PrviRhetos_Grad> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.PrviRhetos_Grad>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded PrviRhetos.Grad*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Naziv == null || string.IsNullOrWhiteSpace(item.Naziv) /*RequiredPropertyInfo OrCondition PrviRhetos.Grad.Naziv*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "PrviRhetos.Grad", "Naziv" },
                        "DataStructure:PrviRhetos.Grad,ID:" + invalid.ID.ToString() + ",Property:Naziv", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UDrzaviID == null /*RequiredPropertyInfo OrCondition PrviRhetos.Grad.UDrzavi*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "PrviRhetos.Grad", "UDrzavi" },
                        "DataStructure:PrviRhetos.Grad,ID:" + invalid.ID.ToString() + ",Property:UDrzaviID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PostanskiBroj == null || string.IsNullOrWhiteSpace(item.PostanskiBroj) /*RequiredPropertyInfo OrCondition PrviRhetos.Grad.PostanskiBroj*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "PrviRhetos.Grad", "PostanskiBroj" },
                        "DataStructure:PrviRhetos.Grad,ID:" + invalid.ID.ToString() + ",Property:PostanskiBroj", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData PrviRhetos.Grad*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.PrviRhetos_Grad.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"PrviRhetos.Drzava", @"ID", @"FK_Grad_Drzava_UDrzaviID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:PrviRhetos.Grad,Property:UDrzaviID,Referenced:PrviRhetos.Drzava";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"PrviRhetos.Osoba", @"GradRodenjaID", @"FK_Osoba_Grad_GradRodenjaID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:PrviRhetos.Osoba,Property:GradRodenjaID,Referenced:PrviRhetos.Grad";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"PrviRhetos.Osoba", @"GradStanovanjaID", @"FK_Osoba_Grad_GradStanovanjaID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:PrviRhetos.Osoba,Property:GradStanovanjaID,Referenced:PrviRhetos.Grad";
                /*DataStructureInfo WritableOrm OnDatabaseError PrviRhetos.Grad*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "PrviRhetos.Grad");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.PrviRhetos_Grad> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 PrviRhetos.Grad*/

                /*DataStructureInfo WritableOrm OnSaveTag2 PrviRhetos.Grad*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "PrviRhetos.Grad");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate PrviRhetos.Grad*/
            yield break;
        }

        public global::PrviRhetos.Grad CreateInstance()
        {
            var _item = new global::PrviRhetos.Grad();
            /*DataStructureInfo CreateInstance PrviRhetos.Grad*/
            return _item;
        }

        /*DataStructureInfo RepositoryMembers PrviRhetos.Grad*/
    }

    /*DataStructureInfo RepositoryAttributes PrviRhetos.Osoba*/
    public class Osoba_Repository : /*DataStructureInfo OverrideBaseType PrviRhetos.Osoba*/ Common.OrmRepositoryBase<Common.Queryable.PrviRhetos_Osoba, PrviRhetos.Osoba> // Common.QueryableRepositoryBase<Common.Queryable.PrviRhetos_Osoba, PrviRhetos.Osoba> // Common.ReadableRepositoryBase<PrviRhetos.Osoba> // global::Common.RepositoryBase
        , IWritableRepository<PrviRhetos.Osoba>, IValidateRepository/*DataStructureInfo RepositoryInterface PrviRhetos.Osoba*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers PrviRhetos.Osoba*/

        public Osoba_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments PrviRhetos.Osoba*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode PrviRhetos.Osoba*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::PrviRhetos.Osoba[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.PrviRhetos_Osoba> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery PrviRhetos.Osoba*/
            return _executionContext.EntityFrameworkContext.PrviRhetos_Osoba.AsNoTracking();
        }

        public void Save(IEnumerable<PrviRhetos.Osoba> insertedNew, IEnumerable<PrviRhetos.Osoba> updatedNew, IEnumerable<PrviRhetos.Osoba> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext PrviRhetos.Osoba*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.OIB != null && newItem.OIB.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Osoba.OIB", "256" },
                        "DataStructure:PrviRhetos.Osoba,ID:" + invalidItem.ID.ToString() + ",Property:OIB",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.BrojMobitela != null && newItem.BrojMobitela.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Osoba.BrojMobitela", "256" },
                        "DataStructure:PrviRhetos.Osoba,ID:" + invalidItem.ID.ToString() + ",Property:BrojMobitela",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation PrviRhetos.Osoba*/

            /*DataStructureInfo WritableOrm Initialization PrviRhetos.Osoba*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.PrviRhetos_Osoba> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.PrviRhetos_Osoba>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.PrviRhetos_Osoba> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.PrviRhetos_Osoba>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded PrviRhetos.Osoba*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.OIB == null || string.IsNullOrWhiteSpace(item.OIB) /*RequiredPropertyInfo OrCondition PrviRhetos.Osoba.OIB*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "PrviRhetos.Osoba", "OIB" },
                        "DataStructure:PrviRhetos.Osoba,ID:" + invalid.ID.ToString() + ",Property:OIB", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.DatumRodenja == null /*RequiredPropertyInfo OrCondition PrviRhetos.Osoba.DatumRodenja*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "PrviRhetos.Osoba", "DatumRodenja" },
                        "DataStructure:PrviRhetos.Osoba,ID:" + invalid.ID.ToString() + ",Property:DatumRodenja", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.GradRodenjaID == null /*RequiredPropertyInfo OrCondition PrviRhetos.Osoba.GradRodenja*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "PrviRhetos.Osoba", "GradRodenja" },
                        "DataStructure:PrviRhetos.Osoba,ID:" + invalid.ID.ToString() + ",Property:GradRodenjaID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.DrzavaRodenjaID == null /*RequiredPropertyInfo OrCondition PrviRhetos.Osoba.DrzavaRodenja*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "PrviRhetos.Osoba", "DrzavaRodenja" },
                        "DataStructure:PrviRhetos.Osoba,ID:" + invalid.ID.ToString() + ",Property:DrzavaRodenjaID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.GradStanovanjaID == null /*RequiredPropertyInfo OrCondition PrviRhetos.Osoba.GradStanovanja*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "PrviRhetos.Osoba", "GradStanovanja" },
                        "DataStructure:PrviRhetos.Osoba,ID:" + invalid.ID.ToString() + ",Property:GradStanovanjaID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Adresa == null || string.IsNullOrWhiteSpace(item.Adresa) /*RequiredPropertyInfo OrCondition PrviRhetos.Osoba.Adresa*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "PrviRhetos.Osoba", "Adresa" },
                        "DataStructure:PrviRhetos.Osoba,ID:" + invalid.ID.ToString() + ",Property:Adresa", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData PrviRhetos.Osoba*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.PrviRhetos_Osoba.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"PrviRhetos.Grad", @"ID", @"FK_Osoba_Grad_GradRodenjaID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:PrviRhetos.Osoba,Property:GradRodenjaID,Referenced:PrviRhetos.Grad";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"PrviRhetos.Drzava", @"ID", @"FK_Osoba_Drzava_DrzavaRodenjaID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:PrviRhetos.Osoba,Property:DrzavaRodenjaID,Referenced:PrviRhetos.Drzava";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"PrviRhetos.Grad", @"ID", @"FK_Osoba_Grad_GradStanovanjaID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:PrviRhetos.Osoba,Property:GradStanovanjaID,Referenced:PrviRhetos.Grad";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"PrviRhetos.Osoba", @"IX_Osoba_OIB_DrzavaRodenja"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:PrviRhetos.Osoba,Property:OIB DrzavaRodenja";
                /*DataStructureInfo WritableOrm OnDatabaseError PrviRhetos.Osoba*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "PrviRhetos.Osoba");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.PrviRhetos_Osoba> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 PrviRhetos.Osoba*/

                /*DataStructureInfo WritableOrm OnSaveTag2 PrviRhetos.Osoba*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "PrviRhetos.Osoba");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new Adresa_MinLengthFilter()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_Adresa__MinLengthFilter(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new PrviRhetos.OIB_RegExMatchFilter()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_OIB_RegExMatchFilter(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate PrviRhetos.Osoba*/
            yield break;
        }

        public global::PrviRhetos.Osoba CreateInstance()
        {
            var _item = new global::PrviRhetos.Osoba();
            /*DataStructureInfo CreateInstance PrviRhetos.Osoba*/
            return _item;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_Adresa__MinLengthFilter(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Minimum allowed length of {0} is {1} characters.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"Adresa_MinLengthFilter";
            metadata[@"Property"] = @"Adresa";
            /*InvalidDataInfo ErrorMetadata PrviRhetos.Osoba.Adresa_MinLengthFilter*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Adresa", 4 },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages PrviRhetos.Osoba.Adresa_MinLengthFilter*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.PrviRhetos_Osoba> Filter(IQueryable<Common.Queryable.PrviRhetos_Osoba> localSource, PrviRhetos.OIB_RegExMatchFilter localParameter)
        {
            Func<IQueryable<Common.Queryable.PrviRhetos_Osoba>, Common.DomRepository, PrviRhetos.OIB_RegExMatchFilter/*ComposableFilterByInfo AdditionalParametersType PrviRhetos.Osoba.'PrviRhetos.OIB_RegExMatchFilter'*/, IQueryable<Common.Queryable.PrviRhetos_Osoba>> filterFunction =
            (source, repository, parameter) =>
                {
                    var items = source.Where(item => !string.IsNullOrEmpty(item.OIB)).Select(item => new { item.ID, item.OIB }).ToList();
                    var regex = new System.Text.RegularExpressions.Regex(@"^\\d{13}$");
                    var invalidItemIds = items.Where(item => !regex.IsMatch(item.OIB)).Select(item => item.ID).ToList();
                    return Filter(source, invalidItemIds);
                };

            /*ComposableFilterByInfo BeforeFilter PrviRhetos.Osoba.'PrviRhetos.OIB_RegExMatchFilter'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument PrviRhetos.Osoba.'PrviRhetos.OIB_RegExMatchFilter'*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_OIB_RegExMatchFilter(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"Property {0} does not match required format.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"PrviRhetos.OIB_RegExMatchFilter";
            metadata[@"Property"] = @"OIB";
            /*InvalidDataInfo ErrorMetadata PrviRhetos.Osoba.'PrviRhetos.OIB_RegExMatchFilter'*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"OIB" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages PrviRhetos.Osoba.'PrviRhetos.OIB_RegExMatchFilter'*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.PrviRhetos_Osoba> Filter(IQueryable<Common.Queryable.PrviRhetos_Osoba> localSource, PrviRhetos.Adresa_MinLengthFilter localParameter)
        {
            Func<IQueryable<Common.Queryable.PrviRhetos_Osoba>, Common.DomRepository, PrviRhetos.Adresa_MinLengthFilter/*ComposableFilterByInfo AdditionalParametersType PrviRhetos.Osoba.'PrviRhetos.Adresa_MinLengthFilter'*/, IQueryable<Common.Queryable.PrviRhetos_Osoba>> filterFunction =
            (source, repository, parameter) => source.Where(item => !String.IsNullOrEmpty(item.Adresa) && item.Adresa.Length < 4);

            /*ComposableFilterByInfo BeforeFilter PrviRhetos.Osoba.'PrviRhetos.Adresa_MinLengthFilter'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument PrviRhetos.Osoba.'PrviRhetos.Adresa_MinLengthFilter'*/);
        }

        public global::PrviRhetos.Osoba[] Filter(PrviRhetos.OIB_RegExMatchFilter filter_Parameter)
        {
            Func<Common.DomRepository, PrviRhetos.OIB_RegExMatchFilter/*FilterByInfo AdditionalParametersType PrviRhetos.Osoba.'PrviRhetos.OIB_RegExMatchFilter'*/, PrviRhetos.Osoba[]> filter_Function =
                (repository, parameter) => repository.PrviRhetos.Osoba.Filter(repository.PrviRhetos.Osoba.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument PrviRhetos.Osoba.'PrviRhetos.OIB_RegExMatchFilter'*/);
        }

        public global::PrviRhetos.Osoba[] Filter(PrviRhetos.Adresa_MinLengthFilter filter_Parameter)
        {
            Func<Common.DomRepository, PrviRhetos.Adresa_MinLengthFilter/*FilterByInfo AdditionalParametersType PrviRhetos.Osoba.'PrviRhetos.Adresa_MinLengthFilter'*/, PrviRhetos.Osoba[]> filter_Function =
                (repository, parameter) => repository.PrviRhetos.Osoba.Filter(repository.PrviRhetos.Osoba.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument PrviRhetos.Osoba.'PrviRhetos.Adresa_MinLengthFilter'*/);
        }

        /*DataStructureInfo RepositoryMembers PrviRhetos.Osoba*/
    }

    /*ModuleInfo HelperNamespaceMembers PrviRhetos*/
}

namespace Common._Helper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;

    /*ModuleInfo Using Common*/

    public class _ModuleRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public _ModuleRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private AutoCodeCache_Repository _AutoCodeCache_Repository;
        public AutoCodeCache_Repository AutoCodeCache { get { return _AutoCodeCache_Repository ?? (_AutoCodeCache_Repository = (AutoCodeCache_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.AutoCodeCache")); } }

        private FilterId_Repository _FilterId_Repository;
        public FilterId_Repository FilterId { get { return _FilterId_Repository ?? (_FilterId_Repository = (FilterId_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.FilterId")); } }

        private KeepSynchronizedMetadata_Repository _KeepSynchronizedMetadata_Repository;
        public KeepSynchronizedMetadata_Repository KeepSynchronizedMetadata { get { return _KeepSynchronizedMetadata_Repository ?? (_KeepSynchronizedMetadata_Repository = (KeepSynchronizedMetadata_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.KeepSynchronizedMetadata")); } }

        private ExclusiveLock_Repository _ExclusiveLock_Repository;
        public ExclusiveLock_Repository ExclusiveLock { get { return _ExclusiveLock_Repository ?? (_ExclusiveLock_Repository = (ExclusiveLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.ExclusiveLock")); } }

        private SetLock_Repository _SetLock_Repository;
        public SetLock_Repository SetLock { get { return _SetLock_Repository ?? (_SetLock_Repository = (SetLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.SetLock")); } }

        private ReleaseLock_Repository _ReleaseLock_Repository;
        public ReleaseLock_Repository ReleaseLock { get { return _ReleaseLock_Repository ?? (_ReleaseLock_Repository = (ReleaseLock_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.ReleaseLock")); } }

        private LogReader_Repository _LogReader_Repository;
        public LogReader_Repository LogReader { get { return _LogReader_Repository ?? (_LogReader_Repository = (LogReader_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogReader")); } }

        private LogRelatedItemReader_Repository _LogRelatedItemReader_Repository;
        public LogRelatedItemReader_Repository LogRelatedItemReader { get { return _LogRelatedItemReader_Repository ?? (_LogRelatedItemReader_Repository = (LogRelatedItemReader_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogRelatedItemReader")); } }

        private Log_Repository _Log_Repository;
        public Log_Repository Log { get { return _Log_Repository ?? (_Log_Repository = (Log_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Log")); } }

        private AddToLog_Repository _AddToLog_Repository;
        public AddToLog_Repository AddToLog { get { return _AddToLog_Repository ?? (_AddToLog_Repository = (AddToLog_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.AddToLog")); } }

        private LogRelatedItem_Repository _LogRelatedItem_Repository;
        public LogRelatedItem_Repository LogRelatedItem { get { return _LogRelatedItem_Repository ?? (_LogRelatedItem_Repository = (LogRelatedItem_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.LogRelatedItem")); } }

        private RelatedEventsSource_Repository _RelatedEventsSource_Repository;
        public RelatedEventsSource_Repository RelatedEventsSource { get { return _RelatedEventsSource_Repository ?? (_RelatedEventsSource_Repository = (RelatedEventsSource_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RelatedEventsSource")); } }

        private Claim_Repository _Claim_Repository;
        public Claim_Repository Claim { get { return _Claim_Repository ?? (_Claim_Repository = (Claim_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Claim")); } }

        private MyClaim_Repository _MyClaim_Repository;
        public MyClaim_Repository MyClaim { get { return _MyClaim_Repository ?? (_MyClaim_Repository = (MyClaim_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.MyClaim")); } }

        private Principal_Repository _Principal_Repository;
        public Principal_Repository Principal { get { return _Principal_Repository ?? (_Principal_Repository = (Principal_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Principal")); } }

        private PrincipalHasRole_Repository _PrincipalHasRole_Repository;
        public PrincipalHasRole_Repository PrincipalHasRole { get { return _PrincipalHasRole_Repository ?? (_PrincipalHasRole_Repository = (PrincipalHasRole_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.PrincipalHasRole")); } }

        private Role_Repository _Role_Repository;
        public Role_Repository Role { get { return _Role_Repository ?? (_Role_Repository = (Role_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.Role")); } }

        private RoleInheritsRole_Repository _RoleInheritsRole_Repository;
        public RoleInheritsRole_Repository RoleInheritsRole { get { return _RoleInheritsRole_Repository ?? (_RoleInheritsRole_Repository = (RoleInheritsRole_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RoleInheritsRole")); } }

        private PrincipalPermission_Repository _PrincipalPermission_Repository;
        public PrincipalPermission_Repository PrincipalPermission { get { return _PrincipalPermission_Repository ?? (_PrincipalPermission_Repository = (PrincipalPermission_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.PrincipalPermission")); } }

        private RolePermission_Repository _RolePermission_Repository;
        public RolePermission_Repository RolePermission { get { return _RolePermission_Repository ?? (_RolePermission_Repository = (RolePermission_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.RolePermission")); } }

        private AuditRelatedEvents_Repository _AuditRelatedEvents_Repository;
        public AuditRelatedEvents_Repository AuditRelatedEvents { get { return _AuditRelatedEvents_Repository ?? (_AuditRelatedEvents_Repository = (AuditRelatedEvents_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.AuditRelatedEvents")); } }

        private AuditDataModifications_Repository _AuditDataModifications_Repository;
        public AuditDataModifications_Repository AuditDataModifications { get { return _AuditDataModifications_Repository ?? (_AuditDataModifications_Repository = (AuditDataModifications_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.AuditDataModifications")); } }

        private ReportTemplate_Repository _ReportTemplate_Repository;
        public ReportTemplate_Repository ReportTemplate { get { return _ReportTemplate_Repository ?? (_ReportTemplate_Repository = (ReportTemplate_Repository)Rhetos.Extensibility.NamedPluginsExtensions.GetPlugin(_repositories, @"Common.ReportTemplate")); } }

        /*ModuleInfo RepositoryMembers Common*/
    }

    /*DataStructureInfo RepositoryAttributes Common.AutoCodeCache*/
    public class AutoCodeCache_Repository : /*DataStructureInfo OverrideBaseType Common.AutoCodeCache*/ Common.OrmRepositoryBase<Common.Queryable.Common_AutoCodeCache, Common.AutoCodeCache> // Common.QueryableRepositoryBase<Common.Queryable.Common_AutoCodeCache, Common.AutoCodeCache> // Common.ReadableRepositoryBase<Common.AutoCodeCache> // global::Common.RepositoryBase
        , IWritableRepository<Common.AutoCodeCache>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.AutoCodeCache*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.AutoCodeCache*/

        public AutoCodeCache_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.AutoCodeCache*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.AutoCodeCache*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.AutoCodeCache[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_AutoCodeCache> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.AutoCodeCache*/
            return _executionContext.EntityFrameworkContext.Common_AutoCodeCache.AsNoTracking();
        }

        public void Save(IEnumerable<Common.AutoCodeCache> insertedNew, IEnumerable<Common.AutoCodeCache> updatedNew, IEnumerable<Common.AutoCodeCache> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.AutoCodeCache*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Entity != null && newItem.Entity.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Entity", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Entity",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Property != null && newItem.Property.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Property", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Property",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Grouping != null && newItem.Grouping.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Grouping", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Grouping",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Prefix != null && newItem.Prefix.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "AutoCodeCache.Prefix", "256" },
                        "DataStructure:Common.AutoCodeCache,ID:" + invalidItem.ID.ToString() + ",Property:Prefix",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.AutoCodeCache*/

            /*DataStructureInfo WritableOrm Initialization Common.AutoCodeCache*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_AutoCodeCache> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_AutoCodeCache>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_AutoCodeCache> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_AutoCodeCache>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.AutoCodeCache*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.AutoCodeCache*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_AutoCodeCache.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.AutoCodeCache", @"IX_AutoCodeCache_Entity_Property_Grouping_Prefix"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.AutoCodeCache,Property:Entity Property Grouping Prefix";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.AutoCodeCache*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.AutoCodeCache");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_AutoCodeCache> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.AutoCodeCache*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.AutoCodeCache*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.AutoCodeCache");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.AutoCodeCache*/
            yield break;
        }

        public global::Common.AutoCodeCache CreateInstance()
        {
            var _item = new global::Common.AutoCodeCache();
            /*DataStructureInfo CreateInstance Common.AutoCodeCache*/
            return _item;
        }

        /*DataStructureInfo RepositoryMembers Common.AutoCodeCache*/
    }

    /*DataStructureInfo RepositoryAttributes Common.FilterId*/
    public class FilterId_Repository : /*DataStructureInfo OverrideBaseType Common.FilterId*/ Common.OrmRepositoryBase<Common.Queryable.Common_FilterId, Common.FilterId> // Common.QueryableRepositoryBase<Common.Queryable.Common_FilterId, Common.FilterId> // Common.ReadableRepositoryBase<Common.FilterId> // global::Common.RepositoryBase
        , IWritableRepository<Common.FilterId>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.FilterId*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.FilterId*/

        public FilterId_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.FilterId*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.FilterId*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.FilterId[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_FilterId> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.FilterId*/
            return _executionContext.EntityFrameworkContext.Common_FilterId.AsNoTracking();
        }

        public void Save(IEnumerable<Common.FilterId> insertedNew, IEnumerable<Common.FilterId> updatedNew, IEnumerable<Common.FilterId> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.FilterId*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.FilterId*/

            /*DataStructureInfo WritableOrm Initialization Common.FilterId*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_FilterId> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_FilterId>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_FilterId> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_FilterId>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.FilterId*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.FilterId*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_FilterId.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		/*DataStructureInfo WritableOrm OnDatabaseError Common.FilterId*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.FilterId");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_FilterId> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.FilterId*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.FilterId*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.FilterId");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.FilterId*/
            yield break;
        }

        /// <summary>
        /// Depending on the ids count, this method will return the list of IDs, or insert the ids to the database and return an SQL query that selects the ids.
        /// EF 6.1.3 has performance issues on Contains function with large lists. It seems to have O(n^2) time complexity.
        /// </summary>
        public IEnumerable<Guid> CreateQueryableFilterIds(IEnumerable<Guid> ids)
        {
            Rhetos.Utilities.CsUtility.Materialize(ref ids);

            if (ids.Count() < 200)
                return ids;

            var handle = Guid.NewGuid();
            string sqlInsertIdFormat = "INSERT INTO Common.FilterId (Handle, Value) VALUES ('" + SqlUtility.GuidToString(handle) + "', '{0}');";

            const int chunkSize = 1000; // Keeping a moderate SQL script size.
            for (int start = 0; start < ids.Count(); start += chunkSize)
            {
                string sqlInsertIds = string.Join("\r\n", ids.Skip(start).Take(chunkSize)
                        .Select(id => string.Format(sqlInsertIdFormat, SqlUtility.GuidToString(id))));
                _executionContext.SqlExecuter.ExecuteSql(sqlInsertIds);
            }

            // Delete temporary data when closing the connection. The data must remain in the database until the returned query is used.
            string deleteFilterIds = "DELETE FROM Common.FilterId WHERE Handle = " + SqlUtility.QuoteGuid(handle);
            _executionContext.PersistenceTransaction.BeforeClose += () =>
                {
                    try
                    {
                        _executionContext.SqlExecuter.ExecuteSql(deleteFilterIds);
                    }
                    catch
                    {
                        // Cleanup error may be ignored. The temporary data may be deleted on regular maintenance.
                    }
                };

            return Query().Where(filterId => filterId.Handle == handle).Select(filterId => filterId.Value.Value);
        }

        public global::Common.FilterId CreateInstance()
        {
            var _item = new global::Common.FilterId();
            /*DataStructureInfo CreateInstance Common.FilterId*/
            return _item;
        }

        /*DataStructureInfo RepositoryMembers Common.FilterId*/
    }

    /*DataStructureInfo RepositoryAttributes Common.KeepSynchronizedMetadata*/
    public class KeepSynchronizedMetadata_Repository : /*DataStructureInfo OverrideBaseType Common.KeepSynchronizedMetadata*/ Common.OrmRepositoryBase<Common.Queryable.Common_KeepSynchronizedMetadata, Common.KeepSynchronizedMetadata> // Common.QueryableRepositoryBase<Common.Queryable.Common_KeepSynchronizedMetadata, Common.KeepSynchronizedMetadata> // Common.ReadableRepositoryBase<Common.KeepSynchronizedMetadata> // global::Common.RepositoryBase
        , IWritableRepository<Common.KeepSynchronizedMetadata>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.KeepSynchronizedMetadata*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.KeepSynchronizedMetadata*/

        public KeepSynchronizedMetadata_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.KeepSynchronizedMetadata*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.KeepSynchronizedMetadata*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.KeepSynchronizedMetadata[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_KeepSynchronizedMetadata> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.KeepSynchronizedMetadata*/
            return _executionContext.EntityFrameworkContext.Common_KeepSynchronizedMetadata.AsNoTracking();
        }

        public void Save(IEnumerable<Common.KeepSynchronizedMetadata> insertedNew, IEnumerable<Common.KeepSynchronizedMetadata> updatedNew, IEnumerable<Common.KeepSynchronizedMetadata> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.KeepSynchronizedMetadata*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Target != null && newItem.Target.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "KeepSynchronizedMetadata.Target", "256" },
                        "DataStructure:Common.KeepSynchronizedMetadata,ID:" + invalidItem.ID.ToString() + ",Property:Target",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Source != null && newItem.Source.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "KeepSynchronizedMetadata.Source", "256" },
                        "DataStructure:Common.KeepSynchronizedMetadata,ID:" + invalidItem.ID.ToString() + ",Property:Source",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.KeepSynchronizedMetadata*/

            /*DataStructureInfo WritableOrm Initialization Common.KeepSynchronizedMetadata*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_KeepSynchronizedMetadata>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_KeepSynchronizedMetadata>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.KeepSynchronizedMetadata*/

            /*DataStructureInfo WritableOrm ProcessedOldData Common.KeepSynchronizedMetadata*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_KeepSynchronizedMetadata.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		/*DataStructureInfo WritableOrm OnDatabaseError Common.KeepSynchronizedMetadata*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.KeepSynchronizedMetadata");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_KeepSynchronizedMetadata> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.KeepSynchronizedMetadata*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.KeepSynchronizedMetadata*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.KeepSynchronizedMetadata");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.KeepSynchronizedMetadata*/
            yield break;
        }

        public global::Common.KeepSynchronizedMetadata CreateInstance()
        {
            var _item = new global::Common.KeepSynchronizedMetadata();
            /*DataStructureInfo CreateInstance Common.KeepSynchronizedMetadata*/
            return _item;
        }

        /*DataStructureInfo RepositoryMembers Common.KeepSynchronizedMetadata*/
    }

    /*DataStructureInfo RepositoryAttributes Common.ExclusiveLock*/
    public class ExclusiveLock_Repository : /*DataStructureInfo OverrideBaseType Common.ExclusiveLock*/ Common.OrmRepositoryBase<Common.Queryable.Common_ExclusiveLock, Common.ExclusiveLock> // Common.QueryableRepositoryBase<Common.Queryable.Common_ExclusiveLock, Common.ExclusiveLock> // Common.ReadableRepositoryBase<Common.ExclusiveLock> // global::Common.RepositoryBase
        , IWritableRepository<Common.ExclusiveLock>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.ExclusiveLock*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.ExclusiveLock*/

        public ExclusiveLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.ExclusiveLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.ExclusiveLock*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.ExclusiveLock[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_ExclusiveLock> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.ExclusiveLock*/
            return _executionContext.EntityFrameworkContext.Common_ExclusiveLock.AsNoTracking();
        }

        public void Save(IEnumerable<Common.ExclusiveLock> insertedNew, IEnumerable<Common.ExclusiveLock> updatedNew, IEnumerable<Common.ExclusiveLock> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.ExclusiveLock*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ResourceType != null && newItem.ResourceType.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ExclusiveLock.ResourceType", "256" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalidItem.ID.ToString() + ",Property:ResourceType",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.UserName != null && newItem.UserName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ExclusiveLock.UserName", "256" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalidItem.ID.ToString() + ",Property:UserName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Workstation != null && newItem.Workstation.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ExclusiveLock.Workstation", "256" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalidItem.ID.ToString() + ",Property:Workstation",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.ExclusiveLock*/

            /*DataStructureInfo WritableOrm Initialization Common.ExclusiveLock*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_ExclusiveLock> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_ExclusiveLock>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_ExclusiveLock> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_ExclusiveLock>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.ExclusiveLock*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ResourceType == null || string.IsNullOrWhiteSpace(item.ResourceType) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.ResourceType*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "ResourceType" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:ResourceType", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ResourceID == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.ResourceID*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "ResourceID" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:ResourceID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UserName == null || string.IsNullOrWhiteSpace(item.UserName) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.UserName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "UserName" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:UserName", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Workstation == null || string.IsNullOrWhiteSpace(item.Workstation) /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.Workstation*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "Workstation" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:Workstation", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LockStart == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.LockStart*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "LockStart" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:LockStart", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LockFinish == null /*RequiredPropertyInfo OrCondition Common.ExclusiveLock.LockFinish*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ExclusiveLock", "LockFinish" },
                        "DataStructure:Common.ExclusiveLock,ID:" + invalid.ID.ToString() + ",Property:LockFinish", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.ExclusiveLock*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_ExclusiveLock.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.ExclusiveLock", @"IX_ExclusiveLock_ResourceID_ResourceType"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.ExclusiveLock,Property:ResourceID ResourceType";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.ExclusiveLock*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.ExclusiveLock");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_ExclusiveLock> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.ExclusiveLock*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.ExclusiveLock*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.ExclusiveLock");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.ExclusiveLock*/
            yield break;
        }

        public global::Common.ExclusiveLock CreateInstance()
        {
            var _item = new global::Common.ExclusiveLock();
            /*DataStructureInfo CreateInstance Common.ExclusiveLock*/
            return _item;
        }

        /*DataStructureInfo RepositoryMembers Common.ExclusiveLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.SetLock*/
    public class SetLock_Repository : /*DataStructureInfo OverrideBaseType Common.SetLock*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.SetLock*/
    {
        private readonly Rhetos.Utilities.ILocalizer _localizer;
        /*DataStructureInfo RepositoryPrivateMembers Common.SetLock*/

        public SetLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ILocalizer _localizer/*DataStructureInfo RepositoryConstructorArguments Common.SetLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._localizer = _localizer;
            /*DataStructureInfo RepositoryConstructorCode Common.SetLock*/
        }

        public void Execute(Common.SetLock actionParameter)
        {
            Action<Common.SetLock, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Common.SetLock*/> action_Object = (parameters, repository, userInfo) =>
        {
            var oldLock = repository.Common.ExclusiveLock.Query()
                .Where(itemLock =>
                    itemLock.ResourceType == parameters.ResourceType
                    && itemLock.ResourceID == parameters.ResourceID)
                .FirstOrDefault();
            
            if (oldLock == null)
                repository.Common.ExclusiveLock.Insert(new[] { new Common.ExclusiveLock
                    {
                        UserName = userInfo.UserName,
                        Workstation = userInfo.Workstation,
                        ResourceType = parameters.ResourceType,
                        ResourceID = parameters.ResourceID,
                        LockStart = DateTime.Now,
                        LockFinish = DateTime.Now.AddMinutes(15)
                    }});
            else if (oldLock.UserName == userInfo.UserName
                && oldLock.Workstation == userInfo.Workstation
                || oldLock.LockFinish < DateTime.Now)
                repository.Common.ExclusiveLock.Update(new[] { new Common.ExclusiveLock
                    {
                        ID = oldLock.ID,
                        UserName = userInfo.UserName,
                        Workstation = userInfo.Workstation,
                        ResourceType = parameters.ResourceType,
                        ResourceID = parameters.ResourceID,
                        LockStart = DateTime.Now,
                        LockFinish = DateTime.Now.AddMinutes(15)
                    }});
             else
             {
                string lockInfo = _localizer["Locked record {0}, ID {1}.", oldLock.ResourceType, oldLock.ResourceID];

                string errorInfo;
                if (oldLock.UserName.Equals(userInfo.UserName, StringComparison.InvariantCultureIgnoreCase))
                    errorInfo = _localizer["It is not allowed to enter the record at client workstation '{0}' because the data entry is in progress at workstation '{1}'.",
                        userInfo.Workstation, oldLock.Workstation];
                else
                    errorInfo = _localizer["It is not allowed to enter the record because the data entry is in progress by user '{0}'.",
                        oldLock.UserName];
                
                string localizedMessage = errorInfo + "\r\n" + lockInfo;
                throw new Rhetos.UserException(localizedMessage);
             }
        };

            /*ActionInfo BeforeAction Common.SetLock*/
            action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Common.SetLock*/);
            /*ActionInfo AfterAction Common.SetLock*/
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.SetLock) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.SetLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.ReleaseLock*/
    public class ReleaseLock_Repository : /*DataStructureInfo OverrideBaseType Common.ReleaseLock*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.ReleaseLock*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.ReleaseLock*/

        public ReleaseLock_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.ReleaseLock*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.ReleaseLock*/
        }

        public void Execute(Common.ReleaseLock actionParameter)
        {
            Action<Common.ReleaseLock, Common.DomRepository, IUserInfo/*DataStructureInfo AdditionalParametersType Common.ReleaseLock*/> action_Object = (parameters, repository, userInfo) =>
        {
            var myLock = repository.Common.ExclusiveLock.Query()
                .Where(itemLock =>
                    itemLock.ResourceType == parameters.ResourceType
                    && itemLock.ResourceID == parameters.ResourceID
                    && itemLock.UserName == userInfo.UserName
                    && itemLock.Workstation == userInfo.Workstation)
                .FirstOrDefault();

            if (myLock != null)
                repository.Common.ExclusiveLock.Delete(new[] { myLock });
        };

            /*ActionInfo BeforeAction Common.ReleaseLock*/
            action_Object(actionParameter, _domRepository, _executionContext.UserInfo/*DataStructureInfo AdditionalParametersArgument Common.ReleaseLock*/);
            /*ActionInfo AfterAction Common.ReleaseLock*/
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.ReleaseLock) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.ReleaseLock*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogReader*/
    public class LogReader_Repository : /*DataStructureInfo OverrideBaseType Common.LogReader*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogReader, Common.LogReader> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogReader, Common.LogReader> // Common.ReadableRepositoryBase<Common.LogReader> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.LogReader*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.LogReader*/

        public LogReader_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.LogReader*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.LogReader*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.LogReader[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_LogReader> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.LogReader*/
            return _executionContext.EntityFrameworkContext.Common_LogReader.AsNoTracking();
        }

        public IQueryable<Common.Queryable.Common_LogReader> Filter(IQueryable<Common.Queryable.Common_LogReader> localSource, LoggedItem localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_LogReader>, Common.DomRepository, LoggedItem/*ComposableFilterByInfo AdditionalParametersType Common.LogReader.LoggedItem*/, IQueryable<Common.Queryable.Common_LogReader>> filterFunction =
            (items, repository, parameter) => items
        .Where(item => item.TableName == parameter.TableName && item.ItemId == parameter.ItemId)
        .OrderByDescending(item => item.Created)
        .ThenBy(item => item.ID);

            /*ComposableFilterByInfo BeforeFilter Common.LogReader.LoggedItem*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.LogReader.LoggedItem*/);
        }

        public IQueryable<Common.Queryable.Common_LogReader> Filter(IQueryable<Common.Queryable.Common_LogReader> localSource, DeletedItems localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_LogReader>, Common.DomRepository, DeletedItems/*ComposableFilterByInfo AdditionalParametersType Common.LogReader.DeletedItems*/, IQueryable<Common.Queryable.Common_LogReader>> filterFunction =
            (items, repository, parameter) => items
        .Where(item => item.TableName == parameter.TableName && item.Action == "Delete")
        .OrderByDescending(item => item.Created)
        .ThenBy(item => item.ID);

            /*ComposableFilterByInfo BeforeFilter Common.LogReader.DeletedItems*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.LogReader.DeletedItems*/);
        }

        public global::Common.LogReader[] Filter(LoggedItem filter_Parameter)
        {
            Func<Common.DomRepository, LoggedItem/*FilterByInfo AdditionalParametersType Common.LogReader.LoggedItem*/, Common.LogReader[]> filter_Function =
                (repository, parameter) => repository.Common.LogReader.Filter(repository.Common.LogReader.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.LogReader.LoggedItem*/);
        }

        public global::Common.LogReader[] Filter(DeletedItems filter_Parameter)
        {
            Func<Common.DomRepository, DeletedItems/*FilterByInfo AdditionalParametersType Common.LogReader.DeletedItems*/, Common.LogReader[]> filter_Function =
                (repository, parameter) => repository.Common.LogReader.Filter(repository.Common.LogReader.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.LogReader.DeletedItems*/);
        }

        /*DataStructureInfo RepositoryMembers Common.LogReader*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogRelatedItemReader*/
    public class LogRelatedItemReader_Repository : /*DataStructureInfo OverrideBaseType Common.LogRelatedItemReader*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogRelatedItemReader, Common.LogRelatedItemReader> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogRelatedItemReader, Common.LogRelatedItemReader> // Common.ReadableRepositoryBase<Common.LogRelatedItemReader> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.LogRelatedItemReader*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.LogRelatedItemReader*/

        public LogRelatedItemReader_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.LogRelatedItemReader*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.LogRelatedItemReader*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.LogRelatedItemReader[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_LogRelatedItemReader> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.LogRelatedItemReader*/
            return _executionContext.EntityFrameworkContext.Common_LogRelatedItemReader.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Common.LogRelatedItemReader*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Log*/
    public class Log_Repository : /*DataStructureInfo OverrideBaseType Common.Log*/ Common.OrmRepositoryBase<Common.Queryable.Common_Log, Common.Log> // Common.QueryableRepositoryBase<Common.Queryable.Common_Log, Common.Log> // Common.ReadableRepositoryBase<Common.Log> // global::Common.RepositoryBase
        , IWritableRepository<Common.Log>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Log*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Log*/

        public Log_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Log*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Log*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Log[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Log> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Log*/
            return _executionContext.EntityFrameworkContext.Common_Log.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Log> insertedNew, IEnumerable<Common.Log> updatedNew, IEnumerable<Common.Log> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Log*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.UserName != null && newItem.UserName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.UserName", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:UserName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Workstation != null && newItem.Workstation.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.Workstation", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:Workstation",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ContextInfo != null && newItem.ContextInfo.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.ContextInfo", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:ContextInfo",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Action != null && newItem.Action.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.Action", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:Action",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.TableName != null && newItem.TableName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Log.TableName", "256" },
                        "DataStructure:Common.Log,ID:" + invalidItem.ID.ToString() + ",Property:TableName",
                        null);
            }
            if (checkUserPermissions)
                throw new Rhetos.UserException(
                    "It is not allowed to directly modify {0}.", new[] { "Common.Log" }, null, null);
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Log*/

            /*DataStructureInfo WritableOrm Initialization Common.Log*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_Log> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Log>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_Log> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Log>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Common.LogRelatedItem> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.LogRelatedItem.Query()
                        .Where(child => child.LogID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.LogRelatedItem { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.LogRelatedItem.Delete(childItems);
            }
            /*DataStructureInfo WritableOrm OldDataLoaded Common.Log*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Created == null /*RequiredPropertyInfo OrCondition Common.Log.Created*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Created" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Created", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UserName == null || string.IsNullOrWhiteSpace(item.UserName) /*RequiredPropertyInfo OrCondition Common.Log.UserName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "UserName" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:UserName", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Workstation == null || string.IsNullOrWhiteSpace(item.Workstation) /*RequiredPropertyInfo OrCondition Common.Log.Workstation*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Workstation" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Workstation", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Action == null || string.IsNullOrWhiteSpace(item.Action) /*RequiredPropertyInfo OrCondition Common.Log.Action*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Log", "Action" },
                        "DataStructure:Common.Log,ID:" + invalid.ID.ToString() + ",Property:Action", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Log*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Log.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.LogRelatedItem", @"LogID", @"FK_LogRelatedItem_Log_LogID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.LogRelatedItem,Property:LogID,Referenced:Common.Log";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Log*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Log");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Log> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Log*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Log*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Log");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Log*/
            yield break;
        }

        public global::Common.Log CreateInstance()
        {
            var _item = new global::Common.Log();
            /*DataStructureInfo CreateInstance Common.Log*/
            return _item;
        }

        /*DataStructureInfo RepositoryMembers Common.Log*/
    }

    /*DataStructureInfo RepositoryAttributes Common.AddToLog*/
    public class AddToLog_Repository : /*DataStructureInfo OverrideBaseType Common.AddToLog*/ global::Common.RepositoryBase
        , IActionRepository/*DataStructureInfo RepositoryInterface Common.AddToLog*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.AddToLog*/

        public AddToLog_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.AddToLog*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.AddToLog*/
        }

        public void Execute(Common.AddToLog actionParameter)
        {
            Action<Common.AddToLog, Common.DomRepository, IUserInfo, Common.ExecutionContext/*DataStructureInfo AdditionalParametersType Common.AddToLog*/> action_Object = (parameter, repository, userInfo, context) =>
		{
			if (parameter.Action == null)
				throw new Rhetos.UserException("Parameter Action is required.");
			string sql = @"INSERT INTO Common.Log (Action, TableName, ItemId, Description)
                SELECT @p0, @p1, @p2, @p3";
			context.EntityFrameworkContext.Database.ExecuteSqlCommand(sql,
				parameter.Action,
				parameter.TableName,
				parameter.ItemId,
				parameter.Description);
		};

            /*ActionInfo BeforeAction Common.AddToLog*/
            action_Object(actionParameter, _domRepository, _executionContext.UserInfo, _executionContext/*DataStructureInfo AdditionalParametersArgument Common.AddToLog*/);
            /*ActionInfo AfterAction Common.AddToLog*/
        }

        void IActionRepository.Execute(object actionParameter)
        {
            Execute((Common.AddToLog) actionParameter);
        }

        /*DataStructureInfo RepositoryMembers Common.AddToLog*/
    }

    /*DataStructureInfo RepositoryAttributes Common.LogRelatedItem*/
    public class LogRelatedItem_Repository : /*DataStructureInfo OverrideBaseType Common.LogRelatedItem*/ Common.OrmRepositoryBase<Common.Queryable.Common_LogRelatedItem, Common.LogRelatedItem> // Common.QueryableRepositoryBase<Common.Queryable.Common_LogRelatedItem, Common.LogRelatedItem> // Common.ReadableRepositoryBase<Common.LogRelatedItem> // global::Common.RepositoryBase
        , IWritableRepository<Common.LogRelatedItem>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.LogRelatedItem*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.LogRelatedItem*/

        public LogRelatedItem_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.LogRelatedItem*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.LogRelatedItem*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.LogRelatedItem[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_LogRelatedItem> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.LogRelatedItem*/
            return _executionContext.EntityFrameworkContext.Common_LogRelatedItem.AsNoTracking();
        }

        public void Save(IEnumerable<Common.LogRelatedItem> insertedNew, IEnumerable<Common.LogRelatedItem> updatedNew, IEnumerable<Common.LogRelatedItem> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.LogRelatedItem*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.TableName != null && newItem.TableName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "LogRelatedItem.TableName", "256" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalidItem.ID.ToString() + ",Property:TableName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Relation != null && newItem.Relation.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "LogRelatedItem.Relation", "256" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalidItem.ID.ToString() + ",Property:Relation",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.LogRelatedItem*/

            /*DataStructureInfo WritableOrm Initialization Common.LogRelatedItem*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_LogRelatedItem> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_LogRelatedItem>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_LogRelatedItem> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_LogRelatedItem>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.LogRelatedItem*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.LogID == null /*RequiredPropertyInfo OrCondition Common.LogRelatedItem.Log*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.LogRelatedItem", "Log" },
                        "DataStructure:Common.LogRelatedItem,ID:" + invalid.ID.ToString() + ",Property:LogID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.LogRelatedItem*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_LogRelatedItem.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Log", @"ID", @"FK_LogRelatedItem_Log_LogID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.LogRelatedItem,Property:LogID,Referenced:Common.Log";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.LogRelatedItem*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.LogRelatedItem");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_LogRelatedItem> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.LogRelatedItem*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.LogRelatedItem*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.LogRelatedItem");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredLog()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredLog(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.LogRelatedItem*/
            yield break;
        }

        public global::Common.LogRelatedItem CreateInstance()
        {
            var _item = new global::Common.LogRelatedItem();
            /*DataStructureInfo CreateInstance Common.LogRelatedItem*/
            return _item;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredLog(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredLog";
            metadata[@"Property"] = @"Log";
            /*InvalidDataInfo ErrorMetadata Common.LogRelatedItem.SystemRequiredLog*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.LogRelatedItem.Log" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.LogRelatedItem.SystemRequiredLog*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_LogRelatedItem> Filter(IQueryable<Common.Queryable.Common_LogRelatedItem> localSource, Common.SystemRequiredLog localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_LogRelatedItem>, Common.DomRepository, Common.SystemRequiredLog/*ComposableFilterByInfo AdditionalParametersType Common.LogRelatedItem.'Common.SystemRequiredLog'*/, IQueryable<Common.Queryable.Common_LogRelatedItem>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Log == null);

            /*ComposableFilterByInfo BeforeFilter Common.LogRelatedItem.'Common.SystemRequiredLog'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.LogRelatedItem.'Common.SystemRequiredLog'*/);
        }

        public global::Common.LogRelatedItem[] Filter(Common.SystemRequiredLog filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredLog/*FilterByInfo AdditionalParametersType Common.LogRelatedItem.'Common.SystemRequiredLog'*/, Common.LogRelatedItem[]> filter_Function =
                (repository, parameter) => repository.Common.LogRelatedItem.Filter(repository.Common.LogRelatedItem.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.LogRelatedItem.'Common.SystemRequiredLog'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.LogRelatedItem*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RelatedEventsSource*/
    public class RelatedEventsSource_Repository : /*DataStructureInfo OverrideBaseType Common.RelatedEventsSource*/ Common.OrmRepositoryBase<Common.Queryable.Common_RelatedEventsSource, Common.RelatedEventsSource> // Common.QueryableRepositoryBase<Common.Queryable.Common_RelatedEventsSource, Common.RelatedEventsSource> // Common.ReadableRepositoryBase<Common.RelatedEventsSource> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.RelatedEventsSource*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.RelatedEventsSource*/

        public RelatedEventsSource_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.RelatedEventsSource*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.RelatedEventsSource*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.RelatedEventsSource[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_RelatedEventsSource> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.RelatedEventsSource*/
            return _executionContext.EntityFrameworkContext.Common_RelatedEventsSource.AsNoTracking();
        }

        /*DataStructureInfo RepositoryMembers Common.RelatedEventsSource*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Claim*/
    public class Claim_Repository : /*DataStructureInfo OverrideBaseType Common.Claim*/ Common.OrmRepositoryBase<Common.Queryable.Common_Claim, Common.Claim> // Common.QueryableRepositoryBase<Common.Queryable.Common_Claim, Common.Claim> // Common.ReadableRepositoryBase<Common.Claim> // global::Common.RepositoryBase
        , IWritableRepository<Common.Claim>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Claim*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Claim*/

        public Claim_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Claim*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Claim*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Claim[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Claim> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Claim*/
            return _executionContext.EntityFrameworkContext.Common_Claim.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Claim> insertedNew, IEnumerable<Common.Claim> updatedNew, IEnumerable<Common.Claim> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Claim*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ClaimResource != null && newItem.ClaimResource.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Claim.ClaimResource", "256" },
                        "DataStructure:Common.Claim,ID:" + invalidItem.ID.ToString() + ",Property:ClaimResource",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.ClaimRight != null && newItem.ClaimRight.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Claim.ClaimRight", "256" },
                        "DataStructure:Common.Claim,ID:" + invalidItem.ID.ToString() + ",Property:ClaimRight",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Claim*/

            /*DataStructureInfo WritableOrm Initialization Common.Claim*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_Claim> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Claim>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_Claim> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Claim>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            			    foreach (var newItem in insertedNew)
                if (newItem.Active == null)
                    newItem.Active = true;

            foreach (var change in updatedNew.Zip(updated, (newItem, oldItem) => new { newItem, oldItem }))
                if (change.newItem.Active == null)
                    change.newItem.Active = change.oldItem.Active ?? true;

if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalPermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalPermission.Query()
                        .Where(child => child.ClaimID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalPermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalPermission.Delete(childItems);
            }
            if (deletedIds.Count() > 0)
            {
                List<Common.RolePermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RolePermission.Query()
                        .Where(child => child.ClaimID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RolePermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RolePermission.Delete(childItems);
            }
            /*DataStructureInfo WritableOrm OldDataLoaded Common.Claim*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimResource == null || string.IsNullOrWhiteSpace(item.ClaimResource) /*RequiredPropertyInfo OrCondition Common.Claim.ClaimResource*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Claim", "ClaimResource" },
                        "DataStructure:Common.Claim,ID:" + invalid.ID.ToString() + ",Property:ClaimResource", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimRight == null || string.IsNullOrWhiteSpace(item.ClaimRight) /*RequiredPropertyInfo OrCondition Common.Claim.ClaimRight*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Claim", "ClaimRight" },
                        "DataStructure:Common.Claim,ID:" + invalid.ID.ToString() + ",Property:ClaimRight", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Claim*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Claim.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalPermission", @"ClaimID", @"FK_PrincipalPermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RolePermission", @"ClaimID", @"FK_RolePermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Claim", @"IX_Claim_ClaimResource_ClaimRight"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Claim,Property:ClaimResource ClaimRight";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Claim*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Claim");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Claim> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Claim*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Claim*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Claim");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredActive()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredActive(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Claim*/
            yield break;
        }

        // Claims in use should be deactivated instead of deleted.
        public IEnumerable<Claim> Filter(IEnumerable<Claim> deleted, Rhetos.Dom.DefaultConcepts.DeactivateInsteadOfDelete parameter)
        {
            var deactivateClaimsId = new List<Guid>();
            var deletedClaimsId = new Lazy<List<Guid>>(() => deleted.Select(c => c.ID).ToList());

            {
                // Don't delete claims that are referenced from RolePermission:

                var permissionsQuery = _domRepository.Common.RolePermission.Query();

                List<Guid> deletedIds = deletedClaimsId.Value;
                if (deletedIds.Count < 1000) // If more than 1000 claims are deleted, it could be faster to load all permissions from database.
                    permissionsQuery = permissionsQuery.Where(p => deletedIds.Contains(p.Claim.ID));

                List<Guid> usedIds = permissionsQuery.Select(p => p.Claim.ID).Distinct().ToList();
                deactivateClaimsId.AddRange(usedIds);
            }
            
            {
                // Don't delete claims that are referenced from PrincipalPermission:

                var permissionsQuery = _domRepository.Common.PrincipalPermission.Query();

                List<Guid> deletedIds = deletedClaimsId.Value;
                if (deletedIds.Count < 1000) // If more than 1000 claims are deleted, it could be faster to load all permissions from database.
                    permissionsQuery = permissionsQuery.Where(p => deletedIds.Contains(p.Claim.ID));

                List<Guid> usedIds = permissionsQuery.Select(p => p.Claim.ID).Distinct().ToList();
                deactivateClaimsId.AddRange(usedIds);
            }
            /*DataStructureInfo DeactivateInsteadOfDelete Common.Claim*/

            var deactivateClaimsIdIndex = new HashSet<Guid>(deactivateClaimsId);
            return deleted.Where(item => deactivateClaimsIdIndex.Contains(item.ID)).ToList();
        }

        public global::Common.Claim CreateInstance()
        {
            var _item = new global::Common.Claim();
            /*DataStructureInfo CreateInstance Common.Claim*/
            return _item;
        }

        public IQueryable<Common.Queryable.Common_Claim> Filter(IQueryable<Common.Queryable.Common_Claim> localSource, Rhetos.Dom.DefaultConcepts.ActiveItems localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository, Rhetos.Dom.DefaultConcepts.ActiveItems/*ComposableFilterByInfo AdditionalParametersType Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/, IQueryable<Common.Queryable.Common_Claim>> filterFunction =
            (items, repository, parameter) =>
                    {
                        if (parameter != null && parameter.ItemID.HasValue)
                            return items.Where(item => item.Active == null || item.Active.Value || item.ID == parameter.ItemID.Value);
                        else
                            return items.Where(item => item.Active == null || item.Active.Value);
                    };

            /*ComposableFilterByInfo BeforeFilter Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/);
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredActive(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredActive";
            metadata[@"Property"] = @"Active";
            /*InvalidDataInfo ErrorMetadata Common.Claim.SystemRequiredActive*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Bool Common.Claim.Active" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.Claim.SystemRequiredActive*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_Claim> Filter(IQueryable<Common.Queryable.Common_Claim> localSource, Common.SystemRequiredActive localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository, Common.SystemRequiredActive/*ComposableFilterByInfo AdditionalParametersType Common.Claim.'Common.SystemRequiredActive'*/, IQueryable<Common.Queryable.Common_Claim>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Active == null);

            /*ComposableFilterByInfo BeforeFilter Common.Claim.'Common.SystemRequiredActive'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.Claim.'Common.SystemRequiredActive'*/);
        }

        public global::Common.Claim[] Filter(Rhetos.Dom.DefaultConcepts.ActiveItems filter_Parameter)
        {
            Func<Common.DomRepository, Rhetos.Dom.DefaultConcepts.ActiveItems/*FilterByInfo AdditionalParametersType Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/, Common.Claim[]> filter_Function =
                (repository, parameter) => repository.Common.Claim.Filter(repository.Common.Claim.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.Claim.'Rhetos.Dom.DefaultConcepts.ActiveItems'*/);
        }

        public global::Common.Claim[] Filter(Common.SystemRequiredActive filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredActive/*FilterByInfo AdditionalParametersType Common.Claim.'Common.SystemRequiredActive'*/, Common.Claim[]> filter_Function =
                (repository, parameter) => repository.Common.Claim.Filter(repository.Common.Claim.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.Claim.'Common.SystemRequiredActive'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.Claim*/
    }

    /*DataStructureInfo RepositoryAttributes Common.MyClaim*/
    public class MyClaim_Repository : /*DataStructureInfo OverrideBaseType Common.MyClaim*/ Common.QueryableRepositoryBase<Common.Queryable.Common_MyClaim, Common.MyClaim> // Common.ReadableRepositoryBase<Common.MyClaim> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.MyClaim*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.MyClaim*/

        public MyClaim_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.MyClaim*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.MyClaim*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.MyClaim[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_MyClaim> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.MyClaim*/
            return Compute(_domRepository.Common.Claim.Query(), _domRepository/*DataStructureInfo AdditionalParametersArgument Common.MyClaim*/);
        }

        public readonly Func<IQueryable<Common.Queryable.Common_Claim>, Common.DomRepository/*DataStructureInfo AdditionalParametersType Common.MyClaim*/, IQueryable<Common.Queryable.Common_MyClaim>> Compute =
            (query, repository) =>
		{ throw new Rhetos.UserException("Reading Common.MyClaim without filter is not permitted. Use filter by Common.Claim or Common.Claim[]."); };

        public global::Common.MyClaim[] Filter(Common.Claim filter_Parameter)
        {
            Func<Common.DomRepository, Common.Claim, Common.ExecutionContext/*FilterByInfo AdditionalParametersType Common.MyClaim.'Common.Claim'*/, Common.MyClaim[]> filter_Function =
                (repository, parameter, executionContext) =>
			{
				var claim = repository.Common.Claim.Query().Where(item => item.ClaimResource == parameter.ClaimResource && item.ClaimRight == parameter.ClaimRight).SingleOrDefault();
				if (claim == null)
					throw new Rhetos.UserException("Claim {0}-{1} does not exist.",
						new[] { parameter.ClaimResource, parameter.ClaimRight }, null, null);
				
				return repository.Common.MyClaim.Filter(new[] { claim });
			};

            return filter_Function(_domRepository, filter_Parameter, _executionContext/*FilterByInfo AdditionalParametersArgument Common.MyClaim.'Common.Claim'*/);
        }

        public global::Common.MyClaim[] Filter(IEnumerable<Common.Claim> filter_Parameter)
        {
            Func<Common.DomRepository, IEnumerable<Common.Claim>, Common.ExecutionContext/*FilterByInfo AdditionalParametersType Common.MyClaim.'IEnumerable<Common.Claim>'*/, Common.MyClaim[]> filter_Function =
                (repository, claims, executionContext) =>
			{
                var securityClaims = claims.Select(c => new Rhetos.Security.Claim(c.ClaimResource, c.ClaimRight)).ToList();
                var authorizations = executionContext.AuthorizationManager.GetAuthorizations(securityClaims);
			
                return claims.Zip(authorizations, (claim, authorized) => new Common.MyClaim {
                        ID = claim.ID,
                        Applies = authorized
                    }).ToArray();
             };

            return filter_Function(_domRepository, filter_Parameter, _executionContext/*FilterByInfo AdditionalParametersArgument Common.MyClaim.'IEnumerable<Common.Claim>'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.MyClaim*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Principal*/
    public class Principal_Repository : /*DataStructureInfo OverrideBaseType Common.Principal*/ Common.OrmRepositoryBase<Common.Queryable.Common_Principal, Common.Principal> // Common.QueryableRepositoryBase<Common.Queryable.Common_Principal, Common.Principal> // Common.ReadableRepositoryBase<Common.Principal> // global::Common.RepositoryBase
        , IWritableRepository<Common.Principal>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Principal*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Principal*/

        public Principal_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Principal*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Principal*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Principal[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Principal> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Principal*/
            return _executionContext.EntityFrameworkContext.Common_Principal.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Principal> insertedNew, IEnumerable<Common.Principal> updatedNew, IEnumerable<Common.Principal> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Principal*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Principal.Name", "256" },
                        "DataStructure:Common.Principal,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Principal*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                Name = item.Name/*LoadOldItemsInfo SelectProperties Common.Principal*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                Name = item.Name/*LoadOldItemsInfo SelectProperties Common.Principal*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.Principal*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_Principal> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Principal>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_Principal> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Principal>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalHasRole> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalHasRole.Query()
                        .Where(child => child.PrincipalID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalHasRole { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalHasRole.Delete(childItems);
            }
            if (deletedIds.Count() > 0)
            {
                List<Common.PrincipalPermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.PrincipalPermission.Query()
                        .Where(child => child.PrincipalID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.PrincipalPermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.PrincipalPermission.Delete(childItems);
            }
            /*DataStructureInfo WritableOrm OldDataLoaded Common.Principal*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Common.Principal.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Principal", "Name" },
                        "DataStructure:Common.Principal,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Principal*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Principal.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalHasRole", @"PrincipalID", @"FK_PrincipalHasRole_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalPermission", @"PrincipalID", @"FK_PrincipalPermission_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Principal", @"IX_Principal_Name"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Principal,Property:Name";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Principal*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Principal");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Principal> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalInfos = ((IEnumerable<Rhetos.Dom.DefaultConcepts.IPrincipal>)insertedNew).Concat(updatedNew)
                    .Concat(updatedOld.Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name }))
                    .Concat(deletedOld.Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name }));
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Principal*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Principal*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Principal");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Principal*/
            yield break;
        }

        public global::Common.Principal CreateInstance()
        {
            var _item = new global::Common.Principal();
            /*DataStructureInfo CreateInstance Common.Principal*/
            return _item;
        }

        /*DataStructureInfo RepositoryMembers Common.Principal*/
    }

    /*DataStructureInfo RepositoryAttributes Common.PrincipalHasRole*/
    public class PrincipalHasRole_Repository : /*DataStructureInfo OverrideBaseType Common.PrincipalHasRole*/ Common.OrmRepositoryBase<Common.Queryable.Common_PrincipalHasRole, Common.PrincipalHasRole> // Common.QueryableRepositoryBase<Common.Queryable.Common_PrincipalHasRole, Common.PrincipalHasRole> // Common.ReadableRepositoryBase<Common.PrincipalHasRole> // global::Common.RepositoryBase
        , IWritableRepository<Common.PrincipalHasRole>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.PrincipalHasRole*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.PrincipalHasRole*/

        public PrincipalHasRole_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.PrincipalHasRole*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.PrincipalHasRole*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.PrincipalHasRole[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_PrincipalHasRole> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.PrincipalHasRole*/
            return _executionContext.EntityFrameworkContext.Common_PrincipalHasRole.AsNoTracking();
        }

        public void Save(IEnumerable<Common.PrincipalHasRole> insertedNew, IEnumerable<Common.PrincipalHasRole> updatedNew, IEnumerable<Common.PrincipalHasRole> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.PrincipalHasRole*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.PrincipalHasRole*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalHasRole*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalHasRole*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.PrincipalHasRole*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_PrincipalHasRole> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalHasRole>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_PrincipalHasRole> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalHasRole>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.PrincipalHasRole*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PrincipalID == null /*RequiredPropertyInfo OrCondition Common.PrincipalHasRole.Principal*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalHasRole", "Principal" },
                        "DataStructure:Common.PrincipalHasRole,ID:" + invalid.ID.ToString() + ",Property:PrincipalID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.RoleID == null /*RequiredPropertyInfo OrCondition Common.PrincipalHasRole.Role*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalHasRole", "Role" },
                        "DataStructure:Common.PrincipalHasRole,ID:" + invalid.ID.ToString() + ",Property:RoleID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.PrincipalHasRole*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_PrincipalHasRole.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_PrincipalHasRole_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.PrincipalHasRole", @"IX_PrincipalHasRole_Principal_Role"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:Principal Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_PrincipalHasRole_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:RoleID,Referenced:Common.Role";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.PrincipalHasRole*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.PrincipalHasRole");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_PrincipalHasRole> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalIds = insertedNew.Concat(updatedNew).Select(item => item.PrincipalID)
                        .Concat(updatedOld.Select(item => item.PrincipalID))
                        .Concat(deletedOld.Select(item => item.PrincipalID))
                        .Where(pid => pid != null).Select(pid => pid.Value)
                        .Distinct().ToList();
                    var principalInfos = _domRepository.Common.Principal.Query(principalIds)
                        .Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name });
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.PrincipalHasRole*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.PrincipalHasRole*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.PrincipalHasRole");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredPrincipal()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredPrincipal(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.PrincipalHasRole*/
            yield break;
        }

        public global::Common.PrincipalHasRole CreateInstance()
        {
            var _item = new global::Common.PrincipalHasRole();
            /*DataStructureInfo CreateInstance Common.PrincipalHasRole*/
            return _item;
        }

        public IQueryable<Common.Queryable.Common_PrincipalHasRole> Query(Rhetos.Dom.DefaultConcepts.IPrincipal queryParameter)
        {
            /*QueryWithParameterInfo BeforeQuery Common.PrincipalHasRole.'Rhetos.Dom.DefaultConcepts.IPrincipal'*/
            Func<Rhetos.Dom.DefaultConcepts.IPrincipal, IQueryable<Common.Queryable.Common_PrincipalHasRole>> queryFunction = parameter => Query().Where(item => item.Principal.ID == parameter.ID);
            var queryResult = queryFunction(queryParameter);
            /*QueryWithParameterInfo AfterQuery Common.PrincipalHasRole.'Rhetos.Dom.DefaultConcepts.IPrincipal'*/
            return queryResult;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredPrincipal(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredPrincipal";
            metadata[@"Property"] = @"Principal";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalHasRole.SystemRequiredPrincipal*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.PrincipalHasRole.Principal" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.PrincipalHasRole.SystemRequiredPrincipal*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_PrincipalHasRole> Filter(IQueryable<Common.Queryable.Common_PrincipalHasRole> localSource, Common.SystemRequiredPrincipal localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_PrincipalHasRole>, Common.DomRepository, Common.SystemRequiredPrincipal/*ComposableFilterByInfo AdditionalParametersType Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/, IQueryable<Common.Queryable.Common_PrincipalHasRole>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Principal == null);

            /*ComposableFilterByInfo BeforeFilter Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/);
        }

        public global::Common.PrincipalHasRole[] Filter(Common.SystemRequiredPrincipal filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredPrincipal/*FilterByInfo AdditionalParametersType Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/, Common.PrincipalHasRole[]> filter_Function =
                (repository, parameter) => repository.Common.PrincipalHasRole.Filter(repository.Common.PrincipalHasRole.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.PrincipalHasRole.'Common.SystemRequiredPrincipal'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.PrincipalHasRole*/
    }

    /*DataStructureInfo RepositoryAttributes Common.Role*/
    public class Role_Repository : /*DataStructureInfo OverrideBaseType Common.Role*/ Common.OrmRepositoryBase<Common.Queryable.Common_Role, Common.Role> // Common.QueryableRepositoryBase<Common.Queryable.Common_Role, Common.Role> // Common.ReadableRepositoryBase<Common.Role> // global::Common.RepositoryBase
        , IWritableRepository<Common.Role>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.Role*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.Role*/

        public Role_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.Role*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.Role*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.Role[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_Role> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.Role*/
            return _executionContext.EntityFrameworkContext.Common_Role.AsNoTracking();
        }

        public void Save(IEnumerable<Common.Role> insertedNew, IEnumerable<Common.Role> updatedNew, IEnumerable<Common.Role> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.Role*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.Name != null && newItem.Name.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "Role.Name", "256" },
                        "DataStructure:Common.Role,ID:" + invalidItem.ID.ToString() + ",Property:Name",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.Role*/

            /*DataStructureInfo WritableOrm Initialization Common.Role*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_Role> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Role>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_Role> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_Role>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            if (deletedIds.Count() > 0)
            {
                List<Common.RoleInheritsRole> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RoleInheritsRole.Query()
                        .Where(child => child.UsersFromID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RoleInheritsRole { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RoleInheritsRole.Delete(childItems);
            }
            if (deletedIds.Count() > 0)
            {
                List<Common.RolePermission> childItems = deletedIds
                    .SelectMany(parent => _executionContext.Repository.Common.RolePermission.Query()
                        .Where(child => child.RoleID == parent.ID)
                        .Select(child => child.ID)
                        .ToList())
                    .Select(childId => new Common.RolePermission { ID = childId })
                    .ToList();

                if (childItems.Count() > 0)
                    _domRepository.Common.RolePermission.Delete(childItems);
            }
            /*DataStructureInfo WritableOrm OldDataLoaded Common.Role*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.Name == null || string.IsNullOrWhiteSpace(item.Name) /*RequiredPropertyInfo OrCondition Common.Role.Name*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.Role", "Name" },
                        "DataStructure:Common.Role,ID:" + invalid.ID.ToString() + ",Property:Name", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.Role*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_Role.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.PrincipalHasRole", @"RoleID", @"FK_PrincipalHasRole_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalHasRole,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RoleInheritsRole", @"UsersFromID", @"FK_RoleInheritsRole_Role_UsersFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RoleInheritsRole", @"PermissionsFromID", @"FK_RoleInheritsRole_Role_PermissionsFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:PermissionsFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnDelete(interpretedException, @"Common.RolePermission", @"RoleID", @"FK_RolePermission_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.Role", @"IX_Role_Name"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.Role,Property:Name";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.Role*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.Role");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_Role> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Concat(deletedIds).Select(r => r.ID);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.Role*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.Role*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.Role");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.Role*/
            yield break;
        }

        public global::Common.Role CreateInstance()
        {
            var _item = new global::Common.Role();
            /*DataStructureInfo CreateInstance Common.Role*/
            return _item;
        }

        /*DataStructureInfo RepositoryMembers Common.Role*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RoleInheritsRole*/
    public class RoleInheritsRole_Repository : /*DataStructureInfo OverrideBaseType Common.RoleInheritsRole*/ Common.OrmRepositoryBase<Common.Queryable.Common_RoleInheritsRole, Common.RoleInheritsRole> // Common.QueryableRepositoryBase<Common.Queryable.Common_RoleInheritsRole, Common.RoleInheritsRole> // Common.ReadableRepositoryBase<Common.RoleInheritsRole> // global::Common.RepositoryBase
        , IWritableRepository<Common.RoleInheritsRole>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.RoleInheritsRole*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.RoleInheritsRole*/

        public RoleInheritsRole_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.RoleInheritsRole*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.RoleInheritsRole*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.RoleInheritsRole[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_RoleInheritsRole> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.RoleInheritsRole*/
            return _executionContext.EntityFrameworkContext.Common_RoleInheritsRole.AsNoTracking();
        }

        public void Save(IEnumerable<Common.RoleInheritsRole> insertedNew, IEnumerable<Common.RoleInheritsRole> updatedNew, IEnumerable<Common.RoleInheritsRole> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.RoleInheritsRole*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.RoleInheritsRole*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                UsersFromID = item.UsersFromID/*LoadOldItemsInfo SelectProperties Common.RoleInheritsRole*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                UsersFromID = item.UsersFromID/*LoadOldItemsInfo SelectProperties Common.RoleInheritsRole*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.RoleInheritsRole*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_RoleInheritsRole> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RoleInheritsRole>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_RoleInheritsRole> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RoleInheritsRole>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.RoleInheritsRole*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.UsersFromID == null /*RequiredPropertyInfo OrCondition Common.RoleInheritsRole.UsersFrom*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RoleInheritsRole", "UsersFrom" },
                        "DataStructure:Common.RoleInheritsRole,ID:" + invalid.ID.ToString() + ",Property:UsersFromID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PermissionsFromID == null /*RequiredPropertyInfo OrCondition Common.RoleInheritsRole.PermissionsFrom*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RoleInheritsRole", "PermissionsFrom" },
                        "DataStructure:Common.RoleInheritsRole,ID:" + invalid.ID.ToString() + ",Property:PermissionsFromID", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.RoleInheritsRole*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_RoleInheritsRole.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RoleInheritsRole_Role_UsersFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RoleInheritsRole_Role_PermissionsFromID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:PermissionsFromID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.RoleInheritsRole", @"IX_RoleInheritsRole_UsersFrom_PermissionsFrom"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RoleInheritsRole,Property:UsersFrom PermissionsFrom";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.RoleInheritsRole*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.RoleInheritsRole");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_RoleInheritsRole> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Select(item => item.UsersFromID)
                        .Concat(updatedOld.Select(item => item.UsersFromID))
                        .Concat(deletedOld.Select(item => item.UsersFromID))
                        .Where(rid => rid != null).Select(rid => rid.Value);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.RoleInheritsRole*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.RoleInheritsRole*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.RoleInheritsRole");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredUsersFrom()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredUsersFrom(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.RoleInheritsRole*/
            yield break;
        }

        public global::Common.RoleInheritsRole CreateInstance()
        {
            var _item = new global::Common.RoleInheritsRole();
            /*DataStructureInfo CreateInstance Common.RoleInheritsRole*/
            return _item;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredUsersFrom(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredUsersFrom";
            metadata[@"Property"] = @"UsersFrom";
            /*InvalidDataInfo ErrorMetadata Common.RoleInheritsRole.SystemRequiredUsersFrom*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.RoleInheritsRole.UsersFrom" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.RoleInheritsRole.SystemRequiredUsersFrom*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_RoleInheritsRole> Filter(IQueryable<Common.Queryable.Common_RoleInheritsRole> localSource, Common.SystemRequiredUsersFrom localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_RoleInheritsRole>, Common.DomRepository, Common.SystemRequiredUsersFrom/*ComposableFilterByInfo AdditionalParametersType Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/, IQueryable<Common.Queryable.Common_RoleInheritsRole>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.UsersFrom == null);

            /*ComposableFilterByInfo BeforeFilter Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/);
        }

        public global::Common.RoleInheritsRole[] Filter(Common.SystemRequiredUsersFrom filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredUsersFrom/*FilterByInfo AdditionalParametersType Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/, Common.RoleInheritsRole[]> filter_Function =
                (repository, parameter) => repository.Common.RoleInheritsRole.Filter(repository.Common.RoleInheritsRole.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.RoleInheritsRole.'Common.SystemRequiredUsersFrom'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.RoleInheritsRole*/
    }

    /*DataStructureInfo RepositoryAttributes Common.PrincipalPermission*/
    public class PrincipalPermission_Repository : /*DataStructureInfo OverrideBaseType Common.PrincipalPermission*/ Common.OrmRepositoryBase<Common.Queryable.Common_PrincipalPermission, Common.PrincipalPermission> // Common.QueryableRepositoryBase<Common.Queryable.Common_PrincipalPermission, Common.PrincipalPermission> // Common.ReadableRepositoryBase<Common.PrincipalPermission> // global::Common.RepositoryBase
        , IWritableRepository<Common.PrincipalPermission>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.PrincipalPermission*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.PrincipalPermission*/

        public PrincipalPermission_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.PrincipalPermission*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.PrincipalPermission*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.PrincipalPermission[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_PrincipalPermission> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.PrincipalPermission*/
            return _executionContext.EntityFrameworkContext.Common_PrincipalPermission.AsNoTracking();
        }

        public void Save(IEnumerable<Common.PrincipalPermission> insertedNew, IEnumerable<Common.PrincipalPermission> updatedNew, IEnumerable<Common.PrincipalPermission> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.PrincipalPermission*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.PrincipalPermission*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalPermission*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                PrincipalID = item.PrincipalID/*LoadOldItemsInfo SelectProperties Common.PrincipalPermission*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.PrincipalPermission*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_PrincipalPermission> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalPermission>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_PrincipalPermission> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_PrincipalPermission>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.PrincipalPermission*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.PrincipalID == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.Principal*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "Principal" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:PrincipalID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimID == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.Claim*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "Claim" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:ClaimID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.IsAuthorized == null /*RequiredPropertyInfo OrCondition Common.PrincipalPermission.IsAuthorized*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.PrincipalPermission", "IsAuthorized" },
                        "DataStructure:Common.PrincipalPermission,ID:" + invalid.ID.ToString() + ",Property:IsAuthorized", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.PrincipalPermission*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_PrincipalPermission.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Principal", @"ID", @"FK_PrincipalPermission_Principal_PrincipalID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:PrincipalID,Referenced:Common.Principal";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Claim", @"ID", @"FK_PrincipalPermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.PrincipalPermission", @"IX_PrincipalPermission_Principal_Claim"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.PrincipalPermission,Property:Principal Claim";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.PrincipalPermission*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.PrincipalPermission");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_PrincipalPermission> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var principalIds = insertedNew.Concat(updatedNew).Select(item => item.PrincipalID)
                        .Concat(updatedOld.Select(item => item.PrincipalID))
                        .Concat(deletedOld.Select(item => item.PrincipalID))
                        .Where(pid => pid != null).Select(pid => pid.Value)
                        .Distinct().ToList();
                    var principalInfos = _domRepository.Common.Principal.Query(principalIds)
                        .Select(p => new Rhetos.Dom.DefaultConcepts.PrincipalInfo { ID = p.ID, Name = p.Name });
                    _authorizationDataCache.ClearCachePrincipals(principalInfos);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.PrincipalPermission*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.PrincipalPermission*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.PrincipalPermission");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredPrincipal()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredPrincipal(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredClaim()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredClaim(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.PrincipalPermission*/
            yield break;
        }

        public global::Common.PrincipalPermission CreateInstance()
        {
            var _item = new global::Common.PrincipalPermission();
            /*DataStructureInfo CreateInstance Common.PrincipalPermission*/
            return _item;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredPrincipal(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredPrincipal";
            metadata[@"Property"] = @"Principal";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalPermission.SystemRequiredPrincipal*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.PrincipalPermission.Principal" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.PrincipalPermission.SystemRequiredPrincipal*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredClaim(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredClaim";
            metadata[@"Property"] = @"Claim";
            /*InvalidDataInfo ErrorMetadata Common.PrincipalPermission.SystemRequiredClaim*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.PrincipalPermission.Claim" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.PrincipalPermission.SystemRequiredClaim*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_PrincipalPermission> Filter(IQueryable<Common.Queryable.Common_PrincipalPermission> localSource, Common.SystemRequiredPrincipal localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_PrincipalPermission>, Common.DomRepository, Common.SystemRequiredPrincipal/*ComposableFilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/, IQueryable<Common.Queryable.Common_PrincipalPermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Principal == null);

            /*ComposableFilterByInfo BeforeFilter Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/);
        }

        public IQueryable<Common.Queryable.Common_PrincipalPermission> Filter(IQueryable<Common.Queryable.Common_PrincipalPermission> localSource, Common.SystemRequiredClaim localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_PrincipalPermission>, Common.DomRepository, Common.SystemRequiredClaim/*ComposableFilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredClaim'*/, IQueryable<Common.Queryable.Common_PrincipalPermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Claim == null);

            /*ComposableFilterByInfo BeforeFilter Common.PrincipalPermission.'Common.SystemRequiredClaim'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredClaim'*/);
        }

        public global::Common.PrincipalPermission[] Filter(Common.SystemRequiredPrincipal filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredPrincipal/*FilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/, Common.PrincipalPermission[]> filter_Function =
                (repository, parameter) => repository.Common.PrincipalPermission.Filter(repository.Common.PrincipalPermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredPrincipal'*/);
        }

        public global::Common.PrincipalPermission[] Filter(Common.SystemRequiredClaim filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredClaim/*FilterByInfo AdditionalParametersType Common.PrincipalPermission.'Common.SystemRequiredClaim'*/, Common.PrincipalPermission[]> filter_Function =
                (repository, parameter) => repository.Common.PrincipalPermission.Filter(repository.Common.PrincipalPermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.PrincipalPermission.'Common.SystemRequiredClaim'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.PrincipalPermission*/
    }

    /*DataStructureInfo RepositoryAttributes Common.RolePermission*/
    public class RolePermission_Repository : /*DataStructureInfo OverrideBaseType Common.RolePermission*/ Common.OrmRepositoryBase<Common.Queryable.Common_RolePermission, Common.RolePermission> // Common.QueryableRepositoryBase<Common.Queryable.Common_RolePermission, Common.RolePermission> // Common.ReadableRepositoryBase<Common.RolePermission> // global::Common.RepositoryBase
        , IWritableRepository<Common.RolePermission>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.RolePermission*/
    {
        private readonly Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache;
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.RolePermission*/

        public RolePermission_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Dom.DefaultConcepts.AuthorizationDataCache _authorizationDataCache, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.RolePermission*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._authorizationDataCache = _authorizationDataCache;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.RolePermission*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.RolePermission[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_RolePermission> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.RolePermission*/
            return _executionContext.EntityFrameworkContext.Common_RolePermission.AsNoTracking();
        }

        public void Save(IEnumerable<Common.RolePermission> insertedNew, IEnumerable<Common.RolePermission> updatedNew, IEnumerable<Common.RolePermission> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.RolePermission*/

            /*DataStructureInfo WritableOrm ArgumentValidation Common.RolePermission*/

            var updatedIdsList = updatedNew.Select(item => item.ID).ToList();
            var deletedIdsList = deletedIds.Select(item => item.ID).ToList();
            var updatedOld = Filter(Query(), updatedIdsList).Select(item => new { item.ID,
                RoleID = item.RoleID/*LoadOldItemsInfo SelectProperties Common.RolePermission*/ }).ToList();
            var deletedOld = Filter(Query(), deletedIdsList).Select(item => new { item.ID,
                RoleID = item.RoleID/*LoadOldItemsInfo SelectProperties Common.RolePermission*/ }).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder(updatedOld, updatedIdsList, item => item.ID);
            Rhetos.Utilities.Graph.SortByGivenOrder(deletedOld, deletedIdsList, item => item.ID);

            /*DataStructureInfo WritableOrm Initialization Common.RolePermission*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_RolePermission> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RolePermission>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_RolePermission> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_RolePermission>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.RolePermission*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.RoleID == null /*RequiredPropertyInfo OrCondition Common.RolePermission.Role*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "Role" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:RoleID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.ClaimID == null /*RequiredPropertyInfo OrCondition Common.RolePermission.Claim*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "Claim" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:ClaimID", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.IsAuthorized == null /*RequiredPropertyInfo OrCondition Common.RolePermission.IsAuthorized*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.RolePermission", "IsAuthorized" },
                        "DataStructure:Common.RolePermission,ID:" + invalid.ID.ToString() + ",Property:IsAuthorized", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.RolePermission*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_RolePermission.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Role", @"ID", @"FK_RolePermission_Role_RoleID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:RoleID,Referenced:Common.Role";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsReferenceErrorOnInsertUpdate(interpretedException, @"Common.Claim", @"ID", @"FK_RolePermission_Claim_ClaimID"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:ClaimID,Referenced:Common.Claim";
                if (interpretedException is Rhetos.UserException && Rhetos.Utilities.MsSqlUtility.IsUniqueError(interpretedException, @"Common.RolePermission", @"IX_RolePermission_Role_Claim"))
                    ((Rhetos.UserException)interpretedException).SystemMessage = @"DataStructure:Common.RolePermission,Property:Role Claim";
                /*DataStructureInfo WritableOrm OnDatabaseError Common.RolePermission*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.RolePermission");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_RolePermission> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                { // ClearAuthenticationCache
                    var roleIds = insertedNew.Concat(updatedNew).Select(item => item.RoleID)
                        .Concat(updatedOld.Select(item => item.RoleID))
                        .Concat(deletedOld.Select(item => item.RoleID))
                        .Where(rid => rid != null).Select(rid => rid.Value);
                    _authorizationDataCache.ClearCacheRoles(roleIds);
                }

                /*DataStructureInfo WritableOrm OnSaveTag1 Common.RolePermission*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.RolePermission*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.RolePermission");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredRole()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredRole(errorIds))
                        yield return error;
            }
            if (onSave)
            {
                var errorIds = this.Filter(this.Query(ids), new SystemRequiredClaim()).Select(item => item.ID).ToArray();
                if (errorIds.Count() > 0)
                    foreach (var error in GetErrorMessage_SystemRequiredClaim(errorIds))
                        yield return error;
            }
            /*DataStructureInfo WritableOrm OnSaveValidate Common.RolePermission*/
            yield break;
        }

        public global::Common.RolePermission CreateInstance()
        {
            var _item = new global::Common.RolePermission();
            /*DataStructureInfo CreateInstance Common.RolePermission*/
            return _item;
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredRole(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredRole";
            metadata[@"Property"] = @"Role";
            /*InvalidDataInfo ErrorMetadata Common.RolePermission.SystemRequiredRole*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.RolePermission.Role" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.RolePermission.SystemRequiredRole*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IEnumerable<InvalidDataMessage> GetErrorMessage_SystemRequiredClaim(IEnumerable<Guid> invalidData_Ids)
        {
            const string invalidData_Description = @"System required property {0} is not set.";
            IDictionary<string, object> metadata = new Dictionary<string, object>();
            metadata["Validation"] = @"SystemRequiredClaim";
            metadata[@"Property"] = @"Claim";
            /*InvalidDataInfo ErrorMetadata Common.RolePermission.SystemRequiredClaim*/
            return invalidData_Ids.Select(id => new InvalidDataMessage
            {
                ID = id,
                Message = invalidData_Description,
                MessageParameters = new object[] { @"Reference Common.RolePermission.Claim" },
                Metadata = metadata
            });
            // /*InvalidDataInfo OverrideUserMessages Common.RolePermission.SystemRequiredClaim*/ return invalidData_Ids.Select(id => new InvalidDataMessage { ID = id, Message = invalidData_Description, Metadata = metadata });
        }

        public IQueryable<Common.Queryable.Common_RolePermission> Filter(IQueryable<Common.Queryable.Common_RolePermission> localSource, Common.SystemRequiredRole localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_RolePermission>, Common.DomRepository, Common.SystemRequiredRole/*ComposableFilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredRole'*/, IQueryable<Common.Queryable.Common_RolePermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Role == null);

            /*ComposableFilterByInfo BeforeFilter Common.RolePermission.'Common.SystemRequiredRole'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredRole'*/);
        }

        public IQueryable<Common.Queryable.Common_RolePermission> Filter(IQueryable<Common.Queryable.Common_RolePermission> localSource, Common.SystemRequiredClaim localParameter)
        {
            Func<IQueryable<Common.Queryable.Common_RolePermission>, Common.DomRepository, Common.SystemRequiredClaim/*ComposableFilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredClaim'*/, IQueryable<Common.Queryable.Common_RolePermission>> filterFunction =
            (source, repository, parameter) => source.Where(item => item.Claim == null);

            /*ComposableFilterByInfo BeforeFilter Common.RolePermission.'Common.SystemRequiredClaim'*/
            return filterFunction(localSource, _domRepository, localParameter/*ComposableFilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredClaim'*/);
        }

        public global::Common.RolePermission[] Filter(Common.SystemRequiredRole filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredRole/*FilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredRole'*/, Common.RolePermission[]> filter_Function =
                (repository, parameter) => repository.Common.RolePermission.Filter(repository.Common.RolePermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredRole'*/);
        }

        public global::Common.RolePermission[] Filter(Common.SystemRequiredClaim filter_Parameter)
        {
            Func<Common.DomRepository, Common.SystemRequiredClaim/*FilterByInfo AdditionalParametersType Common.RolePermission.'Common.SystemRequiredClaim'*/, Common.RolePermission[]> filter_Function =
                (repository, parameter) => repository.Common.RolePermission.Filter(repository.Common.RolePermission.Query(), parameter).ToArray();

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.RolePermission.'Common.SystemRequiredClaim'*/);
        }

        /*DataStructureInfo RepositoryMembers Common.RolePermission*/
    }

    /*DataStructureInfo RepositoryAttributes Common.AuditRelatedEvents*/
    public class AuditRelatedEvents_Repository : /*DataStructureInfo OverrideBaseType Common.AuditRelatedEvents*/ Common.ReadableRepositoryBase<Common.AuditRelatedEvents> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.AuditRelatedEvents*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.AuditRelatedEvents*/

        public AuditRelatedEvents_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.AuditRelatedEvents*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.AuditRelatedEvents*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.AuditRelatedEvents[] All()
        {
            Func<Common.DomRepository/*DataStructureInfo AdditionalParametersType Common.AuditRelatedEvents*/, global::Common.AuditRelatedEvents[]> compute_Function =
            repository => { throw new Rhetos.UserException("Reading Common.AuditRelatedEvents without filter is not permitted. Use filter by Common.LoggedItem."); };

            return compute_Function(_domRepository/*DataStructureInfo AdditionalParametersArgument Common.AuditRelatedEvents*/);
        }

        public global::Common.AuditRelatedEvents[] Filter(LoggedItem filter_Parameter)
        {
            Func<Common.DomRepository, LoggedItem/*FilterByInfo AdditionalParametersType Common.AuditRelatedEvents.LoggedItem*/, Common.AuditRelatedEvents[]> filter_Function =
                (repository, parameter) =>
        {
            /*AuditRelatedEvents Load Begin*/
            
            return repository.Common.RelatedEventsSource.Query()
                .Where(item => item.RelatedToTable == parameter.TableName && item.RelatedToItem == parameter.ItemId)
                .ToList()
                .Select(item =>
                {
                    IUserInfo clientInfo = Rhetos.Utilities.SqlUtility.ExtractUserInfo(item.ContextInfo);
                    
                    var relatedEvent = new Common.AuditRelatedEvents
                    {
                        ID = item.ID,
                        LogID = item.LogID,
                        Created = item.Created,
                        Action = item.Action,
                        TableName = item.TableName,
                        ItemId = item.ItemId,
                        Description = item.Description,
                        
                        ClientUserName = clientInfo.UserName ?? item.UserName,
                        ClientWorkstation = clientInfo.Workstation ?? item.Workstation,
                        
                        Relation = item.Relation,
                        Summary = OmegaCommonConcepts.AuditingUtility.GetSummary(item.Action, item.Description)
                    };
                    
                    /*AuditRelatedEvents Load ProcessEvent*/
                    return relatedEvent;
                })
                .OrderByDescending(item => item.Created)
                .ThenBy(item => item.Relation)
                .ThenBy(item => item.TableName)
                .ToArray();
        };

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.AuditRelatedEvents.LoggedItem*/);
        }

        public global::Common.AuditRelatedEvents[] Filter(DeletedItems filter_Parameter)
        {
            Func<Common.DomRepository, DeletedItems/*FilterByInfo AdditionalParametersType Common.AuditRelatedEvents.DeletedItems*/, Common.AuditRelatedEvents[]> filter_Function =
                (repository, parameter) =>
        {
            /*AuditRelatedEvents Load Begin*/
            
            return repository.Common.RelatedEventsSource.Query()
                .Where(item => item.RelatedToTable == parameter.TableName && item.Action == "Delete")
                .ToList()
                .Select(item =>
                {
                    IUserInfo clientInfo = Rhetos.Utilities.SqlUtility.ExtractUserInfo(item.ContextInfo);
                    
                    var relatedEvent = new Common.AuditRelatedEvents
                    {
                        ID = item.ID,
                        LogID = item.LogID,
                        Created = item.Created,
                        Action = item.Action,
                        TableName = item.TableName,
                        ItemId = item.ItemId,
                        Description = item.Description,
                        
                        ClientUserName = clientInfo.UserName ?? item.UserName,
                        ClientWorkstation = clientInfo.Workstation ?? item.Workstation,
                        
                        Relation = item.Relation,
                        Summary = OmegaCommonConcepts.AuditingUtility.GetSummary(item.Action, item.Description)
                    };
                    
                    /*AuditRelatedEvents Load ProcessEvent*/
                    return relatedEvent;
                })
                .OrderByDescending(item => item.Created)
                .ThenBy(item => item.Relation)
                .ThenBy(item => item.TableName)
                .ToArray();
        };

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.AuditRelatedEvents.DeletedItems*/);
        }

        /*DataStructureInfo RepositoryMembers Common.AuditRelatedEvents*/
    }

    /*DataStructureInfo RepositoryAttributes Common.AuditDataModifications*/
    public class AuditDataModifications_Repository : /*DataStructureInfo OverrideBaseType Common.AuditDataModifications*/ Common.ReadableRepositoryBase<Common.AuditDataModifications> // global::Common.RepositoryBase
        /*DataStructureInfo RepositoryInterface Common.AuditDataModifications*/
    {
        /*DataStructureInfo RepositoryPrivateMembers Common.AuditDataModifications*/

        public AuditDataModifications_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext/*DataStructureInfo RepositoryConstructorArguments Common.AuditDataModifications*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            /*DataStructureInfo RepositoryConstructorCode Common.AuditDataModifications*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.AuditDataModifications[] All()
        {
            Func<Common.DomRepository/*DataStructureInfo AdditionalParametersType Common.AuditDataModifications*/, global::Common.AuditDataModifications[]> compute_Function =
            repository => { throw new Rhetos.UserException("Reading Common.AuditDataModifications without filter is not permitted. Use filter by Common.LoggedItem or Common.Log."); };

            return compute_Function(_domRepository/*DataStructureInfo AdditionalParametersArgument Common.AuditDataModifications*/);
        }

        public global::Common.AuditDataModifications[] Filter(LoggedItem filter_Parameter)
        {
            Func<Common.DomRepository, LoggedItem, Common.ExecutionContext/*FilterByInfo AdditionalParametersType Common.AuditDataModifications.LoggedItem*/, Common.AuditDataModifications[]> filter_Function =
                (repository, parameter, executionContext) =>
        {
            var eventDescriptions = repository.Common.LogReader.Query()
                .Where(item => item.TableName == parameter.TableName && item.ItemId == parameter.ItemId)
                .Select(item => new { item.ID, item.Action, item.Description, item.Created })
                .ToList()
                .Where(item => item.Action == "Update" || item.Action == "Insert" || item.Action == "Delete")
                .OrderByDescending(item => item.Created)
                .ThenBy(item => item.ID)
                .Select(item => new OmegaCommonConcepts.AuditingUtility.EventDescription { LogID = item.ID, Action = item.Action, Description = item.Description })
                .ToList();
                
            string sql = "SELECT Description FROM " + SqlUtility.GetFullName(parameter.TableName + "_CommonLogDescription") + " WHERE ID = "
				+ Rhetos.Utilities.SqlUtility.QuoteGuid(parameter.ItemId);
            string currentItemDescription = "Error: Unknown";
			try
			{
				executionContext.SqlExecuter.ExecuteReader(sql, reader => currentItemDescription = reader.GetString(0));
			}
			catch
			{
				// The currentItemDescription will remain "Error: Unknown" on missing data or missing view (an old entity type that no longer exists).
			}
            
            var result = OmegaCommonConcepts.AuditingUtility.ReconstructDataModifications(eventDescriptions, currentItemDescription);
            return result.Select(item => new Common.AuditDataModifications
                {
                    ID = Guid.NewGuid(),
                    LogID = item.LogID,
                    Property = item.Property,
                    OldValue = item.OldValue,
                    NewValue = item.NewValue,
                    Modified = item.Modified
                }).ToArray();
        };

            return filter_Function(_domRepository, filter_Parameter, _executionContext/*FilterByInfo AdditionalParametersArgument Common.AuditDataModifications.LoggedItem*/);
        }

        public global::Common.AuditDataModifications[] Filter(LogEntry filter_Parameter)
        {
            Func<Common.DomRepository, LogEntry/*FilterByInfo AdditionalParametersType Common.AuditDataModifications.LogEntry*/, Common.AuditDataModifications[]> filter_Function =
                (repository, parameter) =>
        {
            var log = repository.Common.LogReader.Filter(new[] { parameter.LogID.Value }).SingleOrDefault();
            if (log == null)
                throw new Rhetos.UserException("There is no record in Common.Log with ID {0}.", new[] { SqlUtility.GuidToString(parameter.LogID.Value) }, null, null);
            var modifications = repository.Common.AuditDataModifications.Filter(new LoggedItem { TableName = log.TableName, ItemId = log.ItemId });
            return modifications.Where(m => m.LogID == parameter.LogID.Value).ToArray();
        };

            return filter_Function(_domRepository, filter_Parameter/*FilterByInfo AdditionalParametersArgument Common.AuditDataModifications.LogEntry*/);
        }

        /*DataStructureInfo RepositoryMembers Common.AuditDataModifications*/
    }

    /*DataStructureInfo RepositoryAttributes Common.ReportTemplate*/
    public class ReportTemplate_Repository : /*DataStructureInfo OverrideBaseType Common.ReportTemplate*/ Common.OrmRepositoryBase<Common.Queryable.Common_ReportTemplate, Common.ReportTemplate> // Common.QueryableRepositoryBase<Common.Queryable.Common_ReportTemplate, Common.ReportTemplate> // Common.ReadableRepositoryBase<Common.ReportTemplate> // global::Common.RepositoryBase
        , IWritableRepository<Common.ReportTemplate>, IValidateRepository/*DataStructureInfo RepositoryInterface Common.ReportTemplate*/
    {
        private readonly Rhetos.Utilities.ISqlUtility _sqlUtility;
        /*DataStructureInfo RepositoryPrivateMembers Common.ReportTemplate*/

        public ReportTemplate_Repository(Common.DomRepository domRepository, Common.ExecutionContext executionContext, Rhetos.Utilities.ISqlUtility _sqlUtility/*DataStructureInfo RepositoryConstructorArguments Common.ReportTemplate*/)
        {
            _domRepository = domRepository;
            _executionContext = executionContext;
            this._sqlUtility = _sqlUtility;
            /*DataStructureInfo RepositoryConstructorCode Common.ReportTemplate*/
        }

        [Obsolete("Use Load() or Query() method.")]
        public override global::Common.ReportTemplate[] All()
        {
            return Query().ToSimple().ToArray();
        }

        public override IQueryable<Common.Queryable.Common_ReportTemplate> Query()
        {
            /*DataStructureInfo RepositoryBeforeQuery Common.ReportTemplate*/
            return _executionContext.EntityFrameworkContext.Common_ReportTemplate.AsNoTracking();
        }

        public void Save(IEnumerable<Common.ReportTemplate> insertedNew, IEnumerable<Common.ReportTemplate> updatedNew, IEnumerable<Common.ReportTemplate> deletedIds, bool checkUserPermissions = false)
        {
            if (!DomHelper.CleanUpSaveMethodArguments(ref insertedNew, ref updatedNew, ref deletedIds))
                return;

            /*DataStructureInfo WritableOrm ClearContext Common.ReportTemplate*/

            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.FileName != null && newItem.FileName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ReportTemplate.FileName", "256" },
                        "DataStructure:Common.ReportTemplate,ID:" + invalidItem.ID.ToString() + ",Property:FileName",
                        null);
            }
            {
                var invalidItem = insertedNew.Concat(updatedNew).Where(newItem => newItem.DisplayName != null && newItem.DisplayName.Length > 256).FirstOrDefault();
                if (invalidItem != null)
                    throw new Rhetos.UserException(
                        "Maximum length of property {0} is {1}.",
                        new[] { "ReportTemplate.DisplayName", "256" },
                        "DataStructure:Common.ReportTemplate,ID:" + invalidItem.ID.ToString() + ",Property:DisplayName",
                        null);
            }
            /*DataStructureInfo WritableOrm ArgumentValidation Common.ReportTemplate*/

            /*DataStructureInfo WritableOrm Initialization Common.ReportTemplate*/

            // Using old data, including lazy loading of navigation properties:
            IEnumerable<Common.Queryable.Common_ReportTemplate> deleted = this.Query(deletedIds.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_ReportTemplate>)deleted, deletedIds.Select(item => item.ID), item => item.ID);
            IEnumerable<Common.Queryable.Common_ReportTemplate> updated = this.Query(updatedNew.Select(item => item.ID)).ToList();
            Rhetos.Utilities.Graph.SortByGivenOrder((List<Common.Queryable.Common_ReportTemplate>)updated, updatedNew.Select(item => item.ID), item => item.ID);

            /*DataStructureInfo WritableOrm OldDataLoaded Common.ReportTemplate*/

            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.FileName == null || string.IsNullOrWhiteSpace(item.FileName) /*RequiredPropertyInfo OrCondition Common.ReportTemplate.FileName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ReportTemplate", "FileName" },
                        "DataStructure:Common.ReportTemplate,ID:" + invalid.ID.ToString() + ",Property:FileName", null);
            }
            {
                var invalid = insertedNew.Concat(updatedNew).FirstOrDefault(item => item.DisplayName == null || string.IsNullOrWhiteSpace(item.DisplayName) /*RequiredPropertyInfo OrCondition Common.ReportTemplate.DisplayName*/);
                if (invalid != null)
                    throw new Rhetos.UserException("It is not allowed to enter {0} because the required property {1} is not set.",
                        new[] { "Common.ReportTemplate", "DisplayName" },
                        "DataStructure:Common.ReportTemplate,ID:" + invalid.ID.ToString() + ",Property:DisplayName", null);
            }
            /*DataStructureInfo WritableOrm ProcessedOldData Common.ReportTemplate*/

            DomHelper.SaveOperation saveOperation = DomHelper.SaveOperation.None;
            try
            {
                if (deletedIds.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Delete;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in deletedIds.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Deleted;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (updatedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Update;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = false;
                    foreach (var item in updatedNew.Select(item => item.ToNavigation()))
                        _executionContext.EntityFrameworkContext.Entry(item).State = System.Data.Entity.EntityState.Modified;
                    _executionContext.EntityFrameworkContext.Configuration.AutoDetectChangesEnabled = true;
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                if (insertedNew.Count() > 0)
                {
                    saveOperation = DomHelper.SaveOperation.Insert;
                    _executionContext.EntityFrameworkContext.Common_ReportTemplate.AddRange(insertedNew.Select(item => item.ToNavigation()));
                    _executionContext.EntityFrameworkContext.SaveChanges();
                }

                saveOperation = DomHelper.SaveOperation.None;
                _executionContext.EntityFrameworkContext.ClearCache();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException saveException)
            {
                DomHelper.ThrowIfSavingNonexistentId(saveException, checkUserPermissions, saveOperation);
        		Rhetos.RhetosException interpretedException = _sqlUtility.InterpretSqlException(saveException);
        		/*DataStructureInfo WritableOrm OnDatabaseError Common.ReportTemplate*/
                if (checkUserPermissions)
                    Rhetos.Utilities.MsSqlUtility.ThrowIfPrimaryKeyErrorOnInsert(interpretedException, "Common.ReportTemplate");

                if (interpretedException != null)
        			Rhetos.Utilities.ExceptionsUtility.Rethrow(interpretedException);
                var sqlException = _sqlUtility.ExtractSqlException(saveException);
                if (sqlException != null)
                    Rhetos.Utilities.ExceptionsUtility.Rethrow(sqlException);
                throw;
            }

            deleted = null;
            updated = this.Query(updatedNew.Select(item => item.ID));
            IEnumerable<Common.Queryable.Common_ReportTemplate> inserted = this.Query(insertedNew.Select(item => item.ID));

            bool allEffectsCompleted = false;
            try
            {
                /*DataStructureInfo WritableOrm OnSaveTag1 Common.ReportTemplate*/

                /*DataStructureInfo WritableOrm OnSaveTag2 Common.ReportTemplate*/

                Rhetos.Dom.DefaultConcepts.InvalidDataMessage.ValidateOnSave(insertedNew, updatedNew, this, "Common.ReportTemplate");
                allEffectsCompleted = true;
            }
            finally
            {
                if (!allEffectsCompleted)
                    _executionContext.PersistenceTransaction.DiscardChanges();
            }
        }

        public IEnumerable<Rhetos.Dom.DefaultConcepts.InvalidDataMessage> Validate(IList<Guid> ids, bool onSave)
        {
            /*DataStructureInfo WritableOrm OnSaveValidate Common.ReportTemplate*/
            yield break;
        }

        public global::Common.ReportTemplate CreateInstance()
        {
            var _item = new global::Common.ReportTemplate();
            /*DataStructureInfo CreateInstance Common.ReportTemplate*/
            return _item;
        }

        /*DataStructureInfo RepositoryMembers Common.ReportTemplate*/
    }

    /*ModuleInfo HelperNamespaceMembers Common*/
}

/*RepositoryClasses*/