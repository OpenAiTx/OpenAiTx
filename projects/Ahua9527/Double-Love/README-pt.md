# Double Love

<div align="center">

[![Licença do GitHub](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![Estrelas do GitHub](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 Amor entre quadros, eficiência em dobro

[//]: # (Easter egg escondido no código)
<!Double Love：Deixe cada cena esconder a taxa de quadros que não disse em voz alta -->

[English](./README.en.md) · 简体中文 · [Experiência online](https://double-love.ahua.space)

</div>

Double Love fornece processamento automatizado e padronizado de metadados de script supervisor. Suporta uso offline. Através de processamento em lote e local, permite integração perfeita com Adobe Premiere, Silverstack, DTG Slate para garantir a consistência dos metadados. Aumenta significativamente a eficiência do fluxo de trabalho de pós-produção.

## ✨ Características

- 🎬 Suporte ao fluxo de trabalho da indústria cinematográfica
- 📝 Processamento inteligente de padronização de metadados
- ⚡ Processamento local sem latência
- 🧩 Integração perfeita com Adobe Premiere

## 🚀 Início rápido

### Fluxo de trabalho básico

1. Registro de script supervisor: use DTG Slate para gerar folhas de script interativas
2. Gerenciamento de dados: importe dados de script supervisor via Silverstack Lab
3. Exportação de arquivos: gere XML para Adobe Premiere Pro
4. Processamento padronizado: otimize de forma inteligente usando Double Love

Exemplo:
- xml de entrada: `UnitA_304_20250127.xml`
- xml de saída: `UnitA_304_20250127_Double_LOVE.xml`

### Exemplo detalhado

#### Otimização de nomenclatura de arquivos
- O programa processa automaticamente o formato do número de cena, número de plano e número de tomada
- Preenche zeros à esquerda automaticamente para números
- Ajusta maiúsculas e minúsculas automaticamente
- Remove sublinhados extras automaticamente

#### Regras de nomenclatura de clipes

O nome do clipe processado segue o seguinte formato:
```
{prefixo_do_projeto}{cena}_{plano}_{tomada}{camera}{rating}
```

- `prefix`: Prefixo personalizado (opcional)
- `scene`: Número da cena (3 dígitos, ex: 001)
- `shot`: Número do plano (2 dígitos, ex: 01)
- `take`: Número da tomada (2 dígitos, ex: 01)
- `camera`: Identificador da câmera (letra minúscula, ex: a)
- `Rating`: Avaliação (ok/kp/ng)

#### Processamento de avaliação
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### Informação DIT
- Adiciona automaticamente informação DIT: 'DIT: 哆啦Ahua 🌱'
- Se quiser remover, faça o deploy por conta própria😁😁

#### Exemplo de prefixo personalizado

1. Definindo o prefixo como "PROJECT_A_":
   - Arquivo de entrada: `A304C007_250123G3`
   - Arquivo de saída: `PROJECT_A_004_01_07a_kp`

2. Sem definir prefixo:
   - Arquivo de entrada: `A304C007_250123G3`
   - Arquivo de saída: `004_01_07a_kp`

#### Exemplo de configuração de resolução de sequência

1. Resolução FHD (padrão):
   - Largura: 1920
   - Altura: 1080   
2. Resolução DCI 2K (personalizada):
   - Largura: 2048
   - Altura: 1080   

#### Exemplo de processamento em lote

1. Envie vários arquivos ao mesmo tempo:
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. Após o processamento, você terá:
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ Stack Tecnológico

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- Suporte PWA

## 📦 Instalação e uso

1. Clone o projeto

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. Instale as dependências

```bash
npm install
```

3. Desenvolvimento local

```bash
npm run dev
```

4. Build do projeto

```bash
npm run build
```

## 🔒 Aviso de segurança

- Todo o processamento de arquivos é realizado localmente no navegador, nada é enviado para servidores
- Suporta arquivos com tamanho máximo de 50MB
- Suporta apenas arquivos em formato XML

## 🌈 Instruções para desenvolvedores

### Estrutura do projeto

```
Double-Love/
├── src/
│   ├── components/     # Componentes React
│   ├── context/       # React Context
│   ├── utils/         # Funções utilitárias
│   ├── styles/        # Arquivos de estilos
│   └── App.tsx        # Componente principal do app
├── public/            # Recursos estáticos
└── ...arquivos de configuração
```


## 📃 Licença

[MIT License](LICENSE)

## 🤝 Guia de contribuição

Contribuições via Issue e Pull Request são bem-vindas!

## 👨‍💻 Autor

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---