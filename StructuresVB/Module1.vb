Module Module1
    Structure Town
        Dim townName As String
        Dim population As Integer
        Dim area As Double
        Dim county As String
        Public Sub New(tName, tPop, tArea, tCounty)
            townName = tName
            population = tPop
            area = tArea
            county = tCounty
        End Sub
    End Structure
    Sub Main()
        Dim t As Town
        t.townName = "Hekcmondwike"
        t.population = 12345
        t.area = 6520.5
        t.county = "West Yorkshire"
        Console.WriteLine(t.townName)
        Console.WriteLine($"Town {t.townName} has a population of  {t.population} and an area of {t.area}")

        Dim OtherTown As New Town("Batley", 123, 63.1, "West Yorkshire")
        Console.WriteLine($"Town {OtherTown.townName} has a population of  {OtherTown.population} and an area of {OtherTown.area}")

        Dim towns(5) As Town
        towns(0) = OtherTown
        towns(1) = New Town("Leeds", 111, 12.3, "West Yorkshire")
        towns(2).townName = "London"
        towns(2).population = 1
        towns(2).area = 1.1
        towns(2).county = "South"

        Dim myTowns(5) As Town
        For i = 0 To 5
            Console.WriteLine("Town" & i)
            Console.Write("Enter town name: ")
            myTowns(i).townName = Console.ReadLine
            Console.Write("Enter population: ")
            myTowns(i).population = Console.ReadLine()
            Console.Write("Enter area: ")
            myTowns(i).area = Console.ReadLine()
            Console.Write("Enter county: ")
            myTowns(i).county = Console.ReadLine()

        Next
        Dim myTowns2(5) As Town
        Dim tName, County As String
        Dim pop As Integer
        Dim area As Double
        For i = 0 To 5
            Console.WriteLine("Town" & i)
            Console.Write("Enter town name: ")
            tName = Console.ReadLine
            Console.Write("Enter population: ")
            pop = Console.ReadLine
            Console.Write("Enter area: ")
            area = Console.ReadLine()
            Console.Write("Enter county: ")
            County = Console.ReadLine()
            myTowns2(i) = New Town(tName, pop, area, County)
        Next
    End Sub

End Module
