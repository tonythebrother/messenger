#pragma checksum "/home/thb/RiderProjects/CsMessenger/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8ee3e255a717a739b522d9069da74d880df0552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/thb/RiderProjects/CsMessenger/Views/_ViewImports.cshtml"
using CsMessenger;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/thb/RiderProjects/CsMessenger/Views/_ViewImports.cshtml"
using CsMessenger.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/thb/RiderProjects/CsMessenger/Views/Home/Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8ee3e255a717a739b522d9069da74d880df0552", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4eb94c3a2156eec40babf537b36360291cbc71ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "/home/thb/RiderProjects/CsMessenger/Views/Home/Index.cshtml"
       ViewData["Title"] = "Home Page"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("    \n");
#nullable restore
#line 6 "/home/thb/RiderProjects/CsMessenger/Views/Home/Index.cshtml"
     if (!SignInManager.IsSignedIn(User)) {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""jumbotron"">
            <h1>Welcome</h1>
            <p>
                C# Messenger helps you communicate and share with 
                the people who will be part of your life as a programmer .NET, 
                in this community to learn more about these technologies that they provide.
            </p>
        </div>
");
#nullable restore
#line 15 "/home/thb/RiderProjects/CsMessenger/Views/Home/Index.cshtml"
        } else {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""main-home"" id=""main"">
            <div class=""contacts"">
                <input type=""search"" class=""form-control"" id=""search"" v-model=""search"">
                <br>

                <ul id=""list-contacts"" class=""list-group"">
                    <li class=""list-group-item"">
                        <div class=""contact-btn"">
                            <button class=""btn"" id=""general-room""");
            BeginWriteAttribute("v-on:click", " v-on:click=\"", 1002, "\"", 1056, 4);
            WriteAttributeValue("", 1015, "openChatRoom(chat,", 1015, 18, true);
            WriteAttributeValue(" ", 1033, "\'", 1034, 2, true);
#nullable restore
#line 24 "/home/thb/RiderProjects/CsMessenger/Views/Home/Index.cshtml"
WriteAttributeValue("", 1035, User.Identity.Name, 1035, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1054, "\')", 1054, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                            <img src=""css/img-salaprin.png"" alt=""image not found"" width=""50px"" class=""rounded-circle"" style=""padding-right: 5px"">
                            {{chat}}
                        </button>
                        </div>
                    </li>
                    <li v-for=""user in searchUser"" class=""list-group-item""");
            BeginWriteAttribute("v-if", " v-if=\"", 1407, "\"", 1449, 5);
            WriteAttributeValue("", 1414, "user.email", 1414, 10, true);
            WriteAttributeValue(" ", 1424, "!=", 1425, 3, true);
            WriteAttributeValue(" ", 1427, "\'", 1428, 2, true);
#nullable restore
#line 30 "/home/thb/RiderProjects/CsMessenger/Views/Home/Index.cshtml"
WriteAttributeValue("", 1429, User.Identity.Name, 1429, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1448, "\'", 1448, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\n                        <div class=\"contact-btn\">\n                            <button class=\"btn\"");
            BeginWriteAttribute("v-on:click", " v-on:click=\"", 1549, "\"", 1609, 4);
            WriteAttributeValue("", 1562, "openChatRoom(user.email,", 1562, 24, true);
            WriteAttributeValue(" ", 1586, "\'", 1587, 2, true);
#nullable restore
#line 32 "/home/thb/RiderProjects/CsMessenger/Views/Home/Index.cshtml"
WriteAttributeValue("", 1588, User.Identity.Name, 1588, 19, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1607, "\')", 1607, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                            <img src=""css/silouette.png"" alt=""image not found"" width=""50px"" class=""rounded-circle"" style=""padding-right: 5px"">
                            {{user.email}}
                        </button>
                        </div>
                    </li>
                </ul>
            </div>

            <div class=""chat"">
                <div class=""chat-header"">
                    <div class='name' id='name-chat'>
                        {{receiver}}
                    </div>
                </div>
                <div class=""chat-body"" id=""Chat"">

                </div>
                <div class=""chat-input"" v-if=""receiver !== 'Choose a chat'"">
                    <input class=""form-control"" id=""message"" placeholder=""Enter Message"" v-model=""message"" autocomplete=""off"">
                    <input type=""submit"" class=""btn btn-light"" id=""send""");
            BeginWriteAttribute("value", " value=\"", 2495, "\"", 2503, 0);
            EndWriteAttribute();
            WriteLiteral(" v-on:click=\"sendMessage\">\n                </div>\n            </div>\n\n        </div>\n");
#nullable restore
#line 57 "/home/thb/RiderProjects/CsMessenger/Views/Home/Index.cshtml"
        } 

#line default
#line hidden
#nullable disable
            WriteLiteral("        \n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\n\n        <script type=\"text/javascript\" src=\"js/site.js\">\n        </script>\n\n        ");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
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
