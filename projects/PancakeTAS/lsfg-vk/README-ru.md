# lsfg-vk
Этот проект переносит [Генерацию кадров Lossless Scaling](https://store.steampowered.com/app/993090/Lossless_Scaling/) на Linux!
>[!NOTE]
> Это проект в разработке. Хотя генерация кадров уже работает в некоторых играх, впереди ещё много работы. Пожалуйста, ознакомьтесь с вики для поддержки (вики ещё не написана)

## Сборка, установка и запуск

>[!CAUTION]
> Инструкции по сборке недавно изменились. Пожалуйста, ознакомьтесь с ними.

Для компиляции LSFG убедитесь, что у вас установлены следующие компоненты:
- Традиционные инструменты сборки (+ sed, git)
- Компилятор Clang (этот проект НЕ компилируется легко с GCC)
- Заголовочные файлы Vulkan
- Система сборки CMake
- Система сборки Meson (для DXVK)
- Система сборки Ninja (бэкенд для CMake)

Сборка lsfg-vk довольно проста, так как всё аккуратно интегрировано в CMake:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
Это установит lsfg-vk в ~/.local/lib и ~/.local/share/vulkan.

Далее вам нужно скачать Lossless Scaling из Steam. Переключитесь на ветку `legacy_2.13` или скачайте соответствующий депо.
Скопируйте или запомните путь к "Lossless.dll" из файлов игры.

Наконец, давайте запустим программу с включённой генерацией кадров. В этом примере я буду использовать `vkcube`:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
Убедитесь, что вы скорректировали пути. Давайте рассмотрим каждый из них:
- `LVK_INSTANCE_LAYERS`: Здесь укажите `VK_LAYER_LS_frame_generation`. Это заставляет любое Vulkan-приложение загружать слой lsfg-vk.
- `LSFG_DLL_PATH`: Здесь вы указываете Lossless.dll, который скачали из Steam. lsfg-vk извлечёт и преобразует шейдеры отсюда.
- `LSFG_MULTIPLIER`: Это множитель, с которым вы уже знакомы. Укажите `2` для удвоения частоты кадров и т.д.
- `VK_LAYER_PATH`: Если вы не устанавливали в `~/.local` или `/usr`, здесь нужно указать папку `explicit_layer.d`.

>[!WARNING]
> В отличие от Windows, здесь LSFG_MULTIPLIER сильно ограничен (на данный момент!). Если ваше железо может создать 8 swapchain-изображений, установка LSFG_MULTIPLIER в 4 займёт 4 из них, оставив игре только 4. Если игра запросит 5 или больше, она вылетит.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---