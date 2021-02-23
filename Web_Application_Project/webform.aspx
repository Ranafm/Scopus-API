<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <div>
                <asp:ListView ID="ListView1" runat="server">
                    <ItemTemplate>
                        <div class="col">
                            <div class="card " style="width: 18rem;">

                                <div class="card-body">
                                    <h5 class="card-title">
                                        <%#(Eval("name").ToString())%>
                                    </h5>
                                    <p class="card-text">
                                        <%#(Eval("subject").ToString())%>
                                    </p>
                                    <a href='<%#(Eval("link").ToString())%>' class="btn btn-primary">المزيد</a>
                                </div>
                            </div>
                            <br />
                            <br />
                        </div>
                    </ItemTemplate>
                </asp:ListView>
        </div>
    </form>

</body>

</html>
