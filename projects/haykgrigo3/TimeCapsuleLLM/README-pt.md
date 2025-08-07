<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (em breve)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (em breve)</a> |
        | <a href="#" title="Coming soon">ไทย (em breve)</a> |
        | <a href="#" title="Coming soon">Français (em breve)</a>
        | <a href="#" title="Coming soon">Deutsch (em breve)</a>
        | <a href="#" title="Coming soon">Español (em breve)</a>
        | <a href="#" title="Coming soon">Italiano (em breve)</a>
        | <a href="#" title="Coming soon">Русский (em breve)</a>
        | <a href="#" title="Coming soon">Português (em breve)</a>
        | <a href="#" title="Coming soon">Nederlands (em breve)</a>
        | <a href="#" title="Coming soon">Polski (em breve)</a>
        | <a href="#" title="Coming soon">العربية (em breve)</a>
        | <a href="#" title="Coming soon">فارسی (em breve)</a>
        | <a href="#" title="Coming soon">Türkçe (em breve)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (em breve)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (em breve)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Um LLM treinado apenas com dados de certos períodos para reduzir o viés moderno.

Imagine se um modelo de IA não apenas fingisse ser histórico, mas realmente fosse.

Construído sobre o [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) Os scripts principais de treinamento e a arquitetura do modelo são de sua autoria.

# Objetivos do Projeto

TimeCapsule LLM é um projeto experimental que será treinado apenas em textos escritos durante determinados períodos históricos. O objetivo é simular a visão de mundo e a linguagem de eras históricas específicas.

# Por que o fine tuning não é suficiente

Se você apenas fizer fine tuning em um modelo pré-treinado, seu LLM ainda conhecerá conceitos modernos. Claro que conseguir zero viés moderno é difícil, mas quero chegar o mais próximo possível disso. Para não ter viés moderno, é preciso treinar um modelo do zero.

# Resultados Esperados

Espero que, quando finalizado, esse modelo não conheça conceitos modernos e não seja capaz de raciocinar além do que foi treinado. Não deve reconhecer conceitos/vocabulário modernos e espero que não alucine conhecimentos atuais.

# Atualizações de Progresso

## 9 de julho de 2025

Defini meu período de tempo para 1800-1850 e região: Londres

Reuni uma lista de textos, livros, documentos

Até agora consegui 50 arquivos txt e vou começar o treinamento do NanoGPT em breve

Vou atualizar isso enquanto houver progresso

## 13 de julho de 2025

Treinei o nanoGPT com 187MB de dados textuais históricos.

## 15 de julho de 2025

Comecei a baixar textos para a segunda rodada de treinamento. Estou pegando tudo do Internet Archive e expandi o período para 1800-1875. Para obter uma gama diversificada de textos, você pode usar filtros de assunto e pesquisa para local de publicação, período e temas no Internet Archive.

