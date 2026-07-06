# 🎯 MT7902 驱动作为 MT7921 驱动的子部分（✅ 可用）
联发科 mt7902 wifi 6E 芯片蓝牙和 WiFi 支持

> [!IMPORTANT]
> Linux 7.1 内核官方支持 MT7902 WIFI 6E 芯片


## 📁 克隆仓库
将仓库克隆到您的本地电脑
  ```
  git clone https://github.com/OnlineLearningTutorials/mt7902_temp
  ```
如果您不想克隆过去的历史，那么
  ```
  git clone --depth 1 https://github.com/OnlineLearningTutorials/mt7902_temp
  ```

## 安装


### 🚀 安装指南脚本（推荐用于基于Ubuntu的系统）
如果脚本尚未可执行，请赋予执行权限
```
chmod +x ./install_guide.sh
```
现在运行此脚本
```
./install_guide.sh
```
它会在必要时自动提示输入密码  
* 该脚本将依次要求您安装固件、蓝牙和WiFi驱动程序  
* 在使用Linux 7.0内核的Ubuntu上测试通过  

### 🚀 简易自动修复（推荐用于基于Arch的系统）  
如果您想在任何现代内核上快速修复WiFi和蓝牙，请按照以下步骤操作：  

如果脚本尚未可执行，请赋予执行权限  
```
chmod +x ./fix_my_wifi.sh
```

**使用 sudo 运行自动修复脚本**：
```bash
sudo bash fix_my_wifi.sh
```

#### 📖 这个脚本的功能：
* **检查依赖项：** 确保你已安装 `gcc`/`clang`、`make`、`bc` 以及当前的 `kernel-headers`。如果没有，会使用你偏好的包管理器进行安装。
* **编译驱动程序：** 自动为你的精确内核版本构建 WiFi 和蓝牙驱动程序。
* **持久修复：** 安装系统服务，确保即使重启电脑，WiFi 也能保持激活状态。
* **安全性：** 将模块安装到自定义目录（`/lib/modules/mt7902_custom`），避免影响默认系统文件。

> [!NOTE]
> 首次运行时需要联网（通过以太网或手机 USB 共享）以下载必要的构建工具。（如编译器、linux-headers 等）

## ✅ 已测试（验证有效）
此修复已验证并确认有效于：

* **品牌：** ASUS
* **型号：** Vivobook Go (E1404FA)，Vivobook 14 (X1404ZA)
* **芯片组：** MediaTek MT7902（WiFi 6E）
* **内核版本：** 6.19.0（Linux）、6.19.11、7.0.7
* **操作系统：** Arch，Ubuntu
* **包管理器：** pacman，apt

## 适用范围：
* **操作系统：** 支持任一包管理器的操作系统
* **偏好包管理器：** apt，pacman，dnf，zypper，nix-shell
* **内核版本：** 6.14-7.0.7

## 🔧 使用的固件
固件存储在 `firmware` 文件夹中。

## 📱 蓝牙 ✅（正常工作）
> [!WARNING]
> 如果蓝牙驱动与 `gen4-mt7902` 冲突，请删除蓝牙固件以避免干扰此驱动
> ``` sudo rm /lib/firmware/mediatek/mt7902/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```
> 本项目使用的固件为
> ``` /lib/firmware/mediatek/BT_RAM_CODE_MT7902_1_1_hdr.bin.zst ```

要启用蓝牙，请进入你当前内核版本的目录。  
比如如果你使用的是 linux-6.16 内核，则进入目录 `./linux-6.16/drivers/bluetooth` 。



在此目录中打开终端并使用命令 `make` 编译。  
编译了两个内核模块 `btusb.ko` 和 `btmtk.ko`。  
要在设备中启用蓝牙，请移除系统中的 btusb 和 btmtk 并安装这两个文件，使用以下命令  
```
sudo rmmod btusb 
sudo rmmod btmtk

sudo insmod btmtk.ko
sudo insmod btusb.ko

```
现在检查你的蓝牙是否正常工作。

## 💻 WiFi ✅（正常）
> [!重要]
> 一个带有一些限制的可用仓库在[这里](https://github.com/hmtheboy154/gen4-mt7902)

mediatek 最近发布的 mt7902 WiFi 驱动位于 `latest` 文件夹中。

如果你使用的是 Ubuntu，只需进入 `latest` 文件夹并在终端运行以下命令。
```
make
```

它将编译所有模块，压缩它们并安装（用修改后的模块替换原始内核模块）。如果您使用其他发行版或不想执行所有步骤，只想编译代码，请在终端中运行
```
make module_compile
```
要压缩您编译的模块，然后在终端运行
```
make module_compress
```
要将压缩模块安装到系统的内核模块中，请在终端运行
```
make module_install
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-06

---