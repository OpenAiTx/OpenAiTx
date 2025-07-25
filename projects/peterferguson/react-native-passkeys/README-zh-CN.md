# React Native 密钥

这是一个 Expo 模块，帮助您在 iOS、Android 和网页上使用相同的 API 创建和验证密钥。该库旨在紧贴标准 [`navigator.credentials`](https://w3c.github.io/webappsec-credential-management/#framework-credential-management)。更具体地说，我们提供了 `get` 和 `create` 函数的 API（因为这些函数是跨平台可用的）。

我们所做的调整是一些简单的优化，比如自动将 base64-url 编码的字符串转换为缓冲区。这也是为了更方便地将值传递到原生端。

更多的优化还包括一些标志函数，用于指示对某些功能的支持。

## 安装

```sh
npx expo install react-native-passkeys
```

## iOS 设置

#### 1. 托管 Apple 应用关联文件（AASA）

为了让 Passkeys 在 iOS 上正常工作，您需要在您的域名上托管一个 AASA 文件。该文件用于验证您的应用是否被允许处理您尝试认证的域名。此文件必须托管在具有有效 SSL 证书的网站上。

该文件应托管在：

```
https://<your_domain>/.well-known/apple-app-site-association
```
请注意，该文件没有 `.json` 扩展名，但格式是 json。文件内容应类似于以下内容：


```json
{
  "webcredentials": {
    "apps": ["<teamID>.<bundleID>"]
  }
}
```

将 `<teamID>` 替换为您的 Apple 团队 ID，将 `<bundleID>` 替换为您的应用程序捆绑标识符。

#### 2. 添加关联域名

将以下内容添加到您的 `app.json` 中：

```json
{
  "expo": {
    "ios": {
      "associatedDomains": ["webcredentials:<your_domain>"]
    }
  }
}
```

将 `<your_domain>` 替换为您托管 AASA 文件的域名。例如，如果您在 `https://example.com/.well-known/apple-app-site-association` 托管 AASA 文件，您应将 `example.com` 添加到 `associatedDomains` 数组中。

#### 3. 添加最低部署目标

将以下内容添加到您的 `app.json` 中：

```json
{
  "expo": {
    "plugins": [
      [
        "expo-build-properties",
        {
          "ios": {
            "deploymentTarget": "15.0"
          }
        }
      ]
    ]
  }
}
```

#### 4. 预构建并运行你的应用程序

```sh
npx expo prebuild -p ios
npx expo run:ios # or build in the cloud with EAS
```

## Android 设置

#### 1. 托管 `assetlinks.json` 文件

为了让 Passkeys 在 Android 上工作，您需要在您的域名上托管一个 `assetlinks.json` 文件。该文件用于验证您的应用是否被允许处理您尝试认证的域名。此文件必须托管在具有有效 SSL 证书的网站上。

该文件应托管于：

```
https://<your_domain>/.well-known/assetlinks.json
```
应该看起来像这样（您可以使用 [Android 资产链接助手](https://developers.google.com/digital-asset-links/tools/generator) 生成此文件）：


```json
[
  {
    "relation": ["delegate_permission/common.handle_all_urls"],
    "target": {
      "namespace": "android_app",
      "package_name": "<package_name>",
      "sha256_cert_fingerprints": ["<sha256_cert_fingerprint>"]
    }
  }
]
```

将 `<package_name>` 替换为您的应用包名，将 `<sha256_cert_fingerprint>` 替换为您的应用 SHA256 证书指纹。

#### 2. 修改 Expo 构建属性

接下来，您需要将 `app.json` 中的 `compileSdkVersion` 修改为至少 34。

```json
{
  "expo": {
    "plugins": [
      [
        "expo-build-properties",
        {
          "android": {
            "compileSdkVersion": 34
          }
        }
      ]
    ]
  }
}
```
#### 3. 预构建并运行您的应用程序


```sh
npx expo prebuild -p android
npx expo run:android # or build in the cloud with EAS
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---