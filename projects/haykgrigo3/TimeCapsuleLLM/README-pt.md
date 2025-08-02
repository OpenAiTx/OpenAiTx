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
Um LLM treinado apenas com dados de certos períodos de tempo para reduzir o viés moderno.

Imagine se um modelo de IA não apenas fingisse ser histórico, mas realmente fosse.

Baseado no [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) Os scripts principais de treinamento e a arquitetura do modelo são de sua autoria.

# Objetivos do Projeto

TimeCapsule LLM é um projeto experimental que será treinado apenas em textos escritos durante certos períodos históricos. O objetivo é simular a visão de mundo e a linguagem de eras históricas específicas.

# Por que apenas o fine tuning não é suficiente

Se você apenas fizer fine tuning em um modelo pré-treinado, seu LLM ainda conhecerá conceitos modernos. Claro que alcançar zero viés moderno é difícil, mas quero chegar o mais próximo possível disso. Para não ter viés moderno, é preciso treinar um modelo do zero.

# Resultados esperados

Espero que, quando finalizado, este modelo não conheça conceitos modernos e não consiga raciocinar além do que foi treinado. Ele não deve reconhecer conceitos/vocabulário modernos e espero que não "alucine" conhecimento atual.

# Atualizações de Progresso

## 9 de julho de 2025

Defini meu período de tempo para 1800-1850 e região: Londres

Reuni uma lista de textos, livros, documentos

Até agora consegui 50 arquivos em txt e vou começar o treinamento do NanoGPT em breve

Vou atualizar aqui à medida que houver progresso

## 13 de julho de 2025

Treinei o nanoGPT com 187MB de dados históricos em texto.

## 15 de julho de 2025

Comecei a baixar textos para a segunda rodada de treinamento. Estou pegando tudo do Internet Archive e expandi o período para 1800-1875. Para obter uma variedade maior de textos, você pode usar filtros de assunto e pesquisa para local de publicação, período e temas no Internet Archive.

