<<<<<<< HEAD
Imports System
Imports System.IO

' A replace_pattern_at_file program in Visual Basic.
' Данная программа заменяет указанный образец текста во всём вхождении файла. Функция не поддерживает регулярных выражений и чувствительна к регистру!
' АРГУМЕНТЫ: 
'   1 -- краткое или полное имя файла
'   2 -- заменяемый образец в тексте имени файла
'   3 -- заменяющий образец в имени файла
' ФУНКЦИЯ ВОЗВРАЩАЕТ:
'   0 -- успешное завершение
'   1 -- нечего заменять или ошибка в заменяемом образце
'   2 -- ошибка в количестве аргументов функции
'   3 -- неправильное имя файла или файл отсутствует
'
' Данная функция используется для корректной смены указаний файла на самого себя при переименовании файла настроек.
'
Module replace_pattern_at_file

    Function Main(ByVal CmdArgs() As String) As Integer
        If CmdArgs.Length <> 3 Then   ' See if there are not three arguments.
            MsgBox("Wrong Number Arguments! Exit Code 2")   ' Display message on computer screen.
            Return 2
        End If
        If Len(CmdArgs(1)) = 0 Then Return 1
        Dim fi As New FileInfo(CmdArgs(0))
        If fi.Exists Then
            Replace_In_File(CmdArgs(0), CmdArgs(1), CmdArgs(2))
            Return 0   ' Zero usually means successful completion.
        End If
        MsgBox("I/O Error or File not Found! Exit Code 3")   ' Display message on computer screen.
        Return 3
    End Function

End Module
=======
﻿Imports System
Imports System.IO

' A replace_pattern_at_file program in Visual Basic.
' Данная программа заменяет указанный образец текста во всём вхождении файла. Функция не поддерживает регулярных выражений и чувствительна к регистру!
' АРГУМЕНТЫ: 
'   1 -- краткое или полное имя файла
'   2 -- заменяемый образец в тексте имени файла
'   3 -- заменяющий образец в имени файла
' ФУНКЦИЯ ВОЗВРАЩАЕТ:
'   0 -- успешное завершение
'   1 -- нечего заменять или ошибка в заменяемом образце
'   2 -- ошибка в количестве аргументов функции
'   3 -- неправильное имя файла или файл отсутствует
'
' Данная функция используется для корректной смены указаний файла на самого себя при переименовании файла настроек.
'
Module replace_pattern_at_file

    Function Main(ByVal CmdArgs() As String) As Integer
        If CmdArgs.Length <> 3 Then   ' See if there are not three arguments.
            MsgBox("Wrong Number Arguments! Exit Code 2")   ' Display message on computer screen.
            Return 2
        End If
        If Len(CmdArgs(1)) = 0 Then Return 1
        Dim fi As New FileInfo(CmdArgs(0))
        If fi.Exists Then
            Replace_In_File(CmdArgs(0), CmdArgs(1), CmdArgs(2))
            Return 0   ' Zero usually means successful completion.
        End If
        MsgBox("I/O Error or File not Found! Exit Code 3")   ' Display message on computer screen.
        Return 3
    End Function

End Module
>>>>>>> replace_pattern_at_file/master
