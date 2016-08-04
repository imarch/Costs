namespace Costs.DataAccess
module Commands =
    open FSharp.Data
    open System
    open Microsoft.FSharp.Reflection
    open Literals
    open Models

    let private AddCostCommand = new SqlCommandProvider<addCostProcedurePath, connectionString>(connectionString)
    let private AllCostsCommand = new SqlCommandProvider<allCostsProcedurePath, connectionString>(connectionString)

    let getAllCosts = 
        AllCostsCommand.Execute() 
        |> Seq.map (fun record -> Models.createCostInfo record.Price record.Message record.CostType)
    
    let private getUnionCaseName (x:'a) = 
        match FSharpValue.GetUnionFields(x, typeof<'a>) with
        | case, _ -> case.Name 

    let addCostInfo (costInfo:CostInfo) =
        let (price, costType, Message message) = costInfo
        AddCostCommand.Execute(price = price, cost_type = getUnionCaseName costType, message = message)