<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="SamyWeb.Index" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <style type="text/css">
        #divOnly {
            visibility: hidden;
        }
    </style>

    <!--  wrapper -->
    <div id="wrapper">
        <nav class="navbar-default navbar-static-side" role="navigation">
            <!-- sidebar-collapse -->
            <div class="sidebar-collapse">
                <!-- side-menu -->
                <ul class="nav" id="side-menu">
                    <li>
                        <!-- user image section-->
                        <div class="user-section">
                            <%--<div class="user-section-inner">
                                <img  src="assets/img/user.jpg" alt="">
                            </div>--%>
                            <div class="user-info">
                                <div><strong></strong></div>
                                <div class="user-text-online">
                                    <span class="user-circle-online btn btn-success btn-circle "></span>&nbsp;<a href="Login.aspx" onclick="contactMe();">Samy Online</a>
                                </div>
                            </div>
                        </div>
                        <!--end user image section-->
                    </li>
                    <%-- <li class="sidebar-search">
                        <!-- search section-->
                        <div class="input-group custom-search-form">
                            <input type="text" class="form-control" placeholder="Search...">
                            <span class="input-group-btn">
                                <button class="btn btn-default" type="button">
                                    <i class="fa fa-search"></i>
                                </button>
                            </span>
                        </div>
                        <!--end search section-->
                    </li>--%>

                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn1" CssClass=" btn btn-success" Text="مختلط" OnClick="btn1_Click" />

                        </a>
                    </li>

                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn2" CssClass=" btn btn-success" Text="مؤجل الدفع" OnClick="btn2_Click" /></a>
                    </li>

                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn3" CssClass=" btn btn-success" Text="مؤقت" OnClick="btn3_Click" /></a>
                    </li>



                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn4" CssClass=" btn btn-success" Text="مدي الحياة" OnClick="btn4_Click" /></a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn5" CssClass=" btn btn-success" Text="مختلط علي شخصين" OnClick="btn5_Click" /></a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn6" CssClass=" btn btn-success" Text="المهندس" OnClick="btn6_Click" /></a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn7" CssClass=" btn btn-success" Text="المهندس المتزايدة" OnClick="btn7_Click" /></a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn8" CssClass=" btn btn-success" Text="مؤقت متناقص" OnClick="btn8_Click" /></a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn9" CssClass=" btn btn-success" Text="التعاونية" OnClick="btn9_Click" /></a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn10" CssClass=" btn btn-success" Text="حماية الأبناء" OnClick="btn10_Click" /></a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn11" CssClass=" btn btn-success" Text="الفضية" OnClick="btn11_Click" /></a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn12" CssClass=" btn btn-success" Text="الثنائية" OnClick="btn12_Click" /></a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn13" CssClass=" btn btn-success" Text="الثلاثية" OnClick="btn13_Click" /></a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn14" CssClass=" btn btn-success" Text="الرباعية" OnClick="btn14_Click" /></a>
                    </li>


                    <li>
                        <a href="#"><i class="fa fa-flask fa-fw"></i>
                            <asp:Button runat="server" ID="btn15" CssClass=" btn btn-success" Text="مؤقت مع رد الأقساط" OnClick="btn15_Click" /></a>
                    </li>


                    <!-- second-level-items -->
                </ul>
                <!-- end side-menu -->
            </div>
            <!-- end sidebar-collapse -->
        </nav>




        <!--  page-wrapper -->
        <div id="page-wrapper">

            <%--<div class="row">
                <!-- page header -->
                <div class="col-lg-12">
                    <h1 class="page-header">Forms</h1>
                </div>
                <!--end page header -->
            </div>--%>
            <div class="row">
                <div class="col-lg-12">
                    <!-- Form Elements -->
                    <div class="panel panel-default">
                        <%--<div class="panel-heading">
                            Basic Form Elements
                        </div>--%>
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-lg-6">

                                    <div class="form-group">
                                        <label>متوسط السن</label>
                                        <asp:TextBox runat="server" TextMode="Number" ID="txtSen" min="18" max="64" step="1" value="18" class="form-control"></asp:TextBox>

                                    </div>
                                    <div class="form-group">
                                        <label>مدة التأمين</label>
                                        <asp:TextBox runat="server" required="required" TextMode="Number" ID="txtModa" min="1" max="79" step="1" value="1" class="form-control"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label>مبلغ التأمين</label>
                                        <asp:TextBox runat="server" required="required" TextMode="Number" ID="txtMab" min="1000" max="99000000" step="1000" value="1000" class="form-control"></asp:TextBox>

                                    </div>

                                    <div class="col-md-4">
                                        <asp:Button ID="btnResult" runat="server" Text="Result" CssClass="btn btn-success" OnClick="btnResult_Click"></asp:Button>

                                    </div>
                                    <div class="col-md-5">
                                        <asp:Label runat="server" ID="lblDamga" Text=""></asp:Label>
                                    </div>

                                    <br />
                                    <div class="form-group">
                                        <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
                                    </div>
                                </div>
                                <div class="col-lg-6">
                                    <fieldset disabled="disabled">
                                        <div class="form-group">
                                            <asp:Label runat="server" ID="lbl1" Font-Bold="True" Font-Size="13pt">قسط سنوي</asp:Label>
                                            <asp:TextBox runat="server" CssClass="form-control" ID="txtKstYear" TextMode="Number" disabled="true"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label runat="server" ID="lbl2" Font-Bold="True" Font-Size="13pt">قسط نصف سنوي</asp:Label>
                                            <asp:TextBox runat="server" CssClass="form-control" ID="txtKstHalf" TextMode="Number" disabled="true"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label runat="server" ID="lbl3" Font-Bold="True" Font-Size="13pt">قسط ربع سنوي</asp:Label>
                                            <asp:TextBox runat="server" CssClass="form-control" ID="txtKstQuarter" TextMode="Number" disabled="true"></asp:TextBox>
                                        </div>
                                        <div class="form-group">
                                            <asp:Label runat="server" ID="lbl4" Font-Bold="True" Font-Size="13pt">قسط شهري</asp:Label>
                                            <asp:TextBox runat="server" CssClass="form-control" ID="txtKstMonth" TextMode="Number" disabled="true"></asp:TextBox>
                                        </div>

                                        <div id="divOnly" class="form-group">
                                            <asp:Label runat="server" ID="lbl5" Font-Bold="True" Font-Size="13pt">قسط وحيد</asp:Label>
                                            <asp:TextBox runat="server" CssClass="form-control" ID="txtKstOnly" TextMode="Number" disabled="true"></asp:TextBox>
                                        </div>

                                        <%--<button type="submit" class="btn btn-primary">Disabled Button</button>--%>
                                    </fieldset>

                                    <%--     <h1>Form Validation States</h1>

                                    <div class="form-group has-success">
                                        <label class="control-label" for="inputSuccess">Input with success</label>
                                        <input type="text" class="form-control" id="inputSuccess">
                                    </div>
                                    <div class="form-group has-warning">
                                        <label class="control-label" for="inputWarning">Input with warning</label>
                                        <input type="text" class="form-control" id="inputWarning">
                                    </div>
                                    <div class="form-group has-error">
                                        <label class="control-label" for="inputError">Input with error</label>
                                        <input type="text" class="form-control" id="inputError">
                                    </div>
                                    
                                    <h1>Input Groups</h1>
                                    <form role="form">
                                        <div class="form-group input-group">
                                            <span class="input-group-addon">@</span>
                                            <input type="text" class="form-control" placeholder="Username">
                                        </div>
                                        <div class="form-group input-group">
                                            <input type="text" class="form-control">
                                            <span class="input-group-addon">.00</span>
                                        </div>
                                        <div class="form-group input-group">
                                            <span class="input-group-addon"><i class="fa fa-eur"></i>
                                            </span>
                                            <input type="text" class="form-control" placeholder="Font Awesome Icon">
                                        </div>
                                        <div class="form-group input-group">
                                            <span class="input-group-addon">$</span>
                                            <input type="text" class="form-control">
                                            <span class="input-group-addon">.00</span>
                                        </div>
                                        <div class="form-group input-group">
                                            <input type="text" class="form-control">
                                            <span class="input-group-btn">
                                                <button class="btn btn-default" type="button">
                                                    <i class="fa fa-search"></i>
                                                </button>
                                            </span>
                                        </div>
                                    </form>--%>
                                </div>
                            </div>
                        </div>
                    </div>
                    <!-- End Form Elements -->
                </div>
            </div>
        </div>
        <!-- end page-wrapper -->

    </div>
    <!-- end wrapper -->

    <!-- Core Scripts - Include with every page -->
    <script type="text/javascript">
        function contactMe() {
            alert('يمكنك التواصل معي علي الرقم 01115910095');
            alert('أو علي الايميل samyabdelstar69@gmail');
        }
    </script>
</asp:Content>
