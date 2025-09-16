
# mcp-chat

<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Flux159&project=mcp-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>

</div>

MCP sunucularını ve ajanlarını test etmek ve değerlendirmek için Açık Kaynak Genel MCP İstemcisi

<p align="center">
  <img width="600" src="https://raw.githubusercontent.com/Flux159/mcp-chat/refs/heads/main/mcpchat.svg">
</p>

## Hızlı Başlangıç

Ortamınızda veya projenin kök dizininde bir .env dosyasında `ANTHROPIC_API_KEY`'in dışa aktarılmış olduğundan emin olun. Bir API anahtarını [Anthropic Konsol anahtarları sayfası](https://console.anthropic.com/settings/keys) üzerinden kaydolarak edinebilirsiniz.

CLI üzerinden dosya sistemi MCP sunucusu ile etkileşimli bir sohbet istemi başlatan basit bir kullanım örneği:

```shell
npx mcp-chat --server "npx -y @modelcontextprotocol/server-filesystem /Users/$USER/Desktop"
```

Bu, sunucularla etkileşim kurmak ve bir LLM ile sohbet etmek için kullanabileceğiniz bir sohbet istemini açacaktır.

## Yapılandırma

Ayrıca sadece claude_desktop_config.json dosyanızı (Mac) belirtebilirsiniz:

```shell
npx mcp-chat --config "~/Library/Application Support/Claude/claude_desktop_config.json"
```

Veya (Windows):

```shell
npx mcp-chat --config "%APPDATA%\Claude\claude_desktop_config.json"
```

## Web mode

https://github.com/user-attachments/assets/b7e8a648-8084-4955-8cdf-fc6eb141572e

You can also run mcp-chat in web mode by specifying the `--web` flag (make sure to have `ANTHROPIC_API_KEY` exported in your environment):

```shell
npx mcp-chat --web
```

Web modunda, yeni sohbetler başlatabilir, modele mesaj gönderebilir ve mcp sunucularını dinamik olarak UI üzerinden yapılandırabilirsiniz - komut satırında belirtmeye gerek yoktur. Ayrıca, Web UI üzerinden oluşturulan sohbetler, CLI ile oluşturulan sohbetler gibi ~/.mcpchats/chats dizinine kaydedilir.

## Özellikler

- [x] CLI üzerinden etkileşimli modda çalıştırma veya doğrudan `-p` ile istem gönderebilme
- [x] Web arayüzü üzerinden modellerle sohbet edebilmek için web modu `--web`
- [x] Üretimde veya geliştirme sırasında herhangi bir MCP sunucusuna (JS, Python, Docker) bağlanabilme
- [x] Modeller arasında `-m` ile seçim yapabilme
- [x] Sistem istemini `--system` ile özelleştirebilme
- [x] Sohbet geçmişini ve ayarları web sohbetleri dahil `~/.mcpchat/chats` dizininde saklama
- [x] Komutları `~/.mcpchat/history` dizininde kaydedip geri yükleyebilme
- [x] mcp sunucularını hata ayıklamaya yardımcı olmak için araç çağrısı çıktısını ve argümanlarını doğrudan sohbette görüntüleyebilme

## CLI Kullanımı

CLI üzerinden `-p` bayrağı ile istemleri çalıştırabilirsiniz:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Bu, istemi kubernetes mcp-server ile çalıştırır ve yanıt stdout üzerinde alındıktan sonra çıkar.

CLI üzerinden sohbet etmek için `-m` bayrağı ile bir model seçin:

```shell
npx mcp-chat --server "npx mcp-server-kubernetes" -m "claude-3.5"
```

Model olarak sohbet etmek için `claude-3.5` kullanılır. Şu anda yalnızca Anthropic modelleri desteklenmektedir.

Özel sistem istemi:

Sistem istemini belirtmek için `--system` bayrağı kullanılabilir:

```shell
npx mcp-chat --system "Explain the output to the user in pirate speak." --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

## ENV değişkenleri

Mcp-chat, mcp sunucularına ortam değişkenlerinin iletilmesini destekler. Ancak bu, mcp spesifikasyonunda standartlaştırılmamıştır ve diğer istemciler dinamik ortam değişkeni değerleriyle bunu yapmayabilir - standart stdio mcp istemcileri hakkında daha fazla bilgi için [buradan](https://github.com/Flux159/mcp-server-kubernetes/issues/148#issuecomment-2950181666) okuyabilirsiniz.

```shell
KUBECONFIG="~/.kube/config" npx mcp-chat --server "npx mcp-server-kubernetes"
```

## mcp-server geliştiricileri için

Python veya node tabanlı bir mcp-server'ın yerel derlemesini mcp-chat ile test etmek için kullanabilirsiniz:

Node JS:

```shell
# Directly executing built script
npx mcp-chat --server "/path/to/mcp-server-kubernetes/dist/index.js"
# Using node / bun
npx mcp-chat --server "node /path/to/mcp-server-kubernetes/dist/index.js"
```

Python:

```shell
# Python: Using uv
npx mcp-chat --server "uv --directory /path/to/mcp-server-weather/ run weather.py"
# Using python / python3 - make sure to run in venv or install deps globally
npx mcp-chat --server "/path/to/mcp-server-weather/weather.py"
```

## Geliştirme

Bağımlılıkları yükleyin ve CLI'yi çalıştırın:

```shell
git clone https://github.com/Flux159/mcp-chat
bun install
bun run dev
```

mcp-chat'i bir mcp-server'a bağlanırken geliştirmek için, bir derleme yapın ve CLI'yi sunucu bayrağı ile çalıştırın:

```shell
npm run build && node dist/index.js --server "npx mcp-server-kubernetes" -p "List the pods in the default namespace"
```

Test ediliyor:

```shell
bun run test
```

Bina:

```shell
bun run build
```

Yayınlama:

```shell
bun run publish
```

Docker'ı Yayınlama:

```shell
bun run dockerbuild
```

### Proje Yapısı

```
├── src/
│   ├── index.ts            # Main client implementation & CLI params
│   ├── constants.ts        # Default constants
│   ├── interactive.ts      # Interactive chat prompt handling & logic
├── test/                   # Test files
│   ├── cli.test.ts         # Test CLI params
│   ├── config.test.ts      # Test config file parsing
```

## Yeni sürüm yayınlama

[releases](https://github.com/Flux159/mcp-chat/releases) sayfasına gidin, "Draft New Release" seçeneğine tıklayın, "Choose a tag" seçeneğine tıklayın ve yeni bir sürüm numarası yazarak "v{major}.{minor}.{patch}" semver formatında yeni bir etiket oluşturun. Ardından, bir sürüm başlığı olarak "Release v{major}.{minor}.{patch}" yazın ve gerekirse açıklama / değişiklik günlüğü girin ve "Publish Release" düğmesine tıklayın.

Bu, yeni bir etiket oluşturacak ve cd.yml iş akışı aracılığıyla yeni bir sürüm derlemesini tetikleyecektir. Başarılı olduğunda, yeni sürüm npm'ye yayınlanacaktır. Paket.json sürümünü manuel olarak güncellemenize gerek olmadığını unutmayın; iş akışı sürüm numarasını otomatik olarak package.json dosyasında güncelleyecek ve ana dala bir commit gönderecektir.

## Lisans

[MIT Lisansı](https://github.com/Flux159/mcp-chat/blob/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-16

---