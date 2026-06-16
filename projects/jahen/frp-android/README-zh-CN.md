# frp-android

A frp client for Android. 一个 Android 平台的 frp 客户端。

## 关于 frp

[frp](https://github.com/fatedier/frp) 是一个专注于内网穿透的高性能反向代理应用，支持 TCP、UDP、HTTP、HTTPS 等多种协议。

## 功能特性

- **frpc 和 frps 双模式**：支持作为客户端或服务端运行
- **多配置格式**：支持 INI、TOML、YAML、JSON
- **配置管理**：长按拖动排序、导入导出配置
- **免 Root**：手机端无需 root 即可使用
- **后台运行**：支持后台服务，可单独启动/停止每条配置

## 构建说明

### 环境要求

- [Android Studio](https://developer.android.com/studio) 3.2+
- JDK 8+
- Android SDK API 19+ (minSdk)
- frp 动态库：需自行准备或通过应用内版本管理下载

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

### Release 签名（可选）

如需使用自定义 keystore 签名 Release 包：

1. 将 `keystore.properties.example` 复制并重命名为 `keystore.properties`（放在项目根目录）
2. 用文本编辑器打开 `keystore.properties`，填入你的 keystore 信息：
   - `storeFile`：keystore 文件路径（相对于项目根目录，如 `../release.keystore` 表示上一级目录）
   - `storePassword`：keystore 密码
   - `keyAlias`：密钥别名
   - `keyPassword`：密钥密码
3. 确保 keystore 文件存在于 `storeFile` 指定的路径

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