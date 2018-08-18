using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thrives.XrmToolBox.EntityUsage.Model
{
    public class EntityUsageGridModel
    {
        public string EntityName { get; set; }
        public string EntitySchemaName { get; set; }
        public int RecordCount { get; set; }
    }
    public static class EntityUsageExtensions
    {
        public static void Count(this EntityUsageGridModel entityUsage, IOrganizationService service)
        {

            int totalCount = 0;

            QueryExpression query = new QueryExpression(entityUsage.EntitySchemaName);
            query.ColumnSet = new ColumnSet();
            query.Distinct = true;
            query.ColumnSet = new ColumnSet(false);
            query.PageInfo = new PagingInfo();
            query.PageInfo.Count = 5000;
            query.PageInfo.PageNumber = 1;
            query.PageInfo.ReturnTotalRecordCount = true;

            EntityCollection entityCollection = service.RetrieveMultiple(query);
            totalCount = entityCollection.Entities.Count;

            while (entityCollection.MoreRecords)
            {
                query.PageInfo.PageNumber += 1;
                query.PageInfo.PagingCookie = entityCollection.PagingCookie;
                entityCollection = service.RetrieveMultiple(query);
                totalCount = totalCount + entityCollection.Entities.Count;
            }

            entityUsage.RecordCount = totalCount;
           
        }
    }
}
