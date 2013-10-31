// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    
    let anInt = 5
    let aString = "Hello" 
    // Perform a simple calculation and bind anIntSquared to the result. 
    let anIntSquared = anInt * anInt
    System.Console.WriteLine(anInt)
    System.Console.WriteLine(aString)
    System.Console.WriteLine(anIntSquared)
    0 // return an integer exit code
