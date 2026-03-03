<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  一套針對 Bethesda 創作工具箱的修改、增強和逆向工程資源的集合。
</p>


# 描述
**CKPE** 是一個強大的共用原始碼平台，對 **Bethesda** 的 Creation Kit 編輯器進行了大量修正與改進，並支援如 **Skyrim Special Edition**、**Fallout 4**、**Starfield** 等遊戲的編輯器，是 [SSE CKFixes](https://github.com/Nukem9/skyrimse-test)、[SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest)、[FO4 CKFixes](https://github.com/Perchik71/Fallout4Test) 這些專案的繼任者，同時也承襲了[Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test)，這一切都由作者 **perchik71** 開始。  

[Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki) 頁面  

# 依賴
[toml11](https://github.com/ToruNiina/toml11) 由 `ToruNiina` 及其他開發者提供  
[Zydis](https://github.com/zyantific/zydis.git) 由 `zyantifi` 及其他開發者提供  
[zipper](https://github.com/kuba--/zip.git) 由 `kuba--` 提供  
[libdeflate](https://github.com/ebiggers/libdeflate.git) 由 `ebiggers` 及其他開發者提供  
[xbyak](https://github.com/herumi/xbyak.git) 由 `herumi` 及其他開發者提供    
[DirectXTex](https://github.com/microsoft/DirectXTex.git) 由 `microsoft` 提供  
[jDialogs](https://github.com/Perchik71/jDialogs.git) 由 `perchik71` 提供 *(遞迴)*

# 安裝
>[!IMPORTANT]
>常規版還是 noavx2 版本？  
>請使用 Steam 檢查您的 CPU 是否支援 avx2。開啟 Steam，在左下角將滑鼠懸停於說明選單，選擇系統資訊並搜尋 AVX2。  
>如果支援，請選擇常規版本  
>如果不支援，請選擇 noavx2 版本  
### 全新安裝
下載任一[支援的遊戲](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief)並安裝 Creation Kit。  
下載對應遊戲的 **CKPE** [最新版本](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases)。  
將所有內容解壓縮到遊戲目錄，確保 **ckpe_loader.exe** 與 **CreationKit.exe** 位於同一資料夾。
### 更新
下載對應遊戲的 **CKPE** [最新版本](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases)。  
將所有內容解壓縮到遊戲目錄，確保 **ckpe_loader.exe** 與 **CreationKit.exe** 位於同一資料夾。  
同意覆蓋所有檔案。
### 編譯
一般使用者僅需在尚未發佈的新功能時才需要使用此方式。  
於 **`Visual Studio 2022`** 或更高版本開啟專案。在 **`Release`** 模式或 **`Release-NoAVX2`** 模式下建置專案。  
然後將建置產出的檔案移至遊戲目錄，確保 **ckpe_loader.exe** 與 **CreationKit.exe** 位於同一資料夾。  
如系統提示需覆蓋舊檔案，請同意覆蓋。
### 自動化建構（Beta）
下載對應遊戲的 **CKPE** [最新提交建構](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions)。  
將所有內容解壓縮到遊戲目錄，確保 **ckpe_loader.exe** 與 **CreationKit.exe** 位於同一資料夾。  
可能出現錯誤。

# 鳴謝
[Nukem9](https://github.com/Nukem9)（感謝其實驗性功能、雜湊等，非常有用）  
[adzm](https://github.com/adzm)（我非常感謝你的貢獻，你已經[完成了](https://github.com/adzm/win32-custom-menubar-aero-theme)我一直想做的事）  
[yak3d](https://github.com/yak3d)（感謝對工作流程的貢獻和開發，以及對最新 Starfield 的支援）  
[DioKyrie-Git](https://github.com/DioKyrie-Git)（感謝設計 readme）  

# 授權
從 v0.6（commit [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)）開始，專案採用 [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html) 授權。<br />
早期版本採用 [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) 授權 <br />
版權所有 © 2023-2025 aka perchik71。保留所有權利。<br />
檔案 `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` 包含專有且未授權之檔案；`d3dcompiler\*.*` 目錄下的檔案亦同。<br />
相依性遵循各自的授權條款。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---