# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (哇!! NB)

VANB é uma ferramenta de conversão de fluxo de vídeo/áudio baseada em GStreamer, que suporta conversão bidirecional entre os protocolos NDI e RTMP. Ela permite enviar uma fonte NDI para um servidor RTMP, ou converter um fluxo RTMP para saída NDI.

Este projeto é de código aberto sob a licença [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html).

## Plataformas Suportadas

Atualmente, suporta principalmente as seguintes plataformas:
- macOS (Apple Silicon)

## Requisitos do Ambiente

### Dependências do Sistema
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### Passos de Instalação
1. Instale o [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. Instale o GStreamer via Homebrew
```bash
brew install --cask --zap gstreamer-development
```

3. Clone o repositório do projeto
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Instale as dependências Python
```bash
pip install -r requirements.txt
```

5. Configure as variáveis de ambiente (consulte o arquivo .env)
```bash
# Configure o caminho do NDI SDK
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# Configure o caminho dos plugins do GStreamer
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## Instruções de Uso

### NDI para RTMP (Transmissor)
```bash
python vanb_tx.py
```
O programa irá escanear automaticamente as fontes NDI disponíveis e solicitar o endereço RTMP para transmissão.

### RTMP para NDI (Receptor)
```bash
python vanb_rx.py
```
Após inserir o endereço de fluxo RTMP, o programa irá criar automaticamente uma nova saída NDI.

## Status do Desenvolvimento

### Funcionalidades Implementadas
- ✓ Conversão de NDI para RTMP
- ✓ Conversão de RTMP para NDI
- ✓ Adaptação automática de taxa de quadros e resolução
- ✓ Sincronização de áudio e vídeo
- ✓ Detecção automática de fontes NDI
- ✓ Nomeação automática de saídas NDI
- ✓ Codificação e decodificação de hardware VideoToolbox

### Funcionalidades a Implementar
- ⨯ Suporte a arquivo de configuração (Profile/config.json)
  - Controle de parâmetros de entrada e saída via arquivo de configuração
  - Suporte a múltiplos perfis de transcodificação
  - Configuração de tamanho de buffer e parâmetros de latência
  - Suporte a configurações de equilíbrio entre qualidade e desempenho de transcodificação
- ⨯ Processamento concorrente de múltiplos fluxos

## Declaração de Licença

⚠️ **Aviso Importante: Licenciamento e Conformidade**

### Licença de Software

Este projeto é licenciado sob a [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html).

Razões para escolher a licença GPL-3.0:
1. Este projeto utiliza vários plugins GStreamer licenciados sob GPL:
   - `x264`: Codificador de vídeo H.264 (GPL)
   - `x265`: Codificador de vídeo HEVC/H.265 (GPL)
   - `faad`: Decodificador de áudio AAC (GPL)
2. De acordo com as cláusulas de copyleft da GPL, softwares que usam componentes GPL também devem ser licenciados sob GPL
3. A escolha da GPL-3.0 garante compatibilidade de licença com todos os componentes dependentes

### Requisitos da Licença

Ao usar este projeto, você deve cumprir os seguintes requisitos:
1. **Código aberto**: Se modificar o código deste projeto ou integrá-lo ao seu projeto, você deve abrir todo o seu código-fonte
2. **Manter a licença**: Seu projeto deve continuar usando a licença GPL-3.0
3. **Aviso de direitos autorais**: Você deve manter os avisos de direitos autorais e de licença originais
4. **Notificação clara**: Se modificar o código, deve indicar claramente as alterações realizadas
5. **Concessão de patente**: A GPL-3.0 inclui cláusulas explícitas de concessão de patente

### Licenciamento de Componentes GStreamer
1. Este projeto é apenas para fins de desenvolvimento e teste
2. NDI® é uma marca registrada da NewTek, Inc.
3. O uso deste projeto requer conformidade com o contrato de licença do NewTek NDI® SDK
4. Antes de usar em ambientes de produção, certifique-se de obter todas as licenças e autorizações necessárias

## Relato de Problemas

Se encontrar problemas, por favor:
1. Verifique se as variáveis de ambiente estão configuradas corretamente
2. Certifique-se de que os plugins do GStreamer estão instalados corretamente
3. Verifique as informações detalhadas de erro nos arquivos de log
4. Relate o problema via Issues, anexando logs e informações do ambiente

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---