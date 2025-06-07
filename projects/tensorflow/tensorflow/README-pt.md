<div align="center">
  <img src="https://www.tensorflow.org/images/tf_logo_horizontal.png">
</div>

[![Python](https://img.shields.io/pypi/pyversions/tensorflow.svg)](https://badge.fury.io/py/tensorflow)
[![PyPI](https://badge.fury.io/py/tensorflow.svg)](https://badge.fury.io/py/tensorflow)
[![DOI](https://zenodo.org/badge/DOI/10.5281/zenodo.4724125.svg)](https://doi.org/10.5281/zenodo.4724125)
[![CII Best Practices](https://bestpractices.coreinfrastructure.org/projects/1486/badge)](https://bestpractices.coreinfrastructure.org/projects/1486)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/tensorflow/tensorflow/badge)](https://securityscorecards.dev/viewer/?uri=github.com/tensorflow/tensorflow)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/tensorflow.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:tensorflow)
[![Fuzzing Status](https://oss-fuzz-build-logs.storage.googleapis.com/badges/tensorflow-py.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:tensorflow-py)
[![OSSRank](https://shields.io/endpoint?url=https://ossrank.com/shield/44)](https://ossrank.com/p/44)
[![Contributor Covenant](https://img.shields.io/badge/Contributor%20Covenant-v1.4%20adopted-ff69b4.svg)](CODE_OF_CONDUCT.md)

**`Documentação`** |
------------------- |
[![Documentação](https://img.shields.io/badge/api-reference-blue.svg)](https://www.tensorflow.org/api_docs/) |

[TensorFlow](https://www.tensorflow.org/) é uma plataforma open source de ponta a ponta
para aprendizado de máquina. Possui um ecossistema abrangente e flexível de
[ferramentas](https://www.tensorflow.org/resources/tools),
[bibliotecas](https://www.tensorflow.org/resources/libraries-extensions) e
[recursos da comunidade](https://www.tensorflow.org/community) que permite que
pesquisadores avancem o estado da arte em ML e que desenvolvedores criem e
implementem facilmente aplicações com ML.

O TensorFlow foi originalmente desenvolvido por pesquisadores e engenheiros da equipe
de Inteligência de Máquina do Google Brain para realizar pesquisas em
aprendizado de máquina e redes neurais. No entanto, o framework é versátil o suficiente
para ser utilizado em outras áreas também.

O TensorFlow fornece APIs estáveis para [Python](https://www.tensorflow.org/api_docs/python)
e [C++](https://www.tensorflow.org/api_docs/cc), bem como uma API para
[outros idiomas](https://www.tensorflow.org/api_docs) sem garantia de compatibilidade
retroativa.

Mantenha-se atualizado com anúncios de lançamentos e atualizações de segurança inscrevendo-se
em
[announce@tensorflow.org](https://groups.google.com/a/tensorflow.org/forum/#!forum/announce).
Veja todas as [listas de discussão](https://www.tensorflow.org/community/forums).

## Instalação

Consulte o [guia de instalação do TensorFlow](https://www.tensorflow.org/install) para o
[pacote pip](https://www.tensorflow.org/install/pip), para
[habilitar suporte a GPU](https://www.tensorflow.org/install/gpu), usar um
[container Docker](https://www.tensorflow.org/install/docker), e
[compilar a partir do código-fonte](https://www.tensorflow.org/install/source).

Para instalar a versão atual, que inclui suporte para
[placas GPU compatíveis com CUDA](https://www.tensorflow.org/install/gpu) *(Ubuntu e
Windows)*:

```
$ pip install tensorflow
```

Outros dispositivos (DirectX e MacOS-metal) são suportados usando
[Plugins de Dispositivo](https://www.tensorflow.org/install/gpu_plugins#available_devices).

Um pacote menor, apenas para CPU, também está disponível:

```
$ pip install tensorflow-cpu
```

Para atualizar o TensorFlow para a versão mais recente, adicione a opção `--upgrade` aos comandos acima.

*Binários noturnos estão disponíveis para testes usando os pacotes
[tf-nightly](https://pypi.python.org/pypi/tf-nightly) e
[tf-nightly-cpu](https://pypi.python.org/pypi/tf-nightly-cpu) no PyPI.*

#### *Experimente seu primeiro programa com TensorFlow*

```shell
$ python
```

```python
>>> import tensorflow as tf
>>> tf.add(1, 2).numpy()
3
>>> hello = tf.constant('Hello, TensorFlow!')
>>> hello.numpy()
b'Hello, TensorFlow!'
```

Para mais exemplos, veja os
[tutoriais do TensorFlow](https://www.tensorflow.org/tutorials/).

## Diretrizes de contribuição

**Se você deseja contribuir com o TensorFlow, certifique-se de revisar as
[diretrizes de contribuição](CONTRIBUTING.md). Este projeto segue o
[código de conduta](CODE_OF_CONDUCT.md) do TensorFlow. Ao participar, espera-se que
você siga este código.**

**Utilizamos as [issues do GitHub](https://github.com/tensorflow/tensorflow/issues) para
rastrear solicitações e bugs. Consulte o
[Fórum TensorFlow](https://discuss.tensorflow.org/) para perguntas gerais e
discussão, e direcione perguntas específicas para o
[Stack Overflow](https://stackoverflow.com/questions/tagged/tensorflow).**

O projeto TensorFlow busca aderir às melhores práticas geralmente aceitas no
desenvolvimento de software open source.

## Diretrizes para correções (patches)

Siga estes passos para aplicar correções a uma versão específica do TensorFlow, por exemplo,
para corrigir bugs ou vulnerabilidades de segurança:

*   Clone o repositório do TensorFlow e alterne para o branch correspondente à
    versão desejada do TensorFlow, por exemplo, o branch `r2.8` para a versão 2.8.
*   Aplique (isto é, faça cherry-pick) as alterações desejadas e resolva quaisquer conflitos de código.
*   Execute os testes do TensorFlow e certifique-se de que todos passem.
*   [Compile](https://www.tensorflow.org/install/source) o pacote pip do TensorFlow a partir do código-fonte.

## Status de build contínuo

Você pode encontrar mais plataformas e configurações suportadas pela comunidade na
[tabela de builds da comunidade do TensorFlow SIG Build](https://github.com/tensorflow/build#community-supported-tensorflow-builds).

### Builds oficiais

Tipo de Build                 | Status                                                                                                                                                                           | Artefatos
----------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ---------
**Linux CPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-cc.html)           | [PyPI](https://pypi.org/project/tf-nightly/)
**Linux GPU**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-gpu-py3.html) | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Linux XLA**                 | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/ubuntu-xla.html)         | TBA
**macOS**                     | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/macos-py2-cc.html)     | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows CPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-cpu.html)       | [PyPI](https://pypi.org/project/tf-nightly/)
**Windows GPU**               | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/windows-gpu.html)       | [PyPI](https://pypi.org/project/tf-nightly-gpu/)
**Android**                   | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/android.html)               | [Download](https://bintray.com/google/tensorflow/tensorflow/_latestVersion)
**Raspberry Pi 0 e 1**        | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi01-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv6l.whl)
**Raspberry Pi 2 e 3**        | [![Status](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.svg)](https://storage.googleapis.com/tensorflow-kokoro-build-badges/rpi23-py3.html)           | [Py3](https://storage.googleapis.com/tensorflow-nightly/tensorflow-1.10.0-cp34-none-linux_armv7l.whl)
**Libtensorflow MacOS CPU**   | Status Temporariamente Indisponível                                                                                                                                              | [Binário Noturno](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/macos/latest/macos_cpu_libtensorflow_binaries.tar.gz) [GCS Oficial](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux CPU**   | Status Temporariamente Indisponível                                                                                                                                              | [Binário Noturno](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/cpu/ubuntu_cpu_libtensorflow_binaries.tar.gz) [GCS Oficial](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Linux GPU**   | Status Temporariamente Indisponível                                                                                                                                              | [Binário Noturno](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/ubuntu_16/latest/gpu/ubuntu_gpu_libtensorflow_binaries.tar.gz) [GCS Oficial](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows CPU** | Status Temporariamente Indisponível                                                                                                                                              | [Binário Noturno](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/cpu/windows_cpu_libtensorflow_binaries.tar.gz) [GCS Oficial](https://storage.googleapis.com/tensorflow/)
**Libtensorflow Windows GPU** | Status Temporariamente Indisponível                                                                                                                                              | [Binário Noturno](https://storage.googleapis.com/libtensorflow-nightly/prod/tensorflow/release/windows/latest/gpu/windows_gpu_libtensorflow_binaries.tar.gz) [GCS Oficial](https://storage.googleapis.com/tensorflow/)

## Recursos

*   [TensorFlow.org](https://www.tensorflow.org)
*   [Tutoriais do TensorFlow](https://www.tensorflow.org/tutorials/)
*   [Modelos Oficiais do TensorFlow](https://github.com/tensorflow/models/tree/master/official)
*   [Exemplos TensorFlow](https://github.com/tensorflow/examples)
*   [TensorFlow Codelabs](https://codelabs.developers.google.com/?cat=TensorFlow)
*   [Blog do TensorFlow](https://blog.tensorflow.org)
*   [Aprenda ML com TensorFlow](https://www.tensorflow.org/resources/learn-ml)
*   [TensorFlow Twitter](https://twitter.com/tensorflow)
*   [TensorFlow YouTube](https://www.youtube.com/channel/UC0rqucBdTuFTjJiefW5t-IQ)
*   [Roteiro de otimização de modelos TensorFlow](https://www.tensorflow.org/model_optimization/guide/roadmap)
*   [White Papers do TensorFlow](https://www.tensorflow.org/about/bib)
*   [Kit de Visualização TensorBoard](https://github.com/tensorflow/tensorboard)
*   [Pesquisa de Código TensorFlow](https://cs.opensource.google/tensorflow/tensorflow)

Saiba mais sobre a
[comunidade TensorFlow](https://www.tensorflow.org/community) e como
[contribuir](https://www.tensorflow.org/community/contribute).

## Cursos

* [Coursera](https://www.coursera.org/search?query=TensorFlow)
* [Udacity](https://www.udacity.com/courses/all?search=TensorFlow)
* [Edx](https://www.edx.org/search?q=TensorFlow)

## Licença

[Licença Apache 2.0](LICENSE)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---