'Line 7, BC32025: '#Region' or '#End Region' directives cannot appear within a method body
'Line 9, BC32025: '#Region' or '#End Region' directives cannot appear within a method body

Imports System
Module RegionDirectives
	Sub Main()
		#Region

		#End Region	
	End Sub
End Module
