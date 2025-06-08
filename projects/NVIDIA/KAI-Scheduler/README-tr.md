[![Lisans](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Kapsam](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI Scheduler
KAI Scheduler, AI ve makine öğrenimi iş yükleri için GPU kaynak tahsisini optimize eden sağlam, verimli ve ölçeklenebilir bir [Kubernetes zamanlayıcısı](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/)dır.

Binlerce düğüm içeren büyük ölçekli GPU kümelerini ve yüksek iş yükü hacmini yönetmek için tasarlanmıştır; bu da KAI Scheduler’ı kapsamlı ve zorlu ortamlar için ideal kılar.
KAI Scheduler, Kubernetes kümesi yöneticilerinin GPU kaynaklarını iş yüklerine dinamik olarak tahsis etmesine olanak tanır.

KAI Scheduler, az kaynak gerektiren küçük, etkileşimli görevlerden büyük eğitim ve çıkarıma kadar tüm AI yaşam döngüsünü aynı küme içinde destekler.
Farklı tüketiciler arasında kaynak adaletini korurken optimum kaynak tahsisini sağlar.
Kümede yüklü olan diğer zamanlayıcılarla birlikte çalışabilir.

## Temel Özellikler
* [Toplu Zamanlama](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/batch/README.md): Bir gruptaki tüm pod’ların aynı anda veya hiç zamanlanmamasını sağlar.
* Kutuya Yerleştirme & Dağıtılmış Zamanlama: Düğüm kullanımını ya parçalanmayı en aza indirerek (kutuya yerleştirme) ya da dayanıklılığı ve yük dengelemesini artırarak (dağıtılmış zamanlama) optimize eder.
* [İş Yükü Önceliği](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/priority/README.md): Kuyruklar içinde iş yüklerine etkili şekilde öncelik verir.
* [Hiyerarşik Kuyruklar](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/queues/README.md): Esnek organizasyonel kontrol için iki seviyeli kuyruk hiyerarşileriyle iş yüklerini yönetin.
* [Kaynak Dağılımı](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#resource-division-algorithm): Kuyruk başına özel kota, kota aşımı ağırlıkları, sınırlar ve öncelikler belirleyin.
* [Adalet Politikaları](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#reclaim-strategies): Dominant Resource Fairness (DRF) ve kuyruklar arası kaynak geri kazanımı ile adil kaynak dağılımı sağlar.
* İş Yükü Konsolidasyonu: Parçalanmayı azaltmak ve küme kullanımını artırmak için çalışan iş yüklerini akıllıca yeniden tahsis eder.
* [Esnek İş Yükleri](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/elastic/README.md): Tanımlanmış minimum ve maksimum pod sayıları arasında iş yüklerini dinamik olarak ölçeklendirir.
* Dinamik Kaynak Tahsisi (DRA): Kubernetes ResourceClaim’leri aracılığıyla (ör. NVIDIA veya AMD’den GPU’lar) satıcıya özel donanım kaynaklarını destekler.
* [GPU Paylaşımı](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/gpu-sharing/README.md): Bir veya birden fazla GPU’nun birden fazla iş yükü tarafından verimli şekilde paylaşılmasına olanak tanır, kaynak kullanımını maksimize eder.
* Bulut & Yerinde Destek: Dinamik bulut altyapıları (Karpenter gibi otomatik ölçekleyiciler dahil) ile tam uyumlu ve ayrıca sabit yerinde dağıtımlar için uygundur.

## Ön Koşullar
KAI Scheduler’ı yüklemeden önce şunlara sahip olduğunuzdan emin olun:

- Çalışan bir Kubernetes kümesi
- [Helm](https://helm.sh/docs/intro/install) CLI kurulu
- GPU kaynağı talep eden iş yüklerinin zamanlanabilmesi için [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) kurulmuş olmalı

## Kurulum
KAI Scheduler, `kai-scheduler` isim alanına kurulacaktır. İş yükü gönderirken özel bir isim alanı kullandığınızdan emin olun.

### Kurulum Yöntemleri
KAI Scheduler şu şekilde kurulabilir:

- **Üretimden (Önerilen)**
- **Kaynaktan (Kendiniz Derleyin)**

#### Üretimden Kurulum
[Releases](https://github.com/NVIDIA/KAI-Scheduler/releases) sayfasında en son sürümü bulun.
`<VERSION>` yerine istediğiniz sürüm numarasını yazarak aşağıdaki komutu çalıştırın:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### Kaynaktan Derleme
Talimatlar için [buraya](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/developer/building-from-source.md) bakınız.

## Hızlı Başlangıç
KAI Scheduler ile iş yüklerini zamanlamaya başlamak için lütfen [Hızlı Başlangıç örneğine](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/quickstart/README.md) devam edin.

## Yol Haritası

### 2025 için ana önceliklerin genel görünümü
* Kod tabanını satıcıdan bağımsızlık için yeniden yapılandırma
* Scheduling Gates desteği ekle https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Kueue ile olası entegrasyon üzerine araştırma https://github.com/NVIDIA/KAI-Scheduler/issues/68
* Pod-group için Topolojiye Duyarlı Zamanlama desteği ekle https://github.com/NVIDIA/KAI-Scheduler/issues/66
* İş yükü başına Minimum Çalışma Süresi desteği
* İş yükü başına Maksimum Çalışma Süresi desteği (gecikmeli yeniden kuyruğa alma ile)
* Varsayılan KAI kurulumunun bir parçası olarak daha fazla PriorityClass ekle
* JobSet desteği
* LWS (LeaderWorkerSet) desteği
* Pod ve pod-group öncelikli çıkarma için metrikler ekle
* Öncelik ve Öncelikli Çıkarma’yı birbirinden ayır

### Uzun vadeli hedefler
* Kuyruk başına zaman azalması desteği
* Hiper ölçek iyileştirmeleri
* Küme parçalanmasını önlemek için Çıkarım iş yüklerinin konsolidasyonu desteği
* N seviyeli hiyerarşik kuyruk desteği
* Çıkarım iş yüklerinin kademeli olarak yayılması (yeni sürüm güncellemesi sırasında kuyruk geçici olarak kota aşımı ile)

## Topluluk, Tartışma ve Destek

Sizden haber almak isteriz! Bağlanmanın en iyi yolları:

### Slack
Önce [CNCF Slack](https://communityinviter.com/apps/cloud-native/cncf)’e katılın ve ardından [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler) kanalına gelin.

### İki Haftada Bir Topluluk Çağrısı  
**Ne zaman:** Her iki haftada bir Pazartesi, 17:00 CEST  
[Saat diliminize çevirin](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [Takvime ekle](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [Toplantı notları & gündem](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### E-posta Listesi  
İki haftada bir yapılan toplantılardan haberdar olmak için [kai-scheduler e-posta listesine](https://groups.google.com/g/kai-scheduler) katılın.

### Teknik Sorunlar & Özellik Talepleri  
Hatalar, özellik önerileri veya teknik yardım için lütfen bir [GitHub issue](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose) açın. Bu, talepleri takip etmemize ve etkili yanıt vermemize yardımcı olur.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---