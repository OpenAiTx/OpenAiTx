<!---
Copyright 2020 The HuggingFace Team. Todos os direitos reservados.

Licenciado sob a Licença Apache, Versão 2.0 (a "Licença");
você não pode usar este arquivo exceto em conformidade com a Licença.
Você pode obter uma cópia da Licença em

    http://www.apache.org/licenses/LICENSE-2.0

A menos que exigido pela legislação aplicável ou acordado por escrito, o software
distribuído sob a Licença é distribuído "COMO ESTÁ",
SEM GARANTIAS OU CONDIÇÕES DE QUALQUER TIPO, expressas ou implícitas.
Veja a Licença para a linguagem específica que rege permissões e
limitações sob a Licença.
-->

<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-dark.svg">
    <source media="(prefers-color-scheme: light)" srcset="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg">
    <img alt="Hugging Face Transformers Library" src="https://huggingface.co/datasets/huggingface/documentation-images/raw/main/transformers-logo-light.svg" width="352" height="59" style="max-width: 100%;">
  </picture>
  <br/>
  <br/>
</p>

<p align="center">
    <a href="https://huggingface.com/models"><img alt="Checkpoints no Hub" src="https://img.shields.io/endpoint?url=https://huggingface.co/api/shields/models&color=brightgreen"></a>
    <a href="https://circleci.com/gh/huggingface/transformers"><img alt="Build" src="https://img.shields.io/circleci/build/github/huggingface/transformers/main"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/LICENSE"><img alt="GitHub" src="https://img.shields.io/github/license/huggingface/transformers.svg?color=blue"></a>
    <a href="https://huggingface.co/docs/transformers/index"><img alt="Documentação" src="https://img.shields.io/website/http/huggingface.co/docs/transformers/index.svg?down_color=red&down_message=offline&up_message=online"></a>
    <a href="https://github.com/huggingface/transformers/releases"><img alt="GitHub release" src="https://img.shields.io/github/release/huggingface/transformers.svg"></a>
    <a href="https://github.com/huggingface/transformers/blob/main/CODE_OF_CONDUCT.md"><img alt="Contributor Covenant" src="https://img.shields.io/badge/Contributor%20Covenant-v2.0%20adopted-ff69b4.svg"></a>
    <a href="https://zenodo.org/badge/latestdoi/155220641"><img src="https://zenodo.org/badge/155220641.svg" alt="DOI"></a>
</p>

<h4 align="center">
    <p>
        <b>English</b> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hans.md">简体中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_zh-hant.md">繁體中文</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ko.md">한국어</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_es.md">Español</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ja.md">日本語</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_hd.md">हिन्दी</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ru.md">Русский</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_pt-br.md">Рortuguês</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_te.md">తెలుగు</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_fr.md">Français</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_de.md">Deutsch</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_vi.md">Tiếng Việt</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ar.md">العربية</a> |
        <a href="https://github.com/huggingface/transformers/blob/main/i18n/README_ur.md">اردو</a> |
    </p>
</h4>

<h3 align="center">
    <p>Modelos pré-treinados de última geração para inferência e treinamento</p>
</h3>

<h3 align="center">
    <a href="https://hf.co/course"><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/course_banner.png"></a>
</h3>

Transformers é uma biblioteca de modelos pré-treinados de texto, visão computacional, áudio, vídeo e multimodais para inferência e treinamento. Use o Transformers para ajustar modelos aos seus dados, construir aplicações de inferência e para casos de uso de IA generativa em múltiplas modalidades.

