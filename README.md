# Roll the Ball
 
**Índice**
1. [Creacion de entorno y personajes](#id1)
2. [Scripts de movimiento](#id2)
4. [Script de camra](#id3) 
4. [Scripts de monedas](#id4)
5. [Script de enemigo](#id5) 
## Creacion de entorno y personajes<a name="id1"></a>

Lo primero seria la creación de el entorno de juego, de las monedas, el jugador y del enemigo principal

<img width="510" alt="image" src="https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/bf2e2d6f-3b79-4e5d-82d3-67148bddd537">

Creamos un plano para el suelo y una esfera par el jugador principal

<img width="424" alt="image" src="https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/499edf39-6bc4-48e5-aa37-42068041472d">

Ahora creamos los cubos para crear las monedas y otra esfera para hacer al enemigo


<img width="642" alt="image" src="https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/b8c7898a-d6f0-4f40-969c-cbb42754fd68">

Con lo que tenemos creamos los materiales para cada elemento y le damos forma al mapa

<img width="299" alt="image" src="https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/a9902c65-21c1-4a54-b178-5b2e58a1672b">

Lo siguiente seria cambiar el nombre y ponerle los tags indicados a todos los GameObject de la escena para luego poder referenciarlos en los scripts



## Scripts de movimiento<a name="id2"></a>


<img width="65" alt="image" src="https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/5ce981f2-7f7e-4cf3-9acd-81b2c9aa94ca">

Ahora vamos a crear los scripts de movimiento del jugador

<img width="603" alt="image" src="https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/2b59b6e1-3c83-4119-8c01-5aff76b159f2">

Aqui creamos las variables las cuales se pueden tocar desde unity directamente si las referencias aqui

<img width="554" alt="image" src="https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/d9fe2f36-0f2e-4a80-8049-c1894b3fb167">





<img width="296" alt="image" src="https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/632fd319-e5be-427e-a862-00c7859834c8">


Una vez hecho el script podemos cambiar la potencia del salto desde aqui


## Scripts de camara<a name="id3"></a>


<img width="802" alt="image" src="https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/139ce9d7-2c23-46b6-83f4-9992ac1a587a">

Con este script hacemos que la camra siga al jugador 

![Animation](https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/89ae60e5-767f-4c26-af61-b0c6adaf5c04)





## Scripts de monedas<a name="id4"></a>

<img width="712" alt="image" src="https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/631c5c09-b7c7-469c-8cb8-b6dba97473d7">

Aqui realizamos un pequeño script para que si el jugador toca una moneda con el tag "Moneda" esta desaparezca

![Animation2](https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/6c339df2-e679-4961-99a1-b9657cb1ed99)




## Script de enemigo<a name="id5"></a>

<img width="852" alt="image" src="https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/b9a9811a-6e4c-4a62-a4a9-54d908298204">

Script donde el enemigo se mueve hacia el jugador


![Animation3](https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/cc062a10-7d66-43a2-833a-b08d5262d59d)


Ahora para aumentar la dificultad vamos a hacer un scrit que haga aparece un enemigo mas cada 5 segundos


<img width="625" alt="image" src="https://github.com/FranciscoFerreiraT/RollTheball2/assets/92456485/51b275f0-d3b6-41dd-b3de-97c2d9f79458">

 
