# Ohjelmoinnin perusteet IT00AS83 S2026

## Projektityö

### 1. Tavoite

Projektityön tarkoituksena on osoittaa, että osaat käyttää ohjelmoinnin perusrakenteita C#:lla: muuttujia, ehtoja, silmukoita, syötteitä, tulosteita ja metodeja.
Työn avulla harjoittelet ohjelman suunnittelua, koodausta, testausta ja oman työn esittelyä.

### 2. Sisältövaatimukset

Ohjelmassa on oltava vähintään:

| Rakennusosa     | Vaatimus                                                            | Toteutus |
| --------------- | ------------------------------------------------------------------- | :------: |
| Muuttujat       | Käytä vähintään kahta eri tietotyyppiä (int, double, string, bool). |    ✔     |
| Ehtolause       | Käytä vähintään yksi if / if-else.                                  |    ✔     |
| Silmukka        | Käytä vähintään yksi for tai while.                                 |    ✔     |
| Käyttäjän syöte | Käytä Console.ReadLine() vähintään kerran.                          |    ✔     |
| Tulosteet       | Käytä Console.WriteLine() ja muotoile tuloste selkeäksi.            |    ✔     |
| Kommentointi    | Lisää kommentteja, jotka selittävät ohjelman osat ja tarkoituksen.  |    ✔     |
| Metodi          | Käytä vähintään yhtä omaa metodia (parametrit tai paluuarvo).       |    ✔     |
| Lisäpisteet     | Käytät listaa (List<T>) tietojen tallentamiseen tai käsittelyyn.    |    ✔     |

### 3. Projectin laajuus

Koodin pituus: noin 30–100 riviä.

Työaika: 5–8 tuntia.

Tavoite: toimiva, selkeä ja itsenäisesti suunniteltu ohjelma.

### 4. Työn vaiheet

Valittu teema: **Matkakustannuslaskuri**

Suunnittele ohjelman rakenne (syötteet, logiikka, tulosteet).

Toteuta ja testaa ohjelma. Huom! Omia testejä ei tarvitse kirjoittaa vaan testata, että ohjelma toimii ajaessa (dotnet run) kuten pitää, erilaisilla syötteillä.

Kommentoi ja varmista toimivuus.

Palauta ohjelma ja esittele se (5–10 min).

### 5. Teema

#### Matkakustannuslaskuri

- Käyttäjä syöttää matkan pituuden ja kulutusarvon (esim. l/100 km tai €/km).
- Ohjelma laskee matkan kokonaiskustannukset.
- Ehto voi tarkistaa, onko syöte järkevä (esim. negatiivinen matka hylätään).
- Silmukka mahdollistaa usean matkan laskemisen.
- Lisäpisteet: tallennetaan tulokset listaan ja näytetään lopuksi yhteenveto.
