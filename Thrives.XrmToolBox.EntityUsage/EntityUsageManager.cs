using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System.Collections.Generic;
using System.Linq;

namespace Thrives.XrmToolBox.EntityUsage
{
    public enum EntityType { All, Custom, OutOfTheBox,Filter }
    class EntityUsageManager
    {
        private IOrganizationService _service;
        private IEnumerable<EntityMetadata> _metadataList;
        public List<Model.EntityUsageGridModel> Gridlist { get; set; }

        public EntityUsageManager(IOrganizationService service)
        {
            _service = service;
        }

        public void GetEntities(EntityType entityType, string filterText)
        {
            RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest
            {
                EntityFilters = EntityFilters.Entity
            };

            RetrieveAllEntitiesResponse metadataItems = (RetrieveAllEntitiesResponse)_service.Execute(request);
            switch (entityType)
            {
                case EntityType.All:
                    _metadataList = metadataItems.EntityMetadata.Where(x => x.IsValidForAdvancedFind.Value == true);
                    break;
                case EntityType.Custom:
                    _metadataList = metadataItems.EntityMetadata.Where(x => x.IsCustomEntity == true && x.IsValidForAdvancedFind.Value == true);
                    break;
                case EntityType.OutOfTheBox:
                    _metadataList = metadataItems.EntityMetadata.Where(x => x.IsCustomEntity == false && x.IsValidForAdvancedFind.Value == true);
                    break;
                case EntityType.Filter:
                    _metadataList = metadataItems.EntityMetadata.Where(x =>  x.LogicalName.StartsWith(filterText) && x.IsValidForAdvancedFind.Value == true);
                    break;
            }

            Gridlist = _metadataList.Select(x => new Model.EntityUsageGridModel { EntityName = x.SchemaName, EntitySchemaName = x.LogicalName }).ToList();

        }


    }
}
