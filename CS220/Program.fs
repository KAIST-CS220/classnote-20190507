open System

// Object.Equals

type Student (name, id) =
  member __.Name: string = name
  member __.ID: int = id
  override __.Equals obj = true
  // override __.GetHashCode obj = 1
  interface IComparable with
    member __.CompareTo (obj) =
      // downcasting
      // boxing = upcasting
      let you = obj :?> Student
      if __.ID > you.ID then 1
      elif __.ID = you.ID then 0
      else -1

[<EntryPoint>]
let main argv =
  let s1 = Student ("cha", 0)
  let s2 = Student ("kim", 42)
  s1 > s2 |> printfn "%b"
  s1 <= s2 |> printfn "%b"
  0 // return an integer exit code
