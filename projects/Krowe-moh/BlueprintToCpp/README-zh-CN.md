# Blueprint To C++

一个将虚幻引擎蓝图转换为C++代码的工具。

由 [CUE4Parse](https://github.com/FabianFG/CUE4Parse) 提供支持

## 安装

1. 克隆仓库：
    ```bash
    git clone https://github.com/Krowe-moh/BlueprintToCpp.git --recursive
    ```

2. 在您的IDE中打开解决方案文件并构建项目。

## 使用方法

1. 运行可执行文件以自动创建一个 `config.json` 文件。

2. 配置 `config.json` 中的选项：

    示例：
    ```js
    {
      "PakFolderPath": "C:/Program Files/Epic Games/Fortnite/FortniteGame/Content/Paks",
      "BlueprintPath": "FortniteGame/Content/Athena/Cosmetics/Sprays/BP_SprayDecal.uasset",
      "OodlePath": "C:/Users/krowe/BlueprintToCpp/oo2core_5_win64.dll",
      "ZlibPath ": "", // leave blank if no zlib compression
      "UsmapPath": "C:/Users/krowe/BlueprintToCpp/++Fortnite+Release-33.20-CL-39082670-Windows_oo.usmap",
      "Version": "GAME_UE5_LATEST"
    }
    ```

3. 运行 `Main.exe` 以开始转换。

## AES

如果您想设置 AES，先运行程序一次（配置已设置），然后修改生成的 `aes.json` 文件。

## 输出

反编译后的蓝图将输出为 `Output.cpp`（现已改为输出为文件夹层级结构，稍后将添加关闭该功能的选项）。

注意：目前，该工具不支持所有表达式，C++ 输出可能不完全准确。

## 问题

如果遇到任何问题，请在[此处](https://github.com/Krowe-moh/BlueprintToCpp/issues)提交。

## 贡献

欢迎提交问题，派生仓库，并为任何改进创建拉取请求。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-17

---