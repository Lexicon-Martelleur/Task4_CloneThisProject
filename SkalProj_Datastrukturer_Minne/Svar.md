# Svar


## Progammets Minne

**1. Stack och Heap**: 

Stacken och Heapen är två delar/typer av minnet som programmets process använder sig av.

**Stacken** är en LIFO datastruktur (=det objekt som sist läggs till är det objektet som först tas bort) som hanterar de metoder som körs av programmet. När en metod anropas av
programmet så läggs dess information i en *Stack Ram* högst upp på *Stacken*. Denna *Stack Ram* håller värdena för metodens inskickade parametrar, de lokala typerna som
deklareras i metodens kropp, samt en pekare till nästa exekverings punkt i den underliggande *Stack Ramen*. När den översta *Stack Ramen* har exekverats så plockas den bort från stacken
tillsammans med dess argumet, lokala värde typer samt referenser (inte själva datan i heapen), på detta sätt så rensar *Stacken* sig själv. Programmet fortsätter sen exekvering
i den underliggande *Stack Ramen* där den bortplockade *Stack Ramen* pekade vidare till.  

**Heapen** är en datastruktur som håller objekt som endast kan nås med en referens eller en pekare. När inga referenser finns kvar till ett objekt sparat i *Heapen* så kommer en mekanism
kännt som *Skräp Hanteraren* att ta bort objektet från *Heapen*. 

**2. Referens typer Samt värde typer**

**Referens Typer**. Sparas i C# i heapens och nås med en referens eller en pekare. Referens typerna är lika om två referenser pekar mot samma objekt.
En avstickare är strängar som behandlas som värde typer i C#, dvs dem är lika om värdet av två strängar är lika.
.

**Värde typer** Sparas i C# i stacken om inte värde typen är en del av en referenstyp då spara den tillsammans med referens typen i heapen (värde typer sparats där dem deklareras).
Värde typer är lika om värdet av objekt är lika med värdet av ett annat objekt.

**3. Retur Värde**

Metoden *ReturnValue* returnerar 3 därför y och x är värde typer. Värde typen y kommer först ha default värdet 0, sen samma värde som x och tillslut samma värde som y.
Värde typen x kommer först ha standar värdet noll, och sen 3 vilket metoden sen returnerar

Metoden *ReturnValue2* returnerar 4 därför y och x är referens typer. Referens typen y kommer först ha det värde som konstruktorn ger den, sen kommer dess referens skrivas över till samma
referens som x. Detta innebär att när y uppdaterar medlemmen *MyValue* till fyra så kommer x.MyValue returnera 4 eftersom både y och x refererar till samma objekt. 

