<table><tr width=64px><td><img height=64px src="https://user-images.githubusercontent.com/526829/169241046-3087a41d-9606-43ab-90ae-ee0055bef039.png"/></td><td><h1>godot-version-manager</h1></td></tr></table>
  
간단한 앱으로 Godot 엔진의 모든 버전을 다운로드, 설치 및 관리하세요.

<img alt="screenshot with light theme" src="https://github.com/user-attachments/assets/5b504fa3-59ea-46c8-bb78-6a743759d984" />
<img alt="screenshot with dark theme" src="https://github.com/user-attachments/assets/08ff0100-fbd5-40be-a8a4-80bbb186d37e" />

## 설치
### 윈도우:
압축을 풀고 더블 클릭하세요. (Windows XP에서는 Powershell이 설치되어 있는지 확인하세요)
### 리눅스:
압축을 풀고 더블 클릭하세요. 다운로드한 버전의 압축 해제를 위해 `unzip`이 필요하며, 설치되어 있지 않으면 배포판 저장소에서 설치할 수 있습니다.
### OSX:
- 다운로드 후 자동으로 압축이 풀립니다.
- 서명되지 않은 바이너리는 신뢰되지 않는 것으로 표시되므로 `sudo xattr -r -d com.apple.quarantine path/to/Godot Version Manager.app` 명령어를 실행해야 합니다. 미리 빌드된 바이너리를 신뢰하지 않는 경우 직접 빌드해도 됩니다.
- Godot Version Manager.app을 더블 클릭하세요.

## 기능
- 드롭다운 메뉴에서 Godot의 모든 버전을 자동으로 다운로드 및 설치합니다. (압축 해제는 powershell 필요)
- 다운로드 드롭다운에서 알파, 베타, RC, 개발 버전을 표시하거나 숨길 수 있습니다.
- 파일 시스템 어디에든 직접 바이너리를 추가할 수 있습니다.
- 안정 버전, RC, 베타, 알파, 마스터 빌드를 쉽게 구분할 수 있는 컬러 아이콘 제공.
- 리스트 항목을 우클릭하여 삭제할 수 있습니다.
- 항목 순서를 드래그 앤 드롭으로 변경할 수 있습니다.
- project.godot 파일이나 Godot 프로젝트 폴더를 드래그 앤 드롭하여 특정 버전으로 프로젝트를 추가하고 실행할 수 있습니다.
- godotengine.org./news에서 뉴스 피드 제공.

## 자주 묻는 질문
**Q: 다운로드한 바이너리는 어디에 저장되나요?**

A: 플랫폼에 따라 달라지는 `user://versions`에 저장됩니다. 윈도우에서는 %appdata%/Godot/app_userdata/Godot Version Manager/versions 경로입니다.

**Q: Hourglass나 Godot Manager와는 어떻게 다른가요?**

A:
 - [Hourglass](https://hourglass.jwestman.net/)는 프로젝트 관리 지원이 더 뛰어나고 성숙한 프로젝트입니다. GVM의 유일한 장점은 공식 웹사이트에서 뉴스 스니펫도 다운로드한다는 점입니다 :)
 - [Godot Manager](https://github.com/eumario/godot-manager)도 꽤 성숙하고 기능이 풍부한 대안입니다.
 - [Godots](https://github.com/MakovWait/godots)는 2023년 8월에 나온 새 대안으로 많은 사람들이 좋아합니다.
 - [GodotEnv](https://github.com/chickensoft-games/GodotEnv)와 [godot-version-manager](https://github.com/gaheldev/godot-version-manager)는 CLI 전용 대안입니다.
 - [Godot Launcher](https://github.com/sebastianoboem/godot-launcher)는 확장과 캐시 관리를 지원하는 파이썬 기반 대안입니다.
 - [gdvm](https://github.com/adalinesimonian/gdvm)은 Rust로 제작된 또 다른 CLI 기반 버전 관리자입니다.

## LICENSE
MIT 라이선스(라이선스 파일 LICENSE.md 참조)
저작권 ©️2022 Lisandro Lorea 및 기여자

Lilita One 폰트 ©️2011 Juan Montoreano
<a href="https://www.flaticon.com/free-icons/exe" title="exe icons">Exe 아이콘은 Freepik - Flaticon에서 제작되었습니다</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-16

---