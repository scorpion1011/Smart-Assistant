#pragma checksum "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a848a75b337fee62677cd5a58712b516f03cbe10"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerList_Index), @"mvc.1.0.view", @"/Views/CustomerList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CustomerList/Index.cshtml", typeof(AspNetCore.Views_CustomerList_Index))]
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
#line 1 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\_ViewImports.cshtml"
using SmartAssistant;

#line default
#line hidden
#line 2 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\_ViewImports.cshtml"
using SmartAssistant.Models;

#line default
#line hidden
#line 1 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a848a75b337fee62677cd5a58712b516f03cbe10", @"/Views/CustomerList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f35a5cf5788e49f8caeae4f5ec7e1550d68103ac", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SmartAssistant.ViewModels.ListInfoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("button7"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-right: 45px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddNewItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", new global::Microsoft.AspNetCore.Html.HtmlString("post"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(82, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
  
    ViewData["Title"] = "ListInfo";

#line default
#line hidden
            BeginContext(180, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(187, 22, false);
#line 10 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
Write(Localizer["List Info"]);

#line default
#line hidden
            EndContext();
            BeginContext(209, 2160, true);
            WriteLiteral(@"</h2>

<style>
    a.button7, input.button7 {
        font-weight: 700;
        color: white;
        text-decoration: none;
        padding: .8em 1em calc(.8em + 3px);
        border-radius: 3px;
        background: rgb(64,199,129);
        box-shadow: 0 -3px rgb(53,167,110) inset;
        transition: 0.2s;
    }

        a.button7:hover, input.button7:hover {
            background: rgb(53, 167, 110);
        }

        a.button7:active, input.button7:active {
            background: rgb(33,147,90);
            box-shadow: 0 3px rgb(33,147,90) inset;
        }

    .body-content {
        margin-top: 20px;
        padding-left: 15px;
        padding-right: 15px;
    }

    .title {
        /* чтобы линии не выходили за ширину блока заголовка */
        overflow: hidden;
    }

        .title:before,
        .title:after {
            content: '';
            /* делаем линию строчно-блочной */
            display: inline-block;
            /* выравниваем вертикально по ");
            WriteLiteral(@"середине */
            vertical-align: middle;
            /* не позволяем ширине превысить 100% (будет добавлен бордюр) */
            box-sizing: border-box;
            /* установка ширины в 100% делает линию равной ширине тега заголовка
    ** благодаря этому линия заполнит все свободное пространство
    ** слева и справа от текста
    */
            width: 100%;
            height: 3px;
            background: #6CBD83;
            /* добавляем к линии левый и правый бордюр цветом основного фона заголовка
    ** благодаря этому создается нужный отступ между линиями и текстом
    */
            border: solid #FFF;
            border-width: 0 10px;
        }

        .title:before {
            /* смещаем левую линию влево отрицательным отступом, равным 100% ширины
    ** благодаря этому линия встает слева от текста
    */
            margin-left: -100%;
        }

        .title:after {
            /* смещаем правую линию вправо отрицательным отступом, равным 100% ширины
    ** ");
            WriteLiteral("благодаря этому линия встает справа от текста\r\n    */\r\n            margin-right: -100%;\r\n        }\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(2369, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7d4cd4e1c0524c309b82a7d3928fba9f", async() => {
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
            EndContext();
            BeginContext(2420, 65, true);
            WriteLiteral("\r\n\r\n<table class=\"table\" style=\"margin-top: 20px;\">\r\n    <tr><th>");
            EndContext();
            BeginContext(2486, 23, false);
#line 85 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
       Write(Localizer["Thing name"]);

#line default
#line hidden
            EndContext();
            BeginContext(2509, 9, true);
            WriteLiteral("</th><th>");
            EndContext();
            BeginContext(2519, 33, false);
#line 85 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
                                        Write(Localizer["The appropriate mark"]);

#line default
#line hidden
            EndContext();
            BeginContext(2552, 9, true);
            WriteLiteral("</th><th>");
            EndContext();
            BeginContext(2562, 23, false);
#line 85 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
                                                                                   Write(Localizer["Mark owner"]);

#line default
#line hidden
            EndContext();
            BeginContext(2585, 57, true);
            WriteLiteral("</th><th></th></tr>\r\n    <tr><th colspan=\"4\"></th></tr>\r\n");
            EndContext();
#line 87 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
     foreach (var thing in Model.things)
    {

#line default
#line hidden
            BeginContext(2691, 48, true);
            WriteLiteral("        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2740, 10, false);
#line 91 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
           Write(thing.name);

#line default
#line hidden
            EndContext();
            BeginContext(2750, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2806, 10, false);
#line 94 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
           Write(thing.kind);

#line default
#line hidden
            EndContext();
            BeginContext(2816, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(2871, 340, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48386781c090434ea4c76b7bf3693ece", async() => {
                BeginContext(2945, 64, true);
                WriteLiteral("\r\n                    <input type=\"hidden\" name=\"previousMarkId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3009, "\"", 3031, 1);
#line 98 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
WriteAttributeValue("", 3017, thing.idThing, 3017, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3032, 103, true);
                WriteLiteral(" />\r\n                    <button type=\"submit\" class=\"btn btn-sm btn-danger\">\r\n                        ");
                EndContext();
                BeginContext(3136, 19, false);
#line 100 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
                   Write(Localizer["Delete"]);

#line default
#line hidden
                EndContext();
                BeginContext(3155, 49, true);
                WriteLiteral("\r\n                    </button>\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
                                                WriteLiteral(thing.idThing);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3211, 36, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n");
            EndContext();
#line 105 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(3254, 134, true);
            WriteLiteral("</table>\r\n\r\n<table id=\"list_table\" class=\"table\" style=\"margin-top: 20px;\">\r\n    <tr>\r\n        <th>\r\n            <a></a>\r\n            ");
            EndContext();
            BeginContext(3388, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f732e0068fe4ce6afd08e5e59e1f76c", async() => {
                BeginContext(3474, 40, false);
#line 112 "C:\Projects\SmartAssistant\Website\SmartAssistant\Views\CustomerList\Index.cshtml"
                                                                                            Write(Localizer["Add a new thing to the list"]);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3518, 57, true);
            WriteLiteral("\r\n            <a></a>\r\n        </th>\r\n    </tr>\r\n</table>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SmartAssistant.ViewModels.ListInfoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
