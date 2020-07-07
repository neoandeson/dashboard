#pragma checksum "D:\study\template\Dashboard_MVC\dashboard\Dashboard\Dashboard\Views\Invest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c2b7a7ef86883531242ce42a0e694369adfa04c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Invest_Index), @"mvc.1.0.view", @"/Views/Invest/Index.cshtml")]
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
#line 1 "D:\study\template\Dashboard_MVC\dashboard\Dashboard\Dashboard\Views\_ViewImports.cshtml"
using Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\study\template\Dashboard_MVC\dashboard\Dashboard\Dashboard\Views\_ViewImports.cshtml"
using Dashboard.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c2b7a7ef86883531242ce42a0e694369adfa04c", @"/Views/Invest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ccb225a8b7775b6d65d4bc41cad2c9bd60636940", @"/Views/_ViewImports.cshtml")]
    public class Views_Invest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\study\template\Dashboard_MVC\dashboard\Dashboard\Dashboard\Views\Invest\Index.cshtml"
  
  ViewData["Title"] = "Finso-Invest | Banh Mi Ma Hai";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<!-- main-body start -->
<div class=""breadcrumb"">
  <h1>Bánh mì Má Hai | BMMH-22</h1>
  <ul>
    <li><span class=""badge badge-dark w-badge"">Trạng thái</span><span class=""badge badge-success w-badge"">Đang mở</span></li>
    <li><span class=""badge badge-dark w-badge"">Danh mục</span><span class=""badge badge-info w-badge"">Thức ăn sáng</span></li>
  </ul>
