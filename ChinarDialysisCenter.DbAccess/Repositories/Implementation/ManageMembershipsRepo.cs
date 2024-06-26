using ChinarDialysisCenter.Domain;
using System.Data.SqlClient;
using Dapper;

namespace ChinarDialysisCenter.DbAccess.Repositories.Implementation
{
    public class ManageMembershipsRepo : IManageMembershipsRepo
    {
        public async Task<bool> AddMembership(Membership membership)
        {
            bool result = false;
            string insertQuery = $@"Insert into tbl_datapoint_source_result(title,fk_section_id,fk_datasource_id,fk_document_id,fk_datasource_rule_id,start_index,end_index,created_on,fk_entry_source_id,accession_number,fk_project_id) 
                                  values (@HeadingName,@HeadingId,@SourceId,@DocumentId,@SourceRuleId,@StartIndex,@EndIndex,NOW(),@EntrySourceId,@AccessionNumber,@ProjectId);";
            using (var connection = new SqlConnection(DBHelper.GetConnectionString()))
            {
                result = await connection.ExecuteAsync(insertQuery, membership) > 0 ? true : false;
            }
            return result;
        }
    }
}
