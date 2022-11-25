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

|                                                     Method |          Mean | Error |       Gen0 |       Gen1 |       Gen2 |     Allocated |
|----------------------------------------------------------- |--------------:|------:|-----------:|-----------:|-----------:|--------------:|
|             GetInnerClocksForGenerationWithMutationsBySeed |      14.50 ms |    NA |          - |          - |          - |      21.65 KB |
|                   GetInnerClocksForGenerationWithMutations |      14.68 ms |    NA |          - |          - |          - |      18.01 KB |
|                                GetInnerClocksForGeneration |      38.99 ms |    NA |          - |          - |          - |      24.29 KB |
|                              GetInnerClocksbyGeneration150 |     257.29 ms |    NA |  4000.0000 |  4000.0000 |  4000.0000 |   12331.27 KB |
|                           GetInnerClocksbyGeneration150Big |     319.20 ms |    NA |  5000.0000 |  5000.0000 |  5000.0000 |   14428.55 KB |
|     GetInnerClocksForGenerationWithMutationsBySeedSlice150 |     342.47 ms |    NA |  1000.0000 |  1000.0000 |  1000.0000 |   22998.92 KB |
| GetInnerClocksForGenerationWithMutationsBySeedWithSteps150 |     358.20 ms |    NA |  6000.0000 |  6000.0000 |  6000.0000 |    52836.3 KB |
|          GetInnerClocksForGenerationWithMutationsBySeed150 |     367.65 ms |    NA |  4000.0000 |  4000.0000 |  4000.0000 |   29232.85 KB |
|                GetInnerClocksForGenerationWithMutations150 |     373.71 ms |    NA |  2000.0000 |  2000.0000 |  2000.0000 |   16411.52 KB |
|                              GetInnerClocksbyGeneration220 | 148,034.01 ms |    NA | 12000.0000 | 12000.0000 | 12000.0000 | 6291572.66 KB |