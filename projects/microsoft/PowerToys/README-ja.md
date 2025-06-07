# Microsoft PowerToys

![Microsoft PowerToys のヒーロー画像](doc/images/overview/PT_hero_image.png)

[PowerToys の使い方][usingPowerToys-docs-link] | [ダウンロード & リリースノート][github-release-link] | [PowerToys への貢献](#contributing) | [最新情報](#whats-happening) | [ロードマップ](#powertoys-roadmap)

## 概要

Microsoft PowerToys は、パワーユーザー向けに Windows の操作性を調整・最適化し、生産性を向上させるユーティリティのセットです。[PowerToys の概要やユーティリティの使い方][usingPowerToys-docs-link]、または [Windows 開発環境](https://learn.microsoft.com/windows/dev-environment/overview)に関する他のツールやリソースについては、[learn.microsoft.com][usingPowerToys-docs-link] をご覧ください。

|              | 現在のユーティリティ: |              |
|--------------|---------------------|--------------|
| [Advanced Paste](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Always on Top](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [Color Picker](https://aka.ms/PowerToysOverview_ColorPicker) | [Command Not Found](https://aka.ms/PowerToysOverview_CmdNotFound) | [Command Palette](https://aka.ms/PowerToysOverview_CmdPal) |
| [Crop And Lock](https://aka.ms/PowerToysOverview_CropAndLock) | [環境変数](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [ファイル エクスプローラー アドオン](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [File Locksmith](https://aka.ms/PowerToysOverview_FileLocksmith) | [Hosts ファイル エディター](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [画像リサイズ](https://aka.ms/PowerToysOverview_ImageResizer) | [キーボード マネージャー](https://aka.ms/PowerToysOverview_KeyboardManager) | [マウス ユーティリティ](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Mouse Without Borders](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [プレーンテキストとして貼り付け](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Quick Accent](https://aka.ms/PowerToysOverview_QuickAccent) | [レジストリ プレビュー](https://aka.ms/PowerToysOverview_RegistryPreview) | [スクリーンルーラー](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [ショートカット ガイド](https://aka.ms/PowerToysOverview_ShortcutGuide) | [テキスト抽出](https://aka.ms/PowerToysOverview_TextExtractor) | [ワークスペース](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Microsoft PowerToys のインストールと実行

### 必要条件

- Windows 11 または Windows 10 バージョン 2004（コードネーム 20H1 / ビルド番号 19041）以降
- x64 または ARM64 プロセッサ
- インストーラーは以下をインストールします:
   - [Microsoft Edge WebView2 ランタイム](https://go.microsoft.com/fwlink/p/?LinkId=2124703) ブートストラッパー（最新バージョンをインストールします）

### GitHub から EXE で [推奨]

[Microsoft PowerToys GitHub リリースページ][github-release-link] にアクセスし、下部の「Assets」をクリックしてリリース内のファイルを表示します。ご利用のマシンのアーキテクチャやインストールスコープに合った PowerToys インストーラーをご利用ください。ほとんどの場合、「x64」かつユーザーごとインストールです。

<!-- items that need to be updated release to release -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  説明        | ファイル名 | sha256 ハッシュ |
|--------------|------------|-----------------|
| ユーザーごと - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| ユーザーごと - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| マシン全体 - x64   | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| マシン全体 - ARM64 | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

これが推奨の方法です。

### Microsoft Store から

[Microsoft Store の PowerToys ページ][microsoft-store-link]からインストールします。[新しい Microsoft Store](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/) を使用している必要があります（Windows 11 および Windows 10 の両方で利用可能です）。

### WinGet 経由
[WinGet][winget-link] から PowerToys をダウンロードできます。WinGet での PowerToys の更新は、現在のインストールスコープを尊重します。インストールするには、コマンドライン / PowerShell から次のコマンドを実行します。

#### ユーザースコープ インストーラー [デフォルト]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### マシンスコープ インストーラー

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### その他のインストール方法

[Chocolatey や Scoop など、コミュニティ主導のインストール方法](./doc/unofficialInstallMethods.md)もあります。これらがご希望の場合は、インストール手順をご確認ください。

## サードパーティ製 Run プラグイン

PowerToys に同梱されていない [サードパーティ製プラグイン](./doc/thirdPartyRunPlugins.md) がコミュニティによって作成されています。

## 貢献について

このプロジェクトは、あらゆる種類の貢献を歓迎します。コーディングによる機能追加やバグ修正以外にも、仕様書作成、デザイン、ドキュメント作成、バグの発見なども支援方法です。パワーユーザーコミュニティと協力し、Windows を最大限活用するためのツールセットを作り上げていきたいと考えています。

**貢献したい機能に着手する前に**、必ず [Contributor's Guide](CONTRIBUTING.md) をお読みください。最適なアプローチの検討やガイダンス、開発中のメンタリングを行い、無駄や重複作業を避けるお手伝いができます。

ほとんどの貢献には、[Contributor License Agreement (CLA)][oss-CLA] への同意が必要です。これにより、貢献内容の利用許諾や権限を確認します。

PowerToys の開発ガイドラインについては、[開発者向けドキュメント](/doc/devdocs) をご参照ください。環境構築方法など詳細が記載されています。

## 最新情報

### PowerToys ロードマップ

コアチームが注力している機能やユーティリティの[優先ロードマップ][roadmap]です。

### 0.91 - 2025年5月アップデート

このリリースでは、新機能、安定性、オートメーションに焦点を当てました。

**✨ハイライト**

 - コマンドパレットのパフォーマンスを大幅に改善し、多数のバグを修正しました。新機能として：
 - コマンドパレットでフォールバックコマンドにより任意のファイル検索が可能になりました。
 - コマンドパレットのグローバルホットキーを低レベルキーボードフックに設定できるようになりました。
 - WebSearch拡張のオープンURLフォールバックコマンドを追加し、コマンドパレットから直接URLをブラウザで開けるようになりました。
 - PT Runおよびコマンドパレットの日時プラグインでカスタムフォーマットが定義可能に。Thanks [@htcfreek](https://github.com/htcfreek)!

### Advanced Paste

 - 特定の英語言語タグ（例: en-CA）で OCR エンジンの作成に失敗する問題を、ユーザープロファイルの言語で初期化することで修正。Thanks [@cryolithic](https://github.com/cryolithic)!

### Color Picker

 - グラフィックスオブジェクトの適切な破棄により、リソースリークによるハングやクラッシュを修正。Thanks [@dcog989](https://github.com/dcog989)!
 - バックスペースキー押下時に Color Picker が終了する問題を、フォーカス時のみ閉じるようにし、Escape/Backspaceの動作を統一して修正。Thanks [@PesBandi](https://github.com/PesBandi)!
 - Oklab および Oklch カラーフォーマットのサポートを追加。Thanks [@lemonyte](https://github.com/lemonyte)!

### Command Not Found

 - WinGet Command Not Found スクリプトを、実際に実験的機能が存在する場合のみ有効化するように更新。

### Command Palette

 - バグテンプレートを Command Palette モジュールを含むように更新。
 - トーストウィンドウが DPI にスケールされず、ディスプレイスケーリング時にレイアウト崩れする問題を修正。
 - 上/下キーでのナビゲーションがキャレット位置0の時に選択が移動しない問題と、PT Run v1のような連続ナビゲーションを追加。Thanks [@davidegiacometti](https://github.com/davidegiacometti)!
 - Time and Date 拡張のコードを簡素化し、明瞭性を向上。
 - コマンドの大文字小文字違いでマウスポインタ移動が失敗する問題を、小文字に調整して解決。
 - WebSearch拡張のオープンURLフォールバックコマンドを追加し、コマンドパレットから直接URLをブラウザで開けるように。Thanks [@htcfreek](https://github.com/htcfreek)!
 - CmdPal のシステムトレイアイコンの有効/無効切り替え設定を追加し、用語を Windows 11 に合わせて統一。Thanks [@davidegiacometti](https://github.com/davidegiacometti)!
 - エイリアス更新時に古いエイリアスを削除し、新しいものに置き換えることで問題を修正。
 - GitHub の大文字小文字の競合を解消し、Exts と exts を新しい ext ディレクトリに移動して構造を統一し、パス断片化を防止。
 - 'Create New Extension' コマンドで空のファイル名が生成される問題を修正。
 - グローバルホットキーを低レベルキーボードフックに設定できる機能を追加。
 - JUMBO サムネイルのサポートを追加し、高解像度アイコンの利用を可能に。
 - CmdPalがMSALダイアログ表示中に自動的に非表示になりクラッシュする問題を修正。
 - ページロード時に検索テキストを即座に選択できるようにサポートを追加。
 - 拡張設定ページが再オープン時にリロードされないバグを、設定保存時にフォームを更新することで修正。
 - コマンドパレットがランナーから起動できない問題を修正。
 - PowerToys Run v1 の電卓ロジックを Command Palette に移植し、設定サポートとフォールバック動作を改善。
 - リストアイテムのキーボードショートカットサポートを再追加。
 - アクセシビリティを向上（ラベル付与、アニメーション改善、ローカライズ強化、a11y関連修正）。
 - Time and Date プラグインにカスタムフォーマットサポートを移植し、設定順序やエラーメッセージを改善、エッジケースでのクラッシュを修正。Thanks [@htcfreek](https://github.com/htcfreek)!
 - システムコマンドのフォールバックアイテムを追加。
 - Windows System Command で「ごみ箱を開く」アクションのキー表示が「Empty」となっていたバグを修正。Thanks [@jironemo](https://github.com/jironemo)!
 - 「その他のコマンド」リストに表示されるべきでないコマンドが表示される問題を修正。Thanks [@davidegiacometti](https://github.com/davidegiacometti)!
 - 詳細ビューでアイコンが大きすぎたりテキストがずれる問題を修正し、Windows Search の挙動に合わせて調整。
 - 空白の画面やコマンドバーでラベルが長い場合にコンテンツが途切れるバグを修正し、レイアウトと視認性を確保。
 - CmdPal の WinGet 統合を改善し、インストール済みパッケージのバージョン表示やアイコン付きアップデート、winget API の安定版移行を実施。
 - ContentPage 用コマンドが終了後まで更新されない問題を、コンテキストメニューの完全初期化で修正。
 - TimeDate 拡張でのフォールバックサポートを追加し、コマンド事前選択なしで直接日時検索が可能に。
 - CmdPal 複数プロジェクトファイルに Common.Dotnet.AotCompatibility.props のインポートを追加し、AOT コンパイルサポートを強化。
 - settings.json が存在しないまたはホットキー未定義時の CmdPal 設定でのクラッシュを修正。Thanks [@davidegiacometti](https://github.com/davidegiacometti)!
 - CmdPal のフィルタ可能なネストされたコンテキストメニューと検索ボックスのサポートを追加し、フォーカス動作を維持。
 - CmdPal クラスのリファクタリングおよび JSON シリアライゼーション改善、新しいシリアライズコンテキスト導入によるパフォーマンスと保守性向上。
 - AOT（Ahead-of-Time）コンパイルのサポートを追加。
 - CmdPal 起動時のリトライ機構を追加。
 - CmdPal.Common から未使用ファイルを削除し、AOT 対応のためのコードベース整理。
 - SearchText の更新競合で入力ボックスのカーソルが末尾にジャンプするレースコンディションを修正。
 - フォールバックコマンドで任意のファイル検索をサポート。
 - AOT 関連のコードを整理し、テスト時の重複動作を回避。
 - 拡張の起動を並列化し、タイムアウトを追加することで CmdPal のロード時間を短縮し、問題のある拡張によるブロックを防止。
 - リストが空になったときに詳細ペインを閉じて UI 状態の一貫性を保持。
 - マッチするコマンドが見つからなかった場合、CmdPal のフォールバックコマンドを未設定にできるサポートを追加。
 - CmdPal 拡張テンプレートの ComServer の使用不備によるリークを修正。
 - タイトルバーのダブルクリックで CmdPal ウィンドウが最大化されないように修正。Thanks [@davidegiacometti](https://github.com/davidegiacometti)!
 - 設定 UI が小さすぎる問題を DPI 対応と最小幅・高さの強制で修正（WinUIEx 使用）。
 - CmdPal の白いフラッシュや一時的なアニメーション問題を、ウィンドウをクロークすることで修正。
 - 拡張設定が起動時に全て取得されるバグを、拡張設定の遅延ロードによって初期化負荷を軽減。
 - Adaptive Card のパース失敗時の CmdPal クラッシュをガード。
 - CmdPal で shell:AppsFolder を URI アクティベーションに置き換え信頼性向上。
 - PowerToys 設定から CmdPal 設定を開けるように対応。
 - CmdPal が選択項目のプロパティ変更を監視し、拡張詳細を動的に更新できるように。
 - CmdPal 拡張テンプレートのツールキットバージョンを 0.2.0 に更新。

### Image Resizer

 - プリセット削除時に誤ったプリセットが削除される問題を修正。

### Keyboard Manager

 - 左右指定なしで修飾キーを設定した場合、誤ったキー処理によりキーが押しっぱなしになる問題を修正。Thanks [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - 12時間制（AM/PM対応）の時刻フォーマットパターンを追加し、時刻書式機能を強化。Thanks [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - 「Time and Date」プラグインでカスタムフォーマットをサポートし、無効な入力時のエラーメッセージを改善。Thanks [@htcfreek](https://github.com/htcfreek)!
 - WFT のごく初期の日付や、非常に後の日付（例: 31.12.9999）でのクラッシュ2件を修正し、UI 設定を並べ替え。Thanks [@htcfreek](https://github.com/htcfreek)!
 - コマンドの大文字小文字違いでマウスポインタ移動が失敗する問題を小文字化で修正。
 - 'Loading error' および 'Init error' のプラグインエラーメッセージにバージョン詳細を追加。Thanks [@htcfreek](https://github.com/htcfreek)!
 - 結果モデルに使用履歴に基づく並び替えを抑制するサポートを追加し、プラグイン開発者の制御性を向上。Thanks [@CoreyHayward](https://github.com/CoreyHayward) と [@htcfreek](https://github.com/htcfreek)!

### Quick Accent

 - GetDefaultLetterKeyEPO の文字マッピングで VK_U キーの "ǔ" をエスペラント音韻により正確な "ŭ" に置き換え。Thanks [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - オンスクリーンキーボード使用時に Quick Accent が正しく動作しない問題を修正。Thanks [@davidegiacometti](https://github.com/davidegiacometti)!

### Registry Preview

 - ファイルヘッダー記述なしでレジストリキーや値の貼り付けをサポートし、リセットボタンを新規追加。Thanks [@htcfreek](https://github.com/htcfreek)!

### Settings

 - タスクバーで設定アプリのアイコンがランダムに空白になる問題をウィンドウアクティブ化時までアイコン割り当てを遅延させて修正。
 - 「What's New」ウィンドウの最大化機能を追加し、読みやすさを向上。

### Workspaces

 - ウィンドウフィルタリングと Steam URL プロトコル統合により、Steam ゲームが正しくキャプチャ・起動できないバグを修正。

### ドキュメント

 - PowerToys Run のサードパーティープラグインドキュメントに QuickNotes を追加。Thanks [@ruslanlap](https://github.com/ruslanlap)!
 - PowerToys Run のサードパーティープラグインドキュメントに Weather および Pomodoro プラグインを追加。Thanks [@ruslanlap](https://github.com/ruslanlap)!
 - PowerToys Run のサードパーティープラグインドキュメントに Linear プラグインを追加。Thanks [@vednig](https://github.com/vednig)!
 - ドキュメントファイルのフォーマット修正、貢献者とチームメンバー情報の更新。Thanks [@DanielEScherzer](https://github.com/DanielEScherzer) と [@RokyZevon](https://github.com/RokyZevon)!

### 開発

 - GitHub Action を更新し、MSStore リリースサポートのため .NET 9 をインストール。
 - bug_report.yml のバージョンプレースホルダーを更新し、誤った v0.70.0 バージョンが issue レポートに出ないよう修正。
 - GitHub Action の actions/setup-dotnet を v3 から v4 へアップグレード（MSStore リリース用）。
 - WinGet 設定ファイルに securityContext を追加し、ユーザーコンテキストからの呼び出しや、昇格リソースのUACを1回のプロンプトで可能に。Thanks [@mdanish-kh](https://github.com/mdanish-kh)!
 - ログファイル拡張子を .txt から .log に変更し、適切なファイル関連付けやツール互換性をサポート。Workspace 用ログも追加。Thanks [@benwa](https://github.com/benwa)!
 - テストフレームワーク依存関係をアップグレードし、各コンポーネント間でパッケージバージョンを統一。
 - 依存関係をアップグレードし、脆弱性を修正。
 - GitHub Actions と Docker タグを完全長コミットにピン留めし、Dependency Review Workflow による自動脆弱性スキャンを統合してリポジトリのセキュリティを強化。Thanks [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - Boost 依存関係を新しいバージョンにアップグレード。
 - ツールキットを最新版に更新し、AOT 関連の警告を抑制。
 - 新規追加ファイルの署名漏れによるビルド失敗を修正。
 - リリースパイプラインを更新し、100年間プライベートシンボルを公開しないように変更。
 - PowerRename の信頼性向上のためファジングを導入し、他の C++ モジュールにも拡張するためのセットアップガイドを追加。
 - すべての .csproj プロジェクトで生成フォルダの一括事前作成を追加し、ビルド失敗を防止。
 - WinAppSDK を最新の 1.7 バージョンに更新。
 - PowerRename Fuzzing プロジェクトで Boost 依存関係を最新版にアップグレード。
 - tsa.json の ADO エリアパスを更新し、廃止されたパスによる TSA パイプラインエラーを解消。
 - CmdPal の AOT 対応のため基礎作業を開始。
  
### ツール/全般

 - システム情報と診断情報を含む事前入力済みの GitHub issue URL を生成し、バグレポート自動作成をサポート。Thanks [@donlaci](https://github.com/donlaci)!
 - インストーラーをローカルでビルドできるスクリプトを追加し、CmdPal もローカル環境で起動可能に。
 - エクスポート PFX ロジックを削除し、ハードコードされたパスワード利用と PSScriptAnalyzer のセキュリティ警告を解消。
 - PowerShell スクリプトと CI 統合により、src フォルダー配下のすべての C# プロジェクトで Common.Dotnet.CsWinRT.props の一貫利用を強制。
   
### バージョン 0.92 の計画

[v0.92][github-next-release-work] では、以下の項目に取り組みます。

 - Command Palette の継続的な改善
 - 新しい UI オートメーションテスト
 - インストーラーのアップグレード作業
 - Keyboard Manager のエディター UI 強化
 - 安定性向上 / バグ修正

## PowerToys コミュニティ

PowerToys チームは、[素晴らしい活発なコミュニティ][community-link] の支援に心から感謝しています。皆様の活動は非常に重要です。バグ報告、ドキュメント更新、デザインガイド、機能実装など、皆様のご協力なしに現在の PowerToys は成し得ませんでした。月ごとに、PowerToys をより良いソフトウェアに直接進化させてくださっています。本当にありがとうございます。

## 行動規範

本プロジェクトでは [Microsoft オープンソース行動規範][oss-conduct-code] を採用しています。

## プライバシー ステートメント

本アプリケーションは基本的な診断データ（テレメトリ）を記録します。プライバシーや収集内容の詳細については、[PowerToys データとプライバシー ドキュメント](https://aka.ms/powertoys-data-and-privacy-documentation)をご覧ください。

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---