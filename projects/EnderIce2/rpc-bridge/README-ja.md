
# Wine用Discord RPCブリッジ

![GitHub License](https://img.shields.io/github/license/EnderIce2/rpc-bridge?style=for-the-badge)
![GitHub Downloads (all assets, all releases)](https://img.shields.io/github/downloads/EnderIce2/rpc-bridge/total?style=for-the-badge)
![GitHub Release](https://img.shields.io/github/v/release/EnderIce2/rpc-bridge?style=for-the-badge)

WineのゲームやソフトウェアでDiscordリッチプレゼンスを使用可能にするシンプルなブリッジ。

バックグラウンドで小さなプログラムを実行し、プレフィックス内に[named pipe](https://learn.microsoft.com/en-us/windows/win32/ipc/named-pipes) `\\.\pipe\discord-ipc-0`を作成し、すべてのデータをパイプ`/run/user/1000/discord-ipc-0`へ転送します。

このブリッジはWineのWindowsサービス実装を活用し、手動でプログラムを実行する必要をなくしています。

---

## インストールと使用方法

インストールは自身を`C:\windows\bridge.exe`にコピーし、Windowsサービスを作成します。  
ログは`C:\windows\logs\bridge.log`に保存されます。

#### プレフィックス内へのインストール

##### Wine (~/.wine)

- `bridge.exe`をダブルクリックし「Install」をクリック。
    - ![gui](https://raw.githubusercontent.com/EnderIce2/rpc-bridge/master/docs/assets/gui.png)
- 削除する場合は同じ手順で「Remove」をクリック。

*注：MacOSでは[追加の手順](https://github.com/EnderIce2/rpc-bridge?tab=readme-ov-file#macos)が必要です*

##### Lutris

- ゲームをクリックし「Run EXE inside Wine prefix」を選択。
    - ![lutris](https://raw.githubusercontent.com/EnderIce2/rpc-bridge/master/docs/assets/lutris.png)
- Wineと同様の手順で進められます。

##### Steam

- ゲームを右クリックし「Properties」を選択。
- 「Set Launch Options」に以下を追加：
    - ![bridge.sh](https://raw.githubusercontent.com/EnderIce2/rpc-bridge/master/docs/assets/steam_script.png "Launch Optionsにbridge.shのパスを設定")
- `bridge.sh`スクリプトは`bridge.exe`と同じディレクトリに置く必要があります。

#### Flatpakを使用している場合

- SteamやLutrisなどをFlatpakで実行している場合、ブリッジが`/run/user/1000/discord-ipc-0`ファイルにアクセスできるよう許可が必要です。
	- ##### [Flatseal](https://flathub.org/apps/details/com.github.tchx84.Flatseal)を使う場合
		- `Filesystems`カテゴリーに`xdg-run/discord-ipc-0`を追加
			- ![flatseal](https://raw.githubusercontent.com/EnderIce2/rpc-bridge/master/docs/assets/flatseal_permission.png)
	- ##### ターミナルを使う場合
		- アプリケーション単位
			- `flatpak override --filesystem=xdg-run/discord-ipc-0 <flatpakアプリ名>`
		- グローバル
			- `flatpak override --user --filesystem=xdg-run/discord-ipc-0`

##### MacOS

MacOSの手順はほぼ同じですが、`$TMPDIR`の動作のために**LaunchAgent**をインストールする必要があります。

- [リリース](https://github.com/EnderIce2/rpc-bridge/releases)から最新ビルドをダウンロード
- アーカイブを開き、`launchd.sh`スクリプトを`chmod +x launchd.sh`で実行可能にする
- LaunchAgentを**インストール**するには`./launchd.sh install`を実行し、**削除**するには`./launchd.sh remove`を実行

このスクリプトはユーザーのLaunchAgentに、`$TMPDIR`ディレクトリを`/tmp/rpc-bridge/tmpdir`にシンボリックリンクする設定を追加します。

*注：`bridge.exe`をWineで少なくとも一度手動で起動して登録し、次回以降自動起動させる必要があります。*

LaunchAgentのインストール詳細は[ドキュメント](https://enderice2.github.io/rpc-bridge/)を参照してください。

## ソースからのコンパイル

- `wine`、`gcc-mingw-w64`、`make`パッケージをインストール
- このファイルがあるディレクトリで端末を開き`make`を実行
- コンパイル済み実行ファイルは`build/bridge.exe`に生成されます

## クレジット

本プロジェクトは[ wine-discord-ipc-bridge](https://github.com/0e4ef622/wine-discord-ipc-bridge)に触発されています。

---



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---