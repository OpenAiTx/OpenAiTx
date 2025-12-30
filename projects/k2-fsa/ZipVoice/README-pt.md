
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=k2-fsa&project=ZipVoice&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">

# ZipVoice⚡

## Texto para Fala Zero-Shot Rápido e de Alta Qualidade com Flow Matching
</div>

## Visão Geral

ZipVoice é uma série de modelos TTS de zero-shot rápidos e de alta qualidade baseados em flow matching.

### 1. Principais características

- Pequeno e rápido: apenas 123M de parâmetros.

- Clonagem de voz de alta qualidade: desempenho de ponta em similaridade de locutor, inteligibilidade e naturalidade.

- Multi-idiomas: suporta chinês e inglês.

- Multi-modo: suporta geração de fala de locutor único e de diálogos.

### 2. Variantes do modelo

<table>
  <thead>
    <tr>
      <th>Nome do Modelo</th>
      <th>Descrição</th>
      <th>Artigo</th>
      <th>Demo</th>
    </tr>
  </thead>
  <tbody>
    <tr>
      <td>ZipVoice</td>
      <td>O modelo básico que suporta TTS zero-shot de locutor único em chinês e inglês.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2506.13053"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Distill</td>
      <td>Versão destilada do ZipVoice, com velocidade aprimorada e mínima degradação de desempenho.</td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog</td>
      <td>Modelo de geração de diálogos baseado no ZipVoice, capaz de gerar diálogos falados de dois participantes em canal único.</td>
      <td rowspan="2"><a href="https://arxiv.org/abs/2507.09318"><img src="https://img.shields.io/badge/arXiv-Paper-COLOR.svg"></a></td>
      <td rowspan="2"><a href="https://zipvoice-dialog.github.io"><img src="https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square"></a></td>
    </tr>
    <tr>
      <td>ZipVoice-Dialog-Stereo</td>
      <td>A variante estéreo do ZipVoice-Dialog, permitindo geração de diálogos em dois canais com cada falante atribuído a um canal distinto.</td>
    </tr>
  </tbody>
</table>

## Novidades

**2025/07/14**: **ZipVoice-Dialog** e **ZipVoice-Dialog-Stereo**, dois modelos de geração de diálogos falados, foram lançados. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice-dialog.github.io)

