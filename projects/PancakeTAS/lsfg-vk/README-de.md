# lsfg-vk
Dieses Projekt bringt [Lossless Scaling's Frame Generation](https://store.steampowered.com/app/993090/Lossless_Scaling/) nach Linux!
>[!NOTE]
> Dies ist ein laufendes Projekt. Während die Frame-Generierung in einigen Spielen bereits funktioniert hat, gibt es noch viel zu tun. Bitte sieh dir das Wiki für Support an (das Wiki ist noch nicht geschrieben)

## Bauen, Installieren und Ausführen

>[!CAUTION]
> Die Build-Anweisungen haben sich kürzlich geändert. Bitte prüfe sie.

Um LSFG zu kompilieren, stelle sicher, dass du die folgenden Komponenten auf deinem System installiert hast:
- Traditionelle Build-Tools (+ sed, git)
- Clang-Compiler (dieses Projekt lässt sich NICHT einfach mit GCC kompilieren)
- Vulkan-Header-Dateien
- CMake-Buildsystem
- Meson-Buildsystem (für DXVK)
- Ninja-Buildsystem (Backend für CMake)

Das Kompilieren von lsfg-vk ist relativ einfach, da alles sauber in CMake integriert ist:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
Dies installiert lsfg-vk nach ~/.local/lib und ~/.local/share/vulkan.

Als Nächstes musst du Lossless Scaling von Steam herunterladen. Wechsle zum Branch `legacy_2.13` oder lade das entsprechende Depot herunter.
Kopiere oder notiere den Pfad der "Lossless.dll" aus den Spieldateien.

Schließlich wollen wir ein Programm mit aktivierter Frame-Generierung starten. In diesem Beispiel verwende ich `vkcube`:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
Stelle sicher, dass du die Pfade anpasst. Schauen wir uns die einzelnen an:
- `VK_INSTANCE_LAYERS`: Hier gibst du `VK_LAYER_LS_frame_generation` an. Dies zwingt jede Vulkan-App, das lsfg-vk-Layer zu laden.
- `LSFG_DLL_PATH`: Hier gibst du die Lossless.dll an, die du von Steam heruntergeladen hast. lsfg-vk extrahiert und übersetzt die Shader von hier.
- `LSFG_MULTIPLIER`: Dies ist der Multiplikator, den du bereits kennst. Gib `2` an, um die Framerate zu verdoppeln, usw.
- `VK_LAYER_PATH`: Wenn du nicht nach `~/.local` oder `/usr` installiert hast, musst du hier den Ordner `explicit_layer.d` angeben.

>[!WARNING]
> Im Gegensatz zu Windows ist LSFG_MULTIPLIER hier (im Moment!) stark limitiert. Wenn deine Hardware 8 Swapchain-Images erstellen kann, dann belegt LSFG_MULTIPLIER=4 vier davon, sodass nur noch vier für das Spiel übrig bleiben. Wenn das Spiel fünf oder mehr anfordert, wird es abstürzen.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---