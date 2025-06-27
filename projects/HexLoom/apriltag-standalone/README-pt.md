# Biblioteca Independente de Detecção AprilTag

Este é um pacote de ferramentas de reconhecimento de AprilTag baseado na biblioteca pupil-apriltags, utilizado para detecção e rastreamento de AprilTags em câmeras.

<!-- Mantenha estes links. As traduções serão atualizadas automaticamente com o README. -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## Dependências

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## Instalação

1. Certifique-se de ter o ambiente Python instalado
2. Instale as dependências necessárias:

```bash
pip install opencv-python numpy pupil-apriltags
```

## Como Usar

### Uso Básico

```python
import cv2
from apriltag import Detector, DetectorOptions

# Criar o detector
options = DetectorOptions(
    families="tag36h11",  # Família de tags
    border=1,             # Tamanho da borda da tag
    nthreads=4,           # Número de threads
    quad_decimate=1.0,    # Fator de subamostragem da imagem
    quad_blur=0.0,        # Fator de desfoque Gaussiano
    refine_edges=True     # Refinar as bordas
)
detector = Detector(options)

# Ler a imagem
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# Detectar AprilTag
detections = detector.detect(gray)

# Exibir resultados da detecção
for detection in detections:
    print(f"Família da tag: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"Posição: {detection.center}")
    print(f"Cantos: {detection.corners}")
```

### Desenhar Resultados da Detecção

```python
import numpy as np
from apriltag import draw_detection_results

# Matriz intrínseca da câmera e coeficientes de distorção
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# Desenhar resultados da detecção
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# Exibir resultado
cv2.imshow("Detecção AprilTag", result_img)
cv2.waitKey(0)
```

### Executar Script de Teste

Um script de teste simples é fornecido para validar a funcionalidade de detecção de AprilTag:

```bash
python test_apriltag.py
```

Isso abrirá a webcam padrão do computador e detectará AprilTags em tempo real. Pressione a tecla "q" para sair.

## Famílias de Tags Suportadas

A biblioteca pupil-apriltags suporta as seguintes famílias de tags:
- tag36h11 (padrão)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## Observações

- Para melhor desempenho, ajuste os parâmetros em DetectorOptions
- Em dispositivos com recursos computacionais limitados, considere aumentar o parâmetro quad_decimate para reduzir a complexidade computacional
- Certifique-se de que o tamanho do marcador AprilTag utilizado corresponde ao parâmetro tag_size no código
- Para desenhar o eixo 3D é necessário ter parâmetros de câmera precisos

## Características

- Suporte à detecção de AprilTag em tempo real via webcam USB
- Calcula e exibe a pose 3D (posição e orientação) da tag
- Suporte para salvar imagens originais e marcadas
- Permite configuração personalizada e parâmetros de câmera
- Inclui ferramenta completa de calibração de câmera
- Não depende do ROS, é uma versão independente em Python puro do pacote original do ROS

## Passos de Instalação

### 1. Instalar a Biblioteca C do AprilTag

A biblioteca C do AprilTag é obrigatória. Siga os passos abaixo para instalá-la:

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Usuários Windows devem compilar ou baixar o binário já compilado e garantir que `apriltag.dll` esteja no PATH do sistema ou no diretório atual.

### 2. Instalar Dependências Python

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## Instruções de Uso

### Início Rápido (Recomendado)

A forma mais simples de usar é rodar a ferramenta integrada, que fornece um menu interativo para guiá-lo em todas as etapas:

```bash
python apriltag_tool.py
```

Esta ferramenta fornece as opções de menu:
1. Gerar tabuleiro de calibração xadrez
2. Calibração de câmera
3. Detecção de AprilTag
4. Visualizar documentação de ajuda

Basta seguir as instruções no menu para concluir todo o fluxo.

### Calibração da Câmera

Antes de utilizar a detecção AprilTag, recomenda-se calibrar a câmera para obter parâmetros precisos:

