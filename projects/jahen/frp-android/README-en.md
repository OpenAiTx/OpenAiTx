# frp-android

A frp client for Android. An frp client for the Android platform.

## About frp

[frp](https://github.com/fatedier/frp) is a high-performance reverse proxy application focused on intranet penetration, supporting multiple protocols such as TCP, UDP, HTTP, and HTTPS.

## Features

- **Dual mode frpc and frps**: supports running as client or server
- **Multiple configuration formats**: supports INI, TOML, YAML, JSON
- **Configuration management**: long press to drag and sort, import and export configurations
- **No Root required**: can be used on mobile without root
- **Background running**: supports background service, can start/stop each configuration separately

## Build Instructions

### Environment Requirements

- [Android Studio](https://developer.android.com/studio) 3.2+
- JDK 8+
- Android SDK API 19+ (minSdk)
- frp dynamic library: need to prepare by yourself or download through in-app version management

### Build Steps

```bash
# 克隆仓库
git clone https://github.com/jahen/frp-android.git
cd frp-android

# 构建 Debug
./gradlew assembleDebug

# 构建 Release（默认使用 debug 签名，如需正式签名请配置 keystore）
./gradlew assembleRelease
```

### Release Signing (Optional)

If you need to sign the Release package using a custom keystore:

1. Copy `keystore.properties.example` and rename it to `keystore.properties` (place it in the project root directory)
2. Open `keystore.properties` with a text editor and fill in your keystore information:
   - `storeFile`: path to the keystore file (relative to the project root, e.g., `../release.keystore` means the parent directory)
   - `storePassword`: keystore password
   - `keyAlias`: key alias
   - `keyPassword`: key password
3. Ensure the keystore file exists at the path specified by `storeFile`

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