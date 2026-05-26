# MaichartConverter

## A simple program provide functionality of converting maimai chart between Simai and Ma2.

> The original supporting classes are now separated from this repo. Please
> see [MaiLib](https://github.com/Neskol/MaiLib) for more information.

### Build

    git clone
    git submodule update --init --recursive
    dotnet build

### Usage & Available Commands

> Type 'MaichartConverter help' for detailed manual for each command.

- `CompileDatabase`([English](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileDatabase.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileDatabase_CN.md)): Compose
  whole ma2 database to simai
- `CompileMa2`([English](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileMa2.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileMa2_CN.md)): Compile assigned Ma2
  chart to assigned format
- `CompileMa2ID`([English](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileMa2ID.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileMa2ID_CN.md)): Compile assigned
  Ma2 chart indexed by ID to assigned format
- `CompileSimai`([English](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/CompileSimai.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/CompileSimai_CN.md)): Compile assigned
  simai chart to assigned format
-
`ReverseMa2FromSimaiDatabase`([English](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/ENG/ReverseMa2FromSimaiDatabase.md)/[中文](https://raw.githubusercontent.com/Neskol/MaichartConverter/master/./Manuals/CHN/ReverseMa2FromSimaiDatabase_CN.md)):
Reverse Simai Database from given folder to MaiAnalysis folder for compilation

### Parameters notice

- music files should be named musicxxxxxx.mp3 which xxxxxx matches the music id specified in music.xml in each a000
  folder, and compensate 0s at the front to 6 digits
- bga files should be named xxxxxx.mp4 which matches the music id specified in music.xml in each a000 folder, and
  compensate 0s at the front to 6 digits
- image folder should be structured in image/Texture2D/ and the files should start with UI_Jacket_xxxxxx.jpg which
  xxxxxx matches the music id specified in music.xml in each a000 folder, and compensate 0s at the front to 6 digits
- All the rules specified above is in convenience for you to directly use after you obtain data from considerable
  ways
- The difficulty parameter is listed 0-4 as Basic to Re:Master. In MaiLib I specified rules for Easy and Utage, but it
  takes times for me to figure it out, or you could implement on you own referring MaiLib code
- All the path should end with path separator like "/" or "\". You cannot include quote signs in the path.
- If you have difficulty using the commands, please refer VSCode launch.json where I included several examples
- The whole program was planned to convert from ma2 to simai initially and all other features were developed after that,
  so there is a HUGE amount of compromises in code design which made it hard to read (but works so far). It would be
  most kind of you if you would like to help me to fix that

### Disclaimer

- Copyrights of the works belong to each individual right holders. This tool is purely used as non-commercial and study
  purpose. You should find your way for any resource might be used and properly use at your own risk.
- If you would like to use the parser in your project, please refer [MaiLib](https://github.com/Neskol/MaiLib) and
  hopefully that helps!
