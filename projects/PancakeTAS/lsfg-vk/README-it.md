# lsfg-vk
Questo progetto porta [Lossless Scaling's Frame Generation](https://store.steampowered.com/app/993090/Lossless_Scaling/) su Linux!
>[!NOTE]
> Questo è un progetto in corso d'opera. Sebbene la generazione dei frame abbia funzionato in alcuni giochi, c'è ancora molta strada da fare. Si prega di consultare la wiki per il supporto (la wiki non è ancora stata scritta)

## Compilazione, Installazione ed Esecuzione

>[!CAUTION]
> Le istruzioni di compilazione sono cambiate di recente. Si prega di rivederle.

Per compilare LSFG, assicurati di avere i seguenti componenti installati sul tuo sistema:
- Strumenti di build tradizionali (+ sed, git)
- Compilatore Clang (questo progetto NON si compila facilmente con GCC)
- File header di Vulkan
- Sistema di build CMake
- Sistema di build Meson (per DXVK)
- Sistema di build Ninja (backend per CMake)

Compilare lsfg-vk è relativamente semplice, poiché tutto è ben integrato in CMake:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
Questo installerà lsfg-vk in ~/.local/lib e ~/.local/share/vulkan.

Successivamente, dovrai scaricare Lossless Scaling da Steam. Passa al branch `legacy_2.13` oppure scarica il relativo depot.
Copia o annota il percorso di "Lossless.dll" dai file di gioco.

Infine, avviamo effettivamente un programma con la generazione dei frame abilitata. Userò `vkcube` per questo esempio:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
Assicurati di regolare i percorsi. Esaminiamo ciascuno di essi:
- `LVK_INSTANCE_LAYERS`: Specifica qui `VK_LAYER_LS_frame_generation`. Questo forza qualsiasi app Vulkan a caricare il layer lsfg-vk.
- `LSFG_DLL_PATH`: Qui specifichi il Lossless.dll che hai scaricato da Steam. lsfg-vk estrarrà e tradurrà gli shader da qui.
- `LSFG_MULTIPLIER`: Questo è il moltiplicatore che dovresti conoscere. Specifica `2` per raddoppiare il framerate, ecc.
- `VK_LAYER_PATH`: Se non hai installato in `~/.local` o `/usr`, devi specificare qui la cartella `explicit_layer.d`.

>[!WARNING]
> Diversamente da Windows, LSFG_MULTIPLIER è fortemente limitato qui (al momento!). Se il tuo hardware può creare 8 immagini di swapchain, allora impostando LSFG_MULTIPLIER a 4 ne occuperai 4, lasciandone solo 4 al gioco. Se il gioco ne richiede 5 o più, andrà in crash.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---