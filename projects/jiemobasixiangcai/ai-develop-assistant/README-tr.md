# 🚀 MCP AI Geliştirme Asistanı

> AI geliştiricilerine akıllı gereksinim analizi ve mimari tasarımda yardımcı olan MCP aracı

## ✨ Temel Özellikler

- **Akıllı Gereksinim Netleştirme**: Proje türünü otomatik olarak tanır, hedefe yönelik sorular üretir
- **Dallanma Farkındalığı Yönetimi**: Proje hedefleri, fonksiyonel tasarım, teknik tercihler, UI tasarımı gibi boyutları takip eder
- **Otomatik Mimari Oluşturma**: Tam gereksinimlere dayalı teknik mimari planı oluşturur
- **Kalıcı Depolama**: Analiz sonuçlarını otomatik olarak kaydeder, doküman dışa aktarmayı destekler

## 📁 Hızlı Kurulum

### Eski Sürüm Konfigürasyonu
1. **Kodu Klonlayın**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **Sanal Ortam Önerilir**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **Bağımlılıkları Yükleyin**
   ```bash
   pip install -r requirements.txt
   ```

4. **Konfigürasyon Dosyası Konumu**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **Konfigürasyon Ekleyin**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Claude Desktop'u Yeniden Başlatın**

### Yeni Sürüm Konfigürasyonu
#### 🔧 Temel Araçlar
1. **start_new_project** - Yeni proje başlat
2. **create_requirement_blueprint** - Gereksinim taslağı oluştur
3. **requirement_clarifier** - Gereksinim netleştirme ipucu al
4. **save_clarification_tasks** - Netleştirme görevlerini kaydet
5. **update_branch_status** - Dal durumunu güncelle
6. **requirement_manager** - Gereksinim doküman yöneticisi
7. **check_architecture_prerequisites** - Mimari ön koşulları kontrol et
8. **get_architecture_design_prompt** - Mimari tasarım ipucu al
9. **save_generated_architecture** - Oluşturulan mimariyi kaydet
10. **export_final_document** - Tam dokümanı dışa aktar
11. **view_requirements_status** - Gereksinim durumunu görüntüle

#### Konfigürasyon (Uzaktan doğrudan aracınıza kopyalayın, MCP_STORAGE_DIR'i kendi yerel dizininizle değiştirin)
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 Kullanım Akışı

### Temel Adımlar

1. **Gereksinim Netleştirme**
   ```
   requirement_clarifier("Bir online eğitim platformu yapmak istiyorum")
   ```

2. **Gereksinim Yönetimi**
   ```
   requirement_manager("Hedef kullanıcılar: Öğrenciler ve öğretmenler", "Proje özeti")
   ```

3. **Durumu Görüntüle**
   ```
   view_requirements_status()
   ```
4. **Mimari Tasarım**
   ```
   architecture_designer("Çevrimiçi Eğitim Platformu Mimarisi")
   ```

5. **Belgeyi Dışa Aktar**
   ```
   export_final_document()
   ```

## 🚀 Başlarken

### Hızlı Başlangıç
1. **Claude Desktop'u Yapılandırın** (Yukarıdaki yapılandırma yöntemine bakınız)
2. **Claude Desktop'u Yeniden Başlatın**
3. **Akıllı Gereksinim Analizine Başlayın**:
   ```
   requirement_clarifier("Proje fikrinizi açıklayın")
   ```
4. **AI'nın Akıllı Yönlendirmesini Takip Edin**, tüm gereksinim dallarını adım adım tamamlayın
5. **Tam Belgeyi Dışa Aktarın**:
   ```
   export_final_document()
   ```

### En İyi Uygulamalar
- 💬 **AI'nın Dal Yönetimine Güvenin**: Tüm gereksinim dallarını tamamlamak için AI'nın sizi yönlendirmesine izin verin
- 🎯 **Tercihlerinizi Açıkça İfade Edin**: Teknoloji seçimi, UI tarzı vb. konularda tercihlerinizi net bir şekilde belirtin
- 📊 **Durumu Düzenli Olarak Kontrol Edin**: İlerlemenizi görmek için `view_requirements_status` komutunu kullanın
- 🤖 **AI'ya Uygun Yetki Verin**: Emin olmadığınız kısımlarda "standart çözümü kullan" diyebilirsiniz

---

**🎯 Artık elinizde gerçek anlamda akıllı bir AI geliştirme asistanı var; her ayrıntıyı hatırlar ve sizi eksiksiz gereksinim analizine yönlendirir!**

## 💬 Sohbet Grubu

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="Sohbet Grubu">
<br>
Sohbet Grubu
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---