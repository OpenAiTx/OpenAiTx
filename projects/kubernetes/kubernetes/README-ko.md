# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes(쿠버네티스), 또는 K8s로도 알려진 이 시스템은 여러 호스트에 걸쳐 [컨테이너화된 애플리케이션]을 관리하기 위한 오픈 소스 시스템입니다. 애플리케이션의 배포, 유지 관리, 확장에 대한 기본 메커니즘을 제공합니다.

Kubernetes는 Google이 대규모 프로덕션 워크로드를 운영하기 위해 사용한 [Borg]라는 시스템에서 15년에 걸친 경험을 기반으로 하며, 커뮤니티의 최고 수준의 아이디어와 관행을 결합하여 만들어졌습니다.

Kubernetes는 Cloud Native Computing Foundation([CNCF])이 주관합니다. 귀사의 기술이 컨테이너 패키징, 동적 스케줄링, 마이크로서비스 지향 기술의 발전에 기여하길 원한다면 CNCF에 참여하는 것을 고려해 보세요. 누가 참여하고 있으며 Kubernetes가 어떤 역할을 하는지에 대한 자세한 내용은 CNCF [공식 발표문]을 참고하세요.

----

## K8s 사용 시작하기

[kubernetes.io]의 문서를 참고하세요.

[Scalable Microservices with Kubernetes]에서 무료 강의를 수강할 수 있습니다.

다른 애플리케이션에서 Kubernetes 코드를 라이브러리로 사용하려면 [공개된 컴포넌트 목록](https://git.k8s.io/kubernetes/staging/README.md)을 참조하세요.  
`k8s.io/kubernetes` 모듈이나 `k8s.io/kubernetes/...` 패키지를 라이브러리로 사용하는 것은 지원되지 않습니다.

## K8s 개발 시작하기

[커뮤니티 저장소]에는 소스에서 Kubernetes를 빌드하는 방법, 코드 및 문서 기여 방법, 담당자 연락처 등 모든 정보가 있습니다.

바로 Kubernetes를 빌드하려면 두 가지 옵션이 있습니다:

##### [Go 환경]이 준비된 경우

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### [Docker 환경]이 준비된 경우

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

전체 과정은 [개발자 문서]를 참고하세요.

## 지원

지원이 필요하면 먼저 [문제 해결 가이드]를 참고하고, 안내된 절차를 따라 진행하세요.

질문이 있으시면 언제든 [커뮤니케이션 채널][communication]을 통해 문의하실 수 있습니다.

[announcement]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[communication]: https://git.k8s.io/community/communication
[community repository]: https://git.k8s.io/community
[containerized applications]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[developer's documentation]: https://git.k8s.io/community/contributors/devel#readme
[Docker environment]: https://docs.docker.com/engine
[Go environment]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Scalable Microservices with Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[troubleshooting guide]: https://kubernetes.io/docs/tasks/debug/

## 커뮤니티 미팅

[캘린더](https://www.kubernetes.dev/resources/calendar/)에서 Kubernetes 커뮤니티의 모든 미팅 일정을 한 곳에서 확인할 수 있습니다.

## 도입 사례

[사용자 사례 연구](https://kubernetes.io/case-studies/) 웹사이트에서는 다양한 산업 분야에서 Kubernetes를 도입/이관하는 조직의 실제 사례를 확인할 수 있습니다.

## 거버넌스

Kubernetes 프로젝트는 우리의 커뮤니티와 이해관계자들이 공동의 목표를 향해 나아갈 수 있도록 원칙, 가치, 정책, 프로세스의 체계를 기반으로 운영됩니다.

[Kubernetes 커뮤니티](https://github.com/kubernetes/community/blob/master/governance.md)는 우리의 조직 구성 방식을 배우는 출발점입니다.

[Kubernetes Steering 커뮤니티 저장소](https://github.com/kubernetes/steering)는 Kubernetes 프로젝트의 거버넌스를 감독하는 Steering Committee에서 사용합니다.

## 로드맵

[Kubernetes Enhancements 저장소](https://github.com/kubernetes/enhancements)는 Kubernetes 릴리스 정보, 기능 추적 및 백로그 정보를 제공합니다.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---