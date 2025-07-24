![Reactive Resume](https://i.imgur.com/FFc4nyZ.jpg)

![App Version](https://img.shields.io/github/package-json/version/AmruthPillai/Reactive-Resume?label=version)
[![Docker Pulls](https://img.shields.io/docker/pulls/amruthpillai/reactive-resume)](https://hub.docker.com/repository/docker/amruthpillai/reactive-resume)
[![GitHub Sponsors](https://img.shields.io/github/sponsors/AmruthPillai)](https://github.com/sponsors/AmruthPillai)
[![Crowdin](https://badges.crowdin.net/reactive-resume/localized.svg)](https://crowdin.com/project/reactive-resume)
[![Discord](https://img.shields.io/discord/1173518977851473940?label=discord&link=https%3A%2F%2Fdiscord.gg%2FhzwkZbyvUW)](https://discord.gg/hzwkZbyvUW)

# Reactive Resume

無料かつオープンソースの履歴書ビルダーで、履歴書の作成、更新、共有のプロセスを簡素化します。

### [アプリへ移動](https://rxresu.me/) | [ドキュメント](https://docs.rxresu.me/)

## 説明

Reactive Resumeは無料かつオープンソースの履歴書ビルダーで、履歴書の作成、更新、共有のプロセスを簡素化します。ユーザートラッキングや広告は一切なく、プライバシーを最優先しています。プラットフォームは非常に使いやすく、データを完全に所有したい場合は30秒以内にセルフホストが可能です。

複数の言語に対応し、リアルタイム編集、数十のテンプレート、ドラッグ＆ドロップによるカスタマイズ、OpenAIとの統合による文章改善など、多彩な機能を備えています。

履歴書のパーソナライズされたリンクを潜在的な雇用主に共有し、その閲覧数やダウンロード数を追跡したり、セクションのドラッグ＆ドロップでページレイアウトをカスタマイズしたりできます。フォントの選択肢も豊富で、数十のテンプレートから選べます。もちろん、より快適に閲覧できるダークモードもあります。

Reactive Resumeであなたの際立つ履歴書を今すぐ作成しましょう！

## テンプレート

| アズリル                                                     | ブロンズォル                                               | チコリタ                                                   |
| ------------------------------------------------------------ | ----------------------------------------------------------- | ----------------------------------------------------------- |
| <img src="https://i.imgur.com/jKgo04C.jpeg" width="200px" /> | <img src="https://i.imgur.com/DFNQZP2.jpg" width="200px" /> | <img src="https://i.imgur.com/Dwv8Y7f.jpg" width="200px" /> |

| メタモン                                                     | カクーナ                                                   | ノーズパス                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| <img src="https://i.imgur.com/6c5lASL.jpg" width="200px" /> | <img src="https://i.imgur.com/268ML3t.jpg" width="200px" /> | <img src="https://i.imgur.com/npRLsPS.jpg" width="200px" /> |

| オニキス                                                     | ピカチュウ                                                 | サイホーン                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| <img src="https://i.imgur.com/cxplXOW.jpg" width="200px" /> | <img src="https://i.imgur.com/Y9f7qsh.jpg" width="200px" /> | <img src="https://i.imgur.com/h4kQxy2.jpg" width="200px" /> |

## 機能

- **無料で永遠に使える**オープンソース
- テレメトリ、ユーザートラッキング、広告なし
- 30秒以内にアプリをセルフホスト可能
- **複数言語対応**（[言語の追加・改善はこちら](https://translate.rxresu.me/)）
- メールアドレス（または捨てアドレスも可）でアカウント作成可能
- GitHubやGoogleアカウントでのサインインも可能で、二要素認証も設定可能
- 単一アカウントで複数の履歴書を作成可能、求人内容に合わせて最適化しATSスコアを向上
- **OpenAI APIキーを持ち込んで**文章の改善、スペルや文法の修正、トーン変更をワンクリックで実行可能
- ChatGPTを使って履歴書を任意の言語に翻訳し、編集しやすくインポート可能
- 単一ページまたは複数ページの履歴書を簡単に作成可能
- カラーやレイアウトをカスタマイズして個性を演出
- セクションのドラッグ＆ドロップでページレイアウトを自由にカスタマイズ
- 既存のセクションが合わない場合は業界特有のカスタムセクションを作成可能
- あなただけが見られる個人的なメモを履歴書に記録可能
- 編集をロックして履歴書の更なる変更を防止可能（マスターテンプレートに便利）
- **数十種類のテンプレート**があり、プロフェッショナルからモダンまで幅広く対応
- 標準化されたEuroPassデザインテンプレートで履歴書を作成可能
- A4またはレターサイズでの印刷に対応
- [Google Fonts](https://fonts.google.com/)の任意のフォントでデザイン可能
- **履歴書のパーソナライズリンクを共有**し、企業や採用担当者に最新情報を提供可能
- 公開履歴書の閲覧数やダウンロード数を追跡可能
- GitHub上のオープンソースコミュニティによりバトルテスト・ピアレビューされた最新かつ信頼性の高い技術で構築
- **MITライセンス**で、オリジナル作者のクレジットを保持すれば自由にコードを利用可能
- もちろん、ダークモードも搭載 🌓

## 使用技術

- フロントエンドにReact（Vite）
- バックエンドにNestJS
- プライマリデータベースにPostgres
- Prisma ORMで、コードの軽微な変更だけで他のリレーショナルデータベースに切り替え可能
- Minio（オブジェクトストレージ：アバター、履歴書PDF、プレビューを保存）
- Browserless（ヘッドレスChrome：PDF印刷とプレビュー生成）
- SMTPサーバー（パスワード回復メール送信用）
- GitHub/Google OAuth（ユーザー認証を迅速に）
- LinguiJSとCrowdin（翻訳管理とローカリゼーション）

## スター履歴

<a href="https://star-history.com/#AmruthPillai/Reactive-Resume&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=AmruthPillai/Reactive-Resume&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=AmruthPillai/Reactive-Resume&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=AmruthPillai/Reactive-Resume&type=Date" />
  </picture>
</a>

## ライセンス

Reactive Resumeは[MITライセンス](/LICENSE.md)のもとで配布されており、商用利用、配布、改変、私的利用が許可されています。ただし、ソフトウェアのすべてのコピーに同じライセンスと著作権表示を含める必要があります。

_コミュニティによる、コミュニティのためのプロジェクト_  
[Amruth Pillai](https://www.amruthpillai.com/)による情熱的なプロジェクト

<p>
  <a href="https://www.digitalocean.com/?utm_medium=opensource&utm_source=Reactive-Resume">
    <img src="https://opensource.nyc3.cdn.digitaloceanspaces.com/attribution/assets/PoweredByDO/DO_Powered_by_Badge_blue.svg" width="200px">
  </a>
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---