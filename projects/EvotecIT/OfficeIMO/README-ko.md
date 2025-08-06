# OfficeIMO - Microsoft Word .NET 라이브러리

OfficeIMO는 갤러리에서 NuGet 패키지로 제공되며 권장 설치 방법입니다.

[![nuget 다운로드](https://img.shields.io/nuget/dt/officeIMO.Word?label=nuget%20downloads)](https://www.nuget.org/packages/OfficeIMO.Word)
[![nuget 버전](https://img.shields.io/nuget/v/OfficeIMO.Word)](https://www.nuget.org/packages/OfficeIMO.Word)
[![라이선스](https://img.shields.io/github/license/EvotecIT/OfficeIMO.svg)](#)
[![CI](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master)](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml)
[![코드커버리지](https://codecov.io/gh/EvotecIT/OfficeIMO/branch/master/graph/badge.svg)](https://codecov.io/gh/EvotecIT/OfficeIMO)

저에게 연락하고 싶으시면 Twitter 또는 LinkedIn을 통해 연락하실 수 있습니다.

[![트위터](https://img.shields.io/twitter/follow/PrzemyslawKlys.svg?label=Twitter%20%40PrzemyslawKlys&style=social)](https://twitter.com/PrzemyslawKlys)
[![블로그](https://img.shields.io/badge/Blog-evotec.xyz-2A6496.svg)](https://evotec.xyz/hub)
[![링크드인](https://img.shields.io/badge/LinkedIn-pklys-0077B5.svg?logo=LinkedIn)](https://www.linkedin.com/in/pklys)
[![디스코드](https://img.shields.io/discord/508328927853281280?style=flat-square&label=discord%20chat)](https://evo.yt/discord)

## 이 프로젝트는 무엇인가요

이것은 .NET을 사용하여 Microsoft Word 문서(.docx)를 생성할 수 있게 하는 소규모 프로젝트(개발 중)입니다.
내부적으로는 [OpenXML SDK](https://github.com/OfficeDev/Open-XML-SDK)를 사용하지만 크게 단순화했습니다.
OpenXML 작업이 너무 어렵고 시간이 많이 걸려서 만들게 되었습니다.
PowerShell 모듈 [PSWriteOffice](https://github.com/EvotecIT/PSWriteOffice)에서 사용하기 위해 만들었지만,
.NET 커뮤니티의 다른 사람들에게도 유용할 수 있다고 생각했습니다.
이 저장소에는 간단한 스프레드시트를 만들기 위한 실험적 **OfficeIMO.Excel** 구성 요소도 포함되어 있습니다.

무엇을 할 수 있는지 보고 싶다면 이 [블로그 글](https://evotec.xyz/officeimo-free-cross-platform-microsoft-word-net-library/)을 참고하세요.

저는 이전에 DocX 라이브러리(제가 공동 저자/유지보수했으며 Xceed가 인수하기 전)를 사용해 Microsoft Word 문서를 만들었지만,
.NET Framework만 지원하고 최신 커뮤니티 라이선스 때문에 프로젝트를 사용할 수 없게 되었습니다.

*저는 사실 개발자가 아니며 제가 하는 일을 잘 모릅니다. 만약 도울 방법을 아신다면 제발 도와주세요.*

- 잘못된 관행을 보시면 이슈를 열거나 PR을 제출해주세요.
- OpenXML에서 이 프로젝트에 도움이 될 수 있는 방법을 아시면 이슈를 열거나 PR을 제출해주세요.
- 더 나은 방법이 보이면 이슈를 열거나 PR을 제출해주세요.
- 제가 실수한 부분이 보이면 이슈를 열거나 PR을 제출해주세요.
- 작동 방식이 제가 생각한 것과 다르다면 이슈를 열거나 PR을 제출해주세요.

문제가 있거나 개선 제안이 있으면 이슈를 열거나 풀 리퀘스트를 제출해주세요.
중요한 것은 .NET Framework 4.7.2, .NET Standard 2.0 등에서 작동해야 한다는 점입니다.

**이 프로젝트는 개발 중이며, 특히 누군가가 도와준다면 많은 부분이 바뀔 수 있습니다.**


| 플랫폼 | 상태 | 코드 커버리지 | .NET |
| -------- | ------ | ------------- | ---- |
| Windows  | ![Windows](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word: `netstandard2.0`, `net472`, `net8.0`, `net9.0`; OfficeIMO.Excel: `netstandard2.0`, `net472`, `net48`, `net8.0`, `net9.0` |
| Linux    | ![Linux](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word: `net8.0`; OfficeIMO.Excel: `net8.0`, `net9.0` |
| MacOs    | ![macOS](https://github.com/EvotecIT/OfficeIMO/actions/workflows/dotnet-tests.yml/badge.svg?branch=master) | [Codecov](https://codecov.io/gh/EvotecIT/OfficeIMO) | OfficeIMO.Word: `net8.0`; OfficeIMO.Excel: `net8.0`, `net9.0` |
## 이 프로젝트 지원하기

이 프로젝트가 도움이 되었다면 개발 지원을 고려해 주세요.
후원은 유지보수 및 새로운 기능 개발에 더 많은 시간을 할애할 수 있도록 도와줍니다.

이 프로젝트를 만들고 유지하는 데 많은 시간과 노력이 필요합니다.
후원자가 되어 주시면 모든 사람이 무료로 이용할 수 있도록 프로젝트를 유지하는 데 도움이 됩니다.

후원자가 되려면 다음 옵션 중 선택할 수 있습니다:

- [GitHub Sponsors를 통한 후원 :heart:](https://github.com/sponsors/PrzemyslawKlys)
- [PayPal을 통한 후원 :heart:](https://paypal.me/PrzemyslawKlys)

후원은 전적으로 선택 사항이며 이 프로젝트 사용에 필수 조건이 아닙니다.
이 프로젝트는 오픈 소스로 유지되어 누구나 무료로 사용할 수 있도록 하고 싶습니다.
후원 여부와 관계없이 말입니다.

만약 귀사가 저희 .NET 라이브러리 또는 PowerShell 모듈을 사용한다면,
매니저나 마케팅 팀에 이 프로젝트 지원 가능성을 문의해 주세요.
귀사의 지원은 모두를 위한 프로젝트 유지와 개선에 큰 도움이 됩니다.

이 프로젝트 지원을 고려해 주셔서 감사합니다!

## 커뮤니티와 공유해 주세요

OfficeIMO와 그 가치에 대한 게시물을 공유하는 것을 고려해 주세요. 정말 도움이 됩니다!

[![레딧에 공유](https://img.shields.io/badge/share%20on-reddit-red?logo=reddit)](https://reddit.com/submit?url=https://github.com/EvotecIT/OfficeIMO&title=OfficeIMO)
[![해커뉴스에 공유](https://img.shields.io/badge/share%20on-hacker%20news-orange?logo=ycombinator)](https://news.ycombinator.com/submitlink?u=https://github.com/EvotecIT/OfficeIMO)
[![트위터에 공유](https://img.shields.io/badge/share%20on-twitter-03A9F4?logo=twitter)](https://twitter.com/share?url=https://github.com/EvotecIT/OfficeIMO&t=OfficeIMO)
[![페이스북에 공유](https://img.shields.io/badge/share%20on-facebook-1976D2?logo=facebook)](https://www.facebook.com/sharer/sharer.php?u=https://github.com/EvotecIT/OfficeIMO)
[![링크드인에 공유](https://img.shields.io/badge/share%20on-linkedin-3949AB?logo=linkedin)](https://www.linkedin.com/shareArticle?url=https://github.com/EvotecIT/OfficeIMO&title=OfficeIMO)

## 기능

현재 지원하는 기능 목록입니다(아마도 잊은 것도 많고 계획된 것도 있습니다). 닫힌 목록이 아니라 TODO 목록이며 더 많은 기능이 있을 것입니다:

- ☑️ Word 기본 기능
    - ☑️ 생성
    - ☑️ 불러오기
    - ☑️ 저장 (저장 시 자동 열기 옵션 포함)
    - ☑️ 다른 이름으로 저장 (저장 시 자동 열기 옵션 포함)
- ☑️ Word 속성
    - ☑️ 기본 및 사용자 정의 속성 읽기
    - ☑️ 기본 및 사용자 정의 속성 설정
- ☑️ 섹션
    - ☑️ 문단 추가
    - ☑️ 머리글 및 바닥글 추가 (홀수/짝수/첫 페이지)
    - ☑️ 머리글 및 바닥글 제거 (홀수/짝수/첫 페이지)
    - ☑️ 문단 제거
    - ☑️ 섹션 제거
- ☑️ 문서 내 머리글과 바닥글(섹션 제외)
    - ☑️ 기본, 홀수, 짝수, 첫 페이지 추가
    - ☑️ 기본, 홀수, 짝수, 첫 페이지 제거
- ☑️ 문단/텍스트를 굵게, 밑줄, 색상 등으로 설정
    - ☑️ `WordParagraphStyle`을 통한 사용자 지정 문단 스타일
- ☑️ 문단 정렬 변경
- ☑️ 문단 들여쓰기(앞, 뒤, 첫 줄, 행걸이)
- ☑️ 줄 간격(twips 및 포인트 단위 지원)
- ☑️ 표
    - ☑️ [표 스타일 추가 및 수정(내장 스타일 105개 중 하나)](https://evotec.xyz/docs/adding-tables-with-built-in-styles-managing-borders/)
    - ☑️ 행과 열 추가
    - ☑️ 셀 추가
    - ☑️ 셀 속성 추가
    - ☑️ [표 셀 테두리 추가 및 수정](https://evotec.xyz/docs/adding-tables-with-built-in-styles-managing-borders/)
    - ☑️ 행 제거
    - ☑️ 셀 제거
    - ☑️ 기타
        - ☑️ 셀 병합(수직, 수평)
        - ☑️ 셀 분할(수직)
        - ☑️ 셀 분할(수평)
        - ☑️ 병합된 셀 감지(수직, 수평)
        - ☑️ 중첩 표
        - ☑️ 각 페이지에 머리글 행 반복
        - ☑️ 행 페이지 나누기 제어
        - ☑️ 행 높이 및 표 너비 설정
- ☑️ 이미지/그림(BMP, GIF, JPEG, PNG, TIFF, EMF 지원, 다양한 감싸기 옵션 포함)
    - ☑️ 파일에서 워드로 이미지 추가
    - ☑️ Base64 문자열에서 이미지 추가
    - ☑️ 워드에서 파일로 이미지 저장
    - ☑️ 이미지 자르기 및 투명도 설정
    - ☑️ 이미지 위치 지정 및 위치 정보 조회
    - ◼️ 기타 위치 유형
- ☑️ 하이퍼링크
    - ☑️ 하이퍼링크 추가
    - ☑️ 하이퍼링크 읽기
    - ☑️ 하이퍼링크 제거
    - ☑️ 하이퍼링크 변경
- ☑️ 페이지 나누기
    - ☑️ 페이지 나누기 추가
    - ☑️ 페이지 나누기 읽기
    - ☑️ 페이지 나누기 제거
    - ☑️ 페이지 나누기 변경
- ☑️ 페이지 번호 매기기
    - ☑️ 머리글 또는 바닥글에 페이지 번호 삽입
    - ☑️ `WordPageNumberStyle`로 스타일 선택
- ☑️ 책갈피
    - ☑️ 책갈피 추가
    - ☑️ 책갈피 읽기
    - ☑️ 책갈피 제거
    - ☑️ 책갈피 변경
- ☑️ 텍스트 찾기 및 바꾸기
  - ☑️ 주석
      - ☑️ 주석 추가
      - ☑️ 주석 읽기
      - ☑️ 주석 제거(단일 또는 전체)
      - ☑️ 주석 추적
      - ☑️ 스레드형 답글
- ☑️ 필드
    - ☑️ 필드 추가
    - ☑️ 필드 읽기
    - ☑️ 필드 제거
    - ☑️ 필드 변경
- ☑️ 각주
    - ☑️ 새 각주 추가
    - ☑️ 각주 읽기
    - ☑️ 각주 제거
- ☑️ 미주
    - ☑️ 새 미주 추가
    - ☑️ 미주 읽기
    - ☑️ 미주 제거
- ☑️ 문서 변수
    - ☑️ 문서 내 저장된 변수 설정 및 읽기
    - ☑️ 이름 또는 인덱스로 변수 제거
- ☑️ 매크로
    - ☑️ VBA 프로젝트 추가 또는 추출
    - ☑️ 매크로 모듈 제거
- ☑️ 메일 병합
    - ☑️ `MERGEFIELD` 값 교체
    - ☑️ 선택적으로 필드 코드 유지
- ☑️ 콘텐츠 컨트롤
    - ☑️ 컨트롤 추가
    - ☑️ 컨트롤 읽기
    - ☑️ 컨트롤 텍스트 업데이트
    - ☑️ 컨트롤 제거
    - ☑️ 체크박스 폼 컨트롤
    - ☑️ 날짜 선택기 폼 컨트롤
    - ☑️ 드롭다운 목록 폼 컨트롤
    - ☑️ 콤보박스 폼 컨트롤
    - ☑️ 그림 폼 컨트롤
    - ☑️ 반복 섹션 폼 컨트롤
- ☑️ 도형
    - ☑️ 사각형 추가
    - ☑️ 타원 추가
    - ☑️ 선 추가
    - ☑️ 다각형 추가
    - ☑️ 채우기 및 스트로크 색 설정
    - ☑️ 도형 제거
- ☑️ 차트
    - ☑️ 차트 추가
        - ☑️ 파이 및 파이 3D
        - ☑️ 막대 및 막대 3D
        - ☑️ 선 및 선 3D
        - ☑️ 콤보 (막대 + 선)
        - ☑️ 영역 및 영역 3D
        - ☑️ 산점도
        - ☑️ 레이더
    - ☑️ 카테고리 및 범례 추가
    - ☑️ 축 구성
    - ☑️ 여러 시리즈 추가
    - ⚠️ 막대와 선 시리즈를 혼합할 때는 `AddChartAxisX`를 데이터를 추가하기 전에 호출하여 두 차트 유형이 동일한 카테고리 축을 공유하도록 해야 합니다.
- ☑️ 수식
    - ☑️ OMML에서 오피스 수식 삽입
    - ☑️ 필요 시 수식 제거
- ☑️ 목록
    - ☑️ 목록 추가
    - ☑️ 목록 제거
    - ☑️ 번호 매기기 설정을 유지하면서 목록 복제
    - ☑️ 그림 글머리 기호 목록 추가
    - ☑️ 사용자 정의 글머리 기호 및 번호 매기기 목록 생성
    - ☑️ 기존 단락에서 목록 스타일 감지
- ☑️ 목차
    - ☑️ 목차 추가
    - ☑️ 열기 시 목차 필드 업데이트
- ☑️ 테두리
    - ☑️ 내장 스타일 또는 사용자 정의 설정
    - ☑️ 크기, 색상, 스타일 및 간격 변경
- ☑️ 배경
    - ☑️ 배경 색상 설정
- ☑️ 워터마크
    - ☑️ 텍스트 또는 이미지 워터마크 추가
    - ☑️ `WordWatermarkStyle`을 통해 텍스트 또는 이미지 스타일 선택
    - ☑️ 회전, 너비 및 높이 설정
    - ☑️ 워터마크 제거

- ☑️ 표지 페이지
    - ☑️ 내장 표지 페이지 추가

- ☑️ 글꼴
    - ☑️ `WordDocument.EmbedFont`를 통한 글꼴 포함

- ☑️ 내장 콘텐츠
    - ☑️ 내장 문서 추가 (RTF, HTML, TXT)
    - ☑️ HTML 조각 추가
    - ☑️ 단락 뒤에 HTML 조각 삽입
    - ☑️ 텍스트를 HTML 조각으로 대체
    - ☑️ 내장 문서 제거
    - ☑️ 사용자 정의 아이콘과 크기로 객체 포함
 - ☑️ [디지털 서명 및 문서 보안](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.DigitalSignature.cs)
 - ☑️ [문서 보호 옵션](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Settings.cs) (최종 문서, 읽기 전용 권장, 읽기 전용 강제)
 - ☑️ [수정 내용 수락/거부](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Revisions.cs)
 - ☑️ [비동기 저장/로드 API](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Async.cs)
 - ☑️ [여러 문서 병합](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.MergeDocuments.cs)
 - ☑️ [위치 지정 옵션이 있는 텍스트 상자](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.TextBox.cs)
 - ☑️ [페이지 방향, 페이지 크기 및 여백 사전 설정](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.PageSettings.cs) ([여백](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Sections.cs))
 - ☑️ [탭 문자 및 사용자 정의 탭 정지](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.TabStops.cs)
 - ☑️ [문서 검증 유틸리티](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Validation.cs)
 - ☑️ [CleanupDocument 메서드](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.Cleanup.cs) 동일한 런 병합
 - ☑️ [단락 XML 직렬화](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Examples/Word/XmlSerialization/XmlSerialization.Basic.cs)
 - ☑️ [측정 단위 변환 도우미](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/OfficeIMO.Tests/Word.HelpersConversions.cs)

- ☑️ 실험적 Excel 컴포넌트
    - ☑️ 통합 문서 생성 및 로드
    - ☑️ 워크시트 추가
    - ☑️ 비동기 저장 및 로드 API


## 기능 (한줄 요약):

이 기능 목록은 전체 기능을 다루기보다는 빠르게 무언가를 수정하고자 할 때 유용합니다.
이 기능들은 `WordHelpers` 클래스의 일부로 제공됩니다.

- ☑️ 파일에서 머리글과 바닥글 제거
- ☑️ DOTX 템플릿을 DOCX로 변환

## 예제

### 기본 문서: 몇 가지 문서 속성과 단락 포함

이 짧은 예제는 텍스트 한 단락과 몇 가지 문서 속성만 포함하는 워드 문서 생성 방법을 보여줍니다.


```csharp
string filePath = System.IO.Path.Combine(
    "Support",
    "GitHub",
    "PSWriteOffice",
    "Examples",
    "Documents",
    "BasicDocument.docx");

using (WordDocument document = WordDocument.Create(filePath)) {
    document.BuiltinDocumentProperties.Title = "This is my title";
    document.BuiltinDocumentProperties.Creator = "Przemysław Kłys";
    document.BuiltinDocumentProperties.Keywords = "word, docx, test";

    var paragraph = document.AddParagraph("Basic paragraph");
    paragraph.ParagraphAlignment = JustificationValues.Center;
    paragraph.Color = SixLabors.ImageSharp.Color.Red;

document.Save(true);
}
```

### 스트림에서 직접 문서 생성하기

이 오버로드는 문서를 완전히 메모리 내에서 또는 제공된 스트림에서 생성할 수 있게 합니다.

```csharp
using var stream = new MemoryStream();
using (var document = WordDocument.Create(stream)) {
    document.AddParagraph("Stream based document");
    document.Save(stream);
}
stream.Position = 0;
using (var loaded = WordDocument.Load(stream)) {
    Console.WriteLine(loaded.Paragraphs[0].Text);
}
```
### 새 문서로 저장하기

`SaveAs`는 현재 문서를 새 경로로 복제하고 원래 `FilePath`를 변경하지 않은 채 새 `WordDocument` 인스턴스를 반환합니다.


```csharp
using (WordDocument document = WordDocument.Create()) {
    document.AddParagraph("Some text");
    using var copy = document.SaveAs(filePath);
    // document.FilePath is still null
    // copy.FilePath equals filePath
}
```

### 바이트 배열 및 스트림에 저장하기

`SaveAsByteArray` 및 `SaveAsMemoryStream`은 모든 것을 메모리에 저장할 수 있게 해줍니다. `SaveAs(Stream)`은 문서를 제공된 스트림에 복제하고, 해당 스트림에서 로드된 새 인스턴스를 반환합니다.

```csharp
using (WordDocument document = WordDocument.Create()) {
    document.AddParagraph("In memory");
    byte[] data = document.SaveAsByteArray();
    using MemoryStream stream = document.SaveAsMemoryStream();
    using var clone = document.SaveAs(stream);
}
```
### 글꼴 포함하기

`EmbedFont`는 TrueType 또는 OpenType 글꼴 파일을 문서에 추가하여 어떤 기기에서든 사용할 수 있게 합니다.


```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("This document uses an embedded font.");
    document.Save();
}
```

`EmbedFont`에는 단락 스타일을 자동으로 등록할 수 있는 오버로드가 있습니다:

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath, "DejaVuStyle", "DejaVu Style");
    document.AddParagraph("Styled paragraph").SetStyleId("DejaVuStyle");
    document.Save();
}
```

### 내장 글꼴과 포함된 글꼴 혼합하기

글꼴을 포함한 후에는 표준 글꼴과 함께 이름으로 참조할 수 있습니다.

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("Builtin Arial").SetFontFamily("Arial");
    document.AddParagraph("Embedded DejaVu Sans").SetFontFamily("DejaVu Sans");
    var mixed = document.AddParagraph("Mix: ");
    mixed.AddText("Arial, ").SetFontFamily("Arial");
    mixed.AddText("DejaVu").SetFontFamily("DejaVu Sans");
    document.Save();
}
```
내장 폰트를 사용하는 단락 스타일을 만들 수도 있습니다.


```csharp
var style = new Style { Type = StyleValues.Paragraph, StyleId = "EmbeddedStyle" };
style.Append(new StyleName { Val = "EmbeddedStyle" });
style.Append(new StyleRunProperties(new RunFonts { Ascii = "DejaVu Sans" }));
WordParagraphStyle.RegisterCustomStyle("EmbeddedStyle", style);

using (WordDocument document = WordDocument.Create(filePath)) {
    document.EmbedFont(fontPath);
    document.AddParagraph("Paragraph with embedded style").SetStyleId("EmbeddedStyle");
    document.AddParagraph("Built-in style example").Style = WordParagraphStyles.Normal;
    document.Save();
}
```

### 머리글/바닥글이 있는 기본 문서 (첫 번째, 홀수, 짝수)

이 짧은 예제는 Word 문서에 머리글과 바닥글을 추가하는 방법을 보여줍니다.

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.Sections[0].PageOrientation = PageOrientationValues.Landscape;
    document.AddParagraph("Test Section0");
    document.AddHeadersAndFooters();
    document.DifferentFirstPage = true;
    document.DifferentOddAndEvenPages = true;

    document.Sections[0].Header.First.AddParagraph().SetText("Test Section 0 - First Header");
    document.Sections[0].Header.Default.AddParagraph().SetText("Test Section 0 - Header");
    document.Sections[0].Header.Even.AddParagraph().SetText("Test Section 0 - Even");

    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();

    var section1 = document.AddSection();
    section1.PageOrientation = PageOrientationValues.Portrait;
    section1.AddParagraph("Test Section1");
    section1.AddHeadersAndFooters();
    section1.Header.Default.AddParagraph().SetText("Test Section 1 - Header");
    section1.DifferentFirstPage = true;
    section1.Header.First.AddParagraph().SetText("Test Section 1 - First Header");

    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();
    document.AddPageBreak();

    var section2 = document.AddSection();
    section2.AddParagraph("Test Section2");
    section2.PageOrientation = PageOrientationValues.Landscape;
    section2.AddHeadersAndFooters();
    section2.Header.Default.AddParagraph().SetText("Test Section 2 - Header");

    document.AddParagraph("Test Section2 - Paragraph 1");

    var section3 = document.AddSection();
    section3.AddParagraph("Test Section3");
    section3.AddHeadersAndFooters();
    section3.Header.Default.AddParagraph().SetText("Test Section 3 - Header");

    Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Paragraphs[0].Text);
    Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 1: " + document.Sections[2].Paragraphs[1].Text);
    Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Paragraphs[0].Text);

    Console.WriteLine("Section 0 - Text 0: " + document.Sections[0].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 1 - Text 0: " + document.Sections[1].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 2 - Text 0: " + document.Sections[2].Header.Default.Paragraphs[0].Text);
    Console.WriteLine("Section 3 - Text 0: " + document.Sections[3].Header.Default.Paragraphs[0].Text);
    document.Save(true);
}
```

### 콘텐츠 컨트롤 추가하기

이 예제는 간단한 콘텐츠 컨트롤을 추가하고 업데이트한 다음 태그로 검색하는 방법을 보여줍니다.

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    var sdt = document.AddStructuredDocumentTag("Hello", "MyAlias", "MyTag");
    sdt.Text = "Changed";
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    var tag = document.GetStructuredDocumentTagByTag("MyTag");
Console.WriteLine(tag.Text);
}
```

### 다중 콘텐츠 컨트롤

```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.AddStructuredDocumentTag("First", "Alias1", "Tag1");
    document.AddStructuredDocumentTag("Second", "Alias2", "Tag2");
    document.AddStructuredDocumentTag("Third", "Alias3", "Tag3");
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    foreach (var control in document.StructuredDocumentTags) {
        Console.WriteLine(control.Tag + ": " + control.Text);
    }
}
```
### 고급 콘텐츠 제어 사용법


```csharp
using (WordDocument document = WordDocument.Create(filePath)) {
    document.AddStructuredDocumentTag("First", "Alias1", "Tag1");
    document.AddStructuredDocumentTag("Second", "Alias2", "Tag2");
    document.Save(true);
}

using (WordDocument document = WordDocument.Load(filePath)) {
    var alias = document.GetStructuredDocumentTagByAlias("Alias2");
    alias.Text = "Updated";
    var tag = document.GetStructuredDocumentTagByTag("Tag1");
    Console.WriteLine(tag.Text);
}
```
### OfficeIMO의 고급 사용법

이 짧은 예제는 `OfficeIMO.Word`의 여러 기능을 보여줍니다.


```csharp
string filePath = System.IO.Path.Combine(folderPath, "AdvancedDocument.docx");
using (WordDocument document = WordDocument.Create(filePath)) {
    // lets add some properties to the document
    document.BuiltinDocumentProperties.Title = "Cover Page Templates";
    document.BuiltinDocumentProperties.Subject = "How to use Cover Pages with TOC";
    document.ApplicationProperties.Company = "Evotec Services";

    // we force document to update fields on open, this will be used by TOC
    document.Settings.UpdateFieldsOnOpen = true;

    // lets add one of multiple added Cover Pages
    document.AddCoverPage(CoverPageTemplate.IonDark);

    // lets add Table of Content (1 of 2)
    document.AddTableOfContent(TableOfContentStyle.Template1);

    // lets add page break
    document.AddPageBreak();

    // lets create a list that will be binded to TOC
    var wordListToc = document.AddTableOfContentList(WordListStyle.Headings111);

    wordListToc.AddItem("How to add a table to document?");

    document.AddParagraph("In the first paragraph I would like to show you how to add a table to the document using one of the 105 built-in styles:");

    // adding a table and modifying content
    var table = document.AddTable(5, 4, WordTableStyle.GridTable5DarkAccent5);
    table.Rows[3].Cells[2].Paragraphs[0].Text = "Adding text to cell";
    table.Rows[3].Cells[2].Paragraphs[0].Color = Color.Blue; ;
    table.Rows[3].Cells[3].Paragraphs[0].Text = "Different cell";

    document.AddParagraph("As you can see adding a table with some style, and adding content to it ").SetBold().SetUnderline(UnderlineValues.Dotted).AddText("is not really complicated").SetColor(Color.OrangeRed);

    wordListToc.AddItem("How to add a list to document?");

    var paragraph = document.AddParagraph("Adding lists is similar to ading a table. Just define a list and add list items to it. ").SetText("Remember that you can add anything between list items! ");
    paragraph.SetColor(Color.Blue).SetText("For example TOC List is just another list, but defining a specific style.");

    var list = document.AddList(WordListStyle.Bulleted);
    list.AddItem("First element of list", 0);
    list.AddItem("Second element of list", 1);

    var paragraphWithHyperlink = document.AddHyperLink("Go to Evotec Blogs", new Uri("https://evotec.xyz"), true, "URL with tooltip");
    // you can also change the hyperlink text, uri later on using properties
    paragraphWithHyperlink.Hyperlink.Uri = new Uri("https://evotec.xyz/hub");
    paragraphWithHyperlink.ParagraphAlignment = JustificationValues.Center;

    list.AddItem("3rd element of list, but added after hyperlink", 0);
    list.AddItem("4th element with hyperlink ").AddHyperLink("included.", new Uri("https://evotec.xyz/hub"), addStyle: true);

    document.AddParagraph();

    // create a custom bullet list
    var custom = document.AddCustomBulletList(WordListLevelKind.BulletSquareSymbol, "Courier New", SixLabors.ImageSharp.Color.Red, fontSize: 16);
    custom.AddItem("Custom bullet item");

    // create a list using an image as the bullet
    var pictureList = document.AddPictureBulletList(Path.Combine(folderPath, "Images", "Kulek.jpg"));
    pictureList.AddItem("Image bullet 1");
    pictureList.AddItem("Image bullet 2");

    // create a multi-level custom list
    var builder = document.AddCustomList()
        .AddListLevel(1, WordListLevelKind.BulletSquareSymbol, "Courier New", SixLabors.ImageSharp.Color.Red, fontSize: 14)
        .AddListLevel(5, WordListLevelKind.BulletBlackCircle, "Arial", colorHex: "#00ff00", fontSize: 10);
    builder.AddItem("First");
    builder.AddItem("Fifth", 4);

    // Note: use AddCustomList() rather than AddList(WordListStyle.Custom)
    // when you want to build lists with your own levels.
    // See [Custom Lists](https://raw.githubusercontent.com/EvotecIT/OfficeIMO/master/Docs/custom-lists.md) for details on configuring levels.

    var listNumbered = document.AddList(WordListStyle.Heading1ai);
    listNumbered.AddItem("Different list number 1");
    listNumbered.AddItem("Different list number 2", 1);
    listNumbered.AddItem("Different list number 3", 1);
    listNumbered.AddItem("Different list number 4", 1);

    var section = document.AddSection();
    section.PageOrientation = PageOrientationValues.Landscape;
    section.PageSettings.PageSize = WordPageSize.A4;

    wordListToc.AddItem("Adding headers / footers");

    // lets add headers and footers
    document.AddHeadersAndFooters();

    // adding text to default header
    document.Header.Default.AddParagraph("Text added to header - Default");

    var section1 = document.AddSection();
    section1.PageOrientation = PageOrientationValues.Portrait;
    section1.PageSettings.PageSize = WordPageSize.A5;

    wordListToc.AddItem("Adding custom properties to document");

    document.CustomDocumentProperties.Add("TestProperty", new WordCustomProperty { Value = DateTime.Today });
    document.CustomDocumentProperties.Add("MyName", new WordCustomProperty("Some text"));
    document.CustomDocumentProperties.Add("IsTodayGreatDay", new WordCustomProperty(true));

    // document variables available via DocVariable fields
    document.SetDocumentVariable("Project", "OfficeIMO");
    document.SetDocumentVariable("Year", DateTime.Now.Year.ToString());

    if (document.HasDocumentVariables) {
        foreach (var pair in document.DocumentVariables) {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }
    }

    document.Save(openWord);
}
```

## 테스트

`OfficeIMO.Word`가 단위 테스트를 사용하는 것 외에도, [특성화 테스트](https://en.wikipedia.org/wiki/Characterization_test)도 사용됩니다.
특성화 테스트는 동작을 깨뜨리는 변경을 간과하지 않기 위해 추가되었습니다. 이 테스트들은 [Verify](https://github.com/VerifyTests/Verify) ([".NET에서 Verify를 이용한 스냅샷 테스트"](https://youtu.be/wA7oJDyvn4c))를 기반으로 합니다.
검증된 스냅샷을 추가하거나 업데이트해야 하는 경우, powershell 스크립트를 사용할 수 있습니다:
```bash
$ pwsh -c ./Build/ApproveVerifyTests.ps1
```
Verify 테스트가 실패할 때 콘솔 출력 대신 그래픽 차이점을 표시하려면,
테스트를 실행하기 전에 환경 변수 `DiffEngine_Disabled=false`를 설정하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-06

---