<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="LangChain Logosu" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![Sürüm Notları](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - Lisans](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - İndirme](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![GitHub yıldız grafiği](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![Açık Sorunlar](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Dev Containers'da Aç](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="Github Codespace'te Aç" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed Rozeti](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!NOTE]
> JS/TS kütüphanesini mi arıyorsunuz? [LangChain.js](https://github.com/langchain-ai/langchainjs) adresine göz atın.

LangChain, LLM destekli uygulamalar oluşturmak için bir çerçevedir. Birbirleriyle uyumlu bileşenleri ve üçüncü parti entegrasyonları zincirleme yoluyla AI uygulama geliştirmeyi basitleştirir — ve temel teknolojiler geliştikçe kararlarınızı geleceğe hazırlar.

```bash
pip install -U langchain
```

LangChain hakkında daha fazla bilgi edinmek için
[belgelere](https://python.langchain.com/docs/introduction/) göz atabilirsiniz. Daha gelişmiş özelleştirme veya ajan orkestrasyonu arıyorsanız,
[LangGraph](https://langchain-ai.github.io/langgraph/), kontrol edilebilir ajan iş akışları oluşturmak için çerçevemizi inceleyebilirsiniz.

## Neden LangChain kullanmalısınız?

LangChain, geliştiricilere modeller, gömüler, vektör depoları ve daha fazlası için standart bir arayüz sunarak LLM destekli uygulamalar geliştirmelerinde yardımcı olur.

LangChain'i şu amaçlarla kullanabilirsiniz:
- **Gerçek zamanlı veri artırımı**. LLM'leri çeşitli veri kaynaklarına ve harici / dahili sistemlere kolayca bağlayın; LangChain’in, model sağlayıcıları, araçlar, vektör depoları, getiriciler ve daha fazlası ile entegrasyon sağlayan geniş kütüphanesinden yararlanın.
- **Model birlikte çalışabilirliği**. Mühendislik ekibiniz uygulamanızın gereksinimleri için en iyi seçeneği bulmak üzere modelleri kolayca değiştirip deney yapabilir. Sektör geliştikçe hızlıca uyum sağlayın — LangChain’in soyutlamalarıyla hızınızı kaybetmeden ilerleyin.

## LangChain ekosistemi
LangChain çerçevesi tek başına kullanılabilse de, herhangi bir LangChain ürünüyle de sorunsuz şekilde entegre olarak geliştiricilere LLM uygulamaları oluştururken tam bir araç seti sunar.

LLM uygulama geliştirmelerinizi geliştirmek için LangChain'i şunlarla eşleştirin:

- [LangSmith](http://www.langchain.com/langsmith) - Ajan değerlendirmeleri ve gözlemlenebilirlik için faydalıdır. Kötü performans gösteren LLM uygulama çalışmalarını hata ayıklayın, ajan yollarını değerlendirin, üretimde görünürlük kazanın ve zamanla performansı artırın.
- [LangGraph](https://langchain-ai.github.io/langgraph/) - Düşük seviyeli ajan orkestrasyon çerçevemiz LangGraph ile karmaşık görevleri güvenilir şekilde yerine getirebilen ajanlar oluşturun. LangGraph, özelleştirilebilir mimari, uzun vadeli hafıza ve insan-döngüsünde iş akışları sunar — ve LinkedIn, Uber, Klarna ve GitLab gibi şirketler tarafından üretimde güvenle kullanılır.
- [LangGraph Platformu](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - Uzun süre çalışan, durum bilgisine sahip iş akışları için özel olarak tasarlanmış dağıtım platformu ile ajanları zahmetsizce dağıtın ve ölçeklendirin. Takımlar arasında ajanları keşfedin, tekrar kullanın, yapılandırın ve paylaşın — ve [LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/)’da görsel prototipleme ile hızlıca yineleyin.

## Ek kaynaklar
- [Eğitimler](https://python.langchain.com/docs/tutorials/): LangChain ile başlamanıza yardımcı olan, örneklerle yönlendirilmiş basit anlatımlar.
- [Nasıl Yapılır Kılavuzları](https://python.langchain.com/docs/how_to/): Araç çağırma, RAG kullanım senaryoları gibi konular için hızlı ve uygulanabilir kod örnekleri.
- [Kavramsal Kılavuzlar](https://python.langchain.com/docs/concepts/): LangChain çerçevesinin arkasındaki ana kavramların açıklamaları.
- [API Referansı](https://python.langchain.com/api_reference/): LangChain’in temel paketleri ve entegrasyonlarında gezinme hakkında ayrıntılı referans.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---