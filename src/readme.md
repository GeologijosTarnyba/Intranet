Du paleidžiami projektai
1. LGT.Intranet
    * Intranet puslapis
1. Play
    * CLI naudojamas failų generavimui (ateityje gal bus pervadintas, kol kas neaišku į ką būtų tinkama)


## Duomenų bazės
Visos DB prieigos vyksta per Entity Framework Core (toliau EFCore) ORM.

Projektas naudoja šias db
* Web serveryje esančias SQLite duomenų bazes
    1. LGT.Intranet.Authorization.AuthorizationContext iš LGT.Intranet.Authorization.Data
	    * Naudojama  kaupti authorizacijos duomenims (prisijungimui prie intranet/in)
		* Autorizacija padaryta semiantis įkvėpimo iš šitų (tik su trimis atskirais _enum_ Admin, Intranet, GIS vietoj vieno)
		    * https://www.youtube.com/watch?v=BVJVhceN3N4
			* https://github.com/jasontaylordev/flexible-aspnetcore-authorization
    1. LGT.Intranet.IntranetContext iš LGT.Intranet.Data
	    * Naudojama kaupti intraneto duomenis (puslapius, nuorodas, straipsnius, žinutes ir pnš)
    1. LGT.Intranet.Internal.InternalContext iš LGT.Intranet.Internal
	    * Naudojamas kaupti incidentų ir kontaktų duomenis. Kol kas kontaktai naudojami tik su incidentais, bet išskirti į atskirą projektą, jei kada sugalvotume kontaktus pasidaryti.
* Geolis2 db
    1. LGT.Geolis.GeolisContext iš LGT.Geolis.Data projekto
	    * Naudojama prisijungti prie geolis2 db

### Migracijos
Migracijoms atlikti reikalingas `dotnet eftools` įrankis.

DB migracijų skriptai saugomi:
1. \Intranet\src\LGT.Intranet\Migrations\AuthorizationContextMigrations\
1. \Intranet\src\LGT.Intranet\Migrations\IntranetContextMigrations\
1. \Intranet\src\LGT.Intranet\Migrations\InternalContextMigrations\

Migracijos naudojamis duomenų bazės sukūrimui / atnaujinimui pakeitus c# kodą.

GeolisContext migracijų neturi, nes jungiamasi prie egzistuojančios db.

#### Migracijų sukūrimas
sugeneruojami naudojant `dotnet eftools` (pakeičiant _migracijos vardas_)
```cmd
cd ./src/LGT.Intranet
dotnet ef migrations add "migracijos vardas" --context LGT.Intranet.Authorization.AuthorizationContext
dotnet ef migrations add "migracijos vardas" --context LGT.Intranet.IntranetContext
dotnet ef migrations add "migracijos vardas" --context LGT.Intranet.Internal.InternalContext
cd ./../..
```
#### Migracijos skriptų sudiegimas
Migracijos sudiegiamos naudojant
```cmd
cd ./src/LGT.Intranet
dotnet ef database update --context LGT.Intranet.Authorization.AuthorizationContext
dotnet ef database update --context LGT.Intranet.IntranetContext
dotnet ef database update --context LGT.Intranet.Internal.InternalContext
cd ./../..
```
