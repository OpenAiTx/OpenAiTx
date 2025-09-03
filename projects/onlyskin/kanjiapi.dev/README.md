# kanjiapi.dev: a modern JSON API for Kanji

Over 13,000 kanji served at [https://kanjiapi.dev](https://kanjiapi.dev)

## Links
- API documentation: https://kanjiapi.dev/#!/documentation
- Help understanding why which kanji exist in which list: https://onlyskin.dev/official-kanji-list-diffs/

## Buy me a coffee

https://buymeacoffee.com/onlyskin

## Examples

### Kanji `/v1/kanji/{character}`
```
$ curl https://kanjiapi.dev/v1/kanji/猫
{
  "kanji": "猫",
  "grade": 8,
  "stroke_count": 11,
  "meanings": [
    "cat"
  ],
  "kun_readings": [
    "ねこ"
  ],
  "on_readings": [
    "ビョウ"
  ],
  "name_readings": [],
  "jlpt": 2,
  "unicode": "732b"
}
```

```javascript
> fetch('https://kanjiapi.dev/v1/kanji/猫').then(r => r.json()).then(console.log);
{
  "kanji": "猫",
  "grade": 8,
  "stroke_count": 11,
  "meanings": [
    "cat"
  ],
  "kun_readings": [
    "ねこ"
  ],
  "on_readings": [
    "ビョウ"
  ],
  "name_readings": [],
  "jlpt": 2,
  "unicode": "732b"
}
```

#### List of all supported kanji

`$ curl https://kanjiapi.dev/v1/kanji/all`

#### List of joyo kanji

`$ curl https://kanjiapi.dev/v1/kanji/joyo` (also `/jouyou`)

JOYO kanji are general use kanji outlined by the Japanese government. The
Unihan Database labels four additional kanji as Joyo kanji, bringing the total
to 2140 codepoints. This is because four of the Joyo kanji are missing in the
JIS X 0208 encoding, so a different kanji which *is* present in JIS X 0208 was
historically used. Therefore, in the Unihan Database, both the four official
kanji and the four JIS X 0208-compatible kanji are marked as Joyo kanji. This
is mirrored in the `/joyo` list provided by kanjiapi.dev.

The affected characters are:
| official Joyo | historical JIS X 0208 compatible |
| --- | --- |
|𠮟 U+20B9F |叱 U+53F1|
|塡 U+5861  |填 U+586B|
|剝 U+525D  |剥 U+5265|
|頰 U+9830  |頬 U+982C|

#### List of jinmeiyo kanji

`$ curl https://kanjiapi.dev/v1/kanji/jinmeiyo` (also `/jinmeiyou`)

Note, 82 kanji in the Jinmeiyo list have codepoints in the Unicode CJK
compatibility code block. Therefore, they will sometimes be treated as "the
same kanji" as another character. This is specified by Unicode in the Unihan
Database.

`kanjiapi.dev` provides `/kanji/{character}` endpoints for these CJK
compatibility codepoints, but adds a special field to them for ease of
accessing the unified version of the character. In addition, these
compatibility characters mostly have no words listed in their equivalent
`/words/{character}` endpoint file, and much more limited information in the
`/kanji/{character}` endpoint fields. This reflects the data which is present
in the `KANJIDIC` file.

For example, the Jinmeiyo character 海 (U+FA45) is considered by Unicode to be
the same as the Joyo character 海 (U+6d77). The Jinmeiyo version is therefore
present in the CJK compatibility block.

This is an issue because any layer of software (e.g. browser caching, url
encoding) may perform unicode normalisation, which would convert the Jinmeiyo
character to a different character. If you expect to see a Jinmeiyo character,
but you see a Joyo character, this is probably the reason.

If necessary, the css property `font-variant-east-asian: traditional;` can be
used to tell the browser to display the unified equivalent character in the
traditional way, which should mean that a Joyo character codepoint displaysa s
its Jinmeiyo equivalent.

#### List of heisig kanji

`$ curl https://kanjiapi.dev/v1/kanji/heisig`

List of characters which have a Heisig keyword assigned. Note, there are four
extra kanji in the heisig list labeled with '[alt]' after the normal keyword.
These are the four official joyo variants of the missing JIS X 0208 kanji (the
Heisig book series assigned these keywords to the JIS compatible characters,
but a person looking for them could come from either the JIS compatible version
or the official version). See the `List of joyo kanji` section above.

#### List of kanji of a certain grade

`$ curl https://kanjiapi.dev/v1/kanji/grade-1` (school grades 1-6, with grade 8 signalling remaining highschool grade)

### Reading `/v1/reading/{reading}`
```
$ curl https://kanjiapi.dev/v1/reading/クウ
{
  "reading": "クウ",
  "main_kanji": [
    "宮",
    "供",
    "空",
    "咼",
    "啌",
    "喎",
    "垙",
    "瘸",
    "盉",
    "舙"
  ],
  "name_kanji": []
}
```

```javascript
> fetch('https://kanjiapi.dev/v1/reading/クウ').then(r => r.json()).then(console.log);
{
  "reading": "クウ",
  "main_kanji": [
    "宮",
    "供",
    "空",
    "咼",
    "啌",
    "喎",
    "垙",
    "瘸",
    "盉",
    "舙"
  ],
  "name_kanji": []
}
```

### Words `/v1/words/{character}`
```
$ curl https://kanjiapi.dev/v1/words/猫
[
  {
    "variants": [
      {
        "written": "どら猫",
        "pronounced": "どらねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "stray cat"
        ]
      }
    ]
  },
  {
    "variants": [
      {
        "written": "アンゴラ猫",
        "pronounced": "アンゴラねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "Angora cat"
        ]
      }
    ]
  },
  ...
]
```

```javascript
> fetch('https://kanjiapi.dev/v1/reading/クウ').then(r => r.json()).then(console.log);
[
  {
    "variants": [
      {
        "written": "どら猫",
        "pronounced": "どらねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "stray cat"
        ]
      }
    ]
  },
  {
    "variants": [
      {
        "written": "アンゴラ猫",
        "pronounced": "アンゴラねこ",
        "priorities": []
      }
    ],
    "meanings": [
      {
        "glosses": [
          "Angora cat"
        ]
      }
    ]
  },
  ...
]
```

## Development:

### Requirements:

Assumes `python 3`, `make` and `node` are available.

### Setup:

Install python libraries using requirements.txt

Install node dependencies using `yarn` or `npm install`.

Save and extract the kanji dictionary file `kanjidic2.xml` from [EDRDG](http://www.edrdg.org/wiki/index.php/KANJIDIC_Project) to the root of the project.

Save and extract the jmdict dictionary file `JMdict` from [EDRDG](http://www.edrdg.org/wiki/index.php/JMdict-EDICT_Dictionary_Project) to the root of the project.

Save and extract the file Unihan_OtherMappings.txt from Unihan.zip from [Unicode](https://www.unicode.org/versions/components-15.0.0.html) to the root of the project.

Save and extract the file Unihan_IRGSources.txt from Unihan.zip from [Unicode](https://www.unicode.org/versions/components-15.0.0.html) to the root of the project.

Ensure system has `System/Library/Fonts/ヒラギノ丸ゴ\ ProN\ W4.ttc` font
available (for favicon generation).

### Building:

Run `make` to build the site and API endpoints as static assets.

Run `python -m pytest tests` to run the tests.

Note: in order to fetch data from the local build of the API from the local
build of the site, you can set the root of your fileserver to out/site (e.g.
with `serveit`: `serveit -s out/site make`). There is a symlink to `out/v1`
inside `out/site` to enable this.

Note: endpoint files for characters in the Unicode CJK Compatibility block are
written out to a separate directory as some filesystems normalise them with the
non-compatibility equivalents. This means that a few of the
`/kanji/{character}` and `/words/{character}` endpoints don't show up under the
normal path in the API during local development.

### Deployment (Requires google cloud account credentials):

#### Versioning

The API version for deployment is hardcoded in `api_data.py` and the `makefile`.


#### Uploading to bucket

After building, to sync the built assets to the website bucket run:

NB: it's a good idea to run all of these commands with `rsync -n` for a dry-run first

To sync the built site dir (`out/site`) up with the root of the bucket, but non-recursively:
`gsutil -m rsync -c -d -x ".*\.map$" out/site gs://kanjiapi.dev`

To sync the built api dir folders (`out/{version}`) up with the dir `/{version}` in the bucket recursively based on file hashes:
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/kanji gs://kanjiapi.dev/v1/kanji/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c out/v1/kanji_cjk gs://kanjiapi.dev/v1/kanji/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/words gs://kanjiapi.dev/v1/words/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c out/v1/words_cjk gs://kanjiapi.dev/v1/words/`
`gsutil -m -h "Content-Type:application/json" rsync -r -c -d out/v1/reading gs://kanjiapi.dev/v1/reading/`

#### Setting CORS policy:

The CORS policy is stored in `cors.json`, it can be updated by editing this file and running `gsutil cors set cors.json gs://kanjiapi.dev`

### Logging:

Logfiles are generated by the cloud storage bucket for the API, there is a
cloud function which is triggered whenever a usage logfile is written. The
cloud function reads the logfiles to aggregate some useful information which is
displayed on the [logs page](https://kanjiapi.dev/#!/logs)

The cloud function is found in the `popularity-contest` directory.

To deploy it, run `gcloud functions deploy popularity-contest --gen2
--region=us-west1 --runtime=python310 --source popularity-contest --entry-point
handle --trigger-bucket=kanjiapi-dev-logging --trigger-location=us` from the
root of the project. (needs credentials)

To run the cloud function locally, cd into the `popularity-contest` directory,
create and/or activate a virtual environment based on the `requirements.txt`
file in that subdirectory, then run `python main.py`. This is useful to
manually (re)process some log files without deploying or triggering the cloud
function. (needs credentials)
