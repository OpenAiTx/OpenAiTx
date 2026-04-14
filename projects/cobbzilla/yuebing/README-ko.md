Yuebing 🥮
==========
Yuebing은 비디오 호스팅 사이트를 운영하기 위한 오픈 소스 소프트웨어입니다.

Yuebing은 최신 형식을 사용하여 스트리밍용 소스 비디오를 자동으로 준비하며, 모든
장치와 모든 연결에서 재생할 수 있습니다.

Yuebing은 백엔드 저장소로 Amazon S3 또는 Backblaze B2를 사용할 수 있으며, 많은 고급 기능을 제공합니다.

### 소스
* [GitHub의 yuebing](https://github.com/cobbzilla/yuebing)
* [npm의 yuebing](https://www.npmjs.com/package/yuebing)
* [DockerHub의 yuebing](https://hub.docker.com/r/cobbzilla/yuebing)

# 다른 언어로 읽기
이 README.md 문서는 [hokeylization](https://github.com/cobbzilla/hokeylization)을 통해
여러 언어로 번역되었습니다.

완벽하지는 않겠지만, 없는 것보다는 낫기를 바랍니다!

&nbsp;&nbsp;&nbsp;[🇸🇦 아랍어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ar/README.md)
&nbsp;&nbsp;&nbsp;[🇧🇩 벵골어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/bn/README.md)
&nbsp;&nbsp;&nbsp;[🇩🇪 독일어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/de/README.md)
&nbsp;&nbsp;&nbsp;[🇺🇸 영어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/en/README.md)
&nbsp;&nbsp;&nbsp;[🇪🇸 스페인어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/es/README.md)
&nbsp;&nbsp;&nbsp;[🇫🇷 프랑스어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/fr/README.md)
&nbsp;&nbsp;&nbsp;[🇹🇩 하우사어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ha/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇳 힌디어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/hi/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇩 인도네시아어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/id/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇹 이탈리아어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/it/README.md)
&nbsp;&nbsp;&nbsp;[🇯🇵 일본어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ja/README.md)
&nbsp;&nbsp;&nbsp;[🇰🇷 한국어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ko/README.md)
&nbsp;&nbsp;&nbsp;[🇮🇳 마라티어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/mr/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇱 폴란드어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/pl/README.md)
&nbsp;&nbsp;&nbsp;[🇧🇷 포르투갈어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/pt/README.md)
&nbsp;&nbsp;&nbsp;[🇷🇺 러시아어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ru/README.md)
&nbsp;&nbsp;&nbsp;[🇰🇪 스와힐리어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/sw/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇭 타갈로그어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/tl/README.md)
&nbsp;&nbsp;&nbsp;[🇹🇷 터키어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/tr/README.md)
&nbsp;&nbsp;&nbsp;[🇵🇰 우르두어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/ur/README.md)
&nbsp;&nbsp;&nbsp;[🇻🇳 베트남어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/vi/README.md)
&nbsp;&nbsp;&nbsp;[🇨🇳 중국어](https://raw.githubusercontent.com/cobbzilla/yuebing/master/docs/zh/README.md)
----

# 목차
* [영감](#Inspiration)
* [특징](#Features)
* [설치](#Installation)
  * [도커](#Docker)
  * [npm 패키지](#npm-package)
  * [소스에서](#From-source)
* [구성](#Configuration)
  * [nginx 구성](#nginx-config)
* [왜 yuebing이라는 이름인가?](#Why-the-name-yuebing?)

## 영감
작년에 우리 엄마는 오래된 가족 비디오 아카이브를 정리하고 디지털화하는 데 엄청난 시간(그리고 돈!)을 썼습니다.
이 비디오 중 일부는 1940년대로 거슬러 올라가는 꽤 오래된 것들이었습니다. 정말 아름답고 고전적인 자료들입니다.

우리는 이 비디오를 가족과 사적으로 공유하고 싶었지만, *대형 기술 회사와는 공유하지 않으려* 했습니다.
주요 제공업체의 "무료" 비디오 호스팅은 처음부터 고려 대상이 아니었습니다.

우리가 찾던 것은:
* 자체 호스팅 가능하지만 완전히 **손쉬운 운영 및 유지 관리**
* 적응형 비트레이트를 포함한 최신 비디오 포맷 스트리밍
* 모든 장치, 데스크탑이나 모바일에서 비디오 재생 가능
* 고대역폭 연결에서는 비디오 품질이 최상; 가능한 최고의 품질
  * **나쁜 연결 상황에서도** 재생 품질이 괜찮으며 *중단이나 버퍼링이 없음*
* 암호화된 저장소, 따라서 어느 정도 신뢰할 수 있는 공개 클라우드 저장소 사용 가능
* 상태 비저장 서버: 중요한 것은 매우 복원력이 강한 저장소에 지속
  * **백업 걱정 없이!**
  * *이 점이 있었으면 좋겠다고 생각했는데, 알고 보니 이런 것을 제공하는 것은 없었습니다. Yuebing이 해냅니다!*
* 모든 것을 트랜스코딩하기 위해 강력한 인스턴스를 실행한 후, 장기적으로는 더 저렴한 인스턴스를 운영
  * Yuebing은 월 $10 이하로 운영 가능하며, 앞으로 최적화를 거쳐 더 저렴해질 것으로 기대합니다

몇 주 동안 시장 조사를 했습니다. 요구사항을 크게 완화해도
괜찮은 것을 찾을 수 없었습니다. 여러 오픈 소스 프로젝트를 살펴봤지만, 모두
여러 치명적인 결함이 있었습니다.

그래서 나는 생각했습니다, 얼마나 어려울까? S3를 ffmpeg에 연결하고, 적당히 현대적인 프론트엔드를 올리면 끝, 아니겠어?
... 음, 글쎄요, 작업의 대부분은 몇 달이 걸렸지만, 너무 재미있어서 멈출 수가 없었어요!
여러분도 즐기시길 바랍니다!

### <a style="text-decoration: none; color: inherit" href="https://open.spotify.com/track/0HEYFRBo4pBLLWjXsAZjod?si=riLTqMknTji7_X_4XzSkGQ&context=spotify%3Aalbum%3A20KGjm5xRROTqP0UY1EVRg">**셀프 호스팅 비디오 사이트를 아주 쉽게 만들어 봅시다!**</a>

## 기능
* S3(또는 B2) 버킷에 있는 비디오를 친구와 가족을 위한 개인 비디오 사이트로 변환!
* 하나 이상의 원본 버킷을 연결하여 원본 미디어 파일 제공
* Yuebing은 자동으로 원본 비디오를 최신이자 가장 널리 지원되는 적응형 비트레이트 스트리밍 포맷(DASH/mp4)으로 트랜스코딩
* 모든 데이터는 대상 버킷에 저장; 서버는 언제든지 파괴 가능
  * 초기 트랜스코딩을 위해 CPU 최적화 인스턴스에서 실행한 후, 훨씬 저렴한 인스턴스에서 24/7/365 서비스 운영에 유용
  * 완전 암호화 저장 지원(앱 측 암호화, 키는 오직 사용자만 보유)
  * 원본은 항상 읽기 전용, 원본 콘텐츠는 변경하지 않음
  * 새 미디어 파일에 대해 자동 및 수동 스캔
* 얼마나 비공개 또는 공개로 할지 선택 가능! Yuebing은 다음을 지원:
  * 완전 비공개: 익명 사용자에게 미디어 미노출, 승인된 이메일 주소만 계정 생성 가능
  * 반비공개: 익명 사용자에게 미디어 미노출, 누구나 사용자 계정 생성 가능
  * 제한적 공개: 모두에게 미디어 노출, 승인된 이메일 주소만 계정 생성 가능
  * 완전 공개: 모두에게 미디어 노출, 누구나 사용자 계정 생성 가능
* 완전 다국어 지원! 모든 사용자에게 보이는 텍스트(및 기타 로케일 특정 항목)는 현지화된 리소스에서 제공
  * [커뮤니티에 도움을 주세요, Yuebing을 새로운 언어로 번역해 보세요!](https://github.com/cobbzilla/yuebing/blob/master/docs/localize.md)
* 모든 기능을 갖춘 관리자 콘솔
* 키워드 또는 태그 클라우드로 비디오 검색
* <a href="https://www.patreon.com/cobbzilla">**여러분의 후원으로 곧 제공 예정**</a>:
  * 더 많은 미디어 유형 지원(오디오, 이미지 등)
  * 사용자 업로드 미디어
  * 좋아요, 공유, 푸시 알림
  * 새로운 "원본 유형": 또 다른 Yuebing 인스턴스!
    * 친근한 인스턴스 간 연합: 통합 검색, 사용자 계정 등

## 익명 사용자 기능 (사이트가 익명 방문자 허용으로 설정된 경우)
* 미디어 탐색
* 미디어 시청!
* 계정 생성 (사이트가 계정 등록 허용으로 설정된 경우)

## 로그인 사용자 기능
* 미디어 탐색
* 미디어 시청!
* 댓글 작성, 댓글 수정, 댓글 삭제!

* 친구 초대
* 계정 정보 수정
* 계정 삭제, 모든 댓글을 포함한 본인의 모든 데이터가 삭제됨

## 관리자 사용자 기능
* 미디어 메타데이터 편집, 썸네일 보기, 선택한 썸네일 변경
* 미디어 변환 대기열 및 작업 상태 보기
* 소스 미디어에 대한 새로운 스캔 및 인덱스 시작

## 서버/백엔드 기능
* 일시적 환경에 적합하며, 컨테이너 내에 지속적/중요 데이터는 전혀 저장하지 않음.
  * 모든 내구성 데이터는 대상 버킷에 영구 저장됨; 본질적으로 S3를 데이터베이스로 사용함
* 소스 버킷의 신규 미디어에 대한 자동 주기적 스캔
* 미디어 메타데이터 추가 및 변경; 편집 내용은 대상 버킷에 저장되며 소스 미디어는 절대 수정되지 않음
* 구성 가능한 출력 프로필. 기본값은 여러 하위 프로필이 포함된 DASH-mp4
* 사용자 계정 정보도 대상 버킷에 저장되며, 선택적으로 암호화 가능
  * 암호화 키가 변경되면, 관리자가 웹 관리자 콘솔을 통해 사용자를 새 키로 이전할 수 있음

## 설치
`yuebing`은 도커, npm 또는 소스에서 직접 설치 및 실행할 수 있습니다.

### 도커
도커가 있다면, Yuebing을 빠르게 시작할 수 있습니다:

    docker run -it cobbzilla/yuebing

### npm 패키지
    # npm으로 전역 설치
    npm i -g yuebing

    # yarn으로 전역 설치
    yarn global add yuebing

    # 이제 'yuebing' 명령어가 PATH에 있어야 합니다
    yuebing

### 소스에서
소스에서 실행하려면 nodejs v16+와 yarn이 필요합니다.

    # 소스 클론 후 의존성 설치
    git clone https://github.com/cobbzilla/yuebing.git
    cd yuebing
    yarn install

    # git 저장소에서 'yuebing' 명령어 사용
    ./yuebing

    # 또는 소스가 있으니, `yarn` 스크립트 중 하나 실행
    yarn docker-run-dev    # 가장 빠른 빌드 및 시작, 개발용 도커 이미지
    yarn docker-run        # 실행 시 더 빠름, 프로덕션 도커 이미지
    yarn dev               # yuebing을 로컬에서 개발 모드로 실행
    yarn build             # yuebing을 프로덕션 모드로 로컬 빌드
    yarn start             # yuebing을 프로덕션 모드로 로컬 시작

자세한 내용은 [개발자 문서](https://github.com/cobbzilla/yuebing/blob/master/docs/developer.md)를 참고하세요.

## 설정
Yuebing을 사용해보려면, 아무 설정 없이 시작해도 괜찮습니다.
`yuebing`을 실행하면 시작 시 최소한의 설정을 입력하라는 메시지가 표시됩니다.

Yuebing을 오래 실행할 계획이라면, 설정 방법에 대한 자세한 내용은 [설정 문서](https://github.com/cobbzilla/yuebing/blob/master/docs/config.md)를 참고하세요.

### nginx 설정
Yuebing은 Nuxt 앱이며, SSL 처리, 필요 시 속도 제한 등을 위해 nginx(또는 다른 웹 서버)를
앞단에 두는 것을 기대합니다.

nginx를 사용하는 경우, 여기 [샘플 설정](https://github.com/cobbzilla/yuebing/blob/master/docs/sample-yuebing-nginx.conf)이 있습니다.

## yuebing이라는 이름의 의미는?
[우롱 토끼](https://en.wikipedia.org/wiki/Oolong_(rabbit))는 귀엽고 유명한
[초기 인터넷 밈](https://duckduckgo.com/?q=oolong+rabbit&ia=images&iax=images)이었습니다. 우롱은 2003년에 죽었고,
이는 어떤 엄청나게 인기 있는 비디오 서비스가 존재하기 2년 전입니다!

우롱의 후계자는 Yuebing이라는 이름이었습니다. Yuebing은 우롱만큼 유명하지는 않았지만, 그게 중요한가요?
Yuebing은 그럼에도 성공했습니다.

더 흥미로운 점은, yuebing은 [월병](https://en.wikipedia.org/wiki/Mooncake)
(중국어: [月饼](https://zh.wikipedia.org/wiki/%E6%9C%88%E9%A5%BC),
일본어: [月餅](https://ja.wikipedia.org/wiki/%E6%9C%88%E9%A4%85))을 의미합니다; 월병은 매우 맛있고 어디서든 찾을 수 있습니다.

다양한 맛과 스타일이 있습니다. 전통적인 지역 스타일을 즐기거나, 맛있게 미지의 영역을 탐험하는 현대 제빵사들의 이국적인 케이크를 시도해 보세요! 모두를 위한 월병이 진정으로 있습니다!



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-14

---