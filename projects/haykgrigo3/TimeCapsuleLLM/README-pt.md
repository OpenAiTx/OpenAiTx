
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

[Link Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Comportamento do Modelo & Limitações

### **v0**  

Os primeiros prompts mostram o modelo respondendo com linguagem e comportamento do século XIX. 
Exemplo: Prompt: "Who art Henry?" e ele respondeu "I know that man, I have did not a black, the storm." 

![TimeLockLLM Saída de Exemplo](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Sem menção a conceitos modernos  
- Vocabulário majoritariamente preciso à época  
- Frases em sua maioria incoerentes (esperado para ~187MB de dados de treinamento)

### **v0.5** 

Uma melhoria significativa em relação ao v0.  
- Estilo de escrita vitoriano, pontuação correta, frases majoritariamente gramaticais  
- Ainda alta taxa de alucinação factual  
- Ruído de OCR (“Digitized by Google”) ainda presente nas saídas

![TimeLockLLM Saída de Exemplo](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Primeiro modelo a recordar e conectar um evento histórico real com uma figura real do conjunto de dados.

Exemplo: Prompt: "It was the year of our Lord 1834" 

A saída: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

A princípio assumi que um protesto poderia ter ocorrido coincidentemente no mesmo ano, mas olhe isto: ![1834protesto](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### Por que isso importa:

Este é o primeiro exemplo de um dos meus modelos conectando um ano a tanto um evento histórico real quanto a uma pessoa real vinculada a esse evento (Lord Palmerston). Modelos anteriores (v0 e v0.5) conseguiam imitar estilos de escrita do século XIX, mas sempre alucinavam eventos, pessoas e fatos. Isso mostra que o modelo está começando a lembrar coisas do conjunto de dados


## Planos Futuros

- Existem quase 175.000 textos publicados em Londres de 1800-1875 no Internet Archive
- Pretendo expandir o corpus e limpá-lo mais para melhorar as capacidades de raciocínio
- Expandir para diferentes regiões e períodos de tempo para modelos históricos mais abrangentes

## Como Usar

Este projeto foca principalmente em curar dados históricos, prepará-los para treinamento e construir um tokenizador. Não vou cobrir todo o processo de treinamento de LLM, para isso consulte o nanoGPT de Andrej Karpathy.

### Passo 1: Coletar e Preparar Textos Históricos

- Colete arquivos .txt de livros de domínio público, documentos, etc. do período escolhido (ex.: Londres 1800-1850)
- Mantenha-os dentro da janela de tempo/local escolhida
- Limpe os arquivos de texto usando um script ou removendo manualmente cabeçalhos/rodapés do Projeto Gutenberg, anotações modernas ou erros de OCR.

### Passo 2: Construir um Tokenizador Personalizado

- Execute train_tokenizer.py ou train_tokenizer_hf.py nos dados limpos.
- Isso irá gerar vocab.json e merges.txt
- Esses arquivos definem vocabulário e regras de mesclagem para seu modelo

### Passo 3: Treine Seu Modelo

- Consulte [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para o processo de treinamento ou a documentação da arquitetura escolhida.

# FAQ

## O que é Treinamento Temporal Seletivo?

Treinamento Temporal Seletivo (STT) é uma metodologia de aprendizado de máquina onde todos os dados de treinamento são especificamente curados para se enquadrar em um período histórico determinado. Isso é feito para modelar a linguagem e o conhecimento daquela época sem influência de conceitos modernos. Por exemplo, o modelo atual que tenho (v0.5) foi treinado exclusivamente com dados de 1800-1875, não foi apenas ajustado, mas treinado do zero, resultando em uma saída que reflete o estilo linguístico e o contexto histórico daquele período.

## Por que não usar apenas fine-tuning ou LoRA?

Neste projeto estou tentando criar um modelo de linguagem livre de vieses modernos. Se eu fizer fine-tuning em algo como GPT-2, ele já está pré-treinado e essa informação não desaparece. Se eu treinar do zero, o modelo de linguagem não vai fingir ser antigo, ele simplesmente será. O objetivo do projeto agora é criar algo que possa raciocinar exclusivamente usando conhecimento de livros de Londres publicados entre 1800 e 1875.

## Que tipo de dados você usou para treinar?


Estou usando livros, documentos legais, jornais e outros escritos de Londres entre 1800–1875. A lista que mencionei (para v0) tem cerca de 200, mas para o primeiro treinamento usei apenas 50 arquivos, aproximadamente ~187 MB. Você pode ver uma lista dos documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Tamanhos dos conjuntos de dados:
v0: ~187MB
v0.5: ~435MB 
v1: ~6.25GB 

## Qual o tamanho dos modelos ?

V0: 16M Parâmetros

V0.5 123M Parâmetros

V1: 700M Parâmetros

# Especificações de Treinamento ? 

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: A100 alugada















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---