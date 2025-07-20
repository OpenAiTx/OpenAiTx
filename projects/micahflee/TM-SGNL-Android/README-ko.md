# Signal Android

Signal은 간단하고 강력하며 안전한 메신저입니다.

Signal은 휴대폰의 데이터 연결(WiFi/3G/4G/5G)을 사용하여 안전하게 통신합니다. 전 세계 수백만 명이 매일 Signal을 사용하여 무료로 즉시 소통합니다. 고품질 메시지를 보내고 받고, HD 음성/영상 통화에 참여하며, 연결 상태를 유지하는 데 도움이 되는 새로운 기능들을 탐색하세요. Signal의 고급 프라이버시 보호 기술은 항상 활성화되어 있어, 중요한 순간을 중요한 사람들과 공유하는 데 집중할 수 있습니다.

현재 Play 스토어와 [signal.org](https://signal.org/android/apk/)에서 제공됩니다.

<a href='https://play.google.com/store/apps/details?id=org.tm.archive&pcampaignid=MKT-Other-global-all-co-prtnr-py-PartBadge-Mar2515-1'><img alt='Get it on Google Play' src='https://play.google.com/intl/en_us/badges/images/generic/en_badge_web_generic.png' height='80px'/></a>

## 버그 리포트 기여
우리는 버그 추적을 위해 GitHub를 사용합니다. 버그가 이미 보고되었는지 검색하고, 아직 추적되지 않은 버그라면 새 이슈를 생성해 주세요!

https://github.com/signalapp/Signal-Android/issues

## 베타 참여
최신 기능을 가장 먼저 사용해보고 테스트를 도와주고 싶으신가요?

Signal Android 베타 릴리스를 구독할 수 있습니다:
https://play.google.com/apps/testing/org.tm.archive

평화롭고 안정적인 사용을 원하시면 일반 릴리스를 이용하세요.

## 코드 기여

Signal 코드베이스가 처음이라면, 문제 중에서 간단한 버그("easy" 라벨이 붙은)를 선택해 수정해보며 익히는 것을 추천합니다. 또한 [CONTRIBUTING.md](https://github.com/signalapp/Signal-Android/blob/main/CONTRIBUTING.md)를 확인하면 많은 질문에 답을 얻을 수 있습니다.

큰 변경사항이나 기능 아이디어는 구현 전에 [비공식 커뮤니티 포럼](https://community.signalusers.org)에서 넓은 커뮤니티와 고수준 토론을 제안해 주세요.

## 아이디어 기여
Signal 프로젝트에 대해 의견이 있거나 대화에 참여하고 싶으신가요? [커뮤니티 포럼](https://community.signalusers.org)에 참여하세요.

Help
====
## 지원
문제 해결과 질문은 지원 센터를 방문해 주세요!

https://support.signal.org/

## 문서
문서를 찾고 계신가요? 위키를 확인하세요!

https://github.com/signalapp/Signal-Android/wiki

# 법적 사항
## 암호화 관련 공지

이 배포판에는 암호화 소프트웨어가 포함되어 있습니다. 현재 거주하시는 국가에서는 암호화 소프트웨어의 수입, 소지, 사용, 또는 타국으로 재수출에 제한이 있을 수 있습니다.
암호화 소프트웨어 사용 전에 해당 국가의 법률, 규정, 정책을 반드시 확인하여 허용되는지 확인하시기 바랍니다.
자세한 내용은 <http://www.wassenaar.org/>를 참조하세요.

미국 상무부 산업안보국(BIS)은 이 소프트웨어를 ECCN(수출상품관리번호) 5D002.C.1로 분류하였습니다. 이 번호는 비대칭 알고리즘을 사용하는 정보보안 소프트웨어에 해당합니다.
이 배포 형식은 객체 코드와 소스 코드 모두에 대해 라이선스 예외인 ENC 기술 소프트웨어 무제한(TSU) 예외(상무부 수출관리규정, 섹션 740.13)에 따라 수출이 가능합니다.

## 라이선스

Copyright 2013-2024 Signal Messenger, LLC

GNU AGPLv3 라이선스 하에 배포: https://www.gnu.org/licenses/agpl-3.0.html

Google Play 및 Google Play 로고는 Google LLC의 상표입니다.


//**TM_SA**//
Signal – 새로운 기본 라인
1.	다음 링크에서 Signal 공식 오픈 소스를 다운로드하세요:
      https://github.com/signalapp/Signal-Android

2.	다음 순서로 각 폴더 이름을 변경하세요:
      a.	thoughtcrime  tm
      b.	securesms  archive
3.	모든 이전 패키지 언급을 “모두 바꾸기” 기능(Ctrl +Shift + R)을 사용해 교체하세요.
      a.	org.tm.archive -> org.tm.archive
4.	새 폴더 “libs”에 아카이버 SDK와 공용 라이브러리를 추가하고 의존성으로 컴파일하세요.
5.	archiver, intune, selfauthentication 폴더와 모든 아카이빙 클래스 및 util 등을 추가하세요. (src->main->java->org에서 가져오세요)
6.	현재 프로젝트에서 “ArchiveLogger.Companion.sendArchiveLog”를 검색하고 모든 해당 언급을 업데이트된 프로젝트에 추가하세요.
7.	런처 아이콘 앱을 추가하고 매니페스트에서 둥근 아이콘 경로를 변경하세요.
8.	현재 프로젝트에서 proguard-event_bus를 업데이트된 프로젝트에 추가하세요.
9.	현재 TeleMessage Signal 프로젝트로 가서 ctrl+alt+F로 //**TM_SA**//를 검색하세요.

이 문자열에 대한 참조가 수십 개 있습니다. 결과를 하나씩 진행하며 이 문자열(//**TM_SA**//)로 코드 교체 또는 추가를 하여 기본 라인 업데이트 방식을 이어가세요.


intune

1. //**TM_SA**//를 사용하여 의존성을 추가하세요.
2. aar와 jar가 포함된 MAMSDK 폴더를 추가하세요.
3. 1. 앱을 intune 서버에 등록하세요.
2. https://aad.portal.azure.com/#view/Microsoft_AAD_IAM/ActiveDirectoryMenuBlade/~/Overview3. Azure Active Directory > 앱 등록 > 새 등록
3. 인증, 플랫폼 추가 -> uri 추가 -> 패키지 이름 입력.
4. 그런 다음 View 버튼을 통해 표시되는 auth-config 파일을 추가하고 resource-> raw에 넣으세요.
5. API 권한 설정...

4. 1. https://aad.portal.azure.com/#view/Microsoft_AAD_IAM/ActiveDirectoryMenuBlade/~/RegisteredApps
2. 앱 구성 정책 -> 앱 구성 정책 생성 -> 앱 관리 -> 설정 -> 값 추가(managerID 등)
3. 할당 -> 원하는 그룹 포함 또는 모두 할당.

5. http://everythingaboutintune.com/2021/07/guide-for-integrating-intune-sdk-and-msal-to-lob-application/

https://www.youtube.com/watch?v=1AyGpcdDRkY&t=741s&ab_channel=EverythingAboutIntune
https://github.com/msintuneappsdk/Taskr-Sample-Intune-Android-App#readme
//**TM_SA**//


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---