<div align="right">
  <details>
    <summary >🌐 Dil</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=ony3000&project=prettier-plugin-classnames&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# prettier-plugin-classnames

`printWidth` seçeneğine göre uzun sınıf adlarını saran bir Prettier eklentisi.

![Bu eklenti için bir kullanım örneği.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/banner.png)

## Kurulum[^1]

```sh
npm install -D prettier prettier-plugin-classnames
```

[^1]: Eğer `prettier-plugin-classnames` sürümünüz `0.4.0`'dan küçükse, ayrıca `@prettier/sync` paketini de yüklemeniz gerekecektir.

## Yapılandırma

JSON örneği:

```json
{
  "plugins": ["prettier-plugin-classnames"]
}
```

JS örneği (CommonJS modülü):

```javascript
module.exports = {
  plugins: ['prettier-plugin-classnames'],
  customAttributes: ['myClassProp'],
  customFunctions: ['clsx'],
};
```

JS örneği (ES modülü):

```javascript
export default {
  plugins: ['prettier-plugin-classnames'],
  endingPosition: 'absolute',
};
```

### Markdown/MDX Geçersiz Kılma

Bu eklenti Markdown ve MDX'i desteklemez, ancak bu eklenti kod bloklarının içinde bir dili destekliyorsa (ör. Vue), kod bloklarının içinde istenmeyen biçimlendirme oluşabilir.

İstenmeyen biçimlendirmeyi önlemek için, Markdown ve MDX için yapılandırma geçersiz kılmalarını kullanabilirsiniz.

JSON örneği:

```json
{
  "plugins": ["prettier-plugin-classnames"],
  "customFunctions": ["clsx"],
  "overrides": [
    {
      "files": ["*.md", "*.mdx"],
      "options": {
        "plugins": []
      }
    }
  ]
}
```

## Seçenekler

### Özel Nitelikler

Sınıf adlarını kapsayan niteliklerin listesi.<br>
`class` ve `className` nitelikleri, hiçbir seçenek belirtilmese bile her zaman desteklenir.

<!-- prettier-ignore -->
Varsayılan | CLI&nbsp;Geçersiz Kılma | API&nbsp;Geçersiz Kılma
--- | --- | ---
`[]` | `--custom-attributes <string>` | `customAttributes: ["<string>"]`

### Özel Fonksiyonlar

Sınıf adlarını kapsayan fonksiyonların listesi.<br>
`classNames` fonksiyonu, hiçbir seçenek belirtilmese bile her zaman desteklenir.

<!-- prettier-ignore -->
Varsayılan | CLI&nbsp;Geçersiz Kılma | API&nbsp;Geçersiz Kılma
--- | --- | ---
`[]` | `--custom-functions <string>` | `customFunctions: ["<string>"]`

### Bitiş Pozisyonu

İlk kez v0.5.0 sürümünde mevcut.<br>
`absolute-with-indent` v0.6.0 sürümünde eklendi.<br>
`absolute-with-indent` v0.8.0 sürümünde kaldırıldı, ancak aynı çıktıyı `absolute` ile alabilirsiniz.<br>
Varsayılan değer v0.8.0’da `relative`’dan `absolute`’a değiştirildi.

Bu, orijinal sınıf adını çok satırlı bir sınıf adıyla değiştirirken, her satırda sınıf adının bitiş kriteridir.

- `absolute` örneği:

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
        className="bg-gray-100/50 dark:bg-neutral-900/50
          border border-zinc-400/30 dark:border-neutral-500/30
          rounded-xl px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

- `relative` örneği:

  ```
  ------------------------------------------------------------| printWidth=60
  export function Callout({ children }) {
    return (
      <div
       |------------------------------------------------------------|
        className="bg-gray-100/50 dark:bg-neutral-900/50 border
         |------------------------------------------------------------|
          border-zinc-400/30 dark:border-neutral-500/30 rounded-xl
          px-4 py-4"
      >
        {children}
      </div>
    );
  }
  ```

<!-- prettier-ignore -->
Varsayılan | CLI&nbsp;Geçersiz Kılma | API&nbsp;Geçersiz Kılma
--- | --- | ---
`"absolute"` | `--ending-position <absolute\|relative>` | `endingPosition: "<absolute\|relative>"`

### Sözdizimi Dönüşümü

İlk olarak v0.7.7’de kullanılabilir.

Bir sınıf adı ifadesiz sözdizimi ile yazıldığında ve satır kırılması gerçekleşirse, bu ifade sözdizimi haline dönüştürülür. Bu dönüşüm geri döndürülebilir biçimlendirmeyi desteklemez.

<!-- prettier-ignore -->
Varsayılan | CLI&nbsp;Geçersiz Kılma | API&nbsp;Geçersiz Kılma
--- | --- | ---
`false` | `--syntax-transformation` | `syntaxTransformation: <boolean>`

### Classnames Yazdırma Genişliği

İlk olarak v0.10.0’de kullanılabilir.

Sınıf adının yazdırma genişliğini belirtin. Eğer bir değer girilmezse, varsayılan olarak `printWidth` değeri kullanılır.

<!-- prettier-ignore -->
Varsayılan | CLI&nbsp;Geçersiz Kılma | API&nbsp;Geçersiz Kılma
--- | --- | ---
`undefined` | `--classnames-print-width <number>` | `classnamesPrintWidth: <number>`

## Sibling eklentilerle sürüm korelasyonu

`0.6.0` ile birlikte, bir tarafta minör bir sürüm çıktığında, mümkünse bu değişikliği diğer tarafta da yansıtmayı planlıyorum.

![Sürüm korelasyonu.](https://raw.githubusercontent.com/ony3000/prettier-plugin-classnames/master/.github/correlation.png)

## Diğer Prettier eklentileriyle uyumluluk

Formatlamak istediğiniz metni birden fazla Prettier eklentisi işleyebiliyorsa, Prettier yalnızca bu eklentilerin sonuncusunu kullanır.

Bu durumda, eklentileri sıralı olarak uygulamak için [prettier-plugin-merge](https://github.com/ony3000/prettier-plugin-merge) ekleyerek aşağıdaki gibi yapılandırabilirsiniz.

JSON örneği:

<!-- prettier-ignore -->
```json
{
  "plugins": [
    "prettier-plugin-tailwindcss",
    "prettier-plugin-classnames",
    "prettier-plugin-merge"
  ]
}
```

## Stargazers over time

[![Stargazers over time](https://starchart.cc/ony3000/prettier-plugin-classnames.svg?variant=adaptive)](https://starchart.cc/ony3000/prettier-plugin-classnames)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-03

---