#pragma checksum "C:\Users\1\Documents\проекты visual\FoodDeliveryProject\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "768fa419c1817d5d0cb6776ecc4c73a6f6e6cb92"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoodDeliveryProject.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace FoodDeliveryProject.Pages
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
#line 1 "C:\Users\1\Documents\проекты visual\FoodDeliveryProject\Pages\_ViewImports.cshtml"
using FoodDeliveryProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"768fa419c1817d5d0cb6776ecc4c73a6f6e6cb92", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"522e95e6cbf2fc50612d0172f54c8edc46018475", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "768fa419c1817d5d0cb6776ecc4c73a6f6e6cb923075", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>Окамаки</title>
    <meta name=""format-detection"" content=""telephone=no"">
    <link rel=""stylesheet"" type=""text/css"" href=""css/main_page.css"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0, maximum-scale=1.0, user-scalable=0"">
");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "768fa419c1817d5d0cb6776ecc4c73a6f6e6cb924353", async() => {
                WriteLiteral("\r\n    <header class=\"header\">\r\n        <div class=\"header__row\">\r\n            <div class=\"header__logo\">\r\n                <a href=\"main_page.html\"><img src=\"img/logo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 586, "\"", 592, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n            </div>\r\n            <div class=\"line-block\"></div>\r\n            <div class=\"header__social\">\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 724, "\"", 731, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div class=\"social__inst\">\r\n                        <img src=\"img/instagram.png\"");
                BeginWriteAttribute("alt", " alt=\"", 835, "\"", 841, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    </div>\r\n                </a>\r\n                <a");
                BeginWriteAttribute("href", " href=\"", 913, "\"", 920, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <div class=\"social__vk\">\r\n                        <img src=\"img/vk.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1015, "\"", 1021, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </a>
            </div>
            <div class=""header__contact"">
                <p class=""tell"">8 (843) 222-33-33</p>
                <p class=""schedule"">Пн-Вс <span>10:00-00:30</span></p>
            </div>
            <div class=""personal-account__row"">
                <div class=""personal-account__count"">
                    <p class=""personal-account__p"">Мои баллы: <span>0</span></p>
                    <a href=""points.html""");
                BeginWriteAttribute("class", " class=\"", 1512, "\"", 1520, 0);
                EndWriteAttribute();
                WriteLiteral("><p class=\"personal-account__how\">Как начисляются баллы?</p></a>\r\n                </div>\r\n                <a href=\"personal-account.html\"");
                BeginWriteAttribute("class", " class=\"", 1658, "\"", 1666, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"img/enter.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1692, "\"", 1698, 0);
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 1699, "\"", 1707, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n            </div>\r\n        </div>\r\n        <div class=\"header__menu\">\r\n            <div class=\"menu__body\">\r\n                <ul class=\"menu__list\">\r\n                    <li class=\"menu_link\"><a href=\"rolls.html\"");
                BeginWriteAttribute("class", " class=\"", 1928, "\"", 1936, 0);
                EndWriteAttribute();
                WriteLiteral(">Роллы</a></li>\r\n                    <li class=\"menu_link\"><a href=\"sushi.html\"");
                BeginWriteAttribute("class", " class=\"", 2016, "\"", 2024, 0);
                EndWriteAttribute();
                WriteLiteral(">Суши</a></li>\r\n                    <li class=\"menu_link\"><a href=\"pizza.html\"");
                BeginWriteAttribute("class", " class=\"", 2103, "\"", 2111, 0);
                EndWriteAttribute();
                WriteLiteral(">Пицца</a></li>\r\n                    <li class=\"menu_link\"><a href=\"drinks.html\"");
                BeginWriteAttribute("class", " class=\"", 2192, "\"", 2200, 0);
                EndWriteAttribute();
                WriteLiteral(">Напитки</a></li>\r\n                    <li class=\"menu_link1\"><a href=\"basket.html\"");
                BeginWriteAttribute("class", " class=\"", 2284, "\"", 2292, 0);
                EndWriteAttribute();
                WriteLiteral(">Корзина: </a> <span>0</span></li>\r\n                    <li class=\"menu_link\"><a href=\"reviews.html\"");
                BeginWriteAttribute("class", " class=\"", 2393, "\"", 2401, 0);
                EndWriteAttribute();
                WriteLiteral(">Отзывы</a></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </header>\r\n    <div class=\"slider\">\r\n        <div class=\"slider__item\">\r\n            <img src=\"img/h9zMAlkfzuk.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 2598, "\"", 2604, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"slider__item\">\r\n            <img src=\"img/sYKuB_oHQUk.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 2702, "\"", 2708, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n        </div>\r\n        <div class=\"slider__item\">\r\n            <img src=\"img/lnDXbhknzrg.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 2806, "\"", 2812, 0);
                EndWriteAttribute();
                WriteLiteral(@">
        </div>
    </div>
    <div class=""content"">
        <div class=""container"">
            <h1 class=""popular-goods"">Популярные товары</h1>
            <div class=""goods__row"">
                <div class=""goods__block"">
                    <img src=""img/roll1.png""");
                BeginWriteAttribute("alt", " alt=\"", 3092, "\"", 3098, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""goods__text"">
                        <p class=""goods__name"">Ролл Филадельфия</p>
                        <p class=""goods__description"">Лосось, авокадо, сыр сливочный, рис, нори</p>
                    </div>
                    <div class=""goods-bottom__row"">
                        <div class=""goods-price__row"">
                            <p class=""goods-price__mass"">230 грамм</p>
                            <p class=""goods-price__price"">259 <img src=""img/ruble.png""");
                BeginWriteAttribute("alt", " alt=\"", 3614, "\"", 3620, 0);
                EndWriteAttribute();
                WriteLiteral("></p>\r\n                        </div>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3686, "\"", 3693, 0);
                EndWriteAttribute();
                WriteLiteral("><div class=\"into_basket\">В корзину</div></a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"goods__block\">\r\n                    <img src=\"img/roll2.png\"");
                BeginWriteAttribute("alt", " alt=\"", 3881, "\"", 3887, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""goods__text"">
                        <p class=""goods__name"">Ролл Филадельфия</p>
                        <p class=""goods__description"">Лосось, авокадо, сыр сливочный, рис, нори</p>
                    </div>
                    <div class=""goods-bottom__row"">
                        <div class=""goods-price__row"">
                            <p class=""goods-price__mass"">230 грамм</p>
                            <p class=""goods-price__price"">259 <img src=""img/ruble.png""");
                BeginWriteAttribute("alt", " alt=\"", 4403, "\"", 4409, 0);
                EndWriteAttribute();
                WriteLiteral("></p>\r\n                        </div>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 4475, "\"", 4482, 0);
                EndWriteAttribute();
                WriteLiteral("><div class=\"into_basket\">В корзину</div></a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"goods__block\">\r\n                    <img src=\"img/roll3.png\"");
                BeginWriteAttribute("alt", " alt=\"", 4670, "\"", 4676, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""goods__text"">
                        <p class=""goods__name"">Ролл Филадельфия</p>
                        <p class=""goods__description"">
                            Лосось, авокадо, сыр сливочный, рис, нори,
                            лосось, авокадо, сыр сливочный, рис, нори
                        </p>
                    </div>
                    <div class=""goods-bottom__row"">
                        <div class=""goods-price__row"">
                            <p class=""goods-price__mass"">230 грамм</p>
                            <p class=""goods-price__price"">259 <img src=""img/ruble.png""");
                BeginWriteAttribute("alt", " alt=\"", 5320, "\"", 5326, 0);
                EndWriteAttribute();
                WriteLiteral("></p>\r\n                        </div>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 5392, "\"", 5399, 0);
                EndWriteAttribute();
                WriteLiteral("><div class=\"into_basket\">В корзину</div></a>\r\n                    </div>\r\n                </div>\r\n                <div class=\"goods__block\">\r\n                    <img src=\"img/roll4.png\"");
                BeginWriteAttribute("alt", " alt=\"", 5587, "\"", 5593, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""goods__text"">
                        <p class=""goods__name"">Ролл Филадельфия</p>
                        <p class=""goods__description"">Лосось, авокадо, сыр сливочный, рис, нори</p>
                    </div>
                    <div class=""goods-bottom__row"">
                        <div class=""goods-price__row"">
                            <p class=""goods-price__mass"">230 грамм</p>
                            <p class=""goods-price__price"">259 <img src=""img/ruble.png""");
                BeginWriteAttribute("alt", " alt=\"", 6109, "\"", 6115, 0);
                EndWriteAttribute();
                WriteLiteral("></p>\r\n                        </div>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 6181, "\"", 6188, 0);
                EndWriteAttribute();
                WriteLiteral(@"><div class=""into_basket"">В корзину</div></a>
                    </div>
                </div>
            </div>
            <h2 class=""appetit"">Аппетитные суши с доставкой на дом</h2>
            <p class=""appetit__text"">
                Сеть кафе-баров «Окимаки» предлагает заказать вкусные и свежие суши в Казани.
                Мы быстро доставим еду на дом или в офис, чтобы вы могли насладиться вкусом без хлопот.
            </p>
            <p class=""appetit__text"">
                У Вас намечается вечеринка с множеством гостей?
                Хотите устроить своей второй половинке романтический ужин при свечах?
                Или планируете полностью раслабиться и вкусно поесть в кругу семьи?
                Вам не нужно проводить часы на кухне. Просто закажите суши - их любят многие!
                Профессиональные повара сделают все за Вас, а курьеры доставят свежеприготовленную еду в ратчайший срок.
            </p>
            <h3 class=""anticipation"">
                Мы вас оч");
                WriteLiteral(@"ень ждём в наших заведениях
            </h3>
            <div class=""address__row"">
                <div class=""address__block"">
                    <p class=""address__text"">проспект Ямашева, 43А</p>
                    <p class=""address__text"">улица Хайдара Бигичева, 3</p>
                    <p class=""address__text"">проспект Ямашева, 82</p>
                    <p class=""address__text"">улица Копылова, 14</p>
                </div>
                <div class=""address__block"">
                    <p class=""address__text"">улица Калинина, 32</p>
                    <p class=""address__text"">улица Глушко, 17</p>
                    <p class=""address__text"">улица Юлиуса Фучика, 88</p>
                    <p class=""address__text"">улица Декабристов, 85</p>
                </div>
                <div class=""address__block"">
                    <img src=""img/address.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 8103, "\"", 8109, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                </div>
            </div>
        </div>
    </div>
    <footer class=""footer"">
        <div class=""footer__text-block"">
            <p class=""footer__text"">© 2020 «Окимаки»</p>
            <p class=""footer__text"">Реклама и сотрудничество:</p>
            <p class=""footer__text"">marketolog@okimakikazan.ru</p>
            <p class=""footer__text"">Для коммерческих предложений:</p>
            <p class=""footer__text"">commerce@okimakikazan.ru</p>
        </div>
    </footer>
    <script src=""js/jquery-3.5.1.min.js""></script>
    <script src=""js/slick.min.js""></script>
    <script src=""js/main.js""></script>
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodDeliveryProject.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoodDeliveryProject.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoodDeliveryProject.Pages.IndexModel>)PageContext?.ViewData;
        public FoodDeliveryProject.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
