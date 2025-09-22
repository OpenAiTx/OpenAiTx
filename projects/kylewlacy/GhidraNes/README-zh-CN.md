# GhidraNes

一个支持反汇编和分析NES ROM的Ghidra扩展。

![Ghidra反汇编显示名为“game.nes”的文件中反编译函数](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/ghidra-nes.png)

## 功能

- 导入iNES格式的NES ROM。支持以下映射器：
    - 16K/32K固定PRG ROM
        - [NROM](https://www.nesdev.org/wiki/NROM)（映射器0）
        - [CNROM](https://www.nesdev.org/wiki/CNROM)（映射器3、185）
        - [CPROM](https://www.nesdev.org/wiki/CPROM)（映射器13）
    - 16K可切换PRG ROM
        - [MMC1/SxROM](https://www.nesdev.org/wiki/MMC1)（映射器1，也包括映射器16）
        - [UxROM](https://www.nesdev.org/wiki/UxROM)（映射器2）
        - [MMC4/FxROM](https://www.nesdev.org/wiki/MMC4)（映射器10）
        - [UNROM 512](https://www.nesdev.org/wiki/UNROM_512)（映射器30）
        - [Sunsoft 3](https://www.nesdev.org/wiki/INES_Mapper_067)/[Sunsoft 4](https://www.nesdev.org/wiki/INES_Mapper_068)（映射器67、68）
        - 其他映射器 [16](https://www.nesdev.org/wiki/INES_Mapper_016)
    - 32K可切换PRG ROM
        - [AxROM](https://www.nesdev.org/wiki/AxROM)（映射器7）
        - [BNROM/NINA](https://www.nesdev.org/wiki/INES_Mapper_034)（映射器34）
        - [GxROM](https://www.nesdev.org/wiki/GxROM)（映射器66）
        - 其他映射器 [11](https://www.nesdev.org/wiki/Color_Dreams), [38](https://www.nesdev.org/wiki/INES_Mapper_038), [140](https://www.nesdev.org/wiki/INES_Mapper_140)
    - 8K可切换PRG ROM
        - [MMC3/TxROM](https://www.nesdev.org/wiki/MMC3)/[TxSROM](https://www.nesdev.org/wiki/INES_Mapper_118)/[TQROM](https://www.nesdev.org/wiki/INES_Mapper_119)（映射器4、118、119）
        - [Namco 129/163](https://www.nesdev.org/wiki/INES_Mapper_019)（映射器19）
        - [Konami VRC2/4](https://www.nesdev.org/wiki/VRC2_and_VRC4)（映射器21、22、23、25）
        - [RAMBO-1](https://www.nesdev.org/wiki/RAMBO-1)（映射器64、158）
        - [Sunsoft FME-7/5A/5B](https://www.nesdev.org/wiki/Sunsoft_FME-7)（映射器69）
        - [DxROM](https://www.nesdev.org/wiki/DxROM)（映射器[206](https://www.nesdev.org/wiki/INES_Mapper_206)）
        - 其他映射器 [18](https://www.nesdev.org/wiki/INES_Mapper_018), [65](https://www.nesdev.org/wiki/INES_Mapper_065), [74](https://www.nesdev.org/wiki/INES_Mapper_074), [76](https://www.nesdev.org/wiki/INES_Mapper_076), [88](https://www.nesdev.org/wiki/INES_Mapper_088), [95](https://www.nesdev.org/wiki/INES_Mapper_095), [154](https://www.nesdev.org/wiki/INES_Mapper_154), [191](https://www.nesdev.org/wiki/INES_Mapper_191), [192](https://www.nesdev.org/wiki/INES_Mapper_192), [194](https://www.nesdev.org/wiki/INES_Mapper_194), [195](https://www.nesdev.org/wiki/INES_Mapper_195)

- 在反汇编中添加标签和内存块，使浏览反汇编ROM更加便捷！

## 安装

1. 安装兼容版本的Java和Ghidra（Java 21及以上）。
2. 下载最新的[GhidraNes版本](https://github.com/kylewlacy/GhidraNes/releases)。确保下载的版本与您的Ghidra版本相匹配！
3. 进入“文件” > “安装扩展...”。点击右上角的“+”号，选择 GhidraNes Zip 文件。点击“确定”安装扩展。
4. 重启 Ghidra。

## 使用方法

1. 在 Ghidra 中，按照向导通过“文件” > “新建项目...”创建新项目。
2. 将 iNES `.nes` ROM 拖放到项目中。设置格式为“NES ROM”，然后点击“确定”。
3. 双击项目中的 ROM 以打开 Ghidra 的 CodeBrowser。
4. 在提示时分析文件（或进入“分析” > “自动分析...”）。保持默认设置并点击“分析”。
5. 完成，游戏将被反汇编！在左侧“符号树” > “函数”下，打开 `reset` 跳转到复位向量（执行起点），或打开 `vblank` 跳转到 NMI 向量（VBlank 期间执行位置）。

## 注意事项

### 银行切换

GhidraNes 将 ROM 的每个银行映射到自己的内存块，但没有实现自动处理银行切换的控制流分析。相反，银行切换的处理需要手动完成。举例说明如下函数：

![Ghidra 反汇编显示一个“reset”函数，包含“LDA #0x0”、“STA DAT_8000”和“JMP (0xfffc)=>reset”。行号栏显示该函数为无限循环](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/bank-switching-broken.png)

该反汇编函数执行了银行切换：写入 `DAT_8000` 在此例中将 PRG ROM 切换到银行 0。此类情况可通过以下步骤在 Ghidra 中修正：

1. 右键点击 `JMP` 指令
2. 点击“引用 > 添加/编辑 (R)”
3. 双击目标操作数
4. 在“到地址”字段中，将左侧下拉框从“RAM:”更改为相应的内存银行（此例为“PRG0::”）
5. 点击“更新”

反汇编现在应显示跳转到正确的银行：

![Ghidra 反汇编显示相同的“reset”函数，但“JMP”指令现在跳转到“(0xfffc)=>LAB_PRG0__ffaf”](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/bank-switching-fixed.png)

> 注意：任何写入指令（如 `STA`/`STX`/`STY`、`INC`/`DEC`）写入映射器寄存器时，若当前执行代码所在银行被切换，控制流将发生变化。修正方法如下：
>
> 1. 右键点击写入指令
> 2. 选择 `Fallthrough` > `设置...`
> 3. 记住地址偏移框中的值
> 4. 选择 `用户`，并从下拉框中选择新银行
> 5. 将地址偏移框设置为步骤 3 中的值（因为 PC 仍指向新银行中的“下一条”指令）
>
> 这样有助于分析和反编译，使其能够“跟随”银行切换。
默认情况下，PRG 块大小小于 32K 的 ROM 会以基地址 `0x8000` 创建，最后一个银行除外，该银行会位于该银行的“最高”地址（8K 块位于 `0xe000`，16K 位于 `0xc000`）。如果你事先知道每个银行应位于何处，可以在加载时使用“选项...”对话框设置每个银行的地址。如果后来确定猜测错误且不想重新导入 ROM，可以使用内存映射窗口重新设置银行基址：

1. 如果尚未打开，选择菜单 `窗口`>`内存映射`。
2. 选择要更改的银行所在的行。
3. 选择内存映射窗口标题栏中的蓝色十字图标（“将块移动到另一个地址”）。
4. 将“新起始地址”更改为正确的基地址。“新结束地址”应根据块大小自动更新。
5. 选择“确定”，银行地址将被更新。

## 开发

### 使用 Eclipse 开发

1. 安装 Java 和 Ghidra。
2. 安装 Eclipse。
3. 安装 GhidraDev Eclipse 插件。说明可在你的 Ghidra 安装目录下的 `Extensions/Eclipse/GhidraDev/GhidraDev_README.html` 找到。
4. 在 Eclipse 中，通过“文件”>“从文件系统打开项目...”打开 GhidraNes 仓库。点击“目录”，然后选择包含此 `README.md` 文件和 `GhidraNes` 子目录的 _顶层_ 文件夹。最后点击“完成”。
5. 打开“GhidraDev”>“链接 Ghidra...”。添加你的 Ghidra 安装，点击“下一步 >”，然后选择“GhidraNes”作为 Java 项目。点击“完成”。
6. 选择“运行”>“以...方式运行”>“Ghidra”运行带有 GhidraNes 扩展的 Ghidra。

### 在 Eclipse 中构建发布版本

**注意：** 确保 GhidraNes Eclipse 项目设置为应针对的 _最低_ Java 版本。使用更高版本的 Java 可能导致兼容性问题！

1. 安装 Gradle（使用 [SDKMAN](https://sdkman.io/) 可以通过 `sdk install gradle` 安装）。
2. 在 Eclipse 中，打开“GhidraDev”>“导出”>“Ghidra 模块扩展...”。选择“GhidraNes”项目，点击“下一步 >”，然后选择“本地安装目录：”，浏览到你的 Gradle 安装目录（使用 SDKMAN，通常位于 `~/.sdkman/candidates/gradle/$GRADLE_VERSION`）。点击“完成”。
3. 构建的 zip 文件将保存在 `GhidraNes/dist/` 目录。安装详情请参阅“安装”部分。

### 使用其他编辑器开发（如 VS Code）

1. 安装 Java 和 Ghidra。
2. 在编辑器中配置 JDK 设置。
    - 对于 VSCode：请参考官方的[“在 VS Code 中开始使用 Java”](https://code.visualstudio.com/docs/java/java-tutorial) 指南。
3. 将 `GhidraNes/gradle.properties.example` 复制为 `GhidraNes/gradle.properties`，并根据需要配置 Ghidra 的安装目录。
4. 将 GhidraNes 仓库导入为 Java 项目（包含此 `README.md` 文件和 `GhidraNes` 子目录的 _顶层_ 文件夹）。

### 使用 Gradle 构建发布版本

1. 进入内部的 `GhidraNes` 子目录：`cd GhidraNes/GhidraNes`
2. 运行 `gradle buildExtension`

    - 如果尚未设置 `gradle.properties` 文件，可以直接将属性传递给 Gradle，例如 `gradle buildExtension -PGHIDRA_INSTALL_DIR=/home/user/ghidra_10.2.2_PUBLIC`
3. 构建的 zip 文件将保存在 `GhidraNes/dist/` 目录中。有关安装构建的 zip 文件的详细信息，请参阅“安装”部分。

## 发布版本

1. 将 `CHANGELOG.md` 更新为一个新的提交
2. 为新版本创建一个标签。标签和版本名称应根据当前日期 [UTC 时间](https://www.utctime.net/) 命名为 `vYYYYMMDD`（例如 `v20250520`）
3. 推送标签。这将触发["Release" GH Actions 工作流](https://github.com/kylewlacy/GhidraNes/actions/workflows/release.yml)，几分钟后会创建一个带有发布说明和构建资源的新[草稿版本](https://github.com/kylewlacy/GhidraNes/releases)
4. 仔细检查构建资源是否正常，如有需要调整或添加发布说明，然后发布！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---