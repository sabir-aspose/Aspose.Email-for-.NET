﻿Imports Aspose.Email.Exchange

'
'This project uses Automatic Package Restore feature of NuGet to resolve Aspose.Email for .NET API reference 
'when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
'If you do not wish to use NuGet, you can manually download Aspose.Email for .NET API from http://www.aspose.com/downloads, 
'install it and then add its reference to this project. For any issues, questions or suggestions 
'please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
'

Namespace Aspose.Email.Examples.VisualBasic.Email.Exchange
	Class ProgrammingSamplesUsingEWS
		Public Shared Sub Run()
			' ExStart:ProgrammingSamplesUsingEWS
			' Create instance of ExchangeWebServiceClient class by giving credentials
			Dim client As IEWSClient = EWSClient.GetEWSClient("https://outlook.office365.com/ews/exchange.asmx", "Shabir.haider@studentpartner.com", "LoveAir1993")

			' Call ListMessages method to list messages info from Inbox
			Dim msgCollection As ExchangeMessageInfoCollection = client.ListMessages(client.MailboxInfo.InboxUri)

			' Loop through the collection to display the basic information
			For Each msgInfo As ExchangeMessageInfo In msgCollection
				Console.WriteLine("Subject: " + msgInfo.Subject)
				Console.WriteLine("From: " + msgInfo.From.ToString())
				Console.WriteLine("To: " + msgInfo.[To].ToString())
				Console.WriteLine("Message ID: " + msgInfo.MessageId)
				Console.WriteLine("Unique URI: " + msgInfo.UniqueUri)
				Console.WriteLine("==================================")
			Next
			' ExEnd:ProgrammingSamplesUsingEWS
		End Sub
	End Class
End Namespace