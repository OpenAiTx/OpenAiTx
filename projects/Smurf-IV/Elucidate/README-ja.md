
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [プロジェクト概要](#project-description)
- [システム要件:](#os-requirements)
- [よくある質問](#faqs)
- [ロードマップ](#roadmap)
- [スクリーンショット](#screenshots)

## プロジェクト概要

Elucidateは、コマンドラインSnapRAIDアプリケーションのWindows GUIフロントエンドです。

*このプロジェクトは、私自身と他の貢献者による素晴らしい作業の融合を継続しています。

## システム要件

- Windowsオペレーティングシステム
- .Netランタイム 4.8.0
- SnapRaid バージョン 11.5 以下
- 対象ドライブに10MBの空き容量

## よくある質問

**Q**: SnapRAIDとは何ですか？<br/>
**A**: SnapRAIDは、WindowsおよびLinuxオペレーティングシステム向けのソフトウェア定義型スナップショットパリティエンジンです。最も基本的なレベルでは、構成ファイルのハッシュを計算し、その結果をパリティファイルに保存することで、ファイルシステムの内容を保護します。完全なハードドライブ障害が発生した場合、このパリティファイルを使用して失われたデータを復元できます。詳細はSnapRAIDの[公式ファイル保護エンジン比較](http://snapraid.sourceforge.net/compare.html)をご覧ください。

**Q**: GUIが必要ですか？コマンドラインで十分では？<br/>
**A**: より大きな目標は、ユーザーがSnapRAID環境の維持を支援する追加管理機能を備えた、機能完備のGUIを作成することです。初心者が始める際には「ポイント＆クリック」が簡単な場合もあります。SnapRAIDの技術文書や深い設定は、試してみたい人にとって敷居が高く感じることがあります！

**Q**: まだ不安です。他に情報はありますか？<br/>
**A**: はい、[ドキュメント](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md)に画像などがありますのでご覧ください。

**Q**: 「より大きな目標」とは何ですか？<br/>
**A**: 下記の__ロードマップ__をご覧ください。

## ロードマップ

- [x] フェーズI
  - [x] 最新SnapRAIDの最低サポート維持を目指す - __継続中。__
  - [x] 使いやすさ
  - [x] SnapRAIDには3つのコマンドがあるので、初心者が簡単にアクセスできるように
  - [x] 進行状況インジケーター
  - [x] 「インタラクティブ」ログおよび直接ログ記録
  - [x] ユーザーのログイン時に自動起動
  - [x] ツールチップによるガイド •

- [x] フェーズII フェーズII機能要望
  - [x] 一時停止、優先度変更、中止
  - [x] コマンド拡張 - 「デフォルトで使用されるパラメータに追加パラメータを許可」
  - [x] スケジューリング
    - 削除済み、コマンドラインを使用してください
  - [x] 保護されたデータのグラフィカルビュー

- [ ] フェーズIII（2017-03以降の再始動）
  - [x] 新しいコンパイラと .Net 4.7.x
  - [x] コマンドラインインターフェイス
  - [ ] Krypton Toolkit / Navigator などによる新しいレイアウト
    - 作業中
  - [ ] 翻訳
  - [x] 新しいコマンド
  - [ ] ステータスレポート付きメール送信
  - [ ] テスト手順のドキュメント化
    - 作業中
  - [ ] ドキュメントへの追加／画像の更新
    - 作業中
  - [ ] エラーの _Windows EventLog_ 報告を追加
  - [x] 例外のオンライン報告用に _ExceptionLess_ を追加
  - [x] 復元可能な内容を表示

- [ ] フェーズIV（新しい SnapRAID コマンド？）
  - [ ] ディスク復旧のための拡張ヘルプ - 対話型ガイドなど
  - [ ] SnapRAID のバージョンが古い場合にユーザーへ通知
  - [ ] SnapRAID ログの解釈（以下の変更で使用）
  - [ ] コマンド実行後のアレイのステータスを表示
  - [ ] 初回の diff を含めるよう sync コマンドを修正
  - [ ] diff でしきい値を超える問題が報告された場合に sync コマンドで警告を出すよう修正
  - [ ] sync のしきい値要件をユーザーが設定可能にする

## スクリーンショット

![開始画面](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![設定フォーム](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)

## ご協力いただけますか？
- テスターを募集しています（すべての .Net プラットフォーム）


- 翻訳を手伝うことができます
- ヘルプ／ユーザーインターフェースガイド
- その他のアイデア :-)
- アイデアのための開発者


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---