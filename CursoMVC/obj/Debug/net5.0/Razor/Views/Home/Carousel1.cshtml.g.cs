#pragma checksum "c:\Users\rafael.basso\Documents\Personal\GitHub_Projects\CursoMVC\CursoMVC\Views\Home\Carousel1.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "b3291d30b970c090e9f8b94c5b7572368c4643a31c283ff5e42358c74a4a5197"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Carousel1), @"mvc.1.0.view", @"/Views/Home/Carousel1.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "c:\Users\rafael.basso\Documents\Personal\GitHub_Projects\CursoMVC\CursoMVC\Views\_ViewImports.cshtml"
using CursoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\rafael.basso\Documents\Personal\GitHub_Projects\CursoMVC\CursoMVC\Views\_ViewImports.cshtml"
using CursoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"b3291d30b970c090e9f8b94c5b7572368c4643a31c283ff5e42358c74a4a5197", @"/Views/Home/Carousel1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"9b5d3b033f79c7a44cdb63466bccd1d16fa4a196eecf1f921827af5c7abce1a6", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Carousel1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!--<link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
<style>
    .carousel-inner > .item > img,
    .carousel-inner > .item > a > img {
        width: 70%;
        margin: auto;
    }
</style>


<div class=""container"">
    <h2>Activate Carousel with JavaScript</h2>
    <div id=""myCarousel"" class=""carousel slide"">-->
<!-- Indicators -->
<!--<ol class=""carousel-indicators"">
    <li class=""item1 active""></li>
    <li class=""item2""></li>
    <li class=""item3""></li>
    <li class=""item4""></li>
</ol>-->
<!-- Wrapper for slides -->
<!--<div class=""carousel-inner"" role=""listbox"">

    <div class=""item active"">
        <img src=""/Images/bootstrap.png"" alt=""Chania"" width=""460"" height=""345"">
        <div class=""carousel-caption"">
            <h3>Chania</h3>
     ");
            WriteLiteral(@"       <p>The atmosphere in Chania has a touch of Florence and Venice.</p>
        </div>
    </div>

    <div class=""item"">
        <img src=""~/Images/html-css.png"" alt=""Chania"" width=""460"" height=""345"">
        <div class=""carousel-caption"">
            <h3>Chania</h3>
            <p>The atmosphere in Chania has a touch of Florence and Venice.</p>
        </div>
    </div>

    <div class=""item"">
        <img src=""/Images/jQuery.png"" alt=""Flower"" width=""460"" height=""345"">
        <div class=""carousel-caption"">
            <h3>Flowers</h3>
            <p>Beautiful flowers in Kolymbari, Crete.</p>
        </div>
    </div>

    <div class=""item"">
        <img src=""~/Images/js.png"" alt=""Flower"" width=""460"" height=""345"">
        <div class=""carousel-caption"">
            <h3>Flowers</h3>
            <p>Beautiful flowers in Kolymbari, Crete.</p>
        </div>
    </div>

</div>-->
<!-- Left and right controls -->
<!--<a class=""left carousel-control"" href=""#myCarousel"" role=""button""");
            WriteLiteral(@">
                <span class=""glyphicon glyphicon-chevron-left"" aria-hidden=""true""></span>
                <span class=""sr-only"">Previous</span>
            </a>
            <a class=""right carousel-control"" href=""#myCarousel"" role=""button"">
                <span class=""glyphicon glyphicon-chevron-right"" aria-hidden=""true""></span>
                <span class=""sr-only"">Next</span>
            </a>
        </div>
    </div>

    <script>
$(document).ready(function(){
  // Activate Carousel
  $(""#myCarousel"").carousel();

  // Enable Carousel Indicators
  $("".item1"").click(function(){
    $(""#myCarousel"").carousel(0);
  });
  $("".item2"").click(function(){
    $(""#myCarousel"").carousel(1);
  });
  $("".item3"").click(function(){
    $(""#myCarousel"").carousel(2);
  });
  $("".item4"").click(function(){
    $(""#myCarousel"").carousel(3);
  });

  // Enable Carousel Controls
  $("".left"").click(function(){
    $(""#myCarousel"").carousel(""prev"");
  });
  $("".right"").click(function(){
    ");
            WriteLiteral(@"$(""#myCarousel"").carousel(""next"");
  });
});
    </script>-->

<div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">

    <div class=""carousel-inner"">
        <div class=""carousel-item active"">
            <img class=""d-block w-100"" src=""/Images/html-css.png"" alt=""First slide"" style=""max-width: max-content"">
        </div>
        <div class=""carousel-item"">
            <img class=""d-block w-100"" src=""/Images/html-css.png"" alt=""Second slide"" style=""max-width: max-content"">
        </div>
        <div class=""carousel-item"">
            <img class=""d-block w-100"" src=""/Images/html-css.png"" alt=""Third slide"" style=""max-width: max-content"">
        </div>
    </div>
</div>

<div class=""col-12 mt-5"">
    <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
        <!--<span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>-->
        <span aria-hidden=""true"" style=""color: black"">🡸</span>
        <span cla");
            WriteLiteral(@"ss=""sr-only"">Previous</span>
    </a>
    <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
        <!--<span class=""carousel-control-next-icon"" aria-hidden=""true""></span>-->
        <span aria-hidden=""true"" style=""color: black"">🢂</span>
        <span class=""sr-only"">Next</span>
    </a>
    <ol class=""carousel-indicators"">
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""0"" class=""active"" style=""background-color: black""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""1"" style=""background-color: black""></li>
        <li data-target=""#carouselExampleIndicators"" data-slide-to=""2"" style=""background-color: black""></li>
    </ol>
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
