// using Nancy;
// using System;
// using System.Collections.Generic;
// using ScrabbleGame.Objects;
//
// namespace ScrabbleGame
// {
//   public class Scrabble : NancyModule
//   {
//     public class HomeModule()
//
//     {
//       Get["/"] = _ => {
//         return View["index.cshtml"];
//       };
//
//       Post["/results"] = _ => {
//         Scrabble newScrabble = new Scrabble(Request.Form["user word"]);
//         return View["resutls.cshtml", newScrabble];
//       };
//
//       Get["/results"] = _ => {
//         return View["index.cshtml"];
//       };
//
//     }
//   }
//
// }
