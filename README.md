# Jumper Assignment Tutorial

### Inleiding

In dit project wordt er een agent getraind om over een obstakel te springen. Naast de obstakel wordt de agent ook geconfronteerd met een muntstuk. Hierbij moet de agent de muntstuk proberen te pakken.

### Observaties

Voor observaties worden er Rayperception sensor componenten gebruikt. Zo kan de agent zijn omgeving, obstakels en muntstukken observeren.

### Actie

Na observeren, moet de agent een actie uitvoeren. Er zijn twee acties  mogelijk, springen en niet springen. De agent moet aan de hand van obervatie de nodige actie uitvoeren.

### Beloning

De beloning wordt gegeven na een bepaalde actie die door de agent is uitgevoerd. De actie die de agent dichter bij het einddoel brengt, wordt beloond met bonuspunten en aan de andere kant wordt de agent bestraft als de actie dat niet doet.

In Jumper wordt de agent beloond met +1.0 waarde als hij over een obstakel springt en de okstakel zijn einddoel bereikt. Maar telkens als de agent sprint, wordt hij bestraft met -0.01. Dit is om te voorkomen dat de agent blijft springen tijdens de training.

Als de agent een muntstuk raakt, wordt hij beloond met +1.0. Maar als de agent over de muntsuk springt en de munt raakt een ander object, wordt de agent bestraft met -1.0. Op deze manier moedigen we de agent aan om over een obstakel te springen en niets te doen bij een muntstuk. 
Als de agent valt en de zijmuren aanraakt wordt hij ook bestraft met -1.0 punten.

## Installatie

Instructions |
-------------|
Clone        |
Open Unity   |
Go to Scene  |
Open JumperAssignmentScene|


Om te beginnen is het nodig om dit project te clonen. Je kan ook een zip-bestand downloaden. Verder voeg je het project in je Unity Hub.Vervolgens open je het in Unity.

In de Scene folder kan je de JumperAsignmentScene vinden.
Je kan nu zelf de getrainde agent runnen in je omgeving.

Als je zelf de agent wilt trainen moet je eerst de Brainmodel uit de agent verwijderen.  
![](https://github.com/AP-IT-GH/jumper-assignment-UdayaAp/blob/main/JumperAssignment/Images/BrainModel.PNG?raw=true)


### Resultaten  
![](https://github.com/AP-IT-GH/jumper-assignment-UdayaAp/blob/main/JumperAssignment/Images/result.PNG?raw=true)

De resultaten laten zien dat de training effectief is. De geaccumuleerde waarde wordt in de loop van de tijd verhoogd. En elke episode duurt ook langer met de tijd.
***



