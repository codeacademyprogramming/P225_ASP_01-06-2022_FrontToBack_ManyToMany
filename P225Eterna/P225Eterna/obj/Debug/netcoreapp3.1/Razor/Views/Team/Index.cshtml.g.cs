#pragma checksum "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5420ad7902cf09ee93186799b7f9ea2a193729d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Team_Index), @"mvc.1.0.view", @"/Views/Team/Index.cshtml")]
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
#line 2 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\_ViewImports.cshtml"
using P225Eterna.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5420ad7902cf09ee93186799b7f9ea2a193729d6", @"/Views/Team/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed9ecaa3ee8509b557e93a5cd90b8160f99f126", @"/Views/_ViewImports.cshtml")]
    public class Views_Team_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<TeamMember>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- ======= Breadcrumbs ======= -->
<section id=""breadcrumbs"" class=""breadcrumbs"">
    <div class=""container"">

        <ol>
            <li><a href=""index.html"">Home</a></li>
            <li>Team</li>
        </ol>
        <h2>Team</h2>

    </div>
</section><!-- End Breadcrumbs -->
<!-- ======= Team Section ======= -->
<section id=""team"" class=""team"">
    <div class=""container"">

        <div class=""row"">
");
#nullable restore
#line 23 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml"
             foreach (TeamMember teamMember in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-lg-4 col-md-6 d-flex align-items-stretch\">\r\n                    <div class=\"member\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "5420ad7902cf09ee93186799b7f9ea2a193729d64305", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 719, "~/assets/img/team/", 719, 18, true);
#nullable restore
#line 27 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml"
AddHtmlAttributeValue("", 737, teamMember.Image, 737, 17, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h4>");
#nullable restore
#line 28 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml"
                       Write(teamMember.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 28 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml"
                                        Write(teamMember.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <span>");
#nullable restore
#line 29 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml"
                         Write(teamMember.Position.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                        <p>");
#nullable restore
#line 30 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml"
                      Write(teamMember.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div class=\"social\">\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1032, "\"", 1039, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 32 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml"
                                  Write(Html.Raw(teamMember.TwitterUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1109, "\"", 1116, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml"
                                  Write(Html.Raw(teamMember.FacebookUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1187, "\"", 1218, 1);
#nullable restore
#line 34 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml"
WriteAttributeValue("", 1194, teamMember.InstagramUrl, 1194, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-instagram\"></i></a>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1287, "\"", 1317, 1);
#nullable restore
#line 35 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml"
WriteAttributeValue("", 1294, teamMember.LinkedinUrl, 1294, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bi bi-linkedin\"></i></a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 39 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Team\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</section><!-- End Team Section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<TeamMember>> Html { get; private set; }
    }
}
#pragma warning restore 1591
