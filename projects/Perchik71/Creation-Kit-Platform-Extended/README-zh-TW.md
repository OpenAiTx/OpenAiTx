
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=hi">印地語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=Perchik71&project=Creation-Kit-Platform-Extended&lang=as">阿薩姆語</
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://github.com/Perchik71/Creation-Kit-Platform-Extended/blob/master/Resources/logo.png" alt="Creation Kit Platform Extended" border="0" width="400px">
</p>
<p align="center">
  一個由 Bethesda 創建的 Creation Kit 的修改、增強及逆向工程資源集合。
</p>

# 描述
**CKPE** 是一個共享原始碼的強大平台，對 **Bethesda** 的 Creation Kit 編輯器進行了大量修正與改進，支援如 **Skyrim Special Edition**、**Fallout 4**、**Starfield** 等遊戲的編輯器，是 [SSE CKFixes](https://github.com/Nukem9/skyrimse-test)、[SSE CKFixes Update](https://github.com/Perchik71/SkyrimSETest)、[FO4 CKFixes](https://github.com/Perchik71/Fallout4Test) 這些專案的後繼者，還有 [Unicode patch for SSE CK 1.5.73](https://github.com/Perchik71/usse_test)，這一切都由 **perchik71** 作者開始。  

[Wiki](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki) 頁面  

# 依賴項
[toml11](https://github.com/ToruNiina/toml11) 由 `ToruNiina` 及其他人  
[Zydis](https://github.com/zyantific/zydis.git) 由 `zyantifi` 及其他人  
[zipper](https://github.com/kuba--/zip.git) 由 `kuba--`  
[libdeflate](https://github.com/ebiggers/libdeflate.git) 由 `ebiggers` 及其他人  
[xbyak](https://github.com/herumi/xbyak.git) 由 `herumi` 及其他人  
[DirectXTex](https://github.com/microsoft/DirectXTex.git) 由 `microsoft`  
[jDialogs](https://github.com/Perchik71/jDialogs.git) 由 `perchik71` *(遞迴)*

# 安裝
### 全新安裝
下載任一 [支援的遊戲](https://github.com/Perchik71/Creation-Kit-Platform-Extended/wiki#brief) 並安裝 Creation Kit。  
下載你的遊戲 [最新版本](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) 的 **CKPE**。  
將所有內容解壓縮至遊戲目錄，確保 **ckpe_loader.exe** 與 **CreationKit.exe** 位於同一資料夾。
### 更新
下載你的遊戲 [最新版本](https://github.com/Perchik71/Creation-Kit-Platform-Extended/releases) 的 **CKPE**。  
將所有內容解壓縮至遊戲目錄，確保 **ckpe_loader.exe** 與 **CreationKit.exe** 位於同一資料夾。  
同意覆蓋所有檔案。
### 編譯
一般使用者僅需此方法來獲取尚未發布的最新功能。  
用 **`Visual Studio 2022`** 或更新版本開啟專案。在 **`Release`** 或 **`Release-NoAVX2`** 模式下編譯專案。  
然後將編譯輸出移至遊戲目錄，確保 **ckpe_loader.exe** 與 **CreationKit.exe** 位於同一資料夾。  
若系統要求覆蓋舊檔案，請同意全部替換。
### 自動化建置（Beta）
下載你的遊戲 [最新提交版本](https://github.com/Perchik71/Creation-Kit-Platform-Extended/actions) 的 **CKPE**。  
將所有內容解壓縮至遊戲目錄，確保 **ckpe_loader.exe** 與 **CreationKit.exe** 位於同一資料夾。  
可能會有錯誤。

# 致謝
[Nukem9](https://github.com/Nukem9)（實驗性功能、雜湊等，非常有用）  
[adzm](https://github.com/adzm)（非常感謝你的工作，你已經[完成](https://github.com/adzm/win32-custom-menubar-aero-theme)了我長期想要自己做的事）  
[yak3d](https://github.com/yak3d)（對工作流程的貢獻與開發，並支援最新 Starfield）  
[Dio-Kyrie](https://github.com/Dio-Kyrie)（Readme 的設計）  

# 授權
自 v0.6（提交 [9d93970](https://github.com/Perchik71/Creation-Kit-Platform-Extended/commit/9d93970cc3918099c895872d46a24aa29a34db11)）起，本專案採用 [LGPLv3](https://www.gnu.org/licenses/lgpl-3.0.html) 授權。 <br />
早期版本依據 [GPLv3](https://www.gnu.org/licenses/gpl-3.0.html) 授權 <br />
版權所有 © 2023-2025 aka perchik71。保留所有權利。<br />
檔案 `Stuffs\FO4\CreationKitPlatformExtended_FO4_Resources.pak` 包含專有且未授權的檔案；`d3dcompiler\*.*` 目錄下的檔案亦同。<br />
相依套件依其各自授權條款提供。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-09

---