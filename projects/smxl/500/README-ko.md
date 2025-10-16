Simple Config GeoIP for Quantumult X (QuantumultX), Loon, Stash 预配置文件包含 Apple News解锁规则、去广告分流规则、TikTok 解锁 Rewrite、神机分流规则和 VIP 视频解析重写, 并提供相应的快捷方式

## 简介
> + 利용 Quantumult X 와 GeoIP 특성을 활용하여 여러 리라이트 설정을 통합하고, 대부분의 규칙을 제거하여 비용을 절감하며, Vercel을 통해 규칙과 구성 파일을 간소화합니다.
- [사용 방법](https://github.com/smxl/500#使用方法)
- [분류 규칙 및 리라이트](https://github.com/smxl/500#分流规则和重写)
- [유틸리티](https://github.com/smxl/500#小工具)
- [구성 파일 업데이트](https://github.com/smxl/500#配置文件更新)
- [추천](https://github.com/smxl/500#推荐)

## 声明

Disclaimer: 일부 스크립트와 내용은 ChatGPT가 작성하였습니다.

본 프로젝트는 여러 [Quantumult X](https://apps.apple.com/us/app/quantumult-x/id1443988620) 구성 파일에서 최적화되었습니다.

모든 내용은 참고용이며, 본 프로젝트는 어떠한 제3자 콘텐츠에 대해서도 책임지지 않습니다. 이 링크와 내용은 참고 및 사용 편의를 위한 것이며, 본 프로젝트가 이를 승인하거나 인정하는 것은 아닙니다.

Github 주소: [https://github.com/smxl/500](https://github.com/smxl/500)

##  使用方法

1. 구성 파일 다운로드 또는 복사

[https://github.com/smxl/500/raw/main/500.conf](https://github.com/smxl/500/raw/main/500.conf)

[https://cnn.vercel.app/500.conf](https://cnn.vercel.app/500.conf)

2. Quantumult X - 톱니바퀴 - 구성 파일 - 다운로드 - 붙여넣기 - 확인

3. Mitm - 인증서 생성 - 인증서 설정 - 인증서 설치

4. 시스템 - 설정 - 일반 - 정보 - 인증서 신뢰

5. Quantumult X - 톱니바퀴 - 노드 - 참조 (구독) - 우측 상단 추가 - 태그 및 리소스 경로 입력 (자신의 서버 구독 링크)

6. Quantumult X - 톱니바퀴 - 기타 설정 - GeoLite2 소스에 GeoIP 추가

7. GeoIP2-CN 중 하나 선택 (링크 복사 또는 다운로드 후 가져오기)
> - [Loyalsoldier](https://github.com/Loyalsoldier/geoip/raw/release/Country-only-cn-private.mmdb)
> - [Hackl0us](https://github.com/Hackl0us/GeoIP2-CN/raw/release/Country.mmdb)
> - [soffchen](https://github.com/soffchen/GeoIP2-CN/raw/release/Country.mmdb)

8. 만약 본인의 구독 링크가 없다면, 바로 사용 가능하며, 자신의 구독을 사용하려면 설정 파일의 [server_remote] 아래 https://cnn.vercel.app/xv-sub 를 자신의 구독 링크로 변경하세요.

9. 실행 시, Quantumult X가 url schema / url-schema 실행을 지원하지 않으므로, 기타 설정 - VPN - 항상 켜기로 설정하는 것을 권장하며, 나머지 스위치는 필요에 따라 선택하세요.

주1: 이 설정 파일의 기본 구독 링크는 공개된 정보로, 개인정보 보호가 중요한 사용자는 장기간 사용을 권장하지 않습니다. ~~또한 본 설정은 공개된 MITM 인증서를 사용하므로, 직접 생성하여 교체할 것을 권장합니다 (인증서 생성 후 내보낼 때 비밀번호를 입력하지 않으면 패스프레이즈를 생략할 수 있습니다).~~

주2: QX는 NaïveProxy (naiveproxy)를 지원하지 않으므로, 현재 버전에서는 로컬 네트워크 내 OpenWRT에서 실행하는 것을 권장하며, 로컬 서비스 ```socks5=192.168.124.124:1080, tag=LAN```로 연결하고, 라우터 쪽에 시작 스크립트 ```naive /[PATH]/config.json```을 추가하세요.

## 분류 규칙 및 재작성

태그명|유형|단축 링크|소개 - 취소선은 비활성화 표시
-|-|-|-
ads|규칙|https://cnn.vercel.app/xf-ads|광고 차단
cn|규칙|https://cnn.vercel.app/xf-cn|중국 본토 서비스 직연결
global|규칙|https://cnn.vercel.app/xf-global|국제 서비스
hijacking|규칙|https://cnn.vercel.app/xf-hijacking|하이재킹 방지
privacy|규칙|https://cnn.vercel.app/xf-privacy|개인정보 보호
tg|규칙|https://cnn.vercel.app/xf-tg|텔레그램
unbreak|규칙|https://cnn.vercel.app/xf-unbreak|규칙 수정
-|-|-|-
adlite|재작성|https://cnn.vercel.app/xr-adlite|광고 재작성 차단
ads|재작성|https://cnn.vercel.app/xr-ads|광고 재작성
adscript|재작성|https://cnn.vercel.app/xr-adscript|스크립트 광고 차단
apple|재작성|https://cnn.vercel.app/xr-apple|제한된 Apple 서비스 잠금 해제, 날씨 제거, iOS16 호환 Scriptable/IQair/관심 대기 오염 위젯에서 미국 AQI 표시
bing|재작성|https://cnn.vercel.app/xr-bing|New Bing w/ Safari w\ Edge
bili|재작성|https://cnn.vercel.app/xr-bili|Bilibili 인터페이스 최적화
box|재작성|https://cnn.vercel.app/xr-box|BoxJS
-|-|-|수동 추가
covidsc|재작성|https://cnn.vercel.app/xr-covidsc|24시간 핵산 검사 보고서 쓰촨 톈푸 건강통, 전체 기능 - 알리페이+위챗 기본 비활성화
covidsc|재작성|https://cnn.vercel.app/xr-covidhn|24시간 핵산 검사 보고서 허난 위캉마 기본 비활성화
emby|재작성|https://cnn.vercel.app/xr-emby|Emby 잠금 해제, 알림 없음
fake|재작성|https://cnn.vercel.app/xr-fake|Fake Pro 잠금 해제, lk 기반으로 간소화하고 Spotify Pro 추가
jsc|재작성|https://cnn.vercel.app/xr-jsc|스크립트 쿠키 획득
lk|재작성|https://cnn.vercel.app/xr-lk|해외 서비스 Fake VIP
upgrade|재작성|https://cnn.vercel.app/xr-upgrade|앱 업데이트 검사 차단
res|재작성|https://cnn.vercel.app/xr-res|중국 본토 소프트웨어 최적화
search|재작성|https://cnn.vercel.app/xr-search|DuckDuckGo 검색 엔진 재작성
v|재작성|https://cnn.vercel.app/xr-v|비디오 분석 재작성

자신의 상황에 따라 위 규칙과 재작성 활성화 여부를 조정할 수 있습니다. 예: 해외 소프트웨어를 거의 사용하지 않는다면 ```lk 재작성 https://cnn.vercel.app/xr-lk 해외 서비스 Fake VIP``` 여기서 제공하는 여러 소프트웨어의 VIP/Pro 잠금 해제는 쓸모없습니다 [일부 재작성은 이미 작동하지 않음]

마찬가지로 ```fake https://cnn.vercel.app/xr-fake Fake Pro 해제``` 는 해당 규칙의 간략화 버전입니다

2024년 iOS API 변경으로 TikTok 최신 버전은 시스템 국가 변경과 한 줄 분기 규칙만 수정하면 사용 가능합니다 ```host-wildcard, *tiktok*, proxy```

## 소도구

도구|용도|링크/추가설명
-|-|-
빠른 검색|Safari 기본 검색 엔진을 DuckDuckGo로 설정|기본 구글, 접두어 두 글자로 다른 검색 엔진 지정 Baidu:bd/Magi:mm/Twitter:tt/YouTube:yt/WolframAlpha:wa + 공백 + 키워드

fake 재작성 활성화 시, 다음 소프트웨어가 강화됨: Adguard, Day One, Draft, Documents, Lightroom, PS Express, Memrise, Spotify pro*... 별표*는 인앱 구매 해제 또는 VIP 모의 여부 불확실

res 재작성 활성화 시, 다음 소프트웨어가 강화됨: 빌리빌리, 컬러클라우드 날씨, 위챗, 바이두 클라우드...

## 구성 파일 업데이트

500.conf

[https://github.com/smxl/500/raw/main/500.conf](https://github.com/smxl/500/raw/main/500.conf)

[https://cnn.vercel.app/q](https://cnn.vercel.app/q)

## 추천

이 구성 파일은 일부 프로젝트 또는 서비스를 참조하며, vercel.json에서 확인할 수 있습니다

원본 프로젝트 접근 편의를 위해 구성 파일 내 참조 방식은 `https://github.com/사용자/프로젝트/raw/브랜치/디렉토리/파일` 형식을 사용합니다

`https://github.com/사용자/프로젝트/` 를 주소창에 복사하여 참조 프로젝트에 접속하세요

--

극소형 템플릿 https://cnn.vercel.app 대부분의 불필요한 설정 제거, 기본 프레임만 유지

감사합니다 ilovexjp ILoveNucleicAcidTest 등.

AI, Web3 및 백서에 감사드립니다

엔터테인먼트와 당신 자신에게 감사드립니다


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---