// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open FSharp.Data
open Costs.DataAccess

[<EntryPoint>]
let main argv = 
    Commands.addCostInfo (100M, Models.Alcohol, Models.createMessage "Message") |> ignore
    Commands.getAllCosts |> printfn "%A"
    1

