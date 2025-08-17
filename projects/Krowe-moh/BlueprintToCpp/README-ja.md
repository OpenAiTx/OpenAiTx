# Blueprint To C++

Unreal EngineのBlueprintをC++コードに変換するツール。

[CUE4Parse](https://github.com/FabianFG/CUE4Parse)によって動作しています。

## インストール

1. リポジトリをクローンします:
    ```bash
    git clone https://github.com/Krowe-moh/BlueprintToCpp.git --recursive
    ```

2. IDEでソリューションファイルを開き、プロジェクトをビルドします。

## 使用方法

1. 実行可能ファイルを実行して、`config.json` ファイルを自動的に作成します。

2. `config.json` のオプションを設定します：

    例：
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
3. 変換を開始するには、`Main.exe` を実行してください。

## AES

AESを設定したい場合は、プログラムを一度実行（設定済みの状態で）し、その後作成される `aes.json` ファイルを編集してください。

## 出力

逆コンパイルされたブループリントは `Output.cpp` として出力されます（現在はフォルダ階層として出力されるように変更されており、近日中に無効化するオプションが追加される予定です）。

注意：現時点では、このツールはすべての式に対応しておらず、C++の出力は100％正確ではない可能性があります。

## 問題点

問題が発生した場合は、[こちら](https://github.com/Krowe-moh/BlueprintToCpp/issues)に報告してください。

## 貢献

問題を報告したり、リポジトリをフォークして改善のためのプルリクエストを作成したりすることは自由です。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-17

---