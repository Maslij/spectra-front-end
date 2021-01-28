#pragma checksum "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50357c8447a84bf0b8f2b5d6d8db98cbc8b7f372"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
using Microsoft.Azure.CognitiveServices.Vision.CustomVision.Training;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
using Spectra.Model.Client.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
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
#nullable restore
#line 17 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
 if (customVisionProject == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<i class=\"fas fa-spinner fa-spin\"></i>");
#nullable restore
#line 20 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "span");
            __builder.AddAttribute(2, "class", "badge badge-primary");
            __builder.AddContent(3, 
#nullable restore
#line 23 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                        taggedImageCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " Tagged Images");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n    ");
            __builder.OpenElement(6, "span");
            __builder.AddAttribute(7, "class", "badge badge-warning");
            __builder.AddContent(8, 
#nullable restore
#line 24 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                        untaggedImageCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(9, " Untagged Images");
            __builder.CloseElement();
            __builder.OpenElement(10, "h1");
            __builder.AddContent(11, 
#nullable restore
#line 26 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
         customVisionProject.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "p");
            __builder.AddContent(14, 
#nullable restore
#line 27 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
        customVisionProject.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "<h2>Tags</h2>");
#nullable restore
#line 30 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
     foreach (var tag in projectTags)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "badge badge-success mr-1");
            __builder.AddContent(18, 
#nullable restore
#line 32 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                tag.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<h2 class=\"pt-3\">Iterations</h2>\r\n    ");
            __builder.AddMarkupContent(20, "<p>Select a published Iteration to display the model performance.</p>\r\n    ");
            __builder.AddMarkupContent(21, "<label>Probability Threshold</label>\r\n    ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "slidecontainer");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                          UpdatePerformance

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "type", "range");
            __builder.AddAttribute(27, "min", "1");
            __builder.AddAttribute(28, "max", "100");
            __builder.AddAttribute(29, "class", "slider");
            __builder.AddAttribute(30, "id", "myRange");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    ");
            __builder.OpenElement(32, "p");
            __builder.AddContent(33, 
#nullable restore
#line 41 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
        probabilityThreshold

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "col-4");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "list-group");
            __builder.AddAttribute(41, "id", "list-tab");
            __builder.AddAttribute(42, "role", "tablist");
#nullable restore
#line 45 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                 foreach (var iteration in projectIteration)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "class", "list-group-item list-group-item-action d-flex justify-content-between align-items-center");
            __builder.AddAttribute(45, "id", "list-" + (
#nullable restore
#line 47 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                                                                                  iteration.Id

#line default
#line hidden
#nullable disable
            ) + "-list");
            __builder.AddAttribute(46, "data-toggle", "list");
            __builder.AddAttribute(47, "href", "#list-" + (
#nullable restore
#line 47 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                                                                                                                                     iteration.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddEventPreventDefaultAttribute(48, "onclick", 
#nullable restore
#line 48 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                true

#line default
#line hidden
#nullable disable
            );
            __builder.AddEventStopPropagationAttribute(49, "onclick", 
#nullable restore
#line 49 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                 true

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                 () => SetIterationId(iteration.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "role", "tab");
            __builder.AddContent(52, 
#nullable restore
#line 51 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                         iteration.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(53, "    ");
            __builder.OpenElement(54, "span");
            __builder.AddAttribute(55, "class", "badge badge-primary badge-pill");
            __builder.AddContent(56, "Trained on ");
            __builder.AddContent(57, 
#nullable restore
#line 51 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                                                    _iterationTaggedImages[iteration.Id]

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(58, " Tagged Images");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 53 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "col-8");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "tab-content");
#nullable restore
#line 58 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                 foreach (var iteration in projectIteration)
                {
                    var setPrecision = $"{Math.Round(_iterationPerformance[iteration.Id].Precision, 2) * 100}%";
                    var setRecall = $"{Math.Round(_iterationPerformance[iteration.Id].Recall, 2) * 100}%";
                    var setmAP = $"{Math.Round((double)_iterationPerformance[iteration.Id].AveragePrecision, 2) * 100}%";


#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "div");
            __builder.AddAttribute(65, "class", "tab-pane");
            __builder.AddAttribute(66, "id", "list-" + (
#nullable restore
#line 64 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                    iteration.Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "role", "tabpanel");
#nullable restore
#line 65 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                         if (updatingPerformance)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "<i class=\"fas fa-spinner fa-spin\"></i>");
#nullable restore
#line 68 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(69, "p");
            __builder.AddContent(70, "Finished training on ");
            __builder.OpenElement(71, "strong");
            __builder.AddContent(72, 
#nullable restore
#line 71 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                             DateTime.Parse(iteration.TrainedAt.ToString()).ToLocalTime()

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                            ");
            __builder.OpenElement(74, "p");
            __builder.AddContent(75, "Iteration Id: ");
            __builder.OpenElement(76, "strong");
            __builder.AddContent(77, 
#nullable restore
#line 72 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                      iteration.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                            ");
            __builder.AddMarkupContent(79, "<p>Precision</p>\r\n                            ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "progress");
            __builder.OpenElement(82, "div");
            __builder.AddAttribute(83, "class", "progress-bar");
            __builder.AddAttribute(84, "role", "progressbar");
            __builder.AddAttribute(85, "style", "width:" + (
#nullable restore
#line 75 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                                           setPrecision

#line default
#line hidden
#nullable disable
            ) + ";" + " background-color:#9a0089;");
            __builder.AddAttribute(86, "aria-valuenow", 
#nullable restore
#line 75 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                                                                                                    _iterationPerformance[iteration.Id].Precision

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(87, "aria-valuemin", "0");
            __builder.AddAttribute(88, "aria-valuemax", "100");
            __builder.AddContent(89, 
#nullable restore
#line 76 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                     setPrecision

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                            ");
            __builder.AddMarkupContent(91, "<p>Recall</p>\r\n                            ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", "progress");
            __builder.OpenElement(94, "div");
            __builder.AddAttribute(95, "class", "progress-bar");
            __builder.AddAttribute(96, "role", "progressbar");
            __builder.AddAttribute(97, "style", "width:" + (
#nullable restore
#line 81 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                                           setRecall

#line default
#line hidden
#nullable disable
            ) + ";" + " background-color:#0063b1;");
            __builder.AddAttribute(98, "aria-valuenow", 
#nullable restore
#line 81 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                                                                                                 _iterationPerformance[iteration.Id].Recall

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(99, "aria-valuemin", "0");
            __builder.AddAttribute(100, "aria-valuemax", "100");
            __builder.AddContent(101, 
#nullable restore
#line 82 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                     setRecall

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.AddMarkupContent(103, "<p>mAP</p>\r\n                            ");
            __builder.OpenElement(104, "div");
            __builder.AddAttribute(105, "class", "progress");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "progress-bar");
            __builder.AddAttribute(108, "role", "progressbar");
            __builder.AddAttribute(109, "style", "width:" + (
#nullable restore
#line 87 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                                           setmAP

#line default
#line hidden
#nullable disable
            ) + ";" + " background-color:#69c138;");
            __builder.AddAttribute(110, "aria-valuenow", 
#nullable restore
#line 87 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                                                                                              _iterationPerformance[iteration.Id].AveragePrecision

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(111, "aria-valuemin", "0");
            __builder.AddAttribute(112, "aria-valuemax", "100");
            __builder.AddContent(113, 
#nullable restore
#line 88 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                     setmAP

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(114);
            __builder.AddAttribute(115, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
#nullable restore
#line 94 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                     if (activateExporting)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "btn-toolbar pt-5");
                __builder2.AddAttribute(118, "role", "toolbar");
                __builder2.AddAttribute(119, "aria-label", "Toolbar with button groups");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "btn-group mr-2");
                __builder2.AddAttribute(122, "role", "group");
                __builder2.AddAttribute(123, "aria-label", "First group");
                __builder2.OpenElement(124, "button");
                __builder2.AddAttribute(125, "disabled", 
#nullable restore
#line 98 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                   exportingProject

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(126, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 98 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                                               () => GetProjectWithImagesAndRegions(Guid.Parse(ProjectId))

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(127, "class", "btn btn-primary");
                __builder2.AddContent(128, "Export Data");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(129, "\r\n                                            ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "btn-group mr-2");
                __builder2.AddAttribute(132, "role", "group");
                __builder2.AddAttribute(133, "aria-label", "Second group");
                __builder2.OpenElement(134, "select");
                __builder2.AddAttribute(135, "class", "custom-select");
                __builder2.AddAttribute(136, "id", "inputGroupSelect03");
                __builder2.AddAttribute(137, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 101 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                               exportType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(138, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => exportType = __value, exportType));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(139, "option");
                __builder2.AddAttribute(140, "value", "customvision");
                __builder2.AddAttribute(141, "selected");
                __builder2.AddContent(142, "Custom Vision");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n                                                    ");
                __builder2.OpenElement(144, "option");
                __builder2.AddAttribute(145, "value", "pascal");
                __builder2.AddContent(146, "Pascal");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 107 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(147, "<p>Select an Iteration to export.</p>");
#nullable restore
#line 111 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 113 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                     if (exportingProject)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(148, "div");
                __builder2.AddAttribute(149, "class", "alert alert-info mt-2");
                __builder2.AddAttribute(150, "role", "alert");
                __builder2.AddAttribute(151, "style", "text-align:center;");
                __builder2.AddMarkupContent(152, "<i class=\"fas fa-spinner fa-spin\"></i>\r\n                                            ");
                __builder2.OpenElement(153, "span");
                __builder2.AddContent(154, 
#nullable restore
#line 117 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                   exportingProjectStatus

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 119 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 120 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                     if (exportedProject != null)
                                    {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(155, "div");
                __builder2.AddAttribute(156, "class", "alert alert-info mt-2");
                __builder2.AddAttribute(157, "role", "alert");
                __builder2.AddMarkupContent(158, "\r\n                                            Export Completed, ");
                __builder2.OpenElement(159, "a");
                __builder2.AddAttribute(160, "href", 
#nullable restore
#line 123 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                        exportedProject.ZippedProject

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(161, "download", 
#nullable restore
#line 123 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                                                                                  exportedProject.ProjectId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(162, "target", "_top");
                __builder2.AddMarkupContent(163, "\r\n                                                download\r\n                                            ");
                __builder2.CloseElement();
                __builder2.AddContent(164, " ");
                __builder2.AddContent(165, 
#nullable restore
#line 125 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                                  exportedProject.ProjectId

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(166, " is ready!\r\n                                        ");
                __builder2.CloseElement();
#nullable restore
#line 127 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                                    }

#line default
#line hidden
#nullable disable
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 130 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 132 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 136 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 138 "C:\Users\Alec\source\spectra\Spectra.Model.Client\Spectra.Model.Client\Pages\CustomVisionProject.razor"
       
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
        client.Timeout = TimeSpan.FromMinutes(20);

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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ModelApiService _modelApiService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CustomVisionService _customVisionService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpClientFactory clientFactory { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IConfiguration Configuration { get; set; }
    }
}
#pragma warning restore 1591
