# `.gitignore` 範本集錦

這是 GitHub 的 [`.gitignore`][man] 檔案範本集錦。
我們使用這個清單來填充 GitHub.com 介面在建立新儲存庫和檔案時可選擇的 `.gitignore` 範本。

若要了解 `.gitignore` 檔案的運作方式及其使用方法，下列資源是很好的起點：

- [Pro Git][progit] 書中的 [忽略檔案章節][chapter]。
- GitHub 說明網站上的 [忽略檔案文章][help]。
- [gitignore(5)][man] 手冊頁面。

[man]: https://git-scm.com/docs/gitignore
[help]: https://help.github.com/articles/ignoring-files
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring
[progit]: https://git-scm.com/book

## 資料夾結構

我們支援一系列的範本，組織方式如下：

- 根目錄包含常用的範本，協助大家快速開始使用熱門的程式語言與技術。這些範本定義了一套有意義的規則，幫助你起步，並確保你不會將不重要的檔案提交到你的儲存庫中。
- [`Global`](./Global) 目錄包含各種編輯器、工具與作業系統的範本，可用於不同情境。建議你[將這些範本加到全域範本](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer)中，或如需長期使用，將這些規則合併到專案專屬範本裡。
- [`community`](./community) 目錄包含其他熱門語言、工具及專案的專用範本，目前尚未納入主流範本。當你決定採用這些框架或工具時，應將這些範本加到你的專案專屬範本中。

## 什麼是好的範本？

範本應包含一組規則，協助 Git 儲存庫與特定的程式語言、框架、工具或環境協同運作。

如果無法為此情境策劃出一組精簡且有用的規則，則該範本不適合納入本集錦。

如果某個範本大多只是一份由某特定軟體版本（例如 PHP 框架）安裝的檔案清單，則可放在 `community` 目錄下。詳見[版本化範本](#versioned-templates)章節。

如果你有一小組規則，或想支援尚未廣泛使用的技術，且相信這對他人有幫助，請參閱[專用範本](#specialized-templates)章節。

如該範本很重要且顯著，請在發送 pull request 時詳加說明。我們未必會立即接受，但日後可根據需求將其提升至根目錄。

請理解，我們無法列出所有曾經存在的工具。
我們的目標是策劃一套「最常見且有幫助」的範本，
而非涵蓋所有可能的專案。如果我們未納入你的語言、工具或專案，並非因為它不夠優秀。

## 貢獻指引

我們歡迎你協助改善此專案。為維持本集錦的高品質，請遵循下列貢獻指引：

- **提供應用程式或專案首頁的連結**。除非非常熱門，否則維護者可能不瞭解或未曾使用你所修改適用的語言、框架、編輯器、應用或專案。

- **提供支援你修改內容的相關文件連結**。
  以目前且具權威性的官方文件，提及被忽略的檔案為佳。
  若無法取得相關文件，請盡力解釋被忽略檔案的用途。

- **說明你修改的原因**。即使看似不言自明，也請簡述一兩句說明為何需要進行此修改或新增。
  特別要說明為何該變更適用於所有使用該技術的人，而不僅是你或你的團隊。

- **考量修改範圍**。若你的變更僅針對某特定語言或框架，請務必只修改該語言或框架的範本，而非編輯器、工具或作業系統的範本。

- **請每次 pull request 僅修改「一個範本」**。
  這有助於讓 pull request 和回饋聚焦於特定專案或技術。

總之，你越能協助我們理解你的修改內容，我們就越有可能快速接受你的貢獻。

## 版本化範本

有些範本在不同版本間差異很大，若你希望貢獻此類範本，需遵循以下流程：

- 根目錄的範本應為目前支援的版本
- 根目錄的範本檔名不應包含版本號（即「常青」版本）
- 舊版本範本應存放於 `community/` 目錄下
- 舊版本範本的檔名中應嵌入版本號，以便閱讀

這有助於確保使用者取得最新版本（因為會直接使用根目錄中的範本），同時協助維護者支援仍在使用的舊版本。

## 專用範本

如果你有想貢獻但尚未成為主流的範本，請考慮將其加入 `community` 目錄下最適合的子資料夾。

你的專用範本中的規則應專屬於該框架或工具，若有其他相關範本，請於範本標頭註解中說明。

例如，這個範本可以放在 `community/DotNet/InforCRM.gitignore`：

```
# InforCRM（原 SalesLogix）gitignore 範本
# 網站：https://www.infor.com/product-summary/cx/infor-crm/
#
# 建議搭配：VisualStudio.gitignore

# 忽略自動產生的模型檔案
ModelIndex.xml
ExportedFiles.xml

# 忽略部署檔案
[Mm]odel/[Dd]eployment

# 強制納入 portal SupportFiles
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## 貢獻流程

建議你依照以下方式對本專案提出修改建議：

1. [Fork 本專案][fork]至你的帳號。
2. 為你欲修改的內容[建立分支][branch]。
3. 在你的 fork 上進行修改。
4. 從 fork 的分支[發送 pull request][pr]到我們的 `main` 分支。

也可以直接用網頁介面進行修改，這會自動 fork 專案並提示你發送 pull request。

[fork]: https://help.github.com/articles/fork-a-repo/
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository
[pr]: https://help.github.com/articles/using-pull-requests/

## 授權

[CC0-1.0](./LICENSE)。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---