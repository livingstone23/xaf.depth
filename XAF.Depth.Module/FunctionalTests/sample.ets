;#DropDB XAF.DepthEasyTest

#Application XAF.DepthWin
;#Application XAF.DepthWeb
#IfDef XAF.DepthWin

*Action About...
 
*Action OK

#EndIf

#IfDef XAF.DepthWeb
!Action Navigation(My Details)
#EndIf
