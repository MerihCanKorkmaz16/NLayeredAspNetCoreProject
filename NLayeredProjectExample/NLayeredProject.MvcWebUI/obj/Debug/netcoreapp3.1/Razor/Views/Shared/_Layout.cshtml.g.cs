#pragma checksum "C:\Users\ass\Desktop\GitHub\NLayeredAspNetCoreProject\NLayeredProjectExample\NLayeredProject.MvcWebUI\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aadee67ce6dbb41e2592b310e91aa7ef31997b43"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "C:\Users\ass\Desktop\GitHub\NLayeredAspNetCoreProject\NLayeredProjectExample\NLayeredProject.MvcWebUI\Views\_ViewImports.cshtml"
using NLayeredProject.MvcWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ass\Desktop\GitHub\NLayeredAspNetCoreProject\NLayeredProjectExample\NLayeredProject.MvcWebUI\Views\_ViewImports.cshtml"
using NLayeredProject.MvcWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aadee67ce6dbb41e2592b310e91aa7ef31997b43", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d86fcbf76956fe07ba79fe26fef2abaf549695a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("app-search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fixed-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aadee67ce6dbb41e2592b310e91aa7ef31997b434753", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta name=""description"" content=""A fully featured admin theme which can be used to build CRM, CMS, etc."">
    <meta name=""author"" content=""Coderthemes"">

    <!-- App Favicon -->
    <link rel=""shortcut icon"" href=""/assets/images/favicon.ico"">

    <!-- App title -->
    <title>NLayered Project - Responsive Admin Dashboard Template</title>

    <!-- DataTables -->
    <link href=""/assets/plugins/datatables/jquery.dataTables.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/plugins/datatables/buttons.bootstrap.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/plugins/datatables/fixedHeader.bootstrap.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/plugins/datatables/responsive.bootstrap.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/plugins/datatables/scroller.bootstrap.min.css"" rel=""stylesheet"" type=""text/cs");
                WriteLiteral(@"s"" />

    <!-- Plugins css-->
    <link href=""/assets/plugins/custombox/dist/custombox.min.css"" rel=""stylesheet"">
    <link href=""/assets/plugins/bootstrap-tagsinput/dist/bootstrap-tagsinput.css"" rel=""stylesheet"" />
    <link href=""/assets/plugins/multiselect/css/multi-select.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/plugins/select2/dist/css/select2.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""/assets/plugins/select2/dist/css/select2-bootstrap.css"" rel=""stylesheet"" type=""text/css"">
    <link href=""/assets/plugins/bootstrap-touchspin/dist/jquery.bootstrap-touchspin.min.css"" rel=""stylesheet"" />
    <link href=""/assets/plugins/switchery/switchery.min.css"" rel=""stylesheet"" />
    <link href=""/assets/plugins/timepicker/bootstrap-timepicker.min.css"" rel=""stylesheet"">
    <link href=""/assets/plugins/mjolnic-bootstrap-colorpicker/dist/css/bootstrap-colorpicker.min.css"" rel=""stylesheet"">
    <link href=""/assets/plugins/bootstrap-datepicker/dist/css/bootstrap-datepicker.min");
                WriteLiteral(@".css"" rel=""stylesheet"">
    <link href=""/assets/plugins/bootstrap-daterangepicker/daterangepicker.css"" rel=""stylesheet"">

    <link href=""/assets/plugins/fileuploads/css/dropify.min.css"" rel=""stylesheet"" type=""text/css"" />

    <link href=""/assets/css/bootstrap.min.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/css/core.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/css/components.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/css/icons.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/css/pages.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/css/menu.css"" rel=""stylesheet"" type=""text/css"" />
    <link href=""/assets/css/responsive.css"" rel=""stylesheet"" type=""text/css"" />

    <!-- Sweet Alert css -->
    <link href=""/assets/plugins/bootstrap-sweetalert/sweet-alert.css"" rel=""stylesheet"" type=""text/css"" />




    <!-- HTML5 Shiv and Respond.js IE8 support of HTML5 elements and media queries -->
    <!-- WAR");
                WriteLiteral(@"NING: Respond.js doesn't work if you view the page via file:// -->
    <!--[if lt IE 9]>
    <script src=""https://oss.maxcdn.com/libs/html5shiv/3.7.0/html5shiv.js""></script>
    <script src=""https://oss.maxcdn.com/libs/respond.js/1.3.0/respond.min.js""></script>
    <![endif]-->

    <script src=""/assets/js/modernizr.min.js""></script>

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
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aadee67ce6dbb41e2592b310e91aa7ef31997b439407", async() => {
                WriteLiteral(@"

    <!-- Begin page -->
    <div id=""wrapper"">

        <!-- Top Bar Start -->
        <div class=""topbar"">

            <!-- LOGO -->
            <div class=""topbar-left"">
                <a href=""index.html"" class=""logo""><span>NLayared<span>Project</span></span><i class=""zmdi zmdi-layers""></i></a>
            </div>

            <!-- Button mobile view to collapse sidebar menu -->
            <div class=""navbar navbar-default"" role=""navigation"">
                <div class=""container"">
                    <!-- Page title -->
                    <ul class=""nav navbar-nav navbar-left"">
                        <li>
                            <button class=""button-menu-mobile open-left"">
                                <i class=""zmdi zmdi-menu""></i>
                            </button>
                        </li>
                        <li>
                            <h4 class=""page-title"">Test Project Admin Panel</h4>
                        </li>
                    </ul>

 ");
                WriteLiteral(@"                   <!-- Right(Notification and Searchbox -->
                    <ul class=""nav navbar-nav navbar-right"">
                        <li>
                            <!-- Notification -->
                            <div class=""notification-box"">
                                <ul class=""list-inline m-b-0"">
                                    <li>
                                        <a href=""javascript:void(0);"" class=""right-bar-toggle"">
                                            <i class=""zmdi zmdi-notifications-none""></i>
                                        </a>
                                        <div class=""noti-dot"">
                                            <span class=""dot""></span>
                                            <span class=""pulse""></span>
                                        </div>
                                    </li>
                                </ul>
                            </div>
                            <!-- End Notificat");
                WriteLiteral("ion bar -->\r\n                        </li>\r\n                        <li class=\"hidden-xs\">\r\n                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aadee67ce6dbb41e2592b310e91aa7ef31997b4311953", async() => {
                    WriteLiteral("\r\n                                <input type=\"text\" placeholder=\"Search...\"\r\n                                       class=\"form-control\">\r\n                                <a");
                    BeginWriteAttribute("href", " href=\"", 5867, "\"", 5874, 0);
                    EndWriteAttribute();
                    WriteLiteral("><i class=\"fa fa-search\"></i></a>\r\n                            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        </li>
                    </ul>

                </div><!-- end container -->
            </div><!-- end navbar -->
        </div>
        <!-- Top Bar End -->
        <!-- ========== Left Sidebar Start ========== -->
        <div class=""left side-menu"">
            <div class=""sidebar-inner slimscrollleft"">

                <!-- User -->
                <div class=""user-box"">
                    <div class=""user-img"">
                        <img src=""/assets/images/users/avatar-1.jpg"" alt=""user-img"" title=""Mat Helme"" class=""img-circle img-thumbnail img-responsive"">
                        <div class=""user-status offline""><i class=""zmdi zmdi-dot-circle""></i></div>
                    </div>
                    <h5><a href=""#"">Mat Helme</a> </h5>
                    <ul class=""list-inline"">
                        <li>
                            <a href=""#"">
                                <i class=""zmdi zmdi-settings""></i>
                            </a>
   ");
                WriteLiteral(@"                     </li>

                        <li>
                            <a href=""#"" class=""text-custom"">
                                <i class=""zmdi zmdi-power""></i>
                            </a>
                        </li>
                    </ul>
                </div>
                <!-- End User -->
                <!--- Sidemenu -->
                <div id=""sidebar-menu"">
                    <ul>
                        <li class=""text-muted menu-title"">Navigation</li>

                        <li>
                            <a href=""/Home/Index/"" class=""waves-effect""><i class=""zmdi zmdi-view-dashboard""></i> <span> Ana Sayfa </span> </a>
                        </li>

                        <li>
                            <a href=""/Category/GetCategories/"" class=""waves-effect""><i class=""zmdi zmdi-format-underlined""></i> <span> Category </span> </a>
                        </li>
                        <li>
                            <a href=""/Product/GetP");
                WriteLiteral("roducts/\" class=\"waves-effect\"><i class=\"zmdi zmdi-format-underlined\"></i> <span> Product </span> </a>\r\n                        </li>\r\n\r\n\r\n");
                WriteLiteral(@"                    </ul>
                    <div class=""clearfix""></div>
                </div>
                <!-- Sidebar -->
                <div class=""clearfix""></div>

            </div>

        </div>
        <!-- Left Sidebar End -->
        <!-- ============================================================== -->
        <!-- Start right Content here -->
        <!-- ============================================================== -->
        <div class=""content-page"">
            <!-- Start content -->
            <div class=""content"">
                <div class=""container"">

                    <div class=""row"">
                        ");
#nullable restore
#line 195 "C:\Users\ass\Desktop\GitHub\NLayeredAspNetCoreProject\NLayeredProjectExample\NLayeredProject.MvcWebUI\Views\Shared\_Layout.cshtml"
                   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>
                    <!-- End row -->

                </div> <!-- container -->

            </div> <!-- content -->

            <footer class=""footer"">
                2019 © Test Project.
            </footer>

        </div>
        <!-- End content-page -->
        <!-- ============================================================== -->
        <!-- End Right content here -->
        <!-- ============================================================== -->
        <!-- Right Sidebar -->
        <div class=""side-bar right-bar"">
            <a href=""javascript:void(0);"" class=""right-bar-toggle"">
                <i class=""zmdi zmdi-close-circle-o""></i>
            </a>
            <h4");
                BeginWriteAttribute("class", " class=\"", 10400, "\"", 10408, 0);
                EndWriteAttribute();
                WriteLiteral(@">Notifications</h4>
            <div class=""notification-list nicescroll"">
                <ul class=""list-group list-no-border user-list"">
                    <li class=""list-group-item"">
                        <a href=""#"" class=""user-list-item"">
                            <div class=""avatar"">
                                <img src=""/assets/images/users/avatar-2.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 10789, "\"", 10795, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                            <div class=""user-desc"">
                                <span class=""name"">Michael Zenaty</span>
                                <span class=""desc"">There are new settings available</span>
                                <span class=""time"">2 hours ago</span>
                            </div>
                        </a>
                    </li>
                    <li class=""list-group-item"">
                        <a href=""#"" class=""user-list-item"">
                            <div class=""icon bg-info"">
                                <i class=""zmdi zmdi-account""></i>
                            </div>
                            <div class=""user-desc"">
                                <span class=""name"">New Signup</span>
                                <span class=""desc"">There are new settings available</span>
                                <span class=""time"">5 hours ago</span>
                            </div>
          ");
                WriteLiteral(@"              </a>
                    </li>
                    <li class=""list-group-item"">
                        <a href=""#"" class=""user-list-item"">
                            <div class=""icon bg-pink"">
                                <i class=""zmdi zmdi-comment""></i>
                            </div>
                            <div class=""user-desc"">
                                <span class=""name"">New Message received</span>
                                <span class=""desc"">There are new settings available</span>
                                <span class=""time"">1 day ago</span>
                            </div>
                        </a>
                    </li>
                    <li class=""list-group-item active"">
                        <a href=""#"" class=""user-list-item"">
                            <div class=""avatar"">
                                <img src=""/assets/images/users/avatar-3.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 12768, "\"", 12774, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                            <div class=""user-desc"">
                                <span class=""name"">James Anderson</span>
                                <span class=""desc"">There are new settings available</span>
                                <span class=""time"">2 days ago</span>
                            </div>
                        </a>
                    </li>
                    <li class=""list-group-item active"">
                        <a href=""#"" class=""user-list-item"">
                            <div class=""icon bg-warning"">
                                <i class=""zmdi zmdi-settings""></i>
                            </div>
                            <div class=""user-desc"">
                                <span class=""name"">Settings</span>
                                <span class=""desc"">There are new settings available</span>
                                <span class=""time"">1 day ago</span>
                            </div>
    ");
                WriteLiteral(@"                    </a>
                    </li>

                </ul>
            </div>
        </div>
        <!-- /Right-bar -->

    </div>
    <!-- END wrapper -->
    <!-- jQuery  -->
    <script src=""/assets/js/jquery.min.js""></script>
    <script src=""/assets/js/bootstrap.min.js""></script>
    <script src=""/assets/js/detect.js""></script>
    <script src=""/assets/js/fastclick.js""></script>
    <script src=""/assets/js/jquery.slimscroll.js""></script>
    <script src=""/assets/js/jquery.blockUI.js""></script>
    <script src=""/assets/js/waves.js""></script>
    <script src=""/assets/js/wow.min.js""></script>
    <script src=""/assets/js/jquery.nicescroll.js""></script>
    <script src=""/assets/js/jquery.scrollTo.min.js""></script>

    <!-- Datatables-->
    <script src=""/assets/plugins/datatables/jquery.dataTables.min.js""></script>
    <script src=""/assets/plugins/datatables/dataTables.bootstrap.js""></script>
    <script src=""/assets/plugins/datatables/dataTables.buttons.min.js""></sc");
                WriteLiteral(@"ript>
    <script src=""/assets/plugins/datatables/buttons.bootstrap.min.js""></script>
    <script src=""/assets/plugins/datatables/jszip.min.js""></script>
    <script src=""/assets/plugins/datatables/pdfmake.min.js""></script>
    <script src=""/assets/plugins/datatables/vfs_fonts.js""></script>
    <script src=""/assets/plugins/datatables/buttons.html5.min.js""></script>
    <script src=""/assets/plugins/datatables/buttons.print.min.js""></script>
    <script src=""/assets/plugins/datatables/dataTables.fixedHeader.min.js""></script>
    <script src=""/assets/plugins/datatables/dataTables.keyTable.min.js""></script>
    <script src=""/assets/plugins/datatables/dataTables.responsive.min.js""></script>
    <script src=""/assets/plugins/datatables/responsive.bootstrap.min.js""></script>
    <script src=""/assets/plugins/datatables/dataTables.scroller.min.js""></script>

    <!-- Plugins Js -->
    <script src=""/assets/plugins/switchery/switchery.min.js""></script>
    <script src=""/assets/plugins/bootstrap-tagsinput/");
                WriteLiteral(@"dist/bootstrap-tagsinput.min.js""></script>
    <script type=""text/javascript"" src=""/assets/plugins/multiselect/js/jquery.multi-select.js""></script>
    <script type=""text/javascript"" src=""/assets/plugins/jquery-quicksearch/jquery.quicksearch.js""></script>
    <script src=""/assets/plugins/select2/dist/js/select2.min.js"" type=""text/javascript""></script>
    <script src=""/assets/plugins/bootstrap-touchspin/dist/jquery.bootstrap-touchspin.min.js"" type=""text/javascript""></script>
    <script src=""/assets/plugins/bootstrap-inputmask/bootstrap-inputmask.min.js"" type=""text/javascript""></script>
    <script src=""/assets/plugins/moment/moment.js""></script>
    <script src=""/assets/plugins/timepicker/bootstrap-timepicker.min.js""></script>
    <script src=""/assets/plugins/mjolnic-bootstrap-colorpicker/dist/js/bootstrap-colorpicker.min.js""></script>
    <script src=""/assets/plugins/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js""></script>
    <script src=""/assets/plugins/bootstrap-daterangepicker/dater");
                WriteLiteral(@"angepicker.js""></script>
    <script src=""/assets/plugins/bootstrap-maxlength/bootstrap-maxlength.min.js"" type=""text/javascript""></script>

    <!-- Sweet Alert js -->
    <script src=""/assets/plugins/bootstrap-sweetalert/sweet-alert.min.js""></script>
    <script src=""/assets/pages/jquery.sweet-alert.init.js""></script>


    <!-- Datatable init js -->
    <script src=""/assets/pages/datatables.init.js""></script>

    <script src=""/assets/plugins/select2/dist/js/select2.min.js"" type=""text/javascript""></script>

    <!-- Modal-Effect -->
    <script src=""/assets/plugins/custombox/dist/custombox.min.js""></script>
    <script src=""/assets/plugins/custombox/dist/legacy.min.js""></script>

    <!-- file uploads js -->
    <script src=""/assets/plugins/fileuploads/js/dropify.js""></script>

    <!-- Editable js -->
    <script src=""/assets/plugins/magnific-popup/dist/jquery.magnific-popup.min.js""></script>
    <script src=""/assets/plugins/jquery-datatables-editable/jquery.dataTables.js""></script>
");
                WriteLiteral(@"    <script src=""/assets/plugins/datatables/dataTables.bootstrap.js""></script>
    <script src=""/assets/plugins/tiny-editable/mindmup-editabletable.js""></script>
    <script src=""/assets/plugins/tiny-editable/numeric-input-example.js""></script>
    <!-- init -->
    <script src=""/assets/pages/datatables.editable.init.js""></script>

    <!-- Modal-Effect -->
    <script src=""/assets/plugins/custombox/dist/custombox.min.js""></script>
    <script src=""/assets/plugins/custombox/dist/legacy.min.js""></script>

    <!-- App js -->
    <script src=""/assets/js/jquery.core.js""></script>
    <script src=""/assets/js/jquery.app.js""></script>

    <script>
        var resizefunc = [];
    </script>

    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#datatable').dataTable();
            $('#datatable-keytable').DataTable({ keys: true });
            $('#datatable-responsive').DataTable();
            $('#datatable-scroller').DataTable({ ajax: ""/assets/plugins/d");
                WriteLiteral(@"atatables/json/scroller-demo.json"", deferRender: true, scrollY: 380, scrollCollapse: true, scroller: true });
            var table = $('#datatable-fixed-header').DataTable({ fixedHeader: true });
        });
        TableManageButtons.init();

    </script>
    <script>
        jQuery(document).ready(function () {

            //advance multiselect start
            $('#my_multi_select3').multiSelect({
                selectableHeader: ""<input type='text' class='form-control search-input' autocomplete='off' placeholder='search...'>"",
                selectionHeader: ""<input type='text' class='form-control search-input' autocomplete='off' placeholder='search...'>"",
                afterInit: function (ms) {
                    var that = this,
                        $selectableSearch = that.$selectableUl.prev(),
                        $selectionSearch = that.$selectionUl.prev(),
                        selectableSearchString = '#' + that.$container.attr('id') + ' .ms-elem-selectable:not(.ms");
                WriteLiteral(@"-selected)',
                        selectionSearchString = '#' + that.$container.attr('id') + ' .ms-elem-selection.ms-selected';

                    that.qs1 = $selectableSearch.quicksearch(selectableSearchString)
                        .on('keydown', function (e) {
                            if (e.which === 40) {
                                that.$selectableUl.focus();
                                return false;
                            }
                        });

                    that.qs2 = $selectionSearch.quicksearch(selectionSearchString)
                        .on('keydown', function (e) {
                            if (e.which == 40) {
                                that.$selectionUl.focus();
                                return false;
                            }
                        });
                },
                afterSelect: function () {
                    this.qs1.cache();
                    this.qs2.cache();
                },
         ");
                WriteLiteral(@"       afterDeselect: function () {
                    this.qs1.cache();
                    this.qs2.cache();
                }
            });

            // Select2
            $("".select2"").select2();

            $("".select2-limiting"").select2({
                maximumSelectionLength: 2
            });

        });

        //Bootstrap-TouchSpin
        $("".vertical-spin"").TouchSpin({
            verticalbuttons: true,
            buttondown_class: ""btn btn-primary"",
            buttonup_class: ""btn btn-primary"",
            verticalupclass: 'ti-plus',
            verticaldownclass: 'ti-minus'
        });
        var vspinTrue = $("".vertical-spin"").TouchSpin({
            verticalbuttons: true
        });
        if (vspinTrue) {
            $('.vertical-spin').prev('.bootstrap-touchspin-prefix').remove();
        }

        $(""input[name='demo1']"").TouchSpin({
            min: 0,
            max: 100,
            step: 0.1,
            decimals: 2,
            boosta");
                WriteLiteral(@"t: 5,
            maxboostedstep: 10,
            buttondown_class: ""btn btn-primary"",
            buttonup_class: ""btn btn-primary"",
            postfix: '%'
        });
        $(""input[name='demo2']"").TouchSpin({
            min: -1000000000,
            max: 1000000000,
            stepinterval: 50,
            buttondown_class: ""btn btn-primary"",
            buttonup_class: ""btn btn-primary"",
            maxboostedstep: 10000000,
            prefix: '$'
        });
        $(""input[name='demo3']"").TouchSpin({
            buttondown_class: ""btn btn-primary"",
            buttonup_class: ""btn btn-primary""
        });
        $(""input[name='demo3_21']"").TouchSpin({
            initval: 40,
            buttondown_class: ""btn btn-primary"",
            buttonup_class: ""btn btn-primary""
        });
        $(""input[name='demo3_22']"").TouchSpin({
            initval: 40,
            buttondown_class: ""btn btn-primary"",
            buttonup_class: ""btn btn-primary""
        });

      ");
                WriteLiteral(@"  $(""input[name='demo5']"").TouchSpin({
            prefix: ""pre"",
            postfix: ""post"",
            buttondown_class: ""btn btn-primary"",
            buttonup_class: ""btn btn-primary""
        });
        $(""input[name='demo0']"").TouchSpin({
            buttondown_class: ""btn btn-primary"",
            buttonup_class: ""btn btn-primary""
        });

        // Time Picker
        jQuery('#timepicker').timepicker({
            defaultTIme: false
        });
        jQuery('#timepicker2').timepicker({
            showMeridian: false
        });
        jQuery('#timepicker3').timepicker({
            minuteStep: 15
        });

        //colorpicker start

        $('.colorpicker-default').colorpicker({
            format: 'hex'
        });
        $('.colorpicker-rgba').colorpicker();

        // Date Picker
        jQuery('#datepicker').datepicker();
        jQuery('#datepicker-autoclose').datepicker({
            autoclose: true,
            todayHighlight: true,
         ");
                WriteLiteral(@"   down: true
        });
        jQuery('#datepicker-inline').datepicker();
        jQuery('#datepicker-multiple-date').datepicker({
            format: ""dd/mm/yyyy"",
            clearBtn: true,
            multidate: true,
            multidateSeparator: "",""
        });
        jQuery('#date-range').datepicker({
            toggleActive: true
        });

        //Date range picker
        $('.input-daterange-datepicker').daterangepicker({
            buttonClasses: ['btn', 'btn-sm'],
            applyClass: 'btn-default',
            cancelClass: 'btn-primary'
        });
        $('.input-daterange-timepicker').daterangepicker({
            timePicker: true,
            format: 'DD/MM/YYYY h:mm A',
            timePickerIncrement: 30,
            timePicker12Hour: true,
            timePickerSeconds: false,
            buttonClasses: ['btn', 'btn-sm'],
            applyClass: 'btn-default',
            cancelClass: 'btn-primary'
        });
        $('.input-limit-datepicker'");
                WriteLiteral(@").daterangepicker({
            format: 'DD/MM/YYYY',
            minDate: '01/06/2019',
            maxDate: '30/06/2019',
            buttonClasses: ['btn', 'btn-sm'],
            applyClass: 'btn-default',
            cancelClass: 'btn-primary',
            dateLimit: {
                days: 6
            }
        });

        $('#reportrange span').html(moment().subtract(29, 'days').format('DDDD M, YYYY') + ' - ' + moment().format('DDDD M, YYYY'));

        $('#reportrange').daterangepicker({
            format: 'DD/MM/YYYY',
            startDate: moment().subtract(29, 'days'),
            endDate: moment(),
            minDate: '01/01/2019',
            maxDate: '31/12/2019',
            dateLimit: {
                days: 60
            },
            showDropdowns: true,
            showWeekNumbers: true,
            timePicker: false,
            timePickerIncrement: 1,
            timePicker12Hour: true,
            ranges: {
                'Today': [moment(), moment()]");
                WriteLiteral(@",
                'Yesterday': [moment().subtract(1, 'days'), moment().subtract(1, 'days')],
                'Last 7 Days': [moment().subtract(6, 'days'), moment()],
                'Last 30 Days': [moment().subtract(29, 'days'), moment()],
                'This Month': [moment().startOf('month'), moment().endOf('month')],
                'Last Month': [moment().subtract(1, 'month').startOf('month'), moment().subtract(1, 'month').endOf('month')]
            },
            opens: 'left',
            drops: 'down',
            buttonClasses: ['btn', 'btn-sm'],
            applyClass: 'btn-success',
            cancelClass: 'btn-default',
            separator: ' to ',
            locale: {
                applyLabel: 'Submit',
                cancelLabel: 'Cancel',
                fromLabel: 'From',
                toLabel: 'To',
                customRangeLabel: 'Custom',
                daysOfWeek: ['Su', 'Mo', 'Tu', 'We', 'Th', 'Fr', 'Sa'],
                monthNames: ['January', 'Februar");
                WriteLiteral(@"y', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'],
                firstDay: 1
            }
        }, function (start, end, label) {
            console.log(start.toISOString(), end.toISOString(), label);
            $('#reportrange span').html(start.format('DDDD M, YYYY') + ' - ' + end.format('DDDD M, YYYY'));
        });

        //Bootstrap-MaxLength
        $('input#defaultconfig').maxlength()

        $('input#thresholdconfig').maxlength({
            threshold: 20
        });

        $('input#moreoptions').maxlength({
            alwaysShow: true,
            warningClass: ""label label-success"",
            limitReachedClass: ""label label-danger""
        });

        $('input#alloptions').maxlength({
            alwaysShow: true,
            warningClass: ""label label-success"",
            limitReachedClass: ""label label-danger"",
            separator: ' out of ',
            preText: 'You typed ',
            postText: '");
                WriteLiteral(@" chars available.',
            validate: true
        });

        $('textarea#textarea').maxlength({
            alwaysShow: true
        });

        $('input#placement').maxlength({
            alwaysShow: true,
            placement: 'top-left'
        });
    </script>
    <script type=""text/javascript"">
        $('.dropify').dropify({
            messages: {
                'default': 'Drag and drop a file here or click',
                'replace': 'Drag and drop or click to replace',
                'remove': 'Remove',
                'error': 'Ooops, something wrong appended.'
            },
            error: {
                'fileSize': 'The file size is too big (1M max).'
            }
        });
    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
