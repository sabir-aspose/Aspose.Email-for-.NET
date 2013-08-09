'////////////////////////////////////////////////////////////////////////
' Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
'
' This file is part of Aspose.Email. The source code in this file
' is only intended as a supplement to the documentation, and is provided
' "as is", without warranty of any kind, either expressed or implied.
'////////////////////////////////////////////////////////////////////////

Imports Microsoft.VisualBasic
Imports System.IO

Imports Aspose.Email
Imports Aspose.Email.Mail
Imports System
Imports Aspose.Email.Pop3

Namespace RetrievingEmailMessages
	Public Class Program
		Public Shared Sub Main(ByVal args() As String)
			' The path to the documents directory.
			Dim dataDir As String = Path.GetFullPath("../../../Data/")

			'Create an instance of the Pop3Client class
			Dim client As New Pop3Client()

			'Specify host, username and password for your client
			client.Host = "pop.gmail.com"

			' Set username
			client.Username = "asposetest123@gmail.com"

			' Set password
			client.Password = "F123456f"

			' Set the port to 995. This is the SSL port of POP3 server
			client.Port = 995

			' Enable SSL
			client.EnableSsl = True

			Try
				client.Connect(True)

				Dim messageCount As Integer = client.GetMessageCount()
				' Create an instance of the MailMessage class
				Dim msg As MailMessage

				For i As Integer = 1 To messageCount
					'Retrieve the message in a MailMessage class
					msg = client.FetchMessage(i)

					Console.WriteLine("From:" & msg.From.ToString())
					Console.WriteLine("Subject:" & msg.Subject)
					Console.WriteLine(msg.HtmlBody)

				Next i

			Catch ex As Exception
				Console.WriteLine(ex.Message)
			Finally
				client.Disconnect()
			End Try
		End Sub
	End Class
End Namespace