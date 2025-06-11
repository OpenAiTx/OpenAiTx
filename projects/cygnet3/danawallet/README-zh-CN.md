# Dana 钱包

Dana 是一个用于接受比特币捐赠的 Flutter 应用。它使用 silent payments（一种新的静态支付协议）来接收捐赠，同时保护链上隐私。

## 试用 Dana 钱包

**Dana 钱包目前仍处于实验阶段。我们建议使用测试网/signet。如果您确实想在主网测试该钱包，请仅使用您愿意损失的资金。我们不对资金损失负责。**

一旦应用更加稳定，我们计划在流行的应用商店发布 Dana 钱包。

与此同时，有两种方式可以试用 Dana 钱包：

- 从[发行页面](https://github.com/cygnet3/danawallet/releases)下载最新的 Dana 钱包 APK
- 使用我们的[自托管 F-Droid 仓库](https://fdroid.silentpayments.dev/fdroid/repo)下载 Dana 钱包

### 使用 F-Droid 下载

我们推荐使用 F-Droid 选项，因为它支持自动更新，并且只需设置一次。

- 在您的安卓手机上打开 F-Droid
- 进入“设置”
- 在“我的应用”部分，点击“仓库”
- 点击“+”图标添加一个新的仓库
- 扫描本页上的二维码：https://fdroid.silentpayments.dev/fdroid/repo

您现在已添加我们的自托管仓库。要下载应用，请在 F-Droid 应用商店部分搜索“Dana Wallet”（您可能需要先下拉刷新应用列表）。

## 从源码构建 Dana 钱包

以下是从源码构建 Dana 钱包的说明。仅当您想参与 Dana 钱包开发时推荐使用。

### Linux（桌面）构建

Linux 构建无需额外操作，只需执行

```
flutter run
```

这也可能适用于其他平台（macOS、Windows），但我们尚未测试。

### 安卓构建

安卓设备构建需要一些准备工作，以生成该架构的二进制文件。

首先，您需要安装 `cargo-ndk`。您可能还需要添加所需的工具链：

```
cargo install cargo-ndk
rustup target add \
    aarch64-linux-android \
    armv7-linux-androideabi \
    x86_64-linux-android \
    i686-linux-android
```

安装完成后，进入 rust 目录并运行 `just build-android`。

```
cd rust
just build-android
```

如果您没有安装 `just`，也可以复制 `justfile` 中的命令执行。
这将生成二进制文件。

接下来，连接手机并启用调试模式。
通过运行以下命令检查手机是否连接：

```
flutter devices
```

最后，构建并安装应用到安卓设备：

```
flutter run
```

## 捐赠给 Dana

您可以通过以下地址向 Dana 钱包捐赠：

> ₿donate@danawallet.app

或者使用以下静态支付地址：

> sp1qq0cygnetgn3rz2kla5cp05nj5uetlsrzez0l4p8g7wehf7ldr93lcqadw65upymwzvp5ed38l8ur2rznd6934xh95msevwrdwtrpk372hyz4vr6g

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---