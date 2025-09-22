# GhidraNes

A Ghidra extension to support disassembling and analyzing NES ROMs.

![Ghidra disassembly showing a decompiled function from a file named "game.nes"](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/ghidra-nes.png)

## Features

- Import NES ROMs in the iNES format. The following mappers are supported:
    - 16K/32K fixed PRG ROM
        - [NROM](https://www.nesdev.org/wiki/NROM) (mapper 0)
        - [CNROM](https://www.nesdev.org/wiki/CNROM) (mappers 3, 185)
        - [CPROM](https://www.nesdev.org/wiki/CPROM) (mapper 13)
    - 16K bankable PRG ROM
        - [MMC1/SxROM](https://www.nesdev.org/wiki/MMC1) (mapper 1, also includes mapper 16)
        - [UxROM](https://www.nesdev.org/wiki/UxROM) (mapper 2)
        - [MMC4/FxROM](https://www.nesdev.org/wiki/MMC4) (mapper 10)
        - [UNROM 512](https://www.nesdev.org/wiki/UNROM_512) (mapper 30)
        - [Sunsoft 3](https://www.nesdev.org/wiki/INES_Mapper_067)/[Sunsoft 4](https://www.nesdev.org/wiki/INES_Mapper_068) (mappers 67, 68)
        - Misc mapper [16](https://www.nesdev.org/wiki/INES_Mapper_016)
    - 32K bankable PRG ROM
        - [AxROM](https://www.nesdev.org/wiki/AxROM) (mapper 7)
        - [BNROM/NINA](https://www.nesdev.org/wiki/INES_Mapper_034) (mapper 34)
        - [GxROM](https://www.nesdev.org/wiki/GxROM) (mapper 66)
        - Misc mappers [11](https://www.nesdev.org/wiki/Color_Dreams), [38](https://www.nesdev.org/wiki/INES_Mapper_038), [140](https://www.nesdev.org/wiki/INES_Mapper_140)
    - 8K bankable PRG ROM
        - [MMC3/TxROM](https://www.nesdev.org/wiki/MMC3)/[TxSROM](https://www.nesdev.org/wiki/INES_Mapper_118)/[TQROM](https://www.nesdev.org/wiki/INES_Mapper_119) (mappers 4, 118, 119)
        - [Namco 129/163](https://www.nesdev.org/wiki/INES_Mapper_019) (mapper 19)
        - [Konami VRC2/4](https://www.nesdev.org/wiki/VRC2_and_VRC4) (mappers 21, 22, 23, 25)
        - [RAMBO-1](https://www.nesdev.org/wiki/RAMBO-1) (mappers 64, 158)
        - [Sunsoft FME-7/5A/5B](https://www.nesdev.org/wiki/Sunsoft_FME-7) (mapper 69)
        - [DxROM](https://www.nesdev.org/wiki/DxROM) (mapper [206](https://www.nesdev.org/wiki/INES_Mapper_206))
        - Misc mappers [18](https://www.nesdev.org/wiki/INES_Mapper_018), [65](https://www.nesdev.org/wiki/INES_Mapper_065), [74](https://www.nesdev.org/wiki/INES_Mapper_074), [76](https://www.nesdev.org/wiki/INES_Mapper_076), [88](https://www.nesdev.org/wiki/INES_Mapper_088), [95](https://www.nesdev.org/wiki/INES_Mapper_095), [154](https://www.nesdev.org/wiki/INES_Mapper_154), [191](https://www.nesdev.org/wiki/INES_Mapper_191), [192](https://www.nesdev.org/wiki/INES_Mapper_192), [194](https://www.nesdev.org/wiki/INES_Mapper_194), [195](https://www.nesdev.org/wiki/INES_Mapper_195)

- Add labels and memory blocks in disassembly, making it easier to jump around a disassembled ROM!

## Installation

1. Install a Compatible version of Java and Ghidra (Java 21+).
2. Download the latest [GhidraNes release](https://github.com/kylewlacy/GhidraNes/releases). Make sure the release you download matches your Ghidra version!
3. Go to "File" > "Install Extensions...". Click "+" in the top-right corner and choose the GhidraNes Zip. Click "OK" to install the extension.
4. Restart Ghidra.

## Usage

1. In Ghidra, create a new project by following the wizard under "File" > "New Project...".
2. Drag-and-drop an iNES `.nes` ROM onto the project. Set the format to "NES ROM" and click "OK".
3. Double-click the ROM in the project to open Ghidra's CodeBrowser.
4. Analyze the file when prompted (or go to "Analysis" > "Auto Analyze..."). Leave the settings as default and click "Analyze".
5. Done, the game will be disassembled! On the left-hand side, under "Symbol Tree" > "Functions", open `reset` to jump to the reset vector (where execution starts), or `vblank` to jump to the NMI vector (where execution goes during VBlank).

## Notes

### Bank switching

GhidraNes maps each bank of the ROM to its own memory block, but there is no control-flow analysis implemented that handles bank switching automatically. Instead, handling bank switching in the disassembly is a manual process. Take this function for example:

![Ghidra disassembly showing a "reset" function consisting of "LDA #0x0", "STA DAT_8000", and "JMP (0xfffc)=>reset". The gutter shows this function as an infinite loop](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/bank-switching-broken.png)

This disassembled function is doing a bank switch: the write to `DAT_8000` switches the PRG ROM to bank 0 in this case. Cases like this can be fixed in Ghidra using the following steps:

1. Right click the `JMP` instruction
2. Click "References > Add/Edit (R)"
3. Double click the destination operand
4. For the "To Address" field, change the left-hand dropdown from "RAM:" to the appropriate memory bank ("PRG0::" for this example)
5. Click "Update"

The disassembly should now show a jump to the correct bank:

![Ghidra disassembly showing the same "reset" function, but the "JMP" instruction now goes to "(0xfffc)=>LAB_PRG0__ffaf"](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/bank-switching-fixed.png)

> Note: Any write instruction (e.g. `STA`/`STX`/'STY', `INC`/`DEC`) to a mapper register will cause control flow to change if the bank containing the currently-executing code is switched out. To fix these:
>
> 1. Right-click the write instruction
> 2. Choose `Fallthrough`>`Set...`
> 3. Remember the value in the address offset box
> 4. Select `User`, and choose the new bank from the dropdown.
> 5.  Set the address offset box to the value from step 3 (since the PC will still be the "next" instruction in the new bank).
>
>This should help with analysis and decompilation so they can "follow" the bank switch.

By default, ROMs with PRG block sizes of less than 32K are created with a base address of `0x8000` except for the last bank, which will be at the "highest" address for that bank (8K blocks will be at `0xe000`, 16K at `0xc000`).  You can use the `Options...` dialog at load time to set each bank's address if you know in advance where each bank should be.  If you later determine that the guess was wrong and you don't want to re-import the ROM, you can re-base the bank using the Memory Map window:

1. Select menu `Window`>`Memory Map` if you don't have it open already.
2. Select the row with the bank you want to change.
3. Select the blue cross icon ("Move a block to another address") in the title bar of the Memory Map window.
4. Change the "New Start Address" to the correct base address.  The "New End Address" should automatically update for you based on the block size.
5. Select "OK" and the bank will be updated.

## Development

### Developing with Eclipse

1. Install Java and Ghidra.
2. install Eclipse.
3. Install the GhidraDev Eclipse plugin. Instructions can be found in your Ghidra install directory, under `Extensions/Eclipse/GhidraDev/GhidraDev_README.html`.
4. In Eclipse, open the GhidraNes repo by going to "File" > "Open Projects from File System...". Click "Directory", then choose this repo (the _top-level_ folder containing this `README.md` file and the `GhidraNes` subdirectory). Finally, click "Finish".
5. Open "GhidraDev" > "Link Ghidra...". Add your Ghidra installation, click "Next >", then select the "GhidraNes" as the Java project. Click "Finish".
6. Go to "Run" > "Run As" > "Ghidra" to run Ghidra with the GhidraNes extension.

### Building a release from Eclipse

**NOTE:** Ensure the GhidraNes Eclipse project is set up with the _earliest_ version of Java that should be targeted. Using a later version of Java can cause compatibility issues!

1. Install Gradle (with [SDKMAN](https://sdkman.io/), this can be done with `sdk install gradle`).
2. In Eclipse, open "GhidraDev" > "Export" > "Ghidra Module Extension...". Choose "GhidraNes" as the project, click "Next >", then choose "Local installation directory:" and browse to your Gradle installation dir (with SDKMAN, this will be at `~/.sdkman/candidates/gradle/$GRADLE_VERSION`). Click "Finish".
3. The built zip file will be saved in the `GhidraNes/dist/` directory. See the "Installation" section for details on installing the built zip.

### Developing with another editor (such as VS Code)

1. Install Java and Ghidra.
2. Configure the JDK settings in your editor.
    - For VSCode: Follow the official ["Getting Started with Java in VS Code"](https://code.visualstudio.com/docs/java/java-tutorial) guide.
3. Copy the `GhidraNes/gradle.properties.example` file to `GhidraNes/gradle.properties` and configure Ghirda's installation directory as needed.
4. Import the GhidraNes repo as a Java project (the _top-level_ folder containing this `README.md` file and the `GhidraNes` subdirectory).

### Building a release with Gradle

1. Move to the inner `GhidraNes` subdirectory: `cd GhidraNes/GhidraNes`
2. Run `gradle buildExtension`
    - If the `gradle.properties` file hasn't been set up, properties can be passed to Gradle directly, e.g. `gradle buildExtension -PGHIDRA_INSTALL_DIR=/home/user/ghidra_10.2.2_PUBLIC`
3. The built zip file will be saved in the `GhidraNes/dist/` directory. See the "Installation" section for details on installing the built zip.

## Publishing a release

1. Update `CHANGELOG.md` as a new commit
2. Create a tag for the new release. The tag and release name should be named `vYYYYMMDD` based on the current date [in UTC](https://www.utctime.net/) (e.g. `v20250520`)
3. Push the tag. This will trigger the ["Release" GH Actions workflow](https://github.com/kylewlacy/GhidraNes/actions/workflows/release.yml), which will create a new [draft release](https://github.com/kylewlacy/GhidraNes/releases) with release notes and build assets after a few minutes
4. Double-check that the build assets look good, adjust or add to the release notes if needed, and publish!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---