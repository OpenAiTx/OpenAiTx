# Git Smart Squash

Commit’leri elle yeniden düzenleyerek zaman kaybetmeyi bırakın. Bunu sizin için yapacak bir yapay zekâya bırakın.

## Sorun

Bunu yaşadınız: Bir özellik için 15 commit, bunların yarısı "fix", "typo" veya "WIP". Şimdi bunları PR incelemesi için temizlemeniz gerekiyor. Commit’leri elle birleştirmek ve yeniden yazmak zahmetli.

## Çözüm

Git Smart Squash, değişikliklerinizi analiz eder ve bunları uygun mesajlarla mantıksal commit’lere yeniden düzenler:

```bash
# Önce: dağınık branch’iniz
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation
```
# Sonra: temiz, mantıklı commitler
* feat: JWT kimlik doğrulama sistemi uygulandı
* test: auth endpoint kapsaması eklendi
```

## Hızlı Başlangıç

### 1. Kurulum

```bash
# Pip kullanarak
pip install git-smart-squash

# pipx kullanarak (izole kurulum için önerilir)
pipx install git-smart-squash

# uv kullanarak (hızlı Python paket yöneticisi)
uv tool install git-smart-squash
```
### 2. AI Kurulumu

**Seçenek A: Lokal (Ücretsiz, Gizli)**
```bash
# Ollama'yı https://ollama.com adresinden kurun
ollama pull devstral  # Varsayılan model
```

**Seçenek B: Bulut (Daha iyi sonuçlar)**
```bash
export OPENAI_API_KEY="anahtarınız"
export ANTHROPIC_API_KEY="anahtarınız"
export GEMINI_API_KEY="anahtarınız"
```

### 3. Çalıştır

```bash
cd your-repo
git-smart-squash
```
Hepsi bu kadar. Planı gözden geçirin ve onaylayın.

## Komut Satırı Parametreleri

| Parametre | Açıklama | Varsayılan |
|-----------|----------|------------|
| `--base` | Karşılaştırılacak temel dal | Yapılandırma dosyası veya `main` |
| `--ai-provider` | Kullanılacak AI sağlayıcısı (openai, anthropic, local, gemini) | Ayarlarda yapılandırılmış |
| `--model` | Kullanılacak belirli AI modeli (aşağıda önerilen modellere bakınız) | Sağlayıcı varsayılanı |
| `--config` | Özel yapılandırma dosyasının yolu | `.git-smart-squash.yml` veya `~/.git-smart-squash.yml` |
| `--auto-apply` | Onay istemi olmadan commit planını uygula | `false` |
| `--instructions`, `-i` | AI için özel talimatlar (örn. "Özellik alanına göre grupla") | Yok |
| `--no-attribution` | Commitlerde atıf mesajını devre dışı bırak | `false` |
| `--debug` | Ayrıntılı bilgi için hata ayıklama kaydını etkinleştir | `false` |

## Önerilen Modeller

### Varsayılan Modeller
- **OpenAI**: `gpt-4.1` (varsayılan)
- **Anthropic**: `claude-sonnet-4-20250514` (varsayılan)
- **Gemini**: `gemini-2.5-pro` (varsayılan)
- **Local/Ollama**: `devstral` (varsayılan)

### Model Seçimi
```bash
# Farklı bir model belirtin
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# Yerel Ollama için
git-smart-squash --ai-provider local --model llama-3.1
```

## Özel Talimatlar

`--instructions` parametresi, commit'lerin nasıl organize edileceğini kontrol etmenizi sağlar:

### Örnekler
```bash
# Ticket önekleri ekle
git-smart-squash -i "Tüm commit'lere [ABC-1234] öneki ekle"

# Türe göre ayır
git-smart-squash -i "Backend ve frontend değişikliklerini ayrı commit'lerde tut"
```
# Commit sayısını sınırla
git-smart-squash -i "Toplamda en fazla 3 commit oluştur"

```

### Daha İyi Sonuçlar İçin İpuçları
- **Spesifik olun**: "Veritabanı migrasyonlarını ayrı gruplandır" ifadesi "güzelce düzenle"den daha iyi sonuç verir
- **Her seferinde bir talimat verin**: Karmaşık ve çok parçalı talimatlar kısmen göz ardı edilebilir
- **Daha iyi modeller kullanın**: Daha büyük modeller, talimatları daha güvenilir şekilde takip eder

