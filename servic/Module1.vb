Module Module1
    Public login_name, login_ID, sex_name As String

    Public Function check_text(ByVal txt As String) As String
        check_text = txt.Replace("'", "\'")
        check_text = check_text.Replace("$", "\$")
        check_text = check_text.Replace("%", "\%")
        check_text = check_text.Replace("#", "\#")
        check_text = check_text.Replace("%", "\%")
        check_text = check_text.Replace("&", "\&")
        check_text = check_text.Replace("^", "\^")
        check_text = check_text.Replace("*", "\*")
        check_text = check_text.Replace("`", "\`")
        check_text = check_text.Replace("\", "\`")
        Return check_text
    End Function

    Public connect_db As String = "Server=127.0.0.1;User Id=root;Password=root1234; Database=repari; Pooling=false;"



End Module
