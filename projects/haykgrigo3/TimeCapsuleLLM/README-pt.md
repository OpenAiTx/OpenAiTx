<div align="right">
  <details>
<summary>🌐 Idioma</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Um modelo de linguagem treinado **do zero** exclusivamente com dados de certos lugares e períodos para reduzir o viés moderno e emular a voz, o vocabulário e a visão de mundo da época.*

Imagine se um modelo de IA não apenas fingisse ser histórico, mas realmente fosse.

v0 e v0.5 construídos sobre [nanoGPT por Andrej Karpathy](https://github.com/karpathy/nanoGPT) Os scripts principais de treinamento e a arquitetura do modelo são de autoria dele.

v1 construído sobre [Phi 1.5 da Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 construído sobre llamaforcausallm

[Link do Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Status da Pesquisa
Este projeto foi iniciado e desenvolvido de forma independente.

Atualmente, é conduzido sob supervisão acadêmica, com colaboração de pesquisa afiliada à Muhlenberg College.

## Citação

Se você usar este conjunto de dados ou modelo em trabalhos acadêmicos, por favor cite:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

##  Comportamento do Modelo & Limitações

### **v0**  

Os primeiros prompts mostram o modelo respondendo com linguagem e comportamento do século XIX. 
Exemplo: Prompt: "Who art Henry?" e ele respondeu "I know that man, I have did not a black, the storm." 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Nenhuma menção a conceitos modernos  
- Vocabulário majoritariamente fiel à época  
- Frases na maioria incoerentes (esperado para ~187MB de dados de treino)

### **v0.5** 

Uma melhoria significativa em relação ao v0.  
- Estilo de escrita vitoriano, pontuação adequada, frases em sua maioria gramaticais  
- Ainda apresenta alta taxa de alucinação factual  
- Ruído de OCR (“Digitized by Google”) ainda presente nas respostas

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Primeiro modelo a relembrar e conectar um evento histórico real com uma figura do conjunto de dados.

Exemplo: Prompt: "It was the year of our Lord 1834" 

A resposta: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

A princípio, presumi que um protesto pudesse ter ocorrido coincidentemente no mesmo ano, mas veja só: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

Treinado usando uma amostra de 15GB do conjunto de dados de 90GB do v2.
Modelo treinado por apenas 10K passos.

Houve um problema com a tokenização que faz a saída parecer assim:

Quem é Charles Dickens?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Corrigido:

"Quem é Charles Dickens? Será que isso funciona mais do seu excelente estímulo, em suas peças, na fazenda da Grande Companhia? O que ainda tenho a citar de Jack Pickett? Você não sabe que eles eram uma espécie de galope, ou serrando seus peitos, ou o que deveria ser feito na época em que Jackson estava olhando pela janela? Qual é o sucesso de um inglês, e que seu filho ainda não me revelou, para realizar tal feito? Você já fez uma passagem para a antiga estrada, ou para uma brisa de âncora no pé do nosso barco, onde você deve nos deixar? O fato é que, se o vento se levantaria do campo no sábado à noite ou ao meio-dia, ou até o norte, ou de outra forma, seremos obrigados a descrever uma barreira formidável, com os mesmos efeitos da presente. Nessa situação, pelo menos, não é exagero dizer que deixamos aquele cômodo. Acredito que haja três cópias no 'Quinhentos Dobrado', a serem consultadas, como o primeiro número de nossos leitores que desejam t[o]..."

### **v2mini-eval2**

Treinado usando a mesma amostra de 15GB utilizada para o treinamento do eval1.
O modelo foi novamente treinado apenas até 10K passos.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Senhor, — O caso a seguir me interessa: — Estive em Londres por quinze dias e fui muito afetado por um ataque de reumatismo. O primeiro ataque de reumatismo foi uma semana antes de vê-lo, o segundo quando o vi, e o terceiro quando o vi, e o terceiro ao mesmo tempo. O segundo ataque de gota, entretanto, não foi acompanhado de sintomas febris, mas foi acompanhado por um aumento do fluxo urinário, e uma descarga mais abundante de urina. O terceiro ataque foi uma hora depois de vê-lo, e foi sucedido por um retorno de um paroxismo de gota, e um retorno mais rápido da gota. O quarto ataque também foi acompanhado de febre, mas nem sempre com sintomas febris. O terceiro ataque de gota foi quinze dias depois de você estar doente, e o quarto foi seguido por um paroxismo de gota. O quarto ataque foi quinze dias depois de você ter sido atacado, e foi acompanhado por uma sensação

### **v2**

Treinado usando um conjunto de dados de 90GB (112GB tokenizado)
Treinado até 182K passos

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  Conjuntos de Dados

### **v2**

- 90GB (bruto) de textos de Londres de 1800-1875
- 136.344 documentos
- O conjunto de dados tokenizado completo está disponível aqui: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### Estatísticas de Viés
  ![Viés de pronome](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Viés geográfico](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Viés temporal](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Consulte o [relatório de viés do v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) para mais informações.



## Como Usar

Este projeto foca principalmente na curadoria de dados históricos, preparação para treinamento e construção de um tokenizador. Não vou cobrir o processo completo de treinamento de LLM; para isso, consulte o nanoGPT de Andrej Karpathy.

### Passo 1: Coletar e Preparar Textos Históricos

- Colete arquivos .txt de livros, documentos, etc. de domínio público do período escolhido (por exemplo, Londres 1800-1850)
- Mantenha-os dentro da janela de tempo/local escolhida
- Limpe os arquivos de texto usando um script ou remova manualmente cabeçalhos/rodapés do Projeto Gutenberg, anotações modernas ou erros de OCR.

### Passo 2: Construir um Tokenizador Personalizado

- Execute train_tokenizer.py ou train_tokenizer_hf.py nos dados limpos.
- Isso irá gerar vocab.json e merges.txt
- Esses arquivos definem o vocabulário e as regras de fusão para seu modelo

### Passo 3: Treine Seu Modelo

- Consulte [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para o processo de treinamento ou a documentação da arquitetura escolhida.

# FAQ

## O que é Treinamento Temporal Seletivo?

Treinamento Temporal Seletivo (STT) é uma metodologia de aprendizado de máquina onde todos os dados de treinamento são cuidadosamente selecionados para se encaixarem em um período histórico específico. É feito para modelar a linguagem e o conhecimento daquela era sem influência de conceitos modernos. Por exemplo, o modelo atual (v0.5) foi treinado exclusivamente com dados de 1800-1875; não foi apenas ajustado, mas treinado do zero, resultando em uma saída que reflete o estilo linguístico e o contexto histórico desse período.

## Por que não usar apenas fine-tuning ou LoRA?

Neste projeto, estou tentando criar um modelo de linguagem sem viés moderno. Se eu fizer fine-tuning em algo como o GPT-2, ele já está pré-treinado e essa informação não será descartada. Se eu treinar do zero, o modelo de linguagem não fingirá ser antigo, ele realmente será. O objetivo deste projeto agora é criar algo que possa raciocinar exclusivamente usando conhecimento de livros de Londres publicados entre 1800 e 1875.

## Que tipo de dados você usou para o treinamento?

Estou usando livros, documentos legais, jornais e outros escritos de Londres entre 1800–1875. A lista que eu vinculei (para v0) tem cerca de 200, mas para o primeiro treinamento eu usei apenas 50 arquivos, aproximadamente ~187 MB. Você pode ver uma lista dos documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Tamanhos dos conjuntos de dados:
- v0: ~187MB
- v0.5: ~435MB
- v1: ~6,25GB
- v2mini-eval1: 15GB (amostra dos 90GB do v2)
- v2: 90GB

## Qual o tamanho dos modelos?

v0: 16M Parâmetros

v0.5: 123M Parâmetros

v1: 700M Parâmetros

v2mini-eval1: 300M Parâmetros

v2mini-eval2: 200M Parâmetros

v2: 1.2B Parâmetros

## Especificações de Treinamento?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM alugada

### v2mini-eval1/eval2
GPU: A100 SXM alugada

### v2
GPU: H100 SXM alugada

## Agradecimentos

Gostaria de agradecer ao [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) pela supervisão acadêmica, orientação na estruturação da pesquisa e avaliação, além da assistência no treinamento do tokenizador e preparação do conjunto de dados para o lançamento do v2. Seu feedback e experiência foram fundamentais para aprimorar a apresentação deste trabalho.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---