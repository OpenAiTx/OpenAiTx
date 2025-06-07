[![License: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: Um Previsor de Acessibilidade Sintética de Compostos Baseado em Deep Learning

Com o desenvolvimento contínuo da tecnologia de inteligência artificial, cada vez mais modelos de geração profunda são utilizados para a geração de moléculas. No entanto, a maioria das novas moléculas geradas por esses modelos frequentemente enfrenta grandes desafios em relação à acessibilidade sintética.

O DeepSA foi proposto para prever a acessibilidade sintética de compostos, apresentando uma taxa de enriquecimento inicial muito maior na discriminação de moléculas que são difíceis de sintetizar. Isso ajuda os usuários a selecionar moléculas menos dispendiosas para síntese, reduzindo assim o tempo para descoberta e desenvolvimento de fármacos. Você pode usar o DeepSA em um servidor web em https://bailab.siais.shanghaitech.edu.cn/deepsa<br/>

## Requisitos
As dependências podem ser instaladas usando o seguinte comando:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# para versão gpu
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### Novidades 🔔

* 12/2024, devido ao [AutoGluon ter parado de suportar a versão Python 3.8](https://github.com/autogluon/autogluon/pull/4512) a partir de outubro de 2024, atualizamos o DeepSA para usar a versão Python 3.12 e atualizamos os scripts de treinamento e inferência para se adaptarem à versão mais recente do AutoGluon. Agradecemos seu interesse no DeepSA!

* 07/2023, DeepSA_v1.0 foi lançado. Fique à vontade para enviar seu feedback nas issues!

## Dados
Os conjuntos de dados expandidos de treinamento e teste podem ser facilmente baixados em https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing
## Uso Para Pesquisadores
Se você deseja treinar seu próprio modelo, pode executá-lo a partir da linha de comando,

executando:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
Se você deseja utilizar o modelo que propusemos,

executando:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## Servidor Online

Nós implantamos um modelo pré-treinado em um servidor dedicado, disponível publicamente em https://bailab.siais.shanghaitech.edu.cn/deepsa, para facilitar o uso do DeepSA por pesquisadores biomédicos em suas atividades de pesquisa.

Os usuários podem fazer upload de seus SMILES ou arquivos csv para o servidor e, em seguida, obter rapidamente os resultados previstos.

## <span id="citelink">Citação</span>
Se você achar este repositório útil em sua pesquisa, por favor, considere citar nosso artigo:

Wang, S., Wang, L., Li, F. et al. DeepSA: a deep-learning driven predictor of compound synthesis accessibility. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## Contato
Se você tiver quaisquer dúvidas, por favor, entre em contato com Shihang Wang (Email: wangshh12022@shanghaitech.edu.cn) ou Lin Wang (Email: wanglin3@shanghaitech.edu.cn).

Pull requests são muito bem-vindos!

## Agradecimentos
Agradecemos pelo apoio da Plataforma HPC da ShanghaiTech University.<br/>
Agradecemos a todos pela atenção a este trabalho.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---