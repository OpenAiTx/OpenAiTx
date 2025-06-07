# Prompt flow

[![Python package](https://img.shields.io/pypi/v/promptflow)](https://pypi.org/project/promptflow/)
[![Python](https://img.shields.io/pypi/pyversions/promptflow.svg?maxAge=2592000)](https://pypi.python.org/pypi/promptflow/)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/promptflow)](https://pypi.org/project/promptflow/)
[![CLI](https://img.shields.io/badge/CLI-reference-blue)](https://microsoft.github.io/promptflow/reference/pf-command-reference.html)
[![vsc extension](https://img.shields.io/visual-studio-marketplace/i/prompt-flow.prompt-flow?logo=Visual%20Studio&label=Extension%20)](https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow)

[![Doc](https://img.shields.io/badge/Doc-online-green)](https://microsoft.github.io/promptflow/index.html)
[![Issue](https://img.shields.io/github/issues/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![Discussions](https://img.shields.io/github/discussions/microsoft/promptflow)](https://github.com/microsoft/promptflow/issues/new/choose)
[![CONTRIBUTING](https://img.shields.io/badge/Contributing-8A2BE2)](https://github.com/microsoft/promptflow/blob/main/CONTRIBUTING.md)
[![License: MIT](https://img.shields.io/github/license/microsoft/promptflow)](https://github.com/microsoft/promptflow/blob/main/LICENSE)

> Prompt flow'u daha iyi hale getirmek için bize katılmaya,
> [tartışmalara](https://github.com/microsoft/promptflow/discussions) katılarak,
> [sorunlar](https://github.com/microsoft/promptflow/issues/new/choose) açarak,
> [PR'lar](https://github.com/microsoft/promptflow/pulls) göndererek katkıda bulunabilirsiniz.

**Prompt flow**, LLM tabanlı yapay zeka uygulamalarının fikir aşamasından prototipleme, test, değerlendirme, üretime alma ve izlemeye kadar olan uçtan uca geliştirme döngüsünü kolaylaştırmak için tasarlanmış bir geliştirme araçları paketidir. Prompt mühendisliğini çok daha kolay hale getirir ve üretim kalitesinde LLM uygulamaları oluşturmanızı sağlar.

Prompt flow ile şunları yapabilirsiniz:

- **Akış oluşturun ve iteratif olarak geliştirin**
    - LLM'leri, promptları, Python kodunu ve diğer [araçları](https://microsoft.github.io/promptflow/concepts/concept-tools.html) birbirine bağlayan çalıştırılabilir [akışlar](https://microsoft.github.io/promptflow/concepts/concept-flows.html) oluşturun.
    - Özellikle [LLM'lerle etkileşimin izini sürerek](https://microsoft.github.io/promptflow/how-to-guides/tracing/index.html) akışlarınızı kolayca hata ayıklayın ve yineleyin.
- **Akış kalitesini ve performansını değerlendirin**
    - Akışınızın kalitesini ve performansını daha büyük veri setleriyle değerlendirin.
    - Test ve değerlendirmeyi CI/CD sisteminize entegre ederek akışınızın kalitesini garanti altına alın.
- **Üretim için kolaylaştırılmış geliştirme döngüsü**
    - Akışınızı seçtiğiniz servis platformuna dağıtın veya uygulamanızın kod tabanına kolayca entegre edin.
    - (Opsiyonel fakat şiddetle önerilir) [Azure AI'da Prompt flow'un bulut versiyonunu](https://learn.microsoft.com/en-us/azure/machine-learning/prompt-flow/overview-what-is-prompt-flow?view=azureml-api-2) kullanarak ekibinizle iş birliği yapın.

------

## Kurulum

Hızlıca başlamak için önceden hazırlanmış bir geliştirme ortamı kullanabilirsiniz. **Aşağıdaki butona tıklayarak** repoyu GitHub Codespaces'te açabilir ve ardından readme'yi takip edebilirsiniz!

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/microsoft/promptflow?quickstart=1)

Kendi yerel ortamınızda başlamak isterseniz, önce paketleri kurun:

Bir python ortamınızın olduğundan emin olun, `python>=3.9, <=3.11` önerilir.

```sh
pip install promptflow promptflow-tools
```

## Hızlı Başlangıç ⚡

**Prompt flow ile bir sohbet botu oluşturun**

Bir sohbet şablonundan prompt flow başlatmak için komutu çalıştırın, `my_chatbot` adında bir klasör oluşturur ve gerekli dosyaları içine yerleştirir:

```sh
pf flow init --flow ./my_chatbot --type chat
```

**API anahtarınız için bir bağlantı yapılandırın**

OpenAI anahtarı için, `my_chatbot` klasöründeki `openai.yaml` dosyasını kullanarak bağlantı kurmak için komutu çalıştırın (yaml dosyasını değiştirmemek için anahtarları ve ismi --set ile geçersiz kılabilirsiniz):

```sh
pf connection create --file ./my_chatbot/openai.yaml --set api_key=<your_api_key> --name open_ai_connection
```

Azure OpenAI anahtarı için, `azure_openai.yaml` dosyasını kullanarak bağlantıyı kurmak için komutu çalıştırın:

```sh
pf connection create --file ./my_chatbot/azure_openai.yaml --set api_key=<your_api_key> api_base=<your_api_base> --name open_ai_connection
```

**Akışınız ile sohbet edin**

`my_chatbot` klasöründe, giriş/çıkışlar, düğümler, bağlantı ve LLM modeli dahil olmak üzere akışı özetleyen `flow.dag.yaml` dosyası bulunur.

> Not: `chat` düğümünde, `open_ai_connection` adında bir bağlantı (connection alanında belirtilmiş) ve `gpt-35-turbo` modeli (deployment_name alanında belirtilmiş) kullanıyoruz. deployment_name alanı, OpenAI modeli veya Azure OpenAI dağıtım kaynağını belirtmek içindir.

Şu komutla sohbet botunuzla etkileşime geçin: (oturumu bitirmek için `Ctrl + C` tuşlarına basın)

```sh
pf flow test --flow ./my_chatbot --interactive
```

**Temel değer: Prototipten üretime “Yüksek Kalite” sağlamak**

Prompt ayarlama ➡ toplu test ➡ değerlendirme adımlarında size rehberlik eden [**15 dakikalık eğitimimizi**](https://raw.githubusercontent.com/microsoft/promptflow/main/examples/tutorials/flow-fine-tuning-evaluation/promptflow-quality-improvement.md) keşfedin; bunların hepsi üretime hazır yüksek kaliteyi sağlamak için tasarlanmıştır.

Sonraki Adım! Prompt flow'u daha derinlemesine öğrenmek için **Eğitim**  👇 bölümüne devam edin.

## Eğitim 🏃‍♂️

Prompt flow, **yüksek kaliteli LLM uygulamaları oluşturmak** için tasarlanmış bir araçtır. Prompt flow'daki geliştirme süreci şu adımları takip eder: bir akış geliştir, akış kalitesini artır, akışı üretime dağıt.

### Kendi LLM uygulamalarınızı geliştirin

#### VS Code Eklentisi

Etkileşimli bir akış geliştirme deneyimi için (akış tasarımcısı olarak) bir VS Code eklentisi de sunuyoruz.

<img src="https://raw.githubusercontent.com/microsoft/promptflow/main/docs/media/readme/vsc.png" alt="vsc" width="1000"/>

Bunu <a href="https://marketplace.visualstudio.com/items?itemName=prompt-flow.prompt-flow">visualstudio marketplace</a>'ten yükleyebilirsiniz.

#### Akış geliştirmede derinlemesine inceleme

[Prompt flow ile başlarken](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/how-to-guides/quick-start.md): İlk akış çalıştırmanızı başlatmak için adım adım rehberlik.

### Kullanım örneklerinden öğrenin

[Eğitim: PDF ile Sohbet](https://github.com/microsoft/promptflow/blob/main/examples/tutorials/e2e-development/chat-with-pdf.md): Prompt flow ile yüksek kaliteli bir sohbet uygulamasının nasıl oluşturulacağına dair uçtan uca bir eğitim; akış geliştirme ve metriklerle değerlendirme dahil.
> Daha fazla örneğe [buradan](https://microsoft.github.io/promptflow/tutorials/index.html#samples) ulaşabilirsiniz. Yeni kullanım örnekleri katkılarını memnuniyetle karşılıyoruz!

### Katkıda bulunmak için kurulum

Katkıda bulunmakla ilgileniyorsanız, lütfen geliştirici kurulum rehberimizle başlayın: [dev_setup.md](https://raw.githubusercontent.com/microsoft/promptflow/main/docs/dev/dev_setup.md).

Sonraki Adım! Prompt flow'a katkı sağlamak için **Katkıda Bulunma**  👇 bölümüne devam edin.

## Katkıda Bulunma

Bu proje katkıları ve önerileri memnuniyetle karşılar. Çoğu katkı için,
bize katkınızı kullanma hakkı verdiğinizi belirten bir
Katılımcı Lisans Sözleşmesi’ni (CLA) kabul etmeniz gerekmektedir.
Detaylar için https://cla.opensource.microsoft.com adresini ziyaret edin.

Bir pull request gönderdiğinizde, bir CLA botu otomatik olarak bir CLA gerekip gerekmediğini belirler ve PR'ı uygun şekilde işaretler (örneğin, durum kontrolü, yorum). Bot tarafından sağlanan talimatları uygulamanız yeterlidir. Tüm depolarda yalnızca bir kez bunu yapmanız gerekecektir.

Bu proje [Microsoft Açık Kaynak Davranış Kuralları](https://opensource.microsoft.com/codeofconduct/)’nı benimsemiştir.
Daha fazla bilgi için [Davranış Kuralları SSS](https://opensource.microsoft.com/codeofconduct/faq/) veya
ek sorularınız veya yorumlarınız için [opencode@microsoft.com](mailto:opencode@microsoft.com) ile iletişime geçin.

## Ticari Markalar

Bu proje, projeler, ürünler veya hizmetler için ticari markalar veya logolar içerebilir. Microsoft ticari markalarının veya logolarının yetkili kullanımı, [Microsoft Ticari Marka & Marka Rehberi](https://www.microsoft.com/en-us/legal/intellectualproperty/trademarks/usage/general)’ne tabi olmalı ve bu kurallara uymalıdır.
Microsoft ticari markalarının veya logolarının bu projenin değiştirilmiş sürümlerinde kullanılması, karışıklığa neden olmamalı veya Microsoft sponsorluğunu ima etmemelidir.
Üçüncü şahıs ticari markalarının veya logolarının her türlü kullanımı, ilgili üçüncü şahıs politikalarına tabidir.

## Davranış Kuralları

Bu proje,
[Microsoft Açık Kaynak Davranış Kuralları](https://opensource.microsoft.com/codeofconduct/)'nı benimsemiştir.
Daha fazla bilgi için
[Davranış Kuralları SSS](https://opensource.microsoft.com/codeofconduct/faq/)’ye bakabilir veya
ek sorularınız veya yorumlarınız için [opencode@microsoft.com](mailto:opencode@microsoft.com)
adresine e-posta gönderebilirsiniz.

## Veri Toplama

Yazılım, yapılandırılmışsa siz ve yazılımı kullanımınız hakkında bilgi toplayabilir ve Microsoft’a gönderebilir.
Microsoft, bu bilgileri hizmet sağlamak ve ürünlerimizi/hizmetlerimizi geliştirmek için kullanabilir.
Telemetriyi açmak için depo içinde anlatıldığı şekilde devam edebilirsiniz.
Yazılımda, siz ve Microsoft’un uygulamanızın kullanıcılarından veri toplamasına olanak tanıyan bazı özellikler de bulunabilir. Bu özellikleri kullanırsanız,
uygulamanızın kullanıcılarına uygun bildirimleri sağlamak ve Microsoft’un gizlilik bildirisinin bir kopyası ile birlikte yürürlükteki yasalara uymak zorundasınız.
Gizlilik bildirimimize https://go.microsoft.com/fwlink/?LinkID=824704 adresinden ulaşabilirsiniz. Veri
toplama ve kullanımı hakkında yardım belgelerinde ve gizlilik bildirimimizde daha fazla bilgi edinebilirsiniz. Yazılımı kullanmanız, bu uygulamalara onay verdiğiniz anlamına gelir.

### Telemetri Yapılandırması

Telemetri toplama varsayılan olarak açıktır.

Kapatmak için, `pf config set telemetry.enabled=false` komutunu çalıştırarak devre dışı bırakabilirsiniz.

## Lisans

Telif hakkı (c) Microsoft Corporation. Tüm hakları saklıdır.

[MIT](LICENSE) lisansı ile lisanslanmıştır.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---