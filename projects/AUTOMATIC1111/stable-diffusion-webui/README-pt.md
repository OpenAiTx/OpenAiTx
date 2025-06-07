# Stable Diffusion web UI
Uma interface web para Stable Diffusion, implementada usando a biblioteca Gradio.

![](screenshot.png)

## Funcionalidades
[Apresentação detalhada de funcionalidades com imagens](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features):
- Modos originais txt2img e img2img
- Script de instalação e execução com um clique (mas ainda é necessário instalar python e git)
- Outpainting
- Inpainting
- Color Sketch
- Prompt Matrix
- Stable Diffusion Upscale
- Atenção, especifique partes do texto para as quais o modelo deve prestar mais atenção
    - um homem em um `((smoking))` - dará mais atenção ao smoking
    - um homem em um `(smoking:1.21)` - sintaxe alternativa
    - selecione o texto e pressione `Ctrl+Up` ou `Ctrl+Down` (ou `Command+Up` ou `Command+Down` se estiver no MacOS) para ajustar automaticamente a atenção ao texto selecionado (código contribuído por usuário anônimo)
- Loopback, processa img2img múltiplas vezes
- X/Y/Z plot, uma forma de desenhar um gráfico 3D de imagens com diferentes parâmetros
- Textual Inversion
    - tenha quantos embeddings quiser e use os nomes que desejar para eles
    - use múltiplos embeddings com diferentes números de vetores por token
    - funciona com números de ponto flutuante de meia precisão
    - treine embeddings com 8GB (também há relatos de 6GB funcionando)
- Aba Extras com:
    - GFPGAN, rede neural que corrige rostos
    - CodeFormer, ferramenta de restauração facial alternativa ao GFPGAN
    - RealESRGAN, upscaler de rede neural
    - ESRGAN, upscaler de rede neural com muitos modelos de terceiros
    - SwinIR e Swin2SR ([veja aqui](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)), upscalers de rede neural
    - LDSR, upscaling de super-resolução por difusão latente
- Opções de redimensionamento de proporção de aspecto
- Seleção do método de amostragem
    - Ajuste dos valores eta do sampler (multiplicador de ruído)
    - Mais opções avançadas de configuração de ruído
- Interrompa o processamento a qualquer momento
- Suporte a placas de vídeo de 4GB (também há relatos de 2GB funcionando)
- Sementes corretas para lotes
- Validação ao vivo do comprimento do prompt em tokens
- Parâmetros de geração
     - os parâmetros usados para gerar imagens são salvos junto com a imagem
     - em chunks PNG para PNG, em EXIF para JPEG
     - pode arrastar a imagem para a aba PNG info para restaurar os parâmetros de geração e copiá-los automaticamente para a interface
     - pode ser desativado nas configurações
     - arraste e solte uma imagem/texto-parâmetros na caixa de prompt
- Botão Ler Parâmetros de Geração, carrega parâmetros da caixa de prompt para a interface
- Página de configurações
- Execução de código python arbitrário pela interface (deve rodar com `--allow-code` para habilitar)
- Dicas ao passar o mouse na maioria dos elementos da interface
- Possível alterar valores padrões/mín/máx/passo dos elementos da interface via configuração de texto
- Suporte a tiling, uma caixa de seleção para criar imagens que podem ser usadas como texturas
- Barra de progresso e visualização ao vivo da geração de imagem
    - Pode usar uma rede neural separada para produzir prévias sem quase nenhum uso de VRAM ou computação
- Prompt negativo, um campo de texto extra para listar o que não deseja ver na imagem gerada
- Estilos, um modo de salvar parte do prompt e aplicá-lo facilmente pelo menu suspenso depois
- Variações, um modo de gerar a mesma imagem com pequenas diferenças
- Redimensionamento de seed, uma forma de gerar a mesma imagem em resolução levemente diferente
- CLIP interrogator, um botão que tenta adivinhar o prompt a partir de uma imagem
- Edição de Prompt, modo de mudar o prompt durante a geração, por exemplo para começar criando uma melancia e trocar para garota de anime no meio
- Processamento em lote, processa um grupo de arquivos usando img2img
- Img2img Alternativo, método reverso de Euler para controle de cross attention
- Highres Fix, opção conveniente para produzir imagens em alta resolução com um clique sem distorções usuais
- Recarregamento de checkpoints em tempo real
- Mesclador de checkpoints, aba que permite mesclar até 3 checkpoints em um só
- [Scripts personalizados](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts) com várias extensões da comunidade
- [Composable-Diffusion](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/), modo de usar múltiplos prompts ao mesmo tempo
     - separe prompts usando `AND` em maiúsculas
     - também suporta pesos para prompts: `um gato :1.2 AND um cachorro AND um pinguim :2.2`