**2025/07/14**: O conjunto de dados **OpenDialog**, um dataset de diálogos falados de 6,8 mil horas, foi lançado. Baixe em [![hf](https://img.shields.io/badge/%F0%9F%A4%97%20HuggingFace-Dataset-yellow)](https://huggingface.co/datasets/k2-fsa/OpenDialog), [![ms](https://img.shields.io/badge/ModelScope-Dataset-blue?logo=data)](https://www.modelscope.cn/datasets/k2-fsa/OpenDialog). Confira os detalhes em [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2507.09318).

**2025/06/16**: **ZipVoice** e **ZipVoice-Distill** foram lançados. [![arXiv](https://img.shields.io/badge/arXiv-Paper-COLOR.svg)](https://arxiv.org/abs/2506.13053) [![demo page](https://img.shields.io/badge/GitHub.io-Demo_Page-blue?logo=Github&style=flat-square)](https://zipvoice.github.io)

## Instalação

### 1. Clone o repositório ZipVoice

```bash
git clone https://github.com/k2-fsa/ZipVoice.git
```
### 2. (Opcional) Crie um ambiente virtual Python


```bash
python3 -m venv zipvoice
source zipvoice/bin/activate
```
### 3. Instale os pacotes necessários


```bash
pip install -r requirements.txt
```
### 4. Instale o k2 para treinamento ou inferência eficiente

**k2 é necessário para o treinamento** e pode acelerar a inferência. No entanto, você ainda pode usar o modo de inferência do ZipVoice sem instalar o k2.

> **Nota:** Certifique-se de instalar a versão do k2 que corresponde à sua versão do PyTorch e do CUDA. Por exemplo, se você estiver usando pytorch 2.5.1 e CUDA 12.1, você pode instalar o k2 da seguinte forma:


```bash
pip install k2==1.24.4.dev20250208+cuda12.1.torch2.5.1 -f https://k2-fsa.github.io/k2/cuda.html
```
Consulte https://k2-fsa.org/get-started/k2/ para mais detalhes.
Usuários na China continental podem consultar https://k2-fsa.org/zh-CN/get-started/k2/.

- Para verificar a instalação do k2:


```bash
python3 -c "import k2; print(k2.__file__)"
```
## Uso

### 1. Geração de fala de um único locutor

Para gerar fala de um único locutor com nossos modelos pré-treinados ZipVoice ou ZipVoice-Distill, use os seguintes comandos (Os modelos necessários serão baixados do HuggingFace):

#### 1.1 Inferência de uma única sentença


```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --prompt-wav prompt.wav \
    --prompt-text "I am the transcription of the prompt wav." \
    --text "I am the text to be synthesized." \
    --res-wav-path result.wav
```
- `--model-name` pode ser `zipvoice` ou `zipvoice_distill`, que são modelos antes e depois da destilação, respectivamente.
- Se `<>` ou `[]` aparecerem no texto, cadeias de caracteres entre eles serão tratadas como tokens especiais. `<>` denota pinyin chinês e `[]` denota outras tags especiais.

#### 1.2 Inferência de uma lista de sentenças

```bash
python3 -m zipvoice.bin.infer_zipvoice \
    --model-name zipvoice \
    --test-list test.tsv \
    --res-dir results
```
- Cada linha de `test.tsv` está no formato `{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}`.

### 2. Geração de fala em diálogo

#### 2.1 Comando de inferência

Para gerar diálogos falados entre duas pessoas com nossos modelos pré-treinados ZipVoice-Dialogue ou ZipVoice-Dialogue-Stereo, use os seguintes comandos (Os modelos necessários serão baixados do HuggingFace):


```bash
python3 -m zipvoice.bin.infer_zipvoice_dialog \
    --model-name "zipvoice_dialog" \
    --test-list test.tsv \
    --res-dir results
```
- `--model-name` pode ser `zipvoice_dialog` ou `zipvoice_dialog_stereo`,
    que geram diálogos mono e estéreo, respectivamente.

#### 2.2 Formatos de entrada

Cada linha do `test.tsv` está em um dos seguintes formatos:

(1) **Formato de prompt mesclado** onde os áudios e transcrições dos prompts de dois falantes são mesclados em um único arquivo wav de prompt:

```
{wav_name}\t{prompt_transcription}\t{prompt_wav}\t{text}
```

- `wav_name` é o nome do arquivo wav de saída.
- `prompt_transcription` é a transcrição do arquivo wav de prompt de conversação, por exemplo, "[S1] Olá. [S2] Como vai você?"
- `prompt_wav` é o caminho para o arquivo wav de prompt.
- `text` é o texto a ser sintetizado, por exemplo, "[S1] Estou bem. [S2] Qual é o seu nome? [S1] Sou Eric. [S2] Oi Eric."

(2) **Formato de prompt dividido** onde os áudios e transcrições de dois falantes existem em arquivos separados:

```
{wav_name}\t{spk1_prompt_transcription}\t{spk2_prompt_transcription}\t{spk1_prompt_wav}\t{spk2_prompt_wav}\t{text}
```
- `wav_name` é o nome do arquivo wav de saída.
- `spk1_prompt_transcription` é a transcrição do prompt wav do primeiro locutor, por exemplo, "Olá"
- `spk2_prompt_transcription` é a transcrição do prompt wav do segundo locutor, por exemplo, "Como vai você?"
- `spk1_prompt_wav` é o caminho para o arquivo wav do prompt do primeiro locutor.
- `spk2_prompt_wav` é o caminho para o arquivo wav do prompt do segundo locutor.
- `text` é o texto a ser sintetizado, por exemplo, "[S1] Estou bem. [S2] Qual é o seu nome? [S1] Eu sou Eric. [S2] Olá Eric."

### 3 Orientações para melhor uso:

#### 3.1 Comprimento do prompt

Recomendamos um arquivo wav de prompt curto (por exemplo, menos de 3 segundos para geração de fala de um único locutor, menos de 10 segundos para geração de fala em diálogo) para maior velocidade de inferência. Um prompt muito longo irá desacelerar a inferência e degradar a qualidade da fala.

#### 3.2 Otimização de velocidade

Se a velocidade de inferência não for satisfatória, você pode acelerá-la da seguinte forma:

- **Modelo destilado e menos passos**: Para o modelo de geração de fala de único locutor, usamos o modelo `zipvoice` por padrão para melhor qualidade de fala. Se a prioridade for velocidade, você pode trocar para o `zipvoice_distill` e reduzir o `--num-steps` para até `4` (8 por padrão).

- **Aceleração da CPU com multithreading**: Ao rodar na CPU, você pode passar o parâmetro `--num-thread` (por exemplo, `--num-thread 4`) para aumentar o número de threads e obter maior velocidade. Usamos 1 thread por padrão.

- **Aceleração da CPU com ONNX**: Ao rodar na CPU, você pode usar modelos ONNX com `zipvoice.bin.infer_zipvoice_onnx` para mais velocidade (ainda não há suporte ONNX para modelos de geração de diálogo). Para ainda mais velocidade, você pode definir `--onnx-int8 True` para usar um modelo ONNX quantizado em INT8. Note que o modelo quantizado pode apresentar certa degradação na qualidade da fala. **Não use ONNX na GPU**, pois é mais lento do que o PyTorch na GPU.

- **Aceleração de GPU com NVIDIA TensorRT**: Para um aumento significativo de desempenho em GPUs NVIDIA, primeiro exporte o modelo para um engine TensorRT usando zipvoice.bin.tensorrt_export. Em seguida, faça a inferência em seu dataset (por exemplo, um dataset Hugging Face) com zipvoice.bin.infer_zipvoice. Isso pode alcançar aproximadamente 2x o throughput em relação à implementação padrão PyTorch na GPU.

#### 3.3 Controle de memória

O texto fornecido será dividido em partes com base na pontuação (para geração de fala de único locutor) ou símbolo de troca de locutor (para geração de diálogo). Então, os textos fragmentados serão processados em lotes. Portanto, o modelo pode processar textos arbitrariamente longos com uso de memória quase constante. Você pode controlar o uso de memória ajustando o parâmetro `--max-duration`.

#### 3.4 Avaliação "Bruta"

Por padrão, pré-processamos as entradas (prompt wav, transcrição do prompt e texto) para inferência eficiente e melhor desempenho. Se você quiser avaliar o desempenho "bruto" do modelo usando exatamente as entradas fornecidas (por exemplo, para reproduzir os resultados do nosso artigo), pode passar `--raw-evaluation True`.

#### 3.5 Texto curto

Ao gerar fala para textos muito curtos (por exemplo, uma ou duas palavras), a fala gerada pode, às vezes, omitir certas pronúncias. Para resolver esse problema, você pode passar `--speed 0.3` (onde 0.3 é um valor ajustável) para prolongar a duração da fala gerada.

#### 3.6 Corrigindo caracteres polifônicos chineses pronunciados incorretamente


Usamos o [pypinyin](https://github.com/mozillazg/python-pinyin) para converter caracteres chineses em pinyin. No entanto, ele pode ocasionalmente pronunciar incorretamente **caracteres polifônicos** (多音字).

Para corrigir manualmente essas pronúncias incorretas, coloque o **pinyin corrigido** entre sinais de menor e maior `< >` e inclua o **acento tonal**.

**Exemplo:**

- Texto original: `这把剑长三十公分`
- Corrija o pinyin de `长`:  `这把剑<chang2>三十公分`

> **Nota:** Se você quiser atribuir manualmente múltiplos pinyins, coloque cada pinyin com `<>`, por exemplo, `这把<jian4><chang2><san1>十公分`

#### 3.7 Remover longos silêncios da fala gerada

O modelo determinará automaticamente as posições e durações dos silêncios na fala gerada. Ocasionalmente, ele insere longos silêncios no meio da fala. Se não desejar isso, você pode passar `--remove-long-sil` para remover longos silêncios no meio da fala gerada (silêncios nas bordas serão removidos por padrão).

#### 3.8 Download do modelo

Se você tiver problemas para conectar ao HuggingFace ao baixar os modelos pré-treinados, tente mudar o endpoint para o site espelho: `export HF_ENDPOINT=https://hf-mirror.com`.

## Treine Seu Próprio Modelo

Veja o diretório [egs](egs) para exemplos de treinamento, ajuste fino e avaliação.

## Implantação em Produção

### Runtime NVIDIA Triton GPU

Para uma implantação pronta para produção com alto desempenho e escalabilidade, confira a [integração com o Triton Inference Server](runtime/nvidia_triton/), que fornece engines TensorRT otimizadas, manipulação de solicitações concorrentes e APIs gRPC/HTTP para uso corporativo.

### Implantação em CPU

Confira [sherpa-onnx](https://github.com/k2-fsa/sherpa-onnx/pull/2487#issuecomment-3227884498) para a solução de implantação em CPU com C++.

## Discussão & Comunicação

Você pode discutir diretamente em [Github Issues](https://github.com/k2-fsa/ZipVoice/issues).

Você também pode escanear o código QR para entrar em nosso grupo do wechat ou seguir nossa conta oficial do wechat.

| Grupo Wechat | Conta Oficial do Wechat |
| ------------ | ----------------------- |
|![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_group.jpg) |![wechat](https://k2-fsa.org/zh-CN/assets/pic/wechat_account.jpg) |

## Citação

```bibtex
@article{zhu2025zipvoice,
      title={ZipVoice: Fast and High-Quality Zero-Shot Text-to-Speech with Flow Matching},
      author={Zhu, Han and Kang, Wei and Yao, Zengwei and Guo, Liyong and Kuang, Fangjun and Li, Zhaoqing and Zhuang, Weiji and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2506.13053},
      year={2025}
}

@article{zhu2025zipvoicedialog,
      title={ZipVoice-Dialog: Non-Autoregressive Spoken Dialogue Generation with Flow Matching},
      author={Zhu, Han and Kang, Wei and Guo, Liyong and Yao, Zengwei and Kuang, Fangjun and Zhuang, Weiji and Li, Zhaoqing and Han, Zhifeng and Zhang, Dong and Zhang, Xin and Song, Xingchen and Lin, Long and Povey, Daniel},
      journal={arXiv preprint arXiv:2507.09318},
      year={2025}
}
```




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-30

---