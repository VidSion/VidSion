#pragma checksum "C:\Users\M H\Desktop\CMPE 195A\VidSion\VidSion\Views\Register\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ca52f3fbf367734ea016b403bd0671d7bc6e442"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
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
#line 1 "C:\Users\M H\Desktop\CMPE 195A\VidSion\VidSion\Views\_ViewImports.cshtml"
using VidSion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\M H\Desktop\CMPE 195A\VidSion\VidSion\Views\_ViewImports.cshtml"
using VidSion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ca52f3fbf367734ea016b403bd0671d7bc6e442", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df71e6658ed39dafd17695d4b36cefce73333e7d", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("registerForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\M H\Desktop\CMPE 195A\VidSion\VidSion\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Sign up";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ca52f3fbf367734ea016b403bd0671d7bc6e4424090", async() => {
                WriteLiteral(@"
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 mx-auto"">
                <div class=""card"">
                    <div class=""card-body"">

                        <div class=""row"">
                            <div class=""col"">
                                <center>
                                    <h3>Create Account</h3>
                                </center>
                            </div>
                        </div>

                        <div class=""row"">
                            <div class=""col"">
                                <hr>
                            </div>
                        </div>



");
                WriteLiteral(@"                        <div class=""row"">
                            <div class=""col"">
                                <label>Email</label>
                                <div class=""form-group"">
                                    <input id=""userEmail"" type=""text"" class=""form-control"" placeholder=""Email"" />
                                    <span class=""text-danger""></span>
                                </div>
                            </div>
                        </div>

");
                WriteLiteral(@"                        <div class=""row"">
                            <div class=""col"">
                                <label>First Name</label>
                                <div class=""form-group"">
                                    <input id=""userName"" type=""text"" class=""form-control"" placeholder=""First Name"" />
                                    <span class=""text-danger""></span>
                                </div>
                            </div>
                        </div>

");
                WriteLiteral(@"                        <div class=""row"">
                            <div class=""col"">
                                <label>Last Name</label>
                                <div class=""form-group"">
                                    <input id=""userName"" type=""text"" class=""form-control"" placeholder=""Last Name"" />
                                    <span class=""text-danger""></span>
                                </div>
                            </div>
                        </div>

");
                WriteLiteral(@"                        <div class=""row"">
                            <div class=""col"">
                                <label>Password</label>
                                <div class=""form-group"">
                                    <input type=""password"" id=""password"" class=""form-control"" data-toggle=""password"" placeholder=""Password"" />
                                    <span class=""text-danger""></span>
                                </div>

                                <label>Confirm Password</label>
                                <div class=""form-group"">
                                    <input id=""password"" type=""password"" class=""form-control"" data-toggle=""password"" placeholder=""Confirm Password"" />
                                    <span class=""text-danger""></span>
                                </div>


");
                WriteLiteral(@"                                <script>
                                    $('#password').password();
                                </script>

                                <div class=""form-group"">
                                    <button type=""submit"" id=""btnSignIn"" class=""btn btn-primary btn-block"">Sign Up</button>
                                </div>

                                <div class=""form-check"">
                                    <input type=""checkbox"" name=""checkBox"" id=""checkBox"" required />
                                    I acknowledge that my information will be used in accordance with the
                                    <a href=""#"">Privacy Policy</a> and <a href=""#"">Cookie Policy</a>.
                                    <span class=""text-danger""></span>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <br />
                <center");
                WriteLiteral("> Have an account? <a");
                BeginWriteAttribute("href", " href=\"", 4433, "\"", 4469, 1);
#nullable restore
#line 98 "C:\Users\M H\Desktop\CMPE 195A\VidSion\VidSion\Views\Register\Index.cshtml"
WriteAttributeValue("", 4440, Url.Action("Index", "Login"), 4440, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Sign in</a></center>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
