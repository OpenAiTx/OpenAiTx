# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## .NET Aspire란 무엇인가요?

.NET Aspire는 관찰 가능하고, 프로덕션 준비가 된 분산 애플리케이션을 빌드하기 위한 클라우드 준비가 완료된 견해 지향 스택입니다. .NET Aspire는 특정 클라우드 네이티브 문제를 처리하는 NuGet 패키지 모음으로 제공됩니다. 클라우드 네이티브 앱은 종종 단일 모놀리식 코드 베이스가 아닌, 작고 상호 연결된 조각들 또는 마이크로서비스로 구성됩니다. 클라우드 네이티브 앱은 일반적으로 데이터베이스, 메시징, 캐싱 등 다양한 서비스를 많이 사용합니다.

.NET Aspire가 제공하는 기능:

[오케스트레이션](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration): .NET Aspire는 다중 프로젝트 애플리케이션과 그 종속성을 실행하고 연결하는 기능을 제공합니다.

[통합](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations): .NET Aspire 통합은 Redis나 Postgres와 같은 일반적으로 사용되는 서비스에 대한 NuGet 패키지로, 표준화된 인터페이스를 통해 앱과 일관되고 원활하게 연결됩니다.

[도구 지원](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling): .NET Aspire는 Visual Studio 및 dotnet CLI용 프로젝트 템플릿과 도구 경험을 제공하여 .NET Aspire 앱을 생성하고 상호 작용할 수 있도록 도와줍니다.

자세한 내용을 알아보려면 전체 [.NET Aspire 개요 및 문서](https://learn.microsoft.com/dotnet/aspire/)를 읽어보세요. 샘플은 [.NET Aspire 샘플 저장소](https://github.com/dotnet/aspire-samples)에서 확인할 수 있습니다. [eShop 샘플은 여기](https://github.com/dotnet/eshop), [Azure 버전은 여기](https://github.com/Azure-Samples/eShopOnAzure)에서 찾을 수 있습니다.

## 이 저장소에는 무엇이 들어있나요?

.NET Aspire 애플리케이션 호스트, 대시보드, 서비스 디스커버리 인프라, 그리고 모든 .NET Aspire 통합 기능이 포함되어 있습니다. 또한 프로젝트 템플릿도 포함되어 있습니다.

## 최신 데일리 빌드 사용하기

.NET Aspire의 최신 데일리 빌드를 사용하려면 [docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md)의 지침을 따르세요.

## 어떻게 기여할 수 있나요?

기여를 환영합니다! 전 세계 수많은 사람들이 .NET을 더 좋게 만드는 데 기여해왔습니다.

저장소의 코드를 작업하려면 [docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md)의 지침을 따르세요.

## 보안 이슈 및 버그 신고

보안 이슈 및 버그는 Microsoft Security Response Center (MSRC) <secure@microsoft.com>로 이메일을 통해 비공개로 신고해야 합니다. 24시간 이내에 답변을 받아야 합니다. 만약 답변을 받지 못했다면, 원래 메시지를 잘 받았는지 확인하기 위해 다시 이메일을 보내주시기 바랍니다. MSRC PGP 키를 포함한 추가 정보는 [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue)에서 확인할 수 있습니다. 이 지침은 이 저장소의 [보안 문서](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md)에서도 확인할 수 있습니다.

또한 관련된 [Microsoft .NET Core 및 ASP.NET Core Bug Bounty Program](https://www.microsoft.com/msrc/bounty-dot-net-core)에 대한 정보도 참고하세요.

### .NET Aspire 리소스 및 클라이언트 통합에서 사용되는 컨테이너에 대한 참고 사항

.NET 팀은 API 지원을 제공하는 타사 컨테이너의 특정 고객 요구 사항에 대한 적합성을 평가할 수 없습니다.

Aspire와 함께 구성 및 자동화할 컨테이너를 선택할 때, 해당 컨테이너가 본인, 고용주 또는 정부의 보안 및 안전 요구 사항, 암호화 규정, 기타 규제 또는 기업 표준을 충족하는지 직접 평가해야 합니다.

## .NET Foundation

.NET Aspire는 [.NET Foundation](https://www.dotnetfoundation.org/projects) 프로젝트입니다.

GitHub에는 많은 .NET 관련 프로젝트가 있습니다.

* [.NET home repo](https://github.com/Microsoft/dotnet) - Microsoft와 커뮤니티에서 제공하는 수백 개의 .NET 프로젝트에 대한 링크를 제공합니다.
* [ASP.NET Core home](https://docs.microsoft.com/aspnet/core) - ASP.NET Core를 학습하기에 가장 좋은 시작점입니다.

이 프로젝트는 커뮤니티 내에서 기대되는 행동을 명확히 하기 위해 [Contributor Covenant](https://contributor-covenant.org)에서 정의한 행동 강령을 채택했습니다. 자세한 내용은 [.NET Foundation 행동 강령](https://www.dotnetfoundation.org/code-of-conduct)을 참고하세요.

## 라이선스

이 저장소의 코드는 [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT) 라이선스로 라이선스가 부여되어 있습니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---