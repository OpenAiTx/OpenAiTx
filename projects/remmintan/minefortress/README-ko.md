![당신의 Minecraft를 실시간 전략 게임으로 바꿔줄 모드](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/main-banner.png)
# MineFortress
[![프로젝트 지원하기](https://img.shields.io/badge/PATREON-SUPPORT_THE_PROJECT-f96854?style=for-the-badge&logo=patreon&logoColor=f96854&labelColor=052d49&color=f96854)](https://www.patreon.com/minefortress)
[![디스코드 참여하기](https://img.shields.io/discord/906943962659561515?style=for-the-badge&logo=discord&label=discord&color=5865F2)](https://discord.gg/6rt7VJxPcq)
[![웹사이트](https://img.shields.io/badge/website-minefortress-CC9966?style=for-the-badge)](https://minefortress.net/)

Minecraft를 RTS로 바꿔주는 모드입니다. 마을 지도자의 역할을 맡아 자원을 모으고, 집을 짓고, 전문가를 고용해 마을을 성장시키고 확장하며 이웃을 정복하세요! 1인칭 시점을 잊고 고전 RTS 게임처럼 마우스 포인터로 모든 것을 제어하세요.
## 링크
* **[웹사이트](https://minecraftfortress.org/)**
* **[Patreon](https://www.patreon.com/minefortress)**
* **[Modrinth](https://modrinth.com/mod/minefortress)**
* **[CurseForge](https://www.curseforge.com/minecraft/mc-mods/minefortress-rts)**
## 플레이어용
이 저장소는 개발자를 위한 것입니다. 모드를 플레이하고 싶다면 [CurseForge](https://www.curseforge.com/minecraft/mc-mods/minefortress-rts) 또는 [Modrinth](https://modrinth.com/mod/minefortress)에서 다운로드하세요.

모드를 실행하려면 Fabric Loader와 Fabric API가 필요합니다.
자세한 설치 방법은 [위키](https://wiki.minecraftfortress.org/wiki/Installation:Curseforge_Launcher)를 참고하세요.

## 개발자용
### 사전 준비 사항
프로젝트에 기여하고자 하는 모든 분들이 Java/Kotlin 개발에 익숙하다고 가정합니다.
기본 개발 환경 설치 방법에 대해서는 자세히 다루지 않지만, 프로젝트 작업에 필요한 모든 도구를 나열하겠습니다:
* Java 17 - 저는 [Adoptium](https://adoptium.net/) 빌드를 선호합니다.
* IntelliJ IDEA - 가장 편리한 개발 경험과 저와 동일한 결과를 얻기 위해 IntelliJ IDEA 사용을 권장합니다. [여기](https://www.jetbrains.com/idea/download/)에서 다운로드할 수 있습니다.
* Git - 저장소를 클론하고 변경사항을 커밋하기 위해 필요합니다. [여기](https://git-scm.com/downloads)에서 다운로드할 수 있습니다.

개발 환경 설정에 도움이 필요하면 다음 글을 읽어보세요: [IntelliJ IDEA를 이용한 Java 개발](https://www.jetbrains.com/help/idea/getting-started.html)

문의가 있으면 언제든지 [디스코드 서버](https://discord.gg/6rt7VJxPcq)에서 도움을 요청하세요.
### 시작하기 / 설치
1. Git을 사용하여 저장소를 클론합니다.
2. 프로젝트가 `minefortress`라는 이름의 디렉터리에 클론되었는지 확인하세요. 이것은 Gradle이 IDEA와 제대로 작동하기 위해 필요합니다.
3. IntelliJ IDEA에서 프로젝트를 엽니다.
4. Gradle이 프로젝트를 가져오는 작업이 끝날 때까지 기다립니다.
5. 실행 구성을 작동하게 해야 합니다. Fabric 플러그인이 자동으로 처리하지만 프로젝트를 닫아야 합니다.
6. 프로젝트를 닫았다가 다시 엽니다.
7. 새 실행 구성이 나타나야 합니다. 나타나지 않으면 IDEA를 재시작해 보세요.
8. 실행 구성 옆에 작은 X 표시가 있을 수 있습니다. 이는 Fabric 플러그인이 구성을 설정할 때 잘못된 모듈을 사용했다는 뜻입니다.
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-1.png)
9. 해결하려면 구성을 편집하고 `minefortress.main` 모듈 클래스패스 드롭다운을 선택하세요.
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-2.png)
10. 이제 `Minecraft Client` 구성을 사용하여 프로젝트를 실행할 수 있습니다.
![](https://raw.githubusercontent.com/remmintan/minefortress/master/docs/run-configurations-3.png)

### 기여하기
모든 도움은 매우 환영합니다! 프로젝트에 기여하고 싶다면 다음 단계를 따라주세요:
1. 저장소를 포크하세요.
2. `master` 브랜치에서 새 브랜치를 만드세요.
3. 변경사항을 만드세요.
4. 변경사항을 커밋하고 포크한 저장소에 푸시하세요.
5. 이 저장소의 `master` 브랜치로 풀 리퀘스트를 만드세요.

기여 가이드는 아직 없지만, 작업할 내용을 찾으려면 [이슈](https://github.com/remmintan/minefortress/issues)를 확인할 수 있습니다.
버그와 기능 요청은 이슈에 모으려고 하지만, 질문이 있으면 언제든지 [디스코드 서버](https://discord.gg/6rt7VJxPcq)에서 물어보세요.

또한 버그를 찾거나 기능 요청이 있으면 자유롭게 이슈를 생성하세요.

시간이 지나면서 기여 가이드와 초보자에게 좋은 이슈 목록을 만들어 보겠습니다.

## 라이선스
이 프로젝트는 MIT 라이선스 하에 배포됩니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하세요.

## 후원
오픈 소스 개발을 지원하려면 프로젝트에 후원해 주세요. 다음 방법으로 후원할 수 있습니다:
* **[Patreon](https://www.patreon.com/minefortress)**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---