```bash
# Primeiro, gerar o tabuleiro de calibração xadrez
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# Imprima o tabuleiro e meça o tamanho real dos quadrados, depois realize a calibração
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

Descrição dos parâmetros:

**Ferramenta de geração de tabuleiro xadrez (create_chessboard.py):**
- `--size`: número de cantos internos do tabuleiro, largura x altura (padrão: 9x6)
- `--square`: tamanho do quadrado em pixels (padrão: 100)
- `--output`: caminho do arquivo de saída (padrão: chessboard.png)
- `--dpi`: DPI da imagem de saída (padrão: 300), afeta o tamanho de impressão

**Programa de calibração de câmera (camera_calibration.py):**
- `--size`: número de cantos internos do tabuleiro, largura x altura (padrão: 9x6)
- `--square`: tamanho do quadrado do tabuleiro, em metros (padrão: 0.025)
- `--output`: caminho do arquivo de saída (padrão: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: ID do dispositivo de câmera (padrão: 0)
- `--width`: largura da captura da câmera (padrão: 1280)
- `--height`: altura da captura da câmera (padrão: 720)
- `--samples`: número de amostras necessárias para calibração (padrão: 20)
- `--preview`: visualizar o efeito da correção após a calibração

Processo de calibração:
1. Gere e imprima o tabuleiro de calibração xadrez
2. Meça o tamanho real dos quadrados (em metros)
3. Execute o programa de calibração, posicione o tabuleiro em frente à câmera e colete amostras de diferentes ângulos
4. O programa detectará automaticamente o tabuleiro e coletará as amostras, também é possível pressionar 's' para salvar manualmente o frame atual
5. Após coletar amostras suficientes, o programa calculará automaticamente os parâmetros da câmera e os salvará no arquivo especificado

### Detecção AprilTag

Após a calibração, execute o programa de detecção AprilTag:
```bash
python apriltag_detector.py
```

### Uso avançado

```bash
python apriltag_detector.py [CAMINHO_DO_ARQUIVO_DE_CONFIG] --camera ID_DA_CÂMERA --width LARGURA --height ALTURA --camera_info ARQUIVO_DE_PARÂMETROS_DA_CÂMERA
```

Descrição dos parâmetros:
- `CAMINHO_DO_ARQUIVO_DE_CONFIG`: Caminho do arquivo de configuração do AprilTag (padrão: `config/vision/tags_36h11_all.json`)
- `--camera`: ID do dispositivo da câmera (padrão: 0)
- `--camera_info`: Caminho do arquivo de parâmetros internos da câmera (padrão: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: Largura de captura da câmera (padrão: 1280)
- `--height`: Altura de captura da câmera (padrão: 720)

### Controle por teclas

- `q`: Sair do programa

## Explicação do arquivo de configuração

Todas as configurações do sistema podem ser ajustadas no arquivo `config/vision/table_setup.json`:

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // Família dos tags
        "size": 0.05,              // Tamanho físico do tag (unidade: metros)
        "threads": 2,              // Número de threads de processamento
        "max_hamming": 0,          // Distância máxima de Hamming
        "z_up": true,              // Eixo Z para cima
        "decimate": 1.0,           // Fator de subamostragem da imagem
        "blur": 0.8,               // Fator de desfoque
        "refine_edges": 1,         // Refinar as bordas
        "debug": 0                 // Ativar modo debug
    },

    "Camera": {
        "device_id": 0,            // ID do dispositivo da câmera
        "width": 1280,             // Resolução de largura da câmera
        "height": 720,             // Resolução de altura da câmera
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // Arquivo de parâmetros de calibração da câmera
    },

    "Archive": {
        "enable": true,            // Ativar arquivamento de dados
        "preview": true,           // Exibir janela de pré-visualização
        "save_raw": false,         // Salvar imagem original
        "save_pred": false,        // Salvar imagem com predição
        "path": "./data/table_tracking"  // Caminho para salvar os dados
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Lista de IDs dos tags de referência
        "moving_tags": [4, 5, 6],            // Lista de IDs dos tags móveis
        "require_initialization": true,       // Exigir inicialização
        "tag_positions": {                    // Posições pré-definidas dos tags (se houver)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Alterando o arquivo de configuração, você pode:
1. Configurar os parâmetros do detector AprilTag
2. Definir parâmetros da câmera (ID do dispositivo, resolução, arquivo de parâmetros)
3. Configurar as opções de arquivamento de dados
4. Personalizar os IDs dos tags de referência e dos tags móveis
5. Controlar se é necessário inicializar (defina `require_initialization` como `false` para pular a inicialização)
6. Definir as posições pré-definidas dos tags

### Como usar

Muito simples, basta um comando para iniciar o sistema:

```
python table_tracking.py
```

Se quiser usar um arquivo de configuração personalizado:

```
python table_tracking.py --config CAMINHO_DO_ARQUIVO_DE_CONFIG_PERSONALIZADO
```

Após iniciar o sistema, pressione a tecla 'i' a qualquer momento para acionar manualmente o processo de inicialização.

## Perguntas frequentes

1. **Biblioteca apriltag não encontrada**
   
   Certifique-se de que a biblioteca apriltag foi instalada corretamente e que o arquivo da biblioteca está acessível pelo sistema.

2. **Não é possível abrir a câmera**
   
   Verifique se o ID do dispositivo da câmera está correto e se a câmera não está sendo usada por outro programa.

3. **Resultados de detecção imprecisos**
   
   Certifique-se de que sua câmera foi calibrada corretamente e que o tamanho do tag no arquivo de configuração está correto.

## Estrutura dos arquivos

```
apriltag_standalone/
├── apriltag.py              # Código principal da biblioteca de detecção AprilTag
├── apriltag_detector.py     # Programa principal de detecção AprilTag
├── apriltag_tool.py         # Menu de ferramentas integradas
├── camera_calibration.py    # Programa de calibração da câmera
├── create_chessboard.py     # Ferramenta de geração de padrão xadrez
├── configs.py               # Manipulação de arquivos de configuração
├── config/                  # Diretório de configurações
│   ├── camera/              # Configurações da câmera
│   │   └── HSK_200W53_1080P.yaml  # Parâmetros da câmera
│   └── vision/              # Configurações de visão
│       └── tags_36h11_all.json # Configuração de AprilTag
├── README.md                # Documento de instruções
└── requirements.txt         # Dependências Python
```

## Explicação técnica

Este projeto é uma versão independente portada do pacote de detecção ROS AprilTag, removendo a dependência do ROS e mantendo as funcionalidades principais.
São utilizadas as seguintes tecnologias principais:

- OpenCV: Processamento de imagem, calibração de câmera e estimação de pose
- Biblioteca C AprilTag: Detecção de tags
- SciPy: Conversão de matriz de rotação e quaternion

## Licença

Este projeto está sob a licença MIT

## Novas funcionalidades

### Rastreamento multi-tag e tratamento de oclusão

O sistema agora oferece os seguintes novos recursos:

1. **Inicialização por foto**: Após o início do sistema, uma inicialização por foto é feita automaticamente, registrando as relações de posição dos tags, incluindo:
   - Posições dos tags de referência fixos (ID 0-3)
   - Relação de posição relativa entre múltiplos tags móveis (padrão ID 4,5,6)

2. **Tratamento de oclusão**: Após a inicialização, mesmo que alguns tags estejam ocluídos:
   - Se algum tag de referência estiver ocluído, o sistema pode usar outros tags de referência visíveis para estimar a posição dos tags ocluídos
   - Se algum tag móvel estiver ocluído, o sistema pode estimar a posição do tag móvel ocluído usando outros tags móveis visíveis

3. **Rastreamento multi-tag**: Suporte para rastreamento simultâneo de múltiplos tags móveis, por padrão IDs 4,5,6
   - Se a posição relativa entre os tags móveis for fixa, basta um visível para estimar a posição dos demais
   - Os IDs dos tags móveis podem ser definidos no arquivo de configuração

### Explicação do arquivo de configuração

Todas as configurações do sistema podem ser ajustadas no arquivo `config/vision/table_setup.json`:

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // Lista de IDs dos tags de referência
        "moving_tags": [4, 5, 6],            // Lista de IDs dos tags móveis
        "require_initialization": true,       // Exigir inicialização
        "tag_positions": {                    // Posições pré-definidas dos tags (se houver)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

Alterando o arquivo de configuração, você pode:
1. Personalizar os IDs dos tags de referência e tags móveis
2. Controlar se a inicialização é necessária (defina `require_initialization` como `false` para pular a inicialização)
3. Definir as posições pré-definidas dos tags

### Como usar

1. Inicie o sistema com a configuração padrão:
   ```
   python table_tracking.py
   ```

2. Inicie o sistema com um arquivo de configuração personalizado:
   ```
   python table_tracking.py --config CAMINHO_DO_ARQUIVO_DE_CONFIG_PERSONALIZADO
   ```

3. Inicialização manual: Durante a execução do sistema pressione a tecla 'i'

### Requisitos de execução

Certifique-se de que todos os tags estejam visíveis durante a inicialização. O sistema irá registrar as relações de posição entre os tags. Após a inicialização, mesmo que alguns tags estejam ocluídos, o sistema conseguirá estimar corretamente a posição de todos os tags.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---