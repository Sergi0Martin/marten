// <auto-generated/>
#pragma warning disable
using Marten.Internal;
using Marten.Internal.Storage;
using Marten.Schema;
using Marten.Schema.Arguments;
using Marten.Testing.Bugs;
using Npgsql;
using System;
using System.Collections.Generic;
using Weasel.Core;
using Weasel.Postgresql;

namespace Marten.Generated.DocumentStorage
{
    // START: UpsertCarOperation454276853
    public class UpsertCarOperation454276853 : Marten.Internal.Operations.StorageOperation<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>
    {
        private readonly Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpsertCarOperation454276853(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_upsert_bug_1219_ordering_by_attributes_car(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Upsert;
        }

    }

    // END: UpsertCarOperation454276853
    
    
    // START: InsertCarOperation454276853
    public class InsertCarOperation454276853 : Marten.Internal.Operations.StorageOperation<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>
    {
        private readonly Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public InsertCarOperation454276853(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_insert_bug_1219_ordering_by_attributes_car(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
        }


        public override System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            // Nothing
            return System.Threading.Tasks.Task.CompletedTask;
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Insert;
        }

    }

    // END: InsertCarOperation454276853
    
    
    // START: UpdateCarOperation454276853
    public class UpdateCarOperation454276853 : Marten.Internal.Operations.StorageOperation<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>
    {
        private readonly Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car _document;
        private readonly System.Guid _id;
        private readonly System.Collections.Generic.Dictionary<System.Guid, System.Guid> _versions;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public UpdateCarOperation454276853(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, System.Guid id, System.Collections.Generic.Dictionary<System.Guid, System.Guid> versions, Marten.Schema.DocumentMapping mapping) : base(document, id, versions, mapping)
        {
            _document = document;
            _id = id;
            _versions = versions;
            _mapping = mapping;
        }


        public const string COMMAND_TEXT = "select public.mt_update_bug_1219_ordering_by_attributes_car(?, ?, ?, ?)";


        public override string CommandText()
        {
            return COMMAND_TEXT;
        }


        public override NpgsqlTypes.NpgsqlDbType DbType()
        {
            return NpgsqlTypes.NpgsqlDbType.Uuid;
        }


        public override void ConfigureParameters(Npgsql.NpgsqlParameter[] parameters, Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session)
        {
            parameters[0].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Jsonb;
            parameters[0].Value = session.Serializer.ToJson(_document);
            // .Net Class Type
            parameters[1].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Varchar;
            parameters[1].Value = _document.GetType().FullName;
            parameters[2].NpgsqlDbType = NpgsqlTypes.NpgsqlDbType.Uuid;
            parameters[2].Value = document.Id;
            setVersionParameter(parameters[3]);
        }


        public override void Postprocess(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions)
        {
            storeVersion();
            postprocessUpdate(reader, exceptions);
        }


        public override async System.Threading.Tasks.Task PostprocessAsync(System.Data.Common.DbDataReader reader, System.Collections.Generic.IList<System.Exception> exceptions, System.Threading.CancellationToken token)
        {
            storeVersion();
            await postprocessUpdateAsync(reader, exceptions, token);
        }


        public override Marten.Internal.Operations.OperationRole Role()
        {
            return Marten.Internal.Operations.OperationRole.Update;
        }

    }

    // END: UpdateCarOperation454276853
    
    
    // START: QueryOnlyCarSelector454276853
    public class QueryOnlyCarSelector454276853 : Marten.Internal.CodeGeneration.DocumentSelectorWithOnlySerializer, Marten.Linq.Selectors.ISelector<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public QueryOnlyCarSelector454276853(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car Resolve(System.Data.Common.DbDataReader reader)
        {

            Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document;
            document = _serializer.FromJson<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>(reader, 0);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {

            Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>(reader, 0, token).ConfigureAwait(false);
            return document;
        }

    }

    // END: QueryOnlyCarSelector454276853
    
    
    // START: LightweightCarSelector454276853
    public class LightweightCarSelector454276853 : Marten.Internal.CodeGeneration.DocumentSelectorWithVersions<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>, Marten.Linq.Selectors.ISelector<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public LightweightCarSelector454276853(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);

            Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document;
            document = _serializer.FromJson<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);

            Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            return document;
        }

    }

    // END: LightweightCarSelector454276853
    
    
    // START: IdentityMapCarSelector454276853
    public class IdentityMapCarSelector454276853 : Marten.Internal.CodeGeneration.DocumentSelectorWithIdentityMap<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>, Marten.Linq.Selectors.ISelector<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public IdentityMapCarSelector454276853(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document;
            document = _serializer.FromJson<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            return document;
        }

    }

    // END: IdentityMapCarSelector454276853
    
    
    // START: DirtyTrackingCarSelector454276853
    public class DirtyTrackingCarSelector454276853 : Marten.Internal.CodeGeneration.DocumentSelectorWithDirtyChecking<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>, Marten.Linq.Selectors.ISelector<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>
    {
        private readonly Marten.Internal.IMartenSession _session;
        private readonly Marten.Schema.DocumentMapping _mapping;

        public DirtyTrackingCarSelector454276853(Marten.Internal.IMartenSession session, Marten.Schema.DocumentMapping mapping) : base(session, mapping)
        {
            _session = session;
            _mapping = mapping;
        }



        public Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car Resolve(System.Data.Common.DbDataReader reader)
        {
            var id = reader.GetFieldValue<System.Guid>(0);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document;
            document = _serializer.FromJson<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>(reader, 1);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }


        public async System.Threading.Tasks.Task<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car> ResolveAsync(System.Data.Common.DbDataReader reader, System.Threading.CancellationToken token)
        {
            var id = await reader.GetFieldValueAsync<System.Guid>(0, token);
            if (_identityMap.TryGetValue(id, out var existing)) return existing;

            Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document;
            document = await _serializer.FromJsonAsync<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>(reader, 1, token).ConfigureAwait(false);
            _session.MarkAsDocumentLoaded(id, document);
            _identityMap[id] = document;
            StoreTracker(_session, document);
            return document;
        }

    }

    // END: DirtyTrackingCarSelector454276853
    
    
    // START: QueryOnlyCarDocumentStorage454276853
    public class QueryOnlyCarDocumentStorage454276853 : Marten.Internal.Storage.QueryOnlyDocumentStorage<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public QueryOnlyCarDocumentStorage454276853(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateCarOperation454276853
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertCarOperation454276853
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertCarOperation454276853
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.QueryOnlyCarSelector454276853(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: QueryOnlyCarDocumentStorage454276853
    
    
    // START: LightweightCarDocumentStorage454276853
    public class LightweightCarDocumentStorage454276853 : Marten.Internal.Storage.LightweightDocumentStorage<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public LightweightCarDocumentStorage454276853(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateCarOperation454276853
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertCarOperation454276853
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertCarOperation454276853
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.LightweightCarSelector454276853(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: LightweightCarDocumentStorage454276853
    
    
    // START: IdentityMapCarDocumentStorage454276853
    public class IdentityMapCarDocumentStorage454276853 : Marten.Internal.Storage.IdentityMapDocumentStorage<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public IdentityMapCarDocumentStorage454276853(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateCarOperation454276853
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertCarOperation454276853
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertCarOperation454276853
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.IdentityMapCarSelector454276853(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: IdentityMapCarDocumentStorage454276853
    
    
    // START: DirtyTrackingCarDocumentStorage454276853
    public class DirtyTrackingCarDocumentStorage454276853 : Marten.Internal.Storage.DirtyCheckedDocumentStorage<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>
    {
        private readonly Marten.Schema.DocumentMapping _document;

        public DirtyTrackingCarDocumentStorage454276853(Marten.Schema.DocumentMapping document) : base(document)
        {
            _document = document;
        }



        public override System.Guid AssignIdentity(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, string tenantId, Marten.Storage.IMartenDatabase database)
        {
            if (document.Id == Guid.Empty) _setter(document, Marten.Schema.Identity.CombGuidIdGeneration.NewGuid());
            return document.Id;
        }


        public override Marten.Internal.Operations.IStorageOperation Update(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpdateCarOperation454276853
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Insert(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.InsertCarOperation454276853
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Upsert(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {

            return new Marten.Generated.DocumentStorage.UpsertCarOperation454276853
            (
                document, Identity(document),
                session.Versions.ForType<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>(),
                _document
                
            );
        }


        public override Marten.Internal.Operations.IStorageOperation Overwrite(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Internal.IMartenSession session, string tenant)
        {
            throw new System.NotSupportedException();
        }


        public override System.Guid Identity(Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document)
        {
            return document.Id;
        }


        public override Marten.Linq.Selectors.ISelector BuildSelector(Marten.Internal.IMartenSession session)
        {
            return new Marten.Generated.DocumentStorage.DirtyTrackingCarSelector454276853(session, _document);
        }


        public override Npgsql.NpgsqlCommand BuildLoadCommand(System.Guid id, string tenant)
        {
            return new NpgsqlCommand(_loaderSql).With("id", id);
        }


        public override Npgsql.NpgsqlCommand BuildLoadManyCommand(System.Guid[] ids, string tenant)
        {
            return new NpgsqlCommand(_loadArraySql).With("ids", ids);
        }

    }

    // END: DirtyTrackingCarDocumentStorage454276853
    
    
    // START: CarBulkLoader454276853
    public class CarBulkLoader454276853 : Marten.Internal.CodeGeneration.BulkLoader<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid>
    {
        private readonly Marten.Internal.Storage.IDocumentStorage<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid> _storage;

        public CarBulkLoader454276853(Marten.Internal.Storage.IDocumentStorage<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car, System.Guid> storage) : base(storage)
        {
            _storage = storage;
        }


        public const string MAIN_LOADER_SQL = "COPY public.mt_doc_bug_1219_ordering_by_attributes_car(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string TEMP_LOADER_SQL = "COPY mt_doc_bug_1219_ordering_by_attributes_car_temp(\"mt_dotnet_type\", \"id\", \"mt_version\", \"data\") FROM STDIN BINARY";

        public const string COPY_NEW_DOCUMENTS_SQL = "insert into public.mt_doc_bug_1219_ordering_by_attributes_car (\"id\", \"data\", \"mt_version\", \"mt_dotnet_type\", mt_last_modified) (select mt_doc_bug_1219_ordering_by_attributes_car_temp.\"id\", mt_doc_bug_1219_ordering_by_attributes_car_temp.\"data\", mt_doc_bug_1219_ordering_by_attributes_car_temp.\"mt_version\", mt_doc_bug_1219_ordering_by_attributes_car_temp.\"mt_dotnet_type\", transaction_timestamp() from mt_doc_bug_1219_ordering_by_attributes_car_temp left join public.mt_doc_bug_1219_ordering_by_attributes_car on mt_doc_bug_1219_ordering_by_attributes_car_temp.id = public.mt_doc_bug_1219_ordering_by_attributes_car.id where public.mt_doc_bug_1219_ordering_by_attributes_car.id is null)";

        public const string OVERWRITE_SQL = "update public.mt_doc_bug_1219_ordering_by_attributes_car target SET data = source.data, mt_version = source.mt_version, mt_dotnet_type = source.mt_dotnet_type, mt_last_modified = transaction_timestamp() FROM mt_doc_bug_1219_ordering_by_attributes_car_temp source WHERE source.id = target.id";

        public const string CREATE_TEMP_TABLE_FOR_COPYING_SQL = "create temporary table mt_doc_bug_1219_ordering_by_attributes_car_temp as select * from public.mt_doc_bug_1219_ordering_by_attributes_car limit 0";


        public override void LoadRow(Npgsql.NpgsqlBinaryImporter writer, Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer)
        {
            writer.Write(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar);
            writer.Write(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid);
            writer.Write(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb);
        }


        public override async System.Threading.Tasks.Task LoadRowAsync(Npgsql.NpgsqlBinaryImporter writer, Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car document, Marten.Storage.Tenant tenant, Marten.ISerializer serializer, System.Threading.CancellationToken cancellation)
        {
            await writer.WriteAsync(document.GetType().FullName, NpgsqlTypes.NpgsqlDbType.Varchar, cancellation);
            await writer.WriteAsync(document.Id, NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(Marten.Schema.Identity.CombGuidIdGeneration.NewGuid(), NpgsqlTypes.NpgsqlDbType.Uuid, cancellation);
            await writer.WriteAsync(serializer.ToJson(document), NpgsqlTypes.NpgsqlDbType.Jsonb, cancellation);
        }


        public override string MainLoaderSql()
        {
            return MAIN_LOADER_SQL;
        }


        public override string TempLoaderSql()
        {
            return TEMP_LOADER_SQL;
        }


        public override string CreateTempTableForCopying()
        {
            return CREATE_TEMP_TABLE_FOR_COPYING_SQL;
        }


        public override string CopyNewDocumentsFromTempTable()
        {
            return COPY_NEW_DOCUMENTS_SQL;
        }


        public override string OverwriteDuplicatesFromTempTable()
        {
            return OVERWRITE_SQL;
        }

    }

    // END: CarBulkLoader454276853
    
    
    // START: CarProvider454276853
    public class CarProvider454276853 : Marten.Internal.Storage.DocumentProvider<Marten.Testing.Bugs.Bug_1219_ordering_by_attributes.Car>
    {
        private readonly Marten.Schema.DocumentMapping _mapping;

        public CarProvider454276853(Marten.Schema.DocumentMapping mapping) : base(new CarBulkLoader454276853(new QueryOnlyCarDocumentStorage454276853(mapping)), new QueryOnlyCarDocumentStorage454276853(mapping), new LightweightCarDocumentStorage454276853(mapping), new IdentityMapCarDocumentStorage454276853(mapping), new DirtyTrackingCarDocumentStorage454276853(mapping))
        {
            _mapping = mapping;
        }


    }

    // END: CarProvider454276853
    
    
}
