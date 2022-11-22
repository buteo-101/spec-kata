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

|                                                    Method |         Mean | Error |      Gen0 |      Gen1 |      Gen2 |     Allocated |
|---------------------------------------------------------- |-------------:|------:|----------:|----------:|----------:|--------------:|
|                  GetInnerClocksForGenerationWithMutations |     13.60 ms |    NA |         - |         - |         - |       1.94 KB |
|                GetInnerClocksForGenerationWithMutations80 |     15.53 ms |    NA |         - |         - |         - |      38.37 KB |
|                               GetInnerClocksForGeneration |     15.60 ms |    NA |         - |         - |         - |       8.22 KB |
|            GetInnerClocksForGenerationWithMutationsBySeed |     15.76 ms |    NA |         - |         - |         - |       5.58 KB |
|          GetInnerClocksForGenerationWithMutationsBySeed80 |     15.88 ms |    NA |         - |         - |         - |      99.88 KB |
|               GetInnerClocksForGenerationWithMutations150 |    352.54 ms |    NA | 2000.0000 | 2000.0000 | 2000.0000 |   16395.41 KB |
|    GetInnerClocksForGenerationWithMutationsBySeedSlice150 |    353.33 ms |    NA | 1000.0000 | 1000.0000 | 1000.0000 |   22982.66 KB |
|         GetInnerClocksForGenerationWithMutationsBySeed150 |    356.72 ms |    NA | 4000.0000 | 4000.0000 | 4000.0000 |   29216.52 KB |
| GetInnerClocksForGenerationWithMutationsBySeedSlice150Big | 19,805.99 ms |    NA | 8000.0000 | 8000.0000 | 8000.0000 | 2018488.05 KB |
