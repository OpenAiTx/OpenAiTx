# lsfg-vk
Dit project brengt [Lossless Scaling's Frame Generation](https://store.steampowered.com/app/993090/Lossless_Scaling/) naar Linux!
>[!NOTE]
> Dit is een work-in-progress. Hoewel framegeneratie al in enkele games heeft gewerkt, is er nog een lange weg te gaan. Raadpleeg de wiki voor ondersteuning (de wiki is nog niet geschreven)

## Bouwen, Installeren en Uitvoeren

>[!CAUTION]
> De bouwinstructies zijn recentelijk gewijzigd. Bekijk ze alstublieft.

Om LSFG te compileren, zorg ervoor dat je de volgende componenten op je systeem hebt geïnstalleerd:
- Traditionele buildtools (+ sed, git)
- Clang-compiler (dit project compileert NIET eenvoudig met GCC)
- Vulkan-headerbestanden
- CMake-buildsysteem
- Meson-buildsysteem (voor DXVK)
- Ninja-buildsysteem (backend voor CMake)

Het compileren van lsfg-vk is relatief eenvoudig, omdat alles netjes geïntegreerd is in CMake:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
Dit zal lsfg-vk installeren naar ~/.local/lib en ~/.local/share/vulkan.

Vervolgens moet je Lossless Scaling downloaden van Steam. Schakel over naar de `legacy_2.13` branch of download het bijbehorende depot.
Kopieer of noteer het pad van "Lossless.dll" uit de gamebestanden.

Tot slot gaan we daadwerkelijk een programma starten met framegeneratie ingeschakeld. Ik gebruik `vkcube` voor dit voorbeeld:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
Zorg ervoor dat je de paden aanpast. Laten we elk ervan bekijken:
- `LVK_INSTANCE_LAYERS`: Geef hier `VK_LAYER_LS_frame_generation` op. Dit dwingt elke Vulkan-app om de lsfg-vk-laag te laden.
- `LSFG_DLL_PATH`: Hier geef je de Lossless.dll op die je van Steam hebt gedownload. lsfg-vk zal de shaders hieruit extraheren en vertalen.
- `LSFG_MULTIPLIER`: Dit is de multiplier waarmee je bekend zou moeten zijn. Geef `2` op om de framerate te verdubbelen, enzovoorts.
- `VK_LAYER_PATH`: Als je niet hebt geïnstalleerd naar `~/.local` of `/usr`, moet je hier de map `explicit_layer.d` opgeven.

>[!WARNING]
> In tegenstelling tot op Windows is LSFG_MULTIPLIER hier (op dit moment!) sterk beperkt. Als je hardware 8 swapchain-afbeeldingen kan maken, dan zal LSFG_MULTIPLIER op 4, vier daarvan bezetten, waardoor er nog maar 4 voor de game overblijven. Als de game er 5 of meer aanvraagt, zal deze crashen.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---