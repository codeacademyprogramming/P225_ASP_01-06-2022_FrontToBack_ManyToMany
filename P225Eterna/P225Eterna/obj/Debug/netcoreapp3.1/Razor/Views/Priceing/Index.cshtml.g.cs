#pragma checksum "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0359e37278c66b9a5a1f1d3c6adad52916be2d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Priceing_Index), @"mvc.1.0.view", @"/Views/Priceing/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0359e37278c66b9a5a1f1d3c6adad52916be2d7", @"/Views/Priceing/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed9ecaa3ee8509b557e93a5cd90b8160f99f126", @"/Views/_ViewImports.cshtml")]
    public class Views_Priceing_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Plan>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
  
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
            <li>Pricing</li>
        </ol>
        <h2>Pricing</h2>

    </div>
</section><!-- End Breadcrumbs -->
<!-- ======= Pricing Section ======= -->
<section id=""pricing"" class=""pricing"">
    <div class=""container"">

        <div class=""row no-gutters"">

");
#nullable restore
#line 24 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
             foreach (Plan plan in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div");
            BeginWriteAttribute("class", " class=\"", 597, "\"", 651, 3);
            WriteAttributeValue("", 605, "col-lg-4", 605, 8, true);
            WriteAttributeValue(" ", 613, "box", 614, 4, true);
#nullable restore
#line 26 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
WriteAttributeValue(" ", 617, plan.IsFeature ? "featured":"", 618, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h3>");
#nullable restore
#line 27 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                   Write(plan.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <h4>$");
#nullable restore
#line 28 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                    Write(plan.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>per month</span></h4>\r\n                    <ul>\r\n");
#nullable restore
#line 30 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                         foreach (PlanFeature planFeature in plan.PlanFeatures)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li><i class=\"bx bx-check\"></i> ");
#nullable restore
#line 32 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                                                       Write(planFeature.FeatureItem.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 33 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </ul>\r\n                    <a href=\"#\" class=\"buy-btn\">Buy Now</a>\r\n                </div>\r\n");
#nullable restore
#line 37 "C:\Users\hamid.mammadov\Desktop\P225Eterna\P225Eterna\Views\Priceing\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n    </div>\r\n</section><!-- End Pricing Section -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Plan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
