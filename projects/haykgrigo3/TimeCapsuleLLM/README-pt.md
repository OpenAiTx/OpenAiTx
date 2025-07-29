<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Em breve">繁體中文 (em breve)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Em breve">हिन्दी (em breve)</a> |
        | <a href="#" title="Em breve">ไทย (em breve)</a> |
        | <a href="#" title="Em breve">Français (em breve)</a>
        | <a href="#" title="Em breve">Deutsch (em breve)</a>
        | <a href="#" title="Em breve">Español (em breve)</a>
        | <a href="#" title="Em breve">Italiano (em breve)</a>
        | <a href="#" title="Em breve">Русский (em breve)</a>
        | <a href="#" title="Em breve">Português (em breve)</a>
        | <a href="#" title="Em breve">Nederlands (em breve)</a>
        | <a href="#" title="Em breve">Polski (em breve)</a>
        | <a href="#" title="Em breve">العربية (em breve)</a>
        | <a href="#" title="Em breve">فارسی (em breve)</a>
        | <a href="#" title="Em breve">Türkçe (em breve)</a>
        | <a href="#" title="Em breve">Tiếng Việt (em breve)</a>
        | <a href="#" title="Em breve">Bahasa Indonesia (em breve)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
Um LLM treinado apenas com dados de determinados períodos para reduzir o viés moderno.

Imagine se um modelo de IA não apenas fingisse ser histórico, mas realmente fosse.

Baseado no [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT). Os scripts principais de treinamento e arquitetura do modelo são de sua autoria. 

# Objetivos do Projeto 

TimeCapsule LLM é um projeto experimental que será treinado apenas com textos escritos durante determinados períodos históricos. O objetivo é simular a visão de mundo e a linguagem de eras históricas específicas.

# Por que o fine tuning não é suficiente 

Se você apenas fizer fine tuning em um modelo pré-treinado, seu LLM ainda conhecerá conceitos modernos. Claro que atingir zero viés moderno é difícil, mas quero chegar o mais próximo possível disso. Obter ausência de viés moderno requer treinar um modelo do zero.

# Resultados esperados 

Espero que, quando finalizado, este modelo não conheça conceitos modernos e não consiga raciocinar além do que foi treinado. Ele não deve reconhecer conceitos/vocabulário modernos e espero que não alucine conhecimentos atuais.

# Atualizações de Progresso

## 9 de julho de 2025

Defini meu período histórico para 1800-1850 e região: Londres 

Reuni uma lista de textos, livros, documentos 

Até agora consegui 50 arquivos txt e em breve iniciarei o treinamento do NanoGPT 

Atualizarei isso sempre que houver progresso

## 13 de julho de 2025

Treinei o nanoGPT com 187MB de dados textuais históricos. 

## 15 de julho de 2025

Comecei a baixar textos para a segunda rodada de treinamento. Estou buscando tudo no Internet Archive e ampliei o período para 1800-1875. Para obter uma variedade maior de textos, você pode usar filtros de assunto e pesquisa por local de publicação, período e temas no Internet Archive. 

