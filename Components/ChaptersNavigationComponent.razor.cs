using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using blazor2.Models;
using Microsoft.AspNetCore.Components;

namespace blazor2.Components
{
    public partial class ChaptersNavigationComponent : ComponentBase
    {
        [Inject]
        public HttpClient Http { get; set; }

        public List<Problem> Problems { get; set; }
        
        
        protected override async Task OnInitializedAsync()
        {
            var problems = await Http.GetFromJsonAsync<List<Problem>>("url");
            Problems = problems;
        }
    }
}