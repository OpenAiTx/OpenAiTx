<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

Se você gosta deste projeto, considere apoiar-me no Patreon!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Uma extensão de nó personalizada para o ComfyUI que adiciona funcionalidades de texto para fala (TTS) e conversão de voz (VC) usando a biblioteca Chatterbox.
Suporta um MÁXIMO de 40 segundos. Tentei remover essa limitação, mas o modelo apresenta sérios problemas com qualquer coisa acima disso, então ela permanece.

![Exemplo do ChatterBox](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## Instalação

1. Clone este repositório no diretório custom_nodes do seu ComfyUI:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. Instale as dependências básicas:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (Opcional) Instale o suporte a marca d'água:

   ```bash
   pip install resemble-perth
   ```
**Nota**: O pacote `resemble-perth` pode apresentar problemas de compatibilidade com Python 3.12+. Se você encontrar erros de importação, os nós ainda funcionarão sem marca d'água.


## Uso

### Nó Text-to-Speech (FL Chatterbox TTS)
- Adicione o nó "FL Chatterbox TTS" ao seu fluxo de trabalho
- Configure a entrada de texto e os parâmetros (exagero, cfg_weight, temperatura)
- Opcionalmente forneça um prompt de áudio para clonagem de voz

### Nó de Conversão de Voz (FL Chatterbox VC)
- Adicione o nó "FL Chatterbox VC" ao seu fluxo de trabalho
- Conecte o áudio de entrada e a voz alvo
- Ambos os nós suportam fallback para CPU se ocorrerem erros de CUDA

## Registro de Alterações

### 24/06/2025
- Adicionado parâmetro seed a ambos os nós TTS e VC para geração reprodutível
- Faixa de seed: 0 a 4.294.967.295 (inteiro de 32 bits)
- Permite saída de áudio consistente para depuração e controle do fluxo de trabalho
- Marca d'água Perth tornou-se opcional para corrigir problemas de compatibilidade com Python 3.12+
- Nós agora funcionam sem marca d'água se a importação do resemble-perth falhar

### 31/05/2025
- Adicionado carregamento persistente de modelo e funcionalidade de barra de carregamento
- Adicionado suporte para Mac (precisa ser testado, então me avise)
- removida a biblioteca chatterbox-tts e implementado código de inferência nativo.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---