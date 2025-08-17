# Plano a C++

Una herramienta que convierte Blueprints de Unreal Engine a código C++.

Impulsado por [CUE4Parse](https://github.com/FabianFG/CUE4Parse)

## Instalación

1. Clona el repositorio:
    ```bash
    git clone https://github.com/Krowe-moh/BlueprintToCpp.git --recursive
    ```

2. Abra el archivo de la solución en su IDE y compile el proyecto.

## Uso

1. Ejecute el ejecutable para crear automáticamente un archivo `config.json`.

2. Configure las opciones en `config.json`:

    Ejemplo:
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
3. Ejecute `Main.exe` para iniciar la conversión.

## AES

Si desea configurar AES, ejecute el programa una vez (con la configuración establecida), luego modifique el archivo `aes.json` que se crea.

## Salida

El plano descompilado se generará como `Output.cpp` (esto ha cambiado para generar una jerarquía de carpetas, pronto habrá una opción para desactivar esto).

Nota: Actualmente, esta herramienta no soporta todas las expresiones, y la salida en C++ puede no ser 100% precisa.

## Problemas

Si encuentra algún problema, por favor envíelos [aquí](https://github.com/Krowe-moh/BlueprintToCpp/issues).

## Contribuciones

Siéntase libre de enviar problemas, bifurcar el repositorio y crear solicitudes de extracción para cualquier mejora.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-17

---