## Yaygın Kullanım Durumları

### "PR incelemesinden önce temizliğe ihtiyacım var"
```bash
git-smart-squash              # Planı gösterir ve onay ister
git-smart-squash --auto-apply # Onay istemeden otomatik uygular
```

### "Farklı bir ana dal ile çalışıyorum"
```bash
git-smart-squash --base develop
```
### "Belirli bir AI sağlayıcı kullanmak istiyorum"
```bash
git-smart-squash --ai-provider openai
```

## Güvenlik

**Kodunuz güvende:**
- Değişiklik yapmadan önce planı gösterir
- Otomatik yedek dalı oluşturur
- Temiz bir çalışma dizini gerektirir
- Sizin komutunuz olmadan asla push işlemi yapmaz

**Bir şeyler ters giderse:**
```bash
# Yedeği bul
git branch | grep backup

# Geri yükle
git reset --hard your-branch-backup-[timestamp]
```

## AI Sağlayıcıları

| Sağlayıcı   | Maliyet | Gizlilik |
|-------------|---------|----------|
| **Ollama**   | Ücretsiz | Yerel    |
| **OpenAI**   | ~0.01$   | Bulut    |
| **Anthropic**| ~0.01$   | Bulut    |
| **Gemini**   | ~0.01$   | Bulut    |

## Gelişmiş Yapılandırma (İsteğe Bağlı)

Özelleştirmek mi istiyorsunuz? Bir yapılandırma dosyası oluşturun:

**Projeye özel** (`.git-smart-squash.yml` depo kökünüzde):
```yaml
ai:
  provider: openai  # Bu proje için OpenAI kullan
base: develop       # Bu proje için ana dal olarak develop kullan
```
**Global default** (`~/.git-smart-squash.yml`):
```yaml
ai:
  provider: local   # Varsayılan olarak her zaman yerel AI kullan
base: main          # Tüm projeler için varsayılan ana dal
```

## Sorun Giderme

### "Geçersiz JSON" Hatası
Bu genellikle AI modelinin yanıtı doğru biçimlendiremediği anlamına gelir:
- **Ollama ile**: `llama2` yerine `mistral` veya `mixtral` kullanın
- **Çözüm**: `ollama pull mistral` komutunu çalıştırın ve tekrar deneyin
- **Alternatif**: `--ai-provider openai` ile bir bulut sağlayıcı kullanın

### Model Talimatlara Uymuyor
Bazı modeller karmaşık talimatlarla zorlanabilir:
- **Daha iyi modeller kullanın**: `--model gpt-4-turbo` veya `--model claude-3-opus`
- **Talimatları basitleştirin**: Bir net talimat, birden çoktan daha iyi çalışır
- **Açık olun**: "[ABC-123] ile öne ekle" deyin, "bilet numarası ekle" demeyin
### "Ollama bulunamadı" 
```bash
# https://ollama.com adresinden yükleyin
ollama serve
ollama pull devstral  # Varsayılan model
```

### Kötü Commit Gruplama
Eğer AI çok fazla commit oluşturuyorsa veya iyi gruplamıyorsa:
- **Yetersiz model**: Daha büyük bir model kullanın
- **Talimat ekleyin**: `-i "İlgili değişiklikleri grupla, en fazla 3 commit"`
- **Geri Bildirim Verin**: GitHub üzerinde bir issue oluşturun ve bize ne olduğunu bildirin

### Kurulum Sorunları (Mac)
Eğer pip yoksa veya izole kurulumları tercih ediyorsanız:
```bash
# pipx kullanarak (önerilir)
brew install pipx
pipx install git-smart-squash
```
### "Yeniden düzenlenecek değişiklik yok"
```bash
git log --oneline main..HEAD  # Commitlerinizin olup olmadığını kontrol edin
git diff main                 # Değişikliklerinizin olup olmadığını kontrol edin
```

### Büyük Farklar / Token Sınırları
Yerel modellerde yaklaşık ~32k token sınırı vardır. Büyük değişiklikler için:
- Daha yeni bir commit ile `--base` kullanın
- Buluta geçin: `--ai-provider openai`
- Daha küçük PR’lara bölün

### Daha Fazla Yardıma mı İhtiyacınız Var?

[Dökümantasyonumuzu](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md) inceleyin veya bir issue açın!

## Lisans

MIT Lisansı - detaylar için [LICENSE](LICENSE) dosyasına bakın.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---