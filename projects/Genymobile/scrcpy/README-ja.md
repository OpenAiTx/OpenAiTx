**このGitHubリポジトリ（<https://github.com/Genymobile/scrcpy>）が本プロジェクトの唯一の公式ソースです。  
`scrcpy`という名前が含まれていても、無作為なウェブサイトからリリースをダウンロードしないでください。**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_発音は "**scr**een **c**o**py**"（スクリーン・コピー）_

このアプリケーションは、USBまたは[TCP/IP](doc/connection.md#tcpip-wireless)経由で接続されたAndroidデバイス（ビデオとオーディオ）をミラーリングし、コンピューターのキーボードとマウスで操作できるようにします。_root_権限やデバイスへのアプリのインストールは不要です。_Linux_、_Windows_、_macOS_で動作します。

![screenshot](assets/screenshot-debian-600.jpg)

主な特徴は次の通りです:

 - **軽量**: ネイティブで、デバイス画面のみを表示
 - **高パフォーマンス**: デバイスにより30～120fps
 - **高品質**: 1920×1080以上
 - **低遅延**: [35～70ms][lowlatency]
 - **高速起動**: 最初の画像表示まで約1秒
 - **非侵襲性**: Androidデバイスに何もインストールされません
 - **ユーザー利益**: アカウント不要、広告なし、インターネット不要
 - **自由**: 無料かつオープンソースソフトウェア

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

主な機能には次が含まれます:
 - [オーディオ転送](doc/audio.md)（Android 11以降）
 - [録画](doc/recording.md)
 - [仮想ディスプレイ](doc/virtual_display.md)
 - [Androidデバイスの画面オフ状態でのミラーリング](doc/device.md#turn-screen-off)
 - [双方向のコピーペースト](doc/control.md#copy-paste)
 - [画質の設定可能](doc/video.md)
 - [カメラミラーリング](doc/camera.md)（Android 12以降）
 - [Webカメラ（V4L2）としてのミラーリング](doc/v4l2.md)（Linux限定）
 - 物理[キーボード][hid-keyboard]および[マウス][hid-mouse]のシミュレーション（HID）
 - [ゲームパッド](doc/gamepad.md)対応
 - [OTGモード](doc/otg.md)
 - その他多数…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## 前提条件

AndroidデバイスはAPI 21（Android 5.0）以上が必要です。

[オーディオ転送](doc/audio.md)はAPI 30（Android 11以降）でサポートされます。

デバイスで[USBデバッグを有効][enable-adb]にしてください。

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

一部のデバイス（特にXiaomi）では、次のエラーが表示されることがあります:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

この場合、[追加オプション][control]「USBデバッグ（セキュリティ設定）」  
（`USBデバッグ`とは異なる項目です）を有効にして、キーボードやマウスで操作できるようにしてください。  
このオプション設定後は、デバイスの再起動が必要です。

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

なお、[OTGモード](doc/otg.md)でscrcpyを実行する場合、USBデバッグは不要です。


## アプリの入手

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md)（[実行方法](doc/windows.md#run)を参照）
 - [macOS](doc/macos.md)


## 必須のヒント

 - [解像度を下げる](doc/video.md#size)ことでパフォーマンスが大幅に向上する場合があります  
   （`scrcpy -m1024`）
 - [_右クリック_](doc/mouse.md#mouse-bindings)で`BACK`をトリガー
 - [_ミドルクリック_](doc/mouse.md#mouse-bindings)で`HOME`をトリガー
 - <kbd>Alt</kbd>+<kbd>f</kbd>で[全画面表示](doc/window.md#fullscreen)の切り替え
 - その他にも多くの[ショートカット](doc/shortcuts.md)があります


## 使用例

多くのオプションがあり、[個別ページ](#user-documentation)で説明されています。
ここでは一般的な例を紹介します。

 - H.265で画面をキャプチャし（高画質）、サイズを1920に制限し、フレームレートを60fpsに制限、オーディオを無効にし、物理キーボードをシミュレートしてデバイスを操作:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # ショートバージョン
    ```

 - 新しい仮想ディスプレイ（デバイスディスプレイとは別）でVLCを起動:

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - デバイスのカメラをH.265で1920x1080（およびマイク）でMP4ファイルに録画:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - デバイスのフロントカメラをキャプチャし、コンピューター上でWebカメラとして公開（Linuxの場合）:

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - ミラーリングせず、物理キーボードおよびマウスをシミュレートしてデバイスを操作（USBデバッグ不要）:

    ```bash
    scrcpy --otg
    ```

 - コンピューターに接続したゲームパッドでデバイスを操作:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # ショートバージョン
    ```

## ユーザードキュメント

本アプリケーションは多くの機能や設定オプションを備えています。  
それぞれ次のページで説明されています。

 - [接続](doc/connection.md)
 - [ビデオ](doc/video.md)
 - [オーディオ](doc/audio.md)
 - [操作](doc/control.md)
 - [キーボード](doc/keyboard.md)
 - [マウス](doc/mouse.md)
 - [ゲームパッド](doc/gamepad.md)
 - [デバイス](doc/device.md)
 - [ウィンドウ](doc/window.md)
 - [録画](doc/recording.md)
 - [仮想ディスプレイ](doc/virtual_display.md)
 - [トンネル](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [カメラ](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [ショートカット](doc/shortcuts.md)


## リソース

 - [FAQ](FAQ.md)
 - [翻訳][wiki]（最新ではない場合があります）
 - [ビルド手順](doc/build.md)
 - [開発者向け](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki


## 記事

- [Introducing scrcpy][article-intro]
- [Scrcpyがワイヤレスで動作するようになりました][article-tcpip]
- [オーディオ対応のScrcpy 2.0][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## お問い合わせ

バグ報告、機能要望、一般的な質問は[issue]を作成してください。

バグ報告の場合、まず[FAQ](FAQ.md)をお読みください。すぐに解決策が見つかるかもしれません。

[issue]: https://github.com/Genymobile/scrcpy/issues

また、以下も利用できます:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)


## 寄付

私は[@rom1v](https://github.com/rom1v)、_scrcpy_ の作者兼メンテナーです。

このアプリケーションを気に入っていただけたら、私のオープンソース活動を[サポート][donate]していただけると幸いです。
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## ライセンス

    Copyright (C) 2018 Genymobile
    Copyright (C) 2018-2025 Romain Vimont

    本ソフトウェアは、Apache License, Version 2.0（以下「ライセンス」）の下でライセンスされています。
    ライセンスに従わない限り、このファイルを使用することはできません。
    ライセンスのコピーは下記から入手できます。

        http://www.apache.org/licenses/LICENSE-2.0

    適用法または書面による同意がない限り、本ソフトウェアは「現状のまま」提供され、
    明示または黙示を問わず、いかなる保証もありません。
    ライセンスの下で許可される範囲を除き、本ソフトウェアの使用またはその他の取引に起因する
    いかなる責任も負いません。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---