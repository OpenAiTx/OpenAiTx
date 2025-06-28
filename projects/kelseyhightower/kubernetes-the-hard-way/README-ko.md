# Kubernetes The Hard Way

이 튜토리얼은 Kubernetes를 어렵게 설정하는 과정을 안내합니다. 이 가이드는 Kubernetes 클러스터를 자동화 도구로 간편하게 구축하려는 사람을 위한 것이 아닙니다. Kubernetes The Hard Way는 학습에 최적화되어 있으며, 각 작업을 직접 수행함으로써 클러스터를 부트스트랩하는 데 필요한 모든 단계를 이해할 수 있도록 설계되었습니다.

> 이 튜토리얼의 결과물은 프로덕션 환경에 적합하다고 볼 수 없으며, 커뮤니티의 지원도 제한적일 수 있습니다. 하지만 이것이 학습을 방해하지는 않을 것입니다!

## 저작권

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />이 저작물은 <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">크리에이티브 커먼즈 저작자표시-비영리-동일조건변경허락 4.0 국제 라이선스</a>에 따라 이용할 수 있습니다.

## 대상 독자

이 튜토리얼의 대상은 Kubernetes의 기본 원리와 핵심 구성 요소들이 어떻게 결합되는지 이해하고자 하는 사람입니다.

## 클러스터 세부 정보

Kubernetes The Hard Way는 모든 컨트롤 플레인 구성 요소가 단일 노드에 실행되고, 두 개의 워커 노드가 있는 기본적인 Kubernetes 클러스터를 부트스트랩하는 방법을 안내합니다. 이는 핵심 개념을 학습하기에 충분합니다.

구성 요소 버전:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## 실습

이 튜토리얼에는 동일한 네트워크에 연결된 네(4) 대의 ARM64 또는 AMD64 기반 가상 머신 혹은 물리 머신이 필요합니다.

* [사전 준비사항](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [점프박스 설정](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [컴퓨트 리소스 프로비저닝](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [CA 프로비저닝 및 TLS 인증서 생성](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [인증을 위한 Kubernetes 구성 파일 생성](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [데이터 암호화 구성 및 키 생성](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [etcd 클러스터 부트스트랩](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Kubernetes 컨트롤 플레인 부트스트랩](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Kubernetes 워커 노드 부트스트랩](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [원격 접근을 위한 kubectl 구성](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [파드 네트워크 라우팅 프로비저닝](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [스모크 테스트](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [정리](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---