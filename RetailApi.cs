using Google.Api.Gax.ResourceNames;
using Google.Cloud.Retail.V2;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoogleCloudSamples
{
    public class RetailSearch
    {
        public async Task<SearchResponse> SearchAsync(string projectId, string locationId, string catalogId, string query)
        {
            // Create the client.
            SearchServiceClient client = await SearchServiceClient.CreateAsync();

            // Build the search query.
            SearchRequest request = new SearchRequest
            {
                Placement = new PlacementName(projectId, locationId, catalogId, "default_search").ToString(),
                VisitorId = "visitor0",
                Query = query,
                // Filter = "",
                // CanonicalFilter = "",
                //OrderBy = "",
                // PageSize = 0,
                // PageToken = "",
                // Offset = 0,
                // FacetSpecs = { new FacetSpec(), },
                // VariantRollupKeys = { "", },
                // PageCategories = { "", },
                // QueryExpansionSpec = new QueryExpansionSpec(),
                // SpellCorrectionSpec = new SpellCorrectionSpec(),
                // UserInfo = new UserInfo(),
                // Labels = { { "", "" }, },
                // BoostSpec = new BoostSpec(),
                // DynamicFacetSpec = new DynamicFacetSpec(),
                // OrderByExpression = "",
            };

            // Call the API.
            SearchResponse response = await client.SearchAsync(request);

            // Return the result.
            return response;
        }
    }
}  
