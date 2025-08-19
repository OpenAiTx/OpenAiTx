
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

*Um modelo de linguagem treinado **do zero** exclusivamente com dados de determinados locais e períodos para reduzir o viés moderno e emular a voz, o vocabulário e a visão de mundo da época.*

Imagine se um modelo de IA não apenas fingisse ser histórico, mas realmente fosse.

v0 e v0.5 construídos sobre [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) Os scripts principais de treinamento e arquitetura do modelo são trabalho dele. 

v1 construído sobre [Phi 1.5 da Microsoft](https://huggingface.co/microsoft/phi-1_5)

##  Comportamento do Modelo & Limitações

### **v0**  

Os primeiros prompts mostram o modelo respondendo com linguagem e comportamento do século XIX. 
Exemplo: Prompt: "Who art Henry?" e ele respondeu "Eu conheço esse homem, eu não fiz um negro, a tempestade."

![Saída de Exemplo do TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Nenhuma menção a conceitos modernos  
- Vocabulário majoritariamente fiel à época  
- Frases são na maioria incoerentes (esperado para ~187MB de dados de treinamento)

### **v0.5** 

Uma melhoria significativa em relação ao v0.  
- Estilo de escrita vitoriano, pontuação adequada, frases na maioria gramaticais  
- Taxa de alucinação factual ainda alta  
- Ruído de OCR (“Digitized by Google”) ainda presente nas respostas

![Saída de Exemplo do TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Primeiro modelo a recordar e conectar um evento histórico real com uma figura do conjunto de dados.

Exemplo: Prompt: "Foi o ano de nosso Senhor 1834" 

A resposta: "Foi o ano de nosso Senhor 1834 e as ruas de Londres estavam cheias de protestos e petições. A causa, como muitos relataram, não estava vinculada ao modo privado, mas tendo sido tomada no mesmo dia no dia de Lord Palmerston, o público receberá uma breve declaração das dificuldades sob as quais o dia da lei chegou até nós. É motivo de profundo pesar que os eventos atuais na história do mundo sejam claros e, consequentemente, serão conhecidos. Não é verdade que os próprios homens que primeiro se estabeleceram no Evangelho em Jerusalém deveriam ter um registro tão extenso e tão interessante da prosperidade e prosperidade"

No início presumi que um protesto poderia ter acontecido coincidentemente no mesmo ano, mas veja isto: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Por que isso importa:

Este é o primeiro exemplo de um dos meus modelos conectando um ano a um evento histórico real e a uma pessoa real ligada a esse evento (Lord Palmerston). Modelos anteriores (v0 e v0.5) conseguiam imitar estilos de escrita do século XIX, mas sempre alucinavam eventos, pessoas e fatos. Isso mostra que o modelo está começando a lembrar coisas do conjunto de dados

## Planos Futuros 

- Existem quase 175.000 textos publicados em Londres de 1800-1875 disponíveis no Internet Archive
- Pretendo expandir o corpus e limpá-lo mais para melhorar as capacidades de raciocínio
- Expandindo para diferentes regiões e períodos para modelos históricos mais diversos


## Como Usar

Este projeto foca principalmente em curar dados históricos, prepará-los para treinamento e construir um tokenizador. Não vou cobrir o processo completo de treinamento de LLM, para isso, consulte o nanoGPT por Andrej Karpathy.

### Passo 1: Coletar e Preparar Textos Históricos

- Colete arquivos .txt de livros de domínio público, documentos, etc do período escolhido (ex.: Londres 1800-1850)
- Mantenha-os dentro da janela de tempo/local escolhida
- Limpe os arquivos de texto usando um script ou remova manualmente cabeçalhos/rodapés do Project Gutenberg, anotações modernas ou erros de OCR.

### Passo 2: Construir um Tokenizador Personalizado

- Execute train_tokenizer.py ou train_tokenizer_hf.py nos dados limpos.
- Isso irá gerar vocab.json e merges.txt
- Esses arquivos definem o vocabulário e as regras de fusão para seu modelo

### Passo 3: Treinar Seu Modelo

- Consulte [nanoGPT por Andrej Karpathy](https://github.com/karpathy/nanoGPT) para o processo de treinamento ou a documentação da arquitetura escolhida.

# FAQ

## O que é Treinamento Temporal Seletivo?

Treinamento Temporal Seletivo (STT) é uma metodologia de aprendizado de máquina onde todos os dados de treinamento são especificamente selecionados para estar dentro de um período histórico determinado. Isso é feito para modelar a linguagem e o conhecimento daquela época sem influência de conceitos modernos. Por exemplo, o modelo atual que possuo (v0.5) foi treinado exclusivamente com dados de 1800-1875, não é fine-tuned, mas treinado do zero, resultando em uma saída que reflete o estilo linguístico e contexto histórico desse período.

## Por que não apenas usar fine-tuning ou LoRA?

Para este projeto, estou tentando criar um modelo de linguagem livre de viés moderno. Se eu fizer fine-tuning em algo como GPT-2, ele já está pré-treinado e essa informação não desaparece. Se eu treinar do zero, o modelo de linguagem não vai apenas fingir ser antigo, ele realmente será. O objetivo deste projeto agora é criar algo que possa raciocinar exclusivamente usando conhecimento de livros de Londres publicados entre 1800 e 1875.

## Que tipo de dados você usou para o treinamento?

Estou usando livros, documentos legais, jornais e outros escritos de Londres de 1800–1875. A lista que linkei (para v0) tem cerca de 200, mas para o primeiro treinamento usei apenas 50 arquivos totalizando ~187 MB. Você pode ver a lista de documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt


Tamanhos dos conjuntos de dados:
v0: ~187MB
v0.5: ~435MB
v1: ~6,25GB

## Qual o tamanho dos modelos?

V0: 16M Parâmetros

V0.5 123M Parâmetros

V1: 700M Parâmetros

# Especificações de treinamento?

# V0/V0.5
GPU: Geforce RTX 4060
CPU: i5-13400F
Ram: 16GB DDR5.

# V1
GPU: A100 alugada














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---