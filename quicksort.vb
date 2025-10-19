Imports System
Imports System.Net.NetworkInformation

Module quicksort
    Sub Main(args As String())
        Dim testArray(8) As Object
        testArray = {0, 63, 1, 4, 8, 2, 5, 5, 7}
        Dim placedLocations(8) As Boolean
        sortArray(testArray, placedLocations, 0)
    End Sub
    Function reorganiseArray(ByRef arrayToSort As Object(), ByRef placedLocations As Boolean())
        Dim subArraylengthCount As Integer
        subArraylengthCount = 0
        Dim pointer As Integer
        Dim x As Integer
        pointer = 0
        x = 0
        Do
            Do
                subArraylengthCount = subArraylengthCount + 1
                x = x + 1
            Loop Until placedLocations(x) = True

            Dim subArray(subArraylengthCount) As Object
            For i = 0 To subArraylengthCount - 1
                subArray(i) = arrayToSort(pointer + i)
            Next

            x = x + 1
        Loop Until arrayToSort.Length - 1
    End Function
    Function sortArray(ByRef subArray As Object(), ByRef placedArray As Boolean(), ByVal snipIndex As Integer)
        Dim subArrayLength As Integer
        subArrayLength = subArray.Length
        Dim smallerObjArray(subArrayLength - 1) As Object
        Dim sameObjArray(subArrayLength - 1) As Object
        Dim biggerObjArray(subArrayLength - 1) As Object

        Dim pivot As Object
        pivot = subArray(getPivotLocation(subArrayLength))

        Dim smallerAmount As Integer
        Dim sameAmout As Integer
        Dim biggerAmount As Integer
        smallerAmount = 0
        sameAmout = 0
        biggerAmount = 0

        For x = 0 To subArrayLength - 1
            Select Case subArray(x)
                Case < pivot
                    smallerObjArray(smallerAmount) = subArray(x)
                    smallerAmount = smallerAmount + 1
                Case = pivot
                    sameObjArray(sameAmout) = subArray(x)
                    sameAmout = sameAmout + 1
                Case > pivot
                    biggerObjArray(biggerAmount) = subArray(x)
                    biggerAmount = biggerAmount + 1
            End Select
        Next

        For x = 0 To smallerAmount - 1
            subArray(x) = smallerObjArray(x)
        Next
        For x = smallerAmount To (smallerAmount + sameAmout - 1)
            subArray(x) = sameObjArray(x - (smallerAmount + sameAmout - 1))
        Next
        placedArray(snipIndex + (smallerAmount + sameAmout - 1)) = True
        For x = (smallerAmount + sameAmout) To (subArrayLength - 1)
            subArray(x) = biggerObjArray(x - (subArrayLength - 1))
        Next

        Return subArray
    End Function
    Function getPivotLocation(ByVal lengthOfArray As Integer) As Integer
        If lengthOfArray Mod 2 <> 0 Then
            Return (lengthOfArray \ 2)
        Else Return (lengthOfArray \ 2) - 1
        End If
    End Function
End Module
