<translate-content># intellij-platform-git-stats-plugin

![Build](https://github.com/zhensherlock/intellij-platform-git-stats-plugin/workflows/Build/badge.svg)
[![Version](https://img.shields.io/jetbrains/plugin/v/com.huayi.intellijplatform.gitstats.svg)](https://plugins.jetbrains.com/plugin/com.huayi.intellijplatform.gitstats)
[![Downloads](https://img.shields.io/jetbrains/plugin/d/com.huayi.intellijplatform.gitstats.svg)](https://plugins.jetbrains.com/plugin/com.huayi.intellijplatform.gitstats)

[//]: # (## Template ToDo list)

[//]: # (- [x] Create a new [IntelliJ Platform Plugin Template][template] project.)

[//]: # (- [ ] Get familiar with the [template documentation][template].)

[//]: # (- [ ] Adjust the [pluginGroup]&#40;./gradle.properties&#41;, [plugin ID]&#40;./src/main/resources/META-INF/plugin.xml&#41; and [sources package]&#40;./src/main/kotlin&#41;.)

[//]: # (- [ ] Adjust the plugin description in `README` &#40;see [Tips][docs:plugin-description]&#41;)

[//]: # (- [ ] Review the [Legal Agreements]&#40;https://plugins.jetbrains.com/docs/marketplace/legal-agreements.html?from=IJPluginTemplate&#41;.)

[//]: # (- [ ] [Publish a plugin manually]&#40;https://plugins.jetbrains.com/docs/intellij/publishing-plugin.html?from=IJPluginTemplate&#41; for the first time.)

[//]: # (- [ ] Set the `PLUGIN_ID` in the above README badges.)

[//]: # (- [ ] Set the [Plugin Signing]&#40;https://plugins.jetbrains.com/docs/intellij/plugin-signing.html?from=IJPluginTemplate&#41; related [secrets]&#40;https://github.com/JetBrains/intellij-platform-plugin-template#environment-variables&#41;.)

[//]: # (- [ ] Set the [Deployment Token]&#40;https://plugins.jetbrains.com/docs/marketplace/plugin-upload.html?from=IJPluginTemplate&#41;.)

[//]: # (- [ ] Click the <kbd>Watch</kbd> button on the top of the [IntelliJ Platform Plugin Template][template] to be notified about releases containing new features and fixes.)

<!-- Plugin description -->
이 플러그인은 현재 IDE에서 열린 프로젝트 디렉토리 내 소스 코드의 수정 내역을 집계하여 사용자가 자신의 코드 작성 현황을 더 잘 이해할 수 있도록 돕는 것을 목표로 합니다. 일정 기간 내에 추가된 코드 라인 수, 삭제된 코드 라인 수, 수정된 파일 수를 그룹별로 집계한 후 결과를 리스트 형태로 보여주어, 사용자가 자신의 프로젝트 전반적인 코드 작성 상황을 명확히 파악할 수 있도록 합니다.
本插件旨在通过统计当前IDE打开的项目目录中的源代码修改情况，帮助用户更好地了解自己的代码编写情况。通过分组统计某个时间段内的添加代码行数、删除代码行数、修改文件数量，最后用列表形式展现，让用户清晰地了解自己项目的整体编写情况。
<!-- Plugin description end -->

## 설치

- IDE 내장 플러그인 시스템 사용:
  
  <kbd>설정/환경설정</kbd> > <kbd>플러그인</kbd> > <kbd>마켓플레이스</kbd> > <kbd>"intellij-platform-git-stats-plugin" 검색</kbd> >
  <kbd>플러그인 설치</kbd>
  
- 수동 설치:

  [최신 릴리스](https://github.com/zhensherlock/intellij-platform-git-stats-plugin/releases/latest)를 다운로드한 후
  <kbd>설정/환경설정</kbd> > <kbd>플러그인</kbd> > <kbd>⚙️</kbd> > <kbd>디스크에서 플러그인 설치...</kbd>를 사용하여 수동으로 설치하세요.


---
이 플러그인은 [IntelliJ Platform Plugin Template][template]을 기반으로 합니다.

[template]: https://github.com/JetBrains/intellij-platform-plugin-template
[docs:plugin-description]: https://plugins.jetbrains.com/docs/intellij/plugin-user-experience.html#plugin-description-and-presentation</translate-content>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---