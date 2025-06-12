![Envoy 로고](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[클라우드 네이티브 고성능 엣지/미들/서비스 프록시](https://www.envoyproxy.io/)

Envoy는 [Cloud Native Computing Foundation](https://cncf.io) (CNCF)에서 호스팅합니다. 컨테이너 패키징, 동적 스케줄링, 마이크로서비스 지향 기술의 발전에 기여하고자 하는 기업이라면 CNCF 가입을 고려해보세요. 누가 참여하고 있는지, Envoy가 어떤 역할을 하는지에 대한 자세한 내용은 CNCF
[공식 발표문](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/)을 참고하세요.

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## 문서

* [공식 문서](https://www.envoyproxy.io/)
* [FAQ](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [예제 문서](https://github.com/envoyproxy/examples/)
* 스레딩 모델에 관한 [블로그](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310)
* 핫 리스타트에 관한 [블로그](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5)
* 통계 아키텍처에 관한 [블로그](https://medium.com/@mattklein123/envoy-stats-b65c7f363342)
* 범용 데이터 플레인 API에 관한 [블로그](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a)
* Lyft의 Envoy 대시보드에 관한 [블로그](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1)

## 관련

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): v2 API 정의의 독립 저장소. 이는 [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/)의 읽기 전용 미러입니다.
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): 성능 테스트 프레임워크.
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): 새로운 필터 추가 및 메인 저장소와 연결하는 예제.

## 연락처

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): 공지사항만 이메일로 발송하는 저빈도 메일링 리스트.
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): 보안 관련 공지사항만 이메일로 발송하는 저빈도 메일링 리스트.
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): 일반 사용자 토론.
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): Envoy 개발자 토론(APIs, 기능 설계 등).
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): 모든 핵심 Envoy 유지보수자에게 연락할 때 이 리스트를 사용하세요.
* [Twitter](https://twitter.com/EnvoyProxy/): 트위터에서 팔로우하세요!
* [Slack](https://envoyproxy.slack.com/): Slack 초대를 받으려면 [여기](https://communityinviter.com/apps/envoyproxy/envoy)를 클릭하세요.
  * 참고: Slack에서 사용자 질문에 대한 응답은 최선을 다해 제공됩니다. "보장된" 응답을 원하신다면 아래 링크된 스레드의 안내에 따라 envoy-users@로 이메일을 보내시기 바랍니다.

이메일 리스트 사용에 관한 정보는 [이](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) 이메일 스레드를 참고하세요.

## 기여

Envoy에 기여하는 것은 재미있고, 최신 C++은 경험이 없더라도 생각보다 덜 어렵습니다. 시작하려면:

* [기여 가이드](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [초보자 이슈](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [도커를 이용한 빌드/테스트 빠른 시작](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [개발자 가이드](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* 개발 프로세스(특히 코드 리뷰 관련 자동화)에 도움이 되는 Envoy [개발 지원 툴체인](https://github.com/envoyproxy/envoy/blob/main/support/README.md) 설치를 고려해보세요.
* 이슈를 작업 중인 경우 반드시 알려주세요. 중복 작업을 방지할 수 있습니다!

## 커뮤니티 미팅

Envoy 팀은 매월 두 번 화요일 오전 9시(PT)에 정기 미팅을 진행합니다. 공개 Google 캘린더는 [여기](https://goo.gl/PkDijT)에서 확인할 수 있습니다. 미팅은 [회의록](https://goo.gl/5Cergb)에 안건이 있는 경우에만 진행됩니다. 커뮤니티의 누구나 회의록에 안건을 추가하여 제안할 수 있습니다. 유지보수자는 안건 추가를 확인하거나, 확정된 안건이 없을 경우 예정된 날짜 24시간 전에 미팅을 취소합니다.

## 보안

### 보안 감사

Envoy 보안에 초점을 둔 여러 서드파티 감사가 진행되었습니다:
* 2018년 Cure53에서 보안 감사를 수행하였으며, [전체 보고서](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf)를 참고하세요.
* 2021년 Ada Logics에서 퍼징 인프라에 대한 감사를 진행하고 개선 권고를 하였으며, [전체 보고서](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf)를 참고하세요.

### 보안 취약점 신고

Envoy에서 취약점 또는 잠재적 취약점을 발견하신 경우 [envoy-security](mailto:envoy-security@googlegroups.com)로 알려주세요. 신고를 확인하는 이메일을 보내드리며, 이슈 확인 후 추가 안내를 드립니다.

자세한 내용은 전체 [보안 릴리스 프로세스](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md)를 참고하세요.

### ppc64le 빌드

ppc64le 아키텍처 또는 aws-lc를 사용하는 빌드는 envoy 보안 정책 적용 대상이 아닙니다. ppc64le 아키텍처는 현재 최선의 노력 기반으로 지원되며 Envoy 유지보수자가 관리하지 않습니다.

## 릴리즈

자세한 내용은 [릴리즈 프로세스](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md)를 참고하세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---