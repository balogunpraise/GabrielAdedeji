#pragma checksum "C:\Users\hp\source\repos\Gabriel\Gabriel\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a977248b3ddf9777f2465fc0820d0648284b14f"
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
#line 1 "C:\Users\hp\source\repos\Gabriel\Gabriel\Views\_ViewImports.cshtml"
using Gabriel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\source\repos\Gabriel\Gabriel\Views\_ViewImports.cshtml"
using Gabriel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a977248b3ddf9777f2465fc0820d0648284b14f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cae04bf9243f8922b21edc902b6926d921c4042b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Music", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Compositions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Payment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Works", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("boxed-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hp\source\repos\Gabriel\Gabriel\Views\Home\Index.cshtml"
   
    Layout = null;
    var items = ViewData["Items"] as List<Sheet>;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!doctype html>\r\n<html class=\"no-js\" lang=\"zxx\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a977248b3ddf9777f2465fc0820d0648284b14f5773", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\">\r\n    <title>Gabriel Adedeji</title>\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 294, "\"", 304, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <!-- <link rel=""manifest"" href=""site.webmanifest""> -->
    <link rel=""shortcut icon"" type=""image/x-icon"" href=""img/favicon.png"">
    <!-- Place favicon.ico in the root directory -->
    <!-- CSS here -->
    <link rel=""stylesheet"" href=""css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""css/magnific-popup.css"">
    <link rel=""stylesheet"" href=""css/font-awesome.min.css"">
    <link rel=""stylesheet"" href=""css/themify-icons.css"">
    <link rel=""stylesheet"" href=""css/nice-select.css"">
    <link rel=""stylesheet"" href=""css/audioplayer.css"">
    <link rel=""stylesheet"" href=""css/flaticon.css"">
    <link rel=""stylesheet"" href=""css/gijgo.css"">
    <link rel=""stylesheet"" href=""css/animate.css"">
    <link rel=""stylesheet"" href=""css/slick.css"">
    <link rel=""stylesheet"" href=""css/slicknav.css"">
    <link rel=""stylesheet"" href=""css/style.css"">
    <link rel=""s");
                WriteLiteral("tylesheet\" href=\"css/responsive.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a977248b3ddf9777f2465fc0820d0648284b14f8235", async() => {
                WriteLiteral(@"
    <!--[if lte IE 9]>
            <p class=""browserupgrade"">You are using an <strong>outdated</strong> browser. Please <a href=""https://browsehappy.com/"">upgrade your browser</a> to improve your experience and security.</p>
        <![endif]-->
    <!-- header-start -->
    <header>
        <div class=""header-area "">
            <div id=""sticky-header"" class=""main-header-area"">
                <div class=""container-fluid"">
                    <div class=""header_bottom_border"">
                        <div class=""row align-items-center"">
                            <div class=""col-xl-3 col-lg-2"">
                                <div class=""logo"">
                                    <a href=""index.html"">
                                        <img src=""img/logo.png""");
                BeginWriteAttribute("alt", " alt=\"", 2176, "\"", 2182, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                    </a>
                                </div>
                            </div>
                            <div class=""col-xl-6 col-lg-7"">
                                <div class=""main-menu  d-none d-lg-block"">
                                    <nav>
                                        <ul id=""navigation"">
                                            <li><a href=""#about"">About</a></li>
                                            <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a977248b3ddf9777f2465fc0820d0648284b14f9956", async() => {
                    WriteLiteral("My Works");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</li>
                                            <li><a href=""#contact"">Contact</a></li>
                                        </ul>
                                    </nav>
                                </div>
                            </div>
                            <div class=""col-xl-3 col-lg-3 d-none d-lg-block"">
                                <div class=""social_icon text-right"">
                                    <ul>
                                        <li><a href=""https://www.facebook.com/adedejing""> <i class=""fa fa-facebook""></i> </a></li>
                                        <li><a href=""https://www.twitter.com/adedejing""> <i class=""fa fa-twitter""></i> </a></li>
                                        <li><a href=""https://www.instagram.com/adedejing/?hl=en""> <i class=""fa fa-instagram""></i> </a></li>
                                    </ul>
                                </div>
                            </div>
                            <div class=""col-12"">
  ");
                WriteLiteral(@"                              <div class=""mobile_menu d-block d-lg-none""></div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </header>
    <!-- header-end -->
    <!-- slider_area_start -->
    <div class=""slider_area"">
        <div class=""single_slider  d-flex align-items-center slider_bg_1 overlay2"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-12"">
                        <div class=""slider_text text-center "">
                            <h3>Gabriel.Adédèjì </h3>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- slider_area_end -->
    <!-- music_area  -->
    <div class=""music_area"">
        <div class=""container"">
            <div class=""row align-items-center justify-content-center"">
                <div class=""col-xl-10");
                WriteLiteral(@""">
                    <div class=""row align-items-center"">
                        <div class=""col-xl-9 col-md-9"">
                            <div class=""music_field"">
                                <div class=""thumb"">
                                    <img src=""https://yt3.ggpht.com/ytc/AKedOLRYz0LxF7_aAZ3R4tiHcSdZ2CE8NeNvGE1PQl76qQ=s176-c-k-c0x00ffffff-no-rj-mo""
                                         height=""140"" width=""140""");
                BeginWriteAttribute("alt", " alt=\"", 5230, "\"", 5236, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                                </div>
                                <div class=""audio_name"">
                                    <div class=""name"">
                                        <h4>Gabriel Adedeji</h4>
                                        <p>10 November, 2019</p>
                                    </div>
                                    <audio preload=""auto"" controls>
                                        <source src=""https://www.w3schools.com/html/horse.mp3"">
                                    </audio>
                                </div>
                            </div>
                        </div>
                        <div class=""col-xl-3 col-md-3"">
                            <div class=""music_btn"">
                                <a href=""#"" class=""boxed-btn"">Book me</a>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
    <!-- music_a");
                WriteLiteral(@"rea end  -->
    <!-- about_area  -->
    <div id=""about"" class=""about_area"">
        <div class=""container"">
            <div class=""row align-items-center"">
                <div class=""col-xl-5 col-md-6"">
                    <div class=""about_thumb"">
                        <img class=""img-fluid"" src=""img/photo1.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 6588, "\"", 6594, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
                <div class=""col-xl-7 col-md-6"">
                    <div class=""about_info"">
                        <h3>Gabriel Adédèjì</h3>
                        <p>
                            is a Nigerian composer and pianist. He started his musical journey through Yorùbá folk tales that his late mother told, and these tales usually had music, Gabriel believes he owes his musical inspiration to the musical culture of the Yorùbá people. He was introduced to playing drums at the age of 7 and he was soon exposed to the talking drum as a child. He was later introduced to playing keyboards at his father’s church and soon took up a musical career, studying in Peter Kings College of Music, Society of Performing arts of Nigeria and the Musical Society of Nigeria.

                            Gabriel currently resides in Lagos Nigeria where he teaches, writes and performs. He works as an arranger for the Loveworld orchestra, he is also the resident pi");
                WriteLiteral(@"anist and Assistant music director of the Arts in medicine fellowship, Nigeria.

                            He has worked with amazing musicians like Victor Odetunde, Victor Ademofe, Bright Gain, Victor Masondo, Taiwo Clegg, Clintonic Strings, Tombrapade Robert, T sharp, Etuk Ubong and more.....

                            Compositions by Gabriel Adédèjì include Tẹramọ́ṣẹ́, Abule, Ajo, Ọmọ́wùnmí, Ṣọbọ, Ẹmu Ògùrọ̀, Tujuka, Ọpẹ and many others.
                        </p>

                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--/ about_area  -->
    <!-- youtube_video_area  -->
    <div class=""youtube_video_area"">
        <div class=""container-fluid p-0"">
            <div class=""row no-gutters d-flex justify-content-center"">
                <div class=""col-xl-3 col-lg-3 col-md-6"">
                    <div class=""single_video"">
                        <div class=""thumb"">
                            <img src=""img/omowumi.jpg"" height=""200""");
                BeginWriteAttribute("alt", " alt=\"", 8637, "\"", 8643, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""hover_elements"">
                            <div class=""video"">
                                <a class=""popup-video"" href=""https://www.youtube.com/watch?v=9sIvqOEXnrE"">
                                    <i class=""fa fa-play""></i>
                                </a>
                            </div>

                            <div class=""hover_inner"">
                                <span>New York Show-2018</span>
                                <h3><a href=""#"">Ọmọ́wùnmí</a></h3>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-3 col-lg-3 col-md-6"">
                    <div class=""single_video"">
                        <div class=""thumb"">
                            <img src=""img/gab5.jpg"" height=""200""");
                BeginWriteAttribute("alt", " alt=\"", 9553, "\"", 9559, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""hover_elements"">
                            <div class=""video"">
                                <a class=""popup-video"" href=""https://www.youtube.com/watch?v=GpaJKcQ-RDU"">
                                    <i class=""fa fa-play""></i>
                                </a>
                            </div>

                            <div class=""hover_inner"">
                                <span>New York Show-2018</span>
                                <h3><a href=""#"">Black Culture 365 at Trinity Laban</a></h3>
                            </div>
                        </div>
                    </div>
                </div>
               
                <div class=""col-xl-3 col-lg-3 col-md-6"">
                    <div class=""single_video"">
                        <div class=""thumb"">
                            <img src=""img/tere.jpg"" height=""200""");
                BeginWriteAttribute("alt", " alt=\"", 10511, "\"", 10517, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""hover_elements"">
                            <div class=""video"">
                                <a class=""popup-video"" href=""https://www.youtube.com/watch?v=4qBg5-oNxrk"">
                                    <i class=""fa fa-play""></i>
                                </a>
                            </div>

                            <div class=""hover_inner"">
                                <span>New York Show-2018</span>
                                <h3><a href=""#"">Shadows of My Dream</a></h3>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!-- / youtube_video_area  -->
    <!-- music_area  -->
    <div class=""music_area music_gallery"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-12"">
                    <div class=""section_title text-center mb-");
                WriteLiteral("65\">\r\n                        <h3>Latest Tracks</h3>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"row align-items-center justify-content-center mb-20\">\r\n                <div class=\"col-xl-10\">\r\n");
#nullable restore
#line 242 "C:\Users\hp\source\repos\Gabriel\Gabriel\Views\Home\Index.cshtml"
                     foreach (var item in items)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <div class=""row align-items-center"">
                            <div class=""col-xl-9 col-md-9"">
                                <div class=""music_field"">
                                    <div class=""thumb"">
                                        <img");
                BeginWriteAttribute("src", " src=\"", 12144, "\"", 12150, 0);
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 12151, "\"", 12157, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                    </div>\r\n                                    <div class=\"audio_name\">\r\n                                        <div class=\"name\">\r\n                                            <h4>");
#nullable restore
#line 252 "C:\Users\hp\source\repos\Gabriel\Gabriel\Views\Home\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" (");
#nullable restore
#line 252 "C:\Users\hp\source\repos\Gabriel\Gabriel\Views\Home\Index.cshtml"
                                                       Write(item.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(")</h4>\r\n                                            <p>");
#nullable restore
#line 253 "C:\Users\hp\source\repos\Gabriel\Gabriel\Views\Home\Index.cshtml"
                                          Write(item.Composer);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                                        </div>\r\n                                        <a");
                BeginWriteAttribute("href", " href=", 12569, "", 12584, 1);
#nullable restore
#line 255 "C:\Users\hp\source\repos\Gabriel\Gabriel\Views\Home\Index.cshtml"
WriteAttributeValue("", 12575, item.Url, 12575, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                            <audio preload=""auto"" controls controlsList=""nodownload"">
                                                <source src=""https://drive.google.com/file/d/13KxqnmtxKKq6_au1nUZxYhNFLvgRQsFV/view?usp=drivesdk"">
                                            </audio>
                                        </a>
                                    </div>

                                </div>
                            </div>
                            <div class=""col-xl-3 col-md-3"">
                                <div class=""music_btn"">
                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a977248b3ddf9777f2465fc0820d0648284b14f24492", async() => {
                    WriteLiteral("buy piece");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 270 "C:\Users\hp\source\repos\Gabriel\Gabriel\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>

            </div>
        </div>
    </div>
    <!-- music_area end  -->
    <!-- gallery -->
    <div class=""gallery_area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-12"">
                    <div class=""section_title text-center mb-65"">
                        <h3>Image Galleries</h3>
                    </div>
                </div>
            </div>
            <div class=""row d-grid"">
                <div class=""col-xl-5 col-lg-5 grid-item cat1 col-md-6"">
                    <div class=""single-gallery mb-30"">
                        <div class=""portfolio-img"">
                            <img src=""img/Photo2croped.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 14158, "\"", 14164, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                        <div class=\"gallery_hover\">\r\n                            <a class=\"popup-image hover_inner\" href=\"img/Photo2croped.jpg\" ");
                WriteLiteral(@">
                                <i class=""ti-plus""></i>
                            </a>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-7 col-lg-7 grid-item cat3 cat4 col-md-6"">
                    <div class=""single-gallery mb-30"">
                        <div class=""portfolio-img"">
                            <img height=""370"" src=""https://scontent.fabv2-2.fna.fbcdn.net/v/t31.18172-8/15875022_1388723921146009_14807062940937790_o.jpg?_nc_cat=111&ccb=1-5&_nc_sid=e3f864&_nc_eui2=AeHre6Dme2jA8w1dPqxjt8vU0MslRPv-ZrfQyyVE-_5mtzv5buw3i5vsXLYor77FQKiIA1YpyORTmLW8Qr7VdPO7&_nc_ohc=JvmlNvit_GMAX_2VB9i&_nc_ht=scontent.fabv2-2.fna&oh=7669d3d86857219e5ab1d4d4929890e3&oe=61B69150""");
                BeginWriteAttribute("alt", " alt=\"", 15123, "\"", 15129, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""gallery_hover"">
                            <a class=""popup-image hover_inner"" href=""https://scontent.fabv2-2.fna.fbcdn.net/v/t31.18172-8/15875022_1388723921146009_14807062940937790_o.jpg?_nc_cat=111&ccb=1-5&_nc_sid=e3f864&_nc_eui2=AeHre6Dme2jA8w1dPqxjt8vU0MslRPv-ZrfQyyVE-_5mtzv5buw3i5vsXLYor77FQKiIA1YpyORTmLW8Qr7VdPO7&_nc_ohc=JvmlNvit_GMAX_2VB9i&_nc_ht=scontent.fabv2-2.fna&oh=7669d3d86857219e5ab1d4d4929890e3&oe=61B69150"" ");
                WriteLiteral(@">
                                <i class=""ti-plus""></i>
                            </a>
                        </div>
                    </div>
                </div>
                <div class=""col-xl-4 col-lg-6 grid-item cat4 col-md-6"">
                    <div class=""single-gallery mb-30"">
                        <div class=""portfolio-img"">
                            <img src=""img/photo3edited.jpg"" height=""500"" width=""250""");
                BeginWriteAttribute("alt", " alt=\"", 16095, "\"", 16101, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <div class=""gallery_hover"">
                            <a class=""popup-image hover_inner"" href=""img/photo3edited.jpg"">
                                <i class=""ti-plus""></i>
                            </a>
                        </div>
                    </div>
                </div>
");
                WriteLiteral(@"
            </div>
        </div>
    </div>
    <!--/ gallery -->
    <!-- contact_rsvp -->
    <div class=""contact_rsvp"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xl-12"">
                    <div class=""text text-center"">
                        <h3>Contact For RSVP</h3>
                        <a class=""boxed-btn3"" href=""contact.html"">Contact Me</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <!--/ contact_rsvp -->
    <!-- footer start -->
    <footer class=""footer"">
        <div class=""footer_top"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xl-6 col-md-6"">
                        <div class=""footer_widget"">
                            <h3 class=""footer_title"">
                                Services
                            </h3>
                            <div class=""subscribe-from"">
                ");
                WriteLiteral("                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a977248b3ddf9777f2465fc0820d0648284b14f31045", async() => {
                    WriteLiteral("\r\n                                    <input type=\"text\" placeholder=\"Enter your mail\">\r\n                                    <button type=\"submit\">Subscribe</button>\r\n                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </div>
                            <p class=""sub_text"">Find out more about my services...</p>
                        </div>
                    </div>
                    <div id=""contact"" class=""col-xl-5 col-md-5 offset-xl-1"">
                        <div class=""footer_widget"">
                            <h3 class=""footer_title"">
                                Contact Me
                            </h3>
                            <ul>
                                <li>
                                    <a href=""info@gabrieladedeji.com"">
                                        info@gabrieladedeji.com
                                    </a>
                                </li>
                                <li>
                                    <a href=""#"">
                                        +234 803 064 6779
                                    </a>
                                </li>
                                <!-- <li><a href=""#"">60");
                WriteLiteral(@"0/D, Green road, Kings Garden NewYork-6732</a></li> -->
                            </ul>
                            <div class=""socail_links"">
                                <ul>
                                    <li>
                                        <a href=""https://www.facebook.com/adedejing"">
                                            <i class="" fa fa-facebook ""></i>
                                        </a>
                                    </li>

                                    <li>
                                        <a href=""https://www.twitter.com/adedejing"">
                                            <i class=""fa fa-twitter""></i>
                                        </a>
                                    </li>
                                    <li>
                                        <a href=""#"">
                                            <i class=""fa fa-youtube-play""></i>
                                        </a>
                          ");
                WriteLiteral(@"          </li>
                                    <li>
                                        <a href=""https://www.instagram.com/adedejing/?hl=en"">
                                            <i class=""fa fa-instagram""></i>
                                        </a>
                                    </li>
                                </ul>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""copy-right_text"">
            <div class=""container"">
                <div class=""footer_border""></div>
                <div class=""row"">
                    <div class=""col-xl-7 col-md-6"">
                        <p class=""copy_right"">
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                            Copyright &copy;
                            <script>document.write(new Date().getFullYear());</scr");
                WriteLiteral(@"ipt><a> All rights reserved</a>
                            <!-- Link back to Colorlib can't be removed. Template is licensed under CC BY 3.0. -->
                        </p>
                    </div>
                    <div class=""col-xl-5 col-md-6"">
                        <div class=""footer_links"">
                            <ul>

                                <li><a href=""#"">about</a></li>
                                <li><a href=""#"">tracks</a></li>

                                <li><a href=""#"">contact</a></li>
                            </ul>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </footer>


    <script src=""https://code.jquery.com/jquery-3.3.1.slim.min.js""
            integrity=""sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo""
            crossorigin=""anonymous"">
    </script>
    <script src=""js/vendor/modernizr-3.5.0.min.js""></script>
    <script src=""js/vendo");
                WriteLiteral(@"r/jquery-1.12.4.min.js""></script>
    <script src=""js/popper.min.js""></script>
    <script src=""js/bootstrap.min.js""></script>
    <script src=""js/owl.carousel.min.js""></script>
    <script src=""js/isotope.pkgd.min.js""></script>
    <script src=""js/ajax-form.js""></script>
    <script src=""js/waypoints.min.js""></script>
    <script src=""js/jquery.counterup.min.js""></script>
    <script src=""js/imagesloaded.pkgd.min.js""></script>
    <script src=""js/audioplayer.js""></script>
    <script src=""js/scrollIt.js""></script>
    <script src=""js/jquery.scrollUp.min.js""></script>
    <script src=""js/wow.min.js""></script>
    <script src=""js/nice-select.min.js""></script>
    <script src=""js/jquery.slicknav.min.js""></script>
    <script src=""js/jquery.magnific-popup.min.js""></script>
    <script src=""js/plugins.js""></script>
    <script src=""js/gijgo.min.js""></script>
    <script src=""js/slick.min.js""></script>
    <script src=""js/contact.js""></script>
    <script src=""js/jquery.ajaxchimp.min.js""></scri");
                WriteLiteral(@"pt>
    <script src=""js/jquery.form.js""></script>
    <script src=""js/jquery.validate.min.js""></script>
    <script src=""js/mail-script.js""></script>

    <script src=""js/main.js""></script>

    <script>
                $(function() {
                    $('audio').audioPlayer({

                    });
                });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
