# Discord GNOME テーマ

Adwaita スタイルおよび GNOME ヒューマンインターフェースガイドラインに従った Discord 用 GNOME テーマ（Discord の CSS で可能な範囲で実装）。

## 必要条件

1. Vesktop

   Windows タイトルバーを有効にするため。

2. 設定 > 言語 > "English (US)" を選択

   Discord 内でアイコンが識別される方法により、カスタムアイコンが利用できます。[ローカライズ](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/src/global/icons.scss)することも可能ですが、ローカライズに関する注意事項を参照してください。

3. 設定 > プラグイン > "ThemeAttributes" を有効にする

   設定ダイアログ内でアイコンを利用可能にします。

4. 設定 > Vesktop 設定 > "Discord タイトルバー" を有効にする

   任意ですが、タイトルバーを使用している場合は推奨します。

### オプション追加

1. Nitro 表示の削除: https://github.com/CroissantDuNord/discord-adblock

## テーマ設計方針

### ヒューマンインターフェースガイドライン

Discord の CSS や設計上の制限、あるいは作者の判断により、本テーマが HIG に完全に準拠しない場合があります。

### サポートについて

以下はサポート対象外です:

- Discord 実験機能

  作者は Discord の開発者ではないため、これらの機能が変更・廃止されるか把握できません（＝保守負担が高い）。また、他にもいくつかのプロジェクトを管理しています。

- Nitro

  例外 — FakeNitro プラグインでアクセス可能なもの。

これらに関して Issue を立てることは可能ですが、簡単な修正（例：アイコンの欠落など）の場合のみ対応します。

## インストール方法

### 設定不要の場合

設定 > テーマ > オンラインテーマ のテキストボックスに、以下をコピー＆ペーストしてください：

```
https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css
```

### 設定を含める場合

[gnome.theme.css](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/gnome.theme.css) を ~/.config/vesktop/themes に配置してください。自動的に更新されます。

## プレビュー

![first](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2011-55-58.png)
![cozy second](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-31-42.png)
![third](https://raw.githubusercontent.com/ricewind012/discord-gnome-theme/master/assets/preview/Screenshot%20from%202024-04-27%2012-24-16.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---