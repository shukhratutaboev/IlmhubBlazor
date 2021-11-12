using Microsoft.AspNetCore.Components;

namespace blazor2.Pages
{
    public partial class Chapter : ComponentBase
    {
        [Parameter]
        public string Id { get; set; }
        private string strId(string Id)
        {
            return $"chapters/{Id}";
        }
    }
}