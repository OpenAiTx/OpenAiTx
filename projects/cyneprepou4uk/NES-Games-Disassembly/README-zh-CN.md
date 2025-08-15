# NES 游戏反汇编

每个源代码都等同于原始 ROM，可编译且可编辑。

所有代码均由我的 [BZK 6502 反汇编器](https://github.com/cyneprepou4uk/BZK-6502-Disassembler) 脚本制作。

你可以在 [RHDN](https://www.romhacking.net/forum/index.php?topic=32220.0) 主题中联系我。



## 如何构建反汇编

### Windows

无特殊要求。只需运行 `assemble.bat` 并等待完成。

### 其他操作系统

尝试在终端使用 `sh assemble.sh`。所有功劳归于 [gb-2312](https://github.com/gb-2312)。

除非你了解其工作原理，否则不要删除或编辑 `_scripts` 和 `_install_packages` 文件夹。



## 语法高亮

使用 `syntax_6502.xml` 在 [Notepad++](https://notepad-plus-plus.org/) 中高亮代码。

进入 Language -> User Defined Language -> Define your language -> Import。



## 如何编辑反汇编

重要注释以 `bzk` 文本标记。先删除垃圾代码以释放空间。

不用担心类似 `C - - - - - 0x00009C 00:C08C: A9 00     LDA #$00` 的内容。

`preparations.lua` 脚本会在编译前处理它。你只需像平常一样编写新代码，例如 `LDA #$00`。

您可以手动使用正则表达式 `.\s.\s.\s.\s.\s.\s0x0........:....:\s..\s..\s..\s\s` 删除此文本（如有必要）。

## 游戏列表（GoodNES）+ CRC32

### 反汇编
* 冒险岛 (U) [!] `B78C09A2`
* 战斗城市 (J) [!] `F599A07E`
* 巴格斯兔疯狂城堡 (U) [!] `DB0C3656`
* 恶魔城III - 德古拉的诅咒 (U) [!] `7CC9C669`
* 魂斗罗力量 (U) [!] `83D69922`
* 丹尼·沙利文的印第赛车 (U) [!] `311B5A58`
* 双截龙II - 复仇 (J) `8CF69E4B`
* 马里奥医生 (JU) (PRG0) [!] `B1F7E3E9`
* 急速摩托 (JU) [!] `2BB33C69`
* 菲力克斯猫 (U) [!] `0639E88E`
* 冰山攀登者 (J) [!] `80C41616`
* 热血足球联盟 (J) [!] `61C27F7B`
* 塞尔达传说 (U) (PRG0) [!] `D7AE93DF`
* 小美人鱼 (U) [!] `08EB97DB`
* 马皮 (J) [!] `3F0E8E0A`
* 坚果与牛奶 (J) [!] `11879FE8`
* 吃豆人 (J) (V1.1) [!] `D747B639`
* 机械战警3 (U) [!] `FBBB58A6`
* 冬至 - 魔杖的寻找 (U) [!] `1D60732E`
* 孙孙 (J) [!] `F7C8F42D`
* 街头霸王III (9 Fighter) (无标) `22CDD2F6`
* 超级C (U) [!] `1AC846F0`
* Tecmo世界杯足球 (J) [!] `19F24980`
* 网球 (JU) [!] `5F457C00`
* 乂阿功夫 (J) (V1.4) [!] `0D526208`

### 进行中
* 青蛙战士与双截龙 - 终极团队 (U) [!] `53B02F3D`
* 美国队长与复仇者 (U) [!].nes `7254D53D`
* 加拉加 - 死亡恶魔 (U) [!] `E36D5991`
* 忍者龙剑传III - 末日古船 (U) [!] `BABD39FA`




* R.C. Pro-Am II (U) [!] `03DB5562`
* 河城热血传说 (U) [!] `C3508F7E`
* 超级马里奥兄弟 (W) [!] `3337EC46`
* 城市勇士 (W) [!] `0770CDAA`



### 规划
* 气球大战 (J) [!] `A0DABE0A`
* 泡泡龙 (U) [!] `D3A91B41`
* 鬼魂与恶魔 (U) [!] `87ED54AA`
* 小孩伊卡洛斯 (UE) [!] `0B30E036`
* 肌肉人 - 肌肉对决 (J) (PRG0) [!] `C296C8CE`
* 最强终极格斗 (U) [!] `15EB0BEE`
* 三目童子 (J) [!] `E27EC1EC`
* 大力水手 (JU) (PRG0) [!] `DE1D762F`
* 俄罗斯方块 (Tengen) [!] `88F071C3`


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-15

---