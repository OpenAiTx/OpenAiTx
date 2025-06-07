[![Lisans: MIT](https://img.shields.io/badge/License-MIT-yellow)](https://github.com/Shihang-Wang-58/DeepSA)
[![PyPI](https://img.shields.io/badge/PyPI-cyan)](https://pypi.org/project/deepsa)

# DeepSA: Derin Öğrenme Tabanlı Bileşik Sentez Erişilebilirliği Tahmincisi

Yapay zeka teknolojisinin sürekli gelişmesiyle, molekül üretimi için giderek daha fazla derin üretim modeli kullanılmaktadır. Ancak, üretim modelleri tarafından üretilen çoğu yeni molekül, sentez erişilebilirliği açısından büyük zorluklarla karşılaşmaktadır.

DeepSA, bileşiklerin sentez erişilebilirliğini tahmin etmek için önerilmiştir ve sentezi zor olan molekülleri ayırt etmede çok daha yüksek erken zenginleştirme oranına sahiptir. Bu, kullanıcıların sentez için daha az maliyetli molekülleri seçmesine yardımcı olur, böylece ilaç keşfi ve geliştirme süresini azaltır. DeepSA'yı https://bailab.siais.shanghaitech.edu.cn/deepsa adresindeki web sunucusunda kullanabilirsiniz.<br/>

## Gereksinimler
Bağımlılıklar aşağıdaki komut ile kurulabilir:
```bash
conda create -n DeepSA python=3.12
conda activate DeepSA
# gpu versiyonu için
pip3 install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu118
pip3 install autogluon==1.2
pip3 install rdkit
```
### Haberler 🔔 

* 2024-12, [AutoGluon, Ekim 2024'ten itibaren python 3.8 sürümünü desteklemeyi bıraktığı](https://github.com/autogluon/autogluon/pull/4512) için DeepSA, Python 3.12 sürümüne güncellenmiş ve eğitim ile çıkarım betikleri, AutoGluon'un en son sürümüne uyacak şekilde güncellenmiştir. DeepSA'ya gösterdiğiniz ilgi için teşekkürler!

* 2023-7, DeepSA_v1.0 yayınlandı, geri bildirimlerinizi issue kısmından bekliyoruz!

## Veri 
Genişletilmiş eğitim ve test veri setleri kolayca şu adresten indirilebilir: https://drive.google.com/drive/folders/1iup6T3Bqyy-uvpdFyP0Of_WQqn-9l62h?usp=sharing
## Araştırmacılar İçin Kullanım
Kendi modelinizi eğitmek isterseniz, komut satırından aşağıdaki şekilde çalıştırabilirsiniz:

Çalıştırmak için:
```
    python DeepSA_training.py <dataset.csv/training.csv:test.csv> DeepSA_model ./data/test_set.list
```
Önerdiğimiz modeli kullanmak isterseniz,

Çalıştırmak için:
```
    python DeepSA_predict.py <input_data.csv> DeepSA_model
```

## Çevrimiçi Sunucu

Biyomedikal araştırmacı kullanıcıların DeepSA'yı araştırmalarında kolayca kullanabilmeleri için, önceden eğitilmiş bir model özel bir sunucuya dağıtıldı ve herkese açık olarak https://bailab.siais.shanghaitech.edu.cn/deepsa adresinde erişime sunuldu.

Kullanıcılar SMILES veya csv dosyalarını sunucuya yükleyebilir ve ardından tahmin sonuçlarını hızlı bir şekilde alabilirler.

## <span id="citelink">Atıf</span>
Bu deposu araştırmanızda yararlı bulursanız, lütfen makalemizi kaynak olarak gösteriniz: 

Wang, S., Wang, L., Li, F. ve ark. DeepSA: derin öğrenme tabanlı bileşik sentez erişilebilirliği tahmincisi. J Cheminform 15, 103 (2023). https://doi.org/10.1186/s13321-023-00771-3

## İletişim
Sorularınız varsa, lütfen Shihang Wang (E-posta: wangshh12022@shanghaitech.edu.cn) veya Lin Wang (E-posta: wanglin3@shanghaitech.edu.cn) ile iletişime geçmekten çekinmeyin.

Pull request'leriniz memnuniyetle karşılanır!

## Teşekkürler
ShanghaiTech Üniversitesi HPC Platformu'ndan aldığımız destek için minnettarız.<br/>
Bu çalışmaya gösterdiğiniz ilgi için teşekkür ederiz.

![Star History Chart](https://api.star-history.com/svg?repos=Shihang-Wang-58/DeepSA&type=Date)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---