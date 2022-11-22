# spec-kata

from src folder 
- build for release
  dotnet build -c release
- dotnet .\spec.console\bin\Release\netcoreapp3.1\SpecConsole.dll

with initial array 
```csharp
var InnerClocks = new List<int> { 3, 4, 3, 1, 2 };
```
- 18 iterations

|                                   Method |     Mean | Error | Allocated |
|----------------------------------------- |---------:|------:|----------:|
| GetInnerClocksForGenerationWithMutations | 13.01 ms |    NA |   2.05 KB |
|              GetInnerClocksForGeneration | 15.27 ms |    NA |   9.77 KB |
|    GetInnerClocksForGenerationWithNested | 16.75 ms |    NA |  27.68 KB |