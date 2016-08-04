namespace Costs.DataAccess
module Literals =
    [<Literal>]
    let connectionString = @"Data Source=.;Database=Costs;Integrated Security=True"
    [<Literal>]
    let allCostsProcedurePath = __SOURCE_DIRECTORY__ + "\AllCosts.sql"    
    [<Literal>]
    let addCostProcedurePath = __SOURCE_DIRECTORY__ + "\AddCost.sql"