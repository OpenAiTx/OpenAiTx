
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=till213&project=SkyDolly&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

[![プレリリース](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![ライセンス: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![対応コンパイラ](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![ユニットテスト](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - あなたのフライト記録のためのブラックシープ。

## 概要
Sky Dollyは、実行中のFlight Simulator 2020インスタンスに接続し、様々なシミュレーション変数を記録して再生します。

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

接続はSimConnect経由で行われます。SimConnectはFlight Simulator Xから導入された、フライトシミュレーターとの接続用標準APIです。

詳細は [ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.md) もご参照ください。

## 機能
- 記録 / 一時停止 / 再生
- フォーメーションフライト（複数機、記録中の再生、フォーメーション飛行、時間オフセット）
- 記録サンプルレートの設定：固定または可変（「自動」）
- 再生速度の調整（「スローモーション」、「タイムラプス」）、再生ループ
- 位置、速度、基本的なフライトコントロールのシミュレーション変数（エルロン、ラダー、フラップ、ギア等）を記録
- 各種インポート/エクスポートプラグインによるプラグインアーキテクチャ（CSV、GPX、IGC、KML）
- 100以上のデフォルトロケーションとインポート/エクスポート機能を備えたロケーションモジュール
- データベース（SQLite）による永続化機能（「ログブック」）

（プレビュー）リリーストレーラーを [YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I) でご覧ください：

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

Sky Dollyで作成された他の動画については [SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md) もご参照ください。新機能や近日公開予定の機能は [CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md) に記載されています。

## 基本的な使い方

- フライトを開始する
- 「記録」ボタンをクリック（キーR）
- 記録を一時停止できます（キーP）
- 記録を停止（キーR）して「再生」ボタンをクリック（スペースキー）
- 再生速度の調整や再生位置の移動は、再生中にも可能
- 記録されたフライトは自動的に「ログブック」に保存されます
- ログブックでフライトを選択し、「ロード」ボタンを押す（または行をダブルクリック）ことで保存されたフライトをロードできます

### フォーメーション記録と再生

#### 録画

- 「編隊」モジュールに切り替えます（F2キー）
- 「録画」をクリックします（Rキー）
- 録画された各航空機は現在のフライトに追加されます
- 録画中に「自動」サンプルレートで既存の航空機が再生されている間でも、録画サンプルレートを変更できます

#### 位置

- 最後に録画された航空機が「ユーザー航空機」になります（フライトシミュレーターでカメラが追従します）
- 録画前に現在の「ユーザー航空機」に対する相対位置を選択します

#### リプレイ

- 「再生」「一時停止」をクリックし、タイムラインをシークするだけで、単一航空機のフライトと同様に操作できます
- 「ユーザー航空機」を変更して（リプレイ中も可能）、「コックピット間をジャンプ」できます
- 「ユーザー航空機」の操作を「操作を引き継ぐ」または「編隊で飛行」オプションで行えます

#### 編隊の管理

- フライト（「編隊」）から個々の航空機を削除できます
- フライトには少なくとも1機の航空機が必要なため、最後の航空機は削除できません
- 選択した航空機に時間オフセットを追加します（「マルチプレイヤー編隊飛行の同期」）
- 新しい単一航空機のフライトを開始するには、「ログブック」モジュール（F1キー）に戻り、「録画」（Rキー）をクリックします

ガイド付きの["Tell Tours"](https://github.com/till213/Tell-Tours)で試してみませんか？ :)

## ダウンロード

[Releases](https://github.com/till213/SkyDolly/releases)にアクセスして、最新版をダウンロードしてください。

最新（プレ）リリース: **Sky Dolly 0.19.2**

ダウンロードしたファイルの整合性を確認するため、[公開されているSHA-256チェックサム](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md)と照合してください。

## ビルド

[BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md)ドキュメントを参照してください。

## 関連プロジェクト

- https://github.com/nguyenquyhy/Flight-Recorder - .Netベースのフライト記録＆リプレイアプリケーション
- https://github.com/saltysimulations/saltyreplay/ - Webユーザーインターフェース付きの記録＆リプレイ
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - フライトを記録し、Google Earth（KML形式）用の「リプレイ」を生成
- https://github.com/Elephant42/FS_Tool - 航空機の位置とシミュレーション速度を設定できるシンプルなツール
- https://github.com/pyviator/msfs-geoshot - スクリーンショットを撮影し、自動的に「ジオタグ」付け
- https://github.com/ijl20/msfs_logger_replay - IGCロガーとリプレイ（FSX用）
- https://joinfs.net/ - MSFS、Prepar3D/FSX、XPlaneなど異なるフライトシミュレーター間でマルチプレイヤーフライトを同期。編隊飛行記録（「オーバーダブ」）付きフライトレコーダーも提供。
- https://github.com/paulalexandrow/a32nx-webremote - FlyByWireのA32NX用WebRemote：FSUIPC7を使用してFBW A320のコックピット機能を操作
- https://flightloganalyzer.com/ - FlightLog AnalyzerはMSFSのログブックを解析し、Sky Dollyで読み取れるCSVエクスポートを提供
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSaveはフライトプランを自動（または手動）保存
- https://github.com/mracko/MSFS-Landing-Inspector - 着陸パフォーマンスを分析
- [Points of Interest (Google Maps)](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Microsoft Flight Simulatorの観光地、空港、3D都市。

## その他の便利なリソース

- https://obsproject.com/ - 画面キャプチャ／配信アプリケーション
- https://sqlitebrowser.org/ - Sky Dollyのログブック（*.sdlog）データベースファイルの閲覧や独自SQLクエリの実行


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---