# frp-android

Android向けのfrpクライアント。一个 Android 平台的 frp 客户端。

## 关于 frp

[frp](https://github.com/fatedier/frp) は、高性能なリバースプロキシアプリで、TCP、UDP、HTTP、HTTPSなど複数のプロトコルをサポートし、内網透過に特化しています。

## 功能特性

- **frpc と frps のデュアルモード**：クライアントまたはサーバーとして動作可能
- **複数の設定フォーマット**：INI、TOML、YAML、JSONをサポート
- **設定管理**：長押しでドラッグ順序変更、設定のインポート・エクスポート
- **Root不要**：スマホ側はroot不要で使用可能
- **バックグラウンド動作**：バックグラウンドサービスをサポートし、各設定を個別に開始/停止可能

## 构建说明

### 环境要求

- [Android Studio](https://developer.android.com/studio) 3.2以上
- JDK 8以上
- Android SDK API 19以上（minSdk）
- frp動的ライブラリ：自身で用意するか、アプリ内のバージョン管理からダウンロード

### 构建步骤

```bash
# 克隆仓库
git clone https://github.com/jahen/frp-android.git
cd frp-android

# 构建 Debug
./gradlew assembleDebug

# 构建 Release（默认使用 debug 签名，如需正式签名请配置 keystore）
./gradlew assembleRelease
```

### リリース署名（オプション）

カスタム keystore を使用してリリースパッケージに署名する場合：

1. `keystore.properties.example` をコピーして `keystore.properties` にリネームする（プロジェクトのルートディレクトリに配置）
2. テキストエディタで `keystore.properties` を開き、keystore 情報を入力する：
   - `storeFile`：keystore ファイルのパス（プロジェクトのルートディレクトリからの相対パス、例：`../release.keystore` は一つ上のディレクトリを指す）
   - `storePassword`：keystore のパスワード
   - `keyAlias`：キーのエイリアス
   - `keyPassword`：キーのパスワード
3. `storeFile` で指定したパスに keystore ファイルが存在することを確認する

```properties
# keystore.properties 示例
storeFile=../release.keystore
storePassword=your_store_password
keyAlias=your_key_alias
keyPassword=your_key_password
```

**注意：`keystore.properties` 和 `*.keystore` 已加入 `.gitignore`，切勿提交！**

## 许可证

[Apache License 2.0](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-16

---