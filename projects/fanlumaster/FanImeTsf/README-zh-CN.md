## FanImeTsf

这是 [FanImeServer](https://github.com/fanlumaster/FanImeServer) 的 TSF 端。

注意：目前仅支持 64 位应用程序。

## 构建方法

### 先决条件

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

请确保 vcpkg 和 gsudo 已通过 **Scoop** 安装。

## 构建步骤

### 构建

首先，克隆仓库，

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

然后，准备环境，

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

接着，进行构建，

```powershell
.\scripts\lcompile.ps1
```

### 安装

以管理员身份启动 PowerShell，确保已开启系统的 `Enable sudo` 选项。

![](https://i.postimg.cc/zJCn9Cnn/image.png)

然后，在 `C:\Program Files\` 下创建名为 `FanImeTsf` 的文件夹，并将 `FanImeTsf.dll` 复制进去，

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

接着，进行安装，

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### 卸载

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## 截图

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## 路线图

目前仅支持小鹤双拼。

### 中文

- 小鹤双拼
- 全拼
- 汉字部件输入辅助码
- 可自定义词库
- 可定制输入法引擎
- 可定制皮肤
- 简体中文与繁体中文切换
- 英文自动补全
- 开源云输入法 API
- 候选窗口 UI 支持纵向与横向切换
- 功能开关：大多数功能应允许用户自由切换或自定义

### 日语支持

可能另建项目实现。

也可能支持其他语言。

### 参考资料

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---