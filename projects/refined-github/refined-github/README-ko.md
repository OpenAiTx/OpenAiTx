# <img src="https://raw.githubusercontent.com/refined-github/refined-github/main/source/icon.png" width="45" align="left"> Refined GitHub

> GitHub 인터페이스를 간소화하고 유용한 기능을 추가하는 브라우저 확장 프로그램

우리는 GitHub를 많이 사용하면서 수정하고 싶은 여러 불편함을 발견했습니다. 그래서 여기에서 다양한 개선 사항을 시도합니다.

우리의 바람은 GitHub가 이러한 꼭 필요한 개선 사항 중 일부를 채택하는 것입니다. 만약 이 개선 사항들이 마음에 든다면, [GitHub feedback](https://github.com/github-community/community/discussions)에서 논의를 시작하거나 [GitHub support](https://support.github.com/request)에 연락해 채택을 요청해 주세요.

GitHub Enterprise도 지원합니다: [활성화 방법](https://fregante.github.io/webext-permission-toggle/?name=Refined%20GitHub&icon=https%3A%2F%2Fraw.githubusercontent.com%2Frefined-github%2Frefined-github%2Fmain%2Fsource%2Ficon.png). <!-- icon.png renders best -->

*GITHUB 및 REFINED GITHUB 상표는 GitHub, Inc.의 소유이며, 라이선스 하에 사용됩니다.*

## 설치

[link-chrome]: https://chrome.google.com/webstore/detail/refined-github/hlepfoohegkhhmjieoechaddaejaokhf 'Chrome 웹 스토어에 게시된 버전'
[link-firefox]: https://addons.mozilla.org/firefox/addon/refined-github-/ 'Mozilla Add-ons에 게시된 버전'
[link-safari]: https://apps.apple.com/app/id1519867270 'Mac App Store에 게시된 버전'

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/chrome/chrome.svg" width="48" alt="Chrome" valign="middle">][link-chrome] [<img valign="middle" src="https://img.shields.io/chrome-web-store/v/hlepfoohegkhhmjieoechaddaejaokhf.svg?label=%20">][link-chrome] 및 기타 Chromium 브라우저

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/firefox/firefox.svg" width="48" alt="Firefox" valign="middle">][link-firefox] [<img valign="middle" src="https://img.shields.io/amo/v/refined-github-.svg?label=%20">][link-firefox] Firefox Android 포함

[<img src="https://raw.githubusercontent.com/alrra/browser-logos/90fdf03c/src/safari/safari_128x128.png" width="48" alt="Safari" valign="middle">][link-safari] [<img valign="middle" src="https://img.shields.io/itunes/v/1519867270.svg?label=%20">][link-safari] Mac, iOS, iPadOS 지원

[<img src="https://raw.githubusercontent.com/iamcal/emoji-data/08ec822c38e0b7a6fea0b92a9c42e02b6ba24a84/img-apple-160/1f99a.png" width="48" valign="middle">](https://github.com/sponsors/fregante) _Refined GitHub를 좋아한다면, 유지관리자 [@fregante](https://twitter.com/fregante)를 [후원하거나 고용](https://github.com/sponsors/fregante)하는 것을 고려해 주세요._


<div align="center">

<table><tr><td width="550"><div align="center">
	<p><sup><a href="https://github.com/sponsors/fregante">@fregante</a>의 오픈 소스 작업은 커뮤니티의 지원을 받고 있습니다.<br>특별한 감사의 말씀을 전합니다:</sup></p>
	<p><a href="https://www.prisma.io/">
		<picture>
			<source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/f781e9a3-2c03-4334-b234-8f20600ca45f">
			<img width="250" alt="Prisma.io" src=https://user-images.githubusercontent.com/1402241/205429539-4549ea71-f26c-432a-aaef-db430c435718.svg">
		</picture>
		<br><sup>직관적인 데이터 모델, 자동 마이그레이션, 타입 안전성 및 자동 완성을 제공하는 차세대 Node.js 및 TypeScript ORM.</sup>
	</a></p>
	<p><a href="https://frappe.io/">
		<picture>
			<source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/534638ee-7849-4e42-a847-b50be5d1e2f0">
			<img width="190" alt="Frappe" src="https://github.com/user-attachments/assets/1f853047-b30c-41de-acf9-4daefb6a6fc3">
		</picture>
		<br><sup>완벽한 기능의 로우코드 웹 프레임워크 및 세계적인 수준의 무료 오픈 소스 소프트웨어.</sup>
	</a></p>
</table>

</div>

---

## 주요 기능 🔥

<table>
	<tr>
		<th width="50%">
			<p><a title="show-whitespace"></a> 공백 문자를 시각적으로 표시
			<p><img src="https://user-images.githubusercontent.com/1402241/61187598-f9118380-a6a5-11e9-985a-990a7f798805.png">
		<th width="50%">
			<p><a title="resolve-conflicts"></a> 원클릭 머지 충돌 해결 기능 추가
			<p><img src="https://user-images.githubusercontent.com/1402241/54978791-45906080-4fdc-11e9-8fe1-45374f8ff636.png">
	<tr>
		<th width="50%">
			<p><a title="pr-base-commit"></a> PR 헤드 브랜치가 얼마나 뒤처져 있는지 및 베이스 커밋 정보 표시
			<p><img src="https://user-images.githubusercontent.com/1402241/234492651-b54bf9ba-c218-4a30-bed4-f85a7f037297.png">
		<th width="50%">
			<p><a title="conversation-activity-filter"></a> 이슈와 PR에서 댓글 또는 미해결 댓글만 남기고 모든 이벤트 숨기기 가능
			<p><img src="https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252116522-053bce84-5c55-477b-8cc2-42a48104fb02.png">
	<tr>
		<th width="50%">
			<p><a title="status-subscription"></a> 이슈의 열림/닫힘 이벤트를 한 번에 구독 가능
			<p><img src="https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/238186901-cbc98b51-d173-40c6-b21e-5f0bae3d800c.png">
		<th width="50%">
			<p><a title="default-branch-button"></a> 디렉터리 및 파일 목록에 기본 브랜치로 이동 링크 추가
			<p><img src="https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252176294-9130783c-51aa-4df9-9c35-9b87c179199a.png">
	<tr>
		<th width="50%">
			<p><a title="restore-file"></a> PR에서 파일의 모든 변경 사항을 되돌리는 버튼 추가
			<p><img src="https://user-images.githubusercontent.com/1402241/236630610-e11a64f6-5e70-4353-89b8-39aae830dd16.gif">
		<th width="50%">
			<p><a title="select-notifications"></a> 알림을 유형 및 상태별로 선택
			<p><img src="https://user-images.githubusercontent.com/83146190/252175851-e0826d3b-1990-4bff-ba09-71892463818e.gif">
</table>

### 저장소(Repositories)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

- [](# "ci-link") 🔥 [저장소 이름 옆에 빌드/CI 상태 아이콘 추가](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/237923995-5e14a272-0bf2-4fe4-b409-8c05378aa4fd.png)
- [](# "more-dropdown-links") [저장소 내비게이션 드롭다운에 유용한 링크 추가](https://user-images.githubusercontent.com/16872793/124681432-856e6f80-de96-11eb-89c9-6d78e8ae4329.png)
- [](# "swap-branches-on-compare") [브랜치 비교 뷰에서 브랜치 스왑 링크 추가](https://user-images.githubusercontent.com/44045911/230370539-ebc94246-864f-48f2-85fa-7318fc1f6d71.png)
- [](# "repo-age") [사이드바에 저장소 생성 연도 표시](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252176778-f8260312-d0dc-41b5-a4d1-ca680208d347.png)
- [](# "show-open-prs-of-forks") [포크 저장소에서, 원본 저장소로 향하는 오픈 PR 개수 표시](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252177140-94165582-628b-45b6-9a62-faf0c7fc2335.png)
- [](# "clean-repo-filelist-actions") [저장소 파일 목록의 일부 버튼을 더 간결하게 만들어 공간 확보](https://user-images.githubusercontent.com/1402241/108955170-52d48080-7633-11eb-8979-67e0d3a53f16.png)
- [](# "new-repo-disable-projects-and-wikis") [저장소 생성 시 프로젝트와 위키 자동 비활성화](https://user-images.githubusercontent.com/1402241/177040449-73fde2a5-98e2-4583-8f32-905d1c4bfd20.png)
- [](# "sticky-sidebar") [저장소, 이슈, PR에서 사이드바를 화면에 고정(뷰포트에 맞는 경우)](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252179311-ea6d42dc-1525-401a-bc4d-404cf8fa1785.gif)
- [](# "link-to-github-io") [사용자의 github.io 웹사이트로 이동하는 링크 추가](https://user-images.githubusercontent.com/34235681/152473104-c4723999-9239-48fd-baee-273b01c4eb87.png)
- [](# "github-actions-indicators") [워크플로 사이드바에서 수동 트리거 가능 여부 및 예약 실행 시각 표시](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252181237-a1d809b1-e5d4-4747-9654-7dde5ab5c61a.png)
- [](# "quick-repo-deletion") [저장소 삭제 간소화. 별점 0인 포크에 "Delete fork" 버튼 추가. <kbd>shift</kbd> <kbd>alt</kbd> 클릭으로 2번 클릭만에 삭제 가능.](https://github.com/user-attachments/assets/9e05ec18-680d-4fbd-acbd-2b5b3505c5b5)
- [](# "archive-forks-link") [아카이브된 저장소의 포크 찾기 도움](https://user-images.githubusercontent.com/1402241/230362566-12493c80-bffe-4c7a-b9ba-4a11b1358ab0.png)
- [](# "clean-repo-tabs") ["Security", "Insights" 탭을 내비게이션 드롭다운으로 이동, "Projects", "Actions", "Wiki" 탭도 비어있거나 미사용 시 이동](https://user-images.githubusercontent.com/16872793/124681343-4a6c3c00-de96-11eb-9055-a8fc551e6eb8.png)
- [](# "repo-avatars") [공개 저장소 헤더에 프로필 사진 추가](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/255323568-aee4d90e-844e-41e8-880a-ce466826516c.png)
- [](# "quick-new-issue") [저장소 내 어디에서나 이슈 생성 링크 추가](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/274816033-820ec518-049d-4248-9f8a-27b9423e350b.png)
- [](# "small-user-avatars") [이슈/PR 목록 및 멘션에서 사용자 이름 옆에 작은 아바타 표시](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/271184107-24ec471e-54d1-434a-a5f2-615902d2cad9.png)
- [](# "unreleased-commits") 🔥 [저장소의 최신 버전을 보고 있는지, 미배포 커밋이 있는지 여부 표시](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/267236196-8564c193-a3c7-4248-9735-54749c1990c7.png)
- [](# "action-pr-link") 🔥 [워크플로를 실행한 PR로 돌아가는 링크 추가](https://github-production-user-asset-6210df.s3.amazonaws.com/50487467/241645264-076a0137-36a2-4fd0-a66e-735ef3b3a563.png)
- [](# "mobile-tabs") [모바일에서 탭을 더 간결하게 표시하여 더 많은 탭이 보이도록 함](https://user-images.githubusercontent.com/1402241/245446231-28f44b59-0151-4986-8cb9-05b5645592d8.png)
- [](# "repo-header-info") [저장소가 포크인지 여부와 별 개수를 헤더에 표시](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/267216946-404d79ab-46d7-4bc8-ba88-ae8f8029150d.png)
- [](# "visit-tag") [특정 태그의 파일을 탐색할 때, 해당 릴리스/태그로 이동하는 링크 추가](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/285123739-e5f4fa0a-3f48-49ef-9b87-2fd6f183c923.png)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### 파일 관리

- [](# "download-folder-button") [전체 폴더 다운로드 버튼 추가](https://user-images.githubusercontent.com/46634000/158347358-49234bb8-b9e6-41be-92ed-c0c0233cbad2.png), via https://download-directory.github.io.
- [](# "quick-file-edit") [저장소 파일 목록에서 파일 편집 버튼 추가](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252182890-081975f4-f041-4ba5-ae48-d52cb0796543.png)
- [](# "repo-wide-file-finder") 저장소 전체에서 파일 찾기 단축키(<kbd>t</kbd>) 사용 가능
- [](# "show-associated-branch-prs-on-fork") [포크 저장소의 브랜치에 연결된 PR 표시](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/260873542-2a7fc7a2-231f-4f2e-9c7e-272d894de4c6.png)
- [](# "html-preview-link") [HTML 파일 미리보기 링크 추가](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/260874191-69d386a0-7c1f-42ae-84fd-4f67f90982da.png)
- [](# "file-age-color") [파일 목록에서 최근 수정된 항목을 강조 표시](https://user-images.githubusercontent.com/1402241/218314631-1442cc89-3616-40fc-abe2-9ba3d3697b6a.png)
- [](# "previous-version") [한 번의 클릭으로 파일의 이전 버전 보기](https://github.com/refined-github/refined-github/assets/1402241/bc82cc77-bde2-4683-98a6-012c87b4a319)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### 코드

- [](# "linkify-code") [코드 및 이슈/PR 제목의 이슈/PR 참조 및 URL 자동 링크화](https://cloud.githubusercontent.com/assets/170270/25370217/61718820-29b3-11e7-89c5-2959eaf8cac8.png)
- [](# "copy-on-y") [<kbd>y</kbd> 단축키](https://help.github.com/articles/getting-permanent-links-to-files/)를 사용 시 퍼머링크 복사 기능 추가
- [](# "linkify-symbolic-links") [심볼릭 링크 파일 자동 링크화](https://user-images.githubusercontent.com/1402241/62036664-6d0e6880-b21c-11e9-9270-4ae30cc10de2.png)
- [](# "list-prs-for-file") [현재 파일이 오픈 PR에서 변경 중일 때 알림 표시](https://user-images.githubusercontent.com/1402241/234559302-b9911ac2-a1bb-4f8a-8e88-078d631cde18.png)
- [](# "refined-github.css") [GitHub가 사용자 환경설정을 따르지 않을 때 탭 크기를 8칸 대신 4칸으로 축소](https://cloud.githubusercontent.com/assets/170270/14170088/d3be931e-f755-11e5-8edf-c5f864336382.png) ([환경설정 보기](https://github.com/settings/appearance))
- [](# "esc-to-deselect-line") [현재 라인 선택 해제용 단축키 <kbd>esc</kbd> 추가](https://github.com/refined-github/refined-github/issues/1590)
- [](# "vertical-front-matter") [Markdown 프론트 매터를 수직 표로 표시](https://user-images.githubusercontent.com/44045911/87251695-26069b00-c4a0-11ea-9077-53ce366490ed.png)
- [](# "list-prs-for-branch") [브랜치 커밋 목록에서, 해당 브랜치에 영향을 주는 PR 표시](https://user-images.githubusercontent.com/16872793/119760295-b8751a80-be77-11eb-87da-91d0c403bb49.png)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### 댓글 작성

- [](# "tab-to-indent") 🔥 [댓글 입력란에서 <kbd>tab</kbd> 및 <kbd>shift</kbd> <kbd>tab</kbd>으로 들여쓰기 가능](https://user-images.githubusercontent.com/1402241/33802977-beb8497c-ddbf-11e7-899c-698d89298de4.gif)
- [](# "collapsible-content-button") [텍스트 에디터에 접을 수 있는 콘텐츠(<details> 태그) 삽입 버튼 추가](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/260875648-bd495d27-4cd1-4190-bcc5-b8b476f07d39.png)
- [](# "fit-textareas") 🔥 [댓글 입력란의 크기를 자동 조절해 스크롤 바가 나타나지 않도록 함](https://user-images.githubusercontent.com/1402241/54336211-66fd5e00-4666-11e9-9c5e-111fccab004d.gif)
- [](# "quick-comment-edit") [드롭다운 열 필요 없이 한 번의 클릭으로 댓글 수정 가능](https://user-images.githubusercontent.com/46634000/162252055-54750c89-0ddc-487a-b4ad-cec6009d9870.png)
- [](# "one-key-formatting") [선택한 텍스트에 Markdown 기호를 누르면 텍스트를 감싸줌(`[` `` ` `` `'` `"` `*` `~` `_`)](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261155564-e7aabd0e-b14b-4fe6-b379-62e7419c43f8.gif)
- [](# "clean-rich-text-editor") [불필요한 댓글 입력란 툴팁 및 툴바 항목 숨김](https://user-images.githubusercontent.com/46634000/158201651-7364aba7-f9d0-4a51-89c4-2ced0cc34e48.png) (각 항목은 단축키 있음)
- [](# "quick-mention") [이슈/PR에서 사용자를 `@멘션`하는 버튼 추가](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261158402-5a79cc3e-4331-475f-8063-5ed81fefcf10.gif)
- [](# "table-input") [텍스트 에디터에 간단한 HTML 테이블 삽입 버튼 추가](https://user-images.githubusercontent.com/46634000/94559114-09892c00-0261-11eb-8fb0-c5a85ea76b6f.gif)
- [](# "unfinished-comments") [숨겨진 탭에 미완성 댓글이 있을 때 사용자에게 알림](https://user-images.githubusercontent.com/1402241/97792086-423d5d80-1b9f-11eb-9a3a-daf716d10b0e.gif)
- [](# "quick-review-comment-deletion") [리뷰 댓글을 수정할 때 한 번의 클릭으로 삭제 버튼 추가](https://user-images.githubusercontent.com/46634000/115445792-9fdd6900-a216-11eb-9ba3-6dab4d2f9d32.png)
- [](# "avoid-accidental-submissions") [제목 필드에서 <kbd>enter</kbd>로 제출하는 단축키를 비활성화하여 실수로 제출되는 것을 방지. <kbd>ctrl</kbd> <kbd>enter</kbd> 사용](https://user-images.githubusercontent.com/723651/125863341-6cf0bce0-f120-4cec-ac1f-1ce35920e7a7.gif)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### 댓글 읽기

- [](# "reactions-avatars") 🔥 [댓글에 반응한 사람이 누구인지 보여주는 아바타 추가](https://user-images.githubusercontent.com/1402241/236628453-8b646178-b838-44a3-9541-0a9b5f54a84a.png)
- [](# "embed-gist-inline") [댓글에서 링크된 짧은 gist를 인라인으로 임베드](https://user-images.githubusercontent.com/1402241/152117903-80d784d5-4f43-4786-bc4c-d4993aec5c79.png)
- [](# "comments-time-machine-links") [각 댓글 시점의 [저장소](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252749373-9313f1d9-3d92-44a2-a1d1-2b49a29e6a5c.png) 및 [연결된 파일](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252749616-085103bf-17be-4a7d-b63c-aa5003de6dff.png) 탐색 링크 추가]
- [](# "show-names") [사용자 이름 옆에 실제 이름 표시](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252756294-94785dc2-423e-498c-939a-359a012036e0.png)
- [](# "shorten-links") [URL 및 저장소 URL을 "_user/repo/.file@`d71718d`" 형태의 읽기 쉬운 참조로 단축](https://user-images.githubusercontent.com/1402241/27252232-8fdf8ed0-538b-11e7-8f19-12d317c9cd32.png)
- [](# "preview-hidden-comments") 🔥 [숨겨진 댓글을 인라인으로 미리보기](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/262556553-ca04b870-9adb-4a8c-a6d0-6238863948be.png)
- [](# "highest-rated-comment") 🔥 [이슈에서 가장 유용한 댓글을 강조 표시](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252763905-a0c3b074-b032-4d97-946e-328e8a6fb2da.png)
- [](# "hide-low-quality-comments") [리액션 댓글("+1", "👍", …) 숨김](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/258220965-4743b9b9-2aef-41b3-a905-ccf8d7beb74e.png) (유지관리자의 댓글 제외) [언제든 다시 표시 가능](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/258221444-e43f2486-5ba1-40b5-aa1d-d9d5768e8c0a.png)
- [](# "scrollable-areas") [높이가 높은 코드 블록과 인용문의 높이 제한](https://github.com/refined-github/refined-github/issues/1123)
- [](# "quick-comment-hiding") [댓글 숨기기 UI 단순화](https://user-images.githubusercontent.com/1402241/43039221-1ddc91f6-8d29-11e8-9ed4-93459191a510.gif)
- [](# "open-issue-to-latest-comment") [이슈 목록의 "댓글" 아이콘을 최신 댓글로 이동하도록 변경](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261159396-0610574b-ab1f-42fb-813f-ee7310a1e5b6.png)
- [](# "expand-all-hidden-comments") [긴 대화에서 GitHub가 "N개의 항목이 숨겨짐. 더 보기..."로 가린 댓글을 alt-클릭 시 최대 200개까지 한 번에 로드(기본 60개)](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261160123-9c4f894b-38c0-446f-af50-9beca7ff1f74.png)
- [](# "keyboard-navigation") [이슈, PR 대화, PR 파일 목록에서 <kbd>j</kbd>로 아래, <kbd>k</kbd>로 위 댓글/파일로 이동 단축키 추가](https://user-images.githubusercontent.com/1402241/86573176-48665900-bf74-11ea-8996-a5c46cb7bdfd.gif)
- [](# "comment-excess") [긴 이슈의 헤더에 숨겨진 댓글이 있음을 알리고 Cmd+F/Ctrl+F로 바로 스크롤](https://github.com/refined-github/refined-github/assets/1402241/4e4660f9-c987-4b0d-82ca-56ef29952c31)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### 대화(Conversations)

- [](# "open-all-conversations") [모든 보이는 이슈/PR을 한 번에 열기](https://user-images.githubusercontent.com/46634000/110980658-5face000-8366-11eb-88f9-0cc94f75ce57.gif)
- [](# "sticky-conversation-list-toolbar") [이슈/PR 목록의 필터 툴바 고정](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261164103-875b70f7-5adc-4bb2-b158-8d5231d47da2.gif)
- [](# "conversation-authors") [내가 열었거나 현재 저장소 협업자가 연 이슈/PR 강조](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/252804821-a412e05c-fb76-400b-85b5-5acbda538ab2.png)
- [](# "align-issue-labels") [이슈/PR 목록에서 레이블을 왼쪽, 각 제목 아래로 정렬](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261160640-28ae4f12-0e95-4db5-a79c-e89ae523a4d0.png)
- [](# "sort-conversations-by-update-time") 🔥 이슈/PR의 기본 정렬 순서를 `최근 업데이트`로 변경
- [](# "more-conversation-filters") [검색창 드롭다운에 `내가 참여한 모든 항목` 및 `내가 구독한 모든 항목` 필터 추가](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253043952-cfb99cea-1c7b-43ad-9144-9d84bda8206f.png)
- [](# "global-conversation-list-filters") [글로벌 이슈/PR 검색에 "내 저장소" 및 "내가 댓글 단 이슈/PR" 필터 추가](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253048449-2f7cc331-c379-4ec0-a542-441e8b4f8d79.png)
- [](# "clean-conversation-sidebar") 🔥 [이슈/PR 사이드바의 빈 섹션(또는 "비어 있음" 레이블) 숨김](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253054419-48c38c01-b1dc-42ca-9ff6-fd63392b5921.png)
- [](# "clean-conversation-filters") [이슈/PR 목록에서 `Projects`와 `Milestones` 필터가 비어있을 경우 숨깁니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/262557246-4ef1c702-eece-4701-9000-0aad21c54c1b.png)
- [](# "toggle-everything-with-alt") [유사 항목(최소화된 댓글, 연기된 diff 등)을 한 번에 토글하는 단축키를 추가합니다: 각 버튼이나 체크박스에서 <kbd>alt</kbd> <kbd>클릭</kbd>.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253063446-6f556e7d-2ac5-439d-92f0-0c6d719fc86f.gif)
- [](# "extend-conversation-status-filters") [검색에서 is:open/is:closed/is:merged 필터를 토글할 수 있습니다.](https://user-images.githubusercontent.com/1402241/73605061-2125ed00-45cc-11ea-8cbd-41a53ae00cd3.gif)
- [](# "bugs-tab") [“Bugs” 탭을 리포지토리에 추가합니다(“bug” 라벨이 달린 오픈 이슈가 있을 때만 표시).](https://user-images.githubusercontent.com/46634000/156766081-f2ea100b-a9f3-472b-bddc-a984a88ddcd3.png)
- [](# "pinned-issues-update-time") [고정된 이슈의 “opened” 시간을 “updated” 시간으로 교체합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/240707405-e416be14-5ab5-4869-b33c-f43aab7afcb6.png)
- [](# "clean-pinned-issues") [고정된 이슈의 레이아웃을 나란히 배치에서 표준 목록으로 변경합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/258224321-e8ee8c70-6952-4a42-8626-6b5f31d167a3.png)
- [](# "quick-label-removal") [이슈/PR에서 라벨을 한 번에 제거하는 버튼을 추가합니다.](https://user-images.githubusercontent.com/36174850/89980178-0bc80480-dc7a-11ea-8ded-9e25f5f13d1a.gif)
- [](# "clean-conversation-headers") [이슈와 PR 헤더에서 중복 정보를 제거합니다("User wants to merge X commits from Y into Z" 등).](https://user-images.githubusercontent.com/44045911/112314137-a34b0680-8ce3-11eb-9e0e-8afd6c8235c2.png)
- [](# "dim-bots") [봇이 남긴 커밋과 PR을 흐리게 표시해 노이즈를 줄입니다.](https://user-images.githubusercontent.com/1402241/220607557-f8ea0863-f05b-48c8-a447-1fec42af0afd.gif)
- [](# "esc-to-cancel") [이슈/PR 제목 편집을 취소하는 단축키를 추가합니다: <kbd>esc</kbd>.](https://user-images.githubusercontent.com/35100156/98303086-d81d2200-1fbd-11eb-8529-70d48d889bcf.gif)
- [](# "no-duplicate-list-update-time") [이슈/PR 목록에서 업데이트 시간이 오픈/클로즈/머지 시간과 같으면 업데이트 시간을 숨깁니다.](https://user-images.githubusercontent.com/1402241/111357166-ac3a3900-864e-11eb-884a-d6d6da88f7e2.png)
- [](# "linkify-user-labels") [댓글의 "Contributor"와 "Member" 라벨을 작성자의 커밋 목록으로 연결합니다.](https://user-images.githubusercontent.com/1402241/177033344-4d4eea63-e075-4096-b2d4-f4b879f1df31.png)
- [](# "jump-to-conversation-close-event") [이슈/PR의 최신 종료 이벤트로 점프하는 링크를 추가합니다.](https://user-images.githubusercontent.com/16872793/177792713-64219754-f8df-4629-a9ec-33259307cfe7.gif)
- [](# "close-as-unplanned") [“예정되지 않음”으로 이슈를 한 번에 닫을 수 있습니다(기존에는 세 번 클릭 필요).](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/279745773-709cde60-c26a-4a0e-89e1-56444d25ebdf.png)
- [](# "locked-issue") [잠긴 이슈와 PR에 라벨을 표시합니다.](https://user-images.githubusercontent.com/1402241/283015579-0a04becc-9bff-4aef-8770-272d6804970b.png)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### PR(풀 리퀘스트) 보기

- [](# "linkify-commit-sha") [PR 커밋을 방문할 때 비 PR 커밋에 대한 링크를 추가합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/261164635-b3caa3fa-3bb6-41a5-90d3-4aba84517da6.png)
- [](# "pr-filters") [PR 목록에 체크 및 Draft PR 드롭다운 필터를 추가합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253068868-6afb4656-4ef5-4846-89c5-24dc6ee7f839.png)
- [](# "pr-approvals-count") [PR 목록에 색상으로 구분된 리뷰 개수를 표시합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253125143-d10d95df-4a89-4692-b218-5eba5cd79906.png)
- [](# "highlight-non-default-base-branch") [기본 브랜치가 아닌 경우 PR 목록에 base 브랜치를 표시합니다.](https://user-images.githubusercontent.com/1402241/88480306-39f4d700-cf4d-11ea-9e40-2b36d92d41aa.png)
- [](# "hide-inactive-deployments") [PR에서 비활성화된 배포를 숨깁니다.](https://github.com/refined-github/refined-github/issues/1144)
- [](# "previous-next-commit-buttons") [`Commits` 탭 페이지 하단에 중복된 커밋 이동 버튼을 추가합니다.](https://user-images.githubusercontent.com/24777/41755271-741773de-75a4-11e8-9181-fcc1c73df633.png)
- [](# "hidden-review-comments-indicator") [PR 리뷰에서 댓글이 숨겨졌을 때 댓글 표시기를 추가합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253128043-a10eaf9e-ff81-48db-b67c-ee823804c859.gif)
- [](# "conflict-marker") [PR 목록에서 충돌이 있는 PR을 표시합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253128438-d67c8f49-44f1-4e15-9363-a717109fef39.png)
- [](# "pr-commit-lines-changed") [PR 커밋에 diff 통계(라인 변경 수)를 추가합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/253130044-494cd822-c460-42dc-8f65-44454a9d18e3.png)
- [](# "cross-deleted-pr-branches") [PR에서 삭제된 브랜치에 취소선을 추가합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/256963526-646ac7d0-3e7f-40c6-ba39-014b49bc0063.png)
- [](# "batch-mark-files-as-viewed") [PR 파일 탭에서 여러 파일을 “Viewed”로 한 번에 표시/해제할 수 있습니다. 첫 체크박스 클릭 후 `shift`-클릭하면 사이의 파일이 모두 표시/해제됩니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257009611-17249bee-d2e2-42ac-bdf0-ebc90029544e.gif)
- [](# "closing-remarks") 🔥 [머지된 PR이 포함된 첫 Git 태그를 표시하거나, 아직 릴리스되지 않았다면 릴리스 생성을 제안합니다.](https://user-images.githubusercontent.com/1402241/169497171-85d4a97f-413a-41b4-84ba-885dca2b51cf.png)
- [](# "pr-jump-to-first-non-viewed-file") [PR 진행률 바 클릭 시 첫 미확인 파일로 이동합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257011208-764f509d-fed9-424b-84e9-c01cf2fd428b.gif)
- [](# "jump-to-change-requested-comment") [최신 변경 요청 코멘트로 점프하는 링크를 추가합니다.](https://user-images.githubusercontent.com/19198931/98718312-418b9f00-23c9-11eb-8da2-dfb616e95eb6.gif)
- [](# "view-last-pr-deployment") [PR 헤더에서 최신 배포를 바로 열 수 있는 링크를 추가합니다.](https://user-images.githubusercontent.com/44045911/232313171-b54ac9cc-ebb1-43ef-bd41-5d81ec9f9588.png)
- [](# "no-unnecessary-split-diff-view") [분할 diff가 유용하지 않은 파일에서는 항상 통합 diff를 사용합니다.](https://user-images.githubusercontent.com/46634000/121495005-89af8600-c9d9-11eb-822d-77e0b987e3b1.png)
- [](# "emphasize-draft-pr-label") [목록에서 draft PR을 더 쉽게 구분할 수 있도록 합니다.](https://user-images.githubusercontent.com/1402241/218252438-062a1ab3-4437-436d-9140-87bee23aaefb.png)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### PR(풀 리퀘스트) 편집

- [](# "sync-pr-commit-title") 🔥 [PR의 제목을 squash 커밋의 기본 제목으로 사용합니다.](https://github.com/refined-github/refined-github/issues/276) 그리고 [커밋 제목이 변경되면 PR 제목도 일치하도록 업데이트합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257011579-25332762-b25f-407b-b6d2-bbfc13de2be7.png)
- [](# "update-pr-from-base-branch") [모든 PR에 "Update branch" 버튼을 추가합니다.](https://user-images.githubusercontent.com/1402241/234483592-4867cb2e-21cb-436d-9ea0-aedadf834f19.png) GitHub에도 동일 기능이 있지만, 보호된 브랜치로 수동 설정해야 합니다.
- [](# "one-click-review-submission") [PR 리뷰 폼을 단순화: 한 번 클릭으로 승인/거절 등 리뷰 유형을 빠르게 선택합니다.](https://user-images.githubusercontent.com/1402241/236627732-df341ff7-cd98-4cd0-a579-722d1fffa5cf.png)
- [](# "pull-request-hotkeys") [PR 탭을 순환하는 단축키를 추가합니다: <kbd>g</kbd> <kbd>←</kbd> 및 <kbd>g</kbd> <kbd>→</kbd>, 또는 <kbd>g</kbd> <kbd>1</kbd>, <kbd>g</kbd> <kbd>2</kbd>, <kbd>g</kbd> <kbd>3</kbd>, <kbd>g</kbd> <kbd>4</kbd>](https://user-images.githubusercontent.com/16872793/94634958-7e7b5680-029f-11eb-82ea-1f96cd11e4cd.png).
- [](# "pr-branch-auto-delete") [PR이 머지된 후 브랜치를 자동으로 삭제합니다(가능한 경우).](https://user-images.githubusercontent.com/1402241/177067141-eabc7494-38a2-45b5-aef9-ac33cc0da370.png) 장기 브랜치로 알려진 이름(`develop`, `release/*` 등)은 제외됩니다.
- [](# "one-click-pr-or-gist") [한 번 클릭으로 draft PR과 공개 gist를 생성할 수 있습니다.](https://user-images.githubusercontent.com/34235681/152473201-868ad7c1-e06f-4826-b808-d90bca7f08b3.png)
- [](# "clear-pr-merge-commit-message") [PR 병합 커밋 메시지에서 중복 co-author만 남기고 나머지 군더더기를 제거합니다.](https://user-images.githubusercontent.com/1402241/79257078-62b6fc00-7e89-11ea-8798-c06f33baa94b.png)
- [](# "quick-review") [PR 사이드바에 빠른 리뷰 버튼을 추가하고, 리뷰 텍스트 영역에 자동 포커스 및 리뷰 팝업을 여는 단축키 <kbd>v</kbd>를 추가합니다.](https://github.com/refined-github/refined-github/assets/1402241/f11039c4-c9d1-4adc-9a65-cfe1f2027ec3)
- [](# "pr-first-commit-title") [새 PR의 제목과 설명을 첫 커밋에서 가져옵니다.](https://user-images.githubusercontent.com/16872793/87246205-ccf42400-c419-11ea-86d5-0e6570d99e6e.gif)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### 커밋

- [](# "patch-diff-links") [커밋에 `.patch`와 `.diff` 파일 링크를 추가합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257011950-51712338-ffba-4b71-ad8f-9a0f142afb85.png)
- [](# "more-file-links") [PR과 커밋 내 파일에 대해 원본(raw) 보기, blame, history 링크를 추가합니다.](https://user-images.githubusercontent.com/46634000/145016304-aec5a8b8-4cdb-48e6-936f-b214a3fb4b49.png)
- [](# "one-click-diff-options") [diff 스타일 변경 및 공백 무시를 위한 원클릭 버튼과, 공백 무시 단축키 <kbd>d</kbd> <kbd>w</kbd>를 추가합니다.](https://user-images.githubusercontent.com/46634000/156766044-18c9ff50-aead-4c40-ba16-7428b3742b6c.png)
- [](# "extend-diff-expander") [`Expand diff` 버튼을 화면 전체에 클릭할 수 있도록 넓힙니다.](https://user-images.githubusercontent.com/1402241/152118201-f25034c7-6fae-4be0-bb3f-c217647e32b7.gif)
- [](# "hide-diff-signs") [diff 부호를 숨깁니다(이미 색상으로 구분되어 있기 때문).](https://user-images.githubusercontent.com/1402241/54807718-149cec80-4cb9-11e9-869c-e265863211e3.png)
- [](# "suggest-commit-title-limit") [커밋 및 PR 제목을 72자로 제한하도록 제안합니다.](https://github.com/user-attachments/assets/e0392989-9c60-4f5c-9052-27a3bb51d4e4)
- [](# "tags-on-commits-list") [커밋 옆에 해당 태그를 표시합니다.](https://user-images.githubusercontent.com/1402241/285106537-3c882cb2-6847-4098-9e51-cf2951dee818.png)
- [](# "mark-merge-commits-in-list") [커밋 목록에서 merge 커밋을 표시합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/285106996-9bdbc938-69c4-4692-8d47-11e30676de62.png)
- [](# "deep-reblame") [blame 탐색 시, `Alt`-클릭으로 “Reblame”을 누르면 커밋을 단일 변경으로 처리하는 대신 관련 PR의 커밋을 먼저 추출합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257035884-732ee7ff-22c5-4049-af7d-f11117d2bbe4.png)
- [](# "new-or-deleted-file") [커밋과 PR 내 파일이 추가/삭제되는지 아이콘으로 표시합니다.](https://user-images.githubusercontent.com/1402241/90332474-23262b00-dfb5-11ea-9a03-8fd676ea0fdd.png)
- [](# "easy-toggle-files") [파일 diff 헤더바를 클릭하여 파일 diff를 토글할 수 있습니다.](https://user-images.githubusercontent.com/47531779/99855419-be173e00-2b7e-11eb-9a55-0f6251aeb0ef.gif)
- [](# "same-branch-author-commits") [작성자별 커밋 보기 시, 현재 브랜치와 경로를 유지합니다.](https://user-images.githubusercontent.com/44045911/148764372-ee443213-e61a-4227-9219-0ee54ed832e8.png)
- [](# "easy-toggle-commit-messages") [커밋 박스를 클릭하여 커밋 메시지를 토글할 수 있습니다.](https://user-images.githubusercontent.com/1402241/152121837-ca13bf8a-9b7f-4517-8e8d-b58bb135523b.gif)
- [](# "link-to-compare-diff") [비교 페이지의 "X files changed" 텍스트를 링크로 만들어 diff로 바로 이동할 수 있게 합니다.](https://user-images.githubusercontent.com/46634000/157072587-0335357a-18c7-44c4-ae6e-237080fb36b4.png)
- [](# "conventional-commits") [커밋 메시지 앞에 conventional commit 타입을 라벨로 표시합니다.](https://github.com/user-attachments/assets/980a2d5e-13c2-4b1b-bb80-81dc94723000)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### 태그 및 릴리스

- [](# "release-download-count") [릴리스 자산(파일) 옆에 다운로드 수를 표시합니다.](https://user-images.githubusercontent.com/1402241/197958719-1577bc1b-1f4d-44a8-98c2-2645b7b14d31.png)
- [](# "releases-tab") [`Releases` 탭과 단축키 <kbd>g</kbd> <kbd>r</kbd>을 추가합니다.](https://cloud.githubusercontent.com/assets/170270/13136797/16d3f0ea-d64f-11e5-8a45-d771c903038f.png)
- [](# "releases-dropdown") [태그/릴리스 페이지에 태그 드롭다운/검색을 추가합니다.](https://user-images.githubusercontent.com/1402241/231678527-f0a96112-9c30-4b49-8205-efa472bd880e.png)
- [](# "create-release-shortcut") 릴리스 페이지에서 새 릴리스를 만드는 단축키 <kbd>c</kbd>를 추가합니다.
- [](# "tag-changes-link") 🔥 [각 태그/릴리스에 대해 이전 태그/릴리스 이후 변경 사항으로 이동하는 링크를 추가합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257036739-bebafb94-cb94-4053-9768-ff97306ab862.png)
- [](# "convert-release-to-draft") [릴리스를 드래프트로 변환하는 버튼을 추가합니다.](https://user-images.githubusercontent.com/46634000/139236979-44533bfd-5c17-457d-bdc1-f9ec395f6a3a.png)
- [](# "link-to-changelog-file") [릴리스 페이지에서 변경 로그 파일을 바로 볼 수 있는 버튼을 추가합니다.](https://user-images.githubusercontent.com/46634000/139236982-a1bce2a2-f3aa-40a9-bca4-8756bc941210.png)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### 프로필

- [](# "user-profile-follower-badge") [프로필에서 해당 사용자가 나를 팔로우하는지 표시합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/263206287-c8e1b94c-ec80-4394-bbb3-1cf6fb08b807.png)
- [](# "profile-gists-link") [사용자 프로필에 공개 gist로 이동하는 링크를 추가합니다.](https://user-images.githubusercontent.com/44045911/87950518-f7a94100-cad9-11ea-8393-609fad70635c.png)
- [](# "mark-private-orgs") [내 프로필에서 비공개 조직을 표시합니다.](https://github.com/user-attachments/assets/145a7a97-7b8c-4ac4-8288-f72dcb4613ea)
- [](# "profile-hotkey") 내 프로필로 이동하는 단축키 <kbd>g</kbd> <kbd>m</kbd>을 추가합니다.
- [](# "show-user-top-repositories") [사용자의 가장 많은 별을 받은 저장소로 이동하는 링크를 추가합니다.](https://user-images.githubusercontent.com/1402241/48474026-43e3ae80-e82c-11e8-93de-159ad4c6f283.png)
- [](# "hide-user-forks") [프로필에서 기본적으로 포크 및 아카이브된 저장소를 숨기고 원본만 표시합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/1402241/263195425-85cf0951-c6ed-45fe-8cfc-e447e3ed2a25.png) [(하지만 원하면 다시 표시할 수 있습니다.)](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/262547829-2da96718-fb18-4f2e-b637-8157f552e278.png)
- [](# "linkify-user-location") [프로필 및 hovercard에 표시되는 사용자 위치를 링크로 만듭니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/262554067-43bea584-cdb4-41c7-b0fa-f487e7ef8807.png)
- [](# "user-local-time") [사용자 hovercard에 (마지막 커밋 기준) 현지 시간을 표시합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257039621-132bd789-e213-4a89-83ff-e1266215c60d.png)
- [](# "conversation-links-on-repo-lists") [사용자 프로필 저장소 탭 및 전역 검색에 이슈/PR로 바로 가는 링크를 추가합니다.](https://user-images.githubusercontent.com/16872793/78712349-82c54900-78e6-11ea-8328-3c2d39a78862.png)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### 알림

- [](# "open-all-notifications") [읽지 않은 모든 알림을 한 번에 여는 버튼을 추가합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/140871606/257085496-17e5c6fa-6bad-443d-96d2-d97e73cd1a5e.png)
- [](# "unread-anywhere") 🔥 [전역 단축키 <kbd>g</kbd> <kbd>u</kbd>로 읽지 않은 모든 알림을 한 번에 엽니다.](https://github.com/user-attachments/assets/3afb7e86-66e8-4b26-a5c0-9c93fb5d8141)
- [](# "select-all-notifications-shortcut") 현재 보이는 모든 알림을 선택하는 단축키 <kbd>a</kbd>를 추가합니다.
- [](# "stop-redirecting-in-notification-bar") [<kbd>Alt</kbd>를 누른 채 알림 바에서 작업할 때 알림 인박스로 리다이렉트되는 것을 방지합니다.](https://user-images.githubusercontent.com/202916/80318782-c38cef80-880c-11ea-9226-72c585f42a51.png)
- [](# "last-notification-page-button") [알림의 마지막 페이지로 이동하는 링크를 추가합니다.](https://user-images.githubusercontent.com/16872793/199828181-3ff2cef3-8740-4efa-8122-8f2f222bd657.png)
- [](# "pr-notification-link") [PR 알림이 커밋 페이지(404일 수 있음) 대신 Conversation 탭으로 이동하도록 합니다.](https://github.com/refined-github/refined-github/assets/1402241/621f6512-655e-4565-a37b-2b159ea0ffce)
- [](# "sticky-notifications-actions") [알림 액션 바를 고정(sticky)시킵니다.](https://github.com/refined-github/refined-github/assets/1402241/5b370430-2319-4c78-88e7-c2c06cd1c30f)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### 전역(Global)

- [](# "useful-not-found-page") 🔥 [404 페이지에서 관련 있는 페이지 및 대안을 제안합니다.](https://user-images.githubusercontent.com/1402241/46402857-7bdada80-c733-11e8-91a1-856573078ff5.png)
- [](# "selection-in-new-tab") [<kbd>j</kbd> 및 <kbd>k</kbd>로 이동할 때 <kbd>shift</kbd> <kbd>o</kbd> 단축키로 선택 항목을 새 탭에서 엽니다.](https://github.com/refined-github/refined-github/issues/1110)
- [](# "close-out-of-view-modals") [더 이상 보이지 않는 드롭다운 메뉴를 자동으로 닫습니다.](https://user-images.githubusercontent.com/1402241/37022353-531c676e-2155-11e8-96cc-80d934bb22e0.gif)
- [](# "parse-backticks") [GitHub가 일부 장소에서만 렌더링하는 백틱(`` `text in backticks` ``)을 누락된 곳에도 적용합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/262555091-df31aa17-e7a2-4c16-91ca-fb077ba6134a.png)
- [](# "pagination-hotkey") 페이지 이동(페이징) 단축키 <kbd>←</kbd> 및 <kbd>→</kbd>를 추가합니다.
- [](# "action-used-by-link") [마켓플레이스에서 현재 액션을 누가 어떻게 사용하는지 확인할 수 있습니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/258552390-7d2cd013-c167-4fe5-9731-33622b8607e9.png)
- [](# "improve-shortcut-help") [단축키 도움말 모달(<kbd>?</kbd> 단축키)에 Refined GitHub의 모든 새 단축키를 표시합니다.](https://user-images.githubusercontent.com/29176678/36999174-9f07d33e-20bf-11e8-83e3-b3a9908a4b5f.png)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### 네티켓(Netiquette)

- [](# "netiquette") [눈에 띄지 않게 네티켓 알림을 표시합니다(오래된 닫힌 이슈, 매우 활발한 이슈, draft PR 등).](https://github.com/user-attachments/assets/8646d663-7458-4e6d-888a-68d38110fcda)
- [](# "warn-pr-from-master") [기본 브랜치에서 PR을 생성할 때(안티 패턴) 경고를 표시합니다.](https://user-images.githubusercontent.com/1402241/52543516-3ca94e00-2de5-11e9-9f80-ff8f9fe8bdc4.png)
- [](# "warning-for-disallow-edits") [`Allow edits from maintainers`를 해제할 때(메인테이너에게 비우호적임) 경고를 표시합니다.](https://user-images.githubusercontent.com/1402241/53151888-24101380-35ef-11e9-8d30-d6315ad97325.gif)

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### GitHub의 단점 보완

- [](# "hide-navigation-hover-highlight") 저장소 파일 브라우저에서 파일 hover 효과를 제거합니다.
- [](# "clean-repo-sidebar") [저장소 사이드바에서 불필요하거나 중복된 정보를 제거합니다.](https://user-images.githubusercontent.com/46634000/107955448-18694480-6f9e-11eb-8bc6-80cc90d910bc.png)
- [](# "linkify-branch-references") [“빠른 PR” 페이지에서 브랜치 참조를 링크로 만듭니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/258553554-e1711be0-d5ce-4edc-aaf8-72d659c881bc.png)
- [](# "hide-issue-list-autocomplete") [검색 필드의 자동완성을 제거합니다.](https://user-images.githubusercontent.com/1402241/42991841-1f057e4e-8c07-11e8-909c-b051db7a2a03.png)
- [](# "actionable-pr-view-file") [PR의 “View file” 버튼이 커밋이 아닌 브랜치로 이동하도록 하여, "View file" 페이지에서 편집/삭제 버튼이 활성화되게 합니다.](https://user-images.githubusercontent.com/1402241/69044026-c5b17d80-0a26-11ea-86ae-c95f89d3669a.png)
- [](# "reload-failed-proxied-images") [GitHub의 제한된 프록시로 인해 이미지 다운로드에 실패했을 때 재시도합니다.](https://user-images.githubusercontent.com/14858959/64068746-21991100-cc45-11e9-844e-827f5ac9b51e.png)
- [](# "unwrap-unnecessary-dropdowns") [불필요하게 두 번 클릭해야 하는 드롭다운을 한 번만 클릭해도 되도록 개선합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/258554504-97d4079a-2aae-4aea-a870-653a267494a8.png)
- [](# "prevent-link-loss") [GitHub가 잘못 짧게 줄여버린 링크를 복구하도록 제안합니다.](https://github-production-user-asset-6210df.s3.amazonaws.com/83146190/260087535-a0f19995-5f4a-44e9-87d8-cf742b9bfeed.gif)
- [](# "linkify-user-edit-history-popup") [수정 기록 팝업에서 사용자명을 링크로 만듭니다.](https://user-images.githubusercontent.com/1402241/88917988-9ebb7480-d260-11ea-8690-0a3440f1ebbc.png)
- [](# "prevent-duplicate-pr-submission") [“Create pull request”를 실수로 여러 번 클릭할 때 중복 PR 생성을 방지합니다.](https://user-images.githubusercontent.com/16872793/89589967-e029c200-d814-11ea-962b-3ff1f6236781.gif)
- [](# "convert-pr-to-draft-improvements") [“Convert PR to Draft” 버튼을 머지 가능성 박스로 이동시키고, 확인 버튼에 시각적 피드백을 추가합니다.](https://user-images.githubusercontent.com/1402241/95644892-885f3f80-0a7f-11eb-8428-8e0fb0c8dfa5.gif)
- [](# "prevent-pr-merge-panel-opening") 머지 패널이 한 번 열리면 이후 모든 페이지 로드에서 자동으로 열리는 것을 방지합니다.
- [](# "command-palette-navigation-shortcuts") 커맨드 팔레트에서 <kbd>ctrl</kbd> <kbd>n</kbd>, <kbd>ctrl</kbd> <kbd>p</kbd>로 항목을 선택할 수 있는 단축키 추가(macOS 한정).
- [](# "prevent-comment-loss") [댓글 작성/편집 시, 미리보기 링크를 새 탭에서 열어 페이지 이탈로 인한 손실을 방지합니다.](https://user-images.githubusercontent.com/17681399/282616531-2befcabe-5c80-4b9a-bfb5-7b9917847bb5.gif)
- [](# "fix-no-pr-search") [검색에 `is:pr`이 포함되지 않은 경우 저장소 이슈 목록으로 리디렉션합니다.](https://user-images.githubusercontent.com/46634000/286579939-50122f02-dcfd-4510-b9e1-03d9985da2cd.gif)
- [](# "clean-readme-url") [저장소 URL에서 불필요한 "readme-ov-file" 파라미터를 제거합니다.](https://github.com/refined-github/refined-github/assets/1402241/73e96411-3314-4501-a9b6-d006af6fcc47)
- [](# "click-outside-modal") [모달 바깥을 클릭하면 checks 목록을 닫습니다.](https://github.com/refined-github/refined-github/issues/7157)
- [](# "linkify-line-numbers") [GitHub가 링크를 빠뜨린 라인 번호에 링크를 추가합니다.](https://github.com/refined-github/refined-github/assets/1402241/d5b67f4e-35c3-45d8-b72c-937b855168c3)
- [](# "sidebar-focus-file") [파일 트리를 현재 파일 위치로 스크롤합니다.](https://github.com/user-attachments/assets/25e1e19e-799b-4dab-ae81-59ba17ad1194)
- [](# "no-modals") [사용자 경험을 저해하는 모달을 비활성화합니다.](https://github.com/user-attachments/assets/7b63c7db-ae31-4ee8-8510-3b9db0c11f3e)
- [](# "same-page-links") 불필요하게 새 탭에서 열리는 링크를 방지합니다. 새 탭에서 열기는 사용자가 직접 선택해야 합니다.

<!--
Refer to style guide in the wiki. Keep this message between sections.
https://github.com/refined-github/refined-github/wiki/Contributing#metadata-guidelines
-->

### Refined GitHub의 일부였던 기능

[GitHub는 Refined GitHub에서 영감을 얻어](https://github.blog/2018-08-28-announcing-paper-cuts/) 수십 개의 기능을 기본적으로 구현했습니다. 🎉 그래서 [이 확장 프로그램에서 제거되었습니다.](https://github.com/refined-github/refined-github/pulls?q=is%3Apr+is%3Amerged+label%3A%22implemented+by+github%22) Refined GitHub의 [모든 과거 기능](https://github.com/refined-github/refined-github/pulls?q=is%3Apr+is%3Amerged+-label%3Ameta+in%3Atitle+drop+feature)도 한 번에 볼 수 있습니다.

## 커스터마이징

대부분의 기능은 JavaScript 기반일 경우 비활성화할 수 있으며, 확장 옵션에서 CSS를 직접 오버라이드할 수도 있습니다.

제안 및 기여를 환영하지만, 이 프로젝트는 매우 의견이 뚜렷함을 유념해 주세요. [기능 추가 기준이 높습니다.](https://github.com/refined-github/refined-github/wiki/%22Can-you-add-this-feature%3F%22) 모든 사용자가 항상 모두 동의하는 것은 아닙니다. 그럼에도 불구하고 논의는 언제든 환영합니다.

## 링크

- [더 많은 확장 프로그램](https://github.com/refined-github/refined-github/wiki/Other-extensions)
- [기여 가이드](https://github.com/refined-github/refined-github/wiki/Contributing)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---