- Sem limite de tokens para prompts (o stable diffusion original permite até 75 tokens)
- Integração com DeepDanbooru, gera tags no estilo danbooru para prompts de anime
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers), grande aumento de velocidade para placas selecionadas: (adicione `--xformers` nos argumentos de linha de comando)
- via extensão: [Aba de Histórico](https://github.com/yfszzx/stable-diffusion-webui-images-browser): visualize, direcione e apague imagens convenientemente pela interface
- Opção Gerar para sempre
- Aba de Treinamento
     - opções de hypernetworks e embeddings
     - Pré-processamento de imagens: corte, espelhamento, autotagging usando BLIP ou deepdanbooru (para anime)
- Clip skip
- Hypernetworks
- Loras (igual Hypernetworks, mas mais bonitos)
- Uma interface separada onde você pode escolher, com pré-visualização, quais embeddings, hypernetworks ou Loras adicionar ao seu prompt
- Pode selecionar para carregar um VAE diferente na tela de configurações
- Tempo estimado de conclusão na barra de progresso
- API
- Suporte ao [modelo dedicado de inpainting](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion) da RunwayML
- via extensão: [Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients), modo de gerar imagens com estética específica usando embeddings de imagens clip (implementação de [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients))
- Suporte ao [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - veja [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) para instruções
- Suporte ao [Alt-Diffusion](https://arxiv.org/abs/2211.06679) - veja [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) para instruções
- Agora sem letras ruins!
- Carregue checkpoints no formato safetensors
- Restrição de resolução facilitada: as dimensões da imagem gerada devem ser múltiplos de 8 ao invés de 64
- Agora com licença!
- Reordene elementos na interface pelas configurações
- Suporte ao [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## Instalação e Execução
Certifique-se de que as [dependências](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies) necessárias estão atendidas e siga as instruções disponíveis para:
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs) (recomendado)
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) GPUs.
- [CPUs Intel, GPUs Intel (integradas e dedicadas)](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon) (página wiki externa)
- [Ascend NPUs](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs) (página wiki externa)

Alternativamente, utilize serviços online (como Google Colab):

- [Lista de Serviços Online](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Instalação no Windows 10/11 com GPUs NVidia usando pacote de release
1. Baixe o `sd.webui.zip` de [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) e extraia seu conteúdo.
2. Execute `update.bat`.
3. Execute `run.bat`.
> Para mais detalhes, veja [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Instalação Automática no Windows
1. Instale o [Python 3.10.6](https://www.python.org/downloads/release/python-3106/) (Versões mais novas do Python não suportam torch), marcando "Add Python to PATH".
2. Instale o [git](https://git-scm.com/download/win).
3. Baixe o repositório stable-diffusion-webui, por exemplo rodando `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`.
4. Execute `webui-user.bat` no Windows Explorer como usuário normal, não administrador.

### Instalação Automática no Linux
1. Instale as dependências:
```bash
# Baseado em Debian:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Baseado em Red Hat:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# Baseado em openSUSE:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Baseado em Arch:
sudo pacman -S wget git python3
```
Se o seu sistema for muito novo, é necessário instalar python3.11 ou python3.10:
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # não confunda com o pacote python3.11

# Somente para 3.11
# Então configure a variável de ambiente no script de inicialização
export python_cmd="python3.11"
# ou em webui-user.sh
python_cmd="python3.11"
```
2. Navegue até o diretório onde deseja instalar a webui e execute o comando:
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
Ou apenas clone o repositório onde quiser:
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. Execute `webui.sh`.
4. Verifique `webui-user.sh` para opções.
### Instalação no Apple Silicon

Encontre as instruções [aqui](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon).

## Contribuindo
Veja como adicionar código neste repositório: [Contribuindo](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## Documentação

A documentação foi movida deste README para o [wiki do projeto](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki).

Para fins de indexação pelo Google e outros mecanismos de busca, aqui está um link para o (não destinado a humanos) [wiki rastreável](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki).

## Créditos
Licenças de códigos utilizados podem ser encontradas na tela `Configurações -> Licenças`, e também no arquivo `html/licenses.html`.

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel implementando
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- Ideias para otimizações - https://github.com/basujindal/stable-diffusion
- Otimização da camada Cross Attention - Doggettx - https://github.com/Doggettx/stable-diffusion, ideia original para edição de prompt.
- Otimização da camada Cross Attention - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI (originalmente http://github.com/lstein/stable-diffusion)
- Otimização Cross Attention sub-quadrática - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- Textual Inversion - Rinon Gal - https://github.com/rinongal/textual_inversion (não usamos o código dele, mas usamos suas ideias).
- Ideia para SD upscale - https://github.com/jquesnelle/txt2imghd
- Geração de ruído para outpainting mk2 - https://github.com/parlance-zz/g-diffuser-bot
- CLIP interrogator ideia e parte do código - https://github.com/pharmapsychotic/clip-interrogator
- Ideia para Composable Diffusion - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - interrogador para difusores de anime https://github.com/KichangKim/DeepDanbooru
- Amostragem em precisão float32 de um UNet float16 - marunine pela ideia, Birch-san pelo exemplo da implementação Diffusers (https://github.com/Birch-san/diffusers-play/tree/92feee6)
- Instruct pix2pix - Tim Brooks (estrela), Aleksander Holynski (estrela), Alexei A. Efros (sem estrela) - https://github.com/timothybrooks/instruct-pix2pix
- Conselho de segurança - RyotaK
- UniPC sampler - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- Restart sampling - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- Script inicial Gradio - postado no 4chan por um usuário anônimo. Obrigado, usuário anônimo.
- (Você)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---