![Filtros de Pesquisa](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 de julho de 2025

Baixei cerca de 500 arquivos txt do Internet Archive e após limpá-los (apenas removendo espaços em branco, cabeçalhos do Gutenberg, etc.) fiquei com cerca de 500MB de dados. É um conjunto de dados pequeno, mas da última vez treinei com 187MB, então deve haver alguma diferença perceptível na saída após treinar o segundo modelo. Espero que este modelo consiga pelo menos produzir frases mais coerentes que façam algum sentido. Claro que não é garantia, pois ainda é um conjunto de dados bem pequeno, mas é mais do que usei antes.

Deve ser possível treinar no meu próprio hardware, o que é bom porque assim posso ver melhorias antes de partir para um conjunto de dados maior, o que exigiria alugar uma GPU. Mas não se preocupem, ainda pretendo alugar uma GPU em breve, só quero garantir que meu conjunto de dados esteja o mais curado e limpo possível antes. Um dos problemas é a limpeza, muitos desses txt têm trechos sem sentido misturados. Os scripts que usei para limpar funcionam, mas não são 100% eficazes.

Vou treinar este conjunto de dados hoje e deve levar cerca de 4-5 horas. Assim que terminar e eu testar, darei atualizações. Obrigado novamente a todos que estão acompanhando o projeto, já teve gente me enviando links de recursos de OCR, então obrigado! Espero que mais pessoas tentem isso e experimentem com seus próprios conjuntos de dados.


### Atualização de Treinamento

Comecei o treinamento com um corpus de 435MB (108 M tokens), está indo bem por enquanto. O train loss caiu de 10,9 para 4,9 nas primeiras 2800 iterações. Espero que leve cerca de 8 ou 9 horas para completar. Vou postar outra atualização quando terminar.

## 17 de julho de 2025 2:13AM

O treinamento do segundo modelo terminou, levou cerca de 8 horas e 40 minutos na minha 4060 (3.900 iterações/hora) para 33.000 iterações (5 épocas). O loss final de treino foi 3,73. Os resultados foram surpreendentemente bons, agora genuinamente gera frases coerentes no estilo do século XIX.

## 28 de julho de 2025

Já subi a versão v0.5 no Hugging Face, [Confira aqui](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) se quiser. Agora você pode baixar meu repositório e rodar localmente. Infelizmente o nanoGPT não funciona nativamente com o HuggingFace, então você terá que baixar e rodar o modelo localmente.

Também vou começar a curar dados para meu próximo ciclo de treinamento, acredito que precisarei de 5 a 10 vezes mais dados para atingir capacidades de raciocínio.


# Comportamento & Limitações do Modelo V0

Os primeiros prompts mostram o modelo respondendo com linguagem e comportamento dos anos 1800. Por exemplo, perguntei "Who art Henry?" e ele respondeu "I know that man, I have did not a black, the storm." e sim, essa frase não faz sentido, mas o LLM está reconhecendo que estou perguntando sobre uma pessoa.


![Exemplo de Saída do TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Não há menção de conceitos modernos, as saídas contêm principalmente palavras e frases do século XIX.

Ainda precisa de muito trabalho, treinar com 187MB não vai te dar um modelo que produza textos com raciocínio complexo.

Atualmente ele produz sentenças sem estrutura frasal completa e, no geral, sem sentido, mas isso é normal para o tamanho do treinamento.

# Comportamento e Limitações do Modelo V0.5

Esta é uma boa melhoria em comparação ao último modelo. O estilo de escrita e o vocabulário são vitorianos e quase todas as frases são gramaticalmente corretas com pontuação adequada. E novamente, este foi treinado do zero, então se mantém nos assuntos do século XIX.

![Exemplo de Saída do TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Há muitas alucinações factuais. Muitos (como 100%) dos detalhes (datas, eventos, figuras históricas) são inventados. Além disso, as frases realmente não têm conexão entre si, às vezes talvez 2 frases se relacionem, mas além disso não. Outro problema é que às vezes aparece um rodapé “Digitized by Google” perdido, então na próxima vez que eu treinar realmente preciso garantir que os textos estejam bem limpos. No geral, estou muito satisfeito com os resultados, ainda está longe de ser um LLM, mas definitivamente é um gerador de sentenças.

Estou aprendendo muito e vou começar a descobrir o que preciso melhorar nas próximas semanas. Em breve vou disponibilizar arquivos!

# Planos Futuros

(Concluído) Vou começar a trabalhar na versão 0.5, em vez de treinar usando 50 livros, vou treinar idealmente usando 500-600. No momento estou treinando o nanoGPT usando livros de 1800-1850 e especificamente de Londres. Existem alguns desafios como garantir que os livros que encontro não foram atualizados ou tenham interpretações modernas, mas sim livros intactos publicados dentro do período escolhido.

Quero treinar um novo modelo (v1) com um corpus muito maior, talvez 5-10x maior que o que usei para o v0.5. Meu objetivo é ver se consigo fazer habilidades de raciocínio emergirem apenas do Treinamento Temporal Seletivo, o que será uma tarefa mais difícil e nem tenho certeza se é possível devido às limitações de dados históricos. Nas próximas semanas, tentarei reunir dados suficientes para um corpus de 5-10GB. Acredito que se conseguir dados limpos e de alta qualidade e alugar uma GPU, haverá progresso.

# Como Usar Este Projeto

Este projeto foca principalmente em curar dados históricos, prepará-los para treinamento e construir um tokenizador. Não vou cobrir o processo completo de treinamento de LLM, para isso consulte o nanoGPT do Andrej Karpathy.

# Passo 1: Coletar e Preparar Textos Históricos

Colete arquivos .txt de livros de domínio público, documentos, etc, do período escolhido (ex: Londres 1800-1850)

Você pode usar o download_texts_improved.py para baixar livros para você, se precisar.

Limpe os arquivos de texto usando um script ou remova manualmente cabeçalhos/rodapés do Project Gutenberg, anotações modernas ou coisas como erros de OCR.

prepare_dataset.py deve funcionar bem.

# Passo 2: Construir um Tokenizador Personalizado

Execute train_tokenizer.py ou train_tokenizer_hf.py nos dados limpos.
Isso irá gerar vocab.json e merges.txt

Esses arquivos definem vocabulário e regras de fusão para seu modelo

# Passo 3: Treine Seu Modelo (nanoGPT)

Consulte o [nanoGPT do Andrej Karpathy](https://github.com/karpathy/nanoGPT) para o processo de treinamento.

Você pode treinar outro LLM se quiser, mas eu usei o nanoGPT

# FAQ

## O que é Treinamento Temporal Seletivo?

Treinamento Temporal Seletivo (STT) é uma metodologia de aprendizado de máquina onde todos os dados de treinamento são especificamente curados para pertencer a um determinado período histórico. É feito para modelar a linguagem e o conhecimento daquela época sem influência de conceitos modernos. Por exemplo, o modelo que tenho agora (v0.5) foi treinado exclusivamente com dados de 1800-1875, não foi ajustado, mas treinado do zero, resultando em saídas que refletem o estilo linguístico e o contexto histórico desse período.

## Por que não usar apenas fine-tuning ou LoRA?

Para este projeto, estou tentando criar um modelo de linguagem sem viés moderno. Se eu fizer fine-tuning em algo como o GPT-2, ele já está pré-treinado e essa informação não vai embora. Se eu treinar do zero, o modelo de linguagem não vai fingir ser antigo, ele simplesmente será. O objetivo deste projeto no momento é criar algo que possa raciocinar exclusivamente usando conhecimento de livros de Londres publicados entre 1800 e 1850.

## Que tipo de dados você usou para o treinamento?

Estou usando livros, documentos legais, jornais e outros escritos de Londres entre 1800–1850. A lista que linkei tem cerca de 200, mas para o primeiro treinamento usei apenas 50 arquivos de ~187 MB. Você pode ver uma lista dos documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Qual o tamanho do modelo Versão 0?

Este modelo é muito pequeno no momento, estou fazendo isso por diversão e seguindo uma regra rigorosa de treinamento sem fontes modernas. Ele tem quase 16 milhões de parâmetros, mas vou começar a reunir mais textos antigos para iniciar outro treinamento de modelo. Darei atualizações conforme avançar.

## Especificações de Treinamento?

GPU: Geforce rtx 4060
CPU: i5-13400F
Ram: 16GB DDR5.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---