![Filtros de Pesquisa](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 de julho de 2025

Baixei cerca de 500 arquivos txt do Internet Archive e, após limpá-los (apenas removendo espaços em branco, cabeçalhos do Gutenberg, etc), tenho cerca de 500MB de dados. É um dataset pequeno, mas da última vez treinei com 187MB, então deve haver pelo menos alguma diferença perceptível na saída depois que treinar o segundo modelo. Espero que este modelo consiga pelo menos produzir frases mais coerentes que façam algum sentido. Claro que não é garantia, pois ainda é um dataset muito pequeno, mas já é mais do que usei da última vez.

Isso deve ser possível no meu próprio hardware, o que é bom também porque espero ver algum tipo de melhora antes de pular para um dataset maior, o que exigiria alugar uma GPU. Mas não se preocupe, ainda pretendo alugar uma GPU em breve, mas antes quero garantir que meu dataset esteja o mais curado e limpo possível. Um dos problemas que tenho é a limpeza, muitos desses arquivos txt têm lixo misturado. Os scripts que usei para limpar funcionam, mas não são 100% eficazes.

Vou treinar esse dataset hoje e deve levar cerca de 4-5 horas. Assim que terminar e eu testar, darei atualizações. Obrigado novamente a todos que estão acompanhando meu projeto, já teve até gente me enviando links de recursos de OCR, então obrigado! Espero que mais pessoas tentem isso e experimentem com seus próprios datasets.


### Atualização do Treinamento

Comecei a treinar em um corpus de 435MB (108 M tokens), está indo bem até agora. O train loss caiu de 10,9 para 4,9 nas primeiras 2800 iterações. Acho que vai levar cerca de 8 ou 9 horas para terminar. Postarei outra atualização assim que acabar.

## 17 de julho de 2025

O treinamento do segundo modelo terminou, levou cerca de 8 horas e 40 minutos no meu 4060 (3.900 iters/h) para 33.000 iterações (5 épocas). O train loss final foi 3,73. As saídas ficaram surpreendentemente boas, realmente gera frases coerentes no estilo do século XIX agora.

## 28 de julho de 2025

Fui em frente e subi a v0.5 no Hugging Face, [confira aqui](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) se quiser. Agora você pode baixar meu repositório e rodar localmente. Infelizmente o nanoGPT não funciona nativamente com o HuggingFace, então você terá que baixar e rodar o modelo localmente.

Também vou começar a curar dados para minha próxima rodada de treinamento, acredito que vou precisar de 5 a 10 vezes mais dados para alcançar capacidade de raciocínio.

## 2 de agosto de 2025

Vou começar a trabalhar na Versão 1 em breve. Vou precisar fazer a transição da arquitetura do nanoGPT para algo mais moderno. Tenho várias arquiteturas LLM open-source em mente, incluindo: OpenLLaMA v3, Phi-2 e Qwen 1.5B. E para suportar o salto para a V1, vou precisar curar cuidadosamente um dataset muito maior e mais diverso. Preciso de pelo menos 5GB de dados de treinamento limpos.


# Comportamento e Limitações do Modelo V0

Os primeiros prompts mostram o modelo respondendo com linguagem e comportamento do século XIX. Por exemplo, eu perguntei "Who art Henry?" e ele respondeu "I know that man, I have did not a black, the storm." e sim, essa frase não faz sentido, mas o LLM reconheceu que estou perguntando sobre uma pessoa.

![Exemplo de Saída do TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Não há menção a conceitos modernos, as saídas contêm principalmente palavras e frases do século XIX.

Ainda precisa de muito trabalho, treinar com 187MB não resultará em um modelo que produza texto com raciocínio complexo.

No momento, ele produz frases que não têm estrutura completa e, em geral, não fazem sentido, mas isso é normal para esse tamanho de treinamento.

# Comportamento e Limitações do Modelo V0.5

Esta é uma boa melhoria em relação ao modelo anterior. O estilo de escrita e o vocabulário são vitorianos e quase todas as frases são gramaticalmente corretas com a pontuação adequada. E novamente, foi treinado do zero, então mantém os temas do século XIX.

![Exemplo de Saída do TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Há muitas alucinações factuais. Muitas (tipo 100%) das informações (datas, eventos, figuras históricas) são inventadas. Além disso, as frases não têm muita conexão entre si; às vezes, talvez duas frases se relacionem, mas além disso não se conectam. Outro problema é que, às vezes, aparece um rodapé “Digitized by Google”, então na próxima vez que eu treinar preciso garantir que os textos estejam bem limpos. No geral, estou muito satisfeito com os resultados, ainda não é um LLM, mas definitivamente um gerador de frases.

Estou aprendendo muito e começarei a entender o que preciso melhorar nas próximas semanas. Em breve, vou fazer upload dos arquivos!

# Planos Futuros

(Concluído) Vou começar a trabalhar na versão 0.5, em vez de treinar com 50 livros, vou treinar idealmente com 500-600. No momento estou treinando o nanoGPT com livros de 1800-1850 e especificamente de Londres. Há alguns desafios, como garantir que os livros encontrados não sejam atualizados ou tenham interpretações modernas, mas sim livros intocados publicados dentro do período escolhido.

Quero treinar um novo modelo (v1) com um corpus muito maior, talvez 5-10x maior do que o que usei para o v0.5. Meu objetivo é ver se consigo fazer com que habilidades de raciocínio emerjam apenas do Treinamento Temporal Seletivo, será uma tarefa mais difícil e nem tenho certeza se é possível devido às limitações de dados históricos. Nas próximas semanas, tentarei reunir dados suficientes para um corpus de 5-10GB. Acredito que se eu conseguir dados limpos e de alta qualidade e alugar uma GPU, haverá progresso.

# Como Usar Este Projeto

Este projeto foca principalmente na curadoria de dados históricos, preparação para treinamento e construção de um tokenizador. Não vou cobrir o processo completo de treinamento de LLM, para isso consulte o nanoGPT de Andrej Karpathy.

# Passo 1: Coletar e Preparar Textos Históricos

Colete arquivos .txt de livros de domínio público, documentos, etc. do período escolhido (ex: Londres 1800-1850)

Você pode usar o download_texts_improved.py para baixar livros se precisar.

Limpe os arquivos de texto usando um script ou remova manualmente cabeçalhos/rodapés do Project Gutenberg, anotações modernas ou erros de OCR.

prepare_dataset.py deve funcionar bem.

# Passo 2: Construir um Tokenizador Personalizado

Execute train_tokenizer.py ou train_tokenizer_hf.py nos dados limpos.
Isso irá gerar vocab.json e merges.txt

Esses arquivos definem o vocabulário e as regras de junção para o seu modelo

# Passo 3: Treinar seu Modelo (nanoGPT)

Consulte [nanoGPT por Andrej Karpathy](https://github.com/karpathy/nanoGPT) para o processo de treinamento.

Você pode treinar outro LLM se quiser, mas eu usei o nanoGPT

# FAQ

## O que é Treinamento Temporal Seletivo?

Treinamento Temporal Seletivo (STT) é uma metodologia de machine learning onde todos os dados de treinamento são especificamente selecionados para pertencer a um determinado período histórico. É feito para modelar a linguagem e o conhecimento daquela época sem influência de conceitos modernos. Por exemplo, o modelo atual (v0.5) foi treinado exclusivamente com dados de 1800-1875, não foi ajustado, mas treinado do zero, resultando em saídas que refletem o estilo linguístico e o contexto histórico daquele período.

## Por que não apenas usar fine-tuning ou LoRA?

Para este projeto, estou tentando criar um modelo de linguagem sem viés moderno. Se eu fizer fine-tuning em algo como o GPT-2, ele já foi pré-treinado e essa informação não será removida. Se eu treinar do zero, o modelo de linguagem não vai fingir ser antigo, ele realmente será. O objetivo do projeto agora é criar algo que possa raciocinar exclusivamente usando conhecimentos de livros de Londres publicados entre 1800 e 1850.

## Que tipo de dados você usou para o treinamento?

Estou usando livros, documentos legais, jornais e outros escritos de Londres de 1800–1850. A lista que eu linkei tem cerca de 200, mas para o primeiro treinamento usei apenas 50 arquivos, cerca de 187 MB. Você pode ver a lista dos documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Qual o tamanho do modelo Versão 0?

Este modelo é bem pequeno no momento, estou fazendo isso por diversão e seguindo uma regra rígida de treinamento sem fontes modernas. Tem quase 16 milhões de parâmetros, mas vou começar a reunir mais textos antigos para iniciar outro treinamento de modelo. Vou dar atualizações conforme avanço.

## Especificações de Treinamento?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---