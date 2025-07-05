# lsfg-vk
Este projeto traz a [Geração de Quadros do Lossless Scaling](https://store.steampowered.com/app/993090/Lossless_Scaling/) para Linux!
>[!NOTE]
> Este é um trabalho em andamento. Embora a geração de quadros tenha funcionado em alguns jogos, ainda há um longo caminho a percorrer. Por favor, consulte o wiki para suporte (o wiki ainda não foi escrito)

## Compilando, Instalando e Executando

>[!CAUTION]
> As instruções de compilação foram alteradas recentemente. Por favor, revise-as.

Para compilar o LSFG, certifique-se de ter os seguintes componentes instalados no seu sistema:
- Ferramentas de compilação tradicionais (+ sed, git)
- Compilador Clang (este projeto NÃO compila facilmente com GCC)
- Arquivos de cabeçalho do Vulkan
- Sistema de build CMake
- Sistema de build Meson (para DXVK)
- Sistema de build Ninja (backend para o CMake)

Compilar o lsfg-vk é relativamente simples, pois tudo está bem integrado ao CMake:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
Isso instalará o lsfg-vk em ~/.local/lib e ~/.local/share/vulkan.

Em seguida, você precisará baixar o Lossless Scaling da Steam. Troque para o branch `legacy_2.13` ou baixe o depot correspondente.
Copie ou anote o caminho do arquivo "Lossless.dll" dos arquivos do jogo.

Por fim, vamos realmente iniciar um programa com a geração de quadros ativada. Vou usar o `vkcube` neste exemplo:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
Certifique-se de ajustar os caminhos. Vamos analisar cada um:
- `LVK_INSTANCE_LAYERS`: Especifique `VK_LAYER_LS_frame_generation` aqui. Isso força qualquer aplicativo Vulkan a carregar a camada lsfg-vk.
- `LSFG_DLL_PATH`: Aqui você especifica o Lossless.dll que baixou da Steam. O lsfg-vk irá extrair e traduzir os shaders daqui.
- `LSFG_MULTIPLIER`: Este é o multiplicador com o qual você já deve estar familiarizado. Especifique `2` para dobrar a taxa de quadros, etc.
- `VK_LAYER_PATH`: Se você não instalou em `~/.local` ou `/usr`, será necessário especificar a pasta `explicit_layer.d` aqui.

>[!WARNING]
> Diferente do Windows, o LSFG_MULTIPLIER é fortemente limitado aqui (no momento!). Se seu hardware pode criar 8 imagens de swapchain, então definir o LSFG_MULTIPLIER para 4 ocupa 4 dessas, sobrando apenas 4 para o jogo. Se o jogo solicitar 5 ou mais, ele irá travar.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---