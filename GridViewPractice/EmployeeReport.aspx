﻿<%@ Page Language="C#" MasterPageFile="~/MasterPageWithMenus.master" AutoEventWireup="true" CodeFile="EmployeeReport.aspx.cs" Inherits="EmployeeReport" %>
    <%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="cc1" %>  
 <%@ Register TagPrefix="Ajax1" Namespace="AjaxControlToolkit" Assembly="AjaxControlToolkit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
        <script src="../../Scripts/jquery-1.3.2.min.js" language="javascript" type="text/javascript"/>
<script src="../../Scripts/jquery-ui-1.7.1.custom.min.js" type="text/javascript"/>
    <script src="Scripts/jquery-1.3.2.min.js"></script>
   
        <style>
        *{
            font-family:Consolas;
            font-size:12px;
        }

        .gridview th {
    padding: 2px 10px 2px 10px;
}

        .gridview td {
    padding: 2px 10px 2px 10px;
}
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
            <div>
            <table width="100%" border="1" style="border-collapse:collapse">
                <tr>
                    <td>Department</td>
                    <td>
                    <asp:DropDownList ID="ddl_Department"
                                      width="200px"
                                      TabIndex="0"
                                      AutoPostBack="true"
                                      OnSelectedIndexChanged="ddl_Department_SelectedIndexChanged" 
                                      runat="server">
                        <%--<asp:ListItem Text="ALL" Value="0"></asp:ListItem>--%>
                    </asp:DropDownList></td>
                                        <td>Manager</td>
                    <td>
                       
                    <asp:DropDownList ID="ddl_Manager"
                                      width="200px"
                                      TabIndex="1"
                                      AutoPostBack="true"
                                      OnSelectedIndexChanged="ddl_Manager_SelectedIndexChanged" 
                                      runat="server">
                        <asp:ListItem Text="ALL" Value="0"></asp:ListItem>
                    </asp:DropDownList></td>
                    <td style="border:1px solid; border-collapse:collapse; padding:5px 10px 5px 10px">Select Gender:
                        <asp:RadioButton 
                             ID="rb_Male"
                             Text ="Male"
                             GroupName="gender"
                             runat="server" />
                        <asp:RadioButton 
                             ID="rb_Female"
                             GroupName="gender"
                             Text="Female"
                             runat="server" />
                        <asp:RadioButton 
                            ID="rb_Both"
                            Text="Both"
                            GroupName="gender" 
                            Checked="true"
                            runat="server" />
                    </td>
                <td style="
                    border:1px solid; 
                    border-collapse:collapse; 
                    padding:5px 10px 5px 10px">Select Status:
                        <asp:RadioButton 
                             ID="rb_Single"
                             Text ="Single"
                             GroupName="martialStatus"
                             runat="server" />
                        <asp:RadioButton 
                             ID="rb_Married"
                             GroupName="martialStatus"
                             Text="Married"
                             runat="server" />
                        <asp:RadioButton 
                            ID="rb_SignleMarried"
                            Text="Both"
                            Checked="true"
                            GroupName="martialStatus" 
                            runat="server" />
                    </td>
                </tr>
                <tr>
                    <td colspan="6" style="
                    border:1px solid; 
                    border-collapse:collapse; 
                    padding:5px 10px 5px 5px">
                        <asp:CheckBox
                            ID="cb_jd"
                            Checked="true"
                            Text="Job Description"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox
                            ID="cb_hd"
                            Text="Hire Date"
                            Checked="true"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox
                            ID="cb_nic"
                            Text="Nic Number"
                            Checked="true"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox
                            ID="cb_li"
                            Checked="true"
                            Text="Login ID"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
                        <asp:CheckBox
                            ID="cb_shift"
                            Checked="true"
                            Text="Shift"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
                        <%--If you open this check code crush bcoz , not properly insert in query--%> 
 <%--                       <asp:CheckBox
                            ID="cb_email"
                            Checked="true"
                            Text="Email Address"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;--%>
                            <asp:CheckBox
                            ID="cb_slh"
                            Checked="true"
                            Text="Sick Leave Hour"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
                            <asp:CheckBox
                            ID="cb_vh"
                            Checked="true"
                            Text="Vacation Hour"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
                            <asp:CheckBox
                            ID="cb_dob"
                            Checked="true"
                            Text="Date Of Birth"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
                            <asp:CheckBox
                            ID="cb_deptName"
                            Checked="true"
                            Text="Department Name"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
                            <asp:CheckBox
                            ID="cb_grandTotal"
                            Checked="true"
                            Text="Add Grand Total"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
                           </td>
                </tr>
                <tr>                   
                    <td colspan="4" style="border:1px solid; border-collapse:collapse; padding:5px 5px 5px 5px">Date of Birth 
               
                        <cc1:ToolkitScriptManager
                            ID="toolScriptManageer1"
                            runat="server">
                        </cc1:ToolkitScriptManager>
                        <asp:TextBox
                            ID="tb_DOB_To"
                            runat="server"></asp:TextBox>
                        <cc1:CalendarExtender
                            ID="Calendar1"
                            PopupButtonID="imgPopup"
                            runat="server"
                            TargetControlID="tb_DOB_To"
                            Format="dd/MM/yyyy">
                        </cc1:CalendarExtender>                 
                    &nbsp;&nbsp;&nbsp;
                    To
                    &nbsp;&nbsp;&nbsp;        
                        <asp:TextBox
                            ID="tb_DOB_From"
                            runat="server"></asp:TextBox>
                        <cc1:CalendarExtender
                            ID="CalendarExtender2"
                            PopupButtonID="imgPopup"
                            runat="server"
                            TargetControlID="tb_DOB_From"
                            Format="dd/MM/yyyy">
                        </cc1:CalendarExtender>
                    </td>
                                          <td colspan="4" style="border:1px solid; border-collapse:collapse; padding:5px 5px 5px 5px">Hire Date
               
             <%--           <cc1:ToolkitScriptManager
                            ID="ToolkitScriptManager1"
                            runat="server">
                        </cc1:ToolkitScriptManager>--%>
                        <asp:TextBox
                            ID="tb_HD_To"
                            runat="server"></asp:TextBox>
                        <cc1:CalendarExtender
                            ID="CalendarExtender3"
                            PopupButtonID="imgPopup"
                            runat="server"
                            TargetControlID="tb_HD_To"
                            Format="dd/MM/yyyy">
                        </cc1:CalendarExtender>
                  
                    &nbsp;&nbsp;&nbsp;
                    To
                    &nbsp;&nbsp;&nbsp;
        
                        <asp:TextBox
                            ID="tb_HD_From"
                            runat="server"></asp:TextBox>
                        <cc1:CalendarExtender
                            ID="CalendarExtender4"
                            PopupButtonID="imgPopup"
                            runat="server"
                            TargetControlID="tb_HD_From"
                            Format="dd/MM/yyyy">
                        </cc1:CalendarExtender>
                    <asp:Button
                        ID="btn_submit"
                        runat="server"
                        Text="Generate Report" 
                        OnClick="btn_submit_Click"/>    
                    </td>
                </tr>
                <tr>
                    <td>
                        Enter NIC
                    </td>
                    <td>
                        <asp:TextBox
                            ID="tb_nic"
                            runat="server"></asp:TextBox>
                    </td>
                    <td>Select Shift
                    </td>
                    <td>
                        <asp:DropDownList ID="ddl_Shift"
                            Width="200px"
                            TabIndex="2"
                            AutoPostBack="true"                  
                            runat="server">
                            <asp:ListItem Text="ALL" Value="0"></asp:ListItem>
                        </asp:DropDownList></td>
                    <td>
                        <asp:Button 
                            ID="btn_ExcelExport"
                            runat="server"
                            Text="Excel Export"
                            OnClick="btn_ExcelExport_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        Report Make Using
                    </td>
                    <td colspan="3">
                    <asp:RadioButton 
                        ID="rb_gv"
                        GroupName="ReportSelection"
                        runat="server"
                        Text="GridView" />
                        <asp:RadioButton 
                        ID="rb_Repeater"
                        Checked="true"
                        GroupName="ReportSelection"
                        runat="server"
                        Text="Repeater" />
                        <asp:RadioButton 
                        ID="rb_ResponsWrite"
                        GroupName="ReportSelection"
                        runat="server"
                        Text="Response.Write" />
                        <asp:RadioButton 
                        GroupName="ReportSelection"
                        ID="rb_literal"
                        runat="server"
                        Text="Literal" />
                    </td>
                    <td>
                            <asp:CheckBox
                            ID="cb_ShiftwiseTotal"
                            Text="ShiftWise Total Added"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
                            <asp:CheckBox
                            ID="cb_DeptWiseTotal"
                            Text="DeptWise Total Added"
                            TextAlign="Left"
                            runat="server"></asp:CheckBox>&nbsp;&nbsp;&nbsp;
                    </td>
                </tr>
            </table>
                     <%--<asp:Literal ID="lbl_html" runat="server"></asp:Literal>--%>
            <table id="tb123" runat="server">
                                            <tr>
                    <td>
                    <asp:Label ID="lbl_TableHtml" runat="server"></asp:Label></td>
                     <%--   <asp:Literal ID="lbl_html" runat="server"></asp:Literal>
                        </td>--%>
           
                </tr>

       
                <tr>
                    <td>
                        <asp:GridView
                            ID="gv" 
                            CssClass="gridview"
                            RowStyle-Wrap="false"
                            runat="server"
                            AutoGenerateColumns="true"
                            OnRowDataBound="gv_RowDataBound"
                            OnDataBound="gv_DataBound"></asp:GridView>
                        <asp:Repeater 
                            ID="rp"
                            runat="server">
                            <HeaderTemplate>
                                <table style="border: 1px solid #0000FF; width: 500px" cellpadding="0">

                <%--                    <tr style="background-color: #FF6600; color: #000000; font-size: large; font-weight: bold;">

                                        <th>

                                            <b>Comments</b>

                                        </th>

                                    </tr>--%>
                            </HeaderTemplate>
                            <ItemTemplate>

                            </ItemTemplate>
                            <FooterTemplate>
                                </table>
                            </FooterTemplate>
                        </asp:Repeater>
                    </td>
   
        
                </tr>
            </table>
            <table width="100%">
                                <tr>
                    <td>
                        
                    <asp:Label ID="lb_Message" runat="server"></asp:Label></td>
                     <%--   <asp:Literal ID="lbl_html" runat="server"></asp:Literal>
                        </td>--%>
           <td>
             
           </td>
                </tr>
            </table>
        </div>
</asp:Content>


