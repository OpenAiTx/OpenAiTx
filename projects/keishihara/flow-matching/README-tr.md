
<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# PyTorch ile Akış Eşleştirme

Bu depo, [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747) makalesinin basit bir PyTorch uygulamasını içermektedir.

## 2D Akış Eşleştirme Örneği

Aşağıdaki gif, tek bir Gauss dağılımının dama tahtası dağılımına eşlenmesini ve vektör alanının görselleştirilmesini göstermektedir.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

Ve işte, moons veri setinin başka bir örneği.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## Başlarken

Depoyu klonlayın ve python ortamını kurun.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Python 3.12+ kurulu olduğundan emin olun.
`uv`'yi yükleyin:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

Daha sonra, ortamı kurun:

```bash
uv sync
```

## Koşullu Akış Eşleştirme [Lipman+ 2023]

Bu orijinal CFM makalesinin uygulamasıdır [1]. Kodun bazı bileşenleri [2] ve [3] kaynaklarından uyarlanmıştır.

### 2D Oyuncak Veri Setleri

CFM modellerini `checkerboard` ve `moons` gibi 2D sentetik veri setleri üzerinde eğitebilirsiniz. Veri seti adını `--dataset` seçeneğiyle belirtebilirsiniz. Eğitim parametreleri betikte önceden tanımlanmıştır ve eğitim sonuçlarının görselleştirmeleri `outputs/` dizininde saklanır. Model kontrol noktaları dahil edilmemiştir çünkü varsayılan ayarlarla kolayca yeniden üretilebilirler.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

README'nin en üstünde GIF olarak gösterilen vektör alanları ve üretilen örnekler artık `outputs/cfm/` dizininde bulunabilir.

### Görüntü Veri Setleri

Popüler görüntü sınıflandırma veri setlerinde de sınıf koşullu CFM modelleri eğitebilirsiniz. Hem üretilen örnekler hem de model kontrol noktaları `outputs/cfm` dizininde saklanacaktır. Eğitim parametrelerinin ayrıntılı listesi için `uv run scripts/train_flow_matching_on_image.py --help` komutunu çalıştırın.

MNIST veri setinde sınıf koşullu CFM eğitmek için şunu çalıştırın:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

Eğitimden sonra, artık örnekler üretebilirsiniz:

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```

Artık oluşturulan örnekleri `outputs/cfm/mnist/` dizininde görebilmelisiniz.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Düzeltmeli Akış [Liu+ 2023]

Bu, Düzeltmeli Akış makalesinden (özellikle 2-Düzeltmeli Akış) Reflow modelinin bir uygulamasıdır [2].

### 2D Sentetik Veri

Reflow'u, tıpkı CFM'de olduğu gibi, 2d sentetik veri kümeleri üzerinde uyguladık. Reflow'u eğitmek için, reflow bir distilasyon modeli olduğu için önceden eğitilmiş CFM kontrol noktalarını belirtmeniz gerekir.

Örneğin, önceden eğitilmiş bir CFM kontrol noktası ile `checkerboard` veri kümesinde eğitim yapmak için:

```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

Eğitim sonuçları, vektör alanı görselleştirmeleri ve üretilen örnekler dahil olmak üzere `outputs/reflow/` klasörü altında kaydedilir.

### CFM ve Reflow arasında örnekleme sürecinin karşılaştırılması

CFM ve Reflow'u 2 boyutlu veri kümelerinde karşılaştırmak için şunu çalıştırın:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```
Ortaya çıkan GIF'ler `outputs/comparisons/` klasöründe bulunabilir. Aşağıda, `checkerboard` veri setinde iki yöntemin örnek bir karşılaştırması gösterilmektedir:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## Kaynaklar

- [1] Lipman, Yaron, ve diğerleri. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, ve diğerleri. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---