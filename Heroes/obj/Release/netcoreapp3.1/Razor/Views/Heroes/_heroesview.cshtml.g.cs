#pragma checksum "C:\Users\student\Code_School\Projects\HeroesProject\Heroes\Views\Heroes\_heroesview.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "865da9ebb32dffc7b4bbcc8cdf12be10c704105c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Heroes__heroesview), @"mvc.1.0.view", @"/Views/Heroes/_heroesview.cshtml")]
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
#line 1 "C:\Users\student\Code_School\Projects\HeroesProject\Heroes\Views\_ViewImports.cshtml"
using Heroes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\student\Code_School\Projects\HeroesProject\Heroes\Views\_ViewImports.cshtml"
using Heroes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"865da9ebb32dffc7b4bbcc8cdf12be10c704105c", @"/Views/Heroes/_heroesview.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94977f6c8204da2c8090b159a38ace68a4b9a81a", @"/Views/_ViewImports.cshtml")]
    public class Views_Heroes__heroesview : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Heroes.Models.HeroesModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"card text-primary border-primary\" style=\"width: 22rem;\">\r\n  <div class=\"card-body\">\r\n    <h5 class=\"card-title\">");
#nullable restore
#line 5 "C:\Users\student\Code_School\Projects\HeroesProject\Heroes\Views\Heroes\_heroesview.cshtml"
                      Write(Model.heroName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 6 "C:\Users\student\Code_School\Projects\HeroesProject\Heroes\Views\Heroes\_heroesview.cshtml"
                                         Write(Model.power);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n    <p class=\"card-text\">");
#nullable restore
#line 7 "C:\Users\student\Code_School\Projects\HeroesProject\Heroes\Views\Heroes\_heroesview.cshtml"
                    Write(Model.howToReach);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n  </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Heroes.Models.HeroesModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
