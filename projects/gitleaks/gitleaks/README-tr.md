
#### Dir

`dir` (takma adları arasında `files`, `directory` bulunur) komutu, dizinleri ve dosyaları taramanıza olanak tanır. Örnek: `gitleaks dir -v path_to_directory_or_file`.
Eğer pozisyonel argüman olarak bir hedef belirtilmezse, gitleaks geçerli çalışma dizinini tarar.

#### Stdin

Verileri `stdin` komutu ile gitleaks'e aktarabilirsiniz. Örnek: `cat some_file | gitleaks -v stdin`

### Temel (Baseline) Oluşturma

Büyük depoları veya uzun geçmişi olan depoları tararken, bir temel (baseline) kullanmak uygun olabilir. Temel kullanıldığında,
gitleaks, temelde bulunan eski bulguları yoksayar. Bir temel, herhangi bir gitleaks raporu olabilir. Bir gitleaks raporu oluşturmak için, gitleaks'i `--report-path` parametresiyle çalıştırın.

```
gitleaks git --report-path gitleaks-report.json # Bu raporu gitleaks-report.json adlı bir dosyada kaydeder
```

Bir temel oluşturulduktan sonra, detect komutu tekrar çalıştırıldığında uygulanabilir:

```
gitleaks git --baseline-path gitleaks-report.json --report-path findings.json
```

Detect komutunu --baseline-path parametresi ile çalıştırdıktan sonra, rapor çıktısı (findings.json) yalnızca yeni sorunları içerecektir.

## Pre-Commit Hook

Gitleaks'i bir pre-commit hook'u olarak çalıştırmak için örnek `pre-commit.py` betiğini
`.git/hooks/` dizininize kopyalayabilirsiniz.

## Konfigürasyon Yükleme

Öncelik sırası şöyledir:

1. `--config/-c` seçeneği:
      ```bash
      gitleaks git --config /home/dev/customgitleaks.toml .
      ```
2. Dosya yolu ile ortam değişkeni `GITLEAKS_CONFIG`:
      ```bash
      export GITLEAKS_CONFIG="/home/dev/customgitleaks.toml"
      gitleaks git .
      ```
3. Dosya içeriği ile ortam değişkeni `GITLEAKS_CONFIG_TOML`:
      ```bash
      export GITLEAKS_CONFIG_TOML=`cat customgitleaks.toml`
      gitleaks git .
      ```
4. Hedef yolun içinde `.gitleaks.toml` dosyası:
      ```bash
      gitleaks git .
      ```

Bu dört seçeneğin hiçbiri kullanılmazsa, gitleaks varsayılan konfigürasyonu kullanır.

## Konfigürasyon

Gitleaks, kendi gizli bilgi tespit kurallarınızı yazmanız için takip edebileceğiniz bir konfigürasyon formatı sunar:

