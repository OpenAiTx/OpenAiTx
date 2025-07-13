# NFC Ödeme Terminali

Beş blok zinciri ağı üzerinden kripto para ödemelerini işleyen, gerçek zamanlı işlem takibi ve kapsamlı geçmiş izleme özelliklerine sahip çok zincirli bir NFC ödeme terminali.

## 🌐 Desteklenen Ağlar

- **Ethereum**
- **Base** 
- **Arbitrum** 
- **Optimism** 
- **Polygon** 

### 🎯 **Akıllı Ödeme Önceliği**

Satıcı ile zincir / token kombinasyonu pazarlığı yapmak yerine, ödeme terminali bunu otomatik olarak halleder. Önce satıcının desteklediği ve sizin de bakiyenizin bulunduğu bir zinciri belirler, ardından işlemi aşağıdaki öncelik ile ETH veya bir ERC-20 token ile gönderir:

```
L2 Stablecoin > L2 Diğer > L2 ETH > L1 Stablecoin > L1 Diğer > L1 ETH
```
## 🚀 Hızlı Başlangıç

1. **Bağımlılıkları yükleyin:**
   ```bash
   npm install
   ```

2. **Ortamı ayarlayın:**
   ```bash
   echo "ALCHEMY_API_KEY=your_alchemy_api_key_here" > .env
   ```

3. **Terminali çalıştırın:**
   ```bash
   npm start
   ```

4. **Arayüzü açın:**
   `http://localhost:3000` adresine gidin

## 🏗️ Mimari

```
src/
├── server.ts                   # Express sunucusu & WebSocket yöneticisi
├── app.ts                      # Ana uygulama düzenleyicisi
├── web/index.html              # Ödeme terminali arayüzü
├── config/index.ts             # Çoklu-zincir yapılandırması
└── services/
    ├── nfcService.ts           # NFC okuyucu & cüzdan tarama
    ├── alchemyService.ts       # Çoklu-zincir bakiye & izleme
    ├── paymentService.ts       # Ödeme seçimi & EIP-681 oluşturma
    ├── ethereumService.ts      # Adres doğrulama yardımcıları
    └── addressProcessor.ts     # Yinelenen işlem önleme
scripts/
└── rpi-deploy/
    ├── setup-build-environment.sh  # Raspberry Pi imajı oluşturmak için bağımlılıkları yükler
    └── build-pi-image-osx.sh       # Raspberry Pi imajı oluşturur
```
## 💡 Kullanım

### **Ödeme İşleme**
1. Tuş takımını kullanarak tutarı girin (kuruş bazlı: "150" = 1,50 $)
2. Ödemeyi başlatmak için "Tahsil Et"e dokunun
3. Müşteri ödemeyi göndermek için NFC cihazını dokundurur
4. Gerçek zamanlı izleme işlem onayını sağlar
5. Blok gezgini bağlantısı ile "Onaylandı" mesajı

### **İşlem Geçmişi**
1. Tuş takımındaki 📜 geçmiş butonuna dokunun
2. Tüm işlemleri görüntüleyin veya belirli bir cüzdan için geçmişi tarayın
3. "📱 Geçmiş İçin Cüzdan Tara"ya dokunun ve müşterinin cihazını dokundurmasını sağlayın
4. O belirli cüzdana ait filtrelenmiş işlemleri inceleyin


## 🔄 Ödeme Akışı

1. **NFC Algılama** → Müşteri cihazını dokundurur
2. **Çoklu Zincir Getirimi** → Tüm 6 zincirde portföy analizi
3. **Akıllı Seçim** → Öncelik sistemine göre en uygun ödeme tokenı
4. **EIP-681 Oluşturma** → Zincir kimliği ile ödeme isteği
5. **Gerçek Zamanlı İzleme** → İşlem onayı için WebSocket/polling
6. **Geçmiş Kaydı** → İşlem tam meta verilerle saklanır
## 🛡️ İşlem İzleme

- Ethereum, Base, Arbitrum, Optimism, Polygon için **WebSocket izleme**
- **Anket tabanlı izleme** yedekleme
- **5 dakika** sonra otomatik zaman aşımı
- İşlem doğrulaması için **blok gezgini entegrasyonu**
- **Durum takibi**: tespit edildi → onaylandı → başarısız oldu

## 🍓 Raspberry Pi Dağıtımı

Bu NFC ödeme terminali, üretim kullanımı için Raspberry Pi donanımında **tak-çalıştır kiosk** olarak dağıtılabilir.

### **Donanım Gereksinimleri**
- Raspberry Pi 4B (4GB+ RAM önerilir)
- 7" Resmi Raspberry Pi Dokunmatik Ekran
- **ACR1252U-M1 NFC Okuyucu** (özellikle desteklenir)
- 32GB+ MicroSD kart

### **Dağıtım Özellikleri**
- **Tek komutla kurulum** ile önyüklenebilir SD kart imajı oluşturur
- **Önceden yapılandırılmış WiFi** ve API kimlik bilgileri
- **Otomatik başlatma** ile tam ekran kiosk modu
- **Güvenlik doğrulaması** test adresleriyle dağıtımı engeller
- **macOS ve Linux** kurulum desteği
### **Hızlı Dağıtım**
```bash
# Dağıtım betiklerine gidin
cd scripts/rpi-deploy

# Dağıtımınızı yapılandırın
cp build-config.env.template build-config.env
# build-config.env dosyasını WiFi, API anahtarınız ve mağaza adresiniz ile düzenleyin

# Önyüklenebilir imajı oluşturun (macOS)
./build-pi-image-osx.sh

# Oluşturulan nfc-terminal-<date>.img.gz dosyasını Raspberry Pi Imager ile SD karta yazın ve başlatın!
```

📖 **[Tam Dağıtım Kılavuzu](https://raw.githubusercontent.com/FreePayPOS/merchant-app/main/README-DEPLOYMENT.md)**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---