
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">印地語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">阿薩姆語</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Chocolatey 套件管理員自動安裝程式於 wine 中，方便快速在 wine 安裝程式（並隨後在 wine 中發現錯誤 ;) ）  
針對部分錯誤已添加解決方法，如 Visual Studio Community 2022 和 nodejs，詳見後文。  

在封鎖期間感到無聊時，我寫了一個自訂的 winetricks(.ps1)，包含我覺得方便的動詞。只需執行 'winetricks' 即可查看這些動詞。  
某些動詞需要 wine 完全重新啟動（因近期 wine 變更）。你會看到訊息框，並且會結束目前的 session。只要再次啟動 powershell 並重試該動詞。此操作僅需執行一次，之後任何動詞都不需再進行此操作。  

範例：

「winetricks vs22_interactiveinstaller」（ --> 會結束當前會話）

執行「wine powershell」

執行「winetricks vs22_interactiveinstaller」

（順帶一提，透過「winetricks vs22_interactive_installer」可以使用 Visual Studio 2022 安裝程式選擇要安裝的項目；「winetricks vs22_interactive_installer」讓我在十分鐘內進入主程式（選擇了 C++ 桌面開發）。）

安裝：
- 下載並解壓縮發行版 zip 檔，然後執行「wine ChoCinstaller_0.5c.751.exe」（大約一分鐘完成）

選擇性操作：
- 像這樣執行安裝程式「wine ChoCinstaller_0.5a.751.exe /s」，安裝檔案（如 Powershell*.msi 和 dotnet48）會儲存在
  我的文件夾中，如果創建新前綴則無需重新下載）
選擇性操作：
- 像這樣執行安裝程式「wine ChoCinstaller_0.5a.751.exe /q」以防止自動開啟 powershell 視窗（僅安裝）。

選擇性操作：
- 檢查是否安裝成功：「choco install chromium」和「start chrome.exe（wine-8.4 起不再需要 --no-sandbox）」。

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
關於 PowerShell：

提示：Chocolatey 通常安裝程式的最新版，這可能會發現新的 wine 錯誤。您可能在安裝舊版軟體時會比較順利。
範例：

choco search --exact microsoft-edge --all（--> 列出所有版本）

choco install microsoft-edge --version --version='135.0.3179.98'

一般資訊：

- 「wine powershell.exe」可啟動 PowerShell-Core 控制台。

 
關於 ConEmu：


ConEmu 主控台在 wine 下存在一些問題：
  - 使用 Ctrl^C 終止無法返回主控台的程式不起作用。請改用 Shift^Ctrl^C。
  - 在 ConEmu 視窗中選取文字（用於複製/貼上）時不會高亮顯示選擇範圍。已針對近期 wine 版本加入一個非常悲傷的 hack 作為變通，所以現在高亮應該可以正常顯示。
   
關於 winetricks(.ps1)：

- 如果你沒有執行它（在 powershell 主控台輸入 'winetricks'），則不會下載任何檔案，因此不會產生額外負擔。
- 很多動作（如 powershell 5.1）需要一些基本檔案來從 msu 套件中解壓內容。安裝這些基本檔案需要先下載大量檔案，第一次使用時會花很多時間。但檔案緩存之後就會很快。例如你可能想先嘗試 'winetricks ps51'，這大約需要 15 分鐘。其他動作第一次使用可能需要 5 分鐘。但一旦執行過一次，這個麻煩就消失了。
- 檔案會快取在 MyDocuments 目錄。如果執行所有動作，約需 800 MB 空間。
- 希望能有更好的 64 位元動作支援。
- 可以從 msu 檔案中抽取檔案並（嘗試）安裝。執行 'winetricks install_dll_from_msu' 來查看方法。
- 基本 Powershell 5.1。
- 實驗性 dotnet481 安裝，以及 dotnet35（某些應用程式不滿足現有 dotnet48 安裝時可能需要）。
- 自動補全功能。注意：從命令列同時使用多個動作時，現在要用逗號分隔
  （這是 powershell 處理多個參數的方式）
  所以 'winetricks riched20 gdiplus' 不再可行，請改用 'winetricks riched20,gdiplus'
- 某些程式在使用 Chocolatey 時因 wine-bugs 而無法安裝/執行。我已在 winetricks 中為這些情況加入一些變通，如下所示。
- 特殊動作（winetricks vs19、vs22 和 vs22_interactive_installer）用於安裝可用的 Visual Studio Community 2019 及 2022（見截圖，安裝需 >10 分鐘且約需 10GB！安裝後請從 c:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/ 啟動 devenv.exe）
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- 特殊動作可取得多種 unix 指令如 grep、sed、file、less、curl 等等（winetricks git.portable，免責聲明：部分指令因 wine 問題尚未可用）
- 還包含數個來自網路程式碼片段改編的 powershell 腳本：
    - 如何透過 Invoke-ReflectivePEInjection 在 powershell 腳本內嵌 exe（這個 exe 不會出現在工作清單）。
    - 如何製作炫麗的訊息框
    - 將 powershell 腳本（ps1）轉換成 exe。
    - 以及其他一些
 
     
關於系統程式：

新增功能可用於替換簡單的系統程式，例如以
c:\\Program Files\Powershell\7\profile.ps1 中的函式替代 setx.exe。或新增缺少的系統程式如 getmac.exe。
如果程式因系統程式不成熟或缺失而無法執行，可以撰寫函式回傳程式預期的內容。
例如在 profile.ps1 中我加入了（除其他功能外）支援較多選項的 wmic.exe，
以及基本的 setx.exe。
你也可以操作傳給系統程式的參數。請參考 profile.ps1 和 choc_install.ps1。
無法保證此方法對複雜程式也適用…… 
 
備註：


  - 請勿在現有的 wineprefix 上使用，只能在全新建立的 prefix 上使用！此安裝程式僅僅是愚蠢地安裝 dotnet48 並修改註冊表鍵值。
    如果你已經用常規的 winetricks.sh 安裝過任何 dotnet 版本，這很可能會失敗，即使成功，你也可能得到一個損壞的 prefix。
    如果你需要用常規的 winetricks.sh 為程式安裝其他東西，請勿使用任何 dotnet* 相關指令。
    順帶一提，「Arial」和「d3dcompiler_47」指令預設已經安裝。
  - 不支援 WINEARCH=win32！
  - 目前尚不支援從舊版本升級，也許未來會支援

編譯：
  - 如果你想自行編譯而非下載二進位檔：請參閱 mainv1.c 和 installer.c 裡的編譯說明
  - 然後將 choc_install.ps1 複製到同一目錄下
  - 然後執行 'wine ChoCinstaller_0.5a.735.exe'
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---