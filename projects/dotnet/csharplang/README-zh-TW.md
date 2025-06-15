# C# 語言設計

[![加入 https://gitter.im/dotnet/csharplang 聊天](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![在 Discord 上聊天](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

歡迎來到 C# 語言設計的官方儲存庫。這裡是新 C# 語言功能的開發、採納與規範的地方。

C# 由 C# 語言設計團隊（LDT）設計，並與 [Roslyn](https://github.com/dotnet/roslyn) 項目緊密協作進行實作。

你可以在這裡找到：

- [proposals 資料夾](proposals) 中的現行 C# 語言功能提案
- [meetings 資料夾](meetings) 中的 C# 語言設計會議紀錄
- [語言版本歷史摘要](Language-Version-History.md)

如果你發現上述內容有錯誤或不足，請提出 issue 反映，或更好的是：提交 pull request 來修正。

但對於*新功能提案*，請先在 [討論區](https://github.com/dotnet/csharplang/labels/Discussion) 提出討論，僅當語言設計團隊成員（即「champion」）邀請時，才以 issue 或 pull request 的形式正式提交提案。

完整的設計流程描述於[此處](Design-Process.md)。簡要摘要如下。

## 討論

與語言功能有關的爭論在本儲存庫的 [Discussions](https://github.com/dotnet/csharplang/discussions) 進行。

如果你想建議一項功能、討論目前的設計筆記或提案等，請[開啟新的討論主題](https://github.com/dotnet/csharplang/discussions/new)。

討論主題若簡短且聚焦，會更容易被閱讀。如果你留下第 50 則評論，可能只有少數人會閱讀。為了讓討論更容易瀏覽並受益，請遵循以下幾個原則：

- 討論應與 C# 語言設計相關。若無關，將會被直接關閉。
- 請選擇能清楚傳達討論範圍的描述性主題。
- 請堅持討論主題。如評論偏離主題或深入子議題，請開新討論並回鏈。
- 你的評論是否對他人有幫助？還是可用對現有評論加表情回應即可？

若要防止特定語法發生，可透過 [Roslyn 分析器](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers) 實現。僅讓現有語法成為選擇性非法的提案，將會被語言設計委員會拒絕，以避免語言複雜度增加。

## 提案

當 C# LDM 成員認為某項提案值得更廣泛團隊考慮時，他們可[擔任 Champion](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22)，即他們會將其帶到 C# 語言設計會議。提案總是在關聯討論中討論，而不是在 champion issue 中。我們過去並未嚴格遵守這項政策，所以許多 champion issue 仍有討論；現在我們會鎖定 issue，防止新討論發生。每個 champion issue 都會有對應的討論連結。

## 設計流程

[proposals](proposals) 會隨著 [Language Design Meetings](meetings) 的決策演進，這些決策來自 [discussions](https://github.com/dotnet/csharplang/discussions)、實驗及線下設計工作。

在許多情況下，需要實作並分享功能原型，以便確定正確的設計，最終決定是否採納該功能。原型有助於發現功能的實作與易用性問題。原型應於 [Roslyn 儲存庫](https://github.com/dotnet/roslyn) 的分支中實作，並達到以下標準：

- 解析（如適用）應能承受實驗：輸入不應導致崩潰。
- 包含最基本的端到端功能示範測試。
- 包含最基本的 IDE 支援（關鍵字著色、格式化、自動完成）。

一旦通過審核，功能應在 [Roslyn](https://github.com/dotnet/roslyn) 完整實作，並完整規範於 [language specification](spec) 中，然後將提案移至已完成功能的適當資料夾，例如 [C# 7.1 proposals](proposals/csharp-7.1)。

**免責聲明**：一項現行提案代表該功能正在被積極考慮納入 C# 未來版本，但不保證最終會被納入下一個或任何語言版本。根據設計團隊、社群、程式碼審查者或測試的回饋，提案可於上述任何階段被延後或拒絕。

### 里程碑

我們對儲存庫中的 issue 設有幾個不同的里程碑：
* [Working Set](https://github.com/dotnet/csharplang/milestone/19) 是目前正積極進行中的已被 champion 的提案集合。並非所有內容都會進入下一版 C#，但將在即將發行的版本獲得設計時間。
* [Backlog](https://github.com/dotnet/csharplang/milestone/10) 是已經過三方篩選但未被積極進行的已被 champion 的提案集合。對這些提案社群的討論與想法仍然歡迎，但由於設計與實作審查成本過高，暫不考慮社群自行實作，直到我們準備就緒。
* [Any Time](https://github.com/dotnet/csharplang/milestone/14) 是已經過三方篩選但未被積極進行，並開放社群實作的已被 champion 的提案集合。此類 issue 可處於兩種狀態：需要規範審核，或需要實作。需審核規範者仍需在 LDM 提報以取得規範審核通過，但我們會在方便時盡速處理。
* [Likely Never](https://github.com/dotnet/csharplang/milestone/13) 是 LDM 已從語言中拒絕的提案集合。除非有強烈需求或社群回饋，否則這些提案未來不會再考慮。
* 編號里程碑為已針對特定語言版本實作的功能集合。對於已結束的里程碑，這些功能已隨發行版本一同出貨。對於未結束的里程碑，若在接近發行時發現相容性或其他問題，功能仍可能被移除。

## 語言設計會議

語言設計會議（LDMs）由 LDT 及偶爾邀請的來賓舉行，並以設計會議紀錄的形式，記錄於 [meetings](meetings) 資料夾，並依年度分類。設計會議紀錄的生命週期描述於 [meetings/README.md](meetings/README.md)。LDM 是決定 C# 未來版本的地方，包括決定要著手哪些提案、如何發展提案，以及是否與何時採納它們。

## 語言規範

目前的 ECMA-334 規範可於 [C# 語言標準](https://github.com/dotnet/csharpstandard/) 儲存庫中以 markdown 形式取得。

## 實作

C# 語言的參考實作可於 [Roslyn 儲存庫](https://github.com/dotnet/roslyn) 找到。此儲存庫也追蹤[語言功能的實作狀態](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md)。直到最近，這也是語言設計產出物的追蹤地點。請容許我們在將現行提案移動過程中花費一些時間。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---