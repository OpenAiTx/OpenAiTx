# ReferenceTrimmer
[![NuGet Version](https://img.shields.io/nuget/v/ReferenceTrimmer.svg)](https://www.nuget.org/packages/ReferenceTrimmer)
[![NuGet Downloads](https://img.shields.io/nuget/dt/ReferenceTrimmer.svg)](https://www.nuget.org/packages/ReferenceTrimmer)

MSBuild 프로젝트에서 제거할 수 있는 C# 종속성을 쉽게 식별하고, MSVC 출력을 노출하여 링크 시 사용하지 않는 라이브러리와 지연 로드 DLL을 표시합니다. 프로젝트 종속성을 제거하면 빌드 종속성 그래프가 평탄화되어 빌드 병렬성을 향상시키고 전체 빌드 시간을 단축할 수 있습니다.

## 규칙
다음 경고는 이 패키지에서 생성됩니다:

| Id     | 설명        |
|--------|-------------|
| RT0000 | 사용된 참조 감지의 정확성을 위한 문서 생성 활성화 |
| RT0001 | 불필요한 참조  |
| RT0002 | 불필요한 프로젝트 참조 |
| RT0003 | 불필요한 패키지 참조 |

## 사용 방법
프로젝트에 [ReferenceTrimmer](https://www.nuget.org/packages/ReferenceTrimmer) 패키지 참조를 추가하거나, 저장소의 [`Directory.Packages.props`](https://raw.githubusercontent.com/dfederm/ReferenceTrimmer/main/./Directory.Build.props)에서 공통 패키지 참조로 추가합니다.

[중앙 패키지 관리](https://learn.microsoft.com/en-us/nuget/consume-packages/Central-Package-Management)를 사용하는 경우, 저장소 전체에 적용하기 위해 `Directory.Packages.props`에서 `GlobalPackageReference`로 사용할 수 있습니다.

```xml
  <ItemGroup>
    <GlobalPackageReference Include="ReferenceTrimmer" Version="{LatestVersion}" />
  </ItemGroup>
```
### C#
C# 문서 XML 생성을 활성화해야 좋은 분석 결과를 얻을 수 있습니다. 저장소가 아직 전역적으로 docxml을 사용하지 않는 경우, 이는 docxml에 특화된 많은 오류와 경고를 발생시킬 수 있습니다. 또한, docxml을 켜면 추가 출력 I/O가 발생하여 대규모 저장소에서 빌드 속도가 느려질 수 있습니다.

`Directory.Build.props`에 다음과 같은 코드 블록을 사용하여 ReferenceTrimmer를 기본적으로 끈 상태에서 특정 docxml 관련 경고와 오류를 끌 수 있습니다. MSBuild 명령줄에서 `/p:EnableReferenceTrimmer=true`를 설정하거나 동일한 속성 값을 환경 변수로 설정하여 ReferenceTrimmer 빌드를 활성화할 수 있습니다. 저장소용 별도의 빌드 파이프라인을 만들어 ReferenceTrimmer 빌드를 실행할 수도 있습니다.


```xml
  <!-- ReferenceTrimmer - run build with /p:EnableReferenceTrimmer=true to enable -->
  <PropertyGroup Label="ReferenceTrimmer">
    <EnableReferenceTrimmer Condition=" '$(EnableReferenceTrimmer)' == '' ">false</EnableReferenceTrimmer>
  </PropertyGroup>
  <PropertyGroup Condition=" '$(EnableReferenceTrimmer)' == 'true' and '$(GenerateDocumentationFile)' != 'true' " Label="ReferenceTrimmer">
    <!-- Documentation file generation is required for more accurate C# detection. -->
    <GenerateDocumentationFile>true</GenerateDocumentationFile>

    <!-- Suppress XML doc comment issues to avoid errors during ReferenceTrimmer:
         - CS0419: Ambiguous reference in cref attribute
         - CS1570: XML comment has badly formed XML
         - CS1573: Parameter has no matching param tag in the XML comment
         - CS1574: XML comment has cref attribute that could not be resolved
         - CS1584: XML comment has syntactically incorrect cref attribute
         - CS1591: Missing XML comment for publicly visible type or member
         - SA1602: Enumeration items should be documented
    -->
    <NoWarn>$(NoWarn);419;1570;1573;1574;1584;1591;SA1602</NoWarn>
  </PropertyGroup>
```
참고: 더 나은 결과를 얻으려면 [`IDE0005`](https://learn.microsoft.com/en-us/dotnet/fundamentals/code-analysis/style-rules/ide0005) 불필요한 `using` 규칙을 활성화하세요. 이는 C# 컴파일러가 불필요한 `using` 지시문에서 잘못된 어셈블리 사용을 감지하여 제거 가능한 종속성을 놓치는 것을 방지합니다. IDE0005 코드 분석 규칙이 `<GenerateDocumentationFile>` 속성 활성화를 요구하는 이유에 대한 참고 사항도 확인하세요. 문서 생성은 사용된 참조 감지의 정확성을 위해서도 필요합니다(https://github.com/dotnet/roslyn/issues/66188 기반).

### C++ (.vcxproj 프로젝트)
C++용 ReferenceTrimmer는 MSBuild [분산 로거](https://learn.microsoft.com/en-us/visualstudio/msbuild/logging-in-a-multi-processor-environment?view=vs-2022)입니다. MSBuild stdout 스트림에 지침을 작성하며(현재 MSBuild 내부 로거에는 작성하지 않음), 빌드 작업 디렉터리에 `ReferenceTrimmerUnusedMSVCLibraries.json.log`를 기록합니다.

분산 로거는 MSBuild 명령줄에서 `-distributedlogger` 매개변수를 사용하여 구성해야 합니다. 패키지 로거를 가져오고 사용하는 방법은 [BuildWithReferenceTrimmer 예제 스크립트](https://raw.githubusercontent.com/dfederm/ReferenceTrimmer/main/./examples/BuildWithReferenceTrimmer.cmd)를 참조하세요.

.vcxproj 복원이 ReferenceTrimmer props 및 targets를 빌드에 추가하도록 작동하게 하려면 `dotnet restore` 대신 `msbuild -restore` 또는 `msbuild /t:Restore`를 사용하세요. *참고*: MSBuild에서 `Sequence contains no elements` 예외가 발생하면 https://github.com/dotnet/NuGet.BuildTasks/issues/154의 해결 방법이나 수정 상태를 확인하세요.

현재 구현은 MSVC `link.exe` 플래그 `/VERBOSE:UNUSEDLIBS` 및 `/VERBOSE:UNUSEDDELAYLOAD`를 활성화합니다. 이 플래그들은 링커가 stdout에 사용하지 않는 .lib 파일과 지연 로드 DLL을 출력하도록 지시합니다. 여기에는 코드 번들을 포함하는 .lib 파일과 DLL용 임포트 라이브러리가 포함됩니다. 이러한 라이브러리를 제거하면 링커의 I/O 및 메모리 사용량이 줄어듭니다. 링커 출력 예시는 다음과 같습니다:


```text
Unused libraries:
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\gdi32.lib
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\winspool.lib
  C:\Program Files (x86)\Windows Kits\10\lib\10.0.19041.0\um\x64\comdlg32.lib
```

ReferenceTrimmer는 이 출력을 읽고 결과 라이브러리를 두 세트로 분할합니다:

#### Windows SDK 가져오기 라이브러리
MSBuild용 Microsoft C++ SDK는 `AdditionalDependencies` 속성에 kernel32.lib 및 user32.lib와 같은 Win32 가져오기 라이브러리의 기본 목록을 포함합니다. 로컬 VS 설치에서 기본 목록을 찾으려면 다음을 검색하세요:

```cmd
findstr /s CoreLibraryDependencies "\Program Files"\*props
```
이 기능들을 비활성화하려면, vcxproj의 `<AdditionalDependencies>` 속성을 프로젝트에 필요한 SDK .lib 파일 목록만 포함하도록 수정하고, 기본 목록을 피하기 위해 속성에 `%(AdditionalDependencies)`를 추가하지 마십시오. 예:


```xml
<ItemDefinitionGroup>
  <Link>
    <AdditionalDependencies>kernel32.lib;shlwapi.lib;ws2_32.lib</AdditionalDependencies>
  </Link>
</ItemDefinitionGroup>
```

모든 SDK .lib 파일을 이 방법으로 제거할 수 있는 것은 아닙니다. `<IgnoreSpecificDefaultLibraries>`도 사용해야 할 수 있습니다:

```xml
<ItemDefinitionGroup>
  <Link>
    <IgnoreSpecificDefaultLibraries>OLDNAMES.lib;%(IgnoreSpecificDefaultLibraries)</IgnoreSpecificDefaultLibraries>
  </Link>
</ItemDefinitionGroup>
```

#### 패키지 또는 프로젝트 라이브러리
레포에 있는 .vcxproj에서 생성된 사용하지 않는 .lib가 있으면, 빌드 종속성 그래프를 개선하고 빌드 중 병렬성을 높이기 위해 해당 vcxproj에 대한 `ProjectReference`를 제거할 수 있습니다.

패키지에서 온 사용하지 않는 .lib가 있으면, 링크 속도를 높이기 위해 해당 .lib에 대한 참조를 프로젝트에서 제거하십시오.

## 참조에 대한 규칙 비활성화
특정 프로젝트나 패키지 참조에 대한 규칙을 끄려면 관련 RTxxxx 코드를 NoWarn 메타데이터 속성에 추가하십시오. 예를 들면:

```xml
<ProjectReference Include="../Other/Project.csproj" NoWarn="RT0002" />
```
## 구성
`$(EnableReferenceTrimmer)` - 빌드 로직이 특정 프로젝트에 대해 실행될지 여부를 제어합니다. 기본값은 `true`입니다.

`$(ReferenceTrimmerEnableVcxproj)` - MSVC 링크 플래그가 사용되지 않는 라이브러리 및 지연 로드 DLL을 출력하도록 설정할지 여부를 제어합니다. 기본값은 `true`입니다.

## 작동 방식은?

### C#
C# 지원에는 두 가지 주요 요소가 있습니다. 첫째, 컴파일러에 전달된 모든 참조를 수집하는 MSBuild 작업이 있습니다. 또한 Visual Studio 2019 버전 16.10, .NET 5와 함께 제공된 Roslyn 컴파일러에서 사용할 수 있는 [`GetUsedAssemblyReferences`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.codeanalysis.compilation.getusedassemblyreferences) 분석기 API를 사용하는 Roslyn 분석기가 있습니다(https://github.com/dotnet/roslyn/blob/main/docs/wiki/NuGet-packages.md#versioning 참조). 이는 컴파일에 필요한 참조를 컴파일러가 정확히 알려주는 것입니다. 분석기는 작업이 수집한 참조 집합과 컴파일러가 사용했다고 말하는 참조를 비교합니다.

### C++ (.vcxproj 프로젝트)
ReferenceTrimmer는 위에서 언급한 MSVC `link.exe` 플래그를 활성화한 후 `Link` MSBuild 작업에서 나오는 출력을 구문 분석합니다. 출력 결과를 분류하여 MSBuild 콘솔 출력과 위에서 언급한 JSON 출력 파일에 기록합니다. 현재는 MSBuild 경고를 발행하지 않습니다.

## 향후 개발
https://github.com/dotnet/sdk/issues/10414의 결과가 `ReferenceTrimmer`의 향후 업데이트에 유용할 수 있습니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-21

---