﻿Imports Aspose.Email.Exchange

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email.Exchange
	Class ListMessagesFromDifferentFolders
		Public Shared Sub Run()
			' ExStart:ListMessagesFromDifferentFolders
			' Create instance of ExchangeClient class by giving credentials
			Dim client As New ExchangeClient("https://MachineName/exchange/Username", "username", "password", "domain")

			' Get folder URI
			Dim strFolderURI As String = String.Empty
			strFolderURI = client.MailboxInfo.InboxUri
			strFolderURI = client.MailboxInfo.DeletedItemsUri
			strFolderURI = client.MailboxInfo.DraftsUri
			strFolderURI = client.MailboxInfo.SentItemsUri

			' get list of messages from the specified folder
			Dim msgCollection As ExchangeMessageInfoCollection = client.ListMessages(strFolderURI)
			' ExEnd:ListMessagesFromDifferentFolders
		End Sub
	End Class
End Namespace