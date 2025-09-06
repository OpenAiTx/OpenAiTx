[![プレリリース](https://img.shields.io/github/v/tag/till213/skydolly?include_prereleases&label=Pre-Release)](https://github.com/till213/skydolly/releases)
![ライセンス: MIT](https://img.shields.io/badge/%E2%9A%96%EF%B8%8F%20License-MIT-brightgreen)
![C++20](https://img.shields.io/badge/C%2B%2B-20-%2300599C?logo=cplusplus)
![対応コンパイラ](https://img.shields.io/badge/%E2%9A%99%EF%B8%8F%20Compilers-GCC%2C%20clang%2C%20MSVC-informational)

![ユニットテスト](https://github.com/till213/SkyDolly/actions/workflows/unit-tests.yml/badge.svg?event=push)

# Sky Dolly
Sky Dolly - あなたのフライト録画のためのブラックシープ。

## 概要
Sky Dollyは起動中のFlight Simulator 2020インスタンスに接続し、さまざまなシミュレーション変数を記録してリプレイします。

![Sky Dolly v0.11.0](https://raw.githubusercontent.com/till213/SkyDolly/main/./img/SkyDolly-v0.11.0.png)

接続はFlight Simulator Xで導入された標準APIであるSimConnectを介して行われます。

また[ABOUT.md](https://raw.githubusercontent.com/till213/SkyDolly/main/ABOUT.MD)も参照してください。

## 機能
- 録画 / 一時停止 / 再生
- フォーメーション飛行（複数機体、録画中のリプレイ、「フォーメーション飛行」、時間オフセット）
- 設定可能な録画サンプルレート：固定または可変（「自動」）
- 調整可能な再生速度（「スローモーション」、「タイムラプス」）、リプレイループ
- 位置、速度および基本的な飛行制御シミュレーション変数（エルロン、ラダー、フラップ、ギアなど）を記録
- CSV、GPX、IGC、KMLなどの各種インポート/エクスポートプラグインによるプラグインアーキテクチャ
- 100以上のデフォルトロケーションとインポート/エクスポート機能を持つロケーションモジュール
- データベース（SQLite）ベースの永続性（「ログブック」）

（プレビュー）リリーストレーラーは[YouTube](https://www.youtube.com/watch?v=_n4qRtm78_I)でご覧いただけます：

[![Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)](https://img.youtube.com/vi/_n4qRtm78_I/0.jpg)](https://www.youtube.com/watch?v=_n4qRtm78_I "Sky Dolly - Flight Recorder & Replay for Flight Simulator 2020 (Cinematic Teaser Trailer)")

Sky Dollyで作成された他の動画は[SHOWCASE](https://raw.githubusercontent.com/till213/SkyDolly/main/SHOWCASE.md)も参照してください。新機能や今後の機能は[CHANGELOG](https://raw.githubusercontent.com/till213/SkyDolly/main/CHANGELOG.md)にあります。

## 基本的な使い方

- フライトを開始する
- 「録画」ボタンをクリック（キーR）
- 録画を一時停止できます（キーP）
- 録画を停止する（キー R）して、「再生」（スペースバー）をクリック  
- 再生速度を調整し、再生中でも再生位置をシーク可能  
- 録画されたフライトは自動的に「ログブック」に保存される  
- ログブックでフライトを選択し、「読み込み」（または行をダブルクリック）して保存されたフライトを読み込む  

### 編隊録画＆再生  

#### 録画  

- 「編隊」モジュールに切り替える（キー F2）  
- 「録画」をクリック（キー R）  
- 録画された各航空機は現在のフライトに追加される  
- 録画中に既存の航空機が「自動」サンプルレートで再生されている間も録画サンプルレートを変更可能  

#### 位置  

- 最後に録画された航空機が「ユーザー航空機」（フライトシミュレーター内でカメラが追跡）になる  
- 録画前に現在の「ユーザー航空機」からの相対位置を選択  

#### 再生  

- 単一航空機のフライトと同様に「再生」「一時停止」をクリックし、タイムラインをシークするだけ  
- 「ユーザー航空機」を変更（再生中も可能）して「コックピットからコックピットへジャンプ」  
- 「制御を取得」または「編隊で飛行」オプションを選択して「ユーザー航空機」の操作を引き継ぐ  

#### 編隊の管理  

- フライト（「編隊」）から単一航空機を削除可能  
- フライトには少なくとも1機の航空機が必要なため、最後の航空機は削除できない  
- 選択した航空機に時間オフセットを追加（「マルチプレイヤー編隊フライト同期」）  
- 新しい単一航空機のフライトを開始するには、「ログブック」モジュール（キー F1）に戻り、「録画」（キー R）をクリック  

ガイド付きの["Tell Tours"](https://github.com/till213/Tell-Tours)の一つで試してみませんか？ :)  

## ダウンロード  

[Releases](https://github.com/till213/SkyDolly/releases)にアクセスして最新リリースをダウンロードしてください。  

最新（プレ）リリース: **Sky Dolly 0.19.2**

ダウンロードしたコピーの整合性を検証するために、[公開されているSHA-256チェックサム](https://raw.githubusercontent.com/till213/SkyDolly/main/SHASUM256.md)と照合してください。

## ビルド

[BUILD](https://raw.githubusercontent.com/till213/SkyDolly/main/BUILD.md)ドキュメントを参照してください。

## 関連プロジェクト

- https://github.com/nguyenquyhy/Flight-Recorder - .Netベースの飛行記録＆リプレイアプリケーション
- https://github.com/saltysimulations/saltyreplay/ - ウェブユーザーインターフェースを備えた記録＆リプレイ
- https://github.com/SAHorowitz/MSFS2020-PilotPathRecorder - 飛行を記録し、Google Earth（KML形式）の「リプレイ」を生成
- https://github.com/Elephant42/FS_Tool - 飛行機の位置とシミュレーション速度を設定するシンプルなツール
- https://github.com/pyviator/msfs-geoshot - スクリーンショットを撮り、自動的に「ジオタグ」を付与
- https://github.com/ijl20/msfs_logger_replay - IGCロガーおよびリプレイ（FSX用）
- https://joinfs.net/ - 異なるフライトシミュレーター（MSFS、Prepar3D/FSX、XPlane）間でのマルチプレイヤーフライト同期を可能にし、フォーメーション飛行記録（「オーバーダブ」）付きのフライトレコーダーも提供
- https://github.com/paulalexandrow/a32nx-webremote - FlyByWireのA32NX用WebRemote：FSUIPC7を使用してFBW A320のコックピット機能を制御
- https://flightloganalyzer.com/ - FlightLog AnalyzerはMSFSログブックを解析し、Sky Dollyで読み取れるCSVエクスポートを提供
- https://github.com/BojoteX/FSAutoSave/ - FSAutoSaveはフライトプランを自動的に（または要求時に）保存
- https://github.com/mracko/MSFS-Landing-Inspector - 着陸パフォーマンスを解析
- [注目ポイント（Google Maps）](https://www.google.com/maps/d/viewer?mid=1KUg5jwyT_9k2A9n5IZ99UChlhfVUfO5S&ll=-3.81666561775622e-14%2C-23.028915134521867&z=1) - Microsoft Flight Simulatorの注目ポイント、空港、3D都市

## その他の便利なリソース

- https://obsproject.com/ - 画面キャプチャ／配信アプリケーション
- https://sqlitebrowser.org/ - Sky Dollyログブック（*.sdlog）データベースファイルを閲覧し、自分のSQLクエリを実行可能


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---