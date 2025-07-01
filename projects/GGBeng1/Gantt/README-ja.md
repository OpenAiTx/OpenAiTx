# ガント
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
## インストール

```
yarn install
```

### 実行

```
yarn run serve
```

### 説明

```
vue をベースに開発されたガントチャート表示であり、チーム協力やタスク分割などのアジャイルな場面で利用可能

グループ化対応
ドラッグ対応
伸縮対応
パーセンテージ対応
時間スパン対応：日、週、月
現在は1階層のグループ化のみ実装済み。将来的な2階層以上のグループ化ニーズに備え、前回のコミットで一部コードをリファクタリングし多階層グループ化をサポート。ただし現バージョンでは未開発。

利点: ドラッグ、伸縮、進捗変更などの操作時、データはリアルタイムで更新されず、操作後に更新されるためパフォーマンスの消耗を抑制
      編集・削除・追加時もインスタンス全体を再帰的に変更せず、変更部分のみを増減修正

現在コンポーネント化の準備のため、再編成を進行中。現時点でプロジェクトに導入するには本プロジェクト内の`gant.vue`をインポートするだけでOK
バルクデータのインポート・エクスポート方法も実装済み、コピペで利用可能！~

```

### 更新履歴

- 編集対応
- 削除対応
- 垂直スクロール不可のバグ修正（双方向同時スクロールも追加） [#4](https://github.com/GGBeng1/Gantt/issues/4)
- elementUIに起因するバグ修正
- 時間スパンの問題について [#5](https://github.com/GGBeng1/Gantt/issues/5)
- 現状、スパン設定を変更して他のスパン（例：時間単位など）を実現することはできません。初期化時に一部設定が固定されているためですが、今後はAPI化して対応予定です。


### サンプルを見る

[デモを見る](https://ggbeng1.github.io/Gantt/#/)

### 表示例

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---