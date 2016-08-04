namespace Costs.DataAccess
module Models =
    open System;

    type Price = decimal

    type CostType = Food | Alcohol | Fuel | Movie | Other
    let toCostType = function
        | "Food" -> Food
        | "Alcohol" -> Alcohol
        | "Fuel" -> Fuel
        | "Movie" -> Movie
        | _ -> Other

    type Message = Message of string
    let createMessage s =
        if String.IsNullOrEmpty s || String.length s > 200 then
            Message ""
        else
            Message s

    type CostInfo = Price * CostType * Message      
    let createCostInfo price message costType : CostInfo =
        (price, (toCostType costType), (createMessage message))

