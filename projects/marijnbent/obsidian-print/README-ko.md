# 인쇄

Print 플러그인은 Obsidian 작업 공간에 인쇄 도구를 추가합니다. 현재 노트, 텍스트 선택 영역 또는 폴더 내 모든 노트를 명령 팔레트, 프린터 리본, 또는 컨텍스트 메뉴에서 인쇄할 수 있습니다. 이 플러그인이 마음에 들거나 유용하다고 생각되면 GitHub에서 [별점 ![GitHub Repo stars](https://img.shields.io/github/stars/marijnbent/obsidian-print?style=social)](https://github.com/marijnbent/obsidian-print)을 주는 것을 고려해 주세요.

https://github.com/user-attachments/assets/5882f08c-19e6-46da-b808-608b95376979

*플러그인 사용 화면 녹화.*

## 기능

- **현재 노트 인쇄**: 명령 팔레트, 프린터 리본 또는 노트를 우클릭하여 인쇄를 실행합니다.
- **선택 영역 인쇄**: 활성 편집기에서 선택한 텍스트만 인쇄합니다.
- **폴더 내 모든 노트 인쇄**: 폴더를 우클릭하거나 명령 팔레트를 사용하여 해당 폴더의 모든 마크다운 노트를 인쇄합니다.

더 빠른 접근을 위해 인쇄 작업에 바로가기를 추가할 수도 있습니다.

| | |
|:------:|:-------------------------:|
|![image](https://github.com/user-attachments/assets/8ba2959c-20a2-4cab-8ae7-c2f5f2475217)|![image](https://github.com/user-attachments/assets/ddb54bd0-4b58-410f-9d69-0f6a58b2ddfd)

## 지원

이 플러그인이 마음에 든다면 저의 작업과 열정을 응원해 주시고 [https://www.buymeacoffee.com/marijnbent](https://www.buymeacoffee.com/marijnbent)에서 커피 한 잔을 사주세요.

<a href="https://www.buymeacoffee.com/marijnbent"><img src="https://img.buymeacoffee.com/button-api/?text=Buy me a coffee&emoji=&slug=marijnbent&button_colour=6495ED&font_colour=ffffff&font_family=Lato&outline_colour=000000&coffee_colour=FFDD00"></a>

## 시작하기

### 커뮤니티 플러그인 스토어에서 설치하기

1. Obsidian을 열고 **설정** > **커뮤니티 플러그인**으로 이동합니다.
2. **찾아보기**를 클릭하고 **Print**를 검색합니다.
3. **설치**를 클릭하여 플러그인을 Obsidian에 추가합니다.
4. 설치가 완료되면 플러그인을 활성화하고 필요에 따라 설정 페이지로 이동합니다.

자주 인쇄한다면 하나 이상의 인쇄 명령에 바로가기를 추가하는 것이 좋습니다. **설정** > **단축키**로 가서 `print`를 검색한 후 원하는 단축키를 지정하세요.

## 설정


- **노트 제목 인쇄**: 인쇄물에 노트 제목을 포함합니다.
- **속성 인쇄**: 인쇄된 노트 상단에 노트 속성/프런트매터를 포함합니다.
- **글꼴 크기 및 제목 크기**: **스타일 정규화**가 활성화되면 본문 텍스트와 제목 크기를 조절합니다.
- **폴더 노트 병합**: 폴더 내 모든 노트를 인쇄할 때 노트 사이의 페이지 구분을 제거합니다.
- **수평선 페이지 구분 처리**: `---` 구분선을 인쇄 페이지 구분으로 해석합니다.
- **디버그 모드**: 생성된 HTML 및 CSS를 별도의 검사 창에서 열어 스타일 문제를 해결할 수 있습니다.
- **노트 `cssclasses` 상속**: Obsidian 노트의 `cssclasses`를 인쇄 출력에 적용하여 노트별 인쇄 CSS가 유지되도록 합니다.
- **스타일 정규화**: 활성 Obsidian 테마 스타일 대신 중립적인 내장 인쇄 스타일을 사용합니다.
- **사용자 정의 CSS**: 고급 설정에서 Obsidian의 CSS 스니펫 폴더에 있는 `print.css` 스니펫을 사용 가능할 때 활성화합니다.

![image](https://github.com/user-attachments/assets/2ffed185-cc8f-43d9-8444-7cb9657d61f7)

## CSS 사용자 정의

설정에서 제목을 선택적으로 숨길 수 있으며, **스타일 정규화**가 활성화되면 본문 텍스트 및 제목의 글꼴 크기를 조절할 수도 있습니다.

인쇄된 노트의 외관을 더 세밀하게 조정하려면 `.obsidian/snippets`에 `print.css` 스니펫을 생성하고 Obsidian이 이를 감지하면 플러그인 설정에서 활성화할 수 있습니다. 인쇄된 문서 본문은 `obsidian-print` 클래스를 포함합니다. CSS를 `@media print`로 감싸거나 프린트 전용 CSS에 `.obsidian-print` 접두사를 붙여 인쇄된 내용에만 적용되도록 하십시오. **노트 `cssclasses` 상속**을 활성화하면 노트별 Obsidian 클래스도 인쇄 출력에 반영됩니다. 코드 블록과 MathJax의 테마 스타일 역시 필요 시 인쇄 문서에 적용되지만, **스타일 정규화**를 활성화하면 플러그인의 중립 스타일로 대체됩니다. 기본 스타일은 [이 파일](/styles.css)에서 확인할 수 있습니다. 각 개별 노트는 `obsidian-print-note` 클래스를 포함합니다.

스타일 문제가 발생하면 디버그 모드를 켜서 생성된 인쇄 문서에 대한 검사 창을 열어보십시오.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-08

---