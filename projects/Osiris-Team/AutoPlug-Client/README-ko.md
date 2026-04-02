<div align="center">
   <img src="https://i.imgur.com/BMpvtWP.png">
</div>

 AutoPlug-Client는 독립 실행형 Java 실행 프로그램으로 서버 래퍼, CLI 도구, 백그라운드 서비스 등 여러 실행 모드를 지원합니다. 주요 목적은 서버 관련 소프트웨어 업데이트를 자동화하고 서버 유지 관리를 간소화하는 것입니다. 모든 서버 유형(스팀 게임 서버 포함)이 호환되지만, 대부분의 기능은 세계 최고의 판매 게임이자 매우 방대한 모딩 커뮤니티를 자랑하는 마인크래프트에 특화되어 있습니다.
 
## 링크

- 안정/베타 버전은 [AutoPlug-Releases](https://github.com/Osiris-Team/AutoPlug-Releases) 저장소에서 다운로드하세요.
- [AutoPlug-Client-Development](https://bit.ly/acprogress)를 팔로우하여 현재 작업 중인 내용을 확인하세요.
- 개발 지원은 [기부](https://www.paypal.com/donate?hosted_button_id=JNXQCWF2TF9W4)로 해주세요.
- 문제나 질문이 있으신가요? [FAQ](/docs/FAQ.md)를 확인하거나, 라이브 채팅/음성 지원을 위해 [Discord](https://discord.com/invite/GGNmtCC)에 참여하세요.

## 무엇을 할 수 있나요?

- 자동화된 자체, 서버 소프트웨어, 플러그인, 모드 및 JRE(Java Runtime Environment) 업데이트
- 예약된 서버 재시작
- 자동화되고 모듈화된 백업 생성
- 빠르고 비동기적이며 다중 스레드 작업 실행
- 동기화(공유) 폴더 지원
- 서버 시작, 중지, 재시작 및 최근 업데이트 결과 요약을 볼 수 있는 웹 패널 제공

프리미엄 [AutoPlug-Web](https://autoplug.one) 기능:

- [온라인 콘솔](https://raw.githubusercontent.com/Osiris-Team/AutoPlug-Client/master/./docs/online-console.gif)
- [온라인 파일 관리자](https://raw.githubusercontent.com/Osiris-Team/AutoPlug-Client/master/./docs/file-manager.gif)
- 스태프 접근 권한
- 플러그인 상세 데이터베이스

## 상태
안정적이고 기능이 완전하며, 커뮤니티 주도 개발 방식으로 운영됩니다. 즉, 수석 개발자는 보안 문제와 치명적인 버그를 제외한 새로운 기능 개발을 중단하고 다른 사람들의 풀 리퀘스트에 의존합니다.

## 커뮤니티 프로젝트

- 도커 지원: https://github.com/lkkuma/AutoPlug-Client-Docker
- Pterodactly 패널 지원: https://github.com/ImLunaUwU/PteroPlug

개발자: 


프로젝트에서 AutoPlug를 의존성으로 추가하여 [Maven/Gradle/Sbt/Leinigen](https://jitpack.io/#Osiris-Team/AutoPlug-Client/-SNAPSHOT) 을 통해 사용할 수도 있습니다.  
예를 들어 AutoPlug 명령어를 프로그래밍 방식으로 실행할 수 있는 AutoPlugConsole과 같은 유용한 클래스들이 있습니다:


```java
AutoPlugConsole.executeCommand(".check plugins");
AutoPlugConsole.executeCommand(".check server");
// etc...
```
## 기여하기 ![Build test](https://github.com/Osiris-Team/AutoPlug-Client/workflows/build/badge.svg)

기여를 고려해 주셔서 감사합니다, 커뮤니티 💙 가 환영합니다! 다음 사항을 기억해 주세요:
- 큰 변경을 원하시면 먼저 이슈를 생성하여 논의할 수 있도록 하세요.
- 큰 변경은 테스트 작성도 필요하다는 점을 기억하세요.
- 열린 이슈 중 아무거나 선택해 작업할 수 있습니다. 작업 중임을 알려주세요.
- 메모리 사용을 최소화하기 위해 static 메서드/필드/클래스의 사용과 작성을 피하세요.

초보자용:

- [프로젝트에 기여하기](https://www.jetbrains.com/help/idea/contribute-to-projects.html)
- [GitHub에서 프로젝트 클론하기](https://blog.jetbrains.com/idea/2020/10/clone-a-project-from-github/)

현상금:

일부 열린 이슈는 `bounty: 15€` 같은 태그/라벨이 붙어 있습니다 (목록 보기: [list](https://github.com/Osiris-Team/AutoPlug-Client/labels/bounty%3A%2015%E2%82%AC)), 이는 해당 이슈에 대한 풀 리퀘스트를 처음 생성하는 사람이
현상금(15€)을 받는다는 의미입니다. 구현한 수정/기능이 작동함을 입증하는 테스트가 반드시 포함되어야 합니다. 또한 지급은 PayPal을 통해서만 이루어지므로,
풀 리퀘스트를 커밋하는 프로필의 공개 GitHub 페이지에 PayPal 이메일 주소가 반드시 포함되어 있어야 합니다.
현상금 태그가 붙은 이슈에 커밋함으로써 이러한 조건에 동의하는 것으로 간주됩니다.

세부사항:

- [Java](https://java.com/)로 작성되었으며, [JDK 8](https://www.oracle.com/java/technologies/javase/javase-jdk8-downloads.html) 사용, [IntelliJ IDEA](https://www.jetbrains.com/idea/) 내에서 작업
- [1JPM](https://github.com/Osiris-Team/1JPM)으로 빌드, 명령어: `java ./src/main/java/JPM.java`
(직접 실행하려면 끝에 `andRun`을 붙이세요).

## 라이브러리

이 목록은 오래되었을 수 있습니다. 현재 의존성은 [build.gradle](/build.gradle) 파일을 확인하세요.
- [AutoPlug-Core](https://github.com/Osiris-Team/AutoPlug-Core)는 모든 AutoPlug 프로젝트에서 자주 사용하는 코드를 하나의 jar에 포함합니다.
- [Dream-Yaml](https://github.com/Osiris-Team/Dream-Yaml)는 YAML 파일 처리를 위해 사용됩니다.
- [Better-Thread](https://github.com/Osiris-Team/Better-Thread)는 '라이브 작업' 표시를 가능하게 합니다.
- 콘솔 색상 및 작업 표시를 위해 [Jansi](https://github.com/fusesource/jansi)와 [Jline](https://github.com/jline/jline3)를 사용합니다.
- [Zip4j](https://github.com/srikanth-lingala/zip4j)는 jar/zip 압축 해제 및 처리를 담당합니다.
- 서버 재시작은 [Quartz](http://www.quartz-scheduler.org/)로 예약됩니다.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---