module SSA2WebVTT.Parser

open FParsec
open FParsec.Pipes

let scriptinfoparse = 
  %"[Script Info]" 