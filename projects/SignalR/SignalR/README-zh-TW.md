# ASP.NET SignalR 

**重要**：本產品不會再新增新功能。我們目前處於維護模式，只修復關鍵性問題。詳情請參閱[我們的部落格文章](https://devblogs.microsoft.com/aspnet/the-future-of-asp-net-signalr/)。
本儲存庫主機承載 ASP.NET SignalR 的程式碼與專案管理，適用於使用 System.Web 或 Katana 的 .NET Framework 應用程式。如果您正在尋找 ASP.NET Core SignalR 的相關資訊，請參閱 https://github.com/aspnet/AspNetCore/tree/main/src/SignalR 儲存庫。

ASP.NET SignalR 是一個為 ASP.NET 開發人員設計的函式庫，可讓您非常輕鬆地將即時網頁功能加入您的應用程式。什麼是「即時網頁」功能？這是指您的伺服器端程式碼能夠在事件發生時，立即將內容推送到已連線的用戶端。

## 可以用來做什麼？
從伺服器推送資料到用戶端（不僅僅是瀏覽器用戶端）一直是一個困難的問題。SignalR 讓這一切變得非常簡單，並且幫您處理所有繁瑣的細節。

## 文件
請參閱[文件](https://docs.microsoft.com/aspnet/signalr/overview/getting-started/introduction-to-signalr)

## 從 NuGet 取得！

    Install-Package Microsoft.AspNet.SignalR

## 直接從 NuGet 取得範例，安裝到您的應用程式！

    Install-Package Microsoft.AspNet.SignalR.Sample
	
## 授權
[Apache 2.0 授權](https://raw.githubusercontent.com/SignalR/SignalR/main/LICENSE.txt)

## 貢獻

請參閱[貢獻指南](https://raw.githubusercontent.com/SignalR/SignalR/main/CONTRIBUTING.md)

## 建置原始碼

```
git clone git@github.com:SignalR/SignalR.git（如果您使用 https，請改用 https）
```

### Windows
複製儲存庫後，執行 `build.cmd`。

**注意：** 開啟此方案需使用 VS 2017。

## 有問題嗎？
* 在 StackOverflow 上使用 [signalr](https://stackoverflow.com/questions/tagged/signalr) 標籤發問
* 在[問題追蹤器](https://github.com/SignalR/SignalR/issues)中提出 Issue

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---