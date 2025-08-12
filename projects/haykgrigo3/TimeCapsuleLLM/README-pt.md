
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
Um LLM treinado apenas com dados de determinados períodos históricos para reduzir o viés moderno.

Imagine se um modelo de IA não apenas fingisse ser histórico, mas realmente fosse.

Baseado no [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) Os scripts principais de treinamento e a arquitetura do modelo são de autoria dele. 

# Objetivos do Projeto
TimeCapsule LLM é um projeto experimental que será treinado apenas com textos escritos durante determinados períodos históricos. O objetivo é simular a visão de mundo e a linguagem de eras históricas específicas.

# Por que o fine tuning não é suficiente

Se você apenas fizer o fine tuning de um modelo pré-treinado, seu LLM ainda vai conhecer conceitos modernos. Claro que alcançar zero viés moderno é difícil, mas quero chegar o mais próximo possível disso. Para eliminar o viés moderno, é necessário treinar um modelo do zero.

# Resultados esperados

Espero que, quando finalizado, este modelo não conheça conceitos modernos e não consiga raciocinar além do que foi treinado. Ele não deve reconhecer vocabulário/conceitos modernos e não deve alucinar conhecimento moderno.

# Atualizações de progresso

## 9 de julho de 2025

Defini meu período como 1800-1850 e região: Londres

Reuni uma lista de textos, livros, documentos

Até agora consegui 50 arquivos txt e começarei a treinar o NanoGPT em breve

Atualizarei isto enquanto houver progresso

## 13 de julho de 2025

Treinei o nanoGPT com 187MB de dados históricos em texto.

## 15 de julho de 2025

Comecei a baixar textos para a segunda rodada de treinamento. Estou pegando tudo do Internet Archive e ampliei o período para 1800-1875. Para obter uma gama diversificada de textos, você pode usar filtros de assunto e pesquisa por local de publicação, período e temas no Internet Archive.

