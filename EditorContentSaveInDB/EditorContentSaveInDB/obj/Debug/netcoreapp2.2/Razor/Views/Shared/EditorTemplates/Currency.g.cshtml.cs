#pragma checksum "C:\Users\ptodorov\Desktop\Delete\EditorContentSaveInDB\EditorContentSaveInDB\Views\Shared\EditorTemplates\Currency.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d50cb48f1ad3e56ea00da7b95c5ea6c03dddc81"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditorTemplates_Currency), @"mvc.1.0.view", @"/Views/Shared/EditorTemplates/Currency.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/EditorTemplates/Currency.cshtml", typeof(AspNetCore.Views_Shared_EditorTemplates_Currency))]
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
#line 1 "C:\Users\ptodorov\Desktop\Delete\EditorContentSaveInDB\EditorContentSaveInDB\Views\_ViewImports.cshtml"
using EditorContentSaveInDB;

#line default
#line hidden
#line 2 "C:\Users\ptodorov\Desktop\Delete\EditorContentSaveInDB\EditorContentSaveInDB\Views\_ViewImports.cshtml"
using Kendo.Mvc.UI;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d50cb48f1ad3e56ea00da7b95c5ea6c03dddc81", @"/Views/Shared/EditorTemplates/Currency.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c645f024cbdfd5eb7e9ef106a14d0ba22c65a46", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditorTemplates_Currency : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<decimal?>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(21, 111, false);
#line 3 "C:\Users\ptodorov\Desktop\Delete\EditorContentSaveInDB\EditorContentSaveInDB\Views\Shared\EditorTemplates\Currency.cshtml"
Write(Html.Kendo().CurrencyTextBoxFor(m => m)      
      .HtmlAttributes(new {style="width:100%"})
      .Min(0)
);

#line default
#line hidden
            EndContext();
            BeginContext(133, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<decimal?> Html { get; private set; }
    }
}
#pragma warning restore 1591
