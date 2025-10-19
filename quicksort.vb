Imports System
Imports System.Net.NetworkInformation

Module quicksort
    Sub Main(args As String())
        Dim testArray(8) As Object
        testArray = {0, 63, 1, 4, 8, 2, 5, 5, 7}
        swapElements(testArray)
    End Sub
    Function quickSort(ByRef arrayToSort As Object()) As Object()

    End Function
    Function splitList(ByRef arrayToSplit As Object())
        Dim arrayLength = arrayToSplit.Length

    End Function
    Function swapElements(ByRef subArray As Object()) As Object()
        Dim pivot As Integer
        Dim pivotNum As Object
        Dim smallCount As Integer
        Dim bigCount As Integer
        smallCount = 0
        bigCount = 0
        Dim smallOnes(subArray.Length) As Object
        Dim bigOnes(subArray.Length) As Object
        pivot = (subArray.Length) / 2
        If pivot Mod 2 <> 0 Then pivot = pivot + 1
        pivotNum = subArray(pivot)

        For i = 0 To subArray.Length - 1
            If subArray(i) < pivotNum Then
                smallOnes(smallCount) = subArray(i)
                smallCount = smallCount + 1
            End If
            If subArray(i) >= pivotNum Then
                bigOnes(bigCount) = subArray(i)
                bigCount = bigCount + 1
            End If
        Next

        For x = 0 To smallCount - 1
            subArray(x) = smallOnes(x)
        Next
        For x = smallCount To subArray.Length - 1
            subArray(x) = bigOnes(x - smallCount)
        Next
        Return subArray
    End Function
End Module
