# Kubernetes The Hard Way

Ten samouczek przeprowadzi Cię przez proces konfiguracji Kubernetes w trudny sposób. Ten przewodnik nie jest przeznaczony dla osób poszukujących w pełni zautomatyzowanego narzędzia do uruchomienia klastra Kubernetes. Kubernetes The Hard Way został zoptymalizowany pod kątem nauki, co oznacza, że prowadzi dłuższą drogą, byś mógł zrozumieć każde zadanie wymagane do uruchomienia klastra Kubernetes.

> Wyniki tego samouczka nie powinny być traktowane jako gotowe do użycia w środowisku produkcyjnym i mogą otrzymać ograniczone wsparcie społeczności, ale nie powinno to powstrzymać Cię przed nauką!

## Copyright

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />To dzieło jest objęte licencją <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a>.


## Grupa docelowa

Grupą docelową tego samouczka są osoby, które chcą zrozumieć podstawy Kubernetes i jak kluczowe komponenty współpracują ze sobą.

## Szczegóły klastra

Kubernetes The Hard Way prowadzi przez proces uruchamiania podstawowego klastra Kubernetes z wszystkimi komponentami płaszczyzny sterowania działającymi na jednym węźle oraz dwoma węzłami roboczymi, co wystarcza do poznania podstawowych koncepcji.

Wersje komponentów:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## Laboratoria

Ten samouczek wymaga czterech (4) maszyn wirtualnych lub fizycznych opartych na ARM64 lub AMD64, podłączonych do tej samej sieci.

* [Wymagania wstępne](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [Konfiguracja Jumpboxa](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [Przydzielanie zasobów obliczeniowych](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [Tworzenie CA i generowanie certyfikatów TLS](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [Generowanie plików konfiguracyjnych Kubernetes do uwierzytelniania](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [Generowanie konfiguracji szyfrowania danych i klucza](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [Uruchamianie klastra etcd](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [Uruchamianie płaszczyzny sterowania Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [Uruchamianie węzłów roboczych Kubernetes](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [Konfiguracja kubectl do zdalnego dostępu](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [Konfiguracja tras sieciowych Podów](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [Test dymny](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [Czyszczenie](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---