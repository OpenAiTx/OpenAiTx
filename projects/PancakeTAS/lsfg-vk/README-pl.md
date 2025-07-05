# lsfg-vk
Ten projekt przenosi [Generowanie Klatek Lossless Scaling](https://store.steampowered.com/app/993090/Lossless_Scaling/) na Linuksa!
>[!NOTE]
> To jest projekt w toku. Generowanie klatek działało w kilku grach, ale wciąż jest długa droga przed nami. Prosimy o sprawdzenie wiki w celu uzyskania wsparcia (wiki nie jest jeszcze napisana)

## Budowanie, instalacja i uruchamianie

>[!CAUTION]
> Instrukcje dotyczące budowania niedawno się zmieniły. Prosimy o zapoznanie się z nimi.

Aby skompilować LSFG, upewnij się, że masz zainstalowane następujące komponenty w swoim systemie:
- Tradycyjne narzędzia do budowania (+ sed, git)
- Kompilator Clang (ten projekt NIE kompiluje się łatwo z GCC)
- Pliki nagłówkowe Vulkan
- System budowania CMake
- System budowania Meson (dla DXVK)
- System budowania Ninja (backend dla CMake)

Kompilacja lsfg-vk jest stosunkowo prosta, ponieważ wszystko jest schludnie zintegrowane z CMake:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
To zainstaluje lsfg-vk do ~/.local/lib oraz ~/.local/share/vulkan.

Następnie musisz pobrać Lossless Scaling ze Steam. Przełącz się na gałąź `legacy_2.13` lub pobierz odpowiedni depot.
Skopiuj lub zapamiętaj ścieżkę do "Lossless.dll" z plików gry.

Na koniec uruchom program z włączonym generowaniem klatek. W tym przykładzie użyję `vkcube`:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
Upewnij się, że dostosowałeś ścieżki. Przyjrzyjmy się każdej z nich:
- `LVK_INSTANCE_LAYERS`: Podaj tutaj `VK_LAYER_LS_frame_generation`. To wymusza załadowanie warstwy lsfg-vk przez każdą aplikację Vulkan.
- `LSFG_DLL_PATH`: Tutaj podajesz Lossless.dll pobrane ze Steam. lsfg-vk wyodrębni i przetłumaczy z niego shadery.
- `LSFG_MULTIPLIER`: To mnożnik, który powinien być ci znany. Podaj `2`, aby podwoić liczbę klatek na sekundę itp.
- `VK_LAYER_PATH`: Jeśli nie zainstalowałeś do `~/.local` lub `/usr`, musisz tutaj podać folder `explicit_layer.d`.

>[!WARNING]
> W przeciwieństwie do Windows, tutaj LSFG_MULTIPLIER jest mocno ograniczony (na ten moment!). Jeśli twój sprzęt może utworzyć 8 obrazów swapchain, ustawienie LSFG_MULTIPLIER na 4 zajmuje 4 z nich, zostawiając tylko 4 dla gry. Jeśli gra zażąda 5 lub więcej, ulegnie awarii.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---