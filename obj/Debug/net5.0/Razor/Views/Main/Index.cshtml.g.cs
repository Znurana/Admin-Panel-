#pragma checksum "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15cbec57192a64f7fbad0f9ba595893a8527d2bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_Index), @"mvc.1.0.view", @"/Views/Main/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\repos\Test_AdminPanel\Views\_ViewImports.cshtml"
using Test_AdminPanel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
using Test_AdminPanel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15cbec57192a64f7fbad0f9ba595893a8527d2bf", @"/Views/Main/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e10c7711f376dd0ba32ea94d9a38a651d915dcb3", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PaginatedList<Test_AdminPanel.Models.User>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexS", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Main", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 12 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cbec57192a64f7fbad0f9ba595893a8527d2bf6869", async() => {
                WriteLiteral("\r\n    <script src=\"https://unpkg.com/sweetalert/dist/sweetalert.min.js\"></script>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cbec57192a64f7fbad0f9ba595893a8527d2bf7216", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<h2 style=""text-align:center""> User List</h2>

<div class=""page-body"">
    <div class=""container-fluid"">
        <div class=""page-header"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <h3>Users</h3>

                </div>
                <div class=""col-sm-6"">
");
            WriteLiteral("                    <div class=\"bookmark\">\r\n                        <ul>\r\n                            <li><a href=\"javascript:void(0)\" data-container=\"body\" data-bs-toggle=\"popover\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 966, "\"", 974, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Tables\"><i data-feather=\"inbox\"></i></a></li>\r\n                            <li><a href=\"javascript:void(0)\" data-container=\"body\" data-bs-toggle=\"popover\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 1172, "\"", 1180, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Chat\"><i data-feather=\"message-square\"></i></a></li>\r\n                            <li><a href=\"javascript:void(0)\" data-container=\"body\" data-bs-toggle=\"popover\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 1385, "\"", 1393, 0);
            EndWriteAttribute();
            WriteLiteral(" data-original-title=\"Icons\"><i data-feather=\"command\"></i></a></li>\r\n                            <li><a href=\"javascript:void(0)\" data-container=\"body\" data-bs-toggle=\"popover\" data-placement=\"top\"");
            BeginWriteAttribute("title", " title=\"", 1592, "\"", 1600, 0);
            EndWriteAttribute();
            WriteLiteral(@" data-original-title=""Learning""><i data-feather=""layers""></i></a></li>
                            <li>
                                <a href=""javascript:void(0)""><i class=""bookmark-search"" data-feather=""star""></i></a>
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cbec57192a64f7fbad0f9ba595893a8527d2bf11072", async() => {
                WriteLiteral("\r\n                                    <div class=\"form-group form-control-search\">\r\n                                        <input type=\"text\" placeholder=\"Search..\">\r\n                                    </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral(@"    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <div class=""card"">
                    <div class=""card-header pb-0"">
                        <h5>ADY</h5><span>User List</span>
                    </div>
                    <div class=""card-body"">
                        <div style=""position: relative; height: auto; width: 100%;"">
                            <div class=""jsgrid-grid-header jsgrid-header-scrollbar"">
                                <table id=""example"" class=""table table-striped"" style=""padding-left:30%"">
                                    <thead>
                                        <tr>
                                            <th>ID</th>
                                            <th>FirstName</th>
                                            <th>LastName</th>
                                            <th>FatherName</th>
                                            <th>UserName</th>
                      ");
            WriteLiteral(@"                      <th>UserPassword</th>
                                            <th>StationID</th>
                                            <th>KassaID</th>
                                            <th>UserCreateDate</th>
                                            <th>Edit</th>
                                            <th>Delete</th>
                                        </tr>
                                    </thead>
                                    <tbody>
");
#nullable restore
#line 83 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                         foreach (var user in Model)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <tr>\r\n                                                <td>");
#nullable restore
#line 86 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                               Write(user.UserID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 87 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                               Write(user.UserFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 88 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                               Write(user.UserLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 89 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                               Write(user.UserFatherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 90 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                               Write(user.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 91 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                               Write(user.UserPassword);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 92 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                               Write(user.station.StationName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 93 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                               Write(user.KassaID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                                                <td>");
#nullable restore
#line 95 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                               Write(user.UserCreateDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td>");
#nullable restore
#line 96 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                               Write(Html.ActionLink("Edit", "Edit", "User", new { Id = user.UserID }, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                                <td><a id=\"btn1\" class=\"btn btn-warning\"");
            BeginWriteAttribute("href", " href=\"", 5011, "\"", 5076, 1);
#nullable restore
#line 97 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
WriteAttributeValue("", 5018, Url.Action("UserDelete", "User", new { Id = user.UserID}), 5018, 58, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a> </td>\r\n                                            </tr>\r\n");
#nullable restore
#line 99 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </tbody>\r\n                                </table>\r\n\r\n");
            WriteLiteral(@"                            </div>
                            <div class=""jsgrid-grid-body"">
                                <table class=""jsgrid-table"">
                                    <tbody>
                                        <tr class=""jsgrid-edit-row"">
                                            <td class=""jsgrid-cell"" style=""width: 30px;"">
                                                <input type=""number"" disabled>
                                            </td>
                                            <td class=""jsgrid-cell"" style=""width: 60px;"">
                                                <input type=""text"">
                                            </td>
                                            <td class=""jsgrid-cell"" style=""width: 60px;"">
                                                <input type=""text"">
                                            </td>
                                            <td class=""jsgrid-cell"" style=""width: 60px;"">
                ");
            WriteLiteral(@"                                <input type=""text"">
                                            </td>
                                            <td class=""jsgrid-cell"" style=""width: 60px;"">
                                                <input type=""text"">
                                            </td>
                                            <td class=""jsgrid-cell jsgrid-align-right"" style=""width: 60px;"">
                                                <input type=""text"">
                                            </td>
                                            <td class=""jsgrid-cell jsgrid-align-center"" style=""width: 60px;"">
                                                <select>
                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cbec57192a64f7fbad0f9ba595893a8527d2bf20579", async() => {
                WriteLiteral("Baki");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cbec57192a64f7fbad0f9ba595893a8527d2bf21789", async() => {
                WriteLiteral("Gəncə");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cbec57192a64f7fbad0f9ba595893a8527d2bf23000", async() => {
                WriteLiteral("Sumqayıt");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cbec57192a64f7fbad0f9ba595893a8527d2bf24214", async() => {
                WriteLiteral("Xırdalan");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                                                </select>
                                            </td>
                                            <td class=""jsgrid-cell jsgrid-align-right"" style=""width: 60px;"">
                                                <input type=""number"">
                                            </td>

                                            <td class=""jsgrid-cell jsgrid-align-right"" style=""width: 60px;"">
                                                <input type=""date"">
                                            </td>



                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cbec57192a64f7fbad0f9ba595893a8527d2bf26013", async() => {
                WriteLiteral("\r\n\r\n                                                <td class=\"jsgrid-cell jsgrid-control-field jsgrid-align-center\" style=\"width: 100px;\">\r\n\r\n                                                    <input type=\"search\" placeholder=\"Search ...\"");
                BeginWriteAttribute("value", " value=\"", 8416, "\"", 8455, 1);
#nullable restore
#line 151 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
WriteAttributeValue("", 8424, ViewData["GetEmployeedetails"], 8424, 31, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" name=""Empsearch"" />

                                                </td>

                                                <td class=""jsgrid-cell jsgrid-control-field jsgrid-align-center"" style=""width: 60px;"">

                                                    <input class=""btn btn-primary"" type=""submit"" value=""Search"" />

                                                </td>
                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"


                                            <td class=""jsgrid-cell jsgrid-control-field jsgrid-align-center"" style=""width: 60px;"">

                                                <a class=""btn btn-success"" href=""/User/Index"">New User</a>
                                            </td>

                                            <!--a asp-action=""Index"">Get All Users</a>-->

                                    </tbody>
                                </table>
                            </div>
                            
                            <div class=""jsgrid-pager-container""");
            BeginWriteAttribute("style", " style=\"", 9510, "\"", 9518, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n");
#nullable restore
#line 176 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                  
                                    var prevDisabled = !Model.PreviousPage ? "disabled" : "";
                                    var nextDisabled = !Model.NextPage ? "disabled" : "";
                                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cbec57192a64f7fbad0f9ba595893a8527d2bf30141", async() => {
                WriteLiteral("\r\n                                    Previous\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 182 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                              WriteLiteral(Model.PageIndex -1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9961, "btn", 9961, 3, true);
            AddHtmlAttributeValue(" ", 9964, "btn-default", 9965, 12, true);
#nullable restore
#line 183 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
AddHtmlAttributeValue(" ", 9976, prevDisabled, 9977, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "15cbec57192a64f7fbad0f9ba595893a8527d2bf33008", async() => {
                WriteLiteral("\r\n                                    Next\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-pageNumber", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 189 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
                                              WriteLiteral(Model.PageIndex +1);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pageNumber", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pageNumber"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 10260, "btn", 10260, 3, true);
            AddHtmlAttributeValue(" ", 10263, "btn-default", 10264, 12, true);
#nullable restore
#line 190 "D:\repos\Test_AdminPanel\Views\Main\Index.cshtml"
AddHtmlAttributeValue(" ", 10275, nextDisabled, 10276, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral(@"                            </div>
                            <div class=""jsgrid-load-shader"" style=""display: none; position: absolute; inset: 0px; z-index: 1000;""></div>
                            <div class=""jsgrid-load-panel"" style=""display: none; position: absolute; top: 50%; left: 50%; z-index: 1000;"">Please, wait...</div>
                        </div>
                    </div>

                </div>
            </div>


        </div>
    </div>
");
            WriteLiteral("</div>\r\n\r\n\r\n\r\n<script>\r\n    $(\'#btn1\').click(function () {\r\n        //swal(\"Good job!\", \"You clicked the button!\", \"success\");\r\n        swal(\"Hello world!\");\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PaginatedList<Test_AdminPanel.Models.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591