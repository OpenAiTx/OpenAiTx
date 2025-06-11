# 3D Gaussian Splatting para Renderização em Tempo Real de Campos de Radiância - Implementação em C++ e CUDA

[![Discord](https://img.shields.io/badge/Discord-Join%20Us-7289DA?logo=discord&logoColor=white)](https://discord.gg/TbxJST2BbC)
[![Website](https://img.shields.io/badge/Website-mrnerf.com-blue)](https://mrnerf.com)
[![Papers](https://img.shields.io/badge/Papers-Awesome%203DGS-orange)](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)

Uma implementação de alto desempenho em C++ e CUDA de 3D Gaussian Splatting, construída sobre o backend de rasterização [gsplat](https://github.com/nerfstudio-project/gsplat).

## Novidades
- **[2025-06-10]**: Corrigidos alguns problemas. Estamos fechando a diferença para as métricas do gsplat. No entanto, ainda há uma pequena discrepância.
- **[2025-06-04]**: Adicionada estratégia MCMC com a opção de linha de comando `--max-cap` para controlar a contagem máxima de Gaussianas.
- **[2025-06-03]**: Mudança para o backend Gsplat e atualização da licença.
- **[2024-05-27]**: Atualizado para LibTorch 2.7.0 para melhor compatibilidade e desempenho. Alterações significativas na gestão do estado do otimizador foram abordadas.
- **[2024-05-26]**: O objetivo atual deste repositório é migrar para uma licença permissiva. Trabalho importante foi feito para substituir o rasterizador pela implementação do gsplat.

## Métricas
Atualmente a implementação não alcança resultados equivalentes ao gsplat-mcmc, mas está em progresso.  
É apenas uma questão de tempo para corrigir o bug. Ajuda é bem-vinda :) As métricas para a estratégia mcmc são as seguintes:

| Cena     | Iteração | PSNR          | SSIM         | LPIPS        | Tempo por Imagem | Num Gaussians |
| -------- | -------- | ------------- | ------------ | ------------ | ---------------- | ------------- |
| garden   | 30000    | 27.112114     | 0.854833     | 0.157624     | 0.304765         | 1000000       |
| bicycle  | 30000    | 25.047745     | 0.767729     | 0.254825     | 0.293618         | 1000000       |
| stump    | 30000    | 26.554749     | 0.784203     | 0.263013     | 0.296536         | 1000000       |
| bonsai   | 30000    | 32.534199     | 0.948675     | 0.246924     | 0.436188         | 1000000       |
| counter  | 30000    | 29.187017     | 0.915823     | 0.242159     | 0.441259         | 1000000       |
| kitchen  | 30000    | 31.680832     | 0.933897     | 0.154965     | 0.449078         | 1000000       |
| room     | 30000    | 32.211632     | 0.930754     | 0.273719     | 0.413519         | 1000000       |
| **média**| **30000**| **29.189755** | **0.876559** | **0.227604** | **0.376423**     | **1000000**   |

## Comunidade e Suporte

Junte-se à nossa comunidade crescente para discussões, suporte e atualizações:  
- 💬 **[Comunidade Discord](https://discord.gg/TbxJST2BbC)** - Obtenha ajuda, compartilhe resultados e discuta desenvolvimento  
- 🌐 **[mrnerf.com](https://mrnerf.com)** - Visite nosso site para mais recursos  
- 📚 **[Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)** - Lista abrangente de artigos e recursos  
- 🐦 **[@janusch_patas](https://twitter.com/janusch_patas)** - Siga para as últimas atualizações  

## Instruções de Compilação e Execução

### Pré-requisitos de Software
1. **Linux** (testado com Ubuntu 22.04) - Windows não é suportado atualmente  
2. **CMake** 3.24 ou superior  
3. **CUDA** 11.8 ou superior (pode funcionar com versões inferiores com configuração manual)  
4. **Python** com headers de desenvolvimento  
5. **LibTorch 2.7.0** - Instruções de configuração abaixo  
6. Outras dependências são gerenciadas automaticamente pelo CMake  

### Pré-requisitos de Hardware
1. **GPU NVIDIA** com suporte CUDA  
    - Testado com sucesso: RTX 4090, RTX A5000, RTX 3090Ti, A100  
    - Problema conhecido com RTX 3080Ti em datasets maiores (veja #21)  
2. Capacidade mínima de computação: 8.0  

> Se você executar com sucesso em outro hardware, por favor compartilhe sua experiência na seção Discussions!

### Instruções de Compilação

```bash
# Clone o repositório com submódulos
git clone --recursive https://github.com/MrNeRF/gaussian-splatting-cuda
cd gaussian-splatting-cuda

# Baixe e configure o LibTorch
wget https://raw.githubusercontent.com/MrNeRF/gaussian-splatting-cuda/master/libtorch-cxx11-abi-shared-with-deps-2.7.0%2Bcu118.zip  
unzip libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip -d external/
rm libtorch-cxx11-abi-shared-with-deps-2.7.0+cu118.zip

# Compile o projeto
cmake -B build -DCMAKE_BUILD_TYPE=Release
cmake --build build -- -j
```

## LibTorch 2.7.0

Este projeto usa **LibTorch 2.7.0** para desempenho e compatibilidade ideais:

- **Desempenho Aprimorado**: Otimização e gerenciamento de memória melhorados  
- **Estabilidade da API**: Última API estável do PyTorch C++  
- **Compatibilidade CUDA**: Melhor integração com CUDA 11.8+  
- **Correções de Bugs**: Problemas na gestão do estado do otimizador resolvidos  

### Atualizando de Versões Anteriores
1. Baixe a nova versão do LibTorch usando as instruções de compilação  
2. Limpe seu diretório de build: `rm -rf build/`  
3. Recompile o projeto  

## Dataset

Baixe o dataset do repositório original:  
[Tanks & Trains Dataset](https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/datasets/input/tandt_db.zip)

Extraia na pasta `data` na raiz do projeto.

## Opções de Linha de Comando

### Opções Principais

- **`-h, --help`**  
  Exibe o menu de ajuda

- **`-d, --data-path [PATH]`**  
  Caminho para os dados de treinamento (obrigatório)

- **`-o, --output-path [PATH]`**  
  Caminho para salvar o modelo treinado (padrão: `./output`)

- **`-i, --iter [NUM]`**  
  Número de iterações de treinamento (padrão: 30000)  
    - O artigo sugere 30k, mas 6k-7k geralmente traz bons resultados preliminares  
    - Resultados são salvos a cada 7k iterações e ao final

- **`-f, --force`**  
  Força a sobrescrição da pasta de saída existente

- **`-r, --resolution [NUM]`**  
  Define a resolução das imagens de treinamento

### Opções Específicas para MCMC

- **`--max-cap [NUM]`**  
  Número máximo de Gaussianas para a estratégia MCMC (padrão: 1000000)  
    - Controla o limite superior de splats Gaussianos durante o treinamento  
    - Útil para ambientes com restrição de memória

### Exemplos de Uso

Treinamento básico:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000
```

Treinamento MCMC com limite de Gaussianas:  
```bash
./build/gaussian_splatting_cuda -d /path/to/data -o /path/to/output -i 10000 --max-cap 500000
```

## Diretrizes para Contribuição

Aceitamos contribuições! Aqui está como começar:

1. **Primeiros Passos**:  
    - Confira issues marcadas como **good first issues** para tarefas amigáveis a iniciantes  
    - Para novas ideias, abra uma discussão ou junte-se ao nosso [Discord](https://discord.gg/TbxJST2BbC)

2. **Antes de Enviar um PR**:  
    - Aplique `clang-format` para manter o estilo de código consistente  
    - Use o pre-commit hook: `cp tools/pre-commit .git/hooks/`  
    - Discuta novas dependências em uma issue primeiro - buscamos minimizar dependências

## Agradecimentos

Esta implementação é baseada em vários projetos-chave:

- **[gsplat](https://github.com/nerfstudio-project/gsplat)**: Usamos o backend de rasterização CUDA altamente otimizado do gsplat, que oferece melhorias significativas de desempenho e melhor eficiência de memória.

- **3D Gaussian Splatting Original**: Baseado no trabalho inovador de Kerbl et al.

## Citação

Se você usar este software em sua pesquisa, por favor cite o trabalho original:

```bibtex
@article{kerbl3Dgaussians,
  author    = {Kerbl, Bernhard and Kopanas, Georgios and Leimkühler, Thomas and Drettakis, George},
  title     = {3D Gaussian Splatting for Real-Time Radiance Field Rendering},
  journal   = {ACM Transactions on Graphics},
  number    = {4},
  volume    = {42},
  month     = {July},
  year      = {2023},
  url       = {https://repo-sam.inria.fr/fungraph/3d-gaussian-splatting/}
}
```

## Licença

Consulte o arquivo LICENSE para detalhes.

---

**Conecte-se conosco:**  
- 🌐 Website: [mrnerf.com](https://mrnerf.com)  
- 📚 Artigos: [Awesome 3D Gaussian Splatting](https://mrnerf.github.io/awesome-3D-gaussian-splatting/)  
- 💬 Discord: [Junte-se à nossa comunidade](https://discord.gg/TbxJST2BbC)  
- 🐦 Twitter: Siga [@janusch_patas](https://twitter.com/janusch_patas) para atualizações de desenvolvimento

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---