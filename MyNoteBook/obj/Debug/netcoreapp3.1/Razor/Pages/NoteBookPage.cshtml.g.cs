#pragma checksum "C:\Users\DELL\source\repos\MyNoteBook\MyNoteBook\MyNoteBook\Pages\NoteBookPage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e61f20da6fd3a222383ea341926bf1486dcf330"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyNoteBook.Pages.Pages_NoteBookPage), @"mvc.1.0.razor-page", @"/Pages/NoteBookPage.cshtml")]
namespace MyNoteBook.Pages
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
#line 1 "C:\Users\DELL\source\repos\MyNoteBook\MyNoteBook\MyNoteBook\Pages\_ViewImports.cshtml"
using MyNoteBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL\source\repos\MyNoteBook\MyNoteBook\MyNoteBook\Pages\NoteBookPage.cshtml"
using MyNoteBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e61f20da6fd3a222383ea341926bf1486dcf330", @"/Pages/NoteBookPage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55ed44039cbe24ec71b13d3d1e0871dfce999428", @"/Pages/_ViewImports.cshtml")]
    public class Pages_NoteBookPage : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>");
#nullable restore
#line 6 "C:\Users\DELL\source\repos\MyNoteBook\MyNoteBook\MyNoteBook\Pages\NoteBookPage.cshtml"
Write(Model.Notebook.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<ul>\r\n");
#nullable restore
#line 9 "C:\Users\DELL\source\repos\MyNoteBook\MyNoteBook\MyNoteBook\Pages\NoteBookPage.cshtml"
     foreach (Journal journal in Model.Notebook.Journals)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e61f20da6fd3a222383ea341926bf1486dcf3303913", async() => {
#nullable restore
#line 11 "C:\Users\DELL\source\repos\MyNoteBook\MyNoteBook\MyNoteBook\Pages\NoteBookPage.cshtml"
                                                        Write(journal.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\DELL\source\repos\MyNoteBook\MyNoteBook\MyNoteBook\Pages\NoteBookPage.cshtml"
                             WriteLiteral(journal.JournalId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n");
#nullable restore
#line 12 "C:\Users\DELL\source\repos\MyNoteBook\MyNoteBook\MyNoteBook\Pages\NoteBookPage.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
            DefineSection("Schema", async() => {
                WriteLiteral("\r\n    <script type=\"application/ld+json\">\r\n        {\r\n            \"");
                WriteLiteral("@context\": \"http://schema.org\",\r\n            \"");
                WriteLiteral("@type\": \"NoteBook\",\r\n            \"noteBookId\": \"");
#nullable restore
#line 21 "C:\Users\DELL\source\repos\MyNoteBook\MyNoteBook\MyNoteBook\Pages\NoteBookPage.cshtml"
                      Write(Model.Notebook.NotebookId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n            \"name\": \"");
#nullable restore
#line 22 "C:\Users\DELL\source\repos\MyNoteBook\MyNoteBook\MyNoteBook\Pages\NoteBookPage.cshtml"
                Write(Model.Notebook.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("\",\r\n");
                WriteLiteral("\r\n        }\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyNoteBook.Pages.NoteBookPageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyNoteBook.Pages.NoteBookPageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyNoteBook.Pages.NoteBookPageModel>)PageContext?.ViewData;
        public MyNoteBook.Pages.NoteBookPageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
