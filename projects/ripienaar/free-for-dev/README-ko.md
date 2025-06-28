# free-for.dev

개발자와 오픈 소스 저자들은 이제 무료 티어를 제공하는 다양한 서비스를 이용할 수 있지만, 이 모든 서비스를 찾아보고 정보에 입각한 결정을 내리기 위해서는 시간이 많이 소요됩니다.

이 문서는 소프트웨어(SaaS, PaaS, IaaS 등)와 개발자를 위한 무료 티어를 제공하는 기타 서비스들을 모아놓은 목록입니다.

이 목록의 범위는 인프라 개발자(시스템 관리자, DevOps 실무자 등)가 유용하다고 생각할 만한 것들로 한정됩니다. 모든 무료 서비스를 사랑하지만, 주제에 맞게 유지하는 것이 좋다고 생각합니다. 때로는 경계가 모호할 수 있으나, 이 목록은 주관적입니다. 기여가 반영되지 않더라도 기분 나빠하지 마세요.

이 목록은 1600명 이상의 사람들이 Pull Request, 리뷰, 아이디어 및 작업을 통해 만들어졌습니다. 서비스 추가나 제공이 변경되었거나 중단된 서비스를 제거하고 싶다면 [Pull Requests](https://github.com/ripienaar/free-for-dev)를 보내주시면 됩니다.

[![Track Awesome List](https://www.trackawesomelist.com/badge.svg)](https://www.trackawesomelist.com/ripienaar/free-for-dev)

**참고**: 이 목록은 서비스형 소프트웨어(As-a-Service)만을 위한 것이며, 셀프 호스팅 소프트웨어는 포함하지 않습니다. 자격을 갖추기 위해서는 서비스가 무료 티어를 제공해야 하며, 단순한 무료 체험만으로는 부족합니다. 무료 티어가 기간 제한이 있을 경우 최소 1년 이상이어야 합니다. 또한 무료 티어의 보안 관점도 고려합니다. SSO는 괜찮지만, TLS를 유료 티어에만 제한하는 서비스는 허용하지 않습니다.

# 목차

  * [주요 클라우드 제공업체의 상시 무료 한도](#major-cloud-providers)
  * [클라우드 관리 솔루션](#cloud-management-solutions)
  * [애널리틱스, 이벤트 및 통계](#analytics-events-and-statistics)
  * [API, 데이터, ML](#apis-data-and-ml)
  * [아티팩트 저장소](#artifact-repos)
  * [BaaS](#baas)
  * [로우코드 플랫폼](#low-code-platform)
  * [CDN 및 보호](#cdn-and-protection)
  * [CI 및 CD](#ci-and-cd)
  * [CMS](#cms)
  * [코드 생성](#code-generation)
  * [코드 품질](#code-quality)
  * [코드 검색 및 탐색](#code-search-and-browsing)
  * [크래시 및 예외 처리](#crash-and-exception-handling)
  * [지도 기반 데이터 시각화](#data-visualization-on-maps)
  * [매니지드 데이터 서비스](#managed-data-services)
  * [디자인 및 UI](#design-and-ui)
  * [디자인 영감](#design-inspiration)
  * [개발 블로깅 사이트](#dev-blogging-sites)
  * [DNS](#dns)
  * [도커 관련](#docker-related)
  * [도메인](#domain)
  * [교육 및 경력 개발](#education-and-career-development)
  * [이메일](#email)
  * [기능 토글 관리 플랫폼](#feature-toggles-management-platforms)
  * [폰트](#font)
  * [폼](#forms)
  * [생성형 AI](#generative-ai)
  * [IaaS](#iaas)
  * [IDE 및 코드 편집](#ide-and-code-editing)
  * [국제 모바일 번호 인증 API 및 SDK](#international-mobile-number-verification-api-and-sdk)
  * [이슈 트래킹 및 프로젝트 관리](#issue-tracking-and-project-management)
  * [로그 관리](#log-management)
  * [모바일 앱 배포 및 피드백](#mobile-app-distribution-and-feedback)
  * [관리 시스템](#management-system)
  * [메시징 및 스트리밍](#messaging-and-streaming)
  * [기타](#miscellaneous)
  * [모니터링](#monitoring)
  * [PaaS](#paas)
  * [패키지 빌드 시스템](#package-build-system)
  * [결제 및 청구 통합](#payment-and-billing-integration)
  * [프라이버시 관리](#privacy-management)
  * [스크린샷 API](#screenshot-apis)
  * [Flutter 관련 및 Mac 없이 iOS 앱 빌드](#flutter-related-and-building-ios-apps-without-mac)
  * [검색](#search)
  * [보안 및 PKI](#security-and-pki)
  * [인증, 권한 부여 및 사용자 관리](#authentication-authorization-and-user-management)
  * [소스 코드 저장소](#source-code-repos)
  * [스토리지 및 미디어 처리](#storage-and-media-processing)
  * [터널링, WebRTC, 웹 소켓 서버 및 기타 라우터](#tunneling-webrtc-web-socket-servers-and-other-routers)
  * [테스트](#testing)
  * [팀 및 협업 도구](#tools-for-teams-and-collaboration)
  * [번역 관리](#translation-management)
  * [Vagrant 관련](#vagrant-related)
  * [방문자 세션 녹화](#visitor-session-recording)
  * [웹 호스팅](#web-hosting)
  * [댓글 플랫폼](#commenting-platforms)
  * [브라우저 기반 하드웨어 에뮬레이션](#browser-based-hardware-emulation-written-in-javascript)
  * [원격 데스크톱 도구](#remote-desktop-tools)
  * [게임 개발](#game-development)
  * [기타 무료 리소스](#other-free-resources)

## 주요 클라우드 제공업체

  * [Google Cloud Platform](https://cloud.google.com)
    * App Engine - 하루 28 프론트엔드 인스턴스 시간, 하루 9 백엔드 인스턴스 시간
    * Cloud Firestore - 1GB 저장공간, 하루 50,000 읽기, 20,000 쓰기, 20,000 삭제
    * Compute Engine - 1개의 non-preemptible e2-micro, 30GB HDD, 5GB 스냅샷 저장공간(특정 지역 한정), 북미에서 모든 지역 목적지(중국 및 호주 제외)로 월 1GB 네트워크 송신
    * Cloud Storage - 5GB, 1GB 네트워크 송신
    * Cloud Shell - 웹 기반 리눅스 셸/주요 IDE, 5GB 영구 저장공간. 주당 60시간 제한
    * Cloud Pub/Sub - 월 10GB 메시지
    * Cloud Functions - 월 2백만 번 호출(백그라운드 및 HTTP 호출 포함)
    * Cloud Run - 월 2백만 요청, 360,000 GB-초 메모리, 180,000 vCPU-초 컴퓨트 시간, 북미에서 월 1GB 네트워크 송신
    * Google Kubernetes Engine - 하나의 존 클러스터에 대해 클러스터 관리 비용 없음. 각 사용자 노드는 표준 Compute Engine 가격이 적용됨
    * BigQuery - 월 1TB 쿼리, 매월 10GB 저장공간
    * Cloud Build - 하루 120 빌드-분
    * Cloud Source Repositories - 최대 5명 사용자, 50GB 저장공간, 50GB 송신
    * [Google Colab](https://colab.research.google.com/) - 무료 Jupyter Notebooks 개발 환경
    * [Firebase Studio](https://firebase.studio) Google Firebase Studio(구 Project IDX). Google Cloud에서 실행되는 온라인 VSCode
    * 전체 및 상세 목록 - https://cloud.google.com/free

  * [Amazon Web Services](https://aws.amazon.com)
    * [CloudFront](https://aws.amazon.com/cloudfront/) - 월 1TB 송신 및 월 2백만 함수 호출
    * [CloudWatch](https://aws.amazon.com/cloudwatch/) - 10개 사용자 지정 지표 및 10개 알람
* [CodeBuild](https://aws.amazon.com/codebuild/) - 월 100분 빌드 시간 제공  
* [CodeCommit](https://aws.amazon.com/codecommit/) - 월 5명의 활성 사용자, 50GB 저장 공간, 10,000건 요청  
* [CodePipeline](https://aws.amazon.com/codepipeline/) - 월 1개의 활성 파이프라인  
* [DynamoDB](https://aws.amazon.com/dynamodb/) - 25GB NoSQL DB  
* [EC2](https://aws.amazon.com/ec2/) - t2.micro 또는 t3.micro 인스턴스 월 750시간(12개월), 월 100GB 송신  
* [EBS](https://aws.amazon.com/ebs/) - 일반 목적(SSD) 또는 마그네틱 스토리지 월 30GB(12개월)  
* [Elastic Load Balancing](https://aws.amazon.com/elasticloadbalancing/) - 월 750시간(12개월)  
* [RDS](https://aws.amazon.com/rds/) - db.t2.micro, db.t3.micro, db.t4g.micro 인스턴스 월 750시간, 일반 목적(SSD) 스토리지 20GB, 백업 스토리지 20GB(12개월)  
* [S3](https://aws.amazon.com/s3/) - 스탠다드 오브젝트 스토리지 5GB, Get 요청 2만 건, Put 요청 2천 건(12개월)  
* [Glacier](https://aws.amazon.com/glacier/) - 장기 오브젝트 스토리지 10GB  
* [Lambda](https://aws.amazon.com/lambda/) - 월 100만 건 요청  
* [SNS](https://aws.amazon.com/sns/) - 월 100만 건 발행  
* [SES](https://aws.amazon.com/ses/) - 월 3,000건 메시지(12개월)  
* [SQS](https://aws.amazon.com/sqs/) - 월 100만 건 메시징 큐 요청  
* 전체 상세 목록 - https://aws.amazon.com/free/

* [Microsoft Azure](https://azure.microsoft.com)
  * [Virtual Machines](https://azure.microsoft.com/services/virtual-machines/) - 1 B1S Linux VM, 1 B1S Windows VM (12개월)
  * [App Service](https://azure.microsoft.com/services/app-service/) - 웹, 모바일, API 앱 10개(일일 60 CPU분)
  * [Functions](https://azure.microsoft.com/services/functions/) - 월 100만 건 요청
  * [DevTest Labs](https://azure.microsoft.com/services/devtest-lab/) - 빠르고 간편한 개발-테스트 환경 제공
  * [Active Directory](https://azure.microsoft.com/services/active-directory/) - 500,000 오브젝트
  * [Active Directory B2C](https://azure.microsoft.com/services/active-directory/external-identities/b2c/) - 월 50,000명 저장 사용자
  * [Azure DevOps](https://azure.microsoft.com/services/devops/) - 활성 사용자 5명, 무제한 프라이빗 Git 저장소
  * [Azure Pipelines](https://azure.microsoft.com/services/devops/pipelines/) — 오픈소스용 Linux, macOS, Windows에서 무제한 시간의 무료 병렬 작업 10개
  * [Microsoft IoT Hub](https://azure.microsoft.com/services/iot-hub/) - 일일 8,000건 메시지
  * [Load Balancer](https://azure.microsoft.com/services/load-balancer/) - 무료 퍼블릭 로드밸런스 IP(VIP) 1개
  * [Notification Hubs](https://azure.microsoft.com/services/notification-hubs/) - 100만 건 푸시 알림
  * [Bandwidth](https://azure.microsoft.com/pricing/details/bandwidth/) - 인바운드 15GB(12개월) & 월 5GB 송신
  * [Cosmos DB](https://azure.microsoft.com/services/cosmos-db/) - 25GB 저장소 및 1000 RUs 프로비저닝 처리량
  * [Static Web Apps](https://azure.microsoft.com/pricing/details/app-service/static/) — 무료 SSL, 인증/권한부여, 맞춤 도메인을 포함하여 정적 앱 및 서버리스 함수 빌드, 배포, 호스팅
  * [Storage](https://azure.microsoft.com/services/storage/) - LRS 파일 또는 Blob 스토리지 5GB(12개월)
  * [Cognitive Services](https://azure.microsoft.com/services/cognitive-services/) - AI/ML API(컴퓨터 비전, 번역, 얼굴 감지, 봇 등) 무료 티어(거래 제한 포함)
  * [Cognitive Search](https://azure.microsoft.com/services/search/#features) - AI 기반 검색 및 인덱싱 서비스, 10,000개 문서까지 무료
  * [Azure Kubernetes Service](https://azure.microsoft.com/services/kubernetes-service/) - 관리형 쿠버네티스 서비스, 클러스터 관리 무료
  * [Event Grid](https://azure.microsoft.com/services/event-grid/) - 월 10만 건 작업
  * 전체 상세 목록 - https://azure.microsoft.com/free/

* [Oracle Cloud](https://www.oracle.com/cloud/)
  * Compute
     - 1/8 OCPU 및 1GB 메모리의 AMD 기반 컴퓨트 VM 2대
     - 4개의 Arm 기반 Ampere A1 코어 및 24GB 메모리(1대 VM 또는 최대 4대 VM으로 사용 가능)
     - [비활성으로 간주](https://docs.oracle.com/en-us/iaas/Content/FreeTier/freetier_topic-Always_Free_Resources.htm#compute__idleinstances) 시 인스턴스 회수
  * Block Volume - 2개 볼륨, 총 200GB(컴퓨트용)
  * Object Storage - 10GB
  * Load balancer - 1개 인스턴스, 10Mbps
  * Databases - 2개 DB, 각각 20GB
  * Monitoring - 5억 수집 데이터 포인트, 10억 조회 데이터 포인트
  * Bandwidth - 월 10TB 송신, x64 VM은 50Mbps, ARM VM은 코어당 500Mbps 속도 제한
  * Public IP - VM용 IPv4 2개, 로드 밸런서용 IPv4 1개
  * Notifications - 월 100만 건 전송 옵션, 월 1,000건 이메일 발송
  * 전체 상세 목록 - https://www.oracle.com/cloud/free/

* [IBM Cloud](https://www.ibm.com/cloud/free/)
  * Cloudant 데이터베이스 - 1GB 데이터 저장
  * Db2 데이터베이스 - 100MB 데이터 저장
  * API Connect - 월 50,000건 API 호출
  * 가용성 모니터링 - 월 300만 건 데이터 포인트
  * 로그 분석 - 일일 500MB 로그
  * 전체 상세 목록 - https://www.ibm.com/cloud/free/

* [Cloudflare](https://www.cloudflare.com/)
  * [Application Services](https://www.cloudflare.com/plans/) - 무제한 도메인 무료 DNS, DDoS 방어, CDN 및 무료 SSL, 방화벽 규칙 및 페이지 규칙, WAF, 봇 차단, 무료 무제한 속도 제한(도메인당 1개 규칙), 분석, 이메일 포워딩
  * [Zero Trust & SASE](https://www.cloudflare.com/plans/zero-trust-services/) - 최대 50명 사용자, 24시간 활동 로그, 3개 네트워크 위치
  * [Cloudflare Tunnel](https://www.cloudflare.com/products/tunnel/) - 로컬 HTTP 포트를 trycloudflare.com의 임의 서브도메인으로 노출 가능([Quick Tunnels](https://developers.cloudflare.com/cloudflare-one/connections/connect-networks/do-more-with-tunnels/trycloudflare/) 이용, 계정 불필요). [Zero Trust](https://www.cloudflare.com/products/zero-trust/) 무료 플랜에서 TCP 터널, 로드 밸런싱, VPN 등 추가 기능 제공.
  * [Workers](https://developers.cloudflare.com/workers/) - Cloudflare 글로벌 네트워크에서 서버리스 코드 무료 배포, 일일 10만 건 요청
  * [Workers KV](https://developers.cloudflare.com/kv) - 일일 10만 건 읽기 요청, 1천 건 쓰기 요청, 1천 건 삭제 요청, 1천 건 목록 요청, 1GB 저장 데이터
  * [R2](https://developers.cloudflare.com/r2/) - 월 10GB, 월 100만 건 Class A 작업, 월 1천만 건 Class B 작업
  * [D1](https://developers.cloudflare.com/d1/) - 일일 500만 건 행 읽기, 일일 10만 건 행 쓰기, 1GB 저장소
  * [Pages](https://developers.cloudflare.com/pages/) - Cloudflare의 빠르고 안전한 글로벌 네트워크에서 웹 앱 개발 및 배포. 월 500회 빌드, 100개 커스텀 도메인, 통합 SSL, 무제한 사용자, 무제한 미리보기 배포, Cloudflare Workers 연동을 통한 풀스택 기능
  * [Queues](https://developers.cloudflare.com/queues/) - 월 100만 건 작업
  * [TURN](https://developers.cloudflare.com/calls/turn/) – 월 1TB 무료(아웃바운드) 트래픽

**[⬆️ 맨 위로](#table-of-contents)**

## 클라우드 관리 솔루션

* [Brainboard](https://www.brainboard.co) - 시각적으로 클라우드 인프라를 처음부터 끝까지 협업 구축 및 관리할 수 있는 솔루션
* [Cloud 66](https://www.cloud66.com/) - 개인 프로젝트용 무료(1개 배포 서버, 1개 정적 사이트 포함). Cloud 66은 모든 클라우드에서 서버 관련 걱정 없이 앱을 구축, 배포, 성장시키는 데 필요한 모든 기능 제공
* [Pulumi](https://www.pulumi.com/) — 친숙한 프로그래밍 언어와 도구로 클라우드 인프라를 구축, 배포, 관리할 수 있는 현대적 인프라 코드 플랫폼
* [terraform.io](https://www.terraform.io/) — Terraform Cloud. 최대 500개 리소스의 무료 원격 상태 관리 및 팀 협업
* [scalr.com](https://scalr.com/) - Terraform으로 관리되는 인프라 및 설정의 협업과 자동화를 위한 Terraform Automation and Collaboration(TACO) 제품. 전체 Terraform CLI 지원, OPA 통합, 계층형 구성 모델 제공. SSO 추가 요금 없음. 모든 기능 포함. 월 50회 실행 무료
* [deployment.io](https://deployment.io) - AWS에서 배포 자동화를 지원하는 서비스. 무료 티어에서 개발자(1인 사용자)는 무제한 정적 사이트, 웹 서비스, 환경을 배포 가능. 미리보기와 자동 배포 포함, 월 20회 작업 무료 제공

**[⬆️ 맨 위로](#table-of-contents)**

## 소스 코드 저장소

* [Bitbucket](https://bitbucket.org/) — 최대 5명 사용자에게 무제한 공개/비공개 Git 저장소, CI/CD용 Pipelines 제공
* [chiselapp.com](https://chiselapp.com/) — 무제한 공개/비공개 Fossil 저장소
* [codebasehq.com](https://www.codebasehq.com/) — 1개 무료 프로젝트, 100MB 공간, 2명 사용자
* [Codeberg](https://codeberg.org/) — 무료 및 오픈소스 프로젝트용 무제한 공개/비공개 Git 저장소(무제한 협업자). [Forgejo](https://forgejo.org/) 기반. [Codeberg Pages](https://codeberg.page/)로 정적 웹사이트 호스팅, [Codeberg's CI](https://docs.codeberg.org/ci/)로 CI/CD, [Codeberg Translate](https://translate.codeberg.org/)로 번역 호스팅. 패키지/컨테이너 호스팅, 프로젝트 관리, 이슈 트래킹 포함
* [GitGud](https://gitgud.io) — 무제한 공개/비공개 저장소. 영구 무료. GitLab & Sapphire 기반. CI/CD 미제공
* [GitHub](https://github.com/) — 무제한 공개/비공개 저장소(무제한 협업자). CI/CD, 개발 환경, 정적 호스팅, 패키지/컨테이너 호스팅, 프로젝트 관리, AI Copilot 포함
* [gitlab.com](https://about.gitlab.com/) — 최대 5명 협업자까지 무제한 공개/비공개 Git 저장소. CI/CD, 정적 호스팅, 컨테이너 레지스트리, 프로젝트 관리, 이슈 트래킹 포함
* [framagit.org](https://framagit.org/) — Framasoft의 GitLab 기반 소프트웨어 포지, CI, 정적 페이지, 프로젝트 페이지, 이슈 트래킹 포함
* [heptapod.net](https://foss.heptapod.net/) — GitLab Community Edition의 포크로 Mercurial 지원 제공
* [ionicframework.com](https://ionicframework.com/appflow) - Ionic 애플리케이션 개발을 위한 저장소 및 도구; Ionic 저장소 제공
* [NotABug](https://notabug.org) — 자유 소프트웨어용 Git 기반 무료 코드 협업 플랫폼
* [OSDN](https://osdn.net/) - 오픈소스 소프트웨어 개발자를 위한 무료 서비스, SVN/Git/Mercurial/Bazaar/CVS 저장소 제공
* [Pagure.io](https://pagure.io) — Pagure.io는 FOSS 라이선스 프로젝트를 위한 무료 오픈소스 소프트웨어 코드 협업 플랫폼이며, Git 기반입니다.
* [perforce.com](https://www.perforce.com/products/helix-teamhub) — 1GB 클라우드와 Git, Mercurial, 또는 SVN 저장소를 무료로 제공합니다.
* [pijul.com](https://pijul.com/) - 무제한 무료 오픈소스 분산 버전 관리 시스템입니다. 패치 이론에 기반한 독특한 기능으로 쉽게 배우고, 사용하며, 배포할 수 있습니다. git/hg/svn/darcs의 여러 문제를 해결합니다.
* [plasticscm.com](https://plasticscm.com/) — 개인, 오픈소스, 비영리 단체에 무료 제공
* [projectlocker.com](https://projectlocker.com) — 50MB 공간의 1개 무료 프라이빗 프로젝트(Git 및 Subversion) 제공
* [RocketGit](https://rocketgit.com) — Git 기반 저장소 호스팅. 무제한 공개 및 비공개 저장소 제공.
* [savannah.gnu.org](https://savannah.gnu.org/) - 자유 소프트웨어 프로젝트(특히 GNU 프로젝트)를 위한 협업 소프트웨어 개발 관리 시스템 제공
* [savannah.nongnu.org](https://savannah.nongnu.org/) - 자유 소프트웨어 프로젝트(비-GNU 프로젝트)를 위한 협업 소프트웨어 개발 관리 시스템 제공

**[⬆️ 맨 위로 돌아가기](#table-of-contents)**

## APIs, Data, and ML

* [JSONGrid](https://jsongrid.com) - 복잡한 JSON 데이터를 아름다운 표 형태의 그리드로 시각화, 편집, 필터링할 수 있는 무료 도구. 링크로 JSON 데이터를 저장 및 공유 가능.
* [Zerosheets](https://zerosheets.com) - Google Sheets 스프레드시트를 강력한 API로 변환하여 프로토타입, 웹사이트, 앱 등을 빠르게 개발할 수 있습니다. 월 500회 요청 무료 제공.
* [IP.City](https://ip.city) — 하루 100회 무료 IP 지리 위치 요청 제공
* [Abstract API](https://www.abstractapi.com) — IP 지리 위치, 성별 감지, 이메일 검증 등 다양한 용도의 API 모음.
* [Apify](https://www.apify.com/) — 웹 스크래핑 및 자동화 플랫폼으로, 모든 웹사이트에 대한 API를 만들고 데이터를 추출할 수 있습니다. 준비된 스크래퍼, 통합 프록시, 맞춤형 솔루션 제공. 매월 $5의 플랫폼 크레딧이 포함된 무료 요금제.
* [APITemplate.io](https://apitemplate.io) - 간단한 API 또는 Zapier & Airtable과 같은 자동화 도구로 이미지 및 PDF 문서를 자동 생성. CSS/HTML 필요 없음. 무료 요금제는 월 50개 이미지와 3개 템플릿 제공.
* [APIToolkit.io](https://apitoolkit.io) - API 및 백엔드의 상태를 완전히 이해하는 데 필요한 모든 도구 제공. 자동 API 계약 검증 및 모니터링 지원. 무료 요금제는 일 10,000회 요청까지 서버를 지원.
* [APIVerve](https://apiverve.com) - 120개 이상의 고품질, 일관성, 신뢰성을 갖춘 API를 무료로 즉시 사용할 수 있습니다. 무료 요금제는 월 50개 API 토큰 제공. (2025-06-25 기준 서비스 중단 가능성 있음)
* [Arize AI](https://arize.com/) - 모델 모니터링 및 데이터 품질/성능 드리프트 등 문제의 원인 분석을 위한 머신러닝 가시성 플랫폼. 최대 2개 모델까지 무료 제공.
* [Maxim AI](https://getmaxim.ai/) - AI 에이전트를 시뮬레이션, 평가, 관찰할 수 있는 플랫폼. 에이전트의 신뢰성과 배포 속도를 5배 이상 향상. 인디 개발자 및 소규모 팀(3석)에게 영구 무료 제공.
* [Beeceptor](https://beeceptor.com) - 몇 초 만에 REST API를 모킹, 가짜 API 응답 등 다양한 기능 제공. 하루 50회 무료 요청, 공개 대시보드, 오픈 엔드포인트(대시보드 링크를 가진 누구나 제출 및 응답 확인 가능).
* [BigDataCloud](https://www.bigdatacloud.com/) - IP 지리 위치, 역지오코딩, 네트워킹 인사이트, 이메일/전화 검증, 클라이언트 정보 등 현대 웹을 위한 빠르고 정확하며 무료(무제한 또는 월 1만~5만회) API 제공.
* [Browse AI](https://www.browse.ai) — 웹상의 데이터 추출 및 모니터링. 월 1,000 크레딧 무료(동시 1,000 요청 가능).
* [BrowserCat](https://www.browsercat.com) - 자동화, 스크래핑, AI 에이전트 웹 접근, 이미지/PDF 생성 등을 위한 헤드리스 브라우저 API. 월 1,000회 요청 가능한 무료 요금제.
* [Calendarific](https://calendarific.com) - 200개국 이상의 공휴일 API 서비스. 무료 요금제 월 500회 호출 포함.
* [Canopy](https://www.canopyapi.co/) - Amazon.com 상품, 검색, 카테고리 데이터용 GraphQL API. 무료 요금제 월 100회 호출 제공.
* [Clarifai](https://www.clarifai.com) — 맞춤형 얼굴 인식 및 감지를 위한 이미지 API. AI 모델 학습 가능. 무료 요금제는 월 1,000회 호출 제공.
* [Cloudmersive](https://cloudmersive.com/) — 문서 변환, 바이러스 검사 등 광범위한 API 라이브러리 접근이 가능한 유틸리티 API 플랫폼. 월 600회 호출 무료, 북미 AZ 한정, 최대 파일 크기 2.5MB.
* [Colaboratory](https://colab.research.google.com) — Nvidia Tesla K80 GPU가 포함된 무료 웹 기반 파이썬 노트북 환경.
* [CometML](https://www.comet.com/site/) - 실험 추적, 모델 운영관리, 모델 레지스트리, 전체 데이터 라인리지 등 MLOps 플랫폼. 개인 및 학술용 무료 제공.
* [Commerce Layer](https://commercelayer.io) - 모든 프론트엔드에서 주문을 생성, 처리, 관리할 수 있는 조합형 커머스 API. 개발자 요금제는 월 100건 주문, 1,000개 SKU까지 무료 제공.
* [Composio](https://composio.dev/) - AI 에이전트 및 LLM용 통합 플랫폼. 에이전틱 인터넷에서 200개 이상의 도구 통합.
* [Conversion Tools](https://conversiontools.io/) - 문서, 이미지, 비디오, 오디오, eBook 파일을 위한 온라인 변환기. REST API 제공. Node.js, PHP, Python용 라이브러리 지원. 유료 요금제는 최대 50GB 파일 지원, 무료는 파일 크기(20MB)와 변환 횟수(일 30회, 월 300회) 제한.
* [Country-State-City Microservice API](https://country-state-city.rebuscando.info/) - 국가, 지역, 주, 도시, 우편번호 등 다양한 정보를 제공하는 API 및 마이크로서비스. 무료 요금제는 하루 100회 요청까지 제공.
* [Coupler](https://www.coupler.io/) - 앱 간 동기화가 가능한 데이터 통합 도구. 라이브 대시보드/리포트 생성, 값 변환/조작, 인사이트 백업 가능. 무료 요금제는 1명 사용자, 1개 데이터 연결/소스/목적지로 제한, 수동 데이터 새로고침 필요.
* [CraftMyPDF](https://craftmypdf.com) - 드래그앤드롭 편집기와 간단한 API로 재사용 가능한 템플릿에서 PDF 문서를 자동 생성. 무료 요금제는 월 100개 PDF, 3개 템플릿 제공.
* [Crawlbase](https://crawlbase.com/) — 프록시, 인프라, 브라우저 없이 웹사이트 크롤링 및 스크래핑. 캡차 자동 해결 및 차단 방지. 최초 1,000회 호출 무료.
* [CurlHub](https://curlhub.io) — API 호출 검사 및 디버깅용 프록시 서비스. 무료 요금제는 월 10,000회 요청 제공.
* [CurrencyScoop](https://currencyscoop.com) - 핀테크 앱용 실시간 환율 데이터 API. 월 5,000회 호출 무료 제공.
* [Cube](https://cube.dev/) - 데이터 엔지니어 및 개발자가 최신 데이터 저장소에서 데이터를 추출, 일관된 정의로 구성, 모든 앱에 전달할 수 있도록 지원. Cube Cloud의 무료 요금제는 하루 1,000쿼리로 제한.
* [Data Dead Drop](https://datadeaddrop.com) - 간단하고 무료 파일 공유. 데이터는 접근 후 자멸함. 브라우저 또는 명령줄로 업/다운로드 가능.
* [Data Fetcher](https://datafetcher.com) - Airtable을 코드 없이 어떤 앱이나 API에 연결. API 요청을 실행하는 Postman 스타일 인터페이스 제공, 수십 개 앱과 사전 통합. 무료 요금제는 월 100회 실행.
* [Dataimporter.io](https://www.dataimporter.io) - Salesforce용 데이터 연결, 정제, 가져오기 도구. 무료 요금제는 월 최대 20,000건 레코드 제공.
* [Datalore](https://datalore.jetbrains.com) - Jetbrains의 파이썬 노트북. 월 10GB 저장공간, 120시간 실행시간 제공.
* [Data Miner](https://dataminer.io/) - 웹페이지 데이터를 CSV 또는 엑셀로 추출하는 브라우저 확장(Google Chrome, MS Edge). 무료 요금제는 월 500페이지 제공.
* [Datapane](https://datapane.com) - 파이썬에서 인터랙티브 리포트 구축 및 Jupyter 노트북/스크립트의 셀프서비스 도구 배포 API.
* [DB-IP](https://db-ip.com/api/free) - 무료 IP 지리 위치 API (IP당 일 1,000회 요청). CC-BY 4.0 라이선스의 라이트 데이터베이스도 무료.
* [DB Designer](https://www.dbdesigner.net/) — 클라우드 기반 데이터베이스 스키마 설계/모델링 도구. 무료 시작 요금제는 2개 데이터베이스 모델과 모델당 10개 테이블 제공.
* [DeepAR](https://developer.deepar.ai) — 모든 플랫폼에서 사용할 수 있는 증강현실 얼굴 필터 SDK. 무료 요금제는 월 10명 활성 사용자(MAU), 최대 4개 얼굴 추적 제공.
* [Deepnote](https://deepnote.com) - 실시간 협업 및 클라우드 실행이 가능한 새로운 데이터 과학 노트북. 무료 티어는 무제한 개인 프로젝트, 기본 머신(5GB RAM, 2vCPU) 무제한, 최대 3명 에디터 팀 지원.
* [Disease.sh](https://disease.sh/) — Covid-19 관련 앱 개발을 위한 정확한 데이터를 제공하는 무료 API.
* [Doczilla](https://www.doczilla.app/) — HTML/CSS/JS 코드에서 스크린샷 또는 PDF를 직접 생성하는 SaaS API. 무료 요금제는 월 250개 문서 허용.
* [Doppio](https://doppio.sh/) — 최신 렌더링 기술로 PDF 및 스크린샷을 생성·비공개 저장하는 관리형 API. 무료 요금제는 월 400개 PDF/스크린샷 제공.
* [drawDB](https://drawdb.app/) — 무료 오픈소스 온라인 데이터베이스 다이어그램 편집기, 회원가입 불필요.
* [dreamfactory.com](https://dreamfactory.com/) — 모바일, 웹, IoT 앱을 위한 오픈소스 REST API 백엔드. SQL/NoSQL 데이터베이스, 파일 저장소, 외부 서비스 연결 시 즉시 REST API 생성, 라이브 문서 및 사용자 관리 포함.
* [Duply.co](https://duply.co) — API 및 URL로 동적 이미지 생성, 디자인 템플릿 한 번 제작 후 재사용. 무료 티어 20 크레딧 제공.
* [DynamicDocs](https://advicement.io) - LaTeX 템플릿 기반 JSON to PDF API로 PDF 문서 생성. 무료 요금제는 월 50회 API 호출과 템플릿 라이브러리 접근 제공.
* [Efemarai](https://efemarai.com) - ML 모델 및 데이터 테스트 및 디버깅 플랫폼. 모든 계산 그래프 시각화. 로컬 무료 사용 가능.
* [ERD Lab](https://www.erdlab.io) — 개발자를 위한 무료 클라우드 기반 ERD(엔터티 관계 다이어그램) 도구. 무료 체험은 프로젝트 2개, 각 10개 테이블 제공.
* [ExtendsClass](https://extendsclass.com/rest-client-online.html) - HTTP 요청 전송을 위한 무료 웹 기반 HTTP 클라이언트.
* [Export SDK](https://exportsdk.com) - 드래그앤드롭 템플릿 편집기가 포함된 PDF 생성 API, SDK 및 노코드 통합 제공. 무료 요금제는 월 250페이지, 무제한 사용자, 3개 템플릿 제공.
* [file.coffee](https://file.coffee/) - 최대 15MB/파일(계정 생성 시 30MB/파일)까지 저장할 수 있는 플랫폼.
* [Financial Data](https://financialdata.net/) - 주식시장 및 금융 데이터 API. 무료 요금제는 하루 300회 요청 허용.
* [FormatJSONOnline.com](https://formatjsononline.com) - JSON 데이터를 즉시 포맷, 검증, 비교, 최소화할 수 있는 무료 브라우저 기반 도구.
* [FraudLabs Pro](https://www.fraudlabspro.com) — 신용카드 결제 사기 탐지 주문 거래 스크리닝 API. 주문의 입력 파라미터 기반 모든 사기 유형 탐지. 무료 Micro 요금제는 월 500건 거래.
* [GeoDataSource](https://www.geodatasource.com) — 위도/경도를 사용한 도시명 검색 위치 탐색 서비스. 월 500회까지 무료 API 쿼리 지원.
* [Geolocated.io](https://geolocated.io) — 멀티 대륙 서버 기반 IP 지리 위치 API, 무료 요금제는 하루 2,000회 요청 제공.
* [Glitterly](https://glitterly.app/) - 기본 템플릿에서 동적 이미지를 프로그래밍 방식으로 생성. RESTful API와 노코드 통합 지원. 무료 티어는 월 50개 이미지, 5개 템플릿 제공.
* [Hex](https://hex.tech/) - 노트북, 데이터 앱, 지식 라이브러리를 위한 협업 데이터 플랫폼. 최대 5개 프로젝트까지 무료 커뮤니티 티어 제공.
* [Hook0](https://www.hook0.com/) - 오픈소스 Webhooks-as-a-service(WaaS)로, 온라인 제품이 쉽게 웹훅을 제공할 수 있게 지원. 하루 100개 이벤트, 7일 기록 무료 보관.
* [Hoppscotch](https://hoppscotch.io) - 빠르고 아름다운 무료 API 요청 빌더.
* [huggingface.co](https://huggingface.co) - Pytorch, TensorFlow, JAX용 NLP 모델 구축, 학습, 배포. 월 3만 입력 문자까지 무료.
* [Hybiscus](https://hybiscus.dev/) - 간단한 선언적 API로 PDF 리포트 생성. 14일 무료 티어는 50개 단일 페이지 리포트 및 색상 팔레트/폰트 커스터마이즈 제공.
* [Invantive Cloud](https://cloud.invantive.com/) — Invantive SQL 또는 OData4(일반적으로 Power BI, Power Query)를 사용해 Exact Online, Twinfield, ActiveCampaign, Visma 등 70개 플랫폼 접근. 데이터 복제 및 교환 포함. 개발자/구현 컨설턴트 무료 플랜, 특정 플랫폼은 데이터 볼륨 제한 내 무료.
* [ipaddress.sh](https://ipaddress.sh) — 다양한 [포맷](https://about.ipaddress.sh/)으로 공용 IP 주소를 제공하는 간단한 서비스.
* [ip-api](https://ip-api.com) — IP 지리 위치 API, 비상업적 무료, API 키 필요 없음, 무료 요금제는 동일 IP 기준 분당 45회 제한.
* [ipbase.com](https://ipbase.com) - IP 지리 위치 API - 월 150회 요청의 영구 무료 요금제.
* [IP Geolocation](https://ipgeolocation.io/) — IP 지리 위치 API - 개발자용 영구 무료 요금제, 하루 1,000회 제한.
* [IP Geolocation API](https://www.abstractapi.com/ip-geolocation-api) — Abstract 제공 IP 지리 위치 API - 1,000회 무료 요청 허용.
* [IPLocate](https://www.iplocate.io) — IP 지리 위치 API, 하루 1,000회 무료 요청. 프록시/VPN/호스팅 탐지, ASN 데이터, IP-회사 매핑 등 제공. CSV 또는 GeoIP 호환 MMDB 형식의 무료 IP-국가, IP-ASN 데이터베이스 다운로드 제공.
* [IP2Location](https://www.ip2location.com) — 프리미엄 IP 지리 위치 서비스. LITE 데이터베이스 무료 다운로드 가능. 서버에 데이터베이스를 임포트하여 도시, 좌표, ISP 정보 로컬 쿼리 가능.
* [IP2Location.io](https://www.ip2location.io/) — 프리미엄, 빠르고 신뢰성 높은 IP 지리 위치 API. 도시, 좌표, ISP 등 데이터 제공. 무료 요금제는 월 5만 크레딧 제공. 500회 무료 WHOIS 및 도메인 조회도 제공. 도메인 등록 정보, 특정 IP 호스팅 도메인 조회 등. 유료 업그레이드 시 더 많은 기능.
* [ipapi](https://ipapi.co/) - Kloudend, Inc 제공 IP 주소 위치 API - AWS 기반 신뢰성 높은 지리 위치 API, Fortune 500 신뢰. 무료 티어는 회원가입 없이 월 3만회(일 1,000회) 조회 제공.
* [ipapi.is](https://ipapi.is/) - 최고의 호스팅 탐지 기능을 갖춘 개발자용 신뢰성 높은 IP 주소 API. 무료 요금제는 회원가입 없이 1,000회 조회 제공.
* [IPinfo](https://ipinfo.io/) — 빠르고 정확하며 무료(월 5만회) IP 주소 데이터 API. 지리 위치, 기업, 통신사, IP 범위, 도메인, 악용 연락처 등 다양한 API 제공. 유료 API도 무료 체험 가능.
* [IPQuery](https://ipquery.io) — 개발자용 무제한 IP API, 요청 제한 및 가격 없음.
* [IPTrace](https://iptrace.io) — 신뢰성 높고 유용한 IP 지리 위치 데이터를 월 5만회 무료 조회로 제공하는 간단한 API.
* [JSON2Video](https://json2video.com) - 비디오 마케팅 및 SNS 영상을 코드 또는 노코드로 자동화하는 비디오 편집 API.
* [JSON IP](https://getjsonip.com) — 요청한 클라이언트의 공용 IP 주소 반환. 무료 요금제는 회원가입 불필요. CORS 지원, 브라우저에서 클라이언트 JS로 직접 데이터 요청 가능. 클라이언트/서버 IP 변경 모니터링에 유용. 무제한 요청.
* [JSON Serve](https://jsonserve.com/) — 개발자가 JSON 객체를 저장하고 REST API로 사용할 수 있도록 지원하는 무료 서비스.
* [JSONing](https://jsoning.com/api/) — JSON 객체에서 가짜 REST API 생성, HTTP 상태 코드, 헤더, 응답 본문 커스터마이즈 가능.
* [konghq.com](https://konghq.com/) — API 마켓플레이스 및 강력한 개인/공개 API 도구. 무료 티어는 모니터링, 알림, 지원 등 일부 기능 제한.
* [Kreya](https://kreya.app) — 무료 gRPC GUI 클라이언트, gRPC API 호출/테스트 가능. 서버 리플렉션을 통한 gRPC API 임포트 지원.
* [Lightly](https://www.lightly.ai/) — 올바른 데이터를 사용해 머신러닝 모델 성능을 향상. 최대 1,000개 샘플의 데이터셋 무료 사용.
* [LoginLlama](https://loginllama.app) - 사기 및 의심스러운 로그인을 탐지, 고객에게 알림을 보내는 로그인 보안 API. 월 1,000회 로그인까지 무료.
* [MailboxValidator](https://www.mailboxvalidator.com) — 실제 메일 서버 연결로 이메일 유효성을 확인하는 이메일 검증 서비스. 무료 API 요금제는 월 100회 검증 제공.
* [Market Data API](https://www.marketdata.app) - 주식, 옵션, 뮤추얼펀드 등 실시간 및 과거 금융 데이터 제공. Free Forever API 티어는 하루 100회 무료 API 요청 가능.
* [Meteosource Weather API](https://www.meteosource.com/) — 현재 및 예보된 전 세계 날씨 데이터를 제공하는 글로벌 날씨 API입니다. 예보는 더 나은 정확도를 위해 여러 기상 모델의 머신러닝 조합을 기반으로 합니다. 무료 플랜은 하루 400회 호출이 가능합니다.
* [microlink.io](https://microlink.io/) – 모든 웹사이트를 메타태그 정규화, 아름다운 링크 미리보기, 스크래핑 기능, 또는 스크린샷 서비스와 같은 데이터로 변환합니다. 매일 50회 요청이 무료로 제공됩니다.
* [Mindee](https://developers.mindee.com) – Mindee는 강력한 OCR 소프트웨어이자 API 우선 플랫폼으로, 컴퓨터 비전과 머신러닝을 이용한 주요 정보의 데이터 인식을 통해 문서 처리 레이어를 표준화하여 개발자의 애플리케이션 워크플로우 자동화를 지원합니다. 무료 티어는 월 500페이지가 제공됩니다.
* [Mintlify](https://mintlify.com) — API 문서화의 현대적 표준. 아름답고 유지관리가 쉬운 UI 컴포넌트, 인앱 검색, 인터랙티브 플레이그라운드 제공. 1명의 에디터까지 무료.
* [MockAPI](https://www.mockapi.io/) — 빠르게 API를 목업하고, 커스텀 데이터를 생성하며, RESTful 인터페이스를 이용한 작업이 가능한 간단한 도구입니다. MockAPI는 프로토타이핑/테스트/학습용 도구로 설계되었습니다. 한 프로젝트당 2개의 리소스, 한 프로젝트 무료 제공.
* [Mockfly](https://www.mockfly.dev/) — 신뢰할 수 있는 API 목킹 및 기능 플래그 관리 개발 도구입니다. 직관적인 인터페이스로 빠르게 목 API를 생성하고 제어할 수 있습니다. 무료 티어는 하루 500회 요청을 제공합니다.
* [Mocki](https://mocki.io) - GitHub 저장소와 동기화되는 목 GraphQL 및 REST API를 생성할 수 있는 도구입니다. 간단한 REST API는 가입 없이 개발 및 사용이 무료입니다.
* [Mocko.dev](https://mocko.dev/) — API를 프록시하고, 클라우드에서 목킹할 엔드포인트를 선택하여 트래픽을 검사할 수 있습니다. 개발 및 통합 테스트 속도를 높일 수 있습니다. 무료 제공.
* [Mocky](https://designer.mocky.io/) - HTTP 요청을 목킹하기 위한 커스텀 HTTP 응답을 생성하는 간단한 웹 앱입니다. 또한 [오픈 소스](https://github.com/julien-lafont/Mocky)로도 제공됩니다.
* [Mock N Roll](https://mpcknroll.me/) - 무료 목 API 서비스 — 백엔드 지연 없이 실제 API 응답을 시뮬레이션할 수 있는 강력한 도구입니다. 프론트엔드 개발자, QA 테스터, DevOps 팀에 적합합니다. [repo](https://github.com/haerulmuttaqin/mocknroll-web).
* [microenv.com](https://microenv.com) — 개발자를 위한 가짜 REST API를 생성하고, 코드 및 앱을 도커 컨테이너로 생성할 수 있습니다.
* [Multi-Exit IP Address Checker](https://ip.alstra.ca/) — 여러 노드를 통해 자신의 종료 IP 주소를 확인하고, IP가 다양한 글로벌 지역 및 서비스에 어떻게 보이는지 이해할 수 있는 무료 간단 도구입니다. Control D와 같은 규칙 기반 DNS 분할 도구 테스트에 유용합니다.
* [Namekit](https://namekit.app/) - AI 기반 도메인 탐색 — 즉시 사용 가능한, 표준 가격의 도메인을 찾을 수 있습니다. 무료 일일 쿼리 제공.
* [News API](https://newsapi.org) — 웹의 뉴스를 코드로 검색하고, JSON 결과를 얻을 수 있습니다. 개발자는 하루 100회 무료 쿼리를 사용할 수 있습니다. 기사에는 24시간 지연이 있습니다.
* [numlookupapi.com](https://numlookupapi.com) - 무료 전화번호 검증 API - 월 100회 무료 요청.
* [OCR.Space](https://ocr.space/) — 이미지와 PDF 파일을 파싱하여 텍스트 결과를 JSON 형식으로 반환하는 OCR API입니다. 월 25,000회 요청, 파일 크기 1MB 제한이 무료로 제공됩니다.
* [OpenAPI3 Designer](https://openapidesigner.com/) — Open API 3 정의를 시각적으로 무료로 생성할 수 있습니다.
* [parsehub.com](https://parsehub.com/) — 동적 사이트에서 데이터를 추출하고, 동적 웹사이트를 API로 변환합니다. 5개 프로젝트 무료.
* [Parseur](https://parseur.com) — 월 20페이지 무료: PDF, 이메일에서 데이터 추출. AI 기반. 전체 API 접근 제공.
* [PDFBolt](https://pdfbolt.com) - 개발자 중심의 PDF 생성 API로 프라이버시를 중시합니다. Stripe에서 영감을 받은 문서와 월 500회 무료 PDF 변환을 포함합니다.
* [pdfEndpoint.com](https://pdfendpoint.com) - HTML 또는 URL을 간단한 API로 PDF로 변환합니다. 월 100회 무료 변환 제공.
* [PDF-API.io](https://pdf-api.io) - PDF 자동화 API, 시각적 템플릿 에디터, HTML에서 PDF로 변환, 동적 데이터 통합, API를 통한 PDF 렌더링. 무료 플랜은 템플릿 1개, 월 100개 PDF 제공.
* [Pixela](https://pixe.la/) - 무료 데이스트림 데이터베이스 서비스. 모든 작업은 API를 통해 수행됩니다. 히트맵 및 선그래프 시각화도 가능합니다.
* [Postman](https://postman.com) — 워크플로우를 단순화하고 더 나은 API를 더 빠르게 만들 수 있는 API 개발 협업 플랫폼입니다. Postman 앱은 영구 무료로 사용할 수 있습니다. Postman 클라우드 기능도 특정 제한 내에서 영구 무료입니다.
* [Insomnia](https://insomnia.rest) - API 설계 및 테스트를 위한 오픈소스 API 클라이언트로, REST 및 GraphQL을 지원합니다.
* [PrefectCloud](https://www.prefect.io/cloud/) — 데이터플로우 자동화의 완전한 플랫폼입니다. 무료 플랜에는 5개의 배포 워크플로우와 월 500분의 서버리스 컴퓨트 크레딧이 포함됩니다.
* [Preset Cloud](https://preset.io/) - 호스팅된 Apache Superset 서비스입니다. 5명 이하 팀에 영구 무료, 무제한 대시보드 및 차트, 노코드 차트 빌더, 협업 SQL 에디터 제공.
* [PromptLoop](https://www.promptloop.com/) - PromptLoop는 거의 도입 시간 없이 10배 쉬운 AI 웹 스크래핑, 기존 워크플로우 대비 85% 이상 시간 절약, 수작업보다 4배 빠른 속도를 제공합니다. 모든 리서치 작업에 대한 REST API 엔드포인트 포함, 월 1,000 크레딧 무료.
* [Public-Apis Github Repo](https://github.com/public-apis/public-apis) — 무료 공개 API 리스트.
* [Rapidapi](https://rapidapi.com/) - 세계 최대의 API 허브. 수백만 개발자가 수천 개의 API를 찾고 연결하며, 재미있는 챌린지(해결책 제공)와 인터랙티브 예제 등 API 개발 지원.
* [RequestBin.com](https://requestbin.com) — HTTP 요청을 보낼 수 있는 무료 엔드포인트를 생성합니다. 해당 엔드포인트로 전송된 모든 HTTP 요청은 페이로드와 헤더와 함께 기록되어 웹훅 및 기타 서비스의 추천 사항을 관찰할 수 있습니다.
* [reqres.in](https://reqres.in) - AJAX 요청에 응답할 수 있는 무료 호스팅 REST-API.
* [Roboflow](https://roboflow.com) - 사전 머신러닝 경험이 없어도 사용자 맞춤 컴퓨터 비전 모델을 생성하고 배포할 수 있습니다. 무료 티어는 월 30 크레딧 포함.
* [ROBOHASH](https://robohash.org/) - 임의의 텍스트로부터 고유하고 멋진 이미지를 생성하는 웹 서비스.
* [Scraper's Proxy](https://scrapersproxy.com) — 스크래핑을 위한 간단한 HTTP 프록시 API. 제한, 차단, 캡챠 걱정 없이 익명으로 스크랩. 월 100회 성공적인 스크랩(자바스크립트 렌더링 포함) 무료, 추가는 지원팀 문의.
* [ScrapingAnt](https://scrapingant.com/) — 헤드리스 크롬 스크래핑 API와 무료 검사된 프록시 서비스. 자바스크립트 렌더링, 프리미엄 로테이팅 프록시, 캡챠 회피. 10,000 API 크레딧 무료 제공.
* [Simplescraper](https://simplescraper.io) — 각 작업 후 웹훅 호출 가능. 무료 플랜은 100 클라우드 스크랩 크레딧 포함.
* [Select Star](https://www.selectstar.com/) - 데이터 자동 분석 및 문서화를 제공하는 지능형 데이터 탐색 플랫폼. 무료 라이트 티어는 데이터 소스 2개, 최대 테이블 1,000개, 사용자 25명까지 제공.
* [Sheetson](https://sheetson.com) - 모든 Google 시트를 즉시 RESTful API로 변환. 무료 플랜은 시트당 1,000개의 무료 행 포함.
* [Shipyard](https://www.shipyardapp.com) — 클라우드용 로우코드 데이터 오케스트레이션 플랫폼. 로우코드 템플릿과 코드(Python, Node.js, Bash, SQL) 혼합 구축. 무료 개발자 플랜은 월 10시간 런타임, 사용자 1명 제공 — 여러 워크플로우 자동화에 충분.
* [Siterelic](https://siterelic.com/) - Siterelic API로 스크린샷, 웹사이트 감사, TLS 스캔, DNS 조회, TTFB 테스트 등 가능. 무료 플랜은 월 100회 API 요청 제공.
* [SerpApi](https://serpapi.com/) - 실시간 검색 엔진 스크래핑 API. Google, YouTube, Bing, Baidu, Walmart 등 다양한 엔진에 대해 구조화된 JSON 결과 반환. 무료 플랜은 월 100회 성공적 API 콜 제공.
* [SmartParse](https://smartparse.io) - SmartParse는 데이터 마이그레이션 및 CSV to API 플랫폼으로 시간과 비용을 절감하는 개발자 도구를 제공합니다. 무료 티어는 월 300 처리 유닛, 브라우저 업로드, 데이터 검역, 회로 차단기, 작업 알림 포함.
* [Sofodata](https://www.sofodata.com/) - CSV 파일에서 보안 RESTful API를 생성. CSV 파일 업로드 후 즉시 API로 데이터 접근 가능, 빠른 앱 개발 지원. 무료 플랜은 API 2개, 월 2,500 API 콜 제공. 신용카드 불필요.
* [Sqlable](https://sqlable.com/) - SQL 포매터, 밸리데이터, SQL 정규식 테스터, 가짜 데이터 생성기, 인터랙티브 데이터베이스 플레이그라운드 등 무료 온라인 SQL 도구 모음.
* [Stoplight](https://stoplight.io/) - API 설계 및 문서화를 협업할 수 있는 SaaS. 무료 플랜은 설계, 목킹, 문서화 도구 제공.
* [Supportivekoala](https://supportivekoala.com/) — 입력값을 템플릿에 따라 자동으로 이미지를 생성할 수 있습니다. 무료 플랜은 월 최대 50개 이미지 생성 가능.
* [Svix](https://www.svix.com/) - 서비스로서의 웹훅. 월 50,000 메시지까지 무료 전송.
* [Tavily AI](https://tavily.com/) - 온라인 검색 및 빠른 인사이트, 종합 리서치 API. 연구 결과 정리 기능. 무료 티어는 월 1,000회 요청, 신용카드 불필요.
* [The IP API](https://theipapi.com/) - 일일 1,000회 무료 요청의 IP 지리 위치 API. IP 주소의 국가, 도시, 지역 등 위치 정보 제공.
* [TinyMCE](https://www.tiny.cloud) - 리치 텍스트 편집 API. 핵심 기능은 무제한 사용 무료.
* [Tomorrow.io Weather API](https://www.tomorrow.io/weather-api/) - 무료 플랜 제공하는 날씨 API. 글로벌 커버리지, 정확하고 최신 날씨 예보, 과거 데이터, 날씨 모니터링 솔루션 제공.
* [Treblle](https://www.treblle.com) - Treblle은 팀이 API를 구축, 배포, 관리할 수 있도록 지원합니다. 고급 API 로그 집계, 관찰, 문서, 디버깅 제공. 모든 기능을 무료로 사용 가능, 무료 티어는 월 250,000 요청 제한.
* [UniRateAPI](https://unirateapi.com) – 590개 이상의 통화 및 암호화폐 실시간 환율 API. 무료 플랜에서 무제한 API 호출 제공, 개발자와 금융 앱에 적합.
* [vatcheckapi.com](https://vatcheckapi.com) - 간단하고 무료인 VAT 번호 검증 API. 월 150회 무료 검증.
* [WeatherXu](https://weatherxu.com/) — 현재 상태, 시간별·일별 예보, 날씨 알림 등 글로벌 날씨 데이터를 API로 제공합니다. AI 및 ML 시스템 통합으로 여러 기상 모델을 분석·결합하여 개선된 예보 정확도 제공. 무료 티어는 월 10,000 API 호출 포함.
* [Webhook Store](https://www.openwebhook.io) - 타사 웹훅 저장 및 로컬호스트(ngrok 스타일)에서 디버깅하는 도구. 오픈소스 및 자체 호스팅 가능. 무료 개인 도메인 *username*.github.webhook.store, 무료 공개 도메인 *anything*.webhook.store.
* [WebScraping.AI](https://webscraping.ai) - 파싱, 크롬 렌더링, 프록시가 내장된 간단한 웹 스크래핑 API. 월 2,000회 무료 API 호출.
* [Weights & Biases](https://wandb.ai) — 개발자 중심 MLOps 플랫폼. 실험 추적, 데이터셋 버전 관리, 모델 관리로 더 나은 모델을 더 빠르게 구축. 개인 프로젝트 전용 무료 티어, 100GB 저장공간 포함.
* [What The Diff](https://whatthediff.ai) - AI 기반 코드 리뷰 어시스턴트. 무료 플랜은 월 25,000 토큰(~10 PR) 제한.
* [wolfram.com](https://wolfram.com/language/) — 클라우드에 내장된 지식 기반 알고리즘.
* [wrapapi.com](https://wrapapi.com/) — 모든 웹사이트를 파라미터화된 API로 변환. 월 30,000회 API 호출 가능.
* [Zenscrape](https://zenscrape.com/web-scraping-api) — 헤드리스 브라우저, 주거용 IP, 직관적 요금제의 웹 스크래핑 API. 월 1,000회 무료 API 호출, 학생 및 비영리 단체 추가 크레딧 제공.
* [Zipcodebase](https://zipcodebase.com) - 무료 우편번호 API, 전 세계 우편번호 데이터 제공. 월 5,000회 무료 요청.
* [Zipcodestack](https://zipcodestack.com) - 무료 우편번호 API 및 우편번호 검증. 월 10,000회 무료 요청.
* [Zuplo](https://zuplo.com/) - 무료 API 관리 플랫폼. API 키 인증, 속도 제한, 개발자 문서, 수익화 기능을 몇 분 만에 추가. OpenAPI 네이티브, 웹 표준 API 및 Typescript로 완전 프로그래머블. 무료 플랜은 최대 10개 프로젝트, 무제한 프로덕션 엣지 환경, 월 100만 요청, 10GB 이그레스 제공.

**[⬆️ 맨 위로](#table-of-contents)**

## Artifact Repos

* [Artifactory](https://jfrog.com/start-free/) - Maven, Docker, Cargo, Helm, PyPI, CocoaPods, GitLFS 등 다양한 패키지 포맷을 지원하는 아티팩트 저장소. 패키지 스캐닝 도구 XRay와 CI/CD 도구 Pipelines(구 Shippable) 포함. 무료 티어는 월 2,000분 CI/CD 제공.
* [central.sonatype.org](https://central.sonatype.org) — Apache Maven, SBT, 기타 빌드 시스템의 기본 아티팩트 저장소.
* [cloudrepo.io](https://cloudrepo.io) - 클라우드 기반의 프라이빗·공개 Maven, PyPi 저장소. 오픈소스 프로젝트 무료.
* [cloudsmith.io](https://cloudsmith.io) — Java/Maven, RedHat, Debian, Python, Ruby, Vagrant 등 다양한 포맷의 간단하고 안전한 중앙 저장소 서비스. 무료 티어 + 오픈소스 무료.
* [jitpack.io](https://jitpack.io/) — GitHub 상의 JVM 및 안드로이드 프로젝트용 Maven 저장소, 공개 프로젝트 무료.
* [packagecloud.io](https://packagecloud.io/users/new?plan=free_usage_plan) — Maven, RPM, DEB, PyPi, NPM, RubyGem 패키지 호스팅을 간편하게 제공(무료 티어 있음).
* [repsy.io](https://repsy.io) — 1GB 무료 프라이빗/공개 Maven 저장소.
* [Gemfury](https://gemfury.com) — Maven, PyPi, NPM, Go Module, Nuget, APT, RPM 저장소용 프라이빗·공개 아티팩트 저장소. 공개 프로젝트 무료.
* [paperspace](https://www.paperspace.com/) — AI 모델 빌드·확장, AI 앱 개발, 학습, 배포. 무료 플랜: 공개 프로젝트, 5GB 저장소, 기본 인스턴스.
* [RepoForge](https://repoforge.io) - Python, Debian, NPM 패키지 및 Docker 레지스트리용 프라이빗 클라우드 호스팅 저장소. 오픈소스/공개 프로젝트 무료 플랜.
* [RepoFlow](https://repoflow.io) - npm, PyPI, Docker, Go, Helm 등 패키지 관리 간소화. 클라우드에서 10GB 저장소, 10GB 대역폭, 100개 패키지, 무제한 사용자 무료 제공, 또는 개인용 셀프호스팅.

**[⬆️ 맨 위로](#table-of-contents)**

## 팀 및 협업 도구
* [3Cols](https://3cols.com/) - 개인 및 협업용 클라우드 기반 무료 코드 스니펫 관리 도구.
* [Bitwarden](https://bitwarden.com) — 개인, 팀, 비즈니스 조직이 민감한 데이터를 저장·공유·동기화할 수 있는 가장 쉽고 안전한 방법.
* [Braid](https://www.braidchat.com/) — 팀을 위한 채팅 앱. 공개 그룹 무제한 사용자, 히스토리, 통합 무료. 자체 호스팅 가능한 오픈소스 버전 제공.
* [cally.com](https://cally.com/) — 회의에 적합한 시간과 날짜를 쉽게 찾을 수 있는 도구. 소규모·대규모 그룹에 적합.
* [Calendly](https://calendly.com) — 일정 연결 및 미팅 예약 도구. 무료 플랜은 사용자당 캘린더 1개 연결, 무제한 세션 제공. 데스크톱 및 모바일 앱 제공.
* [Discord](https://discord.com/) — 공개/비공개 방에서 채팅. Markdown 텍스트, 음성, 영상, 화면 공유 가능. 무제한 사용자 무료.
* [Fibo](https://fibo.dev) - 무제한 멤버가 스토리 포인트를 평가할 수 있는 애자일 팀용 무료 온라인 실시간 스크럼 포커 도구.
* [Telegram](https://telegram.org/) — 빠르고 신뢰할 수 있는 메시징 및 통화용 메신저. 대규모 그룹, 사용자명, 데스크톱 앱, 강력한 파일 공유 기능 등 비즈니스 및 소규모 팀에 적합.
* [DevToolLab](https://devtoollab.com) — 기본 도구 모두 무료 제공, 도구별 1개 항목 자동 저장, 표준 처리 속도, 커뮤니티 지원.
* [Dubble](https://dubble.so/) — 무료 단계별 가이드 생성기. 스크린샷 찍기, 프로세스 문서화, 팀 협업 지원. 비동기 화면 녹화도 지원.
* [Duckly](https://duckly.com/) — 팀과 실시간 협업 및 대화. IDE, 터미널 공유, 음성·영상·화면 공유를 통한 페어 프로그래밍. 소규모 팀 무료.
* [Dyte](https://dyte.io) - 개발자 친화적인 라이브 비디오/오디오 SDK. 생산성과 참여도 향상을 위한 협업 플러그인 제공. 무료 티어는 월 10,000분 라이브 비디오/오디오 사용 제공.
* [evernote.com](https://evernote.com/) — 정보 정리 도구. 노트 공유 및 협업 가능.
* [Fibery](https://fibery.io/) — 연결된 워크스페이스 플랫폼. 개인 사용자 무료, 디스크 공간 최대 2GB 제공.
  * [flock.com](https://flock.com) — 팀 커뮤니케이션을 더 빠르게 할 수 있는 서비스입니다. 무료로 무제한 메시지, 채널, 사용자, 앱 및 통합 기능 제공
  * [Gather](https://www.gather.town/) - 온라인 미팅을 더 좋게 만드는 서비스입니다. 완전히 커스터마이즈 가능한 공간을 중심으로 커뮤니티와 함께하는 시간을 실제와 같이 쉽게 만듭니다. 동시 10명까지 무료 제공.
  * [gokanban.io](https://gokanban.io) - 구문 기반, 회원가입 없는 칸반 보드로 빠른 사용 가능. 제한 없는 무료 제공.
  * [flat.social](https://flat.social) - 팀 미팅 및 소셜 해피아워를 위한 인터랙티브 커스터마이즈 공간. 무제한 미팅, 동시 8명까지 무료.
  * [GitDailies](https://gitdailies.com) - 팀의 GitHub 커밋 및 풀 리퀘스트 활동에 대한 데일리 리포트. Push 시각화, 동료 인정 시스템, 맞춤 알림 빌더 포함. 무료 티어는 무제한 사용자, 3개 저장소, 3개 알림 설정 제공.
  * [gitter.im](https://gitter.im/) — GitHub용 채팅. 무제한 공개 및 비공개 방, 팀당 최대 25명까지 무료
  * [Hackmd.io](https://hackmd.io/) - 마크다운 형식 문서/파일을 위한 실시간 협업 및 작성 도구. 마크다운 파일용 Google Docs와 유사. 무료로 무제한 "노트" 제공, 단, 비공개 노트 및 템플릿의 협업자(초대자) 수는 [제한](https://hackmd.io/pricing)됨.
  * [hangouts.google.com](https://hangouts.google.com/) — 모든 대화를 한 곳에서 무료로, 구글 계정 필요
  * [HeySpace](https://hey.space) - 채팅, 캘린더, 타임라인, 화상 통화가 포함된 작업 관리 도구. 최대 5명까지 무료.
  * [helplightning.com](https://www.helplightning.com/) — 증강현실을 활용한 영상 지원. 분석, 암호화, 지원 없이 무료 제공
  * [ideascale.com](https://ideascale.com/) — 고객이 아이디어를 제출하고 투표할 수 있게 함, 1개 커뮤니티에 25명까지 무료
  * [Igloo](https://www.igloosoftware.com/) — 문서, 블로그, 캘린더 공유를 위한 내부 포털. 최대 10명까지 무료.
  * [Keybase](https://keybase.io/) — Keybase는 Slack의 오픈소스 대안으로, 가족부터 커뮤니티, 기업까지 모두의 채팅과 파일을 안전하게 보호합니다.
  * [Google Meet](https://meet.google.com/) — 비즈니스용 온라인 화상 회의에 Google Meet 사용. 안전하고 쉽게 참여할 수 있는 온라인 회의 제공.
  * [/meet for Slack](https://meetslack.com) - Slack 내에서 /meet 명령어로 Google Meet 바로 시작. 무제한 무료.
  * [Livecycle](https://www.livecycle.io/) — 크로스펑셔널 제품팀과 오픈소스 프로젝트를 위한 포괄적 협업 플랫폼.
  * [Lockitbot](https://www.lockitbot.com/) — Slack 내에서 회의실, 개발 환경, 서버 등 공유 자원을 예약 및 잠금. 최대 2개 자원까지 무료.
  * [MarkUp](https://www.markup.io/) — 웹사이트, PDF, 이미지 위에 직접 피드백 수집 가능.
  * [Proton Pass](https://proton.me/pass) — 내장 이메일 별칭, 2FA 인증기, 공유 및 패스키를 지원하는 비밀번호 관리자. 웹, 브라우저 확장, 모바일 및 데스크탑 앱 제공.
  * [Visual Debug](https://visualdebug.com) - 클라이언트-개발자 커뮤니케이션을 위한 시각적 피드백 도구
  * [meet.jit.si](https://meet.jit.si/) — 원클릭 화상회의 및 화면 공유, 무료 제공
  * [Microsoft Teams](https://products.office.com/microsoft-teams/free) — 대화, 콘텐츠, 앱을 하나로 모은 챗 기반 디지털 허브. 최대 50만 명까지 무료.
  * [Miro](https://miro.com/) - 분산된 팀을 위한 확장 가능하고 보안성 높은 협업 화이트보드. 프리미엄 플랜 제공.
  * [nootiz](https://www.nootiz.com/) - 웹사이트에서 시각적 피드백을 수집 및 관리하는 도구
  * [Notion](https://www.notion.so/) - 마크다운 지원, 작업, 위키, 데이터베이스 통합의 노트 및 협업 앱. 노트 작성, 프로젝트 관리, 작업 관리 등 올인원 워크스페이스. 크로스플랫폼 앱과 웹 브라우저 모두에서 접근 가능.
  * [Nuclino](https://www.nuclino.com) - 팀의 지식, 문서, 노트를 위한 경량 협업 위키. 필수 기능 모두 제공하는 무료 플랜, 최대 50개 항목, 5GB 저장공간 제공.
  * [OnlineInterview.io](https://onlineinterview.io/) - 내장 화상채팅, 드로잉 보드, 온라인 코드 에디터가 있는 무료 코딩 인터뷰 플랫폼. 브라우저에서 코드 컴파일/실행 가능. 원클릭으로 원격 인터뷰 룸 생성.
  * [Quidlo Timesheets](https://www.quidlo.com/timesheets) - 팀용 간단한 타임시트 및 시간 추적 앱. 무료 플랜은 최대 10명까지 시간 추적 및 리포트 생성 가능.
  * [PageShare.dev](https://www.pageshare.dev) - 별도 배포 없이 GitHub Pull Request에 시각적 검토 기능 추가. 매달 10페이지, 총 100MB 저장공간까지 무료.
  * [Pendulums](https://pendulums.io/) - 쉽고 통계적인 UI로 시간 관리를 지원하는 무료 시간 추적 도구.
  * [Pumble](https://pumble.com) - 무료 팀 채팅 앱. 무제한 사용자, 메시지 기록, 영원히 무료.
  * [Raindrop.io](https://raindrop.io) - macOS, Windows, Android, iOS, Web용 개인 및 보안 북마크 앱. 무제한 북마크 및 협업 무료 제공.
  * [element.io](https://element.io/) — Matrix 기반의 분산형 오픈소스 커뮤니케이션 도구. 그룹 채팅, DM, 암호화된 파일 전송, 음성/영상 채팅, 서비스 통합 지원.
  * [Rocket.Chat](https://rocket.chat/) - 오픈소스 커뮤니케이션 플랫폼, 옴니채널, Matrix 연동, 타 앱 브릿지, 무제한 메시지, 전체 메시지 기록 제공.
  * [seafile.com](https://www.seafile.com/) — 프라이빗/클라우드 저장소, 파일 공유, 동기화, 토론 지원. 클라우드 버전 1GB 제공
  * [Sema](https://www.semasoftware.com/) - 여러 저장소의 기여 내역을 하나의 리포트로 통합/스냅샷할 수 있는 무료 개발자 포트폴리오 도구.
  * [Screen Sharing via Browser](https://screensharing.net) - 브라우저에서 바로 화면 공유, 다운로드/회원가입 없이 무료로 협업자와 화면 공유.
  * [Slab](https://slab.com/) — 팀을 위한 최신 지식 관리 서비스. 최대 10명까지 무료.
  * [slack.com](https://slack.com/) — 일부 기능 제한이 있지만 무제한 사용자 무료 제공
  * [Spectrum](https://spectrum.chat/) - 무료로 공개 또는 비공개 커뮤니티 생성.
  * [StatusPile](https://www.statuspile.com/) - 상태 페이지의 상태 페이지. 공급업체 상태 페이지 트래킹 가능.
  * [Stickies](https://stickies.app/) - 브레인스토밍, 콘텐츠 큐레이션, 노트용 시각적 협업 앱. 최대 3개 벽, 무제한 사용자, 1GB 저장공간 무료.
  * [Stacks](https://betterstacks.com/) - 노트, 링크, 파일 저장 통합 콘텐츠 워크스페이스. 개인용 플랜 영구 무료.
  * [talky.io](https://talky.io/) — 무료 그룹 화상채팅. 익명, P2P, 플러그인/회원가입/결제 불필요
  * [Teamhood](https://teamhood.com/) - 무료 프로젝트, 작업, 이슈 트래킹 소프트웨어. 스윔레인 포함 칸반, 완전한 스크럼 구현, 시간 추적. 최대 5명, 3개 프로젝트 포트폴리오 무료.
  * [Teamplify](https://teamplify.com) - 팀 분석 및 스마트 데일리 스탠드업으로 팀 개발 프로세스 개선. 원격팀용 휴가관리 포함. 최대 5명 소규모 팀 무료.
  * [Tefter](https://tefter.io) - 강력한 Slack 통합 북마크 앱. 오픈소스 팀 무료.
  * [TeleType](https://teletype.oorja.io/) — 터미널, 음성, 코드, 화이트보드 등 공유. 개발자용 종단간 암호화 협업, 가입 불필요.
  * [TimeCamp](https://www.timecamp.com/) - 무제한 사용자 무료 시간 추적 소프트웨어. Jira, Trello, Asana 등 PM 도구와 연동.
  * [Huly](https://huly.io/) - 올인원 프로젝트 관리 플랫폼(Linear, Jira, Slack, Notion, Motion 대안) - 무제한 사용자, 워크스페이스당 10GB 저장, 10GB 비디오(오디오) 트래픽.
  * [Teamcamp](https://www.teamcamp.app) - 소프트웨어 개발사를 위한 올인원 프로젝트 관리 앱.
  * [twist.com](https://twist.com) — 대화가 체계적으로 유지되는 비동기 팀 커뮤니케이션 앱. 무료 및 무제한 플랜 제공. 자격 조건 충족 팀 할인.
  * [tldraw.com](https://tldraw.com) —  무료 오픈소스 화이트보드·다이어그램 도구. 지능형 화살표, 스냅, 스티키노트, SVG 내보내기. 협업 편집용 멀티플레이어 모드 지원. 공식 무료 VS Code 확장 제공.
  * [BookmarkOS.com](https://bookmarkos.com) - 폴더 협업 기능이 포함된 무료 올인원 북마크·탭·작업 관리자.
  * [typetalk.com](https://www.typetalk.com/) — 웹/모바일에서 팀과 아이디어를 즉시 공유 및 논의
  * [Tugboat](https://tugboat.qa) - 풀리퀘스트별 미리보기 자동 및 온디맨드 제공. 모두 무료, 비영리단체용 Nano 티어 무료.
  * [whereby.com](https://whereby.com/) — 원클릭 화상회의, 무료 제공(구. appear.in)
  * [windmill.dev](https://windmill.dev/) - 오픈소스 개발자 플랫폼으로 파이썬·타입스크립트 스크립트 기반 프로덕션급 자동화/내부앱 신속 빌드. 무료 사용자는 최대 3개 비프리미엄 워크스페이스 생성/참여 가능.
  * [vadoo.tv](https://vadoo.tv/) — 손쉬운 영상 호스팅 및 마케팅. 1클릭 업로드, 녹화, 관리, 공유 등. 무료 티어는 영상 10개, 저장 1GB, 트래픽 월 10GB 제공
  * [userforge.com](https://userforge.com/) - 온라인 페르소나, 유저 스토리, 컨텍스트 매핑. 디자인과 개발이 동기화되도록 지원, 페르소나 3개·협업자 2명까지 무료.
  * [wistia.com](https://wistia.com/) — 뷰어 분석, HD 영상 전달, 마케팅 도구 포함 영상 호스팅. 영상 25개, Wistia 브랜딩 플레이어 제공
  * [wormhol.org](https://www.wormhol.org/) — 간단한 파일 공유 서비스. 5GB까지 무제한 파일 다수 사용자와 공유.
  * [Wormhole](https://wormhole.app/) - 종단간 암호화로 최대 5GB 파일, 최대 24시간 공유. 5GB 초과 파일은 P2P 직접 전송.
  * [zoom.us](https://zoom.us/) — 안전한 화상/웹 회의, 추가 기능 제공. 무료 플랜은 40분 제한.
  * [Zulip](https://zulip.com/) — 독특한 이메일식 스레딩의 실시간 채팅. 무료 플랜은 10,000 메시지 검색, 5GB 파일 저장, 오픈소스 셀프호스팅 버전 제공.
  * [robocorp.com](https://robocorp.com) - 오픈소스 자동화 운영 스택. 클라우드 기능 체험 및 간단한 자동화 구현 무료. 월 240분 로봇 작업, 10회 Assistant 실행, 100MB 저장 제공.
  * [Fleep.io](https://fleep.io/) — Slack 대체 채팅. 소규모 팀용 무료 플랜은 전체 메시지 기록, 무제한 1:1 대화, 그룹 1개, 파일 저장 1GB 제공.
  * [Chanty.com](https://chanty.com/) — 또 다른 Slack 대안. 소규모 팀(최대 10명)용 영원히 무료 플랜, 무제한 공개/비공개 대화, 검색 기록, 무제한 1:1 통화, 무제한 음성 메시지, 통합 10개, 팀당 20GB 저장.
  * [ruttl.com](https://ruttl.com/) — 웹사이트, PDF, 이미지에 대한 피드백과 리뷰를 한 번에 수집할 수 있는 올인원 피드백 도구.
  * [Mattermost](https://mattermost.com/) — 기술팀을 위한 안전한 협업. 무제한 채널, 플레이북, 보드, 사용자, 10GB 저장 등 무료 플랜 제공.
  * [Webvizio](https://webvizio.com) — 웹사이트 피드백, 리뷰, 버그 리포트 도구로 실시간 웹사이트/앱, 이미지, PDF, 디자인 파일에서 직접 협업.
  * [Pullflow](https://pullflow.com) — GitHub, Slack, VS Code에서 AI 강화 코드리뷰 협업 플랫폼 제공.
  * [Webex](https://www.webex.com/) — 무료 플랜으로 회당 40분, 최대 100명까지 화상회의 지원.
  * [RingCentral](https://www.ringcentral.com/) — 무료 플랜으로 회당 50분, 최대 100명 참가자 화상회의.
  * [GitBook](https://www.gitbook.com/) — 기술 지식 문서화 플랫폼(제품 문서, 내부 위키, API 등). 개인 개발자용 무료 플랜.
  * [transfernow](https://www.transfernow.net/) — 가장 쉽고 빠르고 안전한 파일 전송/공유 인터페이스. 구독 없이 사진, 영상, 대용량 파일 전송.
  * [paste.sh](https://paste.sh/) — 자바스크립트 및 암호화 기반의 간단한 Paste 사이트.
  * [Revolt.chat](https://revolt.chat/) — [Discord](https://discord.com/)의 오픈소스 대안. 프라이버시 존중, Discord의 대부분 독점 기능을 무료 제공. 100% 무료로, 공식/비공식 플러그인 지원.
  * [Tencent RTC](https://trtc.io/) — 텐센트 실시간 커뮤니케이션(TRTC) 그룹 오디오/영상통화 솔루션. 첫 1년간 월 10,000분 무료.
  * [Pastefy](https://pastefy.app/) - 선택적 클라이언트 암호화, 멀티탭, API, 하이라이트 에디터 등 제공하는 아름답고 간단한 Pastebin.
  * [SiteDots](https://sitedots.com/) - 웹사이트 프로젝트 피드백을 사이트 내에서 직접 공유. 에뮬레이션, 캔버스, 우회 불필요. 완전 무료 티어 제공.

**[⬆️ 맨 위로](#table-of-contents)**

## CMS

  * [acquia.com](https://www.acquia.com/) — Drupal 사이트 호스팅. 개발자용 무료 티어. 무료 개발 도구(Acquia Dev Desktop 등)도 제공.
  * [Contentful](https://www.contentful.com/) — 헤드리스 CMS. 클라우드 기반 콘텐츠 관리 및 제공 API. 무료 Community 공간 1개, 사용자 5명, 2.5만 레코드, 48개 콘텐츠 타입, 2개 로케일 포함.
  * [Cosmic](https://www.cosmicjs.com/) — 헤드리스 CMS 및 API 툴킷. 개발자용 무료 개인 플랜.
  * [Crystallize](https://crystallize.com) — 이커머스 지원 헤드리스 PIM. 내장 GraphQL API. 무료 버전은 무제한 사용자, 1,000개 카탈로그 아이템, 월 5GB 트래픽, 월 2.5만 API 콜 제공.
  * [DatoCMS](https://www.datocms.com/) - 소규모 프로젝트용 무료 티어 제공. GraphQL 기반 CMS. 하위 티어에서 월 10만 콜 제공.
  * [Directus](https://directus.io) — 헤드리스 CMS. 온프레미스 및 클라우드 모두에서 자산과 DB 콘텐츠를 관리할 수 있는 완전 무료 오픈소스 플랫폼. 제한 없음.
  * [FrontAid](https://frontaid.io/) — JSON 콘텐츠를 Git 저장소에 직접 저장하는 헤드리스 CMS. 제한 없음.
  * [kontent.ai](https://www.kontent.ai) - 마케터를 위한 기능을 제공하는 Content-as-a-Service 플랫폼. 개발자 플랜은 두 명의 사용자에게 무제한 프로젝트(각각 2개 환경), 500개 콘텐츠, 2개 언어, Delivery/Management API, 커스텀 요소 지원. 더 자세한 플랜으로 확장 가능.
  * [Prismic](https://www.prismic.io/) — 헤드리스 CMS. 완전 호스팅 및 확장 가능한 API와 콘텐츠 관리 인터페이스 제공. Community 플랜은 사용자 1명에게 무제한 API 콜, 문서, 커스텀 타입, 자산, 로케일 제공. 오픈 콘텐츠/오픈소스 프로젝트용 더 큰 무료 플랜 제공.
  * [Sanity.io](https://www.sanity.io/) - 오픈소스 편집 환경과 실시간 호스팅 데이터 저장소를 갖춘 구조화 콘텐츠 플랫폼. 무제한 프로젝트, 무제한 관리자, 비관리자 3명, 데이터셋 2개, 월 50만 API CDN 요청, 10GB 트래픽, 5GB 자산 무료.
  * [sensenet](https://sensenet.com) - 엔터프라이즈급 API-우선 헤드리스 CMS. 개발자 플랜은 3명, 500개 콘텐츠, 3개 내장 역할, 25+5개 콘텐츠 타입, 완전한 REST API, 문서 미리보기, 오피스 온라인 편집 제공.
  * [TinaCMS](https://tina.io/) — Forestry.io를 대체하는 오픈소스 Git 기반 헤드리스 CMS. Markdown, MDX, JSON 지원. 기본 플랜은 2명까지 무료.
  * [GatsbyjsCMS](https://www.gatsbyjs.com/) - 모든 CMS, API, DB로 웹사이트를 재미있게 빌드할 수 있는 빠르고 유연한 프레임워크. 헤드리스 웹사이트를 빌드·배포하여 더 많은 트래픽, 높은 전환, 수익 증대 가능!
  * [Hygraph](https://hygraph.com/) - 소규모 프로젝트용 무료 티어 제공. GraphQL 기반 API. 레거시 솔루션에서 GraphQL 네이티브 헤드리스 CMS로 전환하여 옴니채널 콘텐츠 API 우선 제공.
* [Squidex](https://squidex.io/) - 소규모 프로젝트를 위한 무료 티어 제공. API / GraphQL 우선. 오픈 소스이며 이벤트 소싱 기반(모든 변경 사항을 자동 버전 관리).
* [InstaWP](https://instawp.com/) - 몇 초 만에 워드프레스 사이트를 시작하세요. 무료 티어로 5개의 활성 사이트, 500MB 공간, 48시간 사이트 만료 제공.
* [Storyblok](https://www.storyblok.com) - 모든 최신 프레임워크와 호환되는 개발자 및 마케터용 헤드리스 CMS. 커뮤니티(무료) 티어는 관리 API, 비주얼 에디터, 10개 소스, 커스텀 필드 타입, 국제화(무제한 언어/로케일), 에셋 관리자(최대 2500개 에셋), 이미지 최적화 서비스, 검색 쿼리, 웹훅 + 월 250GB 트래픽을 포함.
* [WPJack](https://wpjack.com) - 5분 이내에 원하는 클라우드에 워드프레스를 설치하세요! 무료 티어에는 1대의 서버, 2개의 사이트, 무료 SSL 인증서, 무제한 크론 작업이 포함됩니다. 시간 제한이나 만료 없음—당신의 웹사이트, 당신의 방식.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 코드 생성

* [Appinvento](https://appinvento.io/) — AppInvento는 무료 노코드 앱 빌더입니다. 자동 생성된 백엔드 코드에 대해 사용자는 소스 코드 전체와 무제한 API 및 라우트에 접근할 수 있어 광범위한 통합이 가능합니다. 무료 플랜에는 3개 프로젝트, 5개 테이블, Google 애드온이 포함됩니다.
* [Cody AI](https://sourcegraph.com/cody) - Cody는 AI와 코드베이스에 대한 깊은 이해를 활용해 더 빠르게 코드를 작성하고 이해할 수 있도록 돕는 코딩 AI 어시스턴트입니다. 여러 LLM(로컬 추론 포함) 중에서 선택할 수 있고, 다양한 IDE와 연동되며, 모든 인기 프로그래밍 언어를 지원하며 무료 플랜이 있습니다. 무료 플랜은 매월 20개의 채팅 메시지(Claude 3 Sonnet LLM 사용)와 500개의 자동완성(Starcoder 16b 사용)을 제공합니다.
* [DhiWise](https://www.dhiwise.com/) — DhiWise의 혁신적인 코드 생성 기술로 Figma 디자인을 Flutter 및 React 애플리케이션으로 원활하게 변환, 워크플로우를 최적화하고 빠르게 탁월한 모바일 및 웹 경험을 구축할 수 있습니다.
* [Codeium](https://www.codeium.com/) — Codeium은 무료 AI 기반 코드 자동완성 도구입니다. 20개 이상의 프로그래밍 언어(Python, JavaScript, Java, TypeScript, PHP, C/C++, Go 등)를 지원하며 모든 주요 독립 및 웹 IDE와 통합됩니다.
* [Fern](https://buildwithfern.com) - API 정의를 작성하고 이를 바탕으로 TypeScript, Python, Java, Go 등 인기 언어의 SDK/클라이언트 라이브러리를 생성하세요. OpenAPI 완벽 지원. 무료 티어로 최대 20개의 엔드포인트에 대한 코드 생성 가능.
* [Metalama](https://www.postsharp.net/metalama) - C# 전용. Metalama는 컴파일 중에 코드의 보일러플레이트를 즉석에서 생성하여 소스 코드를 깔끔하게 유지합니다. 오픈 소스 프로젝트는 무료이며, 상업적 사용이 가능한 무료 티어에는 3개의 애스펙트가 포함됩니다.
* [Supermaven](https://www.supermaven.com/) — Supermaven은 VSCode, JetBrains, Neovim용 빠른 AI 코드 자동완성 플러그인입니다. 무료 티어는 무제한 인라인 완성을 제공합니다.
* [tabnine.com](https://www.tabnine.com/) — Tabnine은 전 세계의 모든 코드에서 학습한 인사이트로 개발자가 더 나은 소프트웨어를 빠르게 만들 수 있도록 돕습니다. 플러그인 제공.
* [v0.dev](https://v0.dev/) — v0는 AI 모델을 사용하여 간단한 텍스트 프롬프트 기반으로 코드를 생성합니다. shadcn/ui와 Tailwind CSS 기반의 복사-붙여넣기 친화적인 React 코드를 생성하여 프로젝트에 바로 사용할 수 있습니다. 각 생성마다 최소 30 크레딧이 소모되며, 시작 시 1200 크레딧, 매달 200 무료 크레딧이 지급됩니다.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 코드 품질

* [beanstalkapp.com](https://beanstalkapp.com/) — 코드 작성, 리뷰, 배포를 위한 전체 워크플로우, 1명 사용자 및 1개 저장소(100MB 저장공간) 무료 계정 제공
* [browserling.com](https://www.browserling.com/) — 라이브 상호작용 크로스 브라우저 테스트, 무료로 3분 세션(MS IE 9, Vista, 1024 x 768 해상도)만 제공
* [codacy.com](https://www.codacy.com/) — PHP, Python, Ruby, Java, JavaScript, Scala, CSS, CoffeeScript용 자동 코드 리뷰, 무제한 공개/비공개 저장소 무료
* [Codeac.io](https://www.codeac.io/infrastructure-as-code.html?ref=free-for-dev) - DevOps를 위한 자동화된 인프라 코드 리뷰 도구. GitHub, Bitbucket, GitLab(셀프호스트 포함)과 통합. 표준 언어 외에 Ansible, Terraform, CloudFormation, Kubernetes 등도 분석. (오픈 소스 무료)
* [CodeBeat](https://codebeat.co) — 다양한 언어 지원 자동 코드 리뷰 플랫폼. Slack, 이메일 연동. 공개 저장소는 영구 무료.
* [codeclimate.com](https://codeclimate.com/) — 자동 코드 리뷰, 오픈 소스 및 무제한 조직 소유 비공개 저장소(최대 4명 협업자) 무료. 학생 및 기관도 무료.
* [codecov.io](https://codecov.io/) — 코드 커버리지 도구(SaaS), 오픈 소스 및 1개 비공개 저장소 무료
* [CodeFactor](https://www.codefactor.io) — Git용 자동 코드 리뷰. 무료 버전은 무제한 사용자, 공개 저장소, 1개 비공개 저장소 포함.
* [coderabbit.ai](https://coderabbit.ai) — GitHub/GitLab 통합 AI 기반 코드 리뷰 도구. 무료 티어는 시간당 200개 파일, 3회 리뷰, 50회 대화 제공. 오픈 소스 프로젝트는 영구 무료.
* [codescene.io](https://codescene.io/) - 개발자의 작업 방식에 따라 기술 부채를 우선순위화하고 팀 결합 및 시스템 숙련도 등 조직 요인을 시각화. 오픈 소스 무료.
* [CodSpeed](https://codspeed.io) - CI 파이프라인에서 성능 추적 자동화. 배포 전 성능 퇴보를 정밀하고 일관된 지표로 포착. 오픈 소스 프로젝트 영구 무료.
* [coveralls.io](https://coveralls.io/) — 테스트 커버리지 리포트 표시, 오픈 소스 무료
* [dareboost](https://dareboost.com) - 웹 성능, 접근성, 보안을 월 5회 무료 분석
* [deepcode.ai](https://www.deepcode.ai) — DeepCode는 AI를 기반으로 버그, 보안 취약점, 성능 및 API 문제를 찾아줍니다. 분석 속도가 빨라 IDE에서 저장만 해도 실시간 결과 제공. 지원 언어: Java, C/C++, JavaScript, Python, TypeScript. GitHub, BitBucket, GitLab 연동. 오픈 소스 및 비공개 저장소, 최대 30명 개발자까지 무료.
* [deepscan.io](https://deepscan.io) — 자바스크립트 코드 런타임 오류 자동 탐지 고급 정적 분석, 오픈 소스 무료
* [DeepSource](https://deepsource.io/) - 소스 코드 변경 사항을 지속적으로 분석하여 보안, 성능, 안티 패턴, 버그 위험, 문서, 스타일 문제를 탐지 및 수정. GitHub, GitLab, Bitbucket과 네이티브 연동.
* [DiffText](https://difftext.com) - 두 코드 블록의 차이점을 즉시 확인. 완전 무료.
* [eversql.com](https://www.eversql.com/) — EverSQL - 데이터베이스 최적화 1위 플랫폼. 데이터베이스 및 SQL 쿼리에 대한 핵심 인사이트 자동 제공.
* [gerrithub.io](https://review.gerrithub.io/) — GitHub 저장소용 Gerrit 코드 리뷰 무료 제공
* [gocover.io](https://gocover.io/) — 모든 [Go](https://golang.org/) 패키지용 코드 커버리지
* [goreportcard.com](https://goreportcard.com/) — Go 프로젝트 코드 품질, 오픈 소스 무료
* [gtmetrix.com](https://gtmetrix.com/) — 웹사이트 최적화를 위한 리포트 및 상세 권장 사항 제공
* [holistic.dev](https://holistic.dev/) - PostgreSQL 최적화용 1위 정적 코드 분석기. 성능, 보안, 아키텍처 DB 문제 자동 감지 서비스
* [houndci.com](https://houndci.com/) — GitHub 커밋에 코드 품질 코멘트, 오픈 소스 무료
* [Moderne.io](https://app.moderne.io) — 소스 코드 자동 리팩토링. 프레임워크 마이그레이션, 코드 분석 및 수정, 대규모 코드 변환 제공. 개발자가 유지보수 대신 새로운 것에 집중할 수 있게 함. 오픈 소스 무료.
* [reviewable.io](https://reviewable.io/) — GitHub 저장소 코드 리뷰, 공개 또는 개인 저장소 무료
* [parsers.dev](https://parsers.dev/) - 추상 구문 트리 파서 및 중간 표현 컴파일러 서비스 제공
* [scan.coverity.com](https://scan.coverity.com/) — Java, C/C++, C#, JavaScript용 정적 코드 분석, 오픈 소스 무료
* [scrutinizer-ci.com](https://scrutinizer-ci.com/) — 지속적 검사 플랫폼, 오픈 소스 무료
* [semanticdiff.com](https://app.semanticdiff.com/) — GitHub PR 및 커밋용 프로그래밍 언어 인식 diff, 공개 저장소 무료
* [shields.io](https://shields.io) — 오픈 소스 프로젝트용 품질 메타데이터 배지 제공
* [sonarcloud.io](https://sonarcloud.io) — Java, JavaScript, C/C++, C#, VB.NET, PHP, Objective-C, Swift, Python, Groovy 등 다양한 언어용 자동 소스 코드 분석, 오픈 소스 무료
* [SourceLevel](https://sourcelevel.io/) — 자동 코드 리뷰 및 팀 분석. 오픈 소스 및 최대 5명 협업자 조직 무료.
* [webceo.com](https://www.webceo.com/) — SEO 도구이지만 코드 검증 및 다양한 기기별 테스트 제공
* [zoompf.com](https://zoompf.com/) — 웹사이트 성능 개선, 상세 분석 제공

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 코드 검색 및 탐색

* [libraries.io](https://libraries.io/) — 32개 패키지 매니저 지원 검색 및 의존성 업데이트 알림, 오픈 소스 무료
* [Namae](https://namae.dev/) - GitHub, Gitlab, Heroku, Netlify 등 다양한 웹사이트에서 프로젝트명 사용 가능 여부를 검색합니다.
* [searchcode.com](https://searchcode.com/) — 텍스트 기반 코드 전체 검색, 오픈 소스 무료
* [tickgit.com](https://www.tickgit.com/) — `TODO` 등 코멘트로 개선이 필요한 코드 영역을 찾아줌.
* [CodeKeep](https://codekeep.io) - 코드 스니펫 전용 Google Keep. 코드 스니펫을 정리, 검색, 공유하며, 템플릿이 미리 적용된 강력한 코드 스크린샷 도구와 링크 기능 제공.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## CI 및 CD

* [AccessLint](https://github.com/marketplace/accesslint) — AccessLint는 자동 웹 접근성 테스트를 개발 워크플로우에 통합합니다. 오픈 소스 및 교육 목적 무료.
* [appcircle.io](https://appcircle.io) — 엔터프라이즈급 모바일 DevOps 플랫폼으로, 모바일 앱의 빌드, 테스트, 스토어 배포를 자동화해 빠르고 효율적인 릴리즈 사이클 제공. 빌드당 최대 30분, 월 20회 빌드, 1회 동시 빌드 무료.
* [appveyor.com](https://www.appveyor.com/) — Windows용 CD 서비스, 오픈 소스 무료
* [LocalOps](https://localops.co/) - AWS/GCP/Azure에 30분 내 앱 배포. 모든 클라우드에 표준화된 앱 환경을 설정하며, 내장형 CI/CD 자동화 및 고급 관찰성 제공. 무료 플랜은 1명 사용자, 1개 앱 환경 지원.
* [Argonaut](https://argonaut.dev/) - 몇 분 만에 클라우드에 앱과 인프라 배포. Kubernetes 및 Lambda 환경에서 커스텀/서드파티 앱 배포 지원. 무료 티어로 5개 도메인, 2명 사용자에 대해 무제한 앱 및 배포 가능.
* [bitrise.io](https://www.bitrise.io/) — 네이티브/하이브리드 모바일 앱용 CI/CD. 월 200회 무료 빌드, 빌드당 10분, 팀원 2명. OSS 프로젝트는 빌드당 45분, 동시 빌드 +1, 팀원 무제한.
* [buddy.works](https://buddy.works/) — 5개 무료 프로젝트, 1회 동시 실행(월 120회 실행)
* [Buildkite](https://buildkite.com) CI 파이프라인은 3명 사용자, 월 5,000잡 분 무료. Test Analytics 무료 개발자 티어는 월 10만 테스트 실행, 오픈 소스 프로젝트는 추가 무료 제공.
* [bytebase.com](https://www.bytebase.com/) — 데이터베이스 CI/CD 및 DevOps. 20명 사용자, 10개 DB 인스턴스 미만 무료
* [CircleCI](https://circleci.com/) — GitHub, GitLab, BitBucket 저장소용 호스팅 CI/CD 서비스로 모든 기능이 포함된 종합 무료 플랜. 다양한 리소스 클래스, Docker, Windows, Mac OS, ARM 실행기, 로컬 러너, 테스트 분할, Docker 레이어 캐싱 등 고급 기능 제공. 월 최대 6,000분 실행, 무제한 협업자, 비공개 프로젝트 30개 병렬 작업, 오픈 소스 프로젝트는 최대 80,000분 무료 빌드.
* [cirrus-ci.org](https://cirrus-ci.org) - 공개 GitHub 저장소 무료
* [cirun.io](https://cirun.io) - 공개 GitHub 저장소 무료
* [codefresh.io](https://codefresh.io) — Free-for-Life 플랜: 빌드 1회, 환경 1개, 공유 서버, 무제한 공개 저장소
* [codemagic.io](https://codemagic.io/) - 월 500 빌드분 무료
* [codeship.com](https://codeship.com/) — 월 100회 비공개 빌드, 5개 비공개 프로젝트, 오픈 소스는 무제한
* [deploybot.com](https://www.deploybot.com/) — 저장소 1개, 10회 배포, 오픈 소스 무료
* [deployhq.com](https://www.deployhq.com/) — 프로젝트 1개, 하루 10회 배포(월 30분 빌드)
* [drone](https://cloud.drone.io/) - x86 및 Arm(32/64비트) 등 다양한 아키텍처의 CI 파이프라인 제공
* [LayerCI](https://layerci.com) — 풀스택 프로젝트용 CI. 5GB 메모리, 3개 CPU의 풀스택 미리보기 환경 1개 제공.
* [semaphoreci.com](https://semaphoreci.com/) — 오픈 소스 무료, 비공개 빌드 월 100회
* [Squash Labs](https://www.squash.io/) — 브랜치별 VM 생성 및 고유 URL 제공, 무제한 공개/비공개 저장소, 최대 2GB VM 크기 지원.
* [styleci.io](https://styleci.io/) — 공개 GitHub 저장소만 지원
* [Mergify](https://mergify.io) — GitHub용 워크플로우 자동화 및 병합 큐 — 공개 GitHub 저장소 무료
* [Make](https://www.make.com/en) — 앱 연동 및 워크플로우 자동화 도구. 다양한 앱과 인기 API 지원. 공개 GitHub 저장소 무료, 무료 티어는 100MB, 1000회 작업, 최소 15분 간격 지원.
* [Spacelift](https://spacelift.io/) - 인프라 코드 관리 플랫폼. 무료 플랜: IaC 협업, Terraform 모듈 레지스트리, ChatOps 연동, Open Policy Agent 기반 자원 정책 준수, SAML 2.0 SSO, 퍼블릭 워커 풀 접근: 월 최대 200분
* [microtica.com](https://microtica.com/) - 준비된 인프라 컴포넌트로 스타트업 환경, AWS에 무료 앱 배포, 프로덕션 워크로드 지원. 무료 티어: 환경 1개(AWS 계정), Kubernetes 서비스 2개, 월 100분 빌드, 월 20회 배포.
* [Nx Cloud](https://nx.dev/ci) - Nx Cloud는 원격 캐싱, 작업 분산, e2e 테스트 실행 자동 분할 등 기능을 통해 CI에서 모노레포의 속도를 높입니다. 최대 30명의 기여자에게 150,000 크레딧이 포함된 무료 요금제가 제공됩니다.
* [blacksmith](https://www.blacksmith.sh/) - GitHub Actions용 관리형 퍼포먼스 러너로, 월 3,000분 무료, 신용카드 필요 없음.
* [Terramate](https://terramate.io/) - Terramate는 Terraform, OpenTofu, Terragrunt와 같은 IaC(코드형 인프라) 도구의 오케스트레이션 및 관리 플랫폼입니다. 모든 기능 포함, 최대 2명의 사용자까지 무료.
* [Terrateam](https://terrateam.io) - GitOps 중심의 Terraform 자동화로, PR 기반 워크플로우, 자체 호스팅 러너를 통한 프로젝트 분리, 순차 실행을 위한 레이어드 실행 지원. 최대 3명의 사용자까지 무료.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 테스트

* [Applitools.com](https://applitools.com/) — 웹, 네이티브 모바일, 데스크탑 앱을 위한 스마트 비주얼 검증. 거의 모든 자동화 솔루션(Selenium, Karma 등)과 원격 러너(Sauce Labs, Browser Stack 등)와 통합. 오픈 소스는 무료. 주당 제한된 체크포인트로 1인 무료 티어 제공.
* [Appetize](https://appetize.io) — 클라우드 기반 안드로이드/아이폰/아이패드 에뮬레이터로, 브라우저에서 직접 Android & iOS 앱 테스트. 무료 티어는 월 30분 사용, 2개 동시 세션 포함. 앱 크기 제한 없음.
* [Apptim](https://apptim.com) — 성능 엔지니어링 지식 없이도 앱의 성능 및 UX 평가가 가능한 모바일 테스트 도구. 자신의 디바이스로 사용하는 데스크톱 버전은 100% 무료, iOS/Android 무제한 테스트 제공.
* [Argos](https://argos-ci.com) - 개발자를 위한 오픈 소스 비주얼 테스트. 무제한 프로젝트, 월 5,000 스크린샷. 오픈 소스 프로젝트 무료.
* [Bencher](https://bencher.dev/) - CI 성능 저하를 잡는 연속 벤치마킹 도구 모음. 모든 공개 프로젝트 무료.
* [browserstack.com](https://www.browserstack.com/) — 수동 및 자동 브라우저 테스트, [오픈 소스 무료](https://www.browserstack.com/open-source?ref=pricing)
* [BugBug](https://bugbug.io/) - 웹 애플리케이션을 위한 경량 테스트 자동화 도구. 배우기 쉽고 코딩 불필요. 자신의 컴퓨터에서 무제한 테스트 무료 실행. 클라우드 모니터링 및 CI/CD 연동은 월 추가 요금.
* [Checkly](https://checklyhq.com) - 모던 DevOps용 코드 기반 합성 모니터링. 기존 업체 대비 저렴하게 API 및 앱 모니터링. Monitoring as Code 워크플로우와 Playwright 기반. 개발자에게 후한 무료 티어.
* [checkbot.io](https://www.checkbot.io/) — 50개 이상의 SEO, 속도, 보안 모범 사례 준수 여부를 검사하는 브라우저 확장 프로그램. 소규모 웹사이트 무료 티어.
* [CORS-Tester](https://cors-error.dev/cors-tester/) - 개발자 및 API 테스터를 위한 무료 CORS 확인 도구로, 주어진 도메인에 대한 API의 CORS 활성화 여부 및 문제점 파악. 실행 가능한 인사이트 제공.
* [cypress.io](https://www.cypress.io/) - 브라우저에서 실행되는 모든 것에 대한 빠르고 쉬운 신뢰성 높은 테스트. Cypress Test Runner는 항상 무료이자 오픈 소스, 제한 없음. Cypress Dashboard는 오픈 소스 프로젝트 최대 5인까지 무료.
* [Cypress Recorder by Preflight](https://cypress.preflight.com/) - 브라우저에서 AI 기반 Cypress 테스트/POM 모델 생성. AI 기능 제외 오픈 소스. 월 5회 테스트 생성까지 무료, 셀프 힐링 스크립트, 이메일, 비주얼 테스트 포함.
* [everystep-automation.com](https://www.everystep-automation.com/) — 웹 브라우저에서 모든 작업을 기록 및 재생, 스크립트 생성. 옵션 일부 제한 무료.
* [Gremlin](https://www.gremlin.com/gremlin-free-software) — Gremlin의 카오스 엔지니어링 도구로 시스템 장애를 안전하게 주입, 잠재적 약점 탐지. Gremlin Free는 최대 5개 호스트/컨테이너에서 Shutdown 및 CPU 공격 제공.
* [gridlastic.com](https://www.gridlastic.com/) — 무료 플랜으로 최대 4개 동시 Selenium 노드/10회 그리드 시작/월 4,000 테스트 분 제공.
* [katalon.com](https://katalon.com) - 모든 규모의 팀과 다양한 테스트 수준을 지원하는 테스트 플랫폼 제공. Katalon Studio, TestOps(+비주얼 테스트 무료), TestCloud, Katalon Recorder 포함.
* [Keploy](https://keploy.io/) - 개발자를 위한 기능 테스트 툴킷. API 호출을 기록하여 E2E 테스트(KTests) 및 목/스텁(KMocks) 생성. 오픈 소스 프로젝트 무료.
* [knapsackpro.com](https://knapsackpro.com) - 모든 CI에서 최적 테스트 병렬화로 테스트 속도 향상. Ruby, JavaScript 테스트를 병렬 CI 노드에 분배. 테스트 파일 10분까지 무료, 오픈 소스는 무제한 무료.
* [lambdatest.com](https://www.lambdatest.com/) — 수동, 비주얼, 스크린샷, 자동 브라우저 테스트(Selenium, Cypress 지원), [오픈 소스 무료](https://www.lambdatest.com/open-source-cross-browser-testing-tool)
* [loadmill.com](https://www.loadmill.com/) - 네트워크 트래픽 분석을 통한 API 및 부하 테스트 자동 생성. 월 최대 50명 동시 사용자, 60분 무료 시뮬레이션.
* [lost-pixel.com](https://lost-pixel.com) - Storybook, Ladle, Histoire 스토리 및 웹앱용 통합 비주얼 리그레션 테스트. 팀원 무제한, 오픈 소스 완전 무료, 월 7,000 스냅샷.
* [octomind.dev](https://www.octomind.dev/) - AI 보조 테스트 케이스 생성으로 Playwright UI 테스트 자동 생성, 실행 및 유지.
* [percy.io](https://percy.io) - 모든 웹앱, 정적 사이트, 스타일 가이드, 컴포넌트 라이브러리에 비주얼 테스트 추가. 팀원 무제한, 데모 앱, 프로젝트 무제한, 월 5,000 스냅샷.
* [preflight.com](https://preflight.com) - 노코드 자동 웹 테스트. 브라우저에서 UI 변경에 강한 테스트 녹화 및 Windows에서 실행. CI/CD와 연동 가능. 무료 플랜은 월 50회 테스트, 영상, HTML 세션 등 포함.
* [qase.io](https://qase.io) - 개발/QA팀용 테스트 관리 시스템. 테스트 케이스 관리, 실행, 결함 추적, 영향 측정. 핵심 기능 모두 포함 무료 티어, 첨부파일 500MB, 최대 3인.
* [Repeato](https://repeato.app/) 컴퓨터 비전과 AI 기반 노코드 모바일 앱 테스트 자동화 도구. 네이티브, 플러터, 리액트네이티브, 웹, 아이오닉 등 다양한 프레임워크 지원. iOS/Android 각 10회 테스트로 무료 플랜, 유료 기능 대부분 포함, 테스트 실행은 무제한.
* [Requestly](https://requestly.com/) 오픈 소스 Chrome 확장으로 HTTP 요청 가로채기, 리다이렉트, 목(Mock) 지원. [Debugger](https://requestly.com/products/web-debugger/), [Mock Server](https://requestly.com/products/mock-server/), [API Client](https://requestly.com/products/api-client/), [Session Recording](https://requestly.com/products/session-book/) 포함. URL 리다이렉트, HTTP 헤더 수정, API 목킹, JS 삽입, GraphQL 요청 수정, 목 엔드포인트 생성, 세션 기록. 무료 티어 10개 규칙 생성 가능. 오픈 소스 무료.
* [seotest.me](https://seotest.me/) — 무료 온페이지 SEO 사이트 검사기. 하루 10회 웹사이트 크롤링 무료. 기술 무관 모든 사이트에 대한 SEO 학습자료 및 개선 권장 사항 제공.
* [snippets.uilicious.com](https://snippets.uilicious.com) - CodePen과 같은 크로스 브라우저 테스트 플랫폼. 사용자 스토리처럼 테스트 작성, UI-licious Snippets에서 Chrome 테스트 무제한 무료(1회 3분, 회원가입 불필요). 버그 발견 시 테스트 URL 복사로 개발자에게 재현 방법 공유 가능.
* [TestCollab](https://testcollab.com) - 사용하기 쉬운 테스트 관리 소프트웨어, 무료 플랜은 Jira 연동, 프로젝트/테스트케이스 무제한, CSV/XLSx 임포트, 시간 추적, 1GB 파일 저장소 제공.
* [testingbot.com](https://testingbot.com/) — Selenium 브라우저 및 디바이스 테스트, [오픈 소스 무료](https://testingbot.com/open-source)
* [Testspace.com](https://testspace.com/) - 자동 테스트 결과 게시용 대시보드 및 GitHub에서 수동 테스트를 코드로 구현하는 프레임워크. [오픈 소스 무료](https://github.com/marketplace/testspace-com), 월 450건 결과 계정.
* [tesults.com](https://www.tesults.com) — 테스트 결과 리포팅 및 테스트 케이스 관리. 인기 테스트 프레임워크와 연동. 오픈 소스 개발자, 개인, 교육자, 소규모 팀은 기본 무료 프로젝트 외에도 할인 및 무료 제공 요청 가능.
* [UseWebhook.com](https://usewebhook.com) - 브라우저에서 웹훅 캡처 및 검사. localhost로 전달, 히스토리에서 재생 가능. 무료 사용.
* [Vaadin](https://vaadin.com) — Java/TypeScript로 확장 가능한 UI 빌드, 통합 도구/컴포넌트/디자인 시스템 제공. 프로젝트 무제한, 5년 무료 유지보수.
* [websitepulse.com](https://www.websitepulse.com/tools/) — 다양한 무료 네트워크 및 서버 도구.
* [webhook-test.com](https://webhook-test.com) - 통합 중 고유 URL로 웹훅 및 HTTP 요청 디버그·검사. 완전 무료, URL 무제한 생성, 권장사항 제공.
* [webhook.site](https://webhook.site) - 맞춤 URL로 웹훅, 아웃바운드 HTTP 요청, 이메일 검증. 임시 URL/이메일 항상 무료.
* [webhookbeam.com](https://webhookbeam.com) - 웹훅 설정 후 푸시 알림 및 이메일로 모니터링.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 보안 및 PKI

* [aikido.dev](https://www.aikido.dev) — SCA, SAST, CSPM, DAST, 시크릿, IaC, 악성코드, 컨테이너 스캐닝, EOL 등 통합 앱보안 플랫폼. 무료 플랜은 2인, 10개 리포, 1개 클라우드, 2개 컨테이너, 1개 도메인 스캔 포함.
* [alienvault.com](https://www.alienvault.com/open-threat-exchange/reputation-monitor) — 네트워크 내 침해 시스템 탐지
* [Altcha.org](https://altcha.org/anti-spam) - 자연어 처리 및 머신러닝 기반 웹사이트/API용 스팸 필터. 무료 플랜은 도메인 당 일 200회 요청.
* [atomist.com](https://atomist.com/) — 다양한 개발 작업 자동화의 빠르고 편리한 방법. 현재 베타.
* [cloudsploit.com](https://cloudsploit.com/) — Amazon Web Services(AWS) 보안 및 규정 준수 감사/모니터링
* [Public Cloud Threat Intelligence](https://cloudintel.himanshuanand.com/) — 퍼블릭 클라우드 인프라를 겨냥한 높은 신뢰도의 IOC(침해지표) 제공, 일부는 github(https://github.com/unknownhad/AWSAttacks)에서 제공, 전체는 API로 이용 가능
* [CodeNotary.io](https://www.codenotary.io/) — 코드, 파일, 디렉터리, 컨테이너를 공증하는 불변의 증거를 제공하는 오픈 소스 플랫폼
* [crypteron.com](https://www.crypteron.com/) — .NET 및 Java 앱의 데이터 유출 방지용 클라우드 기반 개발자 친화형 보안 플랫폼
* [CyberChef](https://gchq.github.io/CyberChef/) — 복잡한 도구나 프로그래밍 언어 없이 데이터 분석/디코딩/인코딩이 가능한 직관적 웹 앱. 암호화/암호학의 스위스 아미 나이프. 모든 기능 무제한 무료. 오픈 소스이므로 자가 호스팅 가능.
* [DAS](https://signup.styra.com/) — Styra DAS Free, Open Policy Agent(OPA) 권한 정책 생성·배포·관리 위한 전체 라이프사이클 정책 관리
* [Datree](https://www.datree.io/) — Kubernetes 잘못된 구성 방지 위한 오픈 소스 CLI 도구, 매니페스트/Helm 차트가 모범 사례 및 조직 정책 준수하도록 보장
* [Dependabot](https://dependabot.com/) 루비, 자바스크립트, 파이썬, PHP, 엘릭서, 러스트, 자바(Maven/Gradle), .NET, Go, Elm, Docker, Terraform, Git 서브모듈, GitHub Actions용 자동 의존성 업데이트
* [DJ Checkup](https://djcheckup.com) — Django 사이트의 보안 결함 자동 검사 도구. Pony Checkup에서 포크.
* [Doppler](https://doppler.com/) — 앱 시크릿/설정용 범용 시크릿 관리자, 다양한 클라우드 공급자와 동기화 지원. 기본 접근제어 포함, 5인까지 무료.
* [Dotenv](https://dotenv.org/) — .env 파일을 빠르고 안전하게 동기화. 슬랙/이메일 등 불안전한 채널을 통한 .env 공유 방지, 파일 분실 방지. 최대 3명까지 무료.
* [GitGuardian](https://www.gitguardian.com) — 소스 코드 내 시크릿 자동 감지/치유. git 저장소 내 350여종 시크릿/민감 파일 스캔 – 개인/25인 이하 팀 무료.
* [Have I been pwned?](https://haveibeenpwned.com) — 침해 사고 정보 제공 REST API.
* [hostedscan.com](https://hostedscan.com) — 웹앱, 서버, 네트워크 온라인 취약점 스캐너. 월 10회 무료 스캔.
* [Infisical](https://infisical.com/) — 팀 및 인프라 전반의 개발자 시크릿 관리 오픈 소스 플랫폼. 로컬 개발부터 운영/외부 서비스까지. 최대 5명 무료.
* [Internet.nl](https://internet.nl) — IPv6, DNSSEC, HTTPS, DMARC, STARTTLS, DANE 등 최신 인터넷 표준 테스트
* [keychest.net](https://keychest.net) - SSL 만료 관리/구매, CT 데이터베이스 통합
* [letsencrypt.org](https://letsencrypt.org/) — 모든 주요 브라우저에서 신뢰하는 무료 SSL 인증기관
* [meterian.io](https://www.meterian.io/) - Java, Javascript, .NET, Scala, Ruby, NodeJS 프로젝트의 의존성 보안 취약점 모니터링. 개인 프로젝트 1개 무료, 오픈 소스 무제한.
* [Mozilla Observatory](https://observatory.mozilla.org/) — 사이트의 보안 취약점 탐지 및 수정
* [opswat.com](https://www.opswat.com/) — 컴퓨터, 기기, 앱, 설정 보안 모니터링. 25인/30일 기록 무료.
* [openapi.security](https://openapi.security/) - OpenAPI/Swagger 기반 API의 보안 신속 확인용 무료 도구. 회원가입 불필요.
* [pixee.ai](https://pixee.ai) - 자동 제품 보안 엔지니어 역할의 무료 GitHub 봇, Java 코드베이스 취약점 자동 PR로 해결. 곧 타 언어 지원 예정.
* [pyup.io](https://pyup.io) — Python 의존성 보안 취약점 모니터링 및 자동 업데이트. 개인 1개, 오픈 소스 무제한 프로젝트 무료.
* [qualys.com](https://www.qualys.com/community-edition) — 웹앱 취약점 검사, OWASP 위험 감사
* [report-uri.io](https://report-uri.io/) — CSP, HPKP 위반 리포팅
* [ringcaptcha.com](https://ringcaptcha.com/) — 전화번호를 아이디로 활용하는 도구, 무료 이용 가능
* [seclookup.com](https://www.seclookup.com/) - SIEM의 도메인 위협 인디케이터 강화, 도메인 정보 제공, 탐지/대응 향상. [여기서](https://account.seclookup.com/) 5만회 무료 조회.
* [snyk.io](https://snyk.io) — 오픈 소스 의존성 내 보안 취약점 탐지/수정. 오픈 소스 무제한, 개인 프로젝트 월 200회 제한.
* [ssllabs.com](https://www.ssllabs.com/ssltest/) — SSL 웹서버 구성 심층 분석
* [SOOS](https://soos.io) - 오픈 소스 프로젝트 SCA 무제한 무료 스캔. 출시 전 보안 위협 탐지/수정. 간단·효과적인 프로젝트 보호.
* [StackHawk](https://www.stackhawk.com/) 배포 전 파이프라인 내 앱 스캔 자동화, 보안 버그 사전 수정. 단일 앱 무제한 스캔/환경.
* [Sucuri SiteCheck](https://sitecheck.sucuri.net) - 무료 웹사이트 보안 검사 및 악성코드 스캐너
* [Protectumus](https://protectumus.com) - 무료 웹사이트 보안 검사, 사이트 백신, PHP 서버 방화벽(WAF). 무료 등급 등록 시 이메일 알림 제공.
* [TestTLS.com](https://testtls.com) - SSL/TLS 서비스의 서버 구성, 인증서, 체인 등 보안성 테스트. HTTPS에 한정되지 않음.
* [threatconnect.com](https://threatconnect.com) — 위협 인텔리전스: 연구자, 분석가, 사이버 위협 인텔리전스 입문 조직 대상. 최대 3인 무료.
* [tinfoilsecurity.com](https://www.tinfoilsecurity.com/) — 자동 취약점 스캔. 무료 플랜은 주 1회 XSS 스캔.
* [Ubiq Security](https://ubiqsecurity.com/) — 단 3줄 코드로 데이터 암복호화 및 키 관리 자동화. 앱 1개, 월 100만회 암호화 무료.
* [Virgil Security](https://virgilsecurity.com/) — 종단간 암호화, DB 보호, IoT 보안 등 구현용 도구/서비스. 최대 250명 사용자 앱 무료.
* [Vulert](https://vulert.com) - 오픈 소스 의존성 신규 취약점 실시간 모니터링, 코드 접근/설치 없이 수정 제안. 오픈 소스 무료.
* [Escape GraphQL Quickscan](https://escape.tech/) - GraphQL 엔드포인트 1클릭 보안 스캔. 무료, 로그인 불필요.
* [HasMySecretLeaked](https://gitguardian.com/hasmysecretleaked) - 공개 GitHub 저장소, gist, 이슈, 댓글 내 2천만건 노출 시크릿 무료 검색
* [Project Gatekeeper](https://gatekeeper.binarybiology.top/) - 프라이빗 키/CSR 생성, SSL 인증서 디코더, 인증서 매칭, 주문 등 다양한 기능의 All-in-One SSL 툴킷. Let's Encrypt, Google Trust, BuyPass의 무료 SSL 인증서를 TXT 대신 CNAME 레코드로 발급.
**[⬆️ 맨 위로](#table-of-contents)**

## 인증, 인가, 사용자 관리

  * [Aserto](https://www.aserto.com) - 애플리케이션 및 API를 위한 세분화된 인가 서비스. 월 1,000 MAU 및 100 Authorizer 인스턴스까지 무료.
  * [asgardeo.io](https://wso2.com/asgardeo) - SSO, MFA, 패스워드리스 인증 등과의 원활한 통합. 프론트엔드 및 백엔드 앱용 SDK 포함. 월 1,000 MAU 및 5개의 아이덴티티 제공자까지 무료.
  * [Auth0](https://auth0.com/) — 호스팅된 SSO. 무료 플랜에는 25,000 MAU, 무제한 소셜 연결, 커스텀 도메인 등이 포함됨.
  * [Authgear](https://www.authgear.com) - 패스워드리스, OTP, 2FA, SSO를 몇 분 만에 앱에 적용. 모든 프론트엔드 포함. 월 5,000 MAU까지 무료.
  * [Authress](https://authress.io/) — 인증 로그인 및 접근 제어, 모든 프로젝트를 위한 무제한 아이덴티티 제공자 지원. Facebook, Google, Twitter 등. 최초 1,000 API 호출 무료.
  * [Authy](https://authy.com) - 여러 기기에서 2단계 인증(2FA), 백업 지원. Google Authenticator의 대체품. 최대 100회 인증까지 무료.
  * [Cerbos Hub](https://www.cerbos.dev/product-cerbos-hub) - 접근 정책 작성, 테스트, 배포를 위한 완전한 인가 관리 시스템. 세분화된 인가 및 접근 제어, 월 100 활성 프린시플까지 무료.
  * [Clerk](https://clerk.com) — 사용자 관리, 인증, 2FA/MFA, 사전 구축된 로그인/회원가입/프로필 UI 등. 월 10,000 활성 사용자까지 무료.
  * [Cloud-IAM](https://www.cloud-iam.com/) — Keycloak 기반 IAM 서비스. 최대 100명 사용자와 1개 렐름까지 무료.
  * [Corbado](https://www.corbado.com/) — 신규 또는 기존 앱에 패스키 우선 인증 추가. 무제한 MAU 무료.
  * [Descope](https://www.descope.com/) — 고도로 커스터마이즈 가능한 인증 흐름, 노코드 및 API/SDK 방식 모두 지원, 월 7,500 활성 사용자, 50 테넌트(최대 5 SAML/SSO 테넌트) 무료.
  * [duo.com](https://duo.com/) — 웹사이트 또는 앱용 2단계 인증(2FA). 10명까지 무료, 모든 인증 방법, 무제한 통합, 하드웨어 토큰 지원.
  * [Kinde](https://kinde.com/) - 제품에 몇 분 만에 통합 가능한 간단하고 강력한 인증. 7,500 MAU 무료 시작 플랜 제공.
  * [logintc.com](https://www.logintc.com/) — 푸시 알림 기반 2단계 인증(2FA), VPN, 웹사이트, SSH용 10명까지 무료.
  * [MojoAuth](https://mojoauth.com/) - 웹, 모바일 등 어떤 앱이든 몇 분 만에 패스워드리스 인증 구현을 쉽게 지원.
  * [Okta](https://developer.okta.com/signup/) — 사용자 관리, 인증 및 인가. 월 100 활성 사용자까지 무료.
  * [onelogin.com](https://www.onelogin.com/) — IDaaS, SSO 아이덴티티 제공자, 클라우드 SSO IdP, 회사 앱 3개, 개인 앱 5개, 무제한 사용자.
  * [Ory](https://ory.sh/) - AuthN/AuthZ/OAuth2.0/Zero Trust 관리형 보안 플랫폼. 모든 보안 기능 포함된 개발자 계정, 무제한 팀원, 일 200 DAU, 월 25,000 권한 체크 무료.
  * [Permit.io](https://permit.io) - RBAC, ABAC, ReBAC 지원 실시간 업데이트 및 노코드 정책 UI를 갖춘 인가 서비스 플랫폼. 월 1,000 MAU 무료 티어.
  * [Phase Two](https://phasetwo.io) - Keycloak 오픈소스 IAM. 1,000명 사용자, 10개 SSO 연결, Phase Two의 Keycloak 확장 컨테이너( [Organization](https://phasetwo.io/product/organizations/) 확장 포함)로 무료 렐름 제공.
  * [SSOJet](https://ssojet.com/) - 인증 시스템 재구축 없이 엔터프라이즈 SSO 추가. 무료 플랜: 무제한 MAU, 무제한 조직, 2 SSO & 2 SCIM 연결.
  * [Stytch](https://www.stytch.com/) - 인증 및 사기 방지용 API와 SDK를 제공하는 올인원 플랫폼. 월 10,000 MAU, 무제한 조직, 5 SSO 또는 SCIM 연결, 1,000 M2M 토큰 무료.
  * [Stack Auth](https://stack-auth.com) — 개발자 친화적인 오픈소스 인증. 5분 만에 시작 가능. 무료 셀프호스팅 또는 1만 MAU 무료 SaaS 버전 제공.
  * [SuperTokens](https://supertokens.com/) - 앱에 네이티브로 통합되는 오픈소스 사용자 인증 - 빠른 시작과 사용자/개발자 경험 제어 가능. 5,000 MAU까지 무료.
  * [Warrant](https://warrant.dev/) — 앱을 위한 엔터프라이즈급 호스팅 인가 및 접근 제어 서비스. 무료 티어: 월 1백만 API 요청, 1,000개 인가 규칙.
  * [ZITADEL Cloud](https://zitadel.com) — 멀티테넌트(B2B) 지원 올인원 사용자/접근 관리 서비스. 인증 요청 25,000건까지 무료, 모든 보안 기능 포함(OTP, 패스워드리스, 정책 등 무료 제공).
  * [PropelAuth](https://propelauth.com) — 몇 줄의 코드로 모든 규모의 기업에 즉시 판매할 수 있는 인증. 200명 사용자, 1만 트랜잭션 이메일(워터마크: "Powered by PropelAuth")까지 무료.
  * [Logto](https://logto.io/) - 제품의 사용자 인증 및 인가 개발, 보안, 관리. 오픈소스 셀프호스팅 옵션 제공, 5,000 MAU까지 무료.
  * [WorkOS](https://workos.com/) - 최대 1백만 MAU까지 무료 사용자 관리 및 인증. 이메일+비밀번호, 소셜 인증, 매직 인증, MFA 등 지원.


**[⬆️ 맨 위로](#table-of-contents)**

## 모바일 앱 배포 및 피드백

  * [TestApp.io](https://testapp.io) - 모바일 앱이 정상 작동하는지 확인하는 플랫폼. 무료 플랜: 1개 앱, 분석, 무제한 버전/설치, 피드백 수집.
  * [Loadly](https://loadly.io) - iOS & Android 베타앱 배포 서비스, 무제한 다운로드/업로드, 고속 다운로드 등 완전 무료 서비스 제공.
  * [Diawi](https://www.diawi.com) - iOS & Android 앱을 기기에 직접 배포. 무료 플랜: 앱 업로드, 비밀번호 보호 링크, 1일 만료, 10회 설치.
  * [InstallOnAir](https://www.installonair.com) - iOS & Android 앱을 무선으로 배포. 무료 플랜: 무제한 업로드, 비공개 링크, 비회원 2일/회원 60일 만료.
  * [GetUpdraft](https://www.getupdraft.com) - 테스트용 모바일 앱 배포. 무료 플랜: 1개 앱 프로젝트, 3개 버전, 500MB 저장소, 월 100회 앱 설치.
  * [Appho.st](https://appho.st) - 모바일 앱 호스팅 플랫폼. 무료 플랜: 5개 앱, 월 50회 다운로드, 최대 파일 크기 100MB.

**[⬆️ 맨 위로](#table-of-contents)**

## 관리 시스템

  * [bitnami.com](https://bitnami.com/) — 준비된 앱을 IaaS에 배포. AWS 마이크로 인스턴스 1대 관리 무료
  * [Esper](https://esper.io) — Android 기기용 MDM 및 MAM, DevOps 지원. 1명 사용자 라이선스 및 25MB 앱 저장소로 100대 기기 무료 관리.
  * [jamf.com](https://www.jamf.com/) — iPad, iPhone, Mac 기기 관리, 3대까지 무료
  * [Miradore](https://miradore.com) — 디바이스 관리 서비스. 기기 플릿 최신 상태 유지 및 무제한 기기 보안 무료. 기본 기능 무료 제공.
  * [moss.sh](https://moss.sh) - 웹앱/서버 배포 및 관리 지원. 월 25회 git 배포까지 무료
  * [runcloud.io](https://runcloud.io/) - 주로 PHP 프로젝트용 서버 관리. 1대 서버까지 무료.
  * [ploi.io](https://ploi.io/) - 서버/사이트 관리 및 배포 툴. 1대 서버까지 무료.
  * [xcloud.host](https://xcloud.host) — 사용하기 쉬운 UI의 서버 관리 및 배포 플랫폼. 1대 서버 무료 티어 제공.
  * [serveravatar.com](https://serveravatar.com) — PHP 기반 웹 서버 자동 구성 관리/모니터링. 1대 서버까지 무료.

**[⬆️ 맨 위로](#table-of-contents)**

## 메시징 및 스트리밍

  * [Ably](https://www.ably.com/) - 실시간 메시징 서비스, Presence/저장/보장된 전달 지원. 무료 플랜: 월 300만 메시지, 100 동시 접속, 100 채널.
  * [cloudamqp.com](https://www.cloudamqp.com/) — RabbitMQ as a Service. Little Lemur 플랜: 월 100만 메시지, 최대 20 동시 연결, 100 큐, 1만 큐 대기, 다양한 AZ 노드 제공
  * [courier.com](https://www.courier.com/) — 푸시, 인앱, 이메일, 채팅, SMS 등 메시징 채널 단일 API, 템플릿 관리 등 지원. 무료 플랜: 월 1만 메시지.
  * [engagespot.co](https://engagespot.co/) — 사전 구축 인앱 인박스 및 노코드 템플릿 에디터 포함 멀티채널 알림 인프라. 무료 플랜: 월 1만 메시지.
  * [HiveMQ](https://www.hivemq.com/mqtt-cloud-broker/) - 클라우드 네이티브 IoT 메시징 브로커에 MQTT 디바이스 연결. 최대 100대 기기 무료(신용카드 불필요).
  * [knock.app](https://knock.app) – 개발자를 위한 알림 인프라. 인앱, 이메일, SMS, Slack, 푸시 등 단일 API로 전송. 무료 플랜: 월 1만 메시지.
  * [NotificationAPI.com](https://www.notificationapi.com/) — 소프트웨어에 5분 만에 사용자 알림 추가. 무료 플랜: 월 1만 알림 + 100 SMS/자동통화.
  * [Novu.co](https://novu.co) — 개발자를 위한 오픈소스 알림 인프라. 이메일, SMS, 다이렉트, 인앱, 푸시 등 모든 채널 관리용 단순 컴포넌트 및 API. 무료 플랜: 월 3만 알림, 90일 보관.
  * [pusher.com](https://pusher.com/) — 실시간 메시징 서비스. 최대 100 동시 연결, 일 20만 메시지까지 무료
  * [scaledrone.com](https://www.scaledrone.com/) — 실시간 메시징 서비스. 최대 20 동시 연결, 일 10만 이벤트까지 무료
  * [synadia.com](https://synadia.com/ngs) — [NATS.io](https://nats.io) 서비스. 글로벌, AWS, GCP, Azure 지원. 4k 메시지, 50 활성 연결, 월 5GB 데이터 무료.
  * [pubnub.com](https://www.pubnub.com/) - Swift, Kotlin, React용 메시징, 월 100만 트랜잭션 무료. 한 트랜잭션에 다수 메시지 포함 가능.
  * [eyeson API](https://developers.eyeson.team/) - WebRTC(SFU, MCU) 기반 영상통화 API 서비스. 실시간 데이터 인젝션, 레이아웃, 녹화, 웹UI(퀵스타트) 또는 커스텀 UI 패키지. [개발자 무료 티어](https://apiservice.eyeson.com/api-pricing): 월 1,000 회의분 무료.
  * [webpushr](https://www.webpushr.com/) - 웹 푸시 알림 - 최대 1만 구독자, 무제한 푸시, 브라우저 내 메시지 무료
  * [httpSMS](https://httpsms.com) - 안드로이드 폰을 SMS 게이트웨이로 사용해 문자 송수신. 월 200건까지 무료.
  * [EMQX Serverless](https://www.emqx.com/en/cloud/serverless-mqtt) - 확장 가능하고 안전한 서버리스 MQTT 브로커. 월 100만 세션 분 무료(신용카드 불필요).
  * [Pocket Alert](https://pocketalert.app) - iOS/Android 디바이스로 푸시 알림 전송. API/Webhooks 연동, 경고 완전 제어. 무료 플랜: 1개 기기/앱에 일 50건 메시지.
  * [SuprSend](https://www.suprsend.com/) - API 우선 접근 방식의 알림 인프라. 다양한 채널로 트랜잭션/정기/참여 알림 생성 및 발송. 무료 플랜: 월 1만 알림, 다채로운 워크플로우 노드(다이제스트, 배치, 멀티채널, 선호도, 테넌트, 브로드캐스트 등) 포함.

**[⬆️ 맨 위로](#table-of-contents)**

## 로그 관리

  * [bugfender.com](https://bugfender.com/) — 일 10만 로그라인, 24시간 보관 무료
  * [logentries.com](https://logentries.com/) — 월 5GB, 7일 보관 무료
  * [loggly.com](https://www.loggly.com/) — 1인 사용자, 일 200MB, 7일 보관 무료
  * [logz.io](https://logz.io/) — 일 1GB, 1일 보관 무료
  * [ManageEngine Log360 Cloud](https://www.manageengine.com/cloud-siem/) — Manage Engine 기반 로그 관리 서비스. 무료 플랜: 50GB 저장소, 15일 저장, 7일 검색 제공.
  * [papertrailapp.com](https://papertrailapp.com/) — 48시간 검색, 7일 아카이브, 월 50MB 무료
  * [sematext.com](https://sematext.com/logsene) — 일 500MB, 7일 보관 무료
  * [sumologic.com](https://www.sumologic.com/) — 일 500MB, 7일 보관 무료
  * [logflare.app](https://logflare.app/) — 앱당 월 12,960,000건, 3일 보관 무료
  * [logtail.com](https://logtail.com/) — ClickHouse 기반 SQL 호환 로그 관리. 월 1GB, 3일 보관 무료.
  * [logzab.com](https://logzab.com/) — 감사 추적 관리 시스템. 월 1,000 사용자 활동 로그, 1개월 보관, 최대 5개 프로젝트 무료.
  * [openobserve.ai](https://openobserve.ai/) - 월 200GB 인제스션 무료, 15일 보관
**[⬆️ 맨 위로 이동](#table-of-contents)**

## 번역 관리

  * [crowdin.com](https://crowdin.com/) — 오픈 소스용 무제한 프로젝트, 무제한 문자열, 협업자 무료 제공
  * [gitlocalize.com](https://gitlocalize.com) - 비공개 및 공개 저장소 모두에 대해 무료 및 무제한 제공
  * [Lecto](https://lecto.ai/) - 무료 티어가 있는 기계 번역 API(30회 무료 요청, 요청당 1000자 번역). Loco Translate Wordpress 플러그인과 통합.
  * [lingohub.com](https://lingohub.com/) — 최대 3명 사용자까지 무료, 오픈 소스는 항상 무료
  * [localazy.com](https://localazy.com) - 1,000개의 소스 언어 문자열까지 무료, 무제한 언어, 무제한 기여자, 스타트업 및 오픈 소스 혜택 제공
  * [Localeum](https://localeum.com) - 1,000 문자열, 1명 사용자, 무제한 언어, 무제한 프로젝트까지 무료
  * [localizely.com](https://localizely.com/) — 오픈 소스용 무료
  * [Loco](https://localise.biz/) — 2,000개 번역까지 무료, 무제한 번역가, 프로젝트당 10개 언어, 프로젝트당 1,000개 번역 가능 자산
  * [oneskyapp.com](https://www.oneskyapp.com/) — 최대 5명 사용자까지 제한된 무료 에디션, 오픈 소스는 무료
  * [POEditor](https://poeditor.com/) — 1,000개 문자열까지 무료
  * [SimpleLocalize](https://simplelocalize.io/) - 100개의 번역 키까지 무료, 무제한 문자열, 무제한 언어, 스타트업 혜택 제공
  * [Texterify](https://texterify.com/) - 단일 사용자에게 무료
  * [Tolgee](https://tolgee.io) - 제한된 번역량의 무료 SaaS 제공, 영구적으로 무료인 셀프호스팅 버전도 제공
  * [transifex.com](https://www.transifex.com/) — 오픈 소스용 무료
  * [Translation.io](https://translation.io) - 오픈 소스용 무료
  * [Translized](https://translized.com) - 1,000개 문자열, 1명 사용자, 무제한 언어, 무제한 프로젝트까지 무료
  * [webtranslateit.com](https://webtranslateit.com/) — 500개 문자열까지 무료
  * [weblate.org](https://weblate.org/) — 자유 프로젝트에 대해 무료, 무료 티어에서는 최대 10,000개 문자열 소스, 무제한 셀프호스팅 온프레미스 제공
  * [Free PO editor](https://pofile.net/free-po-editor) — 모두에게 무료
  * [Lingo.dev](https://lingo.dev) – 오픈 소스 AI 기반 CLI로 웹 및 모바일 현지화 지원. 직접 LLM을 가져오거나, Lingo.dev 관리 현지화 엔진을 통해 매월 10,000 단어 무료 사용 가능.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 모니터링

  * [UptimeObserver.com](https://uptimeobserver.com) - 5분 간격의 20개 업타임 모니터와 커스터마이징 가능한 상태 페이지 제공, 상업적 사용도 가능. 이메일 및 텔레그램을 통한 무제한 실시간 알림 제공. 신용카드 필요 없음.
  * [Pingmeter.com](https://pingmeter.com/) - 10분 간격의 5개 업타임 모니터. SSH, HTTP, HTTPS, 모든 맞춤 TCP 포트 모니터링 지원.
  * [alerty.ai](https://www.alerty.ai) - FE, BE, DB 등 무료 APM 및 모니터링 + 무료 에이전트 실행.
  * [appdynamics.com](https://www.appdynamics.com/) — 24시간 메트릭 무료, 애플리케이션 성능 관리 에이전트: Java 1개, .NET 1개, PHP 1개, Node.js 1개로 제한
  * [appneta.com](https://www.appneta.com/) — 1시간 데이터 보관 무료
  * [appspector.com](https://appspector.com/) - 원격 iOS/Android/Flutter 디버깅을 위한 미션 컨트롤. 소규모 트래픽(64MB 로그)까지 무료.
  * [assertible.com](https://assertible.com) — 자동화된 API 테스트 및 모니터링. 팀과 개인을 위한 무료 플랜.
  * [bleemeo.com](https://bleemeo.com) - 3대 서버, 5개 업타임 모니터, 무제한 사용자, 무제한 대시보드, 무제한 알림 규칙 무료.
  * [Core Web Vitals History](https://punits.dev/core-web-vitals-historical/) - URL 또는 웹사이트의 Core Web Vitals 이력 확인.
  * [checklyhq.com](https://checklyhq.com) - 개발자를 위한 오픈 소스 E2E/합성 모니터링 및 심층 API 모니터링. 한 명 사용자, 10,000 API & 네트워크/1,500 브라우저 체크 실행 무료 플랜 제공.
  * [cloudsploit.com](https://cloudsploit.com) — AWS 보안 및 구성 모니터링. 무료: 무제한 온디맨드 스캔, 무제한 사용자, 무제한 저장 계정. 구독: 자동 스캔, API 접근 등.
  * [cronitor.io](https://cronitor.io/) - 크론 작업, 웹사이트, API 등 성능 인사이트 및 업타임 모니터링. 5개 모니터 무료 티어 제공.
  * [datadoghq.com](https://www.datadoghq.com/) — 최대 5개 노드까지 무료
  * [deadmanssnitch.com](https://deadmanssnitch.com/) — 크론 작업 모니터링. 1개 스니치(모니터) 무료, 가입 추천 시 더 추가 가능
  * [downtimemonkey.com](https://downtimemonkey.com/) — 60개 업타임 모니터, 5분 간격. 이메일, 슬랙 알림 제공.
  * [economize.cloud](https://economize.cloud) — 클라우드 인프라 비용을 조직화하여 최적화 및 리포트 제공. 매월 Google Cloud Platform에서 $5,000까지 무료.
  * [elastic.co](https://www.elastic.co/solutions/apm) — JS 개발자용 즉각적인 성능 인사이트. 24시간 데이터 보관 무료
  * [fivenines.io](https://fivenines.io/) — 실시간 대시보드 및 알림이 포함된 Linux 서버 모니터링 — 최대 5대 서버까지 60초 간격으로 영구 무료. 신용카드 불필요.
  * [Grafana Cloud](https://grafana.com/products/cloud/) - Grafana Cloud는 메트릭과 로그를 Grafana와 통합하는 관찰 플랫폼. 무료: 3명 사용자, 10개 대시보드, 100개 알림, Prometheus/Graphite 메트릭 저장(10,000 시리즈, 14일 보관), Loki 로그 저장(50GB, 14일 보관)
  * [healthchecks.io](https://healthchecks.io) — 크론 작업 및 백그라운드 작업 모니터링. 최대 20개 체크 무료.
  * [Hydrozen.io](https://hydrozen.io) — 업타임 모니터링 & 상태 페이지, 무료 플랜: 10개 업타임 모니터, 5개 하트비트 모니터, 1개 도메인 모니터 및 1개 상태 페이지 무료 제공.
  * [incidenthub.cloud](https://incidenthub.cloud/) — 클라우드 및 SaaS 상태 페이지 집계 - 20개 모니터, 2개 알림 채널(Slack, Discord) 영구 무료.
  * [inspector.dev](https://www.inspector.dev) - 1분 이내에 완성되는 실시간 모니터링 대시보드, 영구 무료 티어 제공.
  * [instrumentalapp.com](https://instrumentalapp.com) - 최대 500개 메트릭, 3시간 데이터 확인까지 아름답고 사용하기 쉬운 애플리케이션 및 서버 모니터링 무료 제공
  * [keychest.net/speedtest](https://keychest.net/speedtest) - Digital Ocean 대상 독립 속도 테스트 및 TLS 핸드셰이크 지연 테스트
  * [letsmonitor.org](https://letsmonitor.org) - SSL 모니터링, 최대 5개 모니터 무료
  * [linkok.com](https://linkok.com) - 온라인 링크 깨짐 검사, 최대 100페이지 소규모 웹사이트 무료, 오픈 소스 프로젝트는 완전 무료.
  * [loader.io](https://loader.io/) — 제한된 무료 부하 테스트 도구
  * [MonitorMonk](https://monitormonk.com) - 미니멀한 업타임 모니터링, 아름다운 상태 페이지. Forever Free 플랜에서 HTTPS, 키워드, SSL, 응답시간 모니터링을 10개 웹사이트/API 엔드포인트, 2개 대시보드/상태 페이지까지 제공.
  * [netdata.cloud](https://www.netdata.cloud/) — Netdata는 실시간 메트릭 수집용 오픈 소스 도구. GitHub에도 있음.
  * [newrelic.com](https://www.newrelic.com) — New Relic 관찰 플랫폼. 단일 무료 전체 액세스 사용자, 무제한 무료 기본 사용자, 월 100GB 무료 데이터 수집 제공.
  * [Middleware.io](https://middleware.io/) - 미들웨어 관찰 플랫폼으로 앱 및 스택 전체 가시성 제공. 개발자 커뮤니티용 영구 무료 플랜: 1M 로그 이벤트까지 로그 모니터링, 2대 호스트까지 인프라 모니터링 & APM 제공.
  * [nixstats.com](https://nixstats.com) - 한 대 서버 무료. 이메일 알림, 공개 상태 페이지, 60초 간격 등 제공.
  * [OnlineOrNot.com](https://onlineornot.com/) - 웹사이트 및 API 업타임 모니터링, 크론 작업/스케줄 작업 모니터링, 상태 페이지 제공. 3분 간격 5개 체크 무료. 슬랙, 디스코드, 이메일 알림 지원.
  * [OntarioNet.ca CN Test](https://cntest.ontarionet.ca) — 중국의 만리방화벽(GFW) 우회 여부 확인. 중국 내/미국 내 서버의 DNS 결과 및 ASN 정보 비교로 DNS 오염 감지.
  * [opsgenie.com](https://www.opsgenie.com/) — 연중무휴 운영 서비스의 강력한 알림 및 온콜 관리. 최대 5명 사용자까지 무료.
  * [paessler.com](https://www.paessler.com/) — 강력한 인프라 및 네트워크 모니터링 솔루션, 알림, 시각화, 기본 리포트 제공. 최대 100개 센서까지 무료.
  * [pagecrawl.io](https://pagecrawl.io/) - 웹사이트 변경 모니터링, 최대 6개 모니터, 일일 체크 무료.
  * [syagent.com](https://syagent.com/) — 비상업용 무료 서버 모니터링 서비스, 알림 및 메트릭 제공.
  * [pagerly.io](https://pagerly.io/) - Slack에서 온콜 관리(Pagerduty, OpsGenie와 통합). 1팀(온콜 1회)까지 무료.
  * [pagertree.com](https://pagertree.com/) - 간편한 알림 및 온콜 관리 인터페이스. 최대 5명 사용자까지 무료.
  * [phare.io](https://phare.io/) - 무제한 프로젝트, 무제한 상태 페이지에 대해 100,000 이벤트까지 업타임 모니터링 무료.
  * [pingbreak.com](https://pingbreak.com/) — 현대적인 업타임 모니터링 서비스. 무제한 URL 체크, Discord/Slack/이메일 다운타임 알림.
  * [pingpong.one](https://pingpong.one/) — 모니터링이 포함된 고급 상태 페이지 플랫폼. 무료 티어: SSL 서브도메인이 포함된 1개 공개 상태 페이지. 오픈 소스 및 비영리단체에 Pro 플랜 무료 제공.
  * [robusta.dev](https://home.robusta.dev/) — Prometheus 기반 강력한 Kubernetes 모니터링. Prometheus 직접 사용 또는 올인원 번들 설치. 무료 티어: 최대 20개 Kubernetes 노드, Slack/Microsoft Teams/Discord 등 다양한 알림, PagerDuty/Datadog 등 다양한 연동.
  * [sematext.com](https://sematext.com/) — 24시간 메트릭 무료, 무제한 서버, 10개 맞춤 메트릭, 50만 개 맞춤 메트릭 데이터 포인트, 무제한 대시보드/사용자 등.
  * [sitemonki.com](https://sitemonki.com/) — 웹사이트, 도메인, 크론 & SSL 모니터링, 각 카테고리별로 5개 무료
  * [sitesure.net](https://sitesure.net) - 웹사이트 및 크론 모니터링 - 2개 모니터 무료
  * [skylight.io](https://www.skylight.io/) — 처음 100,000 요청까지 무료(Rails 전용)
  * [speedchecker.xyz](https://probeapi.speedchecker.xyz/) — 성능 모니터링 API, Ping, DNS 등 체크 가능
  * [stathat.com](https://www.stathat.com/) — 10개 통계까지 무료, 만료 없음
  * [statuscake.com](https://www.statuscake.com/) — 웹사이트 모니터링, 무제한 테스트 무료(일부 제한 있음)
  * [statusgator.com](https://statusgator.com/) — 상태 페이지 모니터링, 3개 모니터 무료
  * [SweetUptime](https://dicloud.net/sweetuptime-server-uptime-monitoring/) — 서버 모니터링, 업타임 모니터링, DNS & 도메인 모니터링. 서버 10대, 업타임 10개, 도메인 10개 무료.
  * [thousandeyes.com](https://www.thousandeyes.com/) — 네트워크 및 사용자 경험 모니터링. 3개 위치 및 20개 주요 웹서비스 데이터 피드 무료
  * [uptimetoolbox.com](https://uptimetoolbox.com/) — 5개 웹사이트 무료 모니터링, 60초 간격, 공개 상태 페이지.
  * [zenduty.com](https://www.zenduty.com/) — 네트워크 운영, SRE, DevOps를 위한 엔드투엔드 인시던트 관리, 알림, 온콜 관리, 대응 플랫폼. 최대 5명 사용자까지 무료.
  * [instatus.com](https://instatus.com) - 10초 만에 아름다운 상태 페이지 생성. 무제한 구독자 및 무제한 팀과 함께 영구 무료.
  * [Squadcast.com](https://squadcast.com) - 엔드투엔드 인시던트 관리 소프트웨어, SRE 베스트 프랙티스 지원. 최대 10명 사용자까지 영구 무료 플랜 제공.
  * [RoboMiri.com](https://robomiri.com/) - 다양한 모니터 제공: 크론잡, 키워드, 웹사이트, 포트, 핑 등. 3분 간격 25개 업타임 체크 무료. 전화, SMS, 이메일, 웹훅 알림 지원.
  * [Better Stack](https://betterstack.com/better-uptime) - 업타임 모니터링, 인시던트 관리, 온콜 스케줄/알림, 상태 페이지를 하나로. 무료 플랜: 3분 체크 10개 모니터, 상태 페이지 포함.
  * [Pulsetic](https://pulsetic.com) - 10개 모니터, 6개월 업타임/로그 이력, 무제한 상태 페이지 및 커스텀 도메인 포함! 무제한 이메일 알림, 신용카드 필요 없음.
  * [Wachete](https://www.wachete.com) - 5개 페이지 모니터, 24시간마다 체크.
  * [Xitoring.com](https://xitoring.com/) — 업타임 모니터링: 20개 무료, Linux/Windows 서버 모니터링: 5개 무료, 상태 페이지: 1개 무료 - 모바일 앱, 다양한 알림 채널 등 지원.
  * [Servervana](https://servervana.com) - 대규모 프로젝트 및 팀 지원 고급 업타임 모니터링. HTTP, 브라우저, DNS, 도메인 모니터링 및 상태 페이지 등 제공. 무료 티어: HTTP 모니터 10개, DNS 모니터 1개, 상태 페이지 1개.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 크래시 및 예외 처리

* [CatchJS.com](https://catchjs.com/) - 스크린샷과 클릭 트레일이 포함된 JavaScript 오류 추적. 오픈 소스 프로젝트에 무료 제공.
* [bugsnag.com](https://www.bugsnag.com/) — 초기 체험 후 월 2,000건 오류까지 무료
* [elmah.io](https://elmah.io/) — 웹 개발자를 위한 오류 로깅 및 가동 시간 모니터링. 오픈 소스 프로젝트에 Small Business 구독 무료 제공.
* [Embrace](https://embrace.io/) — 모바일 앱 모니터링. 연간 100만 사용자 세션까지 소규모 팀에 무료 제공.
* [exceptionless](https://exceptionless.com) — 실시간 오류, 기능, 로그 보고 등. 월 3,000 이벤트/1 사용자 무료. 오픈 소스 및 무제한 사용을 위한 셀프 호스팅 지원.
* [GlitchTip](https://glitchtip.com/) — 간단한 오픈 소스 오류 추적. 오픈 소스 Sentry SDK와 호환. 월 1,000 이벤트 무료, 또는 제한 없이 셀프 호스팅 가능
* [honeybadger.io](https://www.honeybadger.io) - 예외, 가동 시간, 크론 모니터링. 소규모 팀 및 오픈 소스 프로젝트에 무료(월 12,000 오류).
* [memfault.com](https://memfault.com) — 클라우드 디바이스 관측 및 디버깅 플랫폼. [Nordic](https://app.memfault.com/register-nordic), [NXP](https://app.memfault.com/register-nxp), [Laird](https://app.memfault.com/register-laird) 디바이스 100대 무료.
* [rollbar.com](https://rollbar.com/) — 예외 및 오류 모니터링, 월 5,000 오류까지 무료 플랜, 무제한 사용자, 30일 보관
* [sentry.io](https://sentry.io/) — Sentry는 앱 예외를 실시간으로 추적하며 소규모 무료 플랜을 제공. 월 5,000 오류/1 사용자 무료, 셀프 호스팅 시 무제한 사용
* [Axiom](https://axiom.co/) — 최대 0.5TB 로그 저장, 30일 보관. Vercel 등과의 통합 및 고급 데이터 쿼리, 이메일/Discord 알림 포함.
* [Semaphr](https://semaphr.com) — 모바일 앱을 위한 무료 올인원 킬 스위치.
* [Jam](https://jam.dev) - 개발자 친화적 1클릭 버그 리포트. 무제한 잼으로 무료 플랜 제공.
* [Whitespace](https://whitespace.dev) – 브라우저에서 바로 1클릭 버그 리포트. 개인 용도에 대해 무제한 녹화 무료 플랜.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## Search

* [algolia.com](https://www.algolia.com/) — 오타 허용, 연관성, UI 라이브러리가 포함된 호스팅 검색 솔루션. 무료 "Build" 플랜에 1M 문서, 월 10K 검색 제공. [개발자 문서 검색](https://docsearch.algolia.com/)도 무료 제공.
* [bonsai.io](https://bonsai.io/) — 1GB 메모리 및 1GB 저장소 무료
* [CommandBar](https://www.commandbar.com/) - 통합 검색바 서비스, 웹 기반 UI 위젯/플러그인으로 제품 내 콘텐츠, 내비게이션, 기능 등을 검색할 수 있게 하여 탐색성 향상. 월 활성 사용자 1,000명까지 무료, 무제한 명령.
* [Orama Cloud](https://orama.com/pricing) — 3 인덱스, 인덱스당 10만 문서, 무제한 전문/벡터/하이브리드 검색, 60일 분석 무료
* [searchly.com](http://www.searchly.com/) — 2 인덱스, 20MB 저장소 무료
* [easysitesearch.com](https://easysitesearch.com/) — 자동 웹 크롤러 기반 인덱싱의 검색 위젯 및 API. 최대 50개 하위 페이지에 대해 무제한 검색 무료.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## Education and Career Development

* [FreeCodeCamp](https://www.freecodecamp.org/) - 데이터 분석, 정보 보안, 웹 개발 등 무료 강의와 인증을 제공하는 오픈 소스 플랫폼.
* [The Odin Project](https://www.theodinproject.com/) - 웹 개발을 위한 JavaScript 및 Ruby 중심 커리큘럼의 무료 오픈 소스 플랫폼.
* [Free Professional Resume Templates & Editor](https://www.overleaf.com/latex/templates/tagged/cv) - 숙련된 전문가 이력서 템플릿을 무료로 복제, 완전 편집 및 다운로드할 수 있는 플랫폼, ATS 최적화.
* [DeepLearning.AI Short Courses](https://www.deeplearning.ai/short-courses/) - 업계 최고의 전문가로부터 최신 생성형 AI 도구와 기법을 1시간 이내에 실습할 수 있는 무료 단기 강좌.
* [LabEx](https://labex.io) - Linux, DevOps, 사이버보안, 프로그래밍, 데이터 과학 등 대화형 실습과 실전 프로젝트로 역량 개발.
* [Roadmap.sh](https://roadmap.sh) - 블록체인부터 UX 디자인까지 개발의 모든 측면을 아우르는 무료 학습 로드맵 제공.
* [Cisco Networking Academy, Skills for All](https://skillsforall.com/) - 사이버보안, 네트워킹, Python 등 무료 자격증 연계 강의 제공.
* [MIT OpenCourseWare](https://ocw.mit.edu/) - 2,500개 이상의 MIT 강의 자료를 온라인으로 무료 제공. 전 세계 학습자 및 교육자를 위한 지식 공유. Youtube 채널: [@mitocw](https://www.youtube.com/@mitocw/featured)
* [W3Schools](https://www.w3schools.com/) - HTML, CSS, JavaScript 등 웹 개발 기술에 대한 무료 튜토리얼 제공.
* [Khan Academy](https://www.khanacademy.org/computing/computer-programming) - 기본 및 고급 HTML/CSS, JavaScript, SQL 학습을 위한 무료 온라인 가이드.
* [Full Stack Open](https://fullstackopen.com/en/) – React, Node.js, GraphQL, TypeScript 등 최신 웹 개발을 다루는 대학 수준의 무료 온라인 강의, 자율 진행 가능.
* [edX](https://www.edx.org/) - 하버드, MIT 등 250개 주요 기관의 무료 온라인 강의 4,000여 개 제공. 컴퓨터 과학, 공학, 데이터 과학 등 전문 분야 특화.
* [Django-tutorial.dev](https://django-tutorial.dev) - Django를 처음 배우는 이들을 위한 무료 온라인 가이드 및 사용자 작성 기사에 무료 dofollow 백링크 제공.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## Email

* [10minutemail](https://10minutemail.com) - 테스트용 무료 임시 이메일.
* [AhaSend](https://ahasend.com) - 트랜잭션 이메일 서비스, 월 1,000건 무료, 무료 플랜에 무제한 도메인, 팀원, 웹훅, 메시지 라우트 포함.
* [AnonAddy](https://anonaddy.com) - 오픈 소스 익명 이메일 포워딩, 무제한 이메일 별칭 무료 생성
* [Antideo](https://www.antideo.com) — 무료 티어에서 시간당 10건 이메일 검증, IP, 전화번호 검증 API. 신용카드 불필요.
* [Brevo](https://www.brevo.com/) — 월 9,000건, 일 300건 무료 이메일 제공
* [OneSignal](https://onesignal.com/) — 월 10,000건 이메일, 신용카드 불필요.
* [Bump](https://bump.email/) - 10개의 Bump 이메일 주소, 1개 커스텀 도메인 무료
* [Burnermail](https://burnermail.io/) – 5개의 버너 이메일 주소, 1개 메일박스, 7일 메일박스 기록 무료
* [Buttondown](https://buttondown.email/) — 뉴스레터 서비스. 최대 100명 구독자 무료
* [CloudMailin](https://www.cloudmailin.com/) - HTTP POST 및 트랜잭션 발송용 인커밍 이메일 – 월 10,000건 무료
* [Contact.do](https://contact.do/) — 링크로 제공되는 연락처 폼(연락처 폼의 bitly)
* [debugmail.io](https://debugmail.io/) — 개발자를 위한 사용하기 쉬운 테스트 메일 서버
* [DNSExit](https://dnsexit.com/) - 도메인당 최대 2개 이메일, 100MB 저장 공간 무료. IMAP, POP3, SMTP, SPF/DKIM 지원.
* [EmailLabs.io](https://emaillabs.io/en) — 매월 최대 9,000건, 일 300건 이메일 무료 발송.
* [EmailOctopus](https://emailoctopus.com) - 최대 2,500명 구독자, 월 10,000건 이메일 무료
* [EmailJS](https://www.emailjs.com/) – 전체 이메일 서버가 아니라, 클라이언트에서 자격 증명 노출 없이 이메일을 보낼 수 있는 이메일 클라이언트. 무료 티어는 월 200건 요청, 2개 이메일 템플릿, 50Kb 이하 요청, 제한된 연락처 기록 제공.
* [EtherealMail](https://ethereal.email) - Ethereal은 Nodemailer 및 EmailEngine 사용자를 위한 가짜 SMTP 서비스(타겟이지만 제한 없음). 메시지가 실제로 전송되지 않는 완전 무료 반-트랜잭션 이메일 서비스.
* [Temp-Mail.org](https://temp-mail.org/en/) - 다양한 도메인을 활용한 임시/일회용 메일 생성. 페이지 새로고침 시마다 이메일 주소 갱신. 완전 무료, 별도 요금 없음.
* [TempMailDetector.com](https://tempmaildetector.com/) - 이메일이 임시인지 아닌지 월 200건까지 무료 검증.
* [Emailvalidation.io](https://emailvalidation.io) - 월 100건 무료 이메일 검증
* [FakeMailGenerator.com](https://www.fakemailgenerator.com/) - 독일산 임시/일회용 메일 생성기. 10개 도메인 지원, 무제한 주소 생성 자유 제공(광고 포함), 별도 요금 없음.
* [forwardemail.net](https://forwardemail.net) — 커스텀 도메인을 위한 무료 이메일 포워딩. 도메인으로 무제한 이메일 주소 생성 및 포워딩(**참고**: .casa, .cf, .click, .email, .fit, .ga, .gdn, .gq, .lat, .loan, .london, .men, .ml, .pl, .rest, .ru, .tk, .top, .work TLD 사용 시 요금 부과)
* [Imitate Email](https://imitate.email) - 빌드/QA 및 CI/CD 환경에서 이메일 기능 테스트용 샌드박스 이메일 서버. 무료 계정은 하루 15건 이메일 영구 제공.
* [ImprovMX](https://improvmx.com) – 무료 이메일 포워딩.
* [EForw](https://www.eforw.com) – 1개 도메인 무료 이메일 포워딩. 도메인으로 이메일 수신/발신 가능.
* [Inboxes App](https://inboxesapp.com) — 하루 3개 임시 이메일 생성 후, 크롬 확장 내에서 바로 삭제 가능. 가입 플로우 테스트에 적합.
* [inboxkitten.com](https://inboxkitten.com/) - 무료 임시/일회용 이메일 인박스, 최대 3일 후 자동 삭제. 오픈 소스, 셀프 호스팅 가능.
* [mail-tester.com](https://www.mail-tester.com) — 이메일의 DNS/SPF/DKIM/DMARC 설정 검사, 월 20건 무료.
* [dkimvalidator.com](https://dkimvalidator.com/) - 이메일의 DNS/SPF/DKIM/DMARC 설정 검사, roundsphere.com의 무료 서비스
* [mailcatcher.me](https://mailcatcher.me/) — 메일을 수집하고 웹 인터페이스를 통해 제공.
* [mailchannels.com](https://www.mailchannels.com) - REST API 및 SMTP 통합 지원 이메일 API, 월 최대 3,000건 무료.
* [Mailcheck.ai](https://www.mailcheck.ai/) - 사용자가 임시 이메일 주소로 가입하는 것 차단, 시간당 120회 요청(~월 86,400회)
* [Mailchimp](https://mailchimp.com/) — 500명 구독자, 월 1,000건 이메일 무료.
* [Maildroppa](https://maildroppa.com) - 최대 100명 구독자 및 무제한 이메일, 자동화까지 무료.
* [MailerLite.com](https://www.mailerlite.com) — 월 1,000명 구독자, 12,000건 이메일 무료
* [MailerSend.com](https://www.mailersend.com) — 이메일 API, SMTP, 트랜잭션 이메일 월 3,000건 무료
* [mailinator.com](https://www.mailinator.com/) — 원하는 인박스 사용 가능한 무료 공개 이메일 시스템
* [Mailjet](https://www.mailjet.com/) — 월 6,000건 이메일 무료(일일 발송 200건 제한)
* [Mailnesia](https://mailnesia.com) - 자동으로 등록 링크 방문하는 무료 임시/일회용 이메일
* [mailsac.com](https://mailsac.com) - 임시 이메일 테스트용 무료 API, 무료 공개 이메일 호스팅, 아웃바운드 캡처, 이메일-슬랙/웹소켓/웹훅(월 1,500 API 제한)
* [Mailtrap.io](https://mailtrap.io/) — 개발용 가짜 SMTP 서버, 무료 플랜은 인박스 1개, 메시지 100개, 팀원 없음, 초당 2건 이메일, 포워드 규칙 없음.
* [Mail7.io](https://www.mail7.io/) — QA 개발자를 위한 무료 임시 이메일 주소. 웹 인터페이스 또는 API로 즉시 생성.
* [Momentary Email](https://www.momentaryemail.com/) — 무료 임시 이메일 주소. 웹사이트 또는 RSS 피드로 수신 이메일 확인 가능.
* [Mutant Mail](https://www.mutantmail.com/) – 10개 이메일 ID, 1개 도메인, 1개 메일박스 무료. 모든 이메일 ID를 한 메일박스에서 관리.
* [Outlook.com](https://outlook.live.com/owa/) - 무료 개인 이메일 및 캘린더.
* [Parsio.io](https://parsio.io) — 무료 이메일 파서(이메일 포워딩, 데이터 추출, 서버로 전송)
* [pepipost.com](https://pepipost.com) — 첫 달 3만 건 무료, 이후 일 100건 무료.
* [Plunk](https://useplunk.com) - 월 3,000건 이메일 무료
* [Postmark](https://postmarkapp.com/) - 월 100건 이메일 무료, 무제한 DMARC 주간 요약.
* [Proton Mail](https://proton.me/mail) - 내장 종단 간 암호화 제공하는 무료 보안 이메일 서비스. 1GB 무료 저장 공간.
* [Queuemail.dev](https://queuemail.dev) — 신뢰성 높은 이메일 전송 API. 무료 티어(월 10,000건). 비동기 전송. 여러 SMTP 서버 사용 가능. 차단 목록, 로깅, 추적, 웹훅 등 지원.
* [QuickEmailVerification](https://quickemailverification.com) — 무료 티어에서 일일 100건 이메일 검증 및 DEA 탐지, DNS 조회, SPF 탐지 등 다양한 무료 API 제공.
* [Resend](https://resend.com) - 개발자를 위한 트랜잭션 이메일 API. 월 3,000건, 일 100건 무료, 1개의 커스텀 도메인 제공.
* [Sender](https://www.sender.net) 월 15,000건 이메일, 최대 2,500명의 구독자까지 무료
* [Sendpulse](https://sendpulse.com) — 월 500명의 구독자, 월 15,000건 이메일 무료
* [SimpleLogin](https://simplelogin.io/) – 오픈 소스, 자체 호스팅 가능한 이메일 별칭/포워딩 솔루션. 5개의 별칭, 무제한 대역폭, 무제한 답장/발송 무료. 교육 종사자(학생, 연구원 등)에게 무료 제공.
* [Substack](https://substack.com) — 무제한 무료 뉴스레터 서비스. 유료로 전환 시 결제 시작.
* [Sweego](https://www.sweego.io/) - 유럽 개발자를 위한 트랜잭션 이메일 API. 하루 500건 이메일 무료.
* [Takeout](https://takeout.bysourfruit.com) - 이메일 전송을 쉽게 만들어주는 지속적으로 업데이트되는 이메일 서비스. 월 500건 트랜잭션 이메일 무료.
* [temp-mail.io](https://temp-mail.io) — 여러 이메일 동시 생성 및 포워딩이 가능한 무료 일회용 임시 이메일 서비스
* [tinyletter.com](https://tinyletter.com/) — 월 5,000명 구독자 무료
* [Touchlead](https://touchlead.app) - 리드 관리, 폼 빌더, 자동화가 가능한 다목적 마케팅 자동화 도구. 리드와 자동화 개수 제한 내에서 무료 제공
* [trashmail.com](https://www.trashmail.com) - 포워딩 및 자동 주소 만료 기능이 있는 무료 일회용 이메일 주소
* [Tuta](https://tuta.com/) - 내장형 종단 간 암호화, 광고 및 추적 없는 무료 보안 이메일 계정 서비스. 무료 1GB 저장공간, 1개 캘린더 제공([유료 요금제](https://tuta.com/pricing)도 있음). Tuta는 부분적으로 [오픈 소스](https://github.com/tutao/tutanota)로, 자체 호스팅도 가능.
* [Verifalia](https://verifalia.com/email-verification-api) — 실시간 이메일 검증 API, 메일박스 확인 및 일회용 이메일 감지; 하루 25건 이메일 검증 무료.
* [verimail.io](https://verimail.io/) — 대량 및 API 이메일 검증 서비스. 월 100건 무료 검증
* [Zoho](https://www.zoho.com) — 이메일 제공자로 시작했으나 현재는 다양한 서비스 제공, 일부 무료 요금제 존재. 무료 요금제 서비스 목록:
   - [Email](https://zoho.com/mail) 5명 사용자 무료. 1인당 5GB, 첨부파일 25MB 제한, 1개 도메인.
   - [Zoho Assist](https://www.zoho.com/assist) — 1개 동시 원격지원 라이선스 및 5대 무인 컴퓨터 무제한 사용. 업무 및 개인 모두 무료.
   - [Sprints](https://zoho.com/sprints) 5명 사용자, 5개 프로젝트, 500MB 저장공간 무료.
   - [Docs](https://zoho.com/docs) — 5명 사용자, 1GB 업로드, 5GB 저장공간 무료. Zoho 오피스 번들 포함(Writer, Sheets & Show).
   - [Projects](https://zoho.com/projects) — 3명 사용자, 2개 프로젝트, 10MB 첨부파일 제한 무료. 동일 플랜이 [Bugtracker](https://zoho.com/bugtracker)에도 적용.
   - [Connect](https://zoho.com/connect) — 25명 팀 협업 무료, 3개 그룹/커스텀앱/보드/매뉴얼, 10개 통합 제공. 채널, 이벤트, 포럼 포함.
   - [Meeting](https://zoho.com/meeting) — 최대 3명 미팅, 10명 웨비나 참석자.
   - [Vault](https://zoho.com/vault) — 개인용 비밀번호 관리 무료.
   - [Showtime](https://zoho.com/showtime) — 최대 5명 참석자 원격 교육용 미팅 소프트웨어.
   - [Notebook](https://zoho.com/notebook) — 에버노트 대체 무료 메모 앱.
   - [Wiki](https://zoho.com/wiki) — 3명 사용자, 50MB 저장공간, 무제한 페이지, ZIP 백업, RSS & Atom 피드, 접근제어, CSS 커스터마이징.
   - [Subscriptions](https://zoho.com/subscriptions) — 반복 결제 관리, 20명 고객/구독 및 1명 사용자 무료, 결제 호스팅 제공. 최근 40건 구독 지표 저장.
   - [Checkout](https://zoho.com/checkout) — 3개 상품, 50건 결제 관리 무료.
   - [Desk](https://zoho.com/desk) — 3명 상담원, 프라이빗 지식베이스, 이메일 티켓 등 고객 지원 무료. [Assist](https://zoho.com/assist)와 연동, 1명 원격 기술자 및 5대 무인 컴퓨터 지원.
   - [Cliq](https://zoho.com/cliq) — 팀 채팅, 100GB 저장, 무제한 사용자, 채널당 100명, SSO 제공.
   - [Campaigns](https://zoho.com/campaigns) - 이메일 마케팅
   - [Forms](https://zoho.com/forms) - 폼 생성기
   - [Sign](https://zoho.com/sign) - 전자 서명
   - [Surveys](https://zoho.com/surveys) - 온라인 설문조사
   - [Bookings](https://zoho.com/bookings) - 예약 관리
* [Maileroo](https://maileroo.com) - 개발자를 위한 SMTP 릴레이 및 이메일 API. 월 5,000건 이메일, 무제한 도메인, 무료 이메일 검증, 블랙리스트 모니터링, 메일 테스터 등 제공.

**[⬆️ 맨 위로](#table-of-contents)**

## Feature Toggles 관리 플랫폼

* [ConfigCat](https://configcat.com) - 개발자 중심의 기능 플래그 서비스. 팀 인원 무제한, 우수한 지원, 합리적 가격. 무료 플랜: 10개 플래그, 2개 환경, 1개 제품, 월 5백만 요청까지.
* [Flagsmith](https://flagsmith.com) - 웹, 모바일, 서버 애플리케이션에서 기능 플래그를 관리하고 신뢰성 있게 기능 릴리즈. 호스팅 API 사용, 프라이빗 클라우드 배포 또는 온프레미스 운영 가능.
* [GrowthBook](https://growthbook.io) - 내장 베이지안 통계 분석 엔진이 포함된 오픈 소스 기능 플래그 및 A/B 테스트 제공. 3명 사용자까지, 무제한 플래그와 실험 무료.
* [Hypertune](https://www.hypertune.com) - 타입 안전 기능 플래그, A/B 테스트, 분석, 앱 설정, Git 스타일 버전관리, 동기식 인메모리 로컬 평가 지원. 팀원 5명까지 무제한 플래그 및 A/B 테스트 무료.
* [Molasses](https://www.molasses.app) - 강력한 기능 플래그 및 A/B 테스트. 환경 3개, 각 5개 플래그까지 무료.
* [Toggled.dev](https://www.toggled.dev) - 엔터프라이즈급, 확장성 높은 다지역 기능 토글 관리 플랫폼. 무료 플랜: 10개 플래그, 2개 환경, 무제한 요청. SDK, 분석 대시보드, 릴리즈 캘린더, Slack 알림 등 모든 기능 무제한 무료 제공.
* [Statsig](https://www.statsig.com) - 기능 관리, A/B 테스트, 분석 등 robust 플랫폼. 무료 플랜: 좌석, 플래그, 실험, 동적 구성 모두 무제한, 월 100만 이벤트까지 지원.
* [Abby](https://www.tryabby.com) - 오픈 소스 기능 플래그 & A/B 테스트. 코드 기반 구성 및 완전 타입드 타입스크립트 SDK. Next.js, React 등 프레임워크 강력 연동. 넉넉한 무료 티어, 저렴한 확장 옵션.

**[⬆️ 맨 위로](#table-of-contents)**

## 폰트

* [dafont](https://www.dafont.com/) - 이 웹사이트의 폰트는 저작권자 소유이며 프리웨어, 쉐어웨어, 데모 버전, 퍼블릭 도메인 중 하나입니다.
* [Everything Fonts](https://everythingfonts.com/) - 여러 도구 제공; @font-face, 단위 변환기, 폰트 힌터, 폰트 제출기 등.
* [Font Squirrel](https://www.fontsquirrel.com/) - 상업적 사용이 가능한 프리웨어 폰트. 엄선된 서체를 쉽고 편리하게 제공.
* [Google Fonts](https://fonts.google.com/) - 다양한 무료 폰트를 다운로드하거나 구글 CDN을 통해 웹사이트에 쉽게 설치 가능.
* [FontGet](https://www.fontget.com/) - 다양한 폰트를 태그별로 정리하여 다운로드 제공.
* [Fontshare](https://www.fontshare.com/) - 100% 무료, 개인 및 상업적 사용이 모두 가능한 전문가급 폰트 서비스.
* [Befonts](https://befonts.com/) - 개인 및 상업적 사용이 가능한 독특한 폰트 다수 제공.
* [Font of web](https://fontofweb.com/) - 웹사이트에서 사용되는 모든 폰트 및 사용 방식 식별.
* [Bunny](https://fonts.bunny.net) 개인정보 보호 중심의 Google Fonts
* [FontsKey](https://www.fontskey.com/) - 무료 및 유료 상업용 폰트 제공, 빠른 필터링을 위한 텍스트 입력 가능.
* [fonts.xz.style](https://fonts.xz.style/) 무료 오픈 소스 폰트 패밀리 CSS 배포 서비스.
* [Fontsensei](https://fontsensei.com/) 오픈 소스 Google 폰트, 사용자 태그 지원. CJK(중국어, 일본어, 한국어) 폰트 태그 제공.

**[⬆️ 맨 위로](#table-of-contents)**

## 폼

* [Feathery](https://feathery.io) - 강력하고 개발자 친화적인 폼 빌더. 회원가입, 로그인, 온보딩, 결제, 복잡한 금융 앱 등 제작 가능. 무료 플랜: 월 250회 제출, 5개 활성 폼.
* [Form-Data](https://form-data.com) - 노코드 폼 백엔드. 스팸 필터, 이메일 알림 및 자동응답, 웹훅, Zapier, 리디렉션, AJAX 또는 POST 등 지원. 무료 플랜: 무제한 폼, 월 20회 제출, Form-Data 배지 사용 시 추가 2,000회.
* [FabForm](https://fabform.io/) - 스마트 개발자용 폼 백엔드 플랫폼. 무료 플랜: 월 250회 폼 제출, 현대적 GUI. Google Sheets, Airtable, Slack, Email 등과 연동.
* [Form.taxi](https://form.taxi/) — HTML 폼 제출 엔드포인트. 알림, 스팸 차단, GDPR 준수 데이터 처리. 기본 사용 무료 플랜 제공.
* [Formcarry.com](https://formcarry.com) - HTTP POST 폼 엔드포인트, 무료 플랜 월 100건 제출 가능.
* [formingo.co](https://www.formingo.co/) - 정적 웹사이트용 쉬운 HTML 폼. 계정 등록 없이 무료 시작. 무료 플랜: 월 500건 제출, 커스텀 회신 이메일 주소.
* [FormKeep.com](https://www.formkeep.com/) - 무제한 폼, 월 50건 제출, 스팸 방지, 이메일 알림, HTML 내보내기 가능한 드래그&드롭 디자이너. Google Sheets, Slack, ActiveCampaign, Zapier 등 연동.
* [formlets.com](https://formlets.com/) — 온라인 폼, 월 무제한 단일 페이지 폼, 월 100건 제출, 이메일 알림.
* [formspark.io](https://formspark.io/) - 이메일로 폼 전송 서비스, 무료 플랜: 무제한 폼, 월 250건 제출, 고객 지원팀 지원.
* [Formspree.io](https://formspree.io/) — HTTP POST 요청으로 이메일 전송. 무료 티어: 폼당 월 50회 제출 제한.
* [Formsubmit.co](https://formsubmit.co/) — HTML 폼용 쉬운 엔드포인트. 영구 무료. 회원가입 필요 없음.
* [Formlick.com](https://formlick.com) - Typeform 대체, 1개 무료 폼 및 무제한 제출. 프리미엄은 폼 및 제출 무제한.
* [getform.io](https://getform.io/) - 디자이너/개발자용 폼 백엔드 플랫폼, 1개 폼, 50건 제출, 단일 파일 업로드, 100MB 파일 저장 무료.
* [HeroTofu.com](https://herotofu.com/) - 봇 감지, 암호화 아카이브 지원 폼 백엔드. 이메일, Slack, Zapier로 제출 전달. 프론트엔드만 구현, 서버 코드 불필요. 무료 플랜: 무제한 폼, 월 100건 제출.
* [HeyForm.net](https://heyform.net/) - 드래그 앤 드롭 온라인 폼 빌더. 무료 티어: 무제한 폼, 무제한 제출, 템플릿, 스팸 방지, 100MB 파일 저장.
* [Tally.so](https://tally.so/) - 기능의 99%가 무료. 무제한 폼, 무제한 제출, 이메일 알림, 폼 로직, 결제, 파일 업로드, 커스텀 완료 페이지 등 포함.
* [Hyperforms.app](https://hyperforms.app/) — 백엔드 코드 없이 몇 초 만에 폼 이메일 등 생성. 개인 계정 최대 월 50건 제출 무료.
* [Kwes.io](https://kwes.io/) - 기능 풍부한 폼 엔드포인트. 정적 사이트와 호환. 무료 플랜: 최대 1개 사이트, 월 50건 제출.
* [Pageclip](https://pageclip.co/) - 무료 플랜: 1개 사이트, 1개 폼, 월 1,000건 제출.
* [Qualtrics Survey](https://qualtrics.com/free-account) — 전문가 설계 설문 템플릿 50+개 제공, 전문 설문/폼 제작 툴. 무료 계정: 1개 활성 설문, 설문당 100응답, 8개 응답 유형 제한.
* [Screeb](https://screeb.app/) - 인앱 설문 및 사용자 행동 분석. 영구 무료 플랜: 월 500명 활성 사용자, 무제한 응답/이벤트, 다양한 통합, 내보내기, 정기 리포트.
* [smartforms.dev](https://smartforms.dev/) - 쉽고 강력한 웹사이트 폼 백엔드, 영구 무료 플랜: 월 50건 제출, 250MB 파일 저장, Zapier 연동, CSV/JSON 내보내기, 커스텀 리디렉션/응답, 텔레그램/Slack 알림, 단일 이메일 알림.
* [Survicate](https://survicate.com/) — 다양한 소스에서 피드백 수집, AI로 자동 분석. 이메일, 웹, 인앱, 모바일 설문 및 AI 설문 생성기, 월 25회 응답 무료.
* [staticforms.xyz](https://www.staticforms.xyz/) - 서버측 코드 없이 HTML 폼을 쉽게 통합. 제출 후 등록된 이메일로 폼 내용 발송.
* [stepFORM.io](https://stepform.io) - 퀴즈/폼 빌더. 무료 플랜: 5개 폼, 폼당 최대 3단계, 월 50회 응답.
* [Typeform.com](https://www.typeform.com/) — 아름다운 폼을 웹사이트에 포함. 무료 플랜: 폼당 10개 필드, 월 100회 응답 제한.
* [WaiverStevie.com](https://waiverstevie.com) - REST API 제공 전자 서명 플랫폼. 웹훅으로 알림 수신 가능. 무료 플랜: 서명 문서 워터마크 있지만 무제한 봉투+서명 지원.
* [Web3Forms](https://web3forms.com) - 백엔드 코드 없이 Static & JAMStack 웹사이트용 연락처 폼. 무료 플랜: 무제한 폼, 무제한 도메인, 월 250회 제출.
  * [WebAsk](https://webask.io) - 설문조사 및 폼 빌더. 무료 플랜은 계정당 최대 3개의 설문조사, 월 100회 응답, 설문조사당 10개 요소까지 허용됩니다.
  * [Wufoo](https://www.wufoo.com/) - 웹사이트에서 사용할 수 있는 빠른 폼 생성. 무료 플랜은 월 100회 제출 제한이 있습니다.
  * [formpost.app](https://formpost.app) - 무료, 무제한 폼-투-이메일 서비스. 맞춤 리디렉션, 자동 응답, 웹훅 등을 무료로 설정할 수 있습니다.
  * [Formester.com](https://formester.com) - 독특한 스타일의 폼을 웹사이트에 공유 및 임베드. 폼 생성 개수 및 기능 제한 없이 월 100회 제출까지 무료로 이용할 수 있습니다.
  * [SimplePDF.eu](https://simplepdf.eu/embed) - 웹사이트에 PDF 에디터를 임베드하여 모든 PDF를 입력 가능한 폼으로 변환. 무료 플랜은 무제한 PDF에 대해 PDF당 3회 제출이 허용됩니다.
  * [forms.app](https://forms.app/) — 조건부 로직, 자동 점수 계산기, AI 등 강력한 기능으로 온라인 폼을 생성하세요. 무료 플랜으로 최대 100개의 응답을 수집할 수 있으며, 폼을 웹사이트에 임베드하거나 링크로 사용할 수 있습니다.
  * [Qualli](https://usequalli.com) - 모바일용 인앱 설문조사. Qualli AI로 완벽한 질문을 생성하세요. 무료 플랜으로 최대 500 MAU, 무제한 폼 및 트리거 생성이 가능합니다.
  * [Sprig](https://sprig.com/) - 월 1회 인앱 설문조사 또는 리플레이가 포함된 설문조사 제공, GPT 기반 AI 분석 포함.
  * [feedback.fish](https://feedback.fish/) - 무료 플랜으로 총 25개의 피드백 제출 수집 가능. React와 Vue 컴포넌트가 제공되어 쉽게 통합할 수 있습니다.
  * [Vidhook](https://vidhook.io/) - 높은 응답률을 자랑하는 즐거운 설문조사로 피드백을 수집하세요. 무료 플랜에는 1개의 활성 설문조사, 설문조사당 25회 응답, 커스터마이즈 가능한 템플릿이 포함됩니다.

**[⬆️ 맨 위로](#table-of-contents)**

## 생성형 AI

  * [Zenable](https://zenable.io) - Cursor, Windsurf, Copilot 등과 같은 도구의 출력을 Policy as Code로 구축된 가드레일을 사용해 회사의 품질 및 컴플라이언스 기준에 맞게 즉시 자동 수정. 무료 티어는 MCP 서버에 하루 100회 도구 호출, GitHub 앱을 통한 하루 25회 자동 PR 리뷰 제공.
  * [Keywords AI](https://keywordsai.co) - 최고의 LLM 모니터링 플랫폼. 2줄의 코드로 200개 이상의 LLM을 호출하는 단일 포맷. 매달 10,000회 무료 요청, 플랫폼 기능 무료!
  * [Portkey](https://portkey.ai/) - 관측 기능 및 AI 게이트웨이가 포함된 생성형 AI 앱의 제어판. 매달 최대 10,000회 요청 전송 및 로그 무료.
  * [Braintrust](https://www.braintrustdata.com/) - 생성형 AI용 평가, 프롬프트 플레이그라운드, 데이터 관리. 무료 플랜은 주당 최대 1,000개의 개인 평가 행 제공.
  * [Findr](https://www.usefindr.com/) - 모든 앱을 한 번에 검색할 수 있는 통합 검색. 보유한 정보를 활용해 질문에 답하는 검색 어시스턴트. 무료 플랜은 무제한 통합 검색과 하루 5회 코파일럿 쿼리 제공.
  * [ReportGPT](https://ReportGPT.app) - AI 기반 문서 작성 도우미. 본인의 API 키만 있다면 전체 플랫폼을 무료로 이용할 수 있습니다.
  * [Clair](https://askclair.ai/) - 임상 AI 레퍼런스. 학생은 Open Search, Clinical Summary, Med Review, Drug Interactions, ICD-10 Codes, Stewardship 등 전문가 도구 모음을 무료로 이용할 수 있습니다. 전문가 도구 모음 무료 체험도 제공.
  * [Langtrace](https://langtrace.ai) - 개발자가 LLM 애플리케이션 성능과 관련된 프롬프트 및 데이터셋을 추적, 평가, 관리하고 디버깅할 수 있도록 지원. 모든 LLM에 대한 오픈 텔레메트리 표준 트레이스를 생성해 관측이 가능하며, 모든 관측 클라이언트와 호환. 무료 플랜은 월 5만 트레이스 제공.
  * [LangWatch](https://langwatch.ai) - LLMOps 플랫폼으로, AI 팀이 LLM 애플리케이션의 신뢰성, 비용 효율성, 성능을 측정, 모니터링, 최적화할 수 있도록 지원. DSPy 컴포넌트로 엔지니어와 비개발팀이 협력해 GenAI 제품을 미세 조정 및 제품화 가능. 무료 플랜은 모든 플랫폼 기능, 월 1천 트레이스, 1개 워크플로우 DSPy 옵티마이저 포함. [#opensource](https://github.com/langwatch/langwatch)
  * [Comet Opik](https://www.comet.com/site/products/opik/) - 개발 및 운영 라이프사이클 전반에서 LLM 애플리케이션 평가, 테스트, 배포. [#opensource](https://github.com/comet-ml/opik/)
  * [Langfuse](https://langfuse.com/) - 팀이 LLM 애플리케이션을 협업 디버깅, 분석, 반복할 수 있도록 돕는 오픈소스 LLM 엔지니어링 플랫폼. 무료 영구 플랜은 월 5만 관측 및 모든 플랫폼 기능 포함. [#opensource](https://github.com/langfuse/langfuse)
  * [Pollinations.AI](https://pollinations.ai/) - 사용하기 쉽고 무료인 이미지 생성 AI, 무료 API 제공. 회원가입이나 API 키 없이도 사용 가능하며, 다양한 웹사이트/워크플로우 통합 옵션 제공. [#opensource](https://github.com/pollinations/pollinations)
  * [Othor AI](https://othor.ai/) - Tableau, Power BI, Looker 등 인기 BI 솔루션의 AI-네이티브 빠르고 간단하며 안전한 대안. 대규모 언어 모델(LLM)로 몇 분 만에 맞춤형 비즈니스 인텔리전스 솔루션 제공. Free Forever 플랜은 1명의 사용자가 1개의 워크스페이스에서 5개의 데이터소스 연결, 분석 횟수 무제한. [#opensource](https://github.com/othorai/othor.ai)
  * [OpenRouter](https://openrouter.ai/models?q=free) - DeepSeek R1, V3, Llama, Moonshot AI 등 다양한 무료 AI 모델 제공. 이 모델들은 자연어 처리에 강하며 다양한 개발 요구에 적합. 무료로 사용할 수 있으나, 속도 제한이 있을 수 있음. 추가로 Claude, OpenAI, Grok, Gemini, Nova 등 고급 요구에 맞는 유료 모델 제공.

**[⬆️ 맨 위로](#table-of-contents)**

## CDN 및 보호

  * [bootstrapcdn.com](https://www.bootstrapcdn.com/) — bootstrap, bootswatch, fontawesome.io용 CDN
  * [cdnjs.com](https://cdnjs.com/) — 간단하고 빠르며 신뢰할 수 있는 오픈소스 CDN 서비스. 11% 이상의 웹사이트에서 신뢰하며, Cloudflare 기반.
  * [developers.google.com](https://developers.google.com/speed/libraries/) — 가장 인기 있는 오픈소스 JavaScript 라이브러리용 구글 호스팅 CDN
  * [Stellate](https://stellate.co/) - GraphQL API를 위한 초고속, 신뢰성 높은 CDN, 두 서비스까지 무료 제공.
  * [jsdelivr.com](https://www.jsdelivr.com/) — 무료, 빠르고 신뢰할 수 있는 오픈소스 CDN. npm, GitHub, WordPress, Deno 등 지원.
  * [Microsoft Ajax](https://docs.microsoft.com/en-us/aspnet/ajax/cdn/overview) — Microsoft Ajax CDN은 jQuery 등 인기 서드파티 JS 라이브러리를 호스팅, 웹 앱에 쉽게 추가 가능
  * [ovh.ie](https://www.ovh.ie/ssl-gateway/) — 무료 DDoS 보호 및 SSL 인증서 제공
  * [Skypack](https://www.skypack.dev/) — 100% 네이티브 ES 모듈 JavaScript CDN. 도메인별 월 100만 요청까지 무료.
  * [raw.githack.com](https://raw.githack.com/) — **rawgit.com**의 현대적 대체 서비스, Cloudflare를 사용해 파일 호스팅
  * [section.io](https://www.section.io/) — Varnish Cache 솔루션을 손쉽게 관리 및 실행. 한 사이트는 영구 무료로 제공
  * [statically.io](https://statically.io/) — Git 저장소(GitHub, GitLab, Bitbucket), WordPress 자산, 이미지용 CDN
  * [toranproxy.com](https://toranproxy.com/) — Packagist와 GitHub용 프록시. 영구 무료 CD. 개인용, 1명 개발자, 지원 없음
  * [UNPKG](https://unpkg.com/) — npm의 모든 패키지용 CDN
  * [weserv](https://images.weserv.nl/) — 이미지 캐시 및 리사이즈 서비스. 전 세계적 캐시로 이미지를 실시간 변환.
  * [Namecheap Supersonic](https://www.namecheap.com/supersonic-cdn/#free-plan) — 무료 DDoS 보호
  * [Gcore](https://gcorelabs.com/) 글로벌 콘텐츠 전송 네트워크, 월 1TB 및 100만 요청 무료, 무료 DNS 호스팅
  * [CacheFly](https://portal.cachefly.com/signup/free2023) - 월 5TB까지 무료 CDN 트래픽, 19개 핵심 PoP, 1개 도메인, 범용 SSL 제공.

**[⬆️ 맨 위로](#table-of-contents)**

## PaaS

  * [anvil.works](https://anvil.works) - 파이썬만으로 웹 앱 개발. 무료 티어는 앱 무제한, 요청당 30초 제한.
  * [appwrite](https://appwrite.io) - 무제한 프로젝트, 프로젝트 일시중지 없음(웹소켓 지원), 인증 서비스. 무료 티어에서 프로젝트당 데이터베이스 1개, 버킷 3개, 함수 5개 제공.
  * [configure.it](https://www.configure.it/) — 모바일 앱 개발 플랫폼, 2개 프로젝트까지 무료, 기능 제한 있으나 리소스 제한 없음
  * [codenameone.com](https://www.codenameone.com/) — Java/Kotlin 개발자를 위한 오픈소스, 크로스플랫폼 모바일 앱 개발 툴체인. 프로젝트 수 무제한으로 상업적 사용 무료
  * [deco.cx](https://www.deco.cx/en/dev) - TypeScript 코드에서 자동 생성되는 시각적 CMS가 포함된 엣지 네이티브 프론트엔드 플랫폼. 내장 A/B 테스트, 콘텐츠 세분화, 실시간 분석. 콘텐츠 중심 및 엔터프라이즈 전자상거래에 적합. 월 5,000 페이지뷰 또는 오픈소스/개인 프로젝트는 무료.
  * [Deno Deploy](https://deno.com/deploy) - JavaScript, TypeScript, WebAssembly를 전 세계 엣지에서 실행하는 분산 시스템. 무료 티어는 하루 10만 요청, 월 100GiB 데이터 전송 제공.
  * [domcloud.co](https://domcloud.co) – Linux 호스팅 서비스로 CI/CD(GitHub), SSH, MariaDB/Postgres 데이터베이스 지원. 무료 버전은 1GB 저장소, 월 1GB 네트워크, 무료 도메인만 사용 가능.
  * [encore.dev](https://encore.dev/) — 정적 분석으로 자동 인프라, 보일러플레이트 없는 코드 등 제공하는 백엔드 프레임워크. 취미 프로젝트용 무료 클라우드 호스팅 포함.
  * [flightcontrol.dev](https://flightcontrol.dev/) - Git 푸시 스타일 워크플로우로 AWS에 웹 서비스, 데이터베이스 등 배포. 개인 GitHub 저장소 1명 개발자 무료 티어 제공. AWS 비용은 AWS를 통해 청구되며, AWS 크레딧/무료 티어 사용 가능.
  * [gigalixir.com](https://gigalixir.com/) - Elixir/Phoenix 앱용, 절대 슬립하지 않는 무료 인스턴스 1개 및 연결 2개, 1만 행 제한, 백업 없는 무료 PostgreSQL DB 제공.
  * [Glitch](https://glitch.com/) — 코드 공유 및 실시간 협업 기능 제공, 무료 공개 호스팅. 무료 플랜은 월 1,000시간 제한.
  * [leapcell](https://leapcell.io/) - 신뢰성 있는 분산 애플리케이션 플랫폼, 빠른 성장 지원. 무료 플랜: 서비스 호출 10만, 비동기 작업 1만, Redis 명령 10만.
  * [pipedream.com](https://pipedream.com) - 개발자를 위한 통합 플랫폼. 트리거 기반 워크플로우를 코드로 개발. [무료](https://docs.pipedream.com/pricing/) 워크플로우 제공. 서버나 클라우드 리소스 관리 필요 없음.
  * [pythonanywhere.com](https://www.pythonanywhere.com/) — 클라우드 파이썬 앱 호스팅. 비기너 계정 무료, 1개 파이썬 웹앱(your-username.pythonanywhere.com 도메인), 512MB 개인 파일 저장공간, MySQL DB 1개
  * [ampt.dev](https://getampt.com/) - 복잡한 설정·인프라 관리 없이 AWS에서 JS 앱을 빌드, 배포, 확장. 무료 프리뷰 플랜: 시간당 500회, 일 2,500회, 월 50,000회 호출. 커스텀 도메인은 유료만 가능.
  * [Koyeb](https://www.koyeb.com) - 개발자 친화적 서버리스 앱 글로벌 배포 플랫폼. 도커 컨테이너, 웹앱, API를 git 기반 배포, 네이티브 오토스케일, 글로벌 엣지 네트워크, 내장 서비스 메시·디스커버리. 무료 인스턴스: 독일 프랑크푸르트 또는 미국 워싱턴 D.C.에 웹 서비스 배포 가능. 무료 관리형 Postgres DB 제공(프랑크푸르트, 워싱턴 D.C., 싱가포르). 512MB 메모리, 2GB 저장소, 0.1 CPU.
  * [Napkin](https://www.napkin.io/) - FaaS, 500Mb 메모리, 기본 타임아웃 15초, 월 5,000회 무료 API 호출(초당 5회 제한).
  * [Meteor Cloud](https://www.meteor.com/cloud) — Meteor 앱용 갤럭시 호스팅 PaaS, 무료 MongoDB 공유 호스팅 및 자동 SSL 포함.
  * [Northflank](https://northflank.com) — 강력한 UI, API, CLI로 마이크로서비스, 잡, 관리형 데이터베이스 빌드·배포. 버전 컨트롤/외부 도커 레지스트리에서 컨테이너 무중단 확장. 무료 티어: 서비스 2개, 크론잡 2개, DB 1개.
  * [YepCode](https://yepcode.io) - 서버리스 환경에서 API와 서비스를 연결하는 올인원 플랫폼. 노코드의 민첩함과 프로그래밍 언어의 강력함을 동시에 제공. 무료 티어는 [1,000 yep](https://yepcode.io/pricing/) 제공.
  * [WunderGraph](https://cloud.wundergraph.com) - 현대적 API를 빠르게 구축, 배포, 관리할 수 있는 오픈소스 플랫폼. 내장 CI/CD, GitHub 통합, 자동 HTTPS. [무료 플랜](https://wundergraph.com/pricing) 최대 3개 프로젝트, 1GB 송신, 월 300분 빌드 타임.
  * [Zeabur](https://zeabur.com) - 원클릭 서비스 배포. 3개 서비스까지 무료, 월 미화 5달러 크레딧 지급.
  * [mogenius](https://mogenius.com) - 쿠버네티스에서 서비스 빌드, 배포, 실행을 간편하게. 무료 티어로 로컬 쿠버네티스를 연결해 프로덕션과 유사한 테스트 환경 구축 가능.
  * [genezio](https://genezio.com/) - 서버리스 함수 제공업체, 비상업적·학술용으로 월 100만 함수 호출, 100GB 대역폭, 10개 크론잡 무료 제공.

**[⬆️ 맨 위로](#table-of-contents)**

## BaaS

  * [Activepieces](https://www.activepieces.com) - 앱 백엔드에서 여러 앱을 자동화 플로우로 연결. 예: 이벤트 발생 시 Slack 메시지 전송, Google Sheet 행 추가 등. 월 5,000개 작업까지 무료.
  * [back4app.com](https://www.back4app.com) - Parse Platform 기반, 쉽고 유연하며 확장성 있는 백엔드.
  * [backendless.com](https://backendless.com/) — 모바일·웹 BaaS, 1GB 파일 저장 무료, 월 5만회 푸시 알림, 테이블 내 데이터 오브젝트 1,000개.
  * [bismuth.cloud](https://www.bismuth.cloud/) — AI가 파이썬 API를 함수 런타임 및 호스팅 스토리지에 부트스트랩, 온라인 에디터 또는 로컬에서 빌드·호스팅 무료.
  * [BMC Developer Program](https://developers.bmc.com/site/global/bmc_helix_platform/program/overview/index.gsp) — 엔터프라이즈용 디지털 혁신 빌드·배포를 위한 문서 및 리소스. 플랫폼, SDK, 앱 빌드 및 커스터마이즈 컴포넌트 라이브러리 포함 샌드박스 제공.
  * [connectycube.com](https://connectycube.com) - 무제한 채팅, P2P 음성·영상 통화, 파일 첨부, 푸시 알림. 앱당 1,000명 사용자까지 무료.
  * [convex.dev](https://convex.dev/) - 반응형 BaaS, 데이터(관계형 문서 및 ACID 트랜잭션), 서버리스 함수, WebSocket 실시간 스트림 제공. 소규모 프로젝트 무료 - 최대 100만 레코드, 월 500만 함수 호출.
  * [darklang.com](https://darklang.com/) - 호스팅 언어, 에디터, 인프라 결합. 베타 기간 중 접근 가능, 베타 이후 관대한 무료 티어 예정.
  * [Firebase](https://firebase.com) — 성공적인 앱 빌드 및 운영 지원. 무료 Spark 플랜: 인증, 호스팅, Firebase ML, 실시간 DB, 클라우드 스토리지, Testlab. A/B 테스트, 분석, 앱 배포, 앱 인덱싱, FCM, Crashlytics, 다이나믹 링크, 인앱 메시지, 성능 모니터링, 예측, 원격 설정은 항상 무료.
  * [Flutter Flow](https://flutterflow.io) — 한 줄의 코드 없이 Flutter 앱 UI 빌드. Firebase 연동 지원. 무료 플랜은 UI 빌더와 무료 템플릿 전체 접근 제공.
  * [getstream.io](https://getstream.io/) — 수시간 내 확장성 높은 인앱 채팅, 메시징, 영상/음성, 피드 구축 가능
  * [hasura.io](https://hasura.io/) — 기존 데이터베이스를 즉시 확장해 안전하게 GraphQL API 제공, 웹·모바일·데이터 통합 워크로드에 활용. 월 1GB 데이터 패스스루 무료.
  * [nhost.io](https://nhost.io) - 웹 및 모바일 앱용 서버리스 백엔드. 무료 플랜은 PostgreSQL, GraphQL(Hasura), 인증, 스토리지, 서버리스 함수 포함.
  * [onesignal.com](https://onesignal.com/) — 무제한 무료 푸시 알림. 월 10,000건 이메일 발송, 무제한 연락처, Auto Warm Up 제공.
  * [paraio.com](https://paraio.com) — 유연한 인증, 전문 검색, 캐싱 API 백엔드 서비스. 앱 1개, 앱 데이터 1GB까지 무료.
* [pubnub.com](https://www.pubnub.com/) — 최대 월 1백만 건의 메시지 및 일일 100대의 활성 기기에 대한 무료 푸시 알림 제공
* [pushbots.com](https://pushbots.com/) — 푸시 알림 서비스. 월 150만 건의 푸시까지 무료
* [pushcrew.com](https://pushcrew.com/) — 푸시 알림 서비스. 최대 2,000명의 구독자에게 무제한 알림 제공
* [pusher.com](https://pusher.com/beams) — 월 2,000명의 활성 사용자에게 무료로 무제한 푸시 알림 제공. iOS 및 Android 기기를 위한 단일 API.
* [quickblox.com](https://quickblox.com/) — 인스턴트 메시징, 영상 및 음성 통화, 푸시 알림을 위한 커뮤니케이션 백엔드
* [restspace.io](https://restspace.io/) - 인증, 데이터, 파일, 이메일 API, 템플릿 등 다양한 서비스를 갖춘 서버를 구성하고, 파이프라인으로 조합하여 데이터를 변환할 수 있음.
* [Salesforce Developer Program](https://developer.salesforce.com/signup) — 드래그 앤 드롭 도구로 빠르게 앱을 구축. 클릭으로 데이터 모델 커스터마이즈. Apex 코드로 더 확장. 강력한 API로 모든 것과 통합. 엔터프라이즈급 보안 유지. 클릭 또는 최신 웹 프레임워크로 UI 커스터마이즈. 무료 개발자 프로그램으로 전체 Lightning Platform에 액세스 가능.
* [simperium.com](https://simperium.com/) — 데이터를 어디서나 즉시 자동으로 이동, 멀티플랫폼 지원, 구조화된 데이터의 무제한 전송 및 저장, 최대 월 2,500명의 사용자
* [Supabase](https://supabase.com) — 백엔드 구축을 위한 오픈소스 Firebase 대안. 무료 플랜은 인증, 실시간 데이터베이스 및 오브젝트 스토리지를 제공.
* [tyk.io](https://tyk.io/) — 인증, 쿼터, 모니터링, 분석 기능을 제공하는 API 관리. 무료 클라우드 제공
* [zapier.com](https://zapier.com/) — 사용하는 앱을 연결해 작업 자동화. 15분마다 5개의 zap, 월 100개의 작업 무료
* [IFTTT](https://ifttt.com) — 즐겨 사용하는 앱과 기기 자동화. 무료 2개의 Applet 제공
* [Integrately](https://integrately.com) — 클릭 한 번으로 반복 작업 자동화. 무료 100개 작업, 15분 업데이트 주기, 활성 자동화 5개, 웹훅 제공.
* [LeanCloud](https://leancloud.app/) — 모바일 백엔드. 1GB 데이터 저장소, 256MB 인스턴스, 하루 3,000회 API 요청, 하루 10,000회 푸시 무료. (API는 Parse Platform과 매우 유사)
* [Claw.cloud](https://run.claw.cloud) - 180일 이상 된 GitHub 계정 사용자를 위해 월 $5 상당의 무료 크레딧을 제공하는 PaaS 플랫폼. 앱, 데이터베이스 등 호스팅에 적합. ([무료 크레딧 가입 링크](https://ap-southeast-1.run.claw.cloud/signin)).

**[⬆️ 맨 위로](#table-of-contents)**

## 로우코드 플랫폼

* [appsmith](https://www.appsmith.com/) — 어드민 패널, 내부 도구, 대시보드 구축을 위한 로우코드 프로젝트. 15개 이상의 데이터베이스 및 모든 API와 통합.
* [Basedash](https://www.basedash.com) — 내부 어드민 패널 및 대시보드 구축을 위한 로우코드 플랫폼. SQL 데이터베이스와 REST API 지원.
* [BudiBase](https://budibase.com/) — Budibase는 내부 앱을 몇 분 만에 생성할 수 있는 오픈소스 로우코드 플랫폼. PostgreSQL, MySQL, MSSQL, MongoDB, Rest API, Docker, K8s 지원
* [Clappia](https://www.clappia.com) — 드래그 앤 드롭 인터페이스, 오프라인 지원, 실시간 위치 추적, 다양한 서드파티 서비스 통합 기능을 갖춘 비즈니스 프로세스 앱 제작용 로우코드 플랫폼
* [DronaHQ](https://www.dronahq.com/) — DronaHQ는 엔지니어링 팀과 제품 매니저가 내부 도구, 맞춤형 사용자 여정, 디지털 경험, 자동화, 맞춤형 어드민 패널, 운영 앱을 10배 빠르게 구축할 수 있도록 돕는 로우코드 플랫폼.
* [lil'bots](https://www.lilbots.io/) - OpenAI, Anthropic, Firecrawl 등 무료 내장 API를 활용해 온라인에서 스크립트 작성 및 실행. AI 에이전트/내부 도구 구축 및 팀과 공유에 적합. 무료 티어는 API 전체 접근, AI 코딩 어시스턴트, 월 10,000 실행 크레딧 포함.
* [Mendix](https://www.mendix.com/) — 엔터프라이즈용 신속한 애플리케이션 개발, 무제한 샌드박스 환경(총 사용자 수 지원), 앱당 0.5GB 저장소 및 1GB RAM 제공. 무료 티어에서 Studio 및 Studio Pro IDE 사용 가능.
* [outsystems.com](https://www.outsystems.com/) — 온프레미스 또는 클라우드용 엔터프라이즈 웹 개발 PaaS. 무료 "개인 환경"에서 무제한 코드, 최대 1GB 데이터베이스 제공
* [ReTool](https://retool.com/) — 내부 애플리케이션 구축용 로우코드 플랫폼. JavaScript와 API로 구현 가능. 무료 티어는 월 5명의 사용자, 무제한 앱 및 API 연결 허용.
* [Superblocks](https://superblocks.com/) — 개발자 및 준기술팀을 위한 오픈 엔터프라이즈 애플리케이션 플랫폼. AI로 생성, 시각적 편집, 코드 확장 가능. 통합, 인증, 권한, 감사 로그 등 중앙관리 지원.
* [ToolJet](https://www.tooljet.com/) — 비즈니스 애플리케이션 구축용 확장형 로우코드 프레임워크. 데이터베이스, 클라우드 스토리지, GraphQL, API 엔드포인트, Airtable 등과 연결하고 드래그 앤 드롭 빌더로 앱 생성.
* [UI Bakery](https://uibakery.io) — 맞춤형 웹 애플리케이션을 빠르게 구축할 수 있는 로우코드 플랫폼. 드래그 앤 드롭 UI 구축 및 JavaScript, Python, SQL로 높은 수준의 커스터마이즈 지원. 클라우드 및 자체 호스팅 제공. 최대 5명 무료.
* [manubes](https://www.manubes.com) - 산업 생산 관리에 특화된 강력한 노코드 클라우드 플랫폼. 월 100만 워크플로우 활동, 1명 무료 ([독일어 버전](https://www.manubes.de)도 제공).

**[⬆️ 맨 위로](#table-of-contents)**

## 웹 호스팅

* [Alwaysdata](https://www.alwaysdata.com/) — 100MB 무료 웹 호스팅, MySQL, PostgreSQL, CouchDB, MongoDB, PHP, Python, Ruby, Node.js, Elixir, Java, Deno, 커스텀 웹서버 지원, FTP, WebDAV, SSH 접속 지원; 메일박스, 메일링 리스트, 앱 설치기 포함.
* [Awardspace.com](https://www.awardspace.com) — 무료 웹 호스팅 + 무료 단기 도메인, PHP, MySQL, 앱 설치기, 이메일 발송, 광고 없음.
* [Bohr](https://bohr.io) — 비상업적 프로젝트 무료 + 개발자 중심의 배포 및 개발 플랫폼. 인프라 부담 최소화, 빠른 셋업 지원.
* [Bubble](https://bubble.io/) — 비주얼 프로그래밍으로 웹·모바일 앱을 코드 없이 구축, 무료(버블 브랜딩 포함).
* [dAppling Network](https://www.dappling.network/) - Web3 프론트엔드를 위한 분산형 웹 호스팅 플랫폼. 가용성 및 보안 강화, 사용자용 추가 접근점 제공.
* [DigitalOcean](https://www.digitalocean.com/pricing) - App Platform Starter 티어에서 정적 사이트 3개 무료 구축 및 배포.
* [Drive To Web](https://drv.tw) — Google Drive & OneDrive에서 웹으로 바로 호스팅. 정적 사이트만 가능. 영구 무료. Google/Microsoft 계정당 1사이트.
* [Fenix Web Server](https://preview.fenixwebserver.com) - 로컬에서 사이트를 호스팅하고 실시간으로 공개 공유할 수 있는 개발자용 데스크톱 앱. UI, API, CLI 모두 지원.
* [Fern](https://buildwithfern.com) - Fern의 무료 플랜에서 마크다운 기반 문서 사이트를 구축 및 호스팅. API 정의 파일로 API 레퍼런스 자동 생성 가능. _yoursite_.docs.buildwithfern.com에서 호스팅.
* [Free Hosting](https://freehostingnoads.net/) — PHP5, Perl, CGI, MySQL, FTP, 파일 관리자, POP 이메일, 무료 서브도메인, 무료 도메인 호스팅, DNS 존 에디터, 웹사이트 통계, 무료 온라인 지원 등 다양한 기능의 무료 호스팅.
* [Freehostia](https://www.freehostia.com) — 업계 최고 수준의 컨트롤 패널, 50+ 앱 1클릭 설치 제공 무료 호스팅. 즉시 셋업. 강제 광고 없음.
* [HelioHost](https://heliohost.org) — 비영리 무료 웹 호스팅, Plesk, PHP, Node.js, Python, Django, Flask, .NET, Perl, CGI, MySQL, PostgreSQL, SQLite, IMAP/POP3/SMTP 이메일, 무제한 대역폭, 무료 서브도메인, 1,000MB 무료 저장소, 업그레이드 가능.
* [Kinsta Static Site Hosting](https://kinsta.com/static-site-hosting/) — 최대 100개 정적 사이트 무료 배포, SSL 커스텀 도메인, 월 100GB 대역폭, 260+ Cloudflare CDN 위치.
* [Lecturify](https://www.lecturify.net/index.en.html) - SFTP로 파일 업·다운로드 지원, PHP 사용 가능 웹 호스팅.
* [Neocities](https://neocities.org) — 정적, 1GB 무료 저장소, 200GB 대역폭.
* [Netlify](https://www.netlify.com/) — 정적 사이트/앱 빌드, 배포, 호스팅. 100GB 데이터, 월 100GB 대역폭 무료.
* [pantheon.io](https://pantheon.io/) — Drupal 및 WordPress 호스팅, 자동화 DevOps, 확장형 인프라. 개발자·에이전시용 무료. 커스텀 도메인 불가.
* [readthedocs.org](https://readthedocs.org/) — 버전 관리, PDF 생성 등 기능을 갖춘 무료 문서 호스팅
* [render.com](https://render.com) — 통합 클라우드. 앱·사이트 빌드, 무료 SSL, 글로벌 CDN, 프라이빗 네트워크, Git 자동 배포, 웹 서비스/DB/정적 페이지 완전 무료 플랜.
* [SourceForge](https://sourceforge.net/) — 오픈소스 소프트웨어 무료 검색, 생성, 배포
* [surge.sh](https://surge.sh/) — 프론트엔드 개발자를 위한 정적 웹 퍼블리싱. 무제한 사이트, 커스텀 도메인 지원
* [telegra.ph](https://telegra.ph/) Quill로 웹페이지 쉽게 생성
* [tilda.cc](https://tilda.cc/) — 사이트 1개, 50페이지, 50MB 저장, 170+ 중 주요 블록만 사용, 폰트/파비콘/커스텀 도메인 불가
* [Vercel](https://vercel.com/) — 웹앱 빌드, 배포, 무료 SSL, 글로벌 CDN, git push마다 고유 Preview URL 제공. Next.js 및 정적 사이트 생성기에 최적.
* [Versoly](https://versoly.com/) — SaaS 중심 웹사이트 빌더. 무제한 웹사이트, 70+ 블록, 5개 템플릿, 커스텀 CSS, 파비콘, SEO, 폼 지원. 커스텀 도메인 불가.
* [Qoddi](https://qoddi.com) - Heroku와 유사한 PaaS 서비스. 개발자 중심, 올인원 기능. 정적 자산·스테이징·개발 앱 무료 티어.
* [FreeFlarum](https://freeflarum.com/) - 최대 250명 사용자용 커뮤니티 기반 무료 Flarum 호스팅(푸터 워터마크 제거는 기부 필요).
* [MDB GO](https://mdbgo.com/) - 한 프로젝트 무료 호스팅, 2주 컨테이너 TTL, 프로젝트당 500MB RAM, SFTP - 1G 디스크.
* [Patr Cloud](https://patr.cloud/) — 사용이 쉬운 클라우드 플랫폼. 유료 서비스 외 정적 사이트 3개 무료 호스팅 제공.
* [Serv00.com](https://serv00.com/) — 3GB 무료 웹 호스팅, 일 1회(7일) 백업. 크론탭, SSH, 저장소(GIT, SVN, Mercurial), MySQL, PostgreSQL, MongoDB, PHP, Node.js, Python, Ruby, Java, Perl, TCL/TK, Lua, Erlang, Rust, Pascal, C, C++, D, R 등 다양한 언어 지원.
- [Sevalla](https://sevalla.com/) - 앱, 데이터베이스, 정적 웹사이트 배포/관리를 단순화한 호스팅 플랫폼. 사이트당 1GB, 월 100GB 무료 대역폭, 600분 무료 빌드, 계정당 100개 사이트.

**[⬆️ 맨 위로](#table-of-contents)**

## DNS

* [1.1.1.1](https://developers.cloudflare.com/1.1.1.1/) - Cloudflare에서 제공하는 빠르고 안전한 무료 공개 DNS 리졸버(DNS 쿼리 암호화). 인터넷 제공업체의 DNS 차단 우회, DNS 쿼리 감시 방지, [성인·악성 콘텐츠 차단](https://developers.cloudflare.com/1.1.1.1/1.1.1.1-for-families)에 유용. [API로도 사용 가능](https://developers.cloudflare.com/1.1.1.1/encrypted-dns/dns-over-https/make-api-requests). 참고: DNS 리졸버만 제공, DNS 호스팅 불가.
* [1984.is](https://www.1984.is/product/freedns/) — API 포함 다양한 무료 DNS 기능 제공 무료 DNS 서비스.
* [cloudns.net](https://www.cloudns.net/) — 최대 1도메인, 50레코드 무료 DNS 호스팅
* [deSEC](https://desec.io) - 보안을 고려해 설계된 API 지원 무료 DNS 호스팅. 오픈소스 기반, [SSE](https://www.securesystems.de/) 후원.
* [dns.he.net](https://dns.he.net/) — 다이나믹 DNS 지원 무료 DNS 호스팅 서비스
* [Zonomi](https://zonomi.com/) — 즉시 DNS 전파 지원 무료 DNS 호스팅. 무료 플랜: 1 DNS 존(도메인), 최대 10개 레코드.
* [dnspod.com](https://www.dnspod.com/) — 무료 DNS 호스팅.
* [duckdns.org](https://www.duckdns.org/) — 무료 DDNS, 무료 티어는 최대 5도메인. 다양한 설정 가이드 제공.
* [Dynv6.com](https://dynv6.com/) — [API 지원](https://dynv6.com/docs/apis) 및 CNAME, MX, SPF, SRV, TXT 등 다양한 레코드 유형 관리 가능한 무료 DDNS 서비스.
* [freedns.afraid.org](https://freedns.afraid.org/) — 무료 DNS 호스팅. 다양한 공개 사용자 [기여 도메인](https://freedns.afraid.org/domain/registry/) 기반 무료 서브도메인 제공. 가입 후 "Subdomains" 메뉴에서 무료 서브도메인 획득 가능.
* [luadns.com](https://www.luadns.com/) — 무료 DNS 호스팅, 3도메인, 모든 기능(합리적 제한 내)
* [namecheap.com](https://www.namecheap.com/domains/freedns/) — 무료 DNS. 도메인 수 무제한
* [nextdns.io](https://nextdns.io) - DNS 기반 방화벽, 월 30만 쿼리 무료
* [noip.at](https://noip.at/) — 회원가입, 추적, 로그, 광고 없이 제공되는 무료 DDNS 서비스. 도메인 수 제한 없음.
* [noip](https://www.noip.com/) — 동적 DNS 서비스. 30일마다 확인 시 최대 3개 호스트네임 무료
* [sslip.io](https://sslip.io/) — 호스트네임에 포함된 IP를 질의하면 해당 IP를 반환하는 무료 DNS 서비스.
* [zilore.com](https://zilore.com/en/dns) — 5도메인 무료 DNS 호스팅.
* [zoneedit.com](https://www.zoneedit.com/free-dns/) — 다이나믹 DNS 지원 무료 DNS 호스팅.
* [zonewatcher.com](https://zonewatcher.com) — 자동 백업, DNS 변경 모니터링. 1도메인 무료
* [huaweicloud.com](https://www.huaweicloud.com/intl/en-us/product/dns.html) – 화웨이 제공 무료 DNS 호스팅
* [Hetzner](https://www.hetzner.com/dns-console) – API 지원 무료 Hetzner DNS 호스팅.
* [Glauca](https://docs.glauca.digital/hexdns/) – 최대 3도메인 무료 DNS 호스팅, DNSSEC 지원
* [VolaryDDNS](https://volaryddns.net) - 구독 또는 광고 없이 제공되는 고성능 무료 DDNS
**[⬆️ 맨 위로 이동](#table-of-contents)**

## 도메인

  * [pp.ua](https://nic.ua/) — 무료 pp.ua 서브도메인 제공.
  * [us.kg](https://nic.us.kg/) - 무료 us.kg 서브도메인 제공.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## IaaS

  * [4EVERLAND](https://www.4everland.org/) — AWS S3와 호환 - API, 인터페이스 작업, CLI, 기타 업로드 방법 지원. IPFS 및 Arweave 네트워크에서 파일을 안전하고 편리하며 효율적으로 업로드 및 저장. 가입자는 6GB의 IPFS 스토리지와 300MB의 Arweave 스토리지를 무료로 제공받으며, 150KB 미만의 Arweave 파일 업로드는 무료.
  * [backblaze.com](https://www.backblaze.com/b2/) — Backblaze B2 클라우드 스토리지. 10GB(아마존 S3와 유사) 오브젝트 스토리지를 무제한 기간 무료 제공
  * [filebase.com](https://filebase.com/) - 블록체인 기반 S3 호환 오브젝트 스토리지. 무제한 기간 5GB 무료 저장공간 제공.
  * [Tebi](https://tebi.io/) - S3 호환 오브젝트 스토리지. 25GB 무료 저장공간 및 250GB 아웃바운드 전송.
  * [Idrive e2](https://www.idrive.com/e2/) - S3 호환 오브젝트 스토리지. 월 10GB 무료 저장공간 및 10GB 다운로드 대역폭.
  * [C2 Object Storage](https://c2.synology.com/en-us/pricing/object-storage) - S3 호환 오브젝트 스토리지. 월 15GB 무료 저장공간 및 15GB 다운로드.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 매니지드 데이터 서비스

  * [Aiven](https://aiven.io/) - Aiven은 오픈소스 데이터 플랫폼에서 PostgreSQL, MySQL, Redis 무료 플랜 제공. 단일 노드, 1 CPU, 1GB RAM, PostgreSQL/MySQL의 경우 5GB 저장공간. 더 넓은 플랜이나 클라우드 간 마이그레이션 용이.
  * [airtable.com](https://airtable.com/) — 스프레드시트처럼 보이지만 관계형 데이터베이스. 무제한 베이스, 베이스당 1,200행, 월 1,000 API 요청.
  * [Astra](https://www.datastax.com/products/datastax-astra/) — 클라우드 네이티브 Cassandra as a Service, [80GB 무료 티어](https://www.datastax.com/products/datastax-astra/pricing) 제공
  * [codehooks.io](https://codehooks.io/) — 사용하기 쉬운 자바스크립트 서버리스 API/백엔드 및 NoSQL 데이터베이스 서비스. 함수, Mongdb-ish 쿼리, 키/값 조회, 작업 시스템, 실시간 메시지, 워커 큐, 강력한 CLI, 웹 기반 데이터 관리 포함. 무료 플랜 5GB 저장공간, 분당 60 API 호출, 2명 개발자, 신용카드 불필요.
  * [CrateDB](https://crate.io/) - 분산형 오픈소스 SQL 데이터베이스, 실시간 분석 지원. [무료 티어 CRFREE](https://crate.io/lp-crfree): 1노드, 2 CPU, 2GiB 메모리, 8GiB 스토리지. 조직당 1개 클러스터, 결제 수단 불필요.
  * [Upstash](https://upstash.com/) — 서버리스 Redis 무료 티어(일 1만 요청, 최대 256MB DB, 20 동시 연결)
  * [Couchbase Capella](https://www.couchbase.com/products/capella/) - 개발자를 위한 영구 무료 티어 완전 관리형 데이터베이스 클러스터 제공, IoT부터 AI까지 차세대 앱 개발 가능
  * [MongoDB Atlas](https://www.mongodb.com/cloud/atlas) — 무료 티어 512MB 제공
  * [redsmin.com](https://www.redsmin.com/) — Redis 온라인 실시간 모니터링 및 관리 서비스, 1개 Redis 인스턴스 모니터링 무료
  * [redislabs](https://redislabs.com/try-free/) - 30MB 무료 redis 인스턴스 제공
  * [MemCachier](https://www.memcachier.com/) — 관리형 Memcache 서비스. 최대 25MB, 1 프록시 서버, 기본 분석 무료
  * [scalingo.com](https://scalingo.com/) — 주로 PaaS지만 MySQL, PostgreSQL, MongoDB의 128MB~192MB 무료 티어 제공
  * [SeaTable](https://seatable.io/) — Seafile 팀이 개발한 유연한 스프레드시트형 데이터베이스. 무제한 테이블, 2,000라인, 1개월 버전 관리, 최대 25명 팀원.
  * [skyvia.com](https://skyvia.com/) — 클라우드 데이터 플랫폼, 무료 티어 제공, 베타 기간 모든 플랜 완전 무료
  * [StackBy](https://stackby.com/) — 스프레드시트의 유연성, 데이터베이스의 파워, 비즈니스 앱 통합 제공. 무료 플랜: 무제한 사용자, 10 스택, 스택당 2GB 첨부파일.
  * [TiDB Cloud](https://en.pingcap.com/tidb-cloud/) — TiDB는 오픈소스 MySQL 호환 분산 HTAP RDBMS. TiDB Serverless는 월 5GB 행 스토리지, 5GB 컬럼 스토리지, 5천만 Request Unit(RU) 무료 제공.
  * [Turso by ChiselStrike](https://chiselstrike.com/) - Turso는 엣지 DB에서 SQLite 개발 경험 제공. Free Forever 스타터 플랜: 총 9GB 저장공간, 최대 500 DB, 최대 3개 위치, 월 10억 행 읽기, SQLite 기반 로컬 개발 지원.
  * [InfluxDB](https://www.influxdata.com/) — 시계열 데이터베이스, 3MB/5분 기록, 30MB/5분 읽기, 1만 개 시리즈 무료
  * [restdb.io](https://restdb.io/) - 빠르고 간편한 NoSQL 클라우드 데이터베이스 서비스. 스키마, 관계, 자동 REST API(MongoDB 유사 쿼리), 효율적 다중 사용자 관리 UI. 무료 플랜: 3명 사용자, 2,500개 레코드, 초당 1 API 요청.
  * [CockroachDB Cloud](https://www.cockroachlabs.com/pricing/) — 무료 티어: 월 5천만 RU, 10GiB 스토리지(15달러 상당) 무료. ([Request Unit이란?](https://www.cockroachlabs.com/docs/cockroachcloud/metrics-request-units.html))
  * [Neo4j Aura](https://neo4j.com/cloud/aura/) — 관리형 네이티브 그래프 DBMS/분석 플랫폼, Cypher 쿼리언어, REST API 지원. 그래프 크기 제한(5만 노드, 17.5만 관계).
  * [Neon](https://neon.tech/) — 관리형 PostgreSQL, 총 0.5GB 저장공간, 1개 프로젝트, 10개 브랜치, 무제한 DB, 항상 활성화된 기본 브랜치(5분 후 자동 일시정지), 비기본 브랜치 컴퓨트 월 20시간 제공.
  * [Prisma Postgres](https://prisma.io/postgres) - 유니커널 기반 초고속 호스팅 Postgres, 1GB 저장공간, 10개 DB, Prisma ORM 통합.
  * [Dgraph Cloud](https://cloud.dgraph.io/pricing?type=free) — 관리형 네이티브 그래프 DBMS, GraphQL API 제공. 일 1MB 데이터 전송 제한.
  * [Tinybird](https://tinybird.co) - 서버리스 관리형 ClickHouse, HTTP 기반 커넥션리스 데이터 인제스트, SQL 쿼리 HTTP API로 게시 가능. 무료 티어 기간 제한 없음, 10GB 저장공간 + 일 1,000 API 요청.
  * [TigerGraph Cloud](https://www.tigergraph.com/cloud/) — 관리형 네이티브 그래프 DBMS/분석 플랫폼, SQL 유사 그래프 쿼리언어, REST API 지원. 2 vCPU, 8GB 메모리, 50GB 스토리지 무료 인스턴스 1개, 1시간 비활성 시 슬립.
  * [TerminusCMS](https://terminusdb.com/pricing) — TerminusDB(프롤로그와 러스트로 작성된 문서 및 그래프 DB) 관리형 무료 서비스. 개발자는 무료, 엔터프라이즈 배포/지원은 유료.
  * [filess.io](https://filess.io) - MySQL, MariaDB, MongoDB, PostgreSQL 중 2개 DBMS, DB당 최대 10MB 무료로 생성 가능.
  * [xata.io](https://xata.io) - 서버리스 DB, 강력한 검색/분석 내장. 하나의 API, 다수 타입세이프 클라이언트 라이브러리, 개발 워크플로우에 최적화. 무료-영구 티어는 취미 개발자에 충분, Xata 단위 3개 제공(단위 정의는 사이트 참고).
  * [8base.com](https://www.8base.com/) - 자바스크립트 개발자를 위한 풀스택 로우코드 개발 플랫폼. MySQL, GraphQL, 서버리스 BaaS 기반. UI 앱 빌더로 빠른 웹앱 개발 및 확장 가능. 무료 티어: 2,500행, 500 저장공간, 1Gb/h 서버리스 컴퓨팅, 5명 클라이언트 앱 사용자.
  * [Nile](https://www.thenile.dev/) — B2B 앱용 Postgres 플랫폼. 무제한 데이터베이스, 항상 사용 가능(자동 종료 없음), 총 1GB 저장공간, 5천만 쿼리 토큰, 오토스케일링, 무제한 벡터 임베딩



**[⬆️ 맨 위로 이동](#table-of-contents)**

## 터널링, WebRTC, 웹소켓 서버 및 기타 라우터

  * [Pinggy](https://pinggy.io) — 명령 한 번으로 localhost를 공개 URL로 노출, 다운로드 불필요. HTTPS/TCP/TLS 터널 지원. 무료 플랜 터널 유효시간 60분.
  * [conveyor.cloud](https://conveyor.cloud/) — Visual Studio 확장, IIS Express를 로컬 네트워크 또는 공개 URL로 터널 노출.
  * [Hamachi](https://www.vpn.net/) — LogMeIn Hamachi는 LAN과 유사한 네트워크를 분산 팀에 안전하게 확장해주는 호스팅 VPN 서비스. 무료 플랜은 최대 5명, 무제한 네트워크 허용
  * [Mirna Sockets](https://mirna.cloud/) - Socket as a Service 플랫폼, 웹소켓 서버 코드를 배포하면 wss:// URL 제공, 성능 모니터링 가능. 무료 제공.
  * [localhost.run](https://localhost.run/) — 로컬 서버를 터널로 공개 URL에 노출.
  * [localtunnel](https://theboroer.github.io/localtunnel-www/) — 로컬 서버를 터널로 공개 URL에 노출. 무료 호스팅 버전, [오픈소스](https://github.com/localtunnel/localtunnel).
  * [ngrok.com](https://ngrok.com/) — 로컬 서버를 터널로 공개 URL에 노출.
  * [cname.dev](https://cname.dev/) — 무료 보안 동적 리버스 프록시 서비스.
  * [serveo](https://serveo.net/) — 로컬 서버를 인터넷에 노출. 설치/가입 불필요. 무료 서브도메인, 제한 없음.
  * [Radmin VPN](https://www.radmin-vpn.com/) — VPN을 통해 여러 컴퓨터를 LAN과 유사한 네트워크로 연결. 무제한 피어. (Hamachi 대안)
  * [segment.com](https://segment.com/) — 이벤트를 타사 서비스로 라우팅 및 변환하는 허브. 월 10만 이벤트 무료
  * Google STUN — [stun:stun.l.google.com:19302](stun:stun.l.google.com:19302)
  * Twilio STUN — [stun:global.stun.twilio.com:3478?transport=udp](stun:global.stun.twilio.com:3478?transport=udp)
  * [Tailscale](https://tailscale.com/) — 오픈소스 WireGuard 프로토콜 기반 제로 구성 VPN. MacOS, iOS, Windows, Linux, Android 지원. 개인용 무료 플랜: 최대 100기기, 3명 사용자.
  * [webhookrelay.com](https://webhookrelay.com) — 모든 웹훅을 공개 또는 내부(예: localhost) 대상으로 관리, 디버그, 분배, 프록시. 프라이빗 네트워크 내 서버도 퍼블릭 HTTP 엔드포인트로 노출(`https://yoursubdomain.webrelay.io <----> http://localhost:8080`).
  * [Hookdeck](https://hookdeck.com/pricing) — 어디서나 웹훅 개발, 테스트, 모니터링. 월 10만 요청/10만 시도, 3일 데이터 보관.
  * [Xirsys](https://www.xirsys.com/pricing/) — 무제한 STUN 사용 + 월 500MB TURN 대역폭, 대역폭 제한, 단일 지역.
  * [ZeroTier](https://www.zerotier.com) — FOSS 관리형 가상 이더넷 서비스. 무료 플랜 최대 25클라이언트, 무제한 종단간 암호화 네트워크. 데스크톱/모바일 클라이언트, 웹 인터페이스로 맞춤 라우팅/노드 승인 관리.
  * [LocalXpose](https://localxpose.io) — 로컬 서버를 인터넷에 노출하는 리버스 프록시. 무료 플랜 터널 유효시간 15분.
  * [Traefik-Hub](https://traefik.io/traefik-hub/) - 터널을 통해 로컬 서비스 공개, 액세스 제어로 보호. 한 클러스터에 5개 서비스 무료.
  * [Expose](https://expose.dev/) - 보안 터널로 로컬 사이트 공개. 무료 플랜: EU 서버, 랜덤 서브도메인, 단일 사용자.
  * [btunnel](https://www.btunnel.in/) — localhost 및 로컬 tcp 서버를 인터넷에 노출. 무료 플랜: 파일 서버, 맞춤 HTTP 요청/응답 헤더, 기본 인증 보호, 터널 타임아웃 1시간.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 이슈 트래킹 및 프로젝트 관리

  * [acunote.com](https://www.acunote.com/) — 최대 5명 팀원까지 무료 프로젝트 관리 및 SCRUM 소프트웨어
  * [asana.com](https://asana.com/) — 협업자와 함께하는 개인 프로젝트는 무료
  * [Backlog](https://backlog.com) — 한 플랫폼에서 팀이 필요한 모든 프로젝트 관리. 무료 플랜: 1개 프로젝트, 10명 사용자, 100MB 저장공간 제공.
  * [Basecamp](https://basecamp.com/personal) - 할 일 목록, 마일스톤 관리, 포럼형 메시지, 파일 공유, 시간 추적. 최대 3개 프로젝트, 20명 사용자, 1GB 저장공간.
  * [bitrix24.com](https://www.bitrix24.com/) — 인트라넷 및 프로젝트 관리 툴. 무료 플랜: 무제한 사용자, 5GB 저장공간.
  * [cacoo.com](https://cacoo.com/) — 온라인 실시간 다이어그램: 플로우차트, UML, 네트워크. 최대 15명/다이어그램, 25장 무료
  * [Chpokify](https://chpokify.com/) — 팀 기반 플래닝 포커, 스프린트 추정 시간 절약. 최대 5명 무료, Jira 연동 무료, 무제한 영상통화/팀/세션.
  * [clickup.com](https://clickup.com/) — 프로젝트 관리. 무료, 프리미엄 버전은 클라우드 저장소 제공. 모바일 앱, Git 연동 제공.
  * [Clockify](https://clockify.me) - 프로젝트별 근무시간 추적용 타임 트래커/타임시트 앱. 무제한 사용자, 영구 무료.
  * [Cloudcraft](https://cloudcraft.co/) — AWS에 최적화된 전문 아키텍처 다이어그램을 빠르게 설계. 무료 플랜은 1인 사용자 무제한 개인 다이어그램 제공.
  * [Codegiant](https://codegiant.io) — 저장소 호스팅 & CI/CD 포함 프로젝트 관리. 무료 플랜: 무제한 저장소/프로젝트/문서, 5명 팀원, 월 500 CI/CD 분, 월 30,000 서버리스 코드 실행 분, 1GB 저장소.
  * [Confluence](https://www.atlassian.com/software/confluence) - Atlassian의 콘텐츠 협업 도구. 팀 지식 공유/협업 최적화. 최대 10명 무료 플랜.
  * [contriber.com](https://www.contriber.com/) — 맞춤형 프로젝트 관리 플랫폼, 무료 스타터 플랜, 5개 워크스페이스
* [Crosswork](https://crosswork.app/) - 다용도의 프로젝트 관리 플랫폼. 최대 3개 프로젝트, 무제한 사용자, 1GB 저장 공간까지 무료 제공.
* [diagrams.net](https://app.diagrams.net/) — 온라인 다이어그램을 Google Drive, OneDrive, Dropbox에 로컬로 저장. 모든 기능과 저장 용량이 무료.
* [freedcamp.com](https://freedcamp.com/) - 작업, 토론, 마일스톤, 시간 추적, 캘린더, 파일, 비밀번호 관리자 등 제공. 무제한 프로젝트, 사용자, 파일 저장 공간의 무료 플랜 제공.
* [easyretro.io](https://www.easyretro.io/) — 간단하고 직관적인 스프린트 회고 도구. 무료 플랜은 공개 보드 3개, 보드당 월 1회 설문 제공.
* [GForge](https://gforge.com) — 복잡한 프로젝트를 위한 프로젝트 관리 및 이슈 추적 도구 세트. 온프레미스와 SaaS 옵션 제공. SaaS 무료 플랜은 최초 5명 사용자 무료 및 오픈소스 프로젝트 무료 제공.
* [gleek.io](https://www.gleek.io) — 개발자를 위한 무료 설명→다이어그램 도구. 키워드만으로 비공식 UML 클래스, 오브젝트, ER 다이어그램 생성.
* [GraphQL Inspector](https://github.com/marketplace/graphql-inspector) - GraphQL Inspector는 두 GraphQL 스키마 간의 변경 사항 목록을 출력. 모든 차이점은 정확히 설명되고, 브레이킹/비브레이킹/위험으로 표시됨.
* [huboard.com](https://huboard.com/) — GitHub 이슈를 위한 즉시 프로젝트 관리, 오픈소스 무료
* [Hygger](https://hygger.io) — 프로젝트 관리 플랫폼. 무료 플랜은 무제한 사용자, 프로젝트, 보드와 100MB 저장 공간 제공.
* [Instabug](https://instabug.com) — 모바일 앱을 위한 종합 버그 리포팅 및 인앱 피드백 SDK. 무료 플랜은 앱 1개, 멤버 1명까지 제공.
* [WishKit](https://wishkit.io) — iOS/macOS 앱의 인앱 사용자 피드백 수집 및 투표 기반 기능 우선순위 지정. 무료 플랜은 앱 1개까지 제공.
* [Ilograph](https://www.ilograph.com/)  — 다양한 관점과 세부 수준에서 인프라를 볼 수 있는 인터랙티브 다이어그램. 차트는 코드로 표현 가능. 무료 티어는 최대 3명의 뷰어와 무제한 비공개 다이어그램 제공.
* [Jira](https://www.atlassian.com/software/jira) — 많은 기업 환경에서 사용되는 고급 소프트웨어 개발 프로젝트 관리 도구. 10명까지 무료 플랜 제공.
* [kanbanflow.com](https://kanbanflow.com/) — 보드 기반 프로젝트 관리. 무료, 프리미엄 버전은 더 많은 옵션 제공
* [kanbantool.com](https://kanbantool.com/) — 칸반 보드 기반 프로젝트 관리. 무료 플랜은 보드 2개, 사용자 2명, 첨부파일 및 파일 미제공.
* [kan.bn](https://kan.bn/) - 강력하고 유연한 칸반 앱. 한 곳에서 작업 조직, 진행 상황 추적, 결과 제공. 무료 플랜은 사용자 1명, 무제한 보드·리스트·카드 제공.
* [Kitemaker.co](https://kitemaker.co) - 제품 개발 전 과정을 협업하고 Slack, Discord, Figma, Github와 연동. 무제한 사용자, 공간 제공. 무료 플랜은 250개 작업 아이템까지.
* [Kiter.app](https://www.kiter.app/) - 누구나 구직 활동을 정리하고, 면접/기회/연락처 추적 가능. 강력한 웹앱 및 Chrome 확장 프로그램. 완전 무료.
* [Kumu.io](https://kumu.io/)  — 애니메이션, 장식, 필터, 클러스터링, 스프레드시트 가져오기 등 다양한 기능의 관계도. 무료 티어는 무제한 공개 프로젝트, 그래프 크기 무제한. 학생에겐 비공개 프로젝트 무료 제공. 샌드박스 모드 제공(온라인 공개 없이 파일 업로드/편집/다운로드/삭제 가능).
* [Linear](https://linear.app/) — 간결한 인터페이스의 이슈 트래커. 무제한 멤버, 최대 10MB 파일 업로드, 250개 이슈(아카이브 제외)까지 무료
* [leiga.com](https://www.leiga.com/) — AI가 프로젝트를 자동으로 관리해 팀 집중력·생산성 향상. 최대 10명, 20개 커스텀 필드, 2GB 저장 공간, 영상녹화 AI 5분/영상, 자동화 실행 20회/사용자/월 무료.
* [Lucidchart](https://www.lucidchart.com/) - 협업 기능이 포함된 온라인 다이어그램 도구. 편집 가능한 문서 3개, 100개 전문 템플릿, 기본 협업 기능의 무료 플랜.
* [MeisterTask](https://www.meistertask.com/) — 팀을 위한 온라인 작업 관리. 최대 3개 프로젝트, 무제한 프로젝트 멤버 무료.
* [MeuScrum](https://www.meuscrum.com/en) - 칸반 보드가 포함된 무료 온라인 스크럼 도구
* [nTask](https://www.ntaskmanager.com/) — 팀 협업, 계획, 분석 및 일상 작업 관리를 지원하는 프로젝트 관리 소프트웨어. 필수 플랜은 100MB 저장, 5명/팀까지 영구 무료. 무제한 작업공간, 미팅, 할당, 근무표, 이슈 추적 제공.
* [Ora](https://ora.pm/) - 애자일 작업 관리 및 팀 협업. 최대 3명 사용자, 파일은 10MB까지 무료.
* [pivotaltracker.com](https://www.pivotaltracker.com/) — 무제한 공개 프로젝트 및 2개 비공개 프로젝트가 3명 활성 사용자(읽기/쓰기), 무제한 수동 사용자(읽기 전용)까지 무료.
* [plan.io](https://plan.io/) — 저장소 호스팅 등 다양한 옵션의 프로젝트 관리. 2명 사용자, 10명 고객, 500MB 저장공간 무료 제공
* [Plane](https://plane.so/) - 단순하고 확장 가능한 오픈소스 프로젝트·제품 관리 도구. 무제한 멤버, 파일 업로드 5MB, 이슈 1000개까지 무료.
* [planitpoker.com](https://www.planitpoker.com/) — 무료 온라인 플래닝 포커(견적 도구)
* [point.poker](https://www.point.poker/) - 온라인 플래닝 포커(합의 기반 견적 도구). 무제한 사용자, 팀, 세션, 라운드, 투표 무료. 회원가입 불필요.
* [ScrumFast](https://www.scrumfast.com) - 매우 직관적인 인터페이스의 스크럼 보드, 5명까지 무료.
* [Shake](https://www.shakebugs.com/) - 모바일 앱용 인앱 버그 리포팅 및 피드백 도구. 무료 플랜은 앱당 월 10건 버그 리포트 제공.
* [Shortcut](https://shortcut.com/) - 프로젝트 관리 플랫폼. 10명까지 영구 무료.
* [Tadum](https://tadum.app) - 반복 회의를 위한 안건 및 회의록 앱, 10명 팀까지 무료
* [taiga.io](https://taiga.io/) — 스타트업과 애자일 개발자를 위한 프로젝트 관리 플랫폼, 오픈소스 무료
* [Tara AI](https://tara.ai/) — 간단한 스프린트 관리 서비스. 무료 플랜은 무제한 작업, 스프린트, 작업공간, 사용자 제한 없음.
* [targetprocess.com](https://www.targetprocess.com/) — 칸반, 스크럼 등 다양한 운영 프로세스의 시각적 프로젝트 관리. 무제한 사용자, 1000개 데이터 엔터티까지 무료 {[상세정보](https://www.targetprocess.com/pricing/)}
* [taskade.com](https://www.taskade.com/) — 실시간 협업 작업 목록 및 팀 아웃라인. 무료 플랜은 1개 워크스페이스, 무제한 작업·프로젝트, 1GB 파일 저장소, 1주일 프로젝트 기록, 화상회의 최대 5명 참석자 제공.
* [taskulu.com](https://taskulu.com/) — 역할 기반 프로젝트 관리. 최대 5명 사용자 무료. GitHub/Trello/Dropbox/Google Drive 연동 지원
* [Teaminal](https://www.teaminal.com) - 원격 팀을 위한 스탠드업, 회고, 스프린트 계획 도구. 최대 15명까지 무료.
* [teamwork.com](https://teamwork.com/) — 프로젝트 관리 및 팀 채팅. 5명, 2개 프로젝트까지 무료. 프리미엄 플랜 제공.
* [teleretro.com](https://www.teleretro.com/) — 아이스브레이커, GIF, 이모지 등과 함께하는 간단하고 재미있는 회고 도구. 무료 플랜은 3회 회고, 무제한 멤버 제공.
* [testlio.com](https://testlio.com/) — 이슈 추적, 테스트 관리, 베타 테스트 플랫폼. 개인 사용 무료
* [terrastruct.com](https://terrastruct.com/) — 소프트웨어 아키텍처에 특화된 온라인 다이어그램 제작기. 다이어그램당 최대 4개 레이어까지 무료.
* [todoist.com](https://todoist.com/) — 협업 및 개인 작업 관리. 무료 플랜: 활성 프로젝트 5개, 프로젝트별 5명, 파일 업로드 5MB, 필터 3개, 활동 기록 1주 제공.
* [trello.com](https://trello.com/) — 보드 기반 프로젝트 관리. 무제한 개인 보드, 팀 보드 10개.
* [Tweek](https://tweek.so/) — 심플한 주간 할일 캘린더 및 작업 관리.
* [ubertesters.com](https://ubertesters.com/) — 테스트 플랫폼, 통합 및 크라우드 테스터, 2개 프로젝트, 5명 멤버 무료
* [Wikifactory](https://wikifactory.com/) — 프로젝트, VCS, 이슈 기능의 제품 설계 서비스. 무료 플랜은 무제한 프로젝트·협업자, 3GB 저장공간 제공.
* [Yodiz](https://www.yodiz.com/) — 애자일 개발 및 이슈 추적. 3명, 무제한 프로젝트까지 무료.
* [YouTrack](https://www.jetbrains.com/youtrack/buy/#edition=incloud) — FOSS 프로젝트 및 비공개 프로젝트를 위한 무료 호스팅 YouTrack(InCloud) (3명까지 무료). 시간 추적, 애자일 보드 포함
* [zenhub.com](https://www.zenhub.com) — GitHub 내부에서 사용할 수 있는 유일한 프로젝트 관리 솔루션. 공개 저장소, 오픈소스, 비영리 단체 무료
* [zenkit.com](https://zenkit.com) — 프로젝트 관리 및 협업 도구. 최대 5명, 5GB 첨부파일까지 무료.
* [Zube](https://zube.io) — 프로젝트 관리, 4개 프로젝트 및 4명 사용자 무료 플랜 제공. GitHub 연동 가능.
* [Toggl](https://toggl.com/) — 두 가지 무료 생산성 도구 제공. [Toggl Track](https://toggl.com/track/)은 프리랜서를 위한 시간 관리 및 추적 앱, 무제한 추적 기록·프로젝트·클라이언트·태그·보고서 등 무료. [Toggl Plan](https://toggl.com/plan/)은 솔로 개발자를 위한 작업 계획, 무제한 작업·마일스톤·타임라인 무료.
* [Sflow](https://sflow.io) — sflow.io는 애자일 소프트웨어 개발, 마케팅, 영업, 고객 지원, 특히 아웃소싱·조직 간 협업 프로젝트를 위한 프로젝트 관리 도구. 최대 3개 프로젝트, 5명 멤버까지 무료.
* [Pulse.red](https://pulse.red) — 무료 미니멀리즘 프로젝트용 타임 트래커 및 근무표 앱.

**[⬆️ 맨 위로](#table-of-contents)**

## 저장소 및 미디어 처리

* [AndroidFileHost](https://androidfilehost.com/) - 무제한 속도, 대역폭, 파일 수, 다운로드 수 등 제공하는 무료 파일 공유 플랫폼. 주로 Android 개발 관련 파일(APK 빌드, 커스텀 ROM, 수정 등)에 적합하지만, 다른 파일도 허용하는 듯.
* [borgbase.com](https://www.borgbase.com/) — Borg Backup을 위한 간단하고 안전한 오프사이트 백업 호스팅. 10GB 무료 백업 공간 및 저장소 2개.
* [icedrive.net](https://www.icedrive.net/) - 간단한 클라우드 저장소 서비스. 10GB 무료 저장 공간
* [sync.com](https://www.sync.com/) - 종단 간 암호화 클라우드 저장소 서비스. 5GB 무료 저장 공간
* [pcloud.com](https://www.pcloud.com/) - 클라우드 저장소 서비스. 최대 10GB 무료 저장 공간
* [sirv.com](https://sirv.com/) — 실시간 이미지 최적화 및 리사이즈 기능이 있는 스마트 이미지 CDN. 무료 티어는 500MB 저장공간, 2GB 대역폭 포함.
* [cloudimage.io](https://www.cloudimage.io/en/home) — 전 세계 1,500개 이상의 PoP를 갖춘 이미지 최적화 및 CDN 서비스. 다양한 이미지 리사이즈, 압축, 워터마크 기능. 반응형 이미지, 360 이미지, 이미지 편집용 오픈소스 플러그인 제공. 월 25GB CDN 트래픽, 25GB 캐시 저장공간, 무제한 변환의 무료 플랜.
* [cloudinary.com](https://cloudinary.com/) — 이미지 업로드, 강력한 조작, 저장, 제공 서비스. Ruby, Python, Java, PHP, Objective-C 등 다양한 라이브러리 지원. 무료 티어는 월 25 크레딧(1,000 이미지 변환, 1GB 저장, 1GB CDN 사용 각각 1 크레딧).
* [embed.ly](https://embed.ly/) — 웹페이지에 미디어 임베딩, 반응형 이미지 스케일링, 웹페이지 요소 추출 API 제공. 월 5,000 URL, 초당 15 요청까지 무료
* [filestack.com](https://www.filestack.com/) — 파일 선택, 변환, 제공 서비스. 250개 파일, 500개 변환, 3GB 대역폭 무료
* [file.io](https://www.file.io) - 2GB 파일 저장. 1회 다운로드 후 자동 삭제. REST API 제공, 분당 1회 요청 제한.
* [freetools.site](https://freetools.site/) — 무료 온라인 도구. 문서, 이미지, 오디오, 비디오 등 변환·편집 지원.
* [GoFile.io](https://gofile.io/) - 웹 UI 및 API를 통해 사용 가능한 무료 파일 공유·저장 플랫폼. 파일 크기, 대역폭, 다운로드 수 무제한. 단, 10일 이상 다운로드 없는 파일은 삭제됨.
* [gumlet.com](https://www.gumlet.com/) — 이미지·비디오 호스팅, 처리, CDN 스트리밍. 비디오 월 250GB, 이미지 월 30GB 무료 제공.
* [image-charts.com](https://www.image-charts.com/) — 워터마크 포함 무제한 이미지 차트 생성
* [Imgbot](https://github.com/marketplace/imgbot) — 이미지를 최적화해 용량을 줄여주는 오픈소스용 무료 자동화 봇.
* [ImgBB](https://imgbb.com/) — 무제한 이미지 호스팅 서비스. 화면 어디든 드래그앤드롭 업로드. 이미지당 32MB 제한. 업로드 후 직접 링크, BBCode, HTML 썸네일 제공. 로그인 시 업로드 기록 확인 가능.
* [imgen](https://www.jitbit.com/imgen/) - 워터마크 없는 무료 무제한 소셜 커버 이미지 생성 API
* [imgix](https://www.imgix.com/) - 이미지 캐싱, 관리, CDN. 무료 플랜은 1,000개 원본 이미지, 무한 변환, 100GB 대역폭 제공
* [kraken.io](https://kraken.io/) — 웹사이트 성능을 위한 이미지 최적화 서비스, 파일당 1MB까지 무료 플랜
* [kvstore.io](https://www.kvstore.io/) — 키-값 저장 서비스. 무료 티어는 100개 키, 키당 1KB, 시간당 100회 호출 허용
* [npoint.io](https://www.npoint.io/) — 협업 스키마 편집이 가능한 JSON 저장소
* [nitropack.io](https://nitropack.io/) - 사이트 속도 자동 최적화(캐싱, 이미지·코드 최적화, CDN). 월 5,000 페이지뷰까지 무료
* [otixo.com](https://www.otixo.com/) — 모든 클라우드 저장소 파일을 한 곳에서 암호화, 공유, 복사, 이동. 기본 플랜은 무제한 파일 전송(최대 파일 250MB), 암호화 파일 5개 제공
* [packagecloud.io](https://packagecloud.io/) — YUM, APT, RubyGem, PyPI용 호스팅 패키지 저장소. 요청 시 제한적 무료/오픈소스 플랜 제공
* [getpantry.cloud](https://getpantry.cloud/) — 개인 프로젝트, 해커톤, 모바일 앱에 적합한 간단한 JSON 데이터 저장 API!
* [Pinata IPFS](https://pinata.cloud) — IPFS에 파일을 업로드·관리하는 가장 쉬운 방법. 간편한 UI와 IPFS API 제공. 1GB 저장소, API 접근 무료.
* [placekitten.com](https://placekitten.com/) — 플레이스홀더용 고양이 이미지를 빠르고 간단하게 제공
* [plot.ly](https://plot.ly/) — 데이터 그래프 및 공유 서비스. 무료 티어는 무제한 공개 파일, 10개 비공개 파일 제공
* [podio.com](https://podio.com/) — 최대 5명 팀으로 Basic Plan 기능(사용자 관리 제외) 체험 가능
* [QRME.SH](https://qrme.sh) - 로그인/워터마크/광고 없이 빠르고 아름다운 대량 QR코드 생성기. 1회 최대 100개 URL 일괄 내보내기.
* [QuickChart](https://quickchart.io) — 임베드 가능한 이미지 차트, 그래프, QR코드 생성
* [redbooth.com](https://redbooth.com) — P2P 파일 동기화, 최대 2명까지 무료
* [resmush.it](https://resmush.it) — reSmush.it은 이미지 최적화 무료 API. WordPress, Drupal, Magento 등 주요 CMS에 적용. 70억 이상 이미지 처리, 여전히 무료.
* [Shotstack](https://shotstack.io) - 대규모 동영상 생성·편집 API. 월 최대 20분 렌더링 무료
* [tinypng.com](https://tinypng.com/) — PNG, JPEG 압축·리사이즈 API, 월 500회 무료 압축 제공
* [transloadit.com](https://transloadit.com/) — 파일 업로드, 동영상/오디오/이미지/문서 인코딩 처리. 오픈소스, 자선, 학생(GitHub Student Pack) 무료. 상용앱은 2GB 무료 체험
* [twicpics.com](https://www.twicpics.com) - 서비스형 반응형 이미지. 이미지 CDN, 미디어 처리 API, 프론트엔드 라이브러리를 제공하여 이미지 최적화를 자동화합니다. 월 트래픽 3GB까지 무료로 제공됩니다.
* [uploadcare.com](https://uploadcare.com/hub/developers/) — Uploadcare는 최첨단 알고리즘 기반의 미디어 파이프라인과 궁극의 툴킷을 제공합니다. 모든 기능은 개발자에게 완전히 무료로 제공됩니다: 파일 업로드 API 및 UI, 이미지 CDN 및 Origin 서비스, 적응형 전달, 스마트 압축. 무료 요금제는 3,000건 업로드, 3GB 트래픽, 3GB 저장소를 제공합니다.
* [imagekit.io](https://imagekit.io) – 자동 최적화, 실시간 변환, 저장소를 제공하는 이미지 CDN으로, 기존 환경에 몇 분 만에 통합할 수 있습니다. 무료 요금제는 월 20GB의 대역폭을 포함합니다.
* [internxt.com](https://internxt.com) – Internxt Drive는 절대적인 프라이버시와 타협 없는 보안을 기반으로 한 제로 지식 파일 저장 서비스입니다. 가입 시 10GB를 영구적으로 무료로 제공합니다!
* [degoo.com](https://degoo.com/) – AI 기반 클라우드 저장소, 최대 20GB 무료, 세 대의 기기, 추천 시 5GB 보너스(90일간 계정 비활성 시 적용).
* [MConverter.eu](https://mconverter.eu/) – 파일을 대량 변환. [AVIF](https://mconverter.eu/convert/to/avif/)와 같은 최신 포맷을 포함한 다양한 파일 포맷 지원. 동영상에서 모든 이미지 프레임 추출. 하루 최대 10개의 100MB 파일까지 무료, 2개씩 일괄 처리.
* [ImageEngine](https://imageengine.io/) – ImageEngine은 사용이 간편한 글로벌 이미지 CDN입니다. 60초 이내로 설정 가능. AVIF와 JPEGXL 지원, 워드프레스·마젠토·리액트·뷰 플러그인 등 제공. [여기](https://imageengine.io/developer-program/)에서 무료 개발자 계정 신청 가능.
* [DocsParse](https://docsparse.com/) – GPT 기반 AI로 PDF, 이미지 등을 구조화된 데이터(JSON, CSV, EXCEL)로 변환. 매월 30 크레딧 무료 제공.
* [VaocherApp QR Code Generator](https://www.vaocherapp.com/qr-code-generator) – 기프트 카드, 상품권, 프로모션용 맞춤형 QR 코드 생성. 맞춤 스타일, 색상, 로고 지원.
* [LibreQR](https://libreqr.com) — 프라이버시와 추적 없는 무료 QR 코드 생성기. 데이터 수집 없이 무료 사용 가능.


**[⬆️ 맨 위로](#table-of-contents)**

## 디자인 및 UI

* [AllTheFreeStock](https://allthefreestock.com) - 무료 스톡 이미지, 오디오, 비디오를 선별한 목록.
* [Float UI](https://floatui.com/) - 비디자이너도 빠르게 현대적이고 반응형 웹사이트를 만들 수 있는 무료 웹 개발 도구.
* [Ant Design Landing Page](https://landing.ant.design/) - Ant Motion의 모션 컴포넌트로 빌드된 템플릿 제공. 다양한 홈페이지 템플릿과 템플릿 코드 패키지 다운로드, 빠른 사용 가능. 에디터로 나만의 페이지도 빠르게 구축 가능.
* [Backlight](https://backlight.dev/) — 개발자와 디자이너의 협업을 중심으로 한 완전한 코딩 플랫폼으로, 팀이 디자인 시스템을 구축, 문서화, 배포, 확장, 유지 관리할 수 있습니다. 무료 플랜은 최대 3명의 에디터가 하나의 디자인 시스템에서 무제한 뷰어와 함께 작업할 수 있습니다.
* [BoxySVG](https://boxy-svg.com/app) — SVG를 그릴 수 있고 SVG, PNG, jpeg 등 다양한 포맷으로 내보낼 수 있는 무료 설치형 웹 앱.
* [Carousel Hero](https://carouselhero.com/) - 소셜 미디어 캐러셀을 만들 수 있는 무료 온라인 도구.
* [Circum Icons](https://circumicons.com) - React, Vue, Svelte용 SVG 등 일관성 있는 오픈소스 아이콘 제공.
* [clevebrush.com](https://www.cleverbrush.com/) — 무료 그래픽 디자인/포토 콜라주 앱. 컴포넌트로 유료 통합도 제공.
* [cloudconvert.com](https://cloudconvert.com/) — 무엇이든 변환. 비디오, GIF 등 208개 포맷 지원.
* [CodeMyUI](https://codemyui.com) - 코드 스니펫과 함께 제공되는 엄선된 웹 디자인 및 UI 영감 모음.
* [ColorKit](https://colorkit.co/) - 온라인 컬러 팔레트 생성 또는 인기 팔레트에서 영감 얻기.
* [coolors](https://coolors.co/) - 컬러 팔레트 생성기. 무료.
* [CMYK Pantone](https://www.cmyktopantone.com/) - CMYK 값을 가까운 팬톤 컬러 및 기타 색상 모델로 빠르게 변환. 무료.
* [Branition](https://branition.com/colors) - 브랜드에 가장 적합한 컬러 팔레트 엄선.
* [css-gradient.com](https://www.css-gradient.com/) - 맞춤형 크로스 브라우저 CSS 그라데이션을 빠르게 생성하는 무료 도구. RGB와 HEX 포맷 지원.
* [easyvectors.com](https://easyvectors.com/) — 무료 SVG 벡터 아트 스톡. 최고의 벡터 그래픽을 완전히 무료로 다운로드.
* [figma.com](https://www.figma.com) — 팀을 위한 온라인 협업 디자인 도구. 무료 요금제는 파일 및 뷰어 무제한, 최대 2명의 에디터와 3개의 프로젝트 지원.
* [Flyon UI](https://flyonui.com/)- Tailwind CSS용 가장 쉬운 컴포넌트 라이브러리.
* [framer.com](https://www.framer.com/) - 차기 앱, 웹사이트, 제품의 인터페이스 아이디어를 반복·애니메이션할 수 있도록 지원하는 도구. 전문가용 프로토타이핑 툴로서 무제한 뷰어, 최대 2명 에디터, 3개 프로젝트 제공.
* [freeforcommercialuse.net](https://freeforcommercialuse.net/) — 모델/재산권 걱정 없는 무료 상업용 스톡 사진
* [Gradientos](https://www.gradientos.app) - 그라데이션 선택을 빠르고 쉽게 만듭니다.
* [Icon Horse](https://icon.horse) – 간단한 API로 웹사이트의 최고 해상도 파비콘을 가져올 수 있습니다.
* [Iconoir](https://iconoir.com) – 수천 개의 아이콘을 지원하는 오픈소스 아이콘 라이브러리. React, React Native, Flutter, Vue, Figma, Framer 지원.
* [Icons8](https://icons8.com) — 아이콘, 일러스트, 사진, 음악, 디자인 도구. 무료 플랜은 저해상도 및 제한된 포맷만 제공. 자산 사용 시 Icons8 링크 필요.
* [landen.co](https://www.landen.co) — 코드 없이 아름다운 웹사이트와 랜딩페이지 생성, 편집, 게시. 무료 플랜은 웹사이트 1개, 완전 커스터마이즈 및 웹 게시 가능.
* [Quant Ux](https://quant-ux.com/) - 프로토타이핑 및 디자인 도구. 완전 무료 및 오픈소스.
* [lensdump.com](https://lensdump.com/) - 무료 클라우드 이미지 호스팅.
* [Lorem Picsum](https://picsum.photos/) - 사용이 쉽고 스타일리시한 무료 플레이스홀더 툴. URL 뒤에 원하는 이미지 크기(가로x세로)를 입력하면 랜덤 이미지를 제공.
* [LottieFiles](https://lottiefiles.com/) - 세계 최대의 Lottie 애니메이션(초소형 애니메이션 포맷) 온라인 플랫폼. Android, iOS, Web용 Lottie 애니메이션 도구 및 플러그인 제공.
* [MagicPattern](https://www.magicpattern.design/tools) — 그라데이션, 패턴, 블롭 등 CSS & SVG 배경 생성기 및 도구 모음.
* [marvelapp.com](https://marvelapp.com/) — 디자인, 프로토타이핑, 협업 도구. 무료 플랜은 1인 사용자, 1개 프로젝트로 제한.
* [Mindmup.com](https://www.mindmup.com/) — 무제한 마인드맵을 무료로 만들고 클라우드에 저장. 모든 기기에서 즉시 액세스 가능.
* [Mockplus iDoc](https://www.mockplus.com/idoc) - 디자인 협업 및 핸드오프 도구. 무료 플랜은 3명 사용자, 5개 프로젝트, 모든 기능 제공.
* [mockupmark.com](https://mockupmark.com/create/free) — 소셜 미디어 및 이커머스용 현실적인 티셔츠/의류 목업 생성. 40개 무료 목업.
* [Mossaik](https://mossaik.app) - 웨이브, 블롭, 패턴 등 다양한 도구를 제공하는 무료 SVG 이미지 생성기.
* [movingpencils.com](https://movingpencils.com) — 빠른 브라우저 기반 벡터 에디터. 완전 무료.
* [Octopus.do](https://octopus.do) — 실시간 시각적 사이트맵 빌더. 팀, 고객과 구조를 빠르게 공유 및 협업.
* [Pencil](https://github.com/evolus/pencil) - Electron 기반 오픈소스 디자인 도구.
* [Penpot](https://penpot.app) - 웹 기반 오픈소스 디자인 및 프로토타이핑 도구. SVG 지원. 완전 무료.
* [pexels.com](https://www.pexels.com/) - 상업적 용도의 무료 스톡 사진. 키워드 검색 가능한 무료 API 제공.
* [photopea.com](https://www.photopea.com) — PSD, XCF, Sketch 포맷(Adobe Photoshop, Gimp, Sketch App) 지원, Adobe Photoshop UI의 무료 고급 온라인 디자인 에디터.
* [pixlr.com](https://pixlr.com/) — 상용 소프트웨어 수준의 무료 온라인 브라우저 에디터.
* [Plasmic](https://www.plasmic.app/) - 빠르고 사용하기 쉬우며 견고한 웹 디자인 및 페이지 빌더. 반응형 페이지 및 복잡한 컴포넌트 제작, 코드 확장, 프로덕션 사이트/앱 배포까지 지원.
* [Pravatar](https://pravatar.cc/) - 웹/앱에서 직접 링크할 수 있는 랜덤/플레이스홀더 아바타 생성.
* [Proto.io](https://www.proto.io) - 코딩 없이 완전한 UI 프로토타입 생성. 무료 체험 종료 후 무료 요금제 제공(1인 사용자, 1개 프로젝트, 5개 프로토타입, 100MB 저장소, 앱 미리보기).
* [resizeappicon.com](https://resizeappicon.com/) — 앱 아이콘을 간단하게 리사이즈 및 관리하는 서비스.
* [Rive](https://rive.app) — 모든 플랫폼에 적용 가능한 아름다운 애니메이션 제작 및 배포. 개인 사용자는 영구 무료. 에디터에서 그래픽을 서버에 호스팅하며, 여러 플랫폼용 런타임 제공.
* [storyset.com](https://storyset.com/) — 프로젝트에 맞는 무료 맞춤 일러스트레이션 생성 도구.
* [smartmockups.com](https://smartmockups.com/) — 제품 목업 생성, 200개 무료 목업 제공.
* [Shadcn Studio](https://shadcnstudio.com/theme-editor) — 다양한 컴포넌트 및 레이아웃에서 테마 변경 사항을 미리보기.
* [Tailark](https://tailark.com/) - 마케팅 웹사이트용으로 설계된 현대적이고 반응형의 프리빌트 UI 블록 컬렉션.
* [tabler-icons.io](https://tabler-icons.io/) — 1500개 이상의 무료 복사/붙여넣기 가능한 SVG 편집 아이콘.
* [tweakcn](https://tweakcn.com/) — shadcn/ui용 아름다운 테마. 실시간으로 색상, 타이포그래피 등 커스터마이즈.
* [UI Avatars](https://ui-avatars.com/) - 이름에서 이니셜로 아바타 생성. URL을 웹/앱에서 직접 링크 가능. URL 파라미터로 설정 지원.
* [unDraw](https://undraw.co/) - 크레딧 없이 완전히 자유롭게 사용할 수 있는 아름다운 SVG 이미지 컬렉션.
* [unsplash.com](https://unsplash.com/) - 상업·비상업적 목적 모두 사용 가능한 무료 스톡 사진(제약 없는 라이선스).
* [vectr.com](https://vectr.com/) — 웹+데스크톱용 무료 디자인 앱.
* [walkme.com](https://www.walkme.com/) — 엔터프라이즈급 안내 및 참여 플랫폼, 무료 플랜은 3개의 5단계 워크스루 제공.
* [Webflow](https://webflow.com) - 애니메이션 및 웹 호스팅이 가능한 WYSIWYG 웹사이트 빌더. 2개 프로젝트까지 무료.
* [Updrafts.app](https://updrafts.app) - tailwindcss 기반 디자인용 WYSIWYG 웹사이트 빌더. 비상업용 무료.
* [whimsical.com](https://whimsical.com/) - 협업 플로우차트, 와이어프레임, 스티키노트, 마인드맵. 최대 4개의 보드 무료 생성.
* [Zeplin](https://zeplin.io/) — 디자이너/개발자 협업 플랫폼. 디자인, 자산, 스타일 가이드 제공. 1개 프로젝트 무료.
* [Pixelixe](https://pixelixe.com/) — 매력적이고 독특한 그래픽과 이미지를 온라인에서 생성/편집.
* [Responsively App](https://responsively.app) - 더 빠르고 정밀한 반응형 웹앱 개발을 위한 무료 개발 도구.
* [SceneLab](https://scenelab.io) - 무료 디자인 템플릿이 지속적으로 추가되는 온라인 목업 그래픽 에디터.
* [xLayers](https://xlayers.dev) - Sketch 디자인 파일을 Angular, React, Vue, LitElement, Stencil, Xamarin 등으로 미리보기 및 변환(무료, 오픈소스: https://github.com/xlayers/xlayers)
* [Grapedrop](https://grapedrop.com/) — GrapesJS 프레임워크 기반의 반응형, 강력한, SEO 최적화 웹페이지 빌더. 처음 5페이지까지 무료, 커스텀 도메인 무제한, 모든 기능 사용 가능, 쉬운 사용성.
* [Mastershot](https://mastershot.app) - 완전 무료 브라우저 기반 비디오 에디터. 워터마크 없음, 최대 1080p 내보내기 지원.
* [Unicorn Platform](https://unicornplatform.com/) - 손쉬운 랜딩페이지 빌더 및 호스팅. 1개 웹사이트 무료 제공.
* [SVGmix.com](https://www.svgmix.com/) - 30만개 이상의 무료 SVG 아이콘, 컬렉션, 브랜드 로고 대형 저장소. 브라우저 내 간단한 벡터 편집 프로그램 제공.
* [svgrepo.com](https://www.svgrepo.com/) - 다양한 벡터 라이브러리로 프로젝트에 맞는 아이콘/벡터 탐색, 검색. 상업적 사용 가능한 무료 SVG 벡터 다운로드.
* [haikei.app](https://www.haikei.app/) - 독특한 SVG 도형, 배경, 패턴을 생성하는 웹 앱. 디자인 툴 및 워크플로우에 바로 사용 가능.
* [Canva](https://canva.com) - 시각적 콘텐츠 생성을 위한 무료 온라인 디자인 툴.
* [Superdesigner](https://superdesigner.co) - 몇 번의 클릭만으로 독특한 배경, 패턴, 도형, 이미지 등을 만들 수 있는 무료 디자인 도구 모음.
* [TeleportHQ](https://teleporthq.io/) - 로우코드 프론트엔드 디자인 및 개발 플랫폼. 3개 무료 프로젝트, 무제한 협업, 무료 코드 내보내기.
* [vector.express](https://vector.express) — AI, CDR, DWG, DXF, EPS, HPGL, PDF, PLT, PS, SVG 벡터를 빠르고 쉽게 변환.
* [Vertopal](https://www.vertopal.com) - 다양한 포맷으로 파일을 변환하는 무료 온라인 플랫폼. JPG→SVG, GIF→APNG, PNG→WEBP, JSON→XML 등 개발자용 변환기 포함.
* [okso.app](https://okso.app) - 미니멀한 온라인 드로잉 앱. 빠른 스케치와 시각적 노트 작성. PNG, JPG, SVG, WEBP로 내보내기. PWA 설치 가능. 누구나 무료 사용(회원가입 불필요).
* [Wdrfree SVG](https://wdrfree.com/free-svg) - 흑백 무료 SVG 컷 파일.
* [Lucide](https://lucide.dev) - 무료 맞춤형 일관성 SVG 아이콘 툴킷.
* [Logo.dev](https://www.logo.dev) - 4,400만+ 브랜드의 회사 로고 API. URL 호출만으로 사용. 최초 1만 건 API 무료.
* [MDBootstrap](https://mdbootstrap.com/) - 퍼스널·상업용 모두 무료인 Bootstrap, Angular, React, Vue UI 키트(700+ 컴포넌트, 템플릿, 1분 설치, 방대한 튜토리얼, 대규모 커뮤니티).
* [TW Elements](https://tw-elements.com/) - Tailwind CSS로 재구성된 무료 Bootstrap 컴포넌트. 더 나은 디자인과 다양한 기능 제공.
* [DaisyUI](https://daisyui.com/) -- 무료. "Tailwind CSS를 사용하지만 클래스명을 적게 작성" 가능, 버튼 등 다양한 컴포넌트 제공.
  * [Scrollbar.app](https://scrollbar.app) -- 웹용 커스텀 스크롤바를 디자인할 수 있는 간단한 무료 웹 앱입니다.
  * [css.glass](https://css.glass/) -- CSS를 사용하여 글래스모피즘(유리효과) 디자인을 만드는 무료 웹 앱입니다.
  * [hypercolor.dev](https://hypercolor.dev/) -- Tailwind CSS 색상 그라데이션을 엄선하여 제공하며, 나만의 그라데이션을 생성할 수 있는 다양한 생성기도 제공합니다.
  * [iconify.design](https://icon-sets.iconify.design/) -- 100개 이상의 아이콘 팩을 통합 인터페이스로 제공하는 컬렉션. 여러 팩에서 아이콘을 검색하고, SVG 또는 인기 웹 프레임워크용으로 내보낼 수 있습니다.
  * [NextUI](https://nextui.org/) -- 무료. 아름답고 빠르며 현대적인 React & Next.js UI 라이브러리입니다.
  * [Glyphs](https://glyphs.fyi/) -- 무료, 웹에서 가장 강력한 아이콘. 완전히 편집 가능하고 진정한 오픈소스 디자인 시스템입니다.
  * [ShadcnUI](https://ui.shadcn.com/) -- 아름답게 디자인된 컴포넌트를 복사하여 앱에 붙여넣을 수 있습니다. 접근성, 커스터마이즈, 오픈소스 지원.
  * [HyperUI](https://www.hyperui.dev/) -- 무료 오픈소스 Tailwind CSS 컴포넌트.
  * [Calendar Icons Generator](https://calendariconsgenerator.app/) -- 한 번의 클릭으로 1년치의 고유한 아이콘을 생성, 완전 무료.
  * [Image BG Blurer](https://imagebgblurer.com/) -- 이미지 소스를 배경 블러로 사용하여 Notion, Trello, Jira 등 다양한 도구를 위한 블러 처리된 배경 프레임 생성.
  * [Webstudio](https://webstudio.is/) -- Webflow의 오픈소스 대안. 무료 플랜은 무제한 웹사이트(자체 도메인), 커스텀 도메인 5개 웹사이트, 월 10,000 페이지뷰, 2GB 자산 저장소를 제공합니다.
  * [Nappy](https://nappy.co/) -- 흑인 및 브라운 피부의 아름다운 사진을 무료로 제공. 상업적/개인적 사용 모두 가능.
  * [Tailkits](https://tailkits.com/) -- Tailwind 템플릿, 컴포넌트, 도구를 엄선하여 제공하며, 코드, 그리드, 박스 그림자 등 유용한 생성기도 포함.
  * [Tailcolors](https://tailcolors.com/) -- 아름다운 Tailwind CSS v4 색상 팔레트. 즉시 미리보기 및 완벽한 Tailwind CSS 색상 클래스 복사.
  * [Excalidraw](https://excalidraw.com/) -- 온라인에서 무료로 그림 문서를 작성할 수 있는 웹 페이지. 로컬 저장 및 내보내기 지원.
  * [Lunacy](https://icons8.com/lunacy) -- 오프라인 지원, 내장 자산(아이콘, 사진, 일러스트), 실시간 협업이 가능한 무료 그래픽 디자인 툴. 무료 티어는 10개의 클라우드 문서, 30일 기록, 저해상도 자산, 기본 디자인 도구를 제공합니다.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 디자인 영감

  * [awwwards.](https://www.awwwards.com/) - [최고의 웹사이트] 디자이너들이 투표한 최고의 웹사이트들을 모아놓은 쇼케이스입니다.
  * [Behance](https://www.behance.net/) - [디자인 쇼케이스] 디자이너들이 자신의 작업물을 선보이는 공간. UI/UX 프로젝트 등 카테고리별 필터링 지원.
  * [dribbble](https://dribbble.com/) - [디자인 쇼케이스] 실제 앱이 아닌 독특한 디자인 영감을 얻을 수 있습니다.
  * [Landings](https://landings.dev/) - [웹 스크린샷] 취향에 따라 최고의 랜딩 페이지를 찾아 디자인 영감을 얻을 수 있습니다.
  * [Lapa Ninja](https://www.lapa.ninja/) - [랜딩 페이지 / UI 키트 / 웹 스크린샷] 6,025개 이상의 최고의 랜딩 페이지 예시, 디자이너를 위한 무료 도서, 다양한 무료 UI 키트 갤러리.
  * [LovelyLanding.net](https://www.lovelylanding.net/) - [랜딩 페이지 디자인] 자주 업데이트되는 랜딩 페이지 스크린샷. 데스크탑, 태블릿, 모바일 스크린샷 포함.
  * [Mobbin](https://mobbin.design/) - [모바일 스크린샷] 50,000개 이상의 모바일 앱 UI/UX 스크린샷 라이브러리로 연구 시간을 절약하세요.
  * [Uiland Design](https://uiland.design/) - [모바일 스크린샷] 아프리카 및 전 세계 주요 기업의 모바일 및 웹 UI 디자인 탐색.
  * [Mobile Patterns](https://www.mobile-patterns.com/) - [모바일 스크린샷] 디자이너, 개발자, 제품 제작자를 위한 최고의 UI/UX 패턴(iOS 및 Android) 디자인 영감 라이브러리.
  * [Page Flows](https://pageflows.com/) - [모바일/웹 영상 및 스크린샷] 다양한 모바일 및 웹 앱의 전체 플로우 영상을 제공합니다. 스크린샷도 포함. 검색 및 인덱싱 우수.
  * [Screenlane](https://screenlane.com/) - [모바일 스크린샷] 최신 웹 및 모바일 앱 UI 디자인 트렌드 영감. 패턴 및 앱별 필터링 가능.
  * [scrnshts](https://scrnshts.club/) - [모바일 스크린샷] 엄선된 앱스토어 디자인 스크린샷 컬렉션.
  * [Refero](https://refero.design/) - [웹 스크린샷] 훌륭한 웹 애플리케이션의 디자인 레퍼런스 태그 및 검색 컬렉션.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 지도 데이터 시각화

  * [IP Geolocation](https://ipgeolocation.io/) — 월 30,000회 요청이 가능한 무료 DEVELOPER 플랜 제공.
  * [carto.com](https://carto.com/) — 나의 데이터와 공개 데이터를 기반으로 지도 및 지리공간 API 생성.
  * [Clockwork Micro](https://clockworkmicro.com/) — 시계처럼 작동하는 지도 도구. 월 5만 회 무료 쿼리(지도 타일, db2vector, 고도).
  * [developers.arcgis.com](https://developers.arcgis.com) — 웹, 데스크탑, 모바일에서 지도, 지리공간 데이터 저장, 분석, 지오코딩, 경로 안내 등을 위한 API 및 SDK 제공. 매월 2백만 기본 지도 타일, 2만 비저장 지오코드, 2만 단순 경로, 5천 운전 시간 계산, 5GB 타일+데이터 저장 무료 제공.
  * [Foursquare](https://developer.foursquare.com/) - 장소 API 및 Pilgrim SDK를 통한 위치 탐색, 장소 검색, 상황 인식 콘텐츠 제공.
  * [geoapify.com](https://www.geoapify.com/) - 벡터 및 래스터 지도 타일, 지오코딩, 장소, 경로 안내, 아이솔라인 API. 하루 3,000회 무료 요청.
  * [geocod.io](https://www.geocod.io/) — API 또는 CSV 업로드를 통한 지오코딩. 하루 2,500회 무료 쿼리.
  * [geocodify.com](https://geocodify.com/) — API 또는 CSV 업로드를 통한 지오코딩 및 지오파싱. 월 1만 회 무료 쿼리.
  * [geojs.io](https://www.geojs.io/) - 고가용성 REST/JSON/JSONP IP 지리위치 조회 API.
  * [giscloud.com](https://www.giscloud.com/) — 온라인에서 지리 데이터를 시각화, 분석, 공유.
  * [graphhopper.com](https://www.graphhopper.com/) 라우팅, 경로 최적화, 거리 행렬, 지오코딩, 맵 매칭을 위한 무료 개발자 패키지 제공.
  * [here](https://developer.here.com/) — 지도 및 위치 기반 앱을 위한 API와 SDK. 월 25만 트랜잭션 무료.
  * [locationiq.com](https://locationiq.com/) — 지오코딩, 지도, 경로 안내 API. 일 5,000회 무료 요청.
  * [mapbox.com](https://www.mapbox.com/) — 지도, 지리공간 서비스 및 지도 데이터 표시용 SDK.
  * [maptiler.com](https://maptiler.com/cloud/) — 지도 시각화를 위한 벡터 맵, 지도 서비스 및 SDK. 주간 업데이트되는 무료 벡터 타일 및 4가지 지도 스타일 제공.
  * [nominatim.org](https://nominatim.org/) — OpenStreetMap의 무료 지오코딩 서비스로, 글로벌 주소 검색 및 역지오코딩 기능 제공.
  * [nextbillion.ai](https://nextbillion.ai/) - 지도 관련 서비스: 지오코딩, 내비게이션(방향, 경로, 경로 최적화, 거리 행렬), 지도 SDK(벡터, 정적, 모바일 SDK). [각 서비스별 무료 할당량](https://nextbillion.ai/pricing) 제공.
  * [opencagedata.com](https://opencagedata.com) — OpenStreetMap 및 기타 오픈 지리 소스 집계 지오코딩 API. 일 2,500회 무료 쿼리.
  * [osmnames](https://osmnames.org/) — 위키피디아 관련 페이지의 인기순으로 결과를 정렬해주는 지오코딩 및 검색.
  * [positionstack](https://positionstack.com/) - 전 세계 위치 및 좌표용 무료 지오코딩. 개인 사용 월 25,000회 요청.
  * [stadiamaps.com](https://stadiamaps.com/) — 지도 타일, 경로 안내, 내비게이션 등 지리공간 API. 비상업적 사용 및 테스트용으로 일 2,500회 지도 조회 및 API 요청 무료.
  * [maps.stamen.com](http://maps.stamen.com/) - 무료 지도 타일 및 타일 호스팅.
  * [ipstack](https://ipstack.com/) - IP 주소로 웹사이트 방문자 위치 및 정보 식별.
  * [Geokeo api](https://geokeo.com) - 언어 교정 등 다양한 기능을 가진 지오코딩 API. 전 세계 커버리지. 일 2,500회 무료 쿼리.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 패키지 빌드 시스템

  * [build.opensuse.org](https://build.opensuse.org/) — 다양한 배포판(SUSE, EL, Fedora, Debian 등)을 위한 패키지 빌드 서비스.
  * [copr.fedorainfracloud.org](https://copr.fedorainfracloud.org) — Fedora 및 EL용 Mock 기반 RPM 빌드 서비스.
  * [help.launchpad.net](https://help.launchpad.net/Packaging) — Ubuntu 및 Debian 빌드 서비스.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## IDE 및 코드 에디팅

  * [3v4l](https://3v4l.org/) - 300개 이상의 PHP 버전에서 코드를 실행할 수 있는 무료 온라인 PHP 셸 및 코드 스니펫 공유 사이트
  * [Android Studio](https://developer.android.com/studio) — Android 기기용 앱 개발을 위한 가장 빠른 도구를 제공. 오픈소스 IDE로 모두에게 무료이며 최고의 Android 앱 개발 환경. Windows, Mac, Linux, ChromeOS 지원!
  * [AndroidIDE](https://m.androidide.com/) — 안드로이드 기기에서 실제 Gradle 기반 안드로이드 애플리케이션을 개발할 수 있는 오픈소스 IDE.
  * [Apache Netbeans](https://netbeans.apache.org/) — 개발 환경, 툴링 플랫폼, 애플리케이션 프레임워크.
  * [apiary.io](https://apiary.io/) — 협업 API 디자인 및 즉시 API 모킹, 자동 생성 문서(무제한 API 블루프린트, 무제한 사용자, 1개 관리자 계정, 호스팅 문서 무료).
  * [BBEdit](https://www.barebones.com/) - macOS용 인기 있고 확장 가능한 에디터. 무료 모드로 [강력한 핵심 기능](https://www.barebones.com/products/bbedit/comparison.html) 제공 및 고급 기능 업그레이드 경로 제공.
  * [Binder](https://mybinder.org/) - Git 저장소를 대화형 노트북 모음으로 변환. 무료 공개 서비스.
  * [BlueJ](https://bluej.org) — 초보자를 위해 설계된 무료 Java 개발 환경. 전 세계 수백만 명이 사용. Oracle 지원 및 초보자 친화적 GUI 제공.
  * [Bootify.io](https://bootify.io/) - 맞춤형 데이터베이스와 REST API를 가진 Spring Boot 앱 생성기.
  * [Brackets](http://brackets.io/) - 웹 개발에 특화된 오픈소스 텍스트 에디터. 가볍고 사용이 쉽고 커스터마이즈가 매우 용이함.
  * [cacher.io](https://www.cacher.io) — 100개 이상의 프로그래밍 언어를 지원하는 코드 스니펫 관리 및 라벨링 툴.
  * [Code::Blocks](https://codeblocks.org) — 무료 Fortran & C/C++ IDE. 오픈소스이며 Windows, macOS, Linux 지원.
  * [Cody](https://sourcegraph.com/cody) - 무료 AI 코딩 어시스턴트. (코드 블록, 자동완성, 단위테스트 생성), 전체 코드베이스 이해, 코드 수정 및 검색 지원. VS Code, JetBrains, 온라인 제공.
  * [codiga.io](https://codiga.io/) — IDE 내에서 코드 스니펫 검색, 정의, 재사용을 지원하는 코딩 어시스턴트. 개인 및 소규모 조직 무료.
  * [codesnip.com.br](https://codesnip.com.br) — 카테고리, 검색, 태그 지원의 간단한 코드 스니펫 관리자. 무료 및 무제한.
  * [cocalc.com](https://cocalc.com/) — (구 SageMathCloud, cloud.sagemath.com) — 클라우드에서 협업 계산. 내장 협업 기능, 수학/과학/데이터 과학용 무료 소프트웨어 다수 사전설치(Python, LaTeX, Jupyter 노트북, SageMath, scikitlearn 등)와 함께 브라우저에서 Ubuntu 전체 액세스.
  * [code.cs50.io](https://code.cs50.io/) - CS50용 Visual Studio Code 웹앱. GitHub Codespaces를 학생 및 교사용으로 최적화.
  * [codepen.io](https://codepen.io/) — CodePen은 웹 프론트엔드 개발용 놀이터입니다.
  * [codesandbox.io](https://codesandbox.io/) — React, Vue, Angular, Preact 등 다양한 프레임워크용 온라인 개발 환경.
  * [Components.studio](https://webcomponents.dev/) - 코드 컴포넌트를 독립적으로 작성, 스토리에서 시각화, 테스트, npm에 게시 가능.
  * [Eclipse Che](https://www.eclipse.org/che/) - 개발자 팀을 위한 웹 기반, Kubernetes 네이티브 IDE. 다국어 지원. 오픈소스 및 커뮤니티 주도. [workspaces.openshift.com](https://workspaces.openshift.com/)에서 Red Hat이 호스팅하는 온라인 인스턴스 제공.
  * [fakejson.com](https://fakejson.com/) — API를 통해 빠르게 가짜 데이터를 생성. 요청 시 원하는 데이터와 형태를 설명하면, API가 JSON 형태로 반환. 아이디어의 빠른 프로토타이핑 및 가짜 데이터 생성에 유용.
  * [GetVM](https://getvm.io) — 즉시 무료 리눅스 및 IDE Chrome 사이드바. 무료 티어는 하루 5대 VM 제공.
  * [GitPod](https://www.gitpod.io) — GitHub 프로젝트를 위한 즉시 사용 가능한 개발 환경. 무료 플랜은 월 50시간을 포함합니다.
  * [ide.goorm.io](https://ide.goorm.io) goormIDE는 클라우드 기반의 완전한 IDE입니다. 다중 언어 지원, 완전한 기능의 웹 기반 터미널을 통한 리눅스 기반 컨테이너, 포트 포워딩, 맞춤 URL, 실시간 협업 및 채팅, 링크 공유, Git/Subversion 지원 등 다양한 기능을 제공합니다. (무료 플랜: 컨테이너당 1GB RAM, 10GB 저장공간, 5개 컨테이너 슬롯 제공)
  * [JDoodle](https://www.jdoodle.com) — 60개 이상의 프로그래밍 언어를 지원하는 온라인 컴파일러 및 에디터. REST API 코드 컴파일은 하루 최대 200크레딧까지 무료 플랜 제공.
  * [jetbrains.com](https://jetbrains.com/products.html) — 생산성 도구, IDE 및 배포 도구(예: [IntelliJ IDEA](https://www.jetbrains.com/idea/), [PyCharm](https://www.jetbrains.com/pycharm/) 등). 학생, 교사, 오픈소스 및 사용자 그룹에게 무료 라이선스 제공.
  * [jsbin.com](https://jsbin.com) — JS Bin은 프론트엔드 웹(HTML, CSS, JavaScript)의 코드 플레이그라운드 및 공유 사이트입니다. 또한 Markdown, Jade, Sass도 지원합니다.
  * [jsfiddle.net](https://jsfiddle.net/) — JS Fiddle은 프론트엔드 웹을 위한 코드 플레이그라운드 및 공유 사이트이며, 협업을 지원합니다.
  * [JSONPlaceholder](https://jsonplaceholder.typicode.com/) 일부 REST API 엔드포인트에서 JSON 형식의 가짜 데이터를 반환합니다. 서버를 로컬에서 실행하고 싶다면 소스 코드도 제공됩니다.
  * [Lazarus](https://www.lazarus-ide.org/) — 라자루스는 Rapid Application Development를 위한 델파이 호환 크로스 플랫폼 IDE입니다.
  * [MarsCode](https://www.marscode.com/) - 무료 AI 기반 클라우드 IDE.
  * [micro-jaymock](https://micro-jaymock.now.sh/) - 가짜 JSON 데이터를 생성하는 작은 API 모킹 마이크로서비스.
  * [mockable.io](https://www.mockable.io/) — Mockable은 RESTful API 또는 SOAP 웹 서비스를 모킹할 수 있는 간단한 구성 서비스입니다. 온라인에서 빠르게 REST API 또는 SOAP 엔드포인트를 정의하고 JSON 또는 XML 데이터를 반환하게 할 수 있습니다.
  * [mockaroo](https://mockaroo.com/) — Mockaroo를 통해 CSV, JSON, SQL, Excel 형식의 현실적인 테스트 데이터를 생성할 수 있습니다. 백엔드 API를 위한 목(mock)도 생성할 수 있습니다.
  * [Mocklets](https://mocklets.com) - 빠른 병렬 개발과 더 포괄적인 테스트를 위해 API를 시뮬레이션할 수 있는 HTTP 기반 모의 API 시뮬레이터, 평생 무료 티어 제공.
  * [Paiza](https://paiza.cloud/en/) — 별도의 설정 없이 브라우저에서 웹 앱 개발. 무료 플랜은 1대의 서버, 24시간 사용 가능, 하루 4시간 실행 시간, 2 CPU 코어, 2GB RAM, 1GB 저장공간 제공.
  * [Prepros](https://prepros.io/) - Prepros는 Sass, Less, Stylus, Pug/Jade, Haml, Slim, CoffeeScript, TypeScript를 바로 컴파일할 수 있으며, 브라우저 리로드 및 웹사이트 개발·테스트를 쉽게 해줍니다. 몇 번의 클릭으로 자신만의 도구 추가도 가능합니다.
  * [Replit](https://replit.com/) — 다양한 프로그래밍 언어를 지원하는 클라우드 코딩 환경.
  * [SoloLearn](https://code.sololearn.com) — 코드 스니펫 실행에 적합한 클라우드 프로그래밍 플레이그라운드. 다양한 프로그래밍 언어 지원. 코드 실행에 별도 회원가입 필요 없음(코드 저장은 가입 필요). 초급 및 중급 개발자를 위한 무료 강좌도 제공.
  * [stackblitz.com](https://stackblitz.com/) — 온라인/클라우드 코드 IDE로 전체 스택 앱의 생성, 편집, 배포 지원. NodeJs 기반의 인기 프론트엔드 및 백엔드 프레임워크 모두 지원. 새 프로젝트 생성 단축 링크: [https://node.new](https://node.new).
  * [Sublime Text](https://www.sublimetext.com/) - Sublime Text는 코딩 및 텍스트 편집 작업에 사용되는 인기 있고 다재다능하며 높은 커스터마이징이 가능한 텍스트 에디터입니다.
  * [Visual Studio Code](https://code.visualstudio.com/) - 최신 웹 및 클라우드 애플리케이션 구축과 디버깅을 위해 재정의되고 최적화된 코드 에디터. Microsoft에서 개발.
  * [Visual Studio Community](https://visualstudio.microsoft.com/vs/community/) — 수천 개의 확장 기능이 포함된 완전한 기능의 IDE. 크로스플랫폼 앱 개발(iOS, Android용 Microsoft 확장기능 다운로드 제공), 데스크톱, 웹 및 클라우드 개발, 다중 언어 지원(C#, C++, JavaScript, Python, PHP 등).
  * [VSCodium](https://vscodium.com/) - 커뮤니티 주도, 텔레메트리/트래킹 없는, 자유 라이선스의 Microsoft VSCode 에디터 바이너리 배포판
  * [wakatime.com](https://wakatime.com/) — 텍스트 에디터 플러그인을 통한 코딩 활동에 대한 셀프 메트릭, 무료 플랜은 제한적으로 제공.
  * [Wave Terminal](https://waveterm.dev/) - Wave는 원활한 워크플로우를 위한 오픈소스, 크로스플랫폼 터미널입니다. 인라인 렌더링, 세션 및 히스토리 저장. 오픈 웹 표준 기반. MacOS 및 Linux 지원.
  * [WebComponents.dev](https://webcomponents.dev/) — 58가지 템플릿을 지원하며, 스토리 및 테스트를 지원하는 웹 컴포넌트 독립 개발용 브라우저 내 IDE.
  * [PHPSandbox](https://phpsandbox.io/) — PHP 온라인 개발 환경
  * [WebDB](https://webdb.app) - 무료 효율적인 데이터베이스 IDE. 서버 디스커버리, ERD, 데이터 생성기, AI, NoSQL 구조 관리자, 데이터베이스 버전 관리 등 다양한 기능 제공.
  * [Zed](https://zed.dev/) - Atom 및 Tree-sitter 제작진이 만든 고성능 멀티플레이어 코드 에디터.
  * [OneCompiler](https://onecompiler.com/) - Java, Python, C++, JavaScript 등 70개 이상의 언어를 지원하는 무료 온라인 컴파일러.


**[⬆️ 맨 위로](#table-of-contents)**

## 분석, 이벤트 및 통계

  * [Dwh.dev](https://dwh.dev) - 데이터 클라우드 관측 솔루션(Snowflake). 개인 사용 무료.
  * [Hightouch](https://hightouch.com/) - 데이터 웨어하우스의 고객 데이터를 CRM, 마케팅, 지원 도구로 동기화하는 Reverse ETL 플랫폼. 무료 티어는 한 곳의 목적지로 데이터 동기화 가능.
  * [Avo](https://avo.app/) — 간소화된 분석 릴리즈 워크플로우. 단일 소스의 트래킹 플랜, 타입 세이프 분석 트래킹 라이브러리, 인앱 디버거, 데이터 관측 기능 포함. 무료 플랜은 2명 워크스페이스 멤버와 1시간 데이터 관측 룩백 제공.
  * [Branch](https://www.branch.io) — 모바일 분석 플랫폼. 무료 티어는 최대 1만 명의 모바일 앱 사용자, 딥링킹 및 기타 서비스 제공.
  * [Census](https://www.getcensus.com/) — Reverse ETL 및 운영 분석 플랫폼. 데이터 웨어하우스에서 Salesforce, Zendesk, Amplitude 등 60개 이상의 SaaS로 10개 필드 동기화 가능.
  * [Clicky](https://clicky.com) — 웹사이트 분석 플랫폼. 무료 플랜은 한 개의 웹사이트에서 3,000뷰 분석 제공.
  * [Databox](https://databox.com) — 다양한 분석 및 BI 플랫폼을 결합한 비즈니스 인사이트 및 분석. 무료 플랜: 3명의 사용자, 대시보드 및 데이터 소스, 1,100만 개의 과거 데이터 제공.
  * [Hitsteps.com](https://hitsteps.com/) — 1개 웹사이트에 월 2,000 페이지뷰 제공
  * [amplitude.com](https://amplitude.com/) — 월 100만 개 이벤트, 최대 2개 앱
  * [GoatCounter](https://www.goatcounter.com/) — 오픈소스 웹 분석 플랫폼. 호스팅(비상업적 사용 무료) 또는 자체 호스팅 선택 가능. 구글 애널리틱스 또는 Matomo 대안으로 쉽고 의미 있는 개인정보 친화적 웹 분석 제공. 무료 티어는 비상업적 사용, 무제한 사이트, 6개월 데이터 보관, 월 10만 페이지뷰 제공.
  * [Google Analytics](https://analytics.google.com/) — 구글 애널리틱스
  * [MetricsWave](https://metricswave.com) — 개발자를 위한 개인정보 친화적 구글 애널리틱스 대안. 무료 플랜은 신용카드 없이 월 2만 페이지뷰 허용.
  * [Expensify](https://www.expensify.com/) — 경비 보고, 무료 개인 보고 승인 워크플로우
  * [getinsights.io](https://getinsights.io) - 개인정보 중시, 쿠키 없는 분석, 월 3,000 이벤트까지 무료.
  * [heap.io](https://heap.io) — iOS 또는 웹 앱에서 모든 사용자 액션을 자동 캡처. 월 1만 세션까지 무료.
  * [Hotjar](https://hotjar.com) — 웹사이트 분석 및 보고. 무료 플랜은 하루 2,000 페이지뷰, 하루 100개 스냅샷(최대 300개 저장), 3개의 스냅샷 히트맵을 365일 보관, 무제한 팀 멤버, 앱 내 및 독립 설문/피드백 위젯(스크린샷 포함) 제공. 무료 티어는 3개의 설문조사/피드백 위젯 생성 및 월 20개 응답 수집 가능.
  * [Keen](https://keen.io/) — 데이터 수집, 분석, 시각화를 위한 맞춤형 분석. 월 1,000 이벤트 무료.
  * [Yandex.Datalens](https://datalens.yandex.com/) — Yandex 클라우드 데이터 시각화 및 분석 서비스. 무료 제공. 사용자 및 요청 수 무제한.
  * [Yandex.Metrica](https://metrica.yandex.com/) — 무제한 무료 분석
  * [Mixpanel](https://mixpanel.com/) — 월간 10만 명 트래킹 사용자, 무제한 데이터 기록 및 시트, 미국 또는 EU 데이터 보관
  * [Moesif](https://www.moesif.com) — REST 및 GraphQL용 API 분석. (월 50만 API 호출까지 무료)
  * [optimizely.com](https://www.optimizely.com) — A/B 테스트 솔루션, 무료 스타터 플랜, 한 개 웹사이트, 1개 iOS, 1개 안드로이드 앱
  * [Microsoft PowerBI](https://powerbi.com) — 마이크로소프트의 비즈니스 인사이트 및 분석. 무료 플랜은 100만 사용자 라이선스 제한적 사용 가능.
  * [Row Zero](https://rowzero.io) - 매우 빠르고 연결된 스프레드시트. 데이터베이스, S3, API에 직접 연결. 수백만 행을 즉시 가져오고, 분석하고, 그래프화 및 공유 가능. 3개의 무료(영구) 워크북 제공.
  * [sematext.com](https://sematext.com/cloud/) — 월 5만 액션까지 무료, 1일 데이터 보관, 무제한 대시보드 및 사용자 등.
  * [Similar Web](https://similarweb.com) — 웹 및 모바일 앱 분석. 무료 플랜은 지표별 5개 결과, 모바일 앱 데이터 1개월, 웹사이트 데이터 3개월 제공.
  * [StatCounter](https://statcounter.com/) — 웹사이트 방문자 분석. 최근 500명의 방문자 분석 무료 제공.
  * [Statsig](https://statsig.com) - 분석, 기능 플래깅, A/B 테스트를 통합한 플랫폼. 월 100만 이벤트까지 무료.
  * [Tableau Developer Program](https://www.tableau.com/developer) — 혁신, 제작, Tableau 맞춤화. 무료 개발자 프로그램은 Tableau Online의 개인 개발 샌드박스 라이선스 제공. 최신 프리릴리즈 버전 제공으로 모든 기능 테스트 가능.
  * [usabilityhub.com](https://usabilityhub.com/) — 실제 사용자에게 디자인 및 목업 테스트, 방문자 트래킹. 사용자 1명, 테스트 무제한 무료.
  * [woopra.com](https://www.woopra.com/) — 50만 액션, 90일 데이터 보관, 30개 이상의 원클릭 통합 제공 무료 사용자 분석 플랫폼.
  * [counter.dev](https://counter.dev) — 단순하고 개인정보 친화적인 웹 분석. 무료 또는 기부금 기반.
  * [PostHog](https://posthog.com) - 월 100만 이벤트까지 무료인 풀 프로덕트 분석 제품군. 앱 내 설문은 무제한 생성, 월 250회 응답 수집.
  * [Uptrace](https://uptrace.dev) - 장애 지점 및 성능 병목 현상 파악을 돕는 분산 트레이싱 툴. 무료 플랜, 오픈소스 프로젝트에 무료 Personal 구독, 오픈소스 버전 제공.
  * [Microsoft Clarity](https://clarity.microsoft.com/) - 실제 사용자의 사이트 사용 방식을 캡처하는 무료, 사용하기 쉬운 도구.
  * [Beampipe.io](https://beampipe.io) - 단순하고 개인정보 중시 웹 분석. 5개 도메인, 월 1만 페이지뷰까지 무료.
  * [Aptabase](https://aptabase.com) — 모바일 및 데스크톱 앱용 오픈소스, 개인정보 친화적, 간단한 분석. Swift, Kotlin, React Native, Flutter, Electron 등 SDK 제공. 월 2만 이벤트까지 무료.
  * [Trackingplan](https://www.trackingplan.com/) - 디지털 분석, 마케팅 데이터 및 픽셀 문제 자동 감지, 최신 트래킹 플랜 유지, 원활한 협업 촉진. 프로덕션 환경에 실제 트래픽으로 배포하거나 회귀 테스트에 코드 작성 없이 분석 범위 추가 가능.
  * [LogSpot](https://logspot.io) - 통합 웹 및 제품 분석 플랫폼, 삽입형 분석 위젯, 자동화 로봇(slack, telegram, 웹훅) 포함. 무료 플랜은 월 1만 이벤트 제공.
  * [Umami](https://umami.is/) - 단순하고 빠르며 개인정보에 중점을 둔 오픈소스 구글 애널리틱스 대안.
  * [TrackWith Dicloud](https://dicloud.net/trackwith-privacy-focused-analytics/) - 무료 경량 개인정보 중시 구글 애널리틱스 대안. 무제한 페이지뷰, 방문자, 페이지 히트맵, 목표 추적. 최대 3개 도메인, 도메인당 600회 세션 리플레이 무료.
  * [AppFit](https://appfit.io) - AppFit은 분석 및 제품 업데이트의 원활한 크로스플랫폼 관리를 위한 종합 분석 및 제품 관리 도구. 무료 플랜은 월 1만 이벤트, 제품 저널, 주간 인사이트 제공.
  * [Seline](https://seline.so) - Seline은 단순하고 개인정보 중시의 웹사이트 및 제품 분석 서비스입니다. 쿠키리스, 경량, 독립적. 무료 플랜은 월 3,000 이벤트 및 대시보드, 사용자 여정, 퍼널 등 모든 기능 제공.
  * [Peasy](https://peasy.so) - Peasy는 웹사이트 및 제품용 경량 개인정보 중시 분석 툴. 무료 플랜은 월 3,000 이벤트.
  * [Rybbit](https://rybbit.io) - 오픈소스, 쿠키리스, 구글 애널리틱스보다 10배 직관적인 대안. 무료 플랜은 월 3,000 이벤트 제공.

**[⬆️ 맨 위로](#table-of-contents)**

## 방문자 세션 녹화

  * [Reactflow.com](https://www.reactflow.com/) — 사이트당: 일일 1,000 페이지뷰, 3개 히트맵, 3개 위젯, 무료 버그 트래킹
  * [OpenReplay.com](https://www.openreplay.com) - 오픈소스 세션 리플레이 및 버그 재현용 개발 도구, 실시간 지원용 라이브 세션, 제품 분석 제품군. 월 1,000 세션, 전체 기능, 7일 데이터 보관.
  * [LogRocket.com](https://www.logrocket.com) - 월 1,000 세션, 30일 데이터 보관, 에러 트래킹, 라이브 모드
  * [FullStory.com](https://www.fullstory.com) — 월 1,000 세션, 1개월 데이터 보관, 3명 사용자 시트. 자세한 내용은 [여기](https://help.fullstory.com/hc/en-us/articles/360020623354-FullStory-Free-Edition).
  * [hotjar.com](https://www.hotjar.com/) — 사이트당: 월 1,050 페이지뷰, 무제한 히트맵, 데이터 3개월 저장
  * [inspectlet.com](https://www.inspectlet.com/) — 1개 웹사이트에 월 2,500 세션 무료
  * [Microsoft Clarity](https://clarity.microsoft.com/) - "트래픽 제한 없음", 프로젝트 제한 없음, 샘플링 없음의 완전 무료 세션 녹화
  * [mouseflow.com](https://mouseflow.com/) — 1개 웹사이트에 월 500 세션 무료
  * [mousestats.com](https://www.mousestats.com/) — 1개 웹사이트에 월 100 세션 무료
  * [smartlook.com](https://www.smartlook.com/) — 웹 및 모바일 앱용 무료 패키지(월 1,500 세션), 3개 히트맵, 1개 퍼널, 1개월 데이터 이력
  * [howuku.com](https://howuku.com) — 사용자 상호작용, 참여, 이벤트 트래킹. 월 5,000 방문까지 무료
  * [UXtweak.com](https://www.uxtweak.com/) — 웹사이트 또는 앱에서 방문자가 사용하는 모습을 녹화 및 시청. 소규모 프로젝트는 무제한 무료 이용

**[⬆️ 맨 위로](#table-of-contents)**
## 국제 모바일 번호 인증 API 및 SDK

  * [numverify](https://numverify.com/) — 글로벌 휴대폰 번호 검증 및 조회 JSON API. 월 100회 API 요청 무료
  * [veriphone](https://veriphone.io/) — 글로벌 휴대폰 번호 인증을 위한 빠르고 신뢰성 높은 JSON API. 월 1,000회 요청 무료

**[⬆️ 맨 위로](#table-of-contents)**

## 결제 및 청구 통합

  * [Qonversion](http://qonversion.io/) - 분석, A/B 테스트, Apple Search Ads, 원격 구성, 성장 도구 등 인앱 구매 및 수익화 최적화를 위한 올인원 크로스 플랫폼 구독 관리 플랫폼. iOS, Android, React Native, Flutter, Unity, Cordova, Stripe, 웹과 호환. 월 추적 매출 $10,000까지 무료.
  * [ParityVend](https://www.ambeteco.com/ParityVend/) – 방문자 위치에 따라 자동으로 가격을 조정하여 전 세계적으로 비즈니스를 확장하고 새로운 시장(구매력 평가)에 도달합니다. 무료 플랜은 월 7,500회 API 요청 포함.
  * [Glassfy](https://glassfy.io/) – iOS, Android, Stripe, Paddle에서 인앱 구독 인프라, 실시간 구독 이벤트, 즉시 사용 가능한 수익화 도구 제공. 월 매출 $10,000까지 무료.
  * [Adapty.io](https://adapty.io/) – iOS, Android, React Native, Flutter, Unity, 웹 앱용 오픈 소스 SDK를 제공하는 인앱 구독 통합 원스톱 솔루션. 월 매출 $10,000까지 무료.
  * [CoinMarketCap](https://coinmarketcap.com/api/) — 최신 암호화폐 및 명목 화폐 환율 등 암호화폐 시장 데이터 제공. 무료 등급은 월 10,000 콜 크레딧 제공.
  * [CurrencyFreaks](https://currencyfreaks.com/) — 현재 및 과거 환율 제공. 월 1,000회 요청 가능한 무료 DEVELOPER 플랜 제공.
  * [CoinGecko](https://www.coingecko.com/en/api) — 최신 암호화폐 환율 및 과거 데이터를 포함한 암호화폐 시장 데이터 제공. 데모 API는 분당 30회, 월 10,000회 제한.
  * [CurrencyApi](https://currencyapi.net/) — 실시간 물리 및 암호화폐 환율을 JSON 및 XML로 제공. 무료 등급은 월 1,250회 API 요청 제공.
  * [currencylayer](https://currencylayer.com/) — 비즈니스를 위한 신뢰할 수 있는 환율 및 통화 변환, 월 100회 API 요청 무료.
  * [exchangerate-api.com](https://www.exchangerate-api.com) - 사용이 쉬운 통화 변환 JSON API. 무료 등급은 일일 1회 업데이트, 월 1,500회 요청 제한.
  * [FraudLabsPRO](https://www.fraudlabspro.com) — 결제 사기 및 환불 방지를 지원. 월 500회 쿼리 가능한 무료 마이크로 플랜 제공.
  * [FxRatesAPI](https://fxratesapi.com) — 실시간 및 과거 환율 제공. 무료 등급은 출처 표시 필요.
  * [Moesif API Monetization](https://www.moesif.com/) - 사용량 기반 청구를 통한 API 수익화. Stripe, Chargebee 등과 연결. 무료 등급은 월 30,000 이벤트 제공.
  * [Nami ML](https://www.namiml.com/) - iOS 및 Android용 인앱 구매 및 구독 완성형 플랫폼, 노코드 결제창, CRM, 분석 포함. 모든 기본 기능 무료 제공.
  * [RevenueCat](https://www.revenuecat.com/) — 인앱 구매 및 구독( iOS 및 Android )용 호스팅 백엔드. 월 추적 매출 $2,500까지 무료.
  * [vatlayer](https://vatlayer.com/) — 즉각적인 VAT 번호 검증 및 EU VAT 요율 API, 월 100회 API 요청 무료
  * [Currencyapi](https://currencyapi.com) — 무료 통화 변환 및 환율 데이터 API. 월 300회 요청, 분당 10회 요청(개인용) 무료.

**[⬆️ 맨 위로](#table-of-contents)**

## Docker 관련

  * [canister.io](https://canister.io/) — 개발자용 무료 비공개 저장소 20개, 팀용 무료 비공개 저장소 30개 제공, Docker 이미지 빌드 및 저장
  * [Container Registry Service](https://container-registry.com/) - Harbor 기반 컨테이너 관리 솔루션. 무료 등급은 비공개 저장소 1GB 저장 공간 제공.
  * [Docker Hub](https://hub.docker.com) — Docker 이미지 빌드 및 저장을 위한 무료 비공개 저장소 1개, 무제한 공개 저장소 제공
  * [Play with Docker](https://labs.play-with-docker.com/) — Docker를 배우기 위한 쉽고, 상호작용적이며, 재미있는 플레이그라운드.
  * [quay.io](https://quay.io/) — 무제한 무료 공개 저장소로 컨테이너 이미지 빌드 및 저장
  * [ttl.sh](https://ttl.sh/) - 익명 및 일시적인 Docker 이미지 레지스트리

**[⬆️ 맨 위로](#table-of-contents)**

## Vagrant 관련

  * [Vagrant Cloud](https://app.vagrantup.com) - HashiCorp Vagrant Cloud. Vagrant 박스 호스팅.
  * [Vagrantbox.es](https://www.vagrantbox.es/) — 대체 공개 박스 인덱스

**[⬆️ 맨 위로](#table-of-contents)**

## 개발 블로깅 사이트

  * [BearBlog](https://bearblog.dev/) - 미니멀리스트, Markdown 기반 블로그 및 웹사이트 빌더.
  * [Dev.to](https://dev.to/) - 프로그래머가 아이디어를 공유하고 함께 성장하는 공간.
  * [Hashnode](https://hashnode.com/) — 개발자를 위한 간편한 블로깅 소프트웨어!
  * [Medium](https://medium.com/) — 여러분에게 중요한 주제에 대해 더 깊이 생각할 수 있는 공간.
  * [AyeDot](https://ayedot.com/) — 현대적 멀티미디어 단문 미니블로그 형식으로 아이디어, 지식, 이야기를 무료로 공유하세요.

**[⬆️ 맨 위로](#table-of-contents)**

## 댓글 플랫폼
  * [GraphComment](https://graphcomment.com/) - 웹사이트 방문자를 위한 활발한 커뮤니티 구축을 돕는 댓글 플랫폼.
  * [Utterances](https://utteranc.es/) - GitHub 이슈 기반의 가벼운 댓글 위젯. 블로그 댓글, 위키 페이지 등에 GitHub 이슈를 활용!
  * [Disqus](https://disqus.com/) - 수십만 개 사이트에서 사용되는 네트워크 커뮤니티 플랫폼.
  * [Remarkbox](https://www.remarkbox.com/) - 오픈 소스 호스팅 댓글 플랫폼, "여러 도메인에서 한 명의 관리자, 완전한 동작 및 외관 제어"를 원하는 만큼 지불
  * [IntenseDebate](https://intensedebate.com/) - WordPress, Tumblr, Blogger 등 다양한 웹사이트 플랫폼을 위한 다양한 기능의 댓글 시스템.

**[⬆️ 맨 위로](#table-of-contents)**

## 스크린샷 API

  * [ApiFlash](https://apiflash.com) — AWS Lambda와 Chrome 기반 스크린샷 API. 전체 페이지, 캡처 타이밍, 뷰포트 크기 지원.
  * [microlink.io](https://microlink.io/) – 모든 웹사이트를 메타태그 정규화, 아름다운 링크 미리보기, 스크래핑, 스크린샷 등 데이터로 전환하는 서비스. 매일 250회 요청 무료.
  * [ScreenshotAPI.net](https://screenshotapi.net/) - 간단한 API 호출로 웹사이트 스크린샷을 생성하는 스크린샷 API. Google Cloud에서 호스팅, 월 100회 무료 스크린샷 제공.
  * [screenshotlayer.com](https://screenshotlayer.com/) — 다양한 맞춤 설정이 가능한 웹사이트 스냅샷 캡처. 월 100회 무료 스냅샷
  * [screenshotmachine.com](https://www.screenshotmachine.com/) — 월 100회 스냅샷, png, gif, jpg 지원, 전체 페이지 캡처 포함, 홈페이지만이 아님
  * [PhantomJsCloud](https://PhantomJsCloud.com) — 브라우저 자동화 및 페이지 렌더링. 무료 등급은 일일 최대 500페이지 제공. 2017년부터 무료 티어 유지.
  * [Webshrinker.com](https://webshrinker.com) — 웹사이트 스크린샷 및 도메인 인텔리전스 API 서비스 제공. 월 100회 요청 무료.
  * [Screenshots](https://screenshotson.click) — 다양한 캡처 옵션을 지원하는 스크린샷 API. 월 100회 무료 스크린샷.

**[⬆️ 맨 위로](#table-of-contents)**

## Flutter 관련 및 Mac 없이 IOS 앱 빌드

  * [FlutLab](https://flutlab.io/) - FlutLab은 현대적인 Flutter 온라인 IDE로, 크로스 플랫폼 프로젝트를 생성, 디버깅, 빌드할 수 있는 최고의 공간입니다. Mac 없이 iOS와 Android 앱을 Flutter로 빌드하세요.
  * [CodeMagic](https://codemagic.io/) - 모바일 앱을 위한 완전 호스팅/관리형 CI/CD. GUI 기반 CI/CD 도구로 빌드, 테스트, 배포 가능. 무료 등급은 월 500분 무료 사용, 2.3GHz/8GB RAM Mac Mini 인스턴스 제공.
  * [FlutterFlow](https://flutterflow.io/) - Flutter를 사용하여 모바일 앱을 드래그 앤 드롭으로 제작할 수 있는 브라우저 기반 도구.

**[⬆️ 맨 위로](#table-of-contents)**

## Javascript로 작성된 브라우저 기반 하드웨어 에뮬레이션

  * [JsLinux](https://bellard.org/jslinux) — Linux 및 Windows 2k 실행이 가능한 매우 빠른 x86 가상머신.
  * [Jor1k](https://s-macke.github.io/jor1k/demos/main.html) — 네트워크 지원이 가능한 Linux 구동 OpenRISC 가상머신.
  * [v86](https://copy.sh/v86) — 브라우저에서 직접 Linux 및 기타 OS 실행 가능한 x86 가상머신.

**[⬆️ 맨 위로](#table-of-contents)**

## 프라이버시 관리
  * [Bearer](https://www.bearer.sh/) - 감사 및 지속적인 워크플로우를 통해 프라이버시 바이 디자인 구현을 지원하여 조직의 GDPR 등 규정 준수 지원. 무료 등급은 소규모 팀 및 SaaS 버전만 제공.
  * [Osano](https://www.osano.com/) - GDPR 대표부터 쿠키 배너까지 모두 지원하는 동의 관리 및 컴플라이언스 플랫폼. 무료 등급은 기본 기능 제공.
  * [Iubenda](https://www.iubenda.com/) - 프라이버시 및 쿠키 정책, 동의 관리. 무료 등급은 제한된 프라이버시/쿠키 정책 및 쿠키 배너 제공.
  * [Cookiefirst](https://cookiefirst.com/) - 쿠키 배너, 감시, 다국어 동의 관리 솔루션. 무료 등급은 1회 스캔 및 단일 배너 제공.
* [Ketch](https://www.ketch.com/) - 동의 관리 및 프라이버시 프레임워크 도구. 무료 티어는 방문자 수에 제한을 두고 대부분의 기능을 제공합니다.
* [Concord](https://www.concord.tech/) - 동의 관리, 프라이버시 요청 처리(DSAR), 데이터 매핑을 포함한 전체 데이터 프라이버시 플랫폼. 무료 티어는 핵심 동의 관리 기능을 포함하며, 검증된 오픈 소스 프로젝트에는 더 고급 플랜도 무료로 제공합니다.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 기타

* [BackgroundStyler.com](https://backgroundstyler.com) - 코드, 텍스트 또는 이미지를 소셜 미디어에 공유할 수 있는 미려한 스크린샷으로 만듭니다.
* [BinShare.net](https://binshare.net) - 코드 또는 바이너리를 만들고 공유하세요. 트위터/페이스북 게시물용 이미지나 채팅/포럼용 링크 형태로 공유 가능합니다.
* [Blynk](https://blynk.io) — IoT 기기를 제어, 구축 및 평가할 수 있는 API를 제공하는 SaaS. 무료 개발자 플랜은 5개 기기, 무료 클라우드 및 데이터 저장소를 제공합니다. 모바일 앱도 제공됩니다.
* [Bricks Note Calculator](https://free.getbricks.app/) - 강력한 내장 멀티라인 계산기가 포함된 노트 필기 앱(PWA).
* [Carbon.now.sh](https://carbon.now.sh) - 코드 스니펫을 미려한 스크린샷 이미지 형식으로 생성 및 공유합니다. 주로 트위터나 블로그 게시글에서 코드를 미적으로 공유/과시할 때 사용됩니다.
* [Code Time](https://www.software.com/code-time) - VS Code, Atom, IntelliJ, Sublime Text 등에서 시간 추적 및 코딩 메트릭을 위한 확장 프로그램.
* [Codepng](https://www.codepng.app) - 소셜 미디어에서 공유할 수 있는 멋진 코드 스냅샷 생성.
* [CodeToImage](https://codetoimage.com/) - 소셜 미디어에서 공유할 코드 또는 텍스트의 스크린샷 생성.
* [Cronhooks](https://cronhooks.io/) - 단발성 또는 반복 웹훅 예약. 무료 플랜은 5개의 임시 예약을 허용합니다.
* [cron-job.org](https://cron-job.org) - 온라인 크론잡 서비스. 무제한 작업이 무료입니다.
* [datelist.io](https://datelist.io) - 온라인 예약/약속 예약 시스템. 월 5건까지 무료 예약, 캘린더 1개 포함.
* [Domain Forward](https://domain-forward.com/) - 모든 URL 또는 도메인을 간단하게 포워딩하는 도구. 최대 5개 도메인과 월 20만 요청까지 무료.
* [Elementor](https://elementor.com) — 워드프레스 웹사이트 빌더. 40개 이상의 기본 위젯과 함께 무료 플랜 제공.
* [Exif Editor](https://exifeditor.io/) — 이미지/사진의 메타데이터(위치, 메타데이터 등)를 브라우저에서 즉시 확인, 편집, 삭제, 분석.
* [Format Express](https://www.format-express.dev) - JSON / XML / SQL의 즉각적인 온라인 포맷 변환.
* [FOSSA](https://fossa.com/) - 서드파티 코드, 라이선스 컴플라이언스 및 취약점에 대한 확장 가능한 엔드 투 엔드 관리.
* [Hook Relay](https://www.hookrelay.dev/) - 큐잉, 백오프 재시도, 로깅 등 웹훅 지원을 손쉽게 추가. 무료 플랜은 일 100회 전송, 14일 보관, 훅 엔드포인트 3개 제공.
* [Hosting Checker](https://hostingchecker.co) - 모든 도메인, 웹사이트 또는 IP 주소의 ASN, ISP, 위치 등 호스팅 정보 확인. 다양한 호스팅 및 DNS 관련 도구도 포함.
* [http2.pro](https://http2.pro) — HTTP/2 프로토콜 준비 상태 테스트 및 클라이언트 HTTP/2 지원 감지 API.
* [kandi](https://kandi.openweaver.com/) — 코드 스니펫과 오픈소스 라이브러리 재사용을 통한 맞춤 함수, 유즈케이스, 완성형 앱을 빠르게 구축.
* [Base64 decoder/encoder](https://devpal.co/base64-decode/) — 데이터 디코딩 및 인코딩을 위한 무료 온라인 도구.
* [newreleases.io](https://newreleases.io) - GitHub, GitLab, Bitbucket, Python PyPI, Java Maven, Node.js NPM, Node.js Yarn, Ruby Gems, PHP Packagist, .NET NuGet, Rust Cargo, Docker Hub의 새 릴리스를 이메일, Slack, Telegram, Discord, 커스텀 웹훅으로 알림 수신.
* [OnlineExifViewer](https://onlineexifviewer.com/) — 사진의 GPS 위치 및 메타데이터 등 EXIF 데이터를 온라인에서 즉시 확인.
* [PDFMonkey](https://www.pdfmonkey.io/) — 대시보드에서 PDF 템플릿 관리, 동적 데이터로 API 호출, PDF 다운로드. 월 300건 무료 문서 제공.
* [Pika Code Screenshots](https://pika.style/templates/code-image) — 코드 스니펫과 VSCode로부터 아름답고 커스터마이즈 가능한 스크린샷 생성(확장 프로그램 제공).
* [QuickType.io](https://quicktype.io/) - JSON, 스키마, GraphQL에서 빠르게 모델/클래스/타입/인터페이스 및 직렬화 코드 자동 생성. 다양한 언어로 타입 안정성 높은 코드로 변환.
* [RandomKeygen](https://randomkeygen.com/) - 다양한 난수 키와 비밀번호를 생성해 애플리케이션, 서비스, 기기 보안에 활용할 수 있는 무료 모바일 친화적 도구.
* [ray.so](https://ray.so/) - 코드 스니펫의 아름다운 이미지를 생성.
* [readme.com](https://readme.com/) — 아름다운 문서화를 쉽게, 오픈소스 무료 지원.
* [redirection.io](https://redirection.io/) — 비즈니스, 마케팅, SEO를 위한 HTTP 리디렉션 관리 SaaS 도구.
* [redirect.ing](https://redirect.ing/) - 서버나 SSL 인증서 관리 없이 빠르고 안전하게 도메인 포워딩. 무료 플랜은 10개 호스트네임과 월 10만 요청 제공.
* [redirect.pizza](https://redirect.pizza/) - HTTPS 지원으로 리디렉션을 쉽게 관리. 무료 플랜은 10개 소스와 월 10만 히트 제공.
* [ReqBin](https://reqbin.com/) — HTTP 요청을 온라인에서 전송. GET, POST, PUT, DELETE, HEAD 등 지원. 헤더, 토큰 인증 지원. 요청 저장을 위한 기본 로그인 시스템 포함.
* [Smartcar API](https://smartcar.com) - 차량 위치, 연료/배터리 수준, 주행거리, 도어 잠금/해제 등 차량 정보 API.
* [snappify](https://snappify.com) - 개발자가 아름다운 코드 스니펫부터 기술 프레젠테이션까지 멋진 비주얼 생성. 무료 플랜은 최대 3개 스냅, 무제한 다운로드, 월 5회 AI 코드 설명 제공.
* [Sunrise and Sunset](https://sunrisesunset.io/api/) - 위도와 경도를 입력하면 해당 위치의 일출/일몰 시간 제공.
* [superfeedr.com](https://superfeedr.com/) — 실시간 PubSubHubbub 호환 피드, 내보내기, 분석. 커스터마이징은 제한적이나 무료.
* [SurveyMonkey.com](https://www.surveymonkey.com) — 온라인 설문조사 생성 및 결과 분석. 무료 플랜은 설문당 10문항, 100응답 제한.
* [Tiledesk](https://tiledesk.com) - 챗봇 및 대화형 앱 생성. 웹사이트(라이브챗 위젯)부터 WhatsApp까지 옴니채널 제공. 무료 플랜은 챗봇 무제한.
* [Versionfeeds](https://versionfeeds.com) — 선호하는 소프트웨어 릴리스의 커스텀 RSS 피드. 다양한 프로그래밍 언어, 라이브러리, 도구의 최신 버전을 한 피드에서. (최초 3개 피드 무료)
* [videoinu](https://videoinu.com) — 화면 녹화 및 기타 비디오를 온라인에서 생성 및 편집.
* [Webacus](https://webacus.dev) — 인코딩, 디코딩, 데이터 조작을 위한 다양한 무료 개발자 도구 제공.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 원격 데스크톱 도구

* [Getscreen.me](https://getscreen.me) —  2대 기기까지 무료, 세션 수/시간 무제한
* [Apache Guacamole™](https://guacamole.apache.org/) — 오픈소스 클라이언트리스 원격 데스크톱 게이트웨이
* [RemSupp](https://remsupp.com) — 주문형 지원 및 기기 영구 접근 (무료 2회/일 세션)
* [RustDesk](https://rustdesk.com/) - 모두를 위한 오픈소스 가상/원격 데스크톱 인프라!
* [AnyDesk](https://anydesk.com) —  3대 기기까지 무료, 세션 수/시간 무제한

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 게임 개발

* [itch.io](https://itch.io/game-assets) — 스프라이트, 타일셋, 캐릭터 팩 등 무료/유료 에셋.
* [Gamefresco.com](https://gamefresco.com/) — 전 세계 게임 아티스트의 무료 게임 에셋을 탐색, 수집, 공유.
* [GameDevMarket](https://gamedevmarket.net) — 2D, 3D, 오디오, GUI 등 무료/유료 에셋.
* [OpenGameArt](https://opengameart.org) — 음악, 사운드, 스프라이트, GIF 등 오픈소스 게임 에셋.
* [CraftPix](https://craftpix.net) — 2D, 3D, 오디오, GUI, 배경, 아이콘, 타일셋, 게임킷 등 무료/유료 에셋.
* [Game Icons](https://game-icons.net/) - CC-BY 라이선스 하의 무료 스타일러블 SVG/PNG 아이콘.
* [LoSpec](https://lospec.com/) — 픽셀 아트 및 제한된 디지털 아트 제작을 위한 온라인 도구, 다양한 게임용 튜토리얼/팔레트 리스트 제공.
* [ArtStation](https://www.artstation.com/) - 무료/유료 2D, 3D 에셋 및 오디오, 아이콘, 타일셋, 게임킷의 마켓플레이스. 아트 포트폴리오 공개에도 사용 가능.
* [Rive](https://rive.app/community/) - 커뮤니티 에셋 및 자체 게임 에셋을 무료 플랜으로 제작.
* [Poly Pizza](https://poly.pizza/) - 무료 로우 폴리 3D 에셋 제공.
* [3Dassets.one](https://3dassets.one/) - 8,000개 이상의 무료/유료 3D 모델, PBR 재질 및 텍스처용 소재.
* [Kenney](https://www.kenney.nl/assets/) - CC0 1.0 Universal 라이선스의 무료 2D, 3D, 오디오, UI 게임 에셋.
* [Poliigon](https://www.poliigon.com/) - 다양한 해상도의 무료/유료 텍스처, 모델, HDRI, 브러시 제공. Blender 등으로 내보내기용 무료 플러그인 지원.
* [Freesound](https://freesound.org/) - 다양한 CC 라이선스의 무료 협업 사운드 라이브러리.

**[⬆️ 맨 위로 이동](#table-of-contents)**

## 기타 무료 리소스

* [Wikimint Developer](https://developer.wikimint.com/p/tools.html) - CSS 최소화/복원, 이미지 최적화/리사이즈, 대소문자 변환, CSS 검증, 자바스크립트 컴파일러, HTML 에디터 등 웹 개발자를 위한 무료 도구 모음.
* [ElevateAI](https://www.elevateai.com) - 매월 최대 200시간 무료 오디오 전사 제공.
* [get.localhost.direct](https://get.localhost.direct) — 서브도메인 지원이 가능한 `*.localhost.direct` 와일드카드 공개 CA 서명 SSL 인증서로 더 나은 로컬호스트 개발 환경 제공
* [Framacloud](https://degooglisons-internet.org/en/) — 프랑스 비영리단체 [Framasoft](https://framasoft.org/en/)의 자유/오픈소스 소프트웨어 및 SaaS 목록.
* [github.com — FOSS for Dev](https://github.com/tvvocold/FOSS-for-Dev) — 개발자를 위한 무료 오픈소스 소프트웨어 허브.
* [GitHub Education](https://education.github.com/pack) — 학생을 위한 무료 서비스 모음. 등록 필요.
* [Markdown Tools](https://markdowntools.com) - HTML, CSV, PDF, JSON, Excel 파일을 마크다운으로 또는 그 반대로 변환하는 도구.
* [Microsoft 365 Developer Program](https://developer.microsoft.com/microsoft-365/dev-program) — Microsoft 365 플랫폼 솔루션 개발에 필요한 무료 샌드박스, 도구, 기타 리소스 제공. 구독은 90일 [Microsoft 365 E5 Subscription](https://www.microsoft.com/microsoft-365/enterprise/e5) (Windows 제외)이며, 개발 활동이 있으면 자동 갱신됨(텔레메트리 및 알고리즘 측정).
* [Pyrexp](https://pythonium.net/regex) — 정규표현식 디버깅을 위한 무료 웹 기반 정규식 테스트 및 시각화 도구.
* [RedHat for Developers](https://developers.redhat.com) — 개발자 전용으로 RHEL, OpenShift, CodeReady 등 Red Hat 제품 무료 접근. 개인 플랜만 해당. 참고용 무료 전자책도 제공.
* [smsreceivefree.com](https://smsreceivefree.com/) — 무료 임시 및 폐기 전화번호 제공.
* [sandbox.httpsms.com](https://sandbox.httpsms.com) — 테스트용 SMS 무료 송수신.
* [SimpleBackups.com](https://simplebackups.com/) — 서버 및 데이터베이스(MySQL, PostgreSQL, MongoDB)의 백업 자동화 서비스, 클라우드 저장소(AWS, DigitalOcean, Backblaze)에 직접 저장. 무료 플랜은 1회 백업 제공.
* [SnapShooter](https://snapshooter.com/) — DigitalOcean, AWS, LightSail, Hetzner, Exoscale 백업 솔루션. S3 기반 저장소로 직접 데이터베이스, 파일 시스템, 애플리케이션 백업 지원. 무료 플랜은 리소스 1개에 대해 일일 백업 제공.
* [Themeselection](https://themeselection.com/) — 고품질, 현대적 디자인, 전문가용, 사용이 쉬운 무료 관리자 대시보드 템플릿,
HTML 테마, UI 키트로 빠른 애플리케이션 제작 지원!
* [Web.Dev](https://web.dev/measure/) — 웹사이트 성능을 확인하고 SEO를 개선해 검색 엔진 순위를 높일 수 있는 무료 도구.
  * [SmallDev.tools](https://smalldev.tools/) — 다양한 형식의 인코딩/디코딩, HTML/CSS/Javascript 축소, 코드 보기 좋게 정렬, JSON/CSV 및 기타 여러 형식의 가짜/테스트 데이터셋 생성 등 많은 기능을 제공하는 개발자용 무료 도구. 매력적인 인터페이스 제공.
  * [UseCSV by Layercode](https://layercode.com/usecsv) — 웹 앱에 몇 분 만에 CSV 및 Excel 가져오기 기능을 추가하세요. 사용자에게 즐겁고 견고한 데이터 가져오기 경험을 제공합니다. 신용카드 정보 없이 무료로 시작하고, 오늘 바로 UseCSV를 통합해보세요. 무제한 Importer를 생성할 수 있고 최대 100Mb까지 파일 업로드 가능.
  * [Buttons Generator](https://markodenic.com/tools/buttons-generator/) — 프로젝트에 사용할 수 있는 100개 이상의 버튼 제공.
  * [WrapPixel](https://www.wrappixel.com/) — Angular, React, VueJs, NextJS, NuxtJS로 제작된 고품질의 무료 및 프리미엄 관리자 대시보드 템플릿을 다운로드하세요!
  * [Utils.fun](https://utils.fun/en) — 브라우저의 연산 능력에 기반한 모든 오프라인 일상 및 개발 도구를 무료로 제공. 워터마크 생성, 화면 녹화, 인코딩/디코딩, 암호화/복호화, 코드 포매팅 등 모든 과정에서 데이터를 클라우드로 업로드하지 않음.
  * [It tools](it-tools.tech) - 개발자 및 IT 종사자를 위한 유용한 도구들.
  * [Free Code Tools](https://freecodetools.org/) — 100% 무료의 효과적인 코드 도구. 마크다운 에디터, 코드 축소/정렬, QR 코드 생성기, 오픈 그래프 생성기, 트위터 카드 생성기 등 제공.
  * [regex101](https://regex101.com/) — 정규 표현식(Regex)을 테스트하고 디버그할 수 있는 무료 웹사이트. 정규식 에디터 및 테스터, 유용한 문서와 학습 자료 제공.
  * [Kody Tools](https://www.kodytools.com/dev-tools) — 포매터, 축소기, 변환기 등 100개 이상의 개발 도구 제공.
  * [AdminMart](https://adminmart.com/) — Angular, Bootstrap, React, VueJs, NextJS, NuxtJS로 제작된 고품질의 무료 및 프리미엄 관리자 대시보드 및 웹사이트 템플릿 제공!
  * [Glob tester](https://globster.xyz/) — Glob 패턴을 설계하고 테스트할 수 있는 웹사이트. Glob 패턴 학습 자료도 제공.
  * [SimpleRestore](https://simplerestore.io) - 번거로움 없는 MySQL 백업 복원. 코드나 서버 없이 어떤 원격 데이터베이스에도 MySQL 백업을 복원할 수 있음.
  * [360Converter](https://www.360converter.com/) - 비디오를 텍스트로, 오디오를 텍스트로, 음성을 텍스트로, 실시간 오디오를 텍스트로, 유튜브 비디오를 텍스트로 변환하고 비디오 자막 추가가 가능한 유용한 무료 웹사이트. 짧은 동영상 변환이나 유튜브 튜토리얼에 유용할 수 있음:)
  * [QRCodeBest](https://qrcode.best/) - 13가지 템플릿, 완전한 개인정보 보호 및 개인 브랜딩이 가능한 맞춤형 QR 코드 생성. 추적 픽셀, 프로젝트 분류, QRCode.Best에서 무제한 팀 좌석 제공.
  * [PostPulse](https://PostPulseAI.com) - 월별 AI로 제작된 게시물을 SEO 최적화 도메인에 게시하여 온라인 존재감과 SEO, 사이트 순위를 향상시킵니다. 무료 플랜에서는 매월 1개의 게시물을 수동으로 사이트에 게시 가능.
  * [PageTools](https://pagetools.co/) - 필수 웹사이트 정책 생성, SNS 바이오/게시물/웹페이지 생성 등 다양한 AI 기반 도구를 영원히 무료로 제공. 원클릭 인터페이스 제공.
  * [MySQL Visual Explain](https://mysqlexplain.com) - 느린 쿼리 최적화를 위한 쉽고 무료의 MySQL EXPLAIN 결과 시각화 도구.
  * [Killer Coda](https://killercoda.com/)  - 브라우저에서 리눅스, 쿠버네티스, 컨테이너, 프로그래밍, 데브옵스, 네트워킹을 학습할 수 있는 인터랙티브 플레이그라운드
  * [Axonomy App](https://axonomy-app.com/) - 인보이스를 생성, 관리, 공유할 수 있는 무료 도구. 매월 10개의 무료 인보이스 제공.
  * [Table Format Converter](https://www.tableformatconverter.com) - 표 데이터를 CSV, HTML, JSON, Markdown 등 다양한 형식으로 변환할 수 있는 무료 도구.


**[⬆️ 맨 위로](#table-of-contents)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---