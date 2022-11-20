# spec-kata

from src folder 
- build for release
  dotnet build -c release
- dotnet .\spec.console\bin\Release\netcoreapp3.1\SpecConsole.dll

with initial array 
```csharp
var InnerClocks = new List<int> { 3, 4, 3, 1, 2 };
```
- 80 iterations

|                                   Method |     Mean | Error |  Allocated |
|----------------------------------------- |---------:|------:|-----------:|
| GetInnerClocksForGenerationWithMutations | 20.00 ms |    NA |   67.98 KB |
|              GetInnerClocksForGeneration | 49.24 ms |    NA | 1063.84 KB |

- 256 iterations


|                                   Method |    Mean | Error |       Gen0 |       Gen1 |       Gen2 | Allocated |
|----------------------------------------- |--------:|------:|-----------:|-----------:|-----------:|----------:|
| GetInnerClocksForGenerationWithMutations | 27.44 s |    NA |  7000.0000 |  7000.0000 |  7000.0000 |      2 GB |
|              GetInnerClocksForGeneration | 46.67 s |    NA | 94000.0000 | 94000.0000 | 93000.0000 |  34.32 GB |
