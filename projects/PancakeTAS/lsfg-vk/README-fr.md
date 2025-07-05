# lsfg-vk
Ce projet apporte la [génération d'images de Lossless Scaling](https://store.steampowered.com/app/993090/Lossless_Scaling/) sur Linux !
>[!NOTE]
> Ceci est un travail en cours. Bien que la génération d'images fonctionne dans quelques jeux, il reste encore beaucoup à faire. Veuillez consulter le wiki pour le support (le wiki n'est pas encore rédigé)

## Compilation, Installation et Exécution

>[!CAUTION]
> Les instructions de compilation ont récemment changé. Veuillez les consulter.

Pour compiler LSFG, assurez-vous d'avoir les composants suivants installés sur votre système :
- Outils de compilation traditionnels (+ sed, git)
- Compilateur Clang (ce projet NE se compile PAS facilement avec GCC)
- Fichiers d'en-tête Vulkan
- Système de build CMake
- Système de build Meson (pour DXVK)
- Système de build Ninja (backend pour CMake)

La compilation de lsfg-vk est relativement simple, car tout est soigneusement intégré dans CMake :
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
Cela installera lsfg-vk dans ~/.local/lib et ~/.local/share/vulkan.

Ensuite, vous devrez télécharger Lossless Scaling depuis Steam. Passez à la branche `legacy_2.13` ou téléchargez le dépôt correspondant.
Copiez ou notez le chemin de "Lossless.dll" à partir des fichiers du jeu.

Enfin, lançons un programme avec la génération d'images activée. J'utiliserai `vkcube` dans cet exemple :
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
Assurez-vous d'adapter les chemins. Examinons chacun d'eux :
- `LVK_INSTANCE_LAYERS` : Indiquez ici `VK_LAYER_LS_frame_generation`. Cela force toute application Vulkan à charger la couche lsfg-vk.
- `LSFG_DLL_PATH` : Ici, vous indiquez le Lossless.dll que vous avez téléchargé depuis Steam. lsfg-vk extraira et traduira les shaders à partir de ce fichier.
- `LSFG_MULTIPLIER` : Il s'agit du multiplicateur avec lequel vous devriez être familier. Indiquez `2` pour doubler le nombre d'images par seconde, etc.
- `VK_LAYER_PATH` : Si vous n'avez pas installé dans `~/.local` ou `/usr`, vous devez spécifier ici le dossier `explicit_layer.d`.

>[!WARNING]
> Contrairement à Windows, LSFG_MULTIPLIER est fortement limité ici (pour le moment !). Si votre matériel peut créer 8 images dans la swapchain, alors définir LSFG_MULTIPLIER à 4 en occupe 4, n'en laissant que 4 pour le jeu. Si le jeu en demande 5 ou plus, il plantera.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---