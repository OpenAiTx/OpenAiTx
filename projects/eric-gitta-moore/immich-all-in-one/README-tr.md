# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~Sonraki planım fotoğrafları depolamak için s3 gerektiğinden ente-io/ente'ye geçmekti~~
> 
> ente yine de çok az özelliğe sahip
> 
> Bunun yerine juicedata/juicefs ile s3 mount edildi

## Proje Tanıtımı

Bu proje, [Immich](https://github.com/immich-app/immich) fotoğraf yönetim sisteminin yapay zeka yeteneklerini arttıran bir çözümdür. Immich'in yerleşik özelliklerini aşağıdaki bileşenlerle genişletir:

- **inference-gateway**: Go diliyle yazılmış bir ağ geçidi servisi, Immich'in makine öğrenimi isteklerinin akıllıca yönlendirilmesinden sorumlu
- **mt-photos-ai**: Python ve FastAPI tabanlı bir yapay zeka servisi, RapidOCR ve cn-clip modellerini entegre eder
- Immich'in işlevselliğine genişletmeler: OCR metin tanıma arama ve tekli medya AI verisi yeniden işleme, OCR tam metin vektörü ve CLIP vektör skoru karışık sıralama
- PostgreSQL'e zhparser ile Çince kelime ayrıştırma ekler

## Başlıca Özellikler

### 1. OCR Metin Tanıma ve Arama

- RapidOCR kullanarak resimlerdeki metni tanır
- Çince ve İngilizce karışık metin tanıma desteği
- Görüntü metni içeriğine dayalı arama işlevi sunar

### 2. CLIP Görüntü Vektör İşleme

- cn-clip modeliyle daha doğru Çince görüntü-metin eşlemesi
- Anlamsal arama desteği, arama doğruluğunu artırır

### 3. Tekli Medya AI Verisi Yeniden İşleme

- Tek bir fotoğraf/video için OCR verisini yeniden üretebilir
- Tek bir fotoğraf/video için CLIP vektör verisini yeniden üretebilir
- Tanıma sonucu doğru çıkmazsa manuel yenileme olanağı sunar

## Sistem Mimarisi

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go ağ geçidi)│      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP isteği
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │ (Python servisi) │
                     │                  │
                     └──────────────────┘
```

## Bileşen Detayları

### inference-gateway

Go diliyle yazılmış ağ geçidi servisi, başlıca görevleri:
- Immich'in makine öğrenimi isteklerini almak
- İstek türüne göre OCR ve CLIP isteklerini mt-photos-ai servisine yönlendirmek
- Diğer makine öğrenimi isteklerini (ör. yüz tanıma) Immich'in yerel makine öğrenimi servisine iletmek
- Kimlik doğrulama ve veri formatı dönüşümünü gerçekleştirmek

### mt-photos-ai

Python ve FastAPI ile yazılmış AI servisi, şunları sağlar:
- OCR metin tanıma API'si (RapidOCR tabanlı)
- CLIP vektör işleme API'si (cn-clip tabanlı)
- GPU hızlandırma desteği

## Dağıtım Talimatları

### Sistem Gereksinimleri

- Docker ve Docker Compose
- NVIDIA GPU (isteğe bağlı fakat hız için önerilir)
- Yeterli depolama alanı

### Yapılandırma Açıklaması

1. **inference-gateway Yapılandırması**

Temel ortam değişkenleri:
```
IMMICH_API=http://localhost:3003  # Immich API adresi
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai servis adresi
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API anahtarı
PORT=8080  # Ağ geçidi dinleme portu
```

2. **mt-photos-ai Yapılandırması**

Temel ortam değişkenleri:
```
CLIP_MODEL=ViT-B-16  # CLIP model ismi
CLIP_DOWNLOAD_ROOT=./models/clip  # Model indirme yolu
DEVICE=cuda  # veya cpu, tahmin cihazı
HTTP_PORT=8060  # Servis dinleme portu
```

### Dağıtım Adımları

1. Depoyu klonlayın:
```bash
git clone https://github.com/your-username/immich-all-in-one.git
cd immich-all-in-one
```

2. Servisleri başlatın:
```bash
docker-compose up -d
```

## Kullanım Talimatları

1. **Immich'i özel ML servisiyle yapılandırma**

Immich'in yapılandırma dosyasında, makine öğrenimi servis adresini inference-gateway olarak ayarlayın:
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **OCR Arama Kullanımı**

- Immich arama çubuğunda `ocr:` önekini kullanarak OCR araması yapın
- Örneğin: `ocr:Fatura` ifadesi, resimde "Fatura" metni içeren fotoğrafları arar

3. **Tekli Medya AI Verisi Yeniden İşleme**

- Fotoğraf detay sayfasında menü seçeneklerine tıklayın
- "OCR Verisini Yeniden Oluştur" veya "CLIP Vektörünü Yeniden Oluştur" seçin
- Sistem ilgili fotoğrafın AI verisini yeniden işler

## Geliştirici Rehberi

### inference-gateway (Go)

Derleyip çalıştırmak için:
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

Geliştirme ortamı kurulumu:
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## Lisans

Bu proje MIT lisansı ile açık kaynak olarak sunulmaktadır.

## Teşekkürler

- [Immich](https://github.com/immich-app/immich) - Açık kaynak, kendi kendine barındırılan fotoğraf ve video yedekleme çözümü
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - PaddleOCR tabanlı, çoklu platformda çalışan OCR kütüphanesi
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - Çince çok modlu karşılaştırmalı öğrenme ön eğitimli modeli

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---