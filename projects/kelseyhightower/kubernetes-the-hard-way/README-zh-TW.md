# Kubernetes The Hard Way

本教學將帶你逐步設置 Kubernetes（困難模式）。本指南並不適合尋找全自動化工具來建立 Kubernetes 叢集的人。Kubernetes The Hard Way 最適合用於學習，這意味著採用較繁瑣的路徑，以確保你能了解引導 Kubernetes 叢集所需的每一項任務。

> 本教學的成果不應被視為可直接用於生產環境，且可能只會獲得社群有限的支援，但這不應阻止你學習！

## 版權

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="創用 CC 授權條款" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />本著作採用 <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">創用 CC 姓名標示-非商業性-相同方式分享 4.0 國際 授權條款</a> 授權。

## 目標讀者

本教學的目標讀者是希望理解 Kubernetes 基本原理以及各核心元件如何相互配合的人。

## 叢集細節

Kubernetes The Hard Way 將帶領你引導建立一個基本的 Kubernetes 叢集，所有控制平面元件運行於單一節點，並包含兩個工作節點，這已足夠學習核心概念。

元件版本：

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## 實驗室

本教學需要四（4）台基於 ARM64 或 AMD64 架構、連接於同一網路的虛擬或實體機器。

* [先決條件](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [設置 Jumpbox](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [配置運算資源](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [配置 CA 並產生 TLS 憑證](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [產生 Kubernetes 認證用組態檔](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [產生資料加密組態與金鑰](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [引導 etcd 叢集](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [引導 Kubernetes 控制平面](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [引導 Kubernetes 工作節點](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [設定 kubectl 遠端存取](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [配置 Pod 網路路由](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [冒煙測試](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [清理](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---