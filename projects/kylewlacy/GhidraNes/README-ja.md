# GhidraNes

NES ROMの逆アセンブルと解析をサポートするGhidra拡張機能。

![Ghidra disassembly showing a decompiled function from a file named "game.nes"](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/ghidra-nes.png)

## 機能

- iNESフォーマットのNES ROMをインポート。以下のマッパーをサポート：
    - 16K/32K固定PRG ROM
        - [NROM](https://www.nesdev.org/wiki/NROM) (マッパー0)
        - [CNROM](https://www.nesdev.org/wiki/CNROM) (マッパー3, 185)
        - [CPROM](https://www.nesdev.org/wiki/CPROM) (マッパー13)
    - 16Kバンク切り替え可能PRG ROM
        - [MMC1/SxROM](https://www.nesdev.org/wiki/MMC1) (マッパー1、マッパー16も含む)
        - [UxROM](https://www.nesdev.org/wiki/UxROM) (マッパー2)
        - [MMC4/FxROM](https://www.nesdev.org/wiki/MMC4) (マッパー10)
        - [UNROM 512](https://www.nesdev.org/wiki/UNROM_512) (マッパー30)
        - [Sunsoft 3](https://www.nesdev.org/wiki/INES_Mapper_067)/[Sunsoft 4](https://www.nesdev.org/wiki/INES_Mapper_068) (マッパー67, 68)
        - その他マッパー [16](https://www.nesdev.org/wiki/INES_Mapper_016)
    - 32Kバンク切り替え可能PRG ROM
        - [AxROM](https://www.nesdev.org/wiki/AxROM) (マッパー7)
        - [BNROM/NINA](https://www.nesdev.org/wiki/INES_Mapper_034) (マッパー34)
        - [GxROM](https://www.nesdev.org/wiki/GxROM) (マッパー66)
        - その他マッパー [11](https://www.nesdev.org/wiki/Color_Dreams), [38](https://www.nesdev.org/wiki/INES_Mapper_038), [140](https://www.nesdev.org/wiki/INES_Mapper_140)
    - 8Kバンク切り替え可能PRG ROM
        - [MMC3/TxROM](https://www.nesdev.org/wiki/MMC3)/[TxSROM](https://www.nesdev.org/wiki/INES_Mapper_118)/[TQROM](https://www.nesdev.org/wiki/INES_Mapper_119) (マッパー4, 118, 119)
        - [Namco 129/163](https://www.nesdev.org/wiki/INES_Mapper_019) (マッパー19)
        - [Konami VRC2/4](https://www.nesdev.org/wiki/VRC2_and_VRC4) (マッパー21, 22, 23, 25)
        - [RAMBO-1](https://www.nesdev.org/wiki/RAMBO-1) (マッパー64, 158)
        - [Sunsoft FME-7/5A/5B](https://www.nesdev.org/wiki/Sunsoft_FME-7) (マッパー69)
        - [DxROM](https://www.nesdev.org/wiki/DxROM) (マッパー[206](https://www.nesdev.org/wiki/INES_Mapper_206))
        - その他マッパー [18](https://www.nesdev.org/wiki/INES_Mapper_018), [65](https://www.nesdev.org/wiki/INES_Mapper_065), [74](https://www.nesdev.org/wiki/INES_Mapper_074), [76](https://www.nesdev.org/wiki/INES_Mapper_076), [88](https://www.nesdev.org/wiki/INES_Mapper_088), [95](https://www.nesdev.org/wiki/INES_Mapper_095), [154](https://www.nesdev.org/wiki/INES_Mapper_154), [191](https://www.nesdev.org/wiki/INES_Mapper_191), [192](https://www.nesdev.org/wiki/INES_Mapper_192), [194](https://www.nesdev.org/wiki/INES_Mapper_194), [195](https://www.nesdev.org/wiki/INES_Mapper_195)

- 逆アセンブルにラベルとメモリブロックを追加し、逆アセンブルされたROM内の移動を容易に！

## インストール

1. 互換性のあるJavaおよびGhidraのバージョンをインストール（Java 21以上）。
2. 最新の[GhidraNesリリース](https://github.com/kylewlacy/GhidraNes/releases)をダウンロード。ダウンロードしたリリースがGhidraのバージョンに合っていることを確認！
3. 「ファイル」>「拡張機能のインストール...」に移動します。右上の「＋」をクリックし、GhidraNesのZipファイルを選択します。「OK」をクリックして拡張機能をインストールします。  
4. Ghidraを再起動します。  

## 使用方法  

1. Ghidraで「ファイル」>「新規プロジェクト...」のウィザードに従って新しいプロジェクトを作成します。  
2. iNESの`.nes` ROMファイルをプロジェクトにドラッグアンドドロップします。フォーマットを「NES ROM」に設定し、「OK」をクリックします。  
3. プロジェクト内のROMをダブルクリックしてGhidraのCodeBrowserを開きます。  
4. ファイルの解析を促されたら実行するか、「解析」>「自動解析...」に進みます。設定はデフォルトのままにして「解析」をクリックします。  
5. 完了です。ゲームが逆アセンブルされます！左側の「シンボルツリー」>「関数」内で`reset`を開くとリセットベクタ（実行開始位置）にジャンプします。または`vblank`を開くとNMIベクタ（VBlank中の実行位置）にジャンプします。  

## 注意事項  

### バンク切り替え  

GhidraNesはROMの各バンクを独自のメモリブロックとしてマッピングしますが、バンク切り替えを自動で処理する制御フロー解析は実装されていません。代わりに、逆アセンブルでのバンク切り替えの処理は手動で行います。例えば以下の関数を見てください：  

![Ghidra disassembly showing a "reset" function consisting of "LDA #0x0", "STA DAT_8000", and "JMP (0xfffc)=>reset". The gutter shows this function as an infinite loop](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/bank-switching-broken.png)  

この逆アセンブルされた関数はバンク切り替えを行っています：`DAT_8000`への書き込みはこの場合PRG ROMをバンク0に切り替えています。このようなケースは以下の手順でGhidra内で修正可能です：  

1. `JMP`命令を右クリック  
2. 「参照」>「追加/編集 (R)」をクリック  
3. 宛先オペランドをダブルクリック  
4. 「アドレス先」欄の左側ドロップダウンを「RAM:」から適切なメモリバンク（この例では「PRG0::」）に変更  
5. 「更新」をクリック  

これで逆アセンブルは正しいバンクへのジャンプを表示するはずです：  

![Ghidra disassembly showing the same "reset" function, but the "JMP" instruction now goes to "(0xfffc)=>LAB_PRG0__ffaf"](https://raw.githubusercontent.com/kylewlacy/GhidraNes/main/.github/screenshots/bank-switching-fixed.png)  

> 注意：マッパーレジスタへの書き込み命令（例：`STA`/`STX`/`STY`、`INC`/`DEC`）は、現在実行中のコードを含むバンクが切り替えられると制御フローが変化します。これを修正するには：  
>  
> 1. 書き込み命令を右クリック  
> 2. 「フォールスルー」>「設定...」を選択  
> 3. アドレスオフセット欄の値をメモ  
> 4. 「ユーザー」を選択し、ドロップダウンから新しいバンクを選択  
> 5. アドレスオフセット欄にステップ3でメモした値を設定（PCは新しいバンク内の「次の」命令のままのため）  
>  
> これにより解析や逆コンパイルがバンク切り替えを「追跡」できるようになります。
デフォルトでは、PRGブロックサイズが32K未満のROMは、最後のバンクを除いてベースアドレスが`0x8000`で作成されます。最後のバンクはそのバンクの「最高」アドレスに配置されます（8Kブロックは`0xe000`、16Kは`0xc000`）。各バンクのアドレスを事前に把握している場合は、ロード時に`Options...`ダイアログで各バンクのアドレスを設定できます。後で推測が間違っていることが判明し、ROMを再インポートしたくない場合は、メモリマップウィンドウを使ってバンクのベースを再設定できます：

1. まだ開いていない場合は、メニューから`Window`>`Memory Map`を選択します。
2. 変更したいバンクの行を選択します。
3. メモリマップウィンドウのタイトルバーにある青い十字アイコン（「ブロックを別のアドレスに移動」）を選択します。
4. 「New Start Address」を正しいベースアドレスに変更します。「New End Address」はブロックサイズに基づいて自動的に更新されます。
5. 「OK」を選択すると、バンクが更新されます。

## 開発

### Eclipseでの開発

1. JavaとGhidraをインストールします。
2. Eclipseをインストールします。
3. GhidraDev Eclipseプラグインをインストールします。手順はGhidraのインストールディレクトリの`Extensions/Eclipse/GhidraDev/GhidraDev_README.html`にあります。
4. Eclipseで「File」>「Open Projects from File System...」を開きます。「Directory」をクリックし、このリポジトリ（この`README.md`ファイルと`GhidraNes`サブディレクトリを含むトップレベルフォルダ）を選択します。最後に「Finish」をクリックします。
5. 「GhidraDev」>「Link Ghidra...」を開き、Ghidraのインストールを追加します。「Next >」をクリックし、「GhidraNes」をJavaプロジェクトとして選択します。「Finish」をクリックします。
6. 「Run」>「Run As」>「Ghidra」を選択し、GhidraNes拡張付きのGhidraを起動します。

### Eclipseからのリリースビルド

**注意：** GhidraNes Eclipseプロジェクトは、ターゲットとする最も古いJavaバージョンで設定してください。後のバージョンを使うと互換性の問題が発生する可能性があります！

1. Gradleをインストールします（[SDKMAN](https://sdkman.io/)を使うと`sdk install gradle`で可能です）。
2. Eclipseで「GhidraDev」>「Export」>「Ghidra Module Extension...」を開きます。プロジェクトに「GhidraNes」を選択し「Next >」をクリック、「Local installation directory:」を選択してGradleのインストールディレクトリを指定します（SDKMANの場合は`~/.sdkman/candidates/gradle/$GRADLE_VERSION`にあります）。「Finish」をクリックします。
3. ビルドされたzipファイルは`GhidraNes/dist/`ディレクトリに保存されます。インストール方法の詳細は「Installation」セクションを参照してください。

### 他のエディタ（例：VS Code）での開発

1. JavaとGhidraをインストールします。
2. エディタでJDK設定を行います。
    - VSCodeの場合は公式の「[Getting Started with Java in VS Code](https://code.visualstudio.com/docs/java/java-tutorial)」ガイドに従ってください。
3. `GhidraNes/gradle.properties.example`を`GhidraNes/gradle.properties`にコピーし、必要に応じてGhidraのインストールディレクトリを設定します。
4. GhidraNesリポジトリをJavaプロジェクトとしてインポートします（この`README.md`ファイルと`GhidraNes`サブディレクトリを含むトップレベルフォルダ）。

### Gradleでのリリースビルド

1. 内部の`GhidraNes`サブディレクトリに移動します：`cd GhidraNes/GhidraNes`
2. `gradle buildExtension`を実行します。

    - `gradle.properties` ファイルが設定されていない場合は、プロパティを直接 Gradle に渡すことができます。例：`gradle buildExtension -PGHIDRA_INSTALL_DIR=/home/user/ghidra_10.2.2_PUBLIC`
3. ビルドされた zip ファイルは `GhidraNes/dist/` ディレクトリに保存されます。ビルドした zip のインストール方法については「インストール」セクションを参照してください。

## リリースの公開

1. `CHANGELOG.md` を新しいコミットとして更新します
2. 新しいリリース用のタグを作成します。タグとリリース名は現在の日付（[UTC](https://www.utctime.net/)）に基づき `vYYYYMMDD` としてください（例：`v20250520`）
3. タグをプッシュします。これにより ["Release" GH Actions ワークフロー](https://github.com/kylewlacy/GhidraNes/actions/workflows/release.yml) がトリガーされ、数分後にリリースノートとビルド資産を含む新しい [ドラフトリリース](https://github.com/kylewlacy/GhidraNes/releases) が作成されます
4. ビルド資産が問題ないか再確認し、必要に応じてリリースノートを調整または追加して公開してください！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-22

---