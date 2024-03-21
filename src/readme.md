## Duomenų bazės
Visos DB prieigos vyksta per Entity Framework Core (toliau EFCore) ORM.

Projektas naudoja šias db
* Web serveryje esančias SQLite duomenų bazes
    1. LGT.Intranet.Authorization.AuthorizationContext iš LGT.Intranet.Authorization.Data
	    * Naudojama  kaupti authorizacijos duomenims (prisijungimui prie intranet/in)
		* Autorizacija padaryta bandant atkartot šituos
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
Jų migracijų skriptai saugomi atitinkamai 
1. \Intranet\src\LGT.Intranet\Migrations\AuthorizationContextMigrations\
1. \Intranet\src\LGT.Intranet\Migrations\IntranetContextMigrations\
1. \Intranet\src\LGT.Intranet\Migrations\InternalContextMigrations\

GeolisContext migracijų neturi, nes jungiamasi prie egzistuojančios db.
#### Migracijos skriptų sukūrimas
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
```
cd ./src/LGT.Intranet
dotnet ef database update --context LGT.Intranet.Authorization.AuthorizationContext
dotnet ef database update --context LGT.Intranet.IntranetContext
dotnet ef database update --context LGT.Intranet.Internal.InternalContext
cd ./../..
```