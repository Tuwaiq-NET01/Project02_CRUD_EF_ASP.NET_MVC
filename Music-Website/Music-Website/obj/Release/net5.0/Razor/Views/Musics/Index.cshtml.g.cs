#pragma checksum "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "79289dede9d1499d459eabaadd5de99aeda098f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Musics_Index), @"mvc.1.0.view", @"/Views/Musics/Index.cshtml")]
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
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\_ViewImports.cshtml"
using Music_Website;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\_ViewImports.cshtml"
using Music_Website.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79289dede9d1499d459eabaadd5de99aeda098f9", @"/Views/Musics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91754a4c3abd76473dd9968c0c85a6a6eb4f9522", @"/Views/_ViewImports.cshtml")]
    public class Views_Musics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
  
    var Musics = (List<MusicModel>)ViewData["Musics"];
    var Rating = (List<RateModel>)ViewData["Rating"];
    var id = (int)ViewData["id"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 9 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
 foreach (var Music in Musics)
{
    if (id == -1)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container text-center card1\" style=\"height:260px;margin-top:40px\">\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-4\">\r\n                    <img");
            BeginWriteAttribute("src", " src=", 406, "", 429, 1);
#nullable restore
#line 19 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
WriteAttributeValue("", 411, Music.Music_image, 411, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"container_img\" />\r\n                </div>\r\n                <div class=\"col-8\" style=\"text-align:left;margin-top:50px\">\r\n                    <a class=\"link1\"");
            BeginWriteAttribute("href", " href=\"", 593, "\"", 625, 2);
            WriteAttributeValue("", 600, "/Musics/Details/", 600, 16, true);
#nullable restore
#line 22 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
WriteAttributeValue("", 616, Music.Id, 616, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h1  style=\"color: #78a09c\">");
#nullable restore
#line 23 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
                                               Write(Music.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                        </a>\r\n\r\n");
#nullable restore
#line 26 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
                         foreach (var rate in Rating)
                        {
                            if (rate.MusicId == Music.Id)
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
                                 for (var i = 0; i < 5; i++)
                                {
                                    if (i < rate.score)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"fas fa-star\" style=\"color:orange\"></i>\r\n");
#nullable restore
#line 36 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <i class=\"far fa-star\" style=\"color:orange\"></i>\r\n");
#nullable restore
#line 40 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
                                 

                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <audio controls style=\" width: 655px;margin-top:20px\">\r\n\r\n                            <source");
            BeginWriteAttribute("src", " src=", 1650, "", 1667, 1);
#nullable restore
#line 47 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
WriteAttributeValue("", 1655, Music.audio, 1655, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"audio/mpeg\">\r\n                            Your browser does not support the audio element.\r\n                        </audio>\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 55 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
    }
    else if (Music.ProfileId == id)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"container text-center card1\" style=\"height: 260px;margin-top: 40px\">\r\n\r\n            <div class=\"row\">\r\n\r\n                <div class=\"col-4\">\r\n                    <img");
            BeginWriteAttribute("src", " src=", 2101, "", 2124, 1);
#nullable restore
#line 63 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
WriteAttributeValue("", 2106, Music.Music_image, 2106, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"container_img\" />\r\n                </div>\r\n                <div class=\"col-8\" style=\"text-align:left;margin-top:50px\">\r\n                    <a class=\"link1\"");
            BeginWriteAttribute("href", " href=\"", 2288, "\"", 2320, 2);
            WriteAttributeValue("", 2295, "/Musics/Details/", 2295, 16, true);
#nullable restore
#line 66 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
WriteAttributeValue("", 2311, Music.Id, 2311, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <h1  style=\"color: #78a09c\">");
#nullable restore
#line 67 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
                                               Write(Music.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    </a>\r\n");
#nullable restore
#line 69 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
                     foreach (var rate in Rating)
                    {
                        if (rate.MusicId == Music.Id)
                        {

                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
                             for (var i = 0; i < 5; i++)
                            {
                                if (i < rate.score)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"fas fa-star\" style=\"color:orange\"></i>\r\n");
#nullable restore
#line 79 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <i class=\"far fa-star\" style=\"color:orange\"></i>\r\n");
#nullable restore
#line 83 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
                             

                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <audio controls style=\" width: 655px;margin-top:20px\">\r\n\r\n                        <source");
            BeginWriteAttribute("src", " src=", 3263, "", 3280, 1);
#nullable restore
#line 90 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"
WriteAttributeValue("", 3268, Music.audio, 3268, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" type=\"audio/mpeg\">\r\n                        Your browser does not support the audio element.\r\n                    </audio>\r\n\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 98 "C:\Users\abdul\OneDrive\سطح المكتب\.net\Project02_EF_ASP.NET_MVC\Music-Website\Music-Website\Views\Musics\Index.cshtml"

    }

}

#line default
#line hidden
#nullable disable
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
