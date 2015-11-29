// Learn more about F# at http://fsharp.org. See the 'F# Tutorial' project
// for more guidance on F# programming.

#r @"c:\users\xavi\documents\visual studio 2015\Projects\TypeProviders_FSharp\packages\FSharp.Data.2.2.5\lib\net40\FSharp.Data.dll"

#load "Library1.fs"
open FSharp.Data
open TypeProviders_FSharp

type Questions = JsonProvider<"""https://api.stackexchange.com/2.2/questions?site=stackoverflow""">

let csQuestions  = """https://api.stackexchange.com/2.2/questions?site=stackoverflow&tagged=C%23"""
Questions.Load(csQuestions).Items |> Seq.iter(fun q -> printfn "%s" q.Title)


