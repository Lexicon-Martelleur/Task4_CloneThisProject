# Svar


## Prgammets Minne

**1. Stack och Heap**: 

Stacken och Heapen är två delar/typer av minnet som programmets process använder sig av.

**Stacken** är en LIFO data struktur (=det objekt som sist läggs till är det objektet som först tas bort) som hanterar de metoder som körs av programmet. När en metod anropas av
programmet so läggs dess information i en *Stack Ram* högst upp på *Stacken**. Denna *Stack Ram* håller värdena för metodens inskickade paremtrar, de lokala typerna som
deklereras i metodens kropp, samt en exekverings pekare till nästa exekverings punkt i den underliggande *Stack Ramen**. När den översta metoden har exekverats så plockas den bort från stacken
tillsamans med värde typer samt referenser som har deklarerats i metoden, på detta sätt så rensar stacken sig själv. Programmet fortsätter sen i nästa stack ram där den bortplockna
ramen exekverings pekare pekade till.  

**Heapen** är en data struktur som håller objekt av referens typer, dessa referens typer kan endast nås med en referens eller en pekare. När inga referenser finns kvar så kommer skräp
hanteraren att ta bort objektet från *Heapen*. En pekare måste tas bort av programmeraren. 

**2. Refens typer Samt värde typer**

**Referens Typer**. Sparas i C# i heapens och nås med en referens eller en perkare. Referens typer är lika om två referenser perkar mot samma object.
En avstickare är strängar som behandlas som värde typer i C#,
dvs dem är lika om värdet är lika.

** Värde typer** Sparas i C# i stacken om inte värde typen är en del av en referens typ då spara den tillsamans med referens typen i heapen.  Värde typer är lika om värdet av
object är lika med värdet av ett annat objeckt.

3. **Retur Värde**

Metoden *ReturnValue* returnerar 3 därför y och x är värde typer. Värde typen y kommer först ha default värdet 0, sen samma värde som x och tillslut samma värde som y.
Värde typen x kommer först ha standar värdet noll, och sen 3 vilket metoden sen returnerar

Metoden *ReturnValue2* returnerar 4 därför y och x är referens typer. Referens typen y kommer först ha det värde som konstruktorn ger den, sen kommer dess referens skrivas över till samma
referens som x. Detta innebär att när y updaterar medlemen *MyValue* till fyra så kommer x.MyValue returnera 4 eftersom både y och x refererar till samma object. 

