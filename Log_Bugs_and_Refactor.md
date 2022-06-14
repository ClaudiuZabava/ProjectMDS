### [2 / 3 / 2022] 
Camera nu urmarea jucatorul atunci cand ajungea la marginea mapei.
#### Solved: Am modificat scriptul a.i. sa se uite doar la jucator si am marit FOV-ul cat si viteza cu care urmareste jucatorul.


### [9 / 3 / 2022]. 
Gloantele nu aveau o traiectorie dreapta ( cadeau usor in jos)
#### Solved: Am adaugat componenta "RigidBody", transformand glontul in prefab cu gravity = 0;


### [20 / 4 / 2022]. 
Jucatorul trecea prin texturi:
#### Solved: Am adaugat nav Mesh Obstacle pentru toate obstacolele + Nav Mesh Agent pe Jucator si Inamici


### [27 / 4 / 2022].
Inamicii nu te urmareau mereu, ramaneau pe loc in unele cazuri dar animatia de Walk inca rula.
#### Solved: Corectat greseli in Script Inamici cand te urmaresc (Erau niste conditii puse prost acolo. Vezi Enemy.cs de la linia 51 pana la linia 93 )


### [8 / 5 / 2022]
Bug Inamici care se indeparteaza de tine chiar si cand stai pe loc
#### Solved: In Rigidbody inamici -> bifati Freeze position x y z   + setati  min distance mai mare ca Stop distance din nav mash

### [14 / 5 / 2022] Some Code Refactoring
- Remodelat System shooting inamici ( inamicii trag in tine, dar mai rar ca sa te poti feri, si doar cand intri in range-ul lor)
- Remodelat System Viata jucator 
- Modificat valori pt range-ul inamicilor si distanta maxima la care se pot apropia de tine.
- Modificat niste parametri si setari in enemy prefab
