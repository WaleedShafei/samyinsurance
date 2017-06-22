<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SamyWeb.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <!-- Form Elements -->


    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
        <asp:View ID="View1" runat="server">
            <div class="row">
                <br />
                <br />
                <div class="col-lg-12">
                    <div class="panel panel-default">
                        <div class="panel-body">
                            <h3>Auth</h3>

                            <div class="row">
                                <div class="col-xs-6 col-sm-4">
                                </div>
                                <div class="col-xs-6 col-sm-4">
                                    <div class="form-group">
                                        <label class="pull-right">اسم المستخدم</label>
                                        <asp:TextBox runat="server" required="required" ID="txtUser" class="form-control"></asp:TextBox>
                                    </div>
                                    <div class="form-group">
                                        <label class="pull-right">الباسورد</label>
                                        <asp:TextBox runat="server" required="required" TextMode="Password" ID="txtPass" class="form-control"></asp:TextBox>
                                    </div>

                                    <div class="form-group">
                                        <asp:Button ID="btnLogin" runat="server" Text="Login" CssClass="btn btn-success" OnClick="btnLogin_Click"></asp:Button>
                                    </div>
                                </div>
                                <!-- Optional: clear the XS cols if their content doesn't match in height -->
                                <div class="clearfix visible-xs"></div>
                                <div class="col-xs-6 col-sm-4"></div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>







        </asp:View>
        <asp:View ID="View2" runat="server">
            <div class="row">
                <br />
                <br />
                <div class="col-lg-12">
                    <div class="panel panel-default">
                        <div class="panel-body">
                            <div class="row">
                                <div class="col-xs-6 col-sm-4">
                                    <asp:Label ID="lblWelcome" runat="server"></asp:Label>
                                    <asp:Button runat="server" ID="btnLogOut" CssClass="btn btn-success" Text="Log Out" OnClick="btnLogOut_Click" />

                                </div>
                                <div class="col-xs-6 col-sm-4">

                                    <div class="form-group">
                                        <asp:Label ID="lbl1" CssClass="pull-right" runat="server" Text="الايميل"></asp:Label>
                                        <asp:TextBox ID="txt1" CssClass="form-control" runat="server"></asp:TextBox>

                                    </div>

                                    <div class="form-group">
                                        <asp:Label ID="Label1" CssClass="pull-right" runat="server" Text="الموضوع"></asp:Label>

                                        <asp:TextBox ID="txtBody" CssClass="form-control" runat="server"></asp:TextBox>

                                    </div>

                                    <div class="form-group">
                                        <asp:Label ID="lblImageFile" CssClass="pull-right" runat="server" Text="صورة البطاقة"></asp:Label>

                                        <asp:FileUpload ID="upImage" CssClass="form-control" runat="server" />
                                        <asp:DropDownList ID="ddlFiles" Visible="false" runat="server"></asp:DropDownList>

                                    </div>

                                    <div class="form-group">
                                        <asp:Button ID="btnadd" runat="server" CssClass="btn btn-success" Text="ارســال" OnClick="btnadd_Click" />

                                    </div>
                                </div>
                                <!-- Optional: clear the XS cols if their content doesn't match in height -->
                                <div class="clearfix visible-xs"></div>
                                <div class="col-xs-6 col-sm-4">
                                    <div class="form-group">
                                        <asp:Label ID="Label2" CssClass="pull-right" runat="server" Text="الملفات المستلمة"></asp:Label>
                                        <br />
                                        <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None">
                                            <AlternatingRowStyle BackColor="White" />
                                            <EditRowStyle BackColor="#7C6F57" />
                                            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                                            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                                            <RowStyle BackColor="#E3EAEB" />
                                            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                                            <SortedAscendingCellStyle BackColor="#F8FAFA" />
                                            <SortedAscendingHeaderStyle BackColor="#246B61" />
                                            <SortedDescendingCellStyle BackColor="#D4DFE1" />
                                            <SortedDescendingHeaderStyle BackColor="#15524A" />
                                        </asp:GridView>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

            </div>
        </asp:View>
    </asp:MultiView>

</asp:Content>
