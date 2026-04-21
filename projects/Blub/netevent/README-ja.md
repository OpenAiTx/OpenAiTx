# netevent

Neteventは、Linuxのイベントデバイスを他のマシンと共有するために使用できるツールです（`/dev/uinput`を介して、または同じプロトコルのクライアントを他の方法で実装することにより）。

元々は単にデバイスの機能をstdoutにダンプし、その後はあるモードで`cat /dev/input/eventX`を実行しているように振る舞い、別のモードでは解析された機能を`/dev/uinput`に渡し、イベントを通過させていました。

複数のデバイスを管理する場合、宛先が複数あると面倒になるため（また、元のgrab/toggle/hotkey機構は奇妙で、文字通り私の個人的なユースケースを対象としていたため）、netevent2ではプロトコルを拡張し、複数のデバイスを含むパケットを扱い、デバイスの追加や削除を動的に行えるようにしました。

元の`cat`のような動作（現在はホットキーサポートなし）もデバッグ目的で利用可能であり、`create`モードは両方のプロトコルバージョンをサポートしています。

現在のメインツールは`netevent daemon`で、コマンドソケット（オプションで抽象Unixソケット）を持ち、これを介してデバイス、出力、ホットキーを動的に追加できます。下記の例を参照してください。

## コンパイル

* 任意で：`./configure --prefix=/usr`
* `make`

従来通り単に`make`を実行することも可能です。ただし、通常のインストールフローをサポートし、`/dev/uinput`が`UI_DEV_SETUP` ioctlで拡張されている新しいカーネルを持つシステムを区別するために、`./configure`スクリプトが追加されました。これにより、`config.h`およびPREFIX/BINDIR/...用の`config.mak`が作成されます（これらは通常の`DESTDIR`とともに、変数として直接`make`に渡すことも可能です）。

## インストール

* `make install` または `make DESTDIR=/my/staging/dir install`


















または、前述のように `netevent` バイナリを任意の場所に置くだけでも構いません。

## 使用方法

以下のセットアップスクリプトで使用されるコマンドの詳細は、netevent(1) の DAEMON COMMANDS セクションを参照してください。

### 例

`examples/` ディレクトリを参照してください。以下の setup-example を読んで、ホットキーの行をどのようにデバイスに合わせて調整するか確認してください。

#### 簡単なセットアップ例：ssh 経由でキーボードとマウスを共有する場合：

ホスト側：

* 準備：ユーザーとしてイベントデバイスにアクセスできることを確認する

    通常は `gpasswd -a myuser input` のようなコマンドを実行します。

* ステップ1：どの /dev/input/eventXY デバイスをパススルーするか決める。

    一貫したファイル名を使うには、以下のようなものを使用します：
    `/dev/input/by-id/usb-MyAwesomeKeyboard-event-kbd`
    `/dev/input/by-id/usb-BestMouseEver-event-mouse`

* ステップ2：ホットキーを決め、そのイベントコードを見つける：

    上記の例では、キーボードのキーを使いたい（マウスボタンが非常に多くない限り）。
    `netevent` はイベントを読みやすくダンプするために使えます。`show` サブコマンドを
    デバイスで実行し、ホットキーに使いたいキーを押してください。
    コマンドを入力しているのと同じキーボードの場合、netevent が Enter キーのリリースを
    取得して混乱しないように、実行前に sleep を入れてください。





    ```
    $ sleep 0.3 && netevent show /dev/input/by-id/usb-...-event-kbd
    MSC:4:3829
    KEY:189:1
    SYN:0:0
    MSC:4:3829
    KEY:189:0
    SYN:0:0
    ```

* ステップ3: デーモン用のセットアップスクリプトを準備します:

    ```
    # file: netevent-setup.ne2
    # Add mouse & keyboard
    device add mymouse /dev/input/by-id/usb-BestMouseEver-event-mouse
    device add mykbd /dev/input/by-id/usb-MyAwesomeKeyboard-event-kbd

    # Add toggle hotkey (on press, and ignore the release event)
    hotkey add mykbd key:189:1 grab-devices toggle\; write-events toggle
    hotkey add mykbd key:189:0 nop

    # Connect to the two devices via password-less ssh
    output add myremote exec:ssh user@other-host netevent create
    # Select the output to write to
    use myremote
    ```

* ステップ4: neteventデーモンを実行します：

    `$ netevent daemon -s netevent-setup.ne2 netevent-command.sock`

これで、ソケットに接続してデーモンに追加のコマンドを送信できます。
例えば、`socat READLINE UNIX-CONNECT:netevent-command.sock`を使って接続します。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---