![Filtros de Pesquisa](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 de julho de 2025

Baixei cerca de 500 arquivos txt do Internet Archive e após limpá-los (apenas removendo espaços em branco, cabeçalhos do Gutenberg, etc.) tenho cerca de 500MB de dados. É um conjunto de dados pequeno, mas da última vez treinei com 187MB, então deve haver pelo menos alguma diferença perceptível no resultado após treinar o segundo modelo. Espero que este modelo consiga pelo menos produzir frases mais coerentes que façam algum sentido. Não é garantia, claro, pois ainda é um conjunto de dados muito pequeno, mas é mais do que usei da última vez. 

Isso deve ser viável no meu próprio hardware, e é bom pois espero ver algum tipo de melhoria antes de partir para um conjunto de dados maior, o que exigiria alugar uma GPU. Mas não se preocupe, ainda pretendo alugar uma GPU em breve, mas antes quero garantir que meu conjunto de dados esteja o mais curado e limpo possível. Um dos problemas que tenho é a limpeza, muitos desses arquivos txt têm informações sem sentido misturadas. Os scripts que usei para limpeza funcionam, mas não são 100% eficazes. 

Vou treinar esse conjunto de dados hoje e deve levar cerca de 4-5 horas. Assim que terminar e eu testar, darei atualizações. Obrigado novamente a todos que estão acompanhando meu projeto, inclusive já recebi links de recursos de OCR, então obrigado! Espero que mais pessoas tentem isso e experimentem com seus próprios conjuntos de dados. 

## 28 de julho de 2025 

Já subi a versão v0.5 no Hugging Face, [Confira aqui](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) se quiser. Agora você pode baixar meu repositório e rodar localmente. Infelizmente, o nanoGPT não funciona nativamente com o HuggingFace, então você precisará baixar e rodar o modelo localmente. 

Também vou começar a curar dados para minha próxima rodada de treinamento, acredito que precisarei de 5 a 10 vezes mais dados para atingir capacidade de raciocínio. 

### Atualização de Treinamento 

Comecei o treinamento com um corpus de 435MB (108 milhões de tokens), está indo bem até agora. O train loss caiu de 10.9 para 4.9 nas primeiras 2800 iterações. Espero que leve cerca de 8 ou 9 horas para completar. Postarei outra atualização quando terminar.

## 17 de julho de 2025 2:13AM

O treinamento está concluído para o segundo modelo, levou cerca de 8 horas e 40 minutos no meu 4060 (3.900 iters/hora) para 33.000 iterações (5 épocas). O train loss final foi 3,73. Os resultados foram surpreendentemente bons, agora ele gera frases coerentes no estilo do século XIX. 

# Comportamento do Modelo V0 & Limitações 

Os primeiros prompts mostram o modelo respondendo com linguagem e comportamento dos anos 1800. Por exemplo, solicitei "Who art Henry?" e ele respondeu "I know that man, I have did not a black, the storm." e sim, essa frase não faz sentido, mas o LLM reconheceu que estou perguntando sobre uma pessoa. 

![Saída de Exemplo do TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Não há menção de conceitos modernos, as saídas contêm principalmente palavras e frases do século XIX.

Ainda precisa de muito trabalho, treinar com 187MB não lhe dará um modelo que produza textos com raciocínio complexo.

Neste momento, ele produz frases que não possuem estrutura completa e, no geral, simplesmente não fazem sentido, mas isso é normal para o tamanho do treinamento.

# Comportamento do Modelo V0.5 & Limitações

Esta é uma boa melhoria em comparação com o modelo anterior. O estilo de escrita e o vocabulário são vitorianos e quase todas as frases estão gramaticalmente corretas, com pontuação adequada. E novamente, foi treinado do zero, então se mantém em assuntos do século XIX.

![Saída de Exemplo TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Há muitas alucinações factuais. Muitas (tipo 100%) das informações (datas, eventos, figuras históricas) são inventadas. Além disso, as frases realmente não têm conexão umas com as outras, às vezes talvez 2 frases se relacionem, mas fora isso não se conectam. Outro problema é que às vezes aparece um rodapé “Digitized by Google”, então na próxima vez que treinar preciso garantir que os textos estejam bem limpos. No geral, estou muito satisfeito com os resultados, ainda está longe de ser um LLM, mas definitivamente é um gerador de frases.

Estou aprendendo muito e começarei a descobrir o que preciso melhorar nas próximas semanas. Em breve vou fazer upload dos arquivos!

# Planos Futuros

(Concluído) Vou começar a trabalhar na versão 0.5, ao invés de treinar usando 50 livros, vou treinar usando idealmente 500-600. Neste momento estou treinando o nanoGPT usando livros de 1800-1850 e especificamente de Londres. Existem alguns desafios como garantir que os livros encontrados não foram atualizados ou possuem interpretações modernas, mas livros intocados publicados dentro do período escolhido.

Quero treinar um novo modelo (v1) com um corpus muito maior, talvez 5-10x maior que o usado no v0.5. Meu objetivo é ver se consigo fazer habilidades de raciocínio emergirem apenas do Treinamento Temporal Seletivo, será uma tarefa mais difícil e nem tenho certeza se é possível devido às limitações dos dados históricos. Nas próximas semanas tentarei selecionar dados suficientes para um corpus de 5-10GB. Acredito que se eu conseguir dados limpos e de alta qualidade e alugar uma GPU, haverá progresso.

# Como Usar Este Projeto

Este projeto foca principalmente na curadoria de dados históricos, preparação para treinamento e construção de um tokenizador. Não vou cobrir o processo completo de treinamento de LLM, para isso consulte o nanoGPT de Andrej Karpathy.

# Passo 1: Coletar e Preparar Textos Históricos

Colete arquivos .txt de livros de domínio público, documentos, etc. do período escolhido (por exemplo, Londres 1800-1850)

Você pode usar o download_texts_improved.py para baixar os livros, se precisar.

Limpe os arquivos de texto usando um script ou remova manualmente cabeçalhos/rodapés do Project Gutenberg, anotações modernas ou coisas como erros de OCR.

prepare_dataset.py deve funcionar bem.

# Passo 2: Construir um Tokenizador Personalizado

Execute train_tokenizer.py ou train_tokenizer_hf.py nos dados limpos.
Isso irá gerar vocab.json e merges.txt

Esses arquivos definem o vocabulário e as regras de mesclagem para o seu modelo

# Passo 3: Treinar Seu Modelo (nanoGPT)

Consulte o [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para o processo de treinamento.

Você pode treinar outro LLM se quiser, mas eu usei o nanoGPT

# FAQ

## O que é Treinamento Temporal Seletivo?

Treinamento Temporal Seletivo (STT) é uma metodologia de machine learning onde todos os dados de treinamento são cuidadosamente selecionados para pertencer a um período histórico específico. Isso é feito para modelar a linguagem e o conhecimento daquela época sem influência de conceitos modernos. Por exemplo, o modelo atual (v0.5) é treinado exclusivamente com dados de 1800-1875, não é fine tuned, mas treinado do zero, resultando em uma saída que reflete o estilo linguístico e o contexto histórico daquele período.

## Por que não usar apenas fine-tuning ou LoRA?

Para este projeto, estou tentando criar um modelo de linguagem livre de vieses modernos. Se eu fizer fine-tuning em algo como o GPT-2, ele já está pré-treinado e essa informação não desaparecerá. Se eu treinar do zero, o modelo de linguagem não vai fingir ser antigo, ele será de fato. O objetivo deste projeto agora é criar algo que possa raciocinar exclusivamente com o conhecimento de livros de Londres publicados entre 1800 e 1850.

## Que tipo de dados você usou para o treinamento?

Estou usando livros, documentos legais, jornais e outros escritos de Londres de 1800–1850. A lista que linkei tem cerca de 200, mas para o primeiro treinamento usei apenas 50 arquivos, cerca de ~187 MB. Você pode ver uma lista dos documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Qual o tamanho do modelo da Versão 0?

Este modelo é bem pequeno no momento, estou fazendo por diversão e seguindo uma regra rígida de não usar fontes modernas. Ele tem quase 16 milhões de parâmetros, mas vou começar a reunir mais textos antigos para começar outro treinamento. Vou atualizando conforme avançar.

## Especificações de Treinamento?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---