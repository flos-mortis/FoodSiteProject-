#pragma checksum "C:\Users\1\Documents\проекты visual\FoodDeliveryProject\Pages\Registration.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4b45db80c462e2317c307ea9eb8585af93d7df7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FoodDeliveryProject.Pages.Pages_Registration), @"mvc.1.0.razor-page", @"/Pages/Registration.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4b45db80c462e2317c307ea9eb8585af93d7df7", @"/Pages/Registration.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"522e95e6cbf2fc50612d0172f54c8edc46018475", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Registration : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "SignUp", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Registration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!DOCTYPE html>\r\n    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4b45db80c462e2317c307ea9eb8585af93d7df74796", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"">
        <title>Окамаки</title>
        <!--    <link type=""image/x-icon"" rel=""icon"" href=""favicon.ico""/>-->
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4b45db80c462e2317c307ea9eb8585af93d7df76186", async() => {
                WriteLiteral("\r\n        <header class=\"header\">\r\n            <div class=\"header__row\">\r\n                <div class=\"header__logo\">\r\n                    <a href=\"main_page.html\"><img src=\"img/logo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 717, "\"", 723, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                </div>\r\n                <div class=\"line-block\"></div>\r\n                <div class=\"header__social\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 871, "\"", 878, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"social__inst\">\r\n                            <img src=\"img/instagram.png\"");
                BeginWriteAttribute("alt", " alt=\"", 990, "\"", 996, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                    </a>\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 1080, "\"", 1087, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <div class=\"social__vk\">\r\n                            <img src=\"img/vk.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1190, "\"", 1196, 0);
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
                BeginWriteAttribute("class", " class=\"", 1731, "\"", 1739, 0);
                EndWriteAttribute();
                WriteLiteral("><p class=\"personal-account__how\">Как начисляются баллы?</p></a>\r\n                    </div>\r\n                    <a href=\"personal-account.html\"");
                BeginWriteAttribute("class", " class=\"", 1885, "\"", 1893, 0);
                EndWriteAttribute();
                WriteLiteral("><img src=\"img/enter.png\"");
                BeginWriteAttribute("alt", " alt=\"", 1919, "\"", 1925, 0);
                EndWriteAttribute();
                BeginWriteAttribute("class", " class=\"", 1926, "\"", 1934, 0);
                EndWriteAttribute();
                WriteLiteral("></a>\r\n                </div>\r\n            </div>\r\n            <div class=\"header__menu\">\r\n                <div class=\"menu__body\">\r\n                    <ul class=\"menu__list\">\r\n                        <li class=\"menu_link\"><a href=\"rolls.html\"");
                BeginWriteAttribute("class", " class=\"", 2179, "\"", 2187, 0);
                EndWriteAttribute();
                WriteLiteral(">Роллы</a></li>\r\n                        <li class=\"menu_link\"><a href=\"sushi.html\"");
                BeginWriteAttribute("class", " class=\"", 2271, "\"", 2279, 0);
                EndWriteAttribute();
                WriteLiteral(">Суши</a></li>\r\n                        <li class=\"menu_link\"><a href=\"pizza.html\"");
                BeginWriteAttribute("class", " class=\"", 2362, "\"", 2370, 0);
                EndWriteAttribute();
                WriteLiteral(">Пицца</a></li>\r\n                        <li class=\"menu_link\"><a href=\"drinks.html\"");
                BeginWriteAttribute("class", " class=\"", 2455, "\"", 2463, 0);
                EndWriteAttribute();
                WriteLiteral(">Напитки</a></li>\r\n                        <li class=\"menu_link1\"><a href=\"basket.html\"");
                BeginWriteAttribute("class", " class=\"", 2551, "\"", 2559, 0);
                EndWriteAttribute();
                WriteLiteral(">Корзина: </a> <span>0</span></li>\r\n                        <li class=\"menu_link\"><a href=\"reviews.html\"");
                BeginWriteAttribute("class", " class=\"", 2664, "\"", 2672, 0);
                EndWriteAttribute();
                WriteLiteral(@">Отзывы</a></li>
                    </ul>
                </div>
            </div>
        </header>
        <div class=""content"">
            <div class=""container"">
                <div class=""registration-reg"">Регистрация</div>
                <p class=""bonus-program"">Вы станете участником Бонусной программы и получите:</p>
                <div class=""plus-program"">
                    <p class=""plus-program__text"">►Баллы при каждом заказе в зале и на сайте</p>
                    <p class=""plus-program__text"">►Возможность оплачивать заказы баллами</p>
                    <p class=""plus-program__text"">►Индивидуальные привилегии и спецпредложения</p>
                </div>
                <div class=""form"" id=""form"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4b45db80c462e2317c307ea9eb8585af93d7df711622", async() => {
                    WriteLiteral(@"
                        <input class=""form_box"" type=""text"" name=""username_signup"" placeholder=""Введите имя"" required><br>
                        <input class=""form_box"" type=""text"" name=""phonenumber_signup"" placeholder=""Введите номер вашего телефона"" required><br>
                        <input class=""form_box"" type=""password"" name=""password_signup"" placeholder=""Введите пароль"" required><br>
                        <div class=""checkbox"">
                            <input type=""checkbox"" id=""checkbox_1"">
                            <label for=""checkbox_1"">Запомнить меня</label>
                        </div>
                        <div class=""button_reg"">
                            ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4b45db80c462e2317c307ea9eb8585af93d7df712625", async() => {
                        WriteLiteral("Зарегистрироваться");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("\r\n                        </div>\r\n                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                </div>\r\n                <div class=\"line\"></div>\r\n                <p class=\"have-acc\">Уже есть аккаунта?</p>\r\n                <div class=\"enter\">\r\n                    <a");
                BeginWriteAttribute("href", " href=\"", 4511, "\"", 4518, 0);
                EndWriteAttribute();
                WriteLiteral(@">Войти</a>
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
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodDeliveryProject.Pages.Registration> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoodDeliveryProject.Pages.Registration> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FoodDeliveryProject.Pages.Registration>)PageContext?.ViewData;
        public FoodDeliveryProject.Pages.Registration Model => ViewData.Model;
    }
}
#pragma warning restore 1591