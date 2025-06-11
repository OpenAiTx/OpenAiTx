# Dana wallet

Danaはビットコイン寄付を受け付けるためのFlutterアプリです。オンチェーンのプライバシーを保護しながら寄付を受け取るために、新しい静的支払いプロトコルであるサイレントペイメントを使用しています。

## Dana walletを試す

**Dana walletは現在まだ実験段階です。テストネット/サインネットの使用を推奨します。メインネットでウォレットを試したい場合は、失ってもよい資金のみを使用してください。資金の損失については責任を負いません。**

アプリがより安定したら、一般的なアプリストアでDana walletをリリースする予定です。

それまでは、Dana walletを試す方法は2つあります：

- [リリースページ](https://github.com/cygnet3/danawallet/releases)から最新のDana wallet APKをダウンロードする
- [セルフホストのF-Droidリポジトリ](https://fdroid.silentpayments.dev/fdroid/repo)を使用してDana walletをダウンロードする

### F-Droidを使ったダウンロード

F-Droidオプションを推奨します。自動更新に対応しており、一度設定すれば済みます。

- AndroidスマホでF-Droidを開く
- 「設定」に移動
- 「マイアプリ」セクションの「リポジトリ」をクリック
- 「+」アイコンをクリックして新しいリポジトリを追加
- このページのQRコードをスキャン：https://fdroid.silentpayments.dev/fdroid/repo

これでセルフホストリポジトリが追加されました。アプリをダウンロードするには、F-Droidのアプリストアセクションで「Dana Wallet」を検索します（リストを更新するために、F-Droidストア画面で下にスワイプする必要があるかもしれません）。

## ソースからDana walletをビルドする

以下はDana walletをソースからビルドするための手順です。Dana walletの開発に協力したい場合にのみ推奨します。

### Linux（デスクトップ）向けビルド

Linux向けのビルドは特別な作業は不要で、単に以下を実行します。

```
flutter run
```

これは他のプラットフォーム（macOS、Windows）でも動作する可能性がありますが、テストはしていません。

### Android向けビルド

Androidデバイス向けのビルドには、このアーキテクチャ用のバイナリを生成する準備が必要です。

まず、`cargo-ndk`が必要です。さらに必要に応じて、ツールチェーンを追加します：

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

これらをインストールしたら、rustディレクトリに移動して`just build-android`を実行します。

```
cd rust
just build-android
```

`just`がインストールされていない場合は、`justfile`に記載のコマンドをコピーして実行することもできます。これでバイナリが生成されます。

次に、スマホを接続してデバッグモードを有効にします。接続されているか確認するには、

```
flutter devices
```

を実行してください。

最後に、Androidデバイス向けにビルドしてインストールするには：

```
flutter run
```

## Danaへの寄付

Dana walletへは以下のアドレスで寄付できます：

> ₿donate@danawallet.app

または、以下のサイレントペイメントアドレスを使用してください：

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---