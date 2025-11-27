# Elucidate

- [プロジェクト説明](#project-description)
- [システム要件](#os-requirements)
- [よくある質問](#faqs)
- [ロードマップ](#roadmap)
- [スクリーンショット](#screenshots)

## Project Description

ElucidateはコマンドラインのSnapRAIDアプリケーション用のWindows GUIフロントエンドです。

*このプロジェクトは私自身と他の貢献者による素晴らしい作業の融合を継続しています。

## System Requirements

- Windowsオペレーティングシステム
- .Net Runtime 4.8.0
- SnapRaid バージョン11.5以下
- 対象ドライブに10MBの空き容量

## FAQs

**Q**: SnapRAIDとは何ですか？<br/>
**A**: SnapRAIDはWindowsおよびLinuxオペレーティングシステム向けのソフトウェア定義スナップショットパリティエンジンです。基本的には、管理下のファイルシステムの内容を保護するために、その構成ファイルのハッシュを計算し、結果をパリティファイルに保存します。完全なハードドライブ障害が発生した場合、このパリティファイルを使用して失われたデータを復元できます。詳細については、SnapRAIDの[公式ファイル保護エンジン比較](http://snapraid.sourceforge.net/compare.html)をご覧ください。

**Q**: なぜGUIが必要なのですか？コマンドラインで十分では？<br/>
**A**: 大きな目標は、機能が完全なGUIを作成し、SnapRAID環境の維持を支援する追加の管理機能を提供することです。初心者が始めやすいように「ポイントアンドクリック」が時に便利です。SnapRAIDの技術文書や高度な設定は、試してみたい人にとっては敷居が高く感じられることがあります！

**Q**: まだ不明な点があります。もっとありますか？<br/>
**A**: はい、[ドキュメント](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md)で画像などを参照してください。

**Q**: 「大きな目標」とは何ですか？<br/>
**A**: 完全な内訳は下記の__ロードマップ__をご覧ください。

## Roadmap

- [x] フェーズI
  - [x] 最新のSnapRAIDの最小サポートに追随する試み。 - __進行中。__
  - [x] 使いやすさ
  - [x] SnapRAIDには3つのコマンドがあるので、初心者が簡単にアクセスできるようにします 
  - [x] 進行状況インジケーター 
  - [x] ロギング「インタラクティブ」と直接ログへ。 
  - [x] ユーザーログイン時の自動起動 
  - [x] ツールチップで案内 •

- [x] フェーズII フェーズIIの機能要求
  - [x] 一時停止、優先度変更、中止。
  - [x] コマンド拡張 - 「デフォルトで使用される追加パラメータを許可する。」
  - [x] スケジューリング 
    - 削除、コマンドラインを使用
  - [x] 保護データのグラフィカルビュー。

- [ ] フェーズIII（2017-03以降の再開）
  - [x] 新しいコンパイラーと .Net 4.7.x	
  - [x] コマンドラインインターフェース
  - [ ] Krypton Toolkit / Navigator / その他による新レイアウト 
    - 進行中
  - [ ] 翻訳 
  - [x] 新コマンド
  - [ ] ステータスレポート付きメール送信機能
  - [ ] テスト手順の文書化
    - 進行中
  - [ ] ドキュメントへの追加 / 画像の更新
    - 進行中
  - [ ] _Windows EventLog_ でのエラー報告の追加
  - [x] 例外のオンライン報告のための _ExceptionLess_ の追加
  - [x] 回復可能な内容の表示。 

- [ ] フェーズIV（新しいSnapRAIDコマンド？） 
  - [ ] ディスク回復を含む拡張ヘルプ - インタラクティブガイドなど 
  - [ ] SnapRAIDのバージョンが古い場合にユーザーに通知
  - [ ] SnapRAIDログの解釈（以下の変更で使用）
  - [ ] コマンド実行後のアレイの状態提供
  - [ ] syncコマンドを初期差分を含むように修正
  - [ ] 差分が閾値を超える問題を報告した場合に警告を出すようsyncコマンドを修正
  - [ ] sync閾値要件のユーザー設定可能な設定を追加


## スクリーンショット

![Starting View](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Settings Form](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## お手伝いいただけますか？ 
- テスター募集（すべての .Net プラットフォーム） 
- 翻訳の支援 
- ヘルプ / ユーザーインターフェースガイド 
- その他のアイデア :-) 
- アイデアのための開発者募集 


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-27

---