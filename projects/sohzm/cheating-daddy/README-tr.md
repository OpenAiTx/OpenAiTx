# Cheating Daddy

> [!NOTE]  
> En son MacOS ve Windows sürümünü kullanın, eski sürümlerde sınırlı destek vardır

> [!NOTE]  
> Test sırasında siz bir şey sorduğunuzda cevap vermez, görüşmeci soru sormuş gibi simüle etmeniz gerekir, buna cevap verecektir

Gerçek zamanlı bir yapay zeka asistanı; ekran yakalama ve ses analizi kullanarak video aramaları, mülakatlar, sunumlar ve toplantılar sırasında bağlamsal yardım sağlar.

## Özellikler

- **Canlı Yapay Zeka Desteği**: Google Gemini 2.0 Flash Live ile gerçek zamanlı yardım
- **Ekran & Ses Yakalama**: Gördüklerinizi ve duyduklarınızı analiz ederek bağlamsal yanıtlar sunar
- **Birden Fazla Profil**: Mülakat, Satış Görüşmesi, İş Toplantısı, Sunum, Pazarlık
- **Şeffaf Katman**: Her zaman üstte kalan, her yere konumlandırılabilen pencere
- **Tıkla-geç Modu**: Gerekli olduğunda pencereyi tıklamalara karşı şeffaf yapar
- **Çapraz Platform**: macOS, Windows ve Linux’ta çalışır (şimdilik sadece test amaçlı, kullanmayın)

## Kurulum

1. **Bir Gemini API Anahtarı Alın**: [Google AI Studio](https://aistudio.google.com/apikey) adresini ziyaret edin
2. **Bağımlılıkları Yükleyin**: `npm install`
3. **Uygulamayı Başlatın**: `npm start`

## Kullanım

1. Ana pencerede Gemini API anahtarınızı girin
2. Ayarlardan profilinizi ve dili seçin
3. Başlamak için "Oturumu Başlat"a tıklayın
4. Pencereyi klavye kısayolları ile konumlandırın
5. Yapay zeka, ekranınıza ve görüşmecinin sorduğu şeylere göre anlık yardım sağlar

## Klavye Kısayolları

- **Pencereyi Taşıma**: `Ctrl/Cmd + Yön Tuşları` - Pencereyi taşı
- **Tıkla-geç**: `Ctrl/Cmd + M` - Fare olaylarını aç/kapat
- **Kapat/Geri**: `Ctrl/Cmd + \` - Pencereyi kapat veya geri git
- **Mesaj Gönder**: `Enter` - Metni yapay zekaya gönder

## Ses Yakalama

- **macOS**: Sistem sesi için [SystemAudioDump](https://github.com/Mohammed-Yasin-Mulla/Sound) 
- **Windows**: Loopback ses yakalama
- **Linux**: Mikrofon girişi

## Gereksinimler

- Electron uyumlu işletim sistemi (macOS, Windows, Linux)
- Gemini API anahtarı
- Ekran kaydı izni
- Mikrofon/ses izni

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---