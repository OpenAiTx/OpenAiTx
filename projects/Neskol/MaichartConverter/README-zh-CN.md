# MaichartConverter

## 一个简单的程序，提供在Simai和Ma2之间转换maimai谱面的功能。

> 原始支持类现已从此仓库分离。请参见
> [MaiLib](https://github.com/Neskol/MaiLib) 获取更多信息。

### 构建

    git clone
    git submodule update --init --recursive
    dotnet build

### 使用方法及可用命令

> 输入 'MaichartConverter help' 可获得每个命令的详细手册。

- `CompileDatabase`([英文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileDatabase.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileDatabase_CN.md)): 将
  整个ma2数据库合成为simai格式
- `CompileMa2`([英文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileMa2.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileMa2_CN.md)): 编译指定的Ma2
  谱面至指定格式
- `CompileMa2ID`([英文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileMa2ID.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileMa2ID_CN.md)): 按ID索引编译指定的
  Ma2谱面至指定格式
- `CompileSimai`([英文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileSimai.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileSimai_CN.md)): 编译指定的
  simai谱面至指定格式
-
`ReverseMa2FromSimaiDatabase`([英文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/ReverseMa2FromSimaiDatabase.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/ReverseMa2FromSimaiDatabase_CN.md)):
从给定文件夹反向生成Simai数据库至MaiAnalysis文件夹以供编译

### 参数说明

- 音乐文件应命名为 musicxxxxxx.mp3，xxxxxx对应每个a000文件夹中music.xml指定的音乐ID，且前面补足0至6位数
- bga文件应命名为 xxxxxx.mp4，xxxxxx对应每个a000文件夹中music.xml指定的音乐ID，且前面补足0至6位数
- 图片文件夹应结构为 image/Texture2D/，文件名应以 UI_Jacket_xxxxxx.jpg 开头，xxxxxx对应每个a000文件夹中music.xml指定的音乐ID，且前面补足0至6位数
- 以上所有规则方便您在通过各种方式获取数据后直接使用
- 难度参数列为0-4，分别对应Basic至Re:Master。在MaiLib中我指定了Easy和Utage的规则，但它




  花了一些时间才弄明白，或者你也可以参考 MaiLib 代码自行实现  
- 所有路径应以路径分隔符结尾，如“/”或“\”。路径中不能包含引号。  
- 如果你在使用命令时遇到困难，请参考我在 VSCode launch.json 中包含的几个示例  
- 整个程序最初是计划从 ma2 转换到 simai，其他功能都是后来开发的，  
  所以代码设计上有大量妥协，导致代码难以阅读（但目前能正常工作）。  
  如果你愿意帮我修复这些问题，将不胜感激  

### 免责声明  

- 作品版权归各自权利人所有。该工具纯粹用于非商业和学习目的。  
  你应自行寻找任何可能使用的资源，并自行承担合理使用的风险。  
- 如果你想在项目中使用该解析器，请参考 [MaiLib](https://github.com/Neskol/MaiLib)，  
  希望对你有所帮助！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-26

---