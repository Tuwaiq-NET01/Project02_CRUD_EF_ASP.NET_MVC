#pragma checksum "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94b19ab8f6c812263a973e194581375e4447f1b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Musics_Details), @"mvc.1.0.view", @"/Views/Musics/Details.cshtml")]
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
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\_ViewImports.cshtml"
using Music_Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\_ViewImports.cshtml"
using Music_Website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94b19ab8f6c812263a973e194581375e4447f1b5", @"/Views/Musics/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91754a4c3abd76473dd9968c0c85a6a6eb4f9522", @"/Views/_ViewImports.cshtml")]
    public class Views_Musics_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml"
  

    var Musics = (List<MusicModel>)ViewData["Musics"];
    var id = (int)ViewData["id"];
    var Rating = (List<RateModel>)ViewData["Rating"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml"
 foreach (var Music in Musics)
{
    if (id == Music.Id)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container overflow-hidden\">\r\n    <div class=\"row gx-5\">\r\n        <div class=\"col\">\r\n            <div class=\"p-3  \">\r\n                <img");
            BeginWriteAttribute("src", " src=", 377, "", 400, 1);
#nullable restore
#line 18 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml"
WriteAttributeValue("", 382, Music.Music_image, 382, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n        </div>\r\n        <div class=\"col\">\r\n            <div class=\"p-3 \" style=\"margin-top:50px\">\r\n                <h1 style=\"color: #78a09c\">");
#nullable restore
#line 23 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml"
                                      Write(Music.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 24 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml"
                 foreach (var rate in Rating)
                {
                    if (rate.MusicId == id)
                    {

                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml"
                         for (var i = 0; i < 5; i++)
                        {
                            if (i < rate.score)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"fas fa-star\" style=\"color:orange\"></i>\r\n");
#nullable restore
#line 34 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <i class=\"far fa-star\" style=\"color:orange\"></i>\r\n");
#nullable restore
#line 38 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml"
                         

                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <audio controls style=\" width: 450px;margin-top:20px\">\r\n\r\n                    <source");
            BeginWriteAttribute("src", " src=", 1346, "", 1363, 1);
#nullable restore
#line 45 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml"
WriteAttributeValue("", 1351, Music.audio, 1351, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"audio/mpeg\">\r\n                    Your browser does not support the audio element.\r\n                </audio>\r\n                <br /><br /><br />\r\n                <h5>Description : </h5>\r\n                <p>");
#nullable restore
#line 50 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml"
              Write(Music.description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 57 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project03_CRUD_With_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Details.cshtml"
    }
}

#line default
#line hidden
#nullable disable
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