Existem mais de 500 mil [checkpoints de modelos](https://huggingface.co/models?library=transformers&sort=trending) do Transformers no [Hugging Face Hub](https://huggingface.com/models) que você pode utilizar.

Explore o [Hub](https://huggingface.com/) hoje para encontrar um modelo e usar o Transformers para começar imediatamente.

## Instalação

O Transformers funciona com Python 3.9+, [PyTorch](https://pytorch.org/get-started/locally/) 2.1+, [TensorFlow](https://www.tensorflow.org/install/pip) 2.6+ e [Flax](https://flax.readthedocs.io/en/latest/) 0.4.1+.

Crie e ative um ambiente virtual com [venv](https://docs.python.org/3/library/venv.html) ou [uv](https://docs.astral.sh/uv/), um rápido gerenciador de pacotes e projetos Python baseado em Rust.

```py
# venv
python -m venv .my-env
source .my-env/bin/activate
# uv
uv venv .my-env
source .my-env/bin/activate
```

Instale o Transformers no seu ambiente virtual.

```py
# pip
pip install "transformers[torch]"

# uv
uv pip install "transformers[torch]"
```

Instale o Transformers a partir do código-fonte caso queira as últimas atualizações da biblioteca ou esteja interessado em contribuir. Entretanto, a versão *mais recente* pode não ser estável. Sinta-se à vontade para abrir um [issue](https://github.com/huggingface/transformers/issues) caso encontre algum erro.

```shell
git clone https://github.com/huggingface/transformers.git
cd transformers

# pip
pip install .[torch]

# uv
uv pip install .[torch]
```

## Início Rápido

Comece a usar o Transformers imediatamente com a API [Pipeline](https://huggingface.co/docs/transformers/pipeline_tutorial). O `Pipeline` é uma classe de inferência de alto nível que suporta tarefas de texto, áudio, visão e multimodais. Ele faz o pré-processamento da entrada e retorna a saída apropriada.

Instancie um pipeline e especifique o modelo a ser usado para geração de texto. O modelo é baixado e cacheado para que você possa reutilizá-lo facilmente. Por fim, forneça um texto para instruir o modelo.

```py
from transformers import pipeline

pipeline = pipeline(task="text-generation", model="Qwen/Qwen2.5-1.5B")
pipeline("the secret to baking a really good cake is ")
[{'generated_text': 'the secret to baking a really good cake is 1) to use the right ingredients and 2) to follow the recipe exactly. the recipe for the cake is as follows: 1 cup of sugar, 1 cup of flour, 1 cup of milk, 1 cup of butter, 1 cup of eggs, 1 cup of chocolate chips. if you want to make 2 cakes, how much sugar do you need? To make 2 cakes, you will need 2 cups of sugar.'}]
```

Para conversar com um modelo, o padrão de uso é o mesmo. A única diferença é que você precisa construir um histórico de conversa (a entrada para o `Pipeline`) entre você e o sistema.

> [!DICA]
> Você também pode conversar com um modelo diretamente pela linha de comando.
> ```shell
> transformers chat Qwen/Qwen2.5-0.5B-Instruct
> ```

```py
import torch
from transformers import pipeline

chat = [
    {"role": "system", "content": "Você é um robô irreverente e sarcástico, como imaginado por Hollywood em 1986."},
    {"role": "user", "content": "Ei, você pode me indicar coisas divertidas para fazer em Nova York?"}
]

pipeline = pipeline(task="text-generation", model="meta-llama/Meta-Llama-3-8B-Instruct", torch_dtype=torch.bfloat16, device_map="auto")
response = pipeline(chat, max_new_tokens=512)
print(response[0]["generated_text"][-1]["content"])
```

Expanda os exemplos abaixo para ver como o `Pipeline` funciona para diferentes modalidades e tarefas.

<details>
<summary>Reconhecimento automático de fala</summary>

```py
from transformers import pipeline

pipeline = pipeline(task="automatic-speech-recognition", model="openai/whisper-large-v3")
pipeline("https://huggingface.co/datasets/Narsil/asr_dummy/resolve/main/mlk.flac")
{'text': ' I have a dream that one day this nation will rise up and live out the true meaning of its creed.'}
```

</details>

<details>
<summary>Classificação de imagens</summary>

<h3 align="center">
    <a><img src="https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="image-classification", model="facebook/dinov2-small-imagenet1k-1-layer")
pipeline("https://huggingface.co/datasets/Narsil/image_dummy/raw/main/parrots.png")
[{'label': 'macaw', 'score': 0.997848391532898},
 {'label': 'sulphur-crested cockatoo, Kakatoe galerita, Cacatua galerita',
  'score': 0.0016551691805943847},
 {'label': 'lorikeet', 'score': 0.00018523589824326336},
 {'label': 'African grey, African gray, Psittacus erithacus',
  'score': 7.85409429227002e-05},
 {'label': 'quail', 'score': 5.502637941390276e-05}]
```

</details>

<details>
<summary>Resposta visual a perguntas</summary>


<h3 align="center">
    <a><img src="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg"></a>
</h3>

```py
from transformers import pipeline

pipeline = pipeline(task="visual-question-answering", model="Salesforce/blip-vqa-base")
pipeline(
    image="https://huggingface.co/datasets/huggingface/documentation-images/resolve/main/transformers/tasks/idefics-few-shot.jpg",
    question="O que há na imagem?",
)
[{'answer': 'statue of liberty'}]
```

</details>

## Por que devo usar o Transformers?

1. Modelos de última geração fáceis de usar:
    - Alto desempenho em tarefas de entendimento e geração de linguagem natural, visão computacional, áudio, vídeo e multimodais.
    - Baixa barreira de entrada para pesquisadores, engenheiros e desenvolvedores.
    - Poucas abstrações voltadas para o usuário, com apenas três classes para aprender.
    - Uma API unificada para usar todos os nossos modelos pré-treinados.

1. Reduza custos computacionais e pegada de carbono:
    - Compartilhe modelos treinados ao invés de treinar do zero.
    - Reduza o tempo computacional e custos de produção.
    - Dezenas de arquiteturas de modelos com mais de 1 milhão de checkpoints pré-treinados em todas as modalidades.

1. Escolha o framework certo para cada etapa do ciclo de vida do modelo:
    - Treine modelos de última geração em 3 linhas de código.
    - Mova um único modelo entre os frameworks PyTorch/JAX/TF2.0 quando quiser.
    - Escolha o framework certo para treinamento, avaliação e produção.

1. Personalize facilmente um modelo ou um exemplo para suas necessidades:
    - Fornecemos exemplos para cada arquitetura para reproduzir os resultados publicados pelos autores originais.
    - Os internos dos modelos são expostos de forma tão consistente quanto possível.
    - Os arquivos dos modelos podem ser usados independentemente da biblioteca para experimentos rápidos.

<a target="_blank" href="https://huggingface.co/enterprise">
    <img alt="Hugging Face Enterprise Hub" src="https://github.com/user-attachments/assets/247fb16d-d251-4583-96c4-d3d76dda4925">
</a><br>

## Por que não devo usar o Transformers?

- Esta biblioteca não é uma caixa de ferramentas modular de blocos de construção para redes neurais. O código nos arquivos de modelos não foi refatorado com abstrações adicionais de propósito, para que pesquisadores possam iterar rapidamente em cada modelo sem precisar lidar com abstrações/arquivos extras.
- A API de treinamento é otimizada para funcionar com modelos PyTorch fornecidos pelo Transformers. Para laços genéricos de machine learning, você deve usar outra biblioteca como a [Accelerate](https://huggingface.co/docs/accelerate).
- Os [scripts de exemplo]((https://github.com/huggingface/transformers/tree/main/examples)) são apenas *exemplos*. Eles podem não funcionar imediatamente para o seu caso de uso específico e você terá que adaptar o código.

## 100 projetos usando Transformers

Transformers é mais do que uma caixa de ferramentas para usar modelos pré-treinados, é uma comunidade de projetos construída ao redor dele e do
Hugging Face Hub. Queremos que o Transformers permita que desenvolvedores, pesquisadores, estudantes, professores, engenheiros e qualquer
outra pessoa construa os projetos dos seus sonhos.

Para comemorar as 100.000 estrelas do Transformers, queremos dar destaque à
comunidade com a página [awesome-transformers](./awesome-transformers.md) que lista 100
projetos incríveis construídos com Transformers.

Se você possui ou usa um projeto que acredita que deveria fazer parte da lista, por favor abra um PR para adicioná-lo!

## Exemplos de modelos

Você pode testar a maioria dos nossos modelos diretamente nas suas [páginas de modelos no Hub](https://huggingface.co/models).

Expanda cada modalidade abaixo para ver alguns exemplos de modelos para vários casos de uso.

<details>
<summary>Áudio</summary>

- Classificação de áudio com [Whisper](https://huggingface.co/openai/whisper-large-v3-turbo)
- Reconhecimento automático de fala com [Moonshine](https://huggingface.co/UsefulSensors/moonshine)
- Detecção de palavras-chave com [Wav2Vec2](https://huggingface.co/superb/wav2vec2-base-superb-ks)
- Geração de fala para fala com [Moshi](https://huggingface.co/kyutai/moshiko-pytorch-bf16)
- Texto para áudio com [MusicGen](https://huggingface.co/facebook/musicgen-large)
- Texto para fala com [Bark](https://huggingface.co/suno/bark)

</details>

<details>
<summary>Visão computacional</summary>

- Geração automática de máscaras com [SAM](https://huggingface.co/facebook/sam-vit-base)
- Estimativa de profundidade com [DepthPro](https://huggingface.co/apple/DepthPro-hf)
- Classificação de imagens com [DINO v2](https://huggingface.co/facebook/dinov2-base)
- Detecção de pontos chave com [SuperGlue](https://huggingface.co/magic-leap-community/superglue_outdoor)
- Correspondência de pontos chave com [SuperGlue](https://huggingface.co/magic-leap-community/superglue)
- Detecção de objetos com [RT-DETRv2](https://huggingface.co/PekingU/rtdetr_v2_r50vd)
- Estimativa de pose com [VitPose](https://huggingface.co/usyd-community/vitpose-base-simple)
- Segmentação universal com [OneFormer](https://huggingface.co/shi-labs/oneformer_ade20k_swin_large)
- Classificação de vídeo com [VideoMAE](https://huggingface.co/MCG-NJU/videomae-large)

</details>

<details>
<summary>Multimodal</summary>

- Áudio ou texto para texto com [Qwen2-Audio](https://huggingface.co/Qwen/Qwen2-Audio-7B)
- Perguntas e respostas em documentos com [LayoutLMv3](https://huggingface.co/microsoft/layoutlmv3-base)
- Imagem ou texto para texto com [Qwen-VL](https://huggingface.co/Qwen/Qwen2.5-VL-3B-Instruct)
- Legenda de imagens com [BLIP-2](https://huggingface.co/Salesforce/blip2-opt-2.7b)
- Compreensão de documentos baseada em OCR com [GOT-OCR2](https://huggingface.co/stepfun-ai/GOT-OCR-2.0-hf)
- Perguntas e respostas em tabelas com [TAPAS](https://huggingface.co/google/tapas-base)
- Compreensão e geração multimodal unificada com [Emu3](https://huggingface.co/BAAI/Emu3-Gen)
- Visão para texto com [Llava-OneVision](https://huggingface.co/llava-hf/llava-onevision-qwen2-0.5b-ov-hf)
- Perguntas visuais e respostas com [Llava](https://huggingface.co/llava-hf/llava-1.5-7b-hf)
- Segmentação de expressões referenciais visuais com [Kosmos-2](https://huggingface.co/microsoft/kosmos-2-patch14-224)

</details>

<details>
<summary>PLN (Processamento de Linguagem Natural)</summary>

- Preenchimento de palavra mascarada com [ModernBERT](https://huggingface.co/answerdotai/ModernBERT-base)
- Reconhecimento de entidade nomeada com [Gemma](https://huggingface.co/google/gemma-2-2b)
- Perguntas e respostas com [Mixtral](https://huggingface.co/mistralai/Mixtral-8x7B-v0.1)
- Resumirização com [BART](https://huggingface.co/facebook/bart-large-cnn)
- Tradução com [T5](https://huggingface.co/google-t5/t5-base)
- Geração de texto com [Llama](https://huggingface.co/meta-llama/Llama-3.2-1B)
- Classificação de texto com [Qwen](https://huggingface.co/Qwen/Qwen2.5-0.5B)

</details>

## Citação

Agora temos um [artigo](https://www.aclweb.org/anthology/2020.emnlp-demos.6/) que você pode citar para a biblioteca 🤗 Transformers:
```bibtex
@inproceedings{wolf-etal-2020-transformers,
    title = "Transformers: State-of-the-Art Natural Language Processing",
    author = "Thomas Wolf and Lysandre Debut and Victor Sanh and Julien Chaumond and Clement Delangue and Anthony Moi and Pierric Cistac and Tim Rault and Rémi Louf and Morgan Funtowicz and Joe Davison and Sam Shleifer and Patrick von Platen and Clara Ma and Yacine Jernite and Julien Plu and Canwen Xu and Teven Le Scao and Sylvain Gugger and Mariama Drame and Quentin Lhoest and Alexander M. Rush",
    booktitle = "Proceedings of the 2020 Conference on Empirical Methods in Natural Language Processing: System Demonstrations",
    month = oct,
    year = "2020",
    address = "Online",
    publisher = "Association for Computational Linguistics",
    url = "https://www.aclweb.org/anthology/2020.emnlp-demos.6",
    pages = "38--45"
}
```

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---