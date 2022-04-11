#pragma checksum "C:\Users\modib\source\repos\CommodityMain\CommodityAdmin\Views\Shared\_SidebarMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "87586172f8323f02c27dae671d6b0361d3749438"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SidebarMenu), @"mvc.1.0.view", @"/Views/Shared/_SidebarMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87586172f8323f02c27dae671d6b0361d3749438", @"/Views/Shared/_SidebarMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99b6ebd569011e662d8f2ab9858d3da5b3e20e08", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__SidebarMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- Sidebar -->
<div class=""sidebar sidebar-style-2"" data-background-color=""dark2"">
    <div class=""sidebar-wrapper scrollbar scrollbar-inner"">
        <div class=""sidebar-content"">
            <div class=""user"">
                <div class=""avatar-sm float-left mr-2"">
                    <img src=""../assets/img/profile.jpg"" alt=""..."" class=""avatar-img rounded-circle"">
                </div>
                <div class=""info"">
                    <a data-toggle=""collapse"" href=""#collapseExample"" aria-expanded=""true"">
                        <span>
                            Hizrian
                            <span class=""user-level"">Administrator</span>
                            <span class=""caret""></span>
                        </span>
                    </a>
                    <div class=""clearfix""></div>

                    <div class=""collapse in"" id=""collapseExample"">
                        <ul class=""nav"">
                            <li>
                                <a h");
            WriteLiteral(@"ref=""#profile"">
                                    <span class=""link-collapse"">My Profile</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#edit"">
                                    <span class=""link-collapse"">Edit Profile</span>
                                </a>
                            </li>
                            <li>
                                <a href=""#settings"">
                                    <span class=""link-collapse"">Settings</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
            <ul class=""nav nav-primary"">
                <li class=""nav-item active"">
                    <a data-toggle=""collapse"" href=""#dashboard"" class=""collapsed"" aria-expanded=""false"">
                        <i class=""fas fa-home""></i>
                 ");
            WriteLiteral(@"       <p>Dashboard</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""dashboard"">
                        <ul class=""nav nav-collapse"">
                            <li>
                                <a href=""../demo1/index.html"">
                                    <span class=""sub-item"">Dashboard 1</span>
                                </a>
                            </li>
                            <li>
                                <a href=""../demo2/index.html"">
                                    <span class=""sub-item"">Dashboard 2</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </li>
                <li class=""nav-section"">
                    <span class=""sidebar-mini-icon"">
                        <i class=""fa fa-ellipsis-h""></i>
                    </span>
                    <h4 class=""text-secti");
            WriteLiteral(@"on"">Components</h4>
                </li>
                <li class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#base"">
                        <i class=""fas fa-layer-group""></i>
                        <p>Base</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""base"">
                        <ul class=""nav nav-collapse"">
                            <li>
                                <a href=""components/avatars.html"">
                                    <span class=""sub-item"">Avatars</span>
                                </a>
                            </li>
                            <li>
                                <a href=""components/buttons.html"">
                                    <span class=""sub-item"">Buttons</span>
                                </a>
                            </li>
                            <li>
                                <a href=""components/gridsyste");
            WriteLiteral(@"m.html"">
                                    <span class=""sub-item"">Grid System</span>
                                </a>
                            </li>
                            <li>
                                <a href=""components/panels.html"">
                                    <span class=""sub-item"">Panels</span>
                                </a>
                            </li>
                            <li>
                                <a href=""components/notifications.html"">
                                    <span class=""sub-item"">Notifications</span>
                                </a>
                            </li>
                            <li>
                                <a href=""components/sweetalert.html"">
                                    <span class=""sub-item"">Sweet Alert</span>
                                </a>
                            </li>
                            <li>
                                <a href=""components/font-awes");
            WriteLiteral(@"ome-icons.html"">
                                    <span class=""sub-item"">Font Awesome Icons</span>
                                </a>
                            </li>
                            <li>
                                <a href=""components/simple-line-icons.html"">
                                    <span class=""sub-item"">Simple Line Icons</span>
                                </a>
                            </li>
                            <li>
                                <a href=""components/flaticons.html"">
                                    <span class=""sub-item"">Flaticons</span>
                                </a>
                            </li>
                            <li>
                                <a href=""components/typography.html"">
                                    <span class=""sub-item"">Typography</span>
                                </a>
                            </li>
                        </ul>
                    </div>
        ");
            WriteLiteral(@"        </li>
                <li class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#sidebarLayouts"">
                        <i class=""fas fa-th-list""></i>
                        <p>Sidebar Layouts</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""sidebarLayouts"">
                        <ul class=""nav nav-collapse"">
                            <li>
                                <a href=""sidebar-style-1.html"">
                                    <span class=""sub-item"">Sidebar Style 1</span>
                                </a>
                            </li>
                            <li>
                                <a href=""overlay-sidebar.html"">
                                    <span class=""sub-item"">Overlay Sidebar</span>
                                </a>
                            </li>
                            <li>
                                <a href=""compact-side");
            WriteLiteral(@"bar.html"">
                                    <span class=""sub-item"">Compact Sidebar</span>
                                </a>
                            </li>
                            <li>
                                <a href=""static-sidebar.html"">
                                    <span class=""sub-item"">Static Sidebar</span>
                                </a>
                            </li>
                            <li>
                                <a href=""icon-menu.html"">
                                    <span class=""sub-item"">Icon Menu</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#forms"">
                        <i class=""fas fa-pen-square""></i>
                        <p>Forms</p>
                        <span class=""caret""></span>
                    </a>
 ");
            WriteLiteral(@"                   <div class=""collapse"" id=""forms"">
                        <ul class=""nav nav-collapse"">
                            <li>
                                <a href=""forms/forms.html"">
                                    <span class=""sub-item"">Basic Form</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#tables"">
                        <i class=""fas fa-table""></i>
                        <p>Tables</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""tables"">
                        <ul class=""nav nav-collapse"">
                            <li>
                                <a href=""tables/tables.html"">
                                    <span class=""sub-item"">Basic Table</span>
                          ");
            WriteLiteral(@"      </a>
                            </li>
                            <li>
                                <a href=""tables/datatables.html"">
                                    <span class=""sub-item"">Datatables</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#maps"">
                        <i class=""fas fa-map-marker-alt""></i>
                        <p>Maps</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""maps"">
                        <ul class=""nav nav-collapse"">
                            <li>
                                <a href=""maps/jqvmap.html"">
                                    <span class=""sub-item"">JQVMap</span>
                                </a>
                            </li>
             ");
            WriteLiteral(@"           </ul>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#charts"">
                        <i class=""far fa-chart-bar""></i>
                        <p>Charts</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""charts"">
                        <ul class=""nav nav-collapse"">
                            <li>
                                <a href=""charts/charts.html"">
                                    <span class=""sub-item"">Chart Js</span>
                                </a>
                            </li>
                            <li>
                                <a href=""charts/sparkline.html"">
                                    <span class=""sub-item"">Sparkline</span>
                                </a>
                            </li>
                        </ul>
                    </div>
           ");
            WriteLiteral(@"     </li>
                <li class=""nav-item"">
                    <a href=""widgets.html"">
                        <i class=""fas fa-desktop""></i>
                        <p>Widgets</p>
                        <span class=""badge badge-success"">4</span>
                    </a>
                </li>
                <li class=""nav-item"">
                    <a data-toggle=""collapse"" href=""#submenu"">
                        <i class=""fas fa-bars""></i>
                        <p>Menu Levels</p>
                        <span class=""caret""></span>
                    </a>
                    <div class=""collapse"" id=""submenu"">
                        <ul class=""nav nav-collapse"">
                            <li>
                                <a data-toggle=""collapse"" href=""#subnav1"">
                                    <span class=""sub-item"">Level 1</span>
                                    <span class=""caret""></span>
                                </a>
                                <div");
            WriteLiteral(@" class=""collapse"" id=""subnav1"">
                                    <ul class=""nav nav-collapse subnav"">
                                        <li>
                                            <a href=""#"">
                                                <span class=""sub-item"">Level 2</span>
                                            </a>
                                        </li>
                                        <li>
                                            <a href=""#"">
                                                <span class=""sub-item"">Level 2</span>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </li>
                            <li>
                                <a data-toggle=""collapse"" href=""#subnav2"">
                                    <span class=""sub-item"">Level 1</span>
                                    <s");
            WriteLiteral(@"pan class=""caret""></span>
                                </a>
                                <div class=""collapse"" id=""subnav2"">
                                    <ul class=""nav nav-collapse subnav"">
                                        <li>
                                            <a href=""#"">
                                                <span class=""sub-item"">Level 2</span>
                                            </a>
                                        </li>
                                    </ul>
                                </div>
                            </li>
                            <li>
                                <a href=""#"">
                                    <span class=""sub-item"">Level 1</span>
                                </a>
                            </li>
                        </ul>
                    </div>
                </li>
                <li class=""mx-4 mt-2"">
                    <a href=""http://themekita.com/atlantis-b");
            WriteLiteral("ootstrap-dashboard.html\" class=\"btn btn-primary btn-block\"><span class=\"btn-label mr-2\"> <i class=\"fa fa-heart\"></i> </span>Buy Pro</a>\r\n                </li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- End Sidebar -->");
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