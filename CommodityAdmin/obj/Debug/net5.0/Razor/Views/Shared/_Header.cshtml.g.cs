#pragma checksum "C:\Users\modib\source\repos\CommodityMain\CommodityAdmin\Views\Shared\_Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9219482fcae3d18072c8aaf602c7fb62fce99a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Header), @"mvc.1.0.view", @"/Views/Shared/_Header.cshtml")]
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
#line 1 "C:\Users\modib\source\repos\CommodityMain\CommodityAdmin\Views\_ViewImports.cshtml"
using CommodityAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\modib\source\repos\CommodityMain\CommodityAdmin\Views\_ViewImports.cshtml"
using CommodityAdmin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9219482fcae3d18072c8aaf602c7fb62fce99a7", @"/Views/Shared/_Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b6ebd569011e662d8f2ab9858d3da5b3e20e08", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-left navbar-form nav-search mr-md-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""main-header"">
    <!-- Logo Header -->
    <div class=""logo-header"" data-background-color=""dark2"">

        <a href=""index.html"" class=""logo"">
            <img src=""../assets/img/logo.svg"" alt=""navbar brand"" class=""navbar-brand"">
        </a>
        <button class=""navbar-toggler sidenav-toggler ml-auto"" type=""button"" data-toggle=""collapse"" data-target=""collapse"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon"">
                <i class=""icon-menu""></i>
            </span>
        </button>
        <button class=""topbar-toggler more""><i class=""icon-options-vertical""></i></button>
        <div class=""nav-toggle"">
            <button class=""btn btn-toggle toggle-sidebar"">
                <i class=""icon-menu""></i>
            </button>
        </div>
    </div>
    <!-- End Logo Header -->
    <!-- Navbar Header -->
    <nav class=""navbar navbar-header navbar-expand-lg"" data-background-color=""dark"">

        <div class=""contain");
            WriteLiteral("er-fluid\">\r\n            <div class=\"collapse\" id=\"search-nav\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9219482fcae3d18072c8aaf602c7fb62fce99a74864", async() => {
                WriteLiteral(@"
                    <div class=""input-group"">
                        <div class=""input-group-prepend"">
                            <button type=""submit"" class=""btn btn-search pr-1"">
                                <i class=""fa fa-search search-icon""></i>
                            </button>
                        </div>
                        <input type=""text"" placeholder=""Search ..."" class=""form-control"">
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <ul class=""navbar-nav topbar-nav ml-md-auto align-items-center"">
                <li class=""nav-item toggle-nav-search hidden-caret"">
                    <a class=""nav-link"" data-toggle=""collapse"" href=""#search-nav"" role=""button"" aria-expanded=""false"" aria-controls=""search-nav"">
                        <i class=""fa fa-search""></i>
                    </a>
                </li>
                <li class=""nav-item dropdown hidden-caret"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""messageDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fa fa-envelope""></i>
                    </a>
                    <ul class=""dropdown-menu messages-notif-box animated fadeIn"" aria-labelledby=""messageDropdown"">
                        <li>
                            <div class=""dropdown-title d-flex justify-content-between align-items-center"">
                                Messag");
            WriteLiteral(@"es
                                <a href=""#"" class=""small"">Mark all as read</a>
                            </div>
                        </li>
                        <li>
                            <div class=""message-notif-scroll scrollbar-outer"">
                                <div class=""notif-center"">
                                    <a href=""#"">
                                        <div class=""notif-img"">
                                            <img src=""../assets/img/jm_denis.jpg"" alt=""Img Profile"">
                                        </div>
                                        <div class=""notif-content"">
                                            <span class=""subject"">Jimmy Denis</span>
                                            <span class=""block"">
                                                How are you ?
                                            </span>
                                            <span class=""time"">5 minutes ago</span>
                ");
            WriteLiteral(@"                        </div>
                                    </a>
                                    <a href=""#"">
                                        <div class=""notif-img"">
                                            <img src=""../assets/img/chadengle.jpg"" alt=""Img Profile"">
                                        </div>
                                        <div class=""notif-content"">
                                            <span class=""subject"">Chad</span>
                                            <span class=""block"">
                                                Ok, Thanks !
                                            </span>
                                            <span class=""time"">12 minutes ago</span>
                                        </div>
                                    </a>
                                    <a href=""#"">
                                        <div class=""notif-img"">
                                            <img src=""../assets/");
            WriteLiteral(@"img/mlane.jpg"" alt=""Img Profile"">
                                        </div>
                                        <div class=""notif-content"">
                                            <span class=""subject"">Jhon Doe</span>
                                            <span class=""block"">
                                                Ready for the meeting today...
                                            </span>
                                            <span class=""time"">12 minutes ago</span>
                                        </div>
                                    </a>
                                    <a href=""#"">
                                        <div class=""notif-img"">
                                            <img src=""../assets/img/talha.jpg"" alt=""Img Profile"">
                                        </div>
                                        <div class=""notif-content"">
                                            <span class=""subject"">Talha</span>
   ");
            WriteLiteral(@"                                         <span class=""block"">
                                                Hi, Apa Kabar ?
                                            </span>
                                            <span class=""time"">17 minutes ago</span>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </li>
                        <li>
                            <a class=""see-all"" href=""javascript:void(0);"">See all messages<i class=""fa fa-angle-right""></i> </a>
                        </li>
                    </ul>
                </li>
                <li class=""nav-item dropdown hidden-caret"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""notifDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false"">
                        <i class=""fa fa-bell""></i>
                        <span class=""not");
            WriteLiteral(@"ification"">4</span>
                    </a>
                    <ul class=""dropdown-menu notif-box animated fadeIn"" aria-labelledby=""notifDropdown"">
                        <li>
                            <div class=""dropdown-title"">You have 4 new notification</div>
                        </li>
                        <li>
                            <div class=""notif-scroll scrollbar-outer"">
                                <div class=""notif-center"">
                                    <a href=""#"">
                                        <div class=""notif-icon notif-primary""> <i class=""fa fa-user-plus""></i> </div>
                                        <div class=""notif-content"">
                                            <span class=""block"">
                                                New user registered
                                            </span>
                                            <span class=""time"">5 minutes ago</span>
                                        </div>");
            WriteLiteral(@"
                                    </a>
                                    <a href=""#"">
                                        <div class=""notif-icon notif-success""> <i class=""fa fa-comment""></i> </div>
                                        <div class=""notif-content"">
                                            <span class=""block"">
                                                Rahmad commented on Admin
                                            </span>
                                            <span class=""time"">12 minutes ago</span>
                                        </div>
                                    </a>
                                    <a href=""#"">
                                        <div class=""notif-img"">
                                            <img src=""../assets/img/profile2.jpg"" alt=""Img Profile"">
                                        </div>
                                        <div class=""notif-content"">
                                        ");
            WriteLiteral(@"    <span class=""block"">
                                                Reza send messages to you
                                            </span>
                                            <span class=""time"">12 minutes ago</span>
                                        </div>
                                    </a>
                                    <a href=""#"">
                                        <div class=""notif-icon notif-danger""> <i class=""fa fa-heart""></i> </div>
                                        <div class=""notif-content"">
                                            <span class=""block"">
                                                Farrah liked Admin
                                            </span>
                                            <span class=""time"">17 minutes ago</span>
                                        </div>
                                    </a>
                                </div>
                            </div>
                      ");
            WriteLiteral(@"  </li>
                        <li>
                            <a class=""see-all"" href=""javascript:void(0);"">See all notifications<i class=""fa fa-angle-right""></i> </a>
                        </li>
                    </ul>
                </li>
                <li class=""nav-item dropdown hidden-caret"">
                    <a class=""nav-link"" data-toggle=""dropdown"" href=""#"" aria-expanded=""false"">
                        <i class=""fas fa-layer-group""></i>
                    </a>
                    <div class=""dropdown-menu quick-actions quick-actions-info animated fadeIn"">
                        <div class=""quick-actions-header"">
                            <span class=""title mb-1"">Quick Actions</span>
                            <span class=""subtitle op-8"">Shortcuts</span>
                        </div>
                        <div class=""quick-actions-scroll scrollbar-outer"">
                            <div class=""quick-actions-items"">
                                <div class=""row ");
            WriteLiteral(@"m-0"">
                                    <a class=""col-6 col-md-4 p-0"" href=""#"">
                                        <div class=""quick-actions-item"">
                                            <i class=""flaticon-file-1""></i>
                                            <span class=""text"">Generated Report</span>
                                        </div>
                                    </a>
                                    <a class=""col-6 col-md-4 p-0"" href=""#"">
                                        <div class=""quick-actions-item"">
                                            <i class=""flaticon-database""></i>
                                            <span class=""text"">Create New Database</span>
                                        </div>
                                    </a>
                                    <a class=""col-6 col-md-4 p-0"" href=""#"">
                                        <div class=""quick-actions-item"">
                                            <i cl");
            WriteLiteral(@"ass=""flaticon-pen""></i>
                                            <span class=""text"">Create New Post</span>
                                        </div>
                                    </a>
                                    <a class=""col-6 col-md-4 p-0"" href=""#"">
                                        <div class=""quick-actions-item"">
                                            <i class=""flaticon-interface-1""></i>
                                            <span class=""text"">Create New Task</span>
                                        </div>
                                    </a>
                                    <a class=""col-6 col-md-4 p-0"" href=""#"">
                                        <div class=""quick-actions-item"">
                                            <i class=""flaticon-list""></i>
                                            <span class=""text"">Completed Tasks</span>
                                        </div>
                                    </a>
         ");
            WriteLiteral(@"                           <a class=""col-6 col-md-4 p-0"" href=""#"">
                                        <div class=""quick-actions-item"">
                                            <i class=""flaticon-file""></i>
                                            <span class=""text"">Create New Invoice</span>
                                        </div>
                                    </a>
                                </div>
                            </div>
                        </div>
                    </div>
                </li>
                <li class=""nav-item dropdown hidden-caret"">
                    <a class=""dropdown-toggle profile-pic"" data-toggle=""dropdown"" href=""#"" aria-expanded=""false"">
                        <div class=""avatar-sm"">
                            <img src=""../assets/img/profile.jpg"" alt=""..."" class=""avatar-img rounded-circle"">
                        </div>
                    </a>
                    <div class=""dropdown-menu dropdown-user animated fadeI");
            WriteLiteral(@"n"">
                        <div class=""dropdown-user-scroll scrollbar-outer"">
                             <div>
                                     <div class=""user-box"">
                                <div class=""avatar-lg""><img src=""../assets/img/profile.jpg"" alt=""image profile"" class=""avatar-img rounded""></div>
                                <div class=""u-text"">
                                    <h4>Hizrian</h4>
                                    <p class=""text-muted"">hello@example.com</p><a href=""profile.html"" class=""btn btn-xs btn-secondary btn-sm"">View Profile</a>
                                </div>
                            </div>
                                 </div>
                                <div>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">My Profile</a>
                                <a class=""dropdown-item"" href=""#"">My Balance</a>
                                <a class=");
            WriteLiteral(@"""dropdown-item"" href=""#"">Inbox</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Account Setting</a>
                                <div class=""dropdown-divider""></div>
                                <a class=""dropdown-item"" href=""#"">Logout</a>
                            </div>
                        
                    </div>
                </li>
            </ul>
        </div>
    </nav>
    <!-- End Navbar -->
</div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
