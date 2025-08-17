# Blueprint To C++

Un outil qui convertit les Blueprints d'Unreal Engine en code C++.

Propulsé par [CUE4Parse](https://github.com/FabianFG/CUE4Parse)

## Installation

1. Clonez le dépôt :
    ```bash
    git clone https://github.com/Krowe-moh/BlueprintToCpp.git --recursive
    ```

2. Ouvrez le fichier de solution dans votre IDE et compilez le projet.

## Utilisation

1. Exécutez le fichier exécutable pour créer automatiquement un fichier `config.json`.

2. Configurez les options dans `config.json` :

    Exemple :
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

3. Exécutez `Main.exe` pour démarrer la conversion.

## AES

Si vous souhaitez configurer AES, exécutez le programme une fois (avec la configuration définie), puis modifiez le fichier `aes.json` qui est créé.

## Sortie

Le plan décompilé sera généré sous le nom `Output.cpp` (cela a changé pour une sortie sous forme de hiérarchie de dossiers, une option pour désactiver cela sera bientôt disponible).

Note : Actuellement, cet outil ne prend pas en charge toutes les expressions, et la sortie C++ peut ne pas être 100 % précise.

## Problèmes

Si vous rencontrez des problèmes, veuillez les soumettre [ici](https://github.com/Krowe-moh/BlueprintToCpp/issues).

## Contribution

N’hésitez pas à soumettre des problèmes, à forker le dépôt et à créer des pull requests pour toute amélioration.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-17

---