# Kubernetes (K8s)

[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![Go Report Card](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![GitHub release (latest SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

Kubernetes，也稱為 K8s，是一個開源系統，用於在多個主機上管理[容器化應用程式]。它提供了應用程式的部署、維護和擴展的基本機制。

Kubernetes 構建於 Google 十五年來在大規模生產環境運行負載的經驗之上（該系統名為 [Borg]），並結合了社群中最優秀的理念和實踐。

Kubernetes 由雲原生運算基金會 ([CNCF]) 主持。如果您的公司希望參與推動容器打包、動態調度和微服務導向等技術的發展，歡迎加入 CNCF。關於參與者及 Kubernetes 的角色，請閱讀 CNCF 的[公告]。

----

## 開始使用 K8s

請參閱我們在 [kubernetes.io] 上的文件。

參加免費課程 [使用 Kubernetes 擴展微服務]。

若要在其他應用程式中作為函式庫使用 Kubernetes 程式碼，請參閱[已發佈元件列表](https://git.k8s.io/kubernetes/staging/README.md)。
不支援將 `k8s.io/kubernetes` 模組或 `k8s.io/kubernetes/...` 套件作為函式庫使用。

## 開始開發 K8s

[社群儲存庫] 提供了所有關於從原始碼建置 Kubernetes、貢獻程式碼和文件、聯絡窗口等資訊。

如果您想立即建置 Kubernetes，有兩種選擇：

##### 您已具備可用的 [Go 環境]。

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### 您已具備可用的 [Docker 環境]。

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

詳細說明請參閱[開發者文件]。

## 支援

如果您需要支援，請從[疑難排解指南]開始，並依照我們規劃的流程進行。

此外，若有任何問題，請透過[各種聯絡方式][communication]與我們聯繫。

[announcement]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[communication]: https://git.k8s.io/community/communication
[community repository]: https://git.k8s.io/community
[containerized applications]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[developer's documentation]: https://git.k8s.io/community/contributors/devel#readme
[Docker environment]: https://docs.docker.com/engine
[Go environment]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Scalable Microservices with Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[troubleshooting guide]: https://kubernetes.io/docs/tasks/debug/

## 社群會議

[行事曆](https://www.kubernetes.dev/resources/calendar/) 提供所有 Kubernetes 社群會議的統一列表。

## 採用者

[用戶案例研究](https://kubernetes.io/case-studies/) 網站收錄了各產業組織部署或遷移至 Kubernetes 的真實案例。

## 治理

Kubernetes 專案由一套原則、價值觀、政策和流程所治理，協助我們的社群和成員共同邁向共同目標。

[Kubernetes 社群](https://github.com/kubernetes/community/blob/master/governance.md) 是了解我們如何自我組織的起點。

[Kubernetes Steering 社群儲存庫](https://github.com/kubernetes/steering) 由 Kubernetes Steering Committee 使用，負責監督 Kubernetes 專案的治理。

## 路線圖

[Kubernetes 功能增強儲存庫](https://github.com/kubernetes/enhancements) 提供有關 Kubernetes 發佈、功能追蹤及待辦事項的資訊。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---