
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=OliBomby&project=Mapperatorinator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Mapperatorinator

Experimente o modelo generativo [aqui](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb), ou o MaiMod [aqui](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb). Veja uma demonstração em vídeo [aqui](https://youtu.be/FEr7t1L2EoA).

Mapperatorinator é uma estrutura multi-modelo que utiliza entradas de espectrograma para gerar mapas de osu! completos para todos os modos de jogo e [auxiliar na moderação de mapas](#maimod-the-ai-driven-modding-tool).
O objetivo deste projeto é gerar automaticamente mapas de osu! com qualidade rankeável a partir de qualquer música, com alto grau de personalização.

Este projeto é baseado em [osuT5](https://github.com/gyataro/osuT5) e [osu-diffusion](https://github.com/OliBomby/osu-diffusion). No desenvolvimento, gastei cerca de 2500 horas de processamento de GPU em 142 execuções na minha 4060 Ti e aluguei instâncias 4090 na vast.ai.

#### Use esta ferramenta de forma responsável. Sempre divulgue o uso de IA em seus beatmaps.

## Instalação

A instrução abaixo permite que você gere beatmaps em sua máquina local, alternativamente você pode executá-la na nuvem com o [notebook do colab](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb).

### 1. Clone o repositório

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. (Opcional) Crie um ambiente virtual

Use Python 3.10, versões posteriores podem não ser compatíveis com as dependências.

```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```

### 3. Instale as dependências

- Python 3.10
- [Git](https://git-scm.com/downloads)
- [ffmpeg](http://www.ffmpeg.org/)
- [CUDA](https://developer.nvidia.com/cuda-zone) (Para GPUs NVIDIA) ou [ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html) (Para GPUs AMD no Linux)
- [PyTorch](https://pytorch.org/get-started/locally/): Certifique-se de seguir o guia Get Started para instalar `torch` e `torchaudio` com suporte a GPU. Selecione a versão correta da Plataforma de Computação que você instalou na etapa anterior.

- e as demais dependências Python:

```sh
pip install -r requirements.txt
```

## Interface Web (Recomendado)

Para uma experiência mais amigável, considere usar a interface Web. Ela fornece uma interface gráfica para configurar os parâmetros de geração, iniciar o processo e monitorar a saída.

### Iniciar a GUI

Navegue até o diretório clonado `Mapperatorinator` no seu terminal e execute:

```sh
python web-ui.py
```
Isso iniciará um servidor web local e abrirá automaticamente a interface em uma nova janela.

### Usando a GUI

- **Configurar:** Defina os caminhos de entrada/saída usando os campos do formulário e os botões "Procurar". Ajuste os parâmetros de geração como modo de jogo, dificuldade, estilo (ano, ID do mapeador, descritores), tempo, recursos específicos (hitsounds, super timing) e mais, espelhando as opções da linha de comando. (Nota: Se você fornecer um `beatmap_path`, a interface determinará automaticamente o `audio_path` e o `output_path` a partir dele, então você pode deixar esses campos em branco)
- **Iniciar:** Clique no botão "Iniciar Inferência" para começar a geração do beatmap.
- **Cancelar:** Você pode interromper o processo em andamento usando o botão "Cancelar Inferência".
- **Abrir Saída:** Quando finalizar, use o botão "Abrir Pasta de Saída" para acessar rapidamente os arquivos gerados.

A interface web atua como um wrapper conveniente em torno do script `inference.py`. Para opções avançadas ou resolução de problemas, consulte as instruções da linha de comando.

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## Inferência pela Linha de Comando

Para usuários que preferem a linha de comando ou precisam acessar configurações avançadas, siga os passos abaixo. **Nota:** Para uma interface gráfica mais simples, consulte a seção [Web UI (Recomendado)](#web-ui-recommended) acima.

Execute `inference.py` e passe alguns argumentos para gerar beatmaps. Para isso, use a [sintaxe de override do Hydra](https://hydra.cc/docs/advanced/override_grammar/basic/). Veja `configs/inference_v29.yaml` para todos os parâmetros disponíveis.

```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```

Exemplo:
```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## CLI Interativo
Para quem prefere um fluxo de trabalho baseado em terminal, mas deseja uma configuração guiada, o script CLI interativo é uma excelente alternativa à interface web.

### Iniciar o CLI
Navegue até o diretório clonado. Você pode precisar tornar o script executável primeiro.

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```

### Usando o CLI
O script irá guiá-lo por uma série de prompts para configurar todos os parâmetros de geração, assim como a interface Web.

Ele utiliza uma interface com código de cores para maior clareza.
Oferece um menu avançado de múltipla seleção para escolher os descritores de estilo usando as teclas de seta e barra de espaço.
Após responder todas as perguntas, exibirá o comando final para sua revisão.
Você pode então confirmar para executá-lo diretamente ou cancelar e copiar o comando para uso manual.

## Dicas de Geração

- Você pode editar o arquivo `configs/inference_v29.yaml` e adicionar seus argumentos lá ao invés de digitá-los no terminal toda vez.
- Todos os descritores disponíveis podem ser encontrados [aqui](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags).
- Sempre forneça um argumento de ano entre 2007 e 2023. Se deixar desconhecido, o modelo pode gerar com um estilo inconsistente.
- Sempre forneça um argumento de dificuldade. Se deixar desconhecido, o modelo pode gerar com uma dificuldade inconsistente.
- Aumente o parâmetro `cfg_scale` para aumentar a efetividade dos argumentos `mapper_id` e `descriptors`.
- Você pode usar o argumento `negative_descriptors` para direcionar o modelo a evitar certos estilos. Isso só funciona quando `cfg_scale > 1`. Certifique-se de que o número de descritores negativos seja igual ao número de descritores.
- Se o estilo da sua música e o estilo de beatmap desejado não combinarem bem, o modelo pode não seguir suas direções. Por exemplo, é difícil gerar um beatmap de SR alto e SV alto para uma música calma.
- Se você já tem timing e kiai times prontos para uma música, pode fornecê-los ao modelo para aumentar muito a velocidade e precisão da inferência: Use os argumentos `beatmap_path` e `in_context=[TIMING,KIAI]`.
- Para remapear apenas uma parte do seu beatmap, use os argumentos `beatmap_path`, `start_time`, `end_time`, e `add_to_beatmap=true`.
- Para gerar uma dificuldade guest para um beatmap, use os argumentos `beatmap_path` e `in_context=[GD,TIMING,KIAI]`.
- Para gerar hitsounds para um beatmap, use os argumentos `beatmap_path` e `in_context=[NO_HS,TIMING,KIAI]`.
- Para gerar apenas o timing para uma música, use os argumentos `super_timing=true` e `output_type=[TIMING]`.

## MaiMod: A Ferramenta de Modding com IA

MaiMod é uma ferramenta de modding para beatmaps do osu! que utiliza previsões do Mapperatorinator para encontrar possíveis falhas e inconsistências que não podem ser detectadas por outras ferramentas automáticas de modding como a [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier).
Ela pode detectar problemas como:
- Snapping incorreto ou padrões rítmicos inconsistentes
- Pontos de timing imprecisos
- Posições inconsistentes de hit objects ou placements de new combo
- Formatos estranhos de sliders
- Hitsounds ou volumes inconsistentes

Você pode experimentar o MaiMod [aqui](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb), ou executá-lo localmente:
Para executar o MaiMod localmente, será necessário instalar o Mapperatorinator. Depois, execute o script `mai_mod.py`, especificando o caminho do seu beatmap com o argumento `beatmap_path`.
```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
Isso imprimirá as sugestões de modding no console, que você poderá então aplicar manualmente ao seu beatmap.
As sugestões são ordenadas cronologicamente e agrupadas em categorias.
O primeiro valor no círculo indica o 'surprisal', que é uma medida de quão inesperado o modelo considerou o problema, para que você possa priorizar as questões mais importantes.

O modelo pode cometer erros, especialmente em questões de baixo surprisal, então sempre confira as sugestões antes de aplicá-las ao seu beatmap.
O objetivo principal é ajudá-lo a reduzir o espaço de busca por possíveis problemas, para que você não precise verificar manualmente cada objeto de hit no seu beatmap.

### MaiMod GUI
Para executar a interface web do MaiMod, você precisará instalar o Mapperatorinator.
Em seguida, execute o script `mai_mod_ui.py`. Isso iniciará um servidor web local e abrirá automaticamente a interface em uma nova janela:

```sh
python mai_mod_ui.py
```

<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## Visão Geral

### Tokenização

Mapperatorinator converte mapas de ritmo do osu! em uma representação intermediária de eventos que pode ser convertida diretamente para e de tokens.
Inclui objetos de acerto, sons de acerto, velocidades de slider, novos combos, pontos de tempo, tempos de kiai e velocidades de rolagem de taiko/mania.

Aqui está um pequeno exemplo do processo de tokenização:

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

Para economizar no tamanho do vocabulário, os eventos de tempo são quantizados em intervalos de 10ms e as coordenadas de posição são quantizadas em pontos de grade de 32 pixels.

### Arquitetura do modelo
O modelo é basicamente um wrapper em torno do [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration), com embeddings de entrada e função de perda personalizados.
O tamanho do modelo é de 219M parâmetros.
Este modelo foi considerado mais rápido e preciso do que o T5 para esta tarefa.

A visão geral de alto nível da entrada e saída do modelo é a seguinte:

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

O modelo utiliza frames de espectrograma Mel como entrada do encoder, com um frame por posição de entrada. A saída do decoder do modelo em cada passo é uma distribuição softmax sobre um vocabulário discreto e predefinido de eventos. As saídas são esparsas, os eventos só são necessários quando um objeto de acerto ocorre, em vez de anotar cada frame de áudio.

### Formato de treinamento multitarefa

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

Antes do token SOS existem tokens adicionais que facilitam a geração condicional. Estes tokens incluem o modo de jogo, dificuldade, ID do mapeador, ano e outros metadados.
Durante o treinamento, esses tokens não possuem rótulos correspondentes, então nunca são emitidos pelo modelo.
Também durante o treinamento existe uma chance aleatória de um token de metadado ser substituído por um token 'desconhecido', assim durante a inferência podemos usar esses tokens 'desconhecidos' para reduzir a quantidade de metadados que precisamos fornecer ao modelo.

### Geração longa contínua

O comprimento de contexto do modelo é de 8.192 segundos. Isso obviamente não é suficiente para gerar um mapa completo, então precisamos dividir a música em várias janelas e gerar o mapa em pequenas partes.
Para garantir que o mapa gerado não tenha costuras perceptíveis entre as janelas, usamos uma sobreposição de 90% e geramos as janelas sequencialmente.
Cada janela de geração, exceto a primeira, começa com o decoder pré-preenchido até 50% da janela de geração com tokens das janelas anteriores.
Usamos um processador de logit para garantir que o modelo não possa gerar tokens de tempo que estejam nos primeiros 50% da janela de geração.
Além disso, os últimos 40% da janela de geração são reservados para a próxima janela. Quaisquer tokens de tempo gerados nesse intervalo são tratados como tokens EOS.
Isso garante que cada token gerado seja condicionado a pelo menos 4 segundos de tokens anteriores e 3,3 segundos de áudio futuro a antecipar.

Para evitar o desvio de offset durante gerações longas, offsets aleatórios foram adicionados aos eventos de tempo no decodificador durante o treinamento.
Isso o obriga a corrigir erros de temporização ouvindo os onsets no áudio, resultando em um offset consistentemente preciso.

### Coordenadas refinadas com difusão

As coordenadas de posição geradas pelo decodificador são quantizadas para pontos de grade de 32 pixels, então depois usamos difusão para remover o ruído das coordenadas até as posições finais.
Para isso, treinamos uma versão modificada do [osu-diffusion](https://github.com/OliBomby/osu-diffusion) especializada apenas nos últimos 10% do cronograma de ruído, e aceita tokens de metadados mais avançados que o Mapperatorinator usa para geração condicional.

Como o modelo Mapperatorinator gera o SV dos sliders, o comprimento necessário do slider é fixo independentemente do formato do caminho dos pontos de controle.
Portanto, tentamos guiar o processo de difusão para criar coordenadas que se ajustem aos comprimentos necessários dos sliders.
Fazemos isso recalculando as posições finais do slider após cada etapa do processo de difusão com base no comprimento requerido e no caminho atual dos pontos de controle.
Isso significa que o processo de difusão não tem controle direto sobre as posições finais dos sliders, mas ainda pode influenciá-las alterando o caminho dos pontos de controle.

### Pós-processamento

O Mapperatorinator faz um pós-processamento extra para melhorar a qualidade do beatmap gerado:

- Refinar coordenadas de posição com difusão.
- Resnap de eventos de tempo para o tick mais próximo usando os divisores de snap gerados pelo modelo.
- Ajustar sobreposições posicionais quase perfeitas.
- Converter eventos de coluna mania em coordenadas X.
- Gerar caminhos de slider para drumrolls de taiko.
- Corrigir grandes discrepâncias entre comprimento necessário do slider e comprimento do caminho dos pontos de controle.

### Super timing generator

Super timing generator é um algoritmo que melhora a precisão e acurácia do tempo gerado inferindo o tempo de toda a música 20 vezes e fazendo a média dos resultados.
Isso é útil para músicas com BPM variável ou com mudanças de BPM. O resultado é quase perfeito, restando apenas por vezes uma seção que precisa de ajuste manual.

## Treinamento

A instrução abaixo cria um ambiente de treinamento em sua máquina local.

### 1. Clone o repositório

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. Criar conjunto de dados

Crie seu próprio conjunto de dados usando o [aplicativo de console Mapperator](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset). Ele exige um [token de cliente OAuth do osu!](https://osu.ppy.sh/home/account/edit) para verificar beatmaps e obter metadados adicionais. Coloque o conjunto de dados em um diretório `datasets` ao lado do diretório `Mapperatorinator`.

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. (Opcional) Configure o Weight & Biases para registro
Crie uma conta no [Weight & Biases](https://wandb.ai/site) e obtenha sua chave de API nas configurações da sua conta.
Em seguida, defina a variável de ambiente `WANDB_API_KEY`, para que o processo de treinamento saiba registrar usando essa chave.

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. Criar contêiner Docker
Também é possível treinar no seu venv, mas recomendamos o uso do Docker no WSL para melhor desempenho.
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. Configure parâmetros e inicie o treinamento

Todas as configurações estão localizadas em `./configs/train/default.yaml`.
Certifique-se de definir corretamente os parâmetros `train_dataset_path` e `test_dataset_path` para o seu conjunto de dados, assim como os índices inicial e final do mapset para divisão de treino/teste.
O caminho é local para o container docker, então se você colocou seu conjunto de dados chamado `cool_dataset` no diretório `datasets`, ele deve ser `/workspace/datasets/cool_dataset`.

Recomendo criar um arquivo de configuração personalizado que substitua a configuração padrão, para que você tenha um registro da sua configuração de treinamento para reprodutibilidade.

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. Ajuste fino com LoRA

Você também pode ajustar um modelo pré-treinado com [LoRA](https://arxiv.org/abs/2106.09685) para adaptá-lo a um estilo ou modo de jogo específico.
Para isso, adapte `configs/train/lora.yaml` conforme suas necessidades e execute a configuração de treinamento `lora`:

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```
Parâmetros importantes do LoRA a considerar:
- `pretrained_path`: Caminho ou repositório HF do modelo base para ajuste fino.
- `r`: Rank das matrizes LoRA. Valores maiores aumentam a capacidade do modelo, mas também o uso de memória.
- `lora_alpha`: Fator de escala para as atualizações do LoRA.
- `total_steps`: Número total de passos de treinamento. Equilibre isso de acordo com o tamanho do seu conjunto de dados.
- `enable_lora`: Se deve usar LoRA ou ajuste fino do modelo completo.

Durante a inferência, você pode especificar os pesos do LoRA a serem usados com o argumento `lora_path`.
Isto pode ser um caminho local ou um repositório do Hugging Face.

## Veja também
- [Mapper Classifier](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## Créditos

Agradecimentos especiais a:
1. Os autores do [osuT5](https://github.com/gyataro/osuT5) pelo código de treinamento.
2. Equipe do Hugging Face por suas [ferramentas](https://huggingface.co/docs/transformers/index).
3. [Jason Won](https://github.com/jaswon) e [Richard Nagyfi](https://github.com/sedthh) pelas trocas de ideias.
4. [Marvin](https://github.com/minetoblend) por doar créditos de treinamento.
5. A comunidade osu! pelos beatmaps.

## Trabalhos relacionados

1. [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator) por Syps (Nick Sypteras)
2. [osumapper](https://github.com/kotritrona/osumapper) por kotritrona, jyvden, Yoyolick (Ryan Zmuda)
3. [osu-diffusion](https://github.com/OliBomby/osu-diffusion) por OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu)
4. [osuT5](https://github.com/gyataro/osuT5) por gyataro (Xiwen Teoh)
5. [Beat Learning](https://github.com/sedthh/BeatLearning) por sedthh (Richard Nagyfi)
6. [osu!dreamer](https://github.com/jaswon/osu-dreamer) por jaswon (Jason Won)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-24

---