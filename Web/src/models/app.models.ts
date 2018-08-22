export class Ciudad {
    constructor(
        public nombre: string = "",
        public latitud: number = 0,
        public longitud: number = 0,)
    {}
}

export class Usuario {
    constructor(
       public nombre: string = "",
       public clave: string = "",
       public ciudadId: number = 0,
       public ciudad: Ciudad = new Ciudad()
    ){}
}

export class Suceso {
    constructor(
        public estadoId: TipoEstados = TipoEstados.Nueva 
    )
    {}
}

export enum TipoEstados {
    Nueva = 1,
    Eliminada = 2
}