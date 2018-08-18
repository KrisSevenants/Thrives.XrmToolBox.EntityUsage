using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System.Collections.Generic;
using System.Linq;

namespace Thrives.XrmToolBox.EntityUsage
{
    class EntityUsageManager
    {
        private IOrganizationService _service;
        private IEnumerable<EntityMetadata> _metadataList;
        public List<Model.EntityUsageGridModel> Gridlist { get; set; }

        public EntityUsageManager(IOrganizationService service)
        {
            _service = service;
        }

        public void GetEntities()
        {
            RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest
            {
                EntityFilters = EntityFilters.Default
            };

            RetrieveAllEntitiesResponse metadataItems = (RetrieveAllEntitiesResponse)_service.Execute(request);
            _metadataList = metadataItems.EntityMetadata.Where(x => x.IsValidForAdvancedFind.Value);

            Gridlist =  _metadataList.Select(x => new Model.EntityUsageGridModel { EntityName = x.SchemaName, EntitySchemaName = x.LogicalName }).ToList();

        }

        
    }
}
