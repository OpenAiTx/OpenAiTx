![Logotipo PyTorch](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/pytorch-logo-dark.png)

--------------------------------------------------------------------------------

PyTorch é um pacote Python que oferece dois recursos de alto nível:
- Computação de tensores (como o NumPy) com forte aceleração por GPU
- Redes neurais profundas construídas sobre um sistema de autograd baseado em fitas (tape-based)

Você pode reutilizar seus pacotes Python favoritos, como NumPy, SciPy e Cython, para estender o PyTorch quando necessário.

A saúde do nosso trunk (sinais de Integração Contínua) pode ser encontrada em [hud.pytorch.org](https://hud.pytorch.org/ci/pytorch/pytorch/main).

<!-- toc -->

- [Mais Sobre o PyTorch](#more-about-pytorch)
  - [Uma Biblioteca de Tensores Pronta para GPU](#a-gpu-ready-tensor-library)
  - [Redes Neurais Dinâmicas: Autograd Baseado em Fita](#dynamic-neural-networks-tape-based-autograd)
  - [Python em Primeiro Lugar](#python-first)
  - [Experiências Imperativas](#imperative-experiences)
  - [Rápido e Enxuto](#fast-and-lean)
  - [Extensões sem Dor](#extensions-without-pain)
- [Instalação](#installation)
  - [Binários](#binaries)
    - [Plataformas NVIDIA Jetson](#nvidia-jetson-platforms)
  - [A Partir do Código-Fonte](#from-source)
    - [Pré-requisitos](#prerequisites)
      - [Suporte NVIDIA CUDA](#nvidia-cuda-support)
      - [Suporte AMD ROCm](#amd-rocm-support)
      - [Suporte a GPU Intel](#intel-gpu-support)
    - [Obtenha o Código-Fonte do PyTorch](#get-the-pytorch-source)
    - [Instale as Dependências](#install-dependencies)
    - [Instale o PyTorch](#install-pytorch)
      - [Ajustar Opções de Build (Opcional)](#adjust-build-options-optional)
  - [Imagem Docker](#docker-image)
    - [Usando imagens pré-construídas](#using-pre-built-images)
    - [Construindo a imagem você mesmo](#building-the-image-yourself)
  - [Construindo a Documentação](#building-the-documentation)
    - [Gerando um PDF](#building-a-pdf)
  - [Versões Anteriores](#previous-versions)
- [Primeiros Passos](#getting-started)
- [Recursos](#resources)
- [Comunicação](#communication)
- [Lançamentos e Contribuição](#releases-and-contributing)
- [O Time](#the-team)
- [Licença](#license)

<!-- tocstop -->

## Mais Sobre o PyTorch

[Aprenda o básico do PyTorch](https://pytorch.org/tutorials/beginner/basics/intro.html)

No nível granular, o PyTorch é uma biblioteca que consiste nos seguintes componentes:

| Componente | Descrição |
| ---- | --- |
| [**torch**](https://pytorch.org/docs/stable/torch.html) | Uma biblioteca de tensores como o NumPy, com forte suporte a GPU |
| [**torch.autograd**](https://pytorch.org/docs/stable/autograd.html) | Uma biblioteca de diferenciação automática baseada em fita que suporta todas as operações de tensor diferenciáveis em torch |
| [**torch.jit**](https://pytorch.org/docs/stable/jit.html) | Uma pilha de compilação (TorchScript) para criar modelos serializáveis e otimizáveis a partir de código PyTorch |
| [**torch.nn**](https://pytorch.org/docs/stable/nn.html) | Uma biblioteca de redes neurais profundamente integrada ao autograd projetada para máxima flexibilidade |
| [**torch.multiprocessing**](https://pytorch.org/docs/stable/multiprocessing.html) | Multiprocessamento Python, mas com compartilhamento mágico de memória de tensores torch entre processos. Útil para carregamento de dados e treinamento Hogwild |
| [**torch.utils**](https://pytorch.org/docs/stable/data.html) | DataLoader e outras funções utilitárias para conveniência |

Geralmente, o PyTorch é usado como:

- Um substituto do NumPy para usar o poder das GPUs.
- Uma plataforma de pesquisa em deep learning que oferece máxima flexibilidade e velocidade.

Elaborando mais:

### Uma Biblioteca de Tensores Pronta para GPU

Se você usa NumPy, então já utilizou Tensores (também conhecidos como ndarray).

![Ilustração de Tensor](./docs/source/_static/img/tensor_illustration.png)

O PyTorch fornece Tensores que podem estar tanto na CPU quanto na GPU e acelera
o cálculo consideravelmente.

Oferecemos uma grande variedade de rotinas de tensores para acelerar e atender às suas necessidades de computação científica,
como fatiamento, indexação, operações matemáticas, álgebra linear, reduções.
E elas são rápidas!

### Redes Neurais Dinâmicas: Autograd Baseado em Fita

O PyTorch tem uma forma única de construir redes neurais: usando e reproduzindo um gravador de fita.

A maioria dos frameworks como TensorFlow, Theano, Caffe e CNTK possui uma visão estática do mundo.
É necessário construir uma rede neural e reutilizar a mesma estrutura repetidamente.
Mudar o comportamento da rede significa que é preciso começar do zero.

Com o PyTorch, usamos uma técnica chamada auto-diferenciação de modo reverso, que permite
alterar o comportamento da sua rede arbitrariamente, sem lag ou sobrecarga. Nossa inspiração vem
de vários artigos de pesquisa sobre este tópico, bem como trabalhos atuais e anteriores como
[torch-autograd](https://github.com/twitter/torch-autograd),
[autograd](https://github.com/HIPS/autograd),
[Chainer](https://chainer.org), etc.

Embora essa técnica não seja exclusiva do PyTorch, é uma das implementações mais rápidas até hoje.
Você obtém o melhor de velocidade e flexibilidade para suas pesquisas inovadoras.

![Grafo dinâmico](https://github.com/pytorch/pytorch/raw/main/docs/source/_static/img/dynamic_graph.gif)

### Python em Primeiro Lugar

PyTorch não é apenas um binding Python para um framework C++ monolítico.
Ele foi construído para ser profundamente integrado ao Python.
Você pode usá-lo naturalmente, como faria com [NumPy](https://www.numpy.org/) / [SciPy](https://www.scipy.org/) / [scikit-learn](https://scikit-learn.org) etc.
Você pode escrever suas novas camadas de rede neural em Python, usando suas bibliotecas favoritas
e utilizar pacotes como [Cython](https://cython.org/) e [Numba](http://numba.pydata.org/).
Nosso objetivo é não reinventar a roda onde apropriado.

### Experiências Imperativas

O PyTorch foi projetado para ser intuitivo, linear no pensamento e fácil de usar.
Quando você executa uma linha de código, ela é executada imediatamente. Não existe uma visão assíncrona do mundo.
Quando você entra em um depurador ou recebe mensagens de erro e rastreamentos de pilha, entendê-los é direto.
O rastreamento de pilha aponta exatamente onde seu código foi definido.
Esperamos que você nunca passe horas depurando seu código devido a rastreamentos de pilha ruins ou motores de execução assíncronos e opacos.

### Rápido e Enxuto

O PyTorch tem sobrecarga mínima de framework. Integramos bibliotecas de aceleração
como [Intel MKL](https://software.intel.com/mkl) e NVIDIA ([cuDNN](https://developer.nvidia.com/cudnn), [NCCL](https://developer.nvidia.com/nccl)) para maximizar a velocidade.
No núcleo, seus backends de tensor e rede neural para CPU e GPU
são maduros e foram testados por anos.

Portanto, o PyTorch é bastante rápido — seja você executando redes neurais pequenas ou grandes.

O uso de memória no PyTorch é extremamente eficiente em comparação ao Torch ou algumas alternativas.
Escrevemos alocadores de memória personalizados para a GPU para garantir que
seus modelos de deep learning sejam o mais eficiente possível em memória.
Isso permite que você treine modelos de deep learning maiores do que antes.

### Extensões sem Dor

Escrever novos módulos de rede neural, ou integrar com a API de Tensor do PyTorch foi projetado para ser direto
e com abstrações mínimas.

Você pode escrever novas camadas de rede neural em Python usando a API torch
[ou suas bibliotecas favoritas baseadas em NumPy, como SciPy](https://pytorch.org/tutorials/advanced/numpy_extensions_tutorial.html).

Se quiser escrever suas camadas em C/C++, fornecemos uma API de extensão conveniente, eficiente e com mínimo boilerplate.
Não é necessário escrever código wrapper. Você pode ver [um tutorial aqui](https://pytorch.org/tutorials/advanced/cpp_extension.html) e [um exemplo aqui](https://github.com/pytorch/extension-cpp).


## Instalação

### Binários
Comandos para instalar binários via Conda ou pip wheels estão em nosso site: [https://pytorch.org/get-started/locally/](https://pytorch.org/get-started/locally/)


#### Plataformas NVIDIA Jetson

Wheels Python para Jetson Nano da NVIDIA, Jetson TX1/TX2, Jetson Xavier NX/AGX e Jetson AGX Orin estão disponíveis [aqui](https://forums.developer.nvidia.com/t/pytorch-for-jetson-version-1-10-now-available/72048) e o container L4T é publicado [aqui](https://catalog.ngc.nvidia.com/orgs/nvidia/containers/l4t-pytorch)

Eles requerem JetPack 4.2 ou superior, e [@dusty-nv](https://github.com/dusty-nv) e [@ptrblck](https://github.com/ptrblck) são os responsáveis pela manutenção.


### A Partir do Código-Fonte

#### Pré-requisitos
Se você for instalar a partir do código-fonte, precisará de:
- Python 3.9 ou superior
- Um compilador que suporte totalmente C++17, como clang ou gcc (gcc 9.4.0 ou mais recente é necessário, no Linux)
- Visual Studio ou Visual Studio Build Tool (apenas no Windows)

\* O CI do PyTorch usa Visual C++ BuildTools, que vem com o Visual Studio Enterprise,
Professional ou Community. Você também pode instalar as ferramentas de build em
https://visualstudio.microsoft.com/visual-cpp-build-tools/. As ferramentas de build *não*
vêm com o Visual Studio Code por padrão.

Um exemplo de configuração de ambiente está abaixo:

* Linux:

```bash
$ source <CONDA_INSTALL_DIR>/bin/activate
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
```

* Windows:

```bash
$ source <CONDA_INSTALL_DIR>\Scripts\activate.bat
$ conda create -y -n <CONDA_NAME>
$ conda activate <CONDA_NAME>
$ call "C:\Program Files\Microsoft Visual Studio\<VERSION>\Community\VC\Auxiliary\Build\vcvarsall.bat" x64
```

##### Suporte NVIDIA CUDA
Se quiser compilar com suporte a CUDA, [selecione uma versão suportada de CUDA em nossa matriz de suporte](https://pytorch.org/get-started/locally/), depois instale o seguinte:
- [NVIDIA CUDA](https://developer.nvidia.com/cuda-downloads)
- [NVIDIA cuDNN](https://developer.nvidia.com/cudnn) v8.5 ou superior
- [Compilador](https://gist.github.com/ax3l/9489132) compatível com CUDA

Nota: Você pode consultar a [Matriz de Suporte cuDNN](https://docs.nvidia.com/deeplearning/cudnn/backend/latest/reference/support-matrix.html) para versões do cuDNN com as várias versões suportadas de CUDA, driver CUDA e hardware NVIDIA

Se quiser desabilitar o suporte a CUDA, exporte a variável de ambiente `USE_CUDA=0`.
Outras variáveis de ambiente potencialmente úteis podem ser encontradas em `setup.py`.

Se estiver construindo para as plataformas Jetson da NVIDIA (Jetson Nano, TX1, TX2, AGX Xavier), as instruções para instalar o PyTorch no Jetson Nano estão [disponíveis aqui](https://devtalk.nvidia.com/default/topic/1049071/jetson-nano/pytorch-for-jetson-nano/)

##### Suporte AMD ROCm
Se quiser compilar com suporte a ROCm, instale
- [AMD ROCm](https://rocm.docs.amd.com/en/latest/deploy/linux/quick_start.html) 4.0 ou superior
- O ROCm atualmente é suportado apenas em sistemas Linux.

Por padrão, o sistema de build espera que o ROCm esteja instalado em `/opt/rocm`. Se o ROCm estiver em outro diretório, a variável de ambiente `ROCM_PATH` deve ser definida para o diretório de instalação do ROCm. O sistema de build detecta automaticamente a arquitetura da GPU AMD. Opcionalmente, a arquitetura AMD GPU pode ser definida explicitamente com a variável de ambiente `PYTORCH_ROCM_ARCH` [Arquitetura GPU AMD](https://rocm.docs.amd.com/projects/install-on-linux/en/latest/reference/system-requirements.html#supported-gpus)

Se quiser desabilitar o suporte a ROCm, exporte a variável de ambiente `USE_ROCM=0`.
Outras variáveis de ambiente potencialmente úteis podem ser encontradas em `setup.py`.

##### Suporte a GPU Intel
Se quiser compilar com suporte a GPU Intel, siga estas
- [Pré-requisitos do PyTorch para GPUs Intel](https://www.intel.com/content/www/us/en/developer/articles/tool/pytorch-prerequisites-for-intel-gpus.html) instruções.
- GPU Intel é suportada para Linux e Windows.

Se quiser desabilitar o suporte a GPU Intel, exporte a variável de ambiente `USE_XPU=0`.
Outras variáveis de ambiente potencialmente úteis podem ser encontradas em `setup.py`.

#### Obtenha o Código-Fonte do PyTorch
```bash
git clone https://github.com/pytorch/pytorch
cd pytorch
# se você estiver atualizando um checkout existente
git submodule sync
git submodule update --init --recursive
```

#### Instale as Dependências

**Comum**

```bash
conda install cmake ninja
# Execute este comando do diretório do PyTorch após clonar o código-fonte usando a seção “Obtenha o Código-Fonte do PyTorch” acima
pip install -r requirements.txt
```

**No Linux**

```bash
pip install mkl-static mkl-include
# Somente CUDA: Adicione suporte a LAPACK para a GPU, se necessário
# instalação do magma: execute com o ambiente conda ativo. especifique a versão CUDA para instalar
.ci/docker/common/install_magma_conda.sh 12.4

# (opcional) Se estiver usando torch.compile com inductor/triton, instale a versão correspondente do triton
# Execute do diretório pytorch após clonar
# Para suporte a GPU Intel, por favor, `export USE_XPU=1` explicitamente antes de rodar o comando.
make triton
```

**No MacOS**

```bash
# Adicione este pacote apenas em máquinas com processador intel x86
pip install mkl-static mkl-include
# Adicione estes pacotes se torch.distributed for necessário
conda install pkg-config libuv
```

**No Windows**

```bash
pip install mkl-static mkl-include
# Adicione estes pacotes se torch.distributed for necessário.
# O suporte ao pacote Distributed no Windows é um recurso protótipo e está sujeito a alterações.
conda install -c conda-forge libuv=1.39
```

#### Instale o PyTorch
**No Linux**

Se estiver compilando para AMD ROCm, execute primeiro este comando:
```bash
# Execute isso apenas se estiver compilando para ROCm
python tools/amd_build/build_amd.py
```

Instale o PyTorch
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py develop
```

**No macOS**

```bash
python3 setup.py develop
```

**No Windows**

Se quiser construir código python legado, consulte [Construindo em código legado e CUDA](https://github.com/pytorch/pytorch/blob/main/CONTRIBUTING.md#building-on-legacy-code-and-cuda)

**Builds apenas para CPU**

Neste modo, os cálculos do PyTorch rodarão em sua CPU, não na GPU.

```cmd
python setup.py develop
```

Nota sobre OpenMP: A implementação desejada do OpenMP é a Intel OpenMP (iomp). Para linkar contra iomp, você precisará baixar manualmente a biblioteca e configurar o ambiente de build ajustando `CMAKE_INCLUDE_PATH` e `LIB`. A instrução [aqui](https://github.com/pytorch/pytorch/blob/main/docs/source/notes/windows.rst#building-from-source) é um exemplo para configurar tanto o MKL quanto o Intel OpenMP. Sem essas configurações para o CMake, o runtime OpenMP do Microsoft Visual C (vcomp) será usado.

**Build baseado em CUDA**

Neste modo, os cálculos do PyTorch utilizarão sua GPU via CUDA para processamento mais rápido

[NVTX](https://docs.nvidia.com/gameworks/content/gameworkslibrary/nvtx/nvidia_tools_extension_library_nvtx.htm) é necessário para compilar o Pytorch com CUDA.
NVTX faz parte da distribuição CUDA, onde é chamado de "Nsight Compute". Para instalá-lo em uma instalação CUDA já existente, execute a instalação CUDA novamente e marque a caixa correspondente.
Certifique-se de que o CUDA com Nsight Compute está instalado após o Visual Studio.

Atualmente, VS 2017 / 2019 e Ninja são suportados como geradores do CMake. Se `ninja.exe` for detectado no `PATH`, Ninja será usado como gerador padrão, caso contrário, será usado VS 2017 / 2019.
<br/> Se Ninja for selecionado como gerador, o MSVC mais recente será selecionado como toolchain subjacente.

Bibliotecas adicionais como
[Magma](https://developer.nvidia.com/magma), [oneDNN, também conhecido como MKLDNN ou DNNL](https://github.com/oneapi-src/oneDNN), e [Sccache](https://github.com/mozilla/sccache) são frequentemente necessárias. Consulte o [installation-helper](https://github.com/pytorch/pytorch/tree/main/.ci/pytorch/win-test-helpers/installation-helpers) para instalá-las.

Você pode consultar o script [build_pytorch.bat](https://github.com/pytorch/pytorch/blob/main/.ci/pytorch/win-test-helpers/build_pytorch.bat) para outras configurações de variáveis de ambiente


```cmd
cmd

:: Defina as variáveis de ambiente depois de baixar e descompactar o pacote mkl,
:: senão o CMake retornará erro como `Could NOT find OpenMP`.
set CMAKE_INCLUDE_PATH={Seu diretório}\mkl\include
set LIB={Seu diretório}\mkl\lib;%LIB%

:: Leia atentamente o conteúdo na seção anterior antes de prosseguir.
:: [Opcional] Se quiser sobrescrever o toolset usado pelo Ninja e Visual Studio com CUDA, execute o seguinte bloco de script.
:: O "Prompt de Comando do Desenvolvedor para Visual Studio 2019" será executado automaticamente.
:: Certifique-se de ter CMake >= 3.12 antes de fazer isso ao usar o gerador Visual Studio.
set CMAKE_GENERATOR_TOOLSET_VERSION=14.27
set DISTUTILS_USE_SDK=1
for /f "usebackq tokens=*" %i in (`"%ProgramFiles(x86)%\Microsoft Visual Studio\Installer\vswhere.exe" -version [15^,17^) -products * -latest -property installationPath`) do call "%i\VC\Auxiliary\Build\vcvarsall.bat" x64 -vcvars_ver=%CMAKE_GENERATOR_TOOLSET_VERSION%

:: [Opcional] Se quiser sobrescrever o compilador host CUDA
set CUDAHOSTCXX=C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\VC\Tools\MSVC\14.27.29110\bin\HostX64\x64\cl.exe

python setup.py develop

```

**Builds para GPU Intel**

Neste modo o PyTorch com suporte a GPU Intel será construído.

Certifique-se de que [os pré-requisitos comuns](#prerequisites) bem como [os pré-requisitos para GPU Intel](#intel-gpu-support) estejam devidamente instalados e as variáveis de ambiente configuradas antes de iniciar a build. Para suporte à ferramenta de build, `Visual Studio 2022` é obrigatório.

Então o PyTorch pode ser construído com o comando:

```cmd
:: Comandos CMD:
:: Defina o CMAKE_PREFIX_PATH para ajudar a encontrar os pacotes correspondentes
:: %CONDA_PREFIX% só funciona após `conda activate custom_env`

if defined CMAKE_PREFIX_PATH (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library;%CMAKE_PREFIX_PATH%"
) else (
    set "CMAKE_PREFIX_PATH=%CONDA_PREFIX%\Library"
)

python setup.py develop
```

##### Ajustar Opções de Build (Opcional)

Você pode ajustar a configuração das variáveis do cmake opcionalmente (sem buildar primeiro), fazendo
o seguinte. Por exemplo, ajustar os diretórios pré-detectados para CuDNN ou BLAS pode ser feito
com tal passo.

No Linux
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
python setup.py build --cmake-only
ccmake build  # ou cmake-gui build
```

No macOS
```bash
export CMAKE_PREFIX_PATH="${CONDA_PREFIX:-'$(dirname $(which conda))/../'}:${CMAKE_PREFIX_PATH}"
MACOSX_DEPLOYMENT_TARGET=10.9 CC=clang CXX=clang++ python setup.py build --cmake-only
ccmake build  # ou cmake-gui build
```

### Imagem Docker

#### Usando imagens pré-construídas

Você também pode puxar uma imagem docker pré-construída do Docker Hub e rodar com docker v19.03+

```bash
docker run --gpus all --rm -ti --ipc=host pytorch/pytorch:latest
```

Observe que o PyTorch usa memória compartilhada para compartilhar dados entre processos, então se o torch multiprocessing for utilizado (por exemplo,
para data loaders multithread), o tamanho padrão do segmento de memória compartilhada que o container executa não é suficiente, e você
deve aumentar o tamanho da memória compartilhada usando as opções de linha de comando `--ipc=host` ou `--shm-size` ao rodar o `nvidia-docker run`.

#### Construindo a imagem você mesmo

**NOTA:** Deve ser construída com uma versão do docker > 18.06

O `Dockerfile` é fornecido para construir imagens com suporte a CUDA 11.1 e cuDNN v8.
Você pode passar a variável make `PYTHON_VERSION=x.y` para especificar qual versão do Python será usada pelo Miniconda, ou deixar
em branco para usar o padrão.

```bash
make -f docker.Makefile
# imagens são marcadas como docker.io/${seu_usuario_docker}/pytorch
```

Você também pode passar a variável de ambiente `CMAKE_VARS="..."` para especificar variáveis CMake adicionais a serem passadas ao CMake durante a build.
Veja [setup.py](./setup.py) para a lista de variáveis disponíveis.

```bash
make -f docker.Makefile
```

### Construindo a Documentação

Para construir a documentação em vários formatos, você precisará do [Sphinx](http://www.sphinx-doc.org)
e do pytorch_sphinx_theme2.

Antes de construir a documentação localmente, certifique-se de que o `torch` esteja
instalado em seu ambiente. Para pequenas correções, você pode instalar a
versão nightly conforme descrito em [Primeiros Passos](https://pytorch.org/get-started/locally/).

Para correções mais complexas, como adicionar um novo módulo e docstrings para
o novo módulo, talvez você precise instalar o torch [a partir do código-fonte](#from-source).
Veja as [Diretrizes para Docstrings](https://github.com/pytorch/pytorch/wiki/Docstring-Guidelines)
para convenções de docstring.

```bash
cd docs/
pip install -r requirements.txt
make html
make serve
```

Execute `make` para obter uma lista de todos os formatos de saída disponíveis.

Se receber um erro do katex execute `npm install katex`. Se persistir, tente
`npm install -g katex`

> [!NOTA]
> Se você instalou `nodejs` com um gerenciador de pacotes diferente (por exemplo,
> `conda`) então `npm` provavelmente instalará uma versão do `katex` que não é
> compatível com sua versão do `nodejs` e a construção da documentação falhará.
> Uma combinação de versões que se sabe funcionar é `node@6.13.1` e
> `katex@0.13.18`. Para instalar a última com `npm` você pode executar
> ```npm install -g katex@0.13.18```

> [!NOTA]
> Se você vir um erro de incompatibilidade do numpy, execute:
> ```
> pip install 'numpy<2'
> ```

Quando fizer alterações nas dependências executadas pelo CI, edite o
arquivo `.ci/docker/requirements-docs.txt`.

#### Gerando um PDF

Para compilar um PDF de toda a documentação do PyTorch, certifique-se de ter
`texlive` e LaTeX instalados. No macOS, você pode instalá-los usando:

```
brew install --cask mactex
```

Para criar o PDF:

1. Execute:

   ```
   make latexpdf
   ```

   Isso irá gerar os arquivos necessários no diretório `build/latex`.

2. Navegue até esse diretório e execute:

   ```
   make LATEXOPTS="-interaction=nonstopmode"
   ```

   Isso irá produzir um `pytorch.pdf` com o conteúdo desejado. Execute esse
   comando mais uma vez para gerar o índice e o sumário corretos.

> [!NOTA]
> Para ver o Sumário, mude para a visualização **Sumário**
> em seu visualizador de PDF.


### Versões Anteriores

Instruções de instalação e binários para versões anteriores do PyTorch podem ser encontrados
em [nosso site](https://pytorch.org/get-started/previous-versions).


## Primeiros Passos

Três indicações para você começar:
- [Tutoriais: para você começar a entender e usar o PyTorch](https://pytorch.org/tutorials/)
- [Exemplos: código PyTorch fácil de entender em todos os domínios](https://github.com/pytorch/examples)
- [Referência da API](https://pytorch.org/docs/)
- [Glossário](https://github.com/pytorch/pytorch/blob/main/GLOSSARY.md)

## Recursos

* [PyTorch.org](https://pytorch.org/)
* [Tutoriais PyTorch](https://pytorch.org/tutorials/)
* [Exemplos PyTorch](https://github.com/pytorch/examples)
* [Modelos PyTorch](https://pytorch.org/hub/)
* [Introdução ao Deep Learning com PyTorch da Udacity](https://www.udacity.com/course/deep-learning-pytorch--ud188)
* [Introdução ao Machine Learning com PyTorch da Udacity](https://www.udacity.com/course/intro-to-machine-learning-nanodegree--nd229)
* [Deep Neural Networks with PyTorch da Coursera](https://www.coursera.org/learn/deep-neural-networks-with-pytorch)
* [Twitter PyTorch](https://twitter.com/PyTorch)
* [Blog PyTorch](https://pytorch.org/blog/)
* [YouTube PyTorch](https://www.youtube.com/channel/UCWXI5YeOsh03QvJ59PMaXFw)

## Comunicação
* Fóruns: Discuta implementações, pesquisas, etc. https://discuss.pytorch.org
* GitHub Issues: Relatórios de bugs, solicitações de recursos, problemas de instalação, RFCs, ideias, etc.
* Slack: O [Slack do PyTorch](https://pytorch.slack.com/) reúne principalmente usuários e desenvolvedores moderados a experientes do PyTorch para bate-papo, discussões online, colaboração, etc. Se você é iniciante procurando ajuda, o principal canal é o [Fórum PyTorch](https://discuss.pytorch.org). Se precisar de convite para o slack, preencha este formulário: https://goo.gl/forms/PP1AGvNHpSaJP8to1
* Newsletter: Sem spam, um boletim informativo de mão única com anúncios importantes sobre PyTorch. Inscreva-se aqui: https://eepurl.com/cbG0rv
* Página no Facebook: Anúncios importantes sobre PyTorch. https://www.facebook.com/pytorch
* Para diretrizes de marca, visite nosso site em [pytorch.org](https://pytorch.org/)

## Lançamentos e Contribuição

Normalmente, o PyTorch tem três lançamentos menores por ano. Por favor, nos avise se encontrar um bug [abrindo uma issue](https://github.com/pytorch/pytorch/issues).

Agradecemos todas as contribuições. Se você planeja contribuir com correções de bugs, faça isso sem necessidade de discussão prévia.

Se você planeja contribuir com novos recursos, funções utilitárias ou extensões ao core, por favor, abra primeiro uma issue e discuta o recurso conosco.
Enviar um PR sem discussão pode resultar em rejeição, pois podemos estar levando o core em uma direção diferente da que você imagina.

Para saber mais sobre como contribuir com o Pytorch, veja nossa [página de contribuição](CONTRIBUTING.md). Para mais informações sobre os lançamentos do PyTorch, veja a [página de lançamentos](RELEASE.md).

## O Time

PyTorch é um projeto conduzido pela comunidade com vários engenheiros e pesquisadores talentosos contribuindo para ele.

O PyTorch é atualmente mantido por [Soumith Chintala](http://soumith.ch), [Gregory Chanan](https://github.com/gchanan), [Dmytro Dzhulgakov](https://github.com/dzhulgakov), [Edward Yang](https://github.com/ezyang) e [Nikita Shulga](https://github.com/malfet), com grandes contribuições de centenas de pessoas talentosas de várias formas e meios.
Uma lista não exaustiva mas crescente inclui: [Trevor Killeen](https://github.com/killeent), [Sasank Chilamkurthy](https://github.com/chsasank), [Sergey Zagoruyko](https://github.com/szagoruyko), [Adam Lerer](https://github.com/adamlerer), [Francisco Massa](https://github.com/fmassa), [Alykhan Tejani](https://github.com/alykhantejani), [Luca Antiga](https://github.com/lantiga), [Alban Desmaison](https://github.com/albanD), [Andreas Koepf](https://github.com/andreaskoepf), [James Bradbury](https://github.com/jekbradbury), [Zeming Lin](https://github.com/ebetica), [Yuandong Tian](https://github.com/yuandong-tian), [Guillaume Lample](https://github.com/glample), [Marat Dukhan](https://github.com/Maratyszcza), [Natalia Gimelshein](https://github.com/ngimel), [Christian Sarofeen](https://github.com/csarofeen), [Martin Raison](https://github.com/martinraison), [Edward Yang](https://github.com/ezyang), [Zachary Devito](https://github.com/zdevito).

Nota: Este projeto não está relacionado ao [hughperkins/pytorch](https://github.com/hughperkins/pytorch) de mesmo nome. Hugh é um valioso contribuidor da comunidade Torch e ajudou com muitas coisas no Torch e PyTorch.

## Licença

O PyTorch tem uma licença no estilo BSD, conforme encontrado no arquivo [LICENSE](LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---