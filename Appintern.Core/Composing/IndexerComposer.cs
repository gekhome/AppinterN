using Examine;
using Examine.Providers;
using System;
using System.Collections.Generic;
using Umbraco.Core;
using Umbraco.Core.Composing;
using Umbraco.Web;
using static Umbraco.Core.Constants;

namespace Appintern.Core.Composing
{
    public class IndexerComposer : IUserComposer
    {
        public void Compose(Composition composition)
        {
            composition.Components().Append<IndexerComponent>();
        }

        public class IndexerComponent : IComponent
        {
            private readonly IExamineManager _examineManager;
            private readonly IUmbracoContextFactory _umbracoContextFactory;

            public IndexerComponent(IExamineManager examineManager, IUmbracoContextFactory umbracoContextFactory)
            {
                _examineManager = examineManager;
                _umbracoContextFactory = umbracoContextFactory ?? throw new ArgumentNullException(nameof(umbracoContextFactory));
            }

            public void Initialize()
            {
                if (!_examineManager.TryGetIndex(UmbracoIndexes.ExternalIndexName, out IIndex index))
                    return;

                index.FieldDefinitionCollection.AddOrUpdate(new FieldDefinition("searchableCategories", FieldDefinitionTypes.FullText));

                index.FieldDefinitionCollection.AddOrUpdate(new FieldDefinition("stringJobSector", FieldDefinitionTypes.FullText));
                index.FieldDefinitionCollection.AddOrUpdate(new FieldDefinition("stringDuration", FieldDefinitionTypes.FullText));
                index.FieldDefinitionCollection.AddOrUpdate(new FieldDefinition("stringCommitment", FieldDefinitionTypes.FullText));
                index.FieldDefinitionCollection.AddOrUpdate(new FieldDefinition("stringCompensation", FieldDefinitionTypes.FullText));
                index.FieldDefinitionCollection.AddOrUpdate(new FieldDefinition("stringStatus", FieldDefinitionTypes.FullText));

                ((BaseIndexProvider)index).TransformingIndexValues += IndexerComponent_TransformingIndexValues;
                ((BaseIndexProvider)index).TransformingIndexValues += IndexerComponent_TransformIndexValues;
            }

            private void IndexerComponent_TransformingIndexValues(object sender, IndexingItemEventArgs e)
            {
                if (int.TryParse(e.ValueSet.Id, out var nodeId))
                {
                    switch (e.ValueSet.ItemType)
                    {
                        case "article":
                        case "content":
                        case "apprenticeship":
                        case "clientPage":
                            using (var umbracoContext = _umbracoContextFactory.EnsureUmbracoContext())
                            {
                                var contentNode = umbracoContext.UmbracoContext.Content.GetById(nodeId);
                                if (contentNode != null)
                                {
                                    var categories = contentNode.Value<IEnumerable<string>>("category");
                                    if (categories != null)
                                    {
                                        e.ValueSet.Set("searchableCategories", string.Join(",", categories));
                                    }
                                }
                            }
                            break;
                    }
                }
            }

            private void IndexerComponent_TransformIndexValues(object sender, IndexingItemEventArgs e)
            {
                if (int.TryParse(e.ValueSet.Id, out var nodeId))
                {
                    switch (e.ValueSet.ItemType)
                    {
                        case "apprenticeship":
                            using (var umbracoContext = _umbracoContextFactory.EnsureUmbracoContext())
                            {
                                var contentNode = umbracoContext.UmbracoContext.Content.GetById(nodeId);
                                if (contentNode != null)
                                {
                                    var jobSector = contentNode.Value<string>("jobSector");
                                    var duration = contentNode.Value<string>("duration");
                                    var commitment = contentNode.Value<string>("commitment");
                                    var compensation = contentNode.Value<string>("compensation");
                                    var status = contentNode.Value<string>("status");
                                    if (jobSector != null)
                                    {
                                        e.ValueSet.Set("stringJobSector", jobSector);
                                    }
                                    if (duration != null)
                                    {
                                        e.ValueSet.Set("stringDuration", duration);
                                    }
                                    if (commitment != null)
                                    {
                                        e.ValueSet.Set("stringCommitment", commitment);
                                    }
                                    if (compensation != null)
                                    {
                                        e.ValueSet.Set("stringCompensation", compensation);
                                    }
                                    if (status != null)
                                    {
                                        e.ValueSet.Set("stringStatus", status);
                                    }
                                }
                            }
                            break;
                    }
                }
            }

            public void Terminate()
            {
                // nothing to terminate
            }
        }
    }
}
