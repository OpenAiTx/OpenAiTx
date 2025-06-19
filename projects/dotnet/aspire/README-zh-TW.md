# .NET Aspire

[![Tests](https://github.com/dotnet/aspire/actions/workflows/tests.yml/badge.svg?branch=main&event=push)](https://github.com/dotnet/aspire/actions/workflows/tests.yml)
[![Build Status](https://dev.azure.com/dnceng-public/public/_apis/build/status%2Fdotnet%2Faspire%2Fdotnet.aspire?branchName=main)](https://dev.azure.com/dnceng-public/public/_build/latest?definitionId=274&branchName=main)
[![Help Wanted](https://img.shields.io/github/issues/dotnet/aspire/help%20wanted?style=flat&color=%24EC820&label=help%20wanted)](https://github.com/dotnet/aspire/labels/help%20wanted)
[![Good First Issue](https://img.shields.io/github/issues/dotnet/aspire/good%20first%20issue?style=flat&color=%24EC820&label=good%20first%20issue)](https://github.com/dotnet/aspire/labels/good%20first%20issue)
[![Discord](https://img.shields.io/discord/732297728826277939?style=flat&logo=discord&logoColor=white&label=Join%20our%20Discord&labelColor=512bd4&color=cyan)](https://discord.com/invite/h87kDAHQgJ)

## 什麼是 .NET Aspire？

.NET Aspire 是一個具有明確設計方向、可用於雲端的技術堆疊，用於建構可觀測、可上線且分散式的應用程式。.NET Aspire 透過一組 NuGet 套件提供，這些套件處理特定的雲端原生需求。雲端原生應用程式通常由小型、互相連接的元件或微服務組成，而非單一的單體程式碼庫。雲端原生應用程式通常需要大量消耗各種服務，如資料庫、訊息傳遞與快取。

.NET Aspire 協助您：

[協調運作 (Orchestration)](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#orchestration)：.NET Aspire 提供執行及連接多專案應用程式及其相依項目的功能。

[整合 (Integrations)](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#net-aspire-integrations)：.NET Aspire 整合是針對常用服務（如 Redis 或 Postgres）提供的 NuGet 套件，具有標準化介面，確保與您的應用程式能一致且無縫地連接。

[工具 (Tooling)](https://learn.microsoft.com/dotnet/aspire/get-started/aspire-overview?#project-templates-and-tooling)：.NET Aspire 隨附適用於 Visual Studio 及 dotnet CLI 的專案範本與工具體驗，協助您建立並操作 .NET Aspire 應用程式。

如需進一步了解，請閱讀完整的[.NET Aspire 概述與文件](https://learn.microsoft.com/dotnet/aspire/)。範例可在[.NET Aspire 範例儲存庫](https://github.com/dotnet/aspire-samples)中找到。您可以在[這裡找到 eShop 範例](https://github.com/dotnet/eshop)及[Azure 版本](https://github.com/Azure-Samples/eShopOnAzure)。

## 這個儲存庫包含什麼？

.NET Aspire 應用程式主機、儀表板、服務發現基礎設施以及所有 .NET Aspire 整合套件。此外還包含專案範本。

## 使用最新每日組建

請依照[docs/using-latest-daily.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/using-latest-daily.md)的指示，開始使用最新的 .NET Aspire 每日組建。

## 我可以如何貢獻？

我們歡迎各方貢獻！世界各地許多人都曾協助讓 .NET 變得更好。

請依照[docs/contributing.md](https://raw.githubusercontent.com/dotnet/aspire/main/docs/contributing.md)中的說明，在此儲存庫進行程式碼開發。

## 回報安全性問題與漏洞

安全性問題與漏洞請私下透過電子郵件報告給 Microsoft Security Response Center (MSRC) <secure@microsoft.com>。您應該會在 24 小時內收到回覆。如未收到，請再次發送電子郵件，以確保我們收到您的原始訊息。更多資訊（包含 MSRC PGP 金鑰）請參閱 [Security TechCenter](https://www.microsoft.com/msrc/faqs-report-an-issue)。您也可以在本儲存庫的 [Security 文件](https://raw.githubusercontent.com/dotnet/aspire/main/SECURITY.md)中找到這些說明。

另請參閱有關 [Microsoft .NET Core 及 ASP.NET Core Bug Bounty Program](https://www.microsoft.com/msrc/bounty-dot-net-core) 的資訊。

### 關於 .NET Aspire 資源與用戶端整合所用容器的注意事項

.NET 團隊無法評估我們提供 API 支援的第三方容器是否適合特定客戶需求。

您應評估您選擇與 Aspire 一同組合與自動化的任何容器，以確保其符合您本人、您的雇主或政府對安全與可靠性，以及加密法規及其他適用於您使用容器的相關法規或企業標準的要求。

## .NET 基金會

.NET Aspire 是一個[.NET Foundation](https://www.dotnetfoundation.org/projects) 專案。

GitHub 上有許多與 .NET 相關的專案。

* [.NET home repo](https://github.com/Microsoft/dotnet) - 連結到來自 Microsoft 及社群的數百個 .NET 專案。
* [ASP.NET Core home](https://docs.microsoft.com/aspnet/core) - 開始學習 ASP.NET Core 的最佳起點。

本專案已採用 [Contributor Covenant](https://contributor-covenant.org) 所定義的行為準則，以明確我們社群期望的行為。詳情請參閱[.NET Foundation 行為準則](https://www.dotnetfoundation.org/code-of-conduct)。

## 授權

本儲存庫中的程式碼依 [MIT](https://raw.githubusercontent.com/dotnet/aspire/main/LICENSE.TXT) 授權條款授權。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---