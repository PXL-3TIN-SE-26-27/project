# CampusBook

CampusBook wordt de reservatietoepassing van de campus. Deze week krijg je enkel
het skelet: een API met één endpoint en een frontend die dat endpoint aanspreekt.
Volgende week komt de echte code erbij.

Je opdracht deze week: krijg beide delen online op Azure, via GitHub Actions.

## Inhoud

| Map | Wat |
| --- | --- |
| `API/src/CampusBook.Api` | ASP.NET Core Web API met één endpoint: `GET /api/hello` |
| `API/tests/CampusBook.Tests` | xUnit-tests, voorlopig één (groen) |
| `Frontend` | Vue-applicatie (Vite) die het antwoord van de API toont |

## Lokaal draaien

### API

Je hebt de .NET SDK nodig (zie de `TargetFramework` in het projectbestand).

```
cd API
dotnet build
dotnet test
dotnet run --project src/CampusBook.Api
```

De API luistert op `http://localhost:5080`. Test met
`http://localhost:5080/api/hello`.

### Frontend

Je hebt Node.js nodig (zie de vereisten van Vite voor de minimale versie).

```
cd Frontend
npm install
npm run dev
```

De frontend draait op `http://localhost:5173` en praat met de API op het adres
uit `.env.development`. Start de API dus eerst.

`npm run build` zet het resultaat in `Frontend/dist`. Dat is een map met
statische bestanden.

## Configuratie

| Variabele | Betekenis |
| --- | --- |
| `VITE_API_BASE` | Adres van de API, zonder slash op het einde |

Zie `Frontend/.env.example`. Vite leest deze waarde in **tijdens het bouwen**,
niet wanneer de site draait.

## Klaar als

- [ ] iedereen in je team beide delen lokaal kan draaien
- [ ] de pipeline de API bouwt en de test draait
- [ ] de API online staat en `/api/hello` een antwoord geeft
- [ ] de frontend online staat en het antwoord van de online API toont, niet dat van `localhost`
- [ ] een push naar `main` beide delen opnieuw uitrolt, zonder manuele stappen
- [ ] er geen wachtwoorden, sleutels of connectiestrings in de repo staan
