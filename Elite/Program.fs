// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System
open GameParameters


[<EntryPoint>]
let main argv = 
    printHelp
    let command = Console.ReadLine()
    processCommand command
    Console.ReadKey() |> ignore
    0 // return an integer exit code
