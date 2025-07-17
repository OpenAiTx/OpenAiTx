# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Gelecekte ente-io/ente'ye geçmeyi planlıyorum, çünkü fotoğrafları depolamak için s3'e ihtiyacım var~~
> 
> ente'nin hala çok az özelliği var
> 
> s3'ü bağlamak için juicedata/juicefs kullanmaya geçildi

## Proje Tanıtımı

Bu proje, [Immich](https://github.com/immich-app/immich) fotoğraf yönetim sistemine yapay zeka yetenekleri ekleyen bir çözümdür. Immich'in yerel işlevleri aşağıdaki bileşenlerle genişletilmiştir:

- **inference-gateway**: Go ile yazılmış bir ağ geçidi hizmeti, Immich'in makine öğrenimi isteklerinin akıllı şekilde yönlendirilmesinden sorumlu
- **mt-photos-ai**: Python ve FastAPI tabanlı bir yapay zeka hizmeti, RapidOCR ve cn-clip modelleriyle entegre edilmiştir
- Immich'in işlevselliği üzerine OCR metin tanıma araması ve tekil medya AI verisinin yeniden işlenmesi, OCR tam metin vektörü ve CLIP vektörü puanlama karışık sıralama dahil olmak üzere genişletmeler
- PostgreSQL'e zhparser ile Çince kelime ayrıştırıcı eklenmesi

## Temel Özellikler

### 1. OCR Metin Tanıma ve Arama

- RapidOCR ile resimlerdeki metinleri tanıma
- Çince ve İngilizce karışık metin tanıma desteği
- Görüntüdeki metin içeriğine dayalı arama işlevi sağlama

### 2. CLIP Görüntü Vektörü İşleme

- cn-clip modeli tabanlı daha doğru Çince görsel - metin eşleştirmesi
- Anlamsal arama desteği, arama doğruluğunu artırma

### 3. Tekil Medya AI Verisinin Yeniden İşlenmesi

- Tek bir fotoğraf/video için OCR verisini yeniden oluşturma desteği
- Tek bir fotoğraf/video için CLIP vektör verisini yeniden oluşturma desteği
- Tanıma sonucu doğru olmadığında manuel yenileme olanağı sağlama

## Sistem Mimarisi

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP请求
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python服务)    │
                     │                  │
                     └──────────────────┘
```
## Bileşenlerin Detaylı Açıklaması

### inference-gateway

Go diliyle yazılmış bir ağ geçidi hizmeti, başlıca görevleri:
- Immich'in makine öğrenimi isteklerini almak
- İstek türüne göre OCR ve CLIP isteklerini mt-photos-ai hizmetine yönlendirmek
- Diğer makine öğrenimi isteklerini (ör. yüz tanıma) Immich'in yerel makine öğrenimi hizmetine yönlendirmek
- Kimlik doğrulama ve veri formatı dönüşümünü işlemek

### mt-photos-ai

Python ve FastAPI ile yazılmış bir AI hizmeti, şunları sağlar:
- OCR metin tanıma API'si (RapidOCR tabanlı)
- CLIP vektör işleme API'si (cn-clip tabanlı)
- GPU hızlandırmayı destekler

## Dağıtım Talimatları

### Çevre Gereksinimleri

- Docker ve Docker Compose
- NVIDIA GPU (isteğe bağlı, fakat hızlandırma için önerilir)
- Yeterli depolama alanı

### Yapılandırma Açıklamaları

1. **inference-gateway Yapılandırması**

Başlıca ortam değişkenleri:

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **mt-photos-ai Yapılandırması**

Ana ortam değişkenleri:

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### Dağıtım Adımları

1. Depoyu klonlayın:

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. Servisi başlatın:

```bash
docker-compose up -d
```
## Kullanım Talimatları

1. **Immich'i özel ML servisiyle yapılandırma**

Immich'in yapılandırma dosyasında, makine öğrenimi servisi adresini inference-gateway olarak ayarlayın:

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **OCR Arama Kullanımı**

- Immich arama çubuğunda `ocr:` önekiyle OCR araması yapın
- Örneğin: `ocr:Fatura` ifadesi, fotoğraflarda "Fatura" metni geçen resimleri arar

3. **Tekil Medya AI Verilerini Yeniden İşleme**

- Fotoğraf detay sayfasında menü seçeneğine tıklayın
- "OCR Verisini Yeniden Oluştur" veya "CLIP Vektörünü Yeniden Oluştur" seçin
- Sistem, o fotoğrafın AI verilerini yeniden işleyecektir

## Geliştirici Kılavuzu

### inference-gateway (Go)

Derleyip çalıştırmak için:

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

Geliştirme ortamı ayarları:

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## Lisans

Bu proje MIT Lisansı ile açık kaynak olarak sunulmuştur.

## Teşekkürler

- [Immich](https://github.com/immich-app/immich) - Açık kaynak, kendi kendine barındırılan fotoğraf ve video yedekleme çözümü
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - PaddleOCR tabanlı, çapraz platform OCR kütüphanesi
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Çince çok modlu karşılaştırmalı öğrenme ön eğitimli modeli



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---