```toml
# Gitleaks konfigürasyon dosyası için başlık.
title = "Özel Gitleaks konfigürasyonu"

# Temelde iki seçeneğiniz var:
#
# 1. Kendi konfigürasyonunuzu tanımlayın, varsayılan kurallar uygulanmaz
#
#    Başlangıç noktası olarak varsayılan konfigürasyonu kullanabilirsiniz:
#    https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
#
# 2. Bir konfigürasyonu genişletin, kurallar üzerine yazılır veya genişletilir
#
#    Bir konfigürasyonu genişlettiğinizde, genişletilmiş kurallar varsayılan kuralların önüne geçer.
#    Yani, hem genişletilmiş konfigürasyonda hem de varsayılan konfigürasyonda aynı kurallar varsa,
#    genişletilmiş kurallar veya onların öznitelikleri varsayılan kuralları geçersiz kılar.
#    Konfigürasyonları genişletirken bilmeniz gereken bir diğer şey ise,
#    birden fazla konfigürasyon dosyasını 2 derinliğe kadar zincirleyebilirsiniz.
#    Allowlist dizileri eklenir ve kopya içerebilir.

# useDefault ve path AYNI ANDA kullanılamaz. Birini seçin.
[extend]
# useDefault, ikili dosyada yerleşik olan varsayılan gitleaks konfigürasyonunu genişletir.
# En son sürüm şurada bulunur:
# https://github.com/gitleaks/gitleaks/blob/master/config/gitleaks.toml
useDefault = true
# veya genişletmek için bir konfigürasyon yolu belirtebilirsiniz.
# Yol, gitleaks'in çalıştırıldığı yere göre görecelidir,
# temel konfigürasyonun bulunduğu yere göre değil.
# path = "common_config.toml"
# Miras almak istemediğiniz kuralları burada belirtebilirsiniz.
disabledRules = [ "generic-api-key"]

# Gizli bilgi tespiti talimatlarını tanımlayan bilgileri içeren tablo dizisi
[[rules]]
# Bu kural için benzersiz tanımlayıcı
id = "awesome-rule-1"

# Kuralın kısa ve insan tarafından okunabilir açıklaması.
description = "awesome rule 1"

# Gizlileri tespit etmek için kullanılan Golang regular expression (regex). Golang'in regex motorunun
# lookahead desteği yoktur.
regex = '''one-go-style-regex-for-this-rule'''

# Regex eşleşmesinden gizli bilgiyi çıkarmak için kullanılan tamsayı ve `entropy` ayarlanmışsa
# entropisi kontrol edilecek grup.
secretGroup = 3

# Bir regex grubunun gizli kabul edilmesi için sahip olması gereken minimum shannon entropisini gösteren ondalık sayı.
entropy = 3.5

# Yol eşleştirmek için kullanılan Golang regular expression. Bu, bağımsız bir kural olarak kullanılabilir veya
# geçerli bir `regex` girdisi ile birlikte kullanılabilir.
path = '''a-file-path-regex'''

# Anahtar kelimeler ön-regex kontrolü için filtreleme amacıyla kullanılır. Anahtar kelime içeren kurallar
# hızlı bir dize karşılaştırma kontrolü yapar ve anahtar kelimenin taranan içerikte olduğundan emin olur.
# İdeal olarak bu değerler, ya tanımlayıcının bir parçası ya da kurala özgü regex'e özgü benzersiz dizeler olmalıdır
# (v8.6.0 ile eklendi)
keywords = [
  "auth",
  "password",
  "token",
]

# Meta veri ve raporlama amaçları için kullanılan string dizisi.
tags = ["tag","another tag"]

    # ⚠️ v8.21.0'da `[rules.allowlist]`, `[[rules.allowlists]]` ile değiştirildi.
    # Bu değişiklik geriye dönük uyumludur: `[rules.allowlist]` örnekleri hala çalışır.
    #
    # Yanlış pozitifleri azaltmak için bir kural için birden fazla allowlist tanımlayabilirsiniz.
    # _HERHANGİ BİR_ `[[rules.allowlists]]` eşleşirse, bulgu yok sayılır.
    [[rules.allowlists]]
    description = "commit A'yı yoksay"
    # Birden fazla kriter tanımlandığında, varsayılan koşul "OR"dur.
    # Örneğin, bu |commits| VEYA |paths| VEYA |stopwords| üzerinde eşleşebilir.
    condition = "OR"
    commits = [ "commit-A", "commit-B"]
    paths = [
      '''go\.mod''',
      '''go\.sum'''
    ]
    # not: stopwords, regex eşleşmesinin tamamı değil, çıkarılan gizli bilgiyi hedefler.
    # 'regexes' gibi. (stopwords 8.8.0'da eklendi)
    stopwords = [
      '''client''',
      '''endpoint''',
    ]

    [[rules.allowlists]]
    # "AND" koşulu, tüm kriterlerin eşleşmesini sağlamak için kullanılabilir.
    # Örneğin, bu, |regexes| VE |paths| sağlanırsa eşleşir.
    condition = "AND"
    # not: |regexes| varsayılan olarak bulgudaki _Secret_'ı kontrol eder.
    # Kabul edilebilir |regexTarget| değerleri "secret" (varsayılan), "match" ve "line"dır.
    regexTarget = "match"
    regexes = [ '''(?i)parseur[il]''' ]
    paths = [ '''package-lock\.json''' ]

# Varsayılan konfigürasyondan belirli bir kuralı genişletebilirsiniz. Örneğin, gitlab-pat
# kendi GitLab örneğinizde özel bir token ön eki tanımladıysanız
[[rules]]
id = "gitlab-pat"
# Varsayılan kuraldan tüm diğer öznitelikler miras alınır

    [[rules.allowlists]]
    regexTarget = "line"
    regexes = [ '''MY-glpat-''' ]


# ⚠️ v8.25.0'da `[allowlist]`, `[[allowlists]]` ile değiştirildi.
#
# Global allowlist'ler, kural bazlı allowlist'lerden daha yüksek önceliğe sahiptir.
# Aşağıdaki `commits` alanında listelenen bir commit ile karşılaşılırsa, o commit atlanır ve
# o committe gizli bilgi tespit edilmez. Aynı mantık regex ve path'ler için de geçerlidir.
[[allowlists]]
description = "global allow list"
commits = [ "commit-A", "commit-B", "commit-C"]
paths = [
  '''gitleaks\.toml''',
  '''(.*?)(jpg|gif|doc)'''
]
# not: (global) regexTarget varsayılan olarak bulgudaki _Secret_'ı kontrol eder.
# Kabul edilebilir regexTarget değerleri "match" ve "line"dır
regexTarget = "match"
regexes = [
  '''219-09-9999''',
  '''078-05-1120''',
  '''(9[0-9]{2}|666)-\d{2}-\d{4}''',
]
# not: stopwords, regex eşleşmesinin tamamı değil, çıkarılan gizli bilgiyi hedefler.
# 'regexes' gibi. (stopwords 8.8.0'da eklendi)
stopwords = [
  '''client''',
  '''endpoint''',
]

# ⚠️ v8.25.0 sürümünde, `[[allowlists]]` için |targetRules| adlı yeni bir alan eklendi.
#
# Ortak allowlist'ler bir kez tanımlanıp birden fazla kurala |targetRules| ile atanabilir.
# Bu allowlist'ler sadece belirtilen kurallar üzerinde çalışır, küresel olarak değil.
[[allowlists]]
targetRules = ["awesome-rule-1", "awesome-rule-2"]
description = "Test varlıklarımız bazı kurallarda yanlış pozitif tetikliyor."
paths = ['''tests/expected/._\.json$''']
```