</div>
<div class=""separator-breadcrumb border-top""></div>
<div class=""row"">
  <div class=""col-md-7"">
    <div class=""card mb-4"">
      <div class=""card-body"">
        <h2>Thông tin cơ bản</h2>
        <div class=""pall-tb-15""></div>
        <div class=""row"">
          <div class=""col-sm-3 pb-2"">
            <i class=""nav-icon i-Money-Bag""></i>
            Mục tiêu đầu tư (vnd)
          </div>
          <div id=""target-value"" class=""col-sm-4 t-font-boldest pb-2"">
            200000000000
          </div>
          <div class=""col-sm-5 pb-2"" style=""text-align: end;"">
            <i class=""nav-icon i-Calendar""></i>
            <span>Thời hạ");
            WriteLiteral(@"n cuối:</span>
            <span class=""t-font-boldest"">12/2020</span>
          </div>
        </div>
        <div class=""row pb-2"">
          <div class=""col-form-label col-sm-3 pt-0"">
            <i class=""nav-icon i-Money-2""></i>
            Số vốn được đầu tư
          </div>
          <div id=""progressBar"" class=""col-sm-9"">
            <div class=""progress mb-3"">
              <div class=""progress-bar progress-bar-striped progress-bar-animated bg-primary"" role=""progressbar"" style=""width: 10%"" aria-valuenow=""10"" aria-valuemin=""0"" aria-valuemax=""100"">10%</div>
            </div>
          </div>
        </div>
        <div class=""row"">
          <div class=""col-form-label col-sm-3 pt-0 pb-2"">
            <i class=""nav-icon i-Bar-Code""></i>
            Mã dự án
          </div>
          <div class=""col-sm-3 pb-2"">
            <span class=""t-font-boldest"">BMMH-22</span>
          </div>
          <div class=""col-form-label col-sm-3 pt-0 pb-2"">
            <i class=""nav-icon i-Calend");
            WriteLiteral(@"ar-4""></i>
            Kỳ thanh toán
          </div>
          <div class=""col-sm-3 pb-2"">
            <span class=""t-font-boldest"">6 tháng</span>
          </div>
        </div>
        <div class=""row"">
          <div class=""col-form-label col-sm-3 pt-0 pb-2"">
            <i class=""nav-icon i-Tag""></i>
            Danh mục dự án
          </div>
          <div class=""col-sm-3 pb-2"">
            <span class=""t-font-boldest"">Thức ăn sáng</span>
          </div>
          <div class=""col-form-label col-sm-3 pt-0 pb-2"">
            <i class=""nav-icon i-Line-Chart-2""></i>Lợi nhuận kỳ vọng
          </div>
          <div class=""col-sm-3 pb-2"">
            <span class=""text-success t-font-boldest"">+18%</span>
          </div>
        </div>
        <div class=""pall-tb-15""></div>
        <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
          <li class=""nav-item""><a class=""nav-link tab-sm-pad active"" id=""home-basic-tab"" data-toggle=""tab"" href=""#homeBasic"" role=""tab"" aria-controls=""hom");
            WriteLiteral(@"eBasic"" aria-selected=""true"">Giới thiệu</a></li>
          <li class=""nav-item""><a class=""nav-link tab-sm-pad"" id=""profile-basic-tab"" data-toggle=""tab"" href=""#profileBasic"" role=""tab"" aria-controls=""profileBasic"" aria-selected=""false"">Kế hoạch</a></li>
          <li class=""nav-item""><a class=""nav-link tab-sm-pad"" id=""contact-basic-tab"" data-toggle=""tab"" href=""#contactBasic"" role=""tab"" aria-controls=""contactBasic"" aria-selected=""false"">Chủ dự án</a></li>
        </ul>
        <div class=""tab-content"" id=""myTabContent"">
          <div class=""tab-pane fade show active"" id=""homeBasic"" role=""tabpanel"" aria-labelledby=""home-basic-tab"">
            <p>
              ĐẶT HÀNG SỐ LƯỢNG LỚN CHO CÔNG TY, SỰ KIỆN

              Quý khách hàng có tổ chức picnic, dã ngoại, hội trại, hội theo, tổ chức tập huấn, team building… với số lượng thành viên lớn. Để đảm bảo bữa ăn sáng đầy đủ dinh dưỡng, nhanh, tiện lợi, an toàn.

              Hãy liên hệ với Bánh Mì Má Hải để được tư vấn, đặt hàng và giao hàng với số lư");
            WriteLiteral(@"ợng lớn.

              Chúng tôi luôn phục vụ với phương châm: “Khách Hàng là người thân, tận tâm trên từng sản phẩm” .
            </p>
            <div class=""carousel_wrap"">
              <div class=""carousel slide"" id=""carouselExamplePause"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
                  <li");
            BeginWriteAttribute("class", " class=\"", 4504, "\"", 4512, 0);
            EndWriteAttribute();
            WriteLiteral(" data-target=\"#carouselExamplePause\" data-slide-to=\"0\"></li>\r\n                  <li data-target=\"#carouselExamplePause\" data-slide-to=\"1\"");
            BeginWriteAttribute("class", " class=\"", 4650, "\"", 4658, 0);
            EndWriteAttribute();
            WriteLiteral(@"></li>
                  <li data-target=""#carouselExamplePause"" data-slide-to=""2"" class=""active""></li>
                </ol>
                <div class=""carousel-inner"">
                  <div class=""carousel-item"">
                    <img class=""d-block w-100"" src=""../../dist-assets/images/products/headphone-1.jpg"" alt=""First slide"">
                    <div class=""carousel-caption d-none d-md-block"">
                      <h5 class=""text-white"">Add captions to your slides easily </h5>
                      <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. </p>
                    </div>
                  </div>
                  <div class=""carousel-item"">
                    <img class=""d-block w-100"" src=""../../dist-assets/images/products/iphone-1.jpg"" alt=""Second slide"">
                    <div class=""carousel-caption d-none d-md-block"">
                      <h5 class=""text-white"">Add captions to your slides easily </h5>
                      <p>Lorem ipsum dolor sit amet con");
            WriteLiteral(@"sectetur adipisicing elit. </p>
                    </div>
                  </div>
                  <div class=""carousel-item active"">
                    <img class=""d-block w-100"" src=""../../dist-assets/images/products/headphone-1.jpg"" alt=""Third slide"">
                    <div class=""carousel-caption d-none d-md-block"">
                      <h5 class=""text-white"">Add captions to your slides easily </h5>
                      <p>Lorem ipsum dolor sit amet consectetur adipisicing elit. </p>
                    </div>
                  </div>
                </div><a class=""carousel-control-prev"" href=""#carouselExamplePause"" role=""button"" data-slide=""prev""><span class=""carousel-control-prev-icon"" aria-hidden=""true""></span><span class=""sr-only"">Previous</span></a><a class=""carousel-control-next"" href=""#carouselExamplePause"" role=""button"" data-slide=""next""><span class=""carousel-control-next-icon"" aria-hidden=""true""></span><span class=""sr-only"">Next</span></a>
              </div>
            </d");
            WriteLiteral(@"iv>
          </div>
          <div class=""tab-pane fade"" id=""profileBasic"" role=""tabpanel"" aria-labelledby=""profile-basic-tab"">
            tofu before they sold out mcsweeney's organic lomo retro fanny pack lo-fi farm-to-table readymade. Messenger bag gentrify pitchfork tattooed craft beer, iphone skateboard locavore.
          </div>
          <div class=""tab-pane fade"" id=""contactBasic"" role=""tabpanel"" aria-labelledby=""contact-basic-tab"">
            Khởi nghiệp với xe đẩy bánh mì chả cá vỉa hè từ năm 2013 khi còn là sinh viên trường Đại học Kinh tế TP.HCM với 2 triệu đồng, Hồ Đức Hải cũng nếm trải nhiều vấp váp, sai lầm, cả những ngày buôn bán ế ẩm để duy trì việc kinh doanh.

            Đến cuối năm 2014, Bánh mì má Hải được sự đón nhận tích cực của thị trường. Hoạt động trong khung giờ từ 6 giờ đến 9 giờ 30 phút sáng, các điểm bán có khách đều đặn với số lượng bán ra trung bình 100 ổ/ngày. Bánh mì Má Hải cũng nhận được nhiều lời đề nghị từ đối tác để phát triển nhượng quyền.

            Từ ");
            WriteLiteral(@"đó, Bánh mì má Hải mạnh dạn đầu tư máy móc, phát triển dây chuyền chuyên sản xuất chả cá để phục vụ hệ thống của mình và các đối tác. Năm 2017 đánh dấu một bước ngoặc quan trọng trong quá trình phát triển của Bánh mì Má Hải với hệ thống 3 cửa hàng chả cá, 8 cửa hàng bánh mì và hơn 50 xe bánh mì bao phủ toàn TP.HCM với hàng trăm nhân viên.
          </div>
        </div>
      </div>
    </div>
  </div>
  <div class=""col-md-5"">
    <div class=""card"">
      <div class=""card-body"">
        <h2>Thông tin đầu tư</h2>
        <div class=""pall-tb-15""></div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c2b7a7ef86883531242ce42a0e694369adfa04c12487", async() => {
                WriteLiteral(@"
          <div class=""form-group row"">
            <div class=""col-form-label col-sm-3 pt-0"">Số dư (vnd)</div>
            <div class=""col-sm-9"">
              <span>1,000,000</span>
            </div>
          </div>
          <div class=""form-group row"">
            <div class=""col-form-label col-sm-3 pt-0"">Mã dự án</div>
            <div class=""col-sm-3"">
              <span class=""t-font-boldest"">BMMH-22</span>
            </div>
            <div class=""col-form-label col-sm-4 pt-0"">Kỳ thanh toán</div>
            <div class=""col-sm-2"">
              <span class=""t-font-boldest"">6 tháng</span>
            </div>
          </div>
          <div class=""form-group row"">
            <div class=""col-form-label col-sm-3 pt-0"">Danh mục dự án</div>
            <div class=""col-sm-3"">
              <span class=""t-font-boldest"">Thức ăn sáng</span>
            </div>
            <div class=""col-form-label col-sm-4 pt-0"">Lợi nhuận kỳ vọng</div>
            <div class=""col-sm-2"">
             ");
                WriteLiteral(@" <span class=""text-success t-font-boldest"">+18%</span>
            </div>
          </div>
          <div class=""form-group row"">
            <div class=""col-form-label col-sm-3 pt-0"">Số tiền đầu tư</div>
            <div class=""col-sm-4"">
              <input class=""form-control"">
            </div>
          </div>
          <div class=""form-group row"">
            <div class=""col-form-label col-sm-3 pt-0"" style=""font-size: 90%"">Phí giao dịch (vnd)</div>
            <div class=""col-sm-9"">
              <span>1,000</span>
            </div>
          </div>
          <div class=""form-group row"">
            <div class=""col-form-label col-sm-3 pt-0"">Thuế (vnd)</div>
            <div class=""col-sm-9"">
              <span>0</span>
            </div>
          </div>
          <div class=""form-group row"">
            <div class=""col-sm-3"">Hợp đồng</div>
            <div class=""col-sm-9"">
              <div class=""form-check"">
                <input class=""form-check-input"" id=""gridCheck1");
                WriteLiteral("\" type=\"checkbox\">\r\n                <span>\r\n                  Tôi đồng ý với <a");
                BeginWriteAttribute("href", " href=\"", 10440, "\"", 10447, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""badge badge-pill badge-danger p-2"">Hợp đồng hợp tác đầu tư</a>
                </span>
              </div>
            </div>
          </div>
          <div class=""form-group row"">
            <div class=""col-form-label col-sm-3 pt-0"">Mã OTP</div>
            <div class=""col-sm-3"">
              <input class=""form-control"">
            </div>
          </div>
          <div class=""separator-breadcrumb border-top""></div>
          <div class=""form-group row"">
            <div class=""col-form-label col-sm-3 pt-0"">Giá trị lệnh đặt(vnd)</div>
            <div class=""col-sm-9"">
              <span>1,001,000</span>
            </div>
          </div>
          <div class=""form-group row"">
            <div class=""col-sm-12"">
              <button class=""btn btn-primary btn-block m-1 mb-3"" type=""submit"">Đầu tư</button>
            </div>
          </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("      </div>\r\n    </div>\r\n  </div>\r\n</div>\r\n<!-- main-body end -->\r\n");
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
