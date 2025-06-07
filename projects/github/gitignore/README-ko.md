# `.gitignore` 템플릿 모음

이 문서는 GitHub의 [`.gitignore`][man] 파일 템플릿 모음입니다.  
이 목록은 GitHub.com 인터페이스에서 새로운 저장소와 파일을 만들 때 사용할 수 있는 `.gitignore` 템플릿 선택기에 활용됩니다.

`.gitignore` 파일이 어떻게 동작하는지, 그리고 어떻게 사용하는지에 대한 자세한 정보는 아래 자료들을 참고하세요.

- [Pro Git][progit] 도서의 [파일 무시하기 장][chapter]
- GitHub 도움말 사이트의 [파일 무시하기 관련 글][help]
- [gitignore(5)][man] 매뉴얼 페이지

[man]: https://git-scm.com/docs/gitignore
[help]: https://help.github.com/articles/ignoring-files
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring
[progit]: https://git-scm.com/book

## 폴더 구조

다음과 같이 구성된 템플릿 모음을 지원합니다:

- 루트 폴더에는 많이 사용되는 템플릿이 포함되어 있어, 인기 있는 프로그래밍 언어와 기술을 사용하는 분들이 쉽게 시작할 수 있습니다. 이 템플릿들은 의미 있는 규칙 모음을 정의하여, 중요하지 않은 파일이 저장소에 커밋되는 것을 방지합니다.
- [`Global`](./Global) 폴더에는 다양한 에디터, 도구, 운영체제에서 사용할 수 있는 템플릿이 들어 있습니다. 이를 [글로벌 템플릿에 추가](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer)하거나, 프로젝트별 템플릿에 병합하여 영구적으로 사용할 것을 권장합니다.
- [`community`](./community) 폴더에는 아직 메인스트림 템플릿에 속하지 않은 인기 있는 언어, 도구, 프로젝트에 특화된 템플릿이 있습니다. 프레임워크나 도구를 채택할 경우, 프로젝트별 템플릿에 추가하여 사용하세요.

## 좋은 템플릿의 조건

템플릿은 특정 프로그래밍 언어, 프레임워크, 도구, 환경에서 Git 저장소가 잘 동작할 수 있도록 규칙들을 포함해야 합니다.

이 상황에 맞는 유용한 규칙의 소량 모음을 선별하는 것이 불가능하다면, 해당 템플릿은 이 컬렉션에 적합하지 않습니다.

특정 소프트웨어(예: PHP 프레임워크)의 버전에서 설치되는 파일 목록만 나열된 템플릿이라면, `community` 디렉터리 아래에 둘 수 있습니다. 자세한 내용은 [버전별 템플릿](#versioned-templates)을 참고하세요.

규칙의 수가 적거나, 널리 사용되지 않는 기술을 지원하고 싶지만 다른 사람에게도 도움이 된다고 생각된다면, [특수화된 템플릿](#specialized-templates) 섹션을 참고하세요.

템플릿이 중요하거나 눈에 띄는 경우 Pull Request를 열 때 상세한 설명을 남겨주세요. 바로 승인되지 않을 수 있으나, 관심이 모이면 루트로 승격될 수 있습니다.

또한 모든 도구를 다 다룰 수는 없다는 점을 이해해 주세요. 우리의 목표는 _가장 일반적이고 유용한_ 템플릿을 선별하는 것이지, 가능한 모든 프로젝트를 다루는 것이 아닙니다. 당신의 언어, 도구, 프로젝트가 포함되지 않더라도 가치가 없어서가 아닙니다.

## 기여 가이드라인

이 프로젝트를 개선하는 데 도움을 주시면 감사하겠습니다. 컬렉션의 품질 유지를 위해 다음 가이드라인을 따라주시면 좋겠습니다.

- **애플리케이션 또는 프로젝트의 홈페이지 링크를 제공해주세요.** 매우 유명하지 않다면, 변경사항이 적용되는 언어, 프레임워크, 에디터, 앱, 프로젝트를 관리자가 모를 수도 있습니다.

- **변경사항을 뒷받침하는 문서의 링크를 제공해주세요.** 무시되는 파일을 언급하는 공식 문서가 가장 좋습니다. 문서가 없다면, 무시되는 파일이 무엇을 위해 사용되는지 최대한 설명해주세요.

- **왜 변경을 하는지 설명해주세요.** 자명하더라도, 변경 또는 추가가 필요한 이유를 한두 문장으로 설명해주세요. 특히, 이 변경이 해당 기술을 사용하는 _모든 사람_ 에게 왜 필요한지 명확히 해주시면 좋습니다.

- **변경 범위를 고려해주세요.** 특정 언어나 프레임워크에 특화된 변경이라면, 에디터, 도구, 운영체제 템플릿이 아니라 해당 언어나 프레임워크의 템플릿에 변경사항을 적용해주세요.

- **Pull Request 당 _한 개의 템플릿_ 만 수정해주세요.** 이렇게 하면 PR과 피드백이 특정 프로젝트나 기술에 집중될 수 있습니다.

변경사항을 잘 이해할 수 있도록 도와주신다면, 기여가 더 빨리 수락될 가능성이 높아집니다.

## 버전별 템플릿

일부 템플릿은 버전마다 크게 달라질 수 있으므로, 다음 절차를 따라야 합니다:

- 루트에 있는 템플릿은 현재 지원되는 최신 버전이어야 합니다.
- 루트의 템플릿 파일명에는 버전을 포함하지 않습니다(즉, "evergreen").
- 이전 버전의 템플릿은 `community/`에 위치합니다.
- 이전 버전 템플릿은 파일명에 버전 정보를 포함합니다(가독성 확보 목적).

이렇게 하면 사용자는 항상 최신 버전을 사용할 수 있고, 관리자는 여전히 구버전을 지원할 수 있습니다.

## 특수화된 템플릿

메인스트림은 아니지만 기여하고 싶은 템플릿이 있다면, `community` 디렉터리의 적합한 폴더 아래에 추가하는 것을 고려하세요.

특수화된 템플릿의 규칙은 해당 프레임워크나 도구에 특화되어야 하며, 추가로 필요한 템플릿은 파일 상단 주석에 언급해주세요.

예를 들어, 아래와 같이 `community/DotNet/InforCRM.gitignore`에 위치할 수 있습니다:

```
# InforCRM(구 SalesLogix)용 gitignore 템플릿
# 웹사이트: https://www.infor.com/product-summary/cx/infor-crm/
#
# 권장: VisualStudio.gitignore

# 자동 생성되는 모델 파일 무시
ModelIndex.xml
ExportedFiles.xml

# 배포 파일 무시
[Mm]odel/[Dd]eployment

# 포털 SupportFiles 강제 포함
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## 기여 워크플로우

이 프로젝트에 변경을 제안하는 방법은 다음과 같습니다:

1. [프로젝트를 포크][fork]합니다.
2. [변경사항에 대한 브랜치][branch]를 만듭니다.
3. 포크한 저장소에 변경을 적용합니다.
4. 포크한 브랜치에서 본 저장소의 `main` 브랜치로 [Pull Request를 전송][pr]합니다.

웹 기반 인터페이스를 이용해도 괜찮으며, 이 경우 자동으로 포크 및 Pull Request 생성 안내가 제공됩니다.

[fork]: https://help.github.com/articles/fork-a-repo/
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository
[pr]: https://help.github.com/articles/using-pull-requests/

## 라이선스

[CC0-1.0](./LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---