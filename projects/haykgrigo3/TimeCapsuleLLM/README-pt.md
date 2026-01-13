<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Coming soon">فارسی (em breve)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (em breve)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*Um modelo de linguagem treinado **do zero** exclusivamente com dados de determinados locais e períodos históricos para reduzir o viés moderno e emular a voz, o vocabulário e a visão de mundo da época.*

Imagine se um modelo de IA não apenas fingisse ser histórico, mas realmente fosse.

v0 e v0.5 construídos sobre [nanoGPT por Andrej Karpathy](https://github.com/karpathy/nanoGPT) Os scripts principais de treinamento e a arquitetura do modelo são de autoria dele. 

v1 construído com base no [Phi 1.5 da Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 construído com base no llamaforcausallm

[Link do Hugging Face](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  Comportamento do Modelo & Limitações

### **v0**  

Os primeiros prompts mostram o modelo respondendo com linguagem e comportamento do século XIX. 
Exemplo: Prompt: "Who art Henry?" e ele respondeu "I know that man, I have did not a black, the storm." 

![Saída de Exemplo do TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Nenhuma menção a conceitos modernos  
- Vocabulário majoritariamente fiel à época  
- Frases na maioria das vezes incoerentes (esperado para ~187MB de dados de treinamento)

### **v0.5** 

Uma melhoria significativa em relação ao v0.  
- Estilo de escrita vitoriana, pontuação adequada, frases na maioria das vezes gramaticais  
- Ainda apresenta alta taxa de alucinação factual  
- Ruído de OCR (“Digitized by Google”) ainda presente nas saídas

![Saída de Exemplo do TimeLockLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

Primeiro modelo a recordar e conectar um evento histórico real com uma figura real do conjunto de dados.

Exemplo: Prompt: "It was the year of our Lord 1834" 

A saída: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

No início, presumi que um protesto poderia ter ocorrido coincidentemente no mesmo ano, mas veja isto: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**


Treinado usando uma amostra de 15GB do conjunto de dados de 90GB da v2.
Modelo treinado apenas até 10.000 etapas.

Houve um problema com a tokenização que faz com que a saída fique assim:

PROMPT:
Quem é Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Corrigido:

"Quem é Charles Dickens? Isso funciona mais da sua excelente comoção, em suas peças, na fazenda da Grande Companhia? O que ainda tenho a citar de Jack Pickett? Você não sabe que eles eram uma espécie de galope, ou serração de seus peitos, ou o que deveria ser feito na época em que Jackson olhava pela janela? Qual é o sucesso de um inglês, e o que seu filho ainda não descobriu para mim, pelo qual realizar tal peso? Você já fez uma passagem para a velha estrada, ou para uma brisa de âncora ao pé do nosso barco, que você deve nos deixar? O fato é que, se o vento se levantaria da planície no sábado à noite ou ao meio-dia, ou até o norte, ou de outra forma, seremos obrigados a descrever uma barreira formidável, com os mesmos efeitos do presente. Nesta situação, pelo menos, não é exagero dizer que deixamos aquele quarto. Acredito que há três cópias no 'Quinhentas vezes', para serem referidas, como o primeiro número de nossos leitores que desejam t[o]..."

### **v2mini-eval2**

Treinado usando a mesma amostra de 15GB usada para treinar o eval1.
O modelo foi novamente treinado por apenas 10K passos.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Senhor, — O seguinte caso é interessante para mim: — Estive em Londres por uma quinzena e fui muito afetado por um ataque de reumatismo. O primeiro ataque de reumatismo foi uma semana antes de eu vê-lo, e o segundo quando o vi, e o terceiro quando o vi, e o terceiro no mesmo tempo. O segundo ataque de gota, no entanto, não foi acompanhado por sintomas febris, mas foi acompanhado por um aumento no fluxo de urina, e por uma descarga mais copiosa de urina. O terceiro ataque foi uma hora depois que o vi, e foi sucedido por um retorno de um paroxismo de gota, e um retorno mais rápido da gota. O quarto ataque também foi acompanhado por uma febre, mas nem sempre foi acompanhado por sintomas febris. O terceiro ataque de gota foi uma quinzena depois que você esteve doente, e o quarto foi seguido por um paroxismo de gota. O quarto ataque foi uma quinzena depois que você foi atacado, e foi acompanhado por uma sensação


##  Conjuntos de Dados

### **v2**

- 90GB de textos londrinos de 1800-1875
- 136.344 documentos
- Os 90GB completos ainda não estão disponíveis pois não foram tokenizados, mas você pode encontrar uma amostra de 15GB aqui: https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### Estatísticas de Viés 
  ![Viés de pronome](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Viés geográfico](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Viés temporal](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Consulte o [relatório de viés v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) para mais informações.


## Como Usar

Este projeto foca principalmente na curadoria de dados históricos, preparação para treinamento e construção de um tokenizador. Não vou abordar o processo completo de treinamento de LLM, para isso consulte o nanoGPT de Andrej Karpathy.

### Passo 1: Reunir e Preparar Textos Históricos 

- Colete arquivos .txt de livros de domínio público, documentos, etc do período escolhido (ex: Londres 1800-1850)

- Mantenha-os dentro do intervalo de tempo/local escolhido  
- Limpe os arquivos de texto usando um script ou remova manualmente cabeçalhos/rodapés do Project Gutenberg, anotações modernas ou coisas como erros de OCR.

### Passo 2: Construa um Tokenizador Personalizado

- Execute train_tokenizer.py ou train_tokenizer_hf.py nos dados limpos.
- Isso irá gerar vocab.json e merges.txt
- Esses arquivos definem o vocabulário e as regras de mesclagem para seu modelo

### Passo 3: Treine Seu Modelo

- Consulte [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para o processo de treinamento ou a documentação da arquitetura escolhida.

# FAQ

## O que é Treinamento Temporal Seletivo?

O Treinamento Temporal Seletivo (STT) é uma metodologia de aprendizado de máquina onde todos os dados de treinamento são especificamente selecionados para se enquadrar em um determinado período histórico. É feito para modelar a linguagem e o conhecimento daquela época sem influência de conceitos modernos. Por exemplo, o modelo que possuo agora (v0.5) foi treinado exclusivamente com dados de 1800-1875, não foi ajustado, mas treinado do zero, resultando em uma saída que reflete o estilo linguístico e contexto histórico daquele período.

## Por que não apenas usar fine-tuning ou LoRA?

Para este projeto, estou tentando criar um modelo de linguagem livre de vieses modernos. Se eu ajustar algo como o GPT-2, ele já está pré-treinado e essa informação não será removida. Se eu treinar do zero, o modelo de linguagem não vai fingir ser antigo, ele simplesmente será. O objetivo deste projeto agora é criar algo que possa raciocinar exclusivamente usando conhecimento de livros de Londres publicados entre 1800 e 1875.

## Que tipo de dados você usou para o treinamento?

Estou usando livros, documentos legais, jornais e outros escritos de Londres entre 1800–1875. A lista que eu linkei (para v0) tem cerca de 200, mas para o primeiro treinamento usei apenas 50 arquivos de aproximadamente 187 MB. Você pode ver uma lista dos documentos:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

Tamanhos dos datasets:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6,25GB 
- v2mini-eval1: 15GB

## Qual o tamanho dos modelos?

v0: 16M Parâmetros

v0.5 123M Parâmetros

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented






























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-13

---