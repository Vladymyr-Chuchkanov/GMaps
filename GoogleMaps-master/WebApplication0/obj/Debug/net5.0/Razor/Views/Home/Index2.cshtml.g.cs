#pragma checksum "D:\GMaps\GoogleMaps-master\WebApplication0\Views\Home\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2f06199206792bc3d223ff937af91e508ed89eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index2), @"mvc.1.0.view", @"/Views/Home/Index2.cshtml")]
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
#line 1 "D:\GMaps\GoogleMaps-master\WebApplication0\Views\_ViewImports.cshtml"
using WebApplication0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GMaps\GoogleMaps-master\WebApplication0\Views\_ViewImports.cshtml"
using WebApplication0.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2f06199206792bc3d223ff937af91e508ed89eb", @"/Views/Home/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0591636d0e7c1b4a95a98cab18fb12c4d5ea9680", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n\n<div id=\"demoMap\" style=\"height:250px\"></div>\n<script src=\"/OpenLayers.js\"></script>\n<script src=\"/lib/jquery/dist/jquery.js\"></script>\n");
            WriteLiteral(@"<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#submit"").click(function () {

            $.ajax({
                type: ""POST"",
                url: ""/Home/Index2GetRes?adress="" + $(""#address"").val()
            });
        });

    });
    
    
</script>
<div id=""floating-panel"">
    <input id=""address"" type=""text"" value=""Sydney, NSW"" />
    <input id=""submit"" type=""button"" value=""Geocode"" />
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591