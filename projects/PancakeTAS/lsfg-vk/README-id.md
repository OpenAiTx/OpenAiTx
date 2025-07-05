# lsfg-vk
Proyek ini membawa [Lossless Scaling's Frame Generation](https://store.steampowered.com/app/993090/Lossless_Scaling/) ke Linux!
>[!NOTE]
> Ini adalah proyek yang masih dalam pengembangan. Meskipun frame generation telah bekerja di beberapa game, masih ada jalan panjang yang harus ditempuh. Silakan tinjau wiki untuk dukungan (wiki belum ditulis)

## Membangun, Menginstal, dan Menjalankan

>[!CAUTION]
> Instruksi build baru-baru ini berubah. Silakan tinjau kembali.

Untuk mengkompilasi LSFG, pastikan Anda telah menginstal komponen berikut di sistem Anda:
- Alat build tradisional (+ sed, git)
- Kompiler Clang (proyek ini TIDAK mudah dikompilasi dengan GCC)
- File header Vulkan
- Sistem build CMake
- Sistem build Meson (untuk DXVK)
- Sistem build Ninja (backend untuk CMake)

Kompilasi lsfg-vk cukup mudah, karena semuanya telah terintegrasi rapi ke dalam CMake:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
Ini akan menginstal lsfg-vk ke ~/.local/lib dan ~/.local/share/vulkan.

Selanjutnya, Anda perlu mengunduh Lossless Scaling dari Steam. Beralihlah ke branch `legacy_2.13` atau unduh depot yang sesuai.
Salin atau catat path dari "Lossless.dll" dari file game.

Terakhir, mari kita mulai sebuah program dengan frame generation diaktifkan. Saya akan menggunakan `vkcube` untuk contoh ini:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
Pastikan Anda menyesuaikan path-nya. Mari kita periksa satu per satu:
- `LVK_INSTANCE_LAYERS`: Tentukan `VK_LAYER_LS_frame_generation` di sini. Ini memaksa aplikasi Vulkan apa pun untuk memuat layer lsfg-vk.
- `LSFG_DLL_PATH`: Di sini Anda menentukan Lossless.dll yang Anda unduh dari Steam. lsfg-vk akan mengekstrak dan menerjemahkan shader dari sini.
- `LSFG_MULTIPLIER`: Ini adalah multiplier yang sudah Anda kenal. Tentukan `2` untuk menggandakan framerate, dll.
- `VK_LAYER_PATH`: Jika Anda tidak menginstal ke `~/.local` atau `/usr`, Anda harus menentukan folder `explicit_layer.d` di sini.

>[!WARNING]
> Berbeda dengan di Windows, LSFG_MULTIPLIER sangat terbatas di sini (untuk saat ini!). Jika perangkat keras Anda dapat membuat 8 swapchain images, maka mengatur LSFG_MULTIPLIER ke 4 akan menggunakan 4 dari itu, menyisakan hanya 4 untuk game. Jika game meminta 5 atau lebih, maka akan crash.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---