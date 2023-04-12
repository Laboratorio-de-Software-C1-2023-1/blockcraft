using Blockcraft;

Enemigo enemigo = new Enemigo(100);

Jugador jugador = new Jugador(new Pico());
jugador.atacar(enemigo);

jugador.cambiarArma(new Hacha());
jugador.atacar(enemigo);
