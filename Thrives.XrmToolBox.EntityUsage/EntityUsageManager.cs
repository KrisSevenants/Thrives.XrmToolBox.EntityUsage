using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using System.Collections.Generic;
using System.Linq;

namespace Thrives.XrmToolBox.EntityUsage
{
    public enum EntityType { All, Custom,Customizable,  OutOfTheBox, Filter }
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
            string[] filterarray = filterText.Split(';');
            RetrieveAllEntitiesRequest request = new RetrieveAllEntitiesRequest
            {
                EntityFilters = EntityFilters.Attributes
            };

            RetrieveAllEntitiesResponse metadataItems = (RetrieveAllEntitiesResponse)_service.Execute(request);
            switch (entityType)
            {
                case EntityType.All:
                    _metadataList = metadataItems.EntityMetadata.Where(x => x.IsValidForAdvancedFind.Value == true && x.DataSourceId.HasValue == false);
                    break;
                case EntityType.Custom:
                    _metadataList = metadataItems.EntityMetadata.Where(x => x.IsCustomEntity == true && x.IsValidForAdvancedFind.Value == true && x.DataSourceId.HasValue == false);
                    break;
                case EntityType.Customizable:
                    _metadataList = metadataItems.EntityMetadata.Where(x => x.IsCustomizable.Value == true && x.IsValidForAdvancedFind.Value == true && x.DataSourceId.HasValue == false);
                    break;
                case EntityType.OutOfTheBox:
                    _metadataList = metadataItems.EntityMetadata.Where(x => x.IsCustomEntity == false && x.IsValidForAdvancedFind.Value == true && x.DataSourceId.HasValue == false);
                    break;
               
                case EntityType.Filter:
                    _metadataList = metadataItems.EntityMetadata.Where(x => filterarray.Any(f => x.LogicalName.StartsWith(f)) && x.IsValidForAdvancedFind.Value == true && x.DataSourceId.HasValue == false);
                    break;
            }

            Gridlist = _metadataList.Select(x => new Model.EntityUsageGridModel { EntityName = x.SchemaName, EntitySchemaName = x.LogicalName,NumberOfCustomAttributes =  x.Attributes.Where(a=>a.IsCustomAttribute == true && x.DataSourceId.HasValue == false).Count() , HasModificationDates = x.Attributes.Where(z=> z.LogicalName.Equals("modifiedon") ).Count() > 0 }).ToList();

        }


    }
}
