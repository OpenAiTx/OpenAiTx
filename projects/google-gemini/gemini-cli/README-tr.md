# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI Ekran Görüntüsü](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

Bu depo, komut satırı tabanlı bir AI iş akışı aracı olan Gemini CLI'yi içerir. Gemini CLI, araçlarınıza bağlanır, kodunuzu anlar ve iş akışlarınızı hızlandırır.

Gemini CLI ile şunları yapabilirsiniz:

- Gemini'nin 1M token bağlam penceresinde ve ötesinde büyük kod tabanlarını sorgulayabilir ve düzenleyebilirsiniz.
- Gemini'nin çok modlu yeteneklerini kullanarak PDF'lerden veya eskizlerden yeni uygulamalar oluşturabilirsiniz.
- Çekme isteklerini sorgulamak veya karmaşık rebase işlemlerini yönetmek gibi operasyonel görevleri otomatikleştirebilirsiniz.
- Yeni yetenekler eklemek için araçları ve MCP sunucularını kullanabilirsiniz, buna [Imagen, Veo veya Lyria ile medya üretimi](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia) de dahildir.
- Sorgularınızı Gemini'ye yerleşik olan [Google Search](https://ai.google.dev/gemini-api/docs/grounding) aracıyla zeminleyebilirsiniz.

## Hızlı Başlangıç

1. **Ön Koşullar:** [Node.js sürüm 18](https://nodejs.org/en/download) veya daha yenisinin yüklü olduğundan emin olun.
2. **CLI'yi Çalıştırın:** Terminalinizde aşağıdaki komutu çalıştırın:

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   Veya şu şekilde kurabilirsiniz:

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **Bir renk teması seçin**
4. **Kimlik Doğrulama:** İstendiğinde, kişisel Google hesabınızla oturum açın. Bu, Gemini'yi kullanarak dakikada 60'a ve günde 1.000'e kadar model isteği yapmanıza olanak tanır.

Artık Gemini CLI'yi kullanmaya hazırsınız!

### Gelişmiş kullanım veya daha yüksek limitler için:

Belirli bir modeli kullanmanız veya daha yüksek istek kapasitesine ihtiyacınız varsa, bir API anahtarı kullanabilirsiniz:

1. [Google AI Studio](https://aistudio.google.com/apikey) üzerinden bir anahtar oluşturun.
2. Bunu terminalinizde bir ortam değişkeni olarak ayarlayın. `YOUR_API_KEY` kısmını oluşturduğunuz anahtar ile değiştirin.

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

Diğer kimlik doğrulama yöntemleri, Google Workspace hesapları dahil, için [kimlik doğrulama](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md) kılavuzuna bakın.

## Örnekler

CLI çalıştırıldığında, Gemini ile shell üzerinden etkileşime geçebilirsiniz.

Yeni bir dizinden bir proje başlatabilirsiniz:

```sh
cd new-project/
gemini
> Size sağlayacağım bir FAQ.md dosyasını kullanarak soruları yanıtlayan bir Gemini Discord botu yaz
```

Veya mevcut bir projeyle çalışabilirsiniz:

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> Dün yapılan tüm değişikliklerin özetini ver
```

### Sonraki adımlar

- [Katkıda bulunmayı veya kaynaktan derlemeyi](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md) öğrenin.
- Kullanılabilir **[CLI Komutlarını](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)** keşfedin.
- Herhangi bir sorunla karşılaşırsanız, **[Sorun Giderme Kılavuzu](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**'nu inceleyin.
- Daha kapsamlı belgeler için [tam dokümantasyon](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md)'a bakın.
- Daha fazla ilham için bazı [popüler görevler](#populer-gorevler)'e göz atın.

### Sorun Giderme

Herhangi bir sorun yaşıyorsanız, [sorun giderme](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md) kılavuzuna göz atın.

## Popüler görevler

### Yeni bir kod tabanını keşfet

Var olan veya yeni klonlanan bir depoya `cd` ile geçin ve `gemini` komutunu çalıştırın.

```text
> Bu sistemin mimarisinin ana parçalarını açıkla.
```

```text
> Hangi güvenlik mekanizmaları mevcut?
```

### Mevcut kodunuzla çalışın

```text
> GitHub issue #123 için ilk taslağı uygula.
```

```text
> Bu kod tabanını en son Java sürümüne geçirmeme yardım et. Bir planla başla.
```

### İş akışlarınızı otomatikleştirin

Yerel sistem araçlarınızı kurumsal işbirliği paketinizle entegre etmek için MCP sunucularını kullanın.

```text
> Son 7 günün git geçmişini, özelliğe ve ekip üyesine göre gruplanmış şekilde gösteren bir sunum hazırla.
```

```text
> En çok etkileşim alan GitHub issue'larımızı gösteren tam ekran bir duvar ekranı web uygulaması yap.
```

### Sisteminizle etkileşim kurun

```text
> Bu dizindeki tüm görüntüleri png'ye dönüştür ve exif verisindeki tarihlerle yeniden adlandır.
```

```text
> PDF faturalarımı harcama ayına göre düzenle.
```

## Hizmet Şartları ve Gizlilik Bildirimi

Gemini CLI kullanımınız için geçerli hizmet şartları ve gizlilik bildirimiyle ilgili detaylar için [Hizmet Şartları ve Gizlilik Bildirimi](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md) sayfasına bakın.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---