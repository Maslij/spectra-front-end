// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Spectra.Model.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Spectra.Model.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\_Imports.razor"
using Spectra.Model.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
using Spectra.Model.Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/project/{projectId}")]
    public partial class CustomVisionProject : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 133 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
       
    [Parameter]
    public string ProjectId { get; set; }

    // Objects
    private Project customVisionProject;
    private IList<Iteration> projectIteration = new List<Iteration>();
    private IList<Tag> projectTags = new List<Tag>();
    private IDictionary<Guid, IterationPerformance> _iterationPerformance = new Dictionary<Guid, IterationPerformance>();
    private IDictionary<Guid, int?> _iterationTaggedImages = new Dictionary<Guid, int?>();

    private double probabilityThreshold = .6;
    Spectra.Model.Client.Models.Export exportedProject;

    // Stats
    private int? taggedImageCount;
    private int? untaggedImageCount;
    private bool updatingPerformance = false;

    // Custom Vision Settings
    private string TrainingKey = "c750b0db2467468c87352d069d4a38e2";
    private string Endpoint = "https://spectra-video-analytics.cognitiveservices.azure.com/";
    private CustomVisionTrainingClient trainingApi;

    // Exporting
    private bool exportingProject;
    private string exportingProjectStatus;
    private string exportType = "customvision";
    private Guid selectedIteration;
    private bool activateExporting = false;

    protected async Task ConnectToCustomVision()
    {


        try
        {
            customVisionProject = await trainingApi.GetProjectAsync(Guid.Parse(ProjectId));
            projectIteration = await trainingApi.GetIterationsAsync(customVisionProject.Id);
            taggedImageCount = await trainingApi.GetTaggedImageCountAsync(customVisionProject.Id);
            untaggedImageCount = await trainingApi.GetUntaggedImageCountAsync(customVisionProject.Id);
            projectTags = await trainingApi.GetTagsAsync(customVisionProject.Id);


            foreach (var iteration in projectIteration)
            {
                _iterationPerformance.Add(iteration.Id, await trainingApi.GetIterationPerformanceAsync(customVisionProject.Id, iteration.Id, threshold: probabilityThreshold));
                _iterationTaggedImages[iteration.Id] = await trainingApi.GetTaggedImageCountAsync(customVisionProject.Id, iterationId: iteration.Id);

            }
        }
        catch
        {

        }
    }

    protected async Task QuickTest()
    {

    }

    protected async Task UpdatePerformance(ChangeEventArgs e)
    {
        updatingPerformance = true;
        probabilityThreshold = Convert.ToDouble(e.Value.ToString()) / 100;

        foreach (var iteration in projectIteration)
        {
            _iterationPerformance[iteration.Id] = await trainingApi.GetIterationPerformanceAsync(customVisionProject.Id, iteration.Id, threshold: probabilityThreshold);
            _iterationTaggedImages[iteration.Id] = await trainingApi.GetTaggedImageCountAsync(customVisionProject.Id, iterationId: iteration.Id);
        }
        updatingPerformance = false;

    }

    protected override async Task OnInitializedAsync()
    {
        trainingApi = _customVisionService.AuthenticateTraining(Endpoint, TrainingKey);
        ProjectId = ProjectId ?? null;
        await ConnectToCustomVision();
    }

    protected void SetIterationId(Guid IterationId)
    {
        if (!activateExporting)
            activateExporting = true;
        selectedIteration = IterationId;
    }

    async Task GetProjectWithImagesAndRegions(Guid projectId)
    {

        exportingProject = true;
        exportedProject = null;
        exportingProjectStatus = "Retrieving project.";
        var json_dict = new Dictionary<string, string>
{
            { "Endpoint", Endpoint },
            { "TrainingKey", TrainingKey }
        };

        var url = $"https://spectra-model-api.azurewebsites.net/api/project/{projectId}/images/{exportType}/{selectedIteration}";
        var json = JsonConvert.SerializeObject(json_dict);

        var request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri(url),
            Content = new StringContent(json, Encoding.UTF8, "application/json"),
        };

        exportingProjectStatus = "Exporting annotations. This might take a while.";

        var client = clientFactory.CreateClient();
        var response = await client.SendAsync(request);

        //var response = await client.SendAsync(request).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);

        exportedProject = JsonConvert.DeserializeObject<Spectra.Model.Client.Models.Export>(responseBody);

        exportingProject = false;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomVisionService _customVisionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory clientFactory { get; set; }
    }
}
#pragma warning restore 1591
