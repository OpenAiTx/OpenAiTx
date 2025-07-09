# LlamaIndex İş Akışları

[![Birim Testi](https://github.com/run-llama/workflows/actions/workflows/test.yml/badge.svg)](https://github.com/run-llama/workflows/actions/workflows/test.yml)
[![Kapsam Durumu](https://coveralls.io/repos/github/run-llama/workflows/badge.svg?branch=main)](https://coveralls.io/github/run-llama/workflows?branch=main)
[![GitHub katkıda bulunanlar](https://img.shields.io/github/contributors/run-llama/workflows)](https://github.com/run-llama/llama-index-workflows/graphs/contributors)


[![PyPI - İndirmeler](https://img.shields.io/pypi/dm/llama-index-workflows)](https://pypi.org/project/llama-index-workflows/)
[![Discord](https://img.shields.io/discord/1059199217496772688)](https://discord.gg/dGcwcsnxhU)
[![Twitter](https://img.shields.io/twitter/follow/llama_index)](https://x.com/llama_index)
[![Reddit](https://img.shields.io/reddit/subreddit-subscribers/LlamaIndex?style=plastic&logo=reddit&label=r%2FLlamaIndex&labelColor=white)](https://www.reddit.com/r/LlamaIndex/)

LlamaIndex İş Akışları, adım ve olaylardan oluşan karmaşık sistemleri orkestre etmek ve zincirlemek için bir çerçevedir.

## İş Akışları ile Neler İnşa Edebilirsiniz?

İş Akışları, yapay zeka modelleri, API'ler ve karar mekanizmalarını içeren karmaşık, çok adımlı süreçleri orkestre etmeniz gerektiğinde öne çıkar. İşte inşa edebileceğiniz bazı örnekler:

- **Yapay Zeka Ajanları** - Birden fazla adımda mantık yürütebilen, karar verebilen ve eyleme geçebilen akıllı sistemler oluşturun
- **Belge İşleme Hatları** - Belgeleri çeşitli işleme aşamalarından geçirerek içe aktaran, analiz eden, özetleyen ve yönlendiren sistemler kurun
- **Çoklu Model Yapay Zeka Uygulamaları** - Farklı yapay zeka modelleri (LLM'ler, görsel modeller, vb.) arasında koordinasyon sağlayarak karmaşık görevleri çözün
- **Araştırma Asistanları** - Bilgi arayabilen, analiz edebilen, sentezleyebilen ve kapsamlı yanıtlar sunabilen iş akışları geliştirin
- **İçerik Üretim Sistemleri** - İnsan onaylı, üreten, gözden geçiren, düzenleyen ve yayımlayan içerik hatları oluşturun
- **Müşteri Desteği Otomasyonu** - Müşteri taleplerini anlayabilen, kategorize edebilen ve yanıtlayabilen akıllı yönlendirme sistemleri inşa edin

Async-öncelikli, olay tabanlı mimarisi sayesinde farklı yetenekler arasında yönlendirme yapabilen, paralel işleme desenlerini uygulayabilen, karmaşık diziler üzerinde döngü kurabilen ve birden fazla adım boyunca durumu koruyabilen iş akışlarını kolayca inşa edebilirsiniz - yapay zeka uygulamalarınızı üretime hazır hale getirmek için ihtiyaç duyduğunuz tüm özellikler.
## Temel Özellikler

- **async-first** - iş akışları Python'un async fonksiyonalitesi etrafında inşa edilmiştir - adımlar, bir asyncio kuyruğundan gelen olayları işleyen ve diğer kuyruklara yeni olaylar gönderen async fonksiyonlardır. Bu aynı zamanda iş akışlarının FastAPI, Jupyter Notebooks gibi async uygulamalarınızda en iyi şekilde çalışacağı anlamına gelir.
- **olay tabanlı** - iş akışları adımlar ve olaylardan oluşur. Kodunuzu olaylar ve adımlar etrafında organize etmek, onu anlamayı ve test etmeyi kolaylaştırır.
- **durum yönetimi** - bir iş akışının her çalıştırılması kendi içinde bağımsızdır, yani bir iş akışı başlatabilir, içinde bilgi kaydedebilir, iş akışının durumunu serileştirip daha sonra devam ettirebilirsiniz.
- **gözlemlenebilirlik** - iş akışları otomatik olarak gözlemlenebilirlik için enstrümante edilir, yani `Arize Phoenix` ve `OpenTelemetry` gibi araçları kutudan çıktığı gibi kullanabilirsiniz.

## Hızlı Başlangıç

Paketi yükleyin:

```bash
pip install llama-index-workflows
```

Ve ilk iş akışınızı oluşturun:

```python
import asyncio
from pydantic import BaseModel, Field
from workflows import Context, Workflow, step
from workflows.events import Event, StartEvent, StopEvent

class MyEvent(Event):
    msg: list[str]

class RunState(BaseModel):
    num_runs: int = Field(default=0)

class MyWorkflow(Workflow):
    @step
    async def start(self, ctx: Context[RunState], ev: StartEvent) -> MyEvent:
        async with ctx.store.edit_state() as state:
            state.num_runs += 1

            return MyEvent(msg=[ev.input_msg] * state.num_runs)

    @step
    async def process(self, ctx: Context[RunState], ev: MyEvent) -> StopEvent:
        data_length = len("".join(ev.msg))
        new_msg = f"Processed {len(ev.msg)} times, data length: {data_length}"
        return StopEvent(result=new_msg)

async def main():
    workflow = MyWorkflow()
```
```
# [isteğe bağlı] iş akışına bir bağlam nesnesi sağlayın
ctx = Context(workflow)
result = await workflow.run(input_msg="Merhaba, dünya!", ctx=ctx)
print("İş akışı sonucu:", result)

# Aynı bağlam ile tekrar çalıştırmak durumu koruyacaktır
result = await workflow.run(input_msg="Merhaba, dünya!", ctx=ctx)
print("İş akışı sonucu:", result)

if __name__ == "__main__":
    asyncio.run(main())
```

Yukarıdaki örnekte
- `StartEvent` kabul eden adımlar önce çalıştırılır.
- `StopEvent` döndüren adımlar iş akışını sonlandırır.
- Ara olaylar kullanıcı tarafından tanımlanır ve adımlar arasında bilgi aktarmak için kullanılabilir.
- `Context` nesnesi de adımlar arasında bilgi paylaşmak için kullanılır.

`llama-index` ile ilgili daha fazla örnek için [tam dokümantasyonu](https://docs.llamaindex.ai/en/stable/understanding/workflows/) ziyaret edin!

## Daha Fazla Örnek

- [Temel Özelliklerin Tanıtımı](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/feature_walkthrough.ipynb)
- [`llama-index` ile Fonksiyon Çağıran Bir Ajan Oluşturma](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/agent.ipynb)
- İnsan-Döngüsünde Artımlı Doküman Çıkarma  
  (Human-in-the-loop Iterative Document Extraction)
  - [Açık Telemetri + Enstrümantasyon Giriş](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt1.ipynb)
  - [Açık Telemetri + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observability_pt2.ipynb)
  - [Arize Phoenix + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_arize_phoenix.ipynb)
  - [Langfuse + LlamaIndex](https://raw.githubusercontent.com/run-llama/workflows-py/main/./examples/observability/workflows_observablitiy_langfuse.ipynb)

## İlgili Paketler

- [Typescript Workflows](https://github.com/run-llama/workflows-ts)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---