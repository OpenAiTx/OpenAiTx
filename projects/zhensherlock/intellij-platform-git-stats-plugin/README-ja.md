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
このプラグインは、現在のIDEで開かれているプロジェクトディレクトリ内のソースコードの変更をカウントすることで、ユーザーが自身のコード作成状況をよりよく理解できるよう支援します。  
特定の期間内に追加されたコード行数、削除されたコード行数、変更されたファイル数をグループ化してカウントし、最終的にリスト形式で結果を表示します。  
これにより、ユーザーは自身のプロジェクトのコード作成状況を明確に把握できます。

本插件旨在通过统计当前IDE打开的项目目录中的源代码修改情况，帮助用户更好地了解自己的代码编写情况。通过分组统计某个时间段内的添加代码行数、删除代码行数、修改文件数量，最后用列表形式展现，让用户清晰地了解自己项目的整体编写情况。
<!-- Plugin description end -->

## インストール

- IDE組み込みのプラグインシステムを使用する場合：
  
  <kbd>設定/環境設定</kbd> > <kbd>プラグイン</kbd> > <kbd>マーケットプレース</kbd> > <kbd>"intellij-platform-git-stats-plugin"を検索</kbd> >
  <kbd>プラグインをインストール</kbd>
  
- 手動でのインストール：

  [最新リリース](https://github.com/zhensherlock/intellij-platform-git-stats-plugin/releases/latest) をダウンロードし、  
  <kbd>設定/環境設定</kbd> > <kbd>プラグイン</kbd> > <kbd>⚙️</kbd> > <kbd>ディスクからプラグインをインストール...</kbd> を使って手動でインストールしてください。


---
このプラグインは[IntelliJ Platform Plugin Template][template]をベースにしています。

[template]: https://github.com/JetBrains/intellij-platform-plugin-template
[docs:plugin-description]: https://plugins.jetbrains.com/docs/intellij/plugin-user-experience.html#plugin-description-and-presentation</translate-content>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---