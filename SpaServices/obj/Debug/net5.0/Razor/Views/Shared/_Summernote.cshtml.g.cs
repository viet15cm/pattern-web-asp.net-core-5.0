#pragma checksum "D:\C#\SpaServices\SpaServices\Views\Shared\_Summernote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4a45d18e901b693fa5bfda68d85cca8d5ddf2b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Summernote), @"mvc.1.0.view", @"/Views/Shared/_Summernote.cshtml")]
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
#line 1 "D:\C#\SpaServices\SpaServices\Views\_ViewImports.cshtml"
using SpaServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\SpaServices\SpaServices\Views\_ViewImports.cshtml"
using SpaServices.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4a45d18e901b693fa5bfda68d85cca8d5ddf2b9", @"/Views/Shared/_Summernote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e112bab416e9767407fc8e0c882e44f45c14223", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Summernote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SpaServices.Models.Summernote>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Summernote-cr/summernote-bs4.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Summernote-cr/summernote-bs4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "D:\C#\SpaServices\SpaServices\Views\Shared\_Summernote.cshtml"
 if (Model.IsLoadLib)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e4a45d18e901b693fa5bfda68d85cca8d5ddf2b94347", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4a45d18e901b693fa5bfda68d85cca8d5ddf2b95465", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\C#\SpaServices\SpaServices\Views\Shared\_Summernote.cshtml"
                                                                                                           
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\'");
#nullable restore
#line 12 "D:\C#\SpaServices\SpaServices\Views\Shared\_Summernote.cshtml"
      Write(Model.IdEditor);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"').summernote({
            placeholder: 'Hello',
            tabsize: 2,
            height: 400,
            toolbar: [
                ['style', ['style']],
                ['font', ['bold', 'underline', 'clear']],
                ['color', ['color']],
                ['para', ['ul', 'ol', 'paragraph']],
                ['table', ['table']],
                ['insert', ['link', 'picture', 'video']],
                ['view', ['fullscreen', 'codeview', 'help']],
                /*['dracula', ['dracula']],*/
                ['Code Highlight', ['CodeHighlight']],
            ],
            buttons: {
                /*dracula: Helloframes,*/
                CodeHighlight: HelloCodeHighlight,
            }

        });
    });


    var Helloframes = function (context) {
        var ui = $.summernote.ui;

        // create button
        var button = ui.button({
            contents: 'Coded Dacula',
            tooltip: 'Code Dracula',
            click: function (value) {
       ");
            WriteLiteral(@"         var text = context.invoke('editor.getSelectedText');
                // http://summernote.org/deep-dive/#insertnode
                context.invoke('editor.pasteHTML', '<div class=""code-wrapper""><pre style=""min-height: 50px;background-color: #071e3d; color: white;""><code id=""code""><br><br>' + text + '</code></pre></div><p><br/></p>');
            },

        });

        return button.render(); // return button as jquery object
    }

    var HelloCodeHighlight = function (context) {
        var ui = $.summernote.ui;

        // create button
        var button = ui.button({
            contents: 'Code Highlight',
            tooltip: 'Code Highlight',
            click: function (value) {
                var text = context.invoke('editor.getSelectedText');
                // http://summernote.org/deep-dive/#insertnode
                context.invoke('editor.pasteHTML', '<pre class=""box-shadow"" style=""min-height: 50px; background: #F5F5F5;""><h5 class=""box-shadow"">Name Code</h5><code");
            WriteLiteral(@" class=""""><br><br>' + text + '</code></pre><p><br/></p>');
            },

        });

        return button.render(); // return button as jquery object
    }

    function copyToClipboard(valueText) {

        /*Copy the text inside the text field */
        var message = valueText;
        navigator.clipboard.writeText(message);

        /* Alert the copied text */
        alert(""Copied the text: "" + message);
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SpaServices.Models.Summernote> Html { get; private set; }
    }
}
#pragma warning restore 1591