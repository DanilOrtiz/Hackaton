#language: es-ES

Característica: Login
	Pruebas para iniciar sesión por parte de un usuario

@Login
Esquema del escenario: Login
	Dado una clave ingresada por el usuario <Clave>
	Y el estado del usuario <Estado>
	Y la clave que tiene configurada el usuario <ClaveActual>
	Cuando él usuario desea ingresar
	Entonces el resultado sera <Resultado>
	Y El mensaje es <Mensaje>

	Ejemplos: 
	| Estado     | Clave | Resultado     | ClaveActual | Mensaje                   |
	| false      |       | False         |             | El usuario no está activo |
	| true       | 1234  | True          |    1234     | OK                        |
	