Örnekler için varsayılan [gitleaks konfigürasyonuna](https://raw.githubusercontent.com/gitleaks/gitleaks/master/config/gitleaks.toml) bakabilir veya varsayılan konfigürasyona katkıda bulunmak isterseniz [katkı yönergelerini](https://raw.githubusercontent.com/gitleaks/gitleaks/master/CONTRIBUTING.md) takip edebilirsiniz. Ayrıca, gelişmiş konfigürasyon kurulumlarını ele alan [bu gitleaks blog yazısını](https://blog.gitleaks.io/stop-leaking-secrets-configuration-2-3-aeed293b1fbf) da inceleyebilirsiniz.

### Ek Konfigürasyon

#### gitleaks:allow

Bilerek test amaçlı bir gizli anahtar (secret) ekliyorsanız ve gitleaks bunu yakalayacaksa, o satıra `gitleaks:allow` yorumunu ekleyebilirsiniz. Böylece gitleaks bu secret'ı yok sayar. Örnek:

```
class CustomClass:
    discord_client_secret = '8dyfuiRyq=vVc3RRr_edRk-fK__JItpZ'  #gitleaks:allow

```

#### .gitleaksignore

Belirli bulguları yok saymak için repozitorinizin köküne bir `.gitleaksignore` dosyası oluşturabilirsiniz. v8.10.0 sürümünde Gitleaks, raporuna bir `Fingerprint` değeri ekledi. Her sızıntı veya bulgu, bir secret'ı benzersiz olarak tanımlayan bir Fingerprint'e sahiptir. Bu fingerprint'i `.gitleaksignore` dosyasına ekleyerek o belirli secret'ı yok sayabilirsiniz. Örnek için Gitleaks'in [.gitleaksignore](https://raw.githubusercontent.com/gitleaks/gitleaks/master/.gitleaksignore) dosyasına bakabilirsiniz. Not: Bu özellik deneyseldir ve ileride değişebilir.

#### Kod Çözme (Decoding)

Bazen gizli anahtarlar öyle bir şekilde kodlanır ki, yalnızca regex ile bulmak zorlaşır.
Artık gitleaks'e kodlanmış metni otomatik olarak bulup çözmesini söyleyebilirsiniz.
`--max-decode-depth` bayrağı bu özelliği etkinleştirir (varsayılan değer "0", yani bu özellik varsayılan olarak kapalıdır).

Özyinelemeli (recursive) kod çözme desteklenmektedir, çünkü çözülen metin de kodlanmış metin içerebilir. `--max-decode-depth` bayrağı yineleme sınırını belirler. Yineleme, çözülecek yeni kodlanmış metin kalmadığında durur, bu yüzden çok yüksek bir maksimum derinlik değeri vermek çok fazla geçiş yapılacağı anlamına gelmez. Sadece gereken kadar geçiş yapılır. Genel olarak, kod çözme tarama sürelerini çok az artırır.

Kodlanmış metin bulguları, normal bulgulardan şu şekillerde farklılık gösterir:

- Konum, kodlanmış metnin sınırlarını gösterir
  - Eğer kural kodlanmış metnin dışında eşleşirse, sınırlar bunu da kapsayacak şekilde ayarlanır
- Eşleşen değer ve secret, kodu çözülmüş değeri içerir
- İki etiket eklenir: `decoded:<encoding>` ve `decode-depth:<depth>`

Şu anda desteklenen kodlamalar:

- **percent** - Herhangi bir yazdırılabilir ASCII yüzde kodlu değer
- **hex** - 32 karakter veya daha fazla olan herhangi bir yazdırılabilir ASCII hex kodlu değer
- **base64** - 16 karakter veya daha fazla olan herhangi bir yazdırılabilir ASCII base64 kodlu değer

#### Arşiv Taraması

Bazen gizli anahtarlar zip dosyaları ya da tarball gibi arşiv dosyalarının içine paketlenmiş olur ve bulunması zorlaşır. Artık gitleaks'e arşivlerin içeriğini otomatik olarak çıkartıp taramasını söyleyebilirsiniz. `--max-archive-depth` bayrağı, hem `dir` hem de `git` tarama türlerinde bu özelliği etkinleştirir. Varsayılan değer "0" olduğundan, bu özellik varsayılan olarak kapalıdır.

Özyinelemeli tarama desteklenir çünkü arşivler başka arşivler de içerebilir. `--max-archive-depth` bayrağı yineleme sınırını belirler. Yineleme, çıkarılacak yeni arşiv kalmadığında durur, bu yüzden çok yüksek bir maksimum derinlik değeri vermek, sadece o kadar derine inebilme potansiyelini belirtir. Gerçekte ihtiyaç kadar derine iner.

Bir arşiv içindeki gizli anahtarın bulguları, arşiv içindeki dosyanın yolunu da içerir. İç yollar `!` ile ayrılır.

Örnek bulgu (kısaltılmıştır):

```
Finding:     DB_PASSWORD=8ae31cacf141669ddfb5da
...
File:        testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod
Line:        4
Commit:      6e6ee6596d337bb656496425fb98644eb62b4a82
...
Fingerprint: 6e6ee6596d337bb656496425fb98644eb62b4a82:testdata/archives/nested.tar.gz!archives/files.tar!files/.env.prod:generic-api-key:4
Link:        https://github.com/leaktk/gitleaks/blob/6e6ee6596d337bb656496425fb98644eb62b4a82/testdata/archives/nested.tar.gz
```

Bu, `files/.env.prod.` dosyasının 4. satırında bir secret tespit edildiği anlamına gelir. Bu dosya, `archives/files.tar` içinde; o da `testdata/archives/nested.tar.gz` içinde yer almaktadır.

Şu anda desteklenen formatlar:

[mholt'un archives paketinin](https://github.com/mholt/archives) desteklediği [sıkıştırma](https://github.com/mholt/archives?tab=readme-ov-file#supported-compression-formats) ve [arşiv](https://github.com/mholt/archives?tab=readme-ov-file#supported-archive-formats) formatları desteklenmektedir.

#### Raporlama

Gitleaks, çeşitli rapor formatlarını yerleşik olarak destekler: [`json`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/json_simple.json), [`csv`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/csv_simple.csv?plain=1), [`junit`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/junit_simple.xml) ve [`sarif`](https://raw.githubusercontent.com/gitleaks/gitleaks/master/testdata/expected/report/sarif_simple.sarif).

Bu formatlardan hiçbiri ihtiyacınızı karşılamıyorsa, [Go `text/template` .tmpl dosyası](https://www.digitalocean.com/community/tutorials/how-to-use-templates-in-go#step-4-writing-a-template) ile kendi rapor formatınızı oluşturabilir ve `--report-template` bayrağını kullanabilirsiniz. Şablon, [`Masterminds/sprig` şablon kitaplığından](https://masterminds.github.io/sprig/) genişletilmiş işlevsellik de kullanabilir.

Örneğin, aşağıdaki şablon özel bir JSON çıktısı sağlar:
```gotemplate
# jsonextra.tmpl
[{{ $lastFinding := (sub (len . ) 1) }}
{{- range $i, $finding := . }}{{with $finding}}
    {
        "Description": {{ quote .Description }},
        "StartLine": {{ .StartLine }},
        "EndLine": {{ .EndLine }},
        "StartColumn": {{ .StartColumn }},
        "EndColumn": {{ .EndColumn }},
        "Line": {{ quote .Line }},
        "Match": {{ quote .Match }},
        "Secret": {{ quote .Secret }},
        "File": "{{ .File }}",
        "SymlinkFile": {{ quote .SymlinkFile }},
        "Commit": {{ quote .Commit }},
        "Entropy": {{ .Entropy }},
        "Author": {{ quote .Author }},
        "Email": {{ quote .Email }},
        "Date": {{ quote .Date }},
        "Message": {{ quote .Message }},
        "Tags": [{{ $lastTag := (sub (len .Tags ) 1) }}{{ range $j, $tag := .Tags }}{{ quote . }}{{ if ne $j $lastTag }},{{ end }}{{ end }}],
        "RuleID": {{ quote .RuleID }},
        "Fingerprint": {{ quote .Fingerprint }}
    }{{ if ne $i $lastFinding }},{{ end }}
{{- end}}{{ end }}
]
```

Kullanımı:
```sh
$ gitleaks dir ~/leaky-repo/ --report-path "report.json" --report-format template --report-template testdata/report/jsonextra.tmpl
```

## Sponsorluklar

<p align="left">
	<h3><a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">coderabbit.ai</h3>
	  <a href="https://coderabbit.ai/?utm_source=oss&utm_medium=sponsorship&utm_campaign=gitleaks">
		  <img alt="CodeRabbit.ai Sponsorluk" src="https://github.com/gitleaks/gitleaks/assets/15034943/76c30a85-887b-47ca-9956-17a8e55c6c41" width=200>
	  </a>
</p>


## Çıkış Kodları

Sızıntı tespit edildiğinde çıkış kodunu her zaman --exit-code bayrağı ile ayarlayabilirsiniz. Varsayılan çıkış kodları aşağıdadır:

```
0 - sızıntı yok
1 - sızıntı veya hata ile karşılaşıldı
126 - bilinmeyen bayrak
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---