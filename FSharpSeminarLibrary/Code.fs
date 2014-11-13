namespace FSharpSeminarLibrary



type Customer(id: int, name: string) =

  let mutable _fullName = sprintf "%d - %s" id name
  do
    printf "Constructing a new customer..."

  member this.Id = id

  member this.Name = name
  
  member this.FullName
    with get() = _fullName
    and set(value) = 
      if System.String.IsNullOrWhiteSpace(value) then raise (new System.ArgumentNullException("value"))
      _fullName <- value

  new(id: int) = Customer(id, id.ToString())

  override this.ToString() = _fullName



/// Zakaznicka repository
type ICustomerRespository =
  abstract member GetAllCustomerIds: unit -> int[]
  abstract member GetCustomer: int * string -> Customer


[<AbstractClassAttribute>]
type CustomerRepositoryBase() =
  interface ICustomerRespository with
    member this.GetAllCustomerIds() = this.GetAllCustomerIdsCore()
    member this.GetCustomer(id: int, token: string) = Customer(id)

  abstract member GetAllCustomerIdsCore: unit -> int[]
  default this.GetAllCustomerIdsCore() = Array.ofList [10..100]
  

type DefaultCustomerRepository() =
  inherit CustomerRepositoryBase()

  override this.GetAllCustomerIdsCore() = 
    let baseList = base.GetAllCustomerIdsCore()
    baseList


