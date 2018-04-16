module fabletool

open System
open Fable.Core
open Fable.Core.JsInterop
open Fable.Import
open Fable.Import.Browser


// really, you can have semicolons at the end of the functions?

console.log("Fable is up and running");
Browser.console.log("and yet another line");

[<Emit("undefined")>]
let undefined : obj = jsNative

console.log(undefined);


[<Emit("1")>]
let one : int = jsNative
console.log(one + one);


[<Emit("$0 === undefined")>]
let isUndefined (x : 'a) : bool = jsNative

console.log(isUndefined 5);
console.log(isUndefined undefined);

[<Emit("$0 + $1")>]
let add (a : int) (b : int) : int = jsNative
console.log(add 3 10);
console.log(add 2 4);

[<Emit("Math.random()")>]
let getRandom() : float = jsNative
console.log(getRandom());

// [<Emit("Random.Next($0,$1)")>]
// let getRandomIntBetween (a: int) (b: int) : int = jsNative
// console.log(getRandomIntBetween 7 14);

let rnd = new Random()
[<Emit("rnd.Next($0,$1)")>]
let getRandomBetween (a : int) (b : int) : int = jsNative
console.log(getRandomBetween 7 14);



