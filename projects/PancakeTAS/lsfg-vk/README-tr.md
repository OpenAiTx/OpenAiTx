# lsfg-vk
Bu proje [Lossless Scaling'in Frame Generation](https://store.steampowered.com/app/993090/Lossless_Scaling/) özelliğini Linux'a getiriyor!
>[!NOTE]
> Bu bir devam eden çalışmadır. Frame generation birkaç oyunda çalışsa da, hala alınacak çok yol var. Destek için wikiyi inceleyin (wiki henüz yazılmadı)

## Derleme, Kurulum ve Çalıştırma

>[!CAUTION]
> Derleme talimatları yakın zamanda değişti. Lütfen bunları gözden geçirin.

LSFG derlemek için, sisteminizde aşağıdaki bileşenlerin yüklü olduğundan emin olun:
- Geleneksel derleme araçları (+ sed, git)
- Clang derleyicisi (bu proje GCC ile KOLAYCA derlenmez)
- Vulkan başlık dosyaları
- CMake derleme sistemi
- Meson derleme sistemi (DXVK için)
- Ninja derleme sistemi (CMake için arka uç)

lsfg-vk derlemesi oldukça basittir, çünkü her şey CMake'e düzgün bir şekilde entegre edilmiştir:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
Bu, lsfg-vk'yı ~/.local/lib ve ~/.local/share/vulkan konumuna kuracaktır.

Sonraki adımda, Lossless Scaling'i Steam'den indirmeniz gerekecek. `legacy_2.13` dalına geçin veya ilgili depoyu indirin.
Oyun dosyalarından "Lossless.dll" yolunu kopyalayın veya bir yere not edin.

Son olarak, frame generation etkin şekilde bir program başlatalım. Bu örnek için `vkcube` kullanacağım:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
Yolları kendinize göre ayarladığınızdan emin olun. Her birine bakalım:
- `LVK_INSTANCE_LAYERS`: Burada `VK_LAYER_LS_frame_generation` belirtin. Bu, herhangi bir Vulkan uygulamasının lsfg-vk katmanını yüklemesini zorlar.
- `LSFG_DLL_PATH`: Burada Steam'den indirdiğiniz Lossless.dll dosyasını belirtirsiniz. lsfg-vk shader'ları buradan çıkarıp çevirir.
- `LSFG_MULTIPLIER`: Aşina olduğunuz çarpandır. Örneğin, kare hızını iki katına çıkarmak için `2` belirtin.
- `VK_LAYER_PATH`: Eğer `~/.local` veya `/usr`'a kurmadıysanız, burada `explicit_layer.d` klasörünü belirtmelisiniz.

>[!WARNING]
> Windows'tan farklı olarak, burada LSFG_MULTIPLIER ciddi şekilde sınırlıdır (şu anda!). Eğer donanımınız 8 swapchain görüntüsü oluşturabiliyorsa, LSFG_MULTIPLIER'ı 4 olarak ayarlamak bunların 4'ünü kullanır, oyuna sadece 4 kalır. Oyun 5 veya daha fazlasını isterse, çökecektir.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---