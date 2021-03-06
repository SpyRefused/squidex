﻿// ==========================================================================
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex UG (haftungsbeschränkt)
//  All rights reserved. Licensed under the MIT license.
// ==========================================================================

using GraphQL.Resolvers;
using GraphQL.Types;
using Squidex.Domain.Apps.Core;
using Squidex.Domain.Apps.Core.Schemas;
using Squidex.Domain.Apps.Entities.Contents.GraphQL.Types;
using Squidex.Domain.Apps.Entities.Schemas;
using Squidex.Infrastructure;

namespace Squidex.Domain.Apps.Entities.Contents.GraphQL
{
    public interface IGraphModel
    {
        bool CanGenerateAssetSourceUrl { get; }

        IFieldPartitioning ResolvePartition(Partitioning key);

        IFieldResolver ResolveAssetUrl();

        IFieldResolver ResolveAssetSourceUrl();

        IFieldResolver ResolveAssetThumbnailUrl();

        IFieldResolver ResolveContentUrl(ISchemaEntity schema);

        IObjectGraphType GetAssetType();

        IObjectGraphType GetContentType(DomainId schemaId);

        (IGraphType?, ValueResolver?, QueryArguments?) GetGraphType(ISchemaEntity schema, IField field, string fieldName);
    }
}