![Filtros de Pesquisa](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 16 de julho de 2025

Baixei cerca de 500 arquivos txt do Internet Archive e após limpá-los (removendo espaços em branco, cabeçalhos do Gutenberg, etc) fiquei com cerca de 500MB de dados. É um conjunto de dados pequeno, mas da última vez treinei com 187MB então deve haver pelo menos alguma diferença notável na saída após treinar o segundo modelo. Espero que este modelo consiga produzir frases mais coerentes que façam algum sentido. Não é garantido, claro, pois ainda é um conjunto de dados minúsculo, mas é mais do que usei da última vez.

Deve ser possível treinar isso no meu próprio hardware, o que é bom porque espero ver algum tipo de melhoria antes de migrar para um conjunto maior de dados, o que exigiria alugar uma GPU. Mas não se preocupe, ainda pretendo alugar uma GPU em breve, mas antes disso quero garantir que meu conjunto de dados esteja o mais curado e limpo possível. Um dos problemas que tenho é a limpeza, muitos desses arquivos txt têm textos sem sentido misturados. Os scripts que usei para limpeza funcionam, mas não são 100% eficazes.

Vou treinar este conjunto de dados hoje e deve levar cerca de 4-5 horas. Quando terminar e eu testar, darei atualizações. Obrigado novamente a todos que estão acompanhando meu projeto, até recebi algumas pessoas me enviando links para recursos de OCR então obrigado! Espero que mais pessoas tentem isso e experimentem com seus próprios conjuntos de dados.


## 12 de agosto de 2025

A Versão 1 está completa, esta versão utiliza Phi 1.5 (700M parâmetros) e foi treinada em um conjunto de dados com quase 7000 textos. As principais melhorias deste modelo são sua capacidade de às vezes referenciar nomes reais e eventos históricos. As Versões 0 e 0.5 não conseguiam fazer isso; sempre que eu pedia algo como "No ano de 1821", a saída era apenas alucinações, coisas que nunca aconteceram. Um exemplo disso com a Versão 1:

Meu prompt: Era o ano de nosso Senhor de 1834,

A saída: "Era o ano de nosso Senhor de 1834 e as ruas de Londres estavam cheias de protestos e petições. A causa, como muitos relataram, não estava vinculada ao privado, mas tendo ocupado o mesmo dia no dia de Lord Palmerston, o público receberá uma breve declaração das dificuldades sob as quais o dia da lei nos alcançou. É motivo de profundo pesar que os atuais eventos na história do mundo sejam claros e, consequentemente, serão conhecidos. Não é verdade que os mesmos homens que primeiro se estabeleceram no Evangelho em Jerusalém tenham um registro tão extenso e interessante da prosperidade e prosperidade"

A princípio pensei que fosse coincidência, mas veja isso: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### Atualização do Treinamento

Comecei a treinar em um corpus de 435MB (108 M tokens), está indo bem até agora. A perda de treinamento caiu de 10,9 para 4,9 nas primeiras 2800 iterações. Espero que leve cerca de 8 ou 9 horas para completar. Vou postar outra atualização quando terminar.

## 17 de julho de 2025

O treinamento está concluído para o segundo modelo, minha 4060 levou cerca de 8 horas e 40 minutos (3.900 iterações/h) para 33.000 iterações (5 épocas). A perda final de treinamento foi 3,73. As saídas foram surpreendentemente boas, realmente gera frases coerentes no estilo do século XIX agora.

## 28 de julho de 2025

Fui em frente e enviei a v0.5 para o Hugging Face, [Confira aqui](https://huggingface.co/haykgrigorian/TimeCapsuleLLM) se quiser. Agora você pode baixar meu repositório e rodar localmente. Infelizmente o nanoGPT não funciona nativamente com o HuggingFace, então você terá que baixar e rodar o modelo localmente.

Também vou começar a curar dados para minha próxima rodada de treinamento, acredito que vou precisar de talvez 5-10x mais dados para atingir capacidade de raciocínio.

## 2 de agosto de 2025

Vou começar a trabalhar na Versão 1 em breve. Será necessário migrar da arquitetura do nanoGPT para algo mais moderno. Tenho várias arquiteturas LLM de código aberto em mente, incluindo: OpenLLaMA v3, Phi-2 e Qwen 1.5B. E para suportar o salto para a V1, precisarei curar cuidadosamente um conjunto de dados muito maior e diverso. Vou precisar de pelo menos 5GB de dados limpos de treinamento.

# Comportamento e Limitações do Modelo V0

Prompts iniciais mostram o modelo respondendo com linguagem e comportamento dos anos 1800. Por exemplo, pedi "Quem é Henry?" e respondeu "Eu conheço esse homem, eu não fiz um preto, a tempestade." e sim, essa frase não faz sentido, mas o LLM reconhece que estou perguntando sobre uma pessoa.

![Saída de Amostra do TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

Não há menção a conceitos modernos, as saídas contêm principalmente palavras e frases dos anos 1800.

Ainda precisa de muito trabalho, treinar com 187MB não vai te dar um modelo que produza texto com raciocínio complexo.

Atualmente, ele produz sentenças que não possuem estrutura completa e, no geral, não fazem sentido, mas isso é normal para o tamanho do treinamento.

# Comportamento & Limitações do Modelo V0.5

Esta é uma boa melhoria comparada ao último modelo. O estilo de escrita e o vocabulário são vitorianos e quase todas as frases estão gramaticalmente corretas, com pontuação adequada. E novamente, este foi treinado do zero, então mantém os temas dos anos 1800.

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

Há muitas alucinações factuais. Muitas (como 100%) das informações (datas, eventos, figuras históricas) são inventadas. Além disso, as frases não têm realmente conexão umas com as outras, às vezes talvez 2 frases se relacionem, mas além disso não. Outro problema é que às vezes aparece um rodapé “Digitized by Google” perdido, então da próxima vez que treinar realmente preciso garantir que os textos estejam bem limpos. No geral estou muito satisfeito com os resultados, ainda está longe de ser um LLM, mas definitivamente é um gerador de sentenças.

Estou aprendendo muito e começarei a descobrir o que preciso fazer melhor nas próximas semanas. Em breve vou fazer upload dos arquivos!

# Comportamento & Limitações do Modelo V1

Em breve vou fazer upload de alguns exemplos de saída e também realizar comparações entre os 3 modelos com o mesmo prompt. Também vou fazer upload do V1 para o Huggingface, como fiz com minha última versão; você pode encontrar minha conta Huggingface aqui: https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# Planos Futuros

(Concluído) Vou começar a trabalhar na versão 0.5, em vez de treinar usando 50 livros, vou treinar idealmente usando 500-600. Agora estou treinando o nanoGPT usando livros de 1800-1850 e especificamente de Londres. Existem alguns desafios como garantir que os livros que encontro não foram atualizados ou possuem interpretações modernas, mas sim livros intactos publicados dentro do período escolhido.

Quero treinar um novo modelo (v1) com um corpus muito maior, talvez 5-10x maior que o que usei para o v0.5. Meu objetivo é ver se consigo fazer habilidades de raciocínio emergirem apenas do Treinamento Temporal Seletivo, esta será uma tarefa mais difícil e nem tenho certeza se é possível devido às limitações dos dados históricos. Nas próximas semanas tentarei curar dados suficientes para um corpus de 5-10GB. Acredito que se conseguir dados limpos e de alta qualidade e alugar uma GPU, haverá progresso.

# Como Usar Este Projeto

Este projeto foca principalmente em curar dados históricos, prepará-los para treinamento e construir um tokenizador. Não vou cobrir o processo completo de treinamento de LLM, para isso consulte o nanoGPT de Andrej Karpathy.

# Passo 1: Coletar e Preparar Textos Históricos

Colete arquivos .txt de livros de domínio público, documentos, etc, do período escolhido (ex: Londres 1800-1850)

Você pode usar o download_texts_improved.py para baixar livros caso precise.

Limpe os arquivos de texto usando um script ou remova manualmente cabeçalhos/rodapés do Project Gutenberg, anotações modernas ou coisas como erros de OCR.

prepare_dataset.py deve funcionar bem.

# Passo 2: Construir um Tokenizador Personalizado

Execute train_tokenizer.py ou train_tokenizer_hf.py nos dados limpos.
Isso irá gerar vocab.json e merges.txt
Esses arquivos definem o vocabulário e as regras de mesclagem para o seu modelo

# Passo 3: Treine Seu Modelo (nanoGPT)

Consulte [nanoGPT por Andrej Karpathy](https://github.com/karpathy/nanoGPT) para o processo de treinamento.

Você pode treinar um LLM diferente se quiser, mas eu usei o nanoGPT

# FAQ

## O que é Treinamento Temporal Seletivo?

O Treinamento Temporal Seletivo (STT) é uma metodologia de aprendizado de máquina onde todos os dados de treinamento são especificamente selecionados para se enquadrar em um determinado período histórico. Isso é feito para modelar a linguagem e o conhecimento daquela era sem influência de conceitos modernos. Por exemplo, o modelo que tenho agora (v0.5) foi treinado exclusivamente com dados de 1800–1875, não foi apenas ajustado, mas treinado do zero, resultando em uma saída que reflete o estilo linguístico e o contexto histórico daquele período.

## Por que não usar apenas fine-tuning ou LoRA?

Para este projeto estou tentando criar um modelo de linguagem livre de vieses modernos. Se eu fizer fine-tuning em algo como GPT-2, ele já foi pré-treinado e essa informação não será eliminada. Se eu treinar do zero, o modelo de linguagem não vai fingir ser antigo, ele realmente será. O objetivo deste projeto agora é criar algo que possa raciocinar exclusivamente usando o conhecimento de livros publicados em Londres entre 1800 e 1850.

## Que tipo de dados você usou para o treinamento?

Estou usando livros, documentos legais, jornais e outros escritos de Londres entre 1800–1850. A lista que eu linkei tem cerca de 200, mas para o primeiro treinamento eu usei apenas 50 arquivos, cerca de ~187 MB. Você pode ver uma lista dos documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## Qual o tamanho dos modelos?

V0: 16M Parâmetros

V0.5: 123M Parâmetros

V1: 700M Parâmetros

# Especificações de Treinamento?

#V0/V0.5
GPU: Geforce RTX 4060
CPU: i5-13400F
RAM: 16GB DDR5.

#V1

GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---