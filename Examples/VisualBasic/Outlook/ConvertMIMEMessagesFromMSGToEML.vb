﻿Imports Aspose.Email.Mail
Imports Aspose.Email.Outlook

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https:// Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email.Outlook
    Class ConvertMIMEMessagesFromMSGToEML
        Public Shared Sub Run()
            ' ExStart:ConvertMIMEMessagesFromMSGToEML
            ' The path to the documents directory.
            Dim dataDir As String = RunExamples.GetDataDir_Outlook()
            Dim msg As MailMessage = MailMessage.Load(dataDir & Convert.ToString("message.eml"))
            Dim mapi As MapiMessage = MapiMessage.FromMailMessage(msg, New MapiConversionOptions(OutlookMessageFormat.Unicode))
            ' Save File to disk
            mapi.Save(dataDir & Convert.ToString("ConvertMIMEMessagesFromMSGToEML_out.msg"))
            ' ExEnd:ConvertMIMEMessagesFromMSGToEML
        End Sub
    End Class
End Namespace
