![Envoy 標誌](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[雲原生高效能邊緣／中間／服務代理](https://www.envoyproxy.io/)

Envoy 由 [Cloud Native Computing Foundation](https://cncf.io)（CNCF）託管。如果您的公司希望參與塑造容器封裝、動態排程及微服務導向技術的發展，歡迎考慮加入 CNCF。如需參與成員及 Envoy 角色的相關資訊，請閱讀 CNCF 的
[公告](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/)。

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## 文件

* [官方文件](https://www.envoyproxy.io/)
* [常見問題](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [範例文件](https://github.com/envoyproxy/examples/)
* [部落格](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310)：關於執行緒模型
* [部落格](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5)：關於熱重啟
* [部落格](https://medium.com/@mattklein123/envoy-stats-b65c7f363342)：關於統計架構
* [部落格](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a)：關於通用數據平面 API
* [部落格](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1)：Lyft 的 Envoy 儀表板

## 相關資源

* [data-plane-api](https://github.com/envoyproxy/data-plane-api)：v2 API 定義的獨立存儲庫。這是 [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/) 的唯讀鏡像。
* [envoy-perf](https://github.com/envoyproxy/envoy-perf)：效能測試框架。
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example)：新增過濾器並連結至主存儲庫的範例。

## 聯絡方式

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce)：低頻率郵件列表，僅發送公告。
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce)：低頻率郵件列表，僅發送安全性相關公告。
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users)：一般用戶討論。
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev)：Envoy 開發者討論（API、功能設計等）。
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers)：用於聯絡所有 Envoy 核心維護者的清單。
* [Twitter](https://twitter.com/EnvoyProxy/)：在 Twitter 上關注我們！
* [Slack](https://envoyproxy.slack.com/)：如需邀請請點選[這裡](https://communityinviter.com/apps/envoyproxy/envoy)。
  * 注意：Slack 對用戶問題的回應為盡力而為。如需「保證」回應，請依下方連結說明，發郵件至 envoy-users@。

請參閱[這則](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY)郵件主題，了解郵件列表使用方式。

## 貢獻方式

參與 Envoy 專案很有趣，即使您沒有現代 C++ 經驗，其實也沒那麼困難。開始參與：

* [貢獻指南](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [入門議題](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [使用 Docker 進行建置／測試的快速入門](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [開發者指南](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* 建議安裝 Envoy [開發支援工具鏈](https://github.com/envoyproxy/envoy/blob/main/support/README.md)，以協助自動化部分開發流程，特別是與程式碼審查相關的部分。
* 請務必讓我們知道您正在處理的議題，以避免重複工作！

## 社群會議

Envoy 團隊每月安排兩次會議，時間為週二上午 9 點（太平洋時間）。公開 Google 行事曆在[這裡](https://goo.gl/PkDijT)。只有當[會議記錄](https://goo.gl/5Cergb)中列有議程時才會舉行會議。任何社群成員都可以透過在會議記錄中新增議程來提出議題。維護者將確認議程新增項目，如無確認議程，將於預定日期前 24 小時內取消會議。

## 安全性

### 安全性稽核

已有數次第三方專注於 Envoy 安全性的合作：
* 2018 年，Cure53 進行了安全性稽核，[完整報告](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf)。
* 2021 年，Ada Logics 對我們的模糊測試基礎設施進行了稽核並提出改進建議，[完整報告](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf)。

### 回報安全漏洞

如果您發現了 Envoy 的漏洞或潛在漏洞，請透過 [envoy-security](mailto:envoy-security@googlegroups.com) 聯絡我們。我們會發送確認郵件，並在確認問題（無論成立與否）後，再發送通知郵件。

如需詳細資訊，請參閱我們完整的[安全性發行流程](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md)。

### ppc64le 建置

ppc64le 架構或使用 aws-lc 的建置不在 envoy 安全性政策涵蓋範圍內。ppc64le 架構目前僅為盡力維護，Envoy 維護者不負責其維護。

## 發佈版本

如需詳細資訊，請參閱我們的[發佈流程](https://raw.githubusercontent.com/envoyproxy/envoy/main/RELEASES.md)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---