## FanImeTsf

This is the TSF end of [FanImeServer](https://github.com/fanlumaster/FanImeServer).

Notice: Only 64-bit Apps are supported for now.

## How to build

### Prerequisites

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

Make sure vcpkg and gsudo are installed via **Scoop**.

## Build steps

### Build

First, clone the repository,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

Then, prepare the environment,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

Then, build,

```powershell
.\scripts\lcompile.ps1
```

### Install

Launch PowerShell as administrator, and make sure you enable the system `Enable sudo` option.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

Then, create a folder named `FanImeTsf` in `C:\Program Files\`, and copy `FanImeTsf.dll` to it,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

Then, install it,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### Uninstall

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## Screenshots

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## Roadmap

Currently, only Xiaohe Shuangpin is supported.

### Chinese

- Xiaohe Shuangpin
- Quanpin
- Help codes for Hanzi component usage
- Customizable dictionary
- Customizable IME engine
- Customizable skins
- Switch between Simplified and Traditional Chinese
- English autocomplete
- Open-source Cloud IME API
- Toggle candidate window UI between vertical and horizontal modes
- Feature switches: most features should be freely toggled or customized by users

### Japanese Support

Maybe as another project.

And possibly support for other languages.

### References

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---