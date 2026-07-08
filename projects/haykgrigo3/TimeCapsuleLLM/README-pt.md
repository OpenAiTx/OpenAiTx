<div align="right">
  <details>
<summary>🌐 Idioma</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*Um modelo de linguagem treinado **do zero** exclusivamente com dados de certos lugares e períodos para reduzir o viés moderno e emular a voz, o vocabulário e a visão de mundo da época.*

Imagine se um modelo de IA não apenas fingisse ser histórico, mas realmente fosse.

v0 e v0.5 construídos sobre o [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT). Os scripts principais de treinamento e a arquitetura do modelo são de sua autoria.

v1 construído sobre o [Phi 1.5 da Microsoft](https://huggingface.co/microsoft/phi-1_5)

v2 construído sobre o llamaforcausallm

[Link Hugging Face](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## Status da Pesquisa
Este projeto foi iniciado e desenvolvido de forma independente.

Atualmente é conduzido sob supervisão acadêmica, com uma colaboração de pesquisa afiliada à Muhlenberg College & Georgia State University.

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

## Junte-se ao Vintage LLM Discord

Se você tem interesse em **modelos de linguagem históricos**, **conjuntos de dados específicos de época** ou no futuro de projetos como **TimeCapsuleLLM**, **Violet-1.4B**, **Mr. Chatterbox**, junte-se à comunidade.

Usamos o servidor para discutir ideias, compartilhar progresso e conectar com outros que estão construindo nessa área.

[Entre no Discord](https://discord.gg/JeWkk4z5)

## Patrocinadores

<div align="center">
  <a href="https://doloffer.com">
    <img src="https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/logo.png" width="500">
  </a>
</div>

Agradecimentos à DolOffer pelo apoio a este projeto!

A DolOffer é uma plataforma focada em recomendações de produtos digitais e compartilhamento de descontos, ajudando usuários a descobrir rapidamente ferramentas, serviços e ofertas por tempo limitado que valem a pena. A plataforma oferece uma variedade de serviços de assinatura populares, incluindo YouTube Premium, Claude, ChatGPT Plus, Spotify e Apple Music, com preços a partir de 30% do valor oficial ou até menos.

Cadastre-se agora através deste link exclusivo [doloffer](https://doloffer.com/en/), e insira o código promocional AI8888 ao recarregar para aproveitar um desconto adicional de 10%.

## Comportamento do Modelo & Limitações

### **v0**  

Os primeiros prompts mostram o modelo respondendo com linguagem e comportamento dos anos 1800.
Exemplo: Prompt: "Who art Henry?" e ele respondeu "I know that man, I have did not a black, the storm." 

![Exemplo de Saída do TimeCapsuleLLM](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- Nenhuma menção a conceitos modernos  
- Vocabulário majoritariamente fiel à época  
- Frases geralmente incoerentes (esperado para ~187MB de dados de treino)

### **v0.5-london** 

Uma melhora significativa em relação ao v0.  
- Estilo de escrita vitoriano, pontuação correta, frases na maioria das vezes gramaticais  
- Ainda há uma taxa alta de alucinações factuais  
- Ruído de OCR (“Digitalizado pelo Google”) ainda presente nos resultados

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

Primeiro modelo a relembrar e conectar um evento histórico real com uma figura real do conjunto de dados.

Exemplo: Prompt: "Era o ano de nosso Senhor 1834"

A saída: "Era o ano de nosso Senhor 1834 e as ruas de Londres estavam cheias de protestos e petições. A causa, como muitos relembraram, não estava ligada a interesses privados, mas tendo tomado o mesmo dia no dia de Lord Palmerston, o público receberá uma breve declaração das dificuldades sob as quais a lei chegou até nós. É motivo de profundo pesar que os eventos atuais na história do mundo sejam claros, e consequentemente serão conhecidos. Não é verdade que os próprios homens que primeiro se estabeleceram no Evangelho em Jerusalém deveriam ter um registro tão extenso e tão interessante da prosperidade e prosperidade"

A princípio, presumi que um protesto poderia ter ocorrido coincidentemente no mesmo ano, mas veja isto: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

Treinado usando uma amostra de 15GB do conjunto de dados de 90GB da v2.
Modelo treinado até apenas 10K passos.

Houve um problema com a tokenização que faz a saída parecer com isto:

PROMPT:
Quem é Charles Dickens?


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
Corrigido:

"Quem é Charles Dickens? Será que isso faz parte de mais uma de suas excelentes e emocionantes obras, em suas peças, na fazenda da Grande Companhia? O que ainda tenho para citar de Jack Pickett? Você não sabe que eles eram uma espécie de galopantes, ou serrando seus peitos, ou o que deveria ser feito por volta da época em que Jackson estava olhando pela janela? Qual é o sucesso de um inglês, e que seu filho ainda não me revelou, pelo qual realizar tal peso? Você já fez uma travessia pela antiga estrada, ou até uma brisa de âncora ao pé do nosso barco, que você precisa nos deixar? O fato é que, se o vento se levantaria da planície no sábado à noite ou ao meio-dia, ou até o norte, ou de outro modo, seremos obrigados a descrever uma barreira formidável, com os mesmos efeitos do presente. Nessa situação, pelo menos, não é exagero dizer que deixamos aquele quarto. Acredito que há três cópias nos 'Quinhentos Dobro', a serem referenciadas, como o primeiro número de nossos leitores que desejam t[o]..."

### **v2mini-eval2-london**

Treinado usando a mesma amostra de 15GB utilizada para o treinamento do eval1.
O modelo também foi treinado por apenas 10.000 passos.

PROMPT:Charles Darwin

Charles DarwinECCEMACY. Senhor, — O seguinte caso é interessante para mim: — Estive em Londres por quinze dias e fui muito afetado por um ataque de reumatismo. O primeiro ataque de reumatismo ocorreu uma semana antes de eu vê-lo, o segundo quando o vi e o terceiro quando o vi, e o terceiro ao mesmo tempo. O segundo ataque de gota, porém, não foi acompanhado de sintomas febris, mas veio com aumento do fluxo urinário e descarga mais abundante de urina. O terceiro ataque foi uma hora depois de eu vê-lo, sucedido por um retorno do paroxismo da gota e um retorno mais rápido da gota. O quarto ataque também veio com febre, mas nem sempre foi acompanhado de sintomas febris. O terceiro ataque de gota foi quinze dias depois de você ter adoecido, e o quarto foi seguido por um paroxismo de gota. O quarto ataque ocorreu quinze dias depois de você ter sido atacado, acompanhado por uma sensação

### **v2-london**

Treinado usando um conjunto de dados de 90GB (112GB tokenizado)
Treinado até 182 mil passos 

![TimeCapsuleLLM Exemplo de Saída](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Exemplo de Saída](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **O que vem a seguir?**

- O desenvolvimento do TimeCapsuleLLM v3 já começou
- Escalando o tamanho do conjunto de dados e cobertura geográfica
- Expansão para além de Londres, para cidades adicionais

O trabalho está sendo realizado em colaboração com pesquisadores do Muhlenberg College & Georgia State University. 


##  Conjuntos de Dados

### **v2**

- 90GB (bruto) de textos londrinos de 1800-1875
- 136.344 documentos
- O conjunto de dados tokenizado completo está disponível aqui: https://huggingface.co/datasets/postgrammar/london-llm-1800


 ### Estatísticas de Viés 
  ![Viés de pronome](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![Viés geográfico](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![Viés temporal](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

Consulte o [relatório de viés v2](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) para mais informações.


- 


## Como Usar

Este projeto foca principalmente na curadoria de dados históricos, preparação para treinamento e construção de um tokenizador. Não vou cobrir o processo completo de treinamento de LLM; para isso, consulte o nanoGPT de Andrej Karpathy.

### Passo 1: Coletar e Preparar Textos Históricos

- Colete arquivos .txt de livros de domínio público, documentos, etc. do período escolhido (ex.: Londres 1800-1875)
- Mantenha-os dentro da janela de tempo/local escolhida  
- Limpe os arquivos de texto usando um script ou remova manualmente cabeçalhos/rodapés do Project Gutenberg, anotações modernas ou erros de OCR.

### Passo 2: Construir um Tokenizador Personalizado

- Execute train_tokenizer.py ou train_tokenizer_hf.py nos dados limpos.
- Isso irá gerar vocab.json e merges.txt
- Esses arquivos definem o vocabulário e as regras de mesclagem para seu modelo

### Passo 3: Treinar Seu Modelo

- Consulte o [nanoGPT de Andrej Karpathy](https://github.com/karpathy/nanoGPT) para o processo de treinamento ou a documentação da arquitetura escolhida.

# FAQ

## O que é Treinamento Temporal Seletivo?

Treinamento Temporal Seletivo (STT) é uma metodologia de aprendizado de máquina onde todos os dados de treinamento são especificamente selecionados para cair dentro de um período histórico específico. Isso é feito para modelar a linguagem e o conhecimento da época sem influência de conceitos modernos. Por exemplo, o modelo atual que possuo (v0.5) é treinado exclusivamente com dados de 1800-1875, não é fine-tuned, mas treinado do zero, resultando em saídas que refletem o estilo linguístico e o contexto histórico daquele período.

## Por que não usar apenas fine-tuning ou LoRA?

Para este projeto estou tentando criar um modelo de linguagem que não seja influenciado por vieses modernos. Se eu ajustar algo como o GPT-2, ele já está pré-treinado e essa informação não desaparecerá. Se eu treinar do zero, o modelo de linguagem não irá fingir ser antigo, ele simplesmente será. O objetivo deste projeto agora é criar algo que possa raciocinar exclusivamente usando conhecimento de livros publicados em Londres entre 1800 e 1875.

## Que tipo de dados você usou para o treinamento?

Estou usando livros, documentos legais, jornais e outros escritos de Londres entre 1800–1875. A lista que eu linkei (para v0) tem cerca de 200, mas para o primeiro treinamento eu usei apenas 50 arquivos, aproximadamente ~187 MB. Você pode visualizar uma lista dos documentos:
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

v2: 1,2B Parâmetros

## Especificações de Treinamento?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

### v1
GPU: A100 SXM alugada

### v2mini-eval1/eval2
GPU: A100 SXM alugado

### v2
GPU: H100 SXM alugado

## Trabalhos Relacionados

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  - LLM de 13B parâmetros treinado em 260B tokens de texto anteriores a 1930 com Q&A. Existe também uma versão [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base).
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  - LLM de 1.4B parâmetros treinado em textos de 1800-1899 com Q&A. Existe também uma versão [160M](https://huggingface.co/zakarth/violet-160m-chat).
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  - LLM de 340M parâmetros treinado em mais de 28.000 textos entre 1837-1899 com Q&A. 

- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - uma família de LLMs de 4B parâmetros baseada na arquitetura Qwen3 treinada do zero em 80B tokens de dados históricos até os knowledge-cutoffs 1913, 1929, 1933, 1939, 1946.
 
- **[TypewriterLM](https://huggingface.co/typewriter-ai/typewriter-1913-7B-base)**
  - um modelo de linguagem histórica (LM) de 7,24B pré-treinado exclusivamente em textos em inglês anteriores a 1913. Criado por pesquisadores da University of Waterloo, Adelaide University, University of Oxford e University College London. [Link para o artigo](https://arxiv.org/abs/2606.02991)

- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT é um ajuste fino do Mistral-Hermes 2 em 11.000 textos modernos iniciais em inglês, francês e latim, principalmente provenientes do EEBO e Gallica.

## Agradecimentos

Gostaria de agradecer ao [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) pela supervisão acadêmica, orientação no enquadramento e avaliação da pesquisa, e pela assistência no treinamento do tokenizer e preparação do conjunto de dados para o lançamento da v2. Seu feedback e experiência foram fundamentais para refinar a apresentação deste trabalho.










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-08

---