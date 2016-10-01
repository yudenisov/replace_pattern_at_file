<<<<<<< HEAD
Imports System
Imports System.IO

Module MyLibrary001

    ' В следующем примере используется класс StreamReader для чтения содержимого текстового файла.
    ' path -- полное или краткое имя файла
    ' Возвращаемое значение -- прочитанная строка текста
    Function ReadTextFile(ByVal path As String) As String
        Dim sr As System.IO.StreamReader
        Dim Contents As String
        sr = New StreamReader(path)
        Contents = sr.ReadToEnd()
        sr.Close()
        Return Contents
    End Function

    'Следующий пример совершает обратные действия, используя аналогичный подход: выполняет запись в текстовый файл с помощью класса StreamWriter.
    ' path -- полное или краткое имя
    ' value -- значение, записываемое в текстовый файл
    Sub WriteTextFile(ByVal path As String, ByVal value As String)
        Dim sr As StreamWriter
        sr = New StreamWriter(path)
        sr.Write(value)
        sr.Close()
    End Sub

    ' Подпрограмма заменяет в файла, заданном как sFileName, строку sTemplate строкой sPattern
    Sub Replace_In_File(ByVal sFileName As String, ByVal sTemplate As String, ByVal sPattern As String)
        Dim sInitBuffer, sDestBuffer As String ' Начальный и конечный буфер, содержащий текстовый файл
        sInitBuffer = ReadTextFile(sFileName)
        sDestBuffer = sInitBuffer.Replace(sTemplate, sPattern)
        WriteTextFile(sFileName, sDestBuffer)
    End Sub

End Module
=======
﻿Imports System
Imports System.IO

Module MyLibrary001

    ' В следующем примере используется класс StreamReader для чтения содержимого текстового файла.
    ' path -- полное или краткое имя файла
    ' Возвращаемое значение -- прочитанная строка текста
    Function ReadTextFile(ByVal path As String) As String
        Dim sr As System.IO.StreamReader
        Dim Contents As String
        sr = New StreamReader(path)
        Contents = sr.ReadToEnd()
        sr.Close()
        Return Contents
    End Function

    'Следующий пример совершает обратные действия, используя аналогичный подход: выполняет запись в текстовый файл с помощью класса StreamWriter.
    ' path -- полное или краткое имя
    ' value -- значение, записываемое в текстовый файл
    Sub WriteTextFile(ByVal path As String, ByVal value As String)
        Dim sr As StreamWriter
        sr = New StreamWriter(path)
        sr.Write(value)
        sr.Close()
    End Sub

    ' Подпрограмма заменяет в файла, заданном как sFileName, строку sTemplate строкой sPattern
    Sub Replace_In_File(ByVal sFileName As String, ByVal sTemplate As String, ByVal sPattern As String)
        Dim sInitBuffer, sDestBuffer As String ' Начальный и конечный буфер, содержащий текстовый файл
        sInitBuffer = ReadTextFile(sFileName)
        sDestBuffer = sInitBuffer.Replace(sTemplate, sPattern)
        WriteTextFile(sFileName, sDestBuffer)
    End Sub

End Module
>>>>>>> replace_pattern_at_file/master
