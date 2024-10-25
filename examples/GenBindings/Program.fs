// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"

open CppAst

let options = CppParserOptions()
do options.Defines
let concrete = CppParser.ParseFile("C:\Users\Orlando\Desktop\mushed Research\Auspice\zenoh-csharp\Lib\include\zenoh_concrete.h")

for x in concrete.Typedefs do
    match x.TypeKind with
    | CppTypeKind.Function -> printfn "Function: %s" x.Name
    | CppTypeKind.Enum -> printfn "Enum: %s" x.Name
    | CppTypeKind.StructOrClass -> printfn "Struct: %s" x.Name


let commons = CppParser.ParseFile("C:\Users\Orlando\Desktop\mushed Research\Auspice\zenoh-csharp\Lib\include\zenoh_common.h")