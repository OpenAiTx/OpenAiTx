<div align="center">
    <h1>GitQuill</h1>
    <img alt="Logo" src="https://raw.githubusercontent.com/adamsol/GitQuill/master/img/logo.jpg" width="200" />
    <h2>Git을 위한 크로스 플랫폼 GUI.</h2>
</div>

| ![](https://raw.githubusercontent.com/adamsol/GitQuill/master/img/screenshots/commit-history.png) | ![](https://raw.githubusercontent.com/adamsol/GitQuill/master/img/screenshots/file-diff.png) |
|-----------------------------------------|------------------------------------|


고유 기능
---------------

* diff 뷰에서 파일을 직접 편집할 수 있습니다.
* 파일 확장자별로 특정 문법 강조를 선택할 수 있습니다.
* 리베이스 도구로 과거 커밋을 빠르게 수정할 수 있습니다.
* 커밋 메시지에서 이슈 트래커로 연결을 설정할 수 있습니다.
* 클릭 한 번으로 Git 명령을 실행하는 버튼을 구성할 수 있습니다.


요구 사항
------------

* [Git](https://git-scm.com/) 2.23 이상
* [Node.js](https://nodejs.org/) 18 이상


설치
-----------

```sh
npm install
npm run build
npm start
```
노트
-----

* GitQuill은 전통적인 스태싱 대신 브랜치를 사용하여 작업 중인 내용을 저장/복원하는 맞춤 메커니즘을 가지고 있습니다. 이는 Git의 스태싱이 UI에 일관되게 통합하기 어려운 기술적 특성을 가지고 있기 때문입니다.
* 파일이 선택된 상태에서 리베이스를 시작하면, GitQuill은 인덱스에서 전체 커밋 내용을 되돌리되 작업 트리에는 그대로 유지하여 애플리케이션을 떠나지 않고도 파일을 편집할 수 있습니다.
* 충돌이 감지되면 GitQuill은 복잡한 처리를 초래하는 특수 저장소 상태를 피하기 위해 병합되지 않은 파일들을 자동으로 리셋합니다. 충돌 마커는 수동으로 해결할 수 있도록 그대로 남겨둡니다.
* GitQuill은 저장소 파일 변경을 감시하지 않습니다. 상태는 애플리케이션이 포커스를 받을 때나 UI에서 관련 작업을 수행할 때 새로 고쳐집니다.
* GitQuill은 `git` 명령어를 직접 호출합니다. 각 저장소의 로그 파일 `.git/.quill/app.log`에서 실행된 모든 작업을 확인할 수 있습니다.


설정
-------------

* 저장소별 구성 파일: `.git/.quill/config.json5`. 예:



  ```js
  {
      autolinks: [
          ['#(\\d+)', 'https://github.com/adamsol/GitQuill/issues/$1'],
      ],
      custom_actions: [
          { icon: 'mdi-download-outline', label: 'Pull', command: ['pull'] },
          { icon: 'mdi-upload-outline', label: 'Push', command: ['push'], click_twice: true },
      ],
  }
  ```

* 전역 자동 구성 파일(오픈 저장소, UI 레이아웃 등): Windows의 경우 `%AppData%/GitQuill/config.json`; 다른 플랫폼은 https://electronjs.org/docs/api/app#appgetpathname 참조.


기여하기
------------

프로젝트에 관심을 가져주셔서 감사합니다! 저는 일반적으로 풀 리퀘스트를 받지 않습니다. 기여하는 가장 좋은 방법은 [Issues](https://github.com/adamsol/GitQuill/issues)를 통해 버그를 신고하거나 기능을 제안하는 것입니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-14

---