# lsfg-vk
這個專案將 [Lossless Scaling 的畫面生成技術](https://store.steampowered.com/app/993090/Lossless_Scaling/) 帶到了 Linux！
>[!NOTE]
> 此專案仍在開發中。雖然畫面生成已在部分遊戲中運作，但仍有許多工作尚未完成。請參閱 wiki 以獲得支援（wiki 尚未撰寫）

## 建置、安裝與執行

>[!CAUTION]
> 建置說明最近有變更。請重新閱讀說明內容。

為了編譯 LSFG，請確保你的系統已安裝下列元件：
- 傳統的建置工具（及 sed、git）
- Clang 編譯器（本專案不易用 GCC 編譯）
- Vulkan 標頭檔
- CMake 建置系統
- Meson 建置系統（用於 DXVK）
- Ninja 建置系統（CMake 的後端）

編譯 lsfg-vk 相當直接，因為所有東西都整合在 CMake 中：
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
這會將 lsfg-vk 安裝到 ~/.local/lib 和 ~/.local/share/vulkan。

接下來，你需要從 Steam 下載 Lossless Scaling。切換到 `legacy_2.13` 分支或下載對應的 depot。
複製或記下遊戲檔案中的 "Lossless.dll" 路徑。

最後，讓我們實際啟動一個啟用畫面生成的程式。這裡以 `vkcube` 為例：
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
請務必調整路徑。讓我們檢視每個環境變數：
- `LVK_INSTANCE_LAYERS`：此處指定 `VK_LAYER_LS_frame_generation`。這會強制任何 Vulkan 應用程式載入 lsfg-vk layer。
- `LSFG_DLL_PATH`：在此處指定你從 Steam 下載的 Lossless.dll。lsfg-vk 會從這裡提取並轉換著色器。
- `LSFG_MULTIPLIER`：這就是你熟悉的倍數。指定 `2` 可將幀率加倍，等等。
- `VK_LAYER_PATH`：如果你沒有安裝到 `~/.local` 或 `/usr`，則必須在這裡指定 `explicit_layer.d` 資料夾。

>[!WARNING]
> 與 Windows 不同，LSFG_MULTIPLIER 在這裡（目前）受到很大限制。如果你的硬體能建立 8 個 swapchain 影像，設定 LSFG_MULTIPLIER 為 4 就會佔用其中 4 個，只剩 4 個給遊戲。如果遊戲請求 5 個或更多，將會當機。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---