﻿Imports System.Net
Imports Aspose.Email.Exchange
Imports Aspose.Email.Mail

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email.Exchange
	Class DeleteMessagesFromusingEWS
		Public Shared Sub Run()
			' ExStart:DeleteMessagesFromusingEWS

			' Create instance of IEWSClient class by giving credentials
			Dim client As IEWSClient = EWSClient.GetEWSClient("https://outlook.office365.com/ews/exchange.asmx", "testUser", "pwd", "domain")
			Dim mailboxInfo As ExchangeMailboxInfo = client.GetMailboxInfo()

			' List all messages from Inbox folder
			Console.WriteLine("Listing all messages from Inbox....")
			Dim msgInfoColl As ExchangeMessageInfoCollection = client.ListMessages(mailboxInfo.InboxUri)
			For Each msgInfo As ExchangeMessageInfo In msgInfoColl
				' Delete message based on some criteria
				If msgInfo.Subject IsNot Nothing AndAlso msgInfo.Subject.ToLower().Contains("delete") = True Then
					client.DeleteMessage(msgInfo.UniqueUri)
					Console.WriteLine("Message deleted...." + msgInfo.Subject)
						' Do something else
				Else
				End If
			Next
			' ExEnd:DeleteMessagesFromusingEWS
		End Sub
	End Class
End Namespace