# Turbodrone
一部のベストセラー約50ドルの「おもちゃ」ドローンをコンピュータから制御するためのリバースエンジニアリングされたAPIとクライアント。これにより、付属のクローズドソースのモバイルアプリを置き換えられます。

![S20 Drone Short Clip](https://raw.githubusercontent.com/marshallrichards/turbodrone/master/docs/images/s20-drone-short-clip-small.gif)

## はじめに
現在、Amazonでは非常に安価な「おもちゃ」ドローンが販売されており、基本的には初期のDJI Mavicの簡易版クローンです。1080pカメラによるFPVと録画、位置および高度保持のための小型の下向き光学フローセンサー、そして調整の行き届いたフライトプロファイルが標準で約50ドルで手に入ります。こうしたドローンの唯一の問題は、クローズドソースのファームウェアで動作し、カスタムのモバイルアプリでのみ制御可能なことです。これらのドローンを「檻」から解放し、モバイルアプリの動作をリバースエンジニアリングして動画フィードへのアクセスや制御コマンドの送信を可能にするAPIとクライアントを作るのは面白いと思いました。こうして、高性能な50ドルの「おもちゃ」ドローンをプログラムで制御できるようにし、さまざまな用途や実験に使えるようになります。

## ハードウェア
* WiFiカメラドローン（推奨順）：

    | ブランド      | モデル番号         | 互換性       | 購入リンク                                                  | 備考  |
    |------------|-----------------|---------------|-------------------------------------------------------------|-------|
    | Karuisrc | K417 | テスト済み | [Amazon](https://www.amazon.com/Electric-Adjustable-AIdrones-Quadcopter-Beginners/dp/B0CYPSJ34H/) | 現在の一番のお気に入り。リストで唯一のブラシレスモーター搭載！ビルド品質が素晴らしい。 |
    | Loiley     | S29             | テスト済み    | [Amazon](https://www.amazon.com/Beginners-Altitude-Gestures-Adjustable-Batteries/dp/B0CFDVKJKC)                  | 最高のビルド品質。カメラ傾斜用のサーボあり（APIにはまだ実装されていません）|
    | Hiturbo    | S20             | テスト済み    | [Amazon](https://www.amazon.com/dp/B0BBVZ849G), [別のAmazonリスト](https://www.amazon.com/Beginners-Foldable-Quadcopter-Gestures-Batteries/dp/B0D8LK1KJ3)                  | 元のテストプラットフォーム、優れたビルド品質|
    | FlyVista | V88 | テスト済み | [Amazon](https://www.amazon.com/dp/B0D5CXY6X8) | |
    | ? | D16/GT3/V66 | テスト済み | 最安値は[Aliexpress](https://www.aliexpress.us/item/3256808590663347.html)、[Amazon](https://www.amazon.com/THOAML-Batteries-Altitude-Headless-360%C2%B0Flip/dp/B0F1D6F62J/) | DJI Neoクローンの20％小型。主に屋内飛行向け。 
    | 複数ブランド | E58 | テスト済み | [Amazon](https://www.amazon.com/Foldable-Quadcopter-Beginners-Batteries-Waypoints/dp/B09KV8L7WN/) |  |
    | 複数ブランド | E88/E88 Pro | 推定       | [Amazon](https://www.amazon.com/Foldable-Camera-Quadcopter-Altitude-Beginner/dp/B0DZCLFQXN) | |
    | 複数ブランド | E99/E99 Pro | 推定       | [Amazon](https://www.amazon.com/LJN53-Foldable-Drone-Dual-Cameras/dp/B0DRH9C6RF) | |
    | Swifsen | A35 | 推定       | [Amazon](https://a.co/d/bqKvloz) | とても小さい「おもちゃ」ドローン|
    | 不明 | LSRC-S1S | 推定       | | WiFi UAVアプリの別のリバースエンジニアリングで言及あり|
    | Velcase    | S101            | 未対応      | [Amazon](https://www.amazon.com/Foldable-Beginners-Quadcopter-Carrying-Positioning/dp/B0CH341G5F/)  | S29やS20よりビルド品質が低く、バッテリーとプロペラも小さい|
    | Redrie | X29 | 未対応      | [Amazon](https://www.amazon.com/Adults-1080P-Foldable-Altitude-Auto-Follow-Batteries/dp/B0CZQKNYL5) | 現在対応中|

    _**テスト済み**は、実際にturbodroneで動作確認済みのドローンを示します。_

  _**推定**は、ドローンのAPKがテスト済みドローンと同じパッケージとライブラリを使用していると思われる場合を示します。_

  _**未対応**は、APKが異なるバイトパケットやプロトコルを使用しており、APIに新たな実装として追加する必要があることを示します。_

* WiFiドングル（[ALFA Network AWUS036ACM](https://www.amazon.com/Network-AWUS036ACM-Long-Range-Wide-Coverage-High-Sensitivity/dp/B08BJS8FXD)などの推奨品） 
  * ドローンは自身のWiFiネットワークをブロードキャストするため、コンピュータはそれに接続する必要があります。
  * コンピュータ内蔵のWiFiでも接続可能ですが、その場合はドローン飛行中にインターネット接続が切れる可能性があるため、ドングルを使うとインターネット接続を維持しやすく便利です。


## セットアップ
`backend`ディレクトリに移動してください
```
cd backend
```
venvを追加

```
python -m venv venv
source venv/bin/activate
```
依存関係をインストールする

```
pip install -r requirements.txt
```
_もし_ あなたがWindowsを使用している場合は、`curses`ライブラリを手動でインストールする必要があります。

```
pip install windows-curses
```
新しいターミナルウィンドウを開き、フロントエンドの依存関係をインストールします。  
_Node.js 20以上がインストールされていることを確認してください。_

```
cd frontend
npm install
```

WiFiドングルが接続されていること、ドローンの電源が入っていること、そして「BRAND-MODEL-XXXXXX」ネットワークに接続されていることを確認してください。

`backend` ディレクトリに `.env` ファイルを作成します。お持ちのドローンに基づいて DRONE_TYPE を追加してください：
```
# For "com.vison.macrochip" (s2x) based drones like S20 and S29:
DRONE_TYPE=s2x
# For WiFi UAV-based drones like V88 and D16:
# DRONE_TYPE=wifi_uav 
```

バックエンドを起動する: 
```
uvicorn web_server:app
```
別のターミナルで、フロントエンドのウェブクライアントを起動します:

```
npm run dev
```
`http://localhost:5173` にあるウェブクライアントを開くと、ドローンのビデオフィードが表示され、操作が可能です。

ゲームコントローラーで操作するには、コントローラーを接続してスティックを動かし検出させ、その後トグルボタンを押してキーボードとコントローラーの操作を切り替えます。

安全な場所で飛行してください。できれば風の少ない屋外が望ましいです。また、「着陸」ボタンは _現在_ モーターを即座に停止する緊急停止ボタンの役割を持っています。


## ステータス
再接続のロジックは最近解決されました。

ビデオフィード：安定しています。

操作：ウェブクライアント経由で大幅に改善されました。WiFi UAVベースのドローンに関しては、微調整が必要です。

ウェブクライアント：キーボード、ゲームパッドコントローラー、ThinkPad TrackPointマウス（笑）など様々な入力に対応しています。

[Amazonのベストセラードローンリスト](https://www.amazon.com/best-selling-drones/s?k=best+selling+drones)から、より多くのドローンのサポート追加に取り組んでいます。


## 貢献について
新しい「おもちゃ」ドローンのサポートを追加するには、そのドローンが使用するAPKをミラーサイトからダウンロードし、[jadx](https://github.com/skylot/jadx)でJavaファイルにデコンパイルしてリバースエンジニアリングを開始します。
そこから、`AndroidManifest.xml`を確認し、アプリのエントリーポイントとなるクラスを探します。TCPやUDPなど明示的に使用されているポートやプロトコルを探してください。多くのアプリは、APK内に埋め込まれたネイティブのC++ライブラリで実際の通信やビデオフィード処理を行っています。Ghidraなどのツールを使ってネイティブライブラリをデコンパイルし、有用な情報を見つけられるか調べてください。ビデオフィード処理に関しては、JPEG、YUVなどの使用フォーマット、圧縮の有無、およびパケットから画像フレームを再構成する際のバイト構造を把握することが重要です。
さらに、Wiresharkはアプリが送受信する生データパケットの理解に役立ちます。[こちらの動画](https://x.com/marshallrichrds/status/1923165437698670818)はHiturbo S20ドローンのサポート追加に用いたリバースエンジニアリングの概要を示しています。

RCとビデオのプロトコルと処理が分かったら、小さなテストプログラムを作成し、他の人が試せるように `experimental` ディレクトリに追加してください。
その後、既存のバックエンドアーキテクチャに対応した実装に取り組むことができます。例としては、リバースエンジニアリングされた `s2x` や `wifi_uav` の実装があります。


## 実験的サポート
完全にTurbodroneに統合されていない限定的なサポートのドローンやアプリは、`experimental` ディレクトリをご覧